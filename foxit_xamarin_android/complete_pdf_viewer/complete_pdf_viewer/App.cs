
using Android.App;
using Android.Content;
using Android.Text;
using Android.Net;
using AndroidX.DocumentFile.Provider;
using Com.Foxit.Home;
using Com.Foxit.Sdk.Common;
using Com.Foxit.Uiextensions.Utils;
using Com.Foxit.Uiextensions.Home.Local;

using System.Collections.Generic;
using Android.OS;
using Java.Util;
using System.IO;

namespace Com.Foxit
{

    public class App
    {
        public const string FILTER_DEFAULT = "default_filter";

        private static App INSTANCE = new App();

        private Context mContext;
        private int errCode = Constants.EErrSuccess;
        private bool isInitLibrary = false;

        private App()
        {
        }

        public static App Instance()
        {
            return INSTANCE;
        }

        public bool CheckLicense()
        {
            if (isInitLibrary == false)
            {
                InitLibrary();
            }

            switch (errCode)
            {
                case Constants.EErrSuccess:
                    break;
                case Constants.EErrInvalidLicense:
                    UIToast.GetInstance(mContext).Show("The License is invalid!");
                    return false;
                default:
                    UIToast.GetInstance(mContext).Show("Failed to initialize the library!");
                    return false;
            }
            return true;
        }

        private void InitLibrary()
        {
            var inputstream = mContext.Assets.Open("rdk_sn.txt");
            string sn = GetValueFromPropFile(inputstream, "SN");

            inputstream = mContext.Assets.Open("rdk_key.txt");
            string key = GetValueFromPropFile(inputstream, "Sign");

            errCode = Library.Initialize(sn, key);

            Android.Util.Log.Info("mytag", "key:" + key + " sn:" + sn);
            isInitLibrary = true;
        }

        public void SetApplicationContext(Context context)
        {
            mContext = context;
        }

        public Context GetApplicationContext()
        {
            return mContext;
        }

        private Dictionary<string, LocalModule> mLocalModules = new Dictionary<string, LocalModule>();
        public LocalModule GetLocalModule(string filter)
        {
            if (!mLocalModules.ContainsKey(filter))
            {
                LocalModule module = new LocalModule(mContext);
                module.LoadModule();
                mLocalModules.Add(filter, module);
            }
            return mLocalModules[filter];
        }

        public void UnloadLocalModule(string filter)
        {
            if (mLocalModules.ContainsKey(filter))
            {
                LocalModule module = mLocalModules[filter];
                module.UnloadModule();
                mLocalModules.Remove(filter);
            }
        }

        public void CopyGuideFiles(LocalModule localModule)
        {
            if (Environment.ExternalStorageState.Equals(Environment.MediaMounted))
            {
                string curPath = AppStorageManager.GetInstance(mContext).DefaultFolder;
                if (!AppFileUtil.NeedScopedStorageAdaptation()) 
                {
                    curPath = AppFileUtil.DefaultDocumentDirectory;
                    Java.IO.File file = new Java.IO.File(curPath);
                    if (!file.Exists())
                    {
                        if (!file.Mkdirs())
                            return;
                    }
                    Java.IO.File sampleFile = new Java.IO.File(curPath + Java.IO.File.Separator + "Sample.pdf");
                    if (!sampleFile.Exists())
                    {
                        localModule.CopyFileFromAssertsToTargetFile(sampleFile);
                    }

                    Java.IO.File guideFile = new Java.IO.File(curPath + Java.IO.File.Separator + "complete_pdf_viewer_guide_android.pdf");
                    if (!guideFile.Exists())
                    {
                        localModule.CopyFileFromAssertsToTargetFile(guideFile);
                    }
                }
                else if (!TextUtils.IsEmpty(curPath))
                {
                    Uri uri = AppFileUtil.ToDocumentUriFromPath(curPath);
                    if (AppFileUtil.IsDocumentTreeUri(uri))
                    {
                        DocumentFile directory = AppStorageManager.GetInstance(mContext).GetExistingDocumentFile(uri);
                        if (directory == null) return;
                        string fileName = "Sample.pdf";
                        DocumentFile file = directory.FindFile(fileName);
                        if (file == null)
                        {
                            file = directory.CreateFile(AppFileUtil.GetMimeType(fileName), fileName);
                            localModule.CopyFileFromAssertsToTargetFile(file);
                        }

                        fileName = "complete_pdf_viewer_guide_android.pdf";
                        file = directory.FindFile(fileName);
                        if (file == null)
                        {
                            file = directory.CreateFile(AppFileUtil.GetMimeType(fileName), fileName);
                            localModule.CopyFileFromAssertsToTargetFile(file);
                        }
                    }
                    localModule.SetCurrentPath(curPath);
                }
            }
        }

        private string GetValueFromPropFile(Stream stream, string key)
        {
            Properties props = new Properties();
            props.Load(stream);
            string value = props.GetProperty(key);
            return value;
        }


        public void SelectDefaultFolderOrNot(Activity activity)
        {
            if (AppFileUtil.NeedScopedStorageAdaptation())
            {
                if (activity != null && TextUtils.IsEmpty(AppStorageManager.GetInstance(activity).DefaultFolder))
                {
                    AppFileUtil.CheckCallDocumentTreeUriPermission(activity, MainActivity.REQUEST_SELECT_DEFAULT_FOLDER,
                            Uri.Parse(AppFileUtil.ExternalRootDocumentTreeUriPath));
                    UIToast.GetInstance(activity).Show("Please select the default folder,you can create one when it not exists.");
                }
            }
        }

    }

}