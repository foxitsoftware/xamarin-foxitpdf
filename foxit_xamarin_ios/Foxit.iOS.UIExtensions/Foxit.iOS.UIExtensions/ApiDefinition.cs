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
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace Foxit.iOS.UIExtensions
{
	[Static]
	//[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern double uiextensionsDynamicVersionNumber;
		[Field ("uiextensionsDynamicVersionNumber", "__Internal")]
		double uiextensionsDynamicVersionNumber { get; }

		/*
		// extern const unsigned char [] uiextensionsDynamicVersionString;
		[Field ("uiextensionsDynamicVersionString", "__Internal")]
		byte[] uiextensionsDynamicVersionString { get; }
		*/
	}

	// @protocol FSFileSelectDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface FSFileSelectDelegate
	{
		// @required -(void)didFileSelected:(NSString * _Nonnull)filePath;
		[Abstract]
		[Export ("didFileSelected:")]
		void DidFileSelected (string filePath);
	}

	// @interface FSFileListViewController : UIViewController <IDocEventListener>
	[BaseType (typeof(UIViewController))]
	interface FSFileListViewController : IIDocEventListener
	{
		[Wrap ("WeakDelegate")]
		[NullAllowed]
		FSFileSelectDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<FSFileSelectDelegate> _Nullable delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// @property (nonatomic, strong) UIToolbar * _Nonnull topToolbar;
		[Export ("topToolbar", ArgumentSemantic.Strong)]
		UIToolbar TopToolbar { get; set; }
	}

	// @interface SegmentItem : NSObject
	[BaseType (typeof(NSObject))]
	interface SegmentItem
	{
		// @property (nonatomic, strong) NSString * title;
		[Export ("title", ArgumentSemantic.Strong)]
		string Title { get; set; }

		// @property (nonatomic, strong) UIImage * image;
		[Export ("image", ArgumentSemantic.Strong)]
		UIImage Image { get; set; }

		// @property (nonatomic, strong) UIImage * selectImage;
		[Export ("selectImage", ArgumentSemantic.Strong)]
		UIImage SelectImage { get; set; }

		// @property (assign, nonatomic) NSUInteger tag;
		[Export ("tag")]
		nuint Tag { get; set; }

		// @property (nonatomic, strong) UIColor * titleNormalColor;
		[Export ("titleNormalColor", ArgumentSemantic.Strong)]
		UIColor TitleNormalColor { get; set; }

		// @property (nonatomic, strong) UIColor * titleSelectedColor;
		[Export ("titleSelectedColor", ArgumentSemantic.Strong)]
		UIColor TitleSelectedColor { get; set; }

		// @property (readonly, assign, nonatomic) BOOL selected;
		[Export ("selected")]
		bool Selected { get; }
	}

	// @protocol SegmentDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface SegmentDelegate
	{
		// @required -(void)itemClickWithItem:(SegmentItem *)item;
		[Abstract]
		[Export ("itemClickWithItem:")]
		void ItemClickWithItem (SegmentItem item);
	}

	// @interface SegmentView : UIView
	[BaseType (typeof(UIView))]
	interface SegmentView
	{
		[Wrap ("WeakDelegate")]
		SegmentDelegate Delegate { get; set; }

		// @property (assign, nonatomic) id<SegmentDelegate> delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Assign)]
		NSObject WeakDelegate { get; set; }

		// -(id)initWithFrame:(CGRect)frame;
		[Export ("initWithFrame:")]
		IntPtr Constructor (CGRect frame);

		// -(void)loadWithItems:(NSArray<SegmentItem *> *)items;
		[Export ("loadWithItems:")]
		void LoadWithItems (SegmentItem[] items);

		// -(void)setSelectItem:(SegmentItem *)item;
		[Export ("setSelectItem:")]
		void SetSelectItem (SegmentItem item);

		// -(NSArray *)getItems;
		[Export ("getItems")]
		//[Verify (MethodToProperty), Verify (StronglyTypedNSArray)]
		NSObject[] Items { get; }
	}

	// @protocol IPanelSpec <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface IPanelSpec
	{
		// @required -(int)getType;
		[Abstract]
		[Export ("getType")]
		//[Verify (MethodToProperty)]
		int Type { get; }

		// @required -(UIView *)getTopToolbar;
		[Abstract]
		[Export ("getTopToolbar")]
		//[Verify (MethodToProperty)]
		UIView TopToolbar { get; }

		// @required -(UIView *)getContentView;
		[Abstract]
		[Export ("getContentView")]
		//[Verify (MethodToProperty)]
		UIView ContentView { get; }

		// @required -(SegmentItem *)getSegmentItem;
		[Abstract]
		[Export ("getSegmentItem")]
		//[Verify (MethodToProperty)]
		SegmentItem SegmentItem { get; }

		// @required -(void)onActivated;
		[Abstract]
		[Export ("onActivated")]
		void OnActivated ();

		// @required -(void)onDeactivated;
		[Abstract]
		[Export ("onDeactivated")]
		void OnDeactivated ();
	}

	// @interface PanelHost : NSObject <SegmentDelegate>
	[BaseType (typeof(NSObject))]
	interface PanelHost : SegmentDelegate
	{
		// @property (nonatomic, strong) SegmentView * segmentView;
		[Export ("segmentView", ArgumentSemantic.Strong)]
		SegmentView SegmentView { get; set; }

		// @property (nonatomic, strong) NSMutableArray * specs;
		[Export ("specs", ArgumentSemantic.Strong)]
		NSMutableArray Specs { get; set; }

		// @property (nonatomic, strong) id<IPanelSpec> currentSpec;
		[Export ("currentSpec", ArgumentSemantic.Strong)]
		IPanelSpec CurrentSpec { get; set; }

		// @property (nonatomic, strong) UIView * contentView;
		[Export ("contentView", ArgumentSemantic.Strong)]
		UIView ContentView { get; set; }

		// -(instancetype)initWithFrame:(CGSize)size;
		[Export ("initWithFrame:")]
		IntPtr Constructor (CGSize size);

		// -(void)addSpec:(id<IPanelSpec>)spec;
		[Export ("addSpec:")]
		void AddSpec (IPanelSpec spec);

		// -(void)insertSpec:(id<IPanelSpec>)spec atIndex:(int)index;
		[Export ("insertSpec:atIndex:")]
		void InsertSpec (IPanelSpec spec, int index);

		// -(void)removeSpec:(id<IPanelSpec>)spec;
		[Export ("removeSpec:")]
		void RemoveSpec (IPanelSpec spec);

		// -(void)reloadSegmentView;
		[Export ("reloadSegmentView")]
		void ReloadSegmentView ();
	}

	// @protocol IPanelChangedListener <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface IPanelChangedListener
	{
		// @required -(void)onPanelChanged:(BOOL)isHidden;
		[Abstract]
		[Export ("onPanelChanged:")]
		void OnPanelChanged (bool isHidden);
	}

	// @interface FSPanelController : NSObject
	[BaseType (typeof(NSObject))]
	interface FSPanelController
	{
		// @property (nonatomic, strong) PanelHost * panel;
		[Export ("panel", ArgumentSemantic.Strong)]
		PanelHost Panel { get; set; }

		// @property (assign, nonatomic) BOOL isHidden;
		[Export ("isHidden")]
		bool IsHidden { get; set; }

		// -(instancetype)initWithExtensionsManager:(UIExtensionsManager *)extensionsManager;
		[Export ("initWithExtensionsManager:")]
		IntPtr Constructor (UIExtensionsManager extensionsManager);

		// -(NSMutableDictionary *)getItemHiddenStatus;
		[Export ("getItemHiddenStatus")]
		//[Verify (MethodToProperty)]
		NSMutableDictionary ItemHiddenStatus { get; }

		// -(id<IPanelSpec>)getPanel:(FSPanelType)type;
		[Export ("getPanel:")]
		IPanelSpec GetPanel (FSPanelType type);

		// -(BOOL)isPanelHidden:(FSPanelType)type;
		[Export ("isPanelHidden:")]
		bool IsPanelHidden (FSPanelType type);

		// -(void)setPanelHidden:(BOOL)isHidden type:(FSPanelType)type;
		[Export ("setPanelHidden:type:")]
		void SetPanelHidden (bool isHidden, FSPanelType type);

		// -(void)registerPanelChangedListener:(id<IPanelChangedListener>)listener;
		[Export ("registerPanelChangedListener:")]
		void RegisterPanelChangedListener (IPanelChangedListener listener);

		// -(void)unregisterPanelChangedListener:(id<IPanelChangedListener>)listener;
		[Export ("unregisterPanelChangedListener:")]
		void UnregisterPanelChangedListener (IPanelChangedListener listener);
	}

	// @protocol IAppLifecycleListener <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface IAppLifecycleListener
	{
		// @optional -(void)applicationWillResignActive:(UIApplication *)application;
		[Export ("applicationWillResignActive:")]
		void ApplicationWillResignActive (UIApplication application);

		// @optional -(void)applicationDidEnterBackground:(UIApplication *)application;
		[Export ("applicationDidEnterBackground:")]
		void ApplicationDidEnterBackground (UIApplication application);

		// @optional -(void)applicationWillEnterForeground:(UIApplication *)application;
		[Export ("applicationWillEnterForeground:")]
		void ApplicationWillEnterForeground (UIApplication application);

		// @optional -(void)applicationDidBecomeActive:(UIApplication *)application;
		[Export ("applicationDidBecomeActive:")]
		void ApplicationDidBecomeActive (UIApplication application);
	}

	// @protocol SettingBarDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface SettingBarDelegate
	{
		// @optional -(void)settingBarSinglePageLayout:(SettingBar *)settingBar;
		[Export ("settingBarSinglePageLayout:")]
		void SettingBarSinglePageLayout (SettingBar settingBar);

		// @optional -(void)settingBarContinuousLayout:(SettingBar *)settingBar;
		[Export ("settingBarContinuousLayout:")]
		void SettingBarContinuousLayout (SettingBar settingBar);

		// @optional -(void)settingBarDoublePageLayout:(SettingBar *)settingBar;
		[Export ("settingBarDoublePageLayout:")]
		void SettingBarDoublePageLayout (SettingBar settingBar);

		// @optional -(void)settingBarCoverPageLayout:(SettingBar *)settingBar;
		[Export ("settingBarCoverPageLayout:")]
		void SettingBarCoverPageLayout (SettingBar settingBar);

		// @optional -(void)settingBarThumbnail:(SettingBar *)settingBar;
		[Export ("settingBarThumbnail:")]
		void SettingBarThumbnail (SettingBar settingBar);

		// @optional -(void)settingBarReflow:(SettingBar *)settingBar;
		[Export ("settingBarReflow:")]
		void SettingBarReflow (SettingBar settingBar);

		// @optional -(void)settingBarCrop:(SettingBar *)settingBar;
		[Export ("settingBarCrop:")]
		void SettingBarCrop (SettingBar settingBar);

		// @optional -(void)settingBarPanAndZoom:(SettingBar *)settingBar;
		[Export ("settingBarPanAndZoom:")]
		void SettingBarPanAndZoom (SettingBar settingBar);

		// @optional -(void)settingBar:(SettingBar *)settingBar setLockScreen:(BOOL)isLockScreen;
		[Export ("settingBar:setLockScreen:")]
		void SettingBar (SettingBar settingBar, bool isLockScreen);

		// @optional -(void)settingBar:(SettingBar *)settingBar setNightMode:(BOOL)isNightMode;
		[Export ("settingBar:setNightMode:")]
		void SettingBarSetNightMode (SettingBar settingBar, bool isNightMode);

		// @optional -(void)settingBarFitPage:(SettingBar *)settingBar;
		[Export ("settingBarFitPage:")]
		void SettingBarFitPage (SettingBar settingBar);

		// @optional -(void)settingBarFitWidth:(SettingBar *)settingBar;
		[Export ("settingBarFitWidth:")]
		void SettingBarFitWidth (SettingBar settingBar);

		// @optional -(void)settingBarRotate:(SettingBar *)settingBar;
		[Export ("settingBarRotate:")]
		void SettingBarRotate (SettingBar settingBar);

		// @optional -(void)settingBarDidChangeSize:(SettingBar *)settingBar;
		[Export ("settingBarDidChangeSize:")]
		void SettingBarDidChangeSize (SettingBar settingBar);
	}

	// @interface SettingBar : NSObject <IAppLifecycleListener>
	[BaseType (typeof(NSObject))]
	interface SettingBar : IAppLifecycleListener
	{
		// @property (nonatomic, strong) UIView * contentView;
		[Export ("contentView", ArgumentSemantic.Strong)]
		UIView ContentView { get; set; }

		[Wrap ("WeakDelegate")]
		SettingBarDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<SettingBarDelegate> delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// -(NSMutableDictionary *)getItemHiddenStatus;
		[Export ("getItemHiddenStatus")]
		//[Verify (MethodToProperty)]
		NSMutableDictionary ItemHiddenStatus { get; }

		// -(BOOL)isItemHidden:(SettingItemType)type;
		[Export ("isItemHidden:")]
		bool IsItemHidden (SettingItemType type);

		// -(void)setItem:(SettingItemType)itemType hidden:(BOOL)hidden;
		[Export ("setItem:hidden:")]
		void SetItem (SettingItemType itemType, bool hidden);

		// -(void)updateBtnLayout;
		[Export ("updateBtnLayout")]
		void UpdateBtnLayout ();
	}

	// typedef void (^CancelCallback)();
	delegate void CancelCallback ();

	// @protocol MoreMenuItemAction <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface MoreMenuItemAction
	{
		// @required -(void)onClick:(MoreMenuItem *)item;
		[Abstract]
		[Export ("onClick:")]
		void OnClick (MoreMenuItem item);
	}

	// @interface MoreMenuItem : NSObject
	[BaseType (typeof(NSObject))]
	interface MoreMenuItem
	{
		// @property (assign, nonatomic) NSUInteger tag;
		[Export ("tag")]
		nuint Tag { get; set; }

		// @property (nonatomic, strong) NSString * text;
		[Export ("text", ArgumentSemantic.Strong)]
		string Text { get; set; }

		// @property (assign, nonatomic) NSInteger iconId;
		[Export ("iconId")]
		nint IconId { get; set; }

		// @property (assign, nonatomic) BOOL enable;
		[Export ("enable")]
		bool Enable { get; set; }

		// @property (nonatomic, weak) id<MoreMenuItemAction> callBack;
		[Export ("callBack", ArgumentSemantic.Weak)]
		MoreMenuItemAction CallBack { get; set; }

		// @property (nonatomic, strong) UIView * customView;
		[Export ("customView", ArgumentSemantic.Strong)]
		UIView CustomView { get; set; }
	}

	// @interface MoreMenuGroup : NSObject
	[BaseType (typeof(NSObject))]
	interface MoreMenuGroup
	{
		// @property (assign, nonatomic) NSUInteger tag;
		[Export ("tag")]
		nuint Tag { get; set; }

		// @property (nonatomic, strong) NSString * title;
		[Export ("title", ArgumentSemantic.Strong)]
		string Title { get; set; }

		// -(NSMutableArray *)getItems;
		[Export ("getItems")]
		//[Verify (MethodToProperty)]
		NSMutableArray Items { get; }

		// -(void)setItems:(NSMutableArray *)arr;
		[Export ("setItems:")]
		void SetItems (NSMutableArray arr);
	}

	// @interface MoreMenuView : NSObject
	[BaseType (typeof(NSObject))]
	interface MoreMenuView
	{
		// @property (copy, nonatomic) CancelCallback onCancelClicked;
		[Export ("onCancelClicked", ArgumentSemantic.Copy)]
		CancelCallback OnCancelClicked { get; set; }

		// -(void)addGroup:(MoreMenuGroup *)group;
		[Export ("addGroup:")]
		void AddGroup (MoreMenuGroup group);

		// -(void)removeGroup:(NSUInteger)tag;
		[Export ("removeGroup:")]
		void RemoveGroup (nuint tag);

		// -(MoreMenuGroup *)getGroup:(NSUInteger)tag;
		[Export ("getGroup:")]
		MoreMenuGroup GetGroup (nuint tag);

		// -(void)addMenuItem:(NSUInteger)groupTag withItem:(MoreMenuItem *)item;
		[Export ("addMenuItem:withItem:")]
		void AddMenuItem (nuint groupTag, MoreMenuItem item);

		// -(void)removeMenuItem:(NSUInteger)groupTag WithItemTag:(NSUInteger)itemTag;
		[Export ("removeMenuItem:WithItemTag:")]
		void RemoveMenuItem (nuint groupTag, nuint itemTag);

		// -(UIView *)getContentView;
		[Export ("getContentView")]
		//[Verify (MethodToProperty)]
		UIView ContentView { get; }

		// -(void)setMenuTitle:(NSString *)title;
		[Export ("setMenuTitle:")]
		void SetMenuTitle (string title);

		// -(void)reloadData;
		[Export ("reloadData")]
		void ReloadData ();

		// -(void)setMoreViewItemHiddenWithGroup:(NSUInteger)groupTag hidden:(BOOL)isHidden;
		[Export ("setMoreViewItemHiddenWithGroup:hidden:")]
		void SetMoreViewItemHiddenWithGroup (nuint groupTag, bool isHidden);

		// -(void)setMoreViewItemHiddenWithGroup:(NSUInteger)groupTag andItemTag:(NSUInteger)itemTag hidden:(BOOL)isHidden;
		[Export ("setMoreViewItemHiddenWithGroup:andItemTag:hidden:")]
		void SetMoreViewItemHiddenWithGroup (nuint groupTag, nuint itemTag, bool isHidden);
	}

	// @protocol IAnnotEventListener <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface IAnnotEventListener
	{
		// @optional -(void)onAnnotAdded:(FSPDFPage * _Nonnull)page annot:(FSAnnot * _Nonnull)annot;
		[Export ("onAnnotAdded:annot:")]
		void OnAnnotAdded (FSPDFPage page, FSAnnot annot);

		// @optional -(void)onAnnotWillDelete:(FSPDFPage * _Nonnull)page annot:(FSAnnot * _Nonnull)annot;
		[Export ("onAnnotWillDelete:annot:")]
		void OnAnnotWillDelete (FSPDFPage page, FSAnnot annot);

		// @optional -(void)onAnnotDeleted:(FSPDFPage * _Nonnull)page annot:(FSAnnot * _Nonnull)annot;
		[Export ("onAnnotDeleted:annot:")]
		void OnAnnotDeleted (FSPDFPage page, FSAnnot annot);

		// @optional -(void)onAnnotModified:(FSPDFPage * _Nonnull)page annot:(FSAnnot * _Nonnull)annot;
		[Export ("onAnnotModified:annot:")]
		void OnAnnotModified (FSPDFPage page, FSAnnot annot);

		// @optional -(void)onAnnotSelected:(FSPDFPage * _Nonnull)page annot:(FSAnnot * _Nonnull)annot;
		[Export ("onAnnotSelected:annot:")]
		void OnAnnotSelected (FSPDFPage page, FSAnnot annot);

		// @optional -(void)onAnnotDeselected:(FSPDFPage * _Nonnull)page annot:(FSAnnot * _Nonnull)annot;
		[Export ("onAnnotDeselected:annot:")]
		void OnAnnotDeselected (FSPDFPage page, FSAnnot annot);
	}

	// @protocol IToolEventListener <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface IToolEventListener
	{
		// @required -(void)onToolChanged:(NSString * _Nonnull)lastToolName CurrentToolName:(NSString * _Nonnull)toolName;
		[Abstract]
		[Export ("onToolChanged:CurrentToolName:")]
		void CurrentToolName (string lastToolName, string toolName);
	}

	// @protocol ISearchEventListener <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface ISearchEventListener
	{
		// @optional -(void)onSearchStarted;
		[Export ("onSearchStarted")]
		void OnSearchStarted ();

		// @optional -(void)onSearchCanceled;
		[Export ("onSearchCanceled")]
		void OnSearchCanceled ();
	}

	// @protocol IToolHandler <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface IToolHandler
	{
		// @required @property (assign, nonatomic) FSAnnotType type;
		[Abstract]
		[Export ("type", ArgumentSemantic.Assign)]
		FSAnnotType Type { get; set; }

		// @required -(NSString * _Nonnull)getName;
		[Abstract]
		[Export ("getName")]
		//[Verify (MethodToProperty)]
		string Name { get; }

		// @required -(BOOL)isEnabled;
		[Abstract]
		[Export ("isEnabled")]
		//[Verify (MethodToProperty)]
		bool IsEnabled { get; }

		// @required -(void)onActivate;
		[Abstract]
		[Export ("onActivate")]
		void OnActivate ();

		// @required -(void)onDeactivate;
		[Abstract]
		[Export ("onDeactivate")]
		void OnDeactivate ();

		// @required -(BOOL)onPageViewLongPress:(int)pageIndex recognizer:(UILongPressGestureRecognizer * _Nonnull)recognizer;
		[Abstract]
		[Export ("onPageViewLongPress:recognizer:")]
		bool OnPageViewLongPress (int pageIndex, UILongPressGestureRecognizer recognizer);

		// @required -(BOOL)onPageViewTap:(int)pageIndex recognizer:(UITapGestureRecognizer * _Nullable)recognizer;
		[Abstract]
		[Export ("onPageViewTap:recognizer:")]
		bool OnPageViewTap (int pageIndex, [NullAllowed] UITapGestureRecognizer recognizer);

		// @required -(BOOL)onPageViewPan:(int)pageIndex recognizer:(UIPanGestureRecognizer * _Nonnull)recognizer;
		[Abstract]
		[Export ("onPageViewPan:recognizer:")]
		bool OnPageViewPan (int pageIndex, UIPanGestureRecognizer recognizer);

		// @required -(BOOL)onPageViewShouldBegin:(int)pageIndex recognizer:(UIGestureRecognizer * _Nonnull)gestureRecognizer;
		[Abstract]
		[Export ("onPageViewShouldBegin:recognizer:")]
		bool OnPageViewShouldBegin (int pageIndex, UIGestureRecognizer gestureRecognizer);

		// @required -(BOOL)onPageViewTouchesBegan:(int)pageIndex touches:(NSSet * _Nonnull)touches withEvent:(UIEvent * _Nonnull)event;
		[Abstract]
		[Export ("onPageViewTouchesBegan:touches:withEvent:")]
		bool OnPageViewTouchesBegan (int pageIndex, NSSet touches, UIEvent @event);

		// @required -(BOOL)onPageViewTouchesMoved:(int)pageIndex touches:(NSSet * _Nonnull)touches withEvent:(UIEvent * _Nonnull)event;
		[Abstract]
		[Export ("onPageViewTouchesMoved:touches:withEvent:")]
		bool OnPageViewTouchesMoved (int pageIndex, NSSet touches, UIEvent @event);

		// @required -(BOOL)onPageViewTouchesEnded:(int)pageIndex touches:(NSSet * _Nonnull)touches withEvent:(UIEvent * _Nonnull)event;
		[Abstract]
		[Export ("onPageViewTouchesEnded:touches:withEvent:")]
		bool OnPageViewTouchesEnded (int pageIndex, NSSet touches, UIEvent @event);

		// @required -(BOOL)onPageViewTouchesCancelled:(int)pageIndex touches:(NSSet * _Nonnull)touches withEvent:(UIEvent * _Nonnull)event;
		[Abstract]
		[Export ("onPageViewTouchesCancelled:touches:withEvent:")]
		bool OnPageViewTouchesCancelled (int pageIndex, NSSet touches, UIEvent @event);

		// @optional -(void)onDraw:(int)pageIndex inContext:(CGContextRef _Nonnull)context;
		[Export ("onDraw:inContext:")]
		unsafe void OnDraw (int pageIndex, IntPtr context);
	}

	// @protocol IAnnotHandler <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface IAnnotHandler
	{
		// @required -(BOOL)isHitAnnot:(FSAnnot * _Nonnull)annot point:(FSPointF * _Nonnull)point;
		[Abstract]
		[Export ("isHitAnnot:point:")]
		bool IsHitAnnot (FSAnnot annot, FSPointF point);

		// @required -(void)onAnnotSelected:(FSAnnot * _Nonnull)annot;
		[Abstract]
		[Export ("onAnnotSelected:")]
		void OnAnnotSelected (FSAnnot annot);

		// @required -(void)onAnnotDeselected:(FSAnnot * _Nonnull)annot;
		[Abstract]
		[Export ("onAnnotDeselected:")]
		void OnAnnotDeselected (FSAnnot annot);

		// @optional -(BOOL)addAnnot:(FSAnnot * _Nonnull)annot;
		[Export ("addAnnot:")]
		bool AddAnnot (FSAnnot annot);

		// @optional -(BOOL)addAnnot:(FSAnnot * _Nonnull)annot addUndo:(BOOL)addUndo;
		[Export ("addAnnot:addUndo:")]
		bool AddAnnot (FSAnnot annot, bool addUndo);

		// @optional -(BOOL)modifyAnnot:(FSAnnot * _Nonnull)annot;
		[Export ("modifyAnnot:")]
		bool ModifyAnnot (FSAnnot annot);

		// @optional -(BOOL)modifyAnnot:(FSAnnot * _Nonnull)annot addUndo:(BOOL)addUndo;
		[Export ("modifyAnnot:addUndo:")]
		bool ModifyAnnot (FSAnnot annot, bool addUndo);

		// @optional -(BOOL)removeAnnot:(FSAnnot * _Nonnull)annot;
		[Export ("removeAnnot:")]
		bool RemoveAnnot (FSAnnot annot);

		// @optional -(BOOL)removeAnnot:(FSAnnot * _Nonnull)annot addUndo:(BOOL)addUndo;
		[Export ("removeAnnot:addUndo:")]
		bool RemoveAnnot (FSAnnot annot, bool addUndo);

		// @optional -(BOOL)onPageViewLongPress:(int)pageIndex recognizer:(UILongPressGestureRecognizer * _Nonnull)recognizer annot:(FSAnnot * _Nullable)annot;
		[Export ("onPageViewLongPress:recognizer:annot:")]
		bool OnPageViewLongPress (int pageIndex, UILongPressGestureRecognizer recognizer, [NullAllowed] FSAnnot annot);

		// @optional -(BOOL)onPageViewTap:(int)pageIndex recognizer:(UITapGestureRecognizer * _Nonnull)recognizer annot:(FSAnnot * _Nullable)annot;
		[Export ("onPageViewTap:recognizer:annot:")]
		bool OnPageViewTap (int pageIndex, UITapGestureRecognizer recognizer, [NullAllowed] FSAnnot annot);

		// @optional -(BOOL)onPageViewPan:(int)pageIndex recognizer:(UIPanGestureRecognizer * _Nonnull)recognizer annot:(FSAnnot * _Nonnull)annot;
		[Export ("onPageViewPan:recognizer:annot:")]
		bool OnPageViewPan (int pageIndex, UIPanGestureRecognizer recognizer, FSAnnot annot);

		// @optional -(BOOL)onPageViewShouldBegin:(int)pageIndex recognizer:(UIGestureRecognizer * _Nonnull)gestureRecognizer annot:(FSAnnot * _Nullable)annot;
		[Export ("onPageViewShouldBegin:recognizer:annot:")]
		bool OnPageViewShouldBegin (int pageIndex, UIGestureRecognizer gestureRecognizer, [NullAllowed] FSAnnot annot);

		// @optional -(BOOL)onPageViewTouchesBegan:(int)pageIndex touches:(NSSet * _Nonnull)touches withEvent:(UIEvent * _Nonnull)event annot:(FSAnnot * _Nonnull)annot;
		[Export ("onPageViewTouchesBegan:touches:withEvent:annot:")]
		bool OnPageViewTouchesBegan (int pageIndex, NSSet touches, UIEvent @event, FSAnnot annot);

		// @optional -(BOOL)onPageViewTouchesMoved:(int)pageIndex touches:(NSSet * _Nonnull)touches withEvent:(UIEvent * _Nonnull)event annot:(FSAnnot * _Nonnull)annot;
		[Export ("onPageViewTouchesMoved:touches:withEvent:annot:")]
		bool OnPageViewTouchesMoved (int pageIndex, NSSet touches, UIEvent @event, FSAnnot annot);

		// @optional -(BOOL)onPageViewTouchesEnded:(int)pageIndex touches:(NSSet * _Nonnull)touches withEvent:(UIEvent * _Nonnull)event annot:(FSAnnot * _Nonnull)annot;
		[Export ("onPageViewTouchesEnded:touches:withEvent:annot:")]
		bool OnPageViewTouchesEnded (int pageIndex, NSSet touches, UIEvent @event, FSAnnot annot);

		// @optional -(BOOL)onPageViewTouchesCancelled:(int)pageIndex touches:(NSSet * _Nonnull)touches withEvent:(UIEvent * _Nonnull)event annot:(FSAnnot * _Nonnull)annot;
		[Export ("onPageViewTouchesCancelled:touches:withEvent:annot:")]
		bool OnPageViewTouchesCancelled (int pageIndex, NSSet touches, UIEvent @event, FSAnnot annot);

		// @optional -(FSAnnotType)getType;
		[Export ("getType")]
		//[Verify (MethodToProperty)]
		FSAnnotType Type { get; }

		// @optional -(NSString * _Nonnull)getName;
		[Export ("getName")]
		//[Verify (MethodToProperty)]
		string Name { get; }

		// @optional -(void)onDraw:(int)pageIndex inContext:(CGContextRef _Nonnull)context annot:(FSAnnot * _Nullable)annot;
		[Export ("onDraw:inContext:annot:")]
		unsafe void OnDraw (int pageIndex, IntPtr context, [NullAllowed] FSAnnot annot);

		// @optional -(void)onAnnotChanged:(FSAnnot * _Nonnull)annot property:(long)property from:(NSValue * _Nonnull)oldValue to:(NSValue * _Nonnull)newValue;
		[Export ("onAnnotChanged:property:from:to:")]
		void OnAnnotChanged (FSAnnot annot, nint property, NSValue oldValue, NSValue newValue);

		// @optional -(BOOL)shouldDrawAnnot:(FSAnnot * _Nonnull)annot inPDFViewCtrl:(FSPDFViewCtrl * _Nonnull)pdfViewCtrl;
		[Export ("shouldDrawAnnot:inPDFViewCtrl:")]
		bool ShouldDrawAnnot (FSAnnot annot, FSPDFViewCtrl pdfViewCtrl);

		// @optional -(void)onXFAWidgetSelected:(FSXFAWidget * _Nonnull)widget;
		[Export ("onXFAWidgetSelected:")]
		void OnXFAWidgetSelected (FSXFAWidget widget);

		// @optional -(void)onXFAWidgetDeselected:(FSXFAWidget * _Nonnull)widget;
		[Export ("onXFAWidgetDeselected:")]
		void OnXFAWidgetDeselected (FSXFAWidget widget);

		// @optional -(BOOL)onPageViewTap:(int)pageIndex recognizer:(UITapGestureRecognizer * _Nonnull)recognizer widget:(FSXFAWidget * _Nullable)widget;
		[Export ("onPageViewTap:recognizer:widget:")]
		bool OnPageViewTap (int pageIndex, UITapGestureRecognizer recognizer, [NullAllowed] FSXFAWidget widget);

		// @optional -(BOOL)onPageViewShouldBegin:(int)pageIndex recognizer:(UIGestureRecognizer * _Nonnull)gestureRecognizer widget:(FSXFAWidget * _Nullable)widget;
		[Export ("onPageViewShouldBegin:recognizer:widget:")]
		bool OnPageViewShouldBegin (int pageIndex, UIGestureRecognizer gestureRecognizer, [NullAllowed] FSXFAWidget widget);

		// @optional -(BOOL)onPageViewTouchesBegan:(int)pageIndex touches:(NSSet * _Nonnull)touches withEvent:(UIEvent * _Nonnull)event widget:(FSXFAWidget * _Nullable)widget;
		[Export ("onPageViewTouchesBegan:touches:withEvent:widget:")]
		bool OnPageViewTouchesBegan (int pageIndex, NSSet touches, UIEvent @event, [NullAllowed] FSXFAWidget widget);

		// @optional -(BOOL)onPageViewTouchesMoved:(int)pageIndex touches:(NSSet * _Nonnull)touches withEvent:(UIEvent * _Nonnull)event widget:(FSXFAWidget * _Nullable)widget;
		[Export ("onPageViewTouchesMoved:touches:withEvent:widget:")]
		bool OnPageViewTouchesMoved (int pageIndex, NSSet touches, UIEvent @event, [NullAllowed] FSXFAWidget widget);

		// @optional -(BOOL)onPageViewTouchesEnded:(int)pageIndex touches:(NSSet * _Nonnull)touches withEvent:(UIEvent * _Nonnull)event widget:(FSXFAWidget * _Nullable)widget;
		[Export ("onPageViewTouchesEnded:touches:withEvent:widget:")]
		bool OnPageViewTouchesEnded (int pageIndex, NSSet touches, UIEvent @event, [NullAllowed] FSXFAWidget widget);

		// @optional -(void)onDraw:(int)pageIndex inContext:(CGContextRef _Nonnull)context widget:(FSXFAWidget * _Nullable)widget;
		[Export ("onDraw:inContext:widget:")]
		unsafe void OnDraw (int pageIndex, IntPtr context, [NullAllowed] FSXFAWidget widget);
	}

	// @protocol IFullScreenListener <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface IFullScreenListener
	{
		// @required -(void)onFullScreen:(BOOL)isFullScreen;
		[Abstract]
		[Export ("onFullScreen:")]
		void OnFullScreen (bool isFullScreen);
	}

	// @protocol IPageNumberListener <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface IPageNumberListener
	{
		// @required -(void)updatePageNumber;
		[Abstract]
		[Export ("updatePageNumber")]
		void UpdatePageNumber ();
	}

	// @protocol ILinkEventListener <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface ILinkEventListener
	{
		// @optional -(BOOL)onLinkOpen:(id _Nonnull)link LocationInfo:(CGPoint)pointParam;
		[Export ("onLinkOpen:LocationInfo:")]
		bool LocationInfo (NSObject link, CGPoint pointParam);
	}

	// @protocol UIExtensionsManagerDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface UIExtensionsManagerDelegate
	{
		// @optional -(void)uiextensionsManager:(UIExtensionsManager * _Nonnull)uiextensionsManager onToolBar:(FSToolbarType)type hidden:(BOOL)hidden;
		[Export ("uiextensionsManager:onToolBar:hidden:")]
		void UiextensionsManager (UIExtensionsManager uiextensionsManager, FSToolbarType type, bool hidden);

		// @optional -(BOOL)uiextensionsManager:(UIExtensionsManager * _Nonnull)uiextensionsManager openNewDocAtPath:(NSString * _Nonnull)path shouldCloseCurrentDoc:(BOOL)closeCurrentDoc;
		[Export ("uiextensionsManager:openNewDocAtPath:shouldCloseCurrentDoc:")]
		bool UiextensionsManager (UIExtensionsManager uiextensionsManager, string path, bool closeCurrentDoc);

		// @optional -(void)quitUIExtensionsManager:(UIExtensionsManager * _Nonnull)uiextensionsManager button:(UIButton * _Nonnull)button;
		[Export ("quitUIExtensionsManager:button:")]
		void QuitUIExtensionsManager (UIExtensionsManager uiextensionsManager, UIButton button);
	}

	// @interface UIExtensionsManager : NSObject <FSPDFUIExtensionsManager, IDocEventListener, IPageEventListener, IRotationEventListener, IAnnotEventListener, IRecoveryEventListener, ILinkEventListener, UIToolbarDelegate>
	[BaseType (typeof(NSObject))]
	interface UIExtensionsManager : IFSPDFUIExtensionsManager, IIDocEventListener, IIPageEventListener, IIRotationEventListener, IAnnotEventListener, IIRecoveryEventListener, ILinkEventListener, IUIToolbarDelegate
	{
		// @property (readonly, nonatomic, strong) FSPDFViewCtrl * _Nonnull pdfViewCtrl;
		[Export ("pdfViewCtrl", ArgumentSemantic.Strong)]
		FSPDFViewCtrl PdfViewCtrl { get; }

		// @property (readonly, nonatomic, strong) MoreMenuView * _Nonnull more;
		[Export ("more", ArgumentSemantic.Strong)]
		MoreMenuView More { get; }

		[Wrap ("WeakDelegate")]
		[NullAllowed]
		UIExtensionsManagerDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<UIExtensionsManagerDelegate> _Nullable delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// @property (nonatomic, strong) id<IToolHandler> _Nullable currentToolHandler;
		[NullAllowed, Export ("currentToolHandler", ArgumentSemantic.Strong)]
		IToolHandler CurrentToolHandler { get; set; }

		// @property (nonatomic, strong) FSAnnot * _Nullable currentAnnot;
		[NullAllowed, Export ("currentAnnot", ArgumentSemantic.Strong)]
		FSAnnot CurrentAnnot { get; set; }

		// @property (assign, nonatomic) BOOL enableLinks;
		[Export ("enableLinks")]
		bool EnableLinks { get; set; }

		// @property (assign, nonatomic) BOOL enableHighlightLinks;
		[Export ("enableHighlightLinks")]
		bool EnableHighlightLinks { get; set; }

		// @property (nonatomic, strong) UIColor * _Nonnull linksHighlightColor;
		[Export ("linksHighlightColor", ArgumentSemantic.Strong)]
		UIColor LinksHighlightColor { get; set; }

		// @property (nonatomic, strong) UIColor * _Nonnull selectionHighlightColor;
		[Export ("selectionHighlightColor", ArgumentSemantic.Strong)]
		UIColor SelectionHighlightColor { get; set; }

		// @property (copy, nonatomic) void (^ _Nullable)(void) goBack;
		[NullAllowed, Export ("goBack", ArgumentSemantic.Copy)]
		Action GoBack { get; set; }

		// @property (nonatomic, strong) UIToolbar * _Nullable topToolbar;
		[NullAllowed, Export ("topToolbar", ArgumentSemantic.Strong)]
		UIToolbar TopToolbar { get; set; }

		// @property (nonatomic, strong) UIToolbar * _Nullable bottomToolbar;
		[NullAllowed, Export ("bottomToolbar", ArgumentSemantic.Strong)]
		UIToolbar BottomToolbar { get; set; }

		// @property (nonatomic, strong) FSPanelController * _Nonnull panelController;
		[Export ("panelController", ArgumentSemantic.Strong)]
		FSPanelController PanelController { get; set; }

		// @property (nonatomic, strong) SettingBar * _Nonnull settingBar;
		[Export ("settingBar", ArgumentSemantic.Strong)]
		SettingBar SettingBar { get; set; }

		// @property (assign, nonatomic) BOOL continueAddAnnot;
		[Export ("continueAddAnnot")]
		bool ContinueAddAnnot { get; set; }

		// @property (assign, nonatomic) BOOL isFullScreen;
		[Export ("isFullScreen")]
		bool IsFullScreen { get; set; }

		// @property (assign, nonatomic) BOOL isScreenLocked;
		[Export ("isScreenLocked")]
		bool IsScreenLocked { get; set; }

		// @property (assign, nonatomic) BOOL needScreenLock;
		[Export ("needScreenLock")]
		bool NeedScreenLock { get; set; }

		// @property (nonatomic, strong) NSString * _Nonnull preventOverrideFilePath;
		[Export ("preventOverrideFilePath", ArgumentSemantic.Strong)]
		string PreventOverrideFilePath { get; set; }

		// @property (assign, nonatomic) BOOL isDocModified;
		[Export ("isDocModified")]
		bool IsDocModified { get; set; }

		// @property (assign, nonatomic) BOOL isMultiFileMode;
		[Export ("isMultiFileMode")]
		bool IsMultiFileMode { get; set; }

		// @property (assign, nonatomic) FSPDFDocSaveFlags docSaveFlag;
		[Export ("docSaveFlag", ArgumentSemantic.Assign)]
		FSPDFDocSaveFlags DocSaveFlag { get; set; }

		// @property (nonatomic, strong) id<FSActionCallback> _Nonnull actionHandler;
		[Export ("actionHandler", ArgumentSemantic.Strong)]
		FSActionCallback ActionHandler { get; set; }

		// @property (nonatomic, strong) FSXFAWidget * _Nullable currentWidget;
		[NullAllowed, Export ("currentWidget", ArgumentSemantic.Strong)]
		FSXFAWidget CurrentWidget { get; set; }

		// -(id _Nonnull)initWithPDFViewControl:(FSPDFViewCtrl * _Nonnull)viewctrl;
		[Export ("initWithPDFViewControl:")]
		IntPtr Constructor (FSPDFViewCtrl viewctrl);

		// -(id _Nonnull)initWithPDFViewControl:(FSPDFViewCtrl * _Nonnull)viewctrl configuration:(NSData * _Nullable)jsonConfigData;
		[Export ("initWithPDFViewControl:configuration:")]
		IntPtr Constructor (FSPDFViewCtrl viewctrl, [NullAllowed] NSData jsonConfigData);

		// -(id _Nonnull)initWithPDFViewControl:(FSPDFViewCtrl * _Nonnull)viewctrl configurationObject:(UIExtensionsConfig * _Nonnull)configuration;
		[Export ("initWithPDFViewControl:configurationObject:")]
		IntPtr Constructor (FSPDFViewCtrl viewctrl, UIExtensionsConfig configuration);

		// -(void)registerFullScreenListener:(id<IFullScreenListener> _Nonnull)listener;
		[Export ("registerFullScreenListener:")]
		void RegisterFullScreenListener (IFullScreenListener listener);

		// -(void)unregisterFullScreenListener:(id<IFullScreenListener> _Nonnull)listener;
		[Export ("unregisterFullScreenListener:")]
		void UnregisterFullScreenListener (IFullScreenListener listener);

		// -(void)registerPageNumberListener:(id<IPageNumberListener> _Nonnull)listener;
		[Export ("registerPageNumberListener:")]
		void RegisterPageNumberListener (IPageNumberListener listener);

		// -(void)unregisterPageNumerListener:(id<IPageNumberListener> _Nonnull)listener;
		[Export ("unregisterPageNumerListener:")]
		void UnregisterPageNumerListener (IPageNumberListener listener);

		// -(void)registerRotateChangedListener:(id<IRotationEventListener> _Nonnull)listener;
		[Export ("registerRotateChangedListener:")]
		void RegisterRotateChangedListener (IRotationEventListener listener);

		// -(void)unregisterRotateChangedListener:(id<IRotationEventListener> _Nonnull)listener;
		[Export ("unregisterRotateChangedListener:")]
		void UnregisterRotateChangedListener (IRotationEventListener listener);

		// -(void)enableTopToolbar:(BOOL)isEnabled;
		[Export ("enableTopToolbar:")]
		void EnableTopToolbar (bool isEnabled);

		// -(void)enableBottomToolbar:(BOOL)isEnabled;
		[Export ("enableBottomToolbar:")]
		void EnableBottomToolbar (bool isEnabled);

		// -(id<IToolHandler> _Nonnull)getToolHandlerByName:(NSString * _Nonnull)name;
		[Export ("getToolHandlerByName:")]
		IToolHandler GetToolHandlerByName (string name);

		// -(id<IAnnotHandler> _Nonnull)getAnnotHandlerByType:(FSAnnotType)type;
		[Export ("getAnnotHandlerByType:")]
		IAnnotHandler GetAnnotHandlerByType (FSAnnotType type);

		// -(void)registerToolHandler:(id<IToolHandler> _Nonnull)toolHandler;
		[Export ("registerToolHandler:")]
		void RegisterToolHandler (IToolHandler toolHandler);

		// -(void)unregisterToolHandler:(id<IToolHandler> _Nonnull)toolHandler;
		[Export ("unregisterToolHandler:")]
		void UnregisterToolHandler (IToolHandler toolHandler);

		// -(void)registerAnnotHandler:(id<IAnnotHandler> _Nonnull)annotHandler;
		[Export ("registerAnnotHandler:")]
		void RegisterAnnotHandler (IAnnotHandler annotHandler);

		// -(void)unregisterAnnotHandler:(id<IAnnotHandler> _Nonnull)annotHandler;
		[Export ("unregisterAnnotHandler:")]
		void UnregisterAnnotHandler (IAnnotHandler annotHandler);

		// -(void)registerAnnotEventListener:(id<IAnnotEventListener> _Nonnull)listener;
		[Export ("registerAnnotEventListener:")]
		void RegisterAnnotEventListener (IAnnotEventListener listener);

		// -(void)unregisterAnnotEventListener:(id<IAnnotEventListener> _Nonnull)listener;
		[Export ("unregisterAnnotEventListener:")]
		void UnregisterAnnotEventListener (IAnnotEventListener listener);

		// -(void)registerToolEventListener:(id<IToolEventListener> _Nonnull)listener;
		[Export ("registerToolEventListener:")]
		void RegisterToolEventListener (IToolEventListener listener);

		// -(void)unregisterToolEventListener:(id<IToolEventListener> _Nonnull)listener;
		[Export ("unregisterToolEventListener:")]
		void UnregisterToolEventListener (IToolEventListener listener);

		// -(void)registerLinkEventListener:(id<ILinkEventListener> _Nonnull)listener;
		[Export ("registerLinkEventListener:")]
		void RegisterLinkEventListener (ILinkEventListener listener);

		// -(void)unregisterLinkEventListener:(id<ILinkEventListener> _Nonnull)listener;
		[Export ("unregisterLinkEventListener:")]
		void UnregisterLinkEventListener (ILinkEventListener listener);

		// -(void)showProperty:(FSAnnotType)annotType rect:(CGRect)rect inView:(UIView * _Nonnull)view;
		[Export ("showProperty:rect:inView:")]
		void ShowProperty (FSAnnotType annotType, CGRect rect, UIView view);

		// -(unsigned int)getPropertyBarSettingColor:(FSAnnotType)annotType;
		[Export ("getPropertyBarSettingColor:")]
		uint GetPropertyBarSettingColor (FSAnnotType annotType);

		// -(unsigned int)getPropertyBarSettingOpacity:(FSAnnotType)annotType;
		[Export ("getPropertyBarSettingOpacity:")]
		uint GetPropertyBarSettingOpacity (FSAnnotType annotType);

		// -(void)showSearchBar:(BOOL)show;
		[Export ("showSearchBar:")]
		void ShowSearchBar (bool show);

		// -(void)registerSearchEventListener:(id<ISearchEventListener> _Nonnull)listener;
		[Export ("registerSearchEventListener:")]
		void RegisterSearchEventListener (ISearchEventListener listener);

		// -(void)unregisterSearchEventListener:(id<ISearchEventListener> _Nonnull)listener;
		[Export ("unregisterSearchEventListener:")]
		void UnregisterSearchEventListener (ISearchEventListener listener);

		// -(NSString * _Nonnull)getCurrentSelectedText;
		[Export ("getCurrentSelectedText")]
		//[Verify (MethodToProperty)]
		string CurrentSelectedText { get; }

		// -(void)showThumbnailView;
		[Export ("showThumbnailView")]
		void ShowThumbnailView ();

		// -(void)setFullScreen:(BOOL)fullScreen;
		[Export ("setFullScreen:")]
		void SetFullScreen (bool fullScreen);

		// -(void)suspendAutoFullScreen;
		[Export ("suspendAutoFullScreen")]
		void SuspendAutoFullScreen ();

		// -(void)resumeAutoFullScreen;
		[Export ("resumeAutoFullScreen")]
		void ResumeAutoFullScreen ();

		// -(NSMutableDictionary * _Nonnull)getTopToolbarItemHiddenStatus;
		[Export ("getTopToolbarItemHiddenStatus")]
		//[Verify (MethodToProperty)]
		NSMutableDictionary TopToolbarItemHiddenStatus { get; }

		// -(NSMutableDictionary * _Nonnull)getBottomToolbarItemHiddenStatus;
		[Export ("getBottomToolbarItemHiddenStatus")]
		//[Verify (MethodToProperty)]
		NSMutableDictionary BottomToolbarItemHiddenStatus { get; }

		// -(void)setToolbarItemHiddenWithTag:(NSUInteger)itemTag hidden:(BOOL)isHidden;
		[Export ("setToolbarItemHiddenWithTag:hidden:")]
		void SetToolbarItemHiddenWithTag (nuint itemTag, bool isHidden);

		// +(void)printDoc:(FSPDFDoc * _Nonnull)doc animated:(BOOL)animated jobName:(NSString * _Nullable)jobName delegate:(id<UIPrintInteractionControllerDelegate> _Nullable)delegate completionHandler:(UIPrintInteractionCompletionHandler _Nullable)completion;
		[Static]
		[Export ("printDoc:animated:jobName:delegate:completionHandler:")]
		void PrintDoc (FSPDFDoc doc, bool animated, [NullAllowed] string jobName, [NullAllowed] UIPrintInteractionControllerDelegate @delegate, [NullAllowed] UIPrintInteractionCompletionHandler completion);

		// +(void)printDoc:(FSPDFDoc * _Nonnull)doc fromRect:(CGRect)rect inView:(UIView * _Nonnull)view animated:(BOOL)animated jobName:(NSString * _Nullable)jobName delegate:(id<UIPrintInteractionControllerDelegate> _Nullable)delegate completionHandler:(UIPrintInteractionCompletionHandler _Nullable)completion;
		[Static]
		[Export ("printDoc:fromRect:inView:animated:jobName:delegate:completionHandler:")]
		void PrintDoc (FSPDFDoc doc, CGRect rect, UIView view, bool animated, [NullAllowed] string jobName, [NullAllowed] UIPrintInteractionControllerDelegate @delegate, [NullAllowed] UIPrintInteractionCompletionHandler completion);

		// -(unsigned int)getAnnotColor:(FSAnnotType)annotType;
		[Export ("getAnnotColor:")]
		uint GetAnnotColor (FSAnnotType annotType);

		// -(void)setAnnotColor:(unsigned int)color annotType:(FSAnnotType)annotType;
		[Export ("setAnnotColor:annotType:")]
		void SetAnnotColor (uint color, FSAnnotType annotType);

		// -(int)getState;
		[Export ("getState")]
		//[Verify (MethodToProperty)]
		int State { get; }

		// -(void)changeState:(int)state;
		[Export ("changeState:")]
		void ChangeState (int state);

		// -(void)documentSaveAS:(void (^ _Nullable)(void))successed error:(void (^ _Nullable)(void))error;
		[Export ("documentSaveAS:error:")]
		void DocumentSaveAS ([NullAllowed] Action successed, [NullAllowed] Action error);
	}

	// @interface SettingObj : NSObject
	[BaseType (typeof(NSObject))]
	interface SettingObj
	{
		// @property (copy, nonatomic) NSString * _Nonnull icon;
		[Export ("icon")]
		string Icon { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull textFace;
		[Export ("textFace")]
		string TextFace { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull scaleFromUnit;
		[Export ("scaleFromUnit")]
		string ScaleFromUnit { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull scaleToUnit;
		[Export ("scaleToUnit")]
		string ScaleToUnit { get; set; }

		// @property (assign, nonatomic) CGFloat textSize;
		[Export ("textSize")]
		nfloat TextSize { get; set; }

		// @property (assign, nonatomic) CGFloat opacity;
		[Export ("opacity")]
		nfloat Opacity { get; set; }

		// @property (assign, nonatomic) unsigned int thickness;
		[Export ("thickness")]
		uint Thickness { get; set; }

		// @property (assign, nonatomic) unsigned int rotation;
		[Export ("rotation")]
		uint Rotation { get; set; }

		// @property (assign, nonatomic) unsigned int scaleFromValue;
		[Export ("scaleFromValue")]
		uint ScaleFromValue { get; set; }

		// @property (assign, nonatomic) unsigned int scaleToValue;
		[Export ("scaleToValue")]
		uint ScaleToValue { get; set; }

		// @property (nonatomic, strong) UIColor * _Nonnull color;
		[Export ("color", ArgumentSemantic.Strong)]
		UIColor Color { get; set; }

		// @property (nonatomic, strong) UIColor * _Nonnull fillColor;
		[Export ("fillColor", ArgumentSemantic.Strong)]
		UIColor FillColor { get; set; }

		// @property (nonatomic, strong) UIColor * _Nonnull textColor;
		[Export ("textColor", ArgumentSemantic.Strong)]
		UIColor TextColor { get; set; }

		// @property (assign, nonatomic) BOOL multipleSelection;
		[Export ("multipleSelection")]
		bool MultipleSelection { get; set; }

		// @property (assign, nonatomic) BOOL customText;
		[Export ("customText")]
		bool CustomText { get; set; }
	}

	// @interface Annotations : NSObject
	[BaseType (typeof(NSObject))]
	interface Annotations
	{
		// @property (assign, nonatomic) BOOL continuouslyAdd;
		[Export ("continuouslyAdd")]
		bool ContinuouslyAdd { get; set; }

		// @property (nonatomic, strong) SettingObj * _Nonnull highlight;
		[Export ("highlight", ArgumentSemantic.Strong)]
		SettingObj Highlight { get; set; }

		// @property (nonatomic, strong) SettingObj * _Nonnull underline;
		[Export ("underline", ArgumentSemantic.Strong)]
		SettingObj Underline { get; set; }

		// @property (nonatomic, strong) SettingObj * _Nonnull squiggly;
		[Export ("squiggly", ArgumentSemantic.Strong)]
		SettingObj Squiggly { get; set; }

		// @property (nonatomic, strong) SettingObj * _Nonnull strikeout;
		[Export ("strikeout", ArgumentSemantic.Strong)]
		SettingObj Strikeout { get; set; }

		// @property (nonatomic, strong) SettingObj * _Nonnull insert;
		[Export ("insert", ArgumentSemantic.Strong)]
		SettingObj Insert { get; set; }

		// @property (nonatomic, strong) SettingObj * _Nonnull replace;
		[Export ("replace", ArgumentSemantic.Strong)]
		SettingObj Replace { get; set; }

		// @property (nonatomic, strong) SettingObj * _Nonnull line;
		[Export ("line", ArgumentSemantic.Strong)]
		SettingObj Line { get; set; }

		// @property (nonatomic, strong) SettingObj * _Nonnull rectangle;
		[Export ("rectangle", ArgumentSemantic.Strong)]
		SettingObj Rectangle { get; set; }

		// @property (nonatomic, strong) SettingObj * _Nonnull oval;
		[Export ("oval", ArgumentSemantic.Strong)]
		SettingObj Oval { get; set; }

		// @property (nonatomic, strong) SettingObj * _Nonnull arrow;
		[Export ("arrow", ArgumentSemantic.Strong)]
		SettingObj Arrow { get; set; }

		// @property (nonatomic, strong) SettingObj * _Nonnull pencil;
		[Export ("pencil", ArgumentSemantic.Strong)]
		SettingObj Pencil { get; set; }

		// @property (nonatomic, strong) SettingObj * _Nonnull polygon;
		[Export ("polygon", ArgumentSemantic.Strong)]
		SettingObj Polygon { get; set; }

		// @property (nonatomic, strong) SettingObj * _Nonnull cloud;
		[Export ("cloud", ArgumentSemantic.Strong)]
		SettingObj Cloud { get; set; }

		// @property (nonatomic, strong) SettingObj * _Nonnull polyline;
		[Export ("polyline", ArgumentSemantic.Strong)]
		SettingObj Polyline { get; set; }

		// @property (nonatomic, strong) SettingObj * _Nonnull typewriter;
		[Export ("typewriter", ArgumentSemantic.Strong)]
		SettingObj Typewriter { get; set; }

		// @property (nonatomic, strong) SettingObj * _Nonnull textbox;
		[Export ("textbox", ArgumentSemantic.Strong)]
		SettingObj Textbox { get; set; }

		// @property (nonatomic, strong) SettingObj * _Nonnull callout;
		[Export ("callout", ArgumentSemantic.Strong)]
		SettingObj Callout { get; set; }

		// @property (nonatomic, strong) SettingObj * _Nonnull note;
		[Export ("note", ArgumentSemantic.Strong)]
		SettingObj Note { get; set; }

		// @property (nonatomic, strong) SettingObj * _Nonnull attachment;
		[Export ("attachment", ArgumentSemantic.Strong)]
		SettingObj Attachment { get; set; }

		// @property (nonatomic, strong) SettingObj * _Nonnull distance;
		[Export ("distance", ArgumentSemantic.Strong)]
		SettingObj Distance { get; set; }

		// @property (nonatomic, strong) SettingObj * _Nonnull image;
		[Export ("image", ArgumentSemantic.Strong)]
		SettingObj Image { get; set; }

		// @property (nonatomic, strong) SettingObj * _Nonnull redaction;
		[Export ("redaction", ArgumentSemantic.Strong)]
		SettingObj Redaction { get; set; }
	}

	// @interface Form : NSObject
	[BaseType (typeof(NSObject))]
	interface Form
	{
		// @property (nonatomic, strong) SettingObj * _Nonnull textField;
		[Export ("textField", ArgumentSemantic.Strong)]
		SettingObj TextField { get; set; }

		// @property (nonatomic, strong) SettingObj * _Nonnull checkBox;
		[Export ("checkBox", ArgumentSemantic.Strong)]
		SettingObj CheckBox { get; set; }

		// @property (nonatomic, strong) SettingObj * _Nonnull radioButton;
		[Export ("radioButton", ArgumentSemantic.Strong)]
		SettingObj RadioButton { get; set; }

		// @property (nonatomic, strong) SettingObj * _Nonnull comboBox;
		[Export ("comboBox", ArgumentSemantic.Strong)]
		SettingObj ComboBox { get; set; }

		// @property (nonatomic, strong) SettingObj * _Nonnull listBox;
		[Export ("listBox", ArgumentSemantic.Strong)]
		SettingObj ListBox { get; set; }
	}

	// @interface UISettingsModel : NSObject
	[BaseType (typeof(NSObject))]
	interface UISettingsModel
	{
		// @property (copy, nonatomic) NSString * _Nonnull pageMode;
		[Export ("pageMode")]
		string PageMode { get; set; }

		// @property (assign, nonatomic) BOOL continuous;
		[Export ("continuous")]
		bool Continuous { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull colorMode;
		[Export ("colorMode")]
		string ColorMode { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull zoomMode;
		[Export ("zoomMode")]
		string ZoomMode { get; set; }

		// @property (assign, nonatomic) BOOL fullscreen;
		[Export ("fullscreen")]
		bool Fullscreen { get; set; }

		// @property (assign, nonatomic) BOOL highlightForm;
		[Export ("highlightForm")]
		bool HighlightForm { get; set; }

		// @property (assign, nonatomic) BOOL highlightLink;
		[Export ("highlightLink")]
		bool HighlightLink { get; set; }

		// @property (assign, nonatomic) BOOL disableFormNavigationBar;
		[Export ("disableFormNavigationBar")]
		bool DisableFormNavigationBar { get; set; }

		// @property (nonatomic, strong) UIColor * _Nonnull highlightFormColor;
		[Export ("highlightFormColor", ArgumentSemantic.Strong)]
		UIColor HighlightFormColor { get; set; }

		// @property (nonatomic, strong) UIColor * _Nonnull highlightLinkColor;
		[Export ("highlightLinkColor", ArgumentSemantic.Strong)]
		UIColor HighlightLinkColor { get; set; }

		// @property (nonatomic, strong) UIColor * _Nonnull mapForegroundColor;
		[Export ("mapForegroundColor", ArgumentSemantic.Strong)]
		UIColor MapForegroundColor { get; set; }

		// @property (nonatomic, strong) UIColor * _Nonnull mapBackgroundColor;
		[Export ("mapBackgroundColor", ArgumentSemantic.Strong)]
		UIColor MapBackgroundColor { get; set; }

		// @property (nonatomic, strong) UIColor * _Nonnull reflowBackgroundColor;
		[Export ("reflowBackgroundColor", ArgumentSemantic.Strong)]
		UIColor ReflowBackgroundColor { get; set; }

		// @property (nonatomic, strong) Annotations * _Nonnull annotations;
		[Export ("annotations", ArgumentSemantic.Strong)]
		Annotations Annotations { get; set; }

		// @property (nonatomic, strong) Form * _Nonnull form;
		[Export ("form", ArgumentSemantic.Strong)]
		Form Form { get; set; }

		// @property (nonatomic, strong) SettingObj * _Nonnull signature;
		[Export ("signature", ArgumentSemantic.Strong)]
		SettingObj Signature { get; set; }

		// @property (nonatomic, strong) SettingObj * _Nonnull commonlyUsed;
		[Export ("commonlyUsed", ArgumentSemantic.Strong)]
		SettingObj CommonlyUsed { get; set; }
	}

	// @interface UISettingsModel (NSObject)
	[Category]
	[BaseType (typeof(NSObject))]
	interface NSObject_UISettingsModel
	{
		// +(instancetype _Nonnull)modelWithDict:(NSDictionary * _Nonnull)dict;
		[Static]
		[Export ("modelWithDict:")]
		NSObject ModelWithDict (NSDictionary dict);

		// -(id _Nonnull)replaceSettingsWithDict:(NSDictionary * _Nonnull)dict;
		[Export ("replaceSettingsWithDict:")]
		NSObject ReplaceSettingsWithDict (NSDictionary dict);

		// +(NSDictionary * _Nonnull)defaultSettings;
		[Static]
		[Export ("defaultSettings")]
		//[Verify (MethodToProperty)]
		NSDictionary DefaultSettings { get; }
	}

	    // @interface SettingBarViewC : NSObject
    [BaseType(typeof(NSObject))]
    interface SettingBarViewC
    { 
    }

// @interface UIExtensionsConfig : NSObject
	[BaseType (typeof(NSObject))]
	interface UIExtensionsConfig
	{
		// @property (assign, nonatomic) BOOL loadThumbnail;
		[Export ("loadThumbnail")]
		bool LoadThumbnail { get; set; }

		// @property (assign, nonatomic) BOOL loadReadingBookmark;
		[Export ("loadReadingBookmark")]
		bool LoadReadingBookmark { get; set; }

		// @property (assign, nonatomic) BOOL loadOutline;
		[Export ("loadOutline")]
		bool LoadOutline { get; set; }

		// @property (assign, nonatomic) BOOL loadAttachment;
		[Export ("loadAttachment")]
		bool LoadAttachment { get; set; }

		// @property (assign, nonatomic) BOOL loadForm;
		[Export ("loadForm")]
		bool LoadForm { get; set; }

		// @property (assign, nonatomic) BOOL loadSignature;
		[Export ("loadSignature")]
		bool LoadSignature { get; set; }

		// @property (assign, nonatomic) BOOL loadSearch;
		[Export ("loadSearch")]
		bool LoadSearch { get; set; }

		// @property (assign, nonatomic) BOOL loadPageNavigation;
		[Export ("loadPageNavigation")]
		bool LoadPageNavigation { get; set; }

		// @property (assign, nonatomic) BOOL loadEncryption;
		[Export ("loadEncryption")]
		bool LoadEncryption { get; set; }

		// @property (assign, nonatomic) BOOL runJavaScript;
		[Export ("runJavaScript")]
		bool RunJavaScript { get; set; }

		// @property (assign, nonatomic) BOOL copyText;
		[Export ("copyText")]
		bool CopyText { get; set; }

		// @property (assign, nonatomic) BOOL disableLink;
		[Export ("disableLink")]
		bool DisableLink { get; set; }

		// @property (nonatomic, strong) NSMutableSet<NSString *> * _Nullable tools;
		[NullAllowed, Export ("tools", ArgumentSemantic.Strong)]
		NSMutableSet<NSString> Tools { get; set; }

		// @property (readonly, nonatomic) UISettingsModel * _Nullable defaultSettings;
		[NullAllowed, Export ("defaultSettings")]
		UISettingsModel DefaultSettings { get; }

		// -(id _Nullable)initWithJSONData:(NSData * _Nonnull)data;
		[Export ("initWithJSONData:")]
		IntPtr Constructor (NSData data);
	}
}
