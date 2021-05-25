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
using Foxit.iOS.UIExtensions;

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

	// @interface PDFScanToolbarManager : NSObject
	[BaseType (typeof(NSObject))]
	interface PDFScanToolbarManager
	{
		// -(void)setToolbar:(FSMainToolbar * _Nonnull)toolbar forToolbarType:(FSPDFScanToolbarType)toolbarType;
		[Export ("setToolbar:forToolbarType:")]
		void SetToolbar (FSMainToolbar toolbar, FSPDFScanToolbarType toolbarType);

		// -(FSMainToolbar * _Nonnull)getToolbar:(FSPDFScanToolbarType)toolbarType;
		[Export ("getToolbar:")]
		FSMainToolbar GetToolbar (FSPDFScanToolbarType toolbarType);
	}

	// typedef void (^PDFScanMenuItemAction)(PDFScanMenuItem * _Nonnull);
	delegate void PDFScanMenuItemAction (PDFScanMenuItem arg0);

	// @interface PDFScanMenuItem : NSObject
	[BaseType (typeof(NSObject))]
	interface PDFScanMenuItem
	{
		// @property (readonly, assign, nonatomic) NSUInteger index;
		[Export ("index")]
		nuint Index { get; }

		// @property (copy, nonatomic) NSString * _Nonnull title;
		[Export ("title")]
		string Title { get; set; }

		// @property (nonatomic, strong) UIImage * _Nullable image;
		[NullAllowed, Export ("image", ArgumentSemantic.Strong)]
		UIImage Image { get; set; }

		// @property (copy, nonatomic) PDFScanMenuItemAction _Nullable action;
		[NullAllowed, Export ("action", ArgumentSemantic.Copy)]
		PDFScanMenuItemAction Action { get; set; }

		// -(instancetype _Nonnull)initWithTitle:(NSString * _Nonnull)title image:(UIImage * _Nullable)image action:(PDFScanMenuItemAction _Nonnull)action;
		[Export ("initWithTitle:image:action:")]
		IntPtr Constructor (string title, [NullAllowed] UIImage image, PDFScanMenuItemAction action);
	}

	// @interface PDFScanMenuItemGroup : NSObject
	[BaseType (typeof(NSObject))]
	interface PDFScanMenuItemGroup
	{
		// @property (readonly, assign, nonatomic) NSUInteger index;
		[Export ("index")]
		nuint Index { get; }

		// @property (copy, nonatomic) NSString * _Nonnull title;
		[Export ("title")]
		string Title { get; set; }

		// @property (nonatomic, strong) NSMutableArray * _Nonnull items;
		[Export ("items", ArgumentSemantic.Strong)]
		NSMutableArray Items { get; set; }

		// -(instancetype _Nonnull)initWithTitle:(NSString * _Nullable)title items:(NSArray<PDFScanMenuItem *> * _Nonnull)items;
		[Export ("initWithTitle:items:")]
		IntPtr Constructor ([NullAllowed] string title, PDFScanMenuItem[] items);
	}

	// @protocol PDFScanMenuView <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface PDFScanMenuView
	{
		// @required @property (nonatomic, weak) UIViewController * _Nullable containerController;
		[Abstract]
		[NullAllowed, Export ("containerController", ArgumentSemantic.Weak)]
		UIViewController ContainerController { get; set; }

		// @required -(UIView * _Nonnull)getCustomView;
		[Abstract]
		[Export ("getCustomView")]
		//[Verify (MethodToProperty)]
		UIView CustomView { get; }
	}

	// @interface PDFScanMenuViewManager : NSObject
	[BaseType (typeof(NSObject))]
	interface PDFScanMenuViewManager
	{
		// -(void)setMenuView:(id<PDFScanMenuView> _Nonnull)menuView forMenuViewType:(PDFScanMenuViewType)menuViewType;
		[Export ("setMenuView:forMenuViewType:")]
		void SetMenuView (PDFScanMenuView menuView, PDFScanMenuViewType menuViewType);

		// -(id<PDFScanMenuView> _Nonnull)getMenuViewForMenuViewType:(PDFScanMenuViewType)menuViewType;
		[Export ("getMenuViewForMenuViewType:")]
		PDFScanMenuView GetMenuViewForMenuViewType (PDFScanMenuViewType menuViewType);

		// -(void)addMenuItemGroup:(PDFScanMenuItemGroup * _Nonnull)group forMenuViewType:(PDFScanMenuViewType)menuViewType;
		[Export ("addMenuItemGroup:forMenuViewType:")]
		void AddMenuItemGroup (PDFScanMenuItemGroup group, PDFScanMenuViewType menuViewType);

		// -(void)insertMenuItemGroup:(PDFScanMenuItemGroup * _Nonnull)group atIndex:(NSInteger)index forMenuViewType:(PDFScanMenuViewType)menuViewType;
		[Export ("insertMenuItemGroup:atIndex:forMenuViewType:")]
		void InsertMenuItemGroup (PDFScanMenuItemGroup group, nint index, PDFScanMenuViewType menuViewType);

		// -(void)exchangeMenuItemGroupAtIndex:(NSInteger)index1 withMenuItemGroupAtIndex:(NSInteger)index2 forMenuViewType:(PDFScanMenuViewType)menuViewType;
		[Export ("exchangeMenuItemGroupAtIndex:withMenuItemGroupAtIndex:forMenuViewType:")]
		void ExchangeMenuItemGroupAtIndex (nint index1, nint index2, PDFScanMenuViewType menuViewType);

		// -(void)insertMenuItemGroup:(PDFScanMenuItemGroup * _Nonnull)group beforeGroup:(PDFScanMenuItemGroup * _Nonnull)siblingGroup forMenuViewType:(PDFScanMenuViewType)menuViewType;
		[Export ("insertMenuItemGroup:beforeGroup:forMenuViewType:")]
		void InsertMenuItemGroupBefore (PDFScanMenuItemGroup group, PDFScanMenuItemGroup siblingGroup, PDFScanMenuViewType menuViewType);

		// -(void)insertMenuItemGroup:(PDFScanMenuItemGroup * _Nonnull)group afterGroup:(PDFScanMenuItemGroup * _Nonnull)siblingGroup forMenuViewType:(PDFScanMenuViewType)menuViewType;
		[Export ("insertMenuItemGroup:afterGroup:forMenuViewType:")]
		void InsertMenuItemGroupAfter (PDFScanMenuItemGroup group, PDFScanMenuItemGroup siblingGroup, PDFScanMenuViewType menuViewType);

		// -(void)removeMenuItemGroup:(PDFScanMenuItemGroup * _Nonnull)group forMenuViewType:(PDFScanMenuViewType)menuViewType;
		[Export ("removeMenuItemGroup:forMenuViewType:")]
		void RemoveMenuItemGroup (PDFScanMenuItemGroup group, PDFScanMenuViewType menuViewType);

		// -(NSArray<PDFScanMenuItemGroup *> * _Nonnull)getMenuItemGroupsForMenuViewType:(PDFScanMenuViewType)menuViewType;
		[Export ("getMenuItemGroupsForMenuViewType:")]
		PDFScanMenuItemGroup[] GetMenuItemGroupsForMenuViewType (PDFScanMenuViewType menuViewType);
	}

	// typedef void (^ScanPDFSaveAsCallBack)(NSError * _Nullable, NSString * _Nullable);
	delegate void ScanPDFSaveAsCallBack ([NullAllowed] NSError arg0, [NullAllowed] string arg1);

	// typedef void (^ScanPDFDoneCallBack)(NSError * _Nullable, NSString * _Nullable);
	delegate void ScanPDFDoneCallBack ([NullAllowed] NSError arg0, [NullAllowed] string arg1);

	// typedef void (^ScanPDFSessionPageCountChangeCallBack)(int);
	delegate void ScanPDFSessionPageCountChangeCallBack (int arg0);

	// @interface PDFScanManager : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface PDFScanManager
	{
		// +(PDFScanManager * _Nonnull)shareManager;
		[Static]
		[Export ("shareManager")]
		//[Verify (MethodToProperty)]
		PDFScanManager ShareManager { get; }

		// @property (copy, nonatomic, class) ScanPDFSaveAsCallBack _Nonnull saveAsCallBack;
		[Static]
		[Export ("saveAsCallBack", ArgumentSemantic.Copy)]
		ScanPDFSaveAsCallBack SaveAsCallBack { get; set; }

		// @property (copy, nonatomic, class) ScanPDFDoneCallBack _Nonnull doneCallBack;
		[Static]
		[Export ("doneCallBack", ArgumentSemantic.Copy)]
		ScanPDFDoneCallBack DoneCallBack { get; set; }

		// @property (copy, nonatomic, class) ScanPDFSessionPageCountChangeCallBack _Nonnull pageCountCallBack;
		[Static]
		[Export ("pageCountCallBack", ArgumentSemantic.Copy)]
		ScanPDFSessionPageCountChangeCallBack PageCountCallBack { get; set; }

		// @property (readonly, nonatomic, strong) PDFScanToolbarManager * _Nonnull toolbarManager;
		[Export ("toolbarManager", ArgumentSemantic.Strong)]
		PDFScanToolbarManager ToolbarManager { get; }

		// @property (readonly, nonatomic, strong) PDFScanMenuViewManager * _Nonnull menuViewManager;
		[Export ("menuViewManager", ArgumentSemantic.Strong)]
		PDFScanMenuViewManager MenuViewManager { get; }

		// +(FSErrorCode)initializeScanner:(unsigned long)serial1 serial2:(unsigned long)serial2;
		[Static]
		[Export ("initializeScanner:serial2:")]
		FSErrorCode InitializeScanner (nuint serial1, nuint serial2);

		// +(FSErrorCode)initializeCompression:(unsigned long)serial1 serial2:(unsigned long)serial2;
		[Static]
		[Export ("initializeCompression:serial2:")]
		FSErrorCode InitializeCompression (nuint serial1, nuint serial2);

		// -(UIViewController * _Nonnull)getPDFScanView;
		[Export ("getPDFScanView")]
		//[Verify (MethodToProperty)]
		UIViewController PDFScanView { get; }

		// -(void)setItemHiddenWithType:(FSScanCameraControllerItemType)itemType hidden:(BOOL)hidden;
		[Export ("setItemHiddenWithType:hidden:")]
		void SetItemHiddenWithType (FSScanCameraControllerItemType itemType, bool hidden);

		// -(void)saveAsPDF:(NSString * _Nonnull)pdfFilePath;
		[Export ("saveAsPDF:")]
		void SaveAsPDF (string pdfFilePath);
	}
}
