using System;
using CoreGraphics;
using Foundation;
using FoxitRDK;
using ObjCRuntime;
using UIKit;

namespace FoxitRDK
{
    // @interface SWIGTYPE_p_void : NSObject
    [BaseType (typeof(NSObject))]
    [DisableDefaultCtor]
    interface SWIGTYPE_p_void
    {
        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);
    }

    // @interface FSBasicArray : NSObject
    [BaseType (typeof(NSObject))]
    interface FSBasicArray
    {
        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSPoint : NSObject
    [BaseType (typeof(NSObject))]
    interface FSPoint
    {
        // @property (getter = getX, nonatomic) int x;
        [Export ("x")]
        int X { [Bind ("getX")] get; set; }

        // @property (getter = getY, nonatomic) int y;
        [Export ("y")]
        int Y { [Bind ("getY")] get; set; }

        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(id)initWithOther:(FSPoint *)other;
        [Export ("initWithOther:")]
        IntPtr Constructor (FSPoint other);

        // -(void)set:(int)x y:(int)y;
        [Export ("set:y:")]
        void Set (int x, int y);

        // -(void)add:(int)x y:(int)y;
        [Export ("add:y:")]
        void Add (int x, int y);

        // -(void)subtract:(int)x y:(int)y;
        [Export ("subtract:y:")]
        void Subtract (int x, int y);

        // -(void)reset;
        [Export ("reset")]
        void Reset ();

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSPointF : NSObject
    [BaseType (typeof(NSObject))]
    interface FSPointF
    {
        // @property (getter = getX, nonatomic) float x;
        [Export ("x")]
        float X { [Bind ("getX")] get; set; }

        // @property (getter = getY, nonatomic) float y;
        [Export ("y")]
        float Y { [Bind ("getY")] get; set; }

        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(id)initWithOther:(FSPointF *)other;
        [Export ("initWithOther:")]
        IntPtr Constructor (FSPointF other);

        // -(void)set:(float)x y:(float)y;
        [Export ("set:y:")]
        void Set (float x, float y);

        // -(void)add:(float)x y:(float)y;
        [Export ("add:y:")]
        void Add (float x, float y);

        // -(void)subtract:(float)x y:(float)y;
        [Export ("subtract:y:")]
        void Subtract (float x, float y);

        // -(void)reset;
        [Export ("reset")]
        void Reset ();

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSRectFArray : FSBasicArray
    [BaseType (typeof(FSBasicArray))]
    interface FSRectFArray
    {
        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(id)initWithOther:(FSRectFArray *)other;
        [Export ("initWithOther:")]
        IntPtr Constructor (FSRectFArray other);

        // -(int)getSize;
        [Export ("getSize")]
        //[Verify (MethodToProperty)]
        int Size { get; }

        // -(int)getUpperBound;
        [Export ("getUpperBound")]
        //[Verify (MethodToProperty)]
        int UpperBound { get; }

        // -(int)setSize:(int)nNewSize nGrowBy:(int)nGrowBy;
        [Export ("setSize:nGrowBy:")]
        int SetSize (int nNewSize, int nGrowBy);

        // -(void)removeAll;
        [Export ("removeAll")]
        void RemoveAll ();

        // -(FSRectF *)getAt:(int)nIndex;
        [Export ("getAt:")]
        FSRectF GetAt (int nIndex);

        // -(int)setAt:(int)nIndex newElement:(FSRectF *)newElement;
        [Export ("setAt:newElement:")]
        int SetAt (int nIndex, FSRectF newElement);

        // -(int)setAtGrow:(int)nIndex newElement:(FSRectF *)newElement;
        [Export ("setAtGrow:newElement:")]
        int SetAtGrow (int nIndex, FSRectF newElement);

        // -(int)add:(FSRectF *)newElement;
        [Export ("add:")]
        int Add (FSRectF newElement);

        // -(int)insertAt:(int)nIndex newElement:(FSRectF *)newElement nCount:(int)nCount;
        [Export ("insertAt:newElement:nCount:")]
        int InsertAt (int nIndex, FSRectF newElement, int nCount);

        // -(int)removeAt:(int)nIndex nCount:(int)nCount;
        [Export ("removeAt:nCount:")]
        int RemoveAt (int nIndex, int nCount);

        // -(int)find:(FSRectF *)data iStart:(int)iStart;
        [Export ("find:iStart:")]
        int Find (FSRectF data, int iStart);

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSPointFArray : FSBasicArray
    [BaseType (typeof(FSBasicArray))]
    interface FSPointFArray
    {
        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(id)initWithOther:(FSPointFArray *)other;
        [Export ("initWithOther:")]
        IntPtr Constructor (FSPointFArray other);

        // -(int)getSize;
        [Export ("getSize")]
        //[Verify (MethodToProperty)]
        int Size { get; }

        // -(int)getUpperBound;
        [Export ("getUpperBound")]
        //[Verify (MethodToProperty)]
        int UpperBound { get; }

        // -(int)setSize:(int)nNewSize nGrowBy:(int)nGrowBy;
        [Export ("setSize:nGrowBy:")]
        int SetSize (int nNewSize, int nGrowBy);

        // -(void)removeAll;
        [Export ("removeAll")]
        void RemoveAll ();

        // -(FSPointF *)getAt:(int)nIndex;
        [Export ("getAt:")]
        FSPointF GetAt (int nIndex);

        // -(int)setAt:(int)nIndex newElement:(FSPointF *)newElement;
        [Export ("setAt:newElement:")]
        int SetAt (int nIndex, FSPointF newElement);

        // -(int)setAtGrow:(int)nIndex newElement:(FSPointF *)newElement;
        [Export ("setAtGrow:newElement:")]
        int SetAtGrow (int nIndex, FSPointF newElement);

        // -(int)add:(FSPointF *)newElement;
        [Export ("add:")]
        int Add (FSPointF newElement);

        // -(int)insertAt:(int)nIndex newElement:(FSPointF *)newElement nCount:(int)nCount;
        [Export ("insertAt:newElement:nCount:")]
        int InsertAt (int nIndex, FSPointF newElement, int nCount);

        // -(int)removeAt:(int)nIndex nCount:(int)nCount;
        [Export ("removeAt:nCount:")]
        int RemoveAt (int nIndex, int nCount);

        // -(int)find:(FSPointF *)data iStart:(int)iStart;
        [Export ("find:iStart:")]
        int Find (FSPointF data, int iStart);

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSFloatArray : FSBasicArray
    [BaseType (typeof(FSBasicArray))]
    interface FSFloatArray
    {
        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(id)initWithOther:(FSFloatArray *)other;
        [Export ("initWithOther:")]
        IntPtr Constructor (FSFloatArray other);

        // -(int)getSize;
        [Export ("getSize")]
        //[Verify (MethodToProperty)]
        int Size { get; }

        // -(int)getUpperBound;
        [Export ("getUpperBound")]
        //[Verify (MethodToProperty)]
        int UpperBound { get; }

        // -(int)setSize:(int)nNewSize nGrowBy:(int)nGrowBy;
        [Export ("setSize:nGrowBy:")]
        int SetSize (int nNewSize, int nGrowBy);

        // -(void)removeAll;
        [Export ("removeAll")]
        void RemoveAll ();

        // -(float)getAt:(int)nIndex;
        [Export ("getAt:")]
        float GetAt (int nIndex);

        // -(int)setAt:(int)nIndex newElement:(float)newElement;
        [Export ("setAt:newElement:")]
        int SetAt (int nIndex, float newElement);

        // -(int)setAtGrow:(int)nIndex newElement:(float)newElement;
        [Export ("setAtGrow:newElement:")]
        int SetAtGrow (int nIndex, float newElement);

        // -(int)add:(float)newElement;
        [Export ("add:")]
        int Add (float newElement);

        // -(int)insertAt:(int)nIndex newElement:(float)newElement nCount:(int)nCount;
        [Export ("insertAt:newElement:nCount:")]
        int InsertAt (int nIndex, float newElement, int nCount);

        // -(int)removeAt:(int)nIndex nCount:(int)nCount;
        [Export ("removeAt:nCount:")]
        int RemoveAt (int nIndex, int nCount);

        // -(int)find:(float)data iStart:(int)iStart;
        [Export ("find:iStart:")]
        int Find (float data, int iStart);

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSInt32Array : FSBasicArray
    [BaseType (typeof(FSBasicArray))]
    interface FSInt32Array
    {
        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(id)initWithOther:(FSInt32Array *)other;
        [Export ("initWithOther:")]
        IntPtr Constructor (FSInt32Array other);

        // -(int)getSize;
        [Export ("getSize")]
        //[Verify (MethodToProperty)]
        int Size { get; }

        // -(int)getUpperBound;
        [Export ("getUpperBound")]
        //[Verify (MethodToProperty)]
        int UpperBound { get; }

        // -(int)setSize:(int)nNewSize nGrowBy:(int)nGrowBy;
        [Export ("setSize:nGrowBy:")]
        int SetSize (int nNewSize, int nGrowBy);

        // -(void)removeAll;
        [Export ("removeAll")]
        void RemoveAll ();

        // -(int)getAt:(int)nIndex;
        [Export ("getAt:")]
        int GetAt (int nIndex);

        // -(int)setAt:(int)nIndex newElement:(int)newElement;
        [Export ("setAt:newElement:")]
        int SetAt (int nIndex, int newElement);

        // -(int)setAtGrow:(int)nIndex newElement:(int)newElement;
        [Export ("setAtGrow:newElement:")]
        int SetAtGrow (int nIndex, int newElement);

        // -(int)add:(int)newElement;
        [Export ("add:")]
        int Add (int newElement);

        // -(int)insertAt:(int)nIndex newElement:(int)newElement nCount:(int)nCount;
        [Export ("insertAt:newElement:nCount:")]
        int InsertAt (int nIndex, int newElement, int nCount);

        // -(int)removeAt:(int)nIndex nCount:(int)nCount;
        [Export ("removeAt:nCount:")]
        int RemoveAt (int nIndex, int nCount);

        // -(int)find:(int)data iStart:(int)iStart;
        [Export ("find:iStart:")]
        int Find (int data, int iStart);

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSRectI : NSObject
    [BaseType (typeof(NSObject))]
    interface FSRectI
    {
        // @property (getter = getLeft, nonatomic) int left;
        [Export ("left")]
        int Left { [Bind ("getLeft")] get; set; }

        // @property (getter = getTop, nonatomic) int top;
        [Export ("top")]
        int Top { [Bind ("getTop")] get; set; }

        // @property (getter = getRight, nonatomic) int right;
        [Export ("right")]
        int Right { [Bind ("getRight")] get; set; }

        // @property (getter = getBottom, nonatomic) int bottom;
        [Export ("bottom")]
        int Bottom { [Bind ("getBottom")] get; set; }

        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(id)initWithLeft1:(int)left1 top1:(int)top1 right1:(int)right1 bottom1:(int)bottom1;
        [Export ("initWithLeft1:top1:right1:bottom1:")]
        IntPtr Constructor (int left1, int top1, int right1, int bottom1);

        // -(int)width;
        [Export ("width")]
        //[Verify (MethodToProperty)]
        int Width { get; }

        // -(int)height;
        [Export ("height")]
        //[Verify (MethodToProperty)]
        int Height { get; }

        // -(int)isEmpty;
        [Export ("isEmpty")]
        //[Verify (MethodToProperty)]
        int IsEmpty { get; }

        // -(void)normalize;
        [Export ("normalize")]
        void Normalize ();

        // -(void)intersect:(FSRectI *)src;
        [Export ("intersect:")]
        void Intersect (FSRectI src);

        // -(void)union:(FSRectI *)other_rect;
        [Export ("union:")]
        void Union (FSRectI other_rect);

        // -(void)offset:(int)dx dy:(int)dy;
        [Export ("offset:dy:")]
        void Offset (int dx, int dy);

        // -(int)contains:(FSRectI *)other_rect;
        [Export ("contains:")]
        int Contains (FSRectI other_rect);

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSRectF : NSObject
    [BaseType (typeof(NSObject))]
    interface FSRectF
    {
        // @property (getter = getLeft, nonatomic) float left;
        [Export ("left")]
        float Left { [Bind ("getLeft")] get; set; }

        // @property (getter = getRight, nonatomic) float right;
        [Export ("right")]
        float Right { [Bind ("getRight")] get; set; }

        // @property (getter = getBottom, nonatomic) float bottom;
        [Export ("bottom")]
        float Bottom { [Bind ("getBottom")] get; set; }

        // @property (getter = getTop, nonatomic) float top;
        [Export ("top")]
        float Top { [Bind ("getTop")] get; set; }

        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(id)initWithLeft1:(float)left1 bottom1:(float)bottom1 right1:(float)right1 top1:(float)top1;
        [Export ("initWithLeft1:bottom1:right1:top1:")]
        IntPtr Constructor (float left1, float bottom1, float right1, float top1);

        // -(int)isEmpty;
        [Export ("isEmpty")]
        //[Verify (MethodToProperty)]
        int IsEmpty { get; }

        // -(void)normalize;
        [Export ("normalize")]
        void Normalize ();

        // -(void)reset;
        [Export ("reset")]
        void Reset ();

        // -(int)contains:(FSRectF *)other_rect;
        [Export ("contains:")]
        int Contains (FSRectF other_rect);

        // -(void)transform:(FSMatrix2D *)pMatrix;
        [Export ("transform:")]
        void Transform (FSMatrix2D pMatrix);

        // -(void)intersect:(FSRectF *)other_rect;
        [Export ("intersect:")]
        void Intersect (FSRectF other_rect);

        // -(void)union:(FSRectF *)other_rect;
        [Export ("union:")]
        void Union (FSRectF other_rect);

        // -(FSRectI *)getInnerRect;
        [Export ("getInnerRect")]
        //[Verify (MethodToProperty)]
        FSRectI InnerRect { get; }

        // -(FSRectI *)getOuterRect;
        [Export ("getOuterRect")]
        //[Verify (MethodToProperty)]
        FSRectI OuterRect { get; }

        // -(FSRectI *)getClosestRect;
        [Export ("getClosestRect")]
        //[Verify (MethodToProperty)]
        FSRectI ClosestRect { get; }

        // -(void)initRect:(float)x y:(float)y;
        [Export ("initRect:y:")]
        void InitRect (float x, float y);

        // -(void)updateRect:(float)x y:(float)y;
        [Export ("updateRect:y:")]
        void UpdateRect (float x, float y);

        // -(float)width;
        [Export ("width")]
        //[Verify (MethodToProperty)]
        float Width { get; }

        // -(float)height;
        [Export ("height")]
        //[Verify (MethodToProperty)]
        float Height { get; }

        // -(void)inflate:(float)x y:(float)y;
        [Export ("inflate:y:")]
        void Inflate (float x, float y);

        // -(void)deflate:(float)x y:(float)y;
        [Export ("deflate:y:")]
        void Deflate (float x, float y);

        // -(void)translate:(float)e f:(float)f;
        [Export ("translate:f:")]
        void Translate (float e, float f);

        // +(FSRectF *)getBBox:(FSPointF *)pPoints nPoints:(int)nPoints;
        [Static]
        [Export ("getBBox:nPoints:")]
        FSRectF GetBBox (FSPointF pPoints, int nPoints);

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSMatrix2D : NSObject
    [BaseType (typeof(NSObject))]
    interface FSMatrix2D
    {
        // @property (getter = getA, nonatomic) float a;
        [Export ("a")]
        float A { [Bind ("getA")] get; set; }

        // @property (getter = getB, nonatomic) float b;
        [Export ("b")]
        float B { [Bind ("getB")] get; set; }

        // @property (getter = getC, nonatomic) float c;
        [Export ("c")]
        float C { [Bind ("getC")] get; set; }

        // @property (getter = getD, nonatomic) float d;
        [Export ("d")]
        float D { [Bind ("getD")] get; set; }

        // @property (getter = getE, nonatomic) float e;
        [Export ("e")]
        float E { [Bind ("getE")] get; set; }

        // @property (getter = getF, nonatomic) float f;
        [Export ("f")]
        float F { [Bind ("getF")] get; set; }

        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(id)initWithA1:(float)a1 b1:(float)b1 c1:(float)c1 d1:(float)d1 e1:(float)e1 f1:(float)f1;
        [Export ("initWithA1:b1:c1:d1:e1:f1:")]
        IntPtr Constructor (float a1, float b1, float c1, float d1, float e1, float f1);

        // -(void)set:(float)a b:(float)b c:(float)c d:(float)d e:(float)e f:(float)f;
        [Export ("set:b:c:d:e:f:")]
        void Set (float a, float b, float c, float d, float e, float f);

        // -(void)setIdentity;
        [Export ("setIdentity")]
        void SetIdentity ();

        // -(void)setReverse:(FSMatrix2D *)m;
        [Export ("setReverse:")]
        void SetReverse (FSMatrix2D m);

        // -(void)concat:(float)a b:(float)b c:(float)c d:(float)d e:(float)e f:(float)f bPrepended:(int)bPrepended;
        [Export ("concat:b:c:d:e:f:bPrepended:")]
        void Concat (float a, float b, float c, float d, float e, float f, int bPrepended);

        // -(void)concatInverse:(FSMatrix2D *)m bPrepended:(int)bPrepended;
        [Export ("concatInverse:bPrepended:")]
        void ConcatInverse (FSMatrix2D m, int bPrepended);

        // -(void)reset;
        [Export ("reset")]
        void Reset ();

        // -(void)copy:(FSMatrix2D *)m;
        [Export ("copy:")]
        void Copy (FSMatrix2D m);

        // -(int)isIdentity;
        [Export ("isIdentity")]
        //[Verify (MethodToProperty)]
        int IsIdentity { get; }

        // -(int)isInvertible;
        [Export ("isInvertible")]
        //[Verify (MethodToProperty)]
        int IsInvertible { get; }

        // -(int)is90Rotated;
        [Export ("is90Rotated")]
        //[Verify (MethodToProperty)]
        int Is90Rotated { get; }

        // -(int)isScaled;
        [Export ("isScaled")]
        //[Verify (MethodToProperty)]
        int IsScaled { get; }

        // -(void)translate:(float)x y:(float)y bPrepended:(int)bPrepended;
        [Export ("translate:y:bPrepended:")]
        void Translate (float x, float y, int bPrepended);

        // -(void)translateI:(int)x y:(int)y bPrepended:(int)bPrepended;
        [Export ("translateI:y:bPrepended:")]
        void TranslateI (int x, int y, int bPrepended);

        // -(void)scale:(float)sx sy:(float)sy bPrepended:(int)bPrepended;
        [Export ("scale:sy:bPrepended:")]
        void Scale (float sx, float sy, int bPrepended);

        // -(void)rotate:(float)fRadian bPrepended:(int)bPrepended;
        [Export ("rotate:bPrepended:")]
        void Rotate (float fRadian, int bPrepended);

        // -(void)rotateAt:(float)fRadian x:(float)x y:(float)y bPrepended:(int)bPrepended;
        [Export ("rotateAt:x:y:bPrepended:")]
        void RotateAt (float fRadian, float x, float y, int bPrepended);

        // -(void)shear:(float)fAlphaRadian fBetaRadian:(float)fBetaRadian bPrepended:(int)bPrepended;
        [Export ("shear:fBetaRadian:bPrepended:")]
        void Shear (float fAlphaRadian, float fBetaRadian, int bPrepended);

        // -(void)matchRect:(FSRectF *)dest src:(FSRectF *)src;
        [Export ("matchRect:src:")]
        void MatchRect (FSRectF dest, FSRectF src);

        // -(float)getXUnit;
        [Export ("getXUnit")]
        //[Verify (MethodToProperty)]
        float XUnit { get; }

        // -(float)getYUnit;
        [Export ("getYUnit")]
        //[Verify (MethodToProperty)]
        float YUnit { get; }

        // -(FSRectF *)getUnitRect;
        [Export ("getUnitRect")]
        //[Verify (MethodToProperty)]
        FSRectF UnitRect { get; }

        // -(float)getUnitArea;
        [Export ("getUnitArea")]
        //[Verify (MethodToProperty)]
        float UnitArea { get; }

        // -(float)transformXDistance:(float)dx;
        [Export ("transformXDistance:")]
        float TransformXDistance (float dx);

        // -(float)transformYDistance:(float)dy;
        [Export ("transformYDistance:")]
        float TransformYDistance (float dy);

        // -(float)transformDistance:(float)dx dy:(float)dy;
        [Export ("transformDistance:dy:")]
        float TransformDistance (float dx, float dy);

        // -(void)transformPoint:(float *)x y:(float *)y;
        [Export ("transformPoint:y:")]
        unsafe void TransformPoint (float x, float y);

        // -(void)transformRect:(FSRectF *)rect;
        [Export ("transformRect:")]
        void TransformRect (FSRectF rect);

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSBase : NSObject
    [BaseType (typeof(NSObject))]
    interface FSBase
    {
        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSDateTime : NSObject
    [BaseType (typeof(NSObject))]
    interface FSDateTime
    {
        // @property (getter = getYear, nonatomic) unsigned short year;
        [Export ("year")]
        ushort Year { [Bind ("getYear")] get; set; }

        // @property (getter = getMonth, nonatomic) unsigned short month;
        [Export ("month")]
        ushort Month { [Bind ("getMonth")] get; set; }

        // @property (getter = getDay, nonatomic) unsigned short day;
        [Export ("day")]
        ushort Day { [Bind ("getDay")] get; set; }

        // @property (getter = getHour, nonatomic) unsigned short hour;
        [Export ("hour")]
        ushort Hour { [Bind ("getHour")] get; set; }

        // @property (getter = getMinute, nonatomic) unsigned short minute;
        [Export ("minute")]
        ushort Minute { [Bind ("getMinute")] get; set; }

        // @property (getter = getSecond, nonatomic) unsigned short second;
        [Export ("second")]
        ushort Second { [Bind ("getSecond")] get; set; }

        // @property (getter = getMilliseconds, nonatomic) unsigned short milliseconds;
        [Export ("milliseconds")]
        ushort Milliseconds { [Bind ("getMilliseconds")] get; set; }

        // @property (getter = getUtc_hour_offset, nonatomic) short utc_hour_offset;
        [Export ("utc_hour_offset")]
        short Utc_hour_offset { [Bind ("getUtc_hour_offset")] get; set; }

        // @property (getter = getUtc_minute_offset, nonatomic) unsigned short utc_minute_offset;
        [Export ("utc_minute_offset")]
        ushort Utc_minute_offset { [Bind ("getUtc_minute_offset")] get; set; }

        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // +(FSDateTime *)getUTCTime;
        [Static]
        [Export ("getUTCTime")]
        //[Verify (MethodToProperty)]
        FSDateTime UTCTime { get; }

        // +(FSDateTime *)getLocalTime;
        [Static]
        [Export ("getLocalTime")]
        //[Verify (MethodToProperty)]
        FSDateTime LocalTime { get; }

        // -(id)initWithYear:(unsigned short)year month:(unsigned short)month day:(unsigned short)day hour:(unsigned short)hour minute:(unsigned short)minute second:(unsigned short)second milliseconds:(unsigned short)milliseconds utc_hour_offset:(short)utc_hour_offset utc_minute_offset:(unsigned short)utc_minute_offset;
        [Export ("initWithYear:month:day:hour:minute:second:milliseconds:utc_hour_offset:utc_minute_offset:")]
        IntPtr Constructor (ushort year, ushort month, ushort day, ushort hour, ushort minute, ushort second, ushort milliseconds, short utc_hour_offset, ushort utc_minute_offset);

        // -(id)initWithDt:(FSDateTime *)dt;
        [Export ("initWithDt:")]
        IntPtr Constructor (FSDateTime dt);

        // -(void)set:(unsigned short)year month:(unsigned short)month day:(unsigned short)day hour:(unsigned short)hour minute:(unsigned short)minute second:(unsigned short)second milliseconds:(unsigned short)milliseconds utc_hour_offset:(short)utc_hour_offset utc_minute_offset:(unsigned short)utc_minute_offset;
        [Export ("set:month:day:hour:minute:second:milliseconds:utc_hour_offset:utc_minute_offset:")]
        void Set (ushort year, ushort month, ushort day, ushort hour, ushort minute, ushort second, ushort milliseconds, short utc_hour_offset, ushort utc_minute_offset);

        // -(BOOL)isValid;
        [Export ("isValid")]
        //[Verify (MethodToProperty)]
        bool IsValid { get; }

        // -(FSDateTime *)toLocalTime;
        [Export ("toLocalTime")]
        //[Verify (MethodToProperty)]
        FSDateTime ToLocalTime { get; }

        // -(FSDateTime *)toUTCTime;
        [Export ("toUTCTime")]
        //[Verify (MethodToProperty)]
        FSDateTime ToUTCTime { get; }

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSCodec : FSBase
    [BaseType (typeof(FSBase))]
    interface FSCodec
    {
        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // +(NSData *)base64Encode:(NSData *)buffer;
        [Static]
        [Export ("base64Encode:")]
        NSData Base64Encode (NSData buffer);

        // +(NSData *)base64Decode:(NSData *)buffer;
        [Static]
        [Export ("base64Decode:")]
        NSData Base64Decode (NSData buffer);

        // +(NSData *)flateCompress:(NSData *)buffer;
        [Static]
        [Export ("flateCompress:")]
        NSData FlateCompress (NSData buffer);

        // +(NSData *)flateDecompress:(NSData *)buffer;
        [Static]
        [Export ("flateDecompress:")]
        NSData FlateDecompress (NSData buffer);

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSProgressive : FSBase
    [BaseType (typeof(FSBase))]
    [DisableDefaultCtor]
    interface FSProgressive
    {
        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(id)initWithArg0:(FSProgressive *)arg0;
        [Export ("initWithArg0:")]
        IntPtr Constructor (FSProgressive arg0);

        // -(FSProgressiveState)resume;
        [Export ("resume")]
        //[Verify (MethodToProperty)]
        FSProgressiveState Resume { get; }

        // -(int)getRateOfProgress;
        [Export ("getRateOfProgress")]
        //[Verify (MethodToProperty)]
        int RateOfProgress { get; }

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSLibrary : NSObject
    [BaseType (typeof(NSObject))]
    [DisableDefaultCtor]
    interface FSLibrary
    {
        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // +(FSErrorCode)initialize:(NSString *)sn key:(NSString *)key;
        [Static]
        [Export ("initialize:key:")]
        FSErrorCode Initialize (string sn, string key);

        // +(FSErrorCode)reinitialize;
        [Static]
        [Export ("reinitialize")]
        //[Verify (MethodToProperty)]
        FSErrorCode Reinitialize { get; }

        // +(void)destroy;
        [Static]
        [Export ("destroy")]
        void Destroy ();

        // +(NSString *)getVersion;
        [Static]
        [Export ("getVersion")]
        //[Verify (MethodToProperty)]
        string Version { get; }

        // +(BOOL)setCacheSize:(unsigned int)size;
        [Static]
        [Export ("setCacheSize:")]
        bool SetCacheSize (uint size);

        // +(BOOL)enableJavaScript:(BOOL)enable_javascript;
        [Static]
        [Export ("enableJavaScript:")]
        bool EnableJavaScript (bool enable_javascript);

        // +(BOOL)setAnnotIconProviderCallback:(id<FSIconProviderCallback>)annot_icon_provider;
        [Static]
        [Export ("setAnnotIconProviderCallback:")]
        bool SetAnnotIconProviderCallback (FSIconProviderCallback annot_icon_provider);

        // +(BOOL)setNotifierCallback:(id<FSNotifierCallback>)notifier;
        [Static]
        [Export ("setNotifierCallback:")]
        bool SetNotifierCallback (FSNotifierCallback notifier);

        // +(BOOL)setActionCallback:(id<FSActionCallback>)action_callback;
        [Static]
        [Export ("setActionCallback:")]
        bool SetActionCallback (FSActionCallback action_callback);

        // +(BOOL)setDocEventCallback:(id<FSDocEventCallback>)callback;
        [Static]
        [Export ("setDocEventCallback:")]
        bool SetDocEventCallback (FSDocEventCallback callback);

        // +(BOOL)registerSignatureCallback:(NSString *)filter sub_filter:(NSString *)sub_filter signature_callback:(id<FSSignatureCallback>)signature_callback;
        [Static]
        [Export ("registerSignatureCallback:sub_filter:signature_callback:")]
        bool RegisterSignatureCallback (string filter, string sub_filter, FSSignatureCallback signature_callback);

        // +(BOOL)registerSecurityCallback:(NSString *)filter callback:(id<FSSecurityCallback>)callback;
        [Static]
        [Export ("registerSecurityCallback:callback:")]
        bool RegisterSecurityCallback (string filter, FSSecurityCallback callback);

        // +(BOOL)unregisterSecurityCallback:(NSString *)filter;
        [Static]
        [Export ("unregisterSecurityCallback:")]
        bool UnregisterSecurityCallback (string filter);

        // +(void)registerXFAAppProviderCallback:(id<FSAppProviderCallback>)callback;
        [Static]
        [Export ("registerXFAAppProviderCallback:")]
        void RegisterXFAAppProviderCallback (FSAppProviderCallback callback);

        // +(void)setRenderTextGamma:(float)gamma;
        [Static]
        [Export ("setRenderTextGamma:")]
        void SetRenderTextGamma (float gamma);

        // +(void)setLogFile:(NSString *)log_file_path;
        [Static]
        [Export ("setLogFile:")]
        void SetLogFile (string log_file_path);

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSGraphState : NSObject
    [BaseType (typeof(NSObject))]
    interface FSGraphState
    {
        // @property (getter = getLine_width, nonatomic) float line_width;
        [Export ("line_width")]
        float Line_width { [Bind ("getLine_width")] get; set; }

        // @property (getter = getLine_join, nonatomic) FSGraphStateLineJoinStyle line_join;
        [Export ("line_join", ArgumentSemantic.Assign)]
        FSGraphStateLineJoinStyle Line_join { [Bind ("getLine_join")] get; set; }

        // @property (getter = getMiter_limit, nonatomic) float miter_limit;
        [Export ("miter_limit")]
        float Miter_limit { [Bind ("getMiter_limit")] get; set; }

        // @property (getter = getLine_cap, nonatomic) FSGraphStateLineCapStyle line_cap;
        [Export ("line_cap", ArgumentSemantic.Assign)]
        FSGraphStateLineCapStyle Line_cap { [Bind ("getLine_cap")] get; set; }

        // @property (getter = getDash_phase, nonatomic) float dash_phase;
        [Export ("dash_phase")]
        float Dash_phase { [Bind ("getDash_phase")] get; set; }

        // @property (getter = getDashes, nonatomic, weak) FSFloatArray * dashes;
        [Export ("dashes", ArgumentSemantic.Weak)]
        FSFloatArray Dashes { [Bind ("getDashes")] get; set; }

        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(id)initWithLine_width:(float)line_width line_join:(FSGraphStateLineJoinStyle)line_join miter_limit:(float)miter_limit line_cap:(FSGraphStateLineCapStyle)line_cap dash_phase:(float)dash_phase dashes:(FSFloatArray *)dashes;
        [Export ("initWithLine_width:line_join:miter_limit:line_cap:dash_phase:dashes:")]
        IntPtr Constructor (float line_width, FSGraphStateLineJoinStyle line_join, float miter_limit, FSGraphStateLineCapStyle line_cap, float dash_phase, FSFloatArray dashes);

        // -(id)initWithState:(FSGraphState *)state;
        [Export ("initWithState:")]
        IntPtr Constructor (FSGraphState state);

        // -(void)set:(float)line_width line_join:(FSGraphStateLineJoinStyle)line_join miter_limit:(float)miter_limit line_cap:(FSGraphStateLineCapStyle)line_cap dash_phase:(float)dash_phase dashes:(FSFloatArray *)dashes;
        [Export ("set:line_join:miter_limit:line_cap:dash_phase:dashes:")]
        void Set (float line_width, FSGraphStateLineJoinStyle line_join, float miter_limit, FSGraphStateLineCapStyle line_cap, float dash_phase, FSFloatArray dashes);

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSRange : FSBase
    [BaseType (typeof(FSBase))]
    interface FSRange
    {
        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(id)initWithIndex:(int)index;
        [Export ("initWithIndex:")]
        IntPtr Constructor (int index);

        // -(id)initWithStart_index:(int)start_index end_index:(int)end_index filter:(FSRangeFilter)filter;
        [Export ("initWithStart_index:end_index:filter:")]
        IntPtr Constructor (int start_index, int end_index, FSRangeFilter filter);

        // -(id)initWithStart_index:(int)start_index end_index:(int)end_index;
        [Export ("initWithStart_index:end_index:")]
        IntPtr Constructor (int start_index, int end_index);

        // -(id)initWithArg0:(FSRange *)arg0;
        [Export ("initWithArg0:")]
        IntPtr Constructor (FSRange arg0);

        // -(BOOL)isEmpty;
        [Export ("isEmpty")]
        //[Verify (MethodToProperty)]
        bool IsEmpty { get; }

        // -(void)addSingle:(int)index;
        [Export ("addSingle:")]
        void AddSingle (int index);

        // -(void)addSegment:(int)start_index end_index:(int)end_index filter:(FSRangeFilter)filter;
        [Export ("addSegment:end_index:filter:")]
        void AddSegment (int start_index, int end_index, FSRangeFilter filter);

        // -(int)getSegmentCount;
        [Export ("getSegmentCount")]
        //[Verify (MethodToProperty)]
        int SegmentCount { get; }

        // -(int)getSegmentStart:(int)segment_index;
        [Export ("getSegmentStart:")]
        int GetSegmentStart (int segment_index);

        // -(int)getSegmentEnd:(int)segment_index;
        [Export ("getSegmentEnd:")]
        int GetSegmentEnd (int segment_index);

        // -(void)removeAll;
        [Export ("removeAll")]
        void RemoveAll ();

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSFont : FSBase
    [BaseType (typeof(FSBase))]
    [DisableDefaultCtor]
    interface FSFont
    {
        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(id)initWithName:(NSString *)name styles:(unsigned int)styles charset:(FSFontCharset)charset weight:(int)weight;
        [Export ("initWithName:styles:charset:weight:")]
        IntPtr Constructor (string name, uint styles, FSFontCharset charset, int weight);

        // -(id)initWithFont_id:(FSFontStandardID)font_id;
        [Export ("initWithFont_id:")]
        IntPtr Constructor (FSFontStandardID font_id);

        // -(id)initWithFont_file_path:(NSString *)font_file_path face_index:(int)face_index charset:(FSFontCharset)charset;
        [Export ("initWithFont_file_path:face_index:charset:")]
        IntPtr Constructor (string font_file_path, int face_index, FSFontCharset charset);

        // -(id)initWithArg0:(FSFont *)arg0;
        [Export ("initWithArg0:")]
        IntPtr Constructor (FSFont arg0);

        // -(BOOL)isEmpty;
        [Export ("isEmpty")]
        //[Verify (MethodToProperty)]
        bool IsEmpty { get; }

        // -(NSString *)getName;
        [Export ("getName")]
        //[Verify (MethodToProperty)]
        string Name { get; }

        // -(BOOL)isBold;
        [Export ("isBold")]
        //[Verify (MethodToProperty)]
        bool IsBold { get; }

        // -(BOOL)isItalic;
        [Export ("isItalic")]
        //[Verify (MethodToProperty)]
        bool IsItalic { get; }

        // -(BOOL)isEmbedded:(FSPDFDoc *)document;
        [Export ("isEmbedded:")]
        bool IsEmbedded (FSPDFDoc document);

        // -(BOOL)isSupportEmbedded:(FSPDFDoc *)document;
        [Export ("isSupportEmbedded:")]
        bool IsSupportEmbedded (FSPDFDoc document);

        // -(FSFont *)embed:(FSPDFDoc *)document;
        [Export ("embed:")]
        FSFont Embed (FSPDFDoc document);

        // -(int)getAscent;
        [Export ("getAscent")]
        //[Verify (MethodToProperty)]
        int Ascent { get; }

        // -(int)getDescent;
        [Export ("getDescent")]
        //[Verify (MethodToProperty)]
        int Descent { get; }

        // -(FSRectI *)getCharBBox:(unsigned int)unicode;
        [Export ("getCharBBox:")]
        FSRectI GetCharBBox (uint unicode);

        // -(float)getCharWidth:(unsigned int)unicode;
        [Export ("getCharWidth:")]
        float GetCharWidth (uint unicode);

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSPath : FSBase
    [BaseType (typeof(FSBase))]
    interface FSPath
    {
        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(id)initWithOther:(FSPath *)other;
        [Export ("initWithOther:")]
        IntPtr Constructor (FSPath other);

        // -(BOOL)isEmpty;
        [Export ("isEmpty")]
        //[Verify (MethodToProperty)]
        bool IsEmpty { get; }

        // -(int)getPointCount;
        [Export ("getPointCount")]
        //[Verify (MethodToProperty)]
        int PointCount { get; }

        // -(FSPointF *)getPoint:(int)index;
        [Export ("getPoint:")]
        FSPointF GetPoint (int index);

        // -(FSPathPointType)getPointType:(int)index;
        [Export ("getPointType:")]
        FSPathPointType GetPointType (int index);

        // -(BOOL)setPoint:(int)index point:(FSPointF *)point type:(FSPathPointType)type;
        [Export ("setPoint:point:type:")]
        bool SetPoint (int index, FSPointF point, FSPathPointType type);

        // -(BOOL)moveTo:(FSPointF *)point;
        [Export ("moveTo:")]
        bool MoveTo (FSPointF point);

        // -(BOOL)lineTo:(FSPointF *)point;
        [Export ("lineTo:")]
        bool LineTo (FSPointF point);

        // -(BOOL)cubicBezierTo:(FSPointF *)point1 point2:(FSPointF *)point2 point3:(FSPointF *)point3;
        [Export ("cubicBezierTo:point2:point3:")]
        bool CubicBezierTo (FSPointF point1, FSPointF point2, FSPointF point3);

        // -(BOOL)closeFigure;
        [Export ("closeFigure")]
        //[Verify (MethodToProperty)]
        bool CloseFigure { get; }

        // -(BOOL)removePoint:(int)index;
        [Export ("removePoint:")]
        bool RemovePoint (int index);

        // -(BOOL)appendRect:(FSRectF *)rect;
        [Export ("appendRect:")]
        bool AppendRect (FSRectF rect);

        // -(BOOL)appendEllipse:(FSRectF *)rect;
        [Export ("appendEllipse:")]
        bool AppendEllipse (FSRectF rect);

        // -(void)transform:(FSMatrix2D *)matrix;
        [Export ("transform:")]
        void Transform (FSMatrix2D matrix);

        // -(void)clear;
        [Export ("clear")]
        void Clear ();

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSBitmap : FSBase
    [BaseType (typeof(FSBase))]
    interface FSBitmap
    {
        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(id)initWithWidth:(int)width height:(int)height format:(FSBitmapDIBFormat)format buffer:(NSData *)buffer pitch:(int)pitch;
        [Export ("initWithWidth:height:format:buffer:pitch:")]
        IntPtr Constructor (int width, int height, FSBitmapDIBFormat format, NSData buffer, int pitch);

        // -(id)initWithWidth:(int)width height:(int)height format:(FSBitmapDIBFormat)format;
        [Export ("initWithWidth:height:format:")]
        IntPtr Constructor (int width, int height, FSBitmapDIBFormat format);

        // -(id)initWithOther:(FSBitmap *)other;
        [Export ("initWithOther:")]
        IntPtr Constructor (FSBitmap other);

        // -(BOOL)isEmpty;
        [Export ("isEmpty")]
        //[Verify (MethodToProperty)]
        bool IsEmpty { get; }

        // -(FSBitmap *)clone:(FSRectI *)clip_rect;
        [Export ("clone:")]
        FSBitmap Clone (FSRectI clip_rect);

        // -(int)getWidth;
        [Export ("getWidth")]
        //[Verify (MethodToProperty)]
        int Width { get; }

        // -(int)getHeight;
        [Export ("getHeight")]
        //[Verify (MethodToProperty)]
        int Height { get; }

        // -(int)getPitch;
        [Export ("getPitch")]
        //[Verify (MethodToProperty)]
        int Pitch { get; }

        // -(int)getBpp;
        [Export ("getBpp")]
        //[Verify (MethodToProperty)]
        int Bpp { get; }

        // -(FSBitmapDIBFormat)getFormat;
        [Export ("getFormat")]
        //[Verify (MethodToProperty)]
        FSBitmapDIBFormat Format { get; }

        // -(void)fillRect:(unsigned int)color rect:(FSRectI *)rect;
        [Export ("fillRect:rect:")]
        void FillRect (uint color, FSRectI rect);

        // -(FSBitmap *)convertFormat:(FSBitmapDIBFormat)format icc_transform:(NSData *)icc_transform;
        [Export ("convertFormat:icc_transform:")]
        FSBitmap ConvertFormat (FSBitmapDIBFormat format, NSData icc_transform);

        // -(FSRectI *)calculateBBoxByColor:(unsigned int)backgroud_color;
        [Export ("calculateBBoxByColor:")]
        FSRectI CalculateBBoxByColor (uint backgroud_color);

        // -(FSRectI *)detectBBoxByColorDiffer:(int)detection_size color_differ:(int)color_differ;
        [Export ("detectBBoxByColorDiffer:color_differ:")]
        FSRectI DetectBBoxByColorDiffer (int detection_size, int color_differ);

        // -(FSBitmap *)swapXY:(BOOL)is_flip_horz is_flip_vert:(BOOL)is_flip_vert clip_rect:(FSRectI *)clip_rect;
        [Export ("swapXY:is_flip_vert:clip_rect:")]
        FSBitmap SwapXY (bool is_flip_horz, bool is_flip_vert, FSRectI clip_rect);

        // -(FSBitmap *)flip:(BOOL)is_flip_horz is_flip_vert:(BOOL)is_flip_vert;
        [Export ("flip:is_flip_vert:")]
        FSBitmap Flip (bool is_flip_horz, bool is_flip_vert);

        // -(FSBitmap *)stretchTo:(int)dest_width dest_height:(int)dest_height flag:(FSBitmapInterpolationFlag)flag clip_rect:(FSRectI *)clip_rect;
        [Export ("stretchTo:dest_height:flag:clip_rect:")]
        FSBitmap StretchTo (int dest_width, int dest_height, FSBitmapInterpolationFlag flag, FSRectI clip_rect);

        // -(FSBitmap *)transformTo:(FSMatrix2D *)matrix flag:(FSBitmapInterpolationFlag)flag out_left:(int *)out_left out_top:(int *)out_top clip_rect:(FSRectI *)clip_rect;
        [Export("transformTo:flag:out_left:out_top:clip_rect:")]
        unsafe FSBitmap TransformTo(FSMatrix2D matrix, FSBitmapInterpolationFlag flag, int out_left, int out_top, FSRectI clip_rect);

        // -(FSBitmap *)getMask:(FSRectI *)clip_rect;
        [Export ("getMask:")]
        FSBitmap GetMask (FSRectI clip_rect);

        // -(NSData *)getBuffer;
        [Export ("getBuffer")]
        //[Verify (MethodToProperty)]
        NSData Buffer { get; }

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSImage : FSBase
    [BaseType (typeof(FSBase))]
    interface FSImage
    {
        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(id)initWithPath:(NSString *)path;
        [Export ("initWithPath:")]
        IntPtr Constructor (string path);

        // -(id)initWithFile_read:(id<FSFileReaderCallback>)file_read;
        [Export ("initWithFile_read:")]
        IntPtr Constructor (FSFileReaderCallback file_read);

        // -(id)initWithArg0:(FSImage *)arg0;
        [Export ("initWithArg0:")]
        IntPtr Constructor (FSImage arg0);

        // -(BOOL)isEmpty;
        [Export ("isEmpty")]
        //[Verify (MethodToProperty)]
        bool IsEmpty { get; }

        // -(FSImageType)getType;
        [Export ("getType")]
        //[Verify (MethodToProperty)]
        FSImageType Type { get; }

        // -(int)getWidth;
        [Export ("getWidth")]
        //[Verify (MethodToProperty)]
        int Width { get; }

        // -(int)getHeight;
        [Export ("getHeight")]
        //[Verify (MethodToProperty)]
        int Height { get; }

        // -(int)getFrameCount;
        [Export ("getFrameCount")]
        //[Verify (MethodToProperty)]
        int FrameCount { get; }

        // -(FSBitmap *)getFrameBitmap:(int)index;
        [Export ("getFrameBitmap:")]
        FSBitmap GetFrameBitmap (int index);

        // -(int)getXDPI;
        [Export ("getXDPI")]
        //[Verify (MethodToProperty)]
        int XDPI { get; }

        // -(int)getYDPI;
        [Export ("getYDPI")]
        //[Verify (MethodToProperty)]
        int YDPI { get; }

        // -(BOOL)addFrame:(FSBitmap *)bitmap;
        [Export ("addFrame:")]
        bool AddFrame (FSBitmap bitmap);

        // -(void)setDPIs:(int)x_dpi y_dpi:(int)y_dpi;
        [Export ("setDPIs:y_dpi:")]
        void SetDPIs (int x_dpi, int y_dpi);

        // -(BOOL)saveAs:(NSString *)file_path;
        [Export ("saveAs:")]
        bool SaveAs (string file_path);

        // -(id)initWithBuffer:(NSData *)buffer;
        [Export ("initWithBuffer:")]
        IntPtr Constructor (NSData buffer);

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSRenderer : FSBase
    [BaseType (typeof(FSBase))]
    [DisableDefaultCtor]
    interface FSRenderer
    {
        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(id)initWithBitmap:(FSBitmap *)bitmap is_rgb_order:(BOOL)is_rgb_order;
        [Export ("initWithBitmap:is_rgb_order:")]
        IntPtr Constructor (FSBitmap bitmap, bool is_rgb_order);

        // -(id)initWithContext:(CGContextRef)context device_type:(FSRendererDeviceType)device_type;
        [Export ("initWithContext:device_type:")]
        IntPtr Constructor ( IntPtr context, FSRendererDeviceType device_type);

        // -(id)initWithOther:(FSRenderer *)other;
        [Export ("initWithOther:")]
        IntPtr Constructor (FSRenderer other);

        // -(BOOL)isEmpty;
        [Export ("isEmpty")]
        //[Verify (MethodToProperty)]
        bool IsEmpty { get; }

        // -(FSProgressive *)startQuickRender:(FSPDFPage *)page matrix:(FSMatrix2D *)matrix pause:(id<FSPauseCallback>)pause;
        [Export ("startQuickRender:matrix:pause:")]
        FSProgressive StartQuickRender (FSPDFPage page, FSMatrix2D matrix, FSPauseCallback pause);

        // -(FSProgressive *)startRender:(FSPDFPage *)page matrix:(FSMatrix2D *)matrix pause:(id<FSPauseCallback>)pause;
        [Export ("startRender:matrix:pause:")]
        FSProgressive StartRender (FSPDFPage page, FSMatrix2D matrix, FSPauseCallback pause);

        // -(FSProgressive *)startRenderReflowPage:(FSReflowPage *)reflow_page matrix:(FSMatrix2D *)matrix pause:(id<FSPauseCallback>)pause;
        [Export ("startRenderReflowPage:matrix:pause:")]
        FSProgressive StartRenderReflowPage (FSReflowPage reflow_page, FSMatrix2D matrix, FSPauseCallback pause);

        // -(FSProgressive *)startRenderXFAPage:(FSXFAPage *)xfa_page_view matrix:(FSMatrix2D *)matrix is_highlight:(BOOL)is_highlight pause:(id<FSPauseCallback>)pause;
        [Export ("startRenderXFAPage:matrix:is_highlight:pause:")]
        FSProgressive StartRenderXFAPage (FSXFAPage xfa_page_view, FSMatrix2D matrix, bool is_highlight, FSPauseCallback pause);

        // -(FSProgressive *)startRenderBitmap:(FSBitmap *)bitmap matrix:(FSMatrix2D *)matrix clip_rect:(FSRectI *)clip_rect interpolation:(unsigned int)interpolation pause:(id<FSPauseCallback>)pause;
        [Export ("startRenderBitmap:matrix:clip_rect:interpolation:pause:")]
        FSProgressive StartRenderBitmap (FSBitmap bitmap, FSMatrix2D matrix, FSRectI clip_rect, uint interpolation, FSPauseCallback pause);

        // -(BOOL)renderAnnot:(FSAnnot *)annot matrix:(FSMatrix2D *)matrix;
        [Export ("renderAnnot:matrix:")]
        bool RenderAnnot (FSAnnot annot, FSMatrix2D matrix);

        // -(void)setClipRect:(FSRectI *)clip_rect;
        [Export ("setClipRect:")]
        void SetClipRect (FSRectI clip_rect);

        // -(void)setClipPathFill:(FSPath *)clip_path matrix:(FSMatrix2D *)matrix fill_mode:(FSFillMode)fill_mode;
        [Export ("setClipPathFill:matrix:fill_mode:")]
        void SetClipPathFill (FSPath clip_path, FSMatrix2D matrix, FSFillMode fill_mode);

        // -(void)setClipPathStroke:(FSPath *)clip_path matrix:(FSMatrix2D *)matrix graph_state:(FSGraphState *)graph_state;
        [Export ("setClipPathStroke:matrix:graph_state:")]
        void SetClipPathStroke (FSPath clip_path, FSMatrix2D matrix, FSGraphState graph_state);

        // -(void)setRenderContentFlags:(unsigned int)render_content_flags;
        [Export ("setRenderContentFlags:")]
        void SetRenderContentFlags (uint render_content_flags);

        // -(void)setTransformAnnotIcon:(BOOL)is_to_transform_annot_icon;
        [Export ("setTransformAnnotIcon:")]
        void SetTransformAnnotIcon (bool is_to_transform_annot_icon);

        // -(void)setRenderFormField:(BOOL)is_render_formfield;
        [Export ("setRenderFormField:")]
        void SetRenderFormField (bool is_render_formfield);

        // -(void)setRenderSignature:(BOOL)is_render_signature;
        [Export ("setRenderSignature:")]
        void SetRenderSignature (bool is_render_signature);

        // -(void)setLayerContext:(FSLayerContext *)layer_context;
        [Export ("setLayerContext:")]
        void SetLayerContext (FSLayerContext layer_context);

        // -(void)setColorMode:(FSRendererColorMode)color_mode;
        [Export ("setColorMode:")]
        void SetColorMode (FSRendererColorMode color_mode);

        // -(void)setMappingModeColors:(unsigned int)background_color foreground_color:(unsigned int)foreground_color;
        [Export ("setMappingModeColors:foreground_color:")]
        void SetMappingModeColors (uint background_color, uint foreground_color);

        // -(void)setForceHalftone:(BOOL)is_to_force_halftone;
        [Export ("setForceHalftone:")]
        void SetForceHalftone (bool is_to_force_halftone);

        // -(void)setRenderPathThinLine:(BOOL)is_render_path_thin_line;
        [Export ("setRenderPathThinLine:")]
        void SetRenderPathThinLine (bool is_render_path_thin_line);

        // -(void)setRenderTextAntiAliasing:(BOOL)is_render_text_antialiasing;
        [Export ("setRenderTextAntiAliasing:")]
        void SetRenderTextAntiAliasing (bool is_render_text_antialiasing);

        // -(void)setRenderPathAntiAliasing:(BOOL)is_render_path_antialiasing;
        [Export ("setRenderPathAntiAliasing:")]
        void SetRenderPathAntiAliasing (bool is_render_path_antialiasing);

        // -(void)setRenderImageAntiAliasing:(BOOL)is_render_image_antialiasing;
        [Export ("setRenderImageAntiAliasing:")]
        void SetRenderImageAntiAliasing (bool is_render_image_antialiasing);

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSBarcode : FSBase
    [BaseType (typeof(FSBase))]
    interface FSBarcode
    {
        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(id)initWithOther:(FSBarcode *)other;
        [Export ("initWithOther:")]
        IntPtr Constructor (FSBarcode other);

        // -(BOOL)isEmpty;
        [Export ("isEmpty")]
        //[Verify (MethodToProperty)]
        bool IsEmpty { get; }

        // -(FSBitmap *)generateBitmap:(NSString *)info format:(FSBarcodeFormat)format unit_width:(int)unit_width unit_height:(int)unit_height level:(FSBarcodeQRErrorCorrectionLevel)level;
        [Export ("generateBitmap:format:unit_width:unit_height:level:")]
        FSBitmap GenerateBitmap (string info, FSBarcodeFormat format, int unit_width, int unit_height, FSBarcodeQRErrorCorrectionLevel level);

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSRedaction : FSBase
    [BaseType (typeof(FSBase))]
    [DisableDefaultCtor]
    interface FSRedaction
    {
        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(id)initWithDocument:(FSPDFDoc *)document;
        [Export ("initWithDocument:")]
        IntPtr Constructor (FSPDFDoc document);

        // -(id)initWithOther:(FSRedaction *)other;
        [Export ("initWithOther:")]
        IntPtr Constructor (FSRedaction other);

        // -(BOOL)isEmpty;
        [Export ("isEmpty")]
        //[Verify (MethodToProperty)]
        bool IsEmpty { get; }

        // -(FSRedact *)markRedactAnnot:(FSPDFPage *)page rects:(FSRectFArray *)rects;
        [Export ("markRedactAnnot:rects:")]
        FSRedact MarkRedactAnnot (FSPDFPage page, FSRectFArray rects);

        // -(BOOL)apply;
        [Export ("apply")]
        //[Verify (MethodToProperty)]
        bool Apply { get; }

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSClientInfo : NSObject
    [BaseType (typeof(NSObject))]
    interface FSClientInfo
    {
        // @property (getter = getDevice_id, nonatomic, weak) NSString * device_id;
        [Export ("device_id", ArgumentSemantic.Weak)]
        string Device_id { [Bind ("getDevice_id")] get; set; }

        // @property (getter = getDevice_name, nonatomic, weak) NSString * device_name;
        [Export ("device_name", ArgumentSemantic.Weak)]
        string Device_name { [Bind ("getDevice_name")] get; set; }

        // @property (getter = getDevice_model, nonatomic, weak) NSString * device_model;
        [Export ("device_model", ArgumentSemantic.Weak)]
        string Device_model { [Bind ("getDevice_model")] get; set; }

        // @property (getter = getMac_address, nonatomic, weak) NSString * mac_address;
        [Export ("mac_address", ArgumentSemantic.Weak)]
        string Mac_address { [Bind ("getMac_address")] get; set; }

        // @property (getter = getOs, nonatomic, weak) NSString * os;
        [Export ("os", ArgumentSemantic.Weak)]
        string Os { [Bind ("getOs")] get; set; }

        // @property (getter = getProduct_name, nonatomic, weak) NSString * product_name;
        [Export ("product_name", ArgumentSemantic.Weak)]
        string Product_name { [Bind ("getProduct_name")] get; set; }

        // @property (getter = getProduct_vendor, nonatomic, weak) NSString * product_vendor;
        [Export ("product_vendor", ArgumentSemantic.Weak)]
        string Product_vendor { [Bind ("getProduct_vendor")] get; set; }

        // @property (getter = getProduct_version, nonatomic, weak) NSString * product_version;
        [Export ("product_version", ArgumentSemantic.Weak)]
        string Product_version { [Bind ("getProduct_version")] get; set; }

        // @property (getter = getProduct_language, nonatomic, weak) NSString * product_language;
        [Export ("product_language", ArgumentSemantic.Weak)]
        string Product_language { [Bind ("getProduct_language")] get; set; }

        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSConnectedPDF : FSBase
    [BaseType (typeof(FSBase))]
    [DisableDefaultCtor]
    interface FSConnectedPDF
    {
        // @property (getter = getUserToken, nonatomic, weak) NSString * userToken;
        [Export ("userToken", ArgumentSemantic.Weak)]
        string UserToken { [Bind ("getUserToken")] get; set; }

        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // +(NSString *)getDocURI:(NSString *)file_path;
        [Static]
        [Export ("getDocURI:")]
        string GetDocURI (string file_path);

        // +(NSString *)getClientIDFromServer:(NSString *)endpoint client_info:(FSClientInfo *)client_info;
        [Static]
        [Export ("getClientIDFromServer:client_info:")]
        string GetClientIDFromServer (string endpoint, FSClientInfo client_info);

        // +(NSString *)getUserTokenFromServer:(NSString *)endpoint user_email:(NSString *)user_email password:(NSString *)password;
        [Static]
        [Export ("getUserTokenFromServer:user_email:password:")]
        string GetUserTokenFromServer (string endpoint, string user_email, string password);

        // -(id)initWithClientid:(NSString *)clientid user_token:(NSString *)user_token content_key:(NSString *)content_key file_path:(NSString *)file_path;
        [Export ("initWithClientid:user_token:content_key:file_path:")]
        IntPtr Constructor (string clientid, string user_token, string content_key, string file_path);

        // -(id)initWithClientid:(NSString *)clientid user_token:(NSString *)user_token content_key:(NSString *)content_key file_read:(id<FSFileReaderCallback>)file_read;
        [Export ("initWithClientid:user_token:content_key:file_read:")]
        IntPtr Constructor (string clientid, string user_token, string content_key, FSFileReaderCallback file_read);

        // -(id)initWithClientid:(NSString *)clientid user_token:(NSString *)user_token content_key:(NSString *)content_key document:(FSPDFDoc *)document;
        [Export ("initWithClientid:user_token:content_key:document:")]
        IntPtr Constructor (string clientid, string user_token, string content_key, FSPDFDoc document);

        // -(id)initWithConnected_pdf:(FSConnectedPDF *)connected_pdf;
        [Export ("initWithConnected_pdf:")]
        IntPtr Constructor (FSConnectedPDF connected_pdf);

        // -(BOOL)isEmpty;
        [Export ("isEmpty")]
        //[Verify (MethodToProperty)]
        bool IsEmpty { get; }

        // -(BOOL)isCPDF;
        [Export ("isCPDF")]
        //[Verify (MethodToProperty)]
        bool IsCPDF { get; }

        // -(BOOL)isCDRM;
        [Export ("isCDRM")]
        //[Verify (MethodToProperty)]
        bool IsCDRM { get; }

        // -(BOOL)isOwner;
        [Export ("isOwner")]
        //[Verify (MethodToProperty)]
        bool IsOwner { get; }

        // -(FSPDFDoc *)getDocument;
        [Export ("getDocument")]
        //[Verify (MethodToProperty)]
        FSPDFDoc Document { get; }

        // -(NSString *)getContentKey;
        [Export ("getContentKey")]
        //[Verify (MethodToProperty)]
        string ContentKey { get; }

        // -(FSErrorCode)convertToCPDF:(NSString *)endpoint file_name:(NSString *)file_name;
        [Export ("convertToCPDF:file_name:")]
        FSErrorCode ConvertToCPDF (string endpoint, string file_name);

        // -(FSErrorCode)convertToCDRM:(NSString *)endpoint wrapper_path:(NSString *)wrapper_path file_name:(NSString *)file_name;
        [Export ("convertToCDRM:wrapper_path:file_name:")]
        FSErrorCode ConvertToCDRM (string endpoint, string wrapper_path, string file_name);

        // -(FSErrorCode)removeCDRM;
        [Export ("removeCDRM")]
        //[Verify (MethodToProperty)]
        FSErrorCode RemoveCDRM { get; }

        // -(FSErrorCode)setACL:(NSString *)acl;
        [Export ("setACL:")]
        FSErrorCode SetACL (string acl);

        // -(NSString *)getACL;
        [Export ("getACL")]
        //[Verify (MethodToProperty)]
        string ACL { get; }

        // -(NSString *)getVersionID;
        [Export ("getVersionID")]
        //[Verify (MethodToProperty)]
        string VersionID { get; }

        // -(NSString *)refreshVersionID;
        [Export ("refreshVersionID")]
        //[Verify (MethodToProperty)]
        string RefreshVersionID { get; }

        // -(NSString *)getEndpoint;
        [Export ("getEndpoint")]
        //[Verify (MethodToProperty)]
        string Endpoint { get; }

        // -(NSString *)getOwnerEmail;
        [Export ("getOwnerEmail")]
        //[Verify (MethodToProperty)]
        string OwnerEmail { get; }

        // -(NSString *)getOwnerName;
        [Export ("getOwnerName")]
        //[Verify (MethodToProperty)]
        string OwnerName { get; }

        // -(BOOL)saveAs:(NSString *)file_path;
        [Export ("saveAs:")]
        bool SaveAs (string file_path);

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSXFADoc : FSBase
    [BaseType (typeof(FSBase))]
    [DisableDefaultCtor]
    interface FSXFADoc
    {
        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(id)initWithDocument:(FSPDFDoc *)document xfa_doc_provider_handler:(id<FSDocProviderCallback>)xfa_doc_provider_handler;
        [Export ("initWithDocument:xfa_doc_provider_handler:")]
        IntPtr Constructor (FSPDFDoc document, FSDocProviderCallback xfa_doc_provider_handler);

        // -(id)initWithDocument:(FSPDFDoc *)document;
        [Export ("initWithDocument:")]
        IntPtr Constructor (FSPDFDoc document);

        // -(id)initWithOther:(FSXFADoc *)other;
        [Export ("initWithOther:")]
        IntPtr Constructor (FSXFADoc other);

        // -(BOOL)isEmpty;
        [Export ("isEmpty")]
        //[Verify (MethodToProperty)]
        bool IsEmpty { get; }

        // -(FSProgressive *)startLoad:(id<FSPauseCallback>)pause;
        [Export ("startLoad:")]
        FSProgressive StartLoad (FSPauseCallback pause);

        // -(void)setDocProviderCallback:(id<FSDocProviderCallback>)doc_provider_callback;
        [Export ("setDocProviderCallback:")]
        void SetDocProviderCallback (FSDocProviderCallback doc_provider_callback);

        // -(FSXFADocType)getType;
        [Export ("getType")]
        //[Verify (MethodToProperty)]
        FSXFADocType Type { get; }

        // -(int)getPageCount;
        [Export ("getPageCount")]
        //[Verify (MethodToProperty)]
        int PageCount { get; }

        // -(FSXFAPage *)getPage:(int)page_index;
        [Export ("getPage:")]
        FSXFAPage GetPage (int page_index);

        // -(BOOL)exportData:(NSString *)output_file_path export_type:(FSXFADocExportDataType)export_type;
        [Export ("exportData:export_type:")]
        bool ExportData (string output_file_path, FSXFADocExportDataType export_type);

        // -(void)setPDFPath:(NSString *)pdf_file_path;
        [Export ("setPDFPath:")]
        void SetPDFPath (string pdf_file_path);

        // -(BOOL)importData:(NSString *)file_path;
        [Export ("importData:")]
        bool ImportData (string file_path);

        // -(void)resetForm;
        [Export ("resetForm")]
        void ResetForm ();

        // -(void)flattenTo:(NSString *)output_file_path;
        [Export ("flattenTo:")]
        void FlattenTo (string output_file_path);

        // -(void)processEvent:(FSXFADocEventType)event_type;
        [Export ("processEvent:")]
        void ProcessEvent (FSXFADocEventType event_type);

        // -(void)setFocus:(FSXFAWidget *)xfa_widget;
        [Export ("setFocus:")]
        void SetFocus (FSXFAWidget xfa_widget);

        // -(void)killFocus;
        [Export ("killFocus")]
        void KillFocus ();

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSXFAPage : FSBase
    [BaseType (typeof(FSBase))]
    [DisableDefaultCtor]
    interface FSXFAPage
    {
        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(id)initWithOther:(FSXFAPage *)other;
        [Export ("initWithOther:")]
        IntPtr Constructor (FSXFAPage other);

        // -(BOOL)isEmpty;
        [Export ("isEmpty")]
        //[Verify (MethodToProperty)]
        bool IsEmpty { get; }

        // -(FSMatrix2D *)getDisplayMatrix:(int)left top:(int)top width:(int)width height:(int)height rotate:(FSRotation)rotate;
        [Export ("getDisplayMatrix:top:width:height:rotate:")]
        FSMatrix2D GetDisplayMatrix (int left, int top, int width, int height, FSRotation rotate);

        // -(float)getWidth;
        [Export ("getWidth")]
        //[Verify (MethodToProperty)]
        float Width { get; }

        // -(float)getHeight;
        [Export ("getHeight")]
        //[Verify (MethodToProperty)]
        float Height { get; }

        // -(FSXFAWidget *)getWidgetAtDevicePoint:(FSMatrix2D *)matrix device_point:(FSPointF *)device_point tolerance:(float)tolerance;
        [Export ("getWidgetAtDevicePoint:device_point:tolerance:")]
        FSXFAWidget GetWidgetAtDevicePoint (FSMatrix2D matrix, FSPointF device_point, float tolerance);

        // -(int)getIndex;
        [Export ("getIndex")]
        //[Verify (MethodToProperty)]
        int Index { get; }

        // -(int)getWidgetCount;
        [Export ("getWidgetCount")]
        //[Verify (MethodToProperty)]
        int WidgetCount { get; }

        // -(FSXFAWidget *)getWidget:(int)widget_index;
        [Export ("getWidget:")]
        FSXFAWidget GetWidget (int widget_index);

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSXFAWidget : FSBase
    [BaseType (typeof(FSBase))]
    [DisableDefaultCtor]
    interface FSXFAWidget
    {
        // @property (getter = getValue, nonatomic, weak) NSString * value;
        [Export ("value", ArgumentSemantic.Weak)]
        string Value { [Bind ("getValue")] get; set; }

        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(id)initWithOther:(FSXFAWidget *)other;
        [Export ("initWithOther:")]
        IntPtr Constructor (FSXFAWidget other);

        // -(BOOL)isEmpty;
        [Export ("isEmpty")]
        //[Verify (MethodToProperty)]
        bool IsEmpty { get; }

        // -(FSXFAPage *)getXFAPage;
        [Export ("getXFAPage")]
        //[Verify (MethodToProperty)]
        FSXFAPage XFAPage { get; }

        // -(int)getIndex;
        [Export ("getIndex")]
        //[Verify (MethodToProperty)]
        int Index { get; }

        // -(void)resetData;
        [Export ("resetData")]
        void ResetData ();

        // -(FSRectF *)getRect;
        [Export ("getRect")]
        //[Verify (MethodToProperty)]
        FSRectF Rect { get; }

        // -(FSXFAWidgetPresenceProperty)getPresence;
        [Export ("getPresence")]
        //[Verify (MethodToProperty)]
        FSXFAWidgetPresenceProperty Presence { get; }

        // -(BOOL)onMouseEnter;
        [Export ("onMouseEnter")]
        //[Verify (MethodToProperty)]
        bool OnMouseEnter { get; }

        // -(BOOL)onMouseExit;
        [Export ("onMouseExit")]
        //[Verify (MethodToProperty)]
        bool OnMouseExit { get; }

        // -(BOOL)onLButtonDown:(FSPointF *)point flags:(unsigned int)flags;
        [Export ("onLButtonDown:flags:")]
        bool OnLButtonDown (FSPointF point, uint flags);

        // -(BOOL)onLButtonUp:(FSPointF *)point flags:(unsigned int)flags;
        [Export ("onLButtonUp:flags:")]
        bool OnLButtonUp (FSPointF point, uint flags);

        // -(BOOL)onLButtonDoubleClick:(FSPointF *)point flags:(unsigned int)flags;
        [Export ("onLButtonDoubleClick:flags:")]
        bool OnLButtonDoubleClick (FSPointF point, uint flags);

        // -(BOOL)onMouseMove:(FSPointF *)point flags:(unsigned int)flags;
        [Export ("onMouseMove:flags:")]
        bool OnMouseMove (FSPointF point, uint flags);

        // -(BOOL)onRButtonDown:(FSPointF *)point flags:(unsigned int)flags;
        [Export ("onRButtonDown:flags:")]
        bool OnRButtonDown (FSPointF point, uint flags);

        // -(BOOL)onRButtonUp:(FSPointF *)point flags:(unsigned int)flags;
        [Export ("onRButtonUp:flags:")]
        bool OnRButtonUp (FSPointF point, uint flags);

        // -(BOOL)onKeyDown:(unsigned int)key_code flags:(unsigned int)flags;
        [Export ("onKeyDown:flags:")]
        bool OnKeyDown (uint key_code, uint flags);

        // -(BOOL)onKeyUp:(unsigned int)key_code flags:(unsigned int)flags;
        [Export ("onKeyUp:flags:")]
        bool OnKeyUp (uint key_code, uint flags);

        // -(BOOL)onChar:(int)input_char flags:(unsigned int)flags;
        [Export ("onChar:flags:")]
        bool OnChar (int input_char, uint flags);

        // -(FSXFAWidgetHitTestArea)onHitTest:(FSPointF *)point;
        [Export ("onHitTest:")]
        FSXFAWidgetHitTestArea OnHitTest (FSPointF point);

        // -(FSXFAWidgetWidgetType)getType;
        [Export ("getType")]
        //[Verify (MethodToProperty)]
        FSXFAWidgetWidgetType Type { get; }

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSWidgetMenu : FSBase
    [BaseType (typeof(FSBase))]
    [DisableDefaultCtor]
    interface FSWidgetMenu
    {
        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(id)initWithXfa_widget:(FSXFAWidget *)xfa_widget;
        [Export ("initWithXfa_widget:")]
        IntPtr Constructor (FSXFAWidget xfa_widget);

        // -(id)initWithOther:(FSWidgetMenu *)other;
        [Export ("initWithOther:")]
        IntPtr Constructor (FSWidgetMenu other);

        // -(BOOL)isEmpty;
        [Export ("isEmpty")]
        //[Verify (MethodToProperty)]
        bool IsEmpty { get; }

        // -(BOOL)canCopy;
        [Export ("canCopy")]
        //[Verify (MethodToProperty)]
        bool CanCopy { get; }

        // -(BOOL)canCut;
        [Export ("canCut")]
        //[Verify (MethodToProperty)]
        bool CanCut { get; }

        // -(BOOL)canPaste;
        [Export ("canPaste")]
        //[Verify (MethodToProperty)]
        bool CanPaste { get; }

        // -(BOOL)canSelectAll;
        [Export ("canSelectAll")]
        //[Verify (MethodToProperty)]
        bool CanSelectAll { get; }

        // -(BOOL)canDelete;
        [Export ("canDelete")]
        //[Verify (MethodToProperty)]
        bool CanDelete { get; }

        // -(BOOL)canDeSelect;
        [Export ("canDeSelect")]
        //[Verify (MethodToProperty)]
        bool CanDeSelect { get; }

        // -(NSString *)copy;
        [Export ("copy")]
        //[Verify (MethodToProperty)]
        string Copy { get; }

        // -(NSString *)cut;
        [Export ("cut")]
        //[Verify (MethodToProperty)]
        string Cut { get; }

        // -(BOOL)paste:(NSString *)text;
        [Export ("paste:")]
        bool Paste (string text);

        // -(BOOL)selectAll;
        [Export ("selectAll")]
        //[Verify (MethodToProperty)]
        bool SelectAll { get; }

        // -(BOOL)delete;
        [Export ("delete")]
        //[Verify (MethodToProperty)]
        bool Delete { get; }

        // -(BOOL)deSelect;
        [Export ("deSelect")]
        //[Verify (MethodToProperty)]
        bool DeSelect { get; }

        // -(BOOL)canUndo;
        [Export ("canUndo")]
        //[Verify (MethodToProperty)]
        bool CanUndo { get; }

        // -(BOOL)canRedo;
        [Export ("canRedo")]
        //[Verify (MethodToProperty)]
        bool CanRedo { get; }

        // -(BOOL)undo;
        [Export ("undo")]
        //[Verify (MethodToProperty)]
        bool Undo { get; }

        // -(BOOL)redo;
        [Export ("redo")]
        //[Verify (MethodToProperty)]
        bool Redo { get; }

        // -(BOOL)bold;
        [Export ("bold")]
        //[Verify (MethodToProperty)]
        bool Bold { get; }

        // -(BOOL)italic;
        [Export ("italic")]
        //[Verify (MethodToProperty)]
        bool Italic { get; }

        // -(BOOL)underline;
        [Export ("underline")]
        //[Verify (MethodToProperty)]
        bool Underline { get; }

        // -(BOOL)superscript;
        [Export ("superscript")]
        //[Verify (MethodToProperty)]
        bool Superscript { get; }

        // -(BOOL)subscript;
        [Export ("subscript")]
        //[Verify (MethodToProperty)]
        bool Subscript { get; }

        // -(BOOL)clearStyle;
        [Export ("clearStyle")]
        //[Verify (MethodToProperty)]
        bool ClearStyle { get; }

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSFDFDoc : FSBase
    [BaseType (typeof(FSBase))]
    [DisableDefaultCtor]
    interface FSFDFDoc
    {
        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(id)initWithFile_read:(id<FSFileReaderCallback>)file_read;
        [Export ("initWithFile_read:")]
        IntPtr Constructor (FSFileReaderCallback file_read);

        // -(id)initWithType:(FSFDFDocType)type;
        [Export ("initWithType:")]
        IntPtr Constructor (FSFDFDocType type);

        // -(id)initWithPath:(NSString *)path;
        [Export ("initWithPath:")]
        IntPtr Constructor (string path);

        // -(id)initWithOther:(FSFDFDoc *)other;
        [Export ("initWithOther:")]
        IntPtr Constructor (FSFDFDoc other);

        // -(BOOL)isEmpty;
        [Export ("isEmpty")]
        //[Verify (MethodToProperty)]
        bool IsEmpty { get; }

        // -(FSFDFDocType)getType;
        [Export ("getType")]
        //[Verify (MethodToProperty)]
        FSFDFDocType Type { get; }

        // -(NSString *)getPDFPath;
        [Export ("getPDFPath")]
        //[Verify (MethodToProperty)]
        string PDFPath { get; }

        // -(BOOL)setPDFPath:(NSString *)pdf_path;
        [Export ("setPDFPath:")]
        bool SetPDFPath (string pdf_path);

        // -(BOOL)saveAs:(NSString *)file_path;
        [Export ("saveAs:")]
        bool SaveAs (string file_path);

        // -(FSPDFDictionary *)getCatalog;
        [Export ("getCatalog")]
        //[Verify (MethodToProperty)]
        FSPDFDictionary Catalog { get; }

        // -(FSPDFDictionary *)getFDFDict;
        [Export ("getFDFDict")]
        //[Verify (MethodToProperty)]
        FSPDFDictionary FDFDict { get; }

        // -(id)initWithBuffer:(NSData *)buffer;
        [Export ("initWithBuffer:")]
        IntPtr Constructor (NSData buffer);

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSMenuList : NSObject
    [BaseType (typeof(NSObject))]
    interface FSMenuList
    {
        // @property (getter = getLevel, nonatomic) int level;
        [Export ("level")]
        int Level { [Bind ("getLevel")] get; set; }

        // @property (getter = getName, nonatomic, weak) NSString * name;
        [Export ("name", ArgumentSemantic.Weak)]
        string Name { [Bind ("getName")] get; set; }

        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(id)initWithLevel:(int)level name:(NSString *)name;
        [Export ("initWithLevel:name:")]
        IntPtr Constructor (int level, string name);

        // -(id)initWithMenu_list:(FSMenuList *)menu_list;
        [Export ("initWithMenu_list:")]
        IntPtr Constructor (FSMenuList menu_list);

        // -(void)set:(int)level name:(NSString *)name;
        [Export ("set:name:")]
        void Set (int level, string name);

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSMenuListArray : NSObject
    [BaseType (typeof(NSObject))]
    interface FSMenuListArray
    {
        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(id)initWithArg0:(FSMenuListArray *)arg0;
        [Export ("initWithArg0:")]
        IntPtr Constructor (FSMenuListArray arg0);

        // -(unsigned long)getSize;
        [Export ("getSize")]
        //[Verify (MethodToProperty)]
        nuint Size { get; }

        // -(FSMenuList *)getAt:(unsigned long)index;
        [Export ("getAt:")]
        FSMenuList GetAt (nuint index);

        // -(void)add:(FSMenuList *)element;
        [Export ("add:")]
        void Add (FSMenuList element);

        // -(void)removeAt:(unsigned long)index;
        [Export ("removeAt:")]
        void RemoveAt (nuint index);

        // -(void)insertAt:(unsigned long)index element:(FSMenuList *)element;
        [Export ("insertAt:element:")]
        void InsertAt (nuint index, FSMenuList element);

        // -(void)removeAll;
        [Export ("removeAll")]
        void RemoveAll ();

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSIdentityProperties : NSObject
    [BaseType (typeof(NSObject))]
    interface FSIdentityProperties
    {
        // @property (getter = getCorporation, nonatomic, weak) NSString * corporation;
        [Export ("corporation", ArgumentSemantic.Weak)]
        string Corporation { [Bind ("getCorporation")] get; set; }

        // @property (getter = getEmail, nonatomic, weak) NSString * email;
        [Export ("email", ArgumentSemantic.Weak)]
        string Email { [Bind ("getEmail")] get; set; }

        // @property (getter = getLogin_name, nonatomic, weak) NSString * login_name;
        [Export ("login_name", ArgumentSemantic.Weak)]
        string Login_name { [Bind ("getLogin_name")] get; set; }

        // @property (getter = getName, nonatomic, weak) NSString * name;
        [Export ("name", ArgumentSemantic.Weak)]
        string Name { [Bind ("getName")] get; set; }

        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(id)initWithCorporation:(NSString *)corporation email:(NSString *)email login_name:(NSString *)login_name name:(NSString *)name;
        [Export ("initWithCorporation:email:login_name:name:")]
        IntPtr Constructor (string corporation, string email, string login_name, string name);

        // -(id)initWithId_properities:(FSIdentityProperties *)id_properities;
        [Export ("initWithId_properities:")]
        IntPtr Constructor (FSIdentityProperties id_properities);

        // -(void)set:(NSString *)corporation email:(NSString *)email login_name:(NSString *)login_name name:(NSString *)name;
        [Export ("set:email:login_name:name:")]
        void Set (string corporation, string email, string login_name, string name);

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSDocumentsSource : FSBase
    [BaseType (typeof(FSBase))]
    [DisableDefaultCtor]
    interface FSDocumentsSource
    {
        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(id)initWithDirectory:(NSString *)directory;
        [Export ("initWithDirectory:")]
        IntPtr Constructor (string directory);

        // -(id)initWithOther:(FSDocumentsSource *)other;
        [Export ("initWithOther:")]
        IntPtr Constructor (FSDocumentsSource other);

        // -(BOOL)isEmpty;
        [Export ("isEmpty")]
        //[Verify (MethodToProperty)]
        bool IsEmpty { get; }

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSFullTextSearch : FSBase
    [BaseType (typeof(FSBase))]
    interface FSFullTextSearch
    {
        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(id)initWithOther:(FSFullTextSearch *)other;
        [Export ("initWithOther:")]
        IntPtr Constructor (FSFullTextSearch other);

        // -(BOOL)isEmpty;
        [Export ("isEmpty")]
        //[Verify (MethodToProperty)]
        bool IsEmpty { get; }

        // -(void)setDataBasePath:(NSString *)path_of_data_base;
        [Export ("setDataBasePath:")]
        void SetDataBasePath (string path_of_data_base);

        // -(FSProgressive *)startUpdateIndex:(FSDocumentsSource *)source pause:(id<FSPauseCallback>)pause reupdate:(BOOL)reupdate;
        [Export ("startUpdateIndex:pause:reupdate:")]
        FSProgressive StartUpdateIndex (FSDocumentsSource source, FSPauseCallback pause, bool reupdate);

        // -(BOOL)updateIndexWithFilePath:(NSString *)file_path;
        [Export ("updateIndexWithFilePath:")]
        bool UpdateIndexWithFilePath (string file_path);

        // -(BOOL)searchOf:(NSString *)match_string rank_mode:(FSFullTextSearchRankMode)rank_mode callback:(id<FSSearchCallback>)callback;
        [Export ("searchOf:rank_mode:callback:")]
        bool SearchOf (string match_string, FSFullTextSearchRankMode rank_mode, FSSearchCallback callback);

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSPDFNameTree : FSBase
    [BaseType (typeof(FSBase))]
    [DisableDefaultCtor]
    interface FSPDFNameTree
    {
        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(id)initWithDocument:(FSPDFDoc *)document type:(FSPDFNameTreeType)type;
        [Export ("initWithDocument:type:")]
        IntPtr Constructor (FSPDFDoc document, FSPDFNameTreeType type);

        // -(id)initWithOther:(FSPDFNameTree *)other;
        [Export ("initWithOther:")]
        IntPtr Constructor (FSPDFNameTree other);

        // -(BOOL)isEmpty;
        [Export ("isEmpty")]
        //[Verify (MethodToProperty)]
        bool IsEmpty { get; }

        // -(FSPDFNameTreeType)getType;
        [Export ("getType")]
        //[Verify (MethodToProperty)]
        FSPDFNameTreeType Type { get; }

        // -(BOOL)hasName:(NSString *)name;
        [Export ("hasName:")]
        bool HasName (string name);

        // -(int)getCount;
        [Export ("getCount")]
        //[Verify (MethodToProperty)]
        int Count { get; }

        // -(NSString *)getName:(int)index;
        [Export ("getName:")]
        string GetName (int index);

        // -(FSPDFObject *)getObj:(NSString *)name;
        [Export ("getObj:")]
        FSPDFObject GetObj (string name);

        // -(BOOL)setObj:(NSString *)name pdf_object:(FSPDFObject *)pdf_object;
        [Export ("setObj:pdf_object:")]
        bool SetObj (string name, FSPDFObject pdf_object);

        // -(BOOL)rename:(NSString *)old_name new_name:(NSString *)new_name;
        [Export ("rename:new_name:")]
        bool Rename (string old_name, string new_name);

        // -(BOOL)add:(NSString *)name pdf_object:(FSPDFObject *)pdf_object;
        [Export ("add:pdf_object:")]
        bool Add (string name, FSPDFObject pdf_object);

        // -(BOOL)removeObj:(NSString *)name;
        [Export ("removeObj:")]
        bool RemoveObj (string name);

        // -(BOOL)removeAllObjs;
        [Export ("removeAllObjs")]
        //[Verify (MethodToProperty)]
        bool RemoveAllObjs { get; }

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSPDFObject : NSObject
    [BaseType (typeof(NSObject))]
    interface FSPDFObject
    {
        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // +(FSPDFObject *)createFromBoolean:(BOOL)boolean_value;
        [Static]
        [Export ("createFromBoolean:")]
        FSPDFObject CreateFromBoolean (bool boolean_value);

        // +(FSPDFObject *)createFromFloat:(float)float_value;
        [Static]
        [Export ("createFromFloat:")]
        FSPDFObject CreateFromFloat (float float_value);

        // +(FSPDFObject *)createFromInteger:(int)integer_value;
        [Static]
        [Export ("createFromInteger:")]
        FSPDFObject CreateFromInteger (int integer_value);

        // +(FSPDFObject *)createFromString:(NSString *)string_value;
        [Static]
        [Export ("createFromString:")]
        FSPDFObject CreateFromString (string string_value);

        // +(FSPDFObject *)createFromName:(NSString *)name;
        [Static]
        [Export ("createFromName:")]
        FSPDFObject CreateFromName (string name);

        // +(FSPDFObject *)createFromDateTime:(FSDateTime *)date_time;
        [Static]
        [Export ("createFromDateTime:")]
        FSPDFObject CreateFromDateTime (FSDateTime date_time);

        // +(FSPDFObject *)createReference:(FSPDFDoc *)document object_number:(unsigned int)object_number;
        [Static]
        [Export ("createReference:object_number:")]
        FSPDFObject CreateReference (FSPDFDoc document, uint object_number);

        // -(FSPDFObject *)cloneObject;
        [Export ("cloneObject")]
        //[Verify (MethodToProperty)]
        FSPDFObject CloneObject { get; }

        // -(FSPDFObjectType)getType;
        [Export ("getType")]
        //[Verify (MethodToProperty)]
        FSPDFObjectType Type { get; }

        // -(unsigned int)getObjNum;
        [Export ("getObjNum")]
        //[Verify (MethodToProperty)]
        uint ObjNum { get; }

        // -(int)getInteger;
        [Export ("getInteger")]
        //[Verify (MethodToProperty)]
        int Integer { get; }

        // -(float)getFloat;
        [Export ("getFloat")]
        //[Verify (MethodToProperty)]
        float Float { get; }

        // -(BOOL)getBoolean;
        [Export ("getBoolean")]
        //[Verify (MethodToProperty)]
        bool Boolean { get; }

        // -(FSMatrix2D *)getMatrix;
        [Export ("getMatrix")]
        //[Verify (MethodToProperty)]
        FSMatrix2D Matrix { get; }

        // -(FSRectF *)getRect;
        [Export ("getRect")]
        //[Verify (MethodToProperty)]
        FSRectF Rect { get; }

        // -(FSPDFObject *)getDirectObject;
        [Export ("getDirectObject")]
        //[Verify (MethodToProperty)]
        FSPDFObject DirectObject { get; }

        // -(FSDateTime *)getDateTime;
        [Export ("getDateTime")]
        //[Verify (MethodToProperty)]
        FSDateTime DateTime { get; }

        // -(NSString *)getName;
        [Export ("getName")]
        //[Verify (MethodToProperty)]
        string Name { get; }

        // -(NSString *)getWideString;
        [Export ("getWideString")]
        //[Verify (MethodToProperty)]
        string WideString { get; }

        // -(FSPDFArray *)getArray;
        [Export ("getArray")]
        //[Verify (MethodToProperty)]
        FSPDFArray Array { get; }

        // -(FSPDFDictionary *)getDict;
        [Export ("getDict")]
        //[Verify (MethodToProperty)]
        FSPDFDictionary Dict { get; }

        // -(FSPDFStream *)getStream;
        [Export ("getStream")]
        //[Verify (MethodToProperty)]
        FSPDFStream Stream { get; }

        // -(NSString *)getString;
        [Export ("getString")]
        //[Verify (MethodToProperty)]
        string String { get; }

        // -(const char *)getOriginalString;
        [Export ("getOriginalString")]
        //[Verify (MethodToProperty)]
        unsafe string OriginalString { get; }

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSPDFStream : FSPDFObject
    [BaseType (typeof(FSPDFObject))]
    [DisableDefaultCtor]
    interface FSPDFStream
    {
        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // +(FSPDFStream *)create:(FSPDFDictionary *)dictionary;
        [Static]
        [Export ("create:")]
        FSPDFStream Create (FSPDFDictionary dictionary);

        // -(FSPDFDictionary *)getDictionary;
        [Export ("getDictionary")]
        //[Verify (MethodToProperty)]
        FSPDFDictionary Dictionary { get; }

        // -(FSPDFStreamFilter)getStreamFilter;
        [Export ("getStreamFilter")]
        //[Verify (MethodToProperty)]
        FSPDFStreamFilter StreamFilter { get; }

        // -(unsigned long long)getDataSize:(BOOL)is_raw_data;
        [Export ("getDataSize:")]
        ulong GetDataSize (bool is_raw_data);

        // -(void)importData:(id<FSFileReaderCallback>)file_read stream_filter:(FSPDFStreamFilter)stream_filter;
        [Export ("importData:stream_filter:")]
        void ImportData (FSFileReaderCallback file_read, FSPDFStreamFilter stream_filter);

        // -(id<FSFileReaderCallback>)exportData:(BOOL)is_raw_data;
        [Export ("exportData:")]
        FSFileReaderCallback ExportData (bool is_raw_data);

        // -(NSData *)getData:(BOOL)is_raw_data;
        [Export ("getData:")]
        NSData GetData (bool is_raw_data);

        // -(void)setData:(NSData *)buffer;
        [Export ("setData:")]
        void SetData (NSData buffer);

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSPDFArray : FSPDFObject
    [BaseType (typeof(FSPDFObject))]
    [DisableDefaultCtor]
    interface FSPDFArray
    {
        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // +(FSPDFArray *)create;
        [Static]
        [Export ("create")]
        //[Verify (MethodToProperty)]
        FSPDFArray Create { get; }

        // +(FSPDFArray *)createFromMatrix:(FSMatrix2D *)matrix;
        [Static]
        [Export ("createFromMatrix:")]
        FSPDFArray CreateFromMatrix (FSMatrix2D matrix);

        // +(FSPDFArray *)createFromRect:(FSRectF *)rect;
        [Static]
        [Export ("createFromRect:")]
        FSPDFArray CreateFromRect (FSRectF rect);

        // -(int)getElementCount;
        [Export ("getElementCount")]
        //[Verify (MethodToProperty)]
        int ElementCount { get; }

        // -(FSPDFObject *)getElement:(int)index;
        [Export ("getElement:")]
        FSPDFObject GetElement (int index);

        // -(void)addElement:(FSPDFObject *)element;
        [Export ("addElement:")]
        void AddElement (FSPDFObject element);

        // -(void)addBoolean:(BOOL)boolean_value;
        [Export ("addBoolean:")]
        void AddBoolean (bool boolean_value);

        // -(void)addDateTime:(FSDateTime *)date_time;
        [Export ("addDateTime:")]
        void AddDateTime (FSDateTime date_time);

        // -(void)addFloat:(float)float_value;
        [Export ("addFloat:")]
        void AddFloat (float float_value);

        // -(void)addInteger:(int)integer_value;
        [Export ("addInteger:")]
        void AddInteger (int integer_value);

        // -(void)addMatrix:(FSMatrix2D *)matrix;
        [Export ("addMatrix:")]
        void AddMatrix (FSMatrix2D matrix);

        // -(void)addRect:(FSRectF *)rect;
        [Export ("addRect:")]
        void AddRect (FSRectF rect);

        // -(void)addName:(NSString *)name;
        [Export ("addName:")]
        void AddName (string name);

        // -(void)addString:(NSString *)new_string;
        [Export ("addString:")]
        void AddString (string new_string);

        // -(void)insertAt:(int)index element:(FSPDFObject *)element;
        [Export ("insertAt:element:")]
        void InsertAt (int index, FSPDFObject element);

        // -(void)setAt:(int)index element:(FSPDFObject *)element;
        [Export ("setAt:element:")]
        void SetAt (int index, FSPDFObject element);

        // -(void)removeAt:(int)index;
        [Export ("removeAt:")]
        void RemoveAt (int index);

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSPDFDictionary : FSPDFObject
    [BaseType (typeof(FSPDFObject))]
    [DisableDefaultCtor]
    interface FSPDFDictionary
    {
        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // +(FSPDFDictionary *)create;
        [Static]
        [Export ("create")]
        //[Verify (MethodToProperty)]
        FSPDFDictionary Create { get; }

        // -(BOOL)hasKey:(NSString *)key;
        [Export ("hasKey:")]
        bool HasKey (string key);

        // -(FSPDFObject *)getElement:(NSString *)key;
        [Export ("getElement:")]
        FSPDFObject GetElement (string key);

        // -(SWIGTYPE_p_void *)moveNext:(SWIGTYPE_p_void *)position;
        [Export ("moveNext:")]
        SWIGTYPE_p_void MoveNext (SWIGTYPE_p_void position);

        // -(NSString *)getKey:(SWIGTYPE_p_void *)position;
        [Export ("getKey:")]
        string GetKey (SWIGTYPE_p_void position);

        // -(FSPDFObject *)getValue:(SWIGTYPE_p_void *)position;
        [Export ("getValue:")]
        FSPDFObject GetValue (SWIGTYPE_p_void position);

        // -(void)setAt:(NSString *)key pdf_object:(FSPDFObject *)pdf_object;
        [Export ("setAt:pdf_object:")]
        void SetAt (string key, FSPDFObject pdf_object);

        // -(void)setAtBoolean:(NSString *)key value:(BOOL)value;
        [Export ("setAtBoolean:value:")]
        void SetAtBoolean (string key, bool value);

        // -(void)setAtDateTime:(NSString *)key value:(FSDateTime *)value;
        [Export ("setAtDateTime:value:")]
        void SetAtDateTime (string key, FSDateTime value);

        // -(void)setAtFloat:(NSString *)key value:(float)value;
        [Export ("setAtFloat:value:")]
        void SetAtFloat (string key, float value);

        // -(void)setAtInteger:(NSString *)key value:(int)value;
        [Export ("setAtInteger:value:")]
        void SetAtInteger (string key, int value);

        // -(void)setAtMatrix:(NSString *)key value:(FSMatrix2D *)value;
        [Export ("setAtMatrix:value:")]
        void SetAtMatrix (string key, FSMatrix2D value);

        // -(void)setAtRect:(NSString *)key value:(FSRectF *)value;
        [Export ("setAtRect:value:")]
        void SetAtRect (string key, FSRectF value);

        // -(void)setAtName:(NSString *)key value:(NSString *)value;
        [Export ("setAtName:value:")]
        void SetAtName (string key, string value);

        // -(void)setAtString:(NSString *)key value:(NSString *)value;
        [Export ("setAtString:value:")]
        void SetAtString (string key, string value);

        // -(void)removeAt:(NSString *)key;
        [Export ("removeAt:")]
        void RemoveAt (string key);

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSPDFNumberTree : FSBase
    [BaseType (typeof(FSBase))]
    [DisableDefaultCtor]
    interface FSPDFNumberTree
    {
        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(id)initWithDocument:(FSPDFDoc *)document type:(FSPDFNumberTreeType)type;
        [Export ("initWithDocument:type:")]
        IntPtr Constructor (FSPDFDoc document, FSPDFNumberTreeType type);

        // -(id)initWithOther:(FSPDFNumberTree *)other;
        [Export ("initWithOther:")]
        IntPtr Constructor (FSPDFNumberTree other);

        // -(BOOL)isEmpty;
        [Export ("isEmpty")]
        //[Verify (MethodToProperty)]
        bool IsEmpty { get; }

        // -(FSPDFNumberTreeType)getType;
        [Export ("getType")]
        //[Verify (MethodToProperty)]
        FSPDFNumberTreeType Type { get; }

        // -(BOOL)hasNumber:(int)number;
        [Export ("hasNumber:")]
        bool HasNumber (int number);

        // -(FSPDFObject *)getObj:(int)number;
        [Export ("getObj:")]
        FSPDFObject GetObj (int number);

        // -(BOOL)setObj:(int)number pdf_object:(FSPDFObject *)pdf_object;
        [Export ("setObj:pdf_object:")]
        bool SetObj (int number, FSPDFObject pdf_object);

        // -(BOOL)removeObj:(int)number;
        [Export ("removeObj:")]
        bool RemoveObj (int number);

        // -(BOOL)removeAllObjs;
        [Export ("removeAllObjs")]
        //[Verify (MethodToProperty)]
        bool RemoveAllObjs { get; }

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSRendition : FSBase
    [BaseType (typeof(FSBase))]
    [DisableDefaultCtor]
    interface FSRendition
    {
        // @property (getter = getRenditionName, nonatomic, weak) NSString * renditionName;
        [Export ("renditionName", ArgumentSemantic.Weak)]
        string RenditionName { [Bind ("getRenditionName")] get; set; }

        // @property (getter = getMediaClipName, nonatomic, weak) NSString * mediaClipName;
        [Export ("mediaClipName", ArgumentSemantic.Weak)]
        string MediaClipName { [Bind ("getMediaClipName")] get; set; }

        // @property (getter = getMediaClipFile, nonatomic, weak) FSFileSpec * mediaClipFile;
        [Export ("mediaClipFile", ArgumentSemantic.Weak)]
        FSFileSpec MediaClipFile { [Bind ("getMediaClipFile")] get; set; }

        // @property (getter = getMediaClipContentType, nonatomic, weak) NSString * mediaClipContentType;
        [Export ("mediaClipContentType", ArgumentSemantic.Weak)]
        string MediaClipContentType { [Bind ("getMediaClipContentType")] get; set; }

        // @property (getter = getPermission, nonatomic) FSRenditionMediaPermission permission;
        [Export ("permission", ArgumentSemantic.Assign)]
        FSRenditionMediaPermission Permission { [Bind ("getPermission")] get; set; }

        // @property (getter = getMediaDescriptions, nonatomic, weak) NSArray<NSString *> * mediaDescriptions;
        [Export ("mediaDescriptions", ArgumentSemantic.Weak)]
        string[] MediaDescriptions { [Bind ("getMediaDescriptions")] get; set; }

        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(id)initWithPdf_doc:(FSPDFDoc *)pdf_doc rendition_dict:(FSPDFDictionary *)rendition_dict;
        [Export ("initWithPdf_doc:rendition_dict:")]
        IntPtr Constructor (FSPDFDoc pdf_doc, FSPDFDictionary rendition_dict);

        // -(id)initWithOther:(FSRendition *)other;
        [Export ("initWithOther:")]
        IntPtr Constructor (FSRendition other);

        // -(BOOL)isEmpty;
        [Export ("isEmpty")]
        //[Verify (MethodToProperty)]
        bool IsEmpty { get; }

        // -(FSPDFDictionary *)getDict;
        [Export ("getDict")]
        //[Verify (MethodToProperty)]
        FSPDFDictionary Dict { get; }

        // -(BOOL)hasMediaClip;
        [Export ("hasMediaClip")]
        //[Verify (MethodToProperty)]
        bool HasMediaClip { get; }

        // -(NSString *)getMediaBaseURL;
        [Export ("getMediaBaseURL")]
        //[Verify (MethodToProperty)]
        string MediaBaseURL { get; }

        // -(void)setMediaBaseURL:(NSString *)base_url opt_type:(FSRenditionMediaOptionType)opt_type;
        [Export ("setMediaBaseURL:opt_type:")]
        void SetMediaBaseURL (string base_url, FSRenditionMediaOptionType opt_type);

        // -(int)getMediaPlayerCount:(FSRenditionMediaPlayerType)type;
        [Export ("getMediaPlayerCount:")]
        int GetMediaPlayerCount (FSRenditionMediaPlayerType type);

        // -(FSMediaPlayer *)getMediaPlayer:(FSRenditionMediaPlayerType)type index:(int)index;
        [Export ("getMediaPlayer:index:")]
        FSMediaPlayer GetMediaPlayer (FSRenditionMediaPlayerType type, int index);

        // -(int)addMediaPlayer:(FSRenditionMediaPlayerType)type player:(FSMediaPlayer *)player;
        [Export ("addMediaPlayer:player:")]
        int AddMediaPlayer (FSRenditionMediaPlayerType type, FSMediaPlayer player);

        // -(void)removeMediaPlayer:(FSRenditionMediaPlayerType)type player:(FSMediaPlayer *)player;
        [Export ("removeMediaPlayer:player:")]
        void RemoveMediaPlayer (FSRenditionMediaPlayerType type, FSMediaPlayer player);

        // -(int)getVolume;
        [Export ("getVolume")]
        //[Verify (MethodToProperty)]
        int Volume { get; }

        // -(void)setVolume:(int)volume opt_type:(FSRenditionMediaOptionType)opt_type;
        [Export ("setVolume:opt_type:")]
        void SetVolume (int volume, FSRenditionMediaOptionType opt_type);

        // -(BOOL)isControlBarVisible;
        [Export ("isControlBarVisible")]
        //[Verify (MethodToProperty)]
        bool IsControlBarVisible { get; }

        // -(void)enableControlBarVisible:(BOOL)is_visible opt_type:(FSRenditionMediaOptionType)opt_type;
        [Export ("enableControlBarVisible:opt_type:")]
        void EnableControlBarVisible (bool is_visible, FSRenditionMediaOptionType opt_type);

        // -(FSRenditionMediaPlayerFitStyle)getFitStyle;
        [Export ("getFitStyle")]
        //[Verify (MethodToProperty)]
        FSRenditionMediaPlayerFitStyle FitStyle { get; }

        // -(void)setFitStyle:(FSRenditionMediaPlayerFitStyle)fit_style opt_type:(FSRenditionMediaOptionType)opt_type;
        [Export ("setFitStyle:opt_type:")]
        void SetFitStyle (FSRenditionMediaPlayerFitStyle fit_style, FSRenditionMediaOptionType opt_type);

        // -(int)getDuration;
        [Export ("getDuration")]
        //[Verify (MethodToProperty)]
        int Duration { get; }

        // -(void)setDuration:(int)duration opt_type:(FSRenditionMediaOptionType)opt_type;
        [Export ("setDuration:opt_type:")]
        void SetDuration (int duration, FSRenditionMediaOptionType opt_type);

        // -(BOOL)isAutoPlay;
        [Export ("isAutoPlay")]
        //[Verify (MethodToProperty)]
        bool IsAutoPlay { get; }

        // -(void)enableAutoPlay:(BOOL)is_auto_play opt_type:(FSRenditionMediaOptionType)opt_type;
        [Export ("enableAutoPlay:opt_type:")]
        void EnableAutoPlay (bool is_auto_play, FSRenditionMediaOptionType opt_type);

        // -(int)getRepeatCount;
        [Export ("getRepeatCount")]
        //[Verify (MethodToProperty)]
        int RepeatCount { get; }

        // -(void)setRepeatCount:(int)count opt_type:(FSRenditionMediaOptionType)opt_type;
        [Export ("setRepeatCount:opt_type:")]
        void SetRepeatCount (int count, FSRenditionMediaOptionType opt_type);

        // -(FSRenditionWindowType)getWindowType;
        [Export ("getWindowType")]
        //[Verify (MethodToProperty)]
        FSRenditionWindowType WindowType { get; }

        // -(void)setWindowType:(FSRenditionWindowType)window_type opt_type:(FSRenditionMediaOptionType)opt_type;
        [Export ("setWindowType:opt_type:")]
        void SetWindowType (FSRenditionWindowType window_type, FSRenditionMediaOptionType opt_type);

        // -(unsigned int)getBackgroundColor;
        [Export ("getBackgroundColor")]
        //[Verify (MethodToProperty)]
        uint BackgroundColor { get; }

        // -(void)setBackgroundColor:(unsigned int)color opt_type:(FSRenditionMediaOptionType)opt_type;
        [Export ("setBackgroundColor:opt_type:")]
        void SetBackgroundColor (uint color, FSRenditionMediaOptionType opt_type);

        // -(float)getBackgroundOpacity;
        [Export ("getBackgroundOpacity")]
        //[Verify (MethodToProperty)]
        float BackgroundOpacity { get; }

        // -(void)setBackgroundOpacity:(float)opacity opt_type:(FSRenditionMediaOptionType)opt_type;
        [Export ("setBackgroundOpacity:opt_type:")]
        void SetBackgroundOpacity (float opacity, FSRenditionMediaOptionType opt_type);

        // -(FSRenditionMonitorSpecifier)getMonitorSpecifier;
        [Export ("getMonitorSpecifier")]
        //[Verify (MethodToProperty)]
        FSRenditionMonitorSpecifier MonitorSpecifier { get; }

        // -(void)setMonitorSpecifier:(FSRenditionMonitorSpecifier)monitor_specifier opt_type:(FSRenditionMediaOptionType)opt_type;
        [Export ("setMonitorSpecifier:opt_type:")]
        void SetMonitorSpecifier (FSRenditionMonitorSpecifier monitor_specifier, FSRenditionMediaOptionType opt_type);

        // -(int)getFloatingWindowWidth;
        [Export ("getFloatingWindowWidth")]
        //[Verify (MethodToProperty)]
        int FloatingWindowWidth { get; }

        // -(int)getFloatingWindowHeight;
        [Export ("getFloatingWindowHeight")]
        //[Verify (MethodToProperty)]
        int FloatingWindowHeight { get; }

        // -(void)setFloatingWindowSize:(int)width height:(int)height opt_type:(FSRenditionMediaOptionType)opt_type;
        [Export ("setFloatingWindowSize:height:opt_type:")]
        void SetFloatingWindowSize (int width, int height, FSRenditionMediaOptionType opt_type);

        // -(FSRenditionFloatingWindowRelatedWindowType)getFloatingWindowRelatedWindowType;
        [Export ("getFloatingWindowRelatedWindowType")]
        //[Verify (MethodToProperty)]
        FSRenditionFloatingWindowRelatedWindowType FloatingWindowRelatedWindowType { get; }

        // -(void)setFloatingWindowRelatedWindowType:(FSRenditionFloatingWindowRelatedWindowType)window_type opt_type:(FSRenditionMediaOptionType)opt_type;
        [Export ("setFloatingWindowRelatedWindowType:opt_type:")]
        void SetFloatingWindowRelatedWindowType (FSRenditionFloatingWindowRelatedWindowType window_type, FSRenditionMediaOptionType opt_type);

        // -(FSPosition)getFloatingWindowPosition;
        [Export ("getFloatingWindowPosition")]
        //[Verify (MethodToProperty)]
        FSPosition FloatingWindowPosition { get; }

        // -(void)setFloatingWindowPosition:(FSPosition)position opt_type:(FSRenditionMediaOptionType)opt_type;
        [Export ("setFloatingWindowPosition:opt_type:")]
        void SetFloatingWindowPosition (FSPosition position, FSRenditionMediaOptionType opt_type);

        // -(FSRenditionFloatingWindowOffscreenEvent)getFloatingWindowOffscreenEvent;
        [Export ("getFloatingWindowOffscreenEvent")]
        //[Verify (MethodToProperty)]
        FSRenditionFloatingWindowOffscreenEvent FloatingWindowOffscreenEvent { get; }

        // -(void)setFloatingWindowOffscreenEvent:(FSRenditionFloatingWindowOffscreenEvent)offscreen_event opt_type:(FSRenditionMediaOptionType)opt_type;
        [Export ("setFloatingWindowOffscreenEvent:opt_type:")]
        void SetFloatingWindowOffscreenEvent (FSRenditionFloatingWindowOffscreenEvent offscreen_event, FSRenditionMediaOptionType opt_type);

        // -(BOOL)hasFloatingWindowTitleBar;
        [Export ("hasFloatingWindowTitleBar")]
        //[Verify (MethodToProperty)]
        bool HasFloatingWindowTitleBar { get; }

        // -(void)enableFloatingWindowTitleBar:(BOOL)is_visible opt_type:(FSRenditionMediaOptionType)opt_type;
        [Export ("enableFloatingWindowTitleBar:opt_type:")]
        void EnableFloatingWindowTitleBar (bool is_visible, FSRenditionMediaOptionType opt_type);

        // -(BOOL)hasFloatingWindowCloseButton;
        [Export ("hasFloatingWindowCloseButton")]
        //[Verify (MethodToProperty)]
        bool HasFloatingWindowCloseButton { get; }

        // -(void)enableFloatingWindowCloseButton:(BOOL)is_visible opt_type:(FSRenditionMediaOptionType)opt_type;
        [Export ("enableFloatingWindowCloseButton:opt_type:")]
        void EnableFloatingWindowCloseButton (bool is_visible, FSRenditionMediaOptionType opt_type);

        // -(FSRenditionFloatingWindowResizeType)getFloatingWindowResizeType;
        [Export ("getFloatingWindowResizeType")]
        //[Verify (MethodToProperty)]
        FSRenditionFloatingWindowResizeType FloatingWindowResizeType { get; }

        // -(void)setFloatingWindowResizeType:(FSRenditionFloatingWindowResizeType)resize_type opt_type:(FSRenditionMediaOptionType)opt_type;
        [Export ("setFloatingWindowResizeType:opt_type:")]
        void SetFloatingWindowResizeType (FSRenditionFloatingWindowResizeType resize_type, FSRenditionMediaOptionType opt_type);

        // -(NSArray<NSString *> *)getFloatingWindowTitles;
        [Export ("getFloatingWindowTitles")]
        //[Verify (MethodToProperty)]
        string[] FloatingWindowTitles { get; }

        // -(void)setFloatingWindowTitles:(NSArray<NSString *> *)titles opt_type:(FSRenditionMediaOptionType)opt_type;
        [Export ("setFloatingWindowTitles:opt_type:")]
        void SetFloatingWindowTitles (string[] titles, FSRenditionMediaOptionType opt_type);

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSMediaPlayer : FSBase
    [BaseType (typeof(FSBase))]
    [DisableDefaultCtor]
    interface FSMediaPlayer
    {
        // @property (getter = getSoftwareURI, nonatomic, weak) NSString * softwareURI;
        [Export ("softwareURI", ArgumentSemantic.Weak)]
        string SoftwareURI { [Bind ("getSoftwareURI")] get; set; }

        // @property (getter = getOSIdentifiers, nonatomic, weak) NSArray<NSData *> * oSIdentifiers;
        [Export ("oSIdentifiers", ArgumentSemantic.Weak)]
        NSData[] OSIdentifiers { [Bind ("getOSIdentifiers")] get; set; }

        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(id)initWithMedia_player_dict:(FSPDFDictionary *)media_player_dict;
        [Export ("initWithMedia_player_dict:")]
        IntPtr Constructor (FSPDFDictionary media_player_dict);

        // -(id)initWithOther:(FSMediaPlayer *)other;
        [Export ("initWithOther:")]
        IntPtr Constructor (FSMediaPlayer other);

        // -(BOOL)isEmpty;
        [Export ("isEmpty")]
        //[Verify (MethodToProperty)]
        bool IsEmpty { get; }

        // -(FSPDFDictionary *)getDict;
        [Export ("getDict")]
        //[Verify (MethodToProperty)]
        FSPDFDictionary Dict { get; }

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSDestination : FSBase
    [BaseType (typeof(FSBase))]
    [DisableDefaultCtor]
    interface FSDestination
    {
        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // +(FSDestination *)createXYZ:(FSPDFDoc *)document page_index:(int)page_index left:(float)left top:(float)top zoom_factor:(float)zoom_factor;
        [Static]
        [Export ("createXYZ:page_index:left:top:zoom_factor:")]
        FSDestination CreateXYZ (FSPDFDoc document, int page_index, float left, float top, float zoom_factor);

        // +(FSDestination *)createFitPage:(FSPDFDoc *)document page_index:(int)page_index;
        [Static]
        [Export ("createFitPage:page_index:")]
        FSDestination CreateFitPage (FSPDFDoc document, int page_index);

        // +(FSDestination *)createFitHorz:(FSPDFDoc *)document page_index:(int)page_index top:(float)top;
        [Static]
        [Export ("createFitHorz:page_index:top:")]
        FSDestination CreateFitHorz (FSPDFDoc document, int page_index, float top);

        // +(FSDestination *)createFitVert:(FSPDFDoc *)document page_index:(int)page_index left:(float)left;
        [Static]
        [Export ("createFitVert:page_index:left:")]
        FSDestination CreateFitVert (FSPDFDoc document, int page_index, float left);

        // +(FSDestination *)createFitRect:(FSPDFDoc *)document page_index:(int)page_index left:(float)left bottom:(float)bottom right:(float)right top:(float)top;
        [Static]
        [Export ("createFitRect:page_index:left:bottom:right:top:")]
        FSDestination CreateFitRect (FSPDFDoc document, int page_index, float left, float bottom, float right, float top);

        // +(FSDestination *)createFitBBox:(FSPDFDoc *)document page_index:(int)page_index;
        [Static]
        [Export ("createFitBBox:page_index:")]
        FSDestination CreateFitBBox (FSPDFDoc document, int page_index);

        // +(FSDestination *)createFitBHorz:(FSPDFDoc *)document page_index:(int)page_index top:(float)top;
        [Static]
        [Export ("createFitBHorz:page_index:top:")]
        FSDestination CreateFitBHorz (FSPDFDoc document, int page_index, float top);

        // +(FSDestination *)createFitBVert:(FSPDFDoc *)document page_index:(int)page_index left:(float)left;
        [Static]
        [Export ("createFitBVert:page_index:left:")]
        FSDestination CreateFitBVert (FSPDFDoc document, int page_index, float left);

        // +(FSDestination *)createFromPDFArray:(FSPDFDoc *)document pdf_array:(FSPDFArray *)pdf_array;
        [Static]
        [Export ("createFromPDFArray:pdf_array:")]
        FSDestination CreateFromPDFArray (FSPDFDoc document, FSPDFArray pdf_array);

        // -(id)initWithDest_array:(FSPDFArray *)dest_array;
        [Export ("initWithDest_array:")]
        IntPtr Constructor (FSPDFArray dest_array);

        // -(id)initWithOther:(FSDestination *)other;
        [Export ("initWithOther:")]
        IntPtr Constructor (FSDestination other);

        // -(BOOL)isEmpty;
        [Export ("isEmpty")]
        //[Verify (MethodToProperty)]
        bool IsEmpty { get; }

        // -(int)getPageIndex:(FSPDFDoc *)document;
        [Export ("getPageIndex:")]
        int GetPageIndex (FSPDFDoc document);

        // -(FSDestinationZoomMode)getZoomMode;
        [Export ("getZoomMode")]
        //[Verify (MethodToProperty)]
        FSDestinationZoomMode ZoomMode { get; }

        // -(float)getLeft;
        [Export ("getLeft")]
        //[Verify (MethodToProperty)]
        float Left { get; }

        // -(BOOL)isLeftNull;
        [Export ("isLeftNull")]
        //[Verify (MethodToProperty)]
        bool IsLeftNull { get; }

        // -(float)getTop;
        [Export ("getTop")]
        //[Verify (MethodToProperty)]
        float Top { get; }

        // -(BOOL)isTopNull;
        [Export ("isTopNull")]
        //[Verify (MethodToProperty)]
        bool IsTopNull { get; }

        // -(float)getRight;
        [Export ("getRight")]
        //[Verify (MethodToProperty)]
        float Right { get; }

        // -(float)getBottom;
        [Export ("getBottom")]
        //[Verify (MethodToProperty)]
        float Bottom { get; }

        // -(float)getZoomFactor;
        [Export ("getZoomFactor")]
        //[Verify (MethodToProperty)]
        float ZoomFactor { get; }

        // -(FSPDFArray *)getDestArray;
        [Export ("getDestArray")]
        //[Verify (MethodToProperty)]
        FSPDFArray DestArray { get; }

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSAction : FSBase
    [BaseType (typeof(FSBase))]
    interface FSAction
    {
        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // +(FSAction *)create:(FSPDFDoc *)document action_type:(FSActionType)action_type;
        [Static]
        [Export ("create:action_type:")]
        FSAction Create (FSPDFDoc document, FSActionType action_type);

        // -(id)initWithDocument:(FSPDFDoc *)document action_dict:(FSPDFDictionary *)action_dict;
        [Export ("initWithDocument:action_dict:")]
        IntPtr Constructor (FSPDFDoc document, FSPDFDictionary action_dict);

        // -(id)initWithAction:(FSAction *)action;
        [Export ("initWithAction:")]
        IntPtr Constructor (FSAction action);

        // -(BOOL)isEmpty;
        [Export ("isEmpty")]
        //[Verify (MethodToProperty)]
        bool IsEmpty { get; }

        // -(FSActionType)getType;
        [Export ("getType")]
        //[Verify (MethodToProperty)]
        FSActionType Type { get; }

        // -(FSPDFDoc *)getDocument;
        [Export ("getDocument")]
        //[Verify (MethodToProperty)]
        FSPDFDoc Document { get; }

        // -(FSPDFDictionary *)getDict;
        [Export ("getDict")]
        //[Verify (MethodToProperty)]
        FSPDFDictionary Dict { get; }

        // -(int)getSubActionCount;
        [Export ("getSubActionCount")]
        //[Verify (MethodToProperty)]
        int SubActionCount { get; }

        // -(FSAction *)getSubAction:(int)index;
        [Export ("getSubAction:")]
        FSAction GetSubAction (int index);

        // -(void)setSubAction:(int)index sub_action:(FSAction *)sub_action;
        [Export ("setSubAction:sub_action:")]
        void SetSubAction (int index, FSAction sub_action);

        // -(void)insertSubAction:(int)index sub_action:(FSAction *)sub_action;
        [Export ("insertSubAction:sub_action:")]
        void InsertSubAction (int index, FSAction sub_action);

        // -(void)removeSubAction:(int)index;
        [Export ("removeSubAction:")]
        void RemoveSubAction (int index);

        // -(void)removeAllSubActions;
        [Export ("removeAllSubActions")]
        void RemoveAllSubActions ();

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSGotoAction : FSAction
    [BaseType (typeof(FSAction))]
    [DisableDefaultCtor]
    interface FSGotoAction
    {
        // @property (getter = getDestination, nonatomic, weak) FSDestination * destination;
        [Export ("destination", ArgumentSemantic.Weak)]
        FSDestination Destination { [Bind ("getDestination")] get; set; }

        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(id)initWithAction:(FSAction *)action;
        [Export ("initWithAction:")]
        IntPtr Constructor (FSAction action);

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSURIAction : FSAction
    [BaseType (typeof(FSAction))]
    [DisableDefaultCtor]
    interface FSURIAction
    {
        // @property (getter = getURI, nonatomic, weak) NSString * uRI;
        [Export ("uRI", ArgumentSemantic.Weak)]
        string URI { [Bind ("getURI")] get; set; }

        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(id)initWithAction:(FSAction *)action;
        [Export ("initWithAction:")]
        IntPtr Constructor (FSAction action);

        // -(BOOL)isTrackPosition;
        [Export ("isTrackPosition")]
        //[Verify (MethodToProperty)]
        bool IsTrackPosition { get; }

        // -(void)setTrackPositionFlag:(BOOL)is_track_position;
        [Export ("setTrackPositionFlag:")]
        void SetTrackPositionFlag (bool is_track_position);

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSJavaScriptAction : FSAction
    [BaseType (typeof(FSAction))]
    [DisableDefaultCtor]
    interface FSJavaScriptAction
    {
        // @property (getter = getScript, nonatomic, weak) NSString * script;
        [Export ("script", ArgumentSemantic.Weak)]
        string Script { [Bind ("getScript")] get; set; }

        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(id)initWithAction:(FSAction *)action;
        [Export ("initWithAction:")]
        IntPtr Constructor (FSAction action);

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSNamedAction : FSAction
    [BaseType (typeof(FSAction))]
    [DisableDefaultCtor]
    interface FSNamedAction
    {
        // @property (getter = getName, nonatomic, weak) NSString * name;
        [Export ("name", ArgumentSemantic.Weak)]
        string Name { [Bind ("getName")] get; set; }

        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(id)initWithAction:(FSAction *)action;
        [Export ("initWithAction:")]
        IntPtr Constructor (FSAction action);

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSRemoteGotoAction : FSAction
    [BaseType (typeof(FSAction))]
    [DisableDefaultCtor]
    interface FSRemoteGotoAction
    {
        // @property (getter = getDestination, nonatomic, weak) FSDestination * destination;
        [Export ("destination", ArgumentSemantic.Weak)]
        FSDestination Destination { [Bind ("getDestination")] get; set; }

        // @property (getter = getDestinationName, nonatomic, weak) NSString * destinationName;
        [Export ("destinationName", ArgumentSemantic.Weak)]
        string DestinationName { [Bind ("getDestinationName")] get; set; }

        // @property (getter = getFileSpec, nonatomic, weak) FSFileSpec * fileSpec;
        [Export ("fileSpec", ArgumentSemantic.Weak)]
        FSFileSpec FileSpec { [Bind ("getFileSpec")] get; set; }

        // @property (getter = getNewWindowFlag, nonatomic) FSActionNewWindowFlag newWindowFlag;
        [Export ("newWindowFlag", ArgumentSemantic.Assign)]
        FSActionNewWindowFlag NewWindowFlag { [Bind ("getNewWindowFlag")] get; set; }

        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(id)initWithAction:(FSAction *)action;
        [Export ("initWithAction:")]
        IntPtr Constructor (FSAction action);

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSEmbeddedGotoTarget : FSBase
    [BaseType (typeof(FSBase))]
    [DisableDefaultCtor]
    interface FSEmbeddedGotoTarget
    {
        // @property (getter = getRelationship, nonatomic, weak) NSString * relationship;
        [Export ("relationship", ArgumentSemantic.Weak)]
        string Relationship { [Bind ("getRelationship")] get; set; }

        // @property (getter = getAttachedFileName, nonatomic, weak) NSString * attachedFileName;
        [Export ("attachedFileName", ArgumentSemantic.Weak)]
        string AttachedFileName { [Bind ("getAttachedFileName")] get; set; }

        // @property (getter = getPageIndex, nonatomic) int pageIndex;
        [Export ("pageIndex")]
        int PageIndex { [Bind ("getPageIndex")] get; set; }

        // @property (getter = getFileAttachmentAnnotIndex, nonatomic) int fileAttachmentAnnotIndex;
        [Export ("fileAttachmentAnnotIndex")]
        int FileAttachmentAnnotIndex { [Bind ("getFileAttachmentAnnotIndex")] get; set; }

        // @property (getter = getTarget, nonatomic, weak) FSEmbeddedGotoTarget * target;
        [Export ("target", ArgumentSemantic.Weak)]
        FSEmbeddedGotoTarget Target { [Bind ("getTarget")] get; set; }

        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(id)initWithDocument:(FSPDFDoc *)document;
        [Export ("initWithDocument:")]
        IntPtr Constructor (FSPDFDoc document);

        // -(id)initWithDocument:(FSPDFDoc *)document target_object:(FSPDFDictionary *)target_object;
        [Export ("initWithDocument:target_object:")]
        IntPtr Constructor (FSPDFDoc document, FSPDFDictionary target_object);

        // -(id)initWithAction:(FSEmbeddedGotoTarget *)action;
        [Export ("initWithAction:")]
        IntPtr Constructor (FSEmbeddedGotoTarget action);

        // -(FSPDFDictionary *)getDict;
        [Export ("getDict")]
        //[Verify (MethodToProperty)]
        FSPDFDictionary Dict { get; }

        // -(BOOL)isEmpty;
        [Export ("isEmpty")]
        //[Verify (MethodToProperty)]
        bool IsEmpty { get; }

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSEmbeddedGotoAction : FSAction
    [BaseType (typeof(FSAction))]
    [DisableDefaultCtor]
    interface FSEmbeddedGotoAction
    {
        // @property (getter = getDestination, nonatomic, weak) FSDestination * destination;
        [Export ("destination", ArgumentSemantic.Weak)]
        FSDestination Destination { [Bind ("getDestination")] get; set; }

        // @property (getter = getDestinationName, nonatomic, weak) NSString * destinationName;
        [Export ("destinationName", ArgumentSemantic.Weak)]
        string DestinationName { [Bind ("getDestinationName")] get; set; }

        // @property (getter = getRootFile, nonatomic, weak) FSFileSpec * rootFile;
        [Export ("rootFile", ArgumentSemantic.Weak)]
        FSFileSpec RootFile { [Bind ("getRootFile")] get; set; }

        // @property (getter = getNewWindowFlag, nonatomic) FSActionNewWindowFlag newWindowFlag;
        [Export ("newWindowFlag", ArgumentSemantic.Assign)]
        FSActionNewWindowFlag NewWindowFlag { [Bind ("getNewWindowFlag")] get; set; }

        // @property (getter = getTarget, nonatomic, weak) FSEmbeddedGotoTarget * target;
        [Export ("target", ArgumentSemantic.Weak)]
        FSEmbeddedGotoTarget Target { [Bind ("getTarget")] get; set; }

        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(id)initWithAction:(FSAction *)action;
        [Export ("initWithAction:")]
        IntPtr Constructor (FSAction action);

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSSubmitFormAction : FSAction
    [BaseType (typeof(FSAction))]
    [DisableDefaultCtor]
    interface FSSubmitFormAction
    {
        // @property (getter = getURL, nonatomic, weak) NSString * uRL;
        [Export ("uRL", ArgumentSemantic.Weak)]
        string URL { [Bind ("getURL")] get; set; }

        // @property (getter = getFieldNames, nonatomic, weak) NSArray<NSString *> * fieldNames;
        [Export ("fieldNames", ArgumentSemantic.Weak)]
        string[] FieldNames { [Bind ("getFieldNames")] get; set; }

        // @property (getter = getFlags, nonatomic) unsigned int flags;
        [Export ("flags")]
        uint Flags { [Bind ("getFlags")] get; set; }

        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(id)initWithAction:(FSAction *)action;
        [Export ("initWithAction:")]
        IntPtr Constructor (FSAction action);

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSResetFormAction : FSAction
    [BaseType (typeof(FSAction))]
    [DisableDefaultCtor]
    interface FSResetFormAction
    {
        // @property (getter = getFieldNames, nonatomic, weak) NSArray<NSString *> * fieldNames;
        [Export ("fieldNames", ArgumentSemantic.Weak)]
        string[] FieldNames { [Bind ("getFieldNames")] get; set; }

        // @property (getter = getFlags, nonatomic) unsigned int flags;
        [Export ("flags")]
        uint Flags { [Bind ("getFlags")] get; set; }

        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(id)initWithAction:(FSAction *)action;
        [Export ("initWithAction:")]
        IntPtr Constructor (FSAction action);

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSImportDataAction : FSAction
    [BaseType (typeof(FSAction))]
    [DisableDefaultCtor]
    interface FSImportDataAction
    {
        // @property (getter = getFDFFileSpec, nonatomic, weak) FSFileSpec * fDFFileSpec;
        [Export ("fDFFileSpec", ArgumentSemantic.Weak)]
        FSFileSpec FDFFileSpec { [Bind ("getFDFFileSpec")] get; set; }

        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(id)initWithAction:(FSAction *)action;
        [Export ("initWithAction:")]
        IntPtr Constructor (FSAction action);

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSHideAction : FSAction
    [BaseType (typeof(FSAction))]
    [DisableDefaultCtor]
    interface FSHideAction
    {
        // @property (getter = getFieldNames, nonatomic, weak) NSArray<NSString *> * fieldNames;
        [Export ("fieldNames", ArgumentSemantic.Weak)]
        string[] FieldNames { [Bind ("getFieldNames")] get; set; }

        // @property (getter = getHideState, nonatomic) BOOL hideState;
        [Export ("hideState")]
        bool HideState { [Bind ("getHideState")] get; set; }

        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(id)initWithAction:(FSAction *)action;
        [Export ("initWithAction:")]
        IntPtr Constructor (FSAction action);

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSLaunchAction : FSAction
    [BaseType (typeof(FSAction))]
    [DisableDefaultCtor]
    interface FSLaunchAction
    {
        // @property (getter = getFileSpec, nonatomic, weak) FSFileSpec * fileSpec;
        [Export ("fileSpec", ArgumentSemantic.Weak)]
        FSFileSpec FileSpec { [Bind ("getFileSpec")] get; set; }

        // @property (getter = getNewWindowFlag, nonatomic) FSActionNewWindowFlag newWindowFlag;
        [Export ("newWindowFlag", ArgumentSemantic.Assign)]
        FSActionNewWindowFlag NewWindowFlag { [Bind ("getNewWindowFlag")] get; set; }

        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(id)initWithAction:(FSAction *)action;
        [Export ("initWithAction:")]
        IntPtr Constructor (FSAction action);

        // -(NSString *)getWinFileName;
        [Export ("getWinFileName")]
        //[Verify (MethodToProperty)]
        string WinFileName { get; }

        // -(NSString *)getWinDefaultDirectory;
        [Export ("getWinDefaultDirectory")]
        //[Verify (MethodToProperty)]
        string WinDefaultDirectory { get; }

        // -(NSString *)getWinAppOperation;
        [Export ("getWinAppOperation")]
        //[Verify (MethodToProperty)]
        string WinAppOperation { get; }

        // -(NSString *)getWinAppParameter;
        [Export ("getWinAppParameter")]
        //[Verify (MethodToProperty)]
        string WinAppParameter { get; }

        // -(void)setWinLaunchParameter:(NSString *)file_name default_directory:(NSString *)default_directory operation:(NSString *)operation app_parameter:(NSString *)app_parameter;
        [Export ("setWinLaunchParameter:default_directory:operation:app_parameter:")]
        void SetWinLaunchParameter (string file_name, string default_directory, string operation, string app_parameter);

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSRenditionAction : FSAction
    [BaseType (typeof(FSAction))]
    [DisableDefaultCtor]
    interface FSRenditionAction
    {
        // @property (getter = getOperationType, nonatomic) FSRenditionActionOperationType operationType;
        [Export ("operationType", ArgumentSemantic.Assign)]
        FSRenditionActionOperationType OperationType { [Bind ("getOperationType")] get; set; }

        // @property (getter = getScreenAnnot, nonatomic, weak) FSScreen * screenAnnot;
        [Export ("screenAnnot", ArgumentSemantic.Weak)]
        FSScreen ScreenAnnot { [Bind ("getScreenAnnot")] get; set; }

        // @property (getter = getJavaScript, nonatomic, weak) NSString * javaScript;
        [Export ("javaScript", ArgumentSemantic.Weak)]
        string JavaScript { [Bind ("getJavaScript")] get; set; }

        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(id)initWithAction:(FSAction *)action;
        [Export ("initWithAction:")]
        IntPtr Constructor (FSAction action);

        // -(int)getRenditionCount;
        [Export ("getRenditionCount")]
        //[Verify (MethodToProperty)]
        int RenditionCount { get; }

        // -(FSRendition *)getRendition:(int)index;
        [Export ("getRendition:")]
        FSRendition GetRendition (int index);

        // -(void)insertRendition:(FSRendition *)rendition index:(int)index;
        [Export ("insertRendition:index:")]
        void InsertRendition (FSRendition rendition, int index);

        // -(void)removeRendition:(FSRendition *)rendition;
        [Export ("removeRendition:")]
        void RemoveRendition (FSRendition rendition);

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSAdditionalAction : FSBase
    [BaseType (typeof(FSBase))]
    [DisableDefaultCtor]
    interface FSAdditionalAction
    {
        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(id)initWithDoc:(FSPDFDoc *)doc pdf_dict:(FSPDFDictionary *)pdf_dict;
        [Export ("initWithDoc:pdf_dict:")]
        IntPtr Constructor (FSPDFDoc doc, FSPDFDictionary pdf_dict);

        // -(id)initWithField:(FSField *)field;
        [Export ("initWithField:")]
        IntPtr Constructor (FSField field);

        // -(id)initWithAnnot:(FSAnnot *)annot;
        [Export ("initWithAnnot:")]
        IntPtr Constructor (FSAnnot annot);

        // -(id)initWithOther:(FSAdditionalAction *)other;
        [Export ("initWithOther:")]
        IntPtr Constructor (FSAdditionalAction other);

        // -(BOOL)isEmpty;
        [Export ("isEmpty")]
        //[Verify (MethodToProperty)]
        bool IsEmpty { get; }

        // -(FSAction *)getAction:(FSAdditionalActionTriggerEvent)trigger;
        [Export ("getAction:")]
        FSAction GetAction (FSAdditionalActionTriggerEvent trigger);

        // -(void)setAction:(FSAdditionalActionTriggerEvent)trigger action:(FSAction *)action;
        [Export ("setAction:action:")]
        void SetAction (FSAdditionalActionTriggerEvent trigger, FSAction action);

        // -(BOOL)removeAction:(FSAdditionalActionTriggerEvent)trigger;
        [Export ("removeAction:")]
        bool RemoveAction (FSAdditionalActionTriggerEvent trigger);

        // -(BOOL)removeAllActions;
        [Export ("removeAllActions")]
        //[Verify (MethodToProperty)]
        bool RemoveAllActions { get; }

        // -(BOOL)doJSAction:(FSAdditionalActionTriggerEvent)trigger;
        [Export ("doJSAction:")]
        bool DoJSAction (FSAdditionalActionTriggerEvent trigger);

        // -(FSPDFDictionary *)getDict;
        [Export ("getDict")]
        //[Verify (MethodToProperty)]
        FSPDFDictionary Dict { get; }

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSDefaultAppearance : NSObject
    [BaseType (typeof(NSObject))]
    interface FSDefaultAppearance
    {
        // @property (getter = getFlags, nonatomic) unsigned int flags;
        [Export ("flags")]
        uint Flags { [Bind ("getFlags")] get; set; }

        // @property (getter = getText_size, nonatomic) float text_size;
        [Export ("text_size")]
        float Text_size { [Bind ("getText_size")] get; set; }

        // @property (getter = getText_color, nonatomic) unsigned int text_color;
        [Export ("text_color")]
        uint Text_color { [Bind ("getText_color")] get; set; }

        // @property (getter = getFont, nonatomic, weak) FSFont * font;
        [Export ("font", ArgumentSemantic.Weak)]
        FSFont Font { [Bind ("getFont")] get; set; }

        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(id)initWithFlags:(unsigned int)flags font:(FSFont *)font text_size:(float)text_size text_color:(unsigned int)text_color;
        [Export ("initWithFlags:font:text_size:text_color:")]
        IntPtr Constructor (uint flags, FSFont font, float text_size, uint text_color);

        // -(id)initWithDefault_appearance:(FSDefaultAppearance *)default_appearance;
        [Export ("initWithDefault_appearance:")]
        IntPtr Constructor (FSDefaultAppearance default_appearance);

        // -(void)set:(unsigned int)flags font:(FSFont *)font text_size:(float)text_size text_color:(unsigned int)text_color;
        [Export ("set:font:text_size:text_color:")]
        void Set (uint flags, FSFont font, float text_size, uint text_color);

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSBorderInfo : NSObject
    [BaseType (typeof(NSObject))]
    interface FSBorderInfo
    {
        // @property (getter = getWidth, nonatomic) float width;
        [Export ("width")]
        float Width { [Bind ("getWidth")] get; set; }

        // @property (getter = getStyle, nonatomic) FSBorderInfoStyle style;
        [Export ("style", ArgumentSemantic.Assign)]
        FSBorderInfoStyle Style { [Bind ("getStyle")] get; set; }

        // @property (getter = getCloud_intensity, nonatomic) float cloud_intensity;
        [Export ("cloud_intensity")]
        float Cloud_intensity { [Bind ("getCloud_intensity")] get; set; }

        // @property (getter = getDash_phase, nonatomic) float dash_phase;
        [Export ("dash_phase")]
        float Dash_phase { [Bind ("getDash_phase")] get; set; }

        // @property (getter = getDashes, nonatomic, weak) FSFloatArray * dashes;
        [Export ("dashes", ArgumentSemantic.Weak)]
        FSFloatArray Dashes { [Bind ("getDashes")] get; set; }

        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(id)initWithWidth:(float)width style:(FSBorderInfoStyle)style intensity:(float)intensity dash_phase:(float)dash_phase dashes:(FSFloatArray *)dashes;
        [Export ("initWithWidth:style:intensity:dash_phase:dashes:")]
        IntPtr Constructor (float width, FSBorderInfoStyle style, float intensity, float dash_phase, FSFloatArray dashes);

        // -(id)initWithBorder_info:(FSBorderInfo *)border_info;
        [Export ("initWithBorder_info:")]
        IntPtr Constructor (FSBorderInfo border_info);

        // -(void)set:(float)width style:(FSBorderInfoStyle)style intensity:(float)intensity dash_phase:(float)dash_phase dashes:(FSFloatArray *)dashes;
        [Export ("set:style:intensity:dash_phase:dashes:")]
        void Set (float width, FSBorderInfoStyle style, float intensity, float dash_phase, FSFloatArray dashes);

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSQuadPoints : NSObject
    [BaseType (typeof(NSObject))]
    interface FSQuadPoints
    {
        // @property (getter = getFirst, nonatomic, weak) FSPointF * first;
        [Export ("first", ArgumentSemantic.Weak)]
        FSPointF First { [Bind ("getFirst")] get; set; }

        // @property (getter = getSecond, nonatomic, weak) FSPointF * second;
        [Export ("second", ArgumentSemantic.Weak)]
        FSPointF Second { [Bind ("getSecond")] get; set; }

        // @property (getter = getThird, nonatomic, weak) FSPointF * third;
        [Export ("third", ArgumentSemantic.Weak)]
        FSPointF Third { [Bind ("getThird")] get; set; }

        // @property (getter = getFourth, nonatomic, weak) FSPointF * fourth;
        [Export ("fourth", ArgumentSemantic.Weak)]
        FSPointF Fourth { [Bind ("getFourth")] get; set; }

        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(id)initWithFirst:(FSPointF *)first second:(FSPointF *)second third:(FSPointF *)third fourth:(FSPointF *)fourth;
        [Export ("initWithFirst:second:third:fourth:")]
        IntPtr Constructor (FSPointF first, FSPointF second, FSPointF third, FSPointF fourth);

        // -(id)initWithQuad_points:(FSQuadPoints *)quad_points;
        [Export ("initWithQuad_points:")]
        IntPtr Constructor (FSQuadPoints quad_points);

        // -(void)set:(FSPointF *)first second:(FSPointF *)second third:(FSPointF *)third fourth:(FSPointF *)fourth;
        [Export ("set:second:third:fourth:")]
        void Set (FSPointF first, FSPointF second, FSPointF third, FSPointF fourth);

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSQuadPointsArray : NSObject
    [BaseType (typeof(NSObject))]
    interface FSQuadPointsArray
    {
        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(id)initWithArg0:(FSQuadPointsArray *)arg0;
        [Export ("initWithArg0:")]
        IntPtr Constructor (FSQuadPointsArray arg0);

        // -(unsigned long)getSize;
        [Export ("getSize")]
        //[Verify (MethodToProperty)]
        nuint Size { get; }

        // -(FSQuadPoints *)getAt:(unsigned long)index;
        [Export ("getAt:")]
        FSQuadPoints GetAt (nuint index);

        // -(void)add:(FSQuadPoints *)element;
        [Export ("add:")]
        void Add (FSQuadPoints element);

        // -(void)removeAt:(unsigned long)index;
        [Export ("removeAt:")]
        void RemoveAt (nuint index);

        // -(void)insertAt:(unsigned long)index element:(FSQuadPoints *)element;
        [Export ("insertAt:element:")]
        void InsertAt (nuint index, FSQuadPoints element);

        // -(void)removeAll;
        [Export ("removeAll")]
        void RemoveAll ();

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSIconFit : NSObject
    [BaseType (typeof(NSObject))]
    interface FSIconFit
    {
        // @property (getter = getScale_way_type, nonatomic) FSIconFitScaleWayType scale_way_type;
        [Export ("scale_way_type", ArgumentSemantic.Assign)]
        FSIconFitScaleWayType Scale_way_type { [Bind ("getScale_way_type")] get; set; }

        // @property (getter = getIs_proportional_scaling, nonatomic) BOOL is_proportional_scaling;
        [Export ("is_proportional_scaling")]
        bool Is_proportional_scaling { [Bind ("getIs_proportional_scaling")] get; set; }

        // @property (getter = getHorizontal_fraction, nonatomic) float horizontal_fraction;
        [Export ("horizontal_fraction")]
        float Horizontal_fraction { [Bind ("getHorizontal_fraction")] get; set; }

        // @property (getter = getVertical_fraction, nonatomic) float vertical_fraction;
        [Export ("vertical_fraction")]
        float Vertical_fraction { [Bind ("getVertical_fraction")] get; set; }

        // @property (getter = getFit_bounds, nonatomic) BOOL fit_bounds;
        [Export ("fit_bounds")]
        bool Fit_bounds { [Bind ("getFit_bounds")] get; set; }

        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(id)initWithType:(FSIconFitScaleWayType)type is_proportional_scaling:(BOOL)is_proportional_scaling horizontal_fraction:(float)horizontal_fraction vertical_fraction:(float)vertical_fraction fit_bounds:(BOOL)fit_bounds;
        [Export ("initWithType:is_proportional_scaling:horizontal_fraction:vertical_fraction:fit_bounds:")]
        IntPtr Constructor (FSIconFitScaleWayType type, bool is_proportional_scaling, float horizontal_fraction, float vertical_fraction, bool fit_bounds);

        // -(id)initWithIcon_fit:(FSIconFit *)icon_fit;
        [Export ("initWithIcon_fit:")]
        IntPtr Constructor (FSIconFit icon_fit);

        // -(void)set:(FSIconFitScaleWayType)type is_proportional_scaling:(BOOL)is_proportional_scaling horizontal_fraction:(float)horizontal_fraction vertical_fraction:(float)vertical_fraction fit_bounds:(BOOL)fit_bounds;
        [Export ("set:is_proportional_scaling:horizontal_fraction:vertical_fraction:fit_bounds:")]
        void Set (FSIconFitScaleWayType type, bool is_proportional_scaling, float horizontal_fraction, float vertical_fraction, bool fit_bounds);

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSAnnot : FSBase
    [BaseType (typeof(FSBase))]
    interface FSAnnot
    {
        // @property (getter = getContent, nonatomic, weak) NSString * content;
        [Export ("content", ArgumentSemantic.Weak)]
        string Content { [Bind ("getContent")] get; set; }

        // @property (getter = getModifiedDateTime, nonatomic, weak) FSDateTime * modifiedDateTime;
        [Export ("modifiedDateTime", ArgumentSemantic.Weak)]
        FSDateTime ModifiedDateTime { [Bind ("getModifiedDateTime")] get; set; }

        // @property (getter = getFlags, nonatomic) unsigned int flags;
        [Export ("flags")]
        uint Flags { [Bind ("getFlags")] get; set; }

        // @property (getter = getUniqueID, nonatomic, weak) NSString * uniqueID;
        [Export ("uniqueID", ArgumentSemantic.Weak)]
        string UniqueID { [Bind ("getUniqueID")] get; set; }

        // @property (getter = getBorderInfo, nonatomic, weak) FSBorderInfo * borderInfo;
        [Export ("borderInfo", ArgumentSemantic.Weak)]
        FSBorderInfo BorderInfo { [Bind ("getBorderInfo")] get; set; }

        // @property (getter = getBorderColor, nonatomic) unsigned int borderColor;
        [Export ("borderColor")]
        uint BorderColor { [Bind ("getBorderColor")] get; set; }

        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(id)initWithPage:(FSPDFPage *)page annot_dict:(FSPDFDictionary *)annot_dict;
        [Export ("initWithPage:annot_dict:")]
        IntPtr Constructor (FSPDFPage page, FSPDFDictionary annot_dict);

        // -(id)initWithAnnot:(FSAnnot *)annot;
        [Export ("initWithAnnot:")]
        IntPtr Constructor (FSAnnot annot);

        // -(BOOL)isEmpty;
        [Export ("isEmpty")]
        //[Verify (MethodToProperty)]
        bool IsEmpty { get; }

        // -(FSPDFPage *)getPage;
        [Export ("getPage")]
        //[Verify (MethodToProperty)]
        FSPDFPage Page { get; }

        // -(BOOL)isMarkup;
        [Export ("isMarkup")]
        //[Verify (MethodToProperty)]
        bool IsMarkup { get; }

        // -(FSAnnotType)getType;
        [Export ("getType")]
        //[Verify (MethodToProperty)]
        FSAnnotType Type { get; }

        // -(int)getIndex;
        [Export ("getIndex")]
        //[Verify (MethodToProperty)]
        int Index { get; }

        // -(FSRectF *)getRect;
        [Export ("getRect")]
        //[Verify (MethodToProperty)]
        FSRectF Rect { get; }

        // -(BOOL)move:(FSRectF *)rect;
        [Export ("move:")]
        bool Move (FSRectF rect);

        // -(BOOL)resetAppearanceStream;
        [Export ("resetAppearanceStream")]
        //[Verify (MethodToProperty)]
        bool ResetAppearanceStream { get; }

        // -(FSRectI *)getDeviceRect:(BOOL)is_transform_icon matrix:(FSMatrix2D *)matrix;
        [Export ("getDeviceRect:matrix:")]
        FSRectI GetDeviceRect (bool is_transform_icon, FSMatrix2D matrix);

        // -(FSPDFDictionary *)getDict;
        [Export ("getDict")]
        //[Verify (MethodToProperty)]
        FSPDFDictionary Dict { get; }

        // -(BOOL)removeProperty:(FSAnnotProperty)property;
        [Export ("removeProperty:")]
        bool RemoveProperty (FSAnnotProperty property);

        // -(FSPDFDictionary *)getOptionalContent;
        [Export ("getOptionalContent")]
        //[Verify (MethodToProperty)]
        FSPDFDictionary OptionalContent { get; }

        // -(FSPDFStream *)getAppearanceStream:(FSAnnotAppearanceType)type appearance_state:(NSString *)appearance_state;
        [Export ("getAppearanceStream:appearance_state:")]
        FSPDFStream GetAppearanceStream (FSAnnotAppearanceType type, string appearance_state);

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSAnnotArray : NSObject
    [BaseType (typeof(NSObject))]
    interface FSAnnotArray
    {
        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(id)initWithArg0:(FSAnnotArray *)arg0;
        [Export ("initWithArg0:")]
        IntPtr Constructor (FSAnnotArray arg0);

        // -(unsigned long)getSize;
        [Export ("getSize")]
        //[Verify (MethodToProperty)]
        nuint Size { get; }

        // -(FSAnnot *)getAt:(unsigned long)index;
        [Export ("getAt:")]
        FSAnnot GetAt (nuint index);

        // -(void)add:(FSAnnot *)element;
        [Export ("add:")]
        void Add (FSAnnot element);

        // -(void)removeAt:(unsigned long)index;
        [Export ("removeAt:")]
        void RemoveAt (nuint index);

        // -(void)insertAt:(unsigned long)index element:(FSAnnot *)element;
        [Export ("insertAt:element:")]
        void InsertAt (nuint index, FSAnnot element);

        // -(void)removeAll;
        [Export ("removeAll")]
        void RemoveAll ();

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSShadingColor : NSObject
    [BaseType (typeof(NSObject))]
    interface FSShadingColor
    {
        // @property (getter = getFirst_color, nonatomic) unsigned int first_color;
        [Export ("first_color")]
        uint First_color { [Bind ("getFirst_color")] get; set; }

        // @property (getter = getSecond_color, nonatomic) unsigned int second_color;
        [Export ("second_color")]
        uint Second_color { [Bind ("getSecond_color")] get; set; }

        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(id)initWithFirstcolor:(unsigned int)firstcolor secondcolor:(unsigned int)secondcolor;
        [Export ("initWithFirstcolor:secondcolor:")]
        IntPtr Constructor (uint firstcolor, uint secondcolor);

        // -(id)initWithShading_color:(FSShadingColor *)shading_color;
        [Export ("initWithShading_color:")]
        IntPtr Constructor (FSShadingColor shading_color);

        // -(void)set:(unsigned int)firstcolor secondcolor:(unsigned int)secondcolor;
        [Export ("set:secondcolor:")]
        void Set (uint firstcolor, uint secondcolor);

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSMarkupArray : NSObject
    [BaseType (typeof(NSObject))]
    interface FSMarkupArray
    {
        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(id)initWithArg0:(FSMarkupArray *)arg0;
        [Export ("initWithArg0:")]
        IntPtr Constructor (FSMarkupArray arg0);

        // -(unsigned long)getSize;
        [Export ("getSize")]
        //[Verify (MethodToProperty)]
        nuint Size { get; }

        // -(FSMarkup *)getAt:(unsigned long)index;
        [Export ("getAt:")]
        FSMarkup GetAt (nuint index);

        // -(void)add:(FSMarkup *)element;
        [Export ("add:")]
        void Add (FSMarkup element);

        // -(void)removeAt:(unsigned long)index;
        [Export ("removeAt:")]
        void RemoveAt (nuint index);

        // -(void)insertAt:(unsigned long)index element:(FSMarkup *)element;
        [Export ("insertAt:element:")]
        void InsertAt (nuint index, FSMarkup element);

        // -(void)removeAll;
        [Export ("removeAll")]
        void RemoveAll ();

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSMarkup : FSAnnot
    [BaseType (typeof(FSAnnot))]
    interface FSMarkup
    {
        // @property (getter = getPopup, nonatomic, weak) FSPopup * popup;
        [Export ("popup", ArgumentSemantic.Weak)]
        FSPopup Popup { [Bind ("getPopup")] get; set; }

        // @property (getter = getTitle, nonatomic, weak) NSString * title;
        [Export ("title", ArgumentSemantic.Weak)]
        string Title { [Bind ("getTitle")] get; set; }

        // @property (getter = getSubject, nonatomic, weak) NSString * subject;
        [Export ("subject", ArgumentSemantic.Weak)]
        string Subject { [Bind ("getSubject")] get; set; }

        // @property (getter = getOpacity, nonatomic) float opacity;
        [Export ("opacity")]
        float Opacity { [Bind ("getOpacity")] get; set; }

        // @property (getter = getIntent, nonatomic, weak) NSString * intent;
        [Export ("intent", ArgumentSemantic.Weak)]
        string Intent { [Bind ("getIntent")] get; set; }

        // @property (getter = getCreationDateTime, nonatomic, weak) FSDateTime * creationDateTime;
        [Export ("creationDateTime", ArgumentSemantic.Weak)]
        FSDateTime CreationDateTime { [Bind ("getCreationDateTime")] get; set; }

        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(id)initWithAnnot:(FSAnnot *)annot;
        [Export ("initWithAnnot:")]
        IntPtr Constructor (FSAnnot annot);

        // -(int)getReplyCount;
        [Export ("getReplyCount")]
        //[Verify (MethodToProperty)]
        int ReplyCount { get; }

        // -(FSNote *)getReply:(int)index;
        [Export ("getReply:")]
        FSNote GetReply (int index);

        // -(FSNote *)addReply;
        [Export ("addReply")]
        //[Verify (MethodToProperty)]
        FSNote AddReply { get; }

        // -(BOOL)removeReply:(int)index;
        [Export ("removeReply:")]
        bool RemoveReply (int index);

        // -(BOOL)removeAllReplies;
        [Export ("removeAllReplies")]
        //[Verify (MethodToProperty)]
        bool RemoveAllReplies { get; }

        // -(BOOL)isGrouped;
        [Export ("isGrouped")]
        //[Verify (MethodToProperty)]
        bool IsGrouped { get; }

        // -(FSMarkup *)getGroupHeader;
        [Export ("getGroupHeader")]
        //[Verify (MethodToProperty)]
        FSMarkup GroupHeader { get; }

        // -(FSMarkupArray *)getGroupElements;
        [Export ("getGroupElements")]
        //[Verify (MethodToProperty)]
        FSMarkupArray GroupElements { get; }

        // -(BOOL)ungroup;
        [Export ("ungroup")]
        //[Verify (MethodToProperty)]
        bool Ungroup { get; }

        // -(int)getStateAnnotCount:(FSMarkupStateModel)model;
        [Export ("getStateAnnotCount:")]
        int GetStateAnnotCount (FSMarkupStateModel model);

        // -(FSNote *)getStateAnnot:(FSMarkupStateModel)model index:(int)index;
        [Export ("getStateAnnot:index:")]
        FSNote GetStateAnnot (FSMarkupStateModel model, int index);

        // -(FSNote *)addStateAnnot:(FSMarkupStateModel)model state:(FSMarkupState)state;
        [Export ("addStateAnnot:state:")]
        FSNote AddStateAnnot (FSMarkupStateModel model, FSMarkupState state);

        // -(BOOL)removeAllStateAnnots;
        [Export ("removeAllStateAnnots")]
        //[Verify (MethodToProperty)]
        bool RemoveAllStateAnnots { get; }

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSNote : FSMarkup
    [BaseType (typeof(FSMarkup))]
    interface FSNote
    {
        // @property (getter = getOpenStatus, nonatomic) BOOL openStatus;
        [Export ("openStatus")]
        bool OpenStatus { [Bind ("getOpenStatus")] get; set; }

        // @property (getter = getIconName, nonatomic, weak) NSString * iconName;
        [Export ("iconName", ArgumentSemantic.Weak)]
        string IconName { [Bind ("getIconName")] get; set; }

        // @property (getter = getState, nonatomic) FSMarkupState state;
        [Export ("state", ArgumentSemantic.Assign)]
        FSMarkupState State { [Bind ("getState")] get; set; }

        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(id)initWithAnnot:(FSAnnot *)annot;
        [Export ("initWithAnnot:")]
        IntPtr Constructor (FSAnnot annot);

        // -(FSMarkup *)getReplyTo;
        [Export ("getReplyTo")]
        //[Verify (MethodToProperty)]
        FSMarkup ReplyTo { get; }

        // -(BOOL)isStateAnnot;
        [Export ("isStateAnnot")]
        //[Verify (MethodToProperty)]
        bool IsStateAnnot { get; }

        // -(FSMarkupStateModel)getStateModel;
        [Export ("getStateModel")]
        //[Verify (MethodToProperty)]
        FSMarkupStateModel StateModel { get; }

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSTextMarkup : FSMarkup
    [BaseType (typeof(FSMarkup))]
    interface FSTextMarkup
    {
        // @property (getter = getQuadPoints, nonatomic, weak) FSQuadPointsArray * quadPoints;
        [Export ("quadPoints", ArgumentSemantic.Weak)]
        FSQuadPointsArray QuadPoints { [Bind ("getQuadPoints")] get; set; }

        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(id)initWithAnnot:(FSAnnot *)annot;
        [Export ("initWithAnnot:")]
        IntPtr Constructor (FSAnnot annot);

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSHighlight : FSTextMarkup
    [BaseType (typeof(FSTextMarkup))]
    interface FSHighlight
    {
        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(id)initWithAnnot:(FSAnnot *)annot;
        [Export ("initWithAnnot:")]
        IntPtr Constructor (FSAnnot annot);

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSUnderline : FSTextMarkup
    [BaseType (typeof(FSTextMarkup))]
    interface FSUnderline
    {
        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(id)initWithAnnot:(FSAnnot *)annot;
        [Export ("initWithAnnot:")]
        IntPtr Constructor (FSAnnot annot);

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSStrikeOut : FSTextMarkup
    [BaseType (typeof(FSTextMarkup))]
    interface FSStrikeOut
    {
        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(id)initWithAnnot:(FSAnnot *)annot;
        [Export ("initWithAnnot:")]
        IntPtr Constructor (FSAnnot annot);

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSSquiggly : FSTextMarkup
    [BaseType (typeof(FSTextMarkup))]
    interface FSSquiggly
    {
        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(id)initWithAnnot:(FSAnnot *)annot;
        [Export ("initWithAnnot:")]
        IntPtr Constructor (FSAnnot annot);

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSLink : FSAnnot
    [BaseType (typeof(FSAnnot))]
    interface FSLink
    {
        // @property (getter = getQuadPoints, nonatomic, weak) FSQuadPointsArray * quadPoints;
        [Export ("quadPoints", ArgumentSemantic.Weak)]
        FSQuadPointsArray QuadPoints { [Bind ("getQuadPoints")] get; set; }

        // @property (getter = getHighlightingMode, nonatomic) FSAnnotHighlightingMode highlightingMode;
        [Export ("highlightingMode", ArgumentSemantic.Assign)]
        FSAnnotHighlightingMode HighlightingMode { [Bind ("getHighlightingMode")] get; set; }

        // @property (getter = getAction, nonatomic, weak) FSAction * action;
        [Export ("action", ArgumentSemantic.Weak)]
        FSAction Action { [Bind ("getAction")] get; set; }

        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(id)initWithAnnot:(FSAnnot *)annot;
        [Export ("initWithAnnot:")]
        IntPtr Constructor (FSAnnot annot);

        // -(BOOL)removeAction;
        [Export ("removeAction")]
        //[Verify (MethodToProperty)]
        bool RemoveAction { get; }

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSSquare : FSMarkup
    [BaseType (typeof(FSMarkup))]
    interface FSSquare
    {
        // @property (getter = getFillColor, nonatomic) unsigned int fillColor;
        [Export ("fillColor")]
        uint FillColor { [Bind ("getFillColor")] get; set; }

        // @property (getter = getInnerRect, nonatomic, weak) FSRectF * innerRect;
        [Export ("innerRect", ArgumentSemantic.Weak)]
        FSRectF InnerRect { [Bind ("getInnerRect")] get; set; }

        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(id)initWithAnnot:(FSAnnot *)annot;
        [Export ("initWithAnnot:")]
        IntPtr Constructor (FSAnnot annot);

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSCircle : FSMarkup
    [BaseType (typeof(FSMarkup))]
    interface FSCircle
    {
        // @property (getter = getFillColor, nonatomic) unsigned int fillColor;
        [Export ("fillColor")]
        uint FillColor { [Bind ("getFillColor")] get; set; }

        // @property (getter = getInnerRect, nonatomic, weak) FSRectF * innerRect;
        [Export ("innerRect", ArgumentSemantic.Weak)]
        FSRectF InnerRect { [Bind ("getInnerRect")] get; set; }

        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(id)initWithAnnot:(FSAnnot *)annot;
        [Export ("initWithAnnot:")]
        IntPtr Constructor (FSAnnot annot);

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSFreeText : FSMarkup
    [BaseType (typeof(FSMarkup))]
    interface FSFreeText
    {
        // @property (getter = getFillColor, nonatomic) unsigned int fillColor;
        [Export ("fillColor")]
        uint FillColor { [Bind ("getFillColor")] get; set; }

        // @property (getter = getAlignment, nonatomic) FSAlignment alignment;
        [Export ("alignment", ArgumentSemantic.Assign)]
        FSAlignment Alignment { [Bind ("getAlignment")] get; set; }

        // @property (getter = getInnerRect, nonatomic, weak) FSRectF * innerRect;
        [Export ("innerRect", ArgumentSemantic.Weak)]
        FSRectF InnerRect { [Bind ("getInnerRect")] get; set; }

        // @property (getter = getCalloutLineEndingStyle, nonatomic) FSMarkupEndingStyle calloutLineEndingStyle;
        [Export ("calloutLineEndingStyle", ArgumentSemantic.Assign)]
        FSMarkupEndingStyle CalloutLineEndingStyle { [Bind ("getCalloutLineEndingStyle")] get; set; }

        // @property (getter = getCalloutLinePoints, nonatomic, weak) FSPointFArray * calloutLinePoints;
        [Export ("calloutLinePoints", ArgumentSemantic.Weak)]
        FSPointFArray CalloutLinePoints { [Bind ("getCalloutLinePoints")] get; set; }

        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(id)initWithAnnot:(FSAnnot *)annot;
        [Export ("initWithAnnot:")]
        IntPtr Constructor (FSAnnot annot);

        // -(FSDefaultAppearance *)getDefaultAppearance;
        [Export ("getDefaultAppearance")]
        //[Verify (MethodToProperty)]
        FSDefaultAppearance DefaultAppearance { get; }

        // -(BOOL)setDefaultAppearance:(FSDefaultAppearance *)default_ap;
        [Export ("setDefaultAppearance:")]
        bool SetDefaultAppearance (FSDefaultAppearance default_ap);

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSLine : FSMarkup
    [BaseType (typeof(FSMarkup))]
    interface FSLine
    {
        // @property (getter = getLineStartStyle, nonatomic) FSMarkupEndingStyle lineStartStyle;
        [Export ("lineStartStyle", ArgumentSemantic.Assign)]
        FSMarkupEndingStyle LineStartStyle { [Bind ("getLineStartStyle")] get; set; }

        // @property (getter = getLineEndStyle, nonatomic) FSMarkupEndingStyle lineEndStyle;
        [Export ("lineEndStyle", ArgumentSemantic.Assign)]
        FSMarkupEndingStyle LineEndStyle { [Bind ("getLineEndStyle")] get; set; }

        // @property (getter = getStyleFillColor, nonatomic) unsigned int styleFillColor;
        [Export ("styleFillColor")]
        uint StyleFillColor { [Bind ("getStyleFillColor")] get; set; }

        // @property (getter = getStartPoint, nonatomic, weak) FSPointF * startPoint;
        [Export ("startPoint", ArgumentSemantic.Weak)]
        FSPointF StartPoint { [Bind ("getStartPoint")] get; set; }

        // @property (getter = getEndPoint, nonatomic, weak) FSPointF * endPoint;
        [Export ("endPoint", ArgumentSemantic.Weak)]
        FSPointF EndPoint { [Bind ("getEndPoint")] get; set; }

        // @property (getter = getCaptionPositionType, nonatomic) FSLineCapPos captionPositionType;
        [Export ("captionPositionType", ArgumentSemantic.Assign)]
        FSLineCapPos CaptionPositionType { [Bind ("getCaptionPositionType")] get; set; }

        // @property (getter = getCaptionOffset, nonatomic, weak) FSPointF * captionOffset;
        [Export ("captionOffset", ArgumentSemantic.Weak)]
        FSPointF CaptionOffset { [Bind ("getCaptionOffset")] get; set; }

        // @property (getter = getLeaderLineLength, nonatomic) float leaderLineLength;
        [Export ("leaderLineLength")]
        float LeaderLineLength { [Bind ("getLeaderLineLength")] get; set; }

        // @property (getter = getLeaderLineExtensionLength, nonatomic) float leaderLineExtensionLength;
        [Export ("leaderLineExtensionLength")]
        float LeaderLineExtensionLength { [Bind ("getLeaderLineExtensionLength")] get; set; }

        // @property (getter = getLeaderLineOffset, nonatomic) float leaderLineOffset;
        [Export ("leaderLineOffset")]
        float LeaderLineOffset { [Bind ("getLeaderLineOffset")] get; set; }

        // @property (getter = getMeasureRatio, nonatomic, weak) NSString * measureRatio;
        [Export ("measureRatio", ArgumentSemantic.Weak)]
        string MeasureRatio { [Bind ("getMeasureRatio")] get; set; }

        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(id)initWithAnnot:(FSAnnot *)annot;
        [Export ("initWithAnnot:")]
        IntPtr Constructor (FSAnnot annot);

        // -(BOOL)hasCaption;
        [Export ("hasCaption")]
        //[Verify (MethodToProperty)]
        bool HasCaption { get; }

        // -(void)enableCaption:(BOOL)cap;
        [Export ("enableCaption:")]
        void EnableCaption (bool cap);

        // -(void)setMeasureUnit:(int)measure_type unit:(NSString *)unit;
        [Export ("setMeasureUnit:unit:")]
        void SetMeasureUnit (int measure_type, string unit);

        // -(NSString *)getMeasureUnit:(int)measure_type;
        [Export ("getMeasureUnit:")]
        string GetMeasureUnit (int measure_type);

        // -(void)setMeasureConversionFactor:(int)measure_type factor:(float)factor;
        [Export ("setMeasureConversionFactor:factor:")]
        void SetMeasureConversionFactor (int measure_type, float factor);

        // -(float)getMeasureConversionFactor:(int)measure_type;
        [Export ("getMeasureConversionFactor:")]
        float GetMeasureConversionFactor (int measure_type);

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSInk : FSMarkup
    [BaseType (typeof(FSMarkup))]
    interface FSInk
    {
        // @property (getter = getInkList, nonatomic, weak) FSPath * inkList;
        [Export ("inkList", ArgumentSemantic.Weak)]
        FSPath InkList { [Bind ("getInkList")] get; set; }

        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(id)initWithAnnot:(FSAnnot *)annot;
        [Export ("initWithAnnot:")]
        IntPtr Constructor (FSAnnot annot);

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSStamp : FSMarkup
    [BaseType (typeof(FSMarkup))]
    interface FSStamp
    {
        // @property (getter = getIconName, nonatomic, weak) NSString * iconName;
        [Export ("iconName", ArgumentSemantic.Weak)]
        string IconName { [Bind ("getIconName")] get; set; }

        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(id)initWithAnnot:(FSAnnot *)annot;
        [Export ("initWithAnnot:")]
        IntPtr Constructor (FSAnnot annot);

        // -(void)setBitmap:(FSBitmap *)bitmap;
        [Export ("setBitmap:")]
        void SetBitmap (FSBitmap bitmap);

        // -(void)setImage:(FSImage *)image frame_index:(int)frame_index compress:(int)compress;
        [Export ("setImage:frame_index:compress:")]
        void SetImage (FSImage image, int frame_index, int compress);

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSScreen : FSAnnot
    [BaseType (typeof(FSAnnot))]
    interface FSScreen
    {
        // @property (getter = getMKDict, nonatomic, weak) FSPDFDictionary * mKDict;
        [Export ("mKDict", ArgumentSemantic.Weak)]
        FSPDFDictionary MKDict { [Bind ("getMKDict")] get; set; }

        // @property (getter = getRotation, nonatomic) FSRotation rotation;
        [Export ("rotation", ArgumentSemantic.Assign)]
        FSRotation Rotation { [Bind ("getRotation")] get; set; }

        // @property (getter = getOpacity, nonatomic) float opacity;
        [Export ("opacity")]
        float Opacity { [Bind ("getOpacity")] get; set; }

        // @property (getter = getTitle, nonatomic, weak) NSString * title;
        [Export ("title", ArgumentSemantic.Weak)]
        string Title { [Bind ("getTitle")] get; set; }

        // @property (getter = getAction, nonatomic, weak) FSAction * action;
        [Export ("action", ArgumentSemantic.Weak)]
        FSAction Action { [Bind ("getAction")] get; set; }

        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(id)initWithAnnot:(FSAnnot *)annot;
        [Export ("initWithAnnot:")]
        IntPtr Constructor (FSAnnot annot);

        // -(void)setImage:(FSImage *)image frame_index:(int)frame_index compress:(int)compress;
        [Export ("setImage:frame_index:compress:")]
        void SetImage (FSImage image, int frame_index, int compress);

        // -(void)removeAction;
        [Export ("removeAction")]
        void RemoveAction ();

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSPolygon : FSMarkup
    [BaseType (typeof(FSMarkup))]
    interface FSPolygon
    {
        // @property (getter = getFillColor, nonatomic) unsigned int fillColor;
        [Export ("fillColor")]
        uint FillColor { [Bind ("getFillColor")] get; set; }

        // @property (getter = getVertexes, nonatomic, weak) FSPointFArray * vertexes;
        [Export ("vertexes", ArgumentSemantic.Weak)]
        FSPointFArray Vertexes { [Bind ("getVertexes")] get; set; }

        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(id)initWithAnnot:(FSAnnot *)annot;
        [Export ("initWithAnnot:")]
        IntPtr Constructor (FSAnnot annot);

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSPolyLine : FSMarkup
    [BaseType (typeof(FSMarkup))]
    interface FSPolyLine
    {
        // @property (getter = getStyleFillColor, nonatomic) unsigned int styleFillColor;
        [Export ("styleFillColor")]
        uint StyleFillColor { [Bind ("getStyleFillColor")] get; set; }

        // @property (getter = getVertexes, nonatomic, weak) FSPointFArray * vertexes;
        [Export ("vertexes", ArgumentSemantic.Weak)]
        FSPointFArray Vertexes { [Bind ("getVertexes")] get; set; }

        // @property (getter = getLineStartStyle, nonatomic) FSMarkupEndingStyle lineStartStyle;
        [Export ("lineStartStyle", ArgumentSemantic.Assign)]
        FSMarkupEndingStyle LineStartStyle { [Bind ("getLineStartStyle")] get; set; }

        // @property (getter = getLineEndStyle, nonatomic) FSMarkupEndingStyle lineEndStyle;
        [Export ("lineEndStyle", ArgumentSemantic.Assign)]
        FSMarkupEndingStyle LineEndStyle { [Bind ("getLineEndStyle")] get; set; }

        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(id)initWithAnnot:(FSAnnot *)annot;
        [Export ("initWithAnnot:")]
        IntPtr Constructor (FSAnnot annot);

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSCaret : FSMarkup
    [BaseType (typeof(FSMarkup))]
    interface FSCaret
    {
        // @property (getter = getInnerRect, nonatomic, weak) FSRectF * innerRect;
        [Export ("innerRect", ArgumentSemantic.Weak)]
        FSRectF InnerRect { [Bind ("getInnerRect")] get; set; }

        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(id)initWithAnnot:(FSAnnot *)annot;
        [Export ("initWithAnnot:")]
        IntPtr Constructor (FSAnnot annot);

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSFileAttachment : FSMarkup
    [BaseType (typeof(FSMarkup))]
    interface FSFileAttachment
    {
        // @property (getter = getIconName, nonatomic, weak) NSString * iconName;
        [Export ("iconName", ArgumentSemantic.Weak)]
        string IconName { [Bind ("getIconName")] get; set; }

        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(id)initWithAnnot:(FSAnnot *)annot;
        [Export ("initWithAnnot:")]
        IntPtr Constructor (FSAnnot annot);

        // -(BOOL)setFileSpec:(FSFileSpec *)file_spec;
        [Export ("setFileSpec:")]
        bool SetFileSpec (FSFileSpec file_spec);

        // -(FSFileSpec *)getFileSpec;
        [Export ("getFileSpec")]
        //[Verify (MethodToProperty)]
        FSFileSpec FileSpec { get; }

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSPopup : FSAnnot
    [BaseType (typeof(FSAnnot))]
    interface FSPopup
    {
        // @property (getter = getOpenStatus, nonatomic) BOOL openStatus;
        [Export ("openStatus")]
        bool OpenStatus { [Bind ("getOpenStatus")] get; set; }

        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(id)initWithAnnot:(FSAnnot *)annot;
        [Export ("initWithAnnot:")]
        IntPtr Constructor (FSAnnot annot);

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSPSInk : FSAnnot
    [BaseType (typeof(FSAnnot))]
    interface FSPSInk
    {
        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(id)initWithAnnot:(FSAnnot *)annot;
        [Export ("initWithAnnot:")]
        IntPtr Constructor (FSAnnot annot);

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSWidget : FSAnnot
    [BaseType (typeof(FSAnnot))]
    interface FSWidget
    {
        // @property (getter = getHighlightingMode, nonatomic) FSAnnotHighlightingMode highlightingMode;
        [Export ("highlightingMode", ArgumentSemantic.Assign)]
        FSAnnotHighlightingMode HighlightingMode { [Bind ("getHighlightingMode")] get; set; }

        // @property (getter = getAction, nonatomic, weak) FSAction * action;
        [Export ("action", ArgumentSemantic.Weak)]
        FSAction Action { [Bind ("getAction")] get; set; }

        // @property (getter = getMKRotation, nonatomic) FSRotation mKRotation;
        [Export ("mKRotation", ArgumentSemantic.Assign)]
        FSRotation MKRotation { [Bind ("getMKRotation")] get; set; }

        // @property (getter = getMKBorderColor, nonatomic) unsigned int mKBorderColor;
        [Export ("mKBorderColor")]
        uint MKBorderColor { [Bind ("getMKBorderColor")] get; set; }

        // @property (getter = getMKBackgroundColor, nonatomic) unsigned int mKBackgroundColor;
        [Export ("mKBackgroundColor")]
        uint MKBackgroundColor { [Bind ("getMKBackgroundColor")] get; set; }

        // @property (getter = getMKNormalCaption, nonatomic, weak) NSString * mKNormalCaption;
        [Export ("mKNormalCaption", ArgumentSemantic.Weak)]
        string MKNormalCaption { [Bind ("getMKNormalCaption")] get; set; }

        // @property (getter = getMKRolloverCaption, nonatomic, weak) NSString * mKRolloverCaption;
        [Export ("mKRolloverCaption", ArgumentSemantic.Weak)]
        string MKRolloverCaption { [Bind ("getMKRolloverCaption")] get; set; }

        // @property (getter = getMKDownCaption, nonatomic, weak) NSString * mKDownCaption;
        [Export ("mKDownCaption", ArgumentSemantic.Weak)]
        string MKDownCaption { [Bind ("getMKDownCaption")] get; set; }

        // @property (getter = getMKNormalIconBitmap, nonatomic, weak) FSBitmap * mKNormalIconBitmap;
        [Export ("mKNormalIconBitmap", ArgumentSemantic.Weak)]
        FSBitmap MKNormalIconBitmap { [Bind ("getMKNormalIconBitmap")] get; set; }

        // @property (getter = getMKRolloverIconBitmap, nonatomic, weak) FSBitmap * mKRolloverIconBitmap;
        [Export ("mKRolloverIconBitmap", ArgumentSemantic.Weak)]
        FSBitmap MKRolloverIconBitmap { [Bind ("getMKRolloverIconBitmap")] get; set; }

        // @property (getter = getMKDownIconBitmap, nonatomic, weak) FSBitmap * mKDownIconBitmap;
        [Export ("mKDownIconBitmap", ArgumentSemantic.Weak)]
        FSBitmap MKDownIconBitmap { [Bind ("getMKDownIconBitmap")] get; set; }

        // @property (getter = getMKIconFit, nonatomic, weak) FSIconFit * mKIconFit;
        [Export ("mKIconFit", ArgumentSemantic.Weak)]
        FSIconFit MKIconFit { [Bind ("getMKIconFit")] get; set; }

        // @property (getter = getMKIconCaptionRelation, nonatomic) FSAnnotMKIconCaptionRelation mKIconCaptionRelation;
        [Export ("mKIconCaptionRelation", ArgumentSemantic.Assign)]
        FSAnnotMKIconCaptionRelation MKIconCaptionRelation { [Bind ("getMKIconCaptionRelation")] get; set; }

        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(id)initWithAnnot:(FSAnnot *)annot;
        [Export ("initWithAnnot:")]
        IntPtr Constructor (FSAnnot annot);

        // -(FSField *)getField;
        [Export ("getField")]
        //[Verify (MethodToProperty)]
        FSField Field { get; }

        // -(FSControl *)getControl;
        [Export ("getControl")]
        //[Verify (MethodToProperty)]
        FSControl Control { get; }

        // -(void)removeAction;
        [Export ("removeAction")]
        void RemoveAction ();

        // -(BOOL)hasMKEntry:(FSAnnotMKEntry)mk_entry;
        [Export ("hasMKEntry:")]
        bool HasMKEntry (FSAnnotMKEntry mk_entry);

        // -(void)removeMKEntry:(FSAnnotMKEntry)mk_entry;
        [Export ("removeMKEntry:")]
        void RemoveMKEntry (FSAnnotMKEntry mk_entry);

        // -(void)setMKNormalIconImage:(FSImage *)image frame_index:(int)frame_index;
        [Export ("setMKNormalIconImage:frame_index:")]
        void SetMKNormalIconImage (FSImage image, int frame_index);

        // -(void)setMKRolloverIconImage:(FSImage *)image frame_index:(int)frame_index;
        [Export ("setMKRolloverIconImage:frame_index:")]
        void SetMKRolloverIconImage (FSImage image, int frame_index);

        // -(void)setMKDownIconImage:(FSImage *)image frame_index:(int)frame_index;
        [Export ("setMKDownIconImage:frame_index:")]
        void SetMKDownIconImage (FSImage image, int frame_index);

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSRedact : FSMarkup
    [BaseType (typeof(FSMarkup))]
    interface FSRedact
    {
        // @property (getter = getFillColor, nonatomic) unsigned int fillColor;
        [Export ("fillColor")]
        uint FillColor { [Bind ("getFillColor")] get; set; }

        // @property (getter = getApplyFillColor, nonatomic) unsigned int applyFillColor;
        [Export ("applyFillColor")]
        uint ApplyFillColor { [Bind ("getApplyFillColor")] get; set; }

        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(id)initWithAnnot:(FSAnnot *)annot;
        [Export ("initWithAnnot:")]
        IntPtr Constructor (FSAnnot annot);

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSBookmark : FSBase
    [BaseType (typeof(FSBase))]
    [DisableDefaultCtor]
    interface FSBookmark
    {
        // @property (getter = getDestination, nonatomic, weak) FSDestination * destination;
        [Export ("destination", ArgumentSemantic.Weak)]
        FSDestination Destination { [Bind ("getDestination")] get; set; }

        // @property (getter = getTitle, nonatomic, weak) NSString * title;
        [Export ("title", ArgumentSemantic.Weak)]
        string Title { [Bind ("getTitle")] get; set; }

        // @property (getter = getColor, nonatomic) unsigned int color;
        [Export ("color")]
        uint Color { [Bind ("getColor")] get; set; }

        // @property (getter = getStyle, nonatomic) unsigned int style;
        [Export ("style")]
        uint Style { [Bind ("getStyle")] get; set; }

        // @property (getter = getAction, nonatomic, weak) FSAction * action;
        [Export ("action", ArgumentSemantic.Weak)]
        FSAction Action { [Bind ("getAction")] get; set; }

        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(id)initWithPdf_doc:(FSPDFDoc *)pdf_doc bookmark_dict:(FSPDFDictionary *)bookmark_dict;
        [Export ("initWithPdf_doc:bookmark_dict:")]
        IntPtr Constructor (FSPDFDoc pdf_doc, FSPDFDictionary bookmark_dict);

        // -(id)initWithOther:(FSBookmark *)other;
        [Export ("initWithOther:")]
        IntPtr Constructor (FSBookmark other);

        // -(BOOL)isEmpty;
        [Export ("isEmpty")]
        //[Verify (MethodToProperty)]
        bool IsEmpty { get; }

        // -(FSBookmark *)getParent;
        [Export ("getParent")]
        //[Verify (MethodToProperty)]
        FSBookmark Parent { get; }

        // -(BOOL)hasChild;
        [Export ("hasChild")]
        //[Verify (MethodToProperty)]
        bool HasChild { get; }

        // -(FSBookmark *)getFirstChild;
        [Export ("getFirstChild")]
        //[Verify (MethodToProperty)]
        FSBookmark FirstChild { get; }

        // -(FSBookmark *)getNextSibling;
        [Export ("getNextSibling")]
        //[Verify (MethodToProperty)]
        FSBookmark NextSibling { get; }

        // -(FSBookmark *)insert:(NSString *)title position:(FSBookmarkPosition)position;
        [Export ("insert:position:")]
        FSBookmark Insert (string title, FSBookmarkPosition position);

        // -(BOOL)moveTo:(FSBookmark *)dest_bookmark position:(FSBookmarkPosition)position;
        [Export ("moveTo:position:")]
        bool MoveTo (FSBookmark dest_bookmark, FSBookmarkPosition position);

        // -(BOOL)removeAction;
        [Export ("removeAction")]
        //[Verify (MethodToProperty)]
        bool RemoveAction { get; }

        // -(BOOL)isRoot;
        [Export ("isRoot")]
        //[Verify (MethodToProperty)]
        bool IsRoot { get; }

        // -(BOOL)isFirstChild;
        [Export ("isFirstChild")]
        //[Verify (MethodToProperty)]
        bool IsFirstChild { get; }

        // -(BOOL)isLastChild;
        [Export ("isLastChild")]
        //[Verify (MethodToProperty)]
        bool IsLastChild { get; }

        // -(FSPDFDictionary *)getDict;
        [Export ("getDict")]
        //[Verify (MethodToProperty)]
        FSPDFDictionary Dict { get; }

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSAssociatedFiles : FSBase
    [BaseType (typeof(FSBase))]
    [DisableDefaultCtor]
    interface FSAssociatedFiles
    {
        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(id)initWithOther:(FSAssociatedFiles *)other;
        [Export ("initWithOther:")]
        IntPtr Constructor (FSAssociatedFiles other);

        // -(id)initWithPdf_doc:(FSPDFDoc *)pdf_doc;
        [Export ("initWithPdf_doc:")]
        IntPtr Constructor (FSPDFDoc pdf_doc);

        // -(BOOL)isEmpty;
        [Export ("isEmpty")]
        //[Verify (MethodToProperty)]
        bool IsEmpty { get; }

        // -(int)getAssociatedFilesCount:(FSPDFObject *)pdf_object;
        [Export ("getAssociatedFilesCount:")]
        int GetAssociatedFilesCount (FSPDFObject pdf_object);

        // -(FSFileSpec *)getAssociatedFile:(FSPDFObject *)pdf_object index:(int)index;
        [Export ("getAssociatedFile:index:")]
        FSFileSpec GetAssociatedFile (FSPDFObject pdf_object, int index);

        // -(void)associateFile:(FSPDFObject *)pdf_object file_spec:(FSFileSpec *)file_spec;
        [Export ("associateFile:file_spec:")]
        void AssociateFile (FSPDFObject pdf_object, FSFileSpec file_spec);

        // -(void)removeAssociatedFile:(FSPDFObject *)pdf_object index:(int)index;
        [Export ("removeAssociatedFile:index:")]
        void RemoveAssociatedFile (FSPDFObject pdf_object, int index);

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSAttachments : FSBase
    [BaseType (typeof(FSBase))]
    [DisableDefaultCtor]
    interface FSAttachments
    {
        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(id)initWithDoc:(FSPDFDoc *)doc nametree:(FSPDFNameTree *)nametree;
        [Export ("initWithDoc:nametree:")]
        IntPtr Constructor (FSPDFDoc doc, FSPDFNameTree nametree);

        // -(id)initWithOther:(FSAttachments *)other;
        [Export ("initWithOther:")]
        IntPtr Constructor (FSAttachments other);

        // -(BOOL)isEmpty;
        [Export ("isEmpty")]
        //[Verify (MethodToProperty)]
        bool IsEmpty { get; }

        // -(int)getCount;
        [Export ("getCount")]
        //[Verify (MethodToProperty)]
        int Count { get; }

        // -(NSString *)getKey:(int)index;
        [Export ("getKey:")]
        string GetKey (int index);

        // -(FSFileSpec *)getEmbeddedFile:(NSString *)key;
        [Export ("getEmbeddedFile:")]
        FSFileSpec GetEmbeddedFile (string key);

        // -(BOOL)setEmbeddedFile:(NSString *)key file_spec:(FSFileSpec *)file_spec;
        [Export ("setEmbeddedFile:file_spec:")]
        bool SetEmbeddedFile (string key, FSFileSpec file_spec);

        // -(BOOL)addEmbeddedFile:(NSString *)key file_spec:(FSFileSpec *)file_spec;
        [Export ("addEmbeddedFile:file_spec:")]
        bool AddEmbeddedFile (string key, FSFileSpec file_spec);

        // -(BOOL)addFromFilePath:(NSString *)key file_path:(NSString *)file_path;
        [Export ("addFromFilePath:file_path:")]
        bool AddFromFilePath (string key, string file_path);

        // -(BOOL)removeEmbeddedFile:(NSString *)key;
        [Export ("removeEmbeddedFile:")]
        bool RemoveEmbeddedFile (string key);

        // -(BOOL)removeAllEmbeddedFiles;
        [Export ("removeAllEmbeddedFiles")]
        //[Verify (MethodToProperty)]
        bool RemoveAllEmbeddedFiles { get; }

        // -(BOOL)extractEmbeddedFileTo:(NSString *)key dst_file_path:(NSString *)dst_file_path;
        [Export ("extractEmbeddedFileTo:dst_file_path:")]
        bool ExtractEmbeddedFileTo (string key, string dst_file_path);

        // -(FSPDFNameTree *)getNameTree;
        [Export ("getNameTree")]
        //[Verify (MethodToProperty)]
        FSPDFNameTree NameTree { get; }

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSWrapperData : NSObject
    [BaseType (typeof(NSObject))]
    interface FSWrapperData
    {
        // @property (getter = getVersion, nonatomic) int version;
        [Export ("version")]
        int Version { [Bind ("getVersion")] get; set; }

        // @property (getter = getType, nonatomic, weak) NSString * type;
        [Export ("type", ArgumentSemantic.Weak)]
        string Type { [Bind ("getType")] get; set; }

        // @property (getter = getApp_id, nonatomic, weak) NSString * app_id;
        [Export ("app_id", ArgumentSemantic.Weak)]
        string App_id { [Bind ("getApp_id")] get; set; }

        // @property (getter = getUri, nonatomic, weak) NSString * uri;
        [Export ("uri", ArgumentSemantic.Weak)]
        string Uri { [Bind ("getUri")] get; set; }

        // @property (getter = getDescription, nonatomic, weak) NSString * description;
        [Export ("description", ArgumentSemantic.Weak)]
        string Description { [Bind ("getDescription")] get; set; }

        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(id)initWithVersion:(int)version type:(NSString *)type app_id:(NSString *)app_id uri:(NSString *)uri description:(NSString *)description;
        [Export ("initWithVersion:type:app_id:uri:description:")]
        IntPtr Constructor (int version, string type, string app_id, string uri, string description);

        // -(id)initWithWrapper_data:(FSWrapperData *)wrapper_data;
        [Export ("initWithWrapper_data:")]
        IntPtr Constructor (FSWrapperData wrapper_data);

        // -(void)set:(int)version type:(NSString *)type app_id:(NSString *)app_id uri:(NSString *)uri description:(NSString *)description;
        [Export ("set:type:app_id:uri:description:")]
        void Set (int version, string type, string app_id, string uri, string description);

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSPayLoadData : NSObject
    [BaseType (typeof(NSObject))]
    interface FSPayLoadData
    {
        // @property (getter = getVersion, nonatomic) float version;
        [Export ("version")]
        float Version { [Bind ("getVersion")] get; set; }

        // @property (getter = getCrypto_filter, nonatomic, weak) NSString * crypto_filter;
        [Export ("crypto_filter", ArgumentSemantic.Weak)]
        string Crypto_filter { [Bind ("getCrypto_filter")] get; set; }

        // @property (getter = getFile_name, nonatomic, weak) NSString * file_name;
        [Export ("file_name", ArgumentSemantic.Weak)]
        string File_name { [Bind ("getFile_name")] get; set; }

        // @property (getter = getFile_size, nonatomic) long long file_size;
        [Export ("file_size")]
        long File_size { [Bind ("getFile_size")] get; set; }

        // @property (getter = getDescription, nonatomic, weak) NSString * description;
        [Export ("description", ArgumentSemantic.Weak)]
        string Description { [Bind ("getDescription")] get; set; }

        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(id)initWithPayload_data:(FSPayLoadData *)payload_data;
        [Export ("initWithPayload_data:")]
        IntPtr Constructor (FSPayLoadData payload_data);

        // -(void)set:(float)version crypto_filter:(NSString *)crypto_filter file_name:(NSString *)file_name file_size:(long long)file_size description:(NSString *)description;
        [Export ("set:crypto_filter:file_name:file_size:description:")]
        void Set (float version, string crypto_filter, string file_name, long file_size, string description);

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSPageBasicInfo : NSObject
    [BaseType (typeof(NSObject))]
    interface FSPageBasicInfo
    {
        // @property (getter = getWidth, nonatomic) float width;
        [Export ("width")]
        float Width { [Bind ("getWidth")] get; set; }

        // @property (getter = getHeight, nonatomic) float height;
        [Export ("height")]
        float Height { [Bind ("getHeight")] get; set; }

        // @property (getter = getRotation, nonatomic) FSRotation rotation;
        [Export ("rotation", ArgumentSemantic.Assign)]
        FSRotation Rotation { [Bind ("getRotation")] get; set; }

        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(id)initWithWidth:(float)width height:(float)height rotation:(FSRotation)rotation;
        [Export ("initWithWidth:height:rotation:")]
        IntPtr Constructor (float width, float height, FSRotation rotation);

        // -(id)initWithPage_info:(FSPageBasicInfo *)page_info;
        [Export ("initWithPage_info:")]
        IntPtr Constructor (FSPageBasicInfo page_info);

        // -(void)set:(float)width height:(float)height rotation:(FSRotation)rotation;
        [Export ("set:height:rotation:")]
        void Set (float width, float height, FSRotation rotation);

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSPDFDoc : FSBase
    [BaseType (typeof(FSBase))]
    interface FSPDFDoc
    {
        // @property (getter = getDisplayMode, nonatomic) FSPDFDocDisplayMode displayMode;
        [Export ("displayMode", ArgumentSemantic.Assign)]
        FSPDFDocDisplayMode DisplayMode { [Bind ("getDisplayMode")] get; set; }

        // @property (getter = getFileVersion, nonatomic) int fileVersion;
        [Export ("fileVersion")]
        int FileVersion { [Bind ("getFileVersion")] get; set; }

        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(id)initWithPath:(NSString *)path;
        [Export ("initWithPath:")]
        IntPtr Constructor (string path);

        // -(id)initWithFile_read:(id<FSFileReaderCallback>)file_read is_async:(BOOL)is_async;
        [Export ("initWithFile_read:is_async:")]
        IntPtr Constructor (FSFileReaderCallback file_read, bool is_async);

        // -(id)initWithArg0:(FSPDFDoc *)arg0;
        [Export ("initWithArg0:")]
        IntPtr Constructor (FSPDFDoc arg0);

        // -(BOOL)isEmpty;
        [Export ("isEmpty")]
        //[Verify (MethodToProperty)]
        bool IsEmpty { get; }

        // -(unsigned long long)getFileSize;
        [Export ("getFileSize")]
        //[Verify (MethodToProperty)]
        ulong FileSize { get; }

        // -(BOOL)isLinearized;
        [Export ("isLinearized")]
        //[Verify (MethodToProperty)]
        bool IsLinearized { get; }

        // -(BOOL)isTaggedPDF;
        [Export ("isTaggedPDF")]
        //[Verify (MethodToProperty)]
        bool IsTaggedPDF { get; }

        // -(FSErrorCode)load:(NSString *)password;
        [Export ("load:")]
        FSErrorCode Load (string password);

        // -(FSErrorCode)loadW:(NSString *)password;
        [Export ("loadW:")]
        FSErrorCode LoadW (string password);

        // -(FSProgressive *)startLoad:(NSString *)password is_cache_stream:(BOOL)is_cache_stream pause:(id<FSPauseCallback>)pause;
        [Export ("startLoad:is_cache_stream:pause:")]
        FSProgressive StartLoad (string password, bool is_cache_stream, FSPauseCallback pause);

        // -(FSProgressive *)startLoadW:(NSString *)password is_cache_stream:(BOOL)is_cache_stream pause:(id<FSPauseCallback>)pause;
        [Export ("startLoadW:is_cache_stream:pause:")]
        FSProgressive StartLoadW (string password, bool is_cache_stream, FSPauseCallback pause);

        // -(int)getFirstAvailPageIndex;
        [Export ("getFirstAvailPageIndex")]
        //[Verify (MethodToProperty)]
        int FirstAvailPageIndex { get; }

        // -(BOOL)isXFA;
        [Export ("isXFA")]
        //[Verify (MethodToProperty)]
        bool IsXFA { get; }

        // -(BOOL)isCPDF;
        [Export ("isCPDF")]
        //[Verify (MethodToProperty)]
        bool IsCPDF { get; }

        // -(BOOL)isCDRM;
        [Export ("isCDRM")]
        //[Verify (MethodToProperty)]
        bool IsCDRM { get; }

        // -(NSString *)getDocURI;
        [Export ("getDocURI")]
        //[Verify (MethodToProperty)]
        string DocURI { get; }

        // -(NSString *)getEndpoint;
        [Export ("getEndpoint")]
        //[Verify (MethodToProperty)]
        string Endpoint { get; }

        // -(BOOL)isEncrypted;
        [Export ("isEncrypted")]
        //[Verify (MethodToProperty)]
        bool IsEncrypted { get; }

        // -(void)clearRenderCache;
        [Export ("clearRenderCache")]
        void ClearRenderCache ();

        // -(FSPDFDocPasswordType)getPasswordType;
        [Export ("getPasswordType")]
        //[Verify (MethodToProperty)]
        FSPDFDocPasswordType PasswordType { get; }

        // -(FSPDFDocEncryptType)getEncryptionType;
        [Export ("getEncryptionType")]
        //[Verify (MethodToProperty)]
        FSPDFDocEncryptType EncryptionType { get; }

        // -(FSPDFDocPasswordType)checkPassword:(NSString *)password;
        [Export ("checkPassword:")]
        FSPDFDocPasswordType CheckPassword (string password);

        // -(NSString *)getUserPassword:(NSString *)owner_password;
        [Export ("getUserPassword:")]
        string GetUserPassword (string owner_password);

        // -(FSStdEncryptData *)getStdEncryptData;
        [Export ("getStdEncryptData")]
        //[Verify (MethodToProperty)]
        FSStdEncryptData StdEncryptData { get; }

        // -(FSCertificateEncryptData *)getCertificateEncryptData;
        [Export ("getCertificateEncryptData")]
        //[Verify (MethodToProperty)]
        FSCertificateEncryptData CertificateEncryptData { get; }

        // -(FSDRMEncryptData *)getDRMEncryptData;
        [Export ("getDRMEncryptData")]
        //[Verify (MethodToProperty)]
        FSDRMEncryptData DRMEncryptData { get; }

        // -(FSCustomEncryptData *)getCustomEncryptData;
        [Export ("getCustomEncryptData")]
        //[Verify (MethodToProperty)]
        FSCustomEncryptData CustomEncryptData { get; }

        // -(FSRMSEncryptData *)getRMSEncryptData;
        [Export ("getRMSEncryptData")]
        //[Verify (MethodToProperty)]
        FSRMSEncryptData RMSEncryptData { get; }

        // -(BOOL)saveAs:(NSString *)file_path save_flags:(unsigned int)save_flags;
        [Export ("saveAs:save_flags:")]
        bool SaveAs (string file_path, uint save_flags);

        // -(FSProgressive *)startSaveAs:(NSString *)file_path save_flags:(unsigned int)save_flags pause:(id<FSPauseCallback>)pause;
        [Export ("startSaveAs:save_flags:pause:")]
        FSProgressive StartSaveAs (string file_path, uint save_flags, FSPauseCallback pause);

        // -(FSBookmark *)getRootBookmark;
        [Export ("getRootBookmark")]
        //[Verify (MethodToProperty)]
        FSBookmark RootBookmark { get; }

        // -(FSBookmark *)createRootBookmark;
        [Export ("createRootBookmark")]
        //[Verify (MethodToProperty)]
        FSBookmark CreateRootBookmark { get; }

        // -(BOOL)removeBookmark:(FSBookmark *)bookmark;
        [Export ("removeBookmark:")]
        bool RemoveBookmark (FSBookmark bookmark);

        // -(int)getPageCount;
        [Export ("getPageCount")]
        //[Verify (MethodToProperty)]
        int PageCount { get; }

        // -(FSPDFPage *)getPage:(int)index;
        [Export ("getPage:")]
        FSPDFPage GetPage (int index);

        // -(FSPDFDictionary *)getCatalog;
        [Export ("getCatalog")]
        //[Verify (MethodToProperty)]
        FSPDFDictionary Catalog { get; }

        // -(FSPDFDictionary *)getTrailer;
        [Export ("getTrailer")]
        //[Verify (MethodToProperty)]
        FSPDFDictionary Trailer { get; }

        // -(FSPDFDictionary *)getInfo;
        [Export ("getInfo")]
        //[Verify (MethodToProperty)]
        FSPDFDictionary Info { get; }

        // -(FSPDFDictionary *)getEncryptDict;
        [Export ("getEncryptDict")]
        //[Verify (MethodToProperty)]
        FSPDFDictionary EncryptDict { get; }

        // -(FSPDFDictionary *)getPagesDict;
        [Export ("getPagesDict")]
        //[Verify (MethodToProperty)]
        FSPDFDictionary PagesDict { get; }

        // -(FSPDFObject *)getIndirectObject:(unsigned int)object_number;
        [Export ("getIndirectObject:")]
        FSPDFObject GetIndirectObject (uint object_number);

        // -(unsigned int)addIndirectObject:(FSPDFObject *)pdf_object;
        [Export ("addIndirectObject:")]
        uint AddIndirectObject (FSPDFObject pdf_object);

        // -(void)deleteIndirectObject:(unsigned int)object_number;
        [Export ("deleteIndirectObject:")]
        void DeleteIndirectObject (uint object_number);

        // -(unsigned int)getUserPermissions;
        [Export ("getUserPermissions")]
        //[Verify (MethodToProperty)]
        uint UserPermissions { get; }

        // -(BOOL)isWrapper;
        [Export ("isWrapper")]
        //[Verify (MethodToProperty)]
        bool IsWrapper { get; }

        // -(FSPDFDocWrapperType)getWrapperType;
        [Export ("getWrapperType")]
        //[Verify (MethodToProperty)]
        FSPDFDocWrapperType WrapperType { get; }

        // -(FSWrapperData *)getWrapperData;
        [Export ("getWrapperData")]
        //[Verify (MethodToProperty)]
        FSWrapperData WrapperData { get; }

        // -(long long)getWrapperOffset;
        [Export ("getWrapperOffset")]
        //[Verify (MethodToProperty)]
        long WrapperOffset { get; }

        // -(FSPayLoadData *)getPayLoadData;
        [Export ("getPayLoadData")]
        //[Verify (MethodToProperty)]
        FSPayLoadData PayLoadData { get; }

        // -(FSProgressive *)startGetPayloadFile:(id<FSFileWriterCallback>)payload_file pause:(id<FSPauseCallback>)pause;
        [Export ("startGetPayloadFile:pause:")]
        FSProgressive StartGetPayloadFile (FSFileWriterCallback payload_file, FSPauseCallback pause);

        // -(BOOL)saveAsWrapperFile:(NSString *)file_path wrapper_data:(FSWrapperData *)wrapper_data user_permissions:(unsigned int)user_permissions owner_password:(NSString *)owner_password;
        [Export ("saveAsWrapperFile:wrapper_data:user_permissions:owner_password:")]
        bool SaveAsWrapperFile (string file_path, FSWrapperData wrapper_data, uint user_permissions, string owner_password);

        // -(FSProgressive *)startSaveAsPayloadFile:(NSString *)file_path payload_file_path:(NSString *)payload_file_path crypto_filter:(NSString *)crypto_filter description:(NSString *)description version:(float)version save_flags:(unsigned int)save_flags pause:(id<FSPauseCallback>)pause;
        [Export ("startSaveAsPayloadFile:payload_file_path:crypto_filter:description:version:save_flags:pause:")]
        FSProgressive StartSaveAsPayloadFile (string file_path, string payload_file_path, string crypto_filter, string description, float version, uint save_flags, FSPauseCallback pause);

        // -(BOOL)hasForm;
        [Export ("hasForm")]
        //[Verify (MethodToProperty)]
        bool HasForm { get; }

        // -(int)getReadingBookmarkCount;
        [Export ("getReadingBookmarkCount")]
        //[Verify (MethodToProperty)]
        int ReadingBookmarkCount { get; }

        // -(FSReadingBookmark *)getReadingBookmark:(int)index;
        [Export ("getReadingBookmark:")]
        FSReadingBookmark GetReadingBookmark (int index);

        // -(FSReadingBookmark *)insertReadingBookmark:(int)reading_bookmark_index title:(NSString *)title dest_page_index:(int)dest_page_index;
        [Export ("insertReadingBookmark:title:dest_page_index:")]
        FSReadingBookmark InsertReadingBookmark (int reading_bookmark_index, string title, int dest_page_index);

        // -(BOOL)removeReadingBookmark:(FSReadingBookmark *)reading_bookmark;
        [Export ("removeReadingBookmark:")]
        bool RemoveReadingBookmark (FSReadingBookmark reading_bookmark);

        // -(int)getSignatureCount;
        [Export ("getSignatureCount")]
        //[Verify (MethodToProperty)]
        int SignatureCount { get; }

        // -(FSSignature *)getSignature:(int)index;
        [Export ("getSignature:")]
        FSSignature GetSignature (int index);

        // -(void)removeSignature:(FSSignature *)signature;
        [Export ("removeSignature:")]
        void RemoveSignature (FSSignature signature);

        // -(FSPDFPage *)insertPage:(int)index width:(float)width height:(float)height;
        [Export ("insertPage:width:height:")]
        FSPDFPage InsertPage (int index, float width, float height);

        // -(BOOL)removePage:(int)index;
        [Export ("removePage:")]
        bool RemovePage (int index);

        // -(BOOL)movePageTo:(FSPDFPage *)page dest_index:(int)dest_index;
        [Export ("movePageTo:dest_index:")]
        bool MovePageTo (FSPDFPage page, int dest_index);

        // -(BOOL)movePagesTo:(FSRange *)page_range dest_index:(int)dest_index;
        [Export ("movePagesTo:dest_index:")]
        bool MovePagesTo (FSRange page_range, int dest_index);

        // -(FSProgressive *)startImportPagesFromFilePath:(int)dest_index src_file_path:(NSString *)src_file_path password:(NSString *)password flags:(unsigned int)flags layer_name:(NSString *)layer_name page_range:(FSRange *)page_range pause:(id<FSPauseCallback>)pause;
        [Export ("startImportPagesFromFilePath:src_file_path:password:flags:layer_name:page_range:pause:")]
        FSProgressive StartImportPagesFromFilePath (int dest_index, string src_file_path, string password, uint flags, string layer_name, FSRange page_range, FSPauseCallback pause);

        // -(FSProgressive *)startImportPages:(int)dest_index src_doc:(FSPDFDoc *)src_doc flags:(unsigned int)flags layer_name:(NSString *)layer_name page_range:(FSRange *)page_range pause:(id<FSPauseCallback>)pause;
        [Export ("startImportPages:src_doc:flags:layer_name:page_range:pause:")]
        FSProgressive StartImportPages (int dest_index, FSPDFDoc src_doc, uint flags, string layer_name, FSRange page_range, FSPauseCallback pause);

        // -(BOOL)importFromFDF:(FSFDFDoc *)fdf_doc types:(int)types page_range:(FSRange *)page_range;
        [Export ("importFromFDF:types:page_range:")]
        bool ImportFromFDF (FSFDFDoc fdf_doc, int types, FSRange page_range);

        // -(BOOL)exportToFDF:(FSFDFDoc *)fdf_doc types:(int)types page_range:(FSRange *)page_range;
        [Export ("exportToFDF:types:page_range:")]
        bool ExportToFDF (FSFDFDoc fdf_doc, int types, FSRange page_range);

        // -(BOOL)exportAnnotToFDF:(FSAnnot *)pdf_annot fdf_doc:(FSFDFDoc *)fdf_doc;
        [Export ("exportAnnotToFDF:fdf_doc:")]
        bool ExportAnnotToFDF (FSAnnot pdf_annot, FSFDFDoc fdf_doc);

        // -(BOOL)setSecurityHandler:(FSSecurityHandler *)handler;
        [Export ("setSecurityHandler:")]
        bool SetSecurityHandler (FSSecurityHandler handler);

        // -(FSSecurityHandler *)getSecurityHandler;
        [Export ("getSecurityHandler")]
        //[Verify (MethodToProperty)]
        FSSecurityHandler SecurityHandler { get; }

        // -(BOOL)removeSecurity;
        [Export ("removeSecurity")]
        //[Verify (MethodToProperty)]
        bool RemoveSecurity { get; }

        // -(int)getFontCount;
        [Export ("getFontCount")]
        //[Verify (MethodToProperty)]
        int FontCount { get; }

        // -(FSFont *)getFont:(int)index;
        [Export ("getFont:")]
        FSFont GetFont (int index);

        // -(FSAction *)getOpenAction;
        [Export ("getOpenAction")]
        //[Verify (MethodToProperty)]
        FSAction OpenAction { get; }

        // -(BOOL)setOpenAction:(FSAction *)action;
        [Export ("setOpenAction:")]
        bool SetOpenAction (FSAction action);

        // -(BOOL)removeOpenAction;
        [Export ("removeOpenAction")]
        //[Verify (MethodToProperty)]
        bool RemoveOpenAction { get; }

        // -(BOOL)doJSOpenAction;
        [Export ("doJSOpenAction")]
        //[Verify (MethodToProperty)]
        bool DoJSOpenAction { get; }

        // -(BOOL)isPortfolio;
        [Export ("isPortfolio")]
        //[Verify (MethodToProperty)]
        bool IsPortfolio { get; }

        // -(FSPageBasicInfo *)getPageBasicInfo:(int)index;
        [Export ("getPageBasicInfo:")]
        FSPageBasicInfo GetPageBasicInfo (int index);

        // -(id)initWithBuffer:(NSData *)buffer;
        [Export ("initWithBuffer:")]
        IntPtr Constructor (NSData buffer);

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSFileSpec : FSBase
    [BaseType (typeof(FSBase))]
    [DisableDefaultCtor]
    interface FSFileSpec
    {
        // @property (getter = getFileName, nonatomic, weak) NSString * fileName;
        [Export ("fileName", ArgumentSemantic.Weak)]
        string FileName { [Bind ("getFileName")] get; set; }

        // @property (getter = getAssociteFileRelationship, nonatomic) FSAssociatedFilesRelationship associteFileRelationship;
        [Export ("associteFileRelationship", ArgumentSemantic.Assign)]
        FSAssociatedFilesRelationship AssociteFileRelationship { [Bind ("getAssociteFileRelationship")] get; set; }

        // @property (getter = getDescription, nonatomic, weak) NSString * description;
        [Export ("description", ArgumentSemantic.Weak)]
        string Description { [Bind ("getDescription")] get; set; }

        // @property (getter = getCreationDateTime, nonatomic, weak) FSDateTime * creationDateTime;
        [Export ("creationDateTime", ArgumentSemantic.Weak)]
        FSDateTime CreationDateTime { [Bind ("getCreationDateTime")] get; set; }

        // @property (getter = getModifiedDateTime, nonatomic, weak) FSDateTime * modifiedDateTime;
        [Export ("modifiedDateTime", ArgumentSemantic.Weak)]
        FSDateTime ModifiedDateTime { [Bind ("getModifiedDateTime")] get; set; }

        // @property (getter = getSubtype, nonatomic, weak) NSString * subtype;
        [Export ("subtype", ArgumentSemantic.Weak)]
        string Subtype { [Bind ("getSubtype")] get; set; }

        // @property (getter = getChecksum, nonatomic, weak) NSData * checksum;
        [Export ("checksum", ArgumentSemantic.Weak)]
        NSData Checksum { [Bind ("getChecksum")] get; set; }

        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(id)initWithDocument:(FSPDFDoc *)document;
        [Export ("initWithDocument:")]
        IntPtr Constructor (FSPDFDoc document);

        // -(id)initWithDocument:(FSPDFDoc *)document pdf_object:(FSPDFObject *)pdf_object;
        [Export ("initWithDocument:pdf_object:")]
        IntPtr Constructor (FSPDFDoc document, FSPDFObject pdf_object);

        // -(id)initWithOther:(FSFileSpec *)other;
        [Export ("initWithOther:")]
        IntPtr Constructor (FSFileSpec other);

        // -(BOOL)isEmpty;
        [Export ("isEmpty")]
        //[Verify (MethodToProperty)]
        bool IsEmpty { get; }

        // -(long long)getFileSize;
        [Export ("getFileSize")]
        //[Verify (MethodToProperty)]
        long FileSize { get; }

        // -(id<FSFileReaderCallback>)getFileData;
        [Export ("getFileData")]
        //[Verify (MethodToProperty)]
        FSFileReaderCallback FileData { get; }

        // -(BOOL)embed:(NSString *)file_path;
        [Export ("embed:")]
        bool Embed (string file_path);

        // -(BOOL)isEmbedded;
        [Export ("isEmbedded")]
        //[Verify (MethodToProperty)]
        bool IsEmbedded { get; }

        // -(FSPDFDictionary *)getDict;
        [Export ("getDict")]
        //[Verify (MethodToProperty)]
        FSPDFDictionary Dict { get; }

        // -(BOOL)exportToFile:(NSString *)path;
        [Export ("exportToFile:")]
        bool ExportToFile (string path);

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSLayerNodeArray : NSObject
    [BaseType (typeof(NSObject))]
    interface FSLayerNodeArray
    {
        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(id)initWithArg0:(FSLayerNodeArray *)arg0;
        [Export ("initWithArg0:")]
        IntPtr Constructor (FSLayerNodeArray arg0);

        // -(unsigned long)getSize;
        [Export ("getSize")]
        //[Verify (MethodToProperty)]
        nuint Size { get; }

        // -(FSLayerNode *)getAt:(unsigned long)index;
        [Export ("getAt:")]
        FSLayerNode GetAt (nuint index);

        // -(void)add:(FSLayerNode *)element;
        [Export ("add:")]
        void Add (FSLayerNode element);

        // -(void)removeAt:(unsigned long)index;
        [Export ("removeAt:")]
        void RemoveAt (nuint index);

        // -(void)insertAt:(unsigned long)index element:(FSLayerNode *)element;
        [Export ("insertAt:element:")]
        void InsertAt (nuint index, FSLayerNode element);

        // -(void)removeAll;
        [Export ("removeAll")]
        void RemoveAll ();

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSLayerZoomData : NSObject
    [BaseType (typeof(NSObject))]
    interface FSLayerZoomData
    {
        // @property (getter = getMin_factor, nonatomic) float min_factor;
        [Export ("min_factor")]
        float Min_factor { [Bind ("getMin_factor")] get; set; }

        // @property (getter = getMax_factor, nonatomic) float max_factor;
        [Export ("max_factor")]
        float Max_factor { [Bind ("getMax_factor")] get; set; }

        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(id)initWithMin_factor:(float)min_factor max_factor:(float)max_factor;
        [Export ("initWithMin_factor:max_factor:")]
        IntPtr Constructor (float min_factor, float max_factor);

        // -(id)initWithData:(FSLayerZoomData *)data;
        [Export ("initWithData:")]
        IntPtr Constructor (FSLayerZoomData data);

        // -(void)set:(float)min_factor max_factor:(float)max_factor;
        [Export ("set:max_factor:")]
        void Set (float min_factor, float max_factor);

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSLayerTree : FSBase
    [BaseType (typeof(FSBase))]
    [DisableDefaultCtor]
    interface FSLayerTree
    {
        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(id)initWithDocument:(FSPDFDoc *)document;
        [Export ("initWithDocument:")]
        IntPtr Constructor (FSPDFDoc document);

        // -(id)initWithOther:(FSLayerTree *)other;
        [Export ("initWithOther:")]
        IntPtr Constructor (FSLayerTree other);

        // -(BOOL)isEmpty;
        [Export ("isEmpty")]
        //[Verify (MethodToProperty)]
        bool IsEmpty { get; }

        // -(BOOL)setBaseState:(FSLayerTreeUsageState)state;
        [Export ("setBaseState:")]
        bool SetBaseState (FSLayerTreeUsageState state);

        // -(FSLayerNode *)getRootNode;
        [Export ("getRootNode")]
        //[Verify (MethodToProperty)]
        FSLayerNode RootNode { get; }

        // -(FSPDFDictionary *)getDict;
        [Export ("getDict")]
        //[Verify (MethodToProperty)]
        FSPDFDictionary Dict { get; }

        // -(FSPDFArray *)getOCGs;
        [Export ("getOCGs")]
        //[Verify (MethodToProperty)]
        FSPDFArray OCGs { get; }

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSLayerContext : FSBase
    [BaseType (typeof(FSBase))]
    [DisableDefaultCtor]
    interface FSLayerContext
    {
        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(id)initWithDocument:(FSPDFDoc *)document usage_type:(FSLayerContextUsageType)usage_type;
        [Export ("initWithDocument:usage_type:")]
        IntPtr Constructor (FSPDFDoc document, FSLayerContextUsageType usage_type);

        // -(id)initWithOther:(FSLayerContext *)other;
        [Export ("initWithOther:")]
        IntPtr Constructor (FSLayerContext other);

        // -(BOOL)isEmpty;
        [Export ("isEmpty")]
        //[Verify (MethodToProperty)]
        bool IsEmpty { get; }

        // -(FSPDFDoc *)getDocument;
        [Export ("getDocument")]
        //[Verify (MethodToProperty)]
        FSPDFDoc Document { get; }

        // -(FSLayerContextUsageType)getUsageType;
        [Export ("getUsageType")]
        //[Verify (MethodToProperty)]
        FSLayerContextUsageType UsageType { get; }

        // -(BOOL)reset;
        [Export ("reset")]
        //[Verify (MethodToProperty)]
        bool Reset { get; }

        // -(BOOL)copyStates:(FSLayerContext *)source_context;
        [Export ("copyStates:")]
        bool CopyStates (FSLayerContext source_context);

        // -(BOOL)mergeStates:(FSLayerContext *)source_context;
        [Export ("mergeStates:")]
        bool MergeStates (FSLayerContext source_context);

        // -(BOOL)isVisible:(FSLayerNode *)layer;
        [Export ("isVisible:")]
        bool IsVisible (FSLayerNode layer);

        // -(BOOL)setVisible:(FSLayerNode *)layer is_visible:(BOOL)is_visible;
        [Export ("setVisible:is_visible:")]
        bool SetVisible (FSLayerNode layer, bool is_visible);

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSLayerNode : FSBase
    [BaseType (typeof(FSBase))]
    [DisableDefaultCtor]
    interface FSLayerNode
    {
        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(id)initWithOther:(FSLayerNode *)other;
        [Export ("initWithOther:")]
        IntPtr Constructor (FSLayerNode other);

        // -(BOOL)isEmpty;
        [Export ("isEmpty")]
        //[Verify (MethodToProperty)]
        bool IsEmpty { get; }

        // -(int)getChildrenCount;
        [Export ("getChildrenCount")]
        //[Verify (MethodToProperty)]
        int ChildrenCount { get; }

        // -(FSLayerNode *)getChild:(int)index;
        [Export ("getChild:")]
        FSLayerNode GetChild (int index);

        // -(BOOL)removeChild:(int)index;
        [Export ("removeChild:")]
        bool RemoveChild (int index);

        // -(BOOL)moveTo:(FSLayerNode *)parent_layer_node index:(int)index;
        [Export ("moveTo:index:")]
        bool MoveTo (FSLayerNode parent_layer_node, int index);

        // -(FSLayerNode *)addChild:(int)index name:(NSString *)name has_Layer:(BOOL)has_Layer;
        [Export ("addChild:name:has_Layer:")]
        FSLayerNode AddChild (int index, string name, bool has_Layer);

        // -(NSString *)getName;
        [Export ("getName")]
        //[Verify (MethodToProperty)]
        string Name { get; }

        // -(BOOL)hasLayer;
        [Export ("hasLayer")]
        //[Verify (MethodToProperty)]
        bool HasLayer { get; }

        // -(BOOL)hasIntent:(NSString *)intent;
        [Export ("hasIntent:")]
        bool HasIntent (string intent);

        // -(BOOL)isInPage:(FSPDFPage *)page;
        [Export ("isInPage:")]
        bool IsInPage (FSPDFPage page);

        // -(FSLayerTreeUsageState)getViewUsage;
        [Export ("getViewUsage")]
        //[Verify (MethodToProperty)]
        FSLayerTreeUsageState ViewUsage { get; }

        // -(FSLayerTreeUsageState)getExportUsage;
        [Export ("getExportUsage")]
        //[Verify (MethodToProperty)]
        FSLayerTreeUsageState ExportUsage { get; }

        // -(FSLayerPrintData *)getPrintUsage;
        [Export ("getPrintUsage")]
        //[Verify (MethodToProperty)]
        FSLayerPrintData PrintUsage { get; }

        // -(FSLayerZoomData *)getZoomUsage;
        [Export ("getZoomUsage")]
        //[Verify (MethodToProperty)]
        FSLayerZoomData ZoomUsage { get; }

        // -(BOOL)setName:(NSString *)name;
        [Export ("setName:")]
        bool SetName (string name);

        // -(BOOL)setDefaultVisible:(BOOL)is_visible;
        [Export ("setDefaultVisible:")]
        bool SetDefaultVisible (bool is_visible);

        // -(BOOL)setViewUsage:(FSLayerTreeUsageState)state;
        [Export ("setViewUsage:")]
        bool SetViewUsage (FSLayerTreeUsageState state);

        // -(BOOL)setExportUsage:(FSLayerTreeUsageState)state;
        [Export ("setExportUsage:")]
        bool SetExportUsage (FSLayerTreeUsageState state);

        // -(BOOL)setPrintUsage:(FSLayerPrintData *)data;
        [Export ("setPrintUsage:")]
        bool SetPrintUsage (FSLayerPrintData data);

        // -(BOOL)setZoomUsage:(FSLayerZoomData *)data;
        [Export ("setZoomUsage:")]
        bool SetZoomUsage (FSLayerZoomData data);

        // -(FSGraphicsObjectArray *)getGraphicsObjects:(FSPDFPage *)page;
        [Export ("getGraphicsObjects:")]
        FSGraphicsObjectArray GetGraphicsObjects (FSPDFPage page);

        // -(BOOL)addGraphicsObject:(FSPDFPage *)page graphicsobject:(FSGraphicsObject *)graphicsobject;
        [Export ("addGraphicsObject:graphicsobject:")]
        bool AddGraphicsObject (FSPDFPage page, FSGraphicsObject graphicsobject);

        // -(BOOL)removeGraphicsObject:(FSGraphicsObject *)graphics_object;
        [Export ("removeGraphicsObject:")]
        bool RemoveGraphicsObject (FSGraphicsObject graphics_object);

        // -(BOOL)removeUsage:(FSLayerContextUsageType)usage_type;
        [Export ("removeUsage:")]
        bool RemoveUsage (FSLayerContextUsageType usage_type);

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSLayerPrintData : NSObject
    [BaseType (typeof(NSObject))]
    interface FSLayerPrintData
    {
        // @property (getter = getSubtype, nonatomic, weak) NSString * subtype;
        [Export ("subtype", ArgumentSemantic.Weak)]
        string Subtype { [Bind ("getSubtype")] get; set; }

        // @property (getter = getPrint_state, nonatomic) FSLayerTreeUsageState print_state;
        [Export ("print_state", ArgumentSemantic.Assign)]
        FSLayerTreeUsageState Print_state { [Bind ("getPrint_state")] get; set; }

        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(id)initWithSubtype:(NSString *)subtype print_state:(FSLayerTreeUsageState)print_state;
        [Export ("initWithSubtype:print_state:")]
        IntPtr Constructor (string subtype, FSLayerTreeUsageState print_state);

        // -(id)initWithData:(FSLayerPrintData *)data;
        [Export ("initWithData:")]
        IntPtr Constructor (FSLayerPrintData data);

        // -(void)set:(NSString *)subtype print_state:(FSLayerTreeUsageState)print_state;
        [Export ("set:print_state:")]
        void Set (string subtype, FSLayerTreeUsageState print_state);

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSMetadata : FSBase
    [BaseType (typeof(FSBase))]
    [DisableDefaultCtor]
    interface FSMetadata
    {
        // @property (getter = getCreationDateTime, nonatomic, weak) FSDateTime * creationDateTime;
        [Export ("creationDateTime", ArgumentSemantic.Weak)]
        FSDateTime CreationDateTime { [Bind ("getCreationDateTime")] get; set; }

        // @property (getter = getModifiedDateTime, nonatomic, weak) FSDateTime * modifiedDateTime;
        [Export ("modifiedDateTime", ArgumentSemantic.Weak)]
        FSDateTime ModifiedDateTime { [Bind ("getModifiedDateTime")] get; set; }

        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(id)initWithDocument:(FSPDFDoc *)document;
        [Export ("initWithDocument:")]
        IntPtr Constructor (FSPDFDoc document);

        // -(id)initWithOther:(FSMetadata *)other;
        [Export ("initWithOther:")]
        IntPtr Constructor (FSMetadata other);

        // -(BOOL)isEmpty;
        [Export ("isEmpty")]
        //[Verify (MethodToProperty)]
        bool IsEmpty { get; }

        // -(BOOL)hasKey:(NSString *)key;
        [Export ("hasKey:")]
        bool HasKey (string key);

        // -(NSArray<NSString *> *)getValues:(NSString *)key;
        [Export ("getValues:")]
        string[] GetValues (string key);

        // -(BOOL)setValues:(NSString *)key value_array:(NSArray<NSString *> *)value_array;
        [Export ("setValues:value_array:")]
        bool SetValues (string key, string[] value_array);

        // -(NSArray<NSString *> *)getCustomerKeys;
        [Export ("getCustomerKeys")]
        //[Verify (MethodToProperty)]
        string[] CustomerKeys { get; }

        // -(void)removeCustomerKey:(NSString *)key;
        [Export ("removeCustomerKey:")]
        void RemoveCustomerKey (string key);

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSGraphicsObjectArray : FSBasicArray
    [BaseType (typeof(FSBasicArray))]
    interface FSGraphicsObjectArray
    {
        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(id)initWithOther:(FSGraphicsObjectArray *)other;
        [Export ("initWithOther:")]
        IntPtr Constructor (FSGraphicsObjectArray other);

        // -(int)getSize;
        [Export ("getSize")]
        //[Verify (MethodToProperty)]
        int Size { get; }

        // -(int)getUpperBound;
        [Export ("getUpperBound")]
        //[Verify (MethodToProperty)]
        int UpperBound { get; }

        // -(int)setSize:(int)nNewSize nGrowBy:(int)nGrowBy;
        [Export ("setSize:nGrowBy:")]
        int SetSize (int nNewSize, int nGrowBy);

        // -(void)removeAll;
        [Export ("removeAll")]
        void RemoveAll ();

        // -(FSGraphicsObject *)getAt:(int)nIndex;
        [Export ("getAt:")]
        FSGraphicsObject GetAt (int nIndex);

        // -(int)setAt:(int)nIndex newElement:(FSGraphicsObject *)newElement;
        [Export ("setAt:newElement:")]
        int SetAt (int nIndex, FSGraphicsObject newElement);

        // -(int)setAtGrow:(int)nIndex newElement:(FSGraphicsObject *)newElement;
        [Export ("setAtGrow:newElement:")]
        int SetAtGrow (int nIndex, FSGraphicsObject newElement);

        // -(int)add:(FSGraphicsObject *)newElement;
        [Export ("add:")]
        int Add (FSGraphicsObject newElement);

        // -(int)insertAt:(int)nIndex newElement:(FSGraphicsObject *)newElement nCount:(int)nCount;
        [Export ("insertAt:newElement:nCount:")]
        int InsertAt (int nIndex, FSGraphicsObject newElement, int nCount);

        // -(int)removeAt:(int)nIndex nCount:(int)nCount;
        [Export ("removeAt:nCount:")]
        int RemoveAt (int nIndex, int nCount);

        // -(int)find:(FSGraphicsObject *)data iStart:(int)iStart;
        [Export ("find:iStart:")]
        int Find (FSGraphicsObject data, int iStart);

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSMarkedContent : NSObject
    [BaseType (typeof(NSObject))]
    [DisableDefaultCtor]
    interface FSMarkedContent
    {
        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(BOOL)hasTag:(NSString *)tag_name;
        [Export ("hasTag:")]
        bool HasTag (string tag_name);

        // -(int)getItemCount;
        [Export ("getItemCount")]
        //[Verify (MethodToProperty)]
        int ItemCount { get; }

        // -(NSString *)getItemTagName:(int)index;
        [Export ("getItemTagName:")]
        string GetItemTagName (int index);

        // -(int)getItemMCID:(int)index;
        [Export ("getItemMCID:")]
        int GetItemMCID (int index);

        // -(FSPDFDictionary *)getItemPropertyDict:(int)index;
        [Export ("getItemPropertyDict:")]
        FSPDFDictionary GetItemPropertyDict (int index);

        // -(int)addItem:(NSString *)tag_name property_dict:(FSPDFDictionary *)property_dict;
        [Export ("addItem:property_dict:")]
        int AddItem (string tag_name, FSPDFDictionary property_dict);

        // -(BOOL)removeItem:(NSString *)tag_name;
        [Export ("removeItem:")]
        bool RemoveItem (string tag_name);

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSGraphicsObject : NSObject
    [BaseType (typeof(NSObject))]
    interface FSGraphicsObject
    {
        // @property (getter = getStrokeColor, nonatomic) unsigned int strokeColor;
        [Export ("strokeColor")]
        uint StrokeColor { [Bind ("getStrokeColor")] get; set; }

        // @property (getter = getFillColor, nonatomic) unsigned int fillColor;
        [Export ("fillColor")]
        uint FillColor { [Bind ("getFillColor")] get; set; }

        // @property (getter = getMatrix, nonatomic, weak) FSMatrix2D * matrix;
        [Export ("matrix", ArgumentSemantic.Weak)]
        FSMatrix2D Matrix { [Bind ("getMatrix")] get; set; }

        // @property (getter = getGraphState, nonatomic, weak) FSGraphState * graphState;
        [Export ("graphState", ArgumentSemantic.Weak)]
        FSGraphState GraphState { [Bind ("getGraphState")] get; set; }

        // @property (getter = getBlendMode, nonatomic) FSGraphicsObjectBlendMode blendMode;
        [Export ("blendMode", ArgumentSemantic.Assign)]
        FSGraphicsObjectBlendMode BlendMode { [Bind ("getBlendMode")] get; set; }

        // @property (getter = getClipRect, nonatomic, weak) FSRectF * clipRect;
        [Export ("clipRect", ArgumentSemantic.Weak)]
        FSRectF ClipRect { [Bind ("getClipRect")] get; set; }

        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(FSGraphicsObjectType)getType;
        [Export ("getType")]
        //[Verify (MethodToProperty)]
        FSGraphicsObjectType Type { get; }

        // -(FSRectF *)getRect;
        [Export ("getRect")]
        //[Verify (MethodToProperty)]
        FSRectF Rect { get; }

        // -(BOOL)hasTransparency;
        [Export ("hasTransparency")]
        //[Verify (MethodToProperty)]
        bool HasTransparency { get; }

        // -(BOOL)transform:(FSMatrix2D *)matrix need_transform_clippath:(BOOL)need_transform_clippath;
        [Export ("transform:need_transform_clippath:")]
        bool Transform (FSMatrix2D matrix, bool need_transform_clippath);

        // -(FSGraphicsObject *)clone;
        [Export ("clone")]
        //[Verify (MethodToProperty)]
        FSGraphicsObject Clone { get; }

        // -(int)getClipPathCount;
        [Export ("getClipPathCount")]
        //[Verify (MethodToProperty)]
        int ClipPathCount { get; }

        // -(FSPath *)getClipPath:(int)index;
        [Export ("getClipPath:")]
        FSPath GetClipPath (int index);

        // -(FSFillMode)getClipPathFillMode:(int)index;
        [Export ("getClipPathFillMode:")]
        FSFillMode GetClipPathFillMode (int index);

        // -(BOOL)addClipPath:(FSPath *)path fill_mode:(FSFillMode)fill_mode;
        [Export ("addClipPath:fill_mode:")]
        bool AddClipPath (FSPath path, FSFillMode fill_mode);

        // -(BOOL)removeClipPath:(int)index;
        [Export ("removeClipPath:")]
        bool RemoveClipPath (int index);

        // -(int)getClipTextObjectCount;
        [Export ("getClipTextObjectCount")]
        //[Verify (MethodToProperty)]
        int ClipTextObjectCount { get; }

        // -(FSTextObject *)getClipTextObject:(int)index;
        [Export ("getClipTextObject:")]
        FSTextObject GetClipTextObject (int index);

        // -(BOOL)addClipTextObject:(FSTextObject *)textobject;
        [Export ("addClipTextObject:")]
        bool AddClipTextObject (FSTextObject textobject);

        // -(BOOL)removeClipTextObject:(int)index;
        [Export ("removeClipTextObject:")]
        bool RemoveClipTextObject (int index);

        // -(BOOL)clearClips;
        [Export ("clearClips")]
        //[Verify (MethodToProperty)]
        bool ClearClips { get; }

        // -(FSMarkedContent *)getMarkedContent;
        [Export ("getMarkedContent")]
        //[Verify (MethodToProperty)]
        FSMarkedContent MarkedContent { get; }

        // -(FSLayerNodeArray *)getLayers:(FSLayerTree *)layer_tree;
        [Export ("getLayers:")]
        FSLayerNodeArray GetLayers (FSLayerTree layer_tree);

        // -(FSTextObject *)getTextObject;
        [Export ("getTextObject")]
        //[Verify (MethodToProperty)]
        FSTextObject TextObject { get; }

        // -(FSFormXObject *)getFormXObject;
        [Export ("getFormXObject")]
        //[Verify (MethodToProperty)]
        FSFormXObject FormXObject { get; }

        // -(FSImageObject *)getImageObject;
        [Export ("getImageObject")]
        //[Verify (MethodToProperty)]
        FSImageObject ImageObject { get; }

        // -(FSPathObject *)getPathObject;
        [Export ("getPathObject")]
        //[Verify (MethodToProperty)]
        FSPathObject PathObject { get; }

        // -(FSShadingObject *)getShadingObject;
        [Export ("getShadingObject")]
        //[Verify (MethodToProperty)]
        FSShadingObject ShadingObject { get; }

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSTextState : NSObject
    [BaseType (typeof(NSObject))]
    interface FSTextState
    {
        // @property (getter = getVersion, nonatomic) unsigned int version;
        [Export ("version")]
        uint Version { [Bind ("getVersion")] get; set; }

        // @property (getter = getFont_size, nonatomic) float font_size;
        [Export ("font_size")]
        float Font_size { [Bind ("getFont_size")] get; set; }

        // @property (getter = getCharspace, nonatomic) float charspace;
        [Export ("charspace")]
        float Charspace { [Bind ("getCharspace")] get; set; }

        // @property (getter = getWordspace, nonatomic) float wordspace;
        [Export ("wordspace")]
        float Wordspace { [Bind ("getWordspace")] get; set; }

        // @property (getter = getTextmode, nonatomic) FSTextStateMode textmode;
        [Export ("textmode", ArgumentSemantic.Assign)]
        FSTextStateMode Textmode { [Bind ("getTextmode")] get; set; }

        // @property (getter = getTextmatrix, nonatomic, weak) NSArray<NSNumber *> * textmatrix;
        [Export ("textmatrix", ArgumentSemantic.Weak)]
        NSNumber[] Textmatrix { [Bind ("getTextmatrix")] get; set; }

        // @property (getter = getOrigin_position, nonatomic, weak) FSPointF * origin_position;
        [Export ("origin_position", ArgumentSemantic.Weak)]
        FSPointF Origin_position { [Bind ("getOrigin_position")] get; set; }

        // @property (getter = getFont, nonatomic, weak) FSFont * font;
        [Export ("font", ArgumentSemantic.Weak)]
        FSFont Font { [Bind ("getFont")] get; set; }

        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(id)initWithVersion:(unsigned int)version font:(FSFont *)font font_size:(float)font_size charspace:(float)charspace wordspace:(float)wordspace textmode:(FSTextStateMode)textmode origin_position:(FSPointF *)origin_position textmatrix:(NSArray<NSNumber *> *)textmatrix;
        [Export ("initWithVersion:font:font_size:charspace:wordspace:textmode:origin_position:textmatrix:")]
        IntPtr Constructor (uint version, FSFont font, float font_size, float charspace, float wordspace, FSTextStateMode textmode, FSPointF origin_position, NSNumber[] textmatrix);

        // -(id)initWithState:(FSTextState *)state;
        [Export ("initWithState:")]
        IntPtr Constructor (FSTextState state);

        // -(void)set:(unsigned int)version font:(FSFont *)font font_size:(float)font_size charspace:(float)charspace wordspace:(float)wordspace textmode:(FSTextStateMode)textmode origin_position:(FSPointF *)origin_position textmatrix:(NSArray<NSNumber *> *)textmatrix;
        [Export ("set:font:font_size:charspace:wordspace:textmode:origin_position:textmatrix:")]
        void Set (uint version, FSFont font, float font_size, float charspace, float wordspace, FSTextStateMode textmode, FSPointF origin_position, NSNumber[] textmatrix);

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSImageObject : FSGraphicsObject
    [BaseType (typeof(FSGraphicsObject))]
    [DisableDefaultCtor]
    interface FSImageObject
    {
        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // +(FSImageObject *)create:(FSPDFDoc *)document;
        [Static]
        [Export ("create:")]
        FSImageObject Create (FSPDFDoc document);

        // -(void)setBitmap:(FSBitmap *)bitmap mask:(FSBitmap *)mask;
        [Export ("setBitmap:mask:")]
        void SetBitmap (FSBitmap bitmap, FSBitmap mask);

        // -(void)setImage:(FSImage *)image frame_index:(int)frame_index;
        [Export ("setImage:frame_index:")]
        void SetImage (FSImage image, int frame_index);

        // -(FSBitmap *)cloneBitmap:(FSGraphicsObjects *)graphics_objects;
        [Export ("cloneBitmap:")]
        FSBitmap CloneBitmap (FSGraphicsObjects graphics_objects);

        // -(FSImageObjectColorSpace)getColorSpace;
        [Export ("getColorSpace")]
        //[Verify (MethodToProperty)]
        FSImageObjectColorSpace ColorSpace { get; }

        // -(FSPDFStream *)getStream;
        [Export ("getStream")]
        //[Verify (MethodToProperty)]
        FSPDFStream Stream { get; }

        // -(BOOL)isImageMask;
        [Export ("isImageMask")]
        //[Verify (MethodToProperty)]
        bool IsImageMask { get; }

        // -(FSPDFObject *)getMask;
        [Export ("getMask")]
        //[Verify (MethodToProperty)]
        FSPDFObject Mask { get; }

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSTextObject : FSGraphicsObject
    [BaseType (typeof(FSGraphicsObject))]
    [DisableDefaultCtor]
    interface FSTextObject
    {
        // @property (getter = getText, nonatomic, weak) NSString * text;
        [Export ("text", ArgumentSemantic.Weak)]
        string Text { [Bind ("getText")] get; set; }

        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // +(FSTextObject *)create;
        [Static]
        [Export ("create")]
        //[Verify (MethodToProperty)]
        FSTextObject Create { get; }

        // -(FSTextState *)getTextState:(FSPDFPage *)page;
        [Export ("getTextState:")]
        FSTextState GetTextState (FSPDFPage page);

        // -(void)setTextState:(FSPDFPage *)page text_state:(FSTextState *)text_state is_italic:(BOOL)is_italic weight:(int)weight;
        [Export ("setTextState:text_state:is_italic:weight:")]
        void SetTextState (FSPDFPage page, FSTextState text_state, bool is_italic, int weight);

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSPathObject : FSGraphicsObject
    [BaseType (typeof(FSGraphicsObject))]
    [DisableDefaultCtor]
    interface FSPathObject
    {
        // @property (getter = getFillMode, nonatomic) FSFillMode fillMode;
        [Export ("fillMode", ArgumentSemantic.Assign)]
        FSFillMode FillMode { [Bind ("getFillMode")] get; set; }

        // @property (getter = getStrokeState, nonatomic) BOOL strokeState;
        [Export ("strokeState")]
        bool StrokeState { [Bind ("getStrokeState")] get; set; }

        // @property (getter = getPathData, nonatomic, weak) FSPath * pathData;
        [Export ("pathData", ArgumentSemantic.Weak)]
        FSPath PathData { [Bind ("getPathData")] get; set; }

        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // +(FSPathObject *)create;
        [Static]
        [Export ("create")]
        //[Verify (MethodToProperty)]
        FSPathObject Create { get; }

        // +(FSPathObject *)createFromTextObject:(FSPDFPage *)page text_obj:(FSTextObject *)text_obj;
        [Static]
        [Export ("createFromTextObject:text_obj:")]
        FSPathObject CreateFromTextObject (FSPDFPage page, FSTextObject text_obj);

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSFormXObject : FSGraphicsObject
    [BaseType (typeof(FSGraphicsObject))]
    [DisableDefaultCtor]
    interface FSFormXObject
    {
        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // +(FSFormXObject *)create:(FSPDFDoc *)document;
        [Static]
        [Export ("create:")]
        FSFormXObject Create (FSPDFDoc document);

        // -(FSPDFStream *)getStream;
        [Export ("getStream")]
        //[Verify (MethodToProperty)]
        FSPDFStream Stream { get; }

        // -(FSGraphicsObjects *)getGraphicsObjects;
        [Export ("getGraphicsObjects")]
        //[Verify (MethodToProperty)]
        FSGraphicsObjects GraphicsObjects { get; }

        // -(BOOL)importPageContent:(FSPDFPage *)source_page is_annots_included:(BOOL)is_annots_included;
        [Export ("importPageContent:is_annots_included:")]
        bool ImportPageContent (FSPDFPage source_page, bool is_annots_included);

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSShadingObject : FSGraphicsObject
    [BaseType (typeof(FSGraphicsObject))]
    [DisableDefaultCtor]
    interface FSShadingObject
    {
        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(FSPDFObject *)getPDFObject;
        [Export ("getPDFObject")]
        //[Verify (MethodToProperty)]
        FSPDFObject PDFObject { get; }

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSGraphicsObjects : FSBase
    [BaseType (typeof(FSBase))]
    interface FSGraphicsObjects
    {
        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(id)initWithOther:(FSGraphicsObjects *)other;
        [Export ("initWithOther:")]
        IntPtr Constructor (FSGraphicsObjects other);

        // -(BOOL)isEmpty;
        [Export ("isEmpty")]
        //[Verify (MethodToProperty)]
        bool IsEmpty { get; }

        // -(SWIGTYPE_p_void *)getFirstGraphicsObjectPosition:(FSGraphicsObjectType)filter;
        [Export ("getFirstGraphicsObjectPosition:")]
        SWIGTYPE_p_void GetFirstGraphicsObjectPosition (FSGraphicsObjectType filter);

        // -(SWIGTYPE_p_void *)getNextGraphicsObjectPosition:(SWIGTYPE_p_void *)position filter:(FSGraphicsObjectType)filter;
        [Export ("getNextGraphicsObjectPosition:filter:")]
        SWIGTYPE_p_void GetNextGraphicsObjectPosition (SWIGTYPE_p_void position, FSGraphicsObjectType filter);

        // -(SWIGTYPE_p_void *)getLastGraphicsObjectPosition:(FSGraphicsObjectType)filter;
        [Export ("getLastGraphicsObjectPosition:")]
        SWIGTYPE_p_void GetLastGraphicsObjectPosition (FSGraphicsObjectType filter);

        // -(SWIGTYPE_p_void *)getPrevGraphicsObjectPosition:(SWIGTYPE_p_void *)position filter:(FSGraphicsObjectType)filter;
        [Export ("getPrevGraphicsObjectPosition:filter:")]
        SWIGTYPE_p_void GetPrevGraphicsObjectPosition (SWIGTYPE_p_void position, FSGraphicsObjectType filter);

        // -(FSGraphicsObject *)getGraphicsObject:(SWIGTYPE_p_void *)position;
        [Export ("getGraphicsObject:")]
        FSGraphicsObject GetGraphicsObject (SWIGTYPE_p_void position);

        // -(SWIGTYPE_p_void *)insertGraphicsObject:(SWIGTYPE_p_void *)position_insert_after graphics_object:(FSGraphicsObject *)graphics_object;
        [Export ("insertGraphicsObject:graphics_object:")]
        SWIGTYPE_p_void InsertGraphicsObject (SWIGTYPE_p_void position_insert_after, FSGraphicsObject graphics_object);

        // -(BOOL)removeGraphicsObject:(FSGraphicsObject *)graphics_object;
        [Export ("removeGraphicsObject:")]
        bool RemoveGraphicsObject (FSGraphicsObject graphics_object);

        // -(BOOL)removeGraphicsObjectByPosition:(SWIGTYPE_p_void *)position;
        [Export ("removeGraphicsObjectByPosition:")]
        bool RemoveGraphicsObjectByPosition (SWIGTYPE_p_void position);

        // -(BOOL)generateContent;
        [Export ("generateContent")]
        //[Verify (MethodToProperty)]
        bool GenerateContent { get; }

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSPDFPage : FSGraphicsObjects
    [BaseType (typeof(FSGraphicsObjects))]
    [DisableDefaultCtor]
    interface FSPDFPage
    {
        // @property (getter = getRotation, nonatomic) FSRotation rotation;
        [Export ("rotation", ArgumentSemantic.Assign)]
        FSRotation Rotation { [Bind ("getRotation")] get; set; }

        // @property (getter = getUserUnitSize, nonatomic) float userUnitSize;
        [Export ("userUnitSize")]
        float UserUnitSize { [Bind ("getUserUnitSize")] get; set; }

        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(id)initWithDocument:(FSPDFDoc *)document page_dict:(FSPDFDictionary *)page_dict;
        [Export ("initWithDocument:page_dict:")]
        IntPtr Constructor (FSPDFDoc document, FSPDFDictionary page_dict);

        // -(FSPDFDoc *)getDocument;
        [Export ("getDocument")]
        //[Verify (MethodToProperty)]
        FSPDFDoc Document { get; }

        // -(FSPDFDictionary *)getDict;
        [Export ("getDict")]
        //[Verify (MethodToProperty)]
        FSPDFDictionary Dict { get; }

        // -(BOOL)isParsed;
        [Export ("isParsed")]
        //[Verify (MethodToProperty)]
        bool IsParsed { get; }

        // -(FSProgressive *)startParse:(unsigned int)flags pause:(id<FSPauseCallback>)pause is_reparse:(BOOL)is_reparse;
        [Export ("startParse:pause:is_reparse:")]
        FSProgressive StartParse (uint flags, FSPauseCallback pause, bool is_reparse);

        // -(int)getIndex;
        [Export ("getIndex")]
        //[Verify (MethodToProperty)]
        int Index { get; }

        // -(float)getHeight;
        [Export ("getHeight")]
        //[Verify (MethodToProperty)]
        float Height { get; }

        // -(float)getWidth;
        [Export ("getWidth")]
        //[Verify (MethodToProperty)]
        float Width { get; }

        // -(FSBitmap *)loadThumbnail;
        [Export ("loadThumbnail")]
        //[Verify (MethodToProperty)]
        FSBitmap LoadThumbnail { get; }

        // -(FSMatrix2D *)getDisplayMatrix:(int)left top:(int)top width:(int)width height:(int)height rotate:(FSRotation)rotate;
        [Export ("getDisplayMatrix:top:width:height:rotate:")]
        FSMatrix2D GetDisplayMatrix (int left, int top, int width, int height, FSRotation rotate);

        // -(FSRectF *)calcContentBBox:(FSPDFPageCalcMarginMode)mode;
        [Export ("calcContentBBox:")]
        FSRectF CalcContentBBox (FSPDFPageCalcMarginMode mode);

        // -(int)getAnnotCount;
        [Export ("getAnnotCount")]
        //[Verify (MethodToProperty)]
        int AnnotCount { get; }

        // -(FSAnnot *)getAnnot:(int)index;
        [Export ("getAnnot:")]
        FSAnnot GetAnnot (int index);

        // -(FSAnnot *)getAnnotAtPoint:(FSPointF *)position tolerance:(float)tolerance;
        [Export ("getAnnotAtPoint:tolerance:")]
        FSAnnot GetAnnotAtPoint (FSPointF position, float tolerance);

        // -(FSAnnot *)getAnnotAtDevicePoint:(FSPointF *)position tolerance:(float)tolerance matrix:(FSMatrix2D *)matrix;
        [Export ("getAnnotAtDevicePoint:tolerance:matrix:")]
        FSAnnot GetAnnotAtDevicePoint (FSPointF position, float tolerance, FSMatrix2D matrix);

        // -(FSAnnot *)addAnnot:(FSAnnotType)type rect:(FSRectF *)rect;
        [Export ("addAnnot:rect:")]
        FSAnnot AddAnnot (FSAnnotType type, FSRectF rect);

        // -(BOOL)removeAnnot:(FSAnnot *)annot;
        [Export ("removeAnnot:")]
        bool RemoveAnnot (FSAnnot annot);

        // -(void)moveAnnotToFirst:(FSAnnot *)annot;
        [Export ("moveAnnotToFirst:")]
        void MoveAnnotToFirst (FSAnnot annot);

        // -(void)moveAnnotToLast:(FSAnnot *)annot;
        [Export ("moveAnnotToLast:")]
        void MoveAnnotToLast (FSAnnot annot);

        // -(void)moveAnnotToPrev:(FSAnnot *)annot;
        [Export ("moveAnnotToPrev:")]
        void MoveAnnotToPrev (FSAnnot annot);

        // -(void)moveAnnotToNext:(FSAnnot *)annot;
        [Export ("moveAnnotToNext:")]
        void MoveAnnotToNext (FSAnnot annot);

        // -(BOOL)hasTransparency;
        [Export ("hasTransparency")]
        //[Verify (MethodToProperty)]
        bool HasTransparency { get; }

        // -(BOOL)flatten:(BOOL)for_display options:(unsigned int)options;
        [Export ("flatten:options:")]
        bool Flatten (bool for_display, uint options);

        // -(BOOL)setAnnotGroup:(FSMarkupArray *)annot_array header_index:(int)header_index;
        [Export ("setAnnotGroup:header_index:")]
        bool SetAnnotGroup (FSMarkupArray annot_array, int header_index);

        // -(FSSignature *)addSignature:(FSRectF *)rect;
        [Export ("addSignature:")]
        FSSignature AddSignature (FSRectF rect);

        // -(BOOL)hasWatermark;
        [Export ("hasWatermark")]
        //[Verify (MethodToProperty)]
        bool HasWatermark { get; }

        // -(BOOL)removeAllWatermarks;
        [Export ("removeAllWatermarks")]
        //[Verify (MethodToProperty)]
        bool RemoveAllWatermarks { get; }

        // -(void)setSize:(float)width height:(float)height;
        [Export ("setSize:height:")]
        void SetSize (float width, float height);

        // -(void)setBox:(FSPDFPageBoxType)box_type box:(FSRectF *)box;
        [Export ("setBox:box:")]
        void SetBox (FSPDFPageBoxType box_type, FSRectF box);

        // -(FSRectF *)getBox:(FSPDFPageBoxType)box_type;
        [Export ("getBox:")]
        FSRectF GetBox (FSPDFPageBoxType box_type);

        // -(BOOL)transform:(FSMatrix2D *)matrix need_transform_clip_path:(BOOL)need_transform_clip_path;
        [Export ("transform:need_transform_clip_path:")]
        bool Transform (FSMatrix2D matrix, bool need_transform_clip_path);

        // -(void)setClipRect:(FSRectF *)clip_rect;
        [Export ("setClipRect:")]
        void SetClipRect (FSRectF clip_rect);

        // -(void)setThumbnail:(FSBitmap *)thumbnail;
        [Export ("setThumbnail:")]
        void SetThumbnail (FSBitmap thumbnail);

        // -(FSGraphicsObject *)getGraphicsObjectAtPoint:(FSPointF *)point tolerance:(float)tolerance filter:(FSGraphicsObjectType)filter;
        [Export ("getGraphicsObjectAtPoint:tolerance:filter:")]
        FSGraphicsObject GetGraphicsObjectAtPoint (FSPointF point, float tolerance, FSGraphicsObjectType filter);

        // -(FSGraphicsObjectArray *)getGraphicsObjectsAtPoint:(FSPointF *)point tolerance:(float)tolerance filter:(FSGraphicsObjectType)filter;
        [Export ("getGraphicsObjectsAtPoint:tolerance:filter:")]
        FSGraphicsObjectArray GetGraphicsObjectsAtPoint (FSPointF point, float tolerance, FSGraphicsObjectType filter);

        // -(BOOL)addImageFromFilePath:(NSString *)file_path position:(FSPointF *)position width:(float)width height:(float)height auto_generate_content:(BOOL)auto_generate_content;
        [Export ("addImageFromFilePath:position:width:height:auto_generate_content:")]
        bool AddImageFromFilePath (string file_path, FSPointF position, float width, float height, bool auto_generate_content);

        // -(FSPDFArray *)getAnnots;
        [Export ("getAnnots")]
        //[Verify (MethodToProperty)]
        FSPDFArray Annots { get; }

        // -(FSPDFDictionary *)getResources;
        [Export ("getResources")]
        //[Verify (MethodToProperty)]
        FSPDFDictionary Resources { get; }

        // -(FSPDFObject *)getContents;
        [Export ("getContents")]
        //[Verify (MethodToProperty)]
        FSPDFObject Contents { get; }

        // -(FSPDFStream *)getThumb;
        [Export ("getThumb")]
        //[Verify (MethodToProperty)]
        FSPDFStream Thumb { get; }

        // -(FSPDFObject *)getInheritedAttribute:(NSString *)attruibute_name;
        [Export ("getInheritedAttribute:")]
        FSPDFObject GetInheritedAttribute (string attruibute_name);

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSDocViewerPrefs : FSBase
    [BaseType (typeof(FSBase))]
    [DisableDefaultCtor]
    interface FSDocViewerPrefs
    {
        // @property (getter = getNonFullScreenPageMode, nonatomic) FSPDFDocDisplayMode nonFullScreenPageMode;
        [Export ("nonFullScreenPageMode", ArgumentSemantic.Assign)]
        FSPDFDocDisplayMode NonFullScreenPageMode { [Bind ("getNonFullScreenPageMode")] get; set; }

        // @property (getter = getReadingDirection, nonatomic) BOOL readingDirection;
        [Export ("readingDirection")]
        bool ReadingDirection { [Bind ("getReadingDirection")] get; set; }

        // @property (getter = getViewArea, nonatomic) FSPDFPageBoxType viewArea;
        [Export ("viewArea", ArgumentSemantic.Assign)]
        FSPDFPageBoxType ViewArea { [Bind ("getViewArea")] get; set; }

        // @property (getter = getViewClip, nonatomic) FSPDFPageBoxType viewClip;
        [Export ("viewClip", ArgumentSemantic.Assign)]
        FSPDFPageBoxType ViewClip { [Bind ("getViewClip")] get; set; }

        // @property (getter = getPrintArea, nonatomic) FSPDFPageBoxType printArea;
        [Export ("printArea", ArgumentSemantic.Assign)]
        FSPDFPageBoxType PrintArea { [Bind ("getPrintArea")] get; set; }

        // @property (getter = getPrintClip, nonatomic) FSPDFPageBoxType printClip;
        [Export ("printClip", ArgumentSemantic.Assign)]
        FSPDFPageBoxType PrintClip { [Bind ("getPrintClip")] get; set; }

        // @property (getter = getPrintScale, nonatomic) FSDocViewerPrefsPrintScale printScale;
        [Export ("printScale", ArgumentSemantic.Assign)]
        FSDocViewerPrefsPrintScale PrintScale { [Bind ("getPrintScale")] get; set; }

        // @property (getter = getPrintCopies, nonatomic) int printCopies;
        [Export ("printCopies")]
        int PrintCopies { [Bind ("getPrintCopies")] get; set; }

        // @property (getter = getPrintRange, nonatomic, weak) FSRange * printRange;
        [Export ("printRange", ArgumentSemantic.Weak)]
        FSRange PrintRange { [Bind ("getPrintRange")] get; set; }

        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(id)initWithDocument:(FSPDFDoc *)document pdf_dict:(FSPDFDictionary *)pdf_dict;
        [Export ("initWithDocument:pdf_dict:")]
        IntPtr Constructor (FSPDFDoc document, FSPDFDictionary pdf_dict);

        // -(id)initWithOther:(FSDocViewerPrefs *)other;
        [Export ("initWithOther:")]
        IntPtr Constructor (FSDocViewerPrefs other);

        // -(BOOL)isEmpty;
        [Export ("isEmpty")]
        //[Verify (MethodToProperty)]
        bool IsEmpty { get; }

        // -(BOOL)getUIDisplayStatus:(FSDocViewerPrefsViewerPref)pref;
        [Export ("getUIDisplayStatus:")]
        bool GetUIDisplayStatus (FSDocViewerPrefsViewerPref pref);

        // -(void)setUIDisplayStatus:(FSDocViewerPrefsViewerPref)pref value:(BOOL)value;
        [Export ("setUIDisplayStatus:value:")]
        void SetUIDisplayStatus (FSDocViewerPrefsViewerPref pref, bool value);

        // -(FSPDFDictionary *)getDict;
        [Export ("getDict")]
        //[Verify (MethodToProperty)]
        FSPDFDictionary Dict { get; }

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSPageLabels : FSBase
    [BaseType (typeof(FSBase))]
    [DisableDefaultCtor]
    interface FSPageLabels
    {
        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(id)initWithDocument:(FSPDFDoc *)document;
        [Export ("initWithDocument:")]
        IntPtr Constructor (FSPDFDoc document);

        // -(id)initWithOther:(FSPageLabels *)other;
        [Export ("initWithOther:")]
        IntPtr Constructor (FSPageLabels other);

        // -(BOOL)isEmpty;
        [Export ("isEmpty")]
        //[Verify (MethodToProperty)]
        bool IsEmpty { get; }

        // -(NSString *)getPageLabelTitle:(int)page_index;
        [Export ("getPageLabelTitle:")]
        string GetPageLabelTitle (int page_index);

        // -(BOOL)hasPageLabel:(int)page_index;
        [Export ("hasPageLabel:")]
        bool HasPageLabel (int page_index);

        // -(FSPageLabelsStyle)getPageLabelStyle:(int)page_index;
        [Export ("getPageLabelStyle:")]
        FSPageLabelsStyle GetPageLabelStyle (int page_index);

        // -(NSString *)getPageLabelPrefix:(int)page_index;
        [Export ("getPageLabelPrefix:")]
        string GetPageLabelPrefix (int page_index);

        // -(int)getPageLabelStart:(int)page_index;
        [Export ("getPageLabelStart:")]
        int GetPageLabelStart (int page_index);

        // -(void)setPageLabel:(int)page_index label_style:(FSPageLabelsStyle)label_style first_label_number:(int)first_label_number prefix_string:(NSString *)prefix_string;
        [Export ("setPageLabel:label_style:first_label_number:prefix_string:")]
        void SetPageLabel (int page_index, FSPageLabelsStyle label_style, int first_label_number, string prefix_string);

        // -(void)removePageLabel:(int)page_index;
        [Export ("removePageLabel:")]
        void RemovePageLabel (int page_index);

        // -(void)removeAll;
        [Export ("removeAll")]
        void RemoveAll ();

        // -(FSPDFNumberTree *)getNumberTree;
        [Export ("getNumberTree")]
        //[Verify (MethodToProperty)]
        FSPDFNumberTree NumberTree { get; }

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSPSI : FSBase
    [BaseType (typeof(FSBase))]
    [DisableDefaultCtor]
    interface FSPSI
    {
        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(id)initWithBitmap:(FSBitmap *)bitmap simulate:(BOOL)simulate;
        [Export ("initWithBitmap:simulate:")]
        IntPtr Constructor (FSBitmap bitmap, bool simulate);

        // -(id)initWithWidth:(int)width height:(int)height simulate:(BOOL)simulate;
        [Export ("initWithWidth:height:simulate:")]
        IntPtr Constructor (int width, int height, bool simulate);

        // -(id)initWithOther:(FSPSI *)other;
        [Export ("initWithOther:")]
        IntPtr Constructor (FSPSI other);

        // -(BOOL)isEmpty;
        [Export ("isEmpty")]
        //[Verify (MethodToProperty)]
        bool IsEmpty { get; }

        // -(void)setCallback:(id<FSPSICallback>)callback;
        [Export ("setCallback:")]
        void SetCallback (FSPSICallback callback);

        // -(void)setColor:(unsigned int)color;
        [Export ("setColor:")]
        void SetColor (uint color);

        // -(void)setDiameter:(int)diameter;
        [Export ("setDiameter:")]
        void SetDiameter (int diameter);

        // -(void)setOpacity:(float)opacity;
        [Export ("setOpacity:")]
        void SetOpacity (float opacity);

        // -(void)addPoint:(FSPointF *)point type:(FSPathPointType)type pressure:(float)pressure;
        [Export ("addPoint:type:pressure:")]
        void AddPoint (FSPointF point, FSPathPointType type, float pressure);

        // -(FSRectF *)getContentsRect;
        [Export ("getContentsRect")]
        //[Verify (MethodToProperty)]
        FSRectF ContentsRect { get; }

        // -(FSBitmap *)getBitmap;
        [Export ("getBitmap")]
        //[Verify (MethodToProperty)]
        FSBitmap Bitmap { get; }

        // -(FSPSInk *)convertToPDFAnnot:(FSPDFPage *)page annot_rect:(FSRectF *)annot_rect rotate:(FSRotation)rotate;
        [Export ("convertToPDFAnnot:annot_rect:rotate:")]
        FSPSInk ConvertToPDFAnnot (FSPDFPage page, FSRectF annot_rect, FSRotation rotate);

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSReadingBookmark : FSBase
    [BaseType (typeof(FSBase))]
    [DisableDefaultCtor]
    interface FSReadingBookmark
    {
        // @property (getter = getTitle, nonatomic, weak) NSString * title;
        [Export ("title", ArgumentSemantic.Weak)]
        string Title { [Bind ("getTitle")] get; set; }

        // @property (getter = getPageIndex, nonatomic) int pageIndex;
        [Export ("pageIndex")]
        int PageIndex { [Bind ("getPageIndex")] get; set; }

        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(id)initWithOther:(FSReadingBookmark *)other;
        [Export ("initWithOther:")]
        IntPtr Constructor (FSReadingBookmark other);

        // -(BOOL)isEmpty;
        [Export ("isEmpty")]
        //[Verify (MethodToProperty)]
        bool IsEmpty { get; }

        // -(FSDateTime *)getDateTime:(BOOL)is_creation_date;
        [Export ("getDateTime:")]
        FSDateTime GetDateTime (bool is_creation_date);

        // -(void)setDateTime:(FSDateTime *)date_time is_creation_date:(BOOL)is_creation_date;
        [Export ("setDateTime:is_creation_date:")]
        void SetDateTime (FSDateTime date_time, bool is_creation_date);

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSReflowPage : FSBase
    [BaseType (typeof(FSBase))]
    [DisableDefaultCtor]
    interface FSReflowPage
    {
        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(id)initWithPage:(FSPDFPage *)page;
        [Export ("initWithPage:")]
        IntPtr Constructor (FSPDFPage page);

        // -(id)initWithOther:(FSReflowPage *)other;
        [Export ("initWithOther:")]
        IntPtr Constructor (FSReflowPage other);

        // -(BOOL)isEmpty;
        [Export ("isEmpty")]
        //[Verify (MethodToProperty)]
        bool IsEmpty { get; }

        // -(void)setScreenSize:(float)width height:(float)height;
        [Export ("setScreenSize:height:")]
        void SetScreenSize (float width, float height);

        // -(void)setScreenMargin:(int)left top:(int)top right:(int)right bottom:(int)bottom;
        [Export ("setScreenMargin:top:right:bottom:")]
        void SetScreenMargin (int left, int top, int right, int bottom);

        // -(void)setZoom:(int)zoom;
        [Export ("setZoom:")]
        void SetZoom (int zoom);

        // -(void)setParseFlags:(unsigned int)flags;
        [Export ("setParseFlags:")]
        void SetParseFlags (uint flags);

        // -(void)setLineSpace:(float)line_space;
        [Export ("setLineSpace:")]
        void SetLineSpace (float line_space);

        // -(void)setTopSpace:(float)top_space;
        [Export ("setTopSpace:")]
        void SetTopSpace (float top_space);

        // -(FSProgressive *)startParse:(id<FSPauseCallback>)pause;
        [Export ("startParse:")]
        FSProgressive StartParse (FSPauseCallback pause);

        // -(float)getContentWidth;
        [Export ("getContentWidth")]
        //[Verify (MethodToProperty)]
        float ContentWidth { get; }

        // -(float)getContentHeight;
        [Export ("getContentHeight")]
        //[Verify (MethodToProperty)]
        float ContentHeight { get; }

        // -(FSMatrix2D *)getDisplayMatrix:(float)offset_x offset_y:(float)offset_y;
        [Export ("getDisplayMatrix:offset_y:")]
        FSMatrix2D GetDisplayMatrix (float offset_x, float offset_y);

        // -(NSString *)getFocusData:(FSMatrix2D *)matrix point:(FSPointF *)point;
        [Export ("getFocusData:point:")]
        string GetFocusData (FSMatrix2D matrix, FSPointF point);

        // -(FSPointF *)getFocusPosition:(FSMatrix2D *)matrix focus_data:(NSString *)focus_data;
        [Export ("getFocusPosition:focus_data:")]
        FSPointF GetFocusPosition (FSMatrix2D matrix, string focus_data);

        // -(BOOL)isParsed;
        [Export ("isParsed")]
        //[Verify (MethodToProperty)]
        bool IsParsed { get; }

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSTextPage : FSBase
    [BaseType (typeof(FSBase))]
    [DisableDefaultCtor]
    interface FSTextPage
    {
        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(id)initWithPage:(FSPDFPage *)page flags:(int)flags;
        [Export ("initWithPage:flags:")]
        IntPtr Constructor (FSPDFPage page, int flags);

        // -(id)initWithOther:(FSTextPage *)other;
        [Export ("initWithOther:")]
        IntPtr Constructor (FSTextPage other);

        // -(BOOL)isEmpty;
        [Export ("isEmpty")]
        //[Verify (MethodToProperty)]
        bool IsEmpty { get; }

        // -(int)getCharCount;
        [Export ("getCharCount")]
        //[Verify (MethodToProperty)]
        int CharCount { get; }

        // -(NSString *)getChars:(int)start count:(int)count;
        [Export ("getChars:count:")]
        string GetChars (int start, int count);

        // -(int)getIndexAtPos:(float)x y:(float)y tolerance:(float)tolerance;
        [Export ("getIndexAtPos:y:tolerance:")]
        int GetIndexAtPos (float x, float y, float tolerance);

        // -(NSString *)getTextInRect:(FSRectF *)rect;
        [Export ("getTextInRect:")]
        string GetTextInRect (FSRectF rect);

        // -(FSRange *)getWordAtPos:(float)x y:(float)y tolerance:(float)tolerance;
        [Export ("getWordAtPos:y:tolerance:")]
        FSRange GetWordAtPos (float x, float y, float tolerance);

        // -(int)getTextRectCount:(int)start count:(int)count;
        [Export ("getTextRectCount:count:")]
        int GetTextRectCount (int start, int count);

        // -(FSRectF *)getTextRect:(int)rect_index;
        [Export ("getTextRect:")]
        FSRectF GetTextRect (int rect_index);

        // -(FSRotation)getBaselineRotation:(int)rect_index;
        [Export ("getBaselineRotation:")]
        FSRotation GetBaselineRotation (int rect_index);

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSTextSearch : FSBase
    [BaseType (typeof(FSBase))]
    [DisableDefaultCtor]
    interface FSTextSearch
    {
        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(id)initWithDocument:(FSPDFDoc *)document cancel:(id<FSSearchCancelCallback>)cancel;
        [Export ("initWithDocument:cancel:")]
        IntPtr Constructor (FSPDFDoc document, FSSearchCancelCallback cancel);

        // -(id)initWithXfa_document:(FSXFADoc *)xfa_document;
        [Export ("initWithXfa_document:")]
        IntPtr Constructor (FSXFADoc xfa_document);

        // -(id)initWithAnnot:(FSAnnot *)annot;
        [Export ("initWithAnnot:")]
        IntPtr Constructor (FSAnnot annot);

        // -(id)initWithOther:(FSTextSearch *)other;
        [Export ("initWithOther:")]
        IntPtr Constructor (FSTextSearch other);

        // -(BOOL)isEmpty;
        [Export ("isEmpty")]
        //[Verify (MethodToProperty)]
        bool IsEmpty { get; }

        // -(BOOL)setPattern:(NSString *)key_words;
        [Export ("setPattern:")]
        bool SetPattern (string key_words);

        // -(BOOL)setStartPage:(int)page_index;
        [Export ("setStartPage:")]
        bool SetStartPage (int page_index);

        // -(BOOL)setEndPage:(int)page_index;
        [Export ("setEndPage:")]
        bool SetEndPage (int page_index);

        // -(BOOL)setSearchFlags:(unsigned int)search_flags;
        [Export ("setSearchFlags:")]
        bool SetSearchFlags (uint search_flags);

        // -(BOOL)findNext;
        [Export ("findNext")]
        //[Verify (MethodToProperty)]
        bool FindNext { get; }

        // -(BOOL)findPrev;
        [Export ("findPrev")]
        //[Verify (MethodToProperty)]
        bool FindPrev { get; }

        // -(FSRectFArray *)getMatchRects;
        [Export ("getMatchRects")]
        //[Verify (MethodToProperty)]
        FSRectFArray MatchRects { get; }

        // -(int)getMatchPageIndex;
        [Export ("getMatchPageIndex")]
        //[Verify (MethodToProperty)]
        int MatchPageIndex { get; }

        // -(NSString *)getMatchSentence;
        [Export ("getMatchSentence")]
        //[Verify (MethodToProperty)]
        string MatchSentence { get; }

        // -(int)getMatchSentenceStartIndex;
        [Export ("getMatchSentenceStartIndex")]
        //[Verify (MethodToProperty)]
        int MatchSentenceStartIndex { get; }

        // -(int)getMatchStartCharIndex;
        [Export ("getMatchStartCharIndex")]
        //[Verify (MethodToProperty)]
        int MatchStartCharIndex { get; }

        // -(int)getMatchEndCharIndex;
        [Export ("getMatchEndCharIndex")]
        //[Verify (MethodToProperty)]
        int MatchEndCharIndex { get; }

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSTextLink : FSBase
    [BaseType (typeof(FSBase))]
    [DisableDefaultCtor]
    interface FSTextLink
    {
        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(id)initWithOther:(FSTextLink *)other;
        [Export ("initWithOther:")]
        IntPtr Constructor (FSTextLink other);

        // -(BOOL)isEmpty;
        [Export ("isEmpty")]
        //[Verify (MethodToProperty)]
        bool IsEmpty { get; }

        // -(NSString *)getURI;
        [Export ("getURI")]
        //[Verify (MethodToProperty)]
        string URI { get; }

        // -(int)getStartCharIndex;
        [Export ("getStartCharIndex")]
        //[Verify (MethodToProperty)]
        int StartCharIndex { get; }

        // -(int)getEndCharIndex;
        [Export ("getEndCharIndex")]
        //[Verify (MethodToProperty)]
        int EndCharIndex { get; }

        // -(FSRectFArray *)getRects;
        [Export ("getRects")]
        //[Verify (MethodToProperty)]
        FSRectFArray Rects { get; }

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSPageTextLinks : FSBase
    [BaseType (typeof(FSBase))]
    [DisableDefaultCtor]
    interface FSPageTextLinks
    {
        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(id)initWithPage:(FSTextPage *)page;
        [Export ("initWithPage:")]
        IntPtr Constructor (FSTextPage page);

        // -(id)initWithOther:(FSPageTextLinks *)other;
        [Export ("initWithOther:")]
        IntPtr Constructor (FSPageTextLinks other);

        // -(BOOL)isEmpty;
        [Export ("isEmpty")]
        //[Verify (MethodToProperty)]
        bool IsEmpty { get; }

        // -(int)getTextLinkCount;
        [Export ("getTextLinkCount")]
        //[Verify (MethodToProperty)]
        int TextLinkCount { get; }

        // -(FSTextLink *)getTextLink:(int)index;
        [Export ("getTextLink:")]
        FSTextLink GetTextLink (int index);

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSEnvelopeArray : FSBasicArray
    [BaseType (typeof(FSBasicArray))]
    interface FSEnvelopeArray
    {
        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(id)initWithOther:(FSEnvelopeArray *)other;
        [Export ("initWithOther:")]
        IntPtr Constructor (FSEnvelopeArray other);

        // -(int)getSize;
        [Export ("getSize")]
        //[Verify (MethodToProperty)]
        int Size { get; }

        // -(int)getUpperBound;
        [Export ("getUpperBound")]
        //[Verify (MethodToProperty)]
        int UpperBound { get; }

        // -(int)setSize:(int)nNewSize nGrowBy:(int)nGrowBy;
        [Export ("setSize:nGrowBy:")]
        int SetSize (int nNewSize, int nGrowBy);

        // -(void)removeAll;
        [Export ("removeAll")]
        void RemoveAll ();

        // -(FSEnvelope *)getAt:(int)nIndex;
        [Export ("getAt:")]
        FSEnvelope GetAt (int nIndex);

        // -(int)setAt:(int)nIndex newElement:(FSEnvelope *)newElement;
        [Export ("setAt:newElement:")]
        int SetAt (int nIndex, FSEnvelope newElement);

        // -(int)setAtGrow:(int)nIndex newElement:(FSEnvelope *)newElement;
        [Export ("setAtGrow:newElement:")]
        int SetAtGrow (int nIndex, FSEnvelope newElement);

        // -(int)add:(FSEnvelope *)newElement;
        [Export ("add:")]
        int Add (FSEnvelope newElement);

        // -(int)insertAt:(int)nIndex newElement:(FSEnvelope *)newElement nCount:(int)nCount;
        [Export ("insertAt:newElement:nCount:")]
        int InsertAt (int nIndex, FSEnvelope newElement, int nCount);

        // -(int)removeAt:(int)nIndex nCount:(int)nCount;
        [Export ("removeAt:nCount:")]
        int RemoveAt (int nIndex, int nCount);

        // -(int)find:(FSEnvelope *)data iStart:(int)iStart;
        [Export ("find:iStart:")]
        int Find (FSEnvelope data, int iStart);

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSSecurityHandler : FSBase
    [BaseType (typeof(FSBase))]
    interface FSSecurityHandler
    {
        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(id)initWithOther:(FSSecurityHandler *)other;
        [Export ("initWithOther:")]
        IntPtr Constructor (FSSecurityHandler other);

        // -(BOOL)isEmpty;
        [Export ("isEmpty")]
        //[Verify (MethodToProperty)]
        bool IsEmpty { get; }

        // -(FSPDFDocEncryptType)getSecurityType;
        [Export ("getSecurityType")]
        //[Verify (MethodToProperty)]
        FSPDFDocEncryptType SecurityType { get; }

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSStdEncryptData : NSObject
    [BaseType (typeof(NSObject))]
    interface FSStdEncryptData
    {
        // @property (getter = getIs_encrypt_metadata, nonatomic) BOOL is_encrypt_metadata;
        [Export ("is_encrypt_metadata")]
        bool Is_encrypt_metadata { [Bind ("getIs_encrypt_metadata")] get; set; }

        // @property (getter = getUser_permissions, nonatomic) unsigned int user_permissions;
        [Export ("user_permissions")]
        uint User_permissions { [Bind ("getUser_permissions")] get; set; }

        // @property (getter = getCipher, nonatomic) FSSecurityHandlerCipherType cipher;
        [Export ("cipher", ArgumentSemantic.Assign)]
        FSSecurityHandlerCipherType Cipher { [Bind ("getCipher")] get; set; }

        // @property (getter = getKey_length, nonatomic) int key_length;
        [Export ("key_length")]
        int Key_length { [Bind ("getKey_length")] get; set; }

        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(id)initWithIs_encrypt_metadata:(BOOL)is_encrypt_metadata user_permissions:(unsigned int)user_permissions cipher:(FSSecurityHandlerCipherType)cipher key_length:(int)key_length;
        [Export ("initWithIs_encrypt_metadata:user_permissions:cipher:key_length:")]
        IntPtr Constructor (bool is_encrypt_metadata, uint user_permissions, FSSecurityHandlerCipherType cipher, int key_length);

        // -(id)initWithOther:(FSStdEncryptData *)other;
        [Export ("initWithOther:")]
        IntPtr Constructor (FSStdEncryptData other);

        // -(void)set:(BOOL)is_encrypt_metadata user_permissions:(unsigned int)user_permissions cipher:(FSSecurityHandlerCipherType)cipher key_length:(int)key_length;
        [Export ("set:user_permissions:cipher:key_length:")]
        void Set (bool is_encrypt_metadata, uint user_permissions, FSSecurityHandlerCipherType cipher, int key_length);

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSStdSecurityHandler : FSSecurityHandler
    [BaseType (typeof(FSSecurityHandler))]
    interface FSStdSecurityHandler
    {
        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(id)initWithOther:(FSSecurityHandler *)other;
        [Export ("initWithOther:")]
        IntPtr Constructor (FSSecurityHandler other);

        // -(BOOL)initialize:(FSStdEncryptData *)encrypt_data user_password:(NSString *)user_password owner_password:(NSString *)owner_password;
        [Export ("initialize:user_password:owner_password:")]
        bool Initialize (FSStdEncryptData encrypt_data, string user_password, string owner_password);

        // -(BOOL)initializeW:(FSStdEncryptData *)encrypt_data user_password:(NSString *)user_password owner_password:(NSString *)owner_password;
        [Export ("initializeW:user_password:owner_password:")]
        bool InitializeW (FSStdEncryptData encrypt_data, string user_password, string owner_password);

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSCertificateEncryptData : NSObject
    [BaseType (typeof(NSObject))]
    interface FSCertificateEncryptData
    {
        // @property (getter = getIs_encrypt_metadata, nonatomic) BOOL is_encrypt_metadata;
        [Export ("is_encrypt_metadata")]
        bool Is_encrypt_metadata { [Bind ("getIs_encrypt_metadata")] get; set; }

        // @property (getter = getCipher, nonatomic) FSSecurityHandlerCipherType cipher;
        [Export ("cipher", ArgumentSemantic.Assign)]
        FSSecurityHandlerCipherType Cipher { [Bind ("getCipher")] get; set; }

        // @property (getter = getEnvelopes, nonatomic, weak) NSArray<NSData *> * envelopes;
        [Export ("envelopes", ArgumentSemantic.Weak)]
        NSData[] Envelopes { [Bind ("getEnvelopes")] get; set; }

        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(id)initWithIs_encrypt_metadata:(BOOL)is_encrypt_metadata cipher:(FSSecurityHandlerCipherType)cipher envelopes:(NSArray<NSData *> *)envelopes;
        [Export ("initWithIs_encrypt_metadata:cipher:envelopes:")]
        IntPtr Constructor (bool is_encrypt_metadata, FSSecurityHandlerCipherType cipher, NSData[] envelopes);

        // -(id)initWithOther:(FSCertificateEncryptData *)other;
        [Export ("initWithOther:")]
        IntPtr Constructor (FSCertificateEncryptData other);

        // -(void)set:(BOOL)is_encrypt_metadata cipher:(FSSecurityHandlerCipherType)cipher envelopes:(NSArray<NSData *> *)envelopes;
        [Export ("set:cipher:envelopes:")]
        void Set (bool is_encrypt_metadata, FSSecurityHandlerCipherType cipher, NSData[] envelopes);

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSEnvelope : FSBase
    [BaseType (typeof(FSBase))]
    [DisableDefaultCtor]
    interface FSEnvelope
    {
        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(id)initWithCertFilePath:(NSString *)certFilePath;
        [Export ("initWithCertFilePath:")]
        IntPtr Constructor (string certFilePath);

        // -(id)initWithOther:(FSEnvelope *)other;
        [Export ("initWithOther:")]
        IntPtr Constructor (FSEnvelope other);

        // -(NSString *)getDecryptionKey:(NSString *)p12FilePath password:(NSString *)password;
        [Export ("getDecryptionKey:password:")]
        string GetDecryptionKey (string p12FilePath, string password);

        // -(id)initWithBuffer:(NSData *)buffer;
        [Export ("initWithBuffer:")]
        IntPtr Constructor (NSData buffer);

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSCertificateSecurityHandler : FSSecurityHandler
    [BaseType (typeof(FSSecurityHandler))]
    interface FSCertificateSecurityHandler
    {
        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(id)initWithOther:(FSSecurityHandler *)other;
        [Export ("initWithOther:")]
        IntPtr Constructor (FSSecurityHandler other);

        // -(BOOL)initialize:(FSEnvelopeArray *)envelopes cipher:(FSSecurityHandlerCipherType)cipher is_encrypt_metadata:(BOOL)is_encrypt_metadata;
        [Export ("initialize:cipher:is_encrypt_metadata:")]
        bool Initialize (FSEnvelopeArray envelopes, FSSecurityHandlerCipherType cipher, bool is_encrypt_metadata);

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSDRMEncryptData : NSObject
    [BaseType (typeof(NSObject))]
    interface FSDRMEncryptData
    {
        // @property (getter = getIs_encrypt_metadata, nonatomic) BOOL is_encrypt_metadata;
        [Export ("is_encrypt_metadata")]
        bool Is_encrypt_metadata { [Bind ("getIs_encrypt_metadata")] get; set; }

        // @property (getter = getSub_filter, nonatomic, weak) NSString * sub_filter;
        [Export ("sub_filter", ArgumentSemantic.Weak)]
        string Sub_filter { [Bind ("getSub_filter")] get; set; }

        // @property (getter = getCipher, nonatomic) FSSecurityHandlerCipherType cipher;
        [Export ("cipher", ArgumentSemantic.Assign)]
        FSSecurityHandlerCipherType Cipher { [Bind ("getCipher")] get; set; }

        // @property (getter = getKey_length, nonatomic) int key_length;
        [Export ("key_length")]
        int Key_length { [Bind ("getKey_length")] get; set; }

        // @property (getter = getIs_owner, nonatomic) BOOL is_owner;
        [Export ("is_owner")]
        bool Is_owner { [Bind ("getIs_owner")] get; set; }

        // @property (getter = getUser_permissions, nonatomic) unsigned int user_permissions;
        [Export ("user_permissions")]
        uint User_permissions { [Bind ("getUser_permissions")] get; set; }

        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(id)initWithIs_encrypt_metadata:(BOOL)is_encrypt_metadata sub_filter:(NSString *)sub_filter cipher:(FSSecurityHandlerCipherType)cipher key_length:(int)key_length is_owner:(BOOL)is_owner user_permissions:(unsigned int)user_permissions;
        [Export ("initWithIs_encrypt_metadata:sub_filter:cipher:key_length:is_owner:user_permissions:")]
        IntPtr Constructor (bool is_encrypt_metadata, string sub_filter, FSSecurityHandlerCipherType cipher, int key_length, bool is_owner, uint user_permissions);

        // -(id)initWithOther:(FSDRMEncryptData *)other;
        [Export ("initWithOther:")]
        IntPtr Constructor (FSDRMEncryptData other);

        // -(void)set:(BOOL)is_encrypt_metadata sub_filter:(NSString *)sub_filter cipher:(FSSecurityHandlerCipherType)cipher key_length:(int)key_length is_owner:(BOOL)is_owner user_permissions:(unsigned int)user_permissions;
        [Export ("set:sub_filter:cipher:key_length:is_owner:user_permissions:")]
        void Set (bool is_encrypt_metadata, string sub_filter, FSSecurityHandlerCipherType cipher, int key_length, bool is_owner, uint user_permissions);

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSDRMSecurityHandler : FSSecurityHandler
    [BaseType (typeof(FSSecurityHandler))]
    interface FSDRMSecurityHandler
    {
        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(id)initWithOther:(FSSecurityHandler *)other;
        [Export ("initWithOther:")]
        IntPtr Constructor (FSSecurityHandler other);

        // -(BOOL)initialize:(FSDRMEncryptData *)encrypt_data file_id:(NSString *)file_id initial_key:(NSString *)initial_key;
        [Export ("initialize:file_id:initial_key:")]
        bool Initialize (FSDRMEncryptData encrypt_data, string file_id, string initial_key);

        // -(NSString *)getDRMValue:(NSString *)key;
        [Export ("getDRMValue:")]
        string GetDRMValue (string key);

        // -(BOOL)setDRMValue:(NSString *)key value:(NSString *)value;
        [Export ("setDRMValue:value:")]
        bool SetDRMValue (string key, string value);

        // -(BOOL)verifyEncryptionParams;
        [Export ("verifyEncryptionParams")]
        //[Verify (MethodToProperty)]
        bool VerifyEncryptionParams { get; }

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSCustomEncryptData : NSObject
    [BaseType (typeof(NSObject))]
    interface FSCustomEncryptData
    {
        // @property (getter = getIs_encrypt_metadata, nonatomic) BOOL is_encrypt_metadata;
        [Export ("is_encrypt_metadata")]
        bool Is_encrypt_metadata { [Bind ("getIs_encrypt_metadata")] get; set; }

        // @property (getter = getFilter, nonatomic, weak) NSString * filter;
        [Export ("filter", ArgumentSemantic.Weak)]
        string Filter { [Bind ("getFilter")] get; set; }

        // @property (getter = getSub_filter, nonatomic, weak) NSString * sub_filter;
        [Export ("sub_filter", ArgumentSemantic.Weak)]
        string Sub_filter { [Bind ("getSub_filter")] get; set; }

        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(id)initWithIs_encrypt_metadata:(BOOL)is_encrypt_metadata filter:(NSString *)filter sub_filter:(NSString *)sub_filter;
        [Export ("initWithIs_encrypt_metadata:filter:sub_filter:")]
        IntPtr Constructor (bool is_encrypt_metadata, string filter, string sub_filter);

        // -(id)initWithOther:(FSCustomEncryptData *)other;
        [Export ("initWithOther:")]
        IntPtr Constructor (FSCustomEncryptData other);

        // -(void)set:(BOOL)is_encrypt_metadata filter:(NSString *)filter sub_filter:(NSString *)sub_filter;
        [Export ("set:filter:sub_filter:")]
        void Set (bool is_encrypt_metadata, string filter, string sub_filter);

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSCustomSecurityHandler : FSSecurityHandler
    [BaseType (typeof(FSSecurityHandler))]
    interface FSCustomSecurityHandler
    {
        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(id)initWithOther:(FSSecurityHandler *)other;
        [Export ("initWithOther:")]
        IntPtr Constructor (FSSecurityHandler other);

        // -(BOOL)initialize:(FSCustomEncryptData *)encrypt_data callback:(id<FSCustomSecurityCallback>)callback encrypt_info:(NSString *)encrypt_info;
        [Export ("initialize:callback:encrypt_info:")]
        bool Initialize (FSCustomEncryptData encrypt_data, FSCustomSecurityCallback callback, string encrypt_info);

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSRMSEncryptData : NSObject
    [BaseType (typeof(NSObject))]
    interface FSRMSEncryptData
    {
        // @property (getter = getIs_encrypt_metadata, nonatomic) BOOL is_encrypt_metadata;
        [Export ("is_encrypt_metadata")]
        bool Is_encrypt_metadata { [Bind ("getIs_encrypt_metadata")] get; set; }

        // @property (getter = getPublish_license, nonatomic, weak) NSString * publish_license;
        [Export ("publish_license", ArgumentSemantic.Weak)]
        string Publish_license { [Bind ("getPublish_license")] get; set; }

        // @property (getter = getServer_eul_list, nonatomic, weak) NSArray<NSData *> * server_eul_list;
        [Export ("server_eul_list", ArgumentSemantic.Weak)]
        NSData[] Server_eul_list { [Bind ("getServer_eul_list")] get; set; }

        // @property (getter = getIrm_version, nonatomic) float irm_version;
        [Export ("irm_version")]
        float Irm_version { [Bind ("getIrm_version")] get; set; }

        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(id)initWithIs_encrypt_metadata:(BOOL)is_encrypt_metadata publish_license:(NSString *)publish_license server_eul_list:(NSArray<NSData *> *)server_eul_list irm_version:(float)irm_version;
        [Export ("initWithIs_encrypt_metadata:publish_license:server_eul_list:irm_version:")]
        IntPtr Constructor (bool is_encrypt_metadata, string publish_license, NSData[] server_eul_list, float irm_version);

        // -(id)initWithOther:(FSRMSEncryptData *)other;
        [Export ("initWithOther:")]
        IntPtr Constructor (FSRMSEncryptData other);

        // -(void)set:(BOOL)is_encrypt_metadata publish_license:(NSString *)publish_license server_eul_list:(NSArray<NSData *> *)server_eul_list irm_version:(float)irm_version;
        [Export ("set:publish_license:server_eul_list:irm_version:")]
        void Set (bool is_encrypt_metadata, string publish_license, NSData[] server_eul_list, float irm_version);

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSRMSSecurityHandler : FSSecurityHandler
    [BaseType (typeof(FSSecurityHandler))]
    interface FSRMSSecurityHandler
    {
        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(id)initWithOther:(FSSecurityHandler *)other;
        [Export ("initWithOther:")]
        IntPtr Constructor (FSSecurityHandler other);

        // -(BOOL)initialize:(FSRMSEncryptData *)encrypt_data callback:(id<FSRMSSecurityCallback>)callback;
        [Export ("initialize:callback:")]
        bool Initialize (FSRMSEncryptData encrypt_data, FSRMSSecurityCallback callback);

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSTabOrderMgr : FSBase
    [BaseType (typeof(FSBase))]
    [DisableDefaultCtor]
    interface FSTabOrderMgr
    {
        // @property (getter = getOrderType, nonatomic) FSTabOrderMgrOrderType orderType;
        [Export ("orderType", ArgumentSemantic.Assign)]
        FSTabOrderMgrOrderType OrderType { [Bind ("getOrderType")] get; set; }

        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(id)initWithPage:(FSPDFPage *)page;
        [Export ("initWithPage:")]
        IntPtr Constructor (FSPDFPage page);

        // -(id)initWithOther:(FSTabOrderMgr *)other;
        [Export ("initWithOther:")]
        IntPtr Constructor (FSTabOrderMgr other);

        // -(BOOL)isEmpty;
        [Export ("isEmpty")]
        //[Verify (MethodToProperty)]
        bool IsEmpty { get; }

        // -(void)reload;
        [Export ("reload")]
        void Reload ();

        // -(FSAnnot *)getFirstAnnot;
        [Export ("getFirstAnnot")]
        //[Verify (MethodToProperty)]
        FSAnnot FirstAnnot { get; }

        // -(FSAnnot *)getLastAnnot;
        [Export ("getLastAnnot")]
        //[Verify (MethodToProperty)]
        FSAnnot LastAnnot { get; }

        // -(FSAnnot *)getNextAnnot:(FSAnnot *)annot;
        [Export ("getNextAnnot:")]
        FSAnnot GetNextAnnot (FSAnnot annot);

        // -(FSAnnot *)getPrevAnnot:(FSAnnot *)annot;
        [Export ("getPrevAnnot:")]
        FSAnnot GetPrevAnnot (FSAnnot annot);

        // -(BOOL)adjustStructureOrder:(FSAnnotArray *)annot_array;
        [Export ("adjustStructureOrder:")]
        bool AdjustStructureOrder (FSAnnotArray annot_array);

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSWatermark : FSBase
    [BaseType (typeof(FSBase))]
    [DisableDefaultCtor]
    interface FSWatermark
    {
        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(id)initWithDocument:(FSPDFDoc *)document text:(NSString *)text properties:(FSWatermarkTextProperties *)properties settings:(FSWatermarkSettings *)settings;
        [Export ("initWithDocument:text:properties:settings:")]
        IntPtr Constructor (FSPDFDoc document, string text, FSWatermarkTextProperties properties, FSWatermarkSettings settings);

        // -(id)initWithDocument:(FSPDFDoc *)document bitmap:(FSBitmap *)bitmap settings:(FSWatermarkSettings *)settings;
        [Export ("initWithDocument:bitmap:settings:")]
        IntPtr Constructor (FSPDFDoc document, FSBitmap bitmap, FSWatermarkSettings settings);

        // -(id)initWithDocument:(FSPDFDoc *)document image:(FSImage *)image frame_index:(int)frame_index settings:(FSWatermarkSettings *)settings;
        [Export ("initWithDocument:image:frame_index:settings:")]
        IntPtr Constructor (FSPDFDoc document, FSImage image, int frame_index, FSWatermarkSettings settings);

        // -(id)initWithDocument:(FSPDFDoc *)document page:(FSPDFPage *)page settings:(FSWatermarkSettings *)settings;
        [Export ("initWithDocument:page:settings:")]
        IntPtr Constructor (FSPDFDoc document, FSPDFPage page, FSWatermarkSettings settings);

        // -(id)initWithOther:(FSWatermark *)other;
        [Export ("initWithOther:")]
        IntPtr Constructor (FSWatermark other);

        // -(BOOL)isEmpty;
        [Export ("isEmpty")]
        //[Verify (MethodToProperty)]
        bool IsEmpty { get; }

        // -(float)getWidth;
        [Export ("getWidth")]
        //[Verify (MethodToProperty)]
        float Width { get; }

        // -(float)getHeight;
        [Export ("getHeight")]
        //[Verify (MethodToProperty)]
        float Height { get; }

        // -(BOOL)insertToPage:(FSPDFPage *)page;
        [Export ("insertToPage:")]
        bool InsertToPage (FSPDFPage page);

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSWatermarkSettings : NSObject
    [BaseType (typeof(NSObject))]
    interface FSWatermarkSettings
    {
        // @property (getter = getPosition, nonatomic) FSPosition position;
        [Export ("position", ArgumentSemantic.Assign)]
        FSPosition Position { [Bind ("getPosition")] get; set; }

        // @property (getter = getOffset_x, nonatomic) float offset_x;
        [Export ("offset_x")]
        float Offset_x { [Bind ("getOffset_x")] get; set; }

        // @property (getter = getOffset_y, nonatomic) float offset_y;
        [Export ("offset_y")]
        float Offset_y { [Bind ("getOffset_y")] get; set; }

        // @property (getter = getFlags, nonatomic) unsigned int flags;
        [Export ("flags")]
        uint Flags { [Bind ("getFlags")] get; set; }

        // @property (getter = getScale_x, nonatomic) float scale_x;
        [Export ("scale_x")]
        float Scale_x { [Bind ("getScale_x")] get; set; }

        // @property (getter = getScale_y, nonatomic) float scale_y;
        [Export ("scale_y")]
        float Scale_y { [Bind ("getScale_y")] get; set; }

        // @property (getter = getRotation, nonatomic) float rotation;
        [Export ("rotation")]
        float Rotation { [Bind ("getRotation")] get; set; }

        // @property (getter = getOpacity, nonatomic) int opacity;
        [Export ("opacity")]
        int Opacity { [Bind ("getOpacity")] get; set; }

        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(id)initWithPosition:(FSPosition)position offset_x:(float)offset_x offset_y:(float)offset_y flags:(unsigned int)flags scale_x:(float)scale_x scale_y:(float)scale_y rotation:(float)rotation opacity:(int)opacity;
        [Export ("initWithPosition:offset_x:offset_y:flags:scale_x:scale_y:rotation:opacity:")]
        IntPtr Constructor (FSPosition position, float offset_x, float offset_y, uint flags, float scale_x, float scale_y, float rotation, int opacity);

        // -(id)initWithSettings:(FSWatermarkSettings *)settings;
        [Export ("initWithSettings:")]
        IntPtr Constructor (FSWatermarkSettings settings);

        // -(void)set:(FSPosition)position offset_x:(float)offset_x offset_y:(float)offset_y flags:(unsigned int)flags scale_x:(float)scale_x scale_y:(float)scale_y rotation:(float)rotation opacity:(int)opacity;
        [Export ("set:offset_x:offset_y:flags:scale_x:scale_y:rotation:opacity:")]
        void Set (FSPosition position, float offset_x, float offset_y, uint flags, float scale_x, float scale_y, float rotation, int opacity);

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSWatermarkTextProperties : NSObject
    [BaseType (typeof(NSObject))]
    interface FSWatermarkTextProperties
    {
        // @property (getter = getFont_size, nonatomic) float font_size;
        [Export ("font_size")]
        float Font_size { [Bind ("getFont_size")] get; set; }

        // @property (getter = getColor, nonatomic) unsigned int color;
        [Export ("color")]
        uint Color { [Bind ("getColor")] get; set; }

        // @property (getter = getFont_style, nonatomic) FSWatermarkTextPropertiesFontStyle font_style;
        [Export ("font_style", ArgumentSemantic.Assign)]
        FSWatermarkTextPropertiesFontStyle Font_style { [Bind ("getFont_style")] get; set; }

        // @property (getter = getLine_space, nonatomic) float line_space;
        [Export ("line_space")]
        float Line_space { [Bind ("getLine_space")] get; set; }

        // @property (getter = getAlignment, nonatomic) FSAlignment alignment;
        [Export ("alignment", ArgumentSemantic.Assign)]
        FSAlignment Alignment { [Bind ("getAlignment")] get; set; }

        // @property (getter = getFont, nonatomic, weak) FSFont * font;
        [Export ("font", ArgumentSemantic.Weak)]
        FSFont Font { [Bind ("getFont")] get; set; }

        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(id)initWithFont:(FSFont *)font font_size:(float)font_size color:(unsigned int)color style:(FSWatermarkTextPropertiesFontStyle)style line_space:(float)line_space alignment:(FSAlignment)alignment;
        [Export ("initWithFont:font_size:color:style:line_space:alignment:")]
        IntPtr Constructor (FSFont font, float font_size, uint color, FSWatermarkTextPropertiesFontStyle style, float line_space, FSAlignment alignment);

        // -(id)initWithProperties:(FSWatermarkTextProperties *)properties;
        [Export ("initWithProperties:")]
        IntPtr Constructor (FSWatermarkTextProperties properties);

        // -(void)set:(FSFont *)font font_size:(float)font_size color:(unsigned int)color style:(FSWatermarkTextPropertiesFontStyle)style line_space:(float)line_space alignment:(FSAlignment)alignment;
        [Export ("set:font_size:color:style:line_space:alignment:")]
        void Set (FSFont font, float font_size, uint color, FSWatermarkTextPropertiesFontStyle style, float line_space, FSAlignment alignment);

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSTimer : NSObject
    [BaseType (typeof(NSObject))]
    [DisableDefaultCtor]
    interface FSTimer
    {
        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(void)onTimer:(int)timer;
        [Export ("onTimer:")]
        void OnTimer (int timer);

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSFiller : FSBase
    [BaseType (typeof(FSBase))]
    [DisableDefaultCtor]
    interface FSFiller
    {
        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(id)initWithForm:(FSForm *)form assist:(id<FSFillerAssistCallback>)assist;
        [Export ("initWithForm:assist:")]
        IntPtr Constructor (FSForm form, FSFillerAssistCallback assist);

        // -(id)initWithOther:(FSFiller *)other;
        [Export ("initWithOther:")]
        IntPtr Constructor (FSFiller other);

        // -(BOOL)isEmpty;
        [Export ("isEmpty")]
        //[Verify (MethodToProperty)]
        bool IsEmpty { get; }

        // -(void)render:(FSPDFPage *)page matrix:(FSMatrix2D *)matrix renderer:(FSRenderer *)renderer;
        [Export ("render:matrix:renderer:")]
        void Render (FSPDFPage page, FSMatrix2D matrix, FSRenderer renderer);

        // -(BOOL)onLButtonDown:(FSPDFPage *)page point:(FSPointF *)point flags:(unsigned int)flags;
        [Export ("onLButtonDown:point:flags:")]
        bool OnLButtonDown (FSPDFPage page, FSPointF point, uint flags);

        // -(BOOL)onLButtonUp:(FSPDFPage *)page point:(FSPointF *)point flags:(unsigned int)flags;
        [Export ("onLButtonUp:point:flags:")]
        bool OnLButtonUp (FSPDFPage page, FSPointF point, uint flags);

        // -(BOOL)onLButtonDoubleClick:(FSPDFPage *)page point:(FSPointF *)point flags:(unsigned int)flags;
        [Export ("onLButtonDoubleClick:point:flags:")]
        bool OnLButtonDoubleClick (FSPDFPage page, FSPointF point, uint flags);

        // -(BOOL)onMouseMove:(FSPDFPage *)page point:(FSPointF *)point flags:(unsigned int)flags;
        [Export ("onMouseMove:point:flags:")]
        bool OnMouseMove (FSPDFPage page, FSPointF point, uint flags);

        // -(BOOL)onMouseEnter:(FSPDFPage *)page point:(FSPointF *)point flags:(unsigned int)flags;
        [Export ("onMouseEnter:point:flags:")]
        bool OnMouseEnter (FSPDFPage page, FSPointF point, uint flags);

        // -(BOOL)onMouseHover:(FSPDFPage *)page point:(FSPointF *)point flags:(unsigned int)flags;
        [Export ("onMouseHover:point:flags:")]
        bool OnMouseHover (FSPDFPage page, FSPointF point, uint flags);

        // -(BOOL)onMouseLeave:(FSPDFPage *)page point:(FSPointF *)point flags:(unsigned int)flags;
        [Export ("onMouseLeave:point:flags:")]
        bool OnMouseLeave (FSPDFPage page, FSPointF point, uint flags);

        // -(BOOL)onMouseWheel:(FSPDFPage *)page point:(FSPointF *)point delta:(int)delta flags:(unsigned int)flags;
        [Export ("onMouseWheel:point:delta:flags:")]
        bool OnMouseWheel (FSPDFPage page, FSPointF point, int delta, uint flags);

        // -(BOOL)onRButtonDown:(FSPDFPage *)page point:(FSPointF *)point flags:(unsigned int)flags;
        [Export ("onRButtonDown:point:flags:")]
        bool OnRButtonDown (FSPDFPage page, FSPointF point, uint flags);

        // -(BOOL)onRButtonUp:(FSPDFPage *)page point:(FSPointF *)point flags:(unsigned int)flags;
        [Export ("onRButtonUp:point:flags:")]
        bool OnRButtonUp (FSPDFPage page, FSPointF point, uint flags);

        // -(BOOL)onRButtonDoubleClick:(FSPDFPage *)page point:(FSPointF *)point flags:(unsigned int)flags;
        [Export ("onRButtonDoubleClick:point:flags:")]
        bool OnRButtonDoubleClick (FSPDFPage page, FSPointF point, uint flags);

        // -(BOOL)onWheelButtonDown:(FSPDFPage *)page point:(FSPointF *)point flags:(unsigned int)flags;
        [Export ("onWheelButtonDown:point:flags:")]
        bool OnWheelButtonDown (FSPDFPage page, FSPointF point, uint flags);

        // -(BOOL)onWheelButtonUp:(FSPDFPage *)page point:(FSPointF *)point flags:(unsigned int)flags;
        [Export ("onWheelButtonUp:point:flags:")]
        bool OnWheelButtonUp (FSPDFPage page, FSPointF point, uint flags);

        // -(BOOL)onWheelButtonDoubleClick:(FSPDFPage *)page point:(FSPointF *)point flags:(unsigned int)flags;
        [Export ("onWheelButtonDoubleClick:point:flags:")]
        bool OnWheelButtonDoubleClick (FSPDFPage page, FSPointF point, uint flags);

        // -(BOOL)onKeyDown:(unsigned int)key_code flags:(unsigned int)flags;
        [Export ("onKeyDown:flags:")]
        bool OnKeyDown (uint key_code, uint flags);

        // -(BOOL)onKeyUp:(unsigned int)key_code flags:(unsigned int)flags;
        [Export ("onKeyUp:flags:")]
        bool OnKeyUp (uint key_code, uint flags);

        // -(BOOL)onChar:(unsigned int)char_code flags:(unsigned int)flags;
        [Export ("onChar:flags:")]
        bool OnChar (uint char_code, uint flags);

        // -(BOOL)setFocus:(FSControl *)control;
        [Export ("setFocus:")]
        bool SetFocus (FSControl control);

        // -(BOOL)killFocus;
        [Export ("killFocus")]
        //[Verify (MethodToProperty)]
        bool KillFocus { get; }

        // -(void)highlightFormFields:(BOOL)is_highlight;
        [Export ("highlightFormFields:")]
        void HighlightFormFields (bool is_highlight);

        // -(void)setHighlightColor:(unsigned int)color;
        [Export ("setHighlightColor:")]
        void SetHighlightColor (uint color);

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSFieldArray : NSObject
    [BaseType (typeof(NSObject))]
    interface FSFieldArray
    {
        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(id)initWithArg0:(FSFieldArray *)arg0;
        [Export ("initWithArg0:")]
        IntPtr Constructor (FSFieldArray arg0);

        // -(unsigned long)getSize;
        [Export ("getSize")]
        //[Verify (MethodToProperty)]
        nuint Size { get; }

        // -(FSField *)getAt:(unsigned long)index;
        [Export ("getAt:")]
        FSField GetAt (nuint index);

        // -(void)add:(FSField *)element;
        [Export ("add:")]
        void Add (FSField element);

        // -(void)removeAt:(unsigned long)index;
        [Export ("removeAt:")]
        void RemoveAt (nuint index);

        // -(void)insertAt:(unsigned long)index element:(FSField *)element;
        [Export ("insertAt:element:")]
        void InsertAt (nuint index, FSField element);

        // -(void)removeAll;
        [Export ("removeAll")]
        void RemoveAll ();

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSChoiceOption : NSObject
    [BaseType (typeof(NSObject))]
    interface FSChoiceOption
    {
        // @property (getter = getOption_value, nonatomic, weak) NSString * option_value;
        [Export ("option_value", ArgumentSemantic.Weak)]
        string Option_value { [Bind ("getOption_value")] get; set; }

        // @property (getter = getOption_label, nonatomic, weak) NSString * option_label;
        [Export ("option_label", ArgumentSemantic.Weak)]
        string Option_label { [Bind ("getOption_label")] get; set; }

        // @property (getter = getSelected, nonatomic) BOOL selected;
        [Export ("selected")]
        bool Selected { [Bind ("getSelected")] get; set; }

        // @property (getter = getDefault_selected, nonatomic) BOOL default_selected;
        [Export ("default_selected")]
        bool Default_selected { [Bind ("getDefault_selected")] get; set; }

        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(id)initWithOption_value:(NSString *)option_value option_label:(NSString *)option_label selected:(BOOL)selected default_selected:(BOOL)default_selected;
        [Export ("initWithOption_value:option_label:selected:default_selected:")]
        IntPtr Constructor (string option_value, string option_label, bool selected, bool default_selected);

        // -(id)initWithOption:(FSChoiceOption *)option;
        [Export ("initWithOption:")]
        IntPtr Constructor (FSChoiceOption option);

        // -(void)set:(NSString *)option_value option_label:(NSString *)option_label selected:(BOOL)selected default_selected:(BOOL)default_selected;
        [Export ("set:option_label:selected:default_selected:")]
        void Set (string option_value, string option_label, bool selected, bool default_selected);

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSChoiceOptionArray : NSObject
    [BaseType (typeof(NSObject))]
    interface FSChoiceOptionArray
    {
        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(id)initWithArg0:(FSChoiceOptionArray *)arg0;
        [Export ("initWithArg0:")]
        IntPtr Constructor (FSChoiceOptionArray arg0);

        // -(unsigned long)getSize;
        [Export ("getSize")]
        //[Verify (MethodToProperty)]
        nuint Size { get; }

        // -(FSChoiceOption *)getAt:(unsigned long)index;
        [Export ("getAt:")]
        FSChoiceOption GetAt (nuint index);

        // -(void)add:(FSChoiceOption *)element;
        [Export ("add:")]
        void Add (FSChoiceOption element);

        // -(void)removeAt:(unsigned long)index;
        [Export ("removeAt:")]
        void RemoveAt (nuint index);

        // -(void)insertAt:(unsigned long)index element:(FSChoiceOption *)element;
        [Export ("insertAt:element:")]
        void InsertAt (nuint index, FSChoiceOption element);

        // -(void)removeAll;
        [Export ("removeAll")]
        void RemoveAll ();

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSField : FSBase
    [BaseType (typeof(FSBase))]
    interface FSField
    {
        // @property (getter = getFlags, nonatomic) unsigned int flags;
        [Export ("flags")]
        uint Flags { [Bind ("getFlags")] get; set; }

        // @property (getter = getValue, nonatomic, weak) NSString * value;
        [Export ("value", ArgumentSemantic.Weak)]
        string Value { [Bind ("getValue")] get; set; }

        // @property (getter = getAlignment, nonatomic) FSAlignment alignment;
        [Export ("alignment", ArgumentSemantic.Assign)]
        FSAlignment Alignment { [Bind ("getAlignment")] get; set; }

        // @property (getter = getAlternateName, nonatomic, weak) NSString * alternateName;
        [Export ("alternateName", ArgumentSemantic.Weak)]
        string AlternateName { [Bind ("getAlternateName")] get; set; }

        // @property (getter = getDefaultAppearance, nonatomic, weak) FSDefaultAppearance * defaultAppearance;
        [Export ("defaultAppearance", ArgumentSemantic.Weak)]
        FSDefaultAppearance DefaultAppearance { [Bind ("getDefaultAppearance")] get; set; }

        // @property (getter = getMappingName, nonatomic, weak) NSString * mappingName;
        [Export ("mappingName", ArgumentSemantic.Weak)]
        string MappingName { [Bind ("getMappingName")] get; set; }

        // @property (getter = getMaxLength, nonatomic) int maxLength;
        [Export ("maxLength")]
        int MaxLength { [Bind ("getMaxLength")] get; set; }

        // @property (getter = getOptions, nonatomic, weak) FSChoiceOptionArray * options;
        [Export ("options", ArgumentSemantic.Weak)]
        FSChoiceOptionArray Options { [Bind ("getOptions")] get; set; }

        // @property (getter = getTopVisibleIndex, nonatomic) int topVisibleIndex;
        [Export ("topVisibleIndex")]
        int TopVisibleIndex { [Bind ("getTopVisibleIndex")] get; set; }

        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(id)initWithDocument:(FSPDFDoc *)document field_dict:(FSPDFDictionary *)field_dict;
        [Export ("initWithDocument:field_dict:")]
        IntPtr Constructor (FSPDFDoc document, FSPDFDictionary field_dict);

        // -(id)initWithField:(FSField *)field;
        [Export ("initWithField:")]
        IntPtr Constructor (FSField field);

        // -(BOOL)isEmpty;
        [Export ("isEmpty")]
        //[Verify (MethodToProperty)]
        bool IsEmpty { get; }

        // -(FSFieldType)getType;
        [Export ("getType")]
        //[Verify (MethodToProperty)]
        FSFieldType Type { get; }

        // -(NSString *)getName;
        [Export ("getName")]
        //[Verify (MethodToProperty)]
        string Name { get; }

        // -(NSString *)getDefaultValue;
        [Export ("getDefaultValue")]
        //[Verify (MethodToProperty)]
        string DefaultValue { get; }

        // -(void)setDefualtValue:(NSString *)value;
        [Export ("setDefualtValue:")]
        void SetDefualtValue (string value);

        // -(int)getControlCount;
        [Export ("getControlCount")]
        //[Verify (MethodToProperty)]
        int ControlCount { get; }

        // -(FSControl *)getControl:(int)index;
        [Export ("getControl:")]
        FSControl GetControl (int index);

        // -(BOOL)reset;
        [Export ("reset")]
        //[Verify (MethodToProperty)]
        bool Reset { get; }

        // -(FSPDFDictionary *)getDict;
        [Export ("getDict")]
        //[Verify (MethodToProperty)]
        FSPDFDictionary Dict { get; }

        // -(FSPDFObject *)getValueObj;
        [Export ("getValueObj")]
        //[Verify (MethodToProperty)]
        FSPDFObject ValueObj { get; }

        // -(FSPDFObject *)getDefaultValueObj;
        [Export ("getDefaultValueObj")]
        //[Verify (MethodToProperty)]
        FSPDFObject DefaultValueObj { get; }

        // -(FSPDFObject *)getInheritedAttribute:(NSString *)attribute_name;
        [Export ("getInheritedAttribute:")]
        FSPDFObject GetInheritedAttribute (string attribute_name);

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSForm : FSBase
    [BaseType (typeof(FSBase))]
    [DisableDefaultCtor]
    interface FSForm
    {
        // @property (getter = getAlignment, nonatomic) FSAlignment alignment;
        [Export ("alignment", ArgumentSemantic.Assign)]
        FSAlignment Alignment { [Bind ("getAlignment")] get; set; }

        // @property (getter = getDefaultAppearance, nonatomic, weak) FSDefaultAppearance * defaultAppearance;
        [Export ("defaultAppearance", ArgumentSemantic.Weak)]
        FSDefaultAppearance DefaultAppearance { [Bind ("getDefaultAppearance")] get; set; }

        // @property (getter = getFieldsInCalculationOrder, nonatomic, weak) FSFieldArray * fieldsInCalculationOrder;
        [Export ("fieldsInCalculationOrder", ArgumentSemantic.Weak)]
        FSFieldArray FieldsInCalculationOrder { [Bind ("getFieldsInCalculationOrder")] get; set; }

        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(id)initWithDocument:(FSPDFDoc *)document;
        [Export ("initWithDocument:")]
        IntPtr Constructor (FSPDFDoc document);

        // -(id)initWithOther:(FSForm *)other;
        [Export ("initWithOther:")]
        IntPtr Constructor (FSForm other);

        // -(BOOL)isEmpty;
        [Export ("isEmpty")]
        //[Verify (MethodToProperty)]
        bool IsEmpty { get; }

        // -(BOOL)needConstructAppearances;
        [Export ("needConstructAppearances")]
        //[Verify (MethodToProperty)]
        bool NeedConstructAppearances { get; }

        // -(void)setConstructAppearances:(BOOL)need_construct;
        [Export ("setConstructAppearances:")]
        void SetConstructAppearances (bool need_construct);

        // -(FSControl *)getControlAtDevicePoint:(FSPDFPage *)page point:(FSPointF *)point tolerance:(float)tolerance type:(FSFieldType)type matrix:(FSMatrix2D *)matrix;
        [Export ("getControlAtDevicePoint:point:tolerance:type:matrix:")]
        FSControl GetControlAtDevicePoint (FSPDFPage page, FSPointF point, float tolerance, FSFieldType type, FSMatrix2D matrix);

        // -(FSControl *)getControlAtPoint:(FSPDFPage *)page point:(FSPointF *)point tolerance:(float)tolerance type:(FSFieldType)type;
        [Export ("getControlAtPoint:point:tolerance:type:")]
        FSControl GetControlAtPoint (FSPDFPage page, FSPointF point, float tolerance, FSFieldType type);

        // -(FSPDFDoc *)getDocument;
        [Export ("getDocument")]
        //[Verify (MethodToProperty)]
        FSPDFDoc Document { get; }

        // -(BOOL)validateFieldName:(FSFieldType)type field_name:(NSString *)field_name;
        [Export ("validateFieldName:field_name:")]
        bool ValidateFieldName (FSFieldType type, string field_name);

        // -(BOOL)renameField:(FSField *)field new_field_name:(NSString *)new_field_name;
        [Export ("renameField:new_field_name:")]
        bool RenameField (FSField field, string new_field_name);

        // -(FSControl *)addControl:(FSPDFPage *)page field_name:(NSString *)field_name field_type:(FSFieldType)field_type rect:(FSRectF *)rect;
        [Export ("addControl:field_name:field_type:rect:")]
        FSControl AddControl (FSPDFPage page, string field_name, FSFieldType field_type, FSRectF rect);

        // -(void)removeField:(FSField *)field;
        [Export ("removeField:")]
        void RemoveField (FSField field);

        // -(void)removeControl:(FSControl *)control;
        [Export ("removeControl:")]
        void RemoveControl (FSControl control);

        // -(int)getFieldCount:(NSString *)filter;
        [Export ("getFieldCount:")]
        int GetFieldCount (string filter);

        // -(FSField *)getField:(int)index filter:(NSString *)filter;
        [Export ("getField:filter:")]
        FSField GetField (int index, string filter);

        // -(int)getControlCount:(FSPDFPage *)page;
        [Export ("getControlCount:")]
        int GetControlCount (FSPDFPage page);

        // -(FSControl *)getControl:(FSPDFPage *)page index:(int)index;
        [Export ("getControl:index:")]
        FSControl GetControl (FSPDFPage page, int index);

        // -(FSFiller *)getFormFiller;
        [Export ("getFormFiller")]
        //[Verify (MethodToProperty)]
        FSFiller FormFiller { get; }

        // -(BOOL)reset;
        [Export ("reset")]
        //[Verify (MethodToProperty)]
        bool Reset { get; }

        // -(BOOL)exportToXML:(NSString *)file_path;
        [Export ("exportToXML:")]
        bool ExportToXML (string file_path);

        // -(BOOL)importFromXML:(NSString *)file_path;
        [Export ("importFromXML:")]
        bool ImportFromXML (string file_path);

        // -(FSPDFDictionary *)getDict;
        [Export ("getDict")]
        //[Verify (MethodToProperty)]
        FSPDFDictionary Dict { get; }

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSControl : FSBase
    [BaseType (typeof(FSBase))]
    [DisableDefaultCtor]
    interface FSControl
    {
        // @property (getter = getExportValue, nonatomic, weak) NSString * exportValue;
        [Export ("exportValue", ArgumentSemantic.Weak)]
        string ExportValue { [Bind ("getExportValue")] get; set; }

        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(id)initWithOther:(FSControl *)other;
        [Export ("initWithOther:")]
        IntPtr Constructor (FSControl other);

        // -(BOOL)isEmpty;
        [Export ("isEmpty")]
        //[Verify (MethodToProperty)]
        bool IsEmpty { get; }

        // -(FSField *)getField;
        [Export ("getField")]
        //[Verify (MethodToProperty)]
        FSField Field { get; }

        // -(FSWidget *)getWidget;
        [Export ("getWidget")]
        //[Verify (MethodToProperty)]
        FSWidget Widget { get; }

        // -(int)getIndex;
        [Export ("getIndex")]
        //[Verify (MethodToProperty)]
        int Index { get; }

        // -(BOOL)isChecked;
        [Export ("isChecked")]
        //[Verify (MethodToProperty)]
        bool IsChecked { get; }

        // -(void)setChecked:(BOOL)checked;
        [Export ("setChecked:")]
        void SetChecked (bool @checked);

        // -(BOOL)isDefaultChecked;
        [Export ("isDefaultChecked")]
        //[Verify (MethodToProperty)]
        bool IsDefaultChecked { get; }

        // -(void)setDefaultChecked:(BOOL)checked;
        [Export ("setDefaultChecked:")]
        void SetDefaultChecked (bool @checked);

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @interface FSSignature : FSField
    [BaseType (typeof(FSField))]
    [DisableDefaultCtor]
    interface FSSignature
    {
        // @property (getter = getAppearanceFlags, nonatomic) unsigned int appearanceFlags;
        [Export ("appearanceFlags")]
        uint AppearanceFlags { [Bind ("getAppearanceFlags")] get; set; }

        // @property (getter = getSignTime, nonatomic, weak) FSDateTime * signTime;
        [Export ("signTime", ArgumentSemantic.Weak)]
        FSDateTime SignTime { [Bind ("getSignTime")] get; set; }

        // @property (getter = getFilter, nonatomic, weak) NSString * filter;
        [Export ("filter", ArgumentSemantic.Weak)]
        string Filter { [Bind ("getFilter")] get; set; }

        // @property (getter = getSubFilter, nonatomic, weak) NSString * subFilter;
        [Export ("subFilter", ArgumentSemantic.Weak)]
        string SubFilter { [Bind ("getSubFilter")] get; set; }

        // @property (getter = getBitmap, nonatomic, weak) FSBitmap * bitmap;
        [Export ("bitmap", ArgumentSemantic.Weak)]
        FSBitmap Bitmap { [Bind ("getBitmap")] get; set; }

        // -(void *)getCptr;
        [Export ("getCptr")]
        //[Verify (MethodToProperty)]
        IntPtr Cptr { get; }

        // -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
        [Export ("initWithCptr:swigOwnCObject:")]
        IntPtr Constructor (IntPtr cptr, bool ownCObject);

        // -(id)initWithField:(FSField *)field;
        [Export ("initWithField:")]
        IntPtr Constructor (FSField field);

        // -(id)initWithDocument:(FSPDFDoc *)document sig_field_dict:(FSPDFDictionary *)sig_field_dict;
        [Export ("initWithDocument:sig_field_dict:")]
        IntPtr Constructor (FSPDFDoc document, FSPDFDictionary sig_field_dict);

        // -(BOOL)isEmpty;
        [Export ("isEmpty")]
        //[Verify (MethodToProperty)]
        bool IsEmpty { get; }

        // -(BOOL)isSigned;
        [Export ("isSigned")]
        //[Verify (MethodToProperty)]
        bool IsSigned { get; }

        // -(FSProgressive *)startSign:(NSString *)cert_path cert_password:(NSString *)cert_password digest_algorithm:(FSSignatureDigestAlgorithm)digest_algorithm save_path:(NSString *)save_path client_data:(NSData *)client_data pause:(id<FSPauseCallback>)pause;
        [Export ("startSign:cert_password:digest_algorithm:save_path:client_data:pause:")]
        FSProgressive StartSign (string cert_path, string cert_password, FSSignatureDigestAlgorithm digest_algorithm, string save_path, NSData client_data, FSPauseCallback pause);

        // -(FSProgressive *)startVerify:(NSData *)client_data pause:(id<FSPauseCallback>)pause;
        [Export ("startVerify:pause:")]
        FSProgressive StartVerify (NSData client_data, FSPauseCallback pause);

        // -(NSString *)getCertificateInfo:(NSString *)key;
        [Export ("getCertificateInfo:")]
        string GetCertificateInfo (string key);

        // -(unsigned int)getState;
        [Export ("getState")]
        //[Verify (MethodToProperty)]
        uint State { get; }

        // -(BOOL)clearSignedData;
        [Export ("clearSignedData")]
        //[Verify (MethodToProperty)]
        bool ClearSignedData { get; }

        // -(FSPDFDoc *)getDocument;
        [Export ("getDocument")]
        //[Verify (MethodToProperty)]
        FSPDFDoc Document { get; }

        // -(void)setAppearanceContent:(NSString *)appearance_content;
        [Export ("setAppearanceContent:")]
        void SetAppearanceContent (string appearance_content);

        // -(NSString *)getKeyValue:(FSSignatureKeyName)key;
        [Export ("getKeyValue:")]
        string GetKeyValue (FSSignatureKeyName key);

        // -(void)setKeyValue:(FSSignatureKeyName)key value:(NSString *)value;
        [Export ("setKeyValue:value:")]
        void SetKeyValue (FSSignatureKeyName key, string value);

        // -(void)setImage:(FSImage *)image frame_index:(int)frame_index;
        [Export ("setImage:frame_index:")]
        void SetImage (FSImage image, int frame_index);

        // -(FSPDFDictionary *)getSignatureDict;
        [Export ("getSignatureDict")]
        //[Verify (MethodToProperty)]
        FSPDFDictionary SignatureDict { get; }

        // -(void)setDefaultContentsLength:(unsigned int)default_length;
        [Export ("setDefaultContentsLength:")]
        void SetDefaultContentsLength (uint default_length);

        // -(int)getCertCount;
        [Export ("getCertCount")]
        //[Verify (MethodToProperty)]
        int CertCount { get; }

        // -(NSString *)getCert:(int)index;
        [Export ("getCert:")]
        string GetCert (int index);

        // -(void)setCertChain:(NSArray<NSString *> *)cert_chain;
        [Export ("setCertChain:")]
        void SetCertChain (string[] cert_chain);

        // -(FSInt32Array *)getByteRangeArray;
        [Export ("getByteRangeArray")]
        //[Verify (MethodToProperty)]
        FSInt32Array ByteRangeArray { get; }

        // -(void)dealloc;
        [Export ("dealloc")]
        void Dealloc ();
    }

    // @protocol FSPauseCallback <NSObject>
    [Protocol, Model]
    [BaseType (typeof(NSObject))]
    interface FSPauseCallback
    {
        // @required -(BOOL)needPauseNow;
        [Abstract]
        [Export ("needPauseNow")]
        //[Verify (MethodToProperty)]
        bool NeedPauseNow { get; }
    }

    // @protocol FSFileReaderCallback <NSObject>
    [Protocol, Model]
    [BaseType (typeof(NSObject))]
    interface FSFileReaderCallback
    {
        // @required -(NSData *)readBlock:(unsigned long long)offset size:(unsigned long long)size;
        [Abstract]
        [Export ("readBlock:size:")]
        NSData Size (ulong offset, ulong size);

        // @required -(unsigned long long)getSize;
        [Abstract]
        [Export ("getSize")]
        //[Verify (MethodToProperty)]
        ulong getSize { get; }
    }

    // @protocol FSFileWriterCallback <NSObject>
    [Protocol, Model]
    [BaseType (typeof(NSObject))]
    interface FSFileWriterCallback
    {
        // @required -(unsigned long long)getSize;
        [Abstract]
        [Export ("getSize")]
        //[Verify (MethodToProperty)]
        ulong Size { get; }

        // @required -(BOOL)writeBlock:(NSData *)data offset:(unsigned long long)offset;
        [Abstract]
        [Export ("writeBlock:offset:")]
        bool Offset (NSData data, ulong offset);

        // @required -(BOOL)flush;
        [Abstract]
        [Export ("flush")]
        //[Verify (MethodToProperty)]
        bool Flush { get; }
    }

    // @protocol FSActionCallback <NSObject>
    [Protocol, Model]
    [BaseType (typeof(NSObject))]
    interface FSActionCallback
    {
        // @required -(int)getCurrentPage:(FSPDFDoc *)pdfDoc;
        [Abstract]
        [Export ("getCurrentPage:")]
        int GetCurrentPage (FSPDFDoc pdfDoc);

        // @required -(void)setCurrentPage:(FSPDFDoc *)pdfDoc pageIndex:(int)pageIndex;
        [Abstract]
        [Export ("setCurrentPage:pageIndex:")]
        void SetCurrentPage (FSPDFDoc pdfDoc, int pageIndex);

        // @required -(FSRotation)getPageRotation:(FSPDFDoc *)pdfDoc pageIndex:(int)pageIndex;
        [Abstract]
        [Export ("getPageRotation:pageIndex:")]
        FSRotation GetPageRotation (FSPDFDoc pdfDoc, int pageIndex);

        // @required -(BOOL)setPageRotation:(FSPDFDoc *)pdfDoc pageIndex:(int)pageIndex rotation:(FSRotation)rotation;
        [Abstract]
        [Export ("setPageRotation:pageIndex:rotation:")]
        bool SetPageRotation (FSPDFDoc pdfDoc, int pageIndex, FSRotation rotation);

        // @required -(int)alert:(NSString *)msg title:(NSString *)title type:(int)type icon:(int)icon;
        [Abstract]
        [Export ("alert:title:type:icon:")]
        int Alert (string msg, string title, int type, int icon);

        // @required -(FSIdentityProperties *)getIdentityProperties;
        [Abstract]
        [Export ("getIdentityProperties")]
        //[Verify (MethodToProperty)]
        FSIdentityProperties IdentityProperties { get; }

        // @required -(BOOL)setDocChangeMark:(FSPDFDoc *)document change_mark:(BOOL)change_mark;
        [Abstract]
        [Export ("setDocChangeMark:change_mark:")]
        bool SetDocChangeMark (FSPDFDoc document, bool change_mark);

        // @required -(BOOL)getDocChangeMark:(FSPDFDoc *)document;
        [Abstract]
        [Export ("getDocChangeMark:")]
        bool GetDocChangeMark (FSPDFDoc document);
    }

    // @protocol FSIconProviderCallback <NSObject>
    [Protocol, Model]
    [BaseType (typeof(NSObject))]
    interface FSIconProviderCallback
    {
        // @required -(NSString *)getProviderID;
        [Abstract]
        [Export ("getProviderID")]
        //[Verify (MethodToProperty)]
        string ProviderID { get; }

        // @required -(NSString *)getProviderVersion;
        [Abstract]
        [Export ("getProviderVersion")]
        //[Verify (MethodToProperty)]
        string ProviderVersion { get; }

        // @required -(BOOL)hasIcon:(FSAnnotType)annotType iconName:(NSString *)iconName;
        [Abstract]
        [Export ("hasIcon:iconName:")]
        bool HasIcon (FSAnnotType annotType, string iconName);

        // @required -(BOOL)canChangeColor:(FSAnnotType)annotType iconName:(NSString *)iconName;
        [Abstract]
        [Export ("canChangeColor:iconName:")]
        bool CanChangeColor (FSAnnotType annotType, string iconName);

        // @required -(FSPDFPage *)getIcon:(FSAnnotType)annotType iconName:(NSString *)iconName color:(unsigned int)color;
        [Abstract]
        [Export ("getIcon:iconName:color:")]
        FSPDFPage GetIcon (FSAnnotType annotType, string iconName, uint color);

        // @required -(FSShadingColor *)getShadingColor:(FSAnnotType)annotType iconName:(NSString *)iconName refColor:(unsigned int)refColor shadingIndex:(int)shadingIndex ShadingColor:(FSShadingColor *)out_shading_color;
        [Abstract]
        [Export ("getShadingColor:iconName:refColor:shadingIndex:ShadingColor:")]
        FSShadingColor GetShadingColor (FSAnnotType annotType, string iconName, uint refColor, int shadingIndex, FSShadingColor out_shading_color);

        // @required -(NSNumber *)getDisplayWidth:(FSAnnotType)annotType iconName:(NSString *)iconName;
        [Abstract]
        [Export ("getDisplayWidth:iconName:")]
        NSNumber GetDisplayWidth (FSAnnotType annotType, string iconName);

        // @required -(NSNumber *)getDisplayHeight:(FSAnnotType)annotType iconName:(NSString *)iconName;
        [Abstract]
        [Export ("getDisplayHeight:iconName:")]
        NSNumber GetDisplayHeight (FSAnnotType annotType, string iconName);
    }

    // @protocol FSNotifierCallback <NSObject>
    [Protocol, Model]
    [BaseType (typeof(NSObject))]
    interface FSNotifierCallback
    {
        // @required -(void)onOutOfMemory;
        [Abstract]
        [Export ("onOutOfMemory")]
        void OnOutOfMemory ();
    }

    // @protocol FSDocEventCallback <NSObject>
    [Protocol, Model]
    [BaseType (typeof(NSObject))]
    interface FSDocEventCallback
    {
        // @required -(void)onDocWillOpen;
        [Abstract]
        [Export ("onDocWillOpen")]
        void OnDocWillOpen ();

        // @required -(void)onDocOpened:(FSPDFDoc *)document error_code:(FSErrorCode)error_code;
        [Abstract]
        [Export ("onDocOpened:error_code:")]
        void OnDocOpened (FSPDFDoc document, FSErrorCode error_code);

        // @required -(void)onDocWillDestroy:(FSPDFDoc *)document;
        [Abstract]
        [Export ("onDocWillDestroy:")]
        void OnDocWillDestroy (FSPDFDoc document);

        // @required -(void)onDocWillSave:(FSPDFDoc *)document;
        [Abstract]
        [Export ("onDocWillSave:")]
        void OnDocWillSave (FSPDFDoc document);

        // @required -(void)onDocSaved:(FSPDFDoc *)document error_code:(FSErrorCode)error_code;
        [Abstract]
        [Export ("onDocSaved:error_code:")]
        void OnDocSaved (FSPDFDoc document, FSErrorCode error_code);
    }

    // @protocol FSAsyncReaderCallback <FSFileReaderCallback>
    [Protocol, Model]
    interface FSAsyncReaderCallback : FSFileReaderCallback
    {
        // @required -(BOOL)isDataAvail:(int)offset size:(int)size;
        [Abstract]
        [Export ("isDataAvail:size:")]
        bool IsDataAvail (int offset, int size);

        // @required -(BOOL)addDownloadHint:(int)offset size:(int)size;
        [Abstract]
        [Export ("addDownloadHint:size:")]
        bool AddDownloadHint (int offset, int size);
    }

    // @protocol FSFillerAssistCallback <NSObject>
    [Protocol, Model]
    [BaseType (typeof(NSObject))]
    interface FSFillerAssistCallback
    {
        // @required -(void)refresh:(FSPDFPage *)page rect:(FSRectF *)rect;
        [Abstract]
        [Export ("refresh:rect:")]
        void Refresh (FSPDFPage page, FSRectF rect);

        // @required -(BOOL)setTimer:(int)elapse timer:(FSTimer *)timer out_timer_id:(int *)out_timer_id;
        [Abstract]
        [Export ("setTimer:timer:out_timer_id:")]
        unsafe bool SetTimer(int elapse, FSTimer timer, IntPtr out_timer_id);

        // @required -(BOOL)killTimer:(int)timer_id;
        [Abstract]
        [Export ("killTimer:")]
        bool KillTimer (int timer_id);

        // @required -(void)focusGotOnControl:(FSControl *)control value:(NSString *)value;
        [Abstract]
        [Export ("focusGotOnControl:value:")]
        void FocusGotOnControl (FSControl control, string value);

        // @required -(void)focusLostFromControl:(FSControl *)control value:(NSString *)value;
        [Abstract]
        [Export ("focusLostFromControl:value:")]
        void FocusLostFromControl (FSControl control, string value);
    }

    // @protocol FSSearchCallback <NSObject>
    [Protocol, Model]
    [BaseType (typeof(NSObject))]
    interface FSSearchCallback
    {
        // @required -(int)retrieveSearchResult:(NSString *)file_path page_index:(int)page_index match_result:(NSString *)match_result match_start_text_index:(int)match_start_text_index match_end_text_index:(int)match_end_text_index;
        [Abstract]
        [Export ("retrieveSearchResult:page_index:match_result:match_start_text_index:match_end_text_index:")]
        int Page_index (string file_path, int page_index, string match_result, int match_start_text_index, int match_end_text_index);
    }

    // @protocol FSSearchCancelCallback <NSObject>
    [Protocol, Model]
    [BaseType (typeof(NSObject))]
    interface FSSearchCancelCallback
    {
        // @required -(BOOL)needToCancelNow;
        [Abstract]
        [Export ("needToCancelNow")]
        //[Verify (MethodToProperty)]
        bool NeedToCancelNow { get; }
    }

    // @protocol FSPSICallback <NSObject>
    [Protocol, Model]
    [BaseType (typeof(NSObject))]
    interface FSPSICallback
    {
        // @required -(void)refresh:(FSPSI *)psi rect:(FSRectF *)rect;
        [Abstract]
        [Export ("refresh:rect:")]
        void Rect (FSPSI psi, FSRectF rect);
    }

    // @protocol FSSecurityCallback <NSObject>
    [Protocol, Model]
    [BaseType (typeof(NSObject))]
    interface FSSecurityCallback
    {
        // @required -(FSPDFDocEncryptType)GetSecurityType;
        [Abstract]
        [Export ("GetSecurityType")]
        //[Verify (MethodToProperty)]
        FSPDFDocEncryptType SecurityType { get; }
    }

    // @protocol FSCertificateSecurityCallback <FSSecurityCallback>
    [Protocol, Model]
    interface FSCertificateSecurityCallback : FSSecurityCallback
    {
        // @required -(NSData *)getDecryptionKey:(NSData *)envelope_buffer;
        [Abstract]
        [Export ("getDecryptionKey:")]
        NSData GetDecryptionKey (NSData envelope_buffer);
    }

    // @protocol FSDRMSecurityCallback <FSSecurityCallback>
    [Protocol, Model]
    interface FSDRMSecurityCallback : FSSecurityCallback
    {
        // @required -(BOOL)isOwner:(FSPDFDoc *)document subFilter:(NSString *)sub_filter;
        [Abstract]
        [Export ("isOwner:subFilter:")]
        bool IsOwner (FSPDFDoc document, string sub_filter);

        // @required -(int)getUserPermissions:(FSPDFDoc *)document subFilter:(NSString *)sub_filter;
        [Abstract]
        [Export ("getUserPermissions:subFilter:")]
        int GetUserPermissions (FSPDFDoc document, string sub_filter);

        // @required -(FSSecurityHandlerCipherType)getCipherType:(FSPDFDoc *)document subFilter:(NSString *)sub_filter;
        [Abstract]
        [Export ("getCipherType:subFilter:")]
        FSSecurityHandlerCipherType GetCipherType (FSPDFDoc document, string sub_filter);

        // @required -(int)getKeyLength:(FSPDFDoc *)document subFilter:(NSString *)sub_filter;
        [Abstract]
        [Export ("getKeyLength:subFilter:")]
        int GetKeyLength (FSPDFDoc document, string sub_filter);

        // @required -(NSString *)getFileID:(FSPDFDoc *)document subFilter:(NSString *)sub_filter;
        [Abstract]
        [Export ("getFileID:subFilter:")]
        string GetFileID (FSPDFDoc document, string sub_filter);

        // @required -(NSData *)getInitialKey:(FSPDFDoc *)document subFilter:(NSString *)sub_filter;
        [Abstract]
        [Export ("getInitialKey:subFilter:")]
        NSData GetInitialKey (FSPDFDoc document, string sub_filter);
    }

    // @protocol FSCustomSecurityCallback <FSSecurityCallback>
    [Protocol, Model]
    [BaseType (typeof(NSObject))]
    interface FSCustomSecurityCallback : FSSecurityCallback
    {
        // @required -(void *)createContext:(NSString *)filter subFilter:(NSString *)subFilter encryptInfo:(NSString *)encryptInfo;
        [Abstract]
        [Export ("createContext:subFilter:encryptInfo:")]
        unsafe IntPtr CreateContext (string filter, string subFilter, string encryptInfo);

        // @required -(BOOL)releaseContext:(void *)context;
        [Abstract]
        [Export ("releaseContext:")]
        unsafe bool ReleaseContext (IntPtr context);

        // @required -(FSPDFDocUserPermissions)getUserPermissions:(void *)context userPermission:(FSPDFDocUserPermissions)userPermission;
        [Abstract]
        [Export ("getUserPermissions:userPermission:")]
        unsafe FSPDFDocUserPermissions GetUserPermissions (IntPtr context, FSPDFDocUserPermissions userPermission);

        // @required -(BOOL)isOwner:(void *)context;
        [Abstract]
        [Export ("isOwner:")]
        unsafe bool IsOwner (IntPtr context);

        // @required -(FSSecurityHandlerCipherType)getCipher:(void *)context;
        [Abstract]
        [Export ("getCipher:")]
        unsafe FSSecurityHandlerCipherType GetCipher (IntPtr context);

        // @required -(NSData *)getEncryptKey:(void *)context;
        [Abstract]
        [Export ("getEncryptKey:")]
        unsafe NSData GetEncryptKey (IntPtr context);

        // @required -(unsigned int)getDecryptedSize:(void *)context srcDataSize:(unsigned int)srcDataSize;
        [Abstract]
        [Export ("getDecryptedSize:srcDataSize:")]
        unsafe uint GetDecryptedSize (IntPtr context, uint srcDataSize);

        // @required -(void *)startDecryptor:(void *)context objNum:(int)objNum genNum:(int)genNum;
        [Abstract]
        [Export ("startDecryptor:objNum:genNum:")]
        unsafe IntPtr StartDecryptor (IntPtr context, int objNum, int genNum);

        // @required -(NSData *)decryptData:(void *)decryptor encryptedData:(void *)encryptedData encryptedDataLen:(unsigned int)encryptedDataLen;
        [Abstract]
        [Export ("decryptData:encryptedData:encryptedDataLen:")]
        unsafe NSData DecryptData (IntPtr decryptor, IntPtr encryptedData, uint encryptedDataLen);

        // @required -(NSData *)finishDecryptor:(void *)decryptor;
        [Abstract]
        [Export ("finishDecryptor:")]
        unsafe NSData FinishDecryptor (IntPtr decryptor);

        // @required -(unsigned int)getEncryptedSize:(void *)context objNum:(int)objNum genNum:(int)genNum srcData:(void *)srcData srcDataLen:(unsigned int)srcDataLen;
        [Abstract]
        [Export ("getEncryptedSize:objNum:genNum:srcData:srcDataLen:")]
        unsafe uint GetEncryptedSize (IntPtr context, int objNum, int genNum, IntPtr srcData, uint srcDataLen);

        // @required -(BOOL)encryptData:(void *)context objNum:(int)objNum genNum:(int)genNum srcData:(void *)srcData srcDataLen:(unsigned int)srcDataLen dstBuffer:(void *)dstBuffer dstBufferLen:(unsigned int *)dstBufferLen;
        [Abstract]
        [Export ("encryptData:objNum:genNum:srcData:srcDataLen:dstBuffer:dstBufferLen:")]
        unsafe bool EncryptData (IntPtr context, int objNum, int genNum, IntPtr srcData, uint srcDataLen, IntPtr dstBuffer, IntPtr dstBufferLen);
    }

    // @protocol FSRMSSecurityCallback <FSCustomSecurityCallback>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface FSRMSSecurityCallback : FSCustomSecurityCallback
    {
    }

    // @protocol FSSignatureCallback <NSObject>
    [Protocol, Model]
    [BaseType (typeof(NSObject))]
    interface FSSignatureCallback
    {
        // @required -(BOOL)startCalcDigest:(id<FSFileReaderCallback>)file byteRangeArray:(NSArray<NSNumber *> *)byteRangeArray signature:(FSSignature *)signature clientData:(void *)clientData;
        [Abstract]
        [Export ("startCalcDigest:byteRangeArray:signature:clientData:")]
        unsafe bool StartCalcDigest (FSFileReaderCallback file, NSNumber[] byteRangeArray, FSSignature signature, IntPtr clientData);

        // @required -(FSProgressiveState)continueCalcDigest:(id<FSPauseCallback>)pause clientData:(void *)clientData;
        [Abstract]
        [Export ("continueCalcDigest:clientData:")]
        unsafe FSProgressiveState ContinueCalcDigest (FSPauseCallback pause, IntPtr clientData);

        // @required -(NSData *)getDigest:(void *)clientData;
        [Abstract]
        [Export ("getDigest:")]
        unsafe NSData GetDigest (IntPtr clientData);

        // @required -(NSData *)sign:(NSData *)digest certPath:(NSString *)certPath certPassword:(NSString *)certPassword digestAlgorithm:(FSSignatureDigestAlgorithm)digestAlgorithm clientData:(void *)clientData;
        [Abstract]
        [Export ("sign:certPath:certPassword:digestAlgorithm:clientData:")]
        unsafe NSData Sign (NSData digest, string certPath, string certPassword, FSSignatureDigestAlgorithm digestAlgorithm, IntPtr clientData);

        // @required -(FSSignatureStates)verifySigState:(NSData *)digest signedData:(NSData *)signedData clientData:(void *)clientData;
        [Abstract]
        [Export ("verifySigState:signedData:clientData:")]
        unsafe FSSignatureStates VerifySigState (NSData digest, NSData signedData, IntPtr clientData);

        // @required -(BOOL)isNeedPadData;
        [Abstract]
        [Export ("isNeedPadData")]
        //[Verify (MethodToProperty)]
        bool IsNeedPadData { get; }
    }

    // @protocol FSAppProviderCallback <NSObject>
    [Protocol, Model]
    [BaseType (typeof(NSObject))]
    interface FSAppProviderCallback
    {
        // @required -(NSString *)getAppInfo:(FSAppProviderCallbackAppInfo)app_info;
        [Abstract]
        [Export ("getAppInfo:")]
        string GetAppInfo (FSAppProviderCallbackAppInfo app_info);

        // @required -(void)beep:(FSAppProviderCallbackBeepType)type;
        [Abstract]
        [Export ("beep:")]
        void Beep (FSAppProviderCallbackBeepType type);

        // @required -(FSAppProviderCallbackMsgBoxButtonID)msgBox:(NSString *)message title:(NSString *)title;
        [Abstract]
        [Export ("msgBox:title:")]
        FSAppProviderCallbackMsgBoxButtonID MsgBox (string message, string title);

        // @required -(NSString *)response:(NSString *)question title:(NSString *)title default_answer:(NSString *)default_answer is_mask:(BOOL)is_mask;
        [Abstract]
        [Export ("response:title:default_answer:is_mask:")]
        string Response (string question, string title, string default_answer, bool is_mask);

        // @required -(id<FSFileReaderCallback>)downLoadUrl:(NSString *)url;
        [Abstract]
        [Export ("downLoadUrl:")]
        FSFileReaderCallback DownLoadUrl (string url);

        // @required -(NSString *)postRequestURL:(NSString *)url data:(NSString *)data content_type:(NSString *)content_type encode:(NSString *)encode header:(NSString *)header;
        [Abstract]
        [Export ("postRequestURL:data:content_type:encode:header:")]
        string PostRequestURL (string url, string data, string content_type, string encode, string header);

        // @required -(BOOL)putRequestURL:(NSString *)url data:(NSString *)data encode:(NSString *)encode;
        [Abstract]
        [Export ("putRequestURL:data:encode:")]
        bool PutRequestURL (string url, string data, string encode);

        // @required -(NSString *)loadString:(FSAppProviderCallbackStringID)string_id;
        [Abstract]
        [Export ("loadString:")]
        string LoadString (FSAppProviderCallbackStringID string_id);

        // @required -(NSArray<NSString *> *)showFileDialog:(NSString *)string_title string_filter:(NSString *)string_filter is_openfile_dialog:(BOOL)is_openfile_dialog;
        [Abstract]
        [Export ("showFileDialog:string_filter:is_openfile_dialog:")]
        string[] ShowFileDialog (string string_title, string string_filter, bool is_openfile_dialog);
    }

    // @protocol FSDocProviderCallback <NSObject>
    [Protocol, Model]
    [BaseType (typeof(NSObject))]
    interface FSDocProviderCallback
    {
        // @required -(void)invalidateRect:(int)page_index rect:(FSRectF *)rect flag:(FSDocProviderCallbackInvalidateFlag)flag;
        [Abstract]
        [Export ("invalidateRect:rect:flag:")]
        void InvalidateRect (int page_index, FSRectF rect, FSDocProviderCallbackInvalidateFlag flag);

        // @required -(void)displayCaret:(int)page_index is_visible:(BOOL)is_visible rect:(FSRectF *)rect;
        [Abstract]
        [Export ("displayCaret:is_visible:rect:")]
        void DisplayCaret (int page_index, bool is_visible, FSRectF rect);

        // @required -(BOOL)getPopupPos:(int)page_index min_popup:(int)min_popup max_popup:(int)max_popup rect_widget:(FSRectF *)rect_widget inout_rect_popup:(FSRectF *)inout_rect_popup;
        [Abstract]
        [Export ("getPopupPos:min_popup:max_popup:rect_widget:inout_rect_popup:")]
        bool GetPopupPos (int page_index, int min_popup, int max_popup, FSRectF rect_widget, FSRectF inout_rect_popup);

        // @required -(BOOL)popupMenu:(int)page_index rect_popup:(FSPointF *)rect_popup;
        [Abstract]
        [Export ("popupMenu:rect_popup:")]
        bool PopupMenu (int page_index, FSPointF rect_popup);

        // @required -(int)getCurrentPage:(FSXFADoc *)doc;
        [Abstract]
        [Export ("getCurrentPage:")]
        int GetCurrentPage (FSXFADoc doc);

        // @required -(void)setCurrentPage:(FSXFADoc *)doc current_page_index:(int)current_page_index;
        [Abstract]
        [Export ("setCurrentPage:current_page_index:")]
        void SetCurrentPage (FSXFADoc doc, int current_page_index);

        // @required -(void)setChangeMark:(FSXFADoc *)doc;
        [Abstract]
        [Export ("setChangeMark:")]
        void SetChangeMark (FSXFADoc doc);

        // @required -(NSString *)getTitle:(FSXFADoc *)doc;
        [Abstract]
        [Export ("getTitle:")]
        string GetTitle (FSXFADoc doc);

        // @required -(void)setFocus:(FSXFAWidget *)xfa_widget;
        [Abstract]
        [Export ("setFocus:")]
        void SetFocus (FSXFAWidget xfa_widget);

        // @required -(void)exportData:(FSXFADoc *)doc file_path:(NSString *)file_path;
        [Abstract]
        [Export ("exportData:file_path:")]
        void ExportData (FSXFADoc doc, string file_path);

        // @required -(void)importData:(FSXFADoc *)doc file_path:(NSString *)file_path;
        [Abstract]
        [Export ("importData:file_path:")]
        void ImportData (FSXFADoc doc, string file_path);

        // @required -(void)gotoURL:(FSXFADoc *)doc url:(NSString *)url;
        [Abstract]
        [Export ("gotoURL:url:")]
        void GotoURL (FSXFADoc doc, string url);

        // @required -(void)print:(FSXFADoc *)doc start_page_index:(int)start_page_index end_page_index:(int)end_page_index options:(int)options;
        [Abstract]
        [Export ("print:start_page_index:end_page_index:options:")]
        void Print (FSXFADoc doc, int start_page_index, int end_page_index, int options);

        // @required -(int)getHighlightColor:(FSXFADoc *)doc;
        [Abstract]
        [Export ("getHighlightColor:")]
        int GetHighlightColor (FSXFADoc doc);

        // @required -(BOOL)submitData:(FSXFADoc *)doc target:(NSString *)target format:(FSDocProviderCallbackSubmitFormat)format text_encoding:(FSDocProviderCallbackTextEncoding)text_encoding content:(NSString *)content;
        [Abstract]
        [Export ("submitData:target:format:text_encoding:content:")]
        bool SubmitData (FSXFADoc doc, string target, FSDocProviderCallbackSubmitFormat format, FSDocProviderCallbackTextEncoding text_encoding, string content);

        // @required -(void)pageViewEvent:(int)page_index page_view_event_type:(FSDocProviderCallbackPageViewEventType)page_view_event_type;
        [Abstract]
        [Export ("pageViewEvent:page_view_event_type:")]
        void PageViewEvent (int page_index, FSDocProviderCallbackPageViewEventType page_view_event_type);
		// @required -(void)widgetEvent:(FSXFAWidget *)xfa_widget widget_event_type:(FSDocProviderCallbackWidgetEventType)widget_event_type;
		[Abstract]
		[Export ("widgetEvent:widget_event_type:")]
		void WidgetEvent (FSXFAWidget xfa_widget, FSDocProviderCallbackWidgetEventType widget_event_type);
    }

    // @interface FSSwiftException : NSObject
    [BaseType (typeof(NSObject))]
    interface FSSwiftException
    {
        // +(BOOL)tryBlock:(void (^)(void))block error:(NSError **)error;
        [Static]
        [Export ("tryBlock:error:")]
        bool TryBlock (Action block, out NSError error);
    }

    // typedef void (^InstallSecurityHandlerCallback)(BOOL, NSString *, NSString *);
    delegate void InstallSecurityHandlerCallback (bool arg0, string arg1, string arg2);

    // @interface RMSProtection : NSObject <FSRMSSecurityCallback>
    [BaseType (typeof(NSObject))]
    interface RMSProtection : FSRMSSecurityCallback
    {
        // @property (nonatomic, weak) FSPDFViewCtrl * pdfViewCtrl;
        [Export ("pdfViewCtrl", ArgumentSemantic.Weak)]
        FSPDFViewCtrl PdfViewCtrl { get; set; }

        // @property (nonatomic, strong) MSUserPolicy * userPolicy;
        //[Export ("userPolicy", ArgumentSemantic.Strong)]
        //MSUserPolicy UserPolicy { get; set; }

        // @property (nonatomic, strong) NSOperationQueue * queueRMS;
        [Export ("queueRMS", ArgumentSemantic.Strong)]
        NSOperationQueue QueueRMS { get; set; }

        // @property (assign, nonatomic) BOOL isMSIRMEncryption;
        [Export ("isMSIRMEncryption")]
        bool IsMSIRMEncryption { get; set; }

        // @property (assign, nonatomic) BOOL isFXRMSEncryption;
        [Export ("isFXRMSEncryption")]
        bool IsFXRMSEncryption { get; set; }

        // @property (nonatomic, strong) MSConsentManager * consentManager;
        //[Export ("consentManager", ArgumentSemantic.Strong)]
        //MSConsentManager ConsentManager { get; set; }

        // -(instancetype)initWithPDFViewCtrl:(FSPDFViewCtrl *)pdfViewCtrl;
        [Export ("initWithPDFViewCtrl:")]
        IntPtr Constructor (FSPDFViewCtrl pdfViewCtrl);

        // -(BOOL)installSecurityHandler:(InstallSecurityHandlerCallback)handler;
        [Export ("installSecurityHandler:")]
        bool InstallSecurityHandler (InstallSecurityHandlerCallback handler);

        // -(BOOL)savePPDFDocument:(NSString *)tempPath saveFlags:(int)flag;
        [Export ("savePPDFDocument:saveFlags:")]
        bool SavePPDFDocument (string tempPath, int flag);

        // -(unsigned int)GetPermission:(unsigned int)permission;
        [Export ("GetPermission:")]
        uint GetPermission (uint permission);

        // -(BOOL)isOwner;
        //[Export ("isOwner")]
        ////[Verify (MethodToProperty)]
        //bool IsOwner { get; }

        //// -(BOOL)isOwner:(int)permissions;
        //[Export ("isOwner:")]
        //bool IsOwnerWithPermission (int permissions);

        // -(BOOL)canPrint:(int)permissions;
        [Export ("canPrint:")]
        bool CanPrint (int permissions);

        // -(BOOL)canPrintHighQuality:(int)permissions;
        [Export ("canPrintHighQuality:")]
        bool CanPrintHighQuality (int permissions);

        // -(BOOL)canFillForm:(int)permissions;
        [Export ("canFillForm:")]
        bool CanFillForm (int permissions);

        // -(BOOL)canAddAnnot:(int)permissions;
        [Export ("canAddAnnot:")]
        bool CanAddAnnot (int permissions);

        // -(BOOL)canAssemble:(int)permissions;
        [Export ("canAssemble:")]
        bool CanAssemble (int permissions);

        // -(BOOL)canModifyContents:(int)permissions;
        [Export ("canModifyContents:")]
        bool CanModifyContents (int permissions);

        // -(BOOL)canCopyForAssess:(int)permissions;
        [Export ("canCopyForAssess:")]
        bool CanCopyForAssess (int permissions);

        // -(BOOL)canCopy:(int)permissions;
        [Export ("canCopy:")]
        bool CanCopy (int permissions);

        // -(BOOL)canSigning:(int)permissions;
        [Export ("canSigning:")]
        bool CanSigning (int permissions);

        // -(BOOL)hasPermission:(unsigned int)permission;
        [Export ("hasPermission:")]
        bool HasPermission (uint permission);

        // -(int)pdfPermissionFromUserPolicy;
        [Export ("pdfPermissionFromUserPolicy")]
        //[Verify (MethodToProperty)]
        int PdfPermissionFromUserPolicy { get; }
    }

    // @protocol IRecoveryEventListener <NSObject>
    [Protocol, Model]
    [BaseType (typeof(NSObject))]
    interface IRecoveryEventListener
    {
        // @optional -(void)onWillRecover;
        [Export ("onWillRecover")]
        void OnWillRecover ();

        // @optional -(void)onRecovered;
        [Export ("onRecovered")]
        void OnRecovered ();
    }

    // @protocol IRotationEventListener <NSObject>
    [Protocol, Model]
    [BaseType (typeof(NSObject))]
    interface IRotationEventListener
    {
        // @optional -(void)willRotateToInterfaceOrientation:(UIInterfaceOrientation)toInterfaceOrientation duration:(NSTimeInterval)duration;
        [Export ("willRotateToInterfaceOrientation:duration:")]
        void WillRotateToInterfaceOrientation (UIInterfaceOrientation toInterfaceOrientation, double duration);

        // @optional -(void)willAnimateRotationToInterfaceOrientation:(UIInterfaceOrientation)toInterfaceOrientation duration:(NSTimeInterval)duration;
        [Export ("willAnimateRotationToInterfaceOrientation:duration:")]
        void WillAnimateRotationToInterfaceOrientation (UIInterfaceOrientation toInterfaceOrientation, double duration);

        // @optional -(void)didRotateFromInterfaceOrientation:(UIInterfaceOrientation)fromInterfaceOrientation;
        [Export ("didRotateFromInterfaceOrientation:")]
        void DidRotateFromInterfaceOrientation (UIInterfaceOrientation fromInterfaceOrientation);
    }

    // @protocol IDocEventListener <NSObject>
    [Protocol, Model]
    [BaseType (typeof(NSObject))]
    interface IDocEventListener
    {
        // @optional -(void)onDocWillOpen;
        [Export ("onDocWillOpen")]
        void OnDocWillOpen ();

        // @optional -(void)onDocOpened:(FSPDFDoc * _Nullable)document error:(int)error;
        [Export ("onDocOpened:error:")]
        void OnDocOpened ([NullAllowed] FSPDFDoc document, int error);

        // @optional -(void)onDocWillClose:(FSPDFDoc * _Nonnull)document;
        [Export ("onDocWillClose:")]
        void OnDocWillClose (FSPDFDoc document);

        // @optional -(void)onDocClosed:(FSPDFDoc * _Nullable)document error:(int)error;
        [Export ("onDocClosed:error:")]
        void OnDocClosed ([NullAllowed] FSPDFDoc document, int error);

        // @optional -(void)onDocWillSave:(FSPDFDoc * _Nonnull)document;
        [Export ("onDocWillSave:")]
        void OnDocWillSave (FSPDFDoc document);

        // @optional -(void)onDocSaved:(FSPDFDoc * _Nonnull)document error:(int)error;
        [Export ("onDocSaved:error:")]
        void OnDocSaved (FSPDFDoc document, int error);
    }

    // @protocol IPageEventListener <NSObject>
    [Protocol, Model]
    [BaseType (typeof(NSObject))]
    interface IPageEventListener
    {
        // @optional -(void)onPageChanged:(int)oldIndex currentIndex:(int)currentIndex;
        [Export ("onPageChanged:currentIndex:")]
        void OnPageChanged (int oldIndex, int currentIndex);

        // @optional -(void)onPageVisible:(int)index;
        [Export ("onPageVisible:")]
        void OnPageVisible (int index);

        // @optional -(void)onPageInvisible:(int)index;
        [Export ("onPageInvisible:")]
        void OnPageInvisible (int index);

        // @optional -(void)onPageJumped;
        [Export ("onPageJumped")]
        void OnPageJumped ();

        // @optional -(void)onPagesWillRemove:(NSArray<NSNumber *> * _Nonnull)indexes;
        [Export ("onPagesWillRemove:")]
        void OnPagesWillRemove (NSNumber[] indexes);

        // @optional -(void)onPagesWillMove:(NSArray<NSNumber *> * _Nonnull)indexes dstIndex:(int)dstIndex;
        [Export ("onPagesWillMove:dstIndex:")]
        void OnPagesWillMove (NSNumber[] indexes, int dstIndex);

        // @optional -(void)onPagesWillRotate:(NSArray<NSNumber *> * _Nonnull)indexes rotation:(int)rotation;
        [Export ("onPagesWillRotate:rotation:")]
        void OnPagesWillRotate (NSNumber[] indexes, int rotation);

        // @optional -(void)onPagesRemoved:(NSArray<NSNumber *> * _Nonnull)indexes;
        [Export ("onPagesRemoved:")]
        void OnPagesRemoved (NSNumber[] indexes);

        // @optional -(void)onPagesMoved:(NSArray<NSNumber *> * _Nonnull)indexes dstIndex:(int)dstIndex;
        [Export ("onPagesMoved:dstIndex:")]
        void OnPagesMoved (NSNumber[] indexes, int dstIndex);

        // @optional -(void)onPagesRotated:(NSArray<NSNumber *> * _Nonnull)indexes rotation:(int)rotation;
        [Export ("onPagesRotated:rotation:")]
        void OnPagesRotated (NSNumber[] indexes, int rotation);

        // @optional -(void)onPagesInsertedAtRange:(NSRange)range;
        [Export ("onPagesInsertedAtRange:")]
        void OnPagesInsertedAtRange (NSRange range);
    }

    // @protocol ILayoutEventListener <NSObject>
    [Protocol, Model]
    [BaseType (typeof(NSObject))]
    interface ILayoutEventListener
    {
        // @optional -(void)onLayoutModeChanged:(PDF_LAYOUT_MODE)oldLayoutMode newLayoutMode:(PDF_LAYOUT_MODE)newLayoutMode;
        [Export ("onLayoutModeChanged:newLayoutMode:")]
        void OnLayoutModeChanged (PDF_LAYOUT_MODE oldLayoutMode, PDF_LAYOUT_MODE newLayoutMode);

        // @optional -(void)onLayoutFinished;
        [Export ("onLayoutFinished")]
        void OnLayoutFinished ();
    }

    // @protocol IScrollViewEventListener <NSObject>
    [Protocol, Model]
    [BaseType (typeof(NSObject))]
    interface IScrollViewEventListener
    {
        // @optional -(void)onScrollViewDidScroll:(UIScrollView * _Nonnull)scrollView;
        [Export ("onScrollViewDidScroll:")]
        void OnScrollViewDidScroll (UIScrollView scrollView);

        // @optional -(void)onScrollViewDidZoom:(UIScrollView * _Nonnull)scrollView;
        [Export ("onScrollViewDidZoom:")]
        void OnScrollViewDidZoom (UIScrollView scrollView);

        // @optional -(void)onScrollViewWillBeginDragging:(UIScrollView * _Nonnull)scrollView;
        [Export ("onScrollViewWillBeginDragging:")]
        void OnScrollViewWillBeginDragging (UIScrollView scrollView);

        // @optional -(void)onScrollViewDidEndDragging:(UIScrollView * _Nonnull)scrollView willDecelerate:(BOOL)decelerate;
        [Export ("onScrollViewDidEndDragging:willDecelerate:")]
        void OnScrollViewDidEndDragging (UIScrollView scrollView, bool decelerate);

        // @optional -(void)onScrollViewWillBeginDecelerating:(UIScrollView * _Nonnull)scrollView;
        [Export ("onScrollViewWillBeginDecelerating:")]
        void OnScrollViewWillBeginDecelerating (UIScrollView scrollView);

        // @optional -(void)onScrollViewDidEndDecelerating:(UIScrollView * _Nonnull)scrollView;
        [Export ("onScrollViewDidEndDecelerating:")]
        void OnScrollViewDidEndDecelerating (UIScrollView scrollView);

        // @optional -(void)onScrollViewWillBeginZooming:(UIScrollView * _Nonnull)scrollView;
        [Export ("onScrollViewWillBeginZooming:")]
        void OnScrollViewWillBeginZooming (UIScrollView scrollView);

        // @optional -(void)onScrollViewDidEndZooming:(UIScrollView * _Nonnull)scrollView;
        [Export ("onScrollViewDidEndZooming:")]
        void OnScrollViewDidEndZooming (UIScrollView scrollView);
    }

    // @protocol IGestureEventListener <NSObject>
    [Protocol, Model]
    [BaseType (typeof(NSObject))]
    interface IGestureEventListener
    {
        // @optional -(BOOL)onLongPress:(UILongPressGestureRecognizer * _Nonnull)gestureRecognizer;
        [Export ("onLongPress:")]
        bool OnLongPress (UILongPressGestureRecognizer gestureRecognizer);

        // @optional -(BOOL)onTap:(UITapGestureRecognizer * _Nonnull)gestureRecognizer;
        [Export ("onTap:")]
        bool OnTap (UITapGestureRecognizer gestureRecognizer);

        // @optional -(BOOL)onPan:(UIPanGestureRecognizer * _Nonnull)gestureRecognizer;
        [Export ("onPan:")]
        bool OnPan (UIPanGestureRecognizer gestureRecognizer);

        // @optional -(BOOL)onShouldBegin:(UIGestureRecognizer * _Nonnull)gestureRecognizer;
        [Export ("onShouldBegin:")]
        bool OnShouldBegin (UIGestureRecognizer gestureRecognizer);
    }

    // @protocol IDrawEventListener <NSObject>
    [Protocol, Model]
    [BaseType (typeof(NSObject))]
    interface IDrawEventListener
    {
        // @required -(void)onDraw:(int)pageIndex inContext:(CGContextRef _Nonnull)context;
        [Abstract]
        [Export ("onDraw:inContext:")]
        unsafe void InContext (int pageIndex,  IntPtr context);
    }

    // @protocol ITouchEventListener <NSObject>
    [Protocol, Model]
    [BaseType (typeof(NSObject))]
    interface ITouchEventListener
    {
        // @optional -(BOOL)onTouchesBegan:(NSSet * _Nonnull)touches withEvent:(UIEvent * _Nonnull)event;
        [Export ("onTouchesBegan:withEvent:")]
        bool OnTouchesBegan (NSSet touches, UIEvent @event);

        // @optional -(BOOL)onTouchesMoved:(NSSet * _Nonnull)touches withEvent:(UIEvent * _Nonnull)event;
        [Export ("onTouchesMoved:withEvent:")]
        bool OnTouchesMoved (NSSet touches, UIEvent @event);

        // @optional -(BOOL)onTouchesEnded:(NSSet * _Nonnull)touches withEvent:(UIEvent * _Nonnull)event;
        [Export ("onTouchesEnded:withEvent:")]
        bool OnTouchesEnded (NSSet touches, UIEvent @event);

        // @optional -(BOOL)onTouchesCancelled:(NSSet * _Nonnull)touches withEvent:(UIEvent * _Nonnull)event;
        [Export ("onTouchesCancelled:withEvent:")]
        bool OnTouchesCancelled (NSSet touches, UIEvent @event);
    }

    // @protocol ConnectedPDFDelegate <NSObject>
    [Protocol, Model]
    [BaseType (typeof(NSObject))]
    interface ConnectedPDFDelegate
    {
        // @required -(NSString * _Nonnull)getLoginUserToken;
        [Abstract]
        [Export ("getLoginUserToken")]
        //[Verify (MethodToProperty)]
        string LoginUserToken { get; }

        // @required -(FSClientInfo * _Nonnull)getClientInfo;
        //[Abstract]
        //[Export ("getClientInfo")]
        ////[Verify (MethodToProperty)]
        //FSClientInfo ClientInfo { get; }

        // @required -(void)needLogin;
        [Abstract]
        [Export ("needLogin")]
        void NeedLogin ();

        // @required -(void)onACLReceived:(NSString * _Nonnull)acl forDoc:(FSPDFDoc * _Nonnull)pdfDoc;
        [Abstract]
        [Export ("onACLReceived:forDoc:")]
        void OnACLReceived (string acl, FSPDFDoc pdfDoc);

        // @required -(void)onErrorReport:(int)errorCode forDoc:(FSPDFDoc * _Nonnull)pdfDoc;
        [Abstract]
        [Export ("onErrorReport:forDoc:")]
        void OnErrorReport (int errorCode, FSPDFDoc pdfDoc);
    }

    // @protocol FSPDFUIExtensionsManager <IGestureEventListener, IDrawEventListener, ITouchEventListener, ConnectedPDFDelegate>
    [Protocol, Model]
    interface FSPDFUIExtensionsManager : IGestureEventListener, IDrawEventListener, ITouchEventListener, ConnectedPDFDelegate
    {
        // @optional -(BOOL)shouldDrawAnnot:(FSAnnot * _Nonnull)annot;
        [Export ("shouldDrawAnnot:")]
        bool ShouldDrawAnnot (FSAnnot annot);
    }

    // @protocol FSPageOrganizerDelegate <NSObject>
    [Protocol, Model]
    [BaseType (typeof(NSObject))]
    interface FSPageOrganizerDelegate
    {
        // @required -(NSString * _Nonnull)getDocumentFilePath;
        [Abstract]
        [Export ("getDocumentFilePath")]
        //[Verify (MethodToProperty)]
        string DocumentFilePath { get; }

        // @required -(BOOL)movePagesFromIndexes:(NSArray<NSNumber *> * _Nonnull)sourcePageIndexes toIndex:(NSUInteger)pageIndex;
        [Abstract]
        [Export ("movePagesFromIndexes:toIndex:")]
        bool MovePagesFromIndexes (NSNumber[] sourcePageIndexes, nuint pageIndex);

        // @required -(BOOL)deletePagesAtIndexes:(NSArray<NSNumber *> * _Nonnull)pageIndexes;
        [Abstract]
        [Export ("deletePagesAtIndexes:")]
        bool DeletePagesAtIndexes (NSNumber[] pageIndexes);

        // @required -(BOOL)rotatePagesAtIndexes:(NSArray<NSNumber *> * _Nonnull)pageIndexes clockwise:(BOOL)clockwise;
        [Abstract]
        [Export ("rotatePagesAtIndexes:clockwise:")]
        bool RotatePagesAtIndexes (NSNumber[] pageIndexes, bool clockwise);

        // @required -(BOOL)insertPageFromImage:(UIImage * _Nonnull)image atIndex:(NSUInteger)pageIndex;
        [Abstract]
        [Export ("insertPageFromImage:atIndex:")]
        bool InsertPageFromImage (UIImage image, nuint pageIndex);

        // @required -(void)insertPagesFromDocument:(FSPDFDoc * _Nonnull)document withSourceIndexes:(NSArray<NSNumber *> * _Nonnull)sourcePagesIndexes flags:(FSPDFDocImportPageFlags)flags layerName:(NSString * _Nullable)layerName atIndex:(NSUInteger)destinationIndex success:(void (^ _Nonnull)(NSString * _Nonnull))success error:(void (^ _Nonnull)(NSString * _Nonnull))error;
        [Abstract]
        [Export ("insertPagesFromDocument:withSourceIndexes:flags:layerName:atIndex:success:error:")]
        void InsertPagesFromDocument (FSPDFDoc document, NSNumber[] sourcePagesIndexes, FSPDFDocImportPageFlags flags, [NullAllowed] string layerName, nuint destinationIndex, Action<NSString> success, Action<NSString> error);
    }

    // @interface FSPDFViewCtrl : UIView <IRotationEventListener, FSPageOrganizerDelegate>
    [BaseType (typeof(UIView))]
    interface FSPDFViewCtrl : IRotationEventListener, FSPageOrganizerDelegate
    {
        // @property (nonatomic, weak) id<FSPDFUIExtensionsManager> _Nullable extensionsManager;
        [NullAllowed, Export ("extensionsManager", ArgumentSemantic.Weak)]
        NSObject ExtensionsManager { get; set; }

        // @property (nonatomic, strong) FSPDFDoc * _Nullable currentDoc;
        [NullAllowed, Export ("currentDoc", ArgumentSemantic.Strong)]
        FSPDFDoc CurrentDoc { get; set; }

        // @property (assign, nonatomic) BOOL isNightMode;
        [Export ("isNightMode")]
        bool IsNightMode { get; set; }

        // @property (assign, nonatomic) FSRendererColorMode colorMode;
        [Export ("colorMode", ArgumentSemantic.Assign)]
        FSRendererColorMode ColorMode { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable mappingModeBackgroundColor;
        [NullAllowed, Export ("mappingModeBackgroundColor", ArgumentSemantic.Strong)]
        UIColor MappingModeBackgroundColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable mappingModeForegroundColor;
        [NullAllowed, Export ("mappingModeForegroundColor", ArgumentSemantic.Strong)]
        UIColor MappingModeForegroundColor { get; set; }

        // @property (assign, nonatomic) int bottomOffset;
        [Export ("bottomOffset")]
        int BottomOffset { get; set; }

        // @property (assign, nonatomic) BOOL shouldRecover;
        [Export ("shouldRecover")]
        bool ShouldRecover { get; set; }

        // @property (readonly, nonatomic, strong) NSString * _Nullable filePath;
        [NullAllowed, Export ("filePath", ArgumentSemantic.Strong)]
        string FilePath { get; }

        // @property (nonatomic) CGFloat maxZoomLimit;
        [Export ("maxZoomLimit")]
        nfloat MaxZoomLimit { get; set; }

        // @property (nonatomic) CGFloat minZoomLimit;
        [Export ("minZoomLimit")]
        nfloat MinZoomLimit { get; set; }

        // @property (nonatomic) BOOL IsChangeLayoutMode;
        [Export ("IsChangeLayoutMode")]
        bool IsChangeLayoutMode { get; set; }

        // -(instancetype _Nonnull)initWithFrame:(CGRect)frame;
        [Export ("initWithFrame:")]
        IntPtr Constructor (CGRect frame);

        // -(void)registerDocEventListener:(id<IDocEventListener> _Nonnull)listener;
        [Export ("registerDocEventListener:")]
        void RegisterDocEventListener (NSObject listener);

        // -(void)registerPageEventListener:(id<IPageEventListener> _Nonnull)listener;
        [Export ("registerPageEventListener:")]
        void RegisterPageEventListener (IPageEventListener listener);

        // -(void)registerScrollViewEventListener:(id<IScrollViewEventListener> _Nonnull)listener;
        [Export ("registerScrollViewEventListener:")]
        void RegisterScrollViewEventListener (IScrollViewEventListener listener);

        // -(void)registerLayoutEventListener:(id<ILayoutEventListener> _Nonnull)listener;
        [Export ("registerLayoutEventListener:")]
        void RegisterLayoutEventListener (ILayoutEventListener listener);

        // -(void)registerGestureEventListener:(id<IGestureEventListener> _Nonnull)listener;
        [Export ("registerGestureEventListener:")]
        void RegisterGestureEventListener (IGestureEventListener listener);

        // -(void)registerDrawEventListener:(id<IDrawEventListener> _Nonnull)listener;
        [Export ("registerDrawEventListener:")]
        void RegisterDrawEventListener (IDrawEventListener listener);

        // -(void)registerRecoveryEventListener:(id<IRecoveryEventListener> _Nonnull)listener;
        [Export ("registerRecoveryEventListener:")]
        void RegisterRecoveryEventListener (IRecoveryEventListener listener);

        // -(void)unregisteRecoveryEventListener:(id<IRecoveryEventListener> _Nonnull)listener;
        [Export ("unregisteRecoveryEventListener:")]
        void UnregisteRecoveryEventListener (IRecoveryEventListener listener);

        // -(void)unregisterDrawEventListener:(id<IDrawEventListener> _Nonnull)listener;
        [Export ("unregisterDrawEventListener:")]
        void UnregisterDrawEventListener (IDrawEventListener listener);

        // -(void)unregisterGestureEventListener:(id<IGestureEventListener> _Nonnull)listener;
        [Export ("unregisterGestureEventListener:")]
        void UnregisterGestureEventListener (IGestureEventListener listener);

        // -(void)unregisterDocEventListener:(id<IDocEventListener> _Nonnull)listener;
        [Export ("unregisterDocEventListener:")]
        void UnregisterDocEventListener (IDocEventListener listener);

        // -(void)unregisterPageEventListener:(id<IPageEventListener> _Nonnull)listener;
        [Export ("unregisterPageEventListener:")]
        void UnregisterPageEventListener (IPageEventListener listener);

        // -(void)unregisterScrollViewEventListener:(id<IScrollViewEventListener> _Nonnull)listener;
        [Export ("unregisterScrollViewEventListener:")]
        void UnregisterScrollViewEventListener (IScrollViewEventListener listener);

        // -(void)unregisterLayoutEventListener:(id<ILayoutEventListener> _Nonnull)listener;
        [Export ("unregisterLayoutEventListener:")]
        void UnregisterLayoutEventListener (ILayoutEventListener listener);

        // -(void)setDoc:(FSPDFDoc * _Nonnull)doc;
        [Export ("setDoc:")]
        void SetDoc (FSPDFDoc doc);

        // -(void)setPDFDoc:(FSPDFDoc * _Nonnull)doc XFADoc:(FSXFADoc * _Nonnull)xfadoc;
        [Export ("setPDFDoc:XFADoc:")]
        void SetPDFDoc (FSPDFDoc doc, FSXFADoc xfadoc);

        // -(FSPDFDoc * _Nonnull)getDoc;
        [Export ("getDoc")]
        //[Verify (MethodToProperty)]
        FSPDFDoc Doc { get; }

        // -(FSPDFDocUserPermissions)getDocPermissions;
        [Export ("getDocPermissions")]
        //[Verify (MethodToProperty)]
        FSPDFDocUserPermissions DocPermissions { get; }

        // -(_Bool)isOwner;
        [Export ("isOwner")]
        //[Verify (MethodToProperty)]
        bool IsOwner { get; }

        // -(_Bool)isPPDF;
        [Export ("isPPDF")]
        //[Verify (MethodToProperty)]
        bool IsPPDF { get; }

        // -(void)openDoc:(NSString * _Nonnull)filePath password:(NSString * _Nullable)password completion:(void (^ _Nullable)(FSErrorCode))completion;
        [Export ("openDoc:password:completion:")]
        void OpenDoc (string filePath, [NullAllowed] string password, [NullAllowed] Action<FSErrorCode> completion);

        // -(void)openDocFromMemory:(NSData * _Nonnull)buffer password:(NSString * _Nullable)password completion:(void (^ _Nullable)(FSErrorCode))completion;
        [Export ("openDocFromMemory:password:completion:")]
        void OpenDocFromMemory (NSData buffer, [NullAllowed] string password, [NullAllowed] Action<FSErrorCode> completion);

        // -(void)closeDoc:(void (^ _Nullable)(void))cleanup;
        [Export ("closeDoc:")]
        void CloseDoc ([NullAllowed] Action cleanup);

        // -(BOOL)saveDoc:(NSString * _Nonnull)filePath flag:(FSPDFDocSaveFlags)flag;
        [Export ("saveDoc:flag:")]
        bool SaveDoc (string filePath, FSPDFDocSaveFlags flag);

        // -(int)getPageCount;
        [Export ("getPageCount")]
        //[Verify (MethodToProperty)]
        int PageCount { get; }

        // -(int)getCurrentPage;
        [Export ("getCurrentPage")]
        //[Verify (MethodToProperty)]
        int CurrentPage { get; }

        // -(int)getPageIndex:(CGPoint)displayViewPt;
        [Export ("getPageIndex:")]
        int GetPageIndex (CGPoint displayViewPt);

        // -(NSMutableArray * _Nonnull)getVisiblePages;
        [Export ("getVisiblePages")]
        //[Verify (MethodToProperty)]
        NSMutableArray VisiblePages { get; }

        // -(BOOL)isPageVisible:(int)pageIndex;
        [Export ("isPageVisible:")]
        bool IsPageVisible (int pageIndex);

        // -(BOOL)gotoPage:(int)index animated:(BOOL)animated;
        [Export ("gotoPage:animated:")]
        bool GotoPage (int index, bool animated);

        // -(BOOL)gotoPage:(int)index withDocPoint:(FSPointF * _Nonnull)point animated:(BOOL)animated;
        [Export ("gotoPage:withDocPoint:animated:")]
        bool GotoPage (int index, FSPointF point, bool animated);

        // -(BOOL)gotoFirstPage:(BOOL)animated;
        [Export ("gotoFirstPage:")]
        bool GotoFirstPage (bool animated);

        // -(BOOL)gotoLastPage:(BOOL)animated;
        [Export ("gotoLastPage:")]
        bool GotoLastPage (bool animated);

        // -(BOOL)gotoNextPage:(BOOL)animated;
        [Export ("gotoNextPage:")]
        bool GotoNextPage (bool animated);

        // -(BOOL)gotoPrevPage:(BOOL)animated;
        [Export ("gotoPrevPage:")]
        bool GotoPrevPage (bool animated);

        // -(BOOL)hasPrevView;
        [Export ("hasPrevView")]
        //[Verify (MethodToProperty)]
        bool HasPrevView { get; }

        // -(BOOL)hasNextView;
        [Export ("hasNextView")]
        //[Verify (MethodToProperty)]
        bool HasNextView { get; }

        // -(void)clearPrevNextStack;
        [Export ("clearPrevNextStack")]
        void ClearPrevNextStack ();

        // -(void)gotoPrevView:(BOOL)animated;
        [Export ("gotoPrevView:")]
        void GotoPrevView (bool animated);

        // -(void)gotoNextView:(BOOL)animated;
        [Export ("gotoNextView:")]
        void GotoNextView (bool animated);

        // -(PDF_REFLOW_REFLOWMODE)getReflowMode;
        [Export ("getReflowMode")]
        //[Verify (MethodToProperty)]
        PDF_REFLOW_REFLOWMODE ReflowMode { get; }

        // -(void)setReflowMode:(PDF_REFLOW_REFLOWMODE)reflowMode;
        [Export ("setReflowMode:")]
        void SetReflowMode (PDF_REFLOW_REFLOWMODE reflowMode);

        // -(float)getZoom;
        [Export ("getZoom")]
        //[Verify (MethodToProperty)]
        float Zoom { get; }

        // -(void)setZoom:(float)zoom;
        [Export ("setZoom:")]
        void SetZoom (float zoom);

        // -(void)setZoom:(float)zoom origin:(CGPoint)origin;
        [Export ("setZoom:origin:")]
        void SetZoom (float zoom, CGPoint origin);

        // -(void)setZoomMode:(PDF_DISPLAY_ZOOMMODE)zoomMode;
        [Export ("setZoomMode:")]
        void SetZoomMode (PDF_DISPLAY_ZOOMMODE zoomMode);

        // -(PDF_LAYOUT_MODE)getPageLayoutMode;
        [Export ("getPageLayoutMode")]
        //[Verify (MethodToProperty)]
        PDF_LAYOUT_MODE PageLayoutMode { get; }

        // -(void)setPageLayoutMode:(PDF_LAYOUT_MODE)mode;
        [Export ("setPageLayoutMode:")]
        void SetPageLayoutMode (PDF_LAYOUT_MODE mode);

        // -(UIEdgeInsets)getCropInsets:(int)pageIndex;
        [Export ("getCropInsets:")]
        UIEdgeInsets GetCropInsets (int pageIndex);

        // -(PDF_CROP_MODE)getCropMode;
        [Export ("getCropMode")]
        //[Verify (MethodToProperty)]
        PDF_CROP_MODE CropMode { get; }

        // -(BOOL)setCropMode:(PDF_CROP_MODE)mode;
        [Export ("setCropMode:")]
        bool SetCropMode (PDF_CROP_MODE mode);

        // -(BOOL)setCropPageRect:(int)pageIndex pdfRect:(FSRectF * _Nullable)pdfRect;
        [Export ("setCropPageRect:pdfRect:")]
        bool SetCropPageRect (int pageIndex, [NullAllowed] FSRectF pdfRect);

        // -(void)setBackgroundColor:(UIColor * _Nullable)color;
        [Export ("setBackgroundColor:")]
        void SetBackgroundColor ([NullAllowed] UIColor color);

        // -(double)getHScrollPos;
        [Export ("getHScrollPos")]
        //[Verify (MethodToProperty)]
        double HScrollPos { get; }

        // -(double)getVScrollPos;
        [Export ("getVScrollPos")]
        //[Verify (MethodToProperty)]
        double VScrollPos { get; }

        // -(void)setHScrollPos:(double)pos animated:(BOOL)animated;
        [Export ("setHScrollPos:animated:")]
        void SetHScrollPos (double pos, bool animated);

        // -(void)setVScrollPos:(double)pos animated:(BOOL)animated;
        [Export ("setVScrollPos:animated:")]
        void SetVScrollPos (double pos, bool animated);

        // -(double)getHScrollRange;
        [Export ("getHScrollRange")]
        //[Verify (MethodToProperty)]
        double HScrollRange { get; }

        // -(double)getVScrollRange;
        [Export ("getVScrollRange")]
        //[Verify (MethodToProperty)]
        double VScrollRange { get; }

        // -(void)scrollDisplayView:(float)distanceX distanceY:(float)distanceY;
        [Export ("scrollDisplayView:distanceY:")]
        void ScrollDisplayView (float distanceX, float distanceY);

        // -(float)getDisplayViewWidth;
        [Export ("getDisplayViewWidth")]
        //[Verify (MethodToProperty)]
        float DisplayViewWidth { get; }

        // -(float)getDisplayViewHeight;
        [Export ("getDisplayViewHeight")]
        //[Verify (MethodToProperty)]
        float DisplayViewHeight { get; }

        // -(float)getPageViewWidth:(int)pageIndex;
        [Export ("getPageViewWidth:")]
        float GetPageViewWidth (int pageIndex);

        // -(float)getPageViewHeight:(int)pageIndex;
        [Export ("getPageViewHeight:")]
        float GetPageViewHeight (int pageIndex);

        // -(UIView * _Nonnull)getDisplayView;
        [Export ("getDisplayView")]
        //[Verify (MethodToProperty)]
        UIView DisplayView { get; }

        // -(UIView * _Nonnull)getPageView:(int)pageIndex;
        [Export ("getPageView:")]
        UIView GetPageView (int pageIndex);

        // -(UIView * _Nonnull)getOverlayView:(int)pageIndex;
        [Export ("getOverlayView:")]
        UIView GetOverlayView (int pageIndex);

        // -(BOOL)appendPageView:(UIView * _Nonnull)pageView;
        [Export ("appendPageView:")]
        bool AppendPageView (UIView pageView);

        // -(CGRect)convertPageViewRectToDisplayViewRect:(CGRect)rect pageIndex:(int)pageIndex;
        [Export ("convertPageViewRectToDisplayViewRect:pageIndex:")]
        CGRect ConvertPageViewRectToDisplayViewRect (CGRect rect, int pageIndex);

        // -(CGRect)convertDisplayViewRectToPageViewRect:(CGRect)rect pageIndex:(int)pageIndex;
        [Export ("convertDisplayViewRectToPageViewRect:pageIndex:")]
        CGRect ConvertDisplayViewRectToPageViewRect (CGRect rect, int pageIndex);

        // -(CGPoint)convertDisplayViewPtToPageViewPt:(CGPoint)point pageIndex:(int)pageIndex;
        [Export ("convertDisplayViewPtToPageViewPt:pageIndex:")]
        CGPoint ConvertDisplayViewPtToPageViewPt (CGPoint point, int pageIndex);

        // -(CGPoint)convertPageViewPtToDisplayViewPt:(CGPoint)point pageIndex:(int)pageIndex;
        [Export ("convertPageViewPtToDisplayViewPt:pageIndex:")]
        CGPoint ConvertPageViewPtToDisplayViewPt (CGPoint point, int pageIndex);

        // -(CGPoint)convertPdfPtToPageViewPt:(FSPointF * _Nonnull)point pageIndex:(int)pageIndex;
        [Export ("convertPdfPtToPageViewPt:pageIndex:")]
        CGPoint ConvertPdfPtToPageViewPt (FSPointF point, int pageIndex);

        // -(FSPointF * _Nonnull)convertPageViewPtToPdfPt:(CGPoint)point pageIndex:(int)pageIndex;
        [Export ("convertPageViewPtToPdfPt:pageIndex:")]
        FSPointF ConvertPageViewPtToPdfPt (CGPoint point, int pageIndex);

        // -(CGRect)convertPdfRectToPageViewRect:(FSRectF * _Nonnull)rect pageIndex:(int)pageIndex;
        [Export ("convertPdfRectToPageViewRect:pageIndex:")]
        CGRect ConvertPdfRectToPageViewRect (FSRectF rect, int pageIndex);

        // -(FSRectF * _Nonnull)convertPageViewRectToPdfRect:(CGRect)rect pageIndex:(int)pageIndex;
        [Export ("convertPageViewRectToPdfRect:pageIndex:")]
        FSRectF ConvertPageViewRectToPdfRect (CGRect rect, int pageIndex);

        // -(FSMatrix2D * _Nonnull)getDisplayMatrix:(int)pageIndex;
        [Export ("getDisplayMatrix:")]
        FSMatrix2D GetDisplayMatrix (int pageIndex);

        // -(FSMatrix2D * _Nonnull)getDisplayMatrix:(int)pageIndex fromOrigin:(CGPoint)originPoint;
        [Export ("getDisplayMatrix:fromOrigin:")]
        FSMatrix2D GetDisplayMatrix (int pageIndex, CGPoint originPoint);

        // -(void)lockRefresh;
        [Export ("lockRefresh")]
        void LockRefresh ();

        // -(void)unlockRefresh;
        [Export ("unlockRefresh")]
        void UnlockRefresh ();

        // -(void)refresh:(CGRect)rect pageIndex:(int)pageIndex;
        [Export ("refresh:pageIndex:")]
        void Refresh (CGRect rect, int pageIndex);

        // -(void)refresh:(CGRect)rect pageIndex:(int)pageIndex needRender:(BOOL)needRender;
        [Export ("refresh:pageIndex:needRender:")]
        void Refresh (CGRect rect, int pageIndex, bool needRender);

        // -(void)refresh:(int)pageIndex;
        [Export ("refresh:")]
        void Refresh (int pageIndex);

        // -(void)refresh:(int)pageIndex needRender:(BOOL)needRender;
        [Export ("refresh:needRender:")]
        void Refresh (int pageIndex, bool needRender);

        // -(void)refresh;
        [Export ("refresh")]
        void Refresh ();

        // +(void)recoverForOOM;
        [Static]
        [Export ("recoverForOOM")]
        void RecoverForOOM ();

        // -(void)setPageSpacing:(int)pageSpace;
        [Export ("setPageSpacing:")]
        void SetPageSpacing (int pageSpace);

        // -(BOOL)isDynamicXFA;
        [Export ("isDynamicXFA")]
        //[Verify (MethodToProperty)]
        bool IsDynamicXFA { get; }

        // -(FSXFADoc * _Nonnull)getXFADoc;
        [Export ("getXFADoc")]
        //[Verify (MethodToProperty)]
        FSXFADoc XFADoc { get; }

        // -(BOOL)reloadXFADoc:(FSDocProviderCallbackPageViewEventType)page_view_event_type page_index:(NSArray<NSNumber *> * _Nonnull)pageIndexes;
        [Export ("reloadXFADoc:page_index:")]
        bool ReloadXFADoc (FSDocProviderCallbackPageViewEventType page_view_event_type, NSNumber[] pageIndexes);

        // @property (nonatomic, strong) RMSProtection * _Nonnull rmsHandler;
        [Export ("rmsHandler", ArgumentSemantic.Strong)]
        RMSProtection RmsHandler { get; set; }
    }

    // @interface rms (FSPDFViewCtrl)
    [Category]
    [BaseType (typeof(FSPDFViewCtrl))]
    interface FSPDFViewCtrl_rms
    {
        // -(void)setRMSAppClientId:(NSString * _Nonnull)appClientId redirectURI:(NSString * _Nonnull)redirectURI;
        [Export ("setRMSAppClientId:redirectURI:")]
        void SetRMSAppClientId (string appClientId, string redirectURI);
    }

    // @interface async (FSPDFViewCtrl)
    [Category]
    [BaseType (typeof(FSPDFViewCtrl))]
    interface FSPDFViewCtrl_async
    {
        // -(void)openDocAtURL:(NSURL * _Nonnull)url password:(NSString * _Nonnull)password completion:(void (^ _Nonnull)(FSErrorCode))completion;
        [Export ("openDocAtURL:password:completion:")]
        void OpenDocAtURL (NSUrl url, string password, Action<FSErrorCode> completion);
    }
}
