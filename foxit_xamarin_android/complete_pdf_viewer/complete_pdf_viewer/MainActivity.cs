using Android;
using Android.Text;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Content;
using AndroidX.AppCompat.App;
using AndroidX.Core.Content;
using AndroidX.Core.App;
using Com.Foxit.Uiextensions.Home;
using Com.Foxit.Uiextensions.Home.Local;
using Com.Foxit.Uiextensions.Utils;
using Com.Foxit.Pdfreader;
using Android.App;
using Android.Net;
using Android.Content.Res;
using Java.Lang;

namespace Com.Foxit.Home
{

    [Activity(Label = "@string/app_name",
    ConfigurationChanges = ConfigChanges.KeyboardHidden | ConfigChanges.Orientation | ConfigChanges.ScreenSize | ConfigChanges.Locale | ConfigChanges.LayoutDirection | ConfigChanges.SmallestScreenSize,
    LaunchMode = LaunchMode.SingleTop,
    Theme = "@style/AppTheme",
    WindowSoftInputMode = SoftInput.AdjustPan,
    MainLauncher = true)]
    [Layout(MinHeight ="700dp",MinWidth ="520dp", Gravity = "center")]
    [IntentFilter(new[] { Intent.ActionView },
        Categories = new[] { Intent.CategoryDefault },
        DataMimeType = "application/pdf")]
    public class MainActivity : AppCompatActivity,
        Com.Foxit.Uiextensions.Home.IHomeModuleOnFileItemEventListener,
        LocalModule.ICompareListener,
        IHomeModuleOnFilePathChangeListener
    {

        public const int REQUEST_EXTERNAL_STORAGE_MANAGER = 111;
        public const int REQUEST_EXTERNAL_STORAGE = 222;

        public const int REQUEST_OPEN_DOCUMENT_TREE = 0xF001;
        public const int REQUEST_SELECT_DEFAULT_FOLDER = 0xF002;

        private static string[] PERMISSIONS_STORAGE = {
            Manifest.Permission.ReadExternalStorage,
            Manifest.Permission.WriteExternalStorage
        };

        private string filter = App.FILTER_DEFAULT;
        private bool mLicenseValid = false;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            RequestWindowFeature(Android.Views.WindowFeatures.NoTitle);
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);

            mLicenseValid = App.Instance().CheckLicense();
            if (!mLicenseValid)
                return;

            if (this.Intent != null && this.Intent.Action != null)
            {
                filter = Intent.Action;
            }

            if (Build.VERSION.SdkInt > BuildVersionCodes.Q && !AppFileUtil.IsExternalStorageLegacy)
            {
                AppStorageManager storageManager = AppStorageManager.GetInstance(this);
                bool needPermission = storageManager.NeedManageExternalStoragePermission();
                if (!AppStorageManager.IsExternalStorageManager && needPermission)
                {
                    storageManager.RequestExternalStorageManager(this, REQUEST_EXTERNAL_STORAGE_MANAGER);
                }
                else if (!needPermission)
                {
                    CheckStorageState();
                }
            }
            else if(Build.VERSION.SdkInt > BuildVersionCodes.M)
            {
                CheckStorageState();
            }

            if (Build.VERSION.SdkInt >= Android.OS.BuildVersionCodes.N)
            {
                StrictMode.VmPolicy.Builder builder = new StrictMode.VmPolicy.Builder();
                StrictMode.SetVmPolicy(builder.Build());
            }

            AppStorageManager.OpenTreeRequestCode = REQUEST_OPEN_DOCUMENT_TREE;
            LocalModule local = App.Instance().GetLocalModule(filter);
            local.SetAttachedActivity(this);
            App.Instance().CopyGuideFiles(local);
            local.SetFileItemEventListener(this);
            local.SetCompareListener(this);
            local.SetOnFilePathChangeListener(this);

            View view = local.GetContentView(this.ApplicationContext);
            ViewGroup parent = (ViewGroup)view.Parent;
            if (parent != null)
            {
                parent.RemoveView(view);
            }
            SetContentView(view);

