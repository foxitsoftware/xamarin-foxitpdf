﻿using Android;
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
using Android.Content.Res;

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
    public class MainActivity : AppCompatActivity, Com.Foxit.Uiextensions.Home.IHomeModuleOnFileItemEventListener, LocalModule.ICompareListener
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
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);

            mLicenseValid = App.Instance().CheckLicense();
            if (!mLicenseValid)
                return;

            if (this.Intent != null && this.Intent.Action != null)
            {
                filter = Intent.Action;
            }

            if (Build.VERSION.SdkInt >= BuildVersionCodes.M)
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

            App.Instance().GetLocalModule(filter).SetAttachedActivity(this);
            App.Instance().CopyGuideFiles(App.Instance().GetLocalModule(filter));
            App.Instance().GetLocalModule(filter).SetFileItemEventListener(this);
            App.Instance().GetLocalModule(filter).SetCompareListener(this);

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
                    App.Instance().CopyGuideFiles(App.Instance().GetLocalModule(filter));
                    App.Instance().GetLocalModule(filter).UpdateStoragePermissionGranted();
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

        public override void OnConfigurationChanged(Configuration newConfig)
        {
            base.OnConfigurationChanged(newConfig);
            App.Instance().GetLocalModule(filter).OnConfigurationChanged(newConfig);
        }

    }
}