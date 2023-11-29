using System;

using Android.App;
using Android.Content.Res;
using Android.Runtime;
using Com.Foxit.Sdk;

namespace Com.Foxit
{
    [Application]
    class MyApplication : Application
    {

        public MyApplication(IntPtr handle, JniHandleOwnership ownerShip) : base(handle, ownerShip)
        {
        }

        public override void OnCreate()
        {
            base.OnCreate();
            App.Instance().SetApplicationContext(this.ApplicationContext);
            Localization.SetCurrentLanguage(this, Localization.GetCurrentLanguage(this));
            if (!App.Instance().CheckLicense())
            {
                return;
            }
        }

        public override void OnConfigurationChanged(Configuration newConfig)
        {
            base.OnConfigurationChanged(newConfig);
            Localization.SetCurrentLanguage(this, Localization.GetCurrentLanguage(this));
        }

    }


}