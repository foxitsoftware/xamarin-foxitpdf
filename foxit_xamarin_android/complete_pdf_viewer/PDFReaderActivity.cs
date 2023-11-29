using Android.App;
using Android.OS;
using Android.Views;
using Android.Content.Res;
using Android.Content.PM;
using Android.Content;
using Android.Runtime;
using Android.Net;
using Android.Text;
using AndroidX.AppCompat.App;
using Com.Foxit.Sdk;
using Com.Foxit.Uiextensions;
using Com.Foxit.Home;

using Com.Foxit.Uiextensions.Utils;
using Com.Foxit.Uiextensions.Home;
using Com.Foxit.Uiextensions.Config;
using Com.Foxit.Uiextensions.Home.Local;

namespace Com.Foxit.Pdfreader
{

    [Activity(Label = "@string/app_name",
    ConfigurationChanges = ConfigChanges.KeyboardHidden | ConfigChanges.Orientation | ConfigChanges.ScreenSize | ConfigChanges.SmallestScreenSize,
    ScreenOrientation = ScreenOrientation.FullSensor,
    Theme = "@style/AppTheme")]
    [Layout(MinHeight = "700dp", MinWidth = "520dp", Gravity = "center")]
    [MetaData("android.support.PARENT_ACTIVITY", Value = "Com.Foxit.Home.MainActivity")]
    public class PDFReaderActivity : AppCompatActivity
    {

        private PDFViewCtrl pdfViewCtrl = null;
        private UIExtensionsManager uiExtensionsManager = null;

        private string filter;
        private string filePath;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            AppTheme.SetThemeFullScreen(this);
            AppTheme.SetThemeNeedMenuKey(this);
            ActManager.Instance.CurrentActivity = this;

            filter = this.Intent.GetStringExtra("filter");
            Window.SetSoftInputMode(SoftInput.StateAlwaysHidden);

            pdfViewCtrl = new PDFViewCtrl(ApplicationContext);

            System.IO.Stream stream = Assets.Open("uiextensions_config.json");
            Config config = new Config(stream);
            uiExtensionsManager = new UIExtensionsManager(ApplicationContext, pdfViewCtrl, config);
            uiExtensionsManager.AttachedActivity = this;
            uiExtensionsManager.RegisterModule(App.Instance().GetLocalModule(filter));

            uiExtensionsManager.OnCreate(this, pdfViewCtrl, savedInstanceState);
            pdfViewCtrl.UIExtensionsManager = uiExtensionsManager;
            pdfViewCtrl.AttachedActivity = this;

            filePath = AppFileUtil.GetFilePath(this, this.Intent, HomeModule.FileExtra);
            uiExtensionsManager.OpenDocument(filePath, null);

            SetContentView(uiExtensionsManager.ContentView);
        }

        protected override void OnDestroy()
        {
            if (uiExtensionsManager != null)
            {
                uiExtensionsManager.OnDestroy(this);
            }
            base.OnDestroy();
        }

        protected override void OnStop()
        {
            if (uiExtensionsManager != null)
            {
                uiExtensionsManager.OnStop(this);
            }
            base.OnStop();
        }

        protected override void OnStart()
        {
            if (uiExtensionsManager != null)
            {
                uiExtensionsManager.OnStart(this);
            }
            base.OnStart();
        }

        protected override void OnPause()
        {
            if (uiExtensionsManager != null)
            {
                uiExtensionsManager.OnPause(this);
            }
            base.OnPause();
        }

        protected override void OnResume()
        {
            if (uiExtensionsManager != null)
            {
                uiExtensionsManager.OnResume(this);
            }
            base.OnResume();
        }

        protected override void OnNewIntent(Intent intent)
        {
            base.OnNewIntent(intent);

            filter = intent.GetStringExtra("filter");
            filePath = AppFileUtil.GetFilePath(this, intent, HomeModule.FileExtra);
            this.Intent = intent;
        }

        public override bool OnKeyDown([GeneratedEnum] Keycode keyCode, KeyEvent e)
        {
            if (uiExtensionsManager != null && keyCode == Keycode.Back)
            {
                if (uiExtensionsManager.BackToNormalState())
                {
                    return true;
                }

                if (e.RepeatCount == 0)
                {
                    uiExtensionsManager.BackToPrevActivity();
                    return true;
                }
            }
            return base.OnKeyDown(keyCode, e);
        }

        protected override void OnActivityResult(int requestCode, [GeneratedEnum] Result resultCode, Intent data)
        {
            base.OnActivityResult(requestCode, resultCode, data);
            if (resultCode == Result.Ok)
            {
                if (requestCode == AppStorageManager.OpenTreeRequestCode
                    || requestCode == MainActivity.REQUEST_SELECT_DEFAULT_FOLDER)
                {
                    if (data == null || data.Data == null) return;

                    Android.Net.Uri uri = data.Data;
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

            if (uiExtensionsManager != null)
            {
                uiExtensionsManager.HandleActivityResult(this, requestCode, (int)resultCode, data);
            }
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Permission[] grantResults)
        {
            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
            if (uiExtensionsManager != null)
            {
                int[] _grantResults = new int[grantResults.Length];
                for (int i=0; i < grantResults.Length; i++) {
                    _grantResults[i] = grantResults[i] == Permission.Granted ? 0 : -1;
                }
                uiExtensionsManager.HandleRequestPermissionsResult(requestCode, permissions, _grantResults);
            }
        }

        public override void OnConfigurationChanged(Configuration newConfig)
        {
            base.OnConfigurationChanged(newConfig);
            if (uiExtensionsManager != null)
            {
                uiExtensionsManager.OnConfigurationChanged(this, newConfig);
            }
        }
    }
}
