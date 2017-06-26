using System;
using System.IO;
using UIKit;
using FoxitRDK;
using Foundation;

namespace FoxitRDKDemo
{
    public partial class ViewController : UIViewController
    {
        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
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

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

			// Load the license serial number and key from the resource files
			string sn = GetIni(NSBundle.MainBundle.PathForResource("rdk_sn", "txt"), "SN");
			string key = GetIni(NSBundle.MainBundle.PathForResource("rdk_key", "txt"), "Sign");
			// Initialize the library
			var eRet = FSLibrary.Init(sn, key);
			if (FSErrorCode.Success == eRet)
			{
				// Get the sample PDF file name from the bundle resources
				string pdfFileName = NSBundle.MainBundle.PathForResource("Sample", "pdf");
				// Load the PDF document
				string pdfPassword = "";
				var doc = FSPDFDoc.CreateFromFilePath(pdfFileName);
				if (FSErrorCode.Success == doc.Load(pdfPassword))
				{
					// Create the view
					var view = new FSPDFViewCtrl(new CoreGraphics.CGRect(
					0, 0, this.View.Frame.Size.Width, this.View.Frame.Size.Height));
					view.SetDoc(doc);
					Add(view);
				}
			}
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
