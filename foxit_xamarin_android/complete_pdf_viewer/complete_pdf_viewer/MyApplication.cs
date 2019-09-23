using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Content.Res;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Com.Foxit.Uiextensions.Utils;
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