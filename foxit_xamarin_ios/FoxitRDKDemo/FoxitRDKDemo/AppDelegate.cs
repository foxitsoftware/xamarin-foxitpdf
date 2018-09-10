/**
 * Copyright (C) 2003-2017, Foxit Software Inc..
 * All Rights Reserved.
 *
 * http://www.foxitsoftware.com
 *
 * The following code is copyrighted and is the proprietary of Foxit Software Inc.. It is not allowed to
 * distribute any parts of Foxit Mobile PDF SDK to third party or public without permission unless an agreement
 * is signed between Foxit Software Inc. and customers to explicitly grant customers permissions.
 * Review legal.txt for additional license and legal information.
 */

using Foundation;
using UIKit;
using FoxitRDK;
using FoxitRDKUI;
using System.IO;
using System;

namespace FoxitRDKDemo
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
            this.Window.BackgroundColor = UIColor.White;

            // Load the license serial number and key from the resource files
            string sn = GetIni(NSBundle.MainBundle.PathForResource("rdk_sn", "txt"), "SN");
            string key = GetIni(NSBundle.MainBundle.PathForResource("rdk_key", "txt"), "Sign");

            // Initialize the library
            var eRet = FSLibrary.Initialize(sn, key);
            if (FSErrorCode.Success != eRet)
            {
                string errMsg = "Invalid license";

                UIAlertController alert = UIAlertController.Create("Check License", errMsg, UIAlertControllerStyle.Alert);
                alert.AddAction(UIAlertAction.Create("OK", UIAlertActionStyle.Default, null));
                UIApplication.SharedApplication.KeyWindow.RootViewController.PresentViewController(alert, true, null);

                return false;                
            }

            return true;
        }

        public override void OnResignActivation(UIApplication application)
        {
            // Invoked when the application is about to move from active to inactive state.
            // This can occur for certain types of temporary interruptions (such as an incoming phone call or SMS message) 
            // or when the user quits the application and it begins the transition to the background state.
            // Games should use this method to pause the game.
        }

        public override void DidEnterBackground(UIApplication application)
        {
            // Use this method to release shared resources, save user data, invalidate timers and store the application state.
            // If your application supports background exection this method is called instead of WillTerminate when the user quits.
        }

        public override void WillEnterForeground(UIApplication application)
        {
            // Called as part of the transiton from background to active state.
            // Here you can undo many of the changes made on entering the background.
        }

        public override void OnActivated(UIApplication application)
        {
            // Restart any tasks that were paused (or not yet started) while the application was inactive. 
            // If the application was previously in the background, optionally refresh the user interface.
        }

        public override void WillTerminate(UIApplication application)
        {
            // Called when the application is about to terminate. Save data, if needed. See also DidEnterBackground.
        }
    }
}

