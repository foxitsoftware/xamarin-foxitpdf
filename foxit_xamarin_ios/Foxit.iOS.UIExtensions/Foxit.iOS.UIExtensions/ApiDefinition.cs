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
		// extern const unsigned char[] uiextensionsDynamicVersionString;
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
		NSObject Delegate { get; set; }

		// @property (nonatomic, weak) id<FSFileSelectDelegate> _Nullable delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// @property (nonatomic, strong) UIToolbar * _Nonnull topToolbar;
		[Export ("topToolbar", ArgumentSemantic.Strong)]
		UIToolbar TopToolbar { get; set; }

		// -(instancetype)initWithWindowScene:(UIWindowScene * _Nullable)windowScene __attribute__((availability(ios, introduced=13.0)));
#if !NET
    [iOS (13, 0)]
#endif
		[Export ("initWithWindowScene:")]
		IntPtr Constructor ([NullAllowed] UIWindowScene windowScene);
	}

	// @interface TabItem : NSObject
	[BaseType (typeof(NSObject))]
	interface TabItem
	{
		// @property (nonatomic, strong) UIImage * image;
		[Export ("image", ArgumentSemantic.Strong)]
		UIImage Image { get; set; }

		// @property (nonatomic, strong) UIImage * selectImage;
		[Export ("selectImage", ArgumentSemantic.Strong)]
		UIImage SelectImage { get; set; }
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

		// @required -(TabItem *)getTabItem;
		[Abstract]
		[Export ("getTabItem")]
		//[Verify (MethodToProperty)]
		TabItem TabItem { get; }

		// @required -(void)onActivated;
		[Abstract]
		[Export ("onActivated")]
		void OnActivated ();

		// @required -(void)onDeactivated;
		[Abstract]
		[Export ("onDeactivated")]
		void OnDeactivated ();
	}

	// @interface PanelHost : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface PanelHost
	{
		// @property (nonatomic, strong) NSMutableArray> * specs;
		[Export ("specs", ArgumentSemantic.Strong)]
		NSMutableArray Specs { get; set; }

		// @property (nonatomic, strong) id<IPanelSpec> currentSpec;
		[Export ("currentSpec", ArgumentSemantic.Strong)]
		NSObject CurrentSpec { get; set; }

		// @property (nonatomic, strong) UIView * contentView;
		[Export ("contentView", ArgumentSemantic.Strong)]
		UIView ContentView { get; set; }

		// -(void)addSpec:(id<IPanelSpec>)spec;
		[Export ("addSpec:")]
		void AddSpec (NSObject spec);

		// -(void)insertSpec:(id<IPanelSpec>)spec atIndex:(int)index;
		[Export ("insertSpec:atIndex:")]
		void InsertSpec (NSObject spec, int index);

		// -(void)removeSpec:(id<IPanelSpec>)spec;
		[Export ("removeSpec:")]
		void RemoveSpec (NSObject spec);

		// -(void)reloadData;
		[Export ("reloadData")]
		void ReloadData ();
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

	// @interface FSPanelController : UIViewController
	[BaseType (typeof(UIViewController))]
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
		NSObject GetPanel (FSPanelType type);

		// -(BOOL)isPanelHidden:(FSPanelType)type;
		[Export ("isPanelHidden:")]
		bool IsPanelHidden (FSPanelType type);

		// -(void)setPanelHidden:(BOOL)isHidden type:(FSPanelType)type;
		[Export ("setPanelHidden:type:")]
		void SetPanelHidden (bool isHidden, FSPanelType type);

		// -(void)registerPanelChangedListener:(id<IPanelChangedListener>)listener;
		[Export ("registerPanelChangedListener:")]
		void RegisterPanelChangedListener (NSObject listener);

		// -(void)unregisterPanelChangedListener:(id<IPanelChangedListener>)listener;
		[Export ("unregisterPanelChangedListener:")]
		void UnregisterPanelChangedListener (NSObject listener);
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

	// @protocol FSSettingBarDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface FSSettingBarDelegate
	{
		// @optional -(void)settingBarSinglePageLayout:(FSSettingBar *)settingBar;
		[Export ("settingBarSinglePageLayout:")]
		void SettingBarSinglePageLayout (FSSettingBar settingBar);

		// @optional -(void)settingBarContinuousLayout:(FSSettingBar *)settingBar;
		[Export ("settingBarContinuousLayout:")]
		void SettingBarContinuousLayout (FSSettingBar settingBar);

		// @optional -(void)settingBarDoublePageLayout:(FSSettingBar *)settingBar;
		[Export ("settingBarDoublePageLayout:")]
		void SettingBarDoublePageLayout (FSSettingBar settingBar);

		// @optional -(void)settingBarCoverPageLayout:(FSSettingBar *)settingBar;
		[Export ("settingBarCoverPageLayout:")]
		void SettingBarCoverPageLayout (FSSettingBar settingBar);

		// @optional -(void)settingBarThumbnail:(FSSettingBar *)settingBar;
		[Export ("settingBarThumbnail:")]
		void SettingBarThumbnail (FSSettingBar settingBar);

		// @optional -(void)settingBarReflow:(FSSettingBar *)settingBar;
		[Export ("settingBarReflow:")]
		void SettingBarReflow (FSSettingBar settingBar);

		// @optional -(void)settingBarCrop:(FSSettingBar *)settingBar;
		[Export ("settingBarCrop:")]
		void SettingBarCrop (FSSettingBar settingBar);

		// @optional -(void)settingBarSpeech:(FSSettingBar *)settingBar;
		[Export ("settingBarSpeech:")]
		void SettingBarSpeech (FSSettingBar settingBar);

		// @optional -(void)settingBarPanAndZoom:(FSSettingBar *)settingBar;
		[Export ("settingBarPanAndZoom:")]
		void SettingBarPanAndZoom (FSSettingBar settingBar);

		// @optional -(void)settingBar:(FSSettingBar *)settingBar isLockScreen:(BOOL)isLockScreen;
		[Export ("settingBar:isLockScreen:")]
		void SettingBarLockScreen (FSSettingBar settingBar, bool isLockScreen);

		// @optional -(void)settingBar:(FSSettingBar *)settingBar isNightMode:(BOOL)isNightMode;
		[Export ("settingBar:isNightMode:")]
		void SettingBarNightMode (FSSettingBar settingBar, bool isNightMode);

		// @optional -(void)settingBarPageColor:(FSSettingBar *)settingBar;
		[Export ("settingBarPageColor:")]
		void SettingBarPageColor (FSSettingBar settingBar);

		// @optional -(void)settingBarFitPage:(FSSettingBar *)settingBar;
		[Export ("settingBarFitPage:")]
		void SettingBarFitPage (FSSettingBar settingBar);

		// @optional -(void)settingBarFitWidth:(FSSettingBar *)settingBar;
		[Export ("settingBarFitWidth:")]
		void SettingBarFitWidth (FSSettingBar settingBar);

		// @optional -(void)settingBarRotate:(FSSettingBar *)settingBar;
		[Export ("settingBarRotate:")]
		void SettingBarRotate (FSSettingBar settingBar);

		// @optional -(void)settingBarAutoFlip:(FSSettingBar *)settingBar;
		[Export ("settingBarAutoFlip:")]
		void SettingBarAutoFlip (FSSettingBar settingBar);

		// @optional -(void)settingBarDidChangeSize:(FSSettingBar *)settingBar;
		[Export ("settingBarDidChangeSize:")]
		void SettingBarDidChangeSize (FSSettingBar settingBar);

		// @optional -(void)settingBarDidChangePageEdge:(FSSettingBar *)settingBar;
		[Export ("settingBarDidChangePageEdge:")]
		void SettingBarDidChangePageEdge (FSSettingBar settingBar);
	}

	// @interface FSSettingBar : NSObject <IAppLifecycleListener>
	[BaseType (typeof(NSObject))]
	interface FSSettingBar : IAppLifecycleListener
	{
		// @property (nonatomic, strong) UIView * contentView;
		[Export ("contentView", ArgumentSemantic.Strong)]
		UIView ContentView { get; set; }

		[Wrap ("WeakDelegate")]
		NSObject Delegate { get; set; }

		// @property (nonatomic, weak) id<FSSettingBarDelegate> delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// @property (copy, nonatomic) void (^continueItemStateCallback)(BOOL);
		[Export ("continueItemStateCallback", ArgumentSemantic.Copy)]
		Action<bool> ContinueItemStateCallback { get; set; }

		// @property (copy, nonatomic) void (^pageRTLItemStateCallback)(BOOL);
		[Export ("pageRTLItemStateCallback", ArgumentSemantic.Copy)]
		Action<bool> PageRTLItemStateCallback { get; set; }

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
	}/*
		

	[Static]
		*/
	//[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern const FSAnnotType FSAnnotArrowLine;
		[Field ("FSAnnotArrowLine", "__Internal")]
		FSAnnotType FSAnnotArrowLine { get; }

		// extern const FSAnnotType FSAnnotInsert;
		[Field ("FSAnnotInsert", "__Internal")]
		FSAnnotType FSAnnotInsert { get; }

		// extern const FSAnnotType FSAnnotTextbox;
		[Field ("FSAnnotTextbox", "__Internal")]
		FSAnnotType FSAnnotTextbox { get; }

		// extern const FSAnnotType FSAnnotCloud;
		[Field ("FSAnnotCloud", "__Internal")]
		FSAnnotType FSAnnotCloud { get; }

		// extern const FSAnnotType FSAnnotCallout;
		[Field ("FSAnnotCallout", "__Internal")]
		FSAnnotType FSAnnotCallout { get; }

		// extern const FSAnnotType FSAnnotDistance;
		[Field ("FSAnnotDistance", "__Internal")]
		FSAnnotType FSAnnotDistance { get; }

		// extern const FSAnnotType FSAnnotReplace;
		[Field ("FSAnnotReplace", "__Internal")]
		FSAnnotType FSAnnotReplace { get; }

		// extern const FSAnnotType FSAnnotReflow;
		[Field ("FSAnnotReflow", "__Internal")]
		FSAnnotType FSAnnotReflow { get; }

		// extern const FSToolStringName Tool_Select;
		[Field ("Tool_Select", "__Internal")]
		NSString Tool_Select { get; }

		// extern const FSToolStringName Tool_Note;
		[Field ("Tool_Note", "__Internal")]
		NSString Tool_Note { get; }

		// extern const FSToolStringName Tool_Freetext;
		[Field ("Tool_Freetext", "__Internal")]
		NSString Tool_Freetext { get; }

		// extern const FSToolStringName Tool_Textbox;
		[Field ("Tool_Textbox", "__Internal")]
		NSString Tool_Textbox { get; }

		// extern const FSToolStringName Tool_Callout;
		[Field ("Tool_Callout", "__Internal")]
		NSString Tool_Callout { get; }

		// extern const FSToolStringName Tool_Pencil;
		[Field ("Tool_Pencil", "__Internal")]
		NSString Tool_Pencil { get; }

		// extern const FSToolStringName Tool_Eraser;
		[Field ("Tool_Eraser", "__Internal")]
		NSString Tool_Eraser { get; }

		// extern const FSToolStringName Tool_Stamp;
		[Field ("Tool_Stamp", "__Internal")]
		NSString Tool_Stamp { get; }

		// extern const FSToolStringName Tool_Insert;
		[Field ("Tool_Insert", "__Internal")]
		NSString Tool_Insert { get; }

		// extern const FSToolStringName Tool_Replace;
		[Field ("Tool_Replace", "__Internal")]
		NSString Tool_Replace { get; }

		// extern const FSToolStringName Tool_Attachment;
		[Field ("Tool_Attachment", "__Internal")]
		NSString Tool_Attachment { get; }

		// extern const FSToolStringName Tool_Signature;
		[Field ("Tool_Signature", "__Internal")]
		NSString Tool_Signature { get; }

		// extern const FSToolStringName Tool_Line;
		[Field ("Tool_Line", "__Internal")]
		NSString Tool_Line { get; }

		// extern const FSToolStringName Tool_Arrow;
		[Field ("Tool_Arrow", "__Internal")]
		NSString Tool_Arrow { get; }

		// extern const FSToolStringName Tool_Markup;
		[Field ("Tool_Markup", "__Internal")]
		NSString Tool_Markup { get; }

		// extern const FSToolStringName Tool_Highlight;
		[Field ("Tool_Highlight", "__Internal")]
		NSString Tool_Highlight { get; }

		// extern const FSToolStringName Tool_Squiggly;
		[Field ("Tool_Squiggly", "__Internal")]
		NSString Tool_Squiggly { get; }

		// extern const FSToolStringName Tool_Strikeout;
		[Field ("Tool_Strikeout", "__Internal")]
		NSString Tool_Strikeout { get; }

		// extern const FSToolStringName Tool_Underline;
		[Field ("Tool_Underline", "__Internal")]
		NSString Tool_Underline { get; }

		// extern const FSToolStringName Tool_Shape;
		[Field ("Tool_Shape", "__Internal")]
		NSString Tool_Shape { get; }

		// extern const FSToolStringName Tool_Rectangle;
		[Field ("Tool_Rectangle", "__Internal")]
		NSString Tool_Rectangle { get; }

		// extern const FSToolStringName Tool_Oval;
		[Field ("Tool_Oval", "__Internal")]
		NSString Tool_Oval { get; }

		// extern const FSToolStringName Tool_Distance;
		[Field ("Tool_Distance", "__Internal")]
		NSString Tool_Distance { get; }

		// extern const FSToolStringName Tool_Image;
		[Field ("Tool_Image", "__Internal")]
		NSString Tool_Image { get; }

		// extern const FSToolStringName Tool_Polygon;
		[Field ("Tool_Polygon", "__Internal")]
		NSString Tool_Polygon { get; }

		// extern const FSToolStringName Tool_Cloud;
		[Field ("Tool_Cloud", "__Internal")]
		NSString Tool_Cloud { get; }

		// extern const FSToolStringName Tool_PolyLine;
		[Field ("Tool_PolyLine", "__Internal")]
		NSString Tool_PolyLine { get; }

		// extern const FSToolStringName Tool_Audio;
		[Field ("Tool_Audio", "__Internal")]
		NSString Tool_Audio { get; }

		// extern const FSToolStringName Tool_Video;
		[Field ("Tool_Video", "__Internal")]
		NSString Tool_Video { get; }

		// extern const FSToolStringName Tool_Link;
		[Field ("Tool_Link", "__Internal")]
		NSString Tool_Link { get; }

		// extern const FSToolStringName Tool_Multiple_Selection;
		[Field ("Tool_Multiple_Selection", "__Internal")]
		NSString Tool_Multiple_Selection { get; }

		// extern const FSToolStringName Tool_Redaction;
		[Field ("Tool_Redaction", "__Internal")]
		NSString Tool_Redaction { get; }

		// extern const FSToolStringName Tool_Form;
		[Field ("Tool_Form", "__Internal")]
		NSString Tool_Form { get; }

		// extern const FSToolStringName Tool_Fill_Sign;
		[Field ("Tool_Fill_Sign", "__Internal")]
		NSString Tool_Fill_Sign { get; }

		// extern const FSModuleStringName Module_Thumbnail;
		[Field ("Module_Thumbnail", "__Internal")]
		NSString Module_Thumbnail { get; }

		// extern const FSModuleStringName Module_Signature;
		[Field ("Module_Signature", "__Internal")]
		NSString Module_Signature { get; }

		// extern const FSModuleStringName Module_Speech;
		[Field ("Module_Speech", "__Internal")]
		NSString Module_Speech { get; }

		// extern const FSModuleStringName Module_History_Data;
		[Field ("Module_History_Data", "__Internal")]
		NSString Module_History_Data { get; }

		// extern const FS_TOOLBAR_ITEM_TAG FS_TOOLBAR_ITEM_TAG_BACK;
		[Field ("FS_TOOLBAR_ITEM_TAG_BACK", "__Internal")]
		int FS_TOOLBAR_ITEM_TAG_BACK { get; }

		// extern const FS_TOOLBAR_ITEM_TAG FS_TOOLBAR_ITEM_TAG_MORE;
		[Field ("FS_TOOLBAR_ITEM_TAG_MORE", "__Internal")]
		int FS_TOOLBAR_ITEM_TAG_MORE { get; }

		// extern const FS_TOOLBAR_ITEM_TAG FS_TOOLBAR_ITEM_TAG_SEARCH;
		[Field ("FS_TOOLBAR_ITEM_TAG_SEARCH", "__Internal")]
		int FS_TOOLBAR_ITEM_TAG_SEARCH { get; }

		// extern const FS_TOOLBAR_ITEM_TAG FS_TOOLBAR_ITEM_TAG_PANEL;
		[Field ("FS_TOOLBAR_ITEM_TAG_PANEL", "__Internal")]
		int FS_TOOLBAR_ITEM_TAG_PANEL { get; }

		// extern const FS_TOOLBAR_ITEM_TAG FS_TOOLBAR_ITEM_TAG_VIEW_SETTINGS;
		[Field ("FS_TOOLBAR_ITEM_TAG_VIEW_SETTINGS", "__Internal")]
		int FS_TOOLBAR_ITEM_TAG_VIEW_SETTINGS { get; }

		// extern const FS_TOOLBAR_ITEM_TAG FS_TOOLBAR_ITEM_TAG_THUMBNAIL;
		[Field ("FS_TOOLBAR_ITEM_TAG_THUMBNAIL", "__Internal")]
		int FS_TOOLBAR_ITEM_TAG_THUMBNAIL { get; }

		// extern const FS_TOOLBAR_ITEM_TAG FS_TOOLBAR_ITEM_TAG_READING_BOOKMARK;
		[Field ("FS_TOOLBAR_ITEM_TAG_READING_BOOKMARK", "__Internal")]
		int FS_TOOLBAR_ITEM_TAG_READING_BOOKMARK { get; }

		// extern const FS_TOOLBAR_ITEM_TAG FS_TOOLBAR_ITEM_TAG_HOME;
		[Field ("FS_TOOLBAR_ITEM_TAG_HOME", "__Internal")]
		int FS_TOOLBAR_ITEM_TAG_HOME { get; }

		// extern const FS_TOOLBAR_ITEM_TAG FS_TOOLBAR_ITEM_TAG_EDIT;
		[Field ("FS_TOOLBAR_ITEM_TAG_EDIT", "__Internal")]
		int FS_TOOLBAR_ITEM_TAG_EDIT { get; }

		// extern const FS_TOOLBAR_ITEM_TAG FS_TOOLBAR_ITEM_TAG_COMMENT;
		[Field ("FS_TOOLBAR_ITEM_TAG_COMMENT", "__Internal")]
		int FS_TOOLBAR_ITEM_TAG_COMMENT { get; }

		// extern const FS_TOOLBAR_ITEM_TAG FS_TOOLBAR_ITEM_TAG_DRAWING;
		[Field ("FS_TOOLBAR_ITEM_TAG_DRAWING", "__Internal")]
		int FS_TOOLBAR_ITEM_TAG_DRAWING { get; }

		// extern const FS_TOOLBAR_ITEM_TAG FS_TOOLBAR_ITEM_TAG_VIEW;
		[Field ("FS_TOOLBAR_ITEM_TAG_VIEW", "__Internal")]
		int FS_TOOLBAR_ITEM_TAG_VIEW { get; }

		// extern const FS_TOOLBAR_ITEM_TAG FS_TOOLBAR_ITEM_TAG_FORM;
		[Field ("FS_TOOLBAR_ITEM_TAG_FORM", "__Internal")]
		int FS_TOOLBAR_ITEM_TAG_FORM { get; }

		// extern const FS_TOOLBAR_ITEM_TAG FS_TOOLBAR_ITEM_TAG_SIGN;
		[Field ("FS_TOOLBAR_ITEM_TAG_SIGN", "__Internal")]
		int FS_TOOLBAR_ITEM_TAG_SIGN { get; }

		// extern const FS_TOOLBAR_ITEM_TAG FS_TOOLBAR_ITEM_TAG_PROTECT;
		[Field ("FS_TOOLBAR_ITEM_TAG_PROTECT", "__Internal")]
		int FS_TOOLBAR_ITEM_TAG_PROTECT { get; }

		// extern const int TAG_GROUP_PROTECT;
		[Field ("TAG_GROUP_PROTECT", "__Internal")]
		int TAG_GROUP_PROTECT { get; }

		// extern const int TAG_ITEM_REDACTION;
		[Field ("TAG_ITEM_REDACTION", "__Internal")]
		int TAG_ITEM_REDACTION { get; }

		// extern const int TAG_ITEM_PASSWORD;
		[Field ("TAG_ITEM_PASSWORD", "__Internal")]
		int TAG_ITEM_PASSWORD { get; }

		// extern const int TAG_ITEM_CERTIFICATE;
		[Field ("TAG_ITEM_CERTIFICATE", "__Internal")]
		int TAG_ITEM_CERTIFICATE { get; }

		// extern const int TAG_GROUP_COMMENT_FIELD;
		[Field ("TAG_GROUP_COMMENT_FIELD", "__Internal")]
		int TAG_GROUP_COMMENT_FIELD { get; }

		// extern const int TAG_ITEM_IMPORTCOMMENT;
		[Field ("TAG_ITEM_IMPORTCOMMENT", "__Internal")]
		int TAG_ITEM_IMPORTCOMMENT { get; }

		// extern const int TAG_ITEM_EXPORTCOMMENT;
		[Field ("TAG_ITEM_EXPORTCOMMENT", "__Internal")]
		int TAG_ITEM_EXPORTCOMMENT { get; }

		// extern const int TAG_ITEM_SUMARIZECOMMENT;
		[Field ("TAG_ITEM_SUMARIZECOMMENT", "__Internal")]
		int TAG_ITEM_SUMARIZECOMMENT { get; }

		// extern const int TAG_ITEM_EXPORTHIGHLIGHTEDTEXT;
		[Field ("TAG_ITEM_EXPORTHIGHLIGHTEDTEXT", "__Internal")]
		int TAG_ITEM_EXPORTHIGHLIGHTEDTEXT { get; }

		// extern const int TAG_ITEM_RESETFORM;
		[Field ("TAG_ITEM_RESETFORM", "__Internal")]
		int TAG_ITEM_RESETFORM { get; }

		// extern const int TAG_ITEM_IMPORTFORM;
		[Field ("TAG_ITEM_IMPORTFORM", "__Internal")]
		int TAG_ITEM_IMPORTFORM { get; }

		// extern const int TAG_ITEM_EXPORTFORM;
		[Field ("TAG_ITEM_EXPORTFORM", "__Internal")]
		int TAG_ITEM_EXPORTFORM { get; }

		// extern const int TAG_ITEM_SAVE_AS;
		[Field ("TAG_ITEM_SAVE_AS", "__Internal")]
		int TAG_ITEM_SAVE_AS { get; }

		// extern const int TAG_ITEM_REDUCEFILESIZE;
		[Field ("TAG_ITEM_REDUCEFILESIZE", "__Internal")]
		int TAG_ITEM_REDUCEFILESIZE { get; }

		// extern const int TAG_ITEM_WIRELESSPRINT;
		[Field ("TAG_ITEM_WIRELESSPRINT", "__Internal")]
		int TAG_ITEM_WIRELESSPRINT { get; }

		// extern const int TAG_ITEM_FLATTEN;
		[Field ("TAG_ITEM_FLATTEN", "__Internal")]
		int TAG_ITEM_FLATTEN { get; }

		// extern const int TAG_ITEM_SCREENCAPTURE;
		[Field ("TAG_ITEM_SCREENCAPTURE", "__Internal")]
		int TAG_ITEM_SCREENCAPTURE { get; }

		// extern const int TAG_ITEM_INFO;
		[Field ("TAG_ITEM_INFO", "__Internal")]
		int TAG_ITEM_INFO { get; }
	}

	// @protocol IMoreMenuViewListener <NSObject>
    [Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface IMoreMenuViewListener
	{
		// @required -(void)onMoreMenuChanged:(BOOL)isHidden;
		[Abstract]
		[Export ("onMoreMenuChanged:")]
		void OnMoreMenuChanged (bool isHidden);
	}

	// typedef void (^CancelCallback)();
	delegate void CancelCallback ();

	// @protocol MoreItemActionProtocol <NSObject>
    [Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface MoreItemActionProtocol
	{
		// @required -(void)onClick:(id<MoreItemProtocol> _Nonnull)item;
		[Abstract]
		[Export ("onClick:")]
		void OnClick (NSObject item);
	}

	// @protocol MoreItemProtocol <NSObject>
    [Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface MoreItemProtocol
	{
		// @required @property (assign, nonatomic) NSUInteger tag;
		[Abstract]
		[Export ("tag")]
		nuint Tag { get; set; }

		// @required @property (nonatomic, strong) NSString * _Nonnull title;
		[Abstract]
		[Export ("title", ArgumentSemantic.Strong)]
		string Title { get; set; }
	}

	// @interface MoreMenuItem : NSObject <MoreItemProtocol>
	[BaseType (typeof(NSObject))]
	interface MoreMenuItem : MoreItemProtocol
	{
		// @property (assign, nonatomic) NSUInteger tag;
		[Export ("tag")]
		nuint Tag { get; set; }

		// @property (nonatomic, strong) NSString * _Nonnull title;
		[Export ("title", ArgumentSemantic.Strong)]
		string Title { get; set; }

		// @property (assign, nonatomic) NSInteger iconId;
		[Export ("iconId")]
		nint IconId { get; set; }

		// @property (nonatomic, strong) UIImage * _Nonnull image;
		[Export ("image", ArgumentSemantic.Strong)]
		UIImage Image { get; set; }

		// @property (assign, nonatomic) BOOL enable;
		[Export ("enable")]
		bool Enable { get; set; }

		// @property (nonatomic, weak) id<MoreItemActionProtocol> _Nullable callBack;
		[NullAllowed, Export ("callBack", ArgumentSemantic.Weak)]
		NSObject CallBack { get; set; }

		// @property (nonatomic, strong) UIView * _Nonnull menuView;
		[Export ("menuView", ArgumentSemantic.Strong)]
		UIView MenuView { get; set; }
	}

	// @interface MoreMenuGroup : NSObject <MoreItemProtocol>
	[BaseType (typeof(NSObject))]
	interface MoreMenuGroup : MoreItemProtocol
	{
		// @property (assign, nonatomic) NSUInteger tag;
		[Export ("tag")]
		nuint Tag { get; set; }

		// @property (nonatomic, strong) NSString * _Nonnull title;
		[Export ("title", ArgumentSemantic.Strong)]
		string Title { get; set; }

		// -(NSMutableArray * _Nonnull)getItems;
		[Export ("getItems")]
		//[Verify (MethodToProperty)]
		NSMutableArray Items { get; }

		// @property (nonatomic, weak) id<MoreItemActionProtocol> _Nullable callBack;
		[NullAllowed, Export ("callBack", ArgumentSemantic.Weak)]
		NSObject CallBack { get; set; }

		// -(void)setItems:(NSMutableArray * _Nonnull)arr;
		[Export ("setItems:")]
		void SetItems (NSMutableArray arr);
	}

	// @interface MoreMenuView : NSObject
	[BaseType (typeof(NSObject))]
	interface MoreMenuView
	{
		// -(void)addGroup:(MoreMenuGroup * _Nonnull)group;
		[Export ("addGroup:")]
		void AddGroup (MoreMenuGroup group);

		// -(void)removeGroup:(NSUInteger)tag;
		[Export ("removeGroup:")]
		void RemoveGroup (nuint tag);

		// -(MoreMenuGroup * _Nonnull)getGroup:(NSUInteger)tag;
		[Export ("getGroup:")]
		MoreMenuGroup GetGroup (nuint tag);

		// -(void)addMenuItem:(NSUInteger)groupTag withItem:(MoreMenuItem * _Nonnull)item;
		[Export ("addMenuItem:withItem:")]
		void AddMenuItem (nuint groupTag, MoreMenuItem item);

		// -(void)removeMenuItem:(NSUInteger)groupTag WithItemTag:(NSUInteger)itemTag;
		[Export ("removeMenuItem:WithItemTag:")]
		void RemoveMenuItem (nuint groupTag, nuint itemTag);

		// -(void)addIndividualMenuItem:(MoreMenuItem * _Nonnull)item;
		[Export ("addIndividualMenuItem:")]
		void AddIndividualMenuItem (MoreMenuItem item);

		// -(void)removeIndividualMenuItemWithTag:(NSUInteger)itemTag;
		[Export ("removeIndividualMenuItemWithTag:")]
		void RemoveIndividualMenuItemWithTag (nuint itemTag);

		// -(MoreMenuItem * _Nonnull)getIndividualMenuItemWithTag:(NSUInteger)itemTag;
		[Export ("getIndividualMenuItemWithTag:")]
		MoreMenuItem GetIndividualMenuItemWithTag (nuint itemTag);

		// -(void)setIndividualMenuItemHiddenWithItemTag:(NSUInteger)itemTag hidden:(BOOL)isHidden;
		[Export ("setIndividualMenuItemHiddenWithItemTag:hidden:")]
		void SetIndividualMenuItemHiddenWithItemTag (nuint itemTag, bool isHidden);

		// -(UIView * _Nonnull)getContentView;
		[Export ("getContentView")]
		//[Verify (MethodToProperty)]
		UIView ContentView { get; }

		// -(void)setMenuTitle:(NSString * _Nonnull)title;
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

		// -(void)setTitleBarHidden:(BOOL)isHidden;
		[Export ("setTitleBarHidden:")]
		void SetTitleBarHidden (bool isHidden);

		// -(void)setFileLocationIcon:(UIImage * _Nonnull)icon;
		[Export ("setFileLocationIcon:")]
		void SetFileLocationIcon (UIImage icon);

		// -(void)registerEventListener:(id<IMoreMenuViewListener> _Nonnull)listener;
		[Export ("registerEventListener:")]
		void RegisterEventListener (NSObject listener);

		// -(void)unregisterEventListener:(id<IMoreMenuViewListener> _Nonnull)listener;
		[Export ("unregisterEventListener:")]
		void UnregisterEventListener (NSObject listener);
	}

	// @interface SettingObj : NSObject <NSCoding>
	[BaseType (typeof(NSObject))]
	interface SettingObj : INSCoding
	{
		// @property (copy, nonatomic) NSString * _Nullable icon;
		[NullAllowed, Export ("icon")]
		string Icon { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable textFace;
		[NullAllowed, Export ("textFace")]
		string TextFace { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable scaleFromUnit;
		[NullAllowed, Export ("scaleFromUnit")]
		string ScaleFromUnit { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable scaleToUnit;
		[NullAllowed, Export ("scaleToUnit")]
		string ScaleToUnit { get; set; }

		// @property (assign, nonatomic) CGFloat textSize;
		[Export ("textSize")]
		nfloat TextSize { get; set; }

		// @property (assign, nonatomic) CGFloat opacity;
		[Export ("opacity")]
		nfloat Opacity { get; set; }

		// @property (assign, nonatomic) float thickness;
		[Export ("thickness")]
		float Thickness { get; set; }

		// @property (assign, nonatomic) unsigned int rotation;
		[Export ("rotation")]
		uint Rotation { get; set; }

		// @property (assign, nonatomic) unsigned int scaleFromValue;
		[Export ("scaleFromValue")]
		uint ScaleFromValue { get; set; }

		// @property (assign, nonatomic) unsigned int scaleToValue;
		[Export ("scaleToValue")]
		uint ScaleToValue { get; set; }

		// @property (nonatomic, strong) UIColor * _Nullable color;
		[NullAllowed, Export ("color", ArgumentSemantic.Strong)]
		UIColor Color { get; set; }

		// @property (nonatomic, strong) UIColor * _Nullable fillColor;
		[NullAllowed, Export ("fillColor", ArgumentSemantic.Strong)]
		UIColor FillColor { get; set; }

		// @property (nonatomic, strong) UIColor * _Nullable textColor;
		[NullAllowed, Export ("textColor", ArgumentSemantic.Strong)]
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

		// @property (nonatomic, strong) SettingObj * _Nonnull areaHighlight;
		[Export ("areaHighlight", ArgumentSemantic.Strong)]
		SettingObj AreaHighlight { get; set; }

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

		// @property (nonatomic, strong) SettingObj * _Nonnull highlighter;
		[Export ("highlighter", ArgumentSemantic.Strong)]
		SettingObj Highlighter { get; set; }

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

		// @property (nonatomic, strong) SettingObj * _Nonnull measure;
		[Export ("measure", ArgumentSemantic.Strong)]
		SettingObj Measure { get; set; }

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

		// @property (assign, nonatomic) int enableTopbarDraggable;
		[Export ("enableTopbarDraggable")]
		int EnableTopbarDraggable { get; set; }

		// @property (assign, nonatomic) int enableHandwritingRecognition;
		[Export ("enableHandwritingRecognition")]
		int EnableHandwritingRecognition { get; set; }

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

		// @property (assign, nonatomic) BOOL fillSign;
		[Export ("fillSign")]
		bool FillSign { get; set; }

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

	// @interface FSReadToolSettings : SettingObj <NSCopying>
	[BaseType (typeof(SettingObj))]
	interface FSReadToolSettings : INSCopying
	{
		// @property (readonly, assign, nonatomic) unsigned int settingsColor;
		[Export ("settingsColor")]
		uint SettingsColor { get; }

		// @property (assign, nonatomic) int noteIcon;
		[Export ("noteIcon")]
		int NoteIcon { get; set; }

		// @property (assign, nonatomic) int stampIcon;
		[Export ("stampIcon")]
		int StampIcon { get; set; }

		// @property (assign, nonatomic) int attachmentIcon;
		[Export ("attachmentIcon")]
		int AttachmentIcon { get; set; }

		// @property (assign, nonatomic) float eraserLineWidth;
		[Export ("eraserLineWidth")]
		float EraserLineWidth { get; set; }

		// @property (assign, nonatomic) FSRotation screenAnnotRotation;
		[Export ("screenAnnotRotation", ArgumentSemantic.Assign)]
		FSRotation ScreenAnnotRotation { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull distanceUnit;
		[Export ("distanceUnit")]
		string DistanceUnit { get; set; }

		// @property (readonly, assign, nonatomic) FSReadToolSettingsType settingsType;
		[Export ("settingsType", ArgumentSemantic.Assign)]
		FSReadToolSettingsType SettingsType { get; }

		// -(instancetype _Nonnull)initWithToolSettingType:(FSReadToolSettingsType)type;
		[Export ("initWithToolSettingType:")]
		IntPtr Constructor (FSReadToolSettingsType type);

		// -(instancetype _Nonnull)initWithToolSettingType:(FSReadToolSettingsType)type extensionsManager:(UIExtensionsManager * _Nonnull)extensionsManager;
		[Export ("initWithToolSettingType:extensionsManager:")]
		IntPtr Constructor (FSReadToolSettingsType type, UIExtensionsManager extensionsManager);
	}

	// @interface FSReadToolbarItem : NSObject
	[BaseType (typeof(NSObject))]
	interface FSReadToolbarItem
	{
		// @property (readonly, nonatomic, strong) FSMainToolbarItem * _Nullable customItem;
		[NullAllowed, Export ("customItem", ArgumentSemantic.Strong)]
		FSMainToolbarItem CustomItem { get; }

		// @property (readonly, nonatomic, strong) FSReadToolSettings * _Nullable toolSettings;
		[NullAllowed, Export ("toolSettings", ArgumentSemantic.Strong)]
		FSReadToolSettings ToolSettings { get; }

		// @property (readonly, assign, nonatomic) FSReadToolSettingsType settingsType;
		[Export ("settingsType", ArgumentSemantic.Assign)]
		FSReadToolSettingsType SettingsType { get; }

		// @property (readonly, assign, nonatomic) FSReadToolbarItemType readToolbarItemType;
		[Export ("readToolbarItemType", ArgumentSemantic.Assign)]
		FSReadToolbarItemType ReadToolbarItemType { get; }

		// @property (readonly, nonatomic, strong) UIColor * _Nullable propertyColor;
		[NullAllowed, Export ("propertyColor", ArgumentSemantic.Strong)]
		UIColor PropertyColor { get; }

		// @property (assign, nonatomic) BOOL enabled;
		[Export ("enabled")]
		bool Enabled { get; set; }

		// @property (readonly, assign, nonatomic) FSItemContentType itemContentType;
		[Export ("itemContentType", ArgumentSemantic.Assign)]
		FSItemContentType ItemContentType { get; }

		// -(instancetype _Nonnull)initWithCustomItem:(FSMainToolbarItem * _Nonnull)customItem;
		[Export ("initWithCustomItem:")]
		IntPtr Constructor (FSMainToolbarItem customItem);

		// -(instancetype _Nonnull)initWithToolSettingType:(FSReadToolSettingsType)settingType;
		[Export ("initWithToolSettingType:")]
		IntPtr Constructor (FSReadToolSettingsType settingType);

		// -(instancetype _Nonnull)initWithToolSettingType:(FSReadToolSettingsType)settingType withItemContentType:(FSItemContentType)itemContentType;
		[Export ("initWithToolSettingType:withItemContentType:")]
		IntPtr Constructor (FSReadToolSettingsType settingType, FSItemContentType itemContentType);

		// -(instancetype _Nonnull)initWithToolSettings:(FSReadToolSettings * _Nonnull)toolSettings;
		[Export ("initWithToolSettings:")]
		IntPtr Constructor (FSReadToolSettings toolSettings);

		// -(instancetype _Nonnull)initWithToolSettings:(FSReadToolSettings * _Nonnull)toolSettings withItemContentType:(FSItemContentType)itemContentType;
		[Export ("initWithToolSettings:withItemContentType:")]
		IntPtr Constructor (FSReadToolSettings toolSettings, FSItemContentType itemContentType);

		// -(BOOL)replaceSettings:(FSReadToolSettings * _Nonnull)settings;
		[Export ("replaceSettings:")]
		bool ReplaceSettings (FSReadToolSettings settings);
	}

	// typedef void (^FSMenuItemAction)(FSMenuItem * _Nonnull);
	delegate void FSMenuItemAction (FSMenuItem arg0);

	// @interface FSMenuItem : NSObject
	[BaseType (typeof(NSObject))]
	interface FSMenuItem
	{
		// @property (readonly, assign, nonatomic) NSUInteger index;
		[Export ("index")]
		nuint Index { get; }

		// @property (copy, nonatomic) NSString * _Nonnull title;
		[Export ("title")]
		string Title { get; set; }

		// @property (nonatomic, strong) UIImage * _Nonnull image;
		[Export ("image", ArgumentSemantic.Strong)]
		UIImage Image { get; set; }

		// @property (copy, nonatomic) FSMenuItemAction _Nullable action;
		[NullAllowed, Export ("action", ArgumentSemantic.Copy)]
		FSMenuItemAction Action { get; set; }

		// -(instancetype _Nonnull)initWithTitle:(NSString * _Nonnull)title image:(UIImage * _Nonnull)image action:(FSMenuItemAction _Nonnull)action;
		[Export ("initWithTitle:image:action:")]
		IntPtr Constructor (string title, UIImage image, FSMenuItemAction action);
	}

	// @interface FSMenuItemGroup : NSObject
	[BaseType (typeof(NSObject))]
	interface FSMenuItemGroup
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

		// -(instancetype _Nonnull)initWithTitle:(NSString * _Nullable)title items:(NSArray<FSMenuItem *> * _Nonnull)items;
		[Export ("initWithTitle:items:")]
		IntPtr Constructor ([NullAllowed] string title, FSMenuItem[] items);
	}

	// @interface FSActionControlAttribute : NSString
	[BaseType (typeof(NSString))]
	interface FSActionControlAttribute
	{
		// @property (copy, nonatomic) NSString * _Nonnull normalTitle;
		[Export ("normalTitle")]
		string NormalTitle { get; set; }

		// @property (nonatomic, strong) UIColor * _Nonnull normalTitleColor;
		[Export ("normalTitleColor", ArgumentSemantic.Strong)]
		UIColor NormalTitleColor { get; set; }
	}

	// @protocol FSMenuView <NSObject>
    [Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface FSMenuView
	{
		// @required -(BOOL)shouldPresentByRDK;
		[Abstract]
		[Export ("shouldPresentByRDK")]
		//[Verify (MethodToProperty)]
		bool ShouldPresentByRDK { get; }

		// @optional @property (nonatomic, weak) UIViewController * _Nullable containerController;
		[NullAllowed, Export ("containerController", ArgumentSemantic.Weak)]
		UIViewController ContainerController { get; set; }

		// @optional -(UIView * _Nonnull)getCustomView;
		[Export ("getCustomView")]
		//[Verify (MethodToProperty)]
		UIView CustomView { get; }

		// @optional -(void)presentActionInMenuView;
		[Export ("presentActionInMenuView")]
		void PresentActionInMenuView ();

		// @optional -(void)presentActionInMenuViewByViewController:(UIViewController * _Nonnull (^ _Nonnull)(void))controller;
		[Export ("presentActionInMenuViewByViewController:")]
		void PresentActionInMenuViewByViewController (Func<UIViewController> controller);

		// @optional -(FSActionControlAttribute * _Nonnull)getActionControlAttribute;
		[Export ("getActionControlAttribute")]
		//[Verify (MethodToProperty)]
		FSActionControlAttribute ActionControlAttribute { get; }
	}

	// @interface FSMenuViewManager : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface FSMenuViewManager
	{
		// -(void)setMenuView:(id<FSMenuView> _Nonnull)menuView forMenuViewType:(FSMenuViewType)menuViewType;
		[Export ("setMenuView:forMenuViewType:")]
		void SetMenuView (NSObject menuView, FSMenuViewType menuViewType);

		// -(id<FSMenuView> _Nonnull)getMenuViewForMenuViewType:(FSMenuViewType)menuViewType;
		[Export ("getMenuViewForMenuViewType:")]
		NSObject GetMenuViewForMenuViewType (FSMenuViewType menuViewType);

		// -(void)addMenuItemGroup:(FSMenuItemGroup * _Nonnull)group forMenuViewType:(FSMenuViewType)menuViewType;
		[Export ("addMenuItemGroup:forMenuViewType:")]
		void AddMenuItemGroup (FSMenuItemGroup group, FSMenuViewType menuViewType);

		// -(void)insertMenuItemGroup:(FSMenuItemGroup * _Nonnull)group atIndex:(NSInteger)index forMenuViewType:(FSMenuViewType)menuViewType;
		[Export ("insertMenuItemGroup:atIndex:forMenuViewType:")]
		void InsertMenuItemGroup (FSMenuItemGroup group, nint index, FSMenuViewType menuViewType);

		// -(void)exchangeMenuItemGroupAtIndex:(NSInteger)index1 withMenuItemGroupAtIndex:(NSInteger)index2 forMenuViewType:(FSMenuViewType)menuViewType;
		[Export ("exchangeMenuItemGroupAtIndex:withMenuItemGroupAtIndex:forMenuViewType:")]
		void ExchangeMenuItemGroupAtIndex (nint index1, nint index2, FSMenuViewType menuViewType);

		// -(void)insertMenuItemGroup:(FSMenuItemGroup * _Nonnull)group beforeGroup:(FSMenuItemGroup * _Nonnull)siblingGroup forMenuViewType:(FSMenuViewType)menuViewType;
		[Export ("insertMenuItemGroup:beforeGroup:forMenuViewType:")]
		void InsertMenuItemGroupBefore (FSMenuItemGroup group, FSMenuItemGroup siblingGroup, FSMenuViewType menuViewType);

		// -(void)insertMenuItemGroup:(FSMenuItemGroup * _Nonnull)group afterGroup:(FSMenuItemGroup * _Nonnull)siblingGroup forMenuViewType:(FSMenuViewType)menuViewType;
		[Export ("insertMenuItemGroup:afterGroup:forMenuViewType:")]
		void InsertMenuItemGroupAfter (FSMenuItemGroup group, FSMenuItemGroup siblingGroup, FSMenuViewType menuViewType);

		// -(void)removeMenuItemGroup:(FSMenuItemGroup * _Nonnull)group forMenuViewType:(FSMenuViewType)menuViewType;
		[Export ("removeMenuItemGroup:forMenuViewType:")]
		void RemoveMenuItemGroup (FSMenuItemGroup group, FSMenuViewType menuViewType);

		// -(NSArray<FSMenuItemGroup *> * _Nonnull)getMenuItemGroupsForMenuViewType:(FSMenuViewType)menuViewType;
		[Export ("getMenuItemGroupsForMenuViewType:")]
		FSMenuItemGroup[] GetMenuItemGroupsForMenuViewType (FSMenuViewType menuViewType);
	}

	// @interface FSMainToolbarItem : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface FSMainToolbarItem
	{
		// @property (readonly, assign, nonatomic) FSMainToolbarItemType itemType;
		[Export ("itemType", ArgumentSemantic.Assign)]
		FSMainToolbarItemType ItemType { get; }

		// @property (assign, nonatomic) CGFloat spacing;
		[Export ("spacing")]
		nfloat Spacing { get; set; }

		// @property (assign, nonatomic) CGFloat width;
		[Export ("width")]
		nfloat Width { get; set; }

		// @property (readonly, nonatomic, strong) UIView * _Nullable customView;
		[NullAllowed, Export ("customView", ArgumentSemantic.Strong)]
		UIView CustomView { get; }

		// -(instancetype _Nonnull)initWithCustomView:(UIView * _Nonnull)customView;
		[Export ("initWithCustomView:")]
		IntPtr Constructor (UIView customView);
	}

	// @interface FSMainToolbar : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface FSMainToolbar
	{
		// @property (copy, nonatomic) NSArray<FSMainToolbarItem *> * _Nullable itemsForPositionLeft;
		[NullAllowed, Export ("itemsForPositionLeft", ArgumentSemantic.Copy)]
		FSMainToolbarItem[] ItemsForPositionLeft { get; set; }

		// @property (copy, nonatomic) NSArray<FSMainToolbarItem *> * _Nullable itemsForPositionCenter;
		[NullAllowed, Export ("itemsForPositionCenter", ArgumentSemantic.Copy)]
		FSMainToolbarItem[] ItemsForPositionCenter { get; set; }

		// @property (copy, nonatomic) NSArray<FSMainToolbarItem *> * _Nullable itemsForPositionRight;
		[NullAllowed, Export ("itemsForPositionRight", ArgumentSemantic.Copy)]
		FSMainToolbarItem[] ItemsForPositionRight { get; set; }

		// @property (assign, nonatomic) CGFloat contentHeight;
		[Export ("contentHeight")]
		nfloat ContentHeight { get; set; }

		// -(__kindof UIStackView * _Nonnull)getToolbarContentView;
		[Export ("getToolbarContentView")]
		//[Verify (MethodToProperty)]
		UIStackView ToolbarContentView { get; }

		// -(void)addItem:(FSMainToolbarItem * _Nonnull)item atPosition:(FSMainToolbarItemPosition)position;
		[Export ("addItem:atPosition:")]
		void AddItem (FSMainToolbarItem item, FSMainToolbarItemPosition position);

		// -(void)removeItemAtPosition:(FSMainToolbarItemPosition)position index:(NSUInteger)index;
		[Export ("removeItemAtPosition:index:")]
		void RemoveItemAtPosition (FSMainToolbarItemPosition position, nuint index);

		// -(void)removeItem:(FSMainToolbarItem * _Nonnull)item atPosition:(FSMainToolbarItemPosition)position;
		[Export ("removeItem:atPosition:")]
		void RemoveItem (FSMainToolbarItem item, FSMainToolbarItemPosition position);

		// -(void)setBackgroundColor:(UIColor * _Nonnull)color;
		[Export ("setBackgroundColor:")]
		void SetBackgroundColor (UIColor color);
	}

	// @interface FSMainTopbarToolTagItem : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface FSMainTopbarToolTagItem
	{
		// @property (copy, nonatomic) NSString * _Nonnull title;
		[Export ("title")]
		string Title { get; set; }

		// @property (nonatomic, strong) UIImage * _Nonnull image;
		[Export ("image", ArgumentSemantic.Strong)]
		UIImage Image { get; set; }

		// @property (nonatomic) UIEdgeInsets phoneTitleEdgeInsets;
		[Export ("phoneTitleEdgeInsets", ArgumentSemantic.Assign)]
		UIEdgeInsets PhoneTitleEdgeInsets { get; set; }

		// @property (nonatomic) UIEdgeInsets phoneImageEdgeInsets;
		[Export ("phoneImageEdgeInsets", ArgumentSemantic.Assign)]
		UIEdgeInsets PhoneImageEdgeInsets { get; set; }

		// @property (nonatomic) UIEdgeInsets padTitleEdgeInsets;
		[Export ("padTitleEdgeInsets", ArgumentSemantic.Assign)]
		UIEdgeInsets PadTitleEdgeInsets { get; set; }

		// @property (nonatomic) UIEdgeInsets padImageEdgeInsets;
		[Export ("padImageEdgeInsets", ArgumentSemantic.Assign)]
		UIEdgeInsets PadImageEdgeInsets { get; set; }

		// @property (copy, nonatomic) NSArray<FSReadToolbarItem *> * _Nullable readToolbarItems;
		[NullAllowed, Export ("readToolbarItems", ArgumentSemantic.Copy)]
		FSReadToolbarItem[] ReadToolbarItems { get; set; }

		// @property (copy, nonatomic) NSArray<FSMainToolbarItem *> * _Nullable mainToolbarItems;
		[NullAllowed, Export ("mainToolbarItems", ArgumentSemantic.Copy)]
		FSMainToolbarItem[] MainToolbarItems { get; set; }

		// @property (readonly, assign, nonatomic) FSMainTopbarToolTag toolTag;
		[Export ("toolTag", ArgumentSemantic.Assign)]
		FSMainTopbarToolTag ToolTag { get; }

		// @property (readonly, assign, nonatomic) BOOL isOnToolbar;
		[Export ("isOnToolbar")]
		bool IsOnToolbar { get; }

		// +(instancetype _Nonnull)ItemWithToolTag:(FSMainTopbarToolTag)toolTag readToolbarItems:(NSArray<FSReadToolbarItem *> * _Nullable)readToolbarItems;
		[Static]
		[Export ("ItemWithToolTag:readToolbarItems:")]
		FSMainTopbarToolTagItem ItemWithToolTag (FSMainTopbarToolTag toolTag, [NullAllowed] FSReadToolbarItem[] readToolbarItems);
	}

	// @protocol IFSMainTopbarEventListener <NSObject>
    [Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface IFSMainTopbarEventListener
	{
		// @optional -(void)didShowTagTabPopuper;
		[Export ("didShowTagTabPopuper")]
		void DidShowTagTabPopuper ();

		// @optional -(void)didDismissTagTabPopuper;
		[Export ("didDismissTagTabPopuper")]
		void DidDismissTagTabPopuper ();

		// @optional -(void)didSetCurrentTagItem:(FSMainTopbarToolTagItem * _Nonnull)curTagItem lastTagItem:(FSMainTopbarToolTagItem * _Nonnull)lastTagItem;
		[Export ("didSetCurrentTagItem:lastTagItem:")]
		void DidSetCurrentTagItem (FSMainTopbarToolTagItem curTagItem, FSMainTopbarToolTagItem lastTagItem);

		// @optional -(void)onSubitemViewChanged:(FSTopbarSubitemContentViewPosition)position;
		[Export ("onSubitemViewChanged:")]
		void OnSubitemViewChanged (FSTopbarSubitemContentViewPosition position);
	}

	// @interface FSMainTopbar : FSMainToolbar
	[BaseType (typeof(FSMainToolbar))]
	interface FSMainTopbar
	{
		// @property (copy, nonatomic) NSArray<FSMainTopbarToolTagItem *> * _Nullable tagItems;
		[NullAllowed, Export ("tagItems", ArgumentSemantic.Copy)]
		FSMainTopbarToolTagItem[] TagItems { get; set; }

		// @property (copy, nonatomic) NSArray<FSMainTopbarToolTagItem *> * _Nullable currentNewTagItems;
		[NullAllowed, Export ("currentNewTagItems", ArgumentSemantic.Copy)]
		FSMainTopbarToolTagItem[] CurrentNewTagItems { get; set; }

		// @property (readonly, nonatomic, strong) FSMainTopbarToolTagItem * _Nonnull currentTagItem;
		[Export ("currentTagItem", ArgumentSemantic.Strong)]
		FSMainTopbarToolTagItem CurrentTagItem { get; }

		// @property (assign, nonatomic) FSTopbarSubitemContentViewPosition subitemContentPosition;
		[Export ("subitemContentPosition", ArgumentSemantic.Assign)]
		FSTopbarSubitemContentViewPosition SubitemContentPosition { get; set; }

		// @property (assign, nonatomic) CGFloat horizontalContentHeight;
		[Export ("horizontalContentHeight")]
		nfloat HorizontalContentHeight { get; set; }

		// @property (assign, nonatomic) CGFloat verticalContentWidth;
		[Export ("verticalContentWidth")]
		nfloat VerticalContentWidth { get; set; }

		// @property (nonatomic, strong) __kindof UIView * _Nullable attachView;
		[NullAllowed, Export ("attachView", ArgumentSemantic.Strong)]
		UIView AttachView { get; set; }

		// -(void)resetCurrentTagItem;
		[Export ("resetCurrentTagItem")]
		void ResetCurrentTagItem ();

		// -(void)setStateBarColor:(UIColor * _Nullable)color;
		[Export ("setStateBarColor:")]
		void SetStateBarColor ([NullAllowed] UIColor color);

		// -(void)setTagItemBackgroudColor:(UIColor * _Nullable)color;
		[Export ("setTagItemBackgroudColor:")]
		void SetTagItemBackgroudColor ([NullAllowed] UIColor color);

		// -(void)registerEventListener:(id<IFSMainTopbarEventListener> _Nonnull)listener;
		[Export ("registerEventListener:")]
		void RegisterEventListener (NSObject listener);

		// -(void)unregisterEventListener:(id<IFSMainTopbarEventListener> _Nonnull)listener;
		[Export ("unregisterEventListener:")]
		void UnregisterEventListener (NSObject listener);
	}

	// @interface FSMainBottombar : FSMainToolbar
	[BaseType (typeof(FSMainToolbar))]
	interface FSMainBottombar
	{
		// @property (getter = isAverage, assign, nonatomic) BOOL average;
		[Export ("average")]
		bool Average { [Bind ("isAverage")] get; set; }
	}

	// @protocol FSMenuControlDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface FSMenuControlDelegate
	{
		// @required -(void)menuControlWillShow:(FSMenuControl * _Nonnull)menuControl menuControlScene:(FSMenuControlScene)menuControlScene;
		[Abstract]
		[Export ("menuControlWillShow:menuControlScene:")]
		void MenuControlScene (FSMenuControl menuControl, FSMenuControlScene menuControlScene);
	}

	// @interface FSMenuControl : NSObject
	[BaseType (typeof(NSObject))]
	interface FSMenuControl
	{
		// @property (copy, nonatomic) NSArray<FSMenuItem *> * _Nonnull menuItems;
		[Export ("menuItems", ArgumentSemantic.Copy)]
		FSMenuItem[] MenuItems { get; set; }

		// @property (assign, nonatomic) int pageIndex;
		[Export ("pageIndex")]
		int PageIndex { get; set; }

		// @property (assign, nonatomic) CGPoint displayPoint;
		[Export ("displayPoint", ArgumentSemantic.Assign)]
		CGPoint DisplayPoint { get; set; }
	}

	// typedef void (^CheckPermissionState)(FSPermissionState);
	delegate void CheckPermissionState (FSPermissionState arg0);

	// @protocol IFSPermissionProvider <NSObject>
    [Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface IFSPermissionProvider
	{
		// @required -(void)checkPermission:(FSFunction)function checkPermissionState:(CheckPermissionState _Nonnull)checkPermissionState;
		[Abstract]
		[Export ("checkPermission:checkPermissionState:")]
		void CheckPermission (FSFunction function, CheckPermissionState checkPermissionState);

		// @required -(FSPermissionState)checkPermission:(FSFunction)function;
		[Abstract]
		[Export ("checkPermission:")]
		FSPermissionState CheckPermission (FSFunction function);
	}

	// @interface FSAppInfoProvider : NSObject
	[BaseType (typeof(NSObject))]
	interface FSAppInfoProvider
	{
		// -(NSString * _Nonnull)getAppName;
		[Export ("getAppName")]
		//[Verify (MethodToProperty)]
		string AppName { get; }

		// -(NSString * _Nonnull)getAppVersion;
		[Export ("getAppVersion")]
		//[Verify (MethodToProperty)]
		string AppVersion { get; }

		// -(NSString * _Nonnull)getUserName;
		[Export ("getUserName")]
		//[Verify (MethodToProperty)]
		string UserName { get; }
	}

	// @protocol IModule <NSObject>
    [Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface IModule
	{
		// @required -(FSModuleStringName _Nonnull)getName;
		[Abstract]
		[Export ("getName")]
		//[Verify (MethodToProperty)]
		string Name { get; }
	}

	// @protocol FSAnnotsPermissionDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface FSAnnotsPermissionDelegate
	{
		// @optional -(BOOL)canAddAnnot;
		[Export ("canAddAnnot")]
		//[Verify (MethodToProperty)]
		bool CanAddAnnot { get; }

		// @optional -(BOOL)canModifyAnnot;
		[Export ("canModifyAnnot")]
		//[Verify (MethodToProperty)]
		bool CanModifyAnnot { get; }

		// @optional -(BOOL)canDeleteAnnot;
		[Export ("canDeleteAnnot")]
		//[Verify (MethodToProperty)]
		bool CanDeleteAnnot { get; }
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

		// @optional -(void)onAnnotWillFlatten:(FSPDFPage * _Nonnull)page annot:(FSAnnot * _Nonnull)annot;
		[Export ("onAnnotWillFlatten:annot:")]
		void OnAnnotWillFlatten (FSPDFPage page, FSAnnot annot);

		// @optional -(void)onAnnotFlattened:(FSPDFPage * _Nonnull)page annot:(FSAnnot * _Nonnull)annot;
		[Export ("onAnnotFlattened:annot:")]
		void OnAnnotFlattened (FSPDFPage page, FSAnnot annot);

		// @optional -(void)onAnnotsAdded:(NSArray<FSAnnot *> * _Nonnull)annots;
		[Export ("onAnnotsAdded:")]
		void OnAnnotsAdded (FSAnnot[] annots);

		// @optional -(void)onAnnotsWillDelete:(NSArray<FSAnnot *> * _Nonnull)annots;
		[Export ("onAnnotsWillDelete:")]
		void OnAnnotsWillDelete (FSAnnot[] annots);
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

		// @optional @property (nonatomic, weak) FSReadToolSettings * _Nullable toolSettings;
		[NullAllowed, Export ("toolSettings", ArgumentSemantic.Weak)]
		FSReadToolSettings ToolSettings { get; set; }

		// @optional -(void)onDraw:(int)pageIndex inContext:(CGContextRef _Nonnull)context;
		[Export ("onDraw:inContext:")]
		void OnDraw (int pageIndex, CGContext context);

		// @optional -(BOOL)shouldDrawAnnot:(FSAnnot * _Nonnull)annot inPDFViewCtrl:(FSPDFViewCtrl * _Nonnull)pdfViewCtrl;
		[Export ("shouldDrawAnnot:inPDFViewCtrl:")]
		bool ShouldDrawAnnot (FSAnnot annot, FSPDFViewCtrl pdfViewCtrl);
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

		// @optional -(BOOL)flattenAnnot:(FSAnnot * _Nonnull)annot;
		[Export ("flattenAnnot:")]
		bool FlattenAnnot (FSAnnot annot);

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
		void OnDraw (int pageIndex, CGContext context, [NullAllowed] FSAnnot annot);

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
		void OnDraw (int pageIndex, CGContext context, [NullAllowed] FSXFAWidget widget);
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

	// @protocol IDocModifiedEventListener <NSObject>
    [Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface IDocModifiedEventListener
	{
		// @optional -(void)onDocModified:(FSPDFDoc * _Nonnull)doc;
		[Export ("onDocModified:")]
		void OnDocModified (FSPDFDoc doc);
	}

	// @protocol ISignatureEventListener <NSObject>
    [Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface ISignatureEventListener
	{
		// @optional -(void)onDigitalSignatureSigned:(BOOL)success;
		[Export ("onDigitalSignatureSigned:")]
		void OnDigitalSignatureSigned (bool success);

		// @optional -(void)onDigitalSignatureSigned:(BOOL)success originalDoc:(FSPDFDoc * _Nonnull)originalDoc outputPath:(NSString * _Nonnull)outputPath;
		[Export ("onDigitalSignatureSigned:originalDoc:outputPath:")]
		void OnDigitalSignatureSigned (bool success, FSPDFDoc originalDoc, string outputPath);

		// @optional -(BOOL)canReplaceDigitalSignatureOriginalFile:(NSString * _Nonnull)originalFile;
		[Export ("canReplaceDigitalSignatureOriginalFile:")]
		bool CanReplaceDigitalSignatureOriginalFile (string originalFile);
	}

	// @protocol IUIInteractionEventListener <NSObject>
    [Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface IUIInteractionEventListener
	{
		// @required -(void)onUIInteractElementClicked:(FSUIElementType)element;
		[Abstract]
		[Export ("onUIInteractElementClicked:")]
		void OnUIInteractElementClicked (FSUIElementType element);
	}

	// @protocol FSExtFileOpenDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface FSExtFileOpenDelegate
	{
		// @optional -(BOOL)openFileAtPath:(NSString * _Nonnull)filePath;
		[Export ("openFileAtPath:")]
		bool OpenFileAtPath (string filePath);
	}

	// @protocol UIExtensionsManagerDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface UIExtensionsManagerDelegate
	{
		// @optional -(void)uiextensionsManager:(UIExtensionsManager * _Nonnull)uiextensionsManager onToolBar:(FSToolbarType)type hidden:(BOOL)hidden;
		[Export ("uiextensionsManager:onToolBar:hidden:")]
		void UiextensionsManager (UIExtensionsManager uiextensionsManager, FSToolbarType type, bool hidden);

		// @optional -(BOOL)uiextensionsManager:(UIExtensionsManager * _Nonnull)uiextensionsManager openNewDocAtPath:(NSString * _Nonnull)path shouldCloseCurrentDoc:(BOOL)closeCurrentDoc completionCallBack:(void (^ _Nonnull)(void))completionCallBack;
		[Export ("uiextensionsManager:openNewDocAtPath:shouldCloseCurrentDoc:completionCallBack:")]
		bool UiextensionsManager (UIExtensionsManager uiextensionsManager, string path, bool closeCurrentDoc, Action completionCallBack);

		// @optional -(void)quitUIExtensionsManager:(UIExtensionsManager * _Nonnull)uiextensionsManager control:(UIControl * _Nonnull)control;
		[Export ("quitUIExtensionsManager:control:")]
		void QuitUIExtensionsManager (UIExtensionsManager uiextensionsManager, UIControl control);
	}

	// @interface UIExtensionsManager : NSObject <FSPDFUIExtensionsManager, IDocEventListener, IPageEventListener, IRotationEventListener, IAnnotEventListener, IRecoveryEventListener, ILinkEventListener, UIToolbarDelegate, ISignatureEventListener, IUIInteractionEventListener>
	[BaseType (typeof(NSObject))]
	interface UIExtensionsManager : IFSPDFUIExtensionsManager, IIDocEventListener, IIPageEventListener, IIRotationEventListener, IAnnotEventListener, IIRecoveryEventListener, ILinkEventListener, IUIToolbarDelegate, ISignatureEventListener, IUIInteractionEventListener
	{
		// @property (assign, nonatomic, class) UIStatusBarStyle preferredStatusBarStyle;
		[Static]
		[Export ("preferredStatusBarStyle", ArgumentSemantic.Assign)]
		UIStatusBarStyle PreferredStatusBarStyle { get; set; }

		// @property (nonatomic, strong, class) UIColor * _Nonnull primaryColor;
		[Static]
		[Export ("primaryColor", ArgumentSemantic.Strong)]
		UIColor PrimaryColor { get; set; }

		// @property (nonatomic, strong, class) UIColor * _Nonnull stateBarColor;
		[Static]
		[Export ("stateBarColor", ArgumentSemantic.Strong)]
		UIColor StateBarColor { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull annotAuthor;
		[Export ("annotAuthor")]
		string AnnotAuthor { get; set; }

		// @property (readonly, nonatomic, strong) FSPDFViewCtrl * _Nonnull pdfViewCtrl;
		[Export ("pdfViewCtrl", ArgumentSemantic.Strong)]
		FSPDFViewCtrl PdfViewCtrl { get; }

		// @property (readonly, nonatomic, strong) MoreMenuView * _Nonnull more;
		[Export ("more", ArgumentSemantic.Strong)]
		MoreMenuView More { get; }

		// @property (readonly, nonatomic, strong) FSMenuViewManager * _Nonnull menuViewManager;
		[Export ("menuViewManager", ArgumentSemantic.Strong)]
		FSMenuViewManager MenuViewManager { get; }

		// @property (nonatomic, strong) NSMutableDictionary<NSNumber *,FSReadToolSettings *> * _Nonnull addToolsSettings;
		[Export ("addToolsSettings", ArgumentSemantic.Strong)]
		NSMutableDictionary<NSNumber, FSReadToolSettings> AddToolsSettings { get; set; }

		[Wrap ("WeakDelegate")]
		[NullAllowed]
		NSObject Delegate { get; set; }

		// @property (nonatomic, weak) id<UIExtensionsManagerDelegate> _Nullable delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// @property (nonatomic, strong) id<IToolHandler> _Nullable currentToolHandler;
		[NullAllowed, Export ("currentToolHandler", ArgumentSemantic.Strong)]
		NSObject CurrentToolHandler { get; set; }

		// @property (assign, nonatomic) BOOL canUpdateAnnotDefaultProperties;
		[Export ("canUpdateAnnotDefaultProperties")]
		bool CanUpdateAnnotDefaultProperties { get; set; }

		// @property (nonatomic, strong) FSAnnot * _Nullable currentAnnot;
		[NullAllowed, Export ("currentAnnot", ArgumentSemantic.Strong)]
		FSAnnot CurrentAnnot { get; set; }

		// @property (assign, nonatomic) BOOL enableLinks;
		[Export ("enableLinks")]
		bool EnableLinks { get; set; }

		// @property (assign, nonatomic) BOOL enableHighlightLinks;
		[Export ("enableHighlightLinks")]
		bool EnableHighlightLinks { get; set; }

		// @property (assign, nonatomic) BOOL enableHighlightForm;
		[Export ("enableHighlightForm")]
		bool EnableHighlightForm { get; set; }

		// @property (nonatomic, strong) UIColor * _Nonnull linksHighlightColor;
		[Export ("linksHighlightColor", ArgumentSemantic.Strong)]
		UIColor LinksHighlightColor { get; set; }

		// @property (nonatomic, strong) UIColor * _Nonnull selectionHighlightColor;
		[Export ("selectionHighlightColor", ArgumentSemantic.Strong)]
		UIColor SelectionHighlightColor { get; set; }

		// @property (nonatomic, strong) UIColor * _Nonnull highlightFormColor;
		[Export ("highlightFormColor", ArgumentSemantic.Strong)]
		UIColor HighlightFormColor { get; set; }

		// @property (copy, nonatomic) void (^ _Nullable)(void) goBack;
		[NullAllowed, Export ("goBack", ArgumentSemantic.Copy)]
		Action GoBack { get; set; }

		// @property (readonly, nonatomic, strong) FSMainTopbar * _Nullable topToolbar;
		[NullAllowed, Export ("topToolbar", ArgumentSemantic.Strong)]
		FSMainTopbar TopToolbar { get; }

		// @property (readonly, nonatomic, strong) FSMainBottombar * _Nullable bottomToolbar;
		[NullAllowed, Export ("bottomToolbar", ArgumentSemantic.Strong)]
		FSMainBottombar BottomToolbar { get; }

		// @property (nonatomic, strong) FSPanelController * _Nonnull panelController;
		[Export ("panelController", ArgumentSemantic.Strong)]
		FSPanelController PanelController { get; set; }

		// @property (nonatomic, strong) FSSettingBar * _Nonnull settingBar;
		[Export ("settingBar", ArgumentSemantic.Strong)]
		FSSettingBar SettingBar { get; set; }

		// @property (assign, nonatomic) BOOL continueAddAnnot;
		[Export ("continueAddAnnot")]
		bool ContinueAddAnnot { get; set; }

		// @property (assign, nonatomic) BOOL isFullScreen;
		[Export ("isFullScreen")]
		bool IsFullScreen { get; set; }

		// @property (readonly, assign, nonatomic) BOOL isScreenLocked;
		[Export ("isScreenLocked")]
		bool IsScreenLocked { get; }

		// @property (nonatomic, strong) NSString * _Nonnull preventOverrideFilePath;
		[Export ("preventOverrideFilePath", ArgumentSemantic.Strong)]
		string PreventOverrideFilePath { get; set; }

		// @property (assign, nonatomic, setter = setDocModified:) BOOL isDocModified;
		[Export ("isDocModified")]
		bool IsDocModified { get; [Bind ("setDocModified:")] set; }

		// @property (assign, nonatomic) BOOL isMultiFileMode;
		[Export ("isMultiFileMode")]
		bool IsMultiFileMode { get; set; }

		// @property (assign, nonatomic, setter = setAutoSaveDoc:) BOOL isAutoSaveDoc;
		[Export ("isAutoSaveDoc")]
		bool IsAutoSaveDoc { get; [Bind ("setAutoSaveDoc:")] set; }

		// @property (assign, nonatomic) FSPDFDocSaveFlags docSaveFlag;
		[Export ("docSaveFlag", ArgumentSemantic.Assign)]
		FSPDFDocSaveFlags DocSaveFlag { get; set; }

		// @property (nonatomic, strong) id<FSActionCallback> _Nonnull actionHandler;
		[Export ("actionHandler", ArgumentSemantic.Strong)]
		FSActionCallback ActionHandler { get; set; }

		// @property (nonatomic, strong) FSXFAWidget * _Nullable currentWidget;
		[NullAllowed, Export ("currentWidget", ArgumentSemantic.Strong)]
		FSXFAWidget CurrentWidget { get; set; }

		// @property (assign, nonatomic, setter = setAutoSaveSignedDoc:) BOOL isAutoSaveSignedDoc;
		[Export ("isAutoSaveSignedDoc")]
		bool IsAutoSaveSignedDoc { get; [Bind ("setAutoSaveSignedDoc:")] set; }

		// @property (nonatomic, strong) NSString * _Nonnull signedDocSavePath;
		[Export ("signedDocSavePath", ArgumentSemantic.Strong)]
		string SignedDocSavePath { get; set; }

		// @property (readonly, assign, nonatomic) BOOL prefersStatusBarHidden;
		[Export ("prefersStatusBarHidden")]
		bool PrefersStatusBarHidden { get; }

		[Wrap ("WeakAnnotsPermissionDelegate")]
		[NullAllowed]
		NSObject AnnotsPermissionDelegate { get; set; }

		// @property (nonatomic, weak) id<FSAnnotsPermissionDelegate> _Nullable annotsPermissionDelegate;
		[NullAllowed, Export ("annotsPermissionDelegate", ArgumentSemantic.Weak)]
		NSObject WeakAnnotsPermissionDelegate { get; set; }

		[Wrap ("WeakMenuControlDelegate")]
		[NullAllowed]
		NSObject MenuControlDelegate { get; set; }

		// @property (nonatomic, weak) id<FSMenuControlDelegate> _Nullable menuControlDelegate;
		[NullAllowed, Export ("menuControlDelegate", ArgumentSemantic.Weak)]
		NSObject WeakMenuControlDelegate { get; set; }

		// @property (nonatomic, weak) id<IFSPermissionProvider> _Nullable permissionProvider;
		[NullAllowed, Export ("permissionProvider", ArgumentSemantic.Weak)]
		NSObject PermissionProvider { get; set; }

		// @property (nonatomic, strong) FSAppInfoProvider * _Nonnull appInfoProvider;
		[Export ("appInfoProvider", ArgumentSemantic.Strong)]
		FSAppInfoProvider AppInfoProvider { get; set; }

		[Wrap ("WeakExtFileOpenDelegate")]
		[NullAllowed]
		NSObject ExtFileOpenDelegate { get; set; }

		// @property (nonatomic, weak) id<FSExtFileOpenDelegate> _Nullable extFileOpenDelegate;
		[NullAllowed, Export ("extFileOpenDelegate", ArgumentSemantic.Weak)]
		NSObject WeakExtFileOpenDelegate { get; set; }

		// @property (assign, nonatomic) BOOL disableFingerWhenLinkApplePencil;
		[Export ("disableFingerWhenLinkApplePencil")]
		bool DisableFingerWhenLinkApplePencil { get; set; }

		// @property (readonly, nonatomic, weak) API_AVAILABLE(ios(13.0)) UIWindowScene * windowScene __attribute__((availability(ios, introduced=13.0)));
#if !NET
    [iOS (13, 0)]
#endif
		[Export ("windowScene", ArgumentSemantic.Weak)]
		UIWindowScene WindowScene { get; }

		// @property (assign, nonatomic) BOOL useLogicalPageNumbers;
		[Export ("useLogicalPageNumbers")]
		bool UseLogicalPageNumbers { get; set; }

		// @property (assign, nonatomic) FSMeasurementUnits measurementUnits;
		[Export ("measurementUnits", ArgumentSemantic.Assign)]
		FSMeasurementUnits MeasurementUnits { get; set; }

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
		void RegisterFullScreenListener (NSObject listener);

		// -(void)unregisterFullScreenListener:(id<IFullScreenListener> _Nonnull)listener;
		[Export ("unregisterFullScreenListener:")]
		void UnregisterFullScreenListener (NSObject listener);

		// -(void)registerPageNumberListener:(id<IPageNumberListener> _Nonnull)listener;
		[Export ("registerPageNumberListener:")]
		void RegisterPageNumberListener (NSObject listener);

		// -(void)unregisterPageNumerListener:(id<IPageNumberListener> _Nonnull)listener;
		[Export ("unregisterPageNumerListener:")]
		void UnregisterPageNumerListener (NSObject listener);

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

		// -(void)enableSmallTopToolbar:(BOOL)isEnabled;
		[Export ("enableSmallTopToolbar:")]
		void EnableSmallTopToolbar (bool isEnabled);

		// -(void)enableSmallBottomToolbar:(BOOL)isEnabled;
		[Export ("enableSmallBottomToolbar:")]
		void EnableSmallBottomToolbar (bool isEnabled);

		// -(id<IToolHandler> _Nonnull)getToolHandlerByName:(NSString * _Nonnull)name;
		[Export ("getToolHandlerByName:")]
		NSObject GetToolHandlerByName (string name);

		// -(id<IAnnotHandler> _Nonnull)getAnnotHandlerByType:(FSAnnotType)type;
		[Export ("getAnnotHandlerByType:")]
		NSObject GetAnnotHandlerByType (FSAnnotType type);

		// -(void)registerToolHandler:(id<IToolHandler> _Nonnull)toolHandler;
		[Export ("registerToolHandler:")]
		void RegisterToolHandler (NSObject toolHandler);

		// -(void)unregisterToolHandler:(id<IToolHandler> _Nonnull)toolHandler;
		[Export ("unregisterToolHandler:")]
		void UnregisterToolHandler (NSObject toolHandler);

		// -(void)registerAnnotHandler:(id<IAnnotHandler> _Nonnull)annotHandler;
		[Export ("registerAnnotHandler:")]
		void RegisterAnnotHandler (NSObject annotHandler);

		// -(void)unregisterAnnotHandler:(id<IAnnotHandler> _Nonnull)annotHandler;
		[Export ("unregisterAnnotHandler:")]
		void UnregisterAnnotHandler (NSObject annotHandler);

		// -(void)registerAnnotEventListener:(id<IAnnotEventListener> _Nonnull)listener;
		[Export ("registerAnnotEventListener:")]
		void RegisterAnnotEventListener (NSObject listener);

		// -(void)unregisterAnnotEventListener:(id<IAnnotEventListener> _Nonnull)listener;
		[Export ("unregisterAnnotEventListener:")]
		void UnregisterAnnotEventListener (NSObject listener);

		// -(void)registerToolEventListener:(id<IToolEventListener> _Nonnull)listener;
		[Export ("registerToolEventListener:")]
		void RegisterToolEventListener (NSObject listener);

		// -(void)unregisterToolEventListener:(id<IToolEventListener> _Nonnull)listener;
		[Export ("unregisterToolEventListener:")]
		void UnregisterToolEventListener (NSObject listener);

		// -(void)registerDocModifiedEventListener:(id<IDocModifiedEventListener> _Nonnull)listener;
		[Export ("registerDocModifiedEventListener:")]
		void RegisterDocModifiedEventListener (NSObject listener);

		// -(void)unregisterDocModifiedEventListener:(id<IDocModifiedEventListener> _Nonnull)listener;
		[Export ("unregisterDocModifiedEventListener:")]
		void UnregisterDocModifiedEventListener (NSObject listener);

		// -(void)registerLinkEventListener:(id<ILinkEventListener> _Nonnull)listener;
		[Export ("registerLinkEventListener:")]
		void RegisterLinkEventListener (NSObject listener);

		// -(void)unregisterLinkEventListener:(id<ILinkEventListener> _Nonnull)listener;
		[Export ("unregisterLinkEventListener:")]
		void UnregisterLinkEventListener (NSObject listener);

		// -(void)registerSignatureEventListener:(id<ISignatureEventListener> _Nonnull)listener;
		[Export ("registerSignatureEventListener:")]
		void RegisterSignatureEventListener (NSObject listener);

		// -(void)unregisterSignatureEventListener:(id<ISignatureEventListener> _Nonnull)listener;
		[Export ("unregisterSignatureEventListener:")]
		void UnregisterSignatureEventListener (NSObject listener);

		// -(void)registerUIInteractionEventListener:(id<IUIInteractionEventListener> _Nonnull)listener;
		[Export ("registerUIInteractionEventListener:")]
		void RegisterUIInteractionEventListener (NSObject listener);

		// -(void)unregisterUIInteractionEventListener:(id<IUIInteractionEventListener> _Nonnull)listener;
		[Export ("unregisterUIInteractionEventListener:")]
		void UnregisterUIInteractionEventListener (NSObject listener);

		// -(void)showPropertyWithToolSettings:(FSReadToolSettings * _Nonnull)toolSettings rect:(CGRect)rect inView:(UIView * _Nonnull)view;
		[Export ("showPropertyWithToolSettings:rect:inView:")]
		void ShowPropertyWithToolSettings (FSReadToolSettings toolSettings, CGRect rect, UIView view);

		// -(void)showSearchBar:(BOOL)show;
		[Export ("showSearchBar:")]
		void ShowSearchBar (bool show);

		// -(void)registerSearchEventListener:(id<ISearchEventListener> _Nonnull)listener;
		[Export ("registerSearchEventListener:")]
		void RegisterSearchEventListener (NSObject listener);

		// -(void)unregisterSearchEventListener:(id<ISearchEventListener> _Nonnull)listener;
		[Export ("unregisterSearchEventListener:")]
		void UnregisterSearchEventListener (NSObject listener);

		// -(NSString * _Nonnull)getCurrentSelectedText;
		[Export ("getCurrentSelectedText")]
		//[Verify (MethodToProperty)]
		string CurrentSelectedText { get; }

		// -(__kindof id<IModule> _Nonnull)getModuleByName:(FSModuleStringName _Nonnull)name;
		[Export ("getModuleByName:")]
		NSObject GetModuleByName (string name);

		// -(void)setFullScreen:(BOOL)fullScreen;
		[Export ("setFullScreen:")]
		void SetFullScreen (bool fullScreen);

		// -(void)suspendAutoFullScreen;
		[Export ("suspendAutoFullScreen")]
		void SuspendAutoFullScreen ();

		// -(void)resumeAutoFullScreen;
		[Export ("resumeAutoFullScreen")]
		void ResumeAutoFullScreen ();

		// +(void)printDoc:(FSPDFDoc * _Nonnull)doc animated:(BOOL)animated inWindow:(UIWindow * _Nonnull)window jobName:(NSString * _Nullable)jobName delegate:(id<UIPrintInteractionControllerDelegate> _Nullable)delegate completionHandler:(UIPrintInteractionCompletionHandler _Nullable)completion;
		[Static]
		[Export ("printDoc:animated:inWindow:jobName:delegate:completionHandler:")]
		void PrintDoc (FSPDFDoc doc, bool animated, UIWindow window, [NullAllowed] string jobName, [NullAllowed] UIPrintInteractionControllerDelegate @delegate, [NullAllowed] UIPrintInteractionCompletionHandler completion);

		// +(void)printDoc:(FSPDFDoc * _Nonnull)doc fromRect:(CGRect)rect inView:(UIView * _Nonnull)view animated:(BOOL)animated inWindow:(UIWindow * _Nonnull)window jobName:(NSString * _Nullable)jobName delegate:(id<UIPrintInteractionControllerDelegate> _Nullable)delegate completionHandler:(UIPrintInteractionCompletionHandler _Nullable)completion;
		[Static]
		[Export ("printDoc:fromRect:inView:animated:inWindow:jobName:delegate:completionHandler:")]
		void PrintDoc (FSPDFDoc doc, CGRect rect, UIView view, bool animated, UIWindow window, [NullAllowed] string jobName, [NullAllowed] UIPrintInteractionControllerDelegate @delegate, [NullAllowed] UIPrintInteractionCompletionHandler completion);

		// -(FSReadToolSettings * _Nonnull)getReadToolSettingsForType:(FSReadToolSettingsType)settingsType;
		[Export ("getReadToolSettingsForType:")]
		FSReadToolSettings GetReadToolSettingsForType (FSReadToolSettingsType settingsType);

		// -(FSUIManagerState)getState;
		[Export ("getState")]
		//[Verify (MethodToProperty)]
		FSUIManagerState State { get; }

		// -(void)changeState:(FSUIManagerState)state;
		[Export ("changeState:")]
		void ChangeState (FSUIManagerState state);

		// -(void)documentSaveAS:(void (^ _Nullable)(void))successed error:(void (^ _Nullable)(void))error;
		[Export ("documentSaveAS:error:")]
		void DocumentSaveAS ([NullAllowed] Action successed, [NullAllowed] Action error);

		// -(void)setMoreItemClikedCallback:(void (^ _Nonnull)(UIView * _Nonnull))clickedCallback;
		[Export ("setMoreItemClikedCallback:")]
		void SetMoreItemClikedCallback (Action<UIView> clickedCallback);

		// -(NSMutableDictionary * _Nonnull)getToolbarItemHiddenStatus;
		[Export ("getToolbarItemHiddenStatus")]
		//[Verify (MethodToProperty)]
		NSMutableDictionary ToolbarItemHiddenStatus { get; }

		// -(void)setToolbarItemHiddenWithTag:(FS_TOOLBAR_ITEM_TAG)itemTag hidden:(BOOL)isHidden;
		[Export ("setToolbarItemHiddenWithTag:hidden:")]
		void SetToolbarItemHiddenWithTag (int itemTag, bool isHidden);

		// -(void)enableModification:(BOOL)isEnabled;
		[Export ("enableModification:")]
		void EnableModification (bool isEnabled);
	}

	// @interface SupportsMultipleScenes (UIExtensionsManager) <FSPDFMultipleScenes>
	[Category]
	[BaseType (typeof(UIExtensionsManager))]
	interface UIExtensionsManager_SupportsMultipleScenes 
	{
		// @property (nonatomic, weak, class) UIExtensionsManager * _Nullable currentExtManager;
		[Static]
		[NullAllowed, Export ("currentExtManager", ArgumentSemantic.Weak)]
		UIExtensionsManager CurrentExtManager { get; set; }

		// +(NSSet<NSObject> * _Nonnull)openedExtensionsManagers;
		[Static]
		[Export ("openedExtensionsManagers")]
		//[Verify (MethodToProperty)]
		NSSet<NSObject> OpenedExtensionsManagers { get; }
	}

	// @interface SignatureModule : NSObject <IDocEventListener, IToolEventListener>
	[BaseType (typeof(NSObject))]
	interface SignatureModule : IIDocEventListener, IToolEventListener
	{
		// @property (readonly, getter = getSignatureViewTopBar, nonatomic, strong) FSMainToolbar * signatureViewTopBar;
		[Export ("signatureViewTopBar", ArgumentSemantic.Strong)]
		FSMainToolbar SignatureViewTopBar { [Bind ("getSignatureViewTopBar")] get; }

		// @property (copy, nonatomic) void (^signatureViewHasChanged)(BOOL);
		[Export ("signatureViewHasChanged", ArgumentSemantic.Copy)]
		Action<bool> SignatureViewHasChanged { get; set; }

		// -(instancetype)initWithExtensionsManager:(UIExtensionsManager *)extensionsManager;
		[Export ("initWithExtensionsManager:")]
		IntPtr Constructor (UIExtensionsManager extensionsManager);

		// -(UIImage *)getSignatureViewImage;
		[Export ("getSignatureViewImage")]
		//[Verify (MethodToProperty)]
		UIImage SignatureViewImage { get; }
	}

	// @interface ThumbnailModule : NSObject <IModule>
	[BaseType (typeof(NSObject))]
	interface ThumbnailModule : IModule
	{
		// -(instancetype _Nonnull)initWithExtensionsManager:(UIExtensionsManager * _Nonnull)extensionsManager;
		[Export ("initWithExtensionsManager:")]
		IntPtr Constructor (UIExtensionsManager extensionsManager);

		// -(void)showThumbnailView;
		[Export ("showThumbnailView")]
		void ShowThumbnailView ();

		// -(FSPDFDoc * _Nonnull)getCurrnetDocForSelectedPageIndexs;
		[Export ("getCurrnetDocForSelectedPageIndexs")]
		//[Verify (MethodToProperty)]
		FSPDFDoc CurrnetDocForSelectedPageIndexs { get; }

		// -(void)improtDocumentFromPath:(NSString * _Nonnull)path success:(void (^ _Nonnull)(NSString * _Nonnull))success error:(void (^ _Nonnull)(NSString * _Nonnull))error;
		[Export ("improtDocumentFromPath:success:error:")]
		void ImprotDocumentFromPath (string path, Action<NSString> success, Action<NSString> error);
	}

	// @interface FSHistoryDataItem : NSObject <NSCoding>
	[BaseType (typeof(NSObject))]
	interface FSHistoryDataItem : INSCoding
	{
		// @property (nonatomic, strong) NSDate * _Nonnull createDate;
		[Export ("createDate", ArgumentSemantic.Strong)]
		NSDate CreateDate { get; set; }

		// @property (nonatomic, strong) NSDate * _Nonnull lastUseDate;
		[Export ("lastUseDate", ArgumentSemantic.Strong)]
		NSDate LastUseDate { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull content;
		[Export ("content")]
		string Content { get; set; }
	}

	// @interface FSHistoryDataConfig : NSObject <NSCoding>
	[BaseType (typeof(NSObject))]
	interface FSHistoryDataConfig : INSCoding
	{
		// @property (assign, nonatomic) BOOL enable;
		[Export ("enable")]
		bool Enable { get; set; }

		// @property (assign, nonatomic) FSInteractiveScene scene;
		[Export ("scene", ArgumentSemantic.Assign)]
		FSInteractiveScene Scene { get; set; }

		// @property (assign, nonatomic) FSHistoryDataSortKey sortKey;
		[Export ("sortKey", ArgumentSemantic.Assign)]
		FSHistoryDataSortKey SortKey { get; set; }

		// @property (assign, nonatomic) FSDataSortComparison sortOrder;
		[Export ("sortOrder", ArgumentSemantic.Assign)]
		FSDataSortComparison SortOrder { get; set; }

		// @property (assign, nonatomic) FSHistoryDataSortRule sortRule;
		[Export ("sortRule", ArgumentSemantic.Assign)]
		FSHistoryDataSortRule SortRule { get; set; }

		// @property (assign, nonatomic) NSUInteger maxCount;
		[Export ("maxCount")]
		nuint MaxCount { get; set; }

		// @property (copy, nonatomic) NSArray<FSHistoryDataItem *> * _Nonnull items;
		[Export ("items", ArgumentSemantic.Copy)]
		FSHistoryDataItem[] Items { get; set; }
	}

	// @interface FSHistoryDataModule : NSObject <IModule>
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface FSHistoryDataModule : IModule
	{
		// -(void)configScene:(FSHistoryDataConfig * _Nonnull)config;
		[Export ("configScene:")]
		void ConfigScene (FSHistoryDataConfig config);

		// -(FSHistoryDataConfig * _Nonnull)configForScene:(FSInteractiveScene)scene;
		[Export ("configForScene:")]
		FSHistoryDataConfig ConfigForScene (FSInteractiveScene scene);

		// -(NSArray<FSHistoryDataItem *> * _Nonnull)currentItemsFromScene:(FSInteractiveScene)scene;
		[Export ("currentItemsFromScene:")]
		FSHistoryDataItem[] CurrentItemsFromScene (FSInteractiveScene scene);

		// -(NSArray<FSHistoryDataItem *> * _Nonnull)sortItemsByKeyword:(NSString * _Nonnull)keyword fromScene:(FSInteractiveScene)scene;
		[Export ("sortItemsByKeyword:fromScene:")]
		FSHistoryDataItem[] SortItemsByKeyword (string keyword, FSInteractiveScene scene);
	}
}
