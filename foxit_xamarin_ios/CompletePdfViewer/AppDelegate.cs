/**
 * Copyright (C) 2003-2020, Foxit Software Inc..
 * All Rights Reserved.
 *
 * http://www.foxitsoftware.com
 *
 * The following code is copyrighted and is the proprietary of Foxit Software Inc.. It is not allowed to
 * distribute any parts of Foxit PDF SDK for iOS to third party or public without permission unless an agreement
 * is signed between Foxit Software Inc. and customers to explicitly grant customers permissions.
 * Review legal.txt for additional license and legal information.
 */

using Foundation;
using UIKit;
using Foxit.iOS;
using System.IO;
using System;

namespace CompletePdfViewer
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the
    // User Interface of the application, as well as listening (and optionally responding) to application events from iOS.
    [Register("AppDelegate")]
    public class AppDelegate : UIApplicationDelegate
    {
        // class-level declarations

        public AppDelegate()
        {
            CopyPDFFromResourceToDocuments("Sample", false);
            CopyPDFFromResourceToDocuments("complete_pdf_viewer_guide_ios", false);
            Console.WriteLine("document path " + Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));
            //NSLog( @"%@", DOCUMENT_PATH); //for finding Documents directory to debug
        }

        private bool CopyPDFFromResourceToDocuments(string filename, bool overwrite)
        {
            NSFileManager fileManager = new NSFileManager();

            string fromPath = NSBundle.MainBundle.PathForResource(filename, "pdf");
            if ((fromPath == null) || (fromPath == ""))
            {
                return false;
            }

            string toPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), filename + ".pdf");

            if (fileManager.FileExists(toPath))
            {
                if (overwrite)
                {
                    NSError deleteError = null;
                    if (!fileManager.Remove(toPath, out deleteError))
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }

            NSError error = null;
            if (fileManager.Copy(fromPath, toPath, out error))
            {
                return true;
            }
            else
            {
                Console.WriteLine("Failed to copy " + filename + ". " + error.LocalizedDescription);
                return false;
            }

        }

        public override UIWindow Window
        {
            get;
            set;
        }

        string GetIni(string fileName, string key)
        {
            string[] lines = File.ReadAllLines(fileName);
            foreach (string line in lines)
            {
                if (line.StartsWith(key))
                {
                    return line.Substring(key.Length + 1);
                }
            }
            return "";
        }


        public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
        {

            Window = new UIWindow(UIScreen.MainScreen.Bounds);
            Window.BackgroundColor = UIColor.White;

            // Load the license serial number and key from the resource files
            string sn = GetIni(NSBundle.MainBundle.PathForResource("rdk_sn", "txt"), "SN");
            string key = GetIni(NSBundle.MainBundle.PathForResource("rdk_key", "txt"), "Sign");

            Console.WriteLine("sn {0}", sn);
            Console.WriteLine("key {0}", key);

            // Initialize the library
            var eRet = FSLibrary.Initialize(sn, key);
            if (FSErrorCode.Success != eRet)
            {

                // create a UIViewController with a single UILabel
                var vc = new UIViewController();

                Window.RootViewController = vc;

                // make the window visible
                Window.MakeKeyAndVisible();


                string errMsg = "Invalid license";
                UIAlertController alert = UIAlertController.Create("Check License", errMsg, UIAlertControllerStyle.Alert);
                alert.AddAction(UIAlertAction.Create("OK", UIAlertActionStyle.Default, null));
                vc.PresentViewController(alert, true, null);

                return false;
            }
            else
            {
#if !NET
                UIStoryboard storyboard = UIStoryboard.FromName("Main", NSBundle.MainBundle);
                var vc = storyboard.InstantiateInitialViewController();
#else
                var vc = new ViewController();
#endif
                Window.RootViewController = vc;

                // make the window visible
                Window.MakeKeyAndVisible();
            }

            return true;
        }
    }

}
