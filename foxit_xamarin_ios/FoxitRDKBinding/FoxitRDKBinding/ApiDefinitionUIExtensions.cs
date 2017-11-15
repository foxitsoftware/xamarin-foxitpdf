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
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace FoxitRDK
{
    // @protocol IPanelChangedListener <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface IPanelChangedListener
    {
        // @required -(void)onPanelChanged:(BOOL)isHidden;
        [Abstract]
        [Export("onPanelChanged:")]
        void OnPanelChanged(bool isHidden);
    }

    // @interface FSPanelController : NSObject
    [BaseType(typeof(NSObject))]
    interface FSPanelController
    {
        // @property (assign, nonatomic) BOOL isHidden;
        [Export("isHidden")]
        bool IsHidden { get; set; }

        // -(instancetype)initWithExtensionsManager:(UIExtensionsManager *)extensionsManager;
        [Export("initWithExtensionsManager:")]
        IntPtr Constructor(UIExtensionsManager extensionsManager);

        // -(void)setPanelHidden:(BOOL)isHidden type:(FSPanelType)type;
        [Export("setPanelHidden:type:")]
        void SetPanelHidden(bool isHidden, FSPanelType type);

        // -(void)registerPanelChangedListener:(id<IPanelChangedListener>)listener;
        [Export("registerPanelChangedListener:")]
        void RegisterPanelChangedListener(IPanelChangedListener listener);

        // -(void)unregisterPanelChangedListener:(id<IPanelChangedListener>)listener;
        [Export("unregisterPanelChangedListener:")]
        void UnregisterPanelChangedListener(IPanelChangedListener listener);
    }

    // @protocol IAppLifecycleListener <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface IAppLifecycleListener
    {
        // @optional -(void)applicationWillResignActive:(UIApplication *)application;
        [Export("applicationWillResignActive:")]
        void ApplicationWillResignActive(UIApplication application);

        // @optional -(void)applicationDidEnterBackground:(UIApplication *)application;
        [Export("applicationDidEnterBackground:")]
        void ApplicationDidEnterBackground(UIApplication application);

        // @optional -(void)applicationWillEnterForeground:(UIApplication *)application;
        [Export("applicationWillEnterForeground:")]
        void ApplicationWillEnterForeground(UIApplication application);

        // @optional -(void)applicationDidBecomeActive:(UIApplication *)application;
        [Export("applicationDidBecomeActive:")]
        void ApplicationDidBecomeActive(UIApplication application);
    }

    // @protocol SettingBarDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface SettingBarDelegate
    {
        // @optional -(void)settingBarSinglePageLayout:(SettingBar *)settingBar;
        [Export("settingBarSinglePageLayout:")]
        void SettingBarSinglePageLayout(SettingBar settingBar);

        // @optional -(void)settingBarContinuousLayout:(SettingBar *)settingBar;
        [Export("settingBarContinuousLayout:")]
        void SettingBarContinuousLayout(SettingBar settingBar);

        // @optional -(void)settingBarDoublePageLayout:(SettingBar *)settingBar;
        [Export("settingBarDoublePageLayout:")]
        void SettingBarDoublePageLayout(SettingBar settingBar);

        // @optional -(void)settingBarThumbnail:(SettingBar *)settingBar;
        [Export("settingBarThumbnail:")]
        void SettingBarThumbnail(SettingBar settingBar);

        // @optional -(void)settingBarReflow:(SettingBar *)settingBar;
        [Export("settingBarReflow:")]
        void SettingBarReflow(SettingBar settingBar);

        // @optional -(void)settingBarCrop:(SettingBar *)settingBar;
        [Export("settingBarCrop:")]
        void SettingBarCrop(SettingBar settingBar);

        // @optional -(void)settingBar:(SettingBar *)settingBar setLockScreen:(BOOL)isLockScreen;
        [Export("settingBar:setLockScreen:")]
        void SettingBarLockScreen(SettingBar settingBar, bool isLockScreen);

        // @optional -(void)settingBar:(SettingBar *)settingBar setNightMode:(BOOL)isNightMode;
        [Export("settingBar:setNightMode:")]
        void SettingBarNightMode(SettingBar settingBar, bool isNightMode);
    }

    // @interface SettingBar : NSObject <IAppLifecycleListener>
    [BaseType(typeof(NSObject))]
    interface SettingBar : IAppLifecycleListener
    {
        // @property (nonatomic, strong) UIView * contentView;
        [Export("contentView", ArgumentSemantic.Strong)]
        UIView ContentView { get; set; }

        [Wrap("WeakDelegate")]
        SettingBarDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<SettingBarDelegate> delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // -(instancetype)initWithUIExtensionsManager:(UIExtensionsManager *)extensionsManager;
        [Export("initWithUIExtensionsManager:")]
        IntPtr Constructor(UIExtensionsManager extensionsManager);

        // -(void)setItem:(SettingItemType)itemType hidden:(BOOL)hidden;
        [Export("setItem:hidden:")]
        void SetItem(SettingItemType itemType, bool hidden);

        // -(void)updateBtnLayout;
        [Export("updateBtnLayout")]
        void UpdateBtnLayout();
    }

    // @interface UIExtensionsModulesConfig : NSObject
    [BaseType(typeof(NSObject))]
    interface UIExtensionsModulesConfig
    {
        // @property (assign, nonatomic) BOOL loadThumbnail;
        [Export("loadThumbnail")]
        bool LoadThumbnail { get; set; }

        // @property (assign, nonatomic) BOOL loadReadingBookmark;
        [Export("loadReadingBookmark")]
        bool LoadReadingBookmark { get; set; }

        // @property (assign, nonatomic) BOOL loadOutline;
        [Export("loadOutline")]
        bool LoadOutline { get; set; }

        // @property (assign, nonatomic) BOOL loadAttachment;
        [Export("loadAttachment")]
        bool LoadAttachment { get; set; }

        // @property (assign, nonatomic) BOOL loadForm;
        [Export("loadForm")]
        bool LoadForm { get; set; }

        // @property (assign, nonatomic) BOOL loadSignature;
        [Export("loadSignature")]
        bool LoadSignature { get; set; }

        // @property (assign, nonatomic) BOOL loadSearch;
        [Export("loadSearch")]
        bool LoadSearch { get; set; }

        // @property (assign, nonatomic) BOOL loadPageNavigation;
        [Export("loadPageNavigation")]
        bool LoadPageNavigation { get; set; }

        // @property (assign, nonatomic) BOOL loadEncryption;
        [Export("loadEncryption")]
        bool LoadEncryption { get; set; }

        // @property (nonatomic, strong) NSMutableSet<NSString *> * _Nullable tools;
        [NullAllowed, Export("tools", ArgumentSemantic.Strong)]
        NSMutableSet<NSString> Tools { get; set; }

        // -(id _Nullable)initWithJSONData:(NSData * _Nonnull)data;
        [Export("initWithJSONData:")]
        IntPtr Constructor(NSData data);
    }

    // @protocol IAnnotEventListener <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface IAnnotEventListener
    {
        // @optional -(void)onAnnotAdded:(id)page annot:(id)annot;
        [Export("onAnnotAdded:annot:")]
        void OnAnnotAdded(NSObject page, NSObject annot);

        // @optional -(void)onAnnotDeleted:(id)page annot:(id)annot;
        [Export("onAnnotDeleted:annot:")]
        void OnAnnotDeleted(NSObject page, NSObject annot);

        // @optional -(void)onAnnotModified:(id)page annot:(id)annot;
        [Export("onAnnotModified:annot:")]
        void OnAnnotModified(NSObject page, NSObject annot);

        // @optional -(void)onAnnotSelected:(id)page annot:(id)annot;
        [Export("onAnnotSelected:annot:")]
        void OnAnnotSelected(NSObject page, NSObject annot);

        // @optional -(void)onAnnotDeselected:(id)page annot:(id)annot;
        [Export("onAnnotDeselected:annot:")]
        void OnAnnotDeselected(NSObject page, NSObject annot);
    }

    // @protocol IToolEventListener <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface IToolEventListener
    {
        // @required -(void)onToolChanged:(NSString * _Nonnull)lastToolName CurrentToolName:(NSString * _Nonnull)toolName;
        [Abstract]
        [Export("onToolChanged:CurrentToolName:")]
        void CurrentToolName(string lastToolName, string toolName);
    }

    // @protocol ISearchEventListener <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface ISearchEventListener
    {
        // @optional -(void)onSearchStarted;
        [Export("onSearchStarted")]
        void OnSearchStarted();

        // @optional -(void)onSearchCanceled;
        [Export("onSearchCanceled")]
        void OnSearchCanceled();
    }

    // @protocol IToolHandler <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface IToolHandler
    {
        // @required @property (assign, nonatomic) int type;
        [Abstract]
        [Export("type")]
        int Type { get; set; }

        // @required -(NSString * _Nonnull)getName;
        [Abstract]
        [Export("getName")]
        string GetName();

        // @required -(BOOL)isEnabled;
        [Abstract]
        [Export("isEnabled")]
        bool IsEnabled();

        // @required -(void)onActivate;
        [Abstract]
        [Export("onActivate")]
        void OnActivate();

        // @required -(void)onDeactivate;
        [Abstract]
        [Export("onDeactivate")]
        void OnDeactivate();

        // @required -(BOOL)onPageViewLongPress:(int)pageIndex recognizer:(UILongPressGestureRecognizer * _Nonnull)recognizer;
        [Abstract]
        [Export("onPageViewLongPress:recognizer:")]
        bool OnPageViewLongPress(int pageIndex, UILongPressGestureRecognizer recognizer);

        // @required -(BOOL)onPageViewTap:(int)pageIndex recognizer:(UITapGestureRecognizer * _Nonnull)recognizer;
        [Abstract]
        [Export("onPageViewTap:recognizer:")]
        bool OnPageViewTap(int pageIndex, UITapGestureRecognizer recognizer);

        // @required -(BOOL)onPageViewPan:(int)pageIndex recognizer:(UIPanGestureRecognizer * _Nonnull)recognizer;
        [Abstract]
        [Export("onPageViewPan:recognizer:")]
        bool OnPageViewPan(int pageIndex, UIPanGestureRecognizer recognizer);

        // @required -(BOOL)onPageViewShouldBegin:(int)pageIndex recognizer:(UIGestureRecognizer * _Nonnull)gestureRecognizer;
        [Abstract]
        [Export("onPageViewShouldBegin:recognizer:")]
        bool OnPageViewShouldBegin(int pageIndex, UIGestureRecognizer gestureRecognizer);

        // @required -(BOOL)onPageViewTouchesBegan:(int)pageIndex touches:(NSSet * _Nonnull)touches withEvent:(UIEvent * _Nonnull)event;
        [Abstract]
        [Export("onPageViewTouchesBegan:touches:withEvent:")]
        bool OnPageViewTouchesBegan(int pageIndex, NSSet touches, UIEvent @event);

        // @required -(BOOL)onPageViewTouchesMoved:(int)pageIndex touches:(NSSet * _Nonnull)touches withEvent:(UIEvent * _Nonnull)event;
        [Abstract]
        [Export("onPageViewTouchesMoved:touches:withEvent:")]
        bool OnPageViewTouchesMoved(int pageIndex, NSSet touches, UIEvent @event);

        // @required -(BOOL)onPageViewTouchesEnded:(int)pageIndex touches:(NSSet * _Nonnull)touches withEvent:(UIEvent * _Nonnull)event;
        [Abstract]
        [Export("onPageViewTouchesEnded:touches:withEvent:")]
        bool OnPageViewTouchesEnded(int pageIndex, NSSet touches, UIEvent @event);

        // @required -(BOOL)onPageViewTouchesCancelled:(int)pageIndex touches:(NSSet * _Nonnull)touches withEvent:(UIEvent * _Nonnull)event;
        [Abstract]
        [Export("onPageViewTouchesCancelled:touches:withEvent:")]
        bool OnPageViewTouchesCancelled(int pageIndex, NSSet touches, UIEvent @event);

        // @optional -(void)onDraw:(int)pageIndex inContext:(CGContextRef _Nonnull)context;
        [Export("onDraw:inContext:")]
        unsafe void OnDraw(int pageIndex, IntPtr context);
    }

    // @protocol IAnnotHandler <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface IAnnotHandler
    {
        // @required -(id)getType;
        //[Abstract]
        //[Export("getType")]
        //IntPtr GetType();

        // @required -(BOOL)isHitAnnot:(id)annot point:(id)point;
        [Abstract]
        [Export("isHitAnnot:point:")]
        bool IsHitAnnot(NSObject annot, NSObject point);

        // @required -(void)onAnnotSelected:(id)annot;
        [Abstract]
        [Export("onAnnotSelected:")]
        void OnAnnotSelected(NSObject annot);

        // @required -(void)onAnnotDeselected:(id)annot;
        [Abstract]
        [Export("onAnnotDeselected:")]
        void OnAnnotDeselected(NSObject annot);

        // @required -(void)addAnnot:(id)annot;
        [Abstract]
        [Export("addAnnot:")]
        void AddAnnot(NSObject annot);

        // @required -(void)addAnnot:(id)annot addUndo:(BOOL)addUndo;
        [Abstract]
        [Export("addAnnot:addUndo:")]
        void AddAnnot(NSObject annot, bool addUndo);

        // @required -(void)modifyAnnot:(id)annot;
        [Abstract]
        [Export("modifyAnnot:")]
        void ModifyAnnot(NSObject annot);

        // @required -(void)modifyAnnot:(id)annot addUndo:(BOOL)addUndo;
        [Abstract]
        [Export("modifyAnnot:addUndo:")]
        void ModifyAnnot(NSObject annot, bool addUndo);

        // @required -(void)removeAnnot:(id)annot;
        [Abstract]
        [Export("removeAnnot:")]
        void RemoveAnnot(NSObject annot);

        // @required -(void)removeAnnot:(id)annot addUndo:(BOOL)addUndo;
        [Abstract]
        [Export("removeAnnot:addUndo:")]
        void RemoveAnnot(NSObject annot, bool addUndo);

        // @required -(BOOL)onPageViewLongPress:(int)pageIndex recognizer:(UILongPressGestureRecognizer * _Nonnull)recognizer annot:(id)annot;
        [Abstract]
        [Export("onPageViewLongPress:recognizer:annot:")]
        bool OnPageViewLongPress(int pageIndex, UILongPressGestureRecognizer recognizer, NSObject annot);

        // @required -(BOOL)onPageViewTap:(int)pageIndex recognizer:(UITapGestureRecognizer * _Nonnull)recognizer annot:(id)annot;
        [Abstract]
        [Export("onPageViewTap:recognizer:annot:")]
        bool OnPageViewTap(int pageIndex, UITapGestureRecognizer recognizer, NSObject annot);

        // @required -(BOOL)onPageViewPan:(int)pageIndex recognizer:(UIPanGestureRecognizer * _Nonnull)recognizer annot:(id)annot;
        [Abstract]
        [Export("onPageViewPan:recognizer:annot:")]
        bool OnPageViewPan(int pageIndex, UIPanGestureRecognizer recognizer, NSObject annot);

        // @required -(BOOL)onPageViewShouldBegin:(int)pageIndex recognizer:(UIGestureRecognizer * _Nonnull)gestureRecognizer annot:(id)annot;
        [Abstract]
        [Export("onPageViewShouldBegin:recognizer:annot:")]
        bool OnPageViewShouldBegin(int pageIndex, UIGestureRecognizer gestureRecognizer, NSObject annot);

        // @required -(BOOL)onPageViewTouchesBegan:(int)pageIndex touches:(NSSet * _Nonnull)touches withEvent:(UIEvent * _Nonnull)event annot:(id)annot;
        [Abstract]
        [Export("onPageViewTouchesBegan:touches:withEvent:annot:")]
        bool OnPageViewTouchesBegan(int pageIndex, NSSet touches, UIEvent @event, NSObject annot);

        // @required -(BOOL)onPageViewTouchesMoved:(int)pageIndex touches:(NSSet * _Nonnull)touches withEvent:(UIEvent * _Nonnull)event annot:(id)annot;
        [Abstract]
        [Export("onPageViewTouchesMoved:touches:withEvent:annot:")]
        bool OnPageViewTouchesMoved(int pageIndex, NSSet touches, UIEvent @event, NSObject annot);

        // @required -(BOOL)onPageViewTouchesEnded:(int)pageIndex touches:(NSSet * _Nonnull)touches withEvent:(UIEvent * _Nonnull)event annot:(id)annot;
        [Abstract]
        [Export("onPageViewTouchesEnded:touches:withEvent:annot:")]
        bool OnPageViewTouchesEnded(int pageIndex, NSSet touches, UIEvent @event, NSObject annot);

        // @required -(BOOL)onPageViewTouchesCancelled:(int)pageIndex touches:(NSSet * _Nonnull)touches withEvent:(UIEvent * _Nonnull)event annot:(id)annot;
        [Abstract]
        [Export("onPageViewTouchesCancelled:touches:withEvent:annot:")]
        bool OnPageViewTouchesCancelled(int pageIndex, NSSet touches, UIEvent @event, NSObject annot);

        // @optional -(void)onDraw:(int)pageIndex inContext:(CGContextRef _Nonnull)context annot:(id)annot;
        [Export("onDraw:inContext:annot:")]
        unsafe void OnDraw(int pageIndex, IntPtr context, NSObject annot);

        // @optional -(void)onAnnotChanged:(id)annot property:(long)property from:(NSValue * _Nonnull)oldValue to:(NSValue * _Nonnull)newValue;
        [Export("onAnnotChanged:property:from:to:")]
        void OnAnnotChanged(NSObject annot, nint property, NSValue oldValue, NSValue newValue);
    }

    // @protocol IFullScreenListener <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface IFullScreenListener
    {
        // @required -(void)onFullScreen:(BOOL)isFullScreen;
        [Abstract]
        [Export("onFullScreen:")]
        void OnFullScreen(bool isFullScreen);
    }

    // @protocol ILinkEventListener <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface ILinkEventListener
    {
        // @optional -(BOOL)onLinkOpen:(id _Nonnull)link LocationInfo:(CGPoint)pointParam;
        [Export("onLinkOpen:LocationInfo:")]
        bool LocationInfo(NSObject link, CGPoint pointParam);
    }

    // @interface UIExtensionsManager : NSObject
    [BaseType(typeof(NSObject))]
    interface UIExtensionsManager : IRotationEventListener
    {
        // @property (readonly, nonatomic, strong) FSPDFViewCtrl * _Nonnull pdfViewCtrl;
        [Export("pdfViewCtrl", ArgumentSemantic.Strong)]
        FSPDFViewCtrl PdfViewCtrl { get; }

        // @property (nonatomic, strong) id<IToolHandler> _Nullable currentToolHandler;
        [NullAllowed, Export("currentToolHandler", ArgumentSemantic.Strong)]
        IToolHandler CurrentToolHandler { get; set; }

        // @property (nonatomic, strong) int * _Nullable currentAnnot;
        [NullAllowed, Export("currentAnnot", ArgumentSemantic.Strong)]
        unsafe IntPtr CurrentAnnot { get; set; }

        // @property (assign, nonatomic) BOOL enableLinks;
        [Export("enableLinks")]
        bool EnableLinks { get; set; }

        // @property (assign, nonatomic) BOOL enableHighlightLinks;
        [Export("enableHighlightLinks")]
        bool EnableHighlightLinks { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull linksHighlightColor;
        [Export("linksHighlightColor", ArgumentSemantic.Strong)]
        UIColor LinksHighlightColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull selectionHighlightColor;
        [Export("selectionHighlightColor", ArgumentSemantic.Strong)]
        UIColor SelectionHighlightColor { get; set; }

        // @property (copy, nonatomic) void (^ _Nullable)() goBack;
        [NullAllowed, Export("goBack", ArgumentSemantic.Copy)]
        Action GoBack { get; set; }

        // @property (nonatomic, strong) UIToolbar * _Nonnull topToolbar;
        [Export("topToolbar", ArgumentSemantic.Strong)]
        UIToolbar TopToolbar { get; set; }

        // @property (nonatomic, strong) UIToolbar * _Nonnull bottomToolbar;
        [Export("bottomToolbar", ArgumentSemantic.Strong)]
        UIToolbar BottomToolbar { get; set; }

        // @property (nonatomic, strong) FSPanelController * _Nonnull panelController;
        [Export("panelController", ArgumentSemantic.Strong)]
        FSPanelController PanelController { get; set; }

        // @property (nonatomic, strong) SettingBar * _Nonnull settingBar;
        [Export("settingBar", ArgumentSemantic.Strong)]
        SettingBar SettingBar { get; set; }

        // @property (assign, nonatomic) BOOL continueAddAnnot;
        [Export("continueAddAnnot")]
        bool ContinueAddAnnot { get; set; }

        // @property (assign, nonatomic) BOOL isFullScreen;
        [Export("isFullScreen")]
        bool IsFullScreen { get; set; }

        // @property (assign, nonatomic) BOOL isScreenLocked;
        [Export("isScreenLocked")]
        bool IsScreenLocked { get; set; }

        // -(id _Nonnull)initWithPDFViewControl:(FSPDFViewCtrl * _Nonnull)viewctrl;
        [Export("initWithPDFViewControl:")]
        IntPtr Constructor(FSPDFViewCtrl viewctrl);

        // -(id _Nonnull)initWithPDFViewControl:(FSPDFViewCtrl * _Nonnull)viewctrl configuration:(NSData * _Nullable)jsonConfigData;
        [Export("initWithPDFViewControl:configuration:")]
        IntPtr Constructor(FSPDFViewCtrl viewctrl, [NullAllowed] NSData jsonConfigData);

        // -(id _Nonnull)initWithPDFViewControl:(FSPDFViewCtrl * _Nonnull)viewctrl configurationObject:(UIExtensionsModulesConfig * _Nonnull)configuration;
        [Export("initWithPDFViewControl:configurationObject:")]
        IntPtr Constructor(FSPDFViewCtrl viewctrl, UIExtensionsModulesConfig configuration);

        // -(void)registerFullScreenListener:(id<IFullScreenListener> _Nonnull)listener;
        [Export("registerFullScreenListener:")]
        void RegisterFullScreenListener(IFullScreenListener listener);

        // -(void)unregisterFullScreenListener:(id<IFullScreenListener> _Nonnull)listener;
        [Export("unregisterFullScreenListener:")]
        void UnregisterFullScreenListener(IFullScreenListener listener);

        // -(void)registerRotateChangedListener:(id<IRotationEventListener> _Nonnull)listener;
        [Export("registerRotateChangedListener:")]
        void RegisterRotateChangedListener(IRotationEventListener listener);

        // -(void)unregisterRotateChangedListener:(id<IRotationEventListener> _Nonnull)listener;
        [Export("unregisterRotateChangedListener:")]
        void UnregisterRotateChangedListener(IRotationEventListener listener);

        // -(void)enableTopToolbar:(BOOL)isEnabled;
        [Export("enableTopToolbar:")]
        void EnableTopToolbar(bool isEnabled);

        // -(void)enableBottomToolbar:(BOOL)isEnabled;
        [Export("enableBottomToolbar:")]
        void EnableBottomToolbar(bool isEnabled);

        // -(id<IToolHandler> _Nonnull)getToolHandlerByName:(NSString * _Nonnull)name;
        [Export("getToolHandlerByName:")]
        IToolHandler GetToolHandlerByName(string name);

        // -(id<IAnnotHandler> _Nonnull)getAnnotHandlerByType:(id)type;
        [Export("getAnnotHandlerByType:")]
        IAnnotHandler GetAnnotHandlerByType(NSObject type);

        // -(void)registerToolHandler:(id<IToolHandler> _Nonnull)toolHandler;
        [Export("registerToolHandler:")]
        void RegisterToolHandler(IToolHandler toolHandler);

        // -(void)unregisterToolHandler:(id<IToolHandler> _Nonnull)toolHandler;
        [Export("unregisterToolHandler:")]
        void UnregisterToolHandler(IToolHandler toolHandler);

        // -(void)registerAnnotHandler:(id<IAnnotHandler> _Nonnull)annotHandler;
        [Export("registerAnnotHandler:")]
        void RegisterAnnotHandler(IAnnotHandler annotHandler);

        // -(void)unregisterAnnotHandler:(id<IAnnotHandler> _Nonnull)annotHandler;
        [Export("unregisterAnnotHandler:")]
        void UnregisterAnnotHandler(IAnnotHandler annotHandler);

        // -(void)registerAnnotEventListener:(id<IAnnotEventListener> _Nonnull)listener;
        [Export("registerAnnotEventListener:")]
        void RegisterAnnotEventListener(IAnnotEventListener listener);

        // -(void)unregisterAnnotEventListener:(id<IAnnotEventListener> _Nonnull)listener;
        [Export("unregisterAnnotEventListener:")]
        void UnregisterAnnotEventListener(IAnnotEventListener listener);

        // -(void)registerToolEventListener:(id<IToolEventListener> _Nonnull)listener;
        [Export("registerToolEventListener:")]
        void RegisterToolEventListener(IToolEventListener listener);

        // -(void)unregisterToolEventListener:(id<IToolEventListener> _Nonnull)listener;
        [Export("unregisterToolEventListener:")]
        void UnregisterToolEventListener(IToolEventListener listener);

        // -(void)registerLinkEventListener:(id<ILinkEventListener> _Nonnull)listener;
        [Export("registerLinkEventListener:")]
        void RegisterLinkEventListener(ILinkEventListener listener);

        // -(void)unregisterLinkEventListener:(id<ILinkEventListener> _Nonnull)listener;
        [Export("unregisterLinkEventListener:")]
        void UnregisterLinkEventListener(ILinkEventListener listener);

        // -(void)showProperty:(id)annotType rect:(CGRect)rect inView:(UIView * _Nonnull)view;
        [Export("showProperty:rect:inView:")]
        void ShowProperty(NSObject annotType, CGRect rect, UIView view);

        // -(unsigned int)getPropertyBarSettingColor:(id)annotType;
        [Export("getPropertyBarSettingColor:")]
        uint GetPropertyBarSettingColor(NSObject annotType);

        // -(unsigned int)getPropertyBarSettingOpacity:(id)annotType;
        [Export("getPropertyBarSettingOpacity:")]
        uint GetPropertyBarSettingOpacity(NSObject annotType);

        // -(void)showSearchBar:(BOOL)show;
        [Export("showSearchBar:")]
        void ShowSearchBar(bool show);

        // -(void)registerSearchEventListener:(id<ISearchEventListener> _Nonnull)listener;
        [Export("registerSearchEventListener:")]
        void RegisterSearchEventListener(ISearchEventListener listener);

        // -(void)unregisterSearchEventListener:(id<ISearchEventListener> _Nonnull)listener;
        [Export("unregisterSearchEventListener:")]
        void UnregisterSearchEventListener(ISearchEventListener listener);

        // -(NSString * _Nonnull)getCurrentSelectedText;
        [Export("getCurrentSelectedText")]
        string GetCurrentSelectedText();

        // -(void)showThumbnailView;
        [Export("showThumbnailView")]
        void ShowThumbnailView();

        // -(void)setTopToolbarItemHiddenWithTag:(NSUInteger)itemTag hidden:(BOOL)isHidden;
        [Export("setTopToolbarItemHiddenWithTag:hidden:")]
        void SetTopToolbarItemHiddenWithTag(nuint itemTag, bool isHidden);
    }

    // @protocol FSFileSelectDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface FSFileSelectDelegate
    {
        // @required -(void)didFileSelected:(NSString *)filePath;
        [Abstract]
        [Export("didFileSelected:")]
        void DidFileSelected(string filePath);
    }

    // @interface FSFileListViewController : UIViewController
    [BaseType(typeof(UIViewController))]
    interface FSFileListViewController
    {
        // @property (nonatomic, weak) id<FSFileSelectDelegate> _Nullable delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject ADelegate { get; set; }
    }
}
