using Android.App;
using Android.OS;
using Android.Views;
using Android.Content.Res;
using Android.Support.V7.App;
using Android.Content.PM;
using Android.Content;
using Android.Runtime;

using Com.Foxit.Sdk;
using Com.Foxit.Uiextensions;

using Com.Foxit.Uiextensions.Utils;
using Com.Foxit.Uiextensions.Home;

namespace Com.Foxit.Pdfreader
{

    [Activity(Label = "@string/app_name",
    ConfigurationChanges = ConfigChanges.KeyboardHidden | ConfigChanges.Orientation | ConfigChanges.ScreenSize,
    ScreenOrientation = ScreenOrientation.FullSensor,
    Theme = "@style/AppTheme")]
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

            filter = this.Intent.GetStringExtra("filter");
            Window.SetSoftInputMode(SoftInput.StateAlwaysHidden);

            pdfViewCtrl = new PDFViewCtrl(this);

            System.IO.Stream stream = Assets.Open("uiextensions_config.json");
            UIExtensionsManager.Config config = new UIExtensionsManager.Config(stream);
            uiExtensionsManager = new UIExtensionsManager(this, pdfViewCtrl, config);
            uiExtensionsManager.AttachedActivity = this;
            uiExtensionsManager.RegisterModule(App.Instance().GetLocalModule(filter));

            uiExtensionsManager.OnCreate(this, pdfViewCtrl, savedInstanceState);
            pdfViewCtrl.UIExtensionsManager = uiExtensionsManager;

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
