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
    [BaseType(typeof(NSObject))]
    interface FSSwiftException
    {
        [Static]
        [Export("tryException:error:")]
        bool TryException(Action tryBlock, [NullAllowed] out NSError error);
    }

    [BaseType(typeof(NSObject))]
    interface FSNotifier
    {
        [Export("OnOutOfMemory")]
        void OnOutOfMemory();
    }

    [BaseType(typeof(NSObject))]
    interface FSIdentityProperties
    {
        [Export("set:email:loginName:name:")]
        void Set(string corporation, string email, string loginName, string name);

        [Export("setCorporation:")]
        void SetCorporation(string value);

        [Export("getCorporation")]
        string GetCorporation();

        [Export("setEmail:")]
        void SetEmail(string value);

        [Export("getEmail")]
        string GetEmail();

        [Export("setLoginName:")]
        void SetLoginName(string value);

        [Export("getLoginName")]
        string GetLoginName();

        [Export("setName:")]
        void SetName(string value);

        [Export("getName")]
        string GetName();
    }

    [BaseType(typeof(NSObject))]
    interface FSProgressive
    {
        [Export("resume")]
        FSProgressState Resume();

        [Export("getRateOfProgress")]
        int GetRateOfProgress();
    }

    [BaseType(typeof(NSObject))]
    interface FSActionHandler
    {
        [Export("getCurrentPage:")]
        int GetCurrentPage(FSPDFDoc pdfDoc);

        [Export("setCurrentPage:pageIndex:")]
        void SetCurrentPage(FSPDFDoc pdfDoc, int pageIndex);

        [Export("getPageRotation:pageIndex:")]
        FSRotation GetPageRotation(FSPDFDoc pdfDoc, int pageIndex);

        [Export("setPageRotation:pageIndex:rotation:")]
        bool SetPageRotation(FSPDFDoc pdfDoc, int pageIndex, FSRotation rotation);

        [Export("alert:title:type:icon:")]
        int Alert(string msg, string title, int type, int icon);

        [Export("getIdentityProperties")]
        FSIdentityProperties GetIdentityProperties();
    }

    [BaseType(typeof(NSObject))]
    interface FSFileSpec
    {
        [Export("initWithPDFDoc:")]
        IntPtr Constructor(FSPDFDoc pdfDoc);

        [Export("initWithPDFDoc:pdfObject:")]
        IntPtr Constructor(FSPDFDoc pdfDoc, FSPDFObject pdfObject);

        [Export("getFileName")]
        string GetFileName();

        [Export("setFileName:")]
        void SetFileName(string fileName);

        [Export("getFileSize")]
        ulong GetFileSize();

        [Export("getFileData")]
        FSFileReadCallback GetFileData();

        [Export("embed:")]
        bool Embed(string filePath);

        [Export("isEmbedded")]
        bool IsEmbedded();

        [Export("getDescription")]
        string GetDescription();

        [Export("setDescription:")]
        void SetDescription(string description);

        [Export("getCreationDateTime")]
        FSDateTime GetCreationDateTime();

        [Export("setCreationDateTime:")]
        void SetCreationDateTime(FSDateTime dateTime);

        [Export("getModifiedDateTime")]
        FSDateTime GetModifiedDateTime();

        [Export("setModifiedDateTime:")]
        void SetModifiedDateTime(FSDateTime dateTime);

        [Export("getChecksum")]
        NSData GetChecksum();

        [Export("setChecksum:")]
        void SetChecksum(NSData checksum);

        [Export("getDict")]
        FSPDFDictionary GetDict();
    }

    [BaseType(typeof(NSObject))]
    interface FSLibrary
    {
        [Static]
        [Export("init:key:")]
        FSErrorCode Init([NullAllowed] string sn, [NullAllowed] string key);

        [Static]
        [Export("reinit")]
        FSErrorCode Reinit();

        [Static]
        [Export("release")]
        void Release();

        [Static]
        [Export("getVersion")]
        string GetVersion();

        [Static]
        [Export("getModuleRight:")]
        FSModuleRight GetModuleRight(FSModuleName module);

        [Static]
        [Export("setAnnotIconProvider:")]
        bool SetAnnotIconProvider(FSAnnotIconProviderCallback iconProvider);

        [Static]
        [Export("setNotifier:")]
        bool SetNotifier(FSNotifier notifier);

        [Static]
        [Export("setActionHandler:")]
        bool SetActionHandler(FSActionHandler actionHandler);

        [Static]
        [Export("registerSignatureHandler:subFilter:signatureHandler:")]
        bool RegisterSignatureHandler(string filter, string subFilter, FSSignatureCallback signatureHandler);

        [Static]
        [Export("registerSecurityCallback:callback:")]
        bool RegisterSecurityCallback(string filter, FSSecurityCallback callback);

        [Static]
        [Export("unregisterSecurityCallback:")]
        bool UnregisterSecurityCallback(string filter);
    }

    [BaseType(typeof(NSObject))]
    interface FSRecoveryManager
    {
        [Static]
        [Export("sharedInstance")]
        FSRecoveryManager SharedInstance();

        [Export("reloadDoc:")]
        [return: NullAllowed]
        FSPDFDoc ReloadDoc(FSPDFDoc pdfDoc);
    }

    [BaseType(typeof(NSObject))]
    interface FSPointF
    {
        [Export("x")]
        float X { get; set; }

        [Export("y")]
        float Y { get; set; }

        [Export("set:y:")]
        void Set(float x, float y);

        [Export("getX")]
        float GetX();

        [Export("getY")]
        float GetY();
    }

    [BaseType(typeof(NSObject))]
    interface FSRectF
    {
        [Export("left")]
        float Left { get; set; }

        [Export("bottom")]
        float Bottom { get; set; }

        [Export("right")]
        float Right { get; set; }

        [Export("top")]
        float Top { get; set; }

        [Export("set:bottom:right:top:")]
        void Set(float left, float bottom, float right, float top);

        [Export("getLeft")]
        float GetLeft();

        [Export("getBottom")]
        float GetBottom();

        [Export("getRight")]
        float GetRight();

        [Export("getTop")]
        float GetTop();
    }

    [BaseType(typeof(NSObject))]
    interface FSRectI
    {
        [Export("left")]
        int Left { get; set; }

        [Export("bottom")]
        int Bottom { get; set; }

        [Export("right")]
        int Right { get; set; }

        [Export("top")]
        int Top { get; set; }

        [Export("set:top:right:bottom:")]
        void Set(int left, int top, int right, int bottom);

        [Export("getLeft")]
        int GetLeft();

        [Export("getTop")]
        int GetTop();

        [Export("getRight")]
        int GetRight();

        [Export("getBottom")]
        int GetBottom();
    }

    [BaseType(typeof(NSObject))]
    interface FSMatrix
    {
        [Export("a")]
        float A { get; set; }

        [Export("b")]
        float B { get; set; }

        [Export("c")]
        float C { get; set; }

        [Export("d")]
        float D { get; set; }

        [Export("e")]
        float E { get; set; }

        [Export("f")]
        float F { get; set; }

        [Export("set:b:c:d:e:f:")]
        void Set(float a, float b, float c, float d, float e, float f);

        [Export("getReverse")]
        FSMatrix GetReverse();

        [Export("transform:")]
        FSPointF Transform(FSPointF point);

        [Export("transformRect:")]
        FSRectF TransformRect(FSRectF rect);

        [Export("getA")]
        float GetA();

        [Export("getB")]
        float GetB();

        [Export("getC")]
        float GetC();

        [Export("getD")]
        float GetD();

        [Export("getE")]
        float GetE();

        [Export("getF")]
        float GetF();
    }

    [BaseType(typeof(NSObject))]
    interface FSDateTime
    {
        [Export("year")]
        ushort Year { get; set; }

        [Export("month")]
        ushort Month { get; set; }

        [Export("day")]
        ushort Day { get; set; }

        [Export("hour")]
        ushort Hour { get; set; }

        [Export("minute")]
        ushort Minute { get; set; }

        [Export("second")]
        ushort Second { get; set; }

        [Export("millisecond")]
        ushort Millisecond { get; set; }

        [Export("UTHourOffset")]
        short UTHourOffset { get; set; }

        [Export("UTMinuteOffset")]
        ushort UTMinuteOffset { get; set; }

        [Export("set:month:day:hour:minute:second:millisecond:UTHourOffset:UTMinuteOffset:")]
        void Set(ushort year, ushort month, ushort day, ushort hour, ushort minute, ushort second, ushort millisecond, short UTHourOffset, ushort UTMinuteOffset);

        [Export("getYear")]
        ushort GetYear();

        [Export("getMonth")]
        ushort GetMonth();

        [Export("getDay")]
        ushort GetDay();

        [Export("getHour")]
        ushort GetHour();

        [Export("getMinute")]
        ushort GetMinute();

        [Export("getSecond")]
        ushort GetSecond();

        [Export("getMillisecond")]
        ushort GetMillisecond();

        [Export("getUTHourOffset")]
        short GetUTHourOffset();

        [Export("getUTMinuteOffset")]
        ushort GetUTMinuteOffset();
    }

    [BaseType(typeof(NSObject))]
    interface FSFont
    {
        [Export("initWithFontName:fontStyles:weight:charset:")]
        IntPtr Constructor(string fontName, FSFontStyles fontStyles, int weight, FSFontCharset charset);

        [Export("initWithStandardFontID:")]
        IntPtr Constructor(FSStandardFontID fontID);

        [Export("getName")]
        string GetName();
    }

    [BaseType(typeof(NSObject))]
    interface FSDefaultAppearance
    {
        [Export("flags", ArgumentSemantic.Assign)]
        FSDefaultAPFlags Flags { get; set; }

        [Export("font", ArgumentSemantic.Retain)]
        FSFont Font { get; set; }

        [Export("fontSize")]
        float FontSize { get; set; }

        [Export("textColor")]
        uint TextColor { get; set; }

        [Export("set:font:fontSize:textColor:")]
        void Set(FSDefaultAPFlags flags, FSFont font, float fontSize, uint textColor);
    }

    [BaseType(typeof(NSObject))]
    interface FSPDFPath
    {
        [Export("getPointCount")]
        int GetPointCount();

        [Export("getPoint:")]
        FSPointF GetPoint(int index);

        [Export("getPointType:")]
        FSPathPointType GetPointType(int index);

        [Export("setPoint:point:pointType:")]
        bool SetPoint(int index, FSPointF point, FSPathPointType pointType);

        [Export("moveTo:")]
        bool MoveTo(FSPointF point);

        [Export("lineTo:")]
        bool LineTo(FSPointF point);

        [Export("cubicBezierTo:point2:point3:")]
        bool CubicBezierTo(FSPointF point1, FSPointF point2, FSPointF point3);

        [Export("closeFigure")]
        bool CloseFigure();

        [Export("removePoint:")]
        bool RemovePoint(int index);

        [Export("clear")]
        void Clear();
    }

    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface FSFileReadCallback
    {
        [Abstract]
        [Export("getSize")]
        ulong GetSize();

        [Abstract]
        [Export("readBlock:size:")]
        NSData Size(ulong offset, ulong size);

        [Abstract]
        [Export("getType")]
        FSType GetThisType();
    }

    [BaseType(typeof(NSObject))]
    interface FSPauseCallback
    {
        [Export("needPauseNow")]
        bool NeedPauseNow();
    }

    [BaseType(typeof(NSObject))]
    interface FSDestination
    {
        [Static]
        [Export("createXYZ:left:top:zoomFactor:")]
        FSDestination CreateXYZ(FSPDFPage page, float left, float top, float zoomFactor);

        [Static]
        [Export("createFitPage:")]
        FSDestination CreateFitPage(FSPDFPage page);

        [Static]
        [Export("createFitHorz:top:")]
        FSDestination CreateFitHorz(FSPDFPage page, float top);

        [Static]
        [Export("createFitVert:left:")]
        FSDestination CreateFitVert(FSPDFPage page, float left);

        [Static]
        [Export("createFitRect:left:bottom:right:top:")]
        FSDestination CreateFitRect(FSPDFPage page, float left, float bottom, float right, float top);

        [Static]
        [Export("createFitBBox:")]
        FSDestination CreateFitBBox(FSPDFPage page);

        [Static]
        [Export("createFitBHorz:top:")]
        FSDestination CreateFitBHorz(FSPDFPage page, float top);

        [Static]
        [Export("createFitBVert:left:")]
        FSDestination CreateFitBVert(FSPDFPage page, float left);

        [Export("getPageIndex")]
        int GetPageIndex();

        [Export("getZoomMode")]
        FSZoomMode GetZoomMode();

        [Export("getLeft")]
        float GetLeft();

        [Export("getTop")]
        float GetTop();

        [Export("getRight")]
        float GetRight();

        [Export("getBottom")]
        float GetBottom();

        [Export("getZoomFactor")]
        float GetZoomFactor();
    }

    [BaseType(typeof(NSObject))]
    interface FSAction
    {
        [Static]
        [Export("create:actType:")]
        FSAction Create(FSPDFDoc doc, FSActionType actType);

        [Export("getType")]
        FSActionType GetActionType();

        [Export("getSubActionCount")]
        int GetSubActionCount();

        [Export("getSubAction:")]
        FSAction GetSubAction(int index);

        [Export("setSubAction:subAction:")]
        void SetSubAction(int index, FSAction subAction);

        [Export("insertSubAction:subAction:")]
        bool InsertSubAction(int index, FSAction subAction);

        [Export("removeSubAction:")]
        bool RemoveSubAction(int index);

        [Export("removeAllSubActions")]
        bool RemoveAllSubActions();
    }

    [BaseType(typeof(FSAction))]
    interface FSGotoAction
    {
        [Export("getDestination")]
        FSDestination GetDestination();

        [Export("setDestination:")]
        void SetDestination(FSDestination dest);
    }

    [BaseType(typeof(FSAction))]
    interface FSURIAction
    {
        [Export("getURI")]
        string GetURI();

        [Export("setURI:")]
        void SetURI(string uri);

        [Export("setTrackPositionFlag:")]
        void SetTrackPositionFlag(bool isTrackPosition);

        [Export("isTrackPosition")]
        bool IsTrackPosition();
    }

    [BaseType(typeof(FSAction))]
    interface FSRemoteGotoAction
    {
        [Export("getDestination")]
        FSDestination GetDestination();

        [Export("setDestination:")]
        void SetDestination(FSDestination destination);

        [Export("getDestinationName")]
        string GetDestinationName();

        [Export("setDestinationName:")]
        void SetDestinationName(string destName);

        [Export("getFileSpec")]
        FSFileSpec GetFileSpec();

        [Export("setFileSpec:")]
        void SetFileSpec(FSFileSpec fileSpecification);

        [Export("getNewWindowFlag")]
        FSNewWindowFlag GetNewWindowFlag();

        [Export("setNewWindowFlag:")]
        void SetNewWindowFlag(FSNewWindowFlag flag);
    }

    [BaseType(typeof(FSAction))]
    interface FSLaunchAction
    {
        [Export("getFileSpec")]
        FSFileSpec GetFileSpec();

        [Export("setFileSpec:")]
        void SetFileSpec(FSFileSpec fileSpecification);

        [Export("getNewWindowFlag")]
        FSNewWindowFlag GetNewWindowFlag();

        [Export("setNewWindowFlag:")]
        void SetNewWindowFlag(FSNewWindowFlag flag);

        [Export("getWinFileName")]
        string GetWinFileName();

        [Export("getWinDefaultDirectory")]
        string GetWinDefaultDirectory();

        [Export("getWinAppOperation")]
        string GetWinAppOperation();

        [Export("getWinAppParameter")]
        string GetWinAppParameter();

        [Export("setWinLaunchParameter:defaultDirectory:operation:appParameter:")]
        void SetWinLaunchParameter(string fileName, string defaultDirectory, string operation, string appParameter);
    }

    [BaseType(typeof(NSObject))]
    interface FSFDFDoc
    {
        [Export("initWithFDFDocType:")]
        IntPtr Constructor(FSFDFDocType fdfDocType);

        [Export("initWithFilePath:")]
        IntPtr Constructor(string path);

        [Export("initWithMemory:")]
        IntPtr Constructor(NSData buffer);

        [Export("initWithHandler:")]
        IntPtr Constructor(FSFileReadCallback fileRead);

        [Export("getPDFPath")]
        string GetPDFPath();

        [Export("setPDFPath:")]
        bool SetPDFPath(string pdfPath);

        [Export("saveAs:")]
        bool SaveAs(string filePath);

        [Export("importAnnotFromPDFDoc:")]
        bool ImportAnnotFromPDFDoc(FSAnnot annot);

        [Export("importAllAnnotsFromPDFDoc:")]
        bool ImportAllAnnotsFromPDFDoc(FSPDFDoc pdfDoc);

        [Export("exportAllAnnotsToPDFDoc:")]
        bool ExportAllAnnotsToPDFDoc(FSPDFDoc pdfDoc);
    }

    [BaseType(typeof(NSObject))]
    interface FSSearchCallback
    {
        [Export("retrieveSearchResult:pageIndex:matchResult:matchStartTextIndex:matchEndTextIndex:")]
        int RetrieveSearchResult(string filePath, int pageIndex, string matchResult, int matchStartTextIndex, int matchEndTextIndex);
    }

    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface FSDocumentsSource
    {
        [Export("initWithDirectory:")]
        IntPtr Constructor(string directory);
    }

    [BaseType(typeof(NSObject))]
    interface FSFullTextSearch
    {
        [Export("setDataBasePath:")]
        void SetDataBasePath(string pathOfDataBase);

        [Export("startUpdateIndex:pause:reUpdate:")]
        [return: NullAllowed]
        FSProgressive StartUpdateIndex(FSDocumentsSource source, [NullAllowed] FSPauseCallback pause, bool reUpdate);

        [Export("updateIndexWithFilePath:")]
        bool UpdateIndexWithFilePath(string filePath);

        [Export("searchOf:RankMode:searchCallback:")]
        bool SearchOf(string matchString, FSRankMode rankMode, [NullAllowed] FSSearchCallback searchCallback);
    }

    [BaseType(typeof(NSObject))]
    interface FSAnnot
    {
        [Export("getPage")]
        FSPDFPage GetPage();

        [Export("isMarkup")]
        bool IsMarkup();

        [Export("getType")]
        FSAnnotType GetThisType();

        [Export("getIndex")]
        int GetIndex();

        [Export("getContent")]
        string GetContent();

        [Export("setContent:")]
        void SetContent(string content);

        [Export("getModifiedDateTime")]
        FSDateTime GetModifiedDateTime();

        [Export("setModifiedDateTime:")]
        void SetModifiedDateTime(FSDateTime dataTime);

        [Export("getFlags")]
        FSAnnotFlags GetFlags();

        [Export("setFlags:")]
        void SetFlags(FSAnnotFlags flags);

        [Export("getUniqueID")]
        string GetUniqueID();

        [Export("setUniqueID:")]
        void SetUniqueID(string uniqueID);

        [Export("getRect")]
        FSRectF GetRect();

        [Export("move:")]
        bool Move(FSRectF rect);

        [Export("getBorderInfo")]
        FSBorderInfo GetBorderInfo();

        [Export("setBorderInfo:")]
        void SetBorderInfo(FSBorderInfo border);

        [Export("getBorderColor")]
        uint GetBorderColor();

        [Export("setBorderColor:")]
        void SetBorderColor(uint color);

        //bool ResetAppearanceStream();

        [Export("getDeviceRect:matrix:")]
        FSRectI GetDeviceRect(bool isTransformIcon, FSMatrix matrix);

        [Export("getDict")]
        FSPDFDictionary GetDict();

        [Export("removeProperty:")]
        bool RemoveProperty(FSAnnotProperty property);
    }

    [BaseType(typeof(NSObject))]
    interface FSBorderInfo
    {
        [Export("set:style:intensity:dashPhase:dashes:dashCount:")]
        unsafe void Set(float width, FSBorderStyle style, float intensity, float dashPhase, IntPtr dashes, int dashCount);

        [Export("setWidth:")]
        void SetWidth(float value);

        [Export("getWidth")]
        float GetWidth();

        [Export("setStyle:")]
        void SetStyle(FSBorderStyle value);

        [Export("getStyle")]
        FSBorderStyle GetStyle();

        [Export("setCloudIntensity:")]
        void SetCloudIntensity(float value);

        [Export("getCloudIntensity")]
        float GetCloudIntensity();

        [Export("setDashPhase:")]
        void SetDashPhase(float value);

        [Export("getDashPhase")]
        float GetDashPhase();

        [Export("setDashes:")]
        void SetDashes(NSNumber[] value);

        [Export("getDashes")]
        NSNumber[] GetDashes();
    }

    [BaseType(typeof(NSObject))]
    interface FSQuadPoints
    {
        [Export("set:second:third:fourth:")]
        void Set(FSPointF first, FSPointF second, FSPointF third, FSPointF fourth);

        [Export("setFirst:")]
        void SetFirst(FSPointF value);

        [Export("getFirst")]
        FSPointF GetFirst();

        [Export("setSecond:")]
        void SetSecond(FSPointF value);

        [Export("getSecond")]
        FSPointF GetSecond();

        [Export("setThird:")]
        void SetThird(FSPointF value);

        [Export("getThird")]
        FSPointF GetThird();

        [Export("setFourth:")]
        void SetFourth(FSPointF value);

        [Export("getFourth")]
        FSPointF GetFourth();
    }

    [BaseType(typeof(NSObject))]
    interface FSShadingColor
    {
        [Export("set:secondColor:")]
        void Set(uint firstColor, uint secondColor);

        [Export("setFirstColor:")]
        void SetFirstColor(uint value);

        [Export("getFirstColor")]
        uint GetFirstColor();

        [Export("setSecondColor:")]
        void SetSecondColor(uint value);

        [Export("getSecondColor")]
        uint GetSecondColor();
    }

    [BaseType(typeof(NSObject))]
    interface FSAnnotIconProviderCallback
    {
        [Export("getProviderID")]
        string GetProviderID();

        [Export("getProviderVersion")]
        string GetProviderVersion();

        [Export("hasIcon:iconName:")]
        bool HasIcon(FSAnnotType annotType, string iconName);

        [Export("canChangeColor:iconName:")]
        bool CanChangeColor(FSAnnotType annotType, string iconName);

        [Export("getIcon:iconName:color:")]
        FSPDFPage GetIcon(FSAnnotType annotType, string iconName, uint color);

        [Export("getShadingColor:iconName:refColor:shadingIndex:")]
        FSShadingColor GetShadingColor(FSAnnotType annotType, string iconName, uint refColor, int shadingIndex);

        [Export("getDisplayWidth:iconName:")]
        NSNumber GetDisplayWidth(FSAnnotType annotType, string iconName);

        [Export("getDisplayHeight:iconName:")]
        NSNumber GetDisplayHeight(FSAnnotType annotType, string iconName);
    }

    [BaseType(typeof(FSAnnot))]
    interface FSPopup
    {
        [Export("getOpenStatus")]
        bool GetOpenStatus();

        [Export("setOpenStatus:")]
        void SetOpenStatus(bool status);
    }

    [BaseType(typeof(FSAnnot))]
    interface FSMarkup
    {
        [Export("getPopup")]
        FSPopup GetPopup();

        [Export("setPopup:")]
        void SetPopup(FSPopup popup);

        [Export("getTitle")]
        string GetTitle();

        [Export("setTitle:")]
        void SetTitle(string title);

        [Export("getSubject")]
        string GetSubject();

        [Export("setSubject:")]
        void SetSubject(string subject);

        [Export("getOpacity")]
        float GetOpacity();

        [Export("setOpacity:")]
        void SetOpacity(float opacity);

        [Export("getIntent")]
        string GetIntent();

        [Export("setIntent:")]
        void SetIntent(string intent);

        [Export("getCreationDateTime")]
        FSDateTime GetCreationDateTime();

        [Export("setCreationDateTime:")]
        void SetCreationDateTime(FSDateTime dateTime);

        [Export("getReplyCount")]
        int GetReplyCount();

        [Export("getReply:")]
        FSNote GetReply(int index);

        [Export("addReply")]
        FSNote AddReply();

        [Export("removeReply:")]
        bool RemoveReply(int index);

        [Export("removeAllReplies")]
        bool RemoveAllReplies();

        [Export("isGrouped")]
        bool IsGrouped();

        [Export("getGroupHeader")]
        FSMarkup GetGroupHeader();

        [Export("getGroupElementCount")]
        int GetGroupElementCount();

        [Export("getGroupElement:")]
        FSMarkup GetGroupElement(int index);

        [Export("ungroup")]
        bool Ungroup();

        [Export("getStateAnnotCount:")]
        int GetStateAnnotCount(FSAnnotStateModel stateModel);

        [Export("getStateAnnot:index:")]
        FSNote GetStateAnnot(FSAnnotStateModel stateModel, int index);

        [Export("addStateAnnot:state:")]
        FSNote AddStateAnnot(FSAnnotStateModel stateModel, FSAnnotState state);

        [Export("removeAllStateAnnots")]
        bool RemoveAllStateAnnots();
    }

    [BaseType(typeof(FSMarkup))]
    interface FSNote
    {
        [Export("getOpenStatus")]
        bool GetOpenStatus();

        [Export("setOpenStatus:")]
        void SetOpenStatus(bool status);

        [Export("getIconName")]
        string GetIconName();

        [Export("setIconName:")]
        void SetIconName(string iconName);

        [Export("getReplyTo")]
        FSMarkup GetReplyTo();

        //bool ResetAppearanceStream();

        [Export("isStateAnnot")]
        bool IsStateAnnot();

        [Export("getStateModel")]
        FSAnnotStateModel GetStateModel();

        [Export("getState")]
        FSAnnotState GetState();

        [Export("setState:")]
        void SetState(FSAnnotState state);
    }

    [BaseType(typeof(FSMarkup))]
    interface FSTextMarkup
    {
        [Export("getQuadPointsCount")]
        int GetQuadPointsCount();

        [Export("getQuadPoints:")]
        FSQuadPoints GetQuadPoints(int index);

        [Export("setQuadPoints:")]
        void SetQuadPoints(NSObject[] quadPoints);
    }

    [BaseType(typeof(FSTextMarkup))]
    interface FSHighlight
    {
        //bool ResetAppearanceStream();
    }

    [BaseType(typeof(FSTextMarkup))]
    interface FSUnderline
    {
        //bool ResetAppearanceStream();
    }

    [BaseType(typeof(FSTextMarkup))]
    interface FSStrikeOut
    {
        //bool ResetAppearanceStream();
    }

    [BaseType(typeof(FSTextMarkup))]
    interface FSSquiggly
    {
        //bool ResetAppearanceStream();
    }

    [BaseType(typeof(FSMarkup))]
    interface FSSquare
    {
        [Export("getFillColor")]
        uint GetFillColor();

        [Export("setFillColor:")]
        void SetFillColor(uint fillColor);

        //bool ResetAppearanceStream();

        [Export("getInnerRect")]
        FSRectF GetInnerRect();

        [Export("setInnerRect:")]
        void SetInnerRect(FSRectF innerRect);
    }

    [BaseType(typeof(FSMarkup))]
    interface FSCircle
    {
        [Export("getFillColor")]
        uint GetFillColor();

        [Export("setFillColor:")]
        void SetFillColor(uint fillColor);

        //bool ResetAppearanceStream();

        [Export("getInnerRect")]
        FSRectF GetInnerRect();

        [Export("setInnerRect:")]
        void SetInnerRect(FSRectF innerRect);
    }

    [BaseType(typeof(FSAnnot))]
    interface FSLink
    {
        //bool ResetAppearanceStream();

        [Export("getQuadPointsCount")]
        int GetQuadPointsCount();

        [Export("getQuadPoints:")]
        FSQuadPoints GetQuadPoints(int index);

        [Export("setQuadPoints:")]
        void SetQuadPoints(FSQuadPoints[] quadPoints);

        [Export("getHighlightingMode")]
        FSHighlightingMode GetHighlightingMode();

        [Export("setHighlightingMode:")]
        void SetHighlightingMode(FSHighlightingMode mode);

        [Export("getAction")]
        FSAction GetAction();

        [Export("setAction:")]
        void SetAction(FSAction action);

        [Export("removeAction")]
        bool RemoveAction();
    }

    [BaseType(typeof(FSMarkup))]
    interface FSFreeText
    {
        //bool ResetAppearanceStream();

        [Export("getFillColor")]
        uint GetFillColor();

        [Export("setFillColor:")]
        void SetFillColor(uint fillColor);

        [Export("getAlignment")]
        FSAlignment GetAlignment();

        [Export("setAlignment:")]
        void SetAlignment(FSAlignment alignment);

        [Export("getInnerRect")]
        FSRectF GetInnerRect();

        [Export("setInnerRect:")]
        void SetInnerRect(FSRectF innerRect);

        [Export("getDefaultAppearance")]
        FSDefaultAppearance GetDefaultAppearance();

        [Export("setDefaultAppearance:")]
        bool SetDefaultAppearance(FSDefaultAppearance defaultAP);

        [Export("getCalloutLineEndingStyle")]
        string GetCalloutLineEndingStyle();

        [Export("setCalloutLineEndingStyle:")]
        void SetCalloutLineEndingStyle(string endingStyle);

        [Export("getCalloutLinePointCount")]
        int GetCalloutLinePointCount();

        [Export("getCalloutLinePoint:")]
        FSPointF GetCalloutLinePoint(int index);

        [Export("setCalloutLinePoints:point2:point3:")]
        void SetCalloutLinePoints(FSPointF point1, FSPointF point2, FSPointF point3);
    }

    [BaseType(typeof(FSMarkup))]
    interface FSLine
    {
        //bool ResetAppearanceStream();

        [Export("getLineStartingStyle")]
        string GetLineStartingStyle();

        [Export("setLineStartingStyle:")]
        void SetLineStartingStyle(string startingStyle);

        [Export("getLineEndingStyle")]
        string GetLineEndingStyle();

        [Export("setLineEndingStyle:")]
        void SetLineEndingStyle(string endingStyle);

        [Export("getStyleFillColor")]
        uint GetStyleFillColor();

        [Export("setStyleFillColor:")]
        void SetStyleFillColor(uint color);

        [Export("getStartPoint")]
        FSPointF GetStartPoint();

        [Export("setStartPoint:")]
        void SetStartPoint(FSPointF point);

        [Export("getEndPoint")]
        FSPointF GetEndPoint();

        [Export("setEndPoint:")]
        void SetEndPoint(FSPointF point);

        [Export("hasCaption")]
        bool HasCaption();

        [Export("enableCaption:")]
        void EnableCaption(bool cap);

        [Export("getCaptionPositionType")]
        string GetCaptionPositionType();

        [Export("setCaptionPositionType:")]
        void SetCaptionPositionType(string captionPos);

        [Export("getCaptionOffset")]
        FSPointF GetCaptionOffset();

        [Export("setCaptionOffset:")]
        void SetCaptionOffset(FSPointF offset);
    }

    [BaseType(typeof(FSMarkup))]
    interface FSInk
    {
        //bool ResetAppearanceStream();

        [Export("getInkList")]
        FSPDFPath GetInkList();

        [Export("setInkList:")]
        void SetInkList(FSPDFPath inkList);
    }

    [BaseType(typeof(FSMarkup))]
    interface FSStamp
    {
        //bool ResetAppearanceStream();

        [Export("getIconName")]
        string GetIconName();

        [Export("setIconName:")]
        void SetIconName(string iconName);

        [Export("setBitmap:")]
        void SetBitmap(FSBitmap bitmap);
    }

    [BaseType(typeof(FSMarkup))]
    interface FSPolygon
    {
        //bool ResetAppearanceStream();

        [Export("getFillColor")]
        uint GetFillColor();

        [Export("setFillColor:")]
        void SetFillColor(uint fillColor);

        [Export("getVertexCount")]
        int GetVertexCount();

        [Export("getVertex:")]
        FSPointF GetVertex(int index);

        [Export("setVertexes:")]
        void SetVertexes(FSPointF[] vertexes);
    }

    [BaseType(typeof(FSMarkup))]
    interface FSPolyLine
    {
        //bool ResetAppearanceStream();

        [Export("getStyleFillColor")]
        uint GetStyleFillColor();

        [Export("setStyleFillColor:")]
        void SetStyleFillColor(uint fillColor);

        [Export("getVertexCount")]
        int GetVertexCount();

        [Export("getVertex:")]
        FSPointF GetVertex(int index);

        [Export("setVertexes:")]
        void SetVertexes(FSPointF[] vertexes);

        [Export("getLineStartingStyle")]
        string GetLineStartingStyle();

        [Export("setLineStartingStyle:")]
        void SetLineStartingStyle(string startingStyle);

        [Export("getLineEndingStyle")]
        string GetLineEndingStyle();

        [Export("setLineEndingStyle:")]
        void SetLineEndingStyle(string endingStyle);
    }

    [BaseType(typeof(FSMarkup))]
    interface FSCaret
    {
        //bool ResetAppearanceStream();

        [Export("getInnerRect")]
        FSRectF GetInnerRect();

        [Export("setInnerRect:")]
        void SetInnerRect(FSRectF innerRect);
    }

    [BaseType(typeof(FSMarkup))]
    interface FSFileAttachment
    {
        //bool ResetAppearanceStream();

        [Export("setFileSpec:")]
        bool SetFileSpec(FSFileSpec fileSpecification);

        [Export("getFileSpec")]
        FSFileSpec GetFileSpec();

        [Export("getIconName")]
        string GetIconName();

        [Export("setIconName:")]
        void SetIconName(string iconName);
    }

    [BaseType(typeof(FSAnnot))]
    interface FSPSInk
    {
        //bool ResetAppearanceStream();
    }

    [BaseType(typeof(FSAnnot))]
    interface FSWidget
    {
        [Export("getField")]
        FSFormField GetField();

        [Export("getControl")]
        FSFormControl GetControl();

        //bool ResetAppearanceStream();

        [Export("getHighlightingMode")]
        FSHighlightingMode GetHighlightingMode();

        [Export("setHighlightingMode:")]
        void SetHighlightingMode(FSHighlightingMode mode);

        [Export("getAction")]
        FSAction GetAction();

        [Export("setAction:")]
        void SetAction(FSAction action);

        [Export("removeAction")]
        void RemoveAction();

        [Export("hasMKEntry:")]
        bool HasMKEntry(FSAnnotMKEntry mk_entry);

        [Export("removeMKEntry:")]
        void RemoveMKEntry(FSAnnotMKEntry mk_entry);

        [Export("getMKRotation")]
        FSRotation GetMKRotation();

        [Export("setMKRotation:")]
        void SetMKRotation(FSRotation rotation);

        [Export("getMKBorderColor")]
        uint GetMKBorderColor();

        [Export("setMKBorderColor:")]
        void SetMKBorderColor(uint color);

        [Export("getMKBackgroundColor")]
        uint GetMKBackgroundColor();

        [Export("setMKBackgroundColor:")]
        void SetMKBackgroundColor(uint color);

        [Export("getMKNormalCaption")]
        string GetMKNormalCaption();

        [Export("setMKNormalCaption:")]
        void SetMKNormalCaption(string caption);

        [Export("getMKRolloverCaption")]
        string GetMKRolloverCaption();

        [Export("setMKRolloverCaption:")]
        void SetMKRolloverCaption(string caption);

        [Export("getMKDownCaption")]
        string GetMKDownCaption();

        [Export("setMKDownCaption:")]
        void SetMKDownCaption(string caption);

        [Export("getMKNormalIconBitmap")]
        FSBitmap GetMKNormalIconBitmap();

        [Export("setMKNormalIconBitmap:")]
        void SetMKNormalIconBitmap(FSBitmap bitmap);

        [Export("setMKNormalIconImage:frame_index:")]
        void SetMKNormalIconImage(FSImage image, int frame_index);

        [Export("getMKRolloverIconBitmap")]
        FSBitmap GetMKRolloverIconBitmap();

        [Export("setMKRolloverIconBitmap:")]
        void SetMKRolloverIconBitmap(FSBitmap bitmap);

        [Export("setMKRolloverIconImage:frame_index:")]
        void SetMKRolloverIconImage(FSImage image, int frame_index);

        [Export("getMKDownIconBitmap")]
        FSBitmap GetMKDownIconBitmap();

        [Export("setMKDownIconBitmap:")]
        void SetMKDownIconBitmap(FSBitmap bitmap);

        [Export("setMKDownIconImage:frame_index:")]
        void SetMKDownIconImage(FSImage image, int frame_index);

        [Export("getMKIconFit")]
        FSIconFit GetMKIconFit();

        [Export("setMKIconFit:")]
        void SetMKIconFit(FSIconFit icon_fit);

        [Export("getMKIconCaptionRelation")]
        FSAnnotMKIconCaptionRelation GetMKIconCaptionRelation();

        [Export("setMKIconCaptionRelation:")]
        void SetMKIconCaptionRelation(FSAnnotMKIconCaptionRelation relation);
    }

    [BaseType(typeof(NSObject))]
    interface FSIconFit
    {
        [Export("scaleWayType", ArgumentSemantic.Assign)]
        FSIconScaleWayType ScaleWayType { get; set; }

        [Export("proportionalScaling")]
        bool ProportionalScaling { [Bind("isProportionalScaling")] get; set; }

        [Export("horizontalFraction")]
        float HorizontalFraction { get; set; }

        [Export("verticalFraction")]
        float VerticalFraction { get; set; }

        [Export("fitBounds")]
        bool FitBounds { [Bind("isFitBounds")] get; set; }

        [Export("initWithIconFit:")]
        IntPtr Constructor(FSIconFit iconFit);

        [Export("set:proportionalScaling:horizontalFraction:verticalFraction:fitBounds:")]
        void Set(FSIconScaleWayType type, bool proportionalScaling, float horizontalFraction, float verticalFraction, bool fitBounds);
    }

    [BaseType(typeof(NSObject))]
    interface FSSecurityCallback
    {
        [Export("getSecurityType")]
        FSEncryptType GetSecurityType();
    }

    [BaseType(typeof(FSSecurityCallback))]
    interface FSCertificateSecurityCallback
    {



        [Export("getPKCS12:")]
        NSData GetPKCS12(NSData envelope);

        [Export("getPasswordForPKCS12:")]
        string GetPasswordForPKCS12(NSData pkcs12);
    }

    [BaseType(typeof(NSObject))]
    interface FSSecurityHandler
    {
    }

    [BaseType(typeof(FSSecurityHandler))]
    interface FSStdSecurityHandler
    {
        [Export("initialize:userPassword:ownerPassword:cipher:keyLen:encryptMetadata:")]
        bool Initialize(uint userPermissions, string userPassword, string ownerPassword, FSCipherType cipher, int keyLen, bool encryptMetadata);
    }

    [BaseType(typeof(FSSecurityHandler))]
    interface FSCertificateSecurityHandler
    {
        [Export("initialize:cipher:encryptMetadata:")]
        bool Initialize(NSData[] x509Certificates, FSCipherType cipher, bool encryptMetadata);
    }

    [BaseType(typeof(FSSecurityCallback))]
    interface FSCustomSecurityCallback
    {
        [Export("createContext:subFilter:encryptInfo:")]
        unsafe IntPtr CreateContext(string filter, string subFilter, string encryptInfo);

        [Export("releaseContext:")]
        unsafe bool ReleaseContext(IntPtr context);

        [Export("getUserPermissions:userPermission:")]
        unsafe FSUserPermissions GetUserPermissions(IntPtr context, FSUserPermissions userPermission);

        [Export("isOwner:")]
        unsafe bool IsOwner(IntPtr context);

        [Export("getCipher:")]
        unsafe FSCipherType GetCipher(IntPtr context);

        [Export("getEncryptKey:")]
        unsafe string GetEncryptKey(IntPtr context);

        [Export("getDecryptedSize:srcDataSize:")]
        unsafe uint GetDecryptedSize(IntPtr context, uint srcDataSize);

        [Export("startDecryptor:objNum:genNum:")]
        unsafe IntPtr StartDecryptor(IntPtr context, int objNum, int genNum);

        [Export("decryptData:encryptedData:encryptedDataLen:")]
        unsafe string DecryptData(IntPtr decryptor, IntPtr encryptedData, uint encryptedDataLen);

        [Export("finishDecryptor:")]
        unsafe string FinishDecryptor(IntPtr decryptor);

        [Export("getEncryptedSize:objNum:genNum:srcData:srcDataLen:")]
        unsafe uint GetEncryptedSize(IntPtr context, int objNum, int genNum, IntPtr srcData, uint srcDataLen);

        [Export("encryptData:objNum:genNum:srcData:srcDataLen:dstBuffer:dstBufferLen:")]
        unsafe bool EncryptData(IntPtr context, int objNum, int genNum, IntPtr srcData, uint srcDataLen, IntPtr dstBuffer, ref uint dstBufferLen);
    }

    [BaseType(typeof(FSSecurityHandler))]
    interface FSCustomSecurityHandler
    {
        [Export("initialize:subFilter:encryptInfo:isEncryptMetadata:callback:")]
        bool Initialize(string filter, string subFilter, string encryptInfo, bool isEncryptMetadata, FSCustomSecurityCallback callback);
    }

    [BaseType(typeof(NSObject))]
    interface FSGraphState
    {
        [Export("blendMode", ArgumentSemantic.Assign)]
        FSRenderBlendMode BlendMode { get; set; }

        [Export("lineWidth")]
        float LineWidth { get; set; }

        [Export("lineJoin", ArgumentSemantic.Assign)]
        FSLineJoinType LineJoin { get; set; }

        [Export("miterLimit")]
        float MiterLimit { get; set; }

        [Export("lineCap", ArgumentSemantic.Assign)]
        FSLineCapType LineCap { get; set; }

        [Export("dashPhase")]
        float DashPhase { get; set; }

        [Export("dashes", ArgumentSemantic.Retain)]
        NSNumber[] Dashes { get; set; }

        [Export("set:lineWidth:lineJoin:miterLimit:lineCap:dashPhase:dashes:dashCount:")]
        unsafe void Set(FSRenderBlendMode blendMode, float lineWidth, FSLineJoinType lineJoin, float miterLimit, FSLineCapType lineCap, float dashPhase, IntPtr dashes, int dashCount);
    }

    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface FSPDFMarkedContent
    {
        [Export("hasTag:")]
        bool HasTag(string tagName);

        [Export("getItemCount")]
        int GetItemCount();

        [Export("getItemTagName:")]
        string GetItemTagName(int index);

        [Export("getItemMCID:")]
        int GetItemMCID(int index);

        [Export("getItemPropertyDict:")]
        FSPDFDictionary GetItemPropertyDict(int index);

        [Export("addItem:propertyDict:")]
        int AddItem(string tagName, FSPDFDictionary propertyDict);

        [Export("removeItem:")]
        bool RemoveItem(string tagName);
    }

    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface FSPDFGraphicsObject
    {
        [Export("getType")]
        FSGraphicsObjectType GetThisType();

        [Export("getRect")]
        FSRectF GetRect();

        [Export("hasTransparency")]
        bool HasTransparency();

        [Export("getStrokeColor")]
        uint GetStrokeColor();

        [Export("getFillColor")]
        uint GetFillColor();

        [Export("setStrokeColor:")]
        void SetStrokeColor(uint color);

        [Export("setFillColor:")]
        void SetFillColor(uint color);

        [Export("getMatrix")]
        FSMatrix GetMatrix();

        [Export("setMatrix:")]
        void SetMatrix(FSMatrix matrix);

        [Export("transform:needTransformClipPath:")]
        bool Transform(FSMatrix matrix, bool needTransformClipPath);

        [Export("clone")]
        FSPDFGraphicsObject Clone();

        [Export("getGraphState")]
        FSGraphState GetGraphState();

        [Export("setGraphState:")]
        void SetGraphState(FSGraphState graphState);

        [Export("getClipPathCount")]
        int GetClipPathCount();

        [Export("getClipPath:")]
        FSPDFPath GetClipPath(int index);

        [Export("getClipPathFillMode:")]
        FSFillMode GetClipPathFillMode(int index);

        [Export("addClipPath:fillMode:")]
        bool AddClipPath(FSPDFPath path, FSFillMode fillMode);

        [Export("removeClipPath:")]
        bool RemoveClipPath(int index);

        [Export("getClipTextObjectCount")]
        int GetClipTextObjectCount();

        [Export("getClipTextObject:")]
        FSPDFTextObject GetClipTextObject(int index);

        [Export("addClipTextObject:")]
        bool AddClipTextObject(FSPDFTextObject textObj);

        [Export("removeClipTextObject:")]
        bool RemoveClipTextObject(int index);

        [Export("getClipRect")]
        FSRectF GetClipRect();

        [Export("setClipRect:")]
        void SetClipRect(FSRectF clipRect);

        [Export("clearClips")]
        bool ClearClips();

        [Export("getMarkedContent")]
        FSPDFMarkedContent GetMarkedContent();
    }

    [BaseType(typeof(NSObject))]
    interface FSPDFTextState
    {
        [Export("set:font:fontSize:charSpace:wordSpace:textMode:originPosition:textMatrix:")]
        void Set(uint version, FSFont font, float fontSize, float charSpace, float wordSpace, FSTextMode textMode, FSPointF originPosition, NSNumber[] textMatrix);

        [Export("version")]
        uint Version { get; set; }

        [Export("font", ArgumentSemantic.Retain)]
        FSFont Font { get; set; }

        [Export("fontSize")]
        float FontSize { get; set; }

        [Export("charSpace")]
        float CharSpace { get; set; }

        [Export("wordSpace")]
        float WordSpace { get; set; }

        [Export("textMode", ArgumentSemantic.Assign)]
        FSTextMode TextMode { get; set; }

        [Export("originPosition", ArgumentSemantic.Retain)]
        FSPointF OriginPosition { get; set; }

        [Export("textMatrix", ArgumentSemantic.Retain)]
        NSNumber[] TextMatrix { get; set; }
    }

    [BaseType(typeof(FSPDFGraphicsObject))]
    interface FSPDFTextObject
    {
        [Static]
        [Export("create")]
        FSPDFTextObject Create();

        [Export("getText")]
        string GetText();

        [Export("setText:")]
        void SetText(string text);

        [Export("getTextState:")]
        FSPDFTextState GetTextState(FSPDFPage page);

        [Export("setTextState:textState:isItalic:weight:")]
        void SetTextState(FSPDFPage page, FSPDFTextState textState, bool isItalic, int weight);
    }

    [BaseType(typeof(FSPDFGraphicsObject))]
    interface FSPDFPathObject
    {
        [Static]
        [Export("create")]
        FSPDFPathObject Create();

        [Export("getFillMode")]
        FSFillMode GetFillMode();

        [Export("setFillMode:")]
        void SetFillMode(FSFillMode fillMode);

        [Export("getStrokeState")]
        bool GetStrokeState();

        [Export("setStrokeState:")]
        void SetStrokeState(bool isStroke);

        [Export("getPathData")]
        FSPDFPath GetPathData();

        [Export("setPathData:")]
        void SetPathData(FSPDFPath pathData);
    }

    [BaseType(typeof(FSPDFGraphicsObject))]
    [DisableDefaultCtor]
    interface FSPDFFormXObject
    {
        [Static]
        [Export("create:")]
        FSPDFFormXObject Create(FSPDFDoc pdfDoc);

        [Export("getStream")]
        FSPDFStream GetStream();

        [Export("getGraphicsObjects")]
        FSPDFGraphicsObjects GetGraphicsObjects();

        [Export("importPageContent:isAnnotsIncluded:")]
        bool ImportPageContent(FSPDFPage srcPage, bool isAnnotsIncluded);
    }

    [BaseType(typeof(FSPDFGraphicsObject))]
    [DisableDefaultCtor]
    interface FSPDFShadingObject
    {
        [Export("getPDFObject")]
        FSPDFObject GetPDFObject();
    }

    [BaseType(typeof(FSPDFGraphicsObject))]
    interface FSPDFImageObject
    {
        [Static]
        [Export("create:")]
        FSPDFImageObject Create(FSPDFDoc pdfDoc);

        [Export("setBitmap:mask:")]
        void SetBitmap(FSBitmap bitmap, [NullAllowed] FSBitmap mask);

        [Export("cloneBitmap:")]
        FSBitmap CloneBitmap(FSPDFPage page);

        [Export("getColorSpace")]
        FSImageColorSpace GetColorSpace();

        [Export("getStream")]
        FSPDFStream GetStream();
    }

    [BaseType(typeof(NSObject))]
    interface FSPDFDoc
    {
        [Export("initWithFilePath:")]
        IntPtr Constructor(string path);

        [Export("initWithMemory:")]
        IntPtr Constructor(NSData buffer);

        [Export("initWithHandler:")]
        IntPtr Constructor(FSFileReadCallback fileRead);

        [Export("load:")]
        FSErrorCode Load([NullAllowed] string password);

        [Export("startLoad:length:is_cache_stream:pause:")]
        [return: NullAllowed]
        FSProgressive StartLoad(string password, int length, bool is_cache_stream, [NullAllowed] FSPauseCallback pause);

        [Export("getFileSize")]
        ulong GetFileSize();

        [Export("isXFA")]
        bool IsXFA();

        [Export("isEncrypted")]
        bool IsEncrypted();

        [Export("isModified")]
        bool IsModified();

        [Export("getEncryptionType")]
        FSEncryptType GetEncryptionType();

        [Export("getPasswordType")]
        FSPasswordType GetPasswordType();

        [Export("checkPassword:")]
        FSPasswordType CheckPassword([NullAllowed] string password);

        [Export("saveAs:saveFlags:")]
        bool SaveAs(string filePath, FSSaveFlags saveFlags);

        [Export("startSaveAs:save_flags:pause:")]
        [return: NullAllowed]
        FSProgressive StartSaveAs(string file_path, FSSaveFlags save_flags, [NullAllowed] FSPauseCallback pause);

        [Export("createFirstBookmark")]
        FSBookmark CreateFirstBookmark();

        [Export("removeBookmark:")]
        bool RemoveBookmark(FSBookmark bookmark);

        [Export("getFirstBookmark")]
        FSBookmark GetFirstBookmark();

        [Export("getPageCount")]
        int GetPageCount();

        [Export("getPage:")]
        FSPDFPage GetPage(int pageIndex);

        [Export("closePage:")]
        bool ClosePage(int pageIndex);

        [Export("getDisplayMode")]
        FSDisplayMode GetDisplayMode();

        [Export("setDisplayMode:")]
        void SetDisplayMode(FSDisplayMode displayMode);

        [Export("getCatalog")]
        FSPDFDictionary GetCatalog();

        [Export("getTrailer")]
        FSPDFDictionary GetTrailer();

        [Export("getInfo")]
        FSPDFDictionary GetInfo();

        [Export("getEncryptDict")]
        FSPDFDictionary GetEncryptDict();

        [Export("getIndirectObject:")]
        FSPDFObject GetIndirectObject(uint objnum);

        [Export("addIndirectObject:")]
        uint AddIndirectObject(FSPDFObject obj);

        [Export("deleteIndirectObject:")]
        void DeleteIndirectObject(uint objnum);

        [Export("getUserPermissions")]
        FSUserPermissions GetUserPermissions();

        [Export("hasForm")]
        bool HasForm();

        [Export("getForm")]
        FSForm GetForm();

        [Export("getReadingBookmarkCount")]
        int GetReadingBookmarkCount();

        [Export("getReadingBookmark:")]
        FSReadingBookmark GetReadingBookmark(int index);

        [Export("insertReadingBookmark:title:pageIndex:")]
        FSReadingBookmark InsertReadingBookmark(int readingBookmarkIndex, string title, int destPageIndex);

        [Export("removeReadingBookmark:")]
        bool RemoveReadingBookmark(FSReadingBookmark readingBookmark);

        [Export("getSignatureCount")]
        int GetSignatureCount();

        [Export("getSignature:")]
        FSSignature GetSignature(int index);

        [Export("insertPage:")]
        FSPDFPage InsertPage(int index);

        [Export("removePage:")]
        bool RemovePage(FSPDFPage page);

        [Export("movePageTo:dstIndex:")]
        bool MovePageTo(FSPDFPage page, int dstIndex);

        [Export("startImportPagesFromFilePath:flags:layerName:srcFilePath:password:pageRanges:count:pause:")]
        [return: NullAllowed]
        unsafe FSProgressive StartImportPagesFromFilePath(int dstIndex, FSImportFlags flags, string layerName, string srcFilePath, [NullAllowed] string password, IntPtr pageRanges, int count, [NullAllowed] FSPauseCallback pause);

        [Export("startImportPages:flags:layerName:srcDoc:pageRanges:count:pause:")]
        [return: NullAllowed]
        unsafe FSProgressive StartImportPages(int dstIndex, uint flags, string layerName, FSPDFDoc srcDoc, IntPtr pageRanges, int count, [NullAllowed] FSPauseCallback pause);

        [Export("getFileVersion")]
        int GetFileVersion();

        [Export("setFileVersion:")]
        void SetFileVersion(int version);

        [Export("setSecurityHandler:")]
        bool SetSecurityHandler(FSSecurityHandler securityHandler);

        [Export("getSecurityHandler")]
        FSSecurityHandler GetSecurityHandler();

        [Export("removeSecurity")]
        bool RemoveSecurity();
    }

    [BaseType(typeof(NSObject))]
    interface FSPDFGraphicsObjects
    {
        [Export("getFirstGraphicsObjectPosition:")]
        unsafe IntPtr GetFirstGraphicsObjectPosition(FSGraphicsObjectType filter);

        [Export("getLastGraphicsObjectPosition:")]
        unsafe IntPtr GetLastGraphicsObjectPosition(FSGraphicsObjectType filter);

        [Export("getNextGraphicsObjectPosition:pos:")]
        unsafe IntPtr GetNextGraphicsObjectPosition(FSGraphicsObjectType filter, IntPtr pos);

        [Export("getPrevGraphicsObjectPosition:pos:")]
        unsafe IntPtr GetPrevGraphicsObjectPosition(FSGraphicsObjectType filter, IntPtr pos);

        [Export("getGraphicsObject:")]
        unsafe FSPDFGraphicsObject GetGraphicsObject(IntPtr pos);

        [Export("insertGraphicsObject:graphicsObj:")]
        unsafe IntPtr InsertGraphicsObject(IntPtr posInsertAfter, FSPDFGraphicsObject graphicsObj);

        [Export("removeGraphicsObject:")]
        bool RemoveGraphicsObject(FSPDFGraphicsObject graphicsObj);

        [Export("removeGraphicsObjectByPosition:")]
        unsafe bool RemoveGraphicsObjectByPosition(IntPtr pos);

        [Export("generateContent")]
        bool GenerateContent();
    }

    [BaseType(typeof(FSPDFGraphicsObjects))]
    interface FSPDFPage
    {
        [Export("getDocument")]
        FSPDFDoc GetDocument();

        [Export("getDict")]
        FSPDFDictionary GetDict();

        [Export("isParsed")]
        bool IsParsed();

        [Export("startParse:pause:isReparse:")]
        [return: NullAllowed]
        FSProgressive StartParse(FSPageParseFlag flag, [NullAllowed] FSPauseCallback pause, bool isReparse);

        [Export("getIndex")]
        int GetIndex();

        [Export("getHeight")]
        float GetHeight();

        [Export("getWidth")]
        float GetWidth();

        [Export("getRotation")]
        FSRotation GetRotation();

        [Export("loadThumbnail")]
        FSBitmap LoadThumbnail();

        [Export("getDisplayMatrix:yPos:xSize:ySize:rotate:")]
        FSMatrix GetDisplayMatrix(int xPos, int yPos, int xSize, int ySize, FSRotation rotate);

        [Export("calcContentBBox:")]
        FSRectF CalcContentBBox(FSCalcMarginMode mode);

        [Export("getAnnotCount")]
        int GetAnnotCount();

        [Export("getAnnot:")]
        FSAnnot GetAnnot(int index);

        [Export("getAnnotAtPos:tolerance:")]
        [return: NullAllowed]
        FSAnnot GetAnnotAtPos(FSPointF pos, float tolerance);

        [Export("getAnnotAtDevicePos:position:tolerance:")]
        [return: NullAllowed]
        FSAnnot GetAnnotAtDevicePos(FSMatrix matrix, FSPointF pos, float tolerance);

        [Export("addAnnot:rect:")]
        FSAnnot AddAnnot(FSAnnotType annotType, FSRectF rect);

        [Export("removeAnnot:")]
        bool RemoveAnnot(FSAnnot annot);

        [Export("hasTransparency")]
        bool HasTransparency();

        [Export("flatten:options:")]
        bool Flatten(bool isDisplay, FSFlattenOptions options);

        [Export("setAnnotGroup:headerIndex:")]
        bool SetAnnotGroup(FSMarkup[] annotArray, int headerIndex);

        [Export("addSignature:")]
        FSSignature AddSignature(FSRectF rect);

        [Export("hasWatermark")]
        bool HasWatermark();

        [Export("removeAllWatermarks")]
        bool RemoveAllWatermarks();

        [Export("setRotation:")]
        void SetRotation(FSRotation rotate);

        [Export("setSize:height:")]
        void SetSize(float width, float height);

        [Export("setBox:box:")]
        void SetBox(FSPageBox boxType, FSRectF box);

        [Export("GetBox:")]
        FSRectF GetBox(FSPageBox box_type);

        [Export("transform:needTransformClipPath:")]
        bool Transform(FSMatrix matrix, bool needTransformClipPath);

        [Export("setClipRect:")]
        void SetClipRect(FSRectF clipRect);

        [Export("setThumbnail:")]
        void SetThumbnail(FSBitmap thumbnail);

        [Export("addImageFromFilePath:posPoint:width:height:isGenerateContent:")]
        bool AddImageFromFilePath(string imageFilePath, FSPointF posPoint, float width, float height, bool isGenerateContent);
    }

    [BaseType(typeof(NSObject))]
    interface FSBookmark
    {
        [NullAllowed, Export("getParent")]
        FSBookmark GetParent();

        [NullAllowed, Export("getFirstChild")]
        FSBookmark GetFirstChild();

        [NullAllowed, Export("getNextSibling")]
        FSBookmark GetNextSibling();

        [Export("insert:pos:")]
        FSBookmark Insert(string title, FSBookmarkPosition pos);

        [Export("moveTo:pos:")]
        bool MoveTo(FSBookmark destBookmark, FSBookmarkPosition pos);

        [Export("getDestination")]
        FSDestination GetDestination();

        [Export("setDestination:")]
        void SetDestination(FSDestination dest);

        [Export("getTitle")]
        string GetTitle();

        [Export("setTitle:")]
        void SetTitle(string title);

        [Export("getColor")]
        uint GetColor();

        [Export("setColor:")]
        void SetColor(uint color);

        [Export("getStyle")]
        FSBookmarkStyle GetStyle();

        [Export("setStyle:")]
        void SetStyle(FSBookmarkStyle style);
    }

    [BaseType(typeof(NSObject))]
    interface FSReadingBookmark
    {
        [Export("getTitle")]
        string GetTitle();

        [Export("setTitle:")]
        void SetTitle(string title);

        [Export("getPageIndex")]
        int GetPageIndex();

        [Export("setPageIndex:")]
        void SetPageIndex(int index);

        [Export("getDateTime:")]
        FSDateTime GetDateTime(bool isCreationDate);

        [Export("setDateTime:isCreationDate:")]
        void SetDateTime(FSDateTime dateTime, bool isCreationDate);
    }

    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface FSPDFNameTree
    {
        [Export("initWithPDFDoc:type:")]
        IntPtr Constructor(FSPDFDoc pdfDoc, FSNameTreeType type);

        [Export("hasName:")]
        bool HasName(string name);

        [Export("getCount")]
        int GetCount();

        [Export("getName:")]
        string GetName(int index);

        [Export("getObj:")]
        FSPDFObject GetObj(string name);

        [Export("setObj:pdfObj:")]
        bool SetObj(string name, FSPDFObject pdfObj);

        [Export("rename:newName:")]
        bool Rename(string oldName, string newName);

        [Export("add:pdfObj:")]
        bool Add(string name, FSPDFObject pdfObj);

        [Export("removeObj:")]
        bool RemoveObj(string name);

        [Export("removeAllObjs")]
        bool RemoveAllObjs();
    }

    [BaseType(typeof(NSObject))]
    interface FSPDFPageLabels
    {
        [Export("initWithDocument:")]
        IntPtr Constructor(FSPDFDoc document);

        [Export("getPageLabelTitle:")]
        string GetPageLabelTitle(int page_index);

        [Export("hasPageLabel:")]
        bool HasPageLabel(int page_index);

        [Export("getPageLabelStyle:")]
        FSPageLabelStyle GetPageLabelStyle(int page_index);

        [Export("getPageLabelPrefix:")]
        string GetPageLabelPrefix(int page_index);

        [Export("getFirstLabelNumber:")]
        int GetFirstLabelNumber(int page_index);

        [Export("setPageLabel:label_style:prefix_string:first_label_number:")]
        void SetPageLabel(int page_index, FSPageLabelStyle label_style, string prefix_string, int first_label_number);

        [Export("removePageLabel:")]
        void RemovePageLabel(int page_index);

        [Export("removeAll")]
        void RemoveAll();
    }

    [BaseType(typeof(NSObject))]
    interface FSPDFMetadata
    {
        [Export("initWithDocument:")]
        IntPtr Constructor(FSPDFDoc document);

        [Export("hasKey:")]
        bool HasKey(string key);

        [NullAllowed, Export("getCreationDateTime")]
        FSDateTime GetCreationDateTime();

        [NullAllowed, Export("getModifiedDateTime")]
        FSDateTime GetModifiedDateTime();

        [Export("setCreationDateTime:")]
        void SetCreationDateTime(FSDateTime date_time);

        [Export("setModifiedDateTime:")]
        void SetModifiedDateTime(FSDateTime date_time);

        [Export("getValue:")]
        [return: NullAllowed]
        string GetValue(string key);

        [Export("getValueCount:")]
        int GetValueCount(string key);

        [Export("getValueByIndex:index:")]
        string GetValueByIndex(string key, int index);

        [Export("setValues:value_array:")]
        void SetValues(string key, string[] value_array);

        [Export("getKeys:")]
        [return: NullAllowed]
        string[] GetKeys(FSMetadataKeyType key_type);

        [Export("removeKey:")]
        void RemoveKey(string key);
    }

    [BaseType(typeof(NSObject))]
    interface FSForm
    {
        [Export("getFieldCount:")]
        int GetFieldCount(string filter);

        [Export("getField:index:")]
        FSFormField GetField(string filter, int index);

        [Export("getFormFiller")]
        FSFormFiller GetFormFiller();

        [Export("reset")]
        bool Reset();

        [Export("exportToXML:")]
        bool ExportToXML(string path);

        [Export("importFromXML:")]
        bool ImportFromXML(string path);

        [Export("exportToFDFDoc:")]
        bool ExportToFDFDoc(FSFDFDoc fdfDoc);

        [Export("importFromFDFDoc:")]
        bool ImportFromFDFDoc(FSFDFDoc fdfDoc);
    }

    [BaseType(typeof(NSObject))]
    interface FSChoiceOption
    {
        [Export("initWithOption:")]
        IntPtr Constructor(FSChoiceOption option);

        [Export("set:optionLabel:selected:defaultSelected:")]
        void Set(string optionValue, string optionLabel, bool selected, bool defaultSelected);

        [Export("optionValue")]
        string OptionValue { get; set; }

        [Export("optionLabel")]
        string OptionLabel { get; set; }

        [Export("selected")]
        bool Selected { get; set; }

        [Export("defaultSelected")]
        bool DefaultSelected { get; set; }
    }

    [BaseType(typeof(NSObject))]
    interface FSFormField
    {
        [Export("getType")]
        FSFormFieldType GetThisType();

        [Export("getFlags")]
        FSFormFieldFlags GetFlags();

        [Export("setFlags:")]
        void SetFlags(FSFormFieldFlags flags);

        [Export("getName")]
        string GetName();

        [Export("getDefaultValue")]
        string GetDefaultValue();

        [Export("setDefualtValue:")]
        void SetDefualtValue(string value);

        [Export("getValue")]
        string GetValue();

        [Export("setValue:")]
        void SetValue(string value);

        [Export("getAlignment")]
        FSAlignment GetAlignment();

        [Export("setAlignment:")]
        void SetAlignment(FSAlignment alignment);

        [Export("getAlternateName")]
        string GetAlternateName();

        [Export("setAlternateName:")]
        void SetAlternateName(string alternate_name);

        [Export("getDefaultAppearance")]
        FSDefaultAppearance GetDefaultAppearance();

        [Export("setDefaultAppearance:")]
        void SetDefaultAppearance(FSDefaultAppearance appearance);

        [Export("getMappingName")]
        string GetMappingName();

        [Export("setMappingName:")]
        void SetMappingName(string name);

        [Export("getMaxLength")]
        int GetMaxLength();

        [Export("setMaxLength:")]
        void SetMaxLength(int max_length);

        [Export("getOptions")]
        FSChoiceOption[] GetOptions();

        [Export("setOptions:")]
        void SetOptions(FSChoiceOption[] option_array);

        [Export("getTopVisibleIndex")]
        int GetTopVisibleIndex();

        [Export("setTopVisibleIndex:")]
        void SetTopVisibleIndex(int index);

        [Export("getControlCount")]
        int GetControlCount();

        [Export("getControl:")]
        FSFormControl GetControl(int index);

        [Export("reset")]
        bool Reset();
    }

    [BaseType(typeof(NSObject))]
    interface FSFormControl
    {
        [Export("getField")]
        FSFormField GetField();

        [Export("getWidget")]
        FSWidget GetWidget();

        [Export("getIndex")]
        int GetIndex();

        [Export("getExportValue")]
        string GetExportValue();

        [Export("setExportValue:")]
        void SetExportValue(string value);

        [Export("isChecked")]
        bool IsChecked();

        [Export("setChecked:")]
        void SetChecked(bool @checked);

        [Export("isDefaultChecked")]
        bool IsDefaultChecked();

        [Export("setDefaultChecked:")]
        void SetDefaultChecked(bool @checked);
    }

    [BaseType(typeof(NSObject))]
    interface FSTimer
    {
        [Export("onTimer:")]
        void OnTimer(int timer);
    }

    [BaseType(typeof(NSObject))]
    interface FSFormFillerAssist
    {
        [Export("getVersion")]
        int GetVersion();

        [Export("refresh:pdfRect:")]
        void Refresh(FSPDFPage page, FSRectF pdfRect);

        [Export("setTimer:timer:timerID:")]
        unsafe bool SetTimer(int elapse, FSTimer timer, IntPtr timerID);

        [Export("killTimer:")]
        bool KillTimer(int timerID);

        [Export("focusGotOnControl:fieldValue:")]
        void FocusGotOnControl(FSFormControl control, string fieldValue);

        [Export("focusLostFromControl:fieldValue:")]
        void FocusLostFromControl(FSFormControl control, string fieldValue);
    }

    [BaseType(typeof(NSObject))]
    interface FSFormFiller
    {
        [Export("initWithForm:assist:")]
        IntPtr Constructor(FSForm form, FSFormFillerAssist assist);

        [Export("render:matrix:renderer:")]
        void Render(FSPDFPage page, FSMatrix matrix, NSObject renderer);

        [Export("tap:point:")]
        bool Tap(FSPDFPage page, FSPointF point);

        [Export("touchesBegan:point:")]
        bool TouchesBegan(FSPDFPage page, FSPointF point);

        [Export("touchesMoved:point:")]
        bool TouchesMoved(FSPDFPage page, FSPointF point);

        [Export("touchesEnded:point:")]
        bool TouchesEnded(FSPDFPage page, FSPointF point);

        [Export("input:")]
        bool Input(uint charCode);

        [Export("setFocus:")]
        bool SetFocus(FSFormControl control);

        [Export("highlightFormFields:")]
        void HighlightFormFields(bool isHighlight);

        [Export("setHighlightColor:")]
        void SetHighlightColor(uint color);
    }

    [BaseType(typeof(NSObject))]
    interface FSLayerZoomData
    {
        [Export("initWithMinFactor:MaxFactor:")]
        IntPtr Constructor(float minFactor, float maxFactor);

        [Export("initWithData:")]
        IntPtr Constructor(FSLayerZoomData data);

        [Export("set:maxFactor:")]
        void Set(float minFactor, float maxFactor);

        [Export("setMinFactor:")]
        void SetMinFactor(float value);

        [Export("getMinFactor")]
        float GetMinFactor();

        [Export("setMaxFactor:")]
        void SetMaxFactor(float value);

        [Export("getMaxFactor")]
        float GetMaxFactor();
    }

    [BaseType(typeof(NSObject))]
    interface FSLayerNode
    {
        [Export("getChildrenCount")]
        int GetChildrenCount();

        [Export("getChild:")]
        FSLayerNode GetChild(int index);

        [Export("getName")]
        string GetName();

        [Export("hasLayer")]
        bool HasLayer();

        [Export("hasIntent:")]
        bool HasIntent(string intent);

        [Export("isInPage:")]
        bool IsInPage(FSPDFPage page);

        [Export("getViewUsage")]
        FSLayerUsageState GetViewUsage();

        [Export("getExportUsage")]
        FSLayerUsageState GetExportUsage();

        [Export("getPrintUsage")]
        FSLayerPrintData GetPrintUsage();

        [Export("getZoomUsage")]
        FSLayerZoomData GetZoomUsage();

        [Export("setName:")]
        bool SetName(string name);

        [Export("setDefaultVisible:")]
        bool SetDefaultVisible(bool visible);

        [Export("setViewUsage:")]
        bool SetViewUsage(FSLayerUsageState state);

        [Export("setExportUsage:")]
        bool SetExportUsage(FSLayerUsageState state);

        [Export("setPrintUsage:")]
        bool SetPrintUsage(FSLayerPrintData data);

        [Export("setZoomUsage:")]
        bool SetZoomUsage(FSLayerZoomData data);

        [Export("getGraphicsObjects:")]
        FSPDFGraphicsObject[] GetGraphicsObjects(FSPDFPage page);

        [Export("addGraphicsObject:graphicsObject:")]
        bool AddGraphicsObject(FSPDFPage page, FSPDFGraphicsObject graphicsObject);

        [Export("removeGraphicsObject:")]
        bool RemoveGraphicsObject(FSPDFGraphicsObject graphicsObject);

        [Export("removeUsage:")]
        bool RemoveUsage(FSLayerUsageType usageType);
    }

    [BaseType(typeof(NSObject))]
    interface FSLayerTree
    {
        [Export("initWithPDFDoc:")]
        IntPtr Constructor(FSPDFDoc doc);

        [Export("setBaseState:")]
        bool SetBaseState(FSLayerUsageState state);

        [Export("getRootNode")]
        FSLayerNode GetRootNode();
    }

    [BaseType(typeof(NSObject))]
    interface FSLayerContext
    {
        [Export("initWithPDFDoc:usageType:")]
        IntPtr Constructor(FSPDFDoc doc, FSLayerUsageType usageType);

        [Export("getDocument")]
        FSPDFDoc GetDocument();

        [Export("getUsageType")]
        FSLayerUsageType GetUsageType();

        [Export("reset")]
        bool Reset();

        [Export("copyStates:")]
        bool CopyStates(FSLayerContext srcContext);

        [Export("mergeStates:")]
        bool MergeStates(FSLayerContext srcContext);

        [Export("isVisible:")]
        bool IsVisible(FSLayerNode layer);

        [Export("setVisible:visible:")]
        bool SetVisible(FSLayerNode layer, bool visible);
    }

    [BaseType(typeof(NSObject))]
    interface FSLayerPrintData
    {
        [Export("initWithSubType:PrintState:")]
        IntPtr Constructor(string subType, FSLayerUsageState state);

        [Export("initWithData:")]
        IntPtr Constructor(FSLayerPrintData data);

        [Export("set:printState:")]
        void Set(string subtype, FSLayerUsageState printState);

        [Export("setSubtype:")]
        void SetSubtype(string value);

        [Export("getSubtype")]
        string GetSubtype();

        [Export("setPrintState:")]
        void SetPrintState(FSLayerUsageState value);

        [Export("getPrintState")]
        FSLayerUsageState GetPrintState();
    }

    [BaseType(typeof(NSObject))]
    interface FSBitmap
    {
        [Export("initWithWidth:height:format:buffer:pitch:")]
        unsafe IntPtr Constructor(int width, int height, FSDIBFormat format, [NullAllowed] IntPtr buffer, int pitch);

        [Export("initWithUIImage:")]
        IntPtr Constructor(UIImage image);

        [Export("clone:")]
        FSBitmap Clone([NullAllowed] FSRectI clip);

        [Export("getWidth")]
        int GetWidth();

        [Export("getHeight")]
        int GetHeight();

        [Export("getPitch")]
        int GetPitch();

        [Export("getBpp")]
        int GetBpp();

        [Export("getBuffer")]
        NSData GetBuffer();

        [Export("getFormat")]
        FSDIBFormat GetFormat();

        [Export("fillRect:rect:")]
        void FillRect(uint color, [NullAllowed] FSRectI rect);
    }

    [BaseType(typeof(NSObject))]
    interface FSRenderer
    {
        [Export("initWithBitmap:rgbOrder:")]
        IntPtr Constructor(FSBitmap bitmap, bool rgbOrder);

        [Static]
        [Export("createFromContext:deviceType:")]
        [return: NullAllowed]
        unsafe FSRenderer CreateFromContext(IntPtr context, FSDeviceType deviceType);

        [Export("startQuickRender:matrix:pause:")]
        [return: NullAllowed]
        FSProgressive StartQuickRender(FSPDFPage page, FSMatrix matrix, [NullAllowed] FSPauseCallback pause);

        [Export("startRender:matrix:pause:")]
        [return: NullAllowed]
        FSProgressive StartRender(FSPDFPage page, FSMatrix matrix, [NullAllowed] FSPauseCallback pause);

        [Export("startRenderReflowPage:matrix:pause:")]
        [return: NullAllowed]
        FSProgressive StartRenderReflowPage(FSReflowPage reflowPage, FSMatrix matrix, [NullAllowed] FSPauseCallback pause);

        [Export("startRenderBitmap:matrix:clipRect:interpolation:pause:")]
        [return: NullAllowed]
        FSProgressive StartRenderBitmap(FSBitmap bitmap, FSMatrix matrix, FSRectI clipRect, FSBitmapInterpolationFlag interpolation, [NullAllowed] FSPauseCallback pause);

        [Export("renderAnnot:matrix:")]
        bool RenderAnnot(FSAnnot annot, FSMatrix matrix);

        [Export("setRenderContent:")]
        void SetRenderContent(FSRenderContentFlag renderContentFlag);

        [Export("setTransformAnnotIcon:")]
        void SetTransformAnnotIcon(bool transformAnnotIcon);

        [Export("setLayerContext:")]
        void SetLayerContext(FSLayerContext layerContext);

        [Export("setColorMode:")]
        void SetColorMode(FSRenderColorMode colorMode);

        [Export("setMappingModeColors:foreColor:")]
        void SetMappingModeColors(uint backColor, uint foreColor);

        [Export("setForceHalftone:")]
        void SetForceHalftone(bool isForceHalftone);
    }

    [BaseType(typeof(NSObject))]
    interface FSImage
    {
        [Export("initWithFilePath:")]
        IntPtr Constructor(string path);

        [Export("initWithBuffer:")]
        IntPtr Constructor(NSData buffer);

        [Export("initWithFileRead:")]
        IntPtr Constructor(FSFileReadCallback fileRead);

        [Export("getType")]
        FSImageType GetThisType();

        [Export("getWidth")]
        int GetWidth();

        [Export("getHeight")]
        int GetHeight();

        [Export("getFrameCount")]
        int GetFrameCount();

        [Export("getFrameBitmap:")]
        FSBitmap GetFrameBitmap(int index);

        [Export("getXDPI")]
        int GetXDPI();

        [Export("getYDPI")]
        int GetYDPI();

        [Export("addFrame:")]
        bool AddFrame(FSBitmap bitmap);

        [Export("setDPIs:y_dpi:")]
        void SetDPIs(int x_dpi, int y_dpi);

        [Export("saveAs:")]
        bool SaveAs(string file_path);
    }

    [BaseType(typeof(NSObject))]
    interface FSPDFObject
    {
        [Static]
        [Export("createFromBoolean:")]
        FSPDFObject CreateFromBoolean(bool boolean);

        [Static]
        [Export("createFromFloat:")]
        FSPDFObject CreateFromFloat(float f);

        [Static]
        [Export("createFromInteger:")]
        FSPDFObject CreateFromInteger(int integer);

        [Static]
        [Export("createFromString:")]
        FSPDFObject CreateFromString(string @string);

        [Static]
        [Export("createFromName:")]
        FSPDFObject CreateFromName(string name);

        [Static]
        [Export("createFromDateTime:")]
        FSPDFObject CreateFromDateTime(FSDateTime dateTime);

        [Static]
        [Export("createReference:objnum:")]
        FSPDFObject CreateReference(FSPDFDoc pDoc, uint objnum);

        [Export("cloneObject")]
        FSPDFObject CloneObject();

        [Export("getType")]
        FSPDFObjectType GetThisType();

        [Export("getObjNum")]
        uint GetObjNum();

        [Export("getInteger")]
        int GetInteger();

        [Export("getFloat")]
        float GetFloat();

        [Export("getBoolean")]
        bool GetBoolean();

        [Export("getMatrix")]
        FSMatrix GetMatrix();

        [Export("getRect")]
        FSRectF GetRect();

        [Export("getDirectObject")]
        FSPDFObject GetDirectObject();

        [Export("getDateTime")]
        FSDateTime GetDateTime();

        [Export("getString")]
        string GetString();
    }

    [BaseType(typeof(FSPDFObject))]
    interface FSPDFStream
    {
        [Static]
        [Export("create:")]
        FSPDFStream Create(FSPDFDictionary dictionary);

        [Export("getDictionary")]
        FSPDFDictionary GetDictionary();

        [Export("getDataSize:")]
        uint GetDataSize(bool rawData);

        [Export("getData:bufLen:")]
        NSData GetData(bool rawData, int bufLen);

        [Export("setData:")]
        void SetData(NSData buffer);
    }

    [BaseType(typeof(FSPDFObject))]
    interface FSPDFArray
    {
        [Static]
        [Export("create")]
        FSPDFArray Create();

        [Static]
        [Export("createFromMatrix:")]
        FSPDFArray CreateFromMatrix(FSMatrix matrix);

        [Static]
        [Export("createFromRect:")]
        FSPDFArray CreateFromRect(FSRectF rect);

        [Export("getElementCount")]
        int GetElementCount();

        [Export("getElement:")]
        FSPDFObject GetElement(int index);

        [Export("addElement:")]
        void AddElement(FSPDFObject element);

        [Export("insertAt:element:")]
        void InsertAt(int index, FSPDFObject element);

        [Export("setAt:element:")]
        void SetAt(int index, FSPDFObject element);

        [Export("removeAt:")]
        void RemoveAt(int index);
    }

    [BaseType(typeof(FSPDFObject))]
    interface FSPDFDictionary
    {
        [Static]
        [Export("create")]
        FSPDFDictionary Create();

        [Export("hasKey:")]
        bool HasKey(string key);

        [Export("getElement:")]
        FSPDFObject GetElement(string key);

        [Export("getKey:")]
        unsafe string GetKey(IntPtr pos);

        [Export("getValue:")]
        unsafe FSPDFObject GetValue(IntPtr pos);

        [Export("moveNext:")]
        unsafe IntPtr MoveNext([NullAllowed] IntPtr pos);

        [Export("setAt:object:")]
        void SetAt(string key, FSPDFObject @object);

        [Export("removeAt:")]
        void RemoveAt(string key);
    }

    [BaseType(typeof(NSObject))]
    interface FSPDFTextSearch
    {
        [Export("initWithPDFDoc:pause:")]
        IntPtr Constructor(FSPDFDoc pdfDoc, [NullAllowed] FSPauseCallback pause);

        [Export("setKeyWords:")]
        bool SetKeyWords(string keyWords);

        [Export("setStartPage:")]
        bool SetStartPage(int pageIndex);

        [Export("setFlag:")]
        bool SetFlag(FSSearchFlag flag);

        [Export("findNext")]
        bool FindNext();

        [Export("findPrev")]
        bool FindPrev();

        [Export("getMatchRectCount")]
        int GetMatchRectCount();

        [Export("getMatchRect:")]
        FSRectF GetMatchRect(int index);

        [Export("getMatchPageIndex")]
        int GetMatchPageIndex();

        [Export("getMatchSentence")]
        string GetMatchSentence();

        [Export("getMatchSentenceStartIndex")]
        int GetMatchSentenceStartIndex();

        [Export("getMatchStartCharIndex")]
        int GetMatchStartCharIndex();

        [Export("getMatchEndCharIndex")]
        int GetMatchEndCharIndex();
    }

    [BaseType(typeof(NSObject))]
    interface FSPDFTextSelect
    {
        [Export("initWithPDFPage:")]
        IntPtr Constructor(FSPDFPage pPage);

        [Export("getPage")]
        FSPDFPage GetPage();

        [Export("getCharCount")]
        int GetCharCount();

        [Export("getChars:count:")]
        string GetChars(int startIndex, int count);

        [Export("getIndexAtPos:y:tolerance:")]
        int GetIndexAtPos(float x, float y, float tolerance);

        [Export("getTextInRect:")]
        string GetTextInRect(FSRectF rect);

        [Export("getWordAtPos:y:tolerance:")]
        NSRange GetWordAtPos(float x, float y, float tolerance);

        [Export("getTextRectCount:count:")]
        int GetTextRectCount(int start, int count);

        [Export("getTextRect:")]
        FSRectF GetTextRect(int rectIndex);

        [Export("getBaselineRotation:")]
        FSRotation GetBaselineRotation(int rectIndex);
    }

    [BaseType(typeof(NSObject))]
    interface FSPDFTextLink
    {
        [Export("getURI")]
        string GetURI();

        [Export("getStartCharIndex")]
        int GetStartCharIndex();

        [Export("getEndCharIndex")]
        int GetEndCharIndex();

        [Export("getRectCount")]
        int GetRectCount();

        [Export("getRect:")]
        FSRectF GetRect(int rectIndex);
    }

    [BaseType(typeof(NSObject))]
    interface FSPDFPageLinks
    {
        [Export("initWithPDFPage:")]
        IntPtr Constructor(FSPDFPage page);

        [Export("getTextLinkCount")]
        int GetTextLinkCount();

        [Export("getTextLink:")]
        FSPDFTextLink GetTextLink(int index);

        [Export("getLinkAnnotCount")]
        int GetLinkAnnotCount();

        [Export("getLinkAnnot:")]
        FSLink GetLinkAnnot(int index);
    }

    [BaseType(typeof(NSObject))]
    interface FSSignatureCallback
    {
        [Export("startCalcDigest:byteRangeArray:signature:clientData:")]
        unsafe bool StartCalcDigest(FSFileReadCallback file, NSNumber[] byteRangeArray, FSSignature signature, [NullAllowed] IntPtr clientData);

        [Export("continueCalcDigest:clientData:")]
        unsafe FSProgressState ContinueCalcDigest([NullAllowed] FSPauseCallback pause, [NullAllowed] IntPtr clientData);

        [Export("getDigest:")]
        unsafe NSData GetDigest([NullAllowed] IntPtr clientData);

        [Export("sign:certPath:password:digestAlgorithm:clientData:")]
        unsafe NSData Sign(NSData digest, [NullAllowed] string certPath, [NullAllowed] string password, FSDigestAlgorithm digestAlgorithm, [NullAllowed] IntPtr clientData);

        [Export("verifySigState:signedData:clientData:")]
        unsafe FSSignatureStates VerifySigState(NSData digest, NSData signedData, [NullAllowed] IntPtr clientData);
    }

    [BaseType(typeof(FSFormField))]
    interface FSSignature
    {
        [Export("isSigned")]
        bool IsSigned();

        [Export("startSign:cert_password:digest_algorithm:client_data:pause:save_path:")]
        [return: NullAllowed]
        unsafe FSProgressive StartSign([NullAllowed] string cert_path, [NullAllowed] string cert_password, FSDigestAlgorithm digest_algorithm, [NullAllowed] IntPtr client_data, [NullAllowed] FSPauseCallback pause, string save_path);

        [Export("startVerify:pause:")]
        [return: NullAllowed]
        unsafe FSProgressive StartVerify([NullAllowed] IntPtr client_data, [NullAllowed] FSPauseCallback pause);

        [Export("getCertificateInfo:")]
        string GetCertificateInfo(string key);

        [NullAllowed, Export("getByteRanges")]
        NSNumber[] GetByteRanges();

        [Export("getState")]
        FSSignatureStates GetState();

        [Export("clearSignedData")]
        bool ClearSignedData();

        [Export("getDocument")]
        FSPDFDoc GetDocument();

        [Export("getAppearanceFlags")]
        FSSignatureAPFlags GetAppearanceFlags();

        [Export("setAppearanceFlags:")]
        void SetAppearanceFlags(FSSignatureAPFlags apFlags);

        [Export("setAppearanceContent:")]
        void SetAppearanceContent(string appearanceContent);

        [Export("getSignTime")]
        FSDateTime GetSignTime();

        [Export("setSignTime:")]
        void SetSignTime(FSDateTime signTime);

        [Export("getKeyValue:")]
        string GetKeyValue(FSSignatureKeyName key);

        [Export("setKeyValue:value:")]
        void SetKeyValue(FSSignatureKeyName key, string value);

        [Export("getBitmap")]
        FSBitmap GetBitmap();

        [Export("setBitmap:")]
        void SetBitmap(FSBitmap bitmap);

        [Export("setImage:frame_index:")]
        void SetImage(FSImage image, int frame_index);

        [Export("getSignatureDict")]
        FSPDFDictionary GetSignatureDict();

        [Export("setDefaultContentsLength:")]
        void SetDefaultContentsLength(uint default_length);

        [Export("getCertCount")]
        int GetCertCount();

        [Export("getCert:")]
        string GetCert(int index);

        [Export("setCertChain:")]
        void SetCertChain(string[] cert_chain);
    }

    [BaseType(typeof(NSObject))]
    interface FSReflowPage
    {
        [Export("initWithPDFPage:")]
        IntPtr Constructor(FSPDFPage pdfPage);

        [Export("setScreenSize:screenHeight:")]
        void SetScreenSize(float screenWidth, float screenHeight);

        [Export("setZoom:")]
        void SetZoom(int zoom);

        [Export("setParseFlags:")]
        void SetParseFlags(FSReflowFlags flags);

        [Export("setLineSpace:")]
        void SetLineSpace(float lineSpace);

        [Export("setTopSpace:")]
        void SetTopSpace(float topSpace);

        [Export("startParse:")]
        [return: NullAllowed]
        FSProgressive StartParse([NullAllowed] FSPauseCallback pause);

        [Export("getContentWidth")]
        float GetContentWidth();

        [Export("getContentHeight")]
        float GetContentHeight();

        [Export("getDisplayMatrix:offsetY:")]
        FSMatrix GetDisplayMatrix(float offsetX, float offsetY);

        [Export("getFocusData:point:")]
        string GetFocusData(FSMatrix matrix, FSPointF point);

        [Export("getFocusPosition:focusData:")]
        FSPointF GetFocusPosition(FSMatrix matrix, string focusData);

        [Export("isParsed")]
        bool IsParsed();
    }

    [BaseType(typeof(NSObject))]
    interface FSPSICallback
    {
        [Export("refresh:Rect:")]
        void Refresh(FSPSI PSIHandle, FSRectF flushRect);
    }

    [BaseType(typeof(NSObject))]
    interface FSPSI
    {
        [Export("initWithBitmap:simulate:")]
        IntPtr Constructor(FSBitmap bitmap, bool simulate);

        [Export("initWithWidth:height:simulate:")]
        IntPtr Constructor(int width, int height, bool simulate);

        [Export("setCallback:")]
        void SetCallback(FSPSICallback callback);

        [Export("setColor:")]
        void SetColor(uint color);

        [Export("setDiameter:")]
        void SetDiameter(int diameter);

        [Export("setOpacity:")]
        void SetOpacity(float opacity);

        [Export("addPoint:ptType:pressure:")]
        void AddPoint(FSPointF point, FSPathPointType ptType, float pressure);

        [Export("getContentsRect")]
        FSRectF GetContentsRect();

        [Export("getBitmap")]
        FSBitmap GetBitmap();

        [Export("convertToPDFAnnot:rect:rotate:")]
        FSPSInk ConvertToPDFAnnot(FSPDFPage pdfPage, FSRectF rect, FSRotation rotate);
    }

    [BaseType(typeof(NSObject))]
    interface FSWatermark
    {
        [Export("initWithDocument:text:properties:settings:")]
        IntPtr Constructor(FSPDFDoc document, string text, FSWatermarkTextProperties properties, FSWatermarkSettings settings);

        [Export("getWidth")]
        float GetWidth();

        [Export("getHeight")]
        float GetHeight();

        [Export("insertToPage:")]
        bool InsertToPage(FSPDFPage page);
    }

    [BaseType(typeof(NSObject))]
    interface FSWatermarkSettings
    {
        [Export("position", ArgumentSemantic.Assign)]
        FSWatermarkPosition Position { get; set; }

        [Export("offset_x")]
        float Offset_x { get; set; }

        [Export("offset_y")]
        float Offset_y { get; set; }

        [Export("flags", ArgumentSemantic.Assign)]
        FSWatermarkFlags Flags { get; set; }

        [Export("scale_x")]
        float Scale_x { get; set; }

        [Export("scale_y")]
        float Scale_y { get; set; }

        [Export("rotation")]
        float Rotation { get; set; }

        [Export("opacity")]
        int Opacity { get; set; }

        [Export("initWithSettings:")]
        IntPtr Constructor(FSWatermarkSettings settings);

        [Export("set:offset_x:offset_y:flags:scale_x:scale_y:rotation:opacity:")]
        void Set(FSWatermarkPosition position, float offset_x, float offset_y, uint flags, float scale_x, float scale_y, float rotation, int opacity);
    }

    [BaseType(typeof(NSObject))]
    interface FSWatermarkTextProperties
    {
        [Export("font", ArgumentSemantic.Strong)]
        FSFont Font { get; set; }

        [Export("font_size")]
        float Font_size { get; set; }

        [Export("color")]
        uint Color { get; set; }

        [Export("font_style", ArgumentSemantic.Assign)]
        FSWatermarkFontStyle Font_style { get; set; }

        [Export("line_space")]
        float Line_space { get; set; }

        [Export("alignment", ArgumentSemantic.Assign)]
        FSWatermarkTextAlignment Alignment { get; set; }

        [Export("initWithProperties:")]
        IntPtr Constructor(FSWatermarkTextProperties properties);

        [Export("set:font_size:color:style:line_space:alignment:")]
        void Set(FSFont font, float font_size, uint color, FSWatermarkFontStyle style, float line_space, FSWatermarkTextAlignment alignment);
    }

    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface IRecoveryEventListener
    {
        [Export("onWillRecover")]
        void OnWillRecover();

        [Export("onRecovered")]
        void OnRecovered();
    }

    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface IRotationEventListener
    {
        [Export("willRotateToInterfaceOrientation:duration:")]
        void WillRotateToInterfaceOrientation(UIInterfaceOrientation toInterfaceOrientation, double duration);

        [Export("willAnimateRotationToInterfaceOrientation:duration:")]
        void WillAnimateRotationToInterfaceOrientation(UIInterfaceOrientation toInterfaceOrientation, double duration);

        [Export("didRotateFromInterfaceOrientation:")]
        void DidRotateFromInterfaceOrientation(UIInterfaceOrientation fromInterfaceOrientation);
    }

    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface IDocEventListener
    {
        [Export("onDocWillOpen")]
        void OnDocWillOpen();

        [Export("onDocOpened:error:")]
        void OnDocOpened(FSPDFDoc document, int error);

        [Export("onDocWillClose:")]
        void OnDocWillClose(FSPDFDoc document);

        [Export("onDocClosed:error:")]
        void OnDocClosed(FSPDFDoc document, int error);

        [Export("onDocWillSave:")]
        void OnDocWillSave(FSPDFDoc document);

        [Export("onDocSaved:error:")]
        void OnDocSaved(FSPDFDoc document, int error);
    }

    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface IPageEventListener
    {
        [Export("onPageChanged:currentIndex:")]
        void OnPageChanged(int oldIndex, int currentIndex);

        [Export("onPageVisible:")]
        void OnPageVisible(int index);

        [Export("onPageInvisible:")]
        void OnPageInvisible(int index);

        [Export("onPageJumped")]
        void OnPageJumped();

        [Export("onPagesWillRemove:")]
        void OnPagesWillRemove(NSNumber[] indexes);

        [Export("onPagesWillMove:dstIndex:")]
        void OnPagesWillMove(NSNumber[] indexes, int dstIndex);

        [Export("onPagesWillRotate:rotation:")]
        void OnPagesWillRotate(NSNumber[] indexes, int rotation);

        [Export("onPagesRemoved:")]
        void OnPagesRemoved(NSNumber[] indexes);

        [Export("onPagesMoved:dstIndex:")]
        void OnPagesMoved(NSNumber[] indexes, int dstIndex);

        [Export("onPagesRotated:rotation:")]
        void OnPagesRotated(NSNumber[] indexes, int rotation);

        [Export("onPagesInsertedAtRange:")]
        void OnPagesInsertedAtRange(NSRange range);
    }

    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface ILayoutEventListener
    {
        [Abstract]
        [Export("onLayoutModeChanged:newLayoutMode:")]
        void NewLayoutMode(FSLayoutMode oldLayoutMode, FSLayoutMode newLayoutMode);
    }

    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface IScrollViewEventListener
    {
        [Export("onScrollViewDidScroll:")]
        void OnScrollViewDidScroll(UIScrollView scrollView);

        [Export("onScrollViewDidZoom:")]
        void OnScrollViewDidZoom(UIScrollView scrollView);

        [Export("onScrollViewWillBeginDragging:")]
        void OnScrollViewWillBeginDragging(UIScrollView scrollView);

        [Export("onScrollViewDidEndDragging:willDecelerate:")]
        void OnScrollViewDidEndDragging(UIScrollView scrollView, bool decelerate);

        [Export("onScrollViewWillBeginDecelerating:")]
        void OnScrollViewWillBeginDecelerating(UIScrollView scrollView);

        [Export("onScrollViewDidEndDecelerating:")]
        void OnScrollViewDidEndDecelerating(UIScrollView scrollView);

        [Export("onScrollViewWillBeginZooming:")]
        void OnScrollViewWillBeginZooming(UIScrollView scrollView);

        [Export("onScrollViewDidEndZooming:")]
        void OnScrollViewDidEndZooming(UIScrollView scrollView);
    }

    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface IGestureEventListener
    {
        [Export("onLongPress:")]
        bool OnLongPress(UILongPressGestureRecognizer gestureRecognizer);

        [Export("onTap:")]
        bool OnTap(UITapGestureRecognizer gestureRecognizer);

        [Export("onPan:")]
        bool OnPan(UIPanGestureRecognizer gestureRecognizer);

        [Export("onShouldBegin:")]
        bool OnShouldBegin(UIGestureRecognizer gestureRecognizer);
    }

    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface IDrawEventListener
    {
        [Abstract]
        [Export("onDraw:inContext:")]
        unsafe void InContext(int pageIndex, IntPtr context);
    }

    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface ITouchEventListener
    {
        [Export("onTouchesBegan:withEvent:")]
        bool OnTouchesBegan(NSSet touches, UIEvent @event);

        [Export("onTouchesMoved:withEvent:")]
        bool OnTouchesMoved(NSSet touches, UIEvent @event);

        [Export("onTouchesEnded:withEvent:")]
        bool OnTouchesEnded(NSSet touches, UIEvent @event);

        [Export("onTouchesCancelled:withEvent:")]
        bool OnTouchesCancelled(NSSet touches, UIEvent @event);
    }

    //[Protocol, Model]
    //[BaseType(typeof(NSObject))]
    //interface FSPDFUIExtensionsManager : IGestureEventListener, IDrawEventListener, ITouchEventListener
    //{
    //[Export("shouldDrawAnnot:")]
    //bool ShouldDrawAnnot(FSAnnot annot);
    //}

    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface FSPageOrganizerDelegate
    {
        [Abstract]
        [Export("movePagesFromIndexes:toIndex:")]
        bool MovePagesFromIndexes(NSNumber[] sourcePageIndexes, nuint pageIndex);

        [Abstract]
        [Export("deletePagesAtIndexes:")]
        bool DeletePagesAtIndexes(NSNumber[] pageIndexes);

        [Abstract]
        [Export("rotatePagesAtIndexes:clockwise:")]
        bool RotatePagesAtIndexes(NSNumber[] pageIndexes, bool clockwise);

        [Abstract]
        [Export("insertPageFromImage:atIndex:")]
        bool InsertPageFromImage(UIImage image, nuint pageIndex);

        [Abstract]
        [Export("insertPagesFromDocument:withSourceIndexes:flags:layerName:atIndex:")]
        bool InsertPagesFromDocument(FSPDFDoc document, NSNumber[] sourcePagesIndexes, FSImportFlags flags, string layerName, nuint pageIndex);
    }

    [BaseType(typeof(UIView))]
    interface FSPDFViewCtrl : IRotationEventListener, FSPageOrganizerDelegate
    {
        [NullAllowed, Export("extensionsManager", ArgumentSemantic.Weak)]
        UIExtensionsManager ExtensionsManager { get; set; }

        [Export("currentDoc", ArgumentSemantic.Strong)]
        FSPDFDoc CurrentDoc { get; set; }

        [Export("isNightMode")]
        bool IsNightMode { get; set; }

        [Export("bottomOffset")]
        int BottomOffset { get; set; }

        [Export("shouldRecover")]
        bool ShouldRecover { get; set; }

        [NullAllowed, Export("filePath", ArgumentSemantic.Strong)]
        string FilePath { get; }

        [Export("initWithFrame:")]
        IntPtr Constructor(CGRect frame);

        [Export("registerDocEventListener:")]
        void RegisterDocEventListener(NSObject listener);

        [Export("registerPageEventListener:")]
        void RegisterPageEventListener(IPageEventListener listener);

        [Export("registerScrollViewEventListener:")]
        void RegisterScrollViewEventListener(IScrollViewEventListener listener);

        [Export("registerLayoutChangedEventListener:")]
        void RegisterLayoutChangedEventListener(ILayoutEventListener listener);

        [Export("registerGestureEventListener:")]
        void RegisterGestureEventListener(IGestureEventListener listener);

        [Export("registerDrawEventListener:")]
        void RegisterDrawEventListener(IDrawEventListener listener);

        [Export("registerRecoveryEventListener:")]
        void RegisterRecoveryEventListener(IRecoveryEventListener listener);

        [Export("unregisteRecoveryEventListener:")]
        void UnregisteRecoveryEventListener(IRecoveryEventListener listener);

        [Export("unregisterDrawEventListener:")]
        void UnregisterDrawEventListener(IDrawEventListener listener);

        [Export("unregisterGestureEventListener:")]
        void UnregisterGestureEventListener(IGestureEventListener listener);

        [Export("unregisterDocEventListener:")]
        void UnregisterDocEventListener(NSObject listener);

        [Export("unregisterPageEventListener:")]
        void UnregisterPageEventListener(IPageEventListener listener);

        [Export("unregisterScrollViewEventListener:")]
        void UnregisterScrollViewEventListener(IScrollViewEventListener listener);

        [Export("unregisterLayoutChangedEventListener:")]
        void UnregisterLayoutChangedEventListener(ILayoutEventListener listener);

        [Export("setDoc:")]
        void SetDoc(FSPDFDoc doc);

        [Export("getDoc")]
        FSPDFDoc GetDoc();

        [Export("openDoc:password:completion:")]
        [Async]
        void OpenDoc(string filePath, [NullAllowed] string password, Action<FSErrorCode> completion);

        [Export("openDocFromMemory:password:completion:")]
        void OpenDocFromMemory(NSData buffer, [NullAllowed] string password, Action<FSErrorCode> completion);

        [Export("closeDoc:")]
        void CloseDoc([NullAllowed] Action cleanup);

        [Export("saveDoc:flag:")]
        bool SaveDoc(string filePath, int flag);

        [Export("getPageCount")]
        int GetPageCount();

        [Export("getCurrentPage")]
        int GetCurrentPage();

        [Export("getPageIndex:")]
        int GetPageIndex(CGPoint displayViewPt);

        [Export("getVisiblePages")]
        NSMutableArray GetVisiblePages();

        [Export("isPageVisible:")]
        bool IsPageVisible(int pageIndex);

        [Export("gotoPage:animated:")]
        bool GotoPage(int index, bool animated);

        [Export("gotoPage:withDocPoint:animated:")]
        bool GotoPage(int index, FSPointF point, bool animated);

        [Export("gotoFirstPage:")]
        bool GotoFirstPage(bool animated);

        [Export("gotoLastPage:")]
        bool GotoLastPage(bool animated);

        [Export("gotoNextPage:")]
        bool GotoNextPage(bool animated);

        [Export("gotoPrevPage:")]
        bool GotoPrevPage(bool animated);

        [Export("hasPrevView")]
        bool HasPrevView();

        [Export("hasNextView")]
        bool HasNextView();

        [Export("clearPrevNextStack")]
        void ClearPrevNextStack();

        [Export("gotoPrevView:")]
        void GotoPrevView(bool animated);

        [Export("gotoNextView:")]
        void GotoNextView(bool animated);

        [Export("getReflowMode")]
        FSReflowMode GetReflowMode();

        [Export("setReflowMode:")]
        void SetReflowMode(FSReflowMode reflowMode);

        [Export("getZoom")]
        float GetZoom();

        [Export("setZoom:")]
        void SetZoom(float zoom);

        [Export("setZoom:origin:")]
        void SetZoom(float zoom, CGPoint origin);

        [Export("setZoomMode:")]
        void SetZoomMode(FSDisplayZoomMode zoomMode);

        [Export("getPageLayoutMode")]
        FSLayoutMode GetPageLayoutMode();

        [Export("setPageLayoutMode:")]
        void SetPageLayoutMode(FSLayoutMode mode);

        [Export("setCropMode:")]
        bool SetCropMode(FSCropMode mode);

        [Export("setCropPageRect:pdfRect:")]
        bool SetCropPageRect(int pageIndex, FSRectF pdfRect);

        [Export("setBackgroundColor:")]
        void SetBackgroundColor([NullAllowed] UIColor color);

        [Export("getHScrollPos")]
        double GetHScrollPos();

        [Export("getVScrollPos")]
        double GetVScrollPos();

        [Export("setHScrollPos:animated:")]
        void SetHScrollPos(double pos, bool animated);

        [Export("setVScrollPos:animated:")]
        void SetVScrollPos(double pos, bool animated);

        [Export("getHScrollRange")]
        double GetHScrollRange();

        [Export("getVScrollRange")]
        double GetVScrollRange();

        [Export("getDisplayViewWidth")]
        float GetDisplayViewWidth();

        [Export("getDisplayViewHeight")]
        float GetDisplayViewHeight();

        [Export("getPageViewWidth:")]
        float GetPageViewWidth(int pageIndex);

        [Export("getPageViewHeight:")]
        float GetPageViewHeight(int pageIndex);

        [Export("getDisplayView")]
        UIView GetDisplayView();

        [Export("getPageView:")]
        UIView GetPageView(int pageIndex);

        [Export("getOverlayView:")]
        UIView GetOverlayView(int pageIndex);

        [Export("appendPageView:")]
        bool AppendPageView(UIView pageView);

        [Export("convertPageViewRectToDisplayViewRect:pageIndex:")]
        CGRect ConvertPageViewRectToDisplayViewRect(CGRect rect, int pageIndex);

        [Export("convertDisplayViewRectToPageViewRect:pageIndex:")]
        CGRect ConvertDisplayViewRectToPageViewRect(CGRect rect, int pageIndex);

        [Export("convertDisplayViewPtToPageViewPt:pageIndex:")]
        CGPoint ConvertDisplayViewPtToPageViewPt(CGPoint point, int pageIndex);

        [Export("convertPageViewPtToDisplayViewPt:pageIndex:")]
        CGPoint ConvertPageViewPtToDisplayViewPt(CGPoint point, int pageIndex);

        [Export("convertPdfPtToPageViewPt:pageIndex:")]
        CGPoint ConvertPdfPtToPageViewPt(FSPointF point, int pageIndex);

        [Export("convertPageViewPtToPdfPt:pageIndex:")]
        FSPointF ConvertPageViewPtToPdfPt(CGPoint point, int pageIndex);

        [Export("convertPdfRectToPageViewRect:pageIndex:")]
        CGRect ConvertPdfRectToPageViewRect(FSRectF rect, int pageIndex);

        [Export("convertPageViewRectToPdfRect:pageIndex:")]
        FSRectF ConvertPageViewRectToPdfRect(CGRect rect, int pageIndex);

        [Export("getDisplayMatrix:")]
        FSMatrix GetDisplayMatrix(int pageIndex);

        [Export("getDisplayMatrix:fromOrigin:")]
        FSMatrix GetDisplayMatrix(int pageIndex, CGPoint originPoint);

        [Export("refresh:pageIndex:")]
        void Refresh(CGRect rect, int pageIndex);

        [Export("refresh:pageIndex:needRender:")]
        void Refresh(CGRect rect, int pageIndex, bool needRender);

        [Export("refresh:")]
        void Refresh(int pageIndex);

        [Export("refresh:needRender:")]
        void Refresh(int pageIndex, bool needRender);

        [Export("refresh")]
        void Refresh();

        [Static]
        [Export("recoverForOOM")]
        void RecoverForOOM();
    }
}
