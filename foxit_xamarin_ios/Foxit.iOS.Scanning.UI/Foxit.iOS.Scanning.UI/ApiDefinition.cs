/**
* Copyright (C) 2003-2021, Foxit Software Inc..
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
using Foundation;
using ObjCRuntime;
using UIKit;

using Foxit.iOS;

namespace Foxit.iOS.Scanning.UI
{
	[Static]
	//[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern double FoxitPDFScanUIVersionNumber;
		[Field ("FoxitPDFScanUIVersionNumber", "__Internal")]
		double FoxitPDFScanUIVersionNumber { get; }

		/*
		// extern const unsigned char [] FoxitPDFScanUIVersionString;
		[Field ("FoxitPDFScanUIVersionString", "__Internal")]
		byte[] FoxitPDFScanUIVersionString { get; }
		*/
	}

	// typedef void (^ScanPDFSaveAsCallBack)(NSError * _Nullable, NSString * _Nullable);
	delegate void ScanPDFSaveAsCallBack ([NullAllowed] NSError arg0, [NullAllowed] string arg1);

	// @interface PDFScanManager : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface PDFScanManager
	{
		// @property (copy, nonatomic, class) ScanPDFSaveAsCallBack _Nonnull saveAsCallBack;
		[Static]
		[Export ("saveAsCallBack", ArgumentSemantic.Copy)]
		ScanPDFSaveAsCallBack SaveAsCallBack { get; set; }

		// +(FSErrorCode)initializeScanner:(unsigned long)serial1 serial2:(unsigned long)serial2;
		[Static]
		[Export ("initializeScanner:serial2:")]
		FSErrorCode InitializeScanner (nuint serial1, nuint serial2);

		// +(FSErrorCode)initializeCompression:(unsigned long)serial1 serial2:(unsigned long)serial2;
		[Static]
		[Export ("initializeCompression:serial2:")]
		FSErrorCode InitializeCompression (nuint serial1, nuint serial2);

		// +(__kindof UIViewController * _Nonnull)getPDFScanView;
		[Static]
		[Export ("getPDFScanView")]
		//[Verify (MethodToProperty)]
		UIViewController PDFScanView { get; }
	}
}
