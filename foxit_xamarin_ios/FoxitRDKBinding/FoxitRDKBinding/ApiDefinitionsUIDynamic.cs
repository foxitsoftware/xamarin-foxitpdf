using System;
using CoreGraphics;
using Foundation;
using FoxitRDK;
using ObjCRuntime;
using UIKit;

namespace FoxitRDKUI
{
	[Static]
	partial interface Constants
	{
		// extern double uiextensionsDynamicVersionNumber;
		[Field ("uiextensionsDynamicVersionNumber", "__Internal")]
		double uiextensionsDynamicVersionNumber { get; }

		//// extern const unsigned char [] uiextensionsDynamicVersionString;
		//[Field ("uiextensionsDynamicVersionString", "__Internal")]
		//char uiextensionsDynamicVersionString { get; }
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
	interface FSFileListViewController : IDocEventListener
	{
		[Wrap ("WeakDelegate")]
		[NullAllowed]
		FSFileSelectDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<FSFileSelectDelegate> _Nullable delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		//// @property (nonatomic, strong) BlockButton * _Nonnull signBtn;
		//[Export ("signBtn", ArgumentSemantic.Strong)]
		//BlockButton SignBtn { get; set; }

		// @property (nonatomic, strong) UIToolbar * _Nonnull topToolbar;
		[Export ("topToolbar", ArgumentSemantic.Strong)]
		UIToolbar TopToolbar { get; set; }
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
		// @property (assign, nonatomic) BOOL isHidden;
		[Export ("isHidden")]
		bool IsHidden { get; set; }

		// -(instancetype)initWithExtensionsManager:(UIExtensionsManager *)extensionsManager;
		[Export ("initWithExtensionsManager:")]
		IntPtr Constructor (UIExtensionsManager extensionsManager);

		// -(NSMutableDictionary *)getItemHiddenStatus;
		[Export ("getItemHiddenStatus")]
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
		void SettingBarSetNightMode(SettingBar settingBar, bool isNightMode);

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

		//// @property (nonatomic, strong) id<IMvCallback> callBack;
		//[Export ("callBack", ArgumentSemantic.Strong)]
		//IMvCallback CallBack { get; set; }

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

		// -(void)resetViewData;
		[Export ("resetViewData")]
		void ResetViewData ();
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
		string Name { get; }

		// @required -(BOOL)isEnabled;
		[Abstract]
		[Export ("isEnabled")]
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
        [Export("onDraw:inContext:")]
        unsafe void OnDraw(int pageIndex, IntPtr context);
    }

	// @protocol IAnnotHandler <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface IAnnotHandler
	{
		// @required -(FSAnnotType)getType;
		[Abstract]
		[Export ("getType")]
		FSAnnotType Type { get; }

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

		// @optional -(BOOL)uiextensionsManager:(UIExtensionsManager * _Nonnull)uiextensionsManager openNewDocAtPath:(NSString * _Nonnull)path;
		[Export ("uiextensionsManager:openNewDocAtPath:")]
		bool UiextensionsManager (UIExtensionsManager uiextensionsManager, string path);

		// @optional -(void)quitUIExtensionsManager:(UIExtensionsManager * _Nonnull)uiextensionsManager button:(UIButton * _Nonnull)button;
		[Export ("quitUIExtensionsManager:button:")]
		void QuitUIExtensionsManager (UIExtensionsManager uiextensionsManager, UIButton button);

		//// @optional -(FSClientInfo * _Nonnull)getClientInfo;
		//[Export ("getClientInfo")]
		//FSClientInfo ClientInfo { get; }
	}

	// @interface UIExtensionsManager : NSObject <FSPDFUIExtensionsManager, IDocEventListener, IPageEventListener, IRotationEventListener, IAnnotEventListener, IRecoveryEventListener, ILinkEventListener>
	[BaseType (typeof(NSObject))]
	interface UIExtensionsManager : FSPDFUIExtensionsManager, IDocEventListener, IPageEventListener, IRotationEventListener, IAnnotEventListener, IRecoveryEventListener, ILinkEventListener
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

		// -(id _Nonnull)initWithPDFViewControl:(FSPDFViewCtrl * _Nonnull)viewctrl configurationObject:(UIExtensionsModulesConfig * _Nonnull)configuration;
		[Export ("initWithPDFViewControl:configurationObject:")]
		IntPtr Constructor (FSPDFViewCtrl viewctrl, UIExtensionsModulesConfig configuration);

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
		string CurrentSelectedText { get; }

		// -(void)showThumbnailView;
		[Export ("showThumbnailView")]
		void ShowThumbnailView ();

