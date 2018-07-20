using Android;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using Android.Support.V4.App;
using Android.Support.V4.Content;
using Android.Support.V7.App;
using Android.Views;
using Android.Content;

using Com.Foxit.Uiextensions.Home;
using Com.Foxit.Uiextensions.Utils;
using Com.Foxit.Pdfreader;
using Android.App;
using Com.Foxit.Uiextensions.Modules.Connectpdf.Account;

namespace Com.Foxit.Home
{

    [Activity(Label = "@string/app_name",
    ConfigurationChanges = ConfigChanges.KeyboardHidden | ConfigChanges.Orientation | ConfigChanges.ScreenSize | ConfigChanges.Locale | ConfigChanges.LayoutDirection,
    LaunchMode = LaunchMode.SingleTop,
    Theme = "@style/AppTheme",
    WindowSoftInputMode = SoftInput.AdjustPan,
    MainLauncher = true)]
    [IntentFilter(new[] { Intent.ActionView },
        Categories = new[] { Intent.CategoryDefault },
        DataMimeType = "application/pdf")]
    public class MainActivity : AppCompatActivity, Com.Foxit.Uiextensions.Home.IHomeModuleOnFileItemEventListener
    {

        public static int REQUEST_EXTERNAL_STORAGE = 1;
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

            App.Instance().SetApplicationContext(this.ApplicationContext);
            mLicenseValid = App.Instance().CheckLicense();
            if (!mLicenseValid)
                return;

            if (this.Intent != null)
            {
                filter = Intent.Action;
            }

            if (Build.VERSION.SdkInt > BuildVersionCodes.M)
            {
                Permission permission = ContextCompat.CheckSelfPermission(this.ApplicationContext, Manifest.Permission.WriteExternalStorage);
                if (permission != Permission.Granted)
                {
                    ActivityCompat.RequestPermissions(this, PERMISSIONS_STORAGE, REQUEST_EXTERNAL_STORAGE);
                }
            }

            if (Build.VERSION.SdkInt >= Android.OS.BuildVersionCodes.N)
            {
                StrictMode.VmPolicy.Builder builder = new StrictMode.VmPolicy.Builder();
                StrictMode.SetVmPolicy(builder.Build());
            }

            App.Instance().CopyGuideFiles(App.Instance().GetLocalModule(filter));
            App.Instance().GetLocalModule(filter).SetFileItemEventListener(this);

            AccountModule.Instance.OnCreate(this, savedInstanceState);

            View view = App.Instance().GetLocalModule(filter).GetContentView(this.ApplicationContext);
            ViewGroup parent = (ViewGroup)view.Parent;
            if (parent != null)
            {
                parent.RemoveView(view);
            }
            SetContentView(view);

            HandleIntent(this.Intent);
        }

        protected override void OnDestroy()
        {
            if (mLicenseValid)
            {
                App.Instance().UnloadLocalModule(filter);
                AccountModule.Instance.OnDestroy(this);
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
            if (mLicenseValid && requestCode == REQUEST_EXTERNAL_STORAGE
             && grantResults[0] == Permission.Granted)
            {
                App.Instance().CopyGuideFiles(App.Instance().GetLocalModule(filter));
                App.Instance().GetLocalModule(filter).UpdateStoragePermissionGranted();
            }
            else
            {
                base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
            }
        }

        public void OnFileItemClicked(string fileExtra, string filePath)
        {
            OnFileSelected(fileExtra, filePath);
        }
    }
}