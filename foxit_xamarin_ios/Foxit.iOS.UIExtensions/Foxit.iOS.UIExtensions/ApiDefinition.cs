/**
* Copyright (C) 2003-2019, Foxit Software Inc..
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

		/*
		// @property (nonatomic, strong) BlockButton * _Nonnull signBtn;
		[Export ("signBtn", ArgumentSemantic.Strong)]
		BlockButton SignBtn { get; set; }
		*/

		// @property (nonatomic, strong) UIToolbar * _Nonnull topToolbar;
		[Export ("topToolbar", ArgumentSemantic.Strong)]
		UIToolbar TopToolbar { get; set; }

		// -(instancetype _Nullable)initWithLocalized:(BOOL)needLocalized;
		[Export ("initWithLocalized:")]
		IntPtr Constructor (bool needLocalized);
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

		// -(id)initWithFrame:(CGRect)frame segmentItems:(NSArray *)items;
		[Export ("initWithFrame:segmentItems:")]
		//[Verify (StronglyTypedNSArray)]
		IntPtr Constructor (CGRect frame, NSObject[] items);

		// -(void)setSelectItem:(SegmentItem *)item;
		[Export ("setSelectItem:")]
		void SetSelectItem (SegmentItem item);

		// -(NSArray *)getItems;
		[Export ("getItems")]
		//[Verify (MethodToProperty), Verify (StronglyTypedNSArray)]
		NSObject[] Items { get; }
	}

	// @interface PanelButton : UIButton
	[BaseType (typeof(UIButton))]
	interface PanelButton
	{
		// @property (assign, nonatomic) id<IPanelSpec> spec;
		[Export ("spec", ArgumentSemantic.Assign)]
		IPanelSpec Spec { get; set; }
	}

	// @interface PanelHost : NSObject <SegmentDelegate>
	[BaseType (typeof(NSObject))]
	interface PanelHost : SegmentDelegate
	{
		// @property (nonatomic, strong) NSMutableArray * spaces;
		[Export ("spaces", ArgumentSemantic.Strong)]
		NSMutableArray Spaces { get; set; }

		// @property (nonatomic, strong) id<IPanelSpec> currentSpace;
		[Export ("currentSpace", ArgumentSemantic.Strong)]
		IPanelSpec CurrentSpace { get; set; }

		// @property (nonatomic, strong) UIView * contentView;
		[Export ("contentView", ArgumentSemantic.Strong)]
		UIView ContentView { get; set; }

		// -(instancetype)initWithSize:(CGSize)size panelTypes:(NSArray<NSNumber *> *)panelTypes;
		[Export ("initWithSize:panelTypes:")]
		IntPtr Constructor (CGSize size, NSNumber[] panelTypes);

		// -(void)addSpec:(id<IPanelSpec>)spec;
		[Export ("addSpec:")]
		void AddSpec (IPanelSpec spec);

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

		// -(instancetype)initWithUIExtensionsManager:(UIExtensionsManager *)extensionsManager;
		[Export ("initWithUIExtensionsManager:")]
		IntPtr Constructor (UIExtensionsManager extensionsManager);

		// -(NSMutableDictionary *)getItemHiddenStatus;
		[Export ("getItemHiddenStatus")]
		//[Verify (MethodToProperty)]
		NSMutableDictionary ItemHiddenStatus { get; }

		// -(void)setItem:(SettingItemType)itemType hidden:(BOOL)hidden;
		[Export ("setItem:hidden:")]
		void SetItem (SettingItemType itemType, bool hidden);

		// -(void)updateBtnLayout;
		[Export ("updateBtnLayout")]
		void UpdateBtnLayout ();
	}

	// @interface MenuGroup : NSObject
	[BaseType (typeof(NSObject))]
	interface MenuGroup
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

	// @interface MvMenuItem : NSObject
	[BaseType (typeof(NSObject))]
	interface MvMenuItem
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

		// @property (nonatomic, strong) id<IMvCallback> callBack;
		[Export ("callBack", ArgumentSemantic.Strong)]
		IMvCallback CallBack { get; set; }

		// @property (nonatomic, strong) UIView * customView;
		[Export ("customView", ArgumentSemantic.Strong)]
		UIView CustomView { get; set; }
	}

	// typedef void (^MV_Callback)();
	delegate void MV_Callback ();

	// @interface MenuView : NSObject
	[BaseType (typeof(NSObject))]
	interface MenuView
	{
		// @property (copy, nonatomic) MV_Callback onCancelClicked;
		[Export ("onCancelClicked", ArgumentSemantic.Copy)]
		MV_Callback OnCancelClicked { get; set; }

		// -(void)addGroup:(MenuGroup *)group;
		[Export ("addGroup:")]
		void AddGroup (MenuGroup group);

		// -(void)removeGroup:(NSUInteger)tag;
		[Export ("removeGroup:")]
		void RemoveGroup (nuint tag);

		// -(MenuGroup *)getGroup:(NSUInteger)tag;
		[Export ("getGroup:")]
		MenuGroup GetGroup (nuint tag);

		// -(void)addMenuItem:(NSUInteger)groupTag withItem:(MvMenuItem *)item;
		[Export ("addMenuItem:withItem:")]
		void AddMenuItem (nuint groupTag, MvMenuItem item);

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

		// @required -(void)addAnnot:(FSAnnot * _Nonnull)annot;
		[Abstract]
		[Export ("addAnnot:")]
		void AddAnnot (FSAnnot annot);

		// @required -(void)addAnnot:(FSAnnot * _Nonnull)annot addUndo:(BOOL)addUndo;
		[Abstract]
		[Export ("addAnnot:addUndo:")]
		void AddAnnot (FSAnnot annot, bool addUndo);

		// @required -(void)modifyAnnot:(FSAnnot * _Nonnull)annot;
		[Abstract]
		[Export ("modifyAnnot:")]
		void ModifyAnnot (FSAnnot annot);

		// @required -(void)modifyAnnot:(FSAnnot * _Nonnull)annot addUndo:(BOOL)addUndo;
		[Abstract]
		[Export ("modifyAnnot:addUndo:")]
		void ModifyAnnot (FSAnnot annot, bool addUndo);

		// @required -(void)removeAnnot:(FSAnnot * _Nonnull)annot;
		[Abstract]
		[Export ("removeAnnot:")]
		void RemoveAnnot (FSAnnot annot);

		// @required -(void)removeAnnot:(FSAnnot * _Nonnull)annot addUndo:(BOOL)addUndo;
		[Abstract]
		[Export ("removeAnnot:addUndo:")]
		void RemoveAnnot (FSAnnot annot, bool addUndo);

		// @required -(BOOL)onPageViewLongPress:(int)pageIndex recognizer:(UILongPressGestureRecognizer * _Nonnull)recognizer annot:(FSAnnot * _Nullable)annot;
		[Abstract]
		[Export ("onPageViewLongPress:recognizer:annot:")]
		bool OnPageViewLongPress (int pageIndex, UILongPressGestureRecognizer recognizer, [NullAllowed] FSAnnot annot);

		// @required -(BOOL)onPageViewTap:(int)pageIndex recognizer:(UITapGestureRecognizer * _Nonnull)recognizer annot:(FSAnnot * _Nullable)annot;
		[Abstract]
		[Export ("onPageViewTap:recognizer:annot:")]
		bool OnPageViewTap (int pageIndex, UITapGestureRecognizer recognizer, [NullAllowed] FSAnnot annot);

		// @required -(BOOL)onPageViewPan:(int)pageIndex recognizer:(UIPanGestureRecognizer * _Nonnull)recognizer annot:(FSAnnot * _Nonnull)annot;
		[Abstract]
		[Export ("onPageViewPan:recognizer:annot:")]
		bool OnPageViewPan (int pageIndex, UIPanGestureRecognizer recognizer, FSAnnot annot);

		// @required -(BOOL)onPageViewShouldBegin:(int)pageIndex recognizer:(UIGestureRecognizer * _Nonnull)gestureRecognizer annot:(FSAnnot * _Nullable)annot;
		[Abstract]
		[Export ("onPageViewShouldBegin:recognizer:annot:")]
		bool OnPageViewShouldBegin (int pageIndex, UIGestureRecognizer gestureRecognizer, [NullAllowed] FSAnnot annot);

		// @required -(BOOL)onPageViewTouchesBegan:(int)pageIndex touches:(NSSet * _Nonnull)touches withEvent:(UIEvent * _Nonnull)event annot:(FSAnnot * _Nonnull)annot;
		[Abstract]
		[Export ("onPageViewTouchesBegan:touches:withEvent:annot:")]
		bool OnPageViewTouchesBegan (int pageIndex, NSSet touches, UIEvent @event, FSAnnot annot);

		// @required -(BOOL)onPageViewTouchesMoved:(int)pageIndex touches:(NSSet * _Nonnull)touches withEvent:(UIEvent * _Nonnull)event annot:(FSAnnot * _Nonnull)annot;
		[Abstract]
		[Export ("onPageViewTouchesMoved:touches:withEvent:annot:")]
		bool OnPageViewTouchesMoved (int pageIndex, NSSet touches, UIEvent @event, FSAnnot annot);

		// @required -(BOOL)onPageViewTouchesEnded:(int)pageIndex touches:(NSSet * _Nonnull)touches withEvent:(UIEvent * _Nonnull)event annot:(FSAnnot * _Nonnull)annot;
		[Abstract]
		[Export ("onPageViewTouchesEnded:touches:withEvent:annot:")]
		bool OnPageViewTouchesEnded (int pageIndex, NSSet touches, UIEvent @event, FSAnnot annot);

		// @required -(BOOL)onPageViewTouchesCancelled:(int)pageIndex touches:(NSSet * _Nonnull)touches withEvent:(UIEvent * _Nonnull)event annot:(FSAnnot * _Nonnull)annot;
		[Abstract]
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
		// @optional -(void)uiextensionsManager:(UIExtensionsManager * _Nonnull)uiextensionsManager setTopToolBarHidden:(BOOL)hidden;
		[Export ("uiextensionsManager:setTopToolBarHidden:")]
		void UiextensionsManager (UIExtensionsManager uiextensionsManager, bool hidden);

		// @optional -(BOOL)uiextensionsManager:(UIExtensionsManager * _Nonnull)uiextensionsManager openNewDocAtPath:(NSString * _Nonnull)path UseNewTab:(BOOL)useNewTab;
		[Export ("uiextensionsManager:openNewDocAtPath:UseNewTab:")]
		bool UiextensionsManager (UIExtensionsManager uiextensionsManager, string path, bool useNewTab);

		// @optional -(void)quitUIExtensionsManager:(UIExtensionsManager * _Nonnull)uiextensionsManager button:(UIButton * _Nonnull)button;
		[Export ("quitUIExtensionsManager:button:")]
		void QuitUIExtensionsManager (UIExtensionsManager uiextensionsManager, UIButton button);

		// @optional -(FSClientInfo * _Nonnull)getClientInfo;
		[Export ("getClientInfo")]
		//[Verify (MethodToProperty)]
		FSClientInfo ClientInfo { get; }
	}

	// @interface UIExtensionsManager : NSObject <FSPDFUIExtensionsManager, IDocEventListener, IPageEventListener, IRotationEventListener, IAnnotEventListener, IRecoveryEventListener, ILinkEventListener>
	[BaseType (typeof(NSObject))]
	interface UIExtensionsManager : IFSPDFUIExtensionsManager, IIDocEventListener, IIPageEventListener, IIRotationEventListener, IAnnotEventListener, IIRecoveryEventListener, ILinkEventListener
	{
		// @property (readonly, nonatomic, strong) FSPDFViewCtrl * _Nonnull pdfViewCtrl;
		[Export ("pdfViewCtrl", ArgumentSemantic.Strong)]
		FSPDFViewCtrl PdfViewCtrl { get; }

		// @property (readonly, nonatomic, strong) MenuView * _Nonnull more;
		[Export ("more", ArgumentSemantic.Strong)]
		MenuView More { get; }

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

		// -(NSMutableDictionary * _Nonnull)getTopToolbarItemHiddenStatus;
		[Export ("getTopToolbarItemHiddenStatus")]
		//[Verify (MethodToProperty)]
		NSMutableDictionary TopToolbarItemHiddenStatus { get; }

		// -(NSMutableDictionary * _Nonnull)getBottomToolbarItemHiddenStatus;
		[Export ("getBottomToolbarItemHiddenStatus")]
		//[Verify (MethodToProperty)]
		NSMutableDictionary BottomToolbarItemHiddenStatus { get; }

		// -(void)setFullScreen:(BOOL)fullScreen;
		[Export ("setFullScreen:")]
		void SetFullScreen (bool fullScreen);

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

	// @protocol IMvCallback <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface IMvCallback
	{
		// @required -(void)onClick:(MvMenuItem *)item;
		[Abstract]
		[Export ("onClick:")]
		void OnClick (MvMenuItem item);
	}

    // @protocol IPanelSpec <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface IPanelSpec
    {
    }

    // @interface UISettingsModel : NSObject
    [BaseType(typeof(NSObject))]
    interface UISettingsModel
    { 
    }
}