		// -(NSMutableDictionary * _Nonnull)getTopToolbarItemHiddenStatus;
		[Export ("getTopToolbarItemHiddenStatus")]
		NSMutableDictionary TopToolbarItemHiddenStatus { get; }

		// -(NSMutableDictionary * _Nonnull)getBottomToolbarItemHiddenStatus;
		[Export ("getBottomToolbarItemHiddenStatus")]
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

		// -(FSXFAWidget * _Nonnull)getXFAWidgetAtPoint:(CGPoint)pvPoint pageIndex:(int)pageIndex;
		[Export ("getXFAWidgetAtPoint:pageIndex:")]
		FSXFAWidget GetXFAWidgetAtPoint (CGPoint pvPoint, int pageIndex);
	}

	// @interface UIExtensionsModulesConfig : NSObject
	[BaseType (typeof(NSObject))]
	interface UIExtensionsModulesConfig
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

		// @property (nonatomic, strong) NSMutableSet<NSString *> * _Nullable tools;
		[NullAllowed, Export ("tools", ArgumentSemantic.Strong)]
		NSMutableSet<NSString> Tools { get; set; }

		// -(id _Nullable)initWithJSONData:(NSData * _Nonnull)data;
		[Export ("initWithJSONData:")]
		IntPtr Constructor (NSData data);
	}

	// @interface DXPopover : UIView
	[BaseType (typeof(UIView))]
	interface DXPopover
	{
		// +(instancetype)popover;
		[Static]
		[Export ("popover")]
		DXPopover Popover ();

		// @property (readonly, assign, nonatomic) DXPopoverPosition popoverPosition;
		[Export ("popoverPosition", ArgumentSemantic.Assign)]
		DXPopoverPosition PopoverPosition { get; }

		// @property (assign, nonatomic) CGSize arrowSize;
		[Export ("arrowSize", ArgumentSemantic.Assign)]
		CGSize ArrowSize { get; set; }

		// @property (assign, nonatomic) CGFloat cornerRadius;
		[Export ("cornerRadius")]
		nfloat CornerRadius { get; set; }

		// @property (assign, nonatomic) CGFloat animationIn;
		[Export ("animationIn")]
		nfloat AnimationIn { get; set; }

		// @property (assign, nonatomic) CGFloat animationOut;
		[Export ("animationOut")]
		nfloat AnimationOut { get; set; }

		// @property (assign, nonatomic) BOOL animationSpring;
		[Export ("animationSpring")]
		bool AnimationSpring { get; set; }

		// @property (readonly, assign, nonatomic) BOOL isShow;
		[Export ("isShow")]
		bool IsShow { get; }

		// @property (assign, nonatomic) DXPopoverMaskType maskType;
		[Export ("maskType", ArgumentSemantic.Assign)]
		DXPopoverMaskType MaskType { get; set; }

		// @property (assign, nonatomic) BOOL applyShadow;
		[Export ("applyShadow")]
		bool ApplyShadow { get; set; }

		// @property (assign, nonatomic) CGFloat betweenAtViewAndArrowHeight;
		[Export ("betweenAtViewAndArrowHeight")]
		nfloat BetweenAtViewAndArrowHeight { get; set; }

		// @property (assign, nonatomic) CGFloat sideEdge;
		[Export ("sideEdge")]
		nfloat SideEdge { get; set; }

		// @property (copy, nonatomic) dispatch_block_t didShowHandler;
		[Export ("didShowHandler", ArgumentSemantic.Copy)]
        Action DidShowHandler { get; set; }

		// @property (copy, nonatomic) dispatch_block_t didDismissHandler;
		[Export ("didDismissHandler", ArgumentSemantic.Copy)]
        Action DidDismissHandler { get; set; }

		// @property (copy, nonatomic) dispatch_block_t didRotatedHandler;
		[Export ("didRotatedHandler", ArgumentSemantic.Copy)]
        Action DidRotatedHandler { get; set; }

		// @property (nonatomic, strong) UIControl * blackOverlay;
		[Export ("blackOverlay", ArgumentSemantic.Strong)]
		UIControl BlackOverlay { get; set; }

		// @property (nonatomic, strong) UIView * contentView;
		[Export ("contentView", ArgumentSemantic.Strong)]
		UIView ContentView { get; set; }

		// -(void)showAtPoint:(CGPoint)point popoverPosition:(DXPopoverPosition)position withContentView:(UIView *)contentView inView:(UIView *)containerView;
		[Export ("showAtPoint:popoverPosition:withContentView:inView:")]
		void ShowAtPoint (CGPoint point, DXPopoverPosition position, UIView contentView, UIView containerView);

		// -(void)dismiss;
		[Export ("dismiss")]
		void Dismiss ();
	}
}
