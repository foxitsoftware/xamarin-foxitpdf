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

using System;
using System.IO;
using UIKit;
using FoxitRDK;
using FoxitRDKUI;
using Foundation;
using CoreFoundation;

namespace FoxitRDKDemo
{
    public partial class ViewController : UIViewController, IIDocEventListener, IFSFileSelectDelegate
    {
        private UINavigationController rootViewController;
        private FSPDFViewCtrl pdfViewControl;
        private UIExtensionsManager extensionsMgr;
        private UIViewController pdfViewController;

        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            this.View.BackgroundColor = UIColor.White;
            this.View.AutoresizingMask = UIViewAutoresizing.FlexibleLeftMargin | UIViewAutoresizing.FlexibleTopMargin | UIViewAutoresizing.FlexibleRightMargin | UIViewAutoresizing.FlexibleBottomMargin | UIViewAutoresizing.FlexibleHeight | UIViewAutoresizing.FlexibleWidth;


            this.pdfViewControl = new FSPDFViewCtrl(new CoreGraphics.CGRect(
                0, 0, this.View.Frame.Size.Width, this.View.Frame.Size.Height));

            pdfViewControl.RegisterDocEventListener(this);

            string configPath = NSBundle.MainBundle.PathForResource("uiextensions_config", "json");
            this.extensionsMgr = new UIExtensionsManager(pdfViewControl, NSData.FromFile(configPath));

            if (null == this.extensionsMgr)
            {
                //        UIAlertView *alert = [[UIAlertView alloc] initWithTitle:@"" message:@"Extensions manager could not be loaded." delegate:self cancelButtonTitle:@"cancel" otherButtonTitles:nil, nil];
                //        [alert show];
                return;
            }

            FSFileListViewController fileListViewController = new FSFileListViewController();
            fileListViewController.WeakDelegate = this;
            this.pdfViewControl.RegisterDocEventListener(fileListViewController);

            this.rootViewController = new UINavigationController(fileListViewController);
            this.rootViewController.NavigationBarHidden = true;

            this.rootViewController.View.Frame = new CoreGraphics.CGRect(
                0, 0, this.View.Frame.Size.Width, this.View.Frame.Size.Height);
            this.rootViewController.InteractivePopGestureRecognizer.Enabled = false;
            this.AddChildViewController(this.rootViewController);
            this.View.AddSubview(this.rootViewController.View);

            var weakSelf = new WeakReference(this);
            this.extensionsMgr.GoBack = () =>
            {
                if (weakSelf.IsAlive)
                {
                    this.rootViewController.PopViewController(true);
                }
            };

            this.pdfViewControl.ExtensionsManager = extensionsMgr;
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        #region Rotate event
        public override bool ShouldAutorotateToInterfaceOrientation(UIInterfaceOrientation toInterfaceOrientation)
        {
            return !this.extensionsMgr.IsScreenLocked;
        }

        public override bool ShouldAutorotate()
        {
            return !this.extensionsMgr.IsScreenLocked;
        }

        public override UIInterfaceOrientationMask GetSupportedInterfaceOrientations()
        {
            return UIInterfaceOrientationMask.All;
        }

        public override void WillRotate(UIInterfaceOrientation toInterfaceOrientation, double duration)
        {
            this.extensionsMgr.WillRotateToInterfaceOrientation(toInterfaceOrientation, duration);
        }

        public override void WillAnimateRotation(UIInterfaceOrientation toInterfaceOrientation, double duration)
        {
            this.extensionsMgr.WillAnimateRotationToInterfaceOrientation(toInterfaceOrientation, duration);
        }

        public override void DidRotate(UIInterfaceOrientation fromInterfaceOrientation)
        {
            this.extensionsMgr.DidRotateFromInterfaceOrientation(fromInterfaceOrientation);
        }
        #endregion

        #region <IDocEventListener>
        public void OnDocOpened(FSPDFDoc document, int error)
        {

        }

        void OnDocClosed(FSPDFDoc document, int error)
        {

        }
        #endregion

        #region <FSFileSelectDelegate>
        public void DidFileSelected(string filePath)
        {
            var pdfViewCtrl = new WeakReference<FSPDFViewCtrl>(this.pdfViewControl);
            var weakSelf = new WeakReference(this);

            this.pdfViewControl.OpenDoc(filePath, null, (FSErrorCode error) =>
            {
                if (error != FSErrorCode.Success)
                {
                    UIAlertController alert = UIAlertController.Create("error", "Failed to open the document", UIAlertControllerStyle.Alert);
                    alert.AddAction(UIAlertAction.Create("ok", UIAlertActionStyle.Default, null));
                    PresentViewController(alert, true, null);
                    return;
                }
                if (weakSelf.IsAlive)
                {
                    UINavigationController rootNav = this.rootViewController;
                    if (rootNav.TopViewController.View != this.pdfViewControl)
                    {
                        DispatchQueue.MainQueue.DispatchAsync(() =>
                        {
                            if (this.pdfViewController == null)
                            {
                                this.pdfViewController = new UIViewController();
                                pdfViewController.View = pdfViewControl;
                                pdfViewController.AutomaticallyAdjustsScrollViewInsets = false;
                            }

                            //Push to display the document on pdf view control.
                            rootNav.PushViewController(pdfViewController, true);
                        });
                    }
                }
            });
        }
        #endregion
    }
}