            HandleIntent(this.Intent);
        }

        private void CheckStorageState()
        {
            Permission permission = ContextCompat.CheckSelfPermission(this.ApplicationContext, Manifest.Permission.WriteExternalStorage);
            if (permission != Permission.Granted)
            {
                ActivityCompat.RequestPermissions(this, PERMISSIONS_STORAGE, REQUEST_EXTERNAL_STORAGE);
            }
            else
            {
                App.Instance().SelectDefaultFolderOrNot(this);
            }
        }


        protected override void OnDestroy()
        {
            if (mLicenseValid)
            {
                App.Instance().UnloadLocalModule(filter);
            }
            base.OnDestroy();
        }

        protected override void OnNewIntent(Intent intent)
        {
            base.OnNewIntent(intent);

            this.Intent = intent;
            HandleIntent(intent);
        }

        private void HandleIntent(Intent intent)
        {
            if (intent != null)
            {
                string path = AppFileUtil.GetFilePath(this, intent, HomeModule.FileExtra);
                if (path != null)
                {
                    OnFileSelected(HomeModule.FileExtra, path);
                }
            }
        }

        private void OnFileSelected(string fileExtra, string filePath)
        {
            Intent intent = new Intent();
            intent.PutExtra(fileExtra, filePath);
            intent.PutExtra("filter", filter);
            intent.SetClass(this.ApplicationContext, typeof(PDFReaderActivity));

            this.StartActivity(intent);
        }


        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Permission[] grantResults)
        {
            if (mLicenseValid && requestCode == REQUEST_EXTERNAL_STORAGE)
            {
                if (grantResults[0] == Permission.Granted)
                {
                    App.Instance().SelectDefaultFolderOrNot(this);
                    UpdateLocalModule();
                }
                else
                {
                    UIToast.GetInstance(this.ApplicationContext).Show("Permission Denied");
                }
            }
            else
            {
                base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
                Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);
            }
        }

        private void UpdateLocalModule()
        {
            App app = App.Instance();
            app.CopyGuideFiles(App.Instance().GetLocalModule(filter));
            if (AppFileUtil.NeedScopedStorageAdaptation())
                app.GetLocalModule(filter).SetCurrentPath(AppStorageManager.GetInstance(ApplicationContext).DefaultFolder);
            app.GetLocalModule(filter).UpdateStoragePermissionGranted();
        }

        public void OnFileItemClicked(string fileExtra, string filePath)
        {
            OnFileSelected(fileExtra, filePath);
        }

        public void OnCompareClicked(int state, string filePath)
        {
            if (state == LocalModule.CompareListener.StateSuccess)
            {
                OnFileItemClicked(HomeModule.FileExtra, filePath);
            }
        }

        public void OnFilePathChanged(string path)
        {
            if (AppFileUtil.NeedScopedStorageAdaptation())
            {
                if (path == null || AppStorageManager.GetInstance(ApplicationContext).IsRootVolumePath(path)) return;
                AppFileUtil.CheckCallDocumentTreeUriPermission(this, REQUEST_OPEN_DOCUMENT_TREE, AppFileUtil.ToDocumentUriFromPath(path));
            }
        }

        public override void OnConfigurationChanged(Configuration newConfig)
        {
            base.OnConfigurationChanged(newConfig);
            App.Instance().GetLocalModule(filter).OnConfigurationChanged(newConfig);
        }

        protected override void OnActivityResult(int requestCode, [GeneratedEnum] Result resultCode, Intent data)
        {
            base.OnActivityResult(requestCode, resultCode, data);
            if (requestCode == REQUEST_EXTERNAL_STORAGE_MANAGER)
            {
                AppFileUtil.UpdateIsExternalStorageManager();
                if (!AppFileUtil.IsExternalStorageManager)
                {
                    CheckStorageState();
                }
                UpdateLocalModule();
            }
            else if (resultCode == Result.Ok)
            {
                if (requestCode == AppStorageManager.OpenTreeRequestCode || requestCode == REQUEST_SELECT_DEFAULT_FOLDER)
                {
                    if (data == null || data.Data == null) return;

                    Uri uri = data.Data;
                    ActivityFlags modeFlags = data.Flags & (ActivityFlags.GrantReadUriPermission | ActivityFlags.GrantWriteUriPermission);
                    ContentResolver.TakePersistableUriPermission(uri, modeFlags);
                    LocalModule localModule = App.Instance().GetLocalModule(filter);
                    AppStorageManager storageManager = AppStorageManager.GetInstance(ApplicationContext);
                    if (TextUtils.IsEmpty(storageManager.DefaultFolder))
                    {
                        string defaultPath = AppFileUtil.ToPathFromDocumentTreeUri(uri);
                        storageManager.DefaultFolder = defaultPath;
                        App.Instance().CopyGuideFiles(localModule);
                        localModule.SetCurrentPath(defaultPath);
                    }
                    else
                    {
                        localModule.ReloadCurrentFilePath();
                    }
                }
            }
        }

    }
}