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

using System;
using System.IO;
using UIKit;
using Foundation;
using CoreFoundation;
using Foxit.iOS;
using Foxit.iOS.UIExtensions;

#if !MACCATALYST
    using Foxit.iOS.Scanning.UI;
#endif

using ObjCRuntime;

namespace CompletePdfViewer
{
    public partial class ViewController : UIViewController, IIDocEventListener, IFSFileSelectDelegate
    {
        private UINavigationController rootViewController;
        private FSPDFViewCtrl pdfViewControl;
        private UIExtensionsManager extensionsMgr;
        private UIViewController pdfViewController;

#if !NET
        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }
#endif

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            this.View.BackgroundColor = UIColor.White;
            this.View.AutoresizingMask = UIViewAutoresizing.FlexibleLeftMargin | UIViewAutoresizing.FlexibleTopMargin | UIViewAutoresizing.FlexibleRightMargin | UIViewAutoresizing.FlexibleBottomMargin | UIViewAutoresizing.FlexibleHeight | UIViewAutoresizing.FlexibleWidth;


            this.pdfViewControl = new FSPDFViewCtrl(new CoreGraphics.CGRect(
                0, 0, this.View.Frame.Size.Width, this.View.Frame.Size.Height));
            pdfViewControl.SetRMSAppClientId(appClientId: "972b6681-fa03-4b6b-817b-c8c10d38bd20", redirectURI: "com.foxitsoftware.com.mobilepdf-for-ios://authorize");
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

#if !MACCATALYST
            PDFScanManager.InitializeScanner(0, 0);
            PDFScanManager.InitializeCompression(0, 0);

            UIButton button = new UIButton();
            button.TouchUpInside += openScan;
            button.SetImage(UIImage.FromBundle("scan"), UIControlState.Normal);
            fileListViewController.View.AddSubview(button);
            button.TranslatesAutoresizingMaskIntoConstraints = false;
            button.WidthAnchor.ConstraintEqualTo(60).Active = true;
            button.HeightAnchor.ConstraintEqualTo(60).Active = true;
            button.BottomAnchor.ConstraintEqualTo(fileListViewController.View.SafeAreaLayoutGuide.BottomAnchor, -15).Active = true;
            button.RightAnchor.ConstraintEqualTo(fileListViewController.View.RightAnchor, -15).Active = true;

        }
        public void openScan(object sender, EventArgs e)
        {
            var PDFScanView = PDFScanManager.ShareManager.PDFScanView;
            if (PDFScanView != null) PresentViewController(PDFScanView, true, null);
            PDFScanManager.SaveAsCallBack = (error, savePath) =>
            {
                if (savePath != null)
                {
                    if (PDFScanView.PresentingViewController != null)
                    {
                        PDFScanView.PresentingViewController.DismissViewController(false, null);
                    }
                    PDFScanView.DismissViewController(false, null);
                    DidFileSelected(savePath);
                }
            };
#endif
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
            return this.extensionsMgr == null ? base.ShouldAutorotate() : !this.extensionsMgr.IsScreenLocked;
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

        public override bool PrefersStatusBarHidden()
        {
            return this.extensionsMgr == null ? base.PrefersStatusBarHidden() : this.extensionsMgr.PrefersStatusBarHidden;
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
