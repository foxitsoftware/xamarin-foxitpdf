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

namespace Foxit.iOS
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

		// -(id)initWithX:(int)X Y:(int)Y;
		[Export ("initWithX:Y:")]
		IntPtr Constructor (int X, int Y);

		// -(id)initWithOther:(FSPoint *)other;
		[Export ("initWithOther:")]
		IntPtr Constructor (FSPoint other);

		// -(void)set:(int)x y:(int)y;
		[Export ("set:y:")]
		void Set (int x, int y);

		// -(void)set:(FSPoint *)psv;
		[Export ("set:")]
		void Set (FSPoint psv);

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

		// -(id)initWithX:(float)X Y:(float)Y;
		[Export ("initWithX:Y:")]
		IntPtr Constructor (float X, float Y);

		// -(id)initWithOther:(FSPointF *)other;
		[Export ("initWithOther:")]
		IntPtr Constructor (FSPointF other);

		// -(void)set:(float)x y:(float)y;
		[Export ("set:y:")]
		void Set (float x, float y);

		// -(void)set:(FSPointF *)psv;
		[Export ("set:")]
		void Set (FSPointF psv);

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

		// -(BOOL)setSize:(int)nNewSize nGrowBy:(int)nGrowBy;
		[Export ("setSize:nGrowBy:")]
		bool SetSize (int nNewSize, int nGrowBy);

		// -(BOOL)setSize:(int)nNewSize;
		[Export ("setSize:")]
		bool SetSize (int nNewSize);

		// -(void)removeAll;
		[Export ("removeAll")]
		void RemoveAll ();

		// -(FSRectF *)getAt:(int)nIndex;
		[Export ("getAt:")]
		FSRectF GetAt (int nIndex);

		// -(BOOL)setAt:(int)nIndex newElement:(FSRectF *)newElement;
		[Export ("setAt:newElement:")]
		bool SetAt (int nIndex, FSRectF newElement);

		// -(BOOL)setAtGrow:(int)nIndex newElement:(FSRectF *)newElement;
		[Export ("setAtGrow:newElement:")]
		bool SetAtGrow (int nIndex, FSRectF newElement);

		// -(BOOL)add:(FSRectF *)newElement;
		[Export ("add:")]
		bool Add (FSRectF newElement);

		// -(BOOL)insertAt:(int)nIndex newElement:(FSRectF *)newElement nCount:(int)nCount;
		[Export ("insertAt:newElement:nCount:")]
		bool InsertAt (int nIndex, FSRectF newElement, int nCount);

		// -(BOOL)insertAt:(int)nIndex newElement:(FSRectF *)newElement;
		[Export ("insertAt:newElement:")]
		bool InsertAt (int nIndex, FSRectF newElement);

		// -(BOOL)removeAt:(int)nIndex nCount:(int)nCount;
		[Export ("removeAt:nCount:")]
		bool RemoveAt (int nIndex, int nCount);

		// -(BOOL)removeAt:(int)nIndex;
		[Export ("removeAt:")]
		bool RemoveAt (int nIndex);

		// -(BOOL)insertAt:(int)nStartIndex pNewArray:(FSBasicArray *)pNewArray;
		[Export ("insertAt:pNewArray:")]
		bool InsertAt (int nStartIndex, FSBasicArray pNewArray);

		// -(int)find:(FSRectF *)data iStart:(int)iStart;
		[Export ("find:iStart:")]
		int Find (FSRectF data, int iStart);

		// -(int)find:(FSRectF *)data;
		[Export ("find:")]
		int Find (FSRectF data);

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

		// -(BOOL)setSize:(int)nNewSize nGrowBy:(int)nGrowBy;
		[Export ("setSize:nGrowBy:")]
		bool SetSize (int nNewSize, int nGrowBy);

		// -(BOOL)setSize:(int)nNewSize;
		[Export ("setSize:")]
		bool SetSize (int nNewSize);

		// -(void)removeAll;
		[Export ("removeAll")]
		void RemoveAll ();

		// -(FSPointF *)getAt:(int)nIndex;
		[Export ("getAt:")]
		FSPointF GetAt (int nIndex);

		// -(BOOL)setAt:(int)nIndex newElement:(FSPointF *)newElement;
		[Export ("setAt:newElement:")]
		bool SetAt (int nIndex, FSPointF newElement);

		// -(BOOL)setAtGrow:(int)nIndex newElement:(FSPointF *)newElement;
		[Export ("setAtGrow:newElement:")]
		bool SetAtGrow (int nIndex, FSPointF newElement);

		// -(BOOL)add:(FSPointF *)newElement;
		[Export ("add:")]
		bool Add (FSPointF newElement);

		// -(BOOL)insertAt:(int)nIndex newElement:(FSPointF *)newElement nCount:(int)nCount;
		[Export ("insertAt:newElement:nCount:")]
		bool InsertAt (int nIndex, FSPointF newElement, int nCount);

		// -(BOOL)insertAt:(int)nIndex newElement:(FSPointF *)newElement;
		[Export ("insertAt:newElement:")]
		bool InsertAt (int nIndex, FSPointF newElement);

		// -(BOOL)removeAt:(int)nIndex nCount:(int)nCount;
		[Export ("removeAt:nCount:")]
		bool RemoveAt (int nIndex, int nCount);

		// -(BOOL)removeAt:(int)nIndex;
		[Export ("removeAt:")]
		bool RemoveAt (int nIndex);

		// -(BOOL)insertAt:(int)nStartIndex pNewArray:(FSBasicArray *)pNewArray;
		[Export ("insertAt:pNewArray:")]
		bool InsertAt (int nStartIndex, FSBasicArray pNewArray);

		// -(int)find:(FSPointF *)data iStart:(int)iStart;
		[Export ("find:iStart:")]
		int Find (FSPointF data, int iStart);

		// -(int)find:(FSPointF *)data;
		[Export ("find:")]
		int Find (FSPointF data);

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

		// -(BOOL)setSize:(int)nNewSize nGrowBy:(int)nGrowBy;
		[Export ("setSize:nGrowBy:")]
		bool SetSize (int nNewSize, int nGrowBy);

		// -(BOOL)setSize:(int)nNewSize;
		[Export ("setSize:")]
		bool SetSize (int nNewSize);

		// -(void)removeAll;
		[Export ("removeAll")]
		void RemoveAll ();

		// -(float)getAt:(int)nIndex;
		[Export ("getAt:")]
		float GetAt (int nIndex);

		// -(BOOL)setAt:(int)nIndex newElement:(float)newElement;
		[Export ("setAt:newElement:")]
		bool SetAt (int nIndex, float newElement);

		// -(BOOL)setAtGrow:(int)nIndex newElement:(float)newElement;
		[Export ("setAtGrow:newElement:")]
		bool SetAtGrow (int nIndex, float newElement);

		// -(BOOL)add:(float)newElement;
		[Export ("add:")]
		bool Add (float newElement);

		// -(BOOL)insertAt:(int)nIndex newElement:(float)newElement nCount:(int)nCount;
		[Export ("insertAt:newElement:nCount:")]
		bool InsertAt (int nIndex, float newElement, int nCount);

		// -(BOOL)insertAt:(int)nIndex newElement:(float)newElement;
		[Export ("insertAt:newElement:")]
		bool InsertAt (int nIndex, float newElement);

		// -(BOOL)removeAt:(int)nIndex nCount:(int)nCount;
		[Export ("removeAt:nCount:")]
		bool RemoveAt (int nIndex, int nCount);

		// -(BOOL)removeAt:(int)nIndex;
		[Export ("removeAt:")]
		bool RemoveAt (int nIndex);

		// -(BOOL)insertAt:(int)nStartIndex pNewArray:(FSBasicArray *)pNewArray;
		[Export ("insertAt:pNewArray:")]
		bool InsertAt (int nStartIndex, FSBasicArray pNewArray);

		// -(int)find:(float)data iStart:(int)iStart;
		[Export ("find:iStart:")]
		int Find (float data, int iStart);

		// -(int)find:(float)data;
		[Export ("find:")]
		int Find (float data);

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

		// -(BOOL)setSize:(int)nNewSize nGrowBy:(int)nGrowBy;
		[Export ("setSize:nGrowBy:")]
		bool SetSize (int nNewSize, int nGrowBy);

		// -(BOOL)setSize:(int)nNewSize;
		[Export ("setSize:")]
		bool SetSize (int nNewSize);

		// -(void)removeAll;
		[Export ("removeAll")]
		void RemoveAll ();

		// -(int)getAt:(int)nIndex;
		[Export ("getAt:")]
		int GetAt (int nIndex);

		// -(BOOL)setAt:(int)nIndex newElement:(int)newElement;
		[Export ("setAt:newElement:")]
		bool SetAt (int nIndex, int newElement);

		// -(BOOL)setAtGrow:(int)nIndex newElement:(int)newElement;
		[Export ("setAtGrow:newElement:")]
		bool SetAtGrow (int nIndex, int newElement);

		// -(BOOL)add:(int)newElement;
		[Export ("add:")]
		bool Add (int newElement);

		// -(BOOL)insertAt:(int)nIndex newElement:(int)newElement nCount:(int)nCount;
		[Export ("insertAt:newElement:nCount:")]
		bool InsertAt (int nIndex, int newElement, int nCount);

		// -(BOOL)insertAt:(int)nIndex newElement:(int)newElement;
		[Export ("insertAt:newElement:")]
		bool InsertAt (int nIndex, int newElement);

		// -(BOOL)removeAt:(int)nIndex nCount:(int)nCount;
		[Export ("removeAt:nCount:")]
		bool RemoveAt (int nIndex, int nCount);

		// -(BOOL)removeAt:(int)nIndex;
		[Export ("removeAt:")]
		bool RemoveAt (int nIndex);

		// -(BOOL)insertAt:(int)nStartIndex pNewArray:(FSBasicArray *)pNewArray;
		[Export ("insertAt:pNewArray:")]
		bool InsertAt (int nStartIndex, FSBasicArray pNewArray);

		// -(int)find:(int)data iStart:(int)iStart;
		[Export ("find:iStart:")]
		int Find (int data, int iStart);

		// -(int)find:(int)data;
		[Export ("find:")]
		int Find (int data);

		// -(void)dealloc;
		[Export ("dealloc")]
		void Dealloc ();
	}

	// @interface FSUInt32Array : FSBasicArray
	[BaseType (typeof(FSBasicArray))]
	interface FSUInt32Array
	{
		// -(void *)getCptr;
		[Export ("getCptr")]
		//[Verify (MethodToProperty)]
		IntPtr Cptr { get; }

		// -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
		[Export ("initWithCptr:swigOwnCObject:")]
		IntPtr Constructor (IntPtr cptr, bool ownCObject);

		// -(id)initWithOther:(FSUInt32Array *)other;
		[Export ("initWithOther:")]
		IntPtr Constructor (FSUInt32Array other);

		// -(int)getSize;
		[Export ("getSize")]
		//[Verify (MethodToProperty)]
		int Size { get; }

		// -(int)getUpperBound;
		[Export ("getUpperBound")]
		//[Verify (MethodToProperty)]
		int UpperBound { get; }

		// -(BOOL)setSize:(int)nNewSize nGrowBy:(int)nGrowBy;
		[Export ("setSize:nGrowBy:")]
		bool SetSize (int nNewSize, int nGrowBy);

		// -(BOOL)setSize:(int)nNewSize;
		[Export ("setSize:")]
		bool SetSize (int nNewSize);

		// -(void)removeAll;
		[Export ("removeAll")]
		void RemoveAll ();

		// -(unsigned int)getAt:(int)nIndex;
		[Export ("getAt:")]
		uint GetAt (int nIndex);

		// -(BOOL)setAt:(int)nIndex newElement:(unsigned int)newElement;
		[Export ("setAt:newElement:")]
		bool SetAt (int nIndex, uint newElement);

		// -(BOOL)setAtGrow:(int)nIndex newElement:(unsigned int)newElement;
		[Export ("setAtGrow:newElement:")]
		bool SetAtGrow (int nIndex, uint newElement);

		// -(BOOL)add:(unsigned int)newElement;
		[Export ("add:")]
		bool Add (uint newElement);

		// -(BOOL)insertAt:(int)nIndex newElement:(unsigned int)newElement nCount:(int)nCount;
		[Export ("insertAt:newElement:nCount:")]
		bool InsertAt (int nIndex, uint newElement, int nCount);

		// -(BOOL)insertAt:(int)nIndex newElement:(unsigned int)newElement;
		[Export ("insertAt:newElement:")]
		bool InsertAt (int nIndex, uint newElement);

		// -(BOOL)removeAt:(int)nIndex nCount:(int)nCount;
		[Export ("removeAt:nCount:")]
		bool RemoveAt (int nIndex, int nCount);

		// -(BOOL)removeAt:(int)nIndex;
		[Export ("removeAt:")]
		bool RemoveAt (int nIndex);

		// -(BOOL)insertAt:(int)nStartIndex pNewArray:(FSBasicArray *)pNewArray;
		[Export ("insertAt:pNewArray:")]
		bool InsertAt (int nStartIndex, FSBasicArray pNewArray);

		// -(int)find:(unsigned int)data iStart:(int)iStart;
		[Export ("find:iStart:")]
		int Find (uint data, int iStart);

		// -(int)find:(unsigned int)data;
		[Export ("find:")]
		int Find (uint data);

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

		// -(BOOL)isEmpty;
		[Export ("isEmpty")]
		//[Verify (MethodToProperty)]
		bool IsEmpty { get; }

		// -(void)normalize;
		[Export ("normalize")]
		void Normalize ();

		// -(void)intersect:(FSRectI *)src;
		[Export ("intersect:")]
		void Intersect (FSRectI src);

		// -(void)intersect:(int)left1 top1:(int)top1 right1:(int)right1 bottom1:(int)bottom1;
		[Export ("intersect:top1:right1:bottom1:")]
		void Intersect (int left1, int top1, int right1, int bottom1);

		// -(void)union:(FSRectI *)other_rect;
		[Export ("union:")]
		void Union (FSRectI other_rect);

		// -(void)offset:(int)dx dy:(int)dy;
		[Export ("offset:dy:")]
		void Offset (int dx, int dy);

		// -(BOOL)contains:(FSRectI *)other_rect;
		[Export ("contains:")]
		bool Contains (FSRectI other_rect);

		// -(BOOL)contains:(int)x y:(int)y;
		[Export ("contains:y:")]
		bool Contains (int x, int y);

		// -(BOOL)valid;
		[Export ("valid")]
		//[Verify (MethodToProperty)]
		bool Valid { get; }

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

		// -(id)initWithRect:(FSRectI *)rect;
		[Export ("initWithRect:")]
		IntPtr Constructor (FSRectI rect);

		// -(BOOL)isEmpty;
		[Export ("isEmpty")]
		//[Verify (MethodToProperty)]
		bool IsEmpty { get; }

		// -(void)normalize;
		[Export ("normalize")]
		void Normalize ();

		// -(void)reset;
		[Export ("reset")]
		void Reset ();

		// -(BOOL)contains:(FSRectF *)other_rect;
		[Export ("contains:")]
		bool Contains (FSRectF other_rect);

		// -(BOOL)contains:(float)x y:(float)y;
		[Export ("contains:y:")]
		bool Contains (float x, float y);

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

		// -(void)inflate:(float)left bottom:(float)bottom right:(float)right top:(float)top;
		[Export ("inflate:bottom:right:top:")]
		void Inflate (float left, float bottom, float right, float top);

		// -(void)inflate:(FSRectF *)rt;
		[Export ("inflate:")]
		void Inflate (FSRectF rt);

		// -(void)deflate:(float)x y:(float)y;
		[Export ("deflate:y:")]
		void Deflate (float x, float y);

		// -(void)deflate:(float)left bottom:(float)bottom right:(float)right top:(float)top;
		[Export ("deflate:bottom:right:top:")]
		void Deflate (float left, float bottom, float right, float top);

		// -(void)deflate:(FSRectF *)rt;
		[Export ("deflate:")]
		void Deflate (FSRectF rt);

		// -(void)translate:(float)e f:(float)f;
		[Export ("translate:f:")]
		void Translate (float e, float f);

		// +(FSRectF *)getBBox:(FSPointF *)pPoints nPoints:(int)nPoints;
		[Static]
		[Export ("getBBox:nPoints:")]
		FSRectF GetBBox (FSPointF pPoints, int nPoints);

		// +(BOOL)IsRectAdjacent:(FSRectF *)rect1 rect2:(FSRectF *)rect2 alignmentTolerance:(float)alignmentTolerance distanceTolerance:(float)distanceTolerance direction:(int)direction;
		[Static]
		[Export ("IsRectAdjacent:rect2:alignmentTolerance:distanceTolerance:direction:")]
		bool IsRectAdjacent (FSRectF rect1, FSRectF rect2, float alignmentTolerance, float distanceTolerance, int direction);

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

		// -(void)set:(NSArray<NSNumber *> *)n;
		[Export ("set:")]
		void Set (NSNumber[] n);

		// -(void)setIdentity;
		[Export ("setIdentity")]
		void SetIdentity ();

		// -(void)setReverse:(FSMatrix2D *)m;
		[Export ("setReverse:")]
		void SetReverse (FSMatrix2D m);

		// -(void)concat:(float)a b:(float)b c:(float)c d:(float)d e:(float)e f:(float)f bPrepended:(BOOL)bPrepended;
		[Export ("concat:b:c:d:e:f:bPrepended:")]
		void Concat (float a, float b, float c, float d, float e, float f, bool bPrepended);

		// -(void)concat:(float)a b:(float)b c:(float)c d:(float)d e:(float)e f:(float)f;
		[Export ("concat:b:c:d:e:f:")]
		void Concat (float a, float b, float c, float d, float e, float f);

		// -(void)concat:(FSMatrix2D *)m bPrepended:(BOOL)bPrepended;
		[Export ("concat:bPrepended:")]
		void Concat (FSMatrix2D m, bool bPrepended);

		// -(void)concat:(FSMatrix2D *)m;
		[Export ("concat:")]
		void Concat (FSMatrix2D m);

		// -(void)concatInverse:(FSMatrix2D *)m bPrepended:(BOOL)bPrepended;
		[Export ("concatInverse:bPrepended:")]
		void ConcatInverse (FSMatrix2D m, bool bPrepended);

		// -(void)concatInverse:(FSMatrix2D *)m;
		[Export ("concatInverse:")]
		void ConcatInverse (FSMatrix2D m);

		// -(void)reset;
		[Export ("reset")]
		void Reset ();

		// -(void)copy:(FSMatrix2D *)m;
		[Export ("copy:")]
		void Copy (FSMatrix2D m);

		// -(BOOL)isIdentity;
		[Export ("isIdentity")]
		//[Verify (MethodToProperty)]
		bool IsIdentity { get; }

		// -(BOOL)isInvertible;
		[Export ("isInvertible")]
		//[Verify (MethodToProperty)]
		bool IsInvertible { get; }

		// -(BOOL)is90Rotated;
		[Export ("is90Rotated")]
		//[Verify (MethodToProperty)]
		bool Is90Rotated { get; }

		// -(BOOL)isScaled;
		[Export ("isScaled")]
		//[Verify (MethodToProperty)]
		bool IsScaled { get; }

		// -(void)translate:(float)x y:(float)y bPrepended:(BOOL)bPrepended;
		[Export ("translate:y:bPrepended:")]
		void Translate (float x, float y, bool bPrepended);

		// -(void)translate:(float)x y:(float)y;
		[Export ("translate:y:")]
		void Translate (float x, float y);

		// -(void)translateI:(int)x y:(int)y bPrepended:(BOOL)bPrepended;
		[Export ("translateI:y:bPrepended:")]
		void TranslateI (int x, int y, bool bPrepended);

		// -(void)translateI:(int)x y:(int)y;
		[Export ("translateI:y:")]
		void TranslateI (int x, int y);

		// -(void)scale:(float)sx sy:(float)sy bPrepended:(BOOL)bPrepended;
		[Export ("scale:sy:bPrepended:")]
		void Scale (float sx, float sy, bool bPrepended);

		// -(void)scale:(float)sx sy:(float)sy;
		[Export ("scale:sy:")]
		void Scale (float sx, float sy);

		// -(void)rotate:(float)fRadian bPrepended:(BOOL)bPrepended;
		[Export ("rotate:bPrepended:")]
		void Rotate (float fRadian, bool bPrepended);

		// -(void)rotate:(float)fRadian;
		[Export ("rotate:")]
		void Rotate (float fRadian);

		// -(void)rotateAt:(float)fRadian x:(float)x y:(float)y bPrepended:(BOOL)bPrepended;
		[Export ("rotateAt:x:y:bPrepended:")]
		void RotateAt (float fRadian, float x, float y, bool bPrepended);

		// -(void)rotateAt:(float)fRadian x:(float)x y:(float)y;
		[Export ("rotateAt:x:y:")]
		void RotateAt (float fRadian, float x, float y);

		// -(void)shear:(float)fAlphaRadian fBetaRadian:(float)fBetaRadian bPrepended:(BOOL)bPrepended;
		[Export ("shear:fBetaRadian:bPrepended:")]
		void Shear (float fAlphaRadian, float fBetaRadian, bool bPrepended);

		// -(void)shear:(float)fAlphaRadian fBetaRadian:(float)fBetaRadian;
		[Export ("shear:fBetaRadian:")]
		void Shear (float fAlphaRadian, float fBetaRadian);

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

		// -(float)transformDistance:(float)distance;
		[Export ("transformDistance:")]
		float TransformDistance (float distance);

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

		// -(id)initWithOther:(FSProgressive *)other;
		[Export ("initWithOther:")]
		IntPtr Constructor (FSProgressive other);

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

	// @interface FSRenderConfig : NSObject
	[BaseType (typeof(NSObject))]
	interface FSRenderConfig
	{
		// @property (getter = getGraphics_objs_count_in_one_step, nonatomic) int graphics_objs_count_in_one_step;
		[Export ("graphics_objs_count_in_one_step")]
		int Graphics_objs_count_in_one_step { [Bind ("getGraphics_objs_count_in_one_step")] get; set; }

		// -(void *)getCptr;
		[Export ("getCptr")]
		//[Verify (MethodToProperty)]
		IntPtr Cptr { get; }

		// -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
		[Export ("initWithCptr:swigOwnCObject:")]
		IntPtr Constructor (IntPtr cptr, bool ownCObject);

		// -(id)initWithGraphics_objs_count_in_one_step:(int)graphics_objs_count_in_one_step;
		[Export ("initWithGraphics_objs_count_in_one_step:")]
		IntPtr Constructor (int graphics_objs_count_in_one_step);

		// -(void)set:(int)graphics_objs_count_in_one_step;
		[Export ("set:")]
		void Set (int graphics_objs_count_in_one_step);

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

		// +(BOOL)hasModuleLicenseRight:(FSModuleName)module_name;
		[Static]
		[Export ("hasModuleLicenseRight:")]
		bool HasModuleLicenseRight (FSModuleName module_name);

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
		bool SetAnnotIconProviderCallback (NSObject annot_icon_provider);

		// +(BOOL)setNotifierCallback:(id<FSNotifierCallback>)notifier;
		[Static]
		[Export ("setNotifierCallback:")]
		bool SetNotifierCallback (NSObject notifier);

		// +(BOOL)setActionCallback:(id<FSActionCallback>)action_callback;
		[Static]
		[Export ("setActionCallback:")]
		bool SetActionCallback (NSObject action_callback);

		// +(BOOL)setDocEventCallback:(id<FSDocEventCallback>)callback;
		[Static]
		[Export ("setDocEventCallback:")]
		bool SetDocEventCallback (NSObject callback);

		// +(BOOL)registerSignatureCallback:(NSString *)filter sub_filter:(NSString *)sub_filter signature_callback:(id<FSSignatureCallback>)signature_callback;
		[Static]
		[Export ("registerSignatureCallback:sub_filter:signature_callback:")]
		bool RegisterSignatureCallback (string filter, string sub_filter, NSObject signature_callback);

		// +(BOOL)registerSecurityCallback:(NSString *)filter callback:(id<FSSecurityCallback>)callback;
		[Static]
		[Export ("registerSecurityCallback:callback:")]
		bool RegisterSecurityCallback (string filter, NSObject callback);

		// +(BOOL)unregisterSecurityCallback:(NSString *)filter;
		[Static]
		[Export ("unregisterSecurityCallback:")]
		bool UnregisterSecurityCallback (string filter);

		// +(BOOL)setTimeStampCallback:(id<FSTimeStampCallback>)timestamp_callback;
		[Static]
		[Export ("setTimeStampCallback:")]
		bool SetTimeStampCallback (NSObject timestamp_callback);

		// +(BOOL)isFipsMode;
		[Static]
		[Export ("isFipsMode")]
		//[Verify (MethodToProperty)]
		bool IsFipsMode { get; }

		// +(void)registerXFAAppProviderCallback:(id<FSAppProviderCallback>)callback;
		[Static]
		[Export ("registerXFAAppProviderCallback:")]
		void RegisterXFAAppProviderCallback (NSObject callback);

		// +(void)setRenderTextGamma:(float)gamma;
		[Static]
		[Export ("setRenderTextGamma:")]
		void SetRenderTextGamma (float gamma);

		// +(void)setLogFile:(NSString *)log_file_path;
		[Static]
		[Export ("setLogFile:")]
		void SetLogFile (string log_file_path);

		// +(BOOL)setFontMapperCallback:(id<FSFontMapperCallback>)callback;
		[Static]
		[Export ("setFontMapperCallback:")]
		bool SetFontMapperCallback (NSObject callback);

		// +(void)setDefaultICCProfilesPath:(NSString *)icc_profile_folder_path;
		[Static]
		[Export ("setDefaultICCProfilesPath:")]
		void SetDefaultICCProfilesPath (string icc_profile_folder_path);

		// +(FSRenderConfig *)getRenderConfig;
		[Static]
		[Export ("getRenderConfig")]
		//[Verify (MethodToProperty)]
		FSRenderConfig RenderConfig { get; }

		// +(void)setRenderConfig:(FSRenderConfig *)render_config;
		[Static]
		[Export ("setRenderConfig:")]
		void SetRenderConfig (FSRenderConfig render_config);

		// +(void)enableThreadSafety:(BOOL)is_enable_thread_safety;
		[Static]
		[Export ("enableThreadSafety:")]
		void EnableThreadSafety (bool is_enable_thread_safety);

		// +(NSString *)executeJavaScript:(NSString *)java_script;
		[Static]
		[Export ("executeJavaScript:")]
		string ExecuteJavaScript (string java_script);

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

		// @property (getter = getDashes, copy, nonatomic) FSFloatArray * dashes;
		[Export ("dashes", ArgumentSemantic.Copy)]
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

		// -(id)initWithOther:(FSRange *)other;
		[Export ("initWithOther:")]
		IntPtr Constructor (FSRange other);

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

		// -(void)addSegment:(int)start_index end_index:(int)end_index;
		[Export ("addSegment:end_index:")]
		void AddSegment (int start_index, int end_index);

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

		// -(id)initWithOther:(FSFont *)other;
		[Export ("initWithOther:")]
		IntPtr Constructor (FSFont other);

		// -(BOOL)isEmpty;
		[Export ("isEmpty")]
		//[Verify (MethodToProperty)]
		bool IsEmpty { get; }

		// -(NSString *)getName;
		[Export ("getName")]
		//[Verify (MethodToProperty)]
		string Name { get; }

		// -(NSString *)getFamilyName;
		[Export ("getFamilyName")]
		//[Verify (MethodToProperty)]
		string FamilyName { get; }

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

		// -(FSFont *)embed:(FSPDFDoc *)document is_add_all_unicodes:(BOOL)is_add_all_unicodes;
		[Export ("embed:is_add_all_unicodes:")]
		FSFont Embed (FSPDFDoc document, bool is_add_all_unicodes);

		// -(FSFont *)embed:(FSPDFDoc *)document;
		[Export ("embed:")]
		FSFont Embed (FSPDFDoc document);

		// -(FSUInt32Array *)addUnicodes:(FSPDFDoc *)document unicode_array:(FSUInt32Array *)unicode_array;
		[Export ("addUnicodes:unicode_array:")]
		FSUInt32Array AddUnicodes (FSPDFDoc document, FSUInt32Array unicode_array);

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

		// -(FSRectI *)getCharBBoxWithDoc:(unsigned int)unicode document:(FSPDFDoc *)document;
		[Export ("getCharBBoxWithDoc:document:")]
		FSRectI GetCharBBoxWithDoc (uint unicode, FSPDFDoc document);

		// -(float)getCharWidthWithDoc:(unsigned int)unicode document:(FSPDFDoc *)document;
		[Export ("getCharWidthWithDoc:document:")]
		float GetCharWidthWithDoc (uint unicode, FSPDFDoc document);

		// -(unsigned int)getStyles:(FSPDFDoc *)document;
		[Export ("getStyles:")]
		uint GetStyles (FSPDFDoc document);

		// -(FSFontCIDCharset)getCIDCharset:(FSPDFDoc *)document;
		[Export ("getCIDCharset:")]
		FSFontCIDCharset GetCIDCharset (FSPDFDoc document);

		// -(BOOL)isStandardFont:(FSPDFDoc *)document;
		[Export ("isStandardFont:")]
		bool IsStandardFont (FSPDFDoc document);

		// -(FSFontStandardID)getStandard14Font:(FSPDFDoc *)document;
		[Export ("getStandard14Font:")]
		FSFontStandardID GetStandard14Font (FSPDFDoc document);

		// -(FSFontFontTypes)getFontType:(FSPDFDoc *)document;
		[Export ("getFontType:")]
		FSFontFontTypes GetFontType (FSPDFDoc document);

		// -(NSString *)getBaseFontName:(FSPDFDoc *)document;
		[Export ("getBaseFontName:")]
		string GetBaseFontName (FSPDFDoc document);

		// -(BOOL)isVertWriting:(FSPDFDoc *)document;
		[Export ("isVertWriting:")]
		bool IsVertWriting (FSPDFDoc document);

		// -(NSString *)getEncoding:(FSPDFDoc *)document;
		[Export ("getEncoding:")]
		string GetEncoding (FSPDFDoc document);

		// -(BOOL)setEncoding:(FSPDFDoc *)document value:(NSString *)value;
		[Export ("setEncoding:value:")]
		bool SetEncoding (FSPDFDoc document, string value);

		// -(void)dealloc;
		[Export ("dealloc")]
		void Dealloc ();
	}

	// @interface FSFontMapResult : NSObject
	[BaseType (typeof(NSObject))]
	interface FSFontMapResult
	{
		// @property (getter = getFile_read, nonatomic) id<FSFileReaderCallback> file_read;
		[Export ("file_read", ArgumentSemantic.Assign)]
		NSObject File_read { [Bind ("getFile_read")] get; set; }

		// @property (getter = getFace_index, nonatomic) int face_index;
		[Export ("face_index")]
		int Face_index { [Bind ("getFace_index")] get; set; }

		// -(void *)getCptr;
		[Export ("getCptr")]
		//[Verify (MethodToProperty)]
		IntPtr Cptr { get; }

		// -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
		[Export ("initWithCptr:swigOwnCObject:")]
		IntPtr Constructor (IntPtr cptr, bool ownCObject);

		// -(id)initWithFile_read:(id<FSFileReaderCallback>)file_read face_index:(int)face_index;
		[Export ("initWithFile_read:face_index:")]
		IntPtr Constructor (NSObject file_read, int face_index);

		// -(id)initWithOther:(FSFontMapResult *)other;
		[Export ("initWithOther:")]
		IntPtr Constructor (FSFontMapResult other);

		// -(void)set:(id<FSFileReaderCallback>)file_read face_index:(int)face_index;
		[Export ("set:face_index:")]
		void Set (NSObject file_read, int face_index);

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

		// -(void)increasePointCount:(int)count;
		[Export ("increasePointCount:")]
		void IncreasePointCount (int count);

		// -(void)dealloc;
		[Export ("dealloc")]
		void Dealloc ();
	}

	// @interface FSPathArray : NSObject
	[BaseType (typeof(NSObject))]
	interface FSPathArray
	{
		// -(void *)getCptr;
		[Export ("getCptr")]
		//[Verify (MethodToProperty)]
		IntPtr Cptr { get; }

		// -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
		[Export ("initWithCptr:swigOwnCObject:")]
		IntPtr Constructor (IntPtr cptr, bool ownCObject);

		// -(id)initWithOther:(FSPathArray *)other;
		[Export ("initWithOther:")]
		IntPtr Constructor (FSPathArray other);

		// -(unsigned long)getSize;
		[Export ("getSize")]
		//[Verify (MethodToProperty)]
		nuint Size { get; }

		// -(FSPath *)getAt:(unsigned long)index;
		[Export ("getAt:")]
		FSPath GetAt (nuint index);

		// -(void)add:(FSPath *)element;
		[Export ("add:")]
		void Add (FSPath element);

		// -(void)removeAt:(unsigned long)index;
		[Export ("removeAt:")]
		void RemoveAt (nuint index);

		// -(void)insertAt:(unsigned long)index element:(FSPath *)element;
		[Export ("insertAt:element:")]
		void InsertAt (nuint index, FSPath element);

		// -(void)removeAll;
		[Export ("removeAll")]
		void RemoveAll ();

		// -(void)dealloc;
		[Export ("dealloc")]
		void Dealloc ();
	}

	// @interface FSColorSpace : FSBase
	[BaseType (typeof(FSBase))]
	[DisableDefaultCtor]
	interface FSColorSpace
	{
		// -(void *)getCptr;
		[Export ("getCptr")]
		//[Verify (MethodToProperty)]
		IntPtr Cptr { get; }

		// -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
		[Export ("initWithCptr:swigOwnCObject:")]
		IntPtr Constructor (IntPtr cptr, bool ownCObject);

		// -(id)initWithType:(FSColorSpaceType)type;
		[Export ("initWithType:")]
		IntPtr Constructor (FSColorSpaceType type);

		// -(id)initWithOther:(FSColorSpace *)other;
		[Export ("initWithOther:")]
		IntPtr Constructor (FSColorSpace other);

		// -(BOOL)isEmpty;
		[Export ("isEmpty")]
		//[Verify (MethodToProperty)]
		bool IsEmpty { get; }

		// -(int)getComponentCount;
		[Export ("getComponentCount")]
		//[Verify (MethodToProperty)]
		int ComponentCount { get; }

		// -(FSColorSpaceType)getColorSpaceType;
		[Export ("getColorSpaceType")]
		//[Verify (MethodToProperty)]
		FSColorSpaceType ColorSpaceType { get; }

		// -(BOOL)isSpotColorSpace;
		[Export ("isSpotColorSpace")]
		//[Verify (MethodToProperty)]
		bool IsSpotColorSpace { get; }

		// -(NSArray<NSData *> *)getComponentNames;
		[Export ("getComponentNames")]
		//[Verify (MethodToProperty)]
		NSData[] ComponentNames { get; }

		// -(FSColor *)convertColor:(FSColor *)color;
		[Export ("convertColor:")]
		FSColor ConvertColor (FSColor color);

		// -(FSColor *)convertColorRGB:(int)r_value g_value:(int)g_value b_value:(int)b_value;
		[Export ("convertColorRGB:g_value:b_value:")]
		FSColor ConvertColorRGB (int r_value, int g_value, int b_value);

		// -(FSColor *)convertColorCMYK:(int)c_value m_value:(int)m_value y_value:(int)y_value k_value:(int)k_value;
		[Export ("convertColorCMYK:m_value:y_value:k_value:")]
		FSColor ConvertColorCMYK (int c_value, int m_value, int y_value, int k_value);

		// -(void)dealloc;
		[Export ("dealloc")]
		void Dealloc ();
	}

	// @interface FSColor : FSBase
	[BaseType (typeof(FSBase))]
	interface FSColor
	{
		// @property (getter = getValue, copy, nonatomic) FSFloatArray * value;
		[Export ("value", ArgumentSemantic.Copy)]
		FSFloatArray Value { [Bind ("getValue")] get; set; }

		// -(void *)getCptr;
		[Export ("getCptr")]
		//[Verify (MethodToProperty)]
		IntPtr Cptr { get; }

		// -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
		[Export ("initWithCptr:swigOwnCObject:")]
		IntPtr Constructor (IntPtr cptr, bool ownCObject);

		// -(id)initWithColor_space:(FSColorSpace *)color_space;
		[Export ("initWithColor_space:")]
		IntPtr Constructor (FSColorSpace color_space);

		// -(id)initWithOther:(FSColor *)other;
		[Export ("initWithOther:")]
		IntPtr Constructor (FSColor other);

		// -(BOOL)isEmpty;
		[Export ("isEmpty")]
		//[Verify (MethodToProperty)]
		bool IsEmpty { get; }

		// -(FSColorSpace *)getColorSpace;
		[Export ("getColorSpace")]
		//[Verify (MethodToProperty)]
		FSColorSpace ColorSpace { get; }

		// -(FSColor *)convertToRGB:(FSColorSpaceRenderingIntent)intent;
		[Export ("convertToRGB:")]
		FSColor ConvertToRGB (FSColorSpaceRenderingIntent intent);

		// -(FSColor *)convertToRGB;
		[Export ("convertToRGB")]
		//[Verify (MethodToProperty)]
		FSColor ConvertToRGB ();

		// -(FSColor *)convertToCMYK:(FSColorSpaceRenderingIntent)intent;
		[Export ("convertToCMYK:")]
		FSColor ConvertToCMYK (FSColorSpaceRenderingIntent intent);

		// -(FSColor *)convertToCMYK;
		[Export ("convertToCMYK")]
		//[Verify (MethodToProperty)]
		FSColor ConvertToCMYK ();

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

		// -(id)initWithWidth:(int)width height:(int)height format:(FSBitmapDIBFormat)format buffer:(NSData *)buffer;
		[Export ("initWithWidth:height:format:buffer:")]
		IntPtr Constructor (int width, int height, FSBitmapDIBFormat format, NSData buffer);

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

		// -(FSBitmap *)clone;
		[Export ("clone")]
		//[Verify (MethodToProperty)]
		FSBitmap Clone ();

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

		// -(void)fillRect:(unsigned int)color;
		[Export ("fillRect:")]
		void FillRect (uint color);

		// -(FSBitmap *)convertFormat:(FSBitmapDIBFormat)format icc_transform:(NSData *)icc_transform;
		[Export ("convertFormat:icc_transform:")]
		FSBitmap ConvertFormat (FSBitmapDIBFormat format, NSData icc_transform);

		// -(FSBitmap *)convertFormat:(FSBitmapDIBFormat)format;
		[Export ("convertFormat:")]
		FSBitmap ConvertFormat (FSBitmapDIBFormat format);

		// -(FSRectI *)calculateBBoxByColor:(unsigned int)backgroud_color;
		[Export ("calculateBBoxByColor:")]
		FSRectI CalculateBBoxByColor (uint backgroud_color);

		// -(FSRectI *)detectBBoxByColorDiffer:(int)detection_size color_differ:(int)color_differ;
		[Export ("detectBBoxByColorDiffer:color_differ:")]
		FSRectI DetectBBoxByColorDiffer (int detection_size, int color_differ);

		// -(FSRectI *)detectBBoxByColorDiffer:(int)detection_size;
		[Export ("detectBBoxByColorDiffer:")]
		FSRectI DetectBBoxByColorDiffer (int detection_size);

		// -(FSBitmap *)swapXY:(BOOL)is_flip_horz is_flip_vert:(BOOL)is_flip_vert clip_rect:(FSRectI *)clip_rect;
		[Export ("swapXY:is_flip_vert:clip_rect:")]
		FSBitmap SwapXY (bool is_flip_horz, bool is_flip_vert, FSRectI clip_rect);

		// -(FSBitmap *)swapXY:(BOOL)is_flip_horz is_flip_vert:(BOOL)is_flip_vert;
		[Export ("swapXY:is_flip_vert:")]
		FSBitmap SwapXY (bool is_flip_horz, bool is_flip_vert);

		// -(FSBitmap *)flip:(BOOL)is_flip_horz is_flip_vert:(BOOL)is_flip_vert;
		[Export ("flip:is_flip_vert:")]
		FSBitmap Flip (bool is_flip_horz, bool is_flip_vert);

		// -(FSBitmap *)stretchTo:(int)dest_width dest_height:(int)dest_height flag:(FSBitmapInterpolationFlag)flag clip_rect:(FSRectI *)clip_rect;
		[Export ("stretchTo:dest_height:flag:clip_rect:")]
		FSBitmap StretchTo (int dest_width, int dest_height, FSBitmapInterpolationFlag flag, FSRectI clip_rect);

		// -(FSBitmap *)stretchTo:(int)dest_width dest_height:(int)dest_height flag:(FSBitmapInterpolationFlag)flag;
		[Export ("stretchTo:dest_height:flag:")]
		FSBitmap StretchTo (int dest_width, int dest_height, FSBitmapInterpolationFlag flag);

		// -(FSBitmap *)transformTo:(FSMatrix2D *)matrix flag:(FSBitmapInterpolationFlag)flag out_left:(int *)out_left out_top:(int *)out_top clip_rect:(FSRectI *)clip_rect;
		[Export ("transformTo:flag:out_left:out_top:clip_rect:")]
		unsafe FSBitmap TransformTo (FSMatrix2D matrix, FSBitmapInterpolationFlag flag, int out_left, int out_top, FSRectI clip_rect);

		// -(FSBitmap *)transformTo:(FSMatrix2D *)matrix flag:(FSBitmapInterpolationFlag)flag out_left:(int *)out_left out_top:(int *)out_top;
		[Export ("transformTo:flag:out_left:out_top:")]
		unsafe FSBitmap TransformTo (FSMatrix2D matrix, FSBitmapInterpolationFlag flag, int out_left, int out_top);

		// -(FSBitmap *)getMask:(FSRectI *)clip_rect;
		[Export ("getMask:")]
		FSBitmap GetMask (FSRectI clip_rect);

		// -(FSBitmap *)getMask;
		[Export ("getMask")]
		//[Verify (MethodToProperty)]
		FSBitmap Mask { get; }

		// -(FSBitmap *)fadeOutBackground:(FSBitmapFadeOutEnhancementAlgorithm)enchancement_algorithms threshold_algorithms:(FSBitmapFadeOutThresholdAlogrithm)threshold_algorithms threshold_level:(float)threshold_level;
		[Export ("fadeOutBackground:threshold_algorithms:threshold_level:")]
		FSBitmap FadeOutBackground (FSBitmapFadeOutEnhancementAlgorithm enchancement_algorithms, FSBitmapFadeOutThresholdAlogrithm threshold_algorithms, float threshold_level);

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
		IntPtr Constructor (NSObject file_read);

		// -(id)initWithOther:(FSImage *)other;
		[Export ("initWithOther:")]
		IntPtr Constructor (FSImage other);

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

		// -(BOOL)saveAs:(id<FSStreamCallback>)file file_extension:(NSString *)file_extension;
		[Export ("saveAs:file_extension:")]
		bool SaveAs (NSObject file, string file_extension);

		// -(FSImageOrientation)getOrientation;
		[Export ("getOrientation")]
		//[Verify (MethodToProperty)]
		FSImageOrientation Orientation { get; }

		// -(id)initWithBuffer:(NSData *)buffer;
		[Export ("initWithBuffer:")]
		IntPtr Constructor (NSData buffer);

		// -(void)dealloc;
		[Export ("dealloc")]
		void Dealloc ();
	}

	// @interface FSPrintDeviceSettingData : NSObject
	[BaseType (typeof(NSObject))]
	interface FSPrintDeviceSettingData
	{
		// @property (getter = getDevice_width, nonatomic) int device_width;
		[Export ("device_width")]
		int Device_width { [Bind ("getDevice_width")] get; set; }

		// @property (getter = getDevice_height, nonatomic) int device_height;
		[Export ("device_height")]
		int Device_height { [Bind ("getDevice_height")] get; set; }

		// @property (getter = getDevice_margin, copy, nonatomic) FSRectF * device_margin;
		[Export ("device_margin", ArgumentSemantic.Copy)]
		FSRectF Device_margin { [Bind ("getDevice_margin")] get; set; }

		// @property (getter = getOrientation, nonatomic) FSPrintDeviceSettingDataOrientationFlag orientation;
		[Export ("orientation", ArgumentSemantic.Assign)]
		FSPrintDeviceSettingDataOrientationFlag Orientation { [Bind ("getOrientation")] get; set; }

		// @property (getter = getResolution, nonatomic) int resolution;
		[Export ("resolution")]
		int Resolution { [Bind ("getResolution")] get; set; }

		// @property (getter = getCopies, nonatomic) unsigned int copies;
		[Export ("copies")]
		uint Copies { [Bind ("getCopies")] get; set; }

		// -(void *)getCptr;
		[Export ("getCptr")]
		//[Verify (MethodToProperty)]
		IntPtr Cptr { get; }

		// -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
		[Export ("initWithCptr:swigOwnCObject:")]
		IntPtr Constructor (IntPtr cptr, bool ownCObject);

		// -(id)initWithDevice_width:(int)device_width device_height:(int)device_height device_margin:(FSRectF *)device_margin orientation:(FSPrintDeviceSettingDataOrientationFlag)orientation resolution:(int)resolution copies:(unsigned int)copies;
		[Export ("initWithDevice_width:device_height:device_margin:orientation:resolution:copies:")]
		IntPtr Constructor (int device_width, int device_height, FSRectF device_margin, FSPrintDeviceSettingDataOrientationFlag orientation, int resolution, uint copies);

		// -(id)initWithSettings:(FSPrintDeviceSettingData *)settings;
		[Export ("initWithSettings:")]
		IntPtr Constructor (FSPrintDeviceSettingData settings);

		// -(void)set:(int)device_width device_height:(int)device_height device_margin:(FSRectF *)device_margin orientation:(FSPrintDeviceSettingDataOrientationFlag)orientation resolution:(int)resolution copies:(unsigned int)copies;
		[Export ("set:device_height:device_margin:orientation:resolution:copies:")]
		void Set (int device_width, int device_height, FSRectF device_margin, FSPrintDeviceSettingDataOrientationFlag orientation, int resolution, uint copies);

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

		// -(id)initWithPrint_param:(FSPrintDeviceSettingData *)print_param dest_file_path:(NSString *)dest_file_path;
		[Export ("initWithPrint_param:dest_file_path:")]
		IntPtr Constructor (FSPrintDeviceSettingData print_param, string dest_file_path);

		// -(id)initWithContext:(CGContextRef)context device_type:(FSRendererDeviceType)device_type;
		[Export ("initWithContext:device_type:")]
		IntPtr Constructor (CGContext context, FSRendererDeviceType device_type);

		// -(id)initWithOther:(FSRenderer *)other;
		[Export ("initWithOther:")]
		IntPtr Constructor (FSRenderer other);

		// -(BOOL)isEmpty;
		[Export ("isEmpty")]
		//[Verify (MethodToProperty)]
		bool IsEmpty { get; }

		// -(FSProgressive *)startQuickRender:(FSPDFPage *)page matrix:(FSMatrix2D *)matrix pause:(id<FSPauseCallback>)pause;
		[Export ("startQuickRender:matrix:pause:")]
		FSProgressive StartQuickRender (FSPDFPage page, FSMatrix2D matrix, NSObject pause);

		// -(FSProgressive *)startQuickRender:(FSPDFPage *)page matrix:(FSMatrix2D *)matrix;
		[Export ("startQuickRender:matrix:")]
		FSProgressive StartQuickRender (FSPDFPage page, FSMatrix2D matrix);

		// -(FSProgressive *)startRender:(FSPDFPage *)page matrix:(FSMatrix2D *)matrix pause:(id<FSPauseCallback>)pause;
		[Export ("startRender:matrix:pause:")]
		FSProgressive StartRender (FSPDFPage page, FSMatrix2D matrix, NSObject pause);

		// -(FSProgressive *)startRender:(FSPDFPage *)page matrix:(FSMatrix2D *)matrix;
		[Export ("startRender:matrix:")]
		FSProgressive StartRender (FSPDFPage page, FSMatrix2D matrix);

		// -(FSProgressive *)startRenderReflowPage:(FSReflowPage *)reflow_page matrix:(FSMatrix2D *)matrix pause:(id<FSPauseCallback>)pause;
		[Export ("startRenderReflowPage:matrix:pause:")]
		FSProgressive StartRenderReflowPage (FSReflowPage reflow_page, FSMatrix2D matrix, NSObject pause);

		// -(FSProgressive *)startRenderReflowPage:(FSReflowPage *)reflow_page matrix:(FSMatrix2D *)matrix;
		[Export ("startRenderReflowPage:matrix:")]
		FSProgressive StartRenderReflowPage (FSReflowPage reflow_page, FSMatrix2D matrix);

		// -(FSProgressive *)startRenderXFAPage:(FSXFAPage *)xfa_page_view matrix:(FSMatrix2D *)matrix is_highlight:(BOOL)is_highlight pause:(id<FSPauseCallback>)pause;
		[Export ("startRenderXFAPage:matrix:is_highlight:pause:")]
		FSProgressive StartRenderXFAPage (FSXFAPage xfa_page_view, FSMatrix2D matrix, bool is_highlight, NSObject pause);

		// -(FSProgressive *)startRenderXFAPage:(FSXFAPage *)xfa_page_view matrix:(FSMatrix2D *)matrix is_highlight:(BOOL)is_highlight;
		[Export ("startRenderXFAPage:matrix:is_highlight:")]
		FSProgressive StartRenderXFAPage (FSXFAPage xfa_page_view, FSMatrix2D matrix, bool is_highlight);

		// -(FSProgressive *)startRenderBitmap:(FSBitmap *)bitmap matrix:(FSMatrix2D *)matrix clip_rect:(FSRectI *)clip_rect interpolation:(unsigned int)interpolation pause:(id<FSPauseCallback>)pause;
		[Export ("startRenderBitmap:matrix:clip_rect:interpolation:pause:")]
		FSProgressive StartRenderBitmap (FSBitmap bitmap, FSMatrix2D matrix, FSRectI clip_rect, uint interpolation, NSObject pause);

		// -(FSProgressive *)startRenderBitmap:(FSBitmap *)bitmap matrix:(FSMatrix2D *)matrix clip_rect:(FSRectI *)clip_rect interpolation:(unsigned int)interpolation;
		[Export ("startRenderBitmap:matrix:clip_rect:interpolation:")]
		FSProgressive StartRenderBitmap (FSBitmap bitmap, FSMatrix2D matrix, FSRectI clip_rect, uint interpolation);

		// -(FSProgressive *)startRenderBitmap:(FSBitmap *)bitmap matrix:(FSMatrix2D *)matrix clip_rect:(FSRectI *)clip_rect;
		[Export ("startRenderBitmap:matrix:clip_rect:")]
		FSProgressive StartRenderBitmap (FSBitmap bitmap, FSMatrix2D matrix, FSRectI clip_rect);

		// -(FSProgressive *)startRenderBitmap:(FSBitmap *)bitmap matrix:(FSMatrix2D *)matrix;
		[Export ("startRenderBitmap:matrix:")]
		FSProgressive StartRenderBitmap (FSBitmap bitmap, FSMatrix2D matrix);

		// -(void)setRenderAnnotAppearanceType:(FSAnnotAppearanceType)ap_type;
		[Export ("setRenderAnnotAppearanceType:")]
		void SetRenderAnnotAppearanceType (FSAnnotAppearanceType ap_type);

		// -(BOOL)renderAnnot:(FSAnnot *)annot matrix:(FSMatrix2D *)matrix;
		[Export ("renderAnnot:matrix:")]
		bool RenderAnnot (FSAnnot annot, FSMatrix2D matrix);

		// -(BOOL)renderFormControls:(FSPDFPage *)page matrix:(FSMatrix2D *)matrix;
		[Export ("renderFormControls:matrix:")]
		bool RenderFormControls (FSPDFPage page, FSMatrix2D matrix);

		// -(BOOL)renderGraphicsObject:(FSGraphicsObject *)graphics_object page:(FSPDFPage *)page matrix:(FSMatrix2D *)matrix;
		[Export ("renderGraphicsObject:page:matrix:")]
		bool RenderGraphicsObject (FSGraphicsObject graphics_object, FSPDFPage page, FSMatrix2D matrix);

		// -(void)setClipRect:(FSRectI *)clip_rect;
		[Export ("setClipRect:")]
		void SetClipRect (FSRectI clip_rect);

		// -(void)setClipPathFill:(FSPath *)clip_path matrix:(FSMatrix2D *)matrix fill_mode:(FSFillMode)fill_mode;
		[Export ("setClipPathFill:matrix:fill_mode:")]
		void SetClipPathFill (FSPath clip_path, FSMatrix2D matrix, FSFillMode fill_mode);

		// -(void)setClipPathStroke:(FSPath *)clip_path matrix:(FSMatrix2D *)matrix graph_state:(FSGraphState *)graph_state;
		[Export ("setClipPathStroke:matrix:graph_state:")]
		void SetClipPathStroke (FSPath clip_path, FSMatrix2D matrix, FSGraphState graph_state);

		// -(void)setClipPathStroke:(FSPath *)clip_path matrix:(FSMatrix2D *)matrix;
		[Export ("setClipPathStroke:matrix:")]
		void SetClipPathStroke (FSPath clip_path, FSMatrix2D matrix);

		// -(void)setRenderContentFlags:(unsigned int)render_content_flags;
		[Export ("setRenderContentFlags:")]
		void SetRenderContentFlags (uint render_content_flags);

		// -(void)setRenderAnnotsForThumbnail:(BOOL)is_render_annots_for_thumbnail;
		[Export ("setRenderAnnotsForThumbnail:")]
		void SetRenderAnnotsForThumbnail (bool is_render_annots_for_thumbnail);

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

		// -(void)setJPEGDownSample:(BOOL)is_jepg_down_sample;
		[Export ("setJPEGDownSample:")]
		void SetJPEGDownSample (bool is_jepg_down_sample);

		// -(void)setJPXDownSample:(BOOL)is_jpx_down_sample;
		[Export ("setJPXDownSample:")]
		void SetJPXDownSample (bool is_jpx_down_sample);

		// -(void)enableForPrint:(BOOL)is_render_for_print;
		[Export ("enableForPrint:")]
		void EnableForPrint (bool is_render_for_print);

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

		// -(void)setRenderPathFullCovered:(BOOL)is_render_path_full_covered;
		[Export ("setRenderPathFullCovered:")]
		void SetRenderPathFullCovered (bool is_render_path_full_covered);

		// -(void)setRenderImageAntiAliasing:(BOOL)is_render_image_antialiasing;
		[Export ("setRenderImageAntiAliasing:")]
		void SetRenderImageAntiAliasing (bool is_render_image_antialiasing);

		// -(void)setRenderEnhanceThinLines:(BOOL)is_render_enhance_thin_lines;
		[Export ("setRenderEnhanceThinLines:")]
		void SetRenderEnhanceThinLines (bool is_render_enhance_thin_lines);

		// -(void)setRenderSignatureState:(BOOL)is_render_signature_state;
		[Export ("setRenderSignatureState:")]
		void SetRenderSignatureState (bool is_render_signature_state);

		// -(void)drawTextString:(FSPDFDoc *)document text_string:(NSString *)text_string graph_state:(FSGraphState *)graph_state origin_x:(float)origin_x origin_y:(float)origin_y font:(FSFont *)font font_size:(float)font_size matrix:(FSMatrix2D *)matrix fill_color:(unsigned int)fill_color stroke_color:(unsigned int)stroke_color;
		[Export ("drawTextString:text_string:graph_state:origin_x:origin_y:font:font_size:matrix:fill_color:stroke_color:")]
		void DrawTextString (FSPDFDoc document, string text_string, FSGraphState graph_state, float origin_x, float origin_y, FSFont font, float font_size, FSMatrix2D matrix, uint fill_color, uint stroke_color);

		// -(void)drawPath:(FSPath *)path graph_state:(FSGraphState *)graph_state matrix:(FSMatrix2D *)matrix fill_color:(unsigned int)fill_color stroke_color:(unsigned int)stroke_color fill_mode:(FSFillMode)fill_mode blend_mode:(FSGraphicsObjectBlendMode)blend_mode;
		[Export ("drawPath:graph_state:matrix:fill_color:stroke_color:fill_mode:blend_mode:")]
		void DrawPath (FSPath path, FSGraphState graph_state, FSMatrix2D matrix, uint fill_color, uint stroke_color, FSFillMode fill_mode, FSGraphicsObjectBlendMode blend_mode);

		// -(void)drawStrokeRect:(FSMatrix2D *)matrix rect:(FSRectF *)rect color:(unsigned int *)color width:(float)width;
		[Export ("drawStrokeRect:rect:color:width:")]
		unsafe void DrawStrokeRect (FSMatrix2D matrix, FSRectF rect, uint color, float width);

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

		// -(FSBitmap *)generateBitmap:(NSString *)info format:(FSBarcodeFormat)format unit_width:(int)unit_width height:(int)height level:(FSBarcodeQRErrorCorrectionLevel)level;
		[Export ("generateBitmap:format:unit_width:height:level:")]
		FSBitmap GenerateBitmap (string info, FSBarcodeFormat format, int unit_width, int height, FSBarcodeQRErrorCorrectionLevel level);

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

		// -(FSProgressive *)startApply:(id<FSPauseCallback>)pause;
		[Export ("startApply:")]
		FSProgressive StartApply (NSObject pause);

		// -(FSProgressive *)startApply;
		[Export ("startApply")]
		//[Verify (MethodToProperty)]
		FSProgressive StartApply ();

		// -(void)dealloc;
		[Export ("dealloc")]
		void Dealloc ();
	}

	// @interface FSWidgetChoiceOption : NSObject
	[BaseType (typeof(NSObject))]
	interface FSWidgetChoiceOption
	{
		// @property (getter = getOption_label, copy, nonatomic) NSString * option_label;
		[Export ("option_label")]
		string Option_label { [Bind ("getOption_label")] get; set; }

		// @property (getter = getSelected, nonatomic) BOOL selected;
		[Export ("selected")]
		bool Selected { [Bind ("getSelected")] get; set; }

		// -(void *)getCptr;
		[Export ("getCptr")]
		//[Verify (MethodToProperty)]
		IntPtr Cptr { get; }

		// -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
		[Export ("initWithCptr:swigOwnCObject:")]
		IntPtr Constructor (IntPtr cptr, bool ownCObject);

		// -(id)initWithOption_label:(NSString *)option_label selected:(BOOL)selected;
		[Export ("initWithOption_label:selected:")]
		IntPtr Constructor (string option_label, bool selected);

		// -(id)initWithOption:(FSWidgetChoiceOption *)option;
		[Export ("initWithOption:")]
		IntPtr Constructor (FSWidgetChoiceOption option);

		// -(void)set:(NSString *)option_label selected:(BOOL)selected;
		[Export ("set:selected:")]
		void Set (string option_label, bool selected);

		// -(void)dealloc;
		[Export ("dealloc")]
		void Dealloc ();
	}

	// @interface FSWidgetChoiceOptionArray : NSObject
	[BaseType (typeof(NSObject))]
	interface FSWidgetChoiceOptionArray
	{
		// -(void *)getCptr;
		[Export ("getCptr")]
		//[Verify (MethodToProperty)]
		IntPtr Cptr { get; }

		// -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
		[Export ("initWithCptr:swigOwnCObject:")]
		IntPtr Constructor (IntPtr cptr, bool ownCObject);

		// -(id)initWithOther:(FSWidgetChoiceOptionArray *)other;
		[Export ("initWithOther:")]
		IntPtr Constructor (FSWidgetChoiceOptionArray other);

		// -(unsigned long)getSize;
		[Export ("getSize")]
		//[Verify (MethodToProperty)]
		nuint Size { get; }

		// -(FSWidgetChoiceOption *)getAt:(unsigned long)index;
		[Export ("getAt:")]
		FSWidgetChoiceOption GetAt (nuint index);

		// -(void)add:(FSWidgetChoiceOption *)element;
		[Export ("add:")]
		void Add (FSWidgetChoiceOption element);

		// -(void)removeAt:(unsigned long)index;
		[Export ("removeAt:")]
		void RemoveAt (nuint index);

		// -(void)insertAt:(unsigned long)index element:(FSWidgetChoiceOption *)element;
		[Export ("insertAt:element:")]
		void InsertAt (nuint index, FSWidgetChoiceOption element);

		// -(void)removeAll;
		[Export ("removeAll")]
		void RemoveAll ();

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
		IntPtr Constructor (FSPDFDoc document, NSObject xfa_doc_provider_handler);

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
		FSProgressive StartLoad (NSObject pause);

		// -(FSProgressive *)startLoad;
		[Export ("startLoad")]
		//[Verify (MethodToProperty)]
		FSProgressive StartLoad ();

		// -(void)setDocProviderCallback:(id<FSDocProviderCallback>)doc_provider_callback;
		[Export ("setDocProviderCallback:")]
		void SetDocProviderCallback (NSObject doc_provider_callback);

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

		// -(BOOL)importDataWithReader:(id<FSFileReaderCallback>)file_reader;
		[Export ("importDataWithReader:")]
		bool ImportDataWithReader (NSObject file_reader);

		// -(void)resetForm;
		[Export ("resetForm")]
		void ResetForm ();

		// -(void)flattenTo:(NSString *)output_file_path;
		[Export ("flattenTo:")]
		void FlattenTo (string output_file_path);

		// -(void)flattenToWithStreamCallback:(id<FSStreamCallback>)stream;
		[Export ("flattenToWithStreamCallback:")]
		void FlattenToWithStreamCallback (NSObject stream);

		// -(void)processEvent:(FSXFADocEventType)event_type;
		[Export ("processEvent:")]
		void ProcessEvent (FSXFADocEventType event_type);

		// -(void)setFocus:(FSXFAWidget *)xfa_widget;
		[Export ("setFocus:")]
		void SetFocus (FSXFAWidget xfa_widget);

		// -(void)killFocus;
		[Export ("killFocus")]
		void KillFocus ();

		// -(FSXFAWidget *)getWidgetByFullName:(NSString *)full_name;
		[Export ("getWidgetByFullName:")]
		FSXFAWidget GetWidgetByFullName (string full_name);

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

		// -(FSXFAWidget *)getWidgetByFullName:(NSString *)full_name;
		[Export ("getWidgetByFullName:")]
		FSXFAWidget GetWidgetByFullName (string full_name);

		// -(FSXFAWidget *)getFirstWidget;
		[Export ("getFirstWidget")]
		//[Verify (MethodToProperty)]
		FSXFAWidget FirstWidget { get; }

		// -(FSXFAWidget *)getLastWidget;
		[Export ("getLastWidget")]
		//[Verify (MethodToProperty)]
		FSXFAWidget LastWidget { get; }

		// -(FSXFAWidget *)getNextWidget:(FSXFAWidget *)widget;
		[Export ("getNextWidget:")]
		FSXFAWidget GetNextWidget (FSXFAWidget widget);

		// -(FSXFAWidget *)getPrevWidget:(FSXFAWidget *)widget;
		[Export ("getPrevWidget:")]
		FSXFAWidget GetPrevWidget (FSXFAWidget widget);

		// -(void)dealloc;
		[Export ("dealloc")]
		void Dealloc ();
	}

	// @interface FSXFAWidget : FSBase
	[BaseType (typeof(FSBase))]
	[DisableDefaultCtor]
	interface FSXFAWidget
	{
		// @property (getter = getValue, copy, nonatomic) NSString * value;
		[Export ("value")]
		string Value { [Bind ("getValue")] get; set; }

		// @property (getter = getDefaultValue, copy, nonatomic) NSString * defaultValue;
		[Export ("defaultValue")]
		string DefaultValue { [Bind ("getDefaultValue")] get; set; }

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

		// -(NSString *)getName:(FSXFAWidgetWidgetNameType)type;
		[Export ("getName:")]
		string GetName (FSXFAWidgetWidgetNameType type);

		// -(FSWidgetChoiceOptionArray *)getOptions;
		[Export ("getOptions")]
		//[Verify (MethodToProperty)]
		FSWidgetChoiceOptionArray Options { get; }

		// -(BOOL)setOptions:(FSWidgetChoiceOptionArray *)option_array;
		[Export ("setOptions:")]
		bool SetOptions (FSWidgetChoiceOptionArray option_array);

		// -(BOOL)isChecked;
		[Export ("isChecked")]
		//[Verify (MethodToProperty)]
		bool IsChecked { get; }

		// -(void)setCheckState:(BOOL)is_checked;
		[Export ("setCheckState:")]
		void SetCheckState (bool is_checked);

		// -(BOOL)isListBox;
		[Export ("isListBox")]
		//[Verify (MethodToProperty)]
		bool IsListBox { get; }

		// -(BOOL)isSupportMultiline;
		[Export ("isSupportMultiline")]
		//[Verify (MethodToProperty)]
		bool IsSupportMultiline { get; }

		// -(BOOL)isSupportMultiSelect;
		[Export ("isSupportMultiSelect")]
		//[Verify (MethodToProperty)]
		bool IsSupportMultiSelect { get; }

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

		// -(FSXFAWidgetWidgetHAlignType)getHAlign;
		[Export ("getHAlign")]
		//[Verify (MethodToProperty)]
		FSXFAWidgetWidgetHAlignType HAlign { get; }

		// -(FSXFAWidgetWidgetVAlignType)getVAlign;
		[Export ("getVAlign")]
		//[Verify (MethodToProperty)]
		FSXFAWidgetWidgetVAlignType VAlign { get; }

		// -(BOOL)hasEdge:(FSXFAWidgetWidgetEdgePosition)edge_pos;
		[Export ("hasEdge:")]
		bool HasEdge (FSXFAWidgetWidgetEdgePosition edge_pos);

		// -(FSSignature *)getSignature;
		[Export ("getSignature")]
		//[Verify (MethodToProperty)]
		FSSignature Signature { get; }

		// -(NSString *)getToolTip;
		[Export ("getToolTip")]
		//[Verify (MethodToProperty)]
		string ToolTip { get; }

		// -(FSBitmap *)getBitmap;
		[Export ("getBitmap")]
		//[Verify (MethodToProperty)]
		FSBitmap Bitmap { get; }

		// -(void)setImage:(FSImage *)image;
		[Export ("setImage:")]
		void SetImage (FSImage image);

		// -(BOOL)isAllowRichText;
		[Export ("isAllowRichText")]
		//[Verify (MethodToProperty)]
		bool IsAllowRichText { get; }

		// -(BOOL)isReadOnly;
		[Export ("isReadOnly")]
		//[Verify (MethodToProperty)]
		bool IsReadOnly { get; }

		// -(BOOL)isRequired;
		[Export ("isRequired")]
		//[Verify (MethodToProperty)]
		bool IsRequired { get; }

		// -(BOOL)validateValue:(NSString *)value format:(NSString *)format;
		[Export ("validateValue:format:")]
		bool ValidateValue (string value, string format);

		// -(NSString *)getJavaScript;
		[Export ("getJavaScript")]
		//[Verify (MethodToProperty)]
		string JavaScript { get; }

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

	// @interface FSCompareResultInfo : NSObject
	[BaseType (typeof(NSObject))]
	interface FSCompareResultInfo
	{
		// @property (getter = getType, nonatomic) FSCompareResultInfoCompareResultType type;
		[Export ("type", ArgumentSemantic.Assign)]
		FSCompareResultInfoCompareResultType Type { [Bind ("getType")] get; set; }

		// @property (getter = getRect_array, copy, nonatomic) FSRectFArray * rect_array;
		[Export ("rect_array", ArgumentSemantic.Copy)]
		FSRectFArray Rect_array { [Bind ("getRect_array")] get; set; }

		// @property (getter = getDiff_contents, copy, nonatomic) NSString * diff_contents;
		[Export ("diff_contents")]
		string Diff_contents { [Bind ("getDiff_contents")] get; set; }

		// -(void *)getCptr;
		[Export ("getCptr")]
		//[Verify (MethodToProperty)]
		IntPtr Cptr { get; }

		// -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
		[Export ("initWithCptr:swigOwnCObject:")]
		IntPtr Constructor (IntPtr cptr, bool ownCObject);

		// -(id)initWithType:(FSCompareResultInfoCompareResultType)type rect_array:(FSRectFArray *)rect_array diff_contents:(NSString *)diff_contents;
		[Export ("initWithType:rect_array:diff_contents:")]
		IntPtr Constructor (FSCompareResultInfoCompareResultType type, FSRectFArray rect_array, string diff_contents);

		// -(id)initWithResult_info:(FSCompareResultInfo *)result_info;
		[Export ("initWithResult_info:")]
		IntPtr Constructor (FSCompareResultInfo result_info);

		// -(void)dealloc;
		[Export ("dealloc")]
		void Dealloc ();
	}

	// @interface FSCompareResultInfoArray : NSObject
	[BaseType (typeof(NSObject))]
	interface FSCompareResultInfoArray
	{
		// -(void *)getCptr;
		[Export ("getCptr")]
		//[Verify (MethodToProperty)]
		IntPtr Cptr { get; }

		// -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
		[Export ("initWithCptr:swigOwnCObject:")]
		IntPtr Constructor (IntPtr cptr, bool ownCObject);

		// -(id)initWithOther:(FSCompareResultInfoArray *)other;
		[Export ("initWithOther:")]
		IntPtr Constructor (FSCompareResultInfoArray other);

		// -(unsigned long)getSize;
		[Export ("getSize")]
		//[Verify (MethodToProperty)]
		nuint Size { get; }

		// -(FSCompareResultInfo *)getAt:(unsigned long)index;
		[Export ("getAt:")]
		FSCompareResultInfo GetAt (nuint index);

		// -(void)add:(FSCompareResultInfo *)element;
		[Export ("add:")]
		void Add (FSCompareResultInfo element);

		// -(void)removeAt:(unsigned long)index;
		[Export ("removeAt:")]
		void RemoveAt (nuint index);

		// -(void)insertAt:(unsigned long)index element:(FSCompareResultInfo *)element;
		[Export ("insertAt:element:")]
		void InsertAt (nuint index, FSCompareResultInfo element);

		// -(void)removeAll;
		[Export ("removeAll")]
		void RemoveAll ();

		// -(void)dealloc;
		[Export ("dealloc")]
		void Dealloc ();
	}

	// @interface FSCompareResults : NSObject
	[BaseType (typeof(NSObject))]
	interface FSCompareResults
	{
		// @property (getter = getBase_doc_results, copy, nonatomic) FSCompareResultInfoArray * base_doc_results;
		[Export ("base_doc_results", ArgumentSemantic.Copy)]
		FSCompareResultInfoArray Base_doc_results { [Bind ("getBase_doc_results")] get; set; }

		// @property (getter = getCompared_doc_results, copy, nonatomic) FSCompareResultInfoArray * compared_doc_results;
		[Export ("compared_doc_results", ArgumentSemantic.Copy)]
		FSCompareResultInfoArray Compared_doc_results { [Bind ("getCompared_doc_results")] get; set; }

		// -(void *)getCptr;
		[Export ("getCptr")]
		//[Verify (MethodToProperty)]
		IntPtr Cptr { get; }

		// -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
		[Export ("initWithCptr:swigOwnCObject:")]
		IntPtr Constructor (IntPtr cptr, bool ownCObject);

		// -(id)initWithBase_doc_results:(FSCompareResultInfoArray *)base_doc_results compared_doc_results:(FSCompareResultInfoArray *)compared_doc_results;
		[Export ("initWithBase_doc_results:compared_doc_results:")]
		IntPtr Constructor (FSCompareResultInfoArray base_doc_results, FSCompareResultInfoArray compared_doc_results);

		// -(id)initWithCompare_results:(FSCompareResults *)compare_results;
		[Export ("initWithCompare_results:")]
		IntPtr Constructor (FSCompareResults compare_results);

		// -(void)clear;
		[Export ("clear")]
		void Clear ();

		// -(void)dealloc;
		[Export ("dealloc")]
		void Dealloc ();
	}

	// @interface FSComparison : FSBase
	[BaseType (typeof(FSBase))]
	[DisableDefaultCtor]
	interface FSComparison
	{
		// -(void *)getCptr;
		[Export ("getCptr")]
		//[Verify (MethodToProperty)]
		IntPtr Cptr { get; }

		// -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
		[Export ("initWithCptr:swigOwnCObject:")]
		IntPtr Constructor (IntPtr cptr, bool ownCObject);

		// -(id)initWithBase_doc:(FSPDFDoc *)base_doc compared_doc:(FSPDFDoc *)compared_doc;
		[Export ("initWithBase_doc:compared_doc:")]
		IntPtr Constructor (FSPDFDoc base_doc, FSPDFDoc compared_doc);

		// -(id)initWithOther:(FSComparison *)other;
		[Export ("initWithOther:")]
		IntPtr Constructor (FSComparison other);

		// -(BOOL)isEmpty;
		[Export ("isEmpty")]
		//[Verify (MethodToProperty)]
		bool IsEmpty { get; }

		// -(FSCompareResults *)doCompare:(int)base_page_index compared_page_index:(int)compared_page_index compare_flags:(unsigned int)compare_flags;
		[Export ("doCompare:compared_page_index:compare_flags:")]
		FSCompareResults DoCompare (int base_page_index, int compared_page_index, uint compare_flags);

		// -(FSPDFDoc *)generateComparedDoc:(unsigned int)compare_flags;
		[Export ("generateComparedDoc:")]
		FSPDFDoc GenerateComparedDoc (uint compare_flags);

		// -(FSPDFDoc *)generateComparedDoc:(unsigned int)compare_flags is_show_all_layers:(BOOL)is_show_all_layers;
		[Export ("generateComparedDoc:is_show_all_layers:")]
		FSPDFDoc GenerateComparedDoc (uint compare_flags, bool is_show_all_layers);

		// -(void)dealloc;
		[Export ("dealloc")]
		void Dealloc ();
	}

	// @interface FSOptimizer : FSBase
	[BaseType (typeof(FSBase))]
	interface FSOptimizer
	{
		// -(void *)getCptr;
		[Export ("getCptr")]
		//[Verify (MethodToProperty)]
		IntPtr Cptr { get; }

		// -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
		[Export ("initWithCptr:swigOwnCObject:")]
		IntPtr Constructor (IntPtr cptr, bool ownCObject);

		// +(FSProgressive *)optimize:(FSPDFDoc *)doc settings:(FSOptimizerSettings *)settings pause:(id<FSPauseCallback>)pause;
		[Static]
		[Export ("optimize:settings:pause:")]
		FSProgressive Optimize (FSPDFDoc doc, FSOptimizerSettings settings, NSObject pause);

		// +(FSProgressive *)startSubsetEmbedFont:(FSPDFDoc *)doc pause:(id<FSPauseCallback>)pause;
		[Static]
		[Export ("startSubsetEmbedFont:pause:")]
		FSProgressive StartSubsetEmbedFont (FSPDFDoc doc, NSObject pause);

		// -(void)dealloc;
		[Export ("dealloc")]
		void Dealloc ();
	}

	// @interface FSImageSettings : FSBase
	[BaseType (typeof(FSBase))]
	interface FSImageSettings
	{
		// -(void *)getCptr;
		[Export ("getCptr")]
		//[Verify (MethodToProperty)]
		IntPtr Cptr { get; }

		// -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
		[Export ("initWithCptr:swigOwnCObject:")]
		IntPtr Constructor (IntPtr cptr, bool ownCObject);

		// -(id)initWithOther:(FSImageSettings *)other;
		[Export ("initWithOther:")]
		IntPtr Constructor (FSImageSettings other);

		// -(BOOL)isEmpty;
		[Export ("isEmpty")]
		//[Verify (MethodToProperty)]
		bool IsEmpty { get; }

		// -(void)setStretchMode:(FSImageSettingsStretchMode)mode;
		[Export ("setStretchMode:")]
		void SetStretchMode (FSImageSettingsStretchMode mode);

		// -(void)setImageDPI:(int)dpi;
		[Export ("setImageDPI:")]
		void SetImageDPI (int dpi);

		// -(void)setImageDPILimit:(int)dpi_limit;
		[Export ("setImageDPILimit:")]
		void SetImageDPILimit (int dpi_limit);

		// -(void)setCompressionMode:(FSImageSettingsImageCompressMode)mode;
		[Export ("setCompressionMode:")]
		void SetCompressionMode (FSImageSettingsImageCompressMode mode);

		// -(void)setQuality:(FSImageSettingsImageCompressQuality)quality;
		[Export ("setQuality:")]
		void SetQuality (FSImageSettingsImageCompressQuality quality);

		// -(void)setBackgroundDownScale:(int)down_scale;
		[Export ("setBackgroundDownScale:")]
		void SetBackgroundDownScale (int down_scale);

		// -(void)setForegroundDownScale:(int)down_scale;
		[Export ("setForegroundDownScale:")]
		void SetForegroundDownScale (int down_scale);

		// -(void)setTextSensitivity:(int)text_sensitivity;
		[Export ("setTextSensitivity:")]
		void SetTextSensitivity (int text_sensitivity);

		// -(void)dealloc;
		[Export ("dealloc")]
		void Dealloc ();
	}

	// @interface FSMonoImageSettings : FSBase
	[BaseType (typeof(FSBase))]
	interface FSMonoImageSettings
	{
		// -(void *)getCptr;
		[Export ("getCptr")]
		//[Verify (MethodToProperty)]
		IntPtr Cptr { get; }

		// -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
		[Export ("initWithCptr:swigOwnCObject:")]
		IntPtr Constructor (IntPtr cptr, bool ownCObject);

		// -(id)initWithOther:(FSMonoImageSettings *)other;
		[Export ("initWithOther:")]
		IntPtr Constructor (FSMonoImageSettings other);

		// -(BOOL)isEmpty;
		[Export ("isEmpty")]
		//[Verify (MethodToProperty)]
		bool IsEmpty { get; }

		// -(void)setImageDPI:(int)dpi;
		[Export ("setImageDPI:")]
		void SetImageDPI (int dpi);

		// -(void)setImageDPILimit:(int)dpi_limit;
		[Export ("setImageDPILimit:")]
		void SetImageDPILimit (int dpi_limit);

		// -(void)setCompressionMode:(FSMonoImageSettingsMonoImageCompressMode)mode;
		[Export ("setCompressionMode:")]
		void SetCompressionMode (FSMonoImageSettingsMonoImageCompressMode mode);

		// -(void)setStretchMode:(FSMonoImageSettingsStretchMode)mode;
		[Export ("setStretchMode:")]
		void SetStretchMode (FSMonoImageSettingsStretchMode mode);

		// -(void)setQuality:(FSMonoImageSettingsMonoImageCompressQuality)quality;
		[Export ("setQuality:")]
		void SetQuality (FSMonoImageSettingsMonoImageCompressQuality quality);

		// -(void)dealloc;
		[Export ("dealloc")]
		void Dealloc ();
	}

	// @interface FSUnembeddedFontSettings : FSBase
	[BaseType (typeof(FSBase))]
	interface FSUnembeddedFontSettings
	{
		// -(void *)getCptr;
		[Export ("getCptr")]
		//[Verify (MethodToProperty)]
		IntPtr Cptr { get; }

		// -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
		[Export ("initWithCptr:swigOwnCObject:")]
		IntPtr Constructor (IntPtr cptr, bool ownCObject);

		// -(id)initWithOther:(FSUnembeddedFontSettings *)other;
		[Export ("initWithOther:")]
		IntPtr Constructor (FSUnembeddedFontSettings other);

		// -(BOOL)isEmpty;
		[Export ("isEmpty")]
		//[Verify (MethodToProperty)]
		bool IsEmpty { get; }

		// -(void)setUnembeddedFontNameArray:(NSArray<NSString *> *)font_name_array;
		[Export ("setUnembeddedFontNameArray:")]
		void SetUnembeddedFontNameArray (string[] font_name_array);

		// -(void)dealloc;
		[Export ("dealloc")]
		void Dealloc ();
	}

	// @interface FSOptimizerSettings : FSBase
	[BaseType (typeof(FSBase))]
	interface FSOptimizerSettings
	{
		// -(void *)getCptr;
		[Export ("getCptr")]
		//[Verify (MethodToProperty)]
		IntPtr Cptr { get; }

		// -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
		[Export ("initWithCptr:swigOwnCObject:")]
		IntPtr Constructor (IntPtr cptr, bool ownCObject);

		// -(id)initWithOther:(FSOptimizerSettings *)other;
		[Export ("initWithOther:")]
		IntPtr Constructor (FSOptimizerSettings other);

		// -(BOOL)isEmpty;
		[Export ("isEmpty")]
		//[Verify (MethodToProperty)]
		bool IsEmpty { get; }

		// -(void)setOptimizerOptions:(unsigned int)optimize_options;
		[Export ("setOptimizerOptions:")]
		void SetOptimizerOptions (uint optimize_options);

		// -(void)setColorGrayImageSettings:(FSImageSettings *)settings;
		[Export ("setColorGrayImageSettings:")]
		void SetColorGrayImageSettings (FSImageSettings settings);

		// -(void)setColorImageSettings:(FSImageSettings *)settings;
		[Export ("setColorImageSettings:")]
		void SetColorImageSettings (FSImageSettings settings);

		// -(void)setGrayscaleImageSettings:(FSImageSettings *)settings;
		[Export ("setGrayscaleImageSettings:")]
		void SetGrayscaleImageSettings (FSImageSettings settings);

		// -(void)setMonoImageSettings:(FSMonoImageSettings *)settings;
		[Export ("setMonoImageSettings:")]
		void SetMonoImageSettings (FSMonoImageSettings settings);

		// -(void)setUnembeddedFontSettings:(FSUnembeddedFontSettings *)settings;
		[Export ("setUnembeddedFontSettings:")]
		void SetUnembeddedFontSettings (FSUnembeddedFontSettings settings);

		// -(void)setCleanUpOptions:(unsigned int)clean_up_options;
		[Export ("setCleanUpOptions:")]
		void SetCleanUpOptions (uint clean_up_options);

		// -(void)setDiscardObjectsOptions:(unsigned int)discard_objects_options;
		[Export ("setDiscardObjectsOptions:")]
		void SetDiscardObjectsOptions (uint discard_objects_options);

		// -(void)setDiscardUserDataOptions:(unsigned int)discard_userdata_options;
		[Export ("setDiscardUserDataOptions:")]
		void SetDiscardUserDataOptions (uint discard_userdata_options);

		// -(void)dealloc;
		[Export ("dealloc")]
		void Dealloc ();
	}

	// @interface FSHTML2PDFSettingData : NSObject
	[BaseType (typeof(NSObject))]
	interface FSHTML2PDFSettingData
	{
		// @property (getter = getPage_width, nonatomic) float page_width;
		[Export ("page_width")]
		float Page_width { [Bind ("getPage_width")] get; set; }

		// @property (getter = getPage_height, nonatomic) float page_height;
		[Export ("page_height")]
		float Page_height { [Bind ("getPage_height")] get; set; }

		// @property (getter = getIs_to_page_scale, nonatomic) BOOL is_to_page_scale;
		[Export ("is_to_page_scale")]
		bool Is_to_page_scale { [Bind ("getIs_to_page_scale")] get; set; }

		// @property (getter = getPage_margin, copy, nonatomic) FSRectF * page_margin;
		[Export ("page_margin", ArgumentSemantic.Copy)]
		FSRectF Page_margin { [Bind ("getPage_margin")] get; set; }

		// @property (getter = getRotate_degrees, nonatomic) FSRotation rotate_degrees;
		[Export ("rotate_degrees", ArgumentSemantic.Assign)]
		FSRotation Rotate_degrees { [Bind ("getRotate_degrees")] get; set; }

		// @property (getter = getIs_convert_link, nonatomic) BOOL is_convert_link;
		[Export ("is_convert_link")]
		bool Is_convert_link { [Bind ("getIs_convert_link")] get; set; }

		// @property (getter = getIs_generate_tag, nonatomic) BOOL is_generate_tag;
		[Export ("is_generate_tag")]
		bool Is_generate_tag { [Bind ("getIs_generate_tag")] get; set; }

		// @property (getter = getPage_mode, nonatomic) FSHTML2PDFSettingDataHTML2PDFPageMode page_mode;
		[Export ("page_mode", ArgumentSemantic.Assign)]
		FSHTML2PDFSettingDataHTML2PDFPageMode Page_mode { [Bind ("getPage_mode")] get; set; }

		// @property (getter = getTo_generate_bookmarks, nonatomic) BOOL to_generate_bookmarks;
		[Export ("to_generate_bookmarks")]
		bool To_generate_bookmarks { [Bind ("getTo_generate_bookmarks")] get; set; }

		// @property (getter = getScaling_mode, nonatomic) FSHTML2PDFSettingDataHTML2PDFScalingMode scaling_mode;
		[Export ("scaling_mode", ArgumentSemantic.Assign)]
		FSHTML2PDFSettingDataHTML2PDFScalingMode Scaling_mode { [Bind ("getScaling_mode")] get; set; }

		// @property (getter = getEncoding_format, nonatomic) FSHTML2PDFSettingDataHTML2PDFEncodingFormat encoding_format;
		[Export ("encoding_format", ArgumentSemantic.Assign)]
		FSHTML2PDFSettingDataHTML2PDFEncodingFormat Encoding_format { [Bind ("getEncoding_format")] get; set; }

		// @property (getter = getTo_render_images, nonatomic) BOOL to_render_images;
		[Export ("to_render_images")]
		bool To_render_images { [Bind ("getTo_render_images")] get; set; }

		// @property (getter = getTo_remove_underline_for_link, nonatomic) BOOL to_remove_underline_for_link;
		[Export ("to_remove_underline_for_link")]
		bool To_remove_underline_for_link { [Bind ("getTo_remove_underline_for_link")] get; set; }

		// @property (getter = getTo_set_headerfooter, nonatomic) BOOL to_set_headerfooter;
		[Export ("to_set_headerfooter")]
		bool To_set_headerfooter { [Bind ("getTo_set_headerfooter")] get; set; }

		// @property (getter = getHeaderfooter_title, copy, nonatomic) NSString * headerfooter_title;
		[Export ("headerfooter_title")]
		string Headerfooter_title { [Bind ("getHeaderfooter_title")] get; set; }

		// @property (getter = getHeaderfooter_url, copy, nonatomic) NSString * headerfooter_url;
		[Export ("headerfooter_url")]
		string Headerfooter_url { [Bind ("getHeaderfooter_url")] get; set; }

		// @property (getter = getBookmark_root_name, copy, nonatomic) NSString * bookmark_root_name;
		[Export ("bookmark_root_name")]
		string Bookmark_root_name { [Bind ("getBookmark_root_name")] get; set; }

		// @property (getter = getTo_resize_objects, nonatomic) BOOL to_resize_objects;
		[Export ("to_resize_objects")]
		bool To_resize_objects { [Bind ("getTo_resize_objects")] get; set; }

		// @property (getter = getTo_print_background, nonatomic) BOOL to_print_background;
		[Export ("to_print_background")]
		bool To_print_background { [Bind ("getTo_print_background")] get; set; }

		// @property (getter = getTo_optimize_tag_tree, nonatomic) BOOL to_optimize_tag_tree;
		[Export ("to_optimize_tag_tree")]
		bool To_optimize_tag_tree { [Bind ("getTo_optimize_tag_tree")] get; set; }

		// @property (getter = getMedia_style, nonatomic) FSHTML2PDFSettingDataHTML2PDFMediaStyle media_style;
		[Export ("media_style", ArgumentSemantic.Assign)]
		FSHTML2PDFSettingDataHTML2PDFMediaStyle Media_style { [Bind ("getMedia_style")] get; set; }

		// @property (getter = getTo_load_active_content, nonatomic) BOOL to_load_active_content;
		[Export ("to_load_active_content")]
		bool To_load_active_content { [Bind ("getTo_load_active_content")] get; set; }

		// @property (getter = getTo_disable_sandbox, nonatomic) BOOL to_disable_sandbox;
		[Export ("to_disable_sandbox")]
		bool To_disable_sandbox { [Bind ("getTo_disable_sandbox")] get; set; }

		// @property (getter = getTo_use_blacklist, nonatomic) BOOL to_use_blacklist;
		[Export ("to_use_blacklist")]
		bool To_use_blacklist { [Bind ("getTo_use_blacklist")] get; set; }

		// -(void *)getCptr;
		[Export ("getCptr")]
		//[Verify (MethodToProperty)]
		IntPtr Cptr { get; }

		// -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
		[Export ("initWithCptr:swigOwnCObject:")]
		IntPtr Constructor (IntPtr cptr, bool ownCObject);

		// -(id)initWithPage_width:(float)page_width page_height:(float)page_height is_to_page_scale:(BOOL)is_to_page_scale page_margin:(FSRectF *)page_margin is_convert_link:(BOOL)is_convert_link rotate_degrees:(FSRotation)rotate_degrees is_generate_tag:(BOOL)is_generate_tag page_mode:(FSHTML2PDFSettingDataHTML2PDFPageMode)page_mode to_generate_bookmarks:(BOOL)to_generate_bookmarks scaling_mode:(FSHTML2PDFSettingDataHTML2PDFScalingMode)scaling_mode encoding_format:(FSHTML2PDFSettingDataHTML2PDFEncodingFormat)encoding_format to_render_images:(BOOL)to_render_images to_remove_underline_for_link:(BOOL)to_remove_underline_for_link to_set_headerfooter:(BOOL)to_set_headerfooter headerfooter_title:(NSString *)headerfooter_title headerfooter_url:(NSString *)headerfooter_url bookmark_root_name:(NSString *)bookmark_root_name to_resize_objects:(BOOL)to_resize_objects to_print_background:(BOOL)to_print_background to_optimize_tag_tree:(BOOL)to_optimize_tag_tree media_style:(FSHTML2PDFSettingDataHTML2PDFMediaStyle)media_style to_load_active_content:(BOOL)to_load_active_content to_disable_sandbox:(BOOL)to_disable_sandbox to_use_blacklist:(BOOL)to_use_blacklist;
		[Export ("initWithPage_width:page_height:is_to_page_scale:page_margin:is_convert_link:rotate_degrees:is_generate_tag:page_mode:to_generate_bookmarks:scaling_mode:encoding_format:to_render_images:to_remove_underline_for_link:to_set_headerfooter:headerfooter_title:headerfooter_url:bookmark_root_name:to_resize_objects:to_print_background:to_optimize_tag_tree:media_style:to_load_active_content:to_disable_sandbox:to_use_blacklist:")]
		IntPtr Constructor (float page_width, float page_height, bool is_to_page_scale, FSRectF page_margin, bool is_convert_link, FSRotation rotate_degrees, bool is_generate_tag, FSHTML2PDFSettingDataHTML2PDFPageMode page_mode, bool to_generate_bookmarks, FSHTML2PDFSettingDataHTML2PDFScalingMode scaling_mode, FSHTML2PDFSettingDataHTML2PDFEncodingFormat encoding_format, bool to_render_images, bool to_remove_underline_for_link, bool to_set_headerfooter, string headerfooter_title, string headerfooter_url, string bookmark_root_name, bool to_resize_objects, bool to_print_background, bool to_optimize_tag_tree, FSHTML2PDFSettingDataHTML2PDFMediaStyle media_style, bool to_load_active_content, bool to_disable_sandbox, bool to_use_blacklist);

		// -(void)set:(float)page_width page_height:(float)page_height is_to_page_scale:(BOOL)is_to_page_scale page_margin:(FSRectF *)page_margin is_convert_link:(BOOL)is_convert_link rotate_degrees:(FSRotation)rotate_degrees is_generate_tag:(BOOL)is_generate_tag page_mode:(FSHTML2PDFSettingDataHTML2PDFPageMode)page_mode to_generate_bookmarks:(BOOL)to_generate_bookmarks scaling_mode:(FSHTML2PDFSettingDataHTML2PDFScalingMode)scaling_mode encoding_format:(FSHTML2PDFSettingDataHTML2PDFEncodingFormat)encoding_format to_render_images:(BOOL)to_render_images to_remove_underline_for_link:(BOOL)to_remove_underline_for_link to_set_headerfooter:(BOOL)to_set_headerfooter headerfooter_title:(NSString *)headerfooter_title headerfooter_url:(NSString *)headerfooter_url bookmark_root_name:(NSString *)bookmark_root_name to_resize_objects:(BOOL)to_resize_objects to_print_background:(BOOL)to_print_background to_optimize_tag_tree:(BOOL)to_optimize_tag_tree media_style:(FSHTML2PDFSettingDataHTML2PDFMediaStyle)media_style to_load_active_content:(BOOL)to_load_active_content to_disable_sandbox:(BOOL)to_disable_sandbox to_use_blacklist:(BOOL)to_use_blacklist;
		[Export ("set:page_height:is_to_page_scale:page_margin:is_convert_link:rotate_degrees:is_generate_tag:page_mode:to_generate_bookmarks:scaling_mode:encoding_format:to_render_images:to_remove_underline_for_link:to_set_headerfooter:headerfooter_title:headerfooter_url:bookmark_root_name:to_resize_objects:to_print_background:to_optimize_tag_tree:media_style:to_load_active_content:to_disable_sandbox:to_use_blacklist:")]
		void Set (float page_width, float page_height, bool is_to_page_scale, FSRectF page_margin, bool is_convert_link, FSRotation rotate_degrees, bool is_generate_tag, FSHTML2PDFSettingDataHTML2PDFPageMode page_mode, bool to_generate_bookmarks, FSHTML2PDFSettingDataHTML2PDFScalingMode scaling_mode, FSHTML2PDFSettingDataHTML2PDFEncodingFormat encoding_format, bool to_render_images, bool to_remove_underline_for_link, bool to_set_headerfooter, string headerfooter_title, string headerfooter_url, string bookmark_root_name, bool to_resize_objects, bool to_print_background, bool to_optimize_tag_tree, FSHTML2PDFSettingDataHTML2PDFMediaStyle media_style, bool to_load_active_content, bool to_disable_sandbox, bool to_use_blacklist);

		// -(void)dealloc;
		[Export ("dealloc")]
		void Dealloc ();
	}

	// @interface FSTXT2PDFSettingData : NSObject
	[BaseType (typeof(NSObject))]
	interface FSTXT2PDFSettingData
	{
		// @property (getter = getPage_width, nonatomic) float page_width;
		[Export ("page_width")]
		float Page_width { [Bind ("getPage_width")] get; set; }

		// @property (getter = getPage_height, nonatomic) float page_height;
		[Export ("page_height")]
		float Page_height { [Bind ("getPage_height")] get; set; }

		// @property (getter = getPage_margin, copy, nonatomic) FSRectF * page_margin;
		[Export ("page_margin", ArgumentSemantic.Copy)]
		FSRectF Page_margin { [Bind ("getPage_margin")] get; set; }

		// @property (getter = getFont, copy, nonatomic) FSFont * font;
		[Export ("font", ArgumentSemantic.Copy)]
		FSFont Font { [Bind ("getFont")] get; set; }

		// @property (getter = getText_size, nonatomic) float text_size;
		[Export ("text_size")]
		float Text_size { [Bind ("getText_size")] get; set; }

		// @property (getter = getText_color, nonatomic) unsigned int text_color;
		[Export ("text_color")]
		uint Text_color { [Bind ("getText_color")] get; set; }

		// @property (getter = getLinespace, nonatomic) float linespace;
		[Export ("linespace")]
		float Linespace { [Bind ("getLinespace")] get; set; }

		// @property (getter = getIs_break_page, nonatomic) BOOL is_break_page;
		[Export ("is_break_page")]
		bool Is_break_page { [Bind ("getIs_break_page")] get; set; }

		// -(void *)getCptr;
		[Export ("getCptr")]
		//[Verify (MethodToProperty)]
		IntPtr Cptr { get; }

		// -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
		[Export ("initWithCptr:swigOwnCObject:")]
		IntPtr Constructor (IntPtr cptr, bool ownCObject);

		// -(id)initWithPage_width:(float)page_width page_height:(float)page_height page_margin:(FSRectF *)page_margin font:(FSFont *)font text_size:(float)text_size text_color:(unsigned int)text_color linespace:(float)linespace is_break_page:(BOOL)is_break_page;
		[Export ("initWithPage_width:page_height:page_margin:font:text_size:text_color:linespace:is_break_page:")]
		IntPtr Constructor (float page_width, float page_height, FSRectF page_margin, FSFont font, float text_size, uint text_color, float linespace, bool is_break_page);

		// -(void)set:(float)page_width page_height:(float)page_height page_margin:(FSRectF *)page_margin font:(FSFont *)font text_size:(float)text_size text_color:(unsigned int)text_color linespace:(float)linespace is_break_page:(BOOL)is_break_page;
		[Export ("set:page_height:page_margin:font:text_size:text_color:linespace:is_break_page:")]
		void Set (float page_width, float page_height, FSRectF page_margin, FSFont font, float text_size, uint text_color, float linespace, bool is_break_page);

		// -(void)dealloc;
		[Export ("dealloc")]
		void Dealloc ();
	}

	// @interface FSDWG2PDFSettingData : NSObject
	[BaseType (typeof(NSObject))]
	interface FSDWG2PDFSettingData
	{
		// @property (getter = getExport_flags, nonatomic) unsigned int export_flags;
		[Export ("export_flags")]
		uint Export_flags { [Bind ("getExport_flags")] get; set; }

		// @property (getter = getExport_hatches_type, nonatomic) FSDWG2PDFSettingDataDWG2PDFExportHatchesType export_hatches_type;
		[Export ("export_hatches_type", ArgumentSemantic.Assign)]
		FSDWG2PDFSettingDataDWG2PDFExportHatchesType Export_hatches_type { [Bind ("getExport_hatches_type")] get; set; }

		// @property (getter = getOther_export_hatches_type, nonatomic) FSDWG2PDFSettingDataDWG2PDFExportHatchesType other_export_hatches_type;
		[Export ("other_export_hatches_type", ArgumentSemantic.Assign)]
		FSDWG2PDFSettingDataDWG2PDFExportHatchesType Other_export_hatches_type { [Bind ("getOther_export_hatches_type")] get; set; }

		// @property (getter = getGradient_export_hatches_type, nonatomic) FSDWG2PDFSettingDataDWG2PDFExportHatchesType gradient_export_hatches_type;
		[Export ("gradient_export_hatches_type", ArgumentSemantic.Assign)]
		FSDWG2PDFSettingDataDWG2PDFExportHatchesType Gradient_export_hatches_type { [Bind ("getGradient_export_hatches_type")] get; set; }

		// @property (getter = getSearchable_text_type, nonatomic) FSDWG2PDFSettingDataDWG2PDFSearchableTextType searchable_text_type;
		[Export ("searchable_text_type", ArgumentSemantic.Assign)]
		FSDWG2PDFSettingDataDWG2PDFSearchableTextType Searchable_text_type { [Bind ("getSearchable_text_type")] get; set; }

		// @property (getter = getIs_active_layout, nonatomic) BOOL is_active_layout;
		[Export ("is_active_layout")]
		bool Is_active_layout { [Bind ("getIs_active_layout")] get; set; }

		// @property (getter = getOutput_title, copy, nonatomic) NSString * output_title;
		[Export ("output_title")]
		string Output_title { [Bind ("getOutput_title")] get; set; }

		// @property (getter = getOutput_author, copy, nonatomic) NSString * output_author;
		[Export ("output_author")]
		string Output_author { [Bind ("getOutput_author")] get; set; }

		// @property (getter = getOutput_subject, copy, nonatomic) NSString * output_subject;
		[Export ("output_subject")]
		string Output_subject { [Bind ("getOutput_subject")] get; set; }

		// @property (getter = getOutput_keywords, copy, nonatomic) NSString * output_keywords;
		[Export ("output_keywords")]
		string Output_keywords { [Bind ("getOutput_keywords")] get; set; }

		// @property (getter = getOutput_creator, copy, nonatomic) NSString * output_creator;
		[Export ("output_creator")]
		string Output_creator { [Bind ("getOutput_creator")] get; set; }

		// @property (getter = getOutput_producer, copy, nonatomic) NSString * output_producer;
		[Export ("output_producer")]
		string Output_producer { [Bind ("getOutput_producer")] get; set; }

		// @property (getter = getPaper_width, nonatomic) float paper_width;
		[Export ("paper_width")]
		float Paper_width { [Bind ("getPaper_width")] get; set; }

		// @property (getter = getPaper_height, nonatomic) float paper_height;
		[Export ("paper_height")]
		float Paper_height { [Bind ("getPaper_height")] get; set; }

		// @property (getter = getColor_policy, nonatomic) FSDWG2PDFSettingDataDWG2PDFColorPolicy color_policy;
		[Export ("color_policy", ArgumentSemantic.Assign)]
		FSDWG2PDFSettingDataDWG2PDFColorPolicy Color_policy { [Bind ("getColor_policy")] get; set; }

		// @property (getter = getIs_output_progress, nonatomic) BOOL is_output_progress;
		[Export ("is_output_progress")]
		bool Is_output_progress { [Bind ("getIs_output_progress")] get; set; }

		// @property (getter = getProgress_callback, nonatomic) void * progress_callback;
		[Export ("progress_callback", ArgumentSemantic.Assign)]
		IntPtr Progress_callback { [Bind ("getProgress_callback")] get; set; }

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

	// @interface FSHTML2PDFRelatedResource : NSObject
	[BaseType (typeof(NSObject))]
	interface FSHTML2PDFRelatedResource
	{
		// @property (getter = getRelated_resource_file, nonatomic) id<FSFileReaderCallback> related_resource_file;
		[Export ("related_resource_file", ArgumentSemantic.Assign)]
		NSObject Related_resource_file { [Bind ("getRelated_resource_file")] get; set; }

		// @property (getter = getResource_file_relative_path, copy, nonatomic) NSString * resource_file_relative_path;
		[Export ("resource_file_relative_path")]
		string Resource_file_relative_path { [Bind ("getResource_file_relative_path")] get; set; }

		// -(void *)getCptr;
		[Export ("getCptr")]
		//[Verify (MethodToProperty)]
		IntPtr Cptr { get; }

		// -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
		[Export ("initWithCptr:swigOwnCObject:")]
		IntPtr Constructor (IntPtr cptr, bool ownCObject);

		// -(id)initWithRelated_resource_file:(id<FSFileReaderCallback>)related_resource_file resource_file_relative_path:(NSString *)resource_file_relative_path;
		[Export ("initWithRelated_resource_file:resource_file_relative_path:")]
		IntPtr Constructor (NSObject related_resource_file, string resource_file_relative_path);

		// -(void)dealloc;
		[Export ("dealloc")]
		void Dealloc ();
	}

	// @interface FSHTML2PDFRelatedResourceArray : NSObject
	[BaseType (typeof(NSObject))]
	interface FSHTML2PDFRelatedResourceArray
	{
		// -(void *)getCptr;
		[Export ("getCptr")]
		//[Verify (MethodToProperty)]
		IntPtr Cptr { get; }

		// -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
		[Export ("initWithCptr:swigOwnCObject:")]
		IntPtr Constructor (IntPtr cptr, bool ownCObject);

		// -(id)initWithOther:(FSHTML2PDFRelatedResourceArray *)other;
		[Export ("initWithOther:")]
		IntPtr Constructor (FSHTML2PDFRelatedResourceArray other);

		// -(unsigned long)getSize;
		[Export ("getSize")]
		//[Verify (MethodToProperty)]
		nuint Size { get; }

		// -(FSHTML2PDFRelatedResource *)getAt:(unsigned long)index;
		[Export ("getAt:")]
		FSHTML2PDFRelatedResource GetAt (nuint index);

		// -(void)add:(FSHTML2PDFRelatedResource *)element;
		[Export ("add:")]
		void Add (FSHTML2PDFRelatedResource element);

		// -(void)removeAt:(unsigned long)index;
		[Export ("removeAt:")]
		void RemoveAt (nuint index);

		// -(void)insertAt:(unsigned long)index element:(FSHTML2PDFRelatedResource *)element;
		[Export ("insertAt:element:")]
		void InsertAt (nuint index, FSHTML2PDFRelatedResource element);

		// -(void)removeAll;
		[Export ("removeAll")]
		void RemoveAll ();

		// -(void)dealloc;
		[Export ("dealloc")]
		void Dealloc ();
	}

	// @interface FSConvert : FSBase
	[BaseType (typeof(FSBase))]
	interface FSConvert
	{
		// -(void *)getCptr;
		[Export ("getCptr")]
		//[Verify (MethodToProperty)]
		IntPtr Cptr { get; }

		// -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
		[Export ("initWithCptr:swigOwnCObject:")]
		IntPtr Constructor (IntPtr cptr, bool ownCObject);

		// +(void)fromHTML:(NSString *)src_html engine_path:(NSString *)engine_path cookies_path:(NSString *)cookies_path setting_data:(FSHTML2PDFSettingData *)setting_data saved_pdf_path:(NSString *)saved_pdf_path timeout:(int)timeout;
		[Static]
		[Export ("fromHTML:engine_path:cookies_path:setting_data:saved_pdf_path:timeout:")]
		void FromHTML (string src_html, string engine_path, string cookies_path, FSHTML2PDFSettingData setting_data, string saved_pdf_path, int timeout);

		// +(void)fromHTML:(NSString *)src_html engine_path:(NSString *)engine_path cookies_reader:(id<FSFileReaderCallback>)cookies_reader setting_data:(FSHTML2PDFSettingData *)setting_data saved_pdf_path:(NSString *)saved_pdf_path timeout:(int)timeout;
		[Static]
		[Export ("fromHTML:engine_path:cookies_reader:setting_data:saved_pdf_path:timeout:")]
		void FromHTML (string src_html, string engine_path, NSObject cookies_reader, FSHTML2PDFSettingData setting_data, string saved_pdf_path, int timeout);

		// +(void)fromHTML:(NSString *)src_html engine_path:(NSString *)engine_path cookies_reader:(id<FSFileReaderCallback>)cookies_reader setting_data:(FSHTML2PDFSettingData *)setting_data saved_pdf_filestream:(id<FSFileWriterCallback>)saved_pdf_filestream timeout:(int)timeout;
		[Static]
		[Export ("fromHTML:engine_path:cookies_reader:setting_data:saved_pdf_filestream:timeout:")]
		void FromHTML (string src_html, string engine_path, NSObject cookies_reader, FSHTML2PDFSettingData setting_data, NSObject saved_pdf_filestream, int timeout);

		// +(void)fromHTML:(id<FSFileReaderCallback>)src_html html2pdf_related_resource_array:(FSHTML2PDFRelatedResourceArray *)html2pdf_related_resource_array engine_path:(NSString *)engine_path cookies_reader:(id<FSFileReaderCallback>)cookies_reader setting_data:(FSHTML2PDFSettingData *)setting_data saved_pdf_filestream:(id<FSFileWriterCallback>)saved_pdf_filestream timeout:(int)timeout;
		[Static]
		[Export ("fromHTML:html2pdf_related_resource_array:engine_path:cookies_reader:setting_data:saved_pdf_filestream:timeout:")]
		void FromHTML (NSObject src_html, FSHTML2PDFRelatedResourceArray html2pdf_related_resource_array, string engine_path, NSObject cookies_reader, FSHTML2PDFSettingData setting_data, NSObject saved_pdf_filestream, int timeout);

		// +(void)fromTXT:(NSString *)src_txt saved_pdf_path:(NSString *)saved_pdf_path setting_data:(FSTXT2PDFSettingData *)setting_data;
		[Static]
		[Export ("fromTXT:saved_pdf_path:setting_data:")]
		void FromTXT (string src_txt, string saved_pdf_path, FSTXT2PDFSettingData setting_data);

		// +(void)fromImage:(NSString *)src_img saved_pdf_path:(NSString *)saved_pdf_path;
		[Static]
		[Export ("fromImage:saved_pdf_path:")]
		void FromImage (string src_img, string saved_pdf_path);

		// +(void)fromImage:(id<FSFileReaderCallback>)file_reader saved_pdf_filestream:(id<FSFileWriterCallback>)saved_pdf_filestream;
		[Static]
		[Export ("fromImage:saved_pdf_filestream:")]
		void FromImage (NSObject file_reader, NSObject saved_pdf_filestream);

		// +(BOOL)fromDWG:(NSString *)engine_path src_dwg_path:(NSString *)src_dwg_path saved_pdf_path:(NSString *)saved_pdf_path settings:(FSDWG2PDFSettingData *)settings;
		[Static]
		[Export ("fromDWG:src_dwg_path:saved_pdf_path:settings:")]
		bool FromDWG (string engine_path, string src_dwg_path, string saved_pdf_path, FSDWG2PDFSettingData settings);

		// +(BOOL)toXML:(NSString *)src_pdf_path src_file_password:(NSString *)src_file_password saved_xml_path:(NSString *)saved_xml_path saved_image_folder_path:(NSString *)saved_image_folder_path is_force_to_tagged_pdf:(BOOL)is_force_to_tagged_pdf;
		[Static]
		[Export ("toXML:src_file_password:saved_xml_path:saved_image_folder_path:is_force_to_tagged_pdf:")]
		bool ToXML (string src_pdf_path, string src_file_password, string saved_xml_path, string saved_image_folder_path, bool is_force_to_tagged_pdf);

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
		IntPtr Constructor (NSObject file_read);

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

		// -(BOOL)saveAsWithFile:(id<FSFileWriterCallback>)file;
		[Export ("saveAsWithFile:")]
		bool SaveAsWithFile (NSObject file);

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

		// -(id)initWithOther:(FSMenuListArray *)other;
		[Export ("initWithOther:")]
		IntPtr Constructor (FSMenuListArray other);

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

	// @interface FSMenuItemExArray : NSObject
	[BaseType (typeof(NSObject))]
	interface FSMenuItemExArray
	{
		// -(void *)getCptr;
		[Export ("getCptr")]
		//[Verify (MethodToProperty)]
		IntPtr Cptr { get; }

		// -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
		[Export ("initWithCptr:swigOwnCObject:")]
		IntPtr Constructor (IntPtr cptr, bool ownCObject);

		// -(id)initWithOther:(FSMenuItemExArray *)other;
		[Export ("initWithOther:")]
		IntPtr Constructor (FSMenuItemExArray other);

		// -(unsigned long)getSize;
		[Export ("getSize")]
		//[Verify (MethodToProperty)]
		nuint Size { get; }

		// -(FSMenuItemEx *)getAt:(unsigned long)index;
		[Export ("getAt:")]
		FSMenuItemEx GetAt (nuint index);

		// -(void)add:(FSMenuItemEx *)element;
		[Export ("add:")]
		void Add (FSMenuItemEx element);

		// -(void)removeAt:(unsigned long)index;
		[Export ("removeAt:")]
		void RemoveAt (nuint index);

		// -(void)insertAt:(unsigned long)index element:(FSMenuItemEx *)element;
		[Export ("insertAt:element:")]
		void InsertAt (nuint index, FSMenuItemEx element);

		// -(void)removeAll;
		[Export ("removeAll")]
		void RemoveAll ();

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

		// @property (getter = getName, copy, nonatomic) NSString * name;
		[Export ("name")]
		string Name { [Bind ("getName")] get; set; }

		// @property (getter = getSub_menu_list_array, copy, nonatomic) FSMenuListArray * sub_menu_list_array;
		[Export ("sub_menu_list_array", ArgumentSemantic.Copy)]
		FSMenuListArray Sub_menu_list_array { [Bind ("getSub_menu_list_array")] get; set; }

		// -(void *)getCptr;
		[Export ("getCptr")]
		//[Verify (MethodToProperty)]
		IntPtr Cptr { get; }

		// -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
		[Export ("initWithCptr:swigOwnCObject:")]
		IntPtr Constructor (IntPtr cptr, bool ownCObject);

		// -(id)initWithLevel:(int)level name:(NSString *)name sub_menu_list_array:(FSMenuListArray *)sub_menu_list_array;
		[Export ("initWithLevel:name:sub_menu_list_array:")]
		IntPtr Constructor (int level, string name, FSMenuListArray sub_menu_list_array);

		// -(id)initWithMenu_list:(FSMenuList *)menu_list;
		[Export ("initWithMenu_list:")]
		IntPtr Constructor (FSMenuList menu_list);

		// -(void)set:(int)level name:(NSString *)name sub_menu_list_array:(FSMenuListArray *)sub_menu_list_array;
		[Export ("set:name:sub_menu_list_array:")]
		void Set (int level, string name, FSMenuListArray sub_menu_list_array);

		// -(void)dealloc;
		[Export ("dealloc")]
		void Dealloc ();
	}

	// @interface FSMenuItemEx : NSObject
	[BaseType (typeof(NSObject))]
	interface FSMenuItemEx
	{
		// @property (getter = getItem_name, copy, nonatomic) NSString * item_name;
		[Export ("item_name")]
		string Item_name { [Bind ("getItem_name")] get; set; }

		// @property (getter = getReturn_name, copy, nonatomic) NSString * return_name;
		[Export ("return_name")]
		string Return_name { [Bind ("getReturn_name")] get; set; }

		// @property (getter = getIs_checked, nonatomic) BOOL is_checked;
		[Export ("is_checked")]
		bool Is_checked { [Bind ("getIs_checked")] get; set; }

		// @property (getter = getIs_enabled, nonatomic) BOOL is_enabled;
		[Export ("is_enabled")]
		bool Is_enabled { [Bind ("getIs_enabled")] get; set; }

		// @property (getter = getSub_menu_item_array, copy, nonatomic) FSMenuItemExArray * sub_menu_item_array;
		[Export ("sub_menu_item_array", ArgumentSemantic.Copy)]
		FSMenuItemExArray Sub_menu_item_array { [Bind ("getSub_menu_item_array")] get; set; }

		// -(void *)getCptr;
		[Export ("getCptr")]
		//[Verify (MethodToProperty)]
		IntPtr Cptr { get; }

		// -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
		[Export ("initWithCptr:swigOwnCObject:")]
		IntPtr Constructor (IntPtr cptr, bool ownCObject);

		// -(id)initWithItem_name:(NSString *)item_name return_name:(NSString *)return_name is_checked:(BOOL)is_checked is_enabled:(BOOL)is_enabled sub_menu_item_array:(FSMenuItemExArray *)sub_menu_item_array;
		[Export ("initWithItem_name:return_name:is_checked:is_enabled:sub_menu_item_array:")]
		IntPtr Constructor (string item_name, string return_name, bool is_checked, bool is_enabled, FSMenuItemExArray sub_menu_item_array);

		// -(id)initWithMenu_item:(FSMenuItemEx *)menu_item;
		[Export ("initWithMenu_item:")]
		IntPtr Constructor (FSMenuItemEx menu_item);

		// -(void)set:(NSString *)item_name return_name:(NSString *)return_name is_checked:(BOOL)is_checked is_enabled:(BOOL)is_enabled sub_menu_item_array:(FSMenuItemExArray *)sub_menu_item_array;
		[Export ("set:return_name:is_checked:is_enabled:sub_menu_item_array:")]
		void Set (string item_name, string return_name, bool is_checked, bool is_enabled, FSMenuItemExArray sub_menu_item_array);

		// -(void)dealloc;
		[Export ("dealloc")]
		void Dealloc ();
	}

	// @interface FSIdentityProperties : NSObject
	[BaseType (typeof(NSObject))]
	interface FSIdentityProperties
	{
		// @property (getter = getCorporation, copy, nonatomic) NSString * corporation;
		[Export ("corporation")]
		string Corporation { [Bind ("getCorporation")] get; set; }

		// @property (getter = getEmail, copy, nonatomic) NSString * email;
		[Export ("email")]
		string Email { [Bind ("getEmail")] get; set; }

		// @property (getter = getLogin_name, copy, nonatomic) NSString * login_name;
		[Export ("login_name")]
		string Login_name { [Bind ("getLogin_name")] get; set; }

		// @property (getter = getName, copy, nonatomic) NSString * name;
		[Export ("name")]
		string Name { [Bind ("getName")] get; set; }

		// @property (getter = getFirst_name, copy, nonatomic) NSString * first_name;
		[Export ("first_name")]
		string First_name { [Bind ("getFirst_name")] get; set; }

		// @property (getter = getLast_name, copy, nonatomic) NSString * last_name;
		[Export ("last_name")]
		string Last_name { [Bind ("getLast_name")] get; set; }

		// @property (getter = getTitle, copy, nonatomic) NSString * title;
		[Export ("title")]
		string Title { [Bind ("getTitle")] get; set; }

		// @property (getter = getDepartment, copy, nonatomic) NSString * department;
		[Export ("department")]
		string Department { [Bind ("getDepartment")] get; set; }

		// -(void *)getCptr;
		[Export ("getCptr")]
		//[Verify (MethodToProperty)]
		IntPtr Cptr { get; }

		// -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
		[Export ("initWithCptr:swigOwnCObject:")]
		IntPtr Constructor (IntPtr cptr, bool ownCObject);

		// -(id)initWithCorporation:(NSString *)corporation email:(NSString *)email login_name:(NSString *)login_name name:(NSString *)name first_name:(NSString *)first_name last_name:(NSString *)last_name title:(NSString *)title department:(NSString *)department;
		[Export ("initWithCorporation:email:login_name:name:first_name:last_name:title:department:")]
		IntPtr Constructor (string corporation, string email, string login_name, string name, string first_name, string last_name, string title, string department);

		// -(id)initWithId_properities:(FSIdentityProperties *)id_properities;
		[Export ("initWithId_properities:")]
		IntPtr Constructor (FSIdentityProperties id_properities);

		// -(void)set:(NSString *)corporation email:(NSString *)email login_name:(NSString *)login_name name:(NSString *)name first_name:(NSString *)first_name last_name:(NSString *)last_name title:(NSString *)title department:(NSString *)department;
		[Export ("set:email:login_name:name:first_name:last_name:title:department:")]
		void Set (string corporation, string email, string login_name, string name, string first_name, string last_name, string title, string department);

		// -(void)dealloc;
		[Export ("dealloc")]
		void Dealloc ();
	}

	// @interface FSButtonItem : NSObject
	[BaseType (typeof(NSObject))]
	interface FSButtonItem
	{
		// @property (getter = getName, copy, nonatomic) NSString * name;
		[Export ("name")]
		string Name { [Bind ("getName")] get; set; }

		// @property (getter = getPos, nonatomic) int pos;
		[Export ("pos")]
		int Pos { [Bind ("getPos")] get; set; }

		// @property (getter = getExec, copy, nonatomic) NSString * exec;
		[Export ("exec")]
		string Exec { [Bind ("getExec")] get; set; }

		// @property (getter = getEnable, copy, nonatomic) NSString * enable;
		[Export ("enable")]
		string Enable { [Bind ("getEnable")] get; set; }

		// @property (getter = getMarked, copy, nonatomic) NSString * marked;
		[Export ("marked")]
		string Marked { [Bind ("getMarked")] get; set; }

		// @property (getter = getTooltip, copy, nonatomic) NSString * tooltip;
		[Export ("tooltip")]
		string Tooltip { [Bind ("getTooltip")] get; set; }

		// @property (getter = getLabel, copy, nonatomic) NSString * label;
		[Export ("label")]
		string Label { [Bind ("getLabel")] get; set; }

		// @property (getter = getBitmap, copy, nonatomic) FSBitmap * bitmap;
		[Export ("bitmap", ArgumentSemantic.Copy)]
		FSBitmap Bitmap { [Bind ("getBitmap")] get; set; }

		// -(void *)getCptr;
		[Export ("getCptr")]
		//[Verify (MethodToProperty)]
		IntPtr Cptr { get; }

		// -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
		[Export ("initWithCptr:swigOwnCObject:")]
		IntPtr Constructor (IntPtr cptr, bool ownCObject);

		// -(id)initWithName:(NSString *)name pos:(int)pos exec:(NSString *)exec enable:(NSString *)enable marked:(NSString *)marked tooltip:(NSString *)tooltip label:(NSString *)label bitmap:(FSBitmap *)bitmap;
		[Export ("initWithName:pos:exec:enable:marked:tooltip:label:bitmap:")]
		IntPtr Constructor (string name, int pos, string exec, string enable, string marked, string tooltip, string label, FSBitmap bitmap);

		// -(id)initWithButton_item:(FSButtonItem *)button_item;
		[Export ("initWithButton_item:")]
		IntPtr Constructor (FSButtonItem button_item);

		// -(void)set:(NSString *)name pos:(int)pos exec:(NSString *)exec enable:(NSString *)enable marked:(NSString *)marked tooltip:(NSString *)tooltip label:(NSString *)label bitmap:(FSBitmap *)bitmap;
		[Export ("set:pos:exec:enable:marked:tooltip:label:bitmap:")]
		void Set (string name, int pos, string exec, string enable, string marked, string tooltip, string label, FSBitmap bitmap);

		// -(void)dealloc;
		[Export ("dealloc")]
		void Dealloc ();
	}

	// @interface FSMenuItemConfig : NSObject
	[BaseType (typeof(NSObject))]
	interface FSMenuItemConfig
	{
		// @property (getter = getName, copy, nonatomic) NSString * name;
		[Export ("name")]
		string Name { [Bind ("getName")] get; set; }

		// @property (getter = getUser, copy, nonatomic) NSString * user;
		[Export ("user")]
		string User { [Bind ("getUser")] get; set; }

		// @property (getter = getParent, copy, nonatomic) NSString * parent;
		[Export ("parent")]
		string Parent { [Bind ("getParent")] get; set; }

		// @property (getter = getPos, nonatomic) int pos;
		[Export ("pos")]
		int Pos { [Bind ("getPos")] get; set; }

		// @property (getter = getPos_str, copy, nonatomic) NSString * pos_str;
		[Export ("pos_str")]
		string Pos_str { [Bind ("getPos_str")] get; set; }

		// @property (getter = getExec, copy, nonatomic) NSString * exec;
		[Export ("exec")]
		string Exec { [Bind ("getExec")] get; set; }

		// @property (getter = getEnable, copy, nonatomic) NSString * enable;
		[Export ("enable")]
		string Enable { [Bind ("getEnable")] get; set; }

		// @property (getter = getMarked, copy, nonatomic) NSString * marked;
		[Export ("marked")]
		string Marked { [Bind ("getMarked")] get; set; }

		// -(void *)getCptr;
		[Export ("getCptr")]
		//[Verify (MethodToProperty)]
		IntPtr Cptr { get; }

		// -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
		[Export ("initWithCptr:swigOwnCObject:")]
		IntPtr Constructor (IntPtr cptr, bool ownCObject);

		// -(id)initWithName:(NSString *)name user:(NSString *)user parent:(NSString *)parent pos:(int)pos pos_str:(NSString *)pos_str exec:(NSString *)exec enable:(NSString *)enable marked:(NSString *)marked;
		[Export ("initWithName:user:parent:pos:pos_str:exec:enable:marked:")]
		IntPtr Constructor (string name, string user, string parent, int pos, string pos_str, string exec, string enable, string marked);

		// -(id)initWithMenu_item_config:(FSMenuItemConfig *)menu_item_config;
		[Export ("initWithMenu_item_config:")]
		IntPtr Constructor (FSMenuItemConfig menu_item_config);

		// -(void)set:(NSString *)name user:(NSString *)user parent:(NSString *)parent pos:(int)pos pos_str:(NSString *)pos_str exec:(NSString *)exec enable:(NSString *)enable marked:(NSString *)marked;
		[Export ("set:user:parent:pos:pos_str:exec:enable:marked:")]
		void Set (string name, string user, string parent, int pos, string pos_str, string exec, string enable, string marked);

		// -(void)dealloc;
		[Export ("dealloc")]
		void Dealloc ();
	}

	// @interface FSDialogDescriptionElementArray : NSObject
	[BaseType (typeof(NSObject))]
	interface FSDialogDescriptionElementArray
	{
		// -(void *)getCptr;
		[Export ("getCptr")]
		//[Verify (MethodToProperty)]
		IntPtr Cptr { get; }

		// -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
		[Export ("initWithCptr:swigOwnCObject:")]
		IntPtr Constructor (IntPtr cptr, bool ownCObject);

		// -(id)initWithOther:(FSDialogDescriptionElementArray *)other;
		[Export ("initWithOther:")]
		IntPtr Constructor (FSDialogDescriptionElementArray other);

		// -(unsigned long)getSize;
		[Export ("getSize")]
		//[Verify (MethodToProperty)]
		nuint Size { get; }

		// -(FSDialogDescriptionElement *)getAt:(unsigned long)index;
		[Export ("getAt:")]
		FSDialogDescriptionElement GetAt (nuint index);

		// -(void)add:(FSDialogDescriptionElement *)element;
		[Export ("add:")]
		void Add (FSDialogDescriptionElement element);

		// -(void)removeAt:(unsigned long)index;
		[Export ("removeAt:")]
		void RemoveAt (nuint index);

		// -(void)insertAt:(unsigned long)index element:(FSDialogDescriptionElement *)element;
		[Export ("insertAt:element:")]
		void InsertAt (nuint index, FSDialogDescriptionElement element);

		// -(void)removeAll;
		[Export ("removeAll")]
		void RemoveAll ();

		// -(void)dealloc;
		[Export ("dealloc")]
		void Dealloc ();
	}

	// @interface FSDialogDescriptionElement : NSObject
	[BaseType (typeof(NSObject))]
	interface FSDialogDescriptionElement
	{
		// @property (getter = getName, copy, nonatomic) NSString * name;
		[Export ("name")]
		string Name { [Bind ("getName")] get; set; }

		// @property (getter = getItem_id, copy, nonatomic) NSString * item_id;
		[Export ("item_id")]
		string Item_id { [Bind ("getItem_id")] get; set; }

		// @property (getter = getType, copy, nonatomic) NSString * type;
		[Export ("type")]
		string Type { [Bind ("getType")] get; set; }

		// @property (getter = getNext_tab, copy, nonatomic) NSString * next_tab;
		[Export ("next_tab")]
		string Next_tab { [Bind ("getNext_tab")] get; set; }

		// @property (getter = getWidth, nonatomic) int width;
		[Export ("width")]
		int Width { [Bind ("getWidth")] get; set; }

		// @property (getter = getHeight, nonatomic) int height;
		[Export ("height")]
		int Height { [Bind ("getHeight")] get; set; }

		// @property (getter = getChar_width, nonatomic) int char_width;
		[Export ("char_width")]
		int Char_width { [Bind ("getChar_width")] get; set; }

		// @property (getter = getChar_height, nonatomic) int char_height;
		[Export ("char_height")]
		int Char_height { [Bind ("getChar_height")] get; set; }

		// @property (getter = getFont, copy, nonatomic) NSString * font;
		[Export ("font")]
		string Font { [Bind ("getFont")] get; set; }

		// @property (getter = getBold, nonatomic) BOOL bold;
		[Export ("bold")]
		bool Bold { [Bind ("getBold")] get; set; }

		// @property (getter = getItalic, nonatomic) BOOL italic;
		[Export ("italic")]
		bool Italic { [Bind ("getItalic")] get; set; }

		// @property (getter = getAlignment, copy, nonatomic) NSString * alignment;
		[Export ("alignment")]
		string Alignment { [Bind ("getAlignment")] get; set; }

		// @property (getter = getAlign_children, copy, nonatomic) NSString * align_children;
		[Export ("align_children")]
		string Align_children { [Bind ("getAlign_children")] get; set; }

		// @property (getter = getElement_array, copy, nonatomic) FSDialogDescriptionElementArray * element_array;
		[Export ("element_array", ArgumentSemantic.Copy)]
		FSDialogDescriptionElementArray Element_array { [Bind ("getElement_array")] get; set; }

		// -(void *)getCptr;
		[Export ("getCptr")]
		//[Verify (MethodToProperty)]
		IntPtr Cptr { get; }

		// -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
		[Export ("initWithCptr:swigOwnCObject:")]
		IntPtr Constructor (IntPtr cptr, bool ownCObject);

		// -(id)initWithName:(NSString *)name item_id:(NSString *)item_id type:(NSString *)type next_tab:(NSString *)next_tab width:(int)width height:(int)height char_width:(int)char_width char_height:(int)char_height font:(NSString *)font bold:(BOOL)bold italic:(BOOL)italic alignment:(NSString *)alignment align_children:(NSString *)align_children element_array:(FSDialogDescriptionElementArray *)element_array;
		[Export ("initWithName:item_id:type:next_tab:width:height:char_width:char_height:font:bold:italic:alignment:align_children:element_array:")]
		IntPtr Constructor (string name, string item_id, string type, string next_tab, int width, int height, int char_width, int char_height, string font, bool bold, bool italic, string alignment, string align_children, FSDialogDescriptionElementArray element_array);

		// -(id)initWithDlg_des_element:(FSDialogDescriptionElement *)dlg_des_element;
		[Export ("initWithDlg_des_element:")]
		IntPtr Constructor (FSDialogDescriptionElement dlg_des_element);

		// -(void)set:(NSString *)name item_id:(NSString *)item_id type:(NSString *)type next_tab:(NSString *)next_tab width:(int)width height:(int)height char_width:(int)char_width char_height:(int)char_height font:(NSString *)font bold:(BOOL)bold italic:(BOOL)italic alignment:(NSString *)alignment align_children:(NSString *)align_children element_array:(FSDialogDescriptionElementArray *)element_array;
		[Export ("set:item_id:type:next_tab:width:height:char_width:char_height:font:bold:italic:alignment:align_children:element_array:")]
		void Set (string name, string item_id, string type, string next_tab, int width, int height, int char_width, int char_height, string font, bool bold, bool italic, string alignment, string align_children, FSDialogDescriptionElementArray element_array);

		// -(void)dealloc;
		[Export ("dealloc")]
		void Dealloc ();
	}

	// @interface FSDialogDescriptionConfig : NSObject
	[BaseType (typeof(NSObject))]
	interface FSDialogDescriptionConfig
	{
		// @property (getter = getName, copy, nonatomic) NSString * name;
		[Export ("name")]
		string Name { [Bind ("getName")] get; set; }

		// @property (getter = getFirst_tab, copy, nonatomic) NSString * first_tab;
		[Export ("first_tab")]
		string First_tab { [Bind ("getFirst_tab")] get; set; }

		// @property (getter = getWidth, nonatomic) int width;
		[Export ("width")]
		int Width { [Bind ("getWidth")] get; set; }

		// @property (getter = getHeight, nonatomic) int height;
		[Export ("height")]
		int Height { [Bind ("getHeight")] get; set; }

		// @property (getter = getChar_width, nonatomic) int char_width;
		[Export ("char_width")]
		int Char_width { [Bind ("getChar_width")] get; set; }

		// @property (getter = getChar_height, nonatomic) int char_height;
		[Export ("char_height")]
		int Char_height { [Bind ("getChar_height")] get; set; }

		// @property (getter = getAlign_children, copy, nonatomic) NSString * align_children;
		[Export ("align_children")]
		string Align_children { [Bind ("getAlign_children")] get; set; }

		// @property (getter = getElement_array, copy, nonatomic) FSDialogDescriptionElementArray * element_array;
		[Export ("element_array", ArgumentSemantic.Copy)]
		FSDialogDescriptionElementArray Element_array { [Bind ("getElement_array")] get; set; }

		// -(void *)getCptr;
		[Export ("getCptr")]
		//[Verify (MethodToProperty)]
		IntPtr Cptr { get; }

		// -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
		[Export ("initWithCptr:swigOwnCObject:")]
		IntPtr Constructor (IntPtr cptr, bool ownCObject);

		// -(id)initWithName:(NSString *)name first_tab:(NSString *)first_tab width:(int)width height:(int)height char_width:(int)char_width char_height:(int)char_height align_children:(NSString *)align_children element_array:(FSDialogDescriptionElementArray *)element_array;
		[Export ("initWithName:first_tab:width:height:char_width:char_height:align_children:element_array:")]
		IntPtr Constructor (string name, string first_tab, int width, int height, int char_width, int char_height, string align_children, FSDialogDescriptionElementArray element_array);

		// -(id)initWithDlg_des_config:(FSDialogDescriptionConfig *)dlg_des_config;
		[Export ("initWithDlg_des_config:")]
		IntPtr Constructor (FSDialogDescriptionConfig dlg_des_config);

		// -(void)set:(NSString *)name first_tab:(NSString *)first_tab width:(int)width height:(int)height char_width:(int)char_width char_height:(int)char_height align_children:(NSString *)align_children element_array:(FSDialogDescriptionElementArray *)element_array;
		[Export ("set:first_tab:width:height:char_width:char_height:align_children:element_array:")]
		void Set (string name, string first_tab, int width, int height, int char_width, int char_height, string align_children, FSDialogDescriptionElementArray element_array);

		// -(void)dealloc;
		[Export ("dealloc")]
		void Dealloc ();
	}

	// @interface FSSOAPAuthenticateInfo : NSObject
	[BaseType (typeof(NSObject))]
	interface FSSOAPAuthenticateInfo
	{
		// @property (getter = getUsername, copy, nonatomic) NSString * username;
		[Export ("username")]
		string Username { [Bind ("getUsername")] get; set; }

		// @property (getter = getPassword, copy, nonatomic) NSString * password;
		[Export ("password")]
		string Password { [Bind ("getPassword")] get; set; }

		// @property (getter = getIs_use_platform_auth, nonatomic) BOOL is_use_platform_auth;
		[Export ("is_use_platform_auth")]
		bool Is_use_platform_auth { [Bind ("getIs_use_platform_auth")] get; set; }

		// -(void *)getCptr;
		[Export ("getCptr")]
		//[Verify (MethodToProperty)]
		IntPtr Cptr { get; }

		// -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
		[Export ("initWithCptr:swigOwnCObject:")]
		IntPtr Constructor (IntPtr cptr, bool ownCObject);

		// -(id)initWithUsername:(NSString *)username password:(NSString *)password is_use_platform_auth:(BOOL)is_use_platform_auth;
		[Export ("initWithUsername:password:is_use_platform_auth:")]
		IntPtr Constructor (string username, string password, bool is_use_platform_auth);

		// -(id)initWithSoap_authenticate:(FSSOAPAuthenticateInfo *)soap_authenticate;
		[Export ("initWithSoap_authenticate:")]
		IntPtr Constructor (FSSOAPAuthenticateInfo soap_authenticate);

		// -(void)set:(NSString *)username password:(NSString *)password is_use_platform_auth:(BOOL)is_use_platform_auth;
		[Export ("set:password:is_use_platform_auth:")]
		void Set (string username, string password, bool is_use_platform_auth);

		// -(void)dealloc;
		[Export ("dealloc")]
		void Dealloc ();
	}

	// @interface FSSOAPRequestProperties : NSObject
	[BaseType (typeof(NSObject))]
	interface FSSOAPRequestProperties
	{
		// @property (getter = getRequest_url, copy, nonatomic) NSString * request_url;
		[Export ("request_url")]
		string Request_url { [Bind ("getRequest_url")] get; set; }

		// @property (getter = getRequest_content, copy, nonatomic) NSString * request_content;
		[Export ("request_content")]
		string Request_content { [Bind ("getRequest_content")] get; set; }

		// @property (getter = getSoap_action, copy, nonatomic) NSString * soap_action;
		[Export ("soap_action")]
		string Soap_action { [Bind ("getSoap_action")] get; set; }

		// @property (getter = getSoap_namespace, copy, nonatomic) NSString * soap_namespace;
		[Export ("soap_namespace")]
		string Soap_namespace { [Bind ("getSoap_namespace")] get; set; }

		// @property (getter = getSoap_version, copy, nonatomic) NSString * soap_version;
		[Export ("soap_version")]
		string Soap_version { [Bind ("getSoap_version")] get; set; }

		// @property (getter = getContent_type, copy, nonatomic) NSString * content_type;
		[Export ("content_type")]
		string Content_type { [Bind ("getContent_type")] get; set; }

		// @property (getter = getIs_encode, nonatomic) BOOL is_encode;
		[Export ("is_encode")]
		bool Is_encode { [Bind ("getIs_encode")] get; set; }

		// @property (getter = getIs_wiredump, nonatomic) BOOL is_wiredump;
		[Export ("is_wiredump")]
		bool Is_wiredump { [Bind ("getIs_wiredump")] get; set; }

		// @property (getter = getRequest_header, copy, nonatomic) NSString * request_header;
		[Export ("request_header")]
		string Request_header { [Bind ("getRequest_header")] get; set; }

		// @property (getter = getAuthenticate, copy, nonatomic) FSSOAPAuthenticateInfo * authenticate;
		[Export ("authenticate", ArgumentSemantic.Copy)]
		FSSOAPAuthenticateInfo Authenticate { [Bind ("getAuthenticate")] get; set; }

		// -(void *)getCptr;
		[Export ("getCptr")]
		//[Verify (MethodToProperty)]
		IntPtr Cptr { get; }

		// -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
		[Export ("initWithCptr:swigOwnCObject:")]
		IntPtr Constructor (IntPtr cptr, bool ownCObject);

		// -(id)initWithRequest_url:(NSString *)request_url request_content:(NSString *)request_content soap_action:(NSString *)soap_action soap_namespace:(NSString *)soap_namespace soap_version:(NSString *)soap_version content_type:(NSString *)content_type is_encode:(BOOL)is_encode is_wiredump:(BOOL)is_wiredump request_header:(NSString *)request_header authenticate:(FSSOAPAuthenticateInfo *)authenticate;
		[Export ("initWithRequest_url:request_content:soap_action:soap_namespace:soap_version:content_type:is_encode:is_wiredump:request_header:authenticate:")]
		IntPtr Constructor (string request_url, string request_content, string soap_action, string soap_namespace, string soap_version, string content_type, bool is_encode, bool is_wiredump, string request_header, FSSOAPAuthenticateInfo authenticate);

		// -(id)initWithRequest_properties:(FSSOAPRequestProperties *)request_properties;
		[Export ("initWithRequest_properties:")]
		IntPtr Constructor (FSSOAPRequestProperties request_properties);

		// -(void)set:(NSString *)request_url request_content:(NSString *)request_content soap_action:(NSString *)soap_action soap_namespace:(NSString *)soap_namespace soap_version:(NSString *)soap_version content_type:(NSString *)content_type is_encode:(BOOL)is_encode is_wiredump:(BOOL)is_wiredump request_header:(NSString *)request_header authenticate:(FSSOAPAuthenticateInfo *)authenticate;
		[Export ("set:request_content:soap_action:soap_namespace:soap_version:content_type:is_encode:is_wiredump:request_header:authenticate:")]
		void Set (string request_url, string request_content, string soap_action, string soap_namespace, string soap_version, string content_type, bool is_encode, bool is_wiredump, string request_header, FSSOAPAuthenticateInfo authenticate);

		// -(void)dealloc;
		[Export ("dealloc")]
		void Dealloc ();
	}

	// @interface FSSOAPResponseInfo : NSObject
	[BaseType (typeof(NSObject))]
	interface FSSOAPResponseInfo
	{
		// @property (getter = getResponse_header, copy, nonatomic) NSString * response_header;
		[Export ("response_header")]
		string Response_header { [Bind ("getResponse_header")] get; set; }

		// @property (getter = getResponse_body, copy, nonatomic) NSString * response_body;
		[Export ("response_body")]
		string Response_body { [Bind ("getResponse_body")] get; set; }

		// @property (getter = getNetwork_error, copy, nonatomic) NSString * network_error;
		[Export ("network_error")]
		string Network_error { [Bind ("getNetwork_error")] get; set; }

		// @property (getter = getStatus_code, nonatomic) unsigned int status_code;
		[Export ("status_code")]
		uint Status_code { [Bind ("getStatus_code")] get; set; }

		// -(void *)getCptr;
		[Export ("getCptr")]
		//[Verify (MethodToProperty)]
		IntPtr Cptr { get; }

		// -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
		[Export ("initWithCptr:swigOwnCObject:")]
		IntPtr Constructor (IntPtr cptr, bool ownCObject);

		// -(id)initWithResponse_header:(NSString *)response_header response_body:(NSString *)response_body network_error:(NSString *)network_error status_code:(unsigned int)status_code;
		[Export ("initWithResponse_header:response_body:network_error:status_code:")]
		IntPtr Constructor (string response_header, string response_body, string network_error, uint status_code);

		// -(id)initWithSoap_response:(FSSOAPResponseInfo *)soap_response;
		[Export ("initWithSoap_response:")]
		IntPtr Constructor (FSSOAPResponseInfo soap_response);

		// -(void)set:(NSString *)response_header response_body:(NSString *)response_body network_error:(NSString *)network_error status_code:(unsigned int)status_code;
		[Export ("set:response_body:network_error:status_code:")]
		void Set (string response_header, string response_body, string network_error, uint status_code);

		// -(void)dealloc;
		[Export ("dealloc")]
		void Dealloc ();
	}

	// @interface FSPrintParams : NSObject
	[BaseType (typeof(NSObject))]
	interface FSPrintParams
	{
		// @property (getter = getIs_show_ui, nonatomic) BOOL is_show_ui;
		[Export ("is_show_ui")]
		bool Is_show_ui { [Bind ("getIs_show_ui")] get; set; }

		// @property (getter = getIs_reverse, nonatomic) BOOL is_reverse;
		[Export ("is_reverse")]
		bool Is_reverse { [Bind ("getIs_reverse")] get; set; }

		// @property (getter = getIs_print_as_image, nonatomic) BOOL is_print_as_image;
		[Export ("is_print_as_image")]
		bool Is_print_as_image { [Bind ("getIs_print_as_image")] get; set; }

		// @property (getter = getIs_print_auto_center, nonatomic) BOOL is_print_auto_center;
		[Export ("is_print_auto_center")]
		bool Is_print_auto_center { [Bind ("getIs_print_auto_center")] get; set; }

		// @property (getter = getIs_print_auto_rotate, nonatomic) BOOL is_print_auto_rotate;
		[Export ("is_print_auto_rotate")]
		bool Is_print_auto_rotate { [Bind ("getIs_print_auto_rotate")] get; set; }

		// @property (getter = getIs_simulate_overprinting, nonatomic) BOOL is_simulate_overprinting;
		[Export ("is_simulate_overprinting")]
		bool Is_simulate_overprinting { [Bind ("getIs_simulate_overprinting")] get; set; }

		// @property (getter = getIs_print_page_border, nonatomic) BOOL is_print_page_border;
		[Export ("is_print_page_border")]
		bool Is_print_page_border { [Bind ("getIs_print_page_border")] get; set; }

		// @property (getter = getPage_range, copy, nonatomic) FSRange * page_range;
		[Export ("page_range", ArgumentSemantic.Copy)]
		FSRange Page_range { [Bind ("getPage_range")] get; set; }

		// @property (getter = getPrint_content, nonatomic) FSPrintParamsPrintContent print_content;
		[Export ("print_content", ArgumentSemantic.Assign)]
		FSPrintParamsPrintContent Print_content { [Bind ("getPrint_content")] get; set; }

		// @property (getter = getPrinter_name, copy, nonatomic) NSString * printer_name;
		[Export ("printer_name")]
		string Printer_name { [Bind ("getPrinter_name")] get; set; }

		// @property (getter = getOutput_file_name, copy, nonatomic) NSString * output_file_name;
		[Export ("output_file_name")]
		string Output_file_name { [Bind ("getOutput_file_name")] get; set; }

		// @property (getter = getNum_copies, nonatomic) int num_copies;
		[Export ("num_copies")]
		int Num_copies { [Bind ("getNum_copies")] get; set; }

		// @property (getter = getDuplex_type, nonatomic) FSPrintParamsDuplexType duplex_type;
		[Export ("duplex_type", ArgumentSemantic.Assign)]
		FSPrintParamsDuplexType Duplex_type { [Bind ("getDuplex_type")] get; set; }

		// @property (getter = getIs_tile_label, nonatomic) BOOL is_tile_label;
		[Export ("is_tile_label")]
		bool Is_tile_label { [Bind ("getIs_tile_label")] get; set; }

		// @property (getter = getTile_mark, nonatomic) BOOL tile_mark;
		[Export ("tile_mark")]
		bool Tile_mark { [Bind ("getTile_mark")] get; set; }

		// @property (getter = getTile_overlap, nonatomic) float tile_overlap;
		[Export ("tile_overlap")]
		float Tile_overlap { [Bind ("getTile_overlap")] get; set; }

		// @property (getter = getTile_scale, nonatomic) float tile_scale;
		[Export ("tile_scale")]
		float Tile_scale { [Bind ("getTile_scale")] get; set; }

		// @property (getter = getHandling, nonatomic) FSPrintParamsPrintHandling handling;
		[Export ("handling", ArgumentSemantic.Assign)]
		FSPrintParamsPrintHandling Handling { [Bind ("getHandling")] get; set; }

		// @property (getter = getBinding, nonatomic) FSPrintParamsBookletBinding binding;
		[Export ("binding", ArgumentSemantic.Assign)]
		FSPrintParamsBookletBinding Binding { [Bind ("getBinding")] get; set; }

		// @property (getter = getBooklet_duplex_mode, nonatomic) FSPrintParamsBookletDuplexMode booklet_duplex_mode;
		[Export ("booklet_duplex_mode", ArgumentSemantic.Assign)]
		FSPrintParamsBookletDuplexMode Booklet_duplex_mode { [Bind ("getBooklet_duplex_mode")] get; set; }

		// @property (getter = getNum_pages_h, nonatomic) int num_pages_h;
		[Export ("num_pages_h")]
		int Num_pages_h { [Bind ("getNum_pages_h")] get; set; }

		// @property (getter = getNum_pages_v, nonatomic) int num_pages_v;
		[Export ("num_pages_v")]
		int Num_pages_v { [Bind ("getNum_pages_v")] get; set; }

		// @property (getter = getPage_order, nonatomic) FSPrintParamsPageOrder page_order;
		[Export ("page_order", ArgumentSemantic.Assign)]
		FSPrintParamsPageOrder Page_order { [Bind ("getPage_order")] get; set; }

		// -(void *)getCptr;
		[Export ("getCptr")]
		//[Verify (MethodToProperty)]
		IntPtr Cptr { get; }

		// -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
		[Export ("initWithCptr:swigOwnCObject:")]
		IntPtr Constructor (IntPtr cptr, bool ownCObject);

		// -(id)initWithPrint_params:(FSPrintParams *)print_params;
		[Export ("initWithPrint_params:")]
		IntPtr Constructor (FSPrintParams print_params);

		// -(void)dealloc;
		[Export ("dealloc")]
		void Dealloc ();
	}

	// @interface FSFloatingInfo : NSObject
	[BaseType (typeof(NSObject))]
	interface FSFloatingInfo
	{
		// @property (getter = getWindow_pos, nonatomic) FSFloatingInfoWindowPosition window_pos;
		[Export ("window_pos", ArgumentSemantic.Assign)]
		FSFloatingInfoWindowPosition Window_pos { [Bind ("getWindow_pos")] get; set; }

		// @property (getter = getRelative_target, nonatomic) FSFloatingInfoRelativeTarget relative_target;
		[Export ("relative_target", ArgumentSemantic.Assign)]
		FSFloatingInfoRelativeTarget Relative_target { [Bind ("getRelative_target")] get; set; }

		// @property (getter = getResize_type, nonatomic) FSFloatingInfoResizeType resize_type;
		[Export ("resize_type", ArgumentSemantic.Assign)]
		FSFloatingInfoResizeType Resize_type { [Bind ("getResize_type")] get; set; }

		// @property (getter = getHas_close, nonatomic) BOOL has_close;
		[Export ("has_close")]
		bool Has_close { [Bind ("getHas_close")] get; set; }

		// @property (getter = getHas_title, nonatomic) BOOL has_title;
		[Export ("has_title")]
		bool Has_title { [Bind ("getHas_title")] get; set; }

		// @property (getter = getTitle, copy, nonatomic) NSString * title;
		[Export ("title")]
		string Title { [Bind ("getTitle")] get; set; }

		// @property (getter = getOff_screen, nonatomic) FSFloatingInfoOffScreenAction off_screen;
		[Export ("off_screen", ArgumentSemantic.Assign)]
		FSFloatingInfoOffScreenAction Off_screen { [Bind ("getOff_screen")] get; set; }

		// @property (getter = getRect, copy, nonatomic) FSRectF * rect;
		[Export ("rect", ArgumentSemantic.Copy)]
		FSRectF Rect { [Bind ("getRect")] get; set; }

		// -(void *)getCptr;
		[Export ("getCptr")]
		//[Verify (MethodToProperty)]
		IntPtr Cptr { get; }

		// -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
		[Export ("initWithCptr:swigOwnCObject:")]
		IntPtr Constructor (IntPtr cptr, bool ownCObject);

		// -(id)initWithWindow_pos:(FSFloatingInfoWindowPosition)window_pos relative_target:(FSFloatingInfoRelativeTarget)relative_target resize_type:(FSFloatingInfoResizeType)resize_type has_close:(BOOL)has_close has_title:(BOOL)has_title title:(NSString *)title off_screen:(FSFloatingInfoOffScreenAction)off_screen rect:(FSRectF *)rect;
		[Export ("initWithWindow_pos:relative_target:resize_type:has_close:has_title:title:off_screen:rect:")]
		IntPtr Constructor (FSFloatingInfoWindowPosition window_pos, FSFloatingInfoRelativeTarget relative_target, FSFloatingInfoResizeType resize_type, bool has_close, bool has_title, string title, FSFloatingInfoOffScreenAction off_screen, FSRectF rect);

		// -(id)initWithFloating_info:(FSFloatingInfo *)floating_info;
		[Export ("initWithFloating_info:")]
		IntPtr Constructor (FSFloatingInfo floating_info);

		// -(void)set:(FSFloatingInfoWindowPosition)window_pos relative_target:(FSFloatingInfoRelativeTarget)relative_target resize_type:(FSFloatingInfoResizeType)resize_type has_close:(BOOL)has_close has_title:(BOOL)has_title title:(NSString *)title off_screen:(FSFloatingInfoOffScreenAction)off_screen rect:(FSRectF *)rect;
		[Export ("set:relative_target:resize_type:has_close:has_title:title:off_screen:rect:")]
		void Set (FSFloatingInfoWindowPosition window_pos, FSFloatingInfoRelativeTarget relative_target, FSFloatingInfoResizeType resize_type, bool has_close, bool has_title, string title, FSFloatingInfoOffScreenAction off_screen, FSRectF rect);

		// -(void)dealloc;
		[Export ("dealloc")]
		void Dealloc ();
	}

	// @interface FSMediaSettings : NSObject
	[BaseType (typeof(NSObject))]
	interface FSMediaSettings
	{
		// @property (getter = getAuto_play, nonatomic) BOOL auto_play;
		[Export ("auto_play")]
		bool Auto_play { [Bind ("getAuto_play")] get; set; }

		// @property (getter = getBase_url, copy, nonatomic) NSString * base_url;
		[Export ("base_url")]
		string Base_url { [Bind ("getBase_url")] get; set; }

		// @property (getter = getBg_color, nonatomic) unsigned int bg_color;
		[Export ("bg_color")]
		uint Bg_color { [Bind ("getBg_color")] get; set; }

		// @property (getter = getBg_opacity, nonatomic) float bg_opacity;
		[Export ("bg_opacity")]
		float Bg_opacity { [Bind ("getBg_opacity")] get; set; }

		// @property (getter = getDuration, nonatomic) int duration;
		[Export ("duration")]
		int Duration { [Bind ("getDuration")] get; set; }

		// @property (getter = getPage, nonatomic) int page;
		[Export ("page")]
		int Page { [Bind ("getPage")] get; set; }

		// @property (getter = getRepeat, nonatomic) int repeat;
		[Export ("repeat")]
		int Repeat { [Bind ("getRepeat")] get; set; }

		// @property (getter = getShow_ui, nonatomic) BOOL show_ui;
		[Export ("show_ui")]
		bool Show_ui { [Bind ("getShow_ui")] get; set; }

		// @property (getter = getIs_visible, nonatomic) BOOL is_visible;
		[Export ("is_visible")]
		bool Is_visible { [Bind ("getIs_visible")] get; set; }

		// @property (getter = getVolume, nonatomic) int volume;
		[Export ("volume")]
		int Volume { [Bind ("getVolume")] get; set; }

		// @property (getter = getWindow_type, nonatomic) FSMediaSettingsPlayerWindowType window_type;
		[Export ("window_type", ArgumentSemantic.Assign)]
		FSMediaSettingsPlayerWindowType Window_type { [Bind ("getWindow_type")] get; set; }

		// @property (getter = getFloating_wnd_info, copy, nonatomic) FSFloatingInfo * floating_wnd_info;
		[Export ("floating_wnd_info", ArgumentSemantic.Copy)]
		FSFloatingInfo Floating_wnd_info { [Bind ("getFloating_wnd_info")] get; set; }

		// -(void *)getCptr;
		[Export ("getCptr")]
		//[Verify (MethodToProperty)]
		IntPtr Cptr { get; }

		// -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
		[Export ("initWithCptr:swigOwnCObject:")]
		IntPtr Constructor (IntPtr cptr, bool ownCObject);

		// -(id)initWithAuto_play:(BOOL)auto_play base_url:(NSString *)base_url bg_color:(unsigned int)bg_color bg_opacity:(float)bg_opacity duration:(int)duration page:(int)page repeat:(int)repeat show_ui:(BOOL)show_ui is_visible:(BOOL)is_visible volume:(int)volume window_type:(FSMediaSettingsPlayerWindowType)window_type floating_wnd_info:(FSFloatingInfo *)floating_wnd_info;
		[Export ("initWithAuto_play:base_url:bg_color:bg_opacity:duration:page:repeat:show_ui:is_visible:volume:window_type:floating_wnd_info:")]
		IntPtr Constructor (bool auto_play, string base_url, uint bg_color, float bg_opacity, int duration, int page, int repeat, bool show_ui, bool is_visible, int volume, FSMediaSettingsPlayerWindowType window_type, FSFloatingInfo floating_wnd_info);

		// -(id)initWithMedia_settings:(FSMediaSettings *)media_settings;
		[Export ("initWithMedia_settings:")]
		IntPtr Constructor (FSMediaSettings media_settings);

		// -(void)set:(BOOL)auto_play base_url:(NSString *)base_url bg_color:(unsigned int)bg_color bg_opacity:(float)bg_opacity duration:(int)duration page:(int)page repeat:(int)repeat show_ui:(BOOL)show_ui is_visible:(BOOL)is_visible volume:(int)volume window_type:(FSMediaSettingsPlayerWindowType)window_type floating_wnd_info:(FSFloatingInfo *)floating_wnd_info;
		[Export ("set:base_url:bg_color:bg_opacity:duration:page:repeat:show_ui:is_visible:volume:window_type:floating_wnd_info:")]
		void Set (bool auto_play, string base_url, uint bg_color, float bg_opacity, int duration, int page, int repeat, bool show_ui, bool is_visible, int volume, FSMediaSettingsPlayerWindowType window_type, FSFloatingInfo floating_wnd_info);

		// -(void)dealloc;
		[Export ("dealloc")]
		void Dealloc ();
	}

	// @interface FSPlayerArgs : NSObject
	[BaseType (typeof(NSObject))]
	interface FSPlayerArgs
	{
		// @property (getter = getDoc, copy, nonatomic) FSPDFDoc * doc;
		[Export ("doc", ArgumentSemantic.Copy)]
		FSPDFDoc Doc { [Bind ("getDoc")] get; set; }

		// @property (getter = getScreen_annot, copy, nonatomic) FSScreen * screen_annot;
		[Export ("screen_annot", ArgumentSemantic.Copy)]
		FSScreen Screen_annot { [Bind ("getScreen_annot")] get; set; }

		// @property (getter = getRendition, copy, nonatomic) FSRendition * rendition;
		[Export ("rendition", ArgumentSemantic.Copy)]
		FSRendition Rendition { [Bind ("getRendition")] get; set; }

		// @property (getter = getURL, copy, nonatomic) NSString * uRL;
		[Export ("uRL")]
		string URL { [Bind ("getURL")] get; set; }

		// @property (getter = getAudio_format, copy, nonatomic) NSString * audio_format;
		[Export ("audio_format")]
		string Audio_format { [Bind ("getAudio_format")] get; set; }

		// @property (getter = getPlayer_settings, copy, nonatomic) FSMediaSettings * player_settings;
		[Export ("player_settings", ArgumentSemantic.Copy)]
		FSMediaSettings Player_settings { [Bind ("getPlayer_settings")] get; set; }

		// -(void *)getCptr;
		[Export ("getCptr")]
		//[Verify (MethodToProperty)]
		IntPtr Cptr { get; }

		// -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
		[Export ("initWithCptr:swigOwnCObject:")]
		IntPtr Constructor (IntPtr cptr, bool ownCObject);

		// -(id)initWithDoc:(FSPDFDoc *)doc screen_annot:(FSScreen *)screen_annot rendition:(FSRendition *)rendition URL:(NSString *)URL audio_format:(NSString *)audio_format player_settings:(FSMediaSettings *)player_settings;
		[Export ("initWithDoc:screen_annot:rendition:URL:audio_format:player_settings:")]
		IntPtr Constructor (FSPDFDoc doc, FSScreen screen_annot, FSRendition rendition, string URL, string audio_format, FSMediaSettings player_settings);

		// -(id)initWithPlayer_args:(FSPlayerArgs *)player_args;
		[Export ("initWithPlayer_args:")]
		IntPtr Constructor (FSPlayerArgs player_args);

		// -(void)set:(FSPDFDoc *)doc screen_annot:(FSScreen *)screen_annot rendition:(FSRendition *)rendition URL:(NSString *)URL audio_format:(NSString *)audio_format player_settings:(FSMediaSettings *)player_settings;
		[Export ("set:screen_annot:rendition:URL:audio_format:player_settings:")]
		void Set (FSPDFDoc doc, FSScreen screen_annot, FSRendition rendition, string URL, string audio_format, FSMediaSettings player_settings);

		// -(void)dealloc;
		[Export ("dealloc")]
		void Dealloc ();
	}

	// @interface FSSearchOption : NSObject
	[BaseType (typeof(NSObject))]
	interface FSSearchOption
	{
		// @property (getter = getIs_whole_word, nonatomic) BOOL is_whole_word;
		[Export ("is_whole_word")]
		bool Is_whole_word { [Bind ("getIs_whole_word")] get; set; }

		// @property (getter = getIs_case_sensitive, nonatomic) BOOL is_case_sensitive;
		[Export ("is_case_sensitive")]
		bool Is_case_sensitive { [Bind ("getIs_case_sensitive")] get; set; }

		// @property (getter = getIs_search_bookmarks, nonatomic) BOOL is_search_bookmarks;
		[Export ("is_search_bookmarks")]
		bool Is_search_bookmarks { [Bind ("getIs_search_bookmarks")] get; set; }

		// @property (getter = getIs_search_in_markup, nonatomic) BOOL is_search_in_markup;
		[Export ("is_search_in_markup")]
		bool Is_search_in_markup { [Bind ("getIs_search_in_markup")] get; set; }

		// @property (getter = getIs_search_in_attachments, nonatomic) BOOL is_search_in_attachments;
		[Export ("is_search_in_attachments")]
		bool Is_search_in_attachments { [Bind ("getIs_search_in_attachments")] get; set; }

		// @property (getter = getIs_ignore_accents, nonatomic) BOOL is_ignore_accents;
		[Export ("is_ignore_accents")]
		bool Is_ignore_accents { [Bind ("getIs_ignore_accents")] get; set; }

		// @property (getter = getIs_proximity, nonatomic) BOOL is_proximity;
		[Export ("is_proximity")]
		bool Is_proximity { [Bind ("getIs_proximity")] get; set; }

		// @property (getter = getIs_stemming, nonatomic) BOOL is_stemming;
		[Export ("is_stemming")]
		bool Is_stemming { [Bind ("getIs_stemming")] get; set; }

		// @property (getter = getIs_ignore_full_width, nonatomic) BOOL is_ignore_full_width;
		[Export ("is_ignore_full_width")]
		bool Is_ignore_full_width { [Bind ("getIs_ignore_full_width")] get; set; }

		// @property (getter = getMax_docs, nonatomic) int max_docs;
		[Export ("max_docs")]
		int Max_docs { [Bind ("getMax_docs")] get; set; }

		// @property (getter = getWord_matching, nonatomic) FSSearchOptionWordMatching word_matching;
		[Export ("word_matching", ArgumentSemantic.Assign)]
		FSSearchOptionWordMatching Word_matching { [Bind ("getWord_matching")] get; set; }

		// @property (getter = getIs_search_doc_text, nonatomic) BOOL is_search_doc_text;
		[Export ("is_search_doc_text")]
		bool Is_search_doc_text { [Bind ("getIs_search_doc_text")] get; set; }

		// -(void *)getCptr;
		[Export ("getCptr")]
		//[Verify (MethodToProperty)]
		IntPtr Cptr { get; }

		// -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
		[Export ("initWithCptr:swigOwnCObject:")]
		IntPtr Constructor (IntPtr cptr, bool ownCObject);

		// -(id)initWithIs_whole_word:(BOOL)is_whole_word is_case_sensitive:(BOOL)is_case_sensitive is_search_bookmarks:(BOOL)is_search_bookmarks is_search_in_marup:(BOOL)is_search_in_marup is_search_in_attachments:(BOOL)is_search_in_attachments is_ignore_accents:(BOOL)is_ignore_accents is_proximity:(BOOL)is_proximity is_stemming:(BOOL)is_stemming is_ignore_full_width:(BOOL)is_ignore_full_width max_docs:(int)max_docs word_matching:(FSSearchOptionWordMatching)word_matching is_search_doc_text:(BOOL)is_search_doc_text;
		[Export ("initWithIs_whole_word:is_case_sensitive:is_search_bookmarks:is_search_in_marup:is_search_in_attachments:is_ignore_accents:is_proximity:is_stemming:is_ignore_full_width:max_docs:word_matching:is_search_doc_text:")]
		IntPtr Constructor (bool is_whole_word, bool is_case_sensitive, bool is_search_bookmarks, bool is_search_in_marup, bool is_search_in_attachments, bool is_ignore_accents, bool is_proximity, bool is_stemming, bool is_ignore_full_width, int max_docs, FSSearchOptionWordMatching word_matching, bool is_search_doc_text);

		// -(id)initWithSearch_option:(FSSearchOption *)search_option;
		[Export ("initWithSearch_option:")]
		IntPtr Constructor (FSSearchOption search_option);

		// -(void)set:(BOOL)is_whole_word is_case_sensitive:(BOOL)is_case_sensitive is_search_bookmarks:(BOOL)is_search_bookmarks is_search_in_marup:(BOOL)is_search_in_marup is_search_in_attachments:(BOOL)is_search_in_attachments is_ignore_accents:(BOOL)is_ignore_accents is_proximity:(BOOL)is_proximity is_stemming:(BOOL)is_stemming is_ignore_full_width:(BOOL)is_ignore_full_width max_docs:(int)max_docs word_matching:(FSSearchOptionWordMatching)word_matching is_search_doc_text:(BOOL)is_search_doc_text;
		[Export ("set:is_case_sensitive:is_search_bookmarks:is_search_in_marup:is_search_in_attachments:is_ignore_accents:is_proximity:is_stemming:is_ignore_full_width:max_docs:word_matching:is_search_doc_text:")]
		void Set (bool is_whole_word, bool is_case_sensitive, bool is_search_bookmarks, bool is_search_in_marup, bool is_search_in_attachments, bool is_ignore_accents, bool is_proximity, bool is_stemming, bool is_ignore_full_width, int max_docs, FSSearchOptionWordMatching word_matching, bool is_search_doc_text);

		// -(void)dealloc;
		[Export ("dealloc")]
		void Dealloc ();
	}

	// @interface FSSearchIndexConfig : NSObject
	[BaseType (typeof(NSObject))]
	interface FSSearchIndexConfig
	{
		// @property (getter = getName, copy, nonatomic) NSString * name;
		[Export ("name")]
		string Name { [Bind ("getName")] get; set; }

		// @property (getter = getIs_available, nonatomic) BOOL is_available;
		[Export ("is_available")]
		bool Is_available { [Bind ("getIs_available")] get; set; }

		// @property (getter = getPath, copy, nonatomic) NSString * path;
		[Export ("path")]
		string Path { [Bind ("getPath")] get; set; }

		// @property (getter = getIs_selected, nonatomic) BOOL is_selected;
		[Export ("is_selected")]
		bool Is_selected { [Bind ("getIs_selected")] get; set; }

		// -(void *)getCptr;
		[Export ("getCptr")]
		//[Verify (MethodToProperty)]
		IntPtr Cptr { get; }

		// -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
		[Export ("initWithCptr:swigOwnCObject:")]
		IntPtr Constructor (IntPtr cptr, bool ownCObject);

		// -(id)initWithName:(NSString *)name is_available:(BOOL)is_available path:(NSString *)path is_selected:(BOOL)is_selected;
		[Export ("initWithName:is_available:path:is_selected:")]
		IntPtr Constructor (string name, bool is_available, string path, bool is_selected);

		// -(id)initWithSearch_index_config:(FSSearchIndexConfig *)search_index_config;
		[Export ("initWithSearch_index_config:")]
		IntPtr Constructor (FSSearchIndexConfig search_index_config);

		// -(void)set:(NSString *)name is_available:(BOOL)is_available path:(NSString *)path is_selected:(BOOL)is_selected;
		[Export ("set:is_available:path:is_selected:")]
		void Set (string name, bool is_available, string path, bool is_selected);

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
		FSProgressive StartUpdateIndex (FSDocumentsSource source, NSObject pause, bool reupdate);

		// -(FSProgressive *)startUpdateIndex:(FSDocumentsSource *)source pause:(id<FSPauseCallback>)pause;
		[Export ("startUpdateIndex:pause:")]
		FSProgressive StartUpdateIndex (FSDocumentsSource source, NSObject pause);

		// -(FSProgressive *)startUpdateIndex:(FSDocumentsSource *)source;
		[Export ("startUpdateIndex:")]
		FSProgressive StartUpdateIndex (FSDocumentsSource source);

		// -(BOOL)updateIndexWithFilePath:(NSString *)file_path;
		[Export ("updateIndexWithFilePath:")]
		bool UpdateIndexWithFilePath (string file_path);

		// -(BOOL)searchOf:(NSString *)match_string rank_mode:(FSFullTextSearchRankMode)rank_mode callback:(id<FSSearchCallback>)callback;
		[Export ("searchOf:rank_mode:callback:")]
		bool SearchOf (string match_string, FSFullTextSearchRankMode rank_mode, NSObject callback);

		// -(void)dealloc;
		[Export ("dealloc")]
		void Dealloc ();
	}

	// @interface FSPDFNameTree : FSBase
	[BaseType (typeof(FSBase))]
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

		// -(void)destroy;
		[Export ("destroy")]
		void Destroy ();

		// -(FSPDFObject *)cloneObject;
		[Export ("cloneObject")]
		//[Verify (MethodToProperty)]
		FSPDFObject CloneObject { get; }

		// -(FSPDFObject *)deepCloneObject;
		[Export ("deepCloneObject")]
		//[Verify (MethodToProperty)]
		FSPDFObject DeepCloneObject { get; }

		// -(BOOL)isIdentical:(FSPDFObject *)pdf_obj;
		[Export ("isIdentical:")]
		bool IsIdentical (FSPDFObject pdf_obj);

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

		// -(NSData *)getString;
		[Export ("getString")]
		//[Verify (MethodToProperty)]
		NSData String { get; }

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
		void ImportData (NSObject file_read, FSPDFStreamFilter stream_filter);

		// -(id<FSFileReaderCallback>)exportData:(BOOL)is_raw_data;
		[Export ("exportData:")]
		NSObject ExportData (bool is_raw_data);

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

		// -(long)moveNext:(long)position;
		[Export ("moveNext:")]
		nint MoveNext (nint position);

		// -(NSString *)getKey:(long)position;
		[Export ("getKey:")]
		string GetKey (nint position);

		// -(FSPDFObject *)getValue:(long)position;
		[Export ("getValue:")]
		FSPDFObject GetValue (nint position);

		// -(void)setAt:(NSString *)key pdf_object:(FSPDFObject *)pdf_object;
		[Export ("setAt:pdf_object:")]
		void SetAt (string key, FSPDFObject pdf_object);

		// -(void)setAtReference:(NSString *)key pdf_object:(FSPDFObject *)pdf_object document:(FSPDFDoc *)document;
		[Export ("setAtReference:pdf_object:document:")]
		void SetAtReference (string key, FSPDFObject pdf_object, FSPDFDoc document);

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
		// @property (getter = getRenditionName, copy, nonatomic) NSString * renditionName;
		[Export ("renditionName")]
		string RenditionName { [Bind ("getRenditionName")] get; set; }

		// @property (getter = getMediaClipName, copy, nonatomic) NSString * mediaClipName;
		[Export ("mediaClipName")]
		string MediaClipName { [Bind ("getMediaClipName")] get; set; }

		// @property (getter = getMediaClipFile, copy, nonatomic) FSFileSpec * mediaClipFile;
		[Export ("mediaClipFile", ArgumentSemantic.Copy)]
		FSFileSpec MediaClipFile { [Bind ("getMediaClipFile")] get; set; }

		// @property (getter = getMediaClipContentType, copy, nonatomic) NSString * mediaClipContentType;
		[Export ("mediaClipContentType")]
		string MediaClipContentType { [Bind ("getMediaClipContentType")] get; set; }

		// @property (getter = getPermission, nonatomic) FSRenditionMediaPermission permission;
		[Export ("permission", ArgumentSemantic.Assign)]
		FSRenditionMediaPermission Permission { [Bind ("getPermission")] get; set; }

		// @property (getter = getMediaDescriptions, copy, nonatomic) NSArray<NSString *> * mediaDescriptions;
		[Export ("mediaDescriptions", ArgumentSemantic.Copy)]
		string[] MediaDescriptions { [Bind ("getMediaDescriptions")] get; set; }

		// @property (getter = getMediaBaseURL, copy, nonatomic) NSString * mediaBaseURL;
		[Export ("mediaBaseURL")]
		string MediaBaseURL { [Bind ("getMediaBaseURL")] get; set; }

		// @property (getter = getVolume, nonatomic) int volume;
		[Export ("volume")]
		int Volume { [Bind ("getVolume")] get; set; }

		// @property (getter = getFitStyle, nonatomic) FSRenditionMediaPlayerFitStyle fitStyle;
		[Export ("fitStyle", ArgumentSemantic.Assign)]
		FSRenditionMediaPlayerFitStyle FitStyle { [Bind ("getFitStyle")] get; set; }

		// @property (getter = getDuration, nonatomic) int duration;
		[Export ("duration")]
		int Duration { [Bind ("getDuration")] get; set; }

		// @property (getter = getRepeatCount, nonatomic) int repeatCount;
		[Export ("repeatCount")]
		int RepeatCount { [Bind ("getRepeatCount")] get; set; }

		// @property (getter = getWindowType, nonatomic) FSRenditionWindowType windowType;
		[Export ("windowType", ArgumentSemantic.Assign)]
		FSRenditionWindowType WindowType { [Bind ("getWindowType")] get; set; }

		// @property (getter = getBackgroundColor, nonatomic) unsigned int backgroundColor;
		[Export ("backgroundColor")]
		uint BackgroundColor { [Bind ("getBackgroundColor")] get; set; }

		// @property (getter = getBackgroundOpacity, nonatomic) float backgroundOpacity;
		[Export ("backgroundOpacity")]
		float BackgroundOpacity { [Bind ("getBackgroundOpacity")] get; set; }

		// @property (getter = getMonitorSpecifier, nonatomic) FSRenditionMonitorSpecifier monitorSpecifier;
		[Export ("monitorSpecifier", ArgumentSemantic.Assign)]
		FSRenditionMonitorSpecifier MonitorSpecifier { [Bind ("getMonitorSpecifier")] get; set; }

		// @property (getter = getFloatingWindowRelatedWindowType, nonatomic) FSRenditionFloatingWindowRelatedWindowType floatingWindowRelatedWindowType;
		[Export ("floatingWindowRelatedWindowType", ArgumentSemantic.Assign)]
		FSRenditionFloatingWindowRelatedWindowType FloatingWindowRelatedWindowType { [Bind ("getFloatingWindowRelatedWindowType")] get; set; }

		// @property (getter = getFloatingWindowPosition, nonatomic) FSPosition floatingWindowPosition;
		[Export ("floatingWindowPosition", ArgumentSemantic.Assign)]
		FSPosition FloatingWindowPosition { [Bind ("getFloatingWindowPosition")] get; set; }

		// @property (getter = getFloatingWindowOffscreenEvent, nonatomic) FSRenditionFloatingWindowOffscreenEvent floatingWindowOffscreenEvent;
		[Export ("floatingWindowOffscreenEvent", ArgumentSemantic.Assign)]
		FSRenditionFloatingWindowOffscreenEvent FloatingWindowOffscreenEvent { [Bind ("getFloatingWindowOffscreenEvent")] get; set; }

		// @property (getter = getFloatingWindowResizeType, nonatomic) FSRenditionFloatingWindowResizeType floatingWindowResizeType;
		[Export ("floatingWindowResizeType", ArgumentSemantic.Assign)]
		FSRenditionFloatingWindowResizeType FloatingWindowResizeType { [Bind ("getFloatingWindowResizeType")] get; set; }

		// @property (getter = getFloatingWindowTitles, copy, nonatomic) NSArray<NSString *> * floatingWindowTitles;
		[Export ("floatingWindowTitles", ArgumentSemantic.Copy)]
		string[] FloatingWindowTitles { [Bind ("getFloatingWindowTitles")] get; set; }

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

		// -(id)initWithPdf_doc:(FSPDFDoc *)pdf_doc;
		[Export ("initWithPdf_doc:")]
		IntPtr Constructor (FSPDFDoc pdf_doc);

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

		// -(void)enableControlBarVisible:(BOOL)is_visible;
		[Export ("enableControlBarVisible:")]
		void EnableControlBarVisible (bool is_visible);

		// -(void)setFitStyle:(FSRenditionMediaPlayerFitStyle)fit_style opt_type:(FSRenditionMediaOptionType)opt_type;
		[Export ("setFitStyle:opt_type:")]
		void SetFitStyle (FSRenditionMediaPlayerFitStyle fit_style, FSRenditionMediaOptionType opt_type);

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

		// -(void)enableAutoPlay:(BOOL)is_auto_play;
		[Export ("enableAutoPlay:")]
		void EnableAutoPlay (bool is_auto_play);

		// -(void)setRepeatCount:(int)count opt_type:(FSRenditionMediaOptionType)opt_type;
		[Export ("setRepeatCount:opt_type:")]
		void SetRepeatCount (int count, FSRenditionMediaOptionType opt_type);

		// -(void)setWindowType:(FSRenditionWindowType)window_type opt_type:(FSRenditionMediaOptionType)opt_type;
		[Export ("setWindowType:opt_type:")]
		void SetWindowType (FSRenditionWindowType window_type, FSRenditionMediaOptionType opt_type);

		// -(void)setBackgroundColor:(unsigned int)color opt_type:(FSRenditionMediaOptionType)opt_type;
		[Export ("setBackgroundColor:opt_type:")]
		void SetBackgroundColor (uint color, FSRenditionMediaOptionType opt_type);

		// -(void)setBackgroundOpacity:(float)opacity opt_type:(FSRenditionMediaOptionType)opt_type;
		[Export ("setBackgroundOpacity:opt_type:")]
		void SetBackgroundOpacity (float opacity, FSRenditionMediaOptionType opt_type);

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

		// -(void)setFloatingWindowSize:(int)width height:(int)height;
		[Export ("setFloatingWindowSize:height:")]
		void SetFloatingWindowSize (int width, int height);

		// -(void)setFloatingWindowRelatedWindowType:(FSRenditionFloatingWindowRelatedWindowType)window_type opt_type:(FSRenditionMediaOptionType)opt_type;
		[Export ("setFloatingWindowRelatedWindowType:opt_type:")]
		void SetFloatingWindowRelatedWindowType (FSRenditionFloatingWindowRelatedWindowType window_type, FSRenditionMediaOptionType opt_type);

		// -(void)setFloatingWindowPosition:(FSPosition)position opt_type:(FSRenditionMediaOptionType)opt_type;
		[Export ("setFloatingWindowPosition:opt_type:")]
		void SetFloatingWindowPosition (FSPosition position, FSRenditionMediaOptionType opt_type);

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

		// -(void)enableFloatingWindowTitleBar:(BOOL)is_visible;
		[Export ("enableFloatingWindowTitleBar:")]
		void EnableFloatingWindowTitleBar (bool is_visible);

		// -(BOOL)hasFloatingWindowCloseButton;
		[Export ("hasFloatingWindowCloseButton")]
		//[Verify (MethodToProperty)]
		bool HasFloatingWindowCloseButton { get; }

		// -(void)enableFloatingWindowCloseButton:(BOOL)is_visible opt_type:(FSRenditionMediaOptionType)opt_type;
		[Export ("enableFloatingWindowCloseButton:opt_type:")]
		void EnableFloatingWindowCloseButton (bool is_visible, FSRenditionMediaOptionType opt_type);

		// -(void)enableFloatingWindowCloseButton:(BOOL)is_visible;
		[Export ("enableFloatingWindowCloseButton:")]
		void EnableFloatingWindowCloseButton (bool is_visible);

		// -(void)setFloatingWindowResizeType:(FSRenditionFloatingWindowResizeType)resize_type opt_type:(FSRenditionMediaOptionType)opt_type;
		[Export ("setFloatingWindowResizeType:opt_type:")]
		void SetFloatingWindowResizeType (FSRenditionFloatingWindowResizeType resize_type, FSRenditionMediaOptionType opt_type);

		// -(void)setFloatingWindowTitles:(NSArray<NSString *> *)titles opt_type:(FSRenditionMediaOptionType)opt_type;
		[Export ("setFloatingWindowTitles:opt_type:")]
		void SetFloatingWindowTitles (string[] titles, FSRenditionMediaOptionType opt_type);

		// -(void)dealloc;
		[Export ("dealloc")]
		void Dealloc ();
	}

	// @interface FSMediaPlayer : FSBase
	[BaseType (typeof(FSBase))]
	interface FSMediaPlayer
	{
		// @property (getter = getSoftwareURI, copy, nonatomic) NSString * softwareURI;
		[Export ("softwareURI")]
		string SoftwareURI { [Bind ("getSoftwareURI")] get; set; }

		// @property (getter = getOSIdentifiers, copy, nonatomic) NSArray<NSData *> * oSIdentifiers;
		[Export ("oSIdentifiers", ArgumentSemantic.Copy)]
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
		// @property (getter = getDestination, copy, nonatomic) FSDestination * destination;
		[Export ("destination", ArgumentSemantic.Copy)]
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
		// @property (getter = getURI, copy, nonatomic) NSString * uRI;
		[Export ("uRI")]
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
		// @property (getter = getScript, copy, nonatomic) NSString * script;
		[Export ("script")]
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
		// @property (getter = getName, copy, nonatomic) NSString * name;
		[Export ("name")]
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
		// @property (getter = getDestination, copy, nonatomic) FSDestination * destination;
		[Export ("destination", ArgumentSemantic.Copy)]
		FSDestination Destination { [Bind ("getDestination")] get; set; }

		// @property (getter = getDestinationName, copy, nonatomic) NSString * destinationName;
		[Export ("destinationName")]
		string DestinationName { [Bind ("getDestinationName")] get; set; }

		// @property (getter = getFileSpec, copy, nonatomic) FSFileSpec * fileSpec;
		[Export ("fileSpec", ArgumentSemantic.Copy)]
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
		// @property (getter = getRelationship, copy, nonatomic) NSString * relationship;
		[Export ("relationship")]
		string Relationship { [Bind ("getRelationship")] get; set; }

		// @property (getter = getAttachedFileName, copy, nonatomic) NSString * attachedFileName;
		[Export ("attachedFileName")]
		string AttachedFileName { [Bind ("getAttachedFileName")] get; set; }

		// @property (getter = getPageIndex, nonatomic) int pageIndex;
		[Export ("pageIndex")]
		int PageIndex { [Bind ("getPageIndex")] get; set; }

		// @property (getter = getFileAttachmentAnnotIndex, nonatomic) int fileAttachmentAnnotIndex;
		[Export ("fileAttachmentAnnotIndex")]
		int FileAttachmentAnnotIndex { [Bind ("getFileAttachmentAnnotIndex")] get; set; }

		// @property (getter = getTarget, copy, nonatomic) FSEmbeddedGotoTarget * target;
		[Export ("target", ArgumentSemantic.Copy)]
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
		// @property (getter = getDestination, copy, nonatomic) FSDestination * destination;
		[Export ("destination", ArgumentSemantic.Copy)]
		FSDestination Destination { [Bind ("getDestination")] get; set; }

		// @property (getter = getDestinationName, copy, nonatomic) NSString * destinationName;
		[Export ("destinationName")]
		string DestinationName { [Bind ("getDestinationName")] get; set; }

		// @property (getter = getRootFile, copy, nonatomic) FSFileSpec * rootFile;
		[Export ("rootFile", ArgumentSemantic.Copy)]
		FSFileSpec RootFile { [Bind ("getRootFile")] get; set; }

		// @property (getter = getNewWindowFlag, nonatomic) FSActionNewWindowFlag newWindowFlag;
		[Export ("newWindowFlag", ArgumentSemantic.Assign)]
		FSActionNewWindowFlag NewWindowFlag { [Bind ("getNewWindowFlag")] get; set; }

		// @property (getter = getTarget, copy, nonatomic) FSEmbeddedGotoTarget * target;
		[Export ("target", ArgumentSemantic.Copy)]
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
		// @property (getter = getURL, copy, nonatomic) NSString * uRL;
		[Export ("uRL")]
		string URL { [Bind ("getURL")] get; set; }

		// @property (getter = getFieldNames, copy, nonatomic) NSArray<NSString *> * fieldNames;
		[Export ("fieldNames", ArgumentSemantic.Copy)]
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
		// @property (getter = getFieldNames, copy, nonatomic) NSArray<NSString *> * fieldNames;
		[Export ("fieldNames", ArgumentSemantic.Copy)]
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
		// @property (getter = getFDFFileSpec, copy, nonatomic) FSFileSpec * fDFFileSpec;
		[Export ("fDFFileSpec", ArgumentSemantic.Copy)]
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
		// @property (getter = getFieldNames, copy, nonatomic) NSArray<NSString *> * fieldNames;
		[Export ("fieldNames", ArgumentSemantic.Copy)]
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
		// @property (getter = getFileSpec, copy, nonatomic) FSFileSpec * fileSpec;
		[Export ("fileSpec", ArgumentSemantic.Copy)]
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

		// @property (getter = getScreenAnnot, copy, nonatomic) FSScreen * screenAnnot;
		[Export ("screenAnnot", ArgumentSemantic.Copy)]
		FSScreen ScreenAnnot { [Bind ("getScreenAnnot")] get; set; }

		// @property (getter = getJavaScript, copy, nonatomic) NSString * javaScript;
		[Export ("javaScript")]
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

		// -(void)insertRendition:(FSRendition *)rendition;
		[Export ("insertRendition:")]
		void InsertRendition (FSRendition rendition);

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

		// -(id)initWithDoc:(FSPDFDoc *)doc;
		[Export ("initWithDoc:")]
		IntPtr Constructor (FSPDFDoc doc);

		// -(id)initWithPage:(FSPDFPage *)page;
		[Export ("initWithPage:")]
		IntPtr Constructor (FSPDFPage page);

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

		// @property (getter = getFont, copy, nonatomic) FSFont * font;
		[Export ("font", ArgumentSemantic.Copy)]
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

	// @interface FSRichTextStyle : NSObject
	[BaseType (typeof(NSObject))]
	interface FSRichTextStyle
	{
		// @property (getter = getFont, copy, nonatomic) FSFont * font;
		[Export ("font", ArgumentSemantic.Copy)]
		FSFont Font { [Bind ("getFont")] get; set; }

		// @property (getter = getText_size, nonatomic) float text_size;
		[Export ("text_size")]
		float Text_size { [Bind ("getText_size")] get; set; }

		// @property (getter = getText_alignment, nonatomic) FSAlignment text_alignment;
		[Export ("text_alignment", ArgumentSemantic.Assign)]
		FSAlignment Text_alignment { [Bind ("getText_alignment")] get; set; }

		// @property (getter = getText_color, nonatomic) unsigned int text_color;
		[Export ("text_color")]
		uint Text_color { [Bind ("getText_color")] get; set; }

		// @property (getter = getIs_bold, nonatomic) BOOL is_bold;
		[Export ("is_bold")]
		bool Is_bold { [Bind ("getIs_bold")] get; set; }

		// @property (getter = getIs_italic, nonatomic) BOOL is_italic;
		[Export ("is_italic")]
		bool Is_italic { [Bind ("getIs_italic")] get; set; }

		// @property (getter = getIs_underline, nonatomic) BOOL is_underline;
		[Export ("is_underline")]
		bool Is_underline { [Bind ("getIs_underline")] get; set; }

		// @property (getter = getIs_strikethrough, nonatomic) BOOL is_strikethrough;
		[Export ("is_strikethrough")]
		bool Is_strikethrough { [Bind ("getIs_strikethrough")] get; set; }

		// @property (getter = getMark_style, nonatomic) FSRichTextStyleCornerMarkStyle mark_style;
		[Export ("mark_style", ArgumentSemantic.Assign)]
		FSRichTextStyleCornerMarkStyle Mark_style { [Bind ("getMark_style")] get; set; }

		// @property (getter = getChar_space, nonatomic) float char_space;
		[Export ("char_space")]
		float Char_space { [Bind ("getChar_space")] get; set; }

		// @property (getter = getWord_space, nonatomic) float word_space;
		[Export ("word_space")]
		float Word_space { [Bind ("getWord_space")] get; set; }

		// -(void *)getCptr;
		[Export ("getCptr")]
		//[Verify (MethodToProperty)]
		IntPtr Cptr { get; }

		// -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
		[Export ("initWithCptr:swigOwnCObject:")]
		IntPtr Constructor (IntPtr cptr, bool ownCObject);

		// -(id)initWithFont:(FSFont *)font text_size:(float)text_size text_alignment:(FSAlignment)text_alignment text_color:(unsigned int)text_color is_bold:(BOOL)is_bold is_italic:(BOOL)is_italic is_underline:(BOOL)is_underline is_strikethrough:(BOOL)is_strikethrough mark_style:(FSRichTextStyleCornerMarkStyle)mark_style char_space:(float)char_space word_space:(float)word_space;
		[Export ("initWithFont:text_size:text_alignment:text_color:is_bold:is_italic:is_underline:is_strikethrough:mark_style:char_space:word_space:")]
		IntPtr Constructor (FSFont font, float text_size, FSAlignment text_alignment, uint text_color, bool is_bold, bool is_italic, bool is_underline, bool is_strikethrough, FSRichTextStyleCornerMarkStyle mark_style, float char_space, float word_space);

		// -(id)initWithStyle:(FSRichTextStyle *)style;
		[Export ("initWithStyle:")]
		IntPtr Constructor (FSRichTextStyle style);

		// -(void)set:(FSFont *)font text_size:(float)text_size text_alignment:(FSAlignment)text_alignment text_color:(unsigned int)text_color is_bold:(BOOL)is_bold is_italic:(BOOL)is_italic is_underline:(BOOL)is_underline is_strikethrough:(BOOL)is_strikethrough mark_style:(FSRichTextStyleCornerMarkStyle)mark_style char_space:(float)char_space word_space:(float)word_space;
		[Export ("set:text_size:text_alignment:text_color:is_bold:is_italic:is_underline:is_strikethrough:mark_style:char_space:word_space:")]
		void Set (FSFont font, float text_size, FSAlignment text_alignment, uint text_color, bool is_bold, bool is_italic, bool is_underline, bool is_strikethrough, FSRichTextStyleCornerMarkStyle mark_style, float char_space, float word_space);

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

		// @property (getter = getDashes, copy, nonatomic) FSFloatArray * dashes;
		[Export ("dashes", ArgumentSemantic.Copy)]
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
		// @property (getter = getFirst, copy, nonatomic) FSPointF * first;
		[Export ("first", ArgumentSemantic.Copy)]
		FSPointF First { [Bind ("getFirst")] get; set; }

		// @property (getter = getSecond, copy, nonatomic) FSPointF * second;
		[Export ("second", ArgumentSemantic.Copy)]
		FSPointF Second { [Bind ("getSecond")] get; set; }

		// @property (getter = getThird, copy, nonatomic) FSPointF * third;
		[Export ("third", ArgumentSemantic.Copy)]
		FSPointF Third { [Bind ("getThird")] get; set; }

		// @property (getter = getFourth, copy, nonatomic) FSPointF * fourth;
		[Export ("fourth", ArgumentSemantic.Copy)]
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

		// -(id)initWithOther:(FSQuadPointsArray *)other;
		[Export ("initWithOther:")]
		IntPtr Constructor (FSQuadPointsArray other);

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
		// @property (getter = getContent, copy, nonatomic) NSString * content;
		[Export ("content")]
		string Content { [Bind ("getContent")] get; set; }

		// @property (getter = getModifiedDateTime, copy, nonatomic) FSDateTime * modifiedDateTime;
		[Export ("modifiedDateTime", ArgumentSemantic.Copy)]
		FSDateTime ModifiedDateTime { [Bind ("getModifiedDateTime")] get; set; }

		// @property (getter = getFlags, nonatomic) unsigned int flags;
		[Export ("flags")]
		uint Flags { [Bind ("getFlags")] get; set; }

		// @property (getter = getUniqueID, copy, nonatomic) NSString * uniqueID;
		[Export ("uniqueID")]
		string UniqueID { [Bind ("getUniqueID")] get; set; }

		// @property (getter = getBorderInfo, copy, nonatomic) FSBorderInfo * borderInfo;
		[Export ("borderInfo", ArgumentSemantic.Copy)]
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

		// -(FSMatrix2D *)getDisplayMatrix:(FSMatrix2D *)page_display_matrix;
		[Export ("getDisplayMatrix:")]
		FSMatrix2D GetDisplayMatrix (FSMatrix2D page_display_matrix);

		// -(BOOL)move:(FSRectF *)rect;
		[Export ("move:")]
		bool Move (FSRectF rect);

		// -(BOOL)move:(FSRectF *)rect is_reset_appearance:(BOOL)is_reset_appearance;
		[Export ("move:is_reset_appearance:")]
		bool Move (FSRectF rect, bool is_reset_appearance);

		// -(BOOL)resetAppearanceStream;
		[Export ("resetAppearanceStream")]
		//[Verify (MethodToProperty)]
		bool ResetAppearanceStream ();

		// -(BOOL)resetAppearanceStream:(BOOL)is_generate_new_appearance_obj;
		[Export ("resetAppearanceStream:")]
		bool ResetAppearanceStream (bool is_generate_new_appearance_obj);

		// -(FSRectI *)getDeviceRect:(FSMatrix2D *)matrix;
		[Export ("getDeviceRect:")]
		FSRectI GetDeviceRect (FSMatrix2D matrix);

		// -(FSPDFDictionary *)getDict;
		[Export ("getDict")]
		//[Verify (MethodToProperty)]
		FSPDFDictionary Dict { get; }

		// -(BOOL)hasProperty:(FSAnnotProperty)property;
		[Export ("hasProperty:")]
		bool HasProperty (FSAnnotProperty property);

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

		// -(FSPDFStream *)getAppearanceStream:(FSAnnotAppearanceType)type;
		[Export ("getAppearanceStream:")]
		FSPDFStream GetAppearanceStream (FSAnnotAppearanceType type);

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

		// -(id)initWithOther:(FSAnnotArray *)other;
		[Export ("initWithOther:")]
		IntPtr Constructor (FSAnnotArray other);

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

		// -(id)initWithOther:(FSMarkupArray *)other;
		[Export ("initWithOther:")]
		IntPtr Constructor (FSMarkupArray other);

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

	// @interface FSNoteArray : NSObject
	[BaseType (typeof(NSObject))]
	interface FSNoteArray
	{
		// -(void *)getCptr;
		[Export ("getCptr")]
		//[Verify (MethodToProperty)]
		IntPtr Cptr { get; }

		// -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
		[Export ("initWithCptr:swigOwnCObject:")]
		IntPtr Constructor (IntPtr cptr, bool ownCObject);

		// -(id)initWithOther:(FSNoteArray *)other;
		[Export ("initWithOther:")]
		IntPtr Constructor (FSNoteArray other);

		// -(unsigned long)getSize;
		[Export ("getSize")]
		//[Verify (MethodToProperty)]
		nuint Size { get; }

		// -(FSNote *)getAt:(unsigned long)index;
		[Export ("getAt:")]
		FSNote GetAt (nuint index);

		// -(void)add:(FSNote *)element;
		[Export ("add:")]
		void Add (FSNote element);

		// -(void)removeAt:(unsigned long)index;
		[Export ("removeAt:")]
		void RemoveAt (nuint index);

		// -(void)insertAt:(unsigned long)index element:(FSNote *)element;
		[Export ("insertAt:element:")]
		void InsertAt (nuint index, FSNote element);

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
		// @property (getter = getPopup, copy, nonatomic) FSPopup * popup;
		[Export ("popup", ArgumentSemantic.Copy)]
		FSPopup Popup { [Bind ("getPopup")] get; set; }

		// @property (getter = getTitle, copy, nonatomic) NSString * title;
		[Export ("title")]
		string Title { [Bind ("getTitle")] get; set; }

		// @property (getter = getSubject, copy, nonatomic) NSString * subject;
		[Export ("subject")]
		string Subject { [Bind ("getSubject")] get; set; }

		// @property (getter = getOpacity, nonatomic) float opacity;
		[Export ("opacity")]
		float Opacity { [Bind ("getOpacity")] get; set; }

		// @property (getter = getIntent, copy, nonatomic) NSString * intent;
		[Export ("intent")]
		string Intent { [Bind ("getIntent")] get; set; }

		// @property (getter = getCreationDateTime, copy, nonatomic) FSDateTime * creationDateTime;
		[Export ("creationDateTime", ArgumentSemantic.Copy)]
		FSDateTime CreationDateTime { [Bind ("getCreationDateTime")] get; set; }

		// @property (getter = getBorderOpacity, nonatomic) float borderOpacity;
		[Export ("borderOpacity")]
		float BorderOpacity { [Bind ("getBorderOpacity")] get; set; }

		// @property (getter = getFillOpacity, nonatomic) float fillOpacity;
		[Export ("fillOpacity")]
		float FillOpacity { [Bind ("getFillOpacity")] get; set; }

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

		// -(BOOL)removePopup;
		[Export ("removePopup")]
		//[Verify (MethodToProperty)]
		bool RemovePopup { get; }

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

		// -(FSNoteArray *)getStateAnnots:(FSMarkupStateModel)model;
		[Export ("getStateAnnots:")]
		FSNoteArray GetStateAnnots (FSMarkupStateModel model);

		// -(FSNote *)addStateAnnot:(NSString *)title model:(FSMarkupStateModel)model state:(FSMarkupState)state;
		[Export ("addStateAnnot:model:state:")]
		FSNote AddStateAnnot (string title, FSMarkupStateModel model, FSMarkupState state);

		// -(BOOL)removeAllStateAnnots;
		[Export ("removeAllStateAnnots")]
		//[Verify (MethodToProperty)]
		bool RemoveAllStateAnnots { get; }

		// -(int)getRichTextCount;
		[Export ("getRichTextCount")]
		//[Verify (MethodToProperty)]
		int RichTextCount { get; }

		// -(NSString *)getRichTextContent:(int)index;
		[Export ("getRichTextContent:")]
		string GetRichTextContent (int index);

		// -(void)setRichTextContent:(int)index content:(NSString *)content;
		[Export ("setRichTextContent:content:")]
		void SetRichTextContent (int index, string content);

		// -(FSRichTextStyle *)getRichTextStyle:(int)index;
		[Export ("getRichTextStyle:")]
		FSRichTextStyle GetRichTextStyle (int index);

		// -(void)setRichTextStyle:(int)index style:(FSRichTextStyle *)style;
		[Export ("setRichTextStyle:style:")]
		void SetRichTextStyle (int index, FSRichTextStyle style);

		// -(void)addRichText:(NSString *)content style:(FSRichTextStyle *)style;
		[Export ("addRichText:style:")]
		void AddRichText (string content, FSRichTextStyle style);

		// -(void)insertRichText:(int)index content:(NSString *)content style:(FSRichTextStyle *)style;
		[Export ("insertRichText:content:style:")]
		void InsertRichText (int index, string content, FSRichTextStyle style);

		// -(void)removeRichText:(int)index;
		[Export ("removeRichText:")]
		void RemoveRichText (int index);

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

		// @property (getter = getIconName, copy, nonatomic) NSString * iconName;
		[Export ("iconName")]
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
		// @property (getter = getQuadPoints, copy, nonatomic) FSQuadPointsArray * quadPoints;
		[Export ("quadPoints", ArgumentSemantic.Copy)]
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
		// @property (getter = getQuadPoints, copy, nonatomic) FSQuadPointsArray * quadPoints;
		[Export ("quadPoints", ArgumentSemantic.Copy)]
		FSQuadPointsArray QuadPoints { [Bind ("getQuadPoints")] get; set; }

		// @property (getter = getHighlightingMode, nonatomic) FSAnnotHighlightingMode highlightingMode;
		[Export ("highlightingMode", ArgumentSemantic.Assign)]
		FSAnnotHighlightingMode HighlightingMode { [Bind ("getHighlightingMode")] get; set; }

		// @property (getter = getAction, copy, nonatomic) FSAction * action;
		[Export ("action", ArgumentSemantic.Copy)]
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

		// -(BOOL)executeJavaScriptAction:(FSJavaScriptAction *)javascript_action;
		[Export ("executeJavaScriptAction:")]
		bool ExecuteJavaScriptAction (FSJavaScriptAction javascript_action);

		// -(BOOL)executeJavaScriptAction;
		[Export ("executeJavaScriptAction")]
		//[Verify (MethodToProperty)]
		bool ExecuteJavaScriptAction ();

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

		// @property (getter = getInnerRect, copy, nonatomic) FSRectF * innerRect;
		[Export ("innerRect", ArgumentSemantic.Copy)]
		FSRectF InnerRect { [Bind ("getInnerRect")] get; set; }

		// @property (getter = getMeasureRatio, copy, nonatomic) NSString * measureRatio;
		[Export ("measureRatio")]
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

		// -(NSString *)getMeasureRatioW;
		[Export ("getMeasureRatioW")]
		//[Verify (MethodToProperty)]
		string MeasureRatioW { get; }

		// -(void)setMeasureUnit:(FSMarkupMeasureType)measure_type unit:(NSString *)unit;
		[Export ("setMeasureUnit:unit:")]
		void SetMeasureUnit (FSMarkupMeasureType measure_type, string unit);

		// -(NSString *)getMeasureUnit:(FSMarkupMeasureType)measure_type;
		[Export ("getMeasureUnit:")]
		string GetMeasureUnit (FSMarkupMeasureType measure_type);

		// -(NSString *)getMeasureUnitW:(FSMarkupMeasureType)measure_type;
		[Export ("getMeasureUnitW:")]
		string GetMeasureUnitW (FSMarkupMeasureType measure_type);

		// -(void)setMeasureConversionFactor:(FSMarkupMeasureType)measure_type factor:(float)factor;
		[Export ("setMeasureConversionFactor:factor:")]
		void SetMeasureConversionFactor (FSMarkupMeasureType measure_type, float factor);

		// -(float)getMeasureConversionFactor:(FSMarkupMeasureType)measure_type;
		[Export ("getMeasureConversionFactor:")]
		float GetMeasureConversionFactor (FSMarkupMeasureType measure_type);

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

		// @property (getter = getInnerRect, copy, nonatomic) FSRectF * innerRect;
		[Export ("innerRect", ArgumentSemantic.Copy)]
		FSRectF InnerRect { [Bind ("getInnerRect")] get; set; }

		// @property (getter = getMeasureRatio, copy, nonatomic) NSString * measureRatio;
		[Export ("measureRatio")]
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

		// -(NSString *)getMeasureRatioW;
		[Export ("getMeasureRatioW")]
		//[Verify (MethodToProperty)]
		string MeasureRatioW { get; }

		// -(void)setMeasureUnit:(FSMarkupMeasureType)measure_type unit:(NSString *)unit;
		[Export ("setMeasureUnit:unit:")]
		void SetMeasureUnit (FSMarkupMeasureType measure_type, string unit);

		// -(NSString *)getMeasureUnit:(FSMarkupMeasureType)measure_type;
		[Export ("getMeasureUnit:")]
		string GetMeasureUnit (FSMarkupMeasureType measure_type);

		// -(NSString *)getMeasureUnitW:(FSMarkupMeasureType)measure_type;
		[Export ("getMeasureUnitW:")]
		string GetMeasureUnitW (FSMarkupMeasureType measure_type);

		// -(void)setMeasureConversionFactor:(FSMarkupMeasureType)measure_type factor:(float)factor;
		[Export ("setMeasureConversionFactor:factor:")]
		void SetMeasureConversionFactor (FSMarkupMeasureType measure_type, float factor);

		// -(float)getMeasureConversionFactor:(FSMarkupMeasureType)measure_type;
		[Export ("getMeasureConversionFactor:")]
		float GetMeasureConversionFactor (FSMarkupMeasureType measure_type);

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

		// @property (getter = getInnerRect, copy, nonatomic) FSRectF * innerRect;
		[Export ("innerRect", ArgumentSemantic.Copy)]
		FSRectF InnerRect { [Bind ("getInnerRect")] get; set; }

		// @property (getter = getCalloutLineEndingStyle, nonatomic) FSMarkupEndingStyle calloutLineEndingStyle;
		[Export ("calloutLineEndingStyle", ArgumentSemantic.Assign)]
		FSMarkupEndingStyle CalloutLineEndingStyle { [Bind ("getCalloutLineEndingStyle")] get; set; }

		// @property (getter = getCalloutLinePoints, copy, nonatomic) FSPointFArray * calloutLinePoints;
		[Export ("calloutLinePoints", ArgumentSemantic.Copy)]
		FSPointFArray CalloutLinePoints { [Bind ("getCalloutLinePoints")] get; set; }

		// @property (getter = getTextMatrix, copy, nonatomic) FSMatrix2D * textMatrix;
		[Export ("textMatrix", ArgumentSemantic.Copy)]
		FSMatrix2D TextMatrix { [Bind ("getTextMatrix")] get; set; }

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

		// -(void)rotate:(FSRotation)rotation;
		[Export ("rotate:")]
		void Rotate (FSRotation rotation);

		// -(void)allowTextOverflow:(BOOL)is_text_overflow;
		[Export ("allowTextOverflow:")]
		void AllowTextOverflow (bool is_text_overflow);

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

		// @property (getter = getStartPoint, copy, nonatomic) FSPointF * startPoint;
		[Export ("startPoint", ArgumentSemantic.Copy)]
		FSPointF StartPoint { [Bind ("getStartPoint")] get; set; }

		// @property (getter = getEndPoint, copy, nonatomic) FSPointF * endPoint;
		[Export ("endPoint", ArgumentSemantic.Copy)]
		FSPointF EndPoint { [Bind ("getEndPoint")] get; set; }

		// @property (getter = getCaptionPositionType, nonatomic) FSLineCapPos captionPositionType;
		[Export ("captionPositionType", ArgumentSemantic.Assign)]
		FSLineCapPos CaptionPositionType { [Bind ("getCaptionPositionType")] get; set; }

		// @property (getter = getCaptionOffset, copy, nonatomic) FSPointF * captionOffset;
		[Export ("captionOffset", ArgumentSemantic.Copy)]
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

		// @property (getter = getMeasureRatio, copy, nonatomic) NSString * measureRatio;
		[Export ("measureRatio")]
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

		// -(NSString *)getMeasureRatioW;
		[Export ("getMeasureRatioW")]
		//[Verify (MethodToProperty)]
		string MeasureRatioW { get; }

		// -(void)setMeasureUnit:(FSMarkupMeasureType)measure_type unit:(NSString *)unit;
		[Export ("setMeasureUnit:unit:")]
		void SetMeasureUnit (FSMarkupMeasureType measure_type, string unit);

		// -(NSString *)getMeasureUnit:(FSMarkupMeasureType)measure_type;
		[Export ("getMeasureUnit:")]
		string GetMeasureUnit (FSMarkupMeasureType measure_type);

		// -(NSString *)getMeasureUnitW:(FSMarkupMeasureType)measure_type;
		[Export ("getMeasureUnitW:")]
		string GetMeasureUnitW (FSMarkupMeasureType measure_type);

		// -(void)setMeasureConversionFactor:(FSMarkupMeasureType)measure_type factor:(float)factor;
		[Export ("setMeasureConversionFactor:factor:")]
		void SetMeasureConversionFactor (FSMarkupMeasureType measure_type, float factor);

		// -(float)getMeasureConversionFactor:(FSMarkupMeasureType)measure_type;
		[Export ("getMeasureConversionFactor:")]
		float GetMeasureConversionFactor (FSMarkupMeasureType measure_type);

		// -(void)dealloc;
		[Export ("dealloc")]
		void Dealloc ();
	}

	// @interface FSInk : FSMarkup
	[BaseType (typeof(FSMarkup))]
	interface FSInk
	{
		// @property (getter = getInkList, copy, nonatomic) FSPath * inkList;
		[Export ("inkList", ArgumentSemantic.Copy)]
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

		// -(void)enableUseBezier:(BOOL)use_bezier;
		[Export ("enableUseBezier:")]
		void EnableUseBezier (bool use_bezier);

		// -(FSPathArray *)getEIAInkList;
		[Export ("getEIAInkList")]
		//[Verify (MethodToProperty)]
		FSPathArray EIAInkList { get; }

		// -(void)dealloc;
		[Export ("dealloc")]
		void Dealloc ();
	}

	// @interface FSStamp : FSMarkup
	[BaseType (typeof(FSMarkup))]
	interface FSStamp
	{
		// @property (getter = getIconName, copy, nonatomic) NSString * iconName;
		[Export ("iconName")]
		string IconName { [Bind ("getIconName")] get; set; }

		// @property (getter = getRotation, nonatomic) int rotation;
		[Export ("rotation")]
		int Rotation { [Bind ("getRotation")] get; set; }

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

		// -(void)rotate:(int)angle;
		[Export ("rotate:")]
		void Rotate (int angle);

		// -(void)dealloc;
		[Export ("dealloc")]
		void Dealloc ();
	}

	// @interface FSScreen : FSAnnot
	[BaseType (typeof(FSAnnot))]
	interface FSScreen
	{
		// @property (getter = getMKDict, copy, nonatomic) FSPDFDictionary * mKDict;
		[Export ("mKDict", ArgumentSemantic.Copy)]
		FSPDFDictionary MKDict { [Bind ("getMKDict")] get; set; }

		// @property (getter = getRotation, nonatomic) FSRotation rotation;
		[Export ("rotation", ArgumentSemantic.Assign)]
		FSRotation Rotation { [Bind ("getRotation")] get; set; }

		// @property (getter = getOpacity, nonatomic) float opacity;
		[Export ("opacity")]
		float Opacity { [Bind ("getOpacity")] get; set; }

		// @property (getter = getTitle, copy, nonatomic) NSString * title;
		[Export ("title")]
		string Title { [Bind ("getTitle")] get; set; }

		// @property (getter = getAction, copy, nonatomic) FSAction * action;
		[Export ("action", ArgumentSemantic.Copy)]
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

		// -(FSBitmap *)getBitmap;
		[Export ("getBitmap")]
		//[Verify (MethodToProperty)]
		FSBitmap Bitmap { get; }

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

		// @property (getter = getVertexes, copy, nonatomic) FSPointFArray * vertexes;
		[Export ("vertexes", ArgumentSemantic.Copy)]
		FSPointFArray Vertexes { [Bind ("getVertexes")] get; set; }

		// @property (getter = getMeasureRatio, copy, nonatomic) NSString * measureRatio;
		[Export ("measureRatio")]
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

		// -(NSString *)getMeasureRatioW;
		[Export ("getMeasureRatioW")]
		//[Verify (MethodToProperty)]
		string MeasureRatioW { get; }

		// -(void)setMeasureUnit:(FSMarkupMeasureType)measure_type unit:(NSString *)unit;
		[Export ("setMeasureUnit:unit:")]
		void SetMeasureUnit (FSMarkupMeasureType measure_type, string unit);

		// -(NSString *)getMeasureUnit:(FSMarkupMeasureType)measure_type;
		[Export ("getMeasureUnit:")]
		string GetMeasureUnit (FSMarkupMeasureType measure_type);

		// -(NSString *)getMeasureUnitW:(FSMarkupMeasureType)measure_type;
		[Export ("getMeasureUnitW:")]
		string GetMeasureUnitW (FSMarkupMeasureType measure_type);

		// -(void)setMeasureConversionFactor:(FSMarkupMeasureType)measure_type factor:(float)factor;
		[Export ("setMeasureConversionFactor:factor:")]
		void SetMeasureConversionFactor (FSMarkupMeasureType measure_type, float factor);

		// -(float)getMeasureConversionFactor:(FSMarkupMeasureType)measure_type;
		[Export ("getMeasureConversionFactor:")]
		float GetMeasureConversionFactor (FSMarkupMeasureType measure_type);

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

		// @property (getter = getVertexes, copy, nonatomic) FSPointFArray * vertexes;
		[Export ("vertexes", ArgumentSemantic.Copy)]
		FSPointFArray Vertexes { [Bind ("getVertexes")] get; set; }

		// @property (getter = getLineStartStyle, nonatomic) FSMarkupEndingStyle lineStartStyle;
		[Export ("lineStartStyle", ArgumentSemantic.Assign)]
		FSMarkupEndingStyle LineStartStyle { [Bind ("getLineStartStyle")] get; set; }

		// @property (getter = getLineEndStyle, nonatomic) FSMarkupEndingStyle lineEndStyle;
		[Export ("lineEndStyle", ArgumentSemantic.Assign)]
		FSMarkupEndingStyle LineEndStyle { [Bind ("getLineEndStyle")] get; set; }

		// @property (getter = getMeasureRatio, copy, nonatomic) NSString * measureRatio;
		[Export ("measureRatio")]
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

		// -(NSString *)getMeasureRatioW;
		[Export ("getMeasureRatioW")]
		//[Verify (MethodToProperty)]
		string MeasureRatioW { get; }

		// -(void)setMeasureUnit:(FSMarkupMeasureType)measure_type unit:(NSString *)unit;
		[Export ("setMeasureUnit:unit:")]
		void SetMeasureUnit (FSMarkupMeasureType measure_type, string unit);

		// -(NSString *)getMeasureUnit:(FSMarkupMeasureType)measure_type;
		[Export ("getMeasureUnit:")]
		string GetMeasureUnit (FSMarkupMeasureType measure_type);

		// -(NSString *)getMeasureUnitW:(FSMarkupMeasureType)measure_type;
		[Export ("getMeasureUnitW:")]
		string GetMeasureUnitW (FSMarkupMeasureType measure_type);

		// -(void)setMeasureConversionFactor:(FSMarkupMeasureType)measure_type factor:(float)factor;
		[Export ("setMeasureConversionFactor:factor:")]
		void SetMeasureConversionFactor (FSMarkupMeasureType measure_type, float factor);

		// -(float)getMeasureConversionFactor:(FSMarkupMeasureType)measure_type;
		[Export ("getMeasureConversionFactor:")]
		float GetMeasureConversionFactor (FSMarkupMeasureType measure_type);

		// -(void)dealloc;
		[Export ("dealloc")]
		void Dealloc ();
	}

	// @interface FSCaret : FSMarkup
	[BaseType (typeof(FSMarkup))]
	interface FSCaret
	{
		// @property (getter = getInnerRect, copy, nonatomic) FSRectF * innerRect;
		[Export ("innerRect", ArgumentSemantic.Copy)]
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
		// @property (getter = getIconName, copy, nonatomic) NSString * iconName;
		[Export ("iconName")]
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

		// -(FSMarkup *)getParent;
		[Export ("getParent")]
		//[Verify (MethodToProperty)]
		FSMarkup Parent { get; }

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

		// @property (getter = getAction, copy, nonatomic) FSAction * action;
		[Export ("action", ArgumentSemantic.Copy)]
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

		// @property (getter = getMKNormalCaption, copy, nonatomic) NSString * mKNormalCaption;
		[Export ("mKNormalCaption")]
		string MKNormalCaption { [Bind ("getMKNormalCaption")] get; set; }

		// @property (getter = getMKRolloverCaption, copy, nonatomic) NSString * mKRolloverCaption;
		[Export ("mKRolloverCaption")]
		string MKRolloverCaption { [Bind ("getMKRolloverCaption")] get; set; }

		// @property (getter = getMKDownCaption, copy, nonatomic) NSString * mKDownCaption;
		[Export ("mKDownCaption")]
		string MKDownCaption { [Bind ("getMKDownCaption")] get; set; }

		// @property (getter = getMKNormalIconBitmap, copy, nonatomic) FSBitmap * mKNormalIconBitmap;
		[Export ("mKNormalIconBitmap", ArgumentSemantic.Copy)]
		FSBitmap MKNormalIconBitmap { [Bind ("getMKNormalIconBitmap")] get; set; }

		// @property (getter = getMKRolloverIconBitmap, copy, nonatomic) FSBitmap * mKRolloverIconBitmap;
		[Export ("mKRolloverIconBitmap", ArgumentSemantic.Copy)]
		FSBitmap MKRolloverIconBitmap { [Bind ("getMKRolloverIconBitmap")] get; set; }

		// @property (getter = getMKDownIconBitmap, copy, nonatomic) FSBitmap * mKDownIconBitmap;
		[Export ("mKDownIconBitmap", ArgumentSemantic.Copy)]
		FSBitmap MKDownIconBitmap { [Bind ("getMKDownIconBitmap")] get; set; }

		// @property (getter = getMKIconFit, copy, nonatomic) FSIconFit * mKIconFit;
		[Export ("mKIconFit", ArgumentSemantic.Copy)]
		FSIconFit MKIconFit { [Bind ("getMKIconFit")] get; set; }

		// @property (getter = getMKIconCaptionRelation, nonatomic) FSAnnotMKIconCaptionRelation mKIconCaptionRelation;
		[Export ("mKIconCaptionRelation", ArgumentSemantic.Assign)]
		FSAnnotMKIconCaptionRelation MKIconCaptionRelation { [Bind ("getMKIconCaptionRelation")] get; set; }

		// @property (getter = getAppearanceState, copy, nonatomic) NSString * appearanceState;
		[Export ("appearanceState")]
		string AppearanceState { [Bind ("getAppearanceState")] get; set; }

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

		// -(NSString *)getAppearanceOnStateName;
		[Export ("getAppearanceOnStateName")]
		//[Verify (MethodToProperty)]
		string AppearanceOnStateName { get; }

		// -(FSWidgetLineSpacingStyle)getLineSpacing:(float *)line_spacing_value;
		[Export ("getLineSpacing:")]
		unsafe FSWidgetLineSpacingStyle GetLineSpacing (float line_spacing_value);

		// -(void)setLineSpacing:(FSWidgetLineSpacingStyle)line_spacing_style line_spacing_value:(float)line_spacing_value;
		[Export ("setLineSpacing:line_spacing_value:")]
		void SetLineSpacing (FSWidgetLineSpacingStyle line_spacing_style, float line_spacing_value);

		// -(void)dealloc;
		[Export ("dealloc")]
		void Dealloc ();
	}

	// @interface FSRedact : FSMarkup
	[BaseType (typeof(FSMarkup))]
	interface FSRedact
	{
		// @property (getter = getQuadPoints, copy, nonatomic) FSQuadPointsArray * quadPoints;
		[Export ("quadPoints", ArgumentSemantic.Copy)]
		FSQuadPointsArray QuadPoints { [Bind ("getQuadPoints")] get; set; }

		// @property (getter = getFillColor, nonatomic) unsigned int fillColor;
		[Export ("fillColor")]
		uint FillColor { [Bind ("getFillColor")] get; set; }

		// @property (getter = getApplyFillColor, nonatomic) unsigned int applyFillColor;
		[Export ("applyFillColor")]
		uint ApplyFillColor { [Bind ("getApplyFillColor")] get; set; }

		// @property (getter = getOverlayText, copy, nonatomic) NSString * overlayText;
		[Export ("overlayText")]
		string OverlayText { [Bind ("getOverlayText")] get; set; }

		// @property (getter = getOverlayTextAlignment, nonatomic) FSAlignment overlayTextAlignment;
		[Export ("overlayTextAlignment", ArgumentSemantic.Assign)]
		FSAlignment OverlayTextAlignment { [Bind ("getOverlayTextAlignment")] get; set; }

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

		// -(BOOL)isOverlayTextRepeated;
		[Export ("isOverlayTextRepeated")]
		//[Verify (MethodToProperty)]
		bool IsOverlayTextRepeated { get; }

		// -(void)enableRepeatOverlayText:(BOOL)is_to_repeat_overlay_text;
		[Export ("enableRepeatOverlayText:")]
		void EnableRepeatOverlayText (bool is_to_repeat_overlay_text);

		// -(void)enableAutoFontSize;
		[Export ("enableAutoFontSize")]
		void EnableAutoFontSize ();

		// -(FSDefaultAppearance *)getDefaultAppearance;
		[Export ("getDefaultAppearance")]
		//[Verify (MethodToProperty)]
		FSDefaultAppearance DefaultAppearance { get; }

		// -(BOOL)setDefaultAppearance:(FSDefaultAppearance *)default_ap;
		[Export ("setDefaultAppearance:")]
		bool SetDefaultAppearance (FSDefaultAppearance default_ap);

		// -(BOOL)apply;
		[Export ("apply")]
		//[Verify (MethodToProperty)]
		bool Apply { get; }

		// -(void)dealloc;
		[Export ("dealloc")]
		void Dealloc ();
	}

	// @interface FSSound : FSMarkup
	[BaseType (typeof(FSMarkup))]
	interface FSSound
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

		// -(FSPDFStream *)getSoundStream;
		[Export ("getSoundStream")]
		//[Verify (MethodToProperty)]
		FSPDFStream SoundStream { get; }

		// -(float)getSamplingRate;
		[Export ("getSamplingRate")]
		//[Verify (MethodToProperty)]
		float SamplingRate { get; }

		// -(int)getChannelCount;
		[Export ("getChannelCount")]
		//[Verify (MethodToProperty)]
		int ChannelCount { get; }

		// -(int)getBits;
		[Export ("getBits")]
		//[Verify (MethodToProperty)]
		int Bits { get; }

		// -(FSSoundSampleEncodingFormat)getSampleEncodingFormat;
		[Export ("getSampleEncodingFormat")]
		//[Verify (MethodToProperty)]
		FSSoundSampleEncodingFormat SampleEncodingFormat { get; }

		// -(NSString *)getCompressionFormat;
		[Export ("getCompressionFormat")]
		//[Verify (MethodToProperty)]
		string CompressionFormat { get; }

		// -(FSFileSpec *)getFileSpec;
		[Export ("getFileSpec")]
		//[Verify (MethodToProperty)]
		FSFileSpec FileSpec { get; }

		// -(void)dealloc;
		[Export ("dealloc")]
		void Dealloc ();
	}

	// @interface FSPagingSeal : FSAnnot
	[BaseType (typeof(FSAnnot))]
	[DisableDefaultCtor]
	interface FSPagingSeal
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

		// -(FSPagingSealSignature *)getPagingSealSignature;
		[Export ("getPagingSealSignature")]
		//[Verify (MethodToProperty)]
		FSPagingSealSignature PagingSealSignature { get; }

		// -(void)dealloc;
		[Export ("dealloc")]
		void Dealloc ();
	}

	// @interface FSRichMedia : FSAnnot
	[BaseType (typeof(FSAnnot))]
	interface FSRichMedia
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

		// -(void)saveMediaFile:(NSString *)file_path;
		[Export ("saveMediaFile:")]
		void SaveMediaFile (string file_path);

		// -(FSFileSpec *)getFileSpec;
		[Export ("getFileSpec")]
		//[Verify (MethodToProperty)]
		FSFileSpec FileSpec { get; }

		// -(void)dealloc;
		[Export ("dealloc")]
		void Dealloc ();
	}

	// @interface FSBookmark : FSBase
	[BaseType (typeof(FSBase))]
	[DisableDefaultCtor]
	interface FSBookmark
	{
		// @property (getter = getDestination, copy, nonatomic) FSDestination * destination;
		[Export ("destination", ArgumentSemantic.Copy)]
		FSDestination Destination { [Bind ("getDestination")] get; set; }

		// @property (getter = getTitle, copy, nonatomic) NSString * title;
		[Export ("title")]
		string Title { [Bind ("getTitle")] get; set; }

		// @property (getter = getColor, nonatomic) unsigned int color;
		[Export ("color")]
		uint Color { [Bind ("getColor")] get; set; }

		// @property (getter = getStyle, nonatomic) unsigned int style;
		[Export ("style")]
		uint Style { [Bind ("getStyle")] get; set; }

		// @property (getter = getAction, copy, nonatomic) FSAction * action;
		[Export ("action", ArgumentSemantic.Copy)]
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

		// -(int)getAssociatedFilesCountWithGraphicsObject:(FSGraphicsObject *)graphics_object;
		[Export ("getAssociatedFilesCountWithGraphicsObject:")]
		int GetAssociatedFilesCountWithGraphicsObject (FSGraphicsObject graphics_object);

		// -(FSFileSpec *)getAssociatedFile:(FSPDFObject *)pdf_object index:(int)index;
		[Export ("getAssociatedFile:index:")]
		FSFileSpec GetAssociatedFile (FSPDFObject pdf_object, int index);

		// -(FSFileSpec *)getAssociatedFileWithGraphicsObject:(FSGraphicsObject *)graphics_object index:(int)index;
		[Export ("getAssociatedFileWithGraphicsObject:index:")]
		FSFileSpec GetAssociatedFileWithGraphicsObject (FSGraphicsObject graphics_object, int index);

		// -(void)associateFile:(FSPDFObject *)pdf_object file_spec:(FSFileSpec *)file_spec;
		[Export ("associateFile:file_spec:")]
		void AssociateFile (FSPDFObject pdf_object, FSFileSpec file_spec);

		// -(void)associateFile:(FSGraphicsObject *)graphics_object mark_content_item_index:(int)mark_content_item_index current_resource:(FSPDFObject *)current_resource property_name:(NSString *)property_name file_spec:(FSFileSpec *)file_spec;
		[Export ("associateFile:mark_content_item_index:current_resource:property_name:file_spec:")]
		void AssociateFile (FSGraphicsObject graphics_object, int mark_content_item_index, FSPDFObject current_resource, string property_name, FSFileSpec file_spec);

		// -(void)associateFileWithPage:(FSPDFPage *)page file_spec:(FSFileSpec *)file_spec;
		[Export ("associateFileWithPage:file_spec:")]
		void AssociateFileWithPage (FSPDFPage page, FSFileSpec file_spec);

		// -(void)associateFileWithImage:(FSImageObject *)image file_spec:(FSFileSpec *)file_spec;
		[Export ("associateFileWithImage:file_spec:")]
		void AssociateFileWithImage (FSImageObject image, FSFileSpec file_spec);

		// -(void)associateFileWithFormXobject:(FSFormXObject *)form_xobject file_spec:(FSFileSpec *)file_spec;
		[Export ("associateFileWithFormXobject:file_spec:")]
		void AssociateFileWithFormXobject (FSFormXObject form_xobject, FSFileSpec file_spec);

		// -(void)associateFileWithAnnot:(FSAnnot *)annot file_spec:(FSFileSpec *)file_spec;
		[Export ("associateFileWithAnnot:file_spec:")]
		void AssociateFileWithAnnot (FSAnnot annot, FSFileSpec file_spec);

		// -(void)removeAssociatedFile:(FSPDFObject *)pdf_object index:(int)index;
		[Export ("removeAssociatedFile:index:")]
		void RemoveAssociatedFile (FSPDFObject pdf_object, int index);

		// -(void)removeAssociatedFileWithGraphicsObject:(FSGraphicsObject *)graphics_object index:(int)index;
		[Export ("removeAssociatedFileWithGraphicsObject:index:")]
		void RemoveAssociatedFileWithGraphicsObject (FSGraphicsObject graphics_object, int index);

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

		// -(id)initWithDoc:(FSPDFDoc *)doc;
		[Export ("initWithDoc:")]
		IntPtr Constructor (FSPDFDoc doc);

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

	// @interface FSPageNumberRange : NSObject
	[BaseType (typeof(NSObject))]
	interface FSPageNumberRange
	{
		// @property (getter = getStart_number, nonatomic) int start_number;
		[Export ("start_number")]
		int Start_number { [Bind ("getStart_number")] get; set; }

		// @property (getter = getEnd_number, nonatomic) int end_number;
		[Export ("end_number")]
		int End_number { [Bind ("getEnd_number")] get; set; }

		// @property (getter = getFilter, nonatomic) FSRangeFilter filter;
		[Export ("filter", ArgumentSemantic.Assign)]
		FSRangeFilter Filter { [Bind ("getFilter")] get; set; }

		// -(void *)getCptr;
		[Export ("getCptr")]
		//[Verify (MethodToProperty)]
		IntPtr Cptr { get; }

		// -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
		[Export ("initWithCptr:swigOwnCObject:")]
		IntPtr Constructor (IntPtr cptr, bool ownCObject);

		// -(id)initWithStart_number:(int)start_number end_number:(int)end_number filter:(FSRangeFilter)filter;
		[Export ("initWithStart_number:end_number:filter:")]
		IntPtr Constructor (int start_number, int end_number, FSRangeFilter filter);

		// -(id)initWithPage_range:(FSPageNumberRange *)page_range;
		[Export ("initWithPage_range:")]
		IntPtr Constructor (FSPageNumberRange page_range);

		// -(void)set:(int)start_number end_number:(int)end_number filter:(FSRangeFilter)filter;
		[Export ("set:end_number:filter:")]
		void Set (int start_number, int end_number, FSRangeFilter filter);

		// -(void)dealloc;
		[Export ("dealloc")]
		void Dealloc ();
	}

	// @interface FSHeaderFooterContent : NSObject
	[BaseType (typeof(NSObject))]
	interface FSHeaderFooterContent
	{
		// @property (getter = getHeader_left_content, copy, nonatomic) NSString * header_left_content;
		[Export ("header_left_content")]
		string Header_left_content { [Bind ("getHeader_left_content")] get; set; }

		// @property (getter = getHeader_center_content, copy, nonatomic) NSString * header_center_content;
		[Export ("header_center_content")]
		string Header_center_content { [Bind ("getHeader_center_content")] get; set; }

		// @property (getter = getHeader_right_content, copy, nonatomic) NSString * header_right_content;
		[Export ("header_right_content")]
		string Header_right_content { [Bind ("getHeader_right_content")] get; set; }

		// @property (getter = getFooter_left_content, copy, nonatomic) NSString * footer_left_content;
		[Export ("footer_left_content")]
		string Footer_left_content { [Bind ("getFooter_left_content")] get; set; }

		// @property (getter = getFooter_center_content, copy, nonatomic) NSString * footer_center_content;
		[Export ("footer_center_content")]
		string Footer_center_content { [Bind ("getFooter_center_content")] get; set; }

		// @property (getter = getFooter_right_content, copy, nonatomic) NSString * footer_right_content;
		[Export ("footer_right_content")]
		string Footer_right_content { [Bind ("getFooter_right_content")] get; set; }

		// -(void *)getCptr;
		[Export ("getCptr")]
		//[Verify (MethodToProperty)]
		IntPtr Cptr { get; }

		// -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
		[Export ("initWithCptr:swigOwnCObject:")]
		IntPtr Constructor (IntPtr cptr, bool ownCObject);

		// -(id)initWithHeader_left_content:(NSString *)header_left_content header_center_content:(NSString *)header_center_content header_right_content:(NSString *)header_right_content footer_left_content:(NSString *)footer_left_content footer_center_content:(NSString *)footer_center_content footer_right_content:(NSString *)footer_right_content;
		[Export ("initWithHeader_left_content:header_center_content:header_right_content:footer_left_content:footer_center_content:footer_right_content:")]
		IntPtr Constructor (string header_left_content, string header_center_content, string header_right_content, string footer_left_content, string footer_center_content, string footer_right_content);

		// -(id)initWithOther:(FSHeaderFooterContent *)other;
		[Export ("initWithOther:")]
		IntPtr Constructor (FSHeaderFooterContent other);

		// -(void)set:(NSString *)header_left_content header_center_content:(NSString *)header_center_content header_right_content:(NSString *)header_right_content footer_left_content:(NSString *)footer_left_content footer_center_content:(NSString *)footer_center_content footer_right_content:(NSString *)footer_right_content;
		[Export ("set:header_center_content:header_right_content:footer_left_content:footer_center_content:footer_right_content:")]
		void Set (string header_left_content, string header_center_content, string header_right_content, string footer_left_content, string footer_center_content, string footer_right_content);

		// -(void)dealloc;
		[Export ("dealloc")]
		void Dealloc ();
	}

	// @interface FSHeaderFooter : NSObject
	[BaseType (typeof(NSObject))]
	interface FSHeaderFooter
	{
		// @property (getter = getFont, copy, nonatomic) FSFont * font;
		[Export ("font", ArgumentSemantic.Copy)]
		FSFont Font { [Bind ("getFont")] get; set; }

		// @property (getter = getText_size, nonatomic) float text_size;
		[Export ("text_size")]
		float Text_size { [Bind ("getText_size")] get; set; }

		// @property (getter = getText_color, nonatomic) unsigned int text_color;
		[Export ("text_color")]
		uint Text_color { [Bind ("getText_color")] get; set; }

		// @property (getter = getPage_range, copy, nonatomic) FSPageNumberRange * page_range;
		[Export ("page_range", ArgumentSemantic.Copy)]
		FSPageNumberRange Page_range { [Bind ("getPage_range")] get; set; }

		// @property (getter = getPage_margin, copy, nonatomic) FSRectF * page_margin;
		[Export ("page_margin", ArgumentSemantic.Copy)]
		FSRectF Page_margin { [Bind ("getPage_margin")] get; set; }

		// @property (getter = getHas_text_shrinked, nonatomic) BOOL has_text_shrinked;
		[Export ("has_text_shrinked")]
		bool Has_text_shrinked { [Bind ("getHas_text_shrinked")] get; set; }

		// @property (getter = getHas_fixedsize_for_print, nonatomic) BOOL has_fixedsize_for_print;
		[Export ("has_fixedsize_for_print")]
		bool Has_fixedsize_for_print { [Bind ("getHas_fixedsize_for_print")] get; set; }

		// @property (getter = getStart_page_number, nonatomic) int start_page_number;
		[Export ("start_page_number")]
		int Start_page_number { [Bind ("getStart_page_number")] get; set; }

		// @property (getter = getContent, copy, nonatomic) FSHeaderFooterContent * content;
		[Export ("content", ArgumentSemantic.Copy)]
		FSHeaderFooterContent Content { [Bind ("getContent")] get; set; }

		// @property (getter = getIs_to_embed_font, nonatomic) BOOL is_to_embed_font;
		[Export ("is_to_embed_font")]
		bool Is_to_embed_font { [Bind ("getIs_to_embed_font")] get; set; }

		// @property (getter = getIs_underline, nonatomic) BOOL is_underline;
		[Export ("is_underline")]
		bool Is_underline { [Bind ("getIs_underline")] get; set; }

		// @property (getter = getIs_replace_font, nonatomic) BOOL is_replace_font;
		[Export ("is_replace_font")]
		bool Is_replace_font { [Bind ("getIs_replace_font")] get; set; }

		// -(void *)getCptr;
		[Export ("getCptr")]
		//[Verify (MethodToProperty)]
		IntPtr Cptr { get; }

		// -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
		[Export ("initWithCptr:swigOwnCObject:")]
		IntPtr Constructor (IntPtr cptr, bool ownCObject);

		// -(id)initWithFont:(FSFont *)font text_size:(float)text_size text_color:(unsigned int)text_color page_range:(FSPageNumberRange *)page_range page_margin:(FSRectF *)page_margin has_text_shrinked:(BOOL)has_text_shrinked has_fixedsize_for_print:(BOOL)has_fixedsize_for_print start_page_number:(int)start_page_number content:(FSHeaderFooterContent *)content is_to_embed_font:(BOOL)is_to_embed_font is_underline:(BOOL)is_underline;
		[Export ("initWithFont:text_size:text_color:page_range:page_margin:has_text_shrinked:has_fixedsize_for_print:start_page_number:content:is_to_embed_font:is_underline:")]
		IntPtr Constructor (FSFont font, float text_size, uint text_color, FSPageNumberRange page_range, FSRectF page_margin, bool has_text_shrinked, bool has_fixedsize_for_print, int start_page_number, FSHeaderFooterContent content, bool is_to_embed_font, bool is_underline);

		// -(id)initWithOther:(FSHeaderFooter *)other;
		[Export ("initWithOther:")]
		IntPtr Constructor (FSHeaderFooter other);

		// -(void)set:(FSFont *)font text_size:(float)text_size text_color:(unsigned int)text_color page_range:(FSPageNumberRange *)page_range page_margin:(FSRectF *)page_margin has_text_shrinked:(BOOL)has_text_shrinked has_fixedsize_for_print:(BOOL)has_fixedsize_for_print start_page_number:(int)start_page_number content:(FSHeaderFooterContent *)content is_to_embed_font:(BOOL)is_to_embed_font is_underline:(BOOL)is_underline;
		[Export ("set:text_size:text_color:page_range:page_margin:has_text_shrinked:has_fixedsize_for_print:start_page_number:content:is_to_embed_font:is_underline:")]
		void Set (FSFont font, float text_size, uint text_color, FSPageNumberRange page_range, FSRectF page_margin, bool has_text_shrinked, bool has_fixedsize_for_print, int start_page_number, FSHeaderFooterContent content, bool is_to_embed_font, bool is_underline);

		// -(void)dealloc;
		[Export ("dealloc")]
		void Dealloc ();
	}

	// @interface FSHeaderFooterContentGenerator : FSBase
	[BaseType (typeof(FSBase))]
	interface FSHeaderFooterContentGenerator
	{
		// -(void *)getCptr;
		[Export ("getCptr")]
		//[Verify (MethodToProperty)]
		IntPtr Cptr { get; }

		// -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
		[Export ("initWithCptr:swigOwnCObject:")]
		IntPtr Constructor (IntPtr cptr, bool ownCObject);

		// -(id)initWithOther:(FSHeaderFooterContentGenerator *)other;
		[Export ("initWithOther:")]
		IntPtr Constructor (FSHeaderFooterContentGenerator other);

		// -(BOOL)isEmpty;
		[Export ("isEmpty")]
		//[Verify (MethodToProperty)]
		bool IsEmpty { get; }

		// -(void)addDate:(FSHeaderFooterContentGeneratorDateFormatType)format_type;
		[Export ("addDate:")]
		void AddDate (FSHeaderFooterContentGeneratorDateFormatType format_type);

		// -(void)addPageNumber:(FSHeaderFooterContentGeneratorPageNumberFormat)format_type;
		[Export ("addPageNumber:")]
		void AddPageNumber (FSHeaderFooterContentGeneratorPageNumberFormat format_type);

		// -(void)addString:(NSString *)new_string;
		[Export ("addString:")]
		void AddString (string new_string);

		// -(void)clear;
		[Export ("clear")]
		void Clear ();

		// -(NSString *)generateContent;
		[Export ("generateContent")]
		//[Verify (MethodToProperty)]
		string GenerateContent ();

		// -(void)dealloc;
		[Export ("dealloc")]
		void Dealloc ();
	}

	// @interface FSTiledWatermarkSettings : NSObject
	[BaseType (typeof(NSObject))]
	interface FSTiledWatermarkSettings
	{
		// @property (getter = getRow_space, nonatomic) float row_space;
		[Export ("row_space")]
		float Row_space { [Bind ("getRow_space")] get; set; }

		// @property (getter = getCol_space, nonatomic) float col_space;
		[Export ("col_space")]
		float Col_space { [Bind ("getCol_space")] get; set; }

		// @property (getter = getRotation, nonatomic) float rotation;
		[Export ("rotation")]
		float Rotation { [Bind ("getRotation")] get; set; }

		// @property (getter = getOpacity, nonatomic) int opacity;
		[Export ("opacity")]
		int Opacity { [Bind ("getOpacity")] get; set; }

		// @property (getter = getScale, nonatomic) int scale;
		[Export ("scale")]
		int Scale { [Bind ("getScale")] get; set; }

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

		// -(id)initWithRow_space:(float)row_space col_space:(float)col_space rotation:(float)rotation opacity:(int)opacity scale:(int)scale flags:(unsigned int)flags;
		[Export ("initWithRow_space:col_space:rotation:opacity:scale:flags:")]
		IntPtr Constructor (float row_space, float col_space, float rotation, int opacity, int scale, uint flags);

		// -(id)initWithSettings:(FSTiledWatermarkSettings *)settings;
		[Export ("initWithSettings:")]
		IntPtr Constructor (FSTiledWatermarkSettings settings);

		// -(void)set:(float)row_space col_space:(float)col_space rotation:(float)rotation opacity:(int)opacity scale:(int)scale flags:(unsigned int)flags;
		[Export ("set:col_space:rotation:opacity:scale:flags:")]
		void Set (float row_space, float col_space, float rotation, int opacity, int scale, uint flags);

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

		// @property (getter = getType, copy, nonatomic) NSString * type;
		[Export ("type")]
		string Type { [Bind ("getType")] get; set; }

		// @property (getter = getApp_id, copy, nonatomic) NSString * app_id;
		[Export ("app_id")]
		string App_id { [Bind ("getApp_id")] get; set; }

		// @property (getter = getUri, copy, nonatomic) NSString * uri;
		[Export ("uri")]
		string Uri { [Bind ("getUri")] get; set; }

		// @property (getter = getDescription, copy, nonatomic) NSString * description;
		[Export ("description")]
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

		// @property (getter = getCrypto_filter, copy, nonatomic) NSString * crypto_filter;
		[Export ("crypto_filter")]
		string Crypto_filter { [Bind ("getCrypto_filter")] get; set; }

		// @property (getter = getFile_name, copy, nonatomic) NSString * file_name;
		[Export ("file_name")]
		string File_name { [Bind ("getFile_name")] get; set; }

		// @property (getter = getFile_size, nonatomic) long long file_size;
		[Export ("file_size")]
		long File_size { [Bind ("getFile_size")] get; set; }

		// @property (getter = getDescription, copy, nonatomic) NSString * description;
		[Export ("description")]
		string Description { [Bind ("getDescription")] get; set; }

		// -(void *)getCptr;
		[Export ("getCptr")]
		//[Verify (MethodToProperty)]
		IntPtr Cptr { get; }

		// -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
		[Export ("initWithCptr:swigOwnCObject:")]
		IntPtr Constructor (IntPtr cptr, bool ownCObject);

		// -(id)initWithVersion:(float)version crypto_filter:(NSString *)crypto_filter file_name:(NSString *)file_name file_size:(long long)file_size description:(NSString *)description;
		[Export ("initWithVersion:crypto_filter:file_name:file_size:description:")]
		IntPtr Constructor (float version, string crypto_filter, string file_name, long file_size, string description);

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

	// @interface FSEmbeddedFontData : NSObject
	[BaseType (typeof(NSObject))]
	interface FSEmbeddedFontData
	{
		// @property (getter = getNonstandard_font_name_array, copy, nonatomic) NSArray<NSString *> * nonstandard_font_name_array;
		[Export ("nonstandard_font_name_array", ArgumentSemantic.Copy)]
		string[] Nonstandard_font_name_array { [Bind ("getNonstandard_font_name_array")] get; set; }

		// @property (getter = getStandard_font_name_array, copy, nonatomic) NSArray<NSString *> * standard_font_name_array;
		[Export ("standard_font_name_array", ArgumentSemantic.Copy)]
		string[] Standard_font_name_array { [Bind ("getStandard_font_name_array")] get; set; }

		// -(void *)getCptr;
		[Export ("getCptr")]
		//[Verify (MethodToProperty)]
		IntPtr Cptr { get; }

		// -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
		[Export ("initWithCptr:swigOwnCObject:")]
		IntPtr Constructor (IntPtr cptr, bool ownCObject);

		// -(id)initWithOther:(FSEmbeddedFontData *)other;
		[Export ("initWithOther:")]
		IntPtr Constructor (FSEmbeddedFontData other);

		// -(void)dealloc;
		[Export ("dealloc")]
		void Dealloc ();
	}

	// @interface FSTableOfContentsConfig : NSObject
	[BaseType (typeof(NSObject))]
	interface FSTableOfContentsConfig
	{
		// @property (getter = getTitle, copy, nonatomic) NSString * title;
		[Export ("title")]
		string Title { [Bind ("getTitle")] get; set; }

		// @property (getter = getBookmark_level_array, copy, nonatomic) FSInt32Array * bookmark_level_array;
		[Export ("bookmark_level_array", ArgumentSemantic.Copy)]
		FSInt32Array Bookmark_level_array { [Bind ("getBookmark_level_array")] get; set; }

		// @property (getter = getIs_show_serial_number, nonatomic) BOOL is_show_serial_number;
		[Export ("is_show_serial_number")]
		bool Is_show_serial_number { [Bind ("getIs_show_serial_number")] get; set; }

		// @property (getter = getInclude_toc_pages, nonatomic) BOOL include_toc_pages;
		[Export ("include_toc_pages")]
		bool Include_toc_pages { [Bind ("getInclude_toc_pages")] get; set; }

		// -(void *)getCptr;
		[Export ("getCptr")]
		//[Verify (MethodToProperty)]
		IntPtr Cptr { get; }

		// -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
		[Export ("initWithCptr:swigOwnCObject:")]
		IntPtr Constructor (IntPtr cptr, bool ownCObject);

		// -(id)initWithTitle:(NSString *)title bookmark_level_array:(FSInt32Array *)bookmark_level_array is_show_serial_number:(BOOL)is_show_serial_number include_toc_pages:(BOOL)include_toc_pages;
		[Export ("initWithTitle:bookmark_level_array:is_show_serial_number:include_toc_pages:")]
		IntPtr Constructor (string title, FSInt32Array bookmark_level_array, bool is_show_serial_number, bool include_toc_pages);

		// -(void)set:(NSString *)title bookmark_level_array:(FSInt32Array *)bookmark_level_array is_show_serial_number:(BOOL)is_show_serial_number include_toc_pages:(BOOL)include_toc_pages;
		[Export ("set:bookmark_level_array:is_show_serial_number:include_toc_pages:")]
		void Set (string title, FSInt32Array bookmark_level_array, bool is_show_serial_number, bool include_toc_pages);

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
		IntPtr Constructor (NSObject file_read, bool is_async);

		// -(id)initWithFile_read:(id<FSFileReaderCallback>)file_read;
		[Export ("initWithFile_read:")]
		IntPtr Constructor (NSObject file_read);

		// -(id)initWithOther:(FSPDFDoc *)other;
		[Export ("initWithOther:")]
		IntPtr Constructor (FSPDFDoc other);

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

		// -(FSErrorCode)load;
		[Export ("load")]
		//[Verify (MethodToProperty)]
		FSErrorCode Load ();

		// -(FSErrorCode)loadW:(NSString *)password;
		[Export ("loadW:")]
		FSErrorCode LoadW (string password);

		// -(FSErrorCode)loadW;
		[Export ("loadW")]
		//[Verify (MethodToProperty)]
		FSErrorCode LoadW ();

		// -(BOOL)reload;
		[Export ("reload")]
		//[Verify (MethodToProperty)]
		bool Reload { get; }

		// -(FSProgressive *)startLoad:(NSString *)password is_cache_stream:(BOOL)is_cache_stream pause:(id<FSPauseCallback>)pause;
		[Export ("startLoad:is_cache_stream:pause:")]
		FSProgressive StartLoad (string password, bool is_cache_stream, NSObject pause);

		// -(FSProgressive *)startLoad:(NSString *)password is_cache_stream:(BOOL)is_cache_stream;
		[Export ("startLoad:is_cache_stream:")]
		FSProgressive StartLoad (string password, bool is_cache_stream);

		// -(FSProgressive *)startLoad:(NSString *)password;
		[Export ("startLoad:")]
		FSProgressive StartLoad (string password);

		// -(FSProgressive *)startLoad;
		[Export ("startLoad")]
		//[Verify (MethodToProperty)]
		FSProgressive StartLoad ();

		// -(FSProgressive *)startLoadW:(NSString *)password is_cache_stream:(BOOL)is_cache_stream pause:(id<FSPauseCallback>)pause;
		[Export ("startLoadW:is_cache_stream:pause:")]
		FSProgressive StartLoadW (string password, bool is_cache_stream, NSObject pause);

		// -(FSProgressive *)startLoadW:(NSString *)password is_cache_stream:(BOOL)is_cache_stream;
		[Export ("startLoadW:is_cache_stream:")]
		FSProgressive StartLoadW (string password, bool is_cache_stream);

		// -(FSProgressive *)startLoadW:(NSString *)password;
		[Export ("startLoadW:")]
		FSProgressive StartLoadW (string password);

		// -(FSProgressive *)startLoadW;
		[Export ("startLoadW")]
		//[Verify (MethodToProperty)]
		FSProgressive StartLoadW ();

		// -(int)getFirstAvailPageIndex;
		[Export ("getFirstAvailPageIndex")]
		//[Verify (MethodToProperty)]
		int FirstAvailPageIndex { get; }

		// -(BOOL)isXFA;
		[Export ("isXFA")]
		//[Verify (MethodToProperty)]
		bool IsXFA { get; }

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

		// -(BOOL)isUserPassword:(NSString *)password;
		[Export ("isUserPassword:")]
		bool IsUserPassword (string password);

		// -(BOOL)isOwnerPassword:(NSString *)password;
		[Export ("isOwnerPassword:")]
		bool IsOwnerPassword (string password);

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

		// -(BOOL)saveAs:(NSString *)file_path;
		[Export ("saveAs:")]
		bool SaveAs (string file_path);

		// -(FSProgressive *)startSaveAs:(NSString *)file_path save_flags:(unsigned int)save_flags pause:(id<FSPauseCallback>)pause;
		[Export ("startSaveAs:save_flags:pause:")]
		FSProgressive StartSaveAs (string file_path, uint save_flags, NSObject pause);

		// -(FSProgressive *)startSaveAs:(NSString *)file_path save_flags:(unsigned int)save_flags;
		[Export ("startSaveAs:save_flags:")]
		FSProgressive StartSaveAs (string file_path, uint save_flags);

		// -(FSProgressive *)startSaveAs:(NSString *)file_path;
		[Export ("startSaveAs:")]
		FSProgressive StartSaveAs (string file_path);

		// -(FSProgressive *)startSaveAsWithWriterCallback:(id<FSFileWriterCallback>)file save_flags:(unsigned int)save_flags pause:(id<FSPauseCallback>)pause;
		[Export ("startSaveAsWithWriterCallback:save_flags:pause:")]
		FSProgressive StartSaveAsWithWriterCallback (NSObject file, uint save_flags, NSObject pause);

		// -(FSProgressive *)startSaveAsWithWriterCallback:(id<FSFileWriterCallback>)file save_flags:(unsigned int)save_flags;
		[Export ("startSaveAsWithWriterCallback:save_flags:")]
		FSProgressive StartSaveAsWithWriterCallback (NSObject file, uint save_flags);

		// -(FSProgressive *)startSaveAsWithWriterCallback:(id<FSFileWriterCallback>)file;
		[Export ("startSaveAsWithWriterCallback:")]
		FSProgressive StartSaveAsWithWriterCallback (NSObject file);

		// -(FSBookmark *)getRootBookmark;
		[Export ("getRootBookmark")]
		//[Verify (MethodToProperty)]
		FSBookmark RootBookmark { get; }

		// -(FSBookmark *)createRootBookmark;
		[Export ("createRootBookmark")]
		//[Verify (MethodToProperty)]
		FSBookmark CreateRootBookmark { get; }

		// -(int)getBookmarkLevelDepth;
		[Export ("getBookmarkLevelDepth")]
		//[Verify (MethodToProperty)]
		int BookmarkLevelDepth { get; }

		// -(BOOL)removeBookmark:(FSBookmark *)bookmark;
		[Export ("removeBookmark:")]
		bool RemoveBookmark (FSBookmark bookmark);

		// -(BOOL)hasLayer;
		[Export ("hasLayer")]
		//[Verify (MethodToProperty)]
		bool HasLayer { get; }

		// -(BOOL)hasHeaderFooter;
		[Export ("hasHeaderFooter")]
		//[Verify (MethodToProperty)]
		bool HasHeaderFooter { get; }

		// -(FSHeaderFooter *)getEditableHeaderFooter;
		[Export ("getEditableHeaderFooter")]
		//[Verify (MethodToProperty)]
		FSHeaderFooter EditableHeaderFooter { get; }

		// -(void)addHeaderFooter:(FSHeaderFooter *)headerfooter;
		[Export ("addHeaderFooter:")]
		void AddHeaderFooter (FSHeaderFooter headerfooter);

		// -(void)updateHeaderFooter:(FSHeaderFooter *)headerfooter;
		[Export ("updateHeaderFooter:")]
		void UpdateHeaderFooter (FSHeaderFooter headerfooter);

		// -(BOOL)removeAllHeaderFooters;
		[Export ("removeAllHeaderFooters")]
		//[Verify (MethodToProperty)]
		bool RemoveAllHeaderFooters { get; }

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
		FSProgressive StartGetPayloadFile (NSObject payload_file, NSObject pause);

		// -(FSProgressive *)startGetPayloadFile:(id<FSFileWriterCallback>)payload_file;
		[Export ("startGetPayloadFile:")]
		FSProgressive StartGetPayloadFile (NSObject payload_file);

		// -(BOOL)saveAsWrapperFile:(NSString *)file_path wrapper_data:(FSWrapperData *)wrapper_data user_permissions:(unsigned int)user_permissions owner_password:(NSString *)owner_password;
		[Export ("saveAsWrapperFile:wrapper_data:user_permissions:owner_password:")]
		bool SaveAsWrapperFile (string file_path, FSWrapperData wrapper_data, uint user_permissions, string owner_password);

		// -(BOOL)saveAsWrapperFile:(NSString *)file_path wrapper_data:(FSWrapperData *)wrapper_data user_permissions:(unsigned int)user_permissions;
		[Export ("saveAsWrapperFile:wrapper_data:user_permissions:")]
		bool SaveAsWrapperFile (string file_path, FSWrapperData wrapper_data, uint user_permissions);

		// -(BOOL)saveAsWrapperFile:(NSString *)file_path wrapper_data:(FSWrapperData *)wrapper_data;
		[Export ("saveAsWrapperFile:wrapper_data:")]
		bool SaveAsWrapperFile (string file_path, FSWrapperData wrapper_data);

		// -(BOOL)saveAsWrapperFile:(NSString *)file_path;
		[Export ("saveAsWrapperFile:")]
		bool SaveAsWrapperFile (string file_path);

		// -(FSProgressive *)startSaveAsPayloadFile:(NSString *)file_path payload_file_path:(NSString *)payload_file_path crypto_filter:(NSString *)crypto_filter description:(NSString *)description version:(float)version save_flags:(unsigned int)save_flags pause:(id<FSPauseCallback>)pause;
		[Export ("startSaveAsPayloadFile:payload_file_path:crypto_filter:description:version:save_flags:pause:")]
		FSProgressive StartSaveAsPayloadFile (string file_path, string payload_file_path, string crypto_filter, string description, float version, uint save_flags, NSObject pause);

		// -(FSProgressive *)startSaveAsPayloadFile:(NSString *)file_path payload_file_path:(NSString *)payload_file_path crypto_filter:(NSString *)crypto_filter description:(NSString *)description version:(float)version save_flags:(unsigned int)save_flags;
		[Export ("startSaveAsPayloadFile:payload_file_path:crypto_filter:description:version:save_flags:")]
		FSProgressive StartSaveAsPayloadFile (string file_path, string payload_file_path, string crypto_filter, string description, float version, uint save_flags);

		// -(FSProgressive *)startSaveAsPayloadFile:(NSString *)file_path payload_file_path:(NSString *)payload_file_path crypto_filter:(NSString *)crypto_filter description:(NSString *)description version:(float)version;
		[Export ("startSaveAsPayloadFile:payload_file_path:crypto_filter:description:version:")]
		FSProgressive StartSaveAsPayloadFile (string file_path, string payload_file_path, string crypto_filter, string description, float version);

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

		// -(void)enableUpdatePageLabel:(BOOL)enable_update_page_label;
		[Export ("enableUpdatePageLabel:")]
		void EnableUpdatePageLabel (bool enable_update_page_label);

		// -(FSPDFPage *)insertPage:(int)index width:(float)width height:(float)height;
		[Export ("insertPage:width:height:")]
		FSPDFPage InsertPage (int index, float width, float height);

		// -(FSPDFPage *)insertPageSize:(int)index size:(FSPDFPageSize)size;
		[Export ("insertPageSize:size:")]
		FSPDFPage InsertPageSize (int index, FSPDFPageSize size);

		// -(FSPDFPage *)insertPage:(int)index;
		[Export ("insertPage:")]
		FSPDFPage InsertPage (int index);

		// -(FSPDFPage *)addPageFromTemplate:(NSString *)template_name;
		[Export ("addPageFromTemplate:")]
		FSPDFPage AddPageFromTemplate (string template_name);

		// -(BOOL)hidePageTemplate:(NSString *)template_name;
		[Export ("hidePageTemplate:")]
		bool HidePageTemplate (string template_name);

		// -(BOOL)removePage:(int)index;
		[Export ("removePage:")]
		bool RemovePage (int index);

		// -(BOOL)removePageWithPage:(FSPDFPage *)page;
		[Export ("removePageWithPage:")]
		bool RemovePageWithPage (FSPDFPage page);

		// -(BOOL)movePageTo:(FSPDFPage *)page dest_index:(int)dest_index;
		[Export ("movePageTo:dest_index:")]
		bool MovePageTo (FSPDFPage page, int dest_index);

		// -(BOOL)movePagesTo:(FSRange *)page_range dest_index:(int)dest_index;
		[Export ("movePagesTo:dest_index:")]
		bool MovePagesTo (FSRange page_range, int dest_index);

		// -(FSProgressive *)startImportPagesFromFilePath:(int)dest_index src_file_path:(NSString *)src_file_path password:(NSString *)password flags:(unsigned int)flags layer_name:(NSString *)layer_name page_range:(FSRange *)page_range pause:(id<FSPauseCallback>)pause;
		[Export ("startImportPagesFromFilePath:src_file_path:password:flags:layer_name:page_range:pause:")]
		FSProgressive StartImportPagesFromFilePath (int dest_index, string src_file_path, string password, uint flags, string layer_name, FSRange page_range, NSObject pause);

		// -(FSProgressive *)startImportPagesFromFilePath:(int)dest_index src_file_path:(NSString *)src_file_path password:(NSString *)password flags:(unsigned int)flags layer_name:(NSString *)layer_name page_range:(FSRange *)page_range;
		[Export ("startImportPagesFromFilePath:src_file_path:password:flags:layer_name:page_range:")]
		FSProgressive StartImportPagesFromFilePath (int dest_index, string src_file_path, string password, uint flags, string layer_name, FSRange page_range);

		// -(FSProgressive *)startImportPagesFromFilePath:(int)dest_index src_file_path:(NSString *)src_file_path password:(NSString *)password flags:(unsigned int)flags layer_name:(NSString *)layer_name;
		[Export ("startImportPagesFromFilePath:src_file_path:password:flags:layer_name:")]
		FSProgressive StartImportPagesFromFilePath (int dest_index, string src_file_path, string password, uint flags, string layer_name);

		// -(FSProgressive *)startImportPagesFromFilePath:(int)dest_index src_file_path:(NSString *)src_file_path password:(NSString *)password flags:(unsigned int)flags;
		[Export ("startImportPagesFromFilePath:src_file_path:password:flags:")]
		FSProgressive StartImportPagesFromFilePath (int dest_index, string src_file_path, string password, uint flags);

		// -(FSProgressive *)startImportPagesFromFilePath:(int)dest_index src_file_path:(NSString *)src_file_path password:(NSString *)password;
		[Export ("startImportPagesFromFilePath:src_file_path:password:")]
		FSProgressive StartImportPagesFromFilePath (int dest_index, string src_file_path, string password);

		// -(FSProgressive *)startImportPages:(int)dest_index src_doc:(FSPDFDoc *)src_doc flags:(unsigned int)flags layer_name:(NSString *)layer_name page_range:(FSRange *)page_range pause:(id<FSPauseCallback>)pause;
		[Export ("startImportPages:src_doc:flags:layer_name:page_range:pause:")]
		FSProgressive StartImportPages (int dest_index, FSPDFDoc src_doc, uint flags, string layer_name, FSRange page_range, NSObject pause);

		// -(FSProgressive *)startImportPages:(int)dest_index src_doc:(FSPDFDoc *)src_doc flags:(unsigned int)flags layer_name:(NSString *)layer_name page_range:(FSRange *)page_range;
		[Export ("startImportPages:src_doc:flags:layer_name:page_range:")]
		FSProgressive StartImportPages (int dest_index, FSPDFDoc src_doc, uint flags, string layer_name, FSRange page_range);

		// -(FSProgressive *)startImportPages:(int)dest_index src_doc:(FSPDFDoc *)src_doc flags:(unsigned int)flags layer_name:(NSString *)layer_name;
		[Export ("startImportPages:src_doc:flags:layer_name:")]
		FSProgressive StartImportPages (int dest_index, FSPDFDoc src_doc, uint flags, string layer_name);

		// -(FSProgressive *)startImportPages:(int)dest_index src_doc:(FSPDFDoc *)src_doc flags:(unsigned int)flags;
		[Export ("startImportPages:src_doc:flags:")]
		FSProgressive StartImportPages (int dest_index, FSPDFDoc src_doc, uint flags);

		// -(FSProgressive *)startImportPages:(int)dest_index src_doc:(FSPDFDoc *)src_doc;
		[Export ("startImportPages:src_doc:")]
		FSProgressive StartImportPages (int dest_index, FSPDFDoc src_doc);

		// -(FSProgressive *)startExtractPages:(NSString *)file_path options:(unsigned int)options page_range:(FSRange *)page_range pause:(id<FSPauseCallback>)pause;
		[Export ("startExtractPages:options:page_range:pause:")]
		FSProgressive StartExtractPages (string file_path, uint options, FSRange page_range, NSObject pause);

		// -(FSProgressive *)startExtractPages:(NSString *)file_path options:(unsigned int)options page_range:(FSRange *)page_range;
		[Export ("startExtractPages:options:page_range:")]
		FSProgressive StartExtractPages (string file_path, uint options, FSRange page_range);

		// -(FSProgressive *)startExtractPages:(NSString *)file_path options:(unsigned int)options;
		[Export ("startExtractPages:options:")]
		FSProgressive StartExtractPages (string file_path, uint options);

		// -(FSProgressive *)startExtractPagesWithWriterCallback:(id<FSFileWriterCallback>)file options:(unsigned int)options page_range:(FSRange *)page_range pause:(id<FSPauseCallback>)pause;
		[Export ("startExtractPagesWithWriterCallback:options:page_range:pause:")]
		FSProgressive StartExtractPagesWithWriterCallback (NSObject file, uint options, FSRange page_range, NSObject pause);

		// -(FSProgressive *)startExtractPagesWithWriterCallback:(id<FSFileWriterCallback>)file options:(unsigned int)options page_range:(FSRange *)page_range;
		[Export ("startExtractPagesWithWriterCallback:options:page_range:")]
		FSProgressive StartExtractPagesWithWriterCallback (NSObject file, uint options, FSRange page_range);

		// -(FSProgressive *)startExtractPagesWithWriterCallback:(id<FSFileWriterCallback>)file options:(unsigned int)options;
		[Export ("startExtractPagesWithWriterCallback:options:")]
		FSProgressive StartExtractPagesWithWriterCallback (NSObject file, uint options);

		// -(void)insertDocument:(int)dest_index src_doc:(FSPDFDoc *)src_doc options:(unsigned int)options;
		[Export ("insertDocument:src_doc:options:")]
		void InsertDocument (int dest_index, FSPDFDoc src_doc, uint options);

		// -(BOOL)importFromFDF:(FSFDFDoc *)fdf_doc types:(int)types page_range:(FSRange *)page_range;
		[Export ("importFromFDF:types:page_range:")]
		bool ImportFromFDF (FSFDFDoc fdf_doc, int types, FSRange page_range);

		// -(BOOL)importFromFDF:(FSFDFDoc *)fdf_doc types:(int)types;
		[Export ("importFromFDF:types:")]
		bool ImportFromFDF (FSFDFDoc fdf_doc, int types);

		// -(BOOL)importFromFDF:(FSFDFDoc *)fdf_doc;
		[Export ("importFromFDF:")]
		bool ImportFromFDF (FSFDFDoc fdf_doc);

		// -(BOOL)exportToFDF:(FSFDFDoc *)fdf_doc types:(int)types page_range:(FSRange *)page_range;
		[Export ("exportToFDF:types:page_range:")]
		bool ExportToFDF (FSFDFDoc fdf_doc, int types, FSRange page_range);

		// -(BOOL)exportToFDF:(FSFDFDoc *)fdf_doc types:(int)types;
		[Export ("exportToFDF:types:")]
		bool ExportToFDF (FSFDFDoc fdf_doc, int types);

		// -(BOOL)exportToFDF:(FSFDFDoc *)fdf_doc;
		[Export ("exportToFDF:")]
		bool ExportToFDF (FSFDFDoc fdf_doc);

		// -(BOOL)exportAnnotToFDF:(FSAnnot *)pdf_annot fdf_doc:(FSFDFDoc *)fdf_doc;
		[Export ("exportAnnotToFDF:fdf_doc:")]
		bool ExportAnnotToFDF (FSAnnot pdf_annot, FSFDFDoc fdf_doc);

		// -(BOOL)exportFormFieldsToFDF:(FSFieldArray *)field_array is_include:(BOOL)is_include fdf_doc:(FSFDFDoc *)fdf_doc;
		[Export ("exportFormFieldsToFDF:is_include:fdf_doc:")]
		bool ExportFormFieldsToFDF (FSFieldArray field_array, bool is_include, FSFDFDoc fdf_doc);

		// -(NSString *)getHeader;
		[Export ("getHeader")]
		//[Verify (MethodToProperty)]
		string Header { get; }

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

		// -(FSEmbeddedFontData *)getEmbeddedFontData;
		[Export ("getEmbeddedFontData")]
		//[Verify (MethodToProperty)]
		FSEmbeddedFontData EmbeddedFontData { get; }

		// -(void)createDSS;
		[Export ("createDSS")]
		void CreateDSS ();

		// -(void)addTableOfContentsWithTitle:(NSString *)title bookmark_level_array:(FSInt32Array *)bookmark_level_array;
		[Export ("addTableOfContentsWithTitle:bookmark_level_array:")]
		void AddTableOfContentsWithTitle (string title, FSInt32Array bookmark_level_array);

		// -(void)addTableOfContents:(FSTableOfContentsConfig *)table_of_contents_config;
		[Export ("addTableOfContents:")]
		void AddTableOfContents (FSTableOfContentsConfig table_of_contents_config);

		// -(void)setCacheFile:(id<FSStreamCallback>)file_stream is_own_file_stream:(BOOL)is_own_file_stream;
		[Export ("setCacheFile:is_own_file_stream:")]
		void SetCacheFile (NSObject file_stream, bool is_own_file_stream);

		// -(FSProgressive *)startRecognizeForm:(id<FSPauseCallback>)pause;
		[Export ("startRecognizeForm:")]
		FSProgressive StartRecognizeForm (NSObject pause);

		// -(FSProgressive *)startRecognizeForm;
		[Export ("startRecognizeForm")]
		//[Verify (MethodToProperty)]
		FSProgressive StartRecognizeForm ();

		// -(NSString *)getPageText:(int)page_index;
		[Export ("getPageText:")]
		string GetPageText (int page_index);

		// -(FSPagingSealSignature *)addPagingSealSignature:(FSRange *)page_range width:(float)width height:(float)height;
		[Export ("addPagingSealSignature:width:height:")]
		FSPagingSealSignature AddPagingSealSignature (FSRange page_range, float width, float height);

		// -(FSProgressive *)startEmbedAllFonts:(id<FSPauseCallback>)pause;
		[Export ("startEmbedAllFonts:")]
		FSProgressive StartEmbedAllFonts (NSObject pause);

		// -(FSProgressive *)startEmbedAllFonts;
		[Export ("startEmbedAllFonts")]
		//[Verify (MethodToProperty)]
		FSProgressive StartEmbedAllFonts ();

		// -(FSProgressive *)startAddTiledWatermark:(NSString *)text settings:(FSTiledWatermarkSettings *)settings properties:(FSWatermarkTextProperties *)properties page_range:(FSRange *)page_range pause:(id<FSPauseCallback>)pause;
		[Export ("startAddTiledWatermark:settings:properties:page_range:pause:")]
		FSProgressive StartAddTiledWatermark (string text, FSTiledWatermarkSettings settings, FSWatermarkTextProperties properties, FSRange page_range, NSObject pause);

		// -(FSProgressive *)startAddTiledWatermark:(NSString *)text settings:(FSTiledWatermarkSettings *)settings properties:(FSWatermarkTextProperties *)properties page_range:(FSRange *)page_range;
		[Export ("startAddTiledWatermark:settings:properties:page_range:")]
		FSProgressive StartAddTiledWatermark (string text, FSTiledWatermarkSettings settings, FSWatermarkTextProperties properties, FSRange page_range);

		// -(FSProgressive *)startAddTiledWatermark:(NSString *)src_img_file_path settings:(FSTiledWatermarkSettings *)settings page_range:(FSRange *)page_range pause:(id<FSPauseCallback>)pause;
		[Export ("startAddTiledWatermark:settings:page_range:pause:")]
		FSProgressive StartAddTiledWatermark (string src_img_file_path, FSTiledWatermarkSettings settings, FSRange page_range, NSObject pause);

		// -(FSProgressive *)startAddTiledWatermark:(NSString *)src_img_file_path settings:(FSTiledWatermarkSettings *)settings page_range:(FSRange *)page_range;
		[Export ("startAddTiledWatermark:settings:page_range:")]
		FSProgressive StartAddTiledWatermark (string src_img_file_path, FSTiledWatermarkSettings settings, FSRange page_range);

		// -(FSProgressive *)startAddTiledWatermarkWithSrcImgStream:(id<FSFileReaderCallback>)src_img_stream settings:(FSTiledWatermarkSettings *)settings page_range:(FSRange *)page_range pause:(id<FSPauseCallback>)pause;
		[Export ("startAddTiledWatermarkWithSrcImgStream:settings:page_range:pause:")]
		FSProgressive StartAddTiledWatermarkWithSrcImgStream (NSObject src_img_stream, FSTiledWatermarkSettings settings, FSRange page_range, NSObject pause);

		// -(FSProgressive *)startAddTiledWatermarkWithSrcImgStream:(id<FSFileReaderCallback>)src_img_stream settings:(FSTiledWatermarkSettings *)settings page_range:(FSRange *)page_range;
		[Export ("startAddTiledWatermarkWithSrcImgStream:settings:page_range:")]
		FSProgressive StartAddTiledWatermarkWithSrcImgStream (NSObject src_img_stream, FSTiledWatermarkSettings settings, FSRange page_range);

		// -(FSProgressive *)startAddTiledWatermarkWithpage:(FSPDFPage *)page settings:(FSTiledWatermarkSettings *)settings page_range:(FSRange *)page_range pause:(id<FSPauseCallback>)pause;
		[Export ("startAddTiledWatermarkWithpage:settings:page_range:pause:")]
		FSProgressive StartAddTiledWatermarkWithpage (FSPDFPage page, FSTiledWatermarkSettings settings, FSRange page_range, NSObject pause);

		// -(FSProgressive *)startAddTiledWatermarkWithpage:(FSPDFPage *)page settings:(FSTiledWatermarkSettings *)settings page_range:(FSRange *)page_range;
		[Export ("startAddTiledWatermarkWithpage:settings:page_range:")]
		FSProgressive StartAddTiledWatermarkWithpage (FSPDFPage page, FSTiledWatermarkSettings settings, FSRange page_range);

		// -(FSAnnotArray *)getAnnotsByIdArray:(NSArray<NSString *> *)unique_id_arr;
		[Export ("getAnnotsByIdArray:")]
		FSAnnotArray GetAnnotsByIdArray (string[] unique_id_arr);

		// -(void)loadAnnotsFonts:(FSRange *)page_range;
		[Export ("loadAnnotsFonts:")]
		void LoadAnnotsFonts (FSRange page_range);

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
		// @property (getter = getFileName, copy, nonatomic) NSString * fileName;
		[Export ("fileName")]
		string FileName { [Bind ("getFileName")] get; set; }

		// @property (getter = getAssociteFileRelationship, nonatomic) FSAssociatedFilesRelationship associteFileRelationship;
		[Export ("associteFileRelationship", ArgumentSemantic.Assign)]
		FSAssociatedFilesRelationship AssociteFileRelationship { [Bind ("getAssociteFileRelationship")] get; set; }

		// @property (getter = getDescription, copy, nonatomic) NSString * description;
		[Export ("description")]
		string Description { [Bind ("getDescription")] get; set; }

		// @property (getter = getDescriptionW, copy, nonatomic) NSString * descriptionW;
		[Export ("descriptionW")]
		string DescriptionW { [Bind ("getDescriptionW")] get; set; }

		// @property (getter = getCreationDateTime, copy, nonatomic) FSDateTime * creationDateTime;
		[Export ("creationDateTime", ArgumentSemantic.Copy)]
		FSDateTime CreationDateTime { [Bind ("getCreationDateTime")] get; set; }

		// @property (getter = getModifiedDateTime, copy, nonatomic) FSDateTime * modifiedDateTime;
		[Export ("modifiedDateTime", ArgumentSemantic.Copy)]
		FSDateTime ModifiedDateTime { [Bind ("getModifiedDateTime")] get; set; }

		// @property (getter = getSubtype, copy, nonatomic) NSString * subtype;
		[Export ("subtype")]
		string Subtype { [Bind ("getSubtype")] get; set; }

		// @property (getter = getChecksum, copy, nonatomic) NSData * checksum;
		[Export ("checksum", ArgumentSemantic.Copy)]
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

		// -(long long)getCompressedEmbeddedFileSize;
		[Export ("getCompressedEmbeddedFileSize")]
		//[Verify (MethodToProperty)]
		long CompressedEmbeddedFileSize { get; }

		// -(id<FSFileReaderCallback>)getFileData;
		[Export ("getFileData")]
		//[Verify (MethodToProperty)]
		NSObject FileData { get; }

		// -(BOOL)embed:(NSString *)file_path;
		[Export ("embed:")]
		bool Embed (string file_path);

		// -(BOOL)embedWithPdfObject:(FSPDFObject *)pdf_object;
		[Export ("embedWithPdfObject:")]
		bool EmbedWithPdfObject (FSPDFObject pdf_object);

		// -(BOOL)embedWithStreamCallback:(id<FSStreamCallback>)stream;
		[Export ("embedWithStreamCallback:")]
		bool EmbedWithStreamCallback (NSObject stream);

		// -(BOOL)isEmbedded;
		[Export ("isEmbedded")]
		//[Verify (MethodToProperty)]
		bool IsEmbedded { get; }

		// -(void)setSubtype;
		[Export ("setSubtype")]
		void SetSubtype ();

		// -(FSPDFDictionary *)getDict;
		[Export ("getDict")]
		//[Verify (MethodToProperty)]
		FSPDFDictionary Dict { get; }

		// -(BOOL)exportToFile:(NSString *)path;
		[Export ("exportToFile:")]
		bool ExportToFile (string path);

		// -(BOOL)exportToFileStream:(id<FSStreamCallback>)stream;
		[Export ("exportToFileStream:")]
		bool ExportToFileStream (NSObject stream);

		// -(void)dealloc;
		[Export ("dealloc")]
		void Dealloc ();
	}

	// @interface FSTextFillSignObjectData : FSBase
	[BaseType (typeof(FSBase))]
	interface FSTextFillSignObjectData
	{
		// @property (getter = getText_state, copy, nonatomic) FSTextState * text_state;
		[Export ("text_state", ArgumentSemantic.Copy)]
		FSTextState Text_state { [Bind ("getText_state")] get; set; }

		// @property (getter = getText, copy, nonatomic) NSString * text;
		[Export ("text")]
		string Text { [Bind ("getText")] get; set; }

		// -(void *)getCptr;
		[Export ("getCptr")]
		//[Verify (MethodToProperty)]
		IntPtr Cptr { get; }

		// -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
		[Export ("initWithCptr:swigOwnCObject:")]
		IntPtr Constructor (IntPtr cptr, bool ownCObject);

		// -(id)initWithText_state:(FSTextState *)text_state text:(NSString *)text;
		[Export ("initWithText_state:text:")]
		IntPtr Constructor (FSTextState text_state, string text);

		// -(id)initWithText_data:(FSTextFillSignObjectData *)text_data;
		[Export ("initWithText_data:")]
		IntPtr Constructor (FSTextFillSignObjectData text_data);

		// -(void)set:(FSTextState *)text_state text:(NSString *)text;
		[Export ("set:text:")]
		void Set (FSTextState text_state, string text);

		// -(void)dealloc;
		[Export ("dealloc")]
		void Dealloc ();
	}

	// @interface FSTextFillSignObjectDataArray : NSObject
	[BaseType (typeof(NSObject))]
	interface FSTextFillSignObjectDataArray
	{
		// -(void *)getCptr;
		[Export ("getCptr")]
		//[Verify (MethodToProperty)]
		IntPtr Cptr { get; }

		// -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
		[Export ("initWithCptr:swigOwnCObject:")]
		IntPtr Constructor (IntPtr cptr, bool ownCObject);

		// -(id)initWithOther:(FSTextFillSignObjectDataArray *)other;
		[Export ("initWithOther:")]
		IntPtr Constructor (FSTextFillSignObjectDataArray other);

		// -(unsigned long)getSize;
		[Export ("getSize")]
		//[Verify (MethodToProperty)]
		nuint Size { get; }

		// -(FSTextFillSignObjectData *)getAt:(unsigned long)index;
		[Export ("getAt:")]
		FSTextFillSignObjectData GetAt (nuint index);

		// -(void)add:(FSTextFillSignObjectData *)element;
		[Export ("add:")]
		void Add (FSTextFillSignObjectData element);

		// -(void)removeAt:(unsigned long)index;
		[Export ("removeAt:")]
		void RemoveAt (nuint index);

		// -(void)insertAt:(unsigned long)index element:(FSTextFillSignObjectData *)element;
		[Export ("insertAt:element:")]
		void InsertAt (nuint index, FSTextFillSignObjectData element);

		// -(void)removeAll;
		[Export ("removeAll")]
		void RemoveAll ();

		// -(void)dealloc;
		[Export ("dealloc")]
		void Dealloc ();
	}

	// @interface FSFillSign : FSBase
	[BaseType (typeof(FSBase))]
	[DisableDefaultCtor]
	interface FSFillSign
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

		// -(id)initWithOther:(FSFillSign *)other;
		[Export ("initWithOther:")]
		IntPtr Constructor (FSFillSign other);

		// -(BOOL)isEmpty;
		[Export ("isEmpty")]
		//[Verify (MethodToProperty)]
		bool IsEmpty { get; }

		// -(FSFillSignObject *)addObject:(FSFillSignFillSignObjectType)type point:(FSPointF *)point width:(float)width height:(float)height rotation:(FSRotation)rotation;
		[Export ("addObject:point:width:height:rotation:")]
		FSFillSignObject AddObject (FSFillSignFillSignObjectType type, FSPointF point, float width, float height, FSRotation rotation);

		// -(FSFillSignObject *)addObject:(FSFillSignFillSignObjectType)type point:(FSPointF *)point width:(float)width height:(float)height;
		[Export ("addObject:point:width:height:")]
		FSFillSignObject AddObject (FSFillSignFillSignObjectType type, FSPointF point, float width, float height);

		// -(FSFillSignObject *)addTextObject:(FSTextFillSignObjectDataArray *)text_data point:(FSPointF *)point width:(float)width height:(float)height rotation:(FSRotation)rotation is_comb_field_mode:(BOOL)is_comb_field_mode;
		[Export ("addTextObject:point:width:height:rotation:is_comb_field_mode:")]
		FSFillSignObject AddTextObject (FSTextFillSignObjectDataArray text_data, FSPointF point, float width, float height, FSRotation rotation, bool is_comb_field_mode);

		// -(FSFillSignObject *)addTextObject:(FSTextFillSignObjectDataArray *)text_data point:(FSPointF *)point width:(float)width height:(float)height rotation:(FSRotation)rotation;
		[Export ("addTextObject:point:width:height:rotation:")]
		FSFillSignObject AddTextObject (FSTextFillSignObjectDataArray text_data, FSPointF point, float width, float height, FSRotation rotation);

		// -(FSFillSignObject *)addTextObject:(FSTextFillSignObjectDataArray *)text_data point:(FSPointF *)point width:(float)width height:(float)height;
		[Export ("addTextObject:point:width:height:")]
		FSFillSignObject AddTextObject (FSTextFillSignObjectDataArray text_data, FSPointF point, float width, float height);

		// -(BOOL)removeObject:(FSFillSignObject *)fillsign_object;
		[Export ("removeObject:")]
		bool RemoveObject (FSFillSignObject fillsign_object);

		// -(FSFillSignObject *)getObjectAtPoint:(FSPointF *)point;
		[Export ("getObjectAtPoint:")]
		FSFillSignObject GetObjectAtPoint (FSPointF point);

		// -(FSFillSignObject *)getObjectAtDevicePoint:(FSPointF *)point matrix:(FSMatrix2D *)matrix;
		[Export ("getObjectAtDevicePoint:matrix:")]
		FSFillSignObject GetObjectAtDevicePoint (FSPointF point, FSMatrix2D matrix);

		// -(FSFillSignObject *)getObjectByFormXObject:(FSFormXObject *)formobject;
		[Export ("getObjectByFormXObject:")]
		FSFillSignObject GetObjectByFormXObject (FSFormXObject formobject);

		// -(void)dealloc;
		[Export ("dealloc")]
		void Dealloc ();
	}

	// @interface FSFillSignObject : FSBase
	[BaseType (typeof(FSBase))]
	interface FSFillSignObject
	{
		// -(void *)getCptr;
		[Export ("getCptr")]
		//[Verify (MethodToProperty)]
		IntPtr Cptr { get; }

		// -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
		[Export ("initWithCptr:swigOwnCObject:")]
		IntPtr Constructor (IntPtr cptr, bool ownCObject);

		// -(id)initWithOther:(FSFillSignObject *)other;
		[Export ("initWithOther:")]
		IntPtr Constructor (FSFillSignObject other);

		// -(BOOL)isEmpty;
		[Export ("isEmpty")]
		//[Verify (MethodToProperty)]
		bool IsEmpty { get; }

		// -(FSFillSignFillSignObjectType)getType;
		[Export ("getType")]
		//[Verify (MethodToProperty)]
		FSFillSignFillSignObjectType Type { get; }

		// -(void)move:(FSPointF *)point width:(float)width height:(float)height rotation:(FSRotation)rotation;
		[Export ("move:width:height:rotation:")]
		void Move (FSPointF point, float width, float height, FSRotation rotation);

		// -(void)move:(FSPointF *)point width:(float)width height:(float)height;
		[Export ("move:width:height:")]
		void Move (FSPointF point, float width, float height);

		// -(FSRectF *)getRect;
		[Export ("getRect")]
		//[Verify (MethodToProperty)]
		FSRectF Rect { get; }

		// -(BOOL)generateContent;
		[Export ("generateContent")]
		//[Verify (MethodToProperty)]
		bool GenerateContent ();

		// -(FSFormXObject *)getFormXObject;
		[Export ("getFormXObject")]
		//[Verify (MethodToProperty)]
		FSFormXObject FormXObject { get; }

		// -(void)dealloc;
		[Export ("dealloc")]
		void Dealloc ();
	}

	// @interface FSTextFillSignObject : FSFillSignObject
	[BaseType (typeof(FSFillSignObject))]
	interface FSTextFillSignObject
	{
		// -(void *)getCptr;
		[Export ("getCptr")]
		//[Verify (MethodToProperty)]
		IntPtr Cptr { get; }

		// -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
		[Export ("initWithCptr:swigOwnCObject:")]
		IntPtr Constructor (IntPtr cptr, bool ownCObject);

		// -(id)initWithFillsign_object:(FSFillSignObject *)fillsign_object;
		[Export ("initWithFillsign_object:")]
		IntPtr Constructor (FSFillSignObject fillsign_object);

		// -(FSTextFillSignObjectDataArray *)getTextDataArray;
		[Export ("getTextDataArray")]
		//[Verify (MethodToProperty)]
		FSTextFillSignObjectDataArray TextDataArray { get; }

		// -(BOOL)isCombFieldMode;
		[Export ("isCombFieldMode")]
		//[Verify (MethodToProperty)]
		bool IsCombFieldMode { get; }

		// -(void)dealloc;
		[Export ("dealloc")]
		void Dealloc ();
	}

	// @interface FSSignatureFillSignObject : FSFillSignObject
	[BaseType (typeof(FSFillSignObject))]
	interface FSSignatureFillSignObject
	{
		// -(void *)getCptr;
		[Export ("getCptr")]
		//[Verify (MethodToProperty)]
		IntPtr Cptr { get; }

		// -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
		[Export ("initWithCptr:swigOwnCObject:")]
		IntPtr Constructor (IntPtr cptr, bool ownCObject);

		// -(id)initWithFillsign_object:(FSFillSignObject *)fillsign_object;
		[Export ("initWithFillsign_object:")]
		IntPtr Constructor (FSFillSignObject fillsign_object);

		// -(BOOL)isInitialsType;
		[Export ("isInitialsType")]
		//[Verify (MethodToProperty)]
		bool IsInitialsType { get; }

		// -(void)setBitmap:(FSBitmap *)bitmap;
		[Export ("setBitmap:")]
		void SetBitmap (FSBitmap bitmap);

		// -(void)dealloc;
		[Export ("dealloc")]
		void Dealloc ();
	}

	// @interface FSOutputPreview : FSBase
	[BaseType (typeof(FSBase))]
	[DisableDefaultCtor]
	interface FSOutputPreview
	{
		// -(void *)getCptr;
		[Export ("getCptr")]
		//[Verify (MethodToProperty)]
		IntPtr Cptr { get; }

		// -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
		[Export ("initWithCptr:swigOwnCObject:")]
		IntPtr Constructor (IntPtr cptr, bool ownCObject);

		// -(id)initWithPdf_doc:(FSPDFDoc *)pdf_doc;
		[Export ("initWithPdf_doc:")]
		IntPtr Constructor (FSPDFDoc pdf_doc);

		// -(id)initWithOther:(FSOutputPreview *)other;
		[Export ("initWithOther:")]
		IntPtr Constructor (FSOutputPreview other);

		// -(BOOL)isEmpty;
		[Export ("isEmpty")]
		//[Verify (MethodToProperty)]
		bool IsEmpty { get; }

		// -(void)setSimulationProfile:(NSString *)icc_profile_path;
		[Export ("setSimulationProfile:")]
		void SetSimulationProfile (string icc_profile_path);

		// -(void)setShowType:(FSOutputPreviewShowType)show_type;
		[Export ("setShowType:")]
		void SetShowType (FSOutputPreviewShowType show_type);

		// -(NSArray<NSData *> *)getPlates:(FSOutputPreviewColorantType)colorant_type;
		[Export ("getPlates:")]
		NSData[] GetPlates (FSOutputPreviewColorantType colorant_type);

		// -(unsigned int)getSpotPlateColor:(NSString *)plate_name;
		[Export ("getSpotPlateColor:")]
		uint GetSpotPlateColor (string plate_name);

		// -(void)setCheckStatus:(NSString *)plate_name to_check:(BOOL)to_check;
		[Export ("setCheckStatus:to_check:")]
		void SetCheckStatus (string plate_name, bool to_check);

		// -(BOOL)isChecked:(NSString *)plate_name;
		[Export ("isChecked:")]
		bool IsChecked (string plate_name);

		// -(void)enableSimulateOverprint:(BOOL)is_to_simulate_overprint;
		[Export ("enableSimulateOverprint:")]
		void EnableSimulateOverprint (bool is_to_simulate_overprint);

		// -(FSBitmap *)generatePreviewBitmap:(FSPDFPage *)page matrix:(FSMatrix2D *)matrix renderer:(FSRenderer *)renderer;
		[Export ("generatePreviewBitmap:matrix:renderer:")]
		FSBitmap GeneratePreviewBitmap (FSPDFPage page, FSMatrix2D matrix, FSRenderer renderer);

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

		// -(id)initWithOther:(FSLayerNodeArray *)other;
		[Export ("initWithOther:")]
		IntPtr Constructor (FSLayerNodeArray other);

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

	// @interface FSLayerPrintData : NSObject
	[BaseType (typeof(NSObject))]
	interface FSLayerPrintData
	{
		// @property (getter = getSubtype, copy, nonatomic) NSString * subtype;
		[Export ("subtype")]
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

		// -(BOOL)isLocked;
		[Export ("isLocked")]
		//[Verify (MethodToProperty)]
		bool IsLocked { get; }

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

		// -(FSPDFDictionary *)getDict;
		[Export ("getDict")]
		//[Verify (MethodToProperty)]
		FSPDFDictionary Dict { get; }

		// -(void)dealloc;
		[Export ("dealloc")]
		void Dealloc ();
	}

	// @interface FSMetadata : FSBase
	[BaseType (typeof(FSBase))]
	[DisableDefaultCtor]
	interface FSMetadata
	{
		// @property (getter = getCreationDateTime, copy, nonatomic) FSDateTime * creationDateTime;
		[Export ("creationDateTime", ArgumentSemantic.Copy)]
		FSDateTime CreationDateTime { [Bind ("getCreationDateTime")] get; set; }

		// @property (getter = getModifiedDateTime, copy, nonatomic) FSDateTime * modifiedDateTime;
		[Export ("modifiedDateTime", ArgumentSemantic.Copy)]
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

		// -(BOOL)setSize:(int)nNewSize nGrowBy:(int)nGrowBy;
		[Export ("setSize:nGrowBy:")]
		bool SetSize (int nNewSize, int nGrowBy);

		// -(BOOL)setSize:(int)nNewSize;
		[Export ("setSize:")]
		bool SetSize (int nNewSize);

		// -(void)removeAll;
		[Export ("removeAll")]
		void RemoveAll ();

		// -(FSGraphicsObject *)getAt:(int)nIndex;
		[Export ("getAt:")]
		FSGraphicsObject GetAt (int nIndex);

		// -(BOOL)setAt:(int)nIndex newElement:(FSGraphicsObject *)newElement;
		[Export ("setAt:newElement:")]
		bool SetAt (int nIndex, FSGraphicsObject newElement);

		// -(BOOL)setAtGrow:(int)nIndex newElement:(FSGraphicsObject *)newElement;
		[Export ("setAtGrow:newElement:")]
		bool SetAtGrow (int nIndex, FSGraphicsObject newElement);

		// -(BOOL)add:(FSGraphicsObject *)newElement;
		[Export ("add:")]
		bool Add (FSGraphicsObject newElement);

		// -(BOOL)insertAt:(int)nIndex newElement:(FSGraphicsObject *)newElement nCount:(int)nCount;
		[Export ("insertAt:newElement:nCount:")]
		bool InsertAt (int nIndex, FSGraphicsObject newElement, int nCount);

		// -(BOOL)insertAt:(int)nIndex newElement:(FSGraphicsObject *)newElement;
		[Export ("insertAt:newElement:")]
		bool InsertAt (int nIndex, FSGraphicsObject newElement);

		// -(BOOL)removeAt:(int)nIndex nCount:(int)nCount;
		[Export ("removeAt:nCount:")]
		bool RemoveAt (int nIndex, int nCount);

		// -(BOOL)removeAt:(int)nIndex;
		[Export ("removeAt:")]
		bool RemoveAt (int nIndex);

		// -(BOOL)insertAt:(int)nStartIndex pNewArray:(FSBasicArray *)pNewArray;
		[Export ("insertAt:pNewArray:")]
		bool InsertAt (int nStartIndex, FSBasicArray pNewArray);

		// -(int)find:(FSGraphicsObject *)data iStart:(int)iStart;
		[Export ("find:iStart:")]
		int Find (FSGraphicsObject data, int iStart);

		// -(int)find:(FSGraphicsObject *)data;
		[Export ("find:")]
		int Find (FSGraphicsObject data);

		// -(void)dealloc;
		[Export ("dealloc")]
		void Dealloc ();
	}

	// @interface FSColorState : FSBase
	[BaseType (typeof(FSBase))]
	[DisableDefaultCtor]
	interface FSColorState
	{
		// @property (getter = getFillColor, copy, nonatomic) FSColor * fillColor;
		[Export ("fillColor", ArgumentSemantic.Copy)]
		FSColor FillColor { [Bind ("getFillColor")] get; set; }

		// @property (getter = getStrokeColor, copy, nonatomic) FSColor * strokeColor;
		[Export ("strokeColor", ArgumentSemantic.Copy)]
		FSColor StrokeColor { [Bind ("getStrokeColor")] get; set; }

		// -(void *)getCptr;
		[Export ("getCptr")]
		//[Verify (MethodToProperty)]
		IntPtr Cptr { get; }

		// -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
		[Export ("initWithCptr:swigOwnCObject:")]
		IntPtr Constructor (IntPtr cptr, bool ownCObject);

		// -(id)initWithOther:(FSColorState *)other;
		[Export ("initWithOther:")]
		IntPtr Constructor (FSColorState other);

		// -(BOOL)isEmpty;
		[Export ("isEmpty")]
		//[Verify (MethodToProperty)]
		bool IsEmpty { get; }

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

		// -(int)addItem:(NSString *)tag_name;
		[Export ("addItem:")]
		int AddItem (string tag_name);

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

		// @property (getter = getColorState, copy, nonatomic) FSColorState * colorState;
		[Export ("colorState", ArgumentSemantic.Copy)]
		FSColorState ColorState { [Bind ("getColorState")] get; set; }

		// @property (getter = getFillOpacity, nonatomic) float fillOpacity;
		[Export ("fillOpacity")]
		float FillOpacity { [Bind ("getFillOpacity")] get; set; }

		// @property (getter = getStrokeOpacity, nonatomic) float strokeOpacity;
		[Export ("strokeOpacity")]
		float StrokeOpacity { [Bind ("getStrokeOpacity")] get; set; }

		// @property (getter = getMatrix, copy, nonatomic) FSMatrix2D * matrix;
		[Export ("matrix", ArgumentSemantic.Copy)]
		FSMatrix2D Matrix { [Bind ("getMatrix")] get; set; }

		// @property (getter = getGraphState, copy, nonatomic) FSGraphState * graphState;
		[Export ("graphState", ArgumentSemantic.Copy)]
		FSGraphState GraphState { [Bind ("getGraphState")] get; set; }

		// @property (getter = getBlendMode, nonatomic) FSGraphicsObjectBlendMode blendMode;
		[Export ("blendMode", ArgumentSemantic.Assign)]
		FSGraphicsObjectBlendMode BlendMode { [Bind ("getBlendMode")] get; set; }

		// @property (getter = getClipRect, copy, nonatomic) FSRectF * clipRect;
		[Export ("clipRect", ArgumentSemantic.Copy)]
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
		FSGraphicsObject Clone ();

		// -(FSGraphicsObject *)clone:(FSGraphicsObjects *)src_graphicsobjects dest_graphicsobjects:(FSGraphicsObjects *)dest_graphicsobjects;
		[Export ("clone:dest_graphicsobjects:")]
		FSGraphicsObject Clone (FSGraphicsObjects src_graphicsobjects, FSGraphicsObjects dest_graphicsobjects);

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

		// -(void)rotate:(int)angle;
		[Export ("rotate:")]
		void Rotate (int angle);

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

		// @property (getter = getTextmatrix, copy, nonatomic) NSArray<NSNumber *> * textmatrix;
		[Export ("textmatrix", ArgumentSemantic.Copy)]
		NSNumber[] Textmatrix { [Bind ("getTextmatrix")] get; set; }

		// @property (getter = getOrigin_position, copy, nonatomic) FSPointF * origin_position;
		[Export ("origin_position", ArgumentSemantic.Copy)]
		FSPointF Origin_position { [Bind ("getOrigin_position")] get; set; }

		// @property (getter = getFont, copy, nonatomic) FSFont * font;
		[Export ("font", ArgumentSemantic.Copy)]
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

		// -(void)setBitmap:(FSBitmap *)bitmap;
		[Export ("setBitmap:")]
		void SetBitmap (FSBitmap bitmap);

		// -(void)setImage:(FSImage *)image frame_index:(int)frame_index;
		[Export ("setImage:frame_index:")]
		void SetImage (FSImage image, int frame_index);

		// -(FSBitmap *)cloneBitmap:(FSGraphicsObjects *)graphics_objects;
		[Export ("cloneBitmap:")]
		FSBitmap CloneBitmap (FSGraphicsObjects graphics_objects);

		// -(FSBitmap *)cloneBitmap:(FSPDFPage *)page graphics_objects:(FSGraphicsObjects *)graphics_objects;
		[Export ("cloneBitmap:graphics_objects:")]
		FSBitmap CloneBitmap (FSPDFPage page, FSGraphicsObjects graphics_objects);

		// +(FSImageObject *)createFromType3TextObject:(FSPDFPage *)page text_obj:(FSTextObject *)text_obj;
		[Static]
		[Export ("createFromType3TextObject:text_obj:")]
		FSImageObject CreateFromType3TextObject (FSPDFPage page, FSTextObject text_obj);

		// -(FSBitmap *)saveAsBitmap:(FSGraphicsObjects *)graphics_objects;
		[Export ("saveAsBitmap:")]
		FSBitmap SaveAsBitmap (FSGraphicsObjects graphics_objects);

		// -(FSColorSpaceType)getColorSpace;
		[Export ("getColorSpace")]
		//[Verify (MethodToProperty)]
		FSColorSpaceType ColorSpace { get; }

		// -(FSPDFStream *)getStream;
		[Export ("getStream")]
		//[Verify (MethodToProperty)]
		FSPDFStream Stream { get; }

		// -(void)loadStream:(FSPDFDoc *)document stream:(FSPDFStream *)stream;
		[Export ("loadStream:stream:")]
		void LoadStream (FSPDFDoc document, FSPDFStream stream);

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
		// @property (getter = getText, copy, nonatomic) NSString * text;
		[Export ("text")]
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

		// -(int)getCharCount;
		[Export ("getCharCount")]
		//[Verify (MethodToProperty)]
		int CharCount { get; }

		// -(FSPointF *)getCharPos:(int)index;
		[Export ("getCharPos:")]
		FSPointF GetCharPos (int index);

		// -(float)getCharWidthByIndex:(int)index;
		[Export ("getCharWidthByIndex:")]
		float GetCharWidthByIndex (int index);

		// -(float)getCharHeightByIndex:(int)index;
		[Export ("getCharHeightByIndex:")]
		float GetCharHeightByIndex (int index);

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

		// @property (getter = getPathData, copy, nonatomic) FSPath * pathData;
		[Export ("pathData", ArgumentSemantic.Copy)]
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

		// -(long)getFirstGraphicsObjectPosition:(FSGraphicsObjectType)filter;
		[Export ("getFirstGraphicsObjectPosition:")]
		nint GetFirstGraphicsObjectPosition (FSGraphicsObjectType filter);

		// -(long)getFirstGraphicsObjectPosition;
		[Export ("getFirstGraphicsObjectPosition")]
		//[Verify (MethodToProperty)]
		nint FirstGraphicsObjectPosition { get; }

		// -(long)getNextGraphicsObjectPosition:(long)position filter:(FSGraphicsObjectType)filter;
		[Export ("getNextGraphicsObjectPosition:filter:")]
		nint GetNextGraphicsObjectPosition (nint position, FSGraphicsObjectType filter);

		// -(long)getNextGraphicsObjectPosition:(long)position;
		[Export ("getNextGraphicsObjectPosition:")]
		nint GetNextGraphicsObjectPosition (nint position);

		// -(long)getLastGraphicsObjectPosition:(FSGraphicsObjectType)filter;
		[Export ("getLastGraphicsObjectPosition:")]
		nint GetLastGraphicsObjectPosition (FSGraphicsObjectType filter);

		// -(long)getLastGraphicsObjectPosition;
		[Export ("getLastGraphicsObjectPosition")]
		//[Verify (MethodToProperty)]
		nint LastGraphicsObjectPosition { get; }

		// -(long)getPrevGraphicsObjectPosition:(long)position filter:(FSGraphicsObjectType)filter;
		[Export ("getPrevGraphicsObjectPosition:filter:")]
		nint GetPrevGraphicsObjectPosition (nint position, FSGraphicsObjectType filter);

		// -(long)getPrevGraphicsObjectPosition:(long)position;
		[Export ("getPrevGraphicsObjectPosition:")]
		nint GetPrevGraphicsObjectPosition (nint position);

		// -(FSGraphicsObject *)getGraphicsObject:(long)position;
		[Export ("getGraphicsObject:")]
		FSGraphicsObject GetGraphicsObject (nint position);

		// -(long)insertGraphicsObject:(long)position_insert_after graphics_object:(FSGraphicsObject *)graphics_object;
		[Export ("insertGraphicsObject:graphics_object:")]
		nint InsertGraphicsObject (nint position_insert_after, FSGraphicsObject graphics_object);

		// -(BOOL)removeGraphicsObject:(FSGraphicsObject *)graphics_object;
		[Export ("removeGraphicsObject:")]
		bool RemoveGraphicsObject (FSGraphicsObject graphics_object);

		// -(BOOL)removeGraphicsObjectByPosition:(long)position;
		[Export ("removeGraphicsObjectByPosition:")]
		bool RemoveGraphicsObjectByPosition (nint position);

		// -(long)moveGraphicsObjectByPosition:(long)current_position position_move_after:(long)position_move_after;
		[Export ("moveGraphicsObjectByPosition:position_move_after:")]
		nint MoveGraphicsObjectByPosition (nint current_position, nint position_move_after);

		// -(long)getGraphicsObjectPosition:(FSGraphicsObject *)graphics_object;
		[Export ("getGraphicsObjectPosition:")]
		nint GetGraphicsObjectPosition (FSGraphicsObject graphics_object);

		// -(int)getGraphicsObjectCount;
		[Export ("getGraphicsObjectCount")]
		//[Verify (MethodToProperty)]
		int GraphicsObjectCount { get; }

		// -(int)getGraphicsObjectIndex:(FSGraphicsObject *)graphics_object;
		[Export ("getGraphicsObjectIndex:")]
		int GetGraphicsObjectIndex (FSGraphicsObject graphics_object);

		// -(FSGraphicsObject *)getGraphicsObjectWithIndex:(int)index;
		[Export ("getGraphicsObjectWithIndex:")]
		FSGraphicsObject GetGraphicsObjectWithIndex (int index);

		// -(BOOL)generateContent;
		[Export ("generateContent")]
		//[Verify (MethodToProperty)]
		bool GenerateContent ();

		// -(BOOL)generateContent:(FSGraphicsObjectsTextMergeOption)text_merge_option;
		[Export ("generateContent:")]
		bool GenerateContent (FSGraphicsObjectsTextMergeOption text_merge_option);

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

		// -(id)initWithOther:(FSGraphicsObjects *)other;
		[Export ("initWithOther:")]
		IntPtr Constructor (FSGraphicsObjects other);

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
		FSProgressive StartParse (uint flags, NSObject pause, bool is_reparse);

		// -(FSProgressive *)startParse:(unsigned int)flags pause:(id<FSPauseCallback>)pause;
		[Export ("startParse:pause:")]
		FSProgressive StartParse (uint flags, NSObject pause);

		// -(FSProgressive *)startParse:(unsigned int)flags;
		[Export ("startParse:")]
		FSProgressive StartParse (uint flags);

		// -(FSProgressive *)startParse;
		[Export ("startParse")]
		//[Verify (MethodToProperty)]
		FSProgressive StartParse ();

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

		// -(FSAnnot *)getAnnotAtDevicePoint:(FSPointF *)position tolerance:(float)tolerance;
		[Export ("getAnnotAtDevicePoint:tolerance:")]
		FSAnnot GetAnnotAtDevicePoint (FSPointF position, float tolerance);

		// -(FSAnnotArray *)getAnnotsAtPoint:(FSPointF *)position tolerance:(float)tolerance;
		[Export ("getAnnotsAtPoint:tolerance:")]
		FSAnnotArray GetAnnotsAtPoint (FSPointF position, float tolerance);

		// -(FSAnnotArray *)getAnnotsAtDevicePoint:(FSPointF *)position tolerance:(float)tolerance matrix:(FSMatrix2D *)matrix;
		[Export ("getAnnotsAtDevicePoint:tolerance:matrix:")]
		FSAnnotArray GetAnnotsAtDevicePoint (FSPointF position, float tolerance, FSMatrix2D matrix);

		// -(FSAnnotArray *)getAnnotsAtDevicePoint:(FSPointF *)position tolerance:(float)tolerance;
		[Export ("getAnnotsAtDevicePoint:tolerance:")]
		FSAnnotArray GetAnnotsAtDevicePoint (FSPointF position, float tolerance);

		// -(FSAnnot *)addAnnot:(FSAnnotType)type rect:(FSRectF *)rect;
		[Export ("addAnnot:rect:")]
		FSAnnot AddAnnot (FSAnnotType type, FSRectF rect);

		// -(FSAnnot *)addAnnotWithDictionary:(FSPDFDictionary *)annot_dict;
		[Export ("addAnnotWithDictionary:")]
		FSAnnot AddAnnotWithDictionary (FSPDFDictionary annot_dict);

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

		// -(void)updateAnnotList;
		[Export ("updateAnnotList")]
		void UpdateAnnotList ();

		// -(BOOL)hasTransparency;
		[Export ("hasTransparency")]
		//[Verify (MethodToProperty)]
		bool HasTransparency { get; }

		// -(BOOL)isScanned;
		[Export ("isScanned")]
		//[Verify (MethodToProperty)]
		bool IsScanned { get; }

		// -(BOOL)flatten:(BOOL)for_display options:(unsigned int)options;
		[Export ("flatten:options:")]
		bool Flatten (bool for_display, uint options);

		// -(BOOL)flatten:(BOOL)for_display;
		[Export ("flatten:")]
		bool Flatten (bool for_display);

		// -(BOOL)flattenAnnot:(FSAnnot *)annot;
		[Export ("flattenAnnot:")]
		bool FlattenAnnot (FSAnnot annot);

		// -(BOOL)setAnnotGroup:(FSMarkupArray *)annot_array header_index:(int)header_index;
		[Export ("setAnnotGroup:header_index:")]
		bool SetAnnotGroup (FSMarkupArray annot_array, int header_index);

		// -(FSSignature *)addSignature:(FSRectF *)rect;
		[Export ("addSignature:")]
		FSSignature AddSignature (FSRectF rect);

		// -(FSSignature *)addSignatureWithFieldName:(FSRectF *)rect field_name:(NSString *)field_name;
		[Export ("addSignatureWithFieldName:field_name:")]
		FSSignature AddSignatureWithFieldName (FSRectF rect, string field_name);

		// -(FSSignature *)addSignatureWithSignatureType:(FSRectF *)rect field_name:(NSString *)field_name signature_type:(FSSignatureSignatureType)signature_type to_check_permission:(BOOL)to_check_permission;
		[Export ("addSignatureWithSignatureType:field_name:signature_type:to_check_permission:")]
		FSSignature AddSignatureWithSignatureType (FSRectF rect, string field_name, FSSignatureSignatureType signature_type, bool to_check_permission);

		// -(FSSignature *)addSignatureWithSignatureType:(FSRectF *)rect field_name:(NSString *)field_name signature_type:(FSSignatureSignatureType)signature_type;
		[Export ("addSignatureWithSignatureType:field_name:signature_type:")]
		FSSignature AddSignatureWithSignatureType (FSRectF rect, string field_name, FSSignatureSignatureType signature_type);

		// -(FSSignature *)addSignatureWithExistedVDict:(FSRectF *)rect field_name:(NSString *)field_name signature_type:(FSSignatureSignatureType)signature_type to_check_permission:(BOOL)to_check_permission existed_signature:(FSSignature *)existed_signature;
		[Export ("addSignatureWithExistedVDict:field_name:signature_type:to_check_permission:existed_signature:")]
		FSSignature AddSignatureWithExistedVDict (FSRectF rect, string field_name, FSSignatureSignatureType signature_type, bool to_check_permission, FSSignature existed_signature);

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

		// -(void)setSize:(FSPDFPageSize)size;
		[Export ("setSize:")]
		void SetSize (FSPDFPageSize size);

		// -(void)setBox:(FSPDFPageBoxType)box_type box:(FSRectF *)box;
		[Export ("setBox:box:")]
		void SetBox (FSPDFPageBoxType box_type, FSRectF box);

		// -(FSRectF *)getBox:(FSPDFPageBoxType)box_type;
		[Export ("getBox:")]
		FSRectF GetBox (FSPDFPageBoxType box_type);

		// -(BOOL)transform:(FSMatrix2D *)matrix need_transform_clip_path:(BOOL)need_transform_clip_path need_transform_annotations:(BOOL)need_transform_annotations;
		[Export ("transform:need_transform_clip_path:need_transform_annotations:")]
		bool Transform (FSMatrix2D matrix, bool need_transform_clip_path, bool need_transform_annotations);

		// -(BOOL)transform:(FSMatrix2D *)matrix need_transform_clip_path:(BOOL)need_transform_clip_path;
		[Export ("transform:need_transform_clip_path:")]
		bool Transform (FSMatrix2D matrix, bool need_transform_clip_path);

		// -(BOOL)normalize;
		[Export ("normalize")]
		//[Verify (MethodToProperty)]
		bool Normalize { get; }

		// -(void)setClipRect:(FSRectF *)clip_rect;
		[Export ("setClipRect:")]
		void SetClipRect (FSRectF clip_rect);

		// -(void)setThumbnail:(FSBitmap *)thumbnail;
		[Export ("setThumbnail:")]
		void SetThumbnail (FSBitmap thumbnail);

		// -(FSGraphicsObject *)getGraphicsObjectAtPoint:(FSPointF *)point tolerance:(float)tolerance filter:(FSGraphicsObjectType)filter;
		[Export ("getGraphicsObjectAtPoint:tolerance:filter:")]
		FSGraphicsObject GetGraphicsObjectAtPoint (FSPointF point, float tolerance, FSGraphicsObjectType filter);

		// -(FSGraphicsObject *)getGraphicsObjectAtPoint:(FSPointF *)point tolerance:(float)tolerance;
		[Export ("getGraphicsObjectAtPoint:tolerance:")]
		FSGraphicsObject GetGraphicsObjectAtPoint (FSPointF point, float tolerance);

		// -(FSGraphicsObjectArray *)getGraphicsObjectsAtPoint:(FSPointF *)point tolerance:(float)tolerance filter:(FSGraphicsObjectType)filter;
		[Export ("getGraphicsObjectsAtPoint:tolerance:filter:")]
		FSGraphicsObjectArray GetGraphicsObjectsAtPoint (FSPointF point, float tolerance, FSGraphicsObjectType filter);

		// -(FSGraphicsObjectArray *)getGraphicsObjectsAtPoint:(FSPointF *)point tolerance:(float)tolerance;
		[Export ("getGraphicsObjectsAtPoint:tolerance:")]
		FSGraphicsObjectArray GetGraphicsObjectsAtPoint (FSPointF point, float tolerance);

		// -(FSGraphicsObject *)getGraphicsObjectAtDevicePoint:(FSPointF *)point tolerance:(float)tolerance matrix:(FSMatrix2D *)matrix filter:(FSGraphicsObjectType)filter;
		[Export ("getGraphicsObjectAtDevicePoint:tolerance:matrix:filter:")]
		FSGraphicsObject GetGraphicsObjectAtDevicePoint (FSPointF point, float tolerance, FSMatrix2D matrix, FSGraphicsObjectType filter);

		// -(FSGraphicsObject *)getGraphicsObjectAtDevicePoint:(FSPointF *)point tolerance:(float)tolerance matrix:(FSMatrix2D *)matrix;
		[Export ("getGraphicsObjectAtDevicePoint:tolerance:matrix:")]
		FSGraphicsObject GetGraphicsObjectAtDevicePoint (FSPointF point, float tolerance, FSMatrix2D matrix);

		// -(FSGraphicsObjectArray *)getGraphicsObjectsAtDevicePoint:(FSPointF *)point tolerance:(float)tolerance matrix:(FSMatrix2D *)matrix filter:(FSGraphicsObjectType)filter;
		[Export ("getGraphicsObjectsAtDevicePoint:tolerance:matrix:filter:")]
		FSGraphicsObjectArray GetGraphicsObjectsAtDevicePoint (FSPointF point, float tolerance, FSMatrix2D matrix, FSGraphicsObjectType filter);

		// -(FSGraphicsObjectArray *)getGraphicsObjectsAtDevicePoint:(FSPointF *)point tolerance:(float)tolerance matrix:(FSMatrix2D *)matrix;
		[Export ("getGraphicsObjectsAtDevicePoint:tolerance:matrix:")]
		FSGraphicsObjectArray GetGraphicsObjectsAtDevicePoint (FSPointF point, float tolerance, FSMatrix2D matrix);

		// -(FSGraphicsObject *)getGraphicsObjectAtRectangle:(FSRectF *)rect filter:(FSGraphicsObjectType)filter;
		[Export ("getGraphicsObjectAtRectangle:filter:")]
		FSGraphicsObject GetGraphicsObjectAtRectangle (FSRectF rect, FSGraphicsObjectType filter);

		// -(FSGraphicsObject *)getGraphicsObjectAtRectangle:(FSRectF *)rect;
		[Export ("getGraphicsObjectAtRectangle:")]
		FSGraphicsObject GetGraphicsObjectAtRectangle (FSRectF rect);

		// -(FSGraphicsObjectArray *)getGraphicsObjectsAtRectangle:(FSRectF *)rect filter:(FSGraphicsObjectType)filter;
		[Export ("getGraphicsObjectsAtRectangle:filter:")]
		FSGraphicsObjectArray GetGraphicsObjectsAtRectangle (FSRectF rect, FSGraphicsObjectType filter);

		// -(FSGraphicsObjectArray *)getGraphicsObjectsAtRectangle:(FSRectF *)rect;
		[Export ("getGraphicsObjectsAtRectangle:")]
		FSGraphicsObjectArray GetGraphicsObjectsAtRectangle (FSRectF rect);

		// -(BOOL)addImage:(FSImage *)image frame_index:(int)frame_index position:(FSPointF *)position width:(float)width height:(float)height auto_generate_content:(BOOL)auto_generate_content;
		[Export ("addImage:frame_index:position:width:height:auto_generate_content:")]
		bool AddImage (FSImage image, int frame_index, FSPointF position, float width, float height, bool auto_generate_content);

		// -(BOOL)addImage:(FSImage *)image frame_index:(int)frame_index position:(FSPointF *)position width:(float)width height:(float)height;
		[Export ("addImage:frame_index:position:width:height:")]
		bool AddImage (FSImage image, int frame_index, FSPointF position, float width, float height);

		// -(BOOL)addImageFromFilePath:(NSString *)file_path position:(FSPointF *)position width:(float)width height:(float)height auto_generate_content:(BOOL)auto_generate_content;
		[Export ("addImageFromFilePath:position:width:height:auto_generate_content:")]
		bool AddImageFromFilePath (string file_path, FSPointF position, float width, float height, bool auto_generate_content);

		// -(BOOL)addImageFromFilePath:(NSString *)file_path position:(FSPointF *)position width:(float)width height:(float)height;
		[Export ("addImageFromFilePath:position:width:height:")]
		bool AddImageFromFilePath (string file_path, FSPointF position, float width, float height);

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

		// -(void)clearRenderCache;
		[Export ("clearRenderCache")]
		void ClearRenderCache ();

		// -(FSRectF *)getSuggestedRect:(FSBitmap *)render_result render_matrix:(FSMatrix2D *)render_matrix point:(FSPointF *)point;
		[Export ("getSuggestedRect:render_matrix:point:")]
		FSRectF GetSuggestedRect (FSBitmap render_result, FSMatrix2D render_matrix, FSPointF point);

		// -(BOOL)addText:(NSString *)text rect:(FSRectF *)rect style:(FSRichTextStyle *)style matrix:(FSMatrix2D *)matrix is_each_text:(BOOL)is_each_text disable_embed_font:(BOOL)disable_embed_font;
		[Export ("addText:rect:style:matrix:is_each_text:disable_embed_font:")]
		bool AddText (string text, FSRectF rect, FSRichTextStyle style, FSMatrix2D matrix, bool is_each_text, bool disable_embed_font);

		// -(BOOL)addText:(NSString *)text rect:(FSRectF *)rect style:(FSRichTextStyle *)style matrix:(FSMatrix2D *)matrix is_each_text:(BOOL)is_each_text;
		[Export ("addText:rect:style:matrix:is_each_text:")]
		bool AddText (string text, FSRectF rect, FSRichTextStyle style, FSMatrix2D matrix, bool is_each_text);

		// -(BOOL)addText:(NSString *)text rect:(FSRectF *)rect style:(FSRichTextStyle *)style matrix:(FSMatrix2D *)matrix;
		[Export ("addText:rect:style:matrix:")]
		bool AddText (string text, FSRectF rect, FSRichTextStyle style, FSMatrix2D matrix);

		// -(BOOL)addText:(NSString *)text rect:(FSRectF *)rect style:(FSRichTextStyle *)style;
		[Export ("addText:rect:style:")]
		bool AddText (string text, FSRectF rect, FSRichTextStyle style);

		// -(FSRectF *)addText:(NSString *)text rect:(FSRectF *)rect style:(FSRichTextStyle *)style rotation:(int)rotation rotate_point:(FSRotationPointOptions)rotate_point disable_embed_font:(BOOL)disable_embed_font;
		[Export ("addText:rect:style:rotation:rotate_point:disable_embed_font:")]
		FSRectF AddText (string text, FSRectF rect, FSRichTextStyle style, int rotation, FSRotationPointOptions rotate_point, bool disable_embed_font);

		// -(FSRectF *)addText:(NSString *)text rect:(FSRectF *)rect style:(FSRichTextStyle *)style rotation:(int)rotation rotate_point:(FSRotationPointOptions)rotate_point;
		[Export ("addText:rect:style:rotation:rotate_point:")]
		FSRectF AddText (string text, FSRectF rect, FSRichTextStyle style, int rotation, FSRotationPointOptions rotate_point);

		// -(FSRectF *)addText:(NSString *)text rect:(FSRectF *)rect style:(FSRichTextStyle *)style rotation:(int)rotation;
		[Export ("addText:rect:style:rotation:")]
		FSRectF AddText (string text, FSRectF rect, FSRichTextStyle style, int rotation);

		// -(FSRectF *)calculateNewRectForText:(NSString *)text rect:(FSRectF *)rect style:(FSRichTextStyle *)style rotation:(int)rotation rotate_point:(FSRotationPointOptions)rotate_point disable_embed_font:(BOOL)disable_embed_font;
		[Export ("calculateNewRectForText:rect:style:rotation:rotate_point:disable_embed_font:")]
		FSRectF CalculateNewRectForText (string text, FSRectF rect, FSRichTextStyle style, int rotation, FSRotationPointOptions rotate_point, bool disable_embed_font);

		// -(FSRectF *)calculateNewRectForText:(NSString *)text rect:(FSRectF *)rect style:(FSRichTextStyle *)style rotation:(int)rotation rotate_point:(FSRotationPointOptions)rotate_point;
		[Export ("calculateNewRectForText:rect:style:rotation:rotate_point:")]
		FSRectF CalculateNewRectForText (string text, FSRectF rect, FSRichTextStyle style, int rotation, FSRotationPointOptions rotate_point);

		// -(FSRectF *)calculateNewRectForText:(NSString *)text rect:(FSRectF *)rect style:(FSRichTextStyle *)style rotation:(int)rotation;
		[Export ("calculateNewRectForText:rect:style:rotation:")]
		FSRectF CalculateNewRectForText (string text, FSRectF rect, FSRichTextStyle style, int rotation);

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

		// @property (getter = getPrintRange, copy, nonatomic) FSRange * printRange;
		[Export ("printRange", ArgumentSemantic.Copy)]
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

		// -(id)initWithDocument:(FSPDFDoc *)document;
		[Export ("initWithDocument:")]
		IntPtr Constructor (FSPDFDoc document);

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

		// -(void)setPageLabel:(int)page_index label_style:(FSPageLabelsStyle)label_style first_label_number:(int)first_label_number;
		[Export ("setPageLabel:label_style:first_label_number:")]
		void SetPageLabel (int page_index, FSPageLabelsStyle label_style, int first_label_number);

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
		void SetCallback (NSObject callback);

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
		// @property (getter = getTitle, copy, nonatomic) NSString * title;
		[Export ("title")]
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

		// -(void)setImageScale:(float)image_scale;
		[Export ("setImageScale:")]
		void SetImageScale (float image_scale);

		// -(void)setTopSpace:(float)top_space;
		[Export ("setTopSpace:")]
		void SetTopSpace (float top_space);

		// -(FSProgressive *)startParse:(id<FSPauseCallback>)pause;
		[Export ("startParse:")]
		FSProgressive StartParse (NSObject pause);

		// -(FSProgressive *)startParse;
		[Export ("startParse")]
		//[Verify (MethodToProperty)]
		FSProgressive StartParse ();

		// -(float)getContentWidth;
		[Export ("getContentWidth")]
		//[Verify (MethodToProperty)]
		float ContentWidth { get; }

		// -(float)getContentHeight;
		[Export ("getContentHeight")]
		//[Verify (MethodToProperty)]
		float ContentHeight { get; }

		// -(FSMatrix2D *)getDisplayMatrix:(float)offset_x offset_y:(float)offset_y width:(int)width height:(int)height rotate:(FSRotation)rotate;
		[Export ("getDisplayMatrix:offset_y:width:height:rotate:")]
		FSMatrix2D GetDisplayMatrix (float offset_x, float offset_y, int width, int height, FSRotation rotate);

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

	// @interface FSTextPageCharInfo : NSObject
	[BaseType (typeof(NSObject))]
	interface FSTextPageCharInfo
	{
		// @property (getter = getFont, copy, nonatomic) FSFont * font;
		[Export ("font", ArgumentSemantic.Copy)]
		FSFont Font { [Bind ("getFont")] get; set; }

		// @property (getter = getFlag, nonatomic) FSTextPageCharInfoTextCharFlag flag;
		[Export ("flag", ArgumentSemantic.Assign)]
		FSTextPageCharInfoTextCharFlag Flag { [Bind ("getFlag")] get; set; }

		// @property (getter = getFont_size, nonatomic) float font_size;
		[Export ("font_size")]
		float Font_size { [Bind ("getFont_size")] get; set; }

		// @property (getter = getOrigin_x, nonatomic) float origin_x;
		[Export ("origin_x")]
		float Origin_x { [Bind ("getOrigin_x")] get; set; }

		// @property (getter = getOrigin_y, nonatomic) float origin_y;
		[Export ("origin_y")]
		float Origin_y { [Bind ("getOrigin_y")] get; set; }

		// @property (getter = getChar_box, copy, nonatomic) FSRectF * char_box;
		[Export ("char_box", ArgumentSemantic.Copy)]
		FSRectF Char_box { [Bind ("getChar_box")] get; set; }

		// @property (getter = getChar_outbox, copy, nonatomic) FSRectF * char_outbox;
		[Export ("char_outbox", ArgumentSemantic.Copy)]
		FSRectF Char_outbox { [Bind ("getChar_outbox")] get; set; }

		// @property (getter = getMatrix, copy, nonatomic) FSMatrix2D * matrix;
		[Export ("matrix", ArgumentSemantic.Copy)]
		FSMatrix2D Matrix { [Bind ("getMatrix")] get; set; }

		// -(void *)getCptr;
		[Export ("getCptr")]
		//[Verify (MethodToProperty)]
		IntPtr Cptr { get; }

		// -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
		[Export ("initWithCptr:swigOwnCObject:")]
		IntPtr Constructor (IntPtr cptr, bool ownCObject);

		// -(id)initWithFont:(FSFont *)font flag:(FSTextPageCharInfoTextCharFlag)flag font_size:(float)font_size origin_x:(float)origin_x origin_y:(float)origin_y char_box:(FSRectF *)char_box char_outbox:(FSRectF *)char_outbox matrix:(FSMatrix2D *)matrix;
		[Export ("initWithFont:flag:font_size:origin_x:origin_y:char_box:char_outbox:matrix:")]
		IntPtr Constructor (FSFont font, FSTextPageCharInfoTextCharFlag flag, float font_size, float origin_x, float origin_y, FSRectF char_box, FSRectF char_outbox, FSMatrix2D matrix);

		// -(id)initWithChar_info:(FSTextPageCharInfo *)char_info;
		[Export ("initWithChar_info:")]
		IntPtr Constructor (FSTextPageCharInfo char_info);

		// -(void)set:(FSFont *)font flag:(FSTextPageCharInfoTextCharFlag)flag font_size:(float)font_size origin_x:(float)origin_x origin_y:(float)origin_y char_box:(FSRectF *)char_box char_outbox:(FSRectF *)char_outbox matrix:(FSMatrix2D *)matrix;
		[Export ("set:flag:font_size:origin_x:origin_y:char_box:char_outbox:matrix:")]
		void Set (FSFont font, FSTextPageCharInfoTextCharFlag flag, float font_size, float origin_x, float origin_y, FSRectF char_box, FSRectF char_outbox, FSMatrix2D matrix);

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

		// -(id)initWithPage:(FSPDFPage *)page;
		[Export ("initWithPage:")]
		IntPtr Constructor (FSPDFPage page);

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

		// -(FSTextPageCharInfo *)getCharInfo:(int)char_index;
		[Export ("getCharInfo:")]
		FSTextPageCharInfo GetCharInfo (int char_index);

		// -(NSString *)getChars:(int)start count:(int)count;
		[Export ("getChars:count:")]
		string GetChars (int start, int count);

		// -(NSString *)getChars:(int)start;
		[Export ("getChars:")]
		string GetChars (int start);

		// -(NSString *)getChars;
		[Export ("getChars")]
		//[Verify (MethodToProperty)]
		string Chars { get; }

		// -(int)getIndexAtPos:(float)x y:(float)y tolerance:(float)tolerance;
		[Export ("getIndexAtPos:y:tolerance:")]
		int GetIndexAtPos (float x, float y, float tolerance);

		// -(NSString *)getTextInRect:(FSRectF *)rect;
		[Export ("getTextInRect:")]
		string GetTextInRect (FSRectF rect);

		// -(NSString *)getText:(FSTextPageTextOrderFlag)flag;
		[Export ("getText:")]
		string GetText (FSTextPageTextOrderFlag flag);

		// -(FSRange *)getWordAtPos:(float)x y:(float)y tolerance:(float)tolerance;
		[Export ("getWordAtPos:y:tolerance:")]
		FSRange GetWordAtPos (float x, float y, float tolerance);

		// -(int)getTextRectCount:(int)start count:(int)count;
		[Export ("getTextRectCount:count:")]
		int GetTextRectCount (int start, int count);

		// -(int)getTextRectCount:(int)start;
		[Export ("getTextRectCount:")]
		int GetTextRectCount (int start);

		// -(int)getTextRectCount;
		[Export ("getTextRectCount")]
		//[Verify (MethodToProperty)]
		int TextRectCount { get; }

		// -(FSRectF *)getTextRect:(int)rect_index;
		[Export ("getTextRect:")]
		FSRectF GetTextRect (int rect_index);

		// -(FSRotation)getBaselineRotation:(int)rect_index;
		[Export ("getBaselineRotation:")]
		FSRotation GetBaselineRotation (int rect_index);

		// -(FSRectFArray *)getTextRectArrayByRect:(FSRectF *)rect;
		[Export ("getTextRectArrayByRect:")]
		FSRectFArray GetTextRectArrayByRect (FSRectF rect);

		// -(FSRange *)getCharRange:(FSRectF *)rect;
		[Export ("getCharRange:")]
		FSRange GetCharRange (FSRectF rect);

		// -(NSString *)getTextUnderAnnot:(FSAnnot *)annot;
		[Export ("getTextUnderAnnot:")]
		string GetTextUnderAnnot (FSAnnot annot);

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

		// -(id)initWithDocument:(FSPDFDoc *)document cancel:(id<FSSearchCancelCallback>)cancel flags:(int)flags;
		[Export ("initWithDocument:cancel:flags:")]
		IntPtr Constructor (FSPDFDoc document, NSObject cancel, int flags);

		// -(id)initWithDocument:(FSPDFDoc *)document cancel:(id<FSSearchCancelCallback>)cancel;
		[Export ("initWithDocument:cancel:")]
		IntPtr Constructor (FSPDFDoc document, NSObject cancel);

		// -(id)initWithDocument:(FSPDFDoc *)document;
		[Export ("initWithDocument:")]
		IntPtr Constructor (FSPDFDoc document);

		// -(id)initWithXfa_document:(FSXFADoc *)xfa_document cancel:(id<FSSearchCancelCallback>)cancel;
		[Export ("initWithXfa_document:cancel:")]
		IntPtr Constructor (FSXFADoc xfa_document, NSObject cancel);

		// -(id)initWithXfa_document:(FSXFADoc *)xfa_document;
		[Export ("initWithXfa_document:")]
		IntPtr Constructor (FSXFADoc xfa_document);

		// -(id)initWithText_page:(FSTextPage *)text_page;
		[Export ("initWithText_page:")]
		IntPtr Constructor (FSTextPage text_page);

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

		// -(BOOL)setPattern:(NSString *)key_words is_regex_search:(BOOL)is_regex_search;
		[Export ("setPattern:is_regex_search:")]
		bool SetPattern (string key_words, bool is_regex_search);

		// -(BOOL)setPattern:(NSString *)key_words;
		[Export ("setPattern:")]
		bool SetPattern (string key_words);

		// -(BOOL)setStartPage:(int)page_index;
		[Export ("setStartPage:")]
		bool SetStartPage (int page_index);

		// -(BOOL)setEndPage:(int)page_index;
		[Export ("setEndPage:")]
		bool SetEndPage (int page_index);

		// -(BOOL)setStartCharacter:(int)char_index;
		[Export ("setStartCharacter:")]
		bool SetStartCharacter (int char_index);

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

		// -(int)getMatchSentenceEndIndex;
		[Export ("getMatchSentenceEndIndex")]
		//[Verify (MethodToProperty)]
		int MatchSentenceEndIndex { get; }

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

		// -(BOOL)setSize:(int)nNewSize nGrowBy:(int)nGrowBy;
		[Export ("setSize:nGrowBy:")]
		bool SetSize (int nNewSize, int nGrowBy);

		// -(BOOL)setSize:(int)nNewSize;
		[Export ("setSize:")]
		bool SetSize (int nNewSize);

		// -(void)removeAll;
		[Export ("removeAll")]
		void RemoveAll ();

		// -(FSEnvelope *)getAt:(int)nIndex;
		[Export ("getAt:")]
		FSEnvelope GetAt (int nIndex);

		// -(BOOL)setAt:(int)nIndex newElement:(FSEnvelope *)newElement;
		[Export ("setAt:newElement:")]
		bool SetAt (int nIndex, FSEnvelope newElement);

		// -(BOOL)setAtGrow:(int)nIndex newElement:(FSEnvelope *)newElement;
		[Export ("setAtGrow:newElement:")]
		bool SetAtGrow (int nIndex, FSEnvelope newElement);

		// -(BOOL)add:(FSEnvelope *)newElement;
		[Export ("add:")]
		bool Add (FSEnvelope newElement);

		// -(BOOL)insertAt:(int)nIndex newElement:(FSEnvelope *)newElement nCount:(int)nCount;
		[Export ("insertAt:newElement:nCount:")]
		bool InsertAt (int nIndex, FSEnvelope newElement, int nCount);

		// -(BOOL)insertAt:(int)nIndex newElement:(FSEnvelope *)newElement;
		[Export ("insertAt:newElement:")]
		bool InsertAt (int nIndex, FSEnvelope newElement);

		// -(BOOL)removeAt:(int)nIndex nCount:(int)nCount;
		[Export ("removeAt:nCount:")]
		bool RemoveAt (int nIndex, int nCount);

		// -(BOOL)removeAt:(int)nIndex;
		[Export ("removeAt:")]
		bool RemoveAt (int nIndex);

		// -(BOOL)insertAt:(int)nStartIndex pNewArray:(FSBasicArray *)pNewArray;
		[Export ("insertAt:pNewArray:")]
		bool InsertAt (int nStartIndex, FSBasicArray pNewArray);

		// -(int)find:(FSEnvelope *)data iStart:(int)iStart;
		[Export ("find:iStart:")]
		int Find (FSEnvelope data, int iStart);

		// -(int)find:(FSEnvelope *)data;
		[Export ("find:")]
		int Find (FSEnvelope data);

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

		// -(void)setAES256ModifyFlags:(unsigned int)modify_flags;
		[Export ("setAES256ModifyFlags:")]
		void SetAES256ModifyFlags (uint modify_flags);

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

		// @property (getter = getEnvelopes, copy, nonatomic) NSArray<NSData *> * envelopes;
		[Export ("envelopes", ArgumentSemantic.Copy)]
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

		// -(BOOL)initialize:(FSCertificateEncryptData *)encrypt_data encrypt_key:(NSString *)encrypt_key;
		[Export ("initialize:encrypt_key:")]
		bool Initialize (FSCertificateEncryptData encrypt_data, string encrypt_key);

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

		// @property (getter = getSub_filter, copy, nonatomic) NSString * sub_filter;
		[Export ("sub_filter")]
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

		// @property (getter = getFilter, copy, nonatomic) NSString * filter;
		[Export ("filter")]
		string Filter { [Bind ("getFilter")] get; set; }

		// @property (getter = getSub_filter, copy, nonatomic) NSString * sub_filter;
		[Export ("sub_filter")]
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
		bool Initialize (FSCustomEncryptData encrypt_data, NSObject callback, string encrypt_info);

		// -(BOOL)initialize:(FSCustomEncryptData *)encrypt_data callback:(id<FSCustomSecurityCallback>)callback;
		[Export ("initialize:callback:")]
		bool Initialize (FSCustomEncryptData encrypt_data, NSObject callback);

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

		// @property (getter = getPublish_license, copy, nonatomic) NSString * publish_license;
		[Export ("publish_license")]
		string Publish_license { [Bind ("getPublish_license")] get; set; }

		// @property (getter = getServer_eul_list, copy, nonatomic) NSArray<NSData *> * server_eul_list;
		[Export ("server_eul_list", ArgumentSemantic.Copy)]
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

		// -(id)initWithIs_encrypt_metadata:(BOOL)is_encrypt_metadata publish_license:(NSData *)publish_license server_eul_list:(NSArray<NSData *> *)server_eul_list irm_version:(float)irm_version;
		[Export ("initWithIs_encrypt_metadata:publish_license:server_eul_list:irm_version:")]
		IntPtr Constructor (bool is_encrypt_metadata, NSData publish_license, NSData[] server_eul_list, float irm_version);

		// -(id)initWithIs_encrypt_metadata:(BOOL)is_encrypt_metadata publish_license:(NSString *)publish_license server_eul_list:(NSArray<NSData *> *)server_eul_list;
		[Export ("initWithIs_encrypt_metadata:publish_license:server_eul_list:")]
		IntPtr Constructor (bool is_encrypt_metadata, string publish_license, NSData[] server_eul_list);

		// -(id)initWithOther:(FSRMSEncryptData *)other;
		[Export ("initWithOther:")]
		IntPtr Constructor (FSRMSEncryptData other);

		// -(void)set:(BOOL)is_encrypt_metadata publish_license:(NSString *)publish_license server_eul_list:(NSArray<NSData *> *)server_eul_list irm_version:(float)irm_version;
		[Export ("set:publish_license:server_eul_list:irm_version:")]
		void Set (bool is_encrypt_metadata, string publish_license, NSData[] server_eul_list, float irm_version);

		// -(void)set:(BOOL)is_encrypt_metadata publish_license:(NSString *)publish_license server_eul_list:(NSArray<NSData *> *)server_eul_list;
		[Export ("set:publish_license:server_eul_list:")]
		void Set (bool is_encrypt_metadata, string publish_license, NSData[] server_eul_list);

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
		bool Initialize (FSRMSEncryptData encrypt_data, NSObject callback);

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

		// @property (getter = getFont, copy, nonatomic) FSFont * font;
		[Export ("font", ArgumentSemantic.Copy)]
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
		IntPtr Constructor (FSForm form, NSObject assist);

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

		// -(void)highlightFormFieldsAndSignature:(BOOL)is_highlight is_sign_highlight:(BOOL)is_sign_highlight;
		[Export ("highlightFormFieldsAndSignature:is_sign_highlight:")]
		void HighlightFormFieldsAndSignature (bool is_highlight, bool is_sign_highlight);

		// -(void)setHighlightColor:(unsigned int)color;
		[Export ("setHighlightColor:")]
		void SetHighlightColor (uint color);

		// -(void)showOverflowIndicator:(BOOL)is_show_overflow_indicator;
		[Export ("showOverflowIndicator:")]
		void ShowOverflowIndicator (bool is_show_overflow_indicator);

		// -(BOOL)onCut;
		[Export ("onCut")]
		//[Verify (MethodToProperty)]
		bool OnCut { get; }

		// -(BOOL)onCopy;
		[Export ("onCopy")]
		//[Verify (MethodToProperty)]
		bool OnCopy { get; }

		// -(BOOL)onPaste;
		[Export ("onPaste")]
		//[Verify (MethodToProperty)]
		bool OnPaste { get; }

		// -(BOOL)onSelectAll;
		[Export ("onSelectAll")]
		//[Verify (MethodToProperty)]
		bool OnSelectAll { get; }

		// -(BOOL)onDelete;
		[Export ("onDelete")]
		//[Verify (MethodToProperty)]
		bool OnDelete { get; }

		// -(FSPointF *)getEditingTextCaretPosition:(FSMatrix2D *)matrix;
		[Export ("getEditingTextCaretPosition:")]
		FSPointF GetEditingTextCaretPosition (FSMatrix2D matrix);

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

		// -(id)initWithOther:(FSFieldArray *)other;
		[Export ("initWithOther:")]
		IntPtr Constructor (FSFieldArray other);

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
		// @property (getter = getOption_value, copy, nonatomic) NSString * option_value;
		[Export ("option_value")]
		string Option_value { [Bind ("getOption_value")] get; set; }

		// @property (getter = getOption_label, copy, nonatomic) NSString * option_label;
		[Export ("option_label")]
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

		// -(id)initWithOther:(FSChoiceOptionArray *)other;
		[Export ("initWithOther:")]
		IntPtr Constructor (FSChoiceOptionArray other);

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

		// @property (getter = getDefaultValue, copy, nonatomic) NSString * defaultValue;
		[Export ("defaultValue")]
		string DefaultValue { [Bind ("getDefaultValue")] get; set; }

		// @property (getter = getValue, copy, nonatomic) NSString * value;
		[Export ("value")]
		string Value { [Bind ("getValue")] get; set; }

		// @property (getter = getAlignment, nonatomic) FSAlignment alignment;
		[Export ("alignment", ArgumentSemantic.Assign)]
		FSAlignment Alignment { [Bind ("getAlignment")] get; set; }

		// @property (getter = getAlternateName, copy, nonatomic) NSString * alternateName;
		[Export ("alternateName")]
		string AlternateName { [Bind ("getAlternateName")] get; set; }

		// @property (getter = getDefaultAppearance, copy, nonatomic) FSDefaultAppearance * defaultAppearance;
		[Export ("defaultAppearance", ArgumentSemantic.Copy)]
		FSDefaultAppearance DefaultAppearance { [Bind ("getDefaultAppearance")] get; set; }

		// @property (getter = getMappingName, copy, nonatomic) NSString * mappingName;
		[Export ("mappingName")]
		string MappingName { [Bind ("getMappingName")] get; set; }

		// @property (getter = getMaxLength, nonatomic) int maxLength;
		[Export ("maxLength")]
		int MaxLength { [Bind ("getMaxLength")] get; set; }

		// @property (getter = getOptions, copy, nonatomic) FSChoiceOptionArray * options;
		[Export ("options", ArgumentSemantic.Copy)]
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

		// -(int)getControlCount;
		[Export ("getControlCount")]
		//[Verify (MethodToProperty)]
		int ControlCount { get; }

		// -(FSControl *)getControl:(int)index;
		[Export ("getControl:")]
		FSControl GetControl (int index);

		// -(int)getControlCount:(FSPDFPage *)page;
		[Export ("getControlCount:")]
		int GetControlCount (FSPDFPage page);

		// -(FSControl *)getControl:(FSPDFPage *)page index:(int)index;
		[Export ("getControl:index:")]
		FSControl GetControl (FSPDFPage page, int index);

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

		// @property (getter = getDefaultAppearance, copy, nonatomic) FSDefaultAppearance * defaultAppearance;
		[Export ("defaultAppearance", ArgumentSemantic.Copy)]
		FSDefaultAppearance DefaultAppearance { [Bind ("getDefaultAppearance")] get; set; }

		// @property (getter = getFieldsInCalculationOrder, copy, nonatomic) FSFieldArray * fieldsInCalculationOrder;
		[Export ("fieldsInCalculationOrder", ArgumentSemantic.Copy)]
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

		// -(FSControl *)getControlAtDevicePoint:(FSPDFPage *)page point:(FSPointF *)point tolerance:(float)tolerance type:(FSFieldType)type;
		[Export ("getControlAtDevicePoint:point:tolerance:type:")]
		FSControl GetControlAtDevicePoint (FSPDFPage page, FSPointF point, float tolerance, FSFieldType type);

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

		// -(BOOL)moveControl:(FSControl *)control field_name:(NSString *)field_name;
		[Export ("moveControl:field_name:")]
		bool MoveControl (FSControl control, string field_name);

		// -(void)removeField:(FSField *)field;
		[Export ("removeField:")]
		void RemoveField (FSField field);

		// -(void)removeControl:(FSControl *)control;
		[Export ("removeControl:")]
		void RemoveControl (FSControl control);

		// -(int)getFieldCount:(NSString *)filter;
		[Export ("getFieldCount:")]
		int GetFieldCount (string filter);

		// -(int)getFieldCount;
		[Export ("getFieldCount")]
		//[Verify (MethodToProperty)]
		int FieldCount { get; }

		// -(FSField *)getField:(int)index filter:(NSString *)filter;
		[Export ("getField:filter:")]
		FSField GetField (int index, string filter);

		// -(FSField *)getField:(int)index;
		[Export ("getField:")]
		FSField GetField (int index);

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

		// -(BOOL)exportToXML:(NSString *)file_path field_array:(FSFieldArray *)field_array is_include:(BOOL)is_include;
		[Export ("exportToXML:field_array:is_include:")]
		bool ExportToXML (string file_path, FSFieldArray field_array, bool is_include);

		// -(BOOL)exportToXMLWithXmlFile:(id<FSFileWriterCallback>)xml_file field_array:(FSFieldArray *)field_array is_include:(BOOL)is_include;
		[Export ("exportToXMLWithXmlFile:field_array:is_include:")]
		bool ExportToXMLWithXmlFile (NSObject xml_file, FSFieldArray field_array, bool is_include);

		// -(BOOL)importFromXML:(NSString *)file_path;
		[Export ("importFromXML:")]
		bool ImportFromXML (string file_path);

		// -(BOOL)exportToCSV:(NSString *)csv_file_path pdf_file_name:(NSString *)pdf_file_name is_append:(BOOL)is_append;
		[Export ("exportToCSV:pdf_file_name:is_append:")]
		bool ExportToCSV (string csv_file_path, string pdf_file_name, bool is_append);

		// -(BOOL)exportToCSVWithCsvFile:(id<FSStreamCallback>)csv_file pdf_file_name:(NSString *)pdf_file_name is_append:(BOOL)is_append;
		[Export ("exportToCSVWithCsvFile:pdf_file_name:is_append:")]
		bool ExportToCSVWithCsvFile (NSObject csv_file, string pdf_file_name, bool is_append);

		// -(BOOL)exportToHTML:(NSString *)html_file_path field_array:(FSFieldArray *)field_array is_include:(BOOL)is_include;
		[Export ("exportToHTML:field_array:is_include:")]
		bool ExportToHTML (string html_file_path, FSFieldArray field_array, bool is_include);

		// -(BOOL)exportToHTMLWithHtmlFile:(id<FSFileWriterCallback>)html_file field_array:(FSFieldArray *)field_array is_include:(BOOL)is_include;
		[Export ("exportToHTMLWithHtmlFile:field_array:is_include:")]
		bool ExportToHTMLWithHtmlFile (NSObject html_file, FSFieldArray field_array, bool is_include);

		// -(BOOL)exportToTXT:(NSString *)txt_file_path field_array:(FSFieldArray *)field_array is_include:(BOOL)is_include;
		[Export ("exportToTXT:field_array:is_include:")]
		bool ExportToTXT (string txt_file_path, FSFieldArray field_array, bool is_include);

		// -(BOOL)exportToTXTWithTxtFile:(id<FSFileWriterCallback>)txt_file field_array:(FSFieldArray *)field_array is_include:(BOOL)is_include;
		[Export ("exportToTXTWithTxtFile:field_array:is_include:")]
		bool ExportToTXTWithTxtFile (NSObject txt_file, FSFieldArray field_array, bool is_include);

		// -(FSPDFDictionary *)getDict;
		[Export ("getDict")]
		//[Verify (MethodToProperty)]
		FSPDFDictionary Dict { get; }

		// -(void)fixPageFields:(int)page_index;
		[Export ("fixPageFields:")]
		void FixPageFields (int page_index);

		// -(void)reload;
		[Export ("reload")]
		void Reload ();

		// -(void)dealloc;
		[Export ("dealloc")]
		void Dealloc ();
	}

	// @interface FSControl : FSBase
	[BaseType (typeof(FSBase))]
	[DisableDefaultCtor]
	interface FSControl
	{
		// @property (getter = getExportValue, copy, nonatomic) NSString * exportValue;
		[Export ("exportValue")]
		string ExportValue { [Bind ("getExportValue")] get; set; }

		// @property (getter = getDefaultAppearance, copy, nonatomic) FSDefaultAppearance * defaultAppearance;
		[Export ("defaultAppearance", ArgumentSemantic.Copy)]
		FSDefaultAppearance DefaultAppearance { [Bind ("getDefaultAppearance")] get; set; }

		// @property (getter = getAlignment, nonatomic) FSAlignment alignment;
		[Export ("alignment", ArgumentSemantic.Assign)]
		FSAlignment Alignment { [Bind ("getAlignment")] get; set; }

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

		// -(FSPDFDictionary *)getWidgetDict;
		[Export ("getWidgetDict")]
		//[Verify (MethodToProperty)]
		FSPDFDictionary WidgetDict { get; }

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

		// -(void)setChecked:(BOOL)checked_status;
		[Export ("setChecked:")]
		void SetChecked (bool checked_status);

		// -(BOOL)isDefaultChecked;
		[Export ("isDefaultChecked")]
		//[Verify (MethodToProperty)]
		bool IsDefaultChecked { get; }

		// -(void)setDefaultChecked:(BOOL)checked_status;
		[Export ("setDefaultChecked:")]
		void SetDefaultChecked (bool checked_status);

		// -(void)dealloc;
		[Export ("dealloc")]
		void Dealloc ();
	}

	// @interface FSSignatureArray : NSObject
	[BaseType (typeof(NSObject))]
	interface FSSignatureArray
	{
		// -(void *)getCptr;
		[Export ("getCptr")]
		//[Verify (MethodToProperty)]
		IntPtr Cptr { get; }

		// -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
		[Export ("initWithCptr:swigOwnCObject:")]
		IntPtr Constructor (IntPtr cptr, bool ownCObject);

		// -(id)initWithOther:(FSSignatureArray *)other;
		[Export ("initWithOther:")]
		IntPtr Constructor (FSSignatureArray other);

		// -(unsigned long)getSize;
		[Export ("getSize")]
		//[Verify (MethodToProperty)]
		nuint Size { get; }

		// -(FSSignature *)getAt:(unsigned long)index;
		[Export ("getAt:")]
		FSSignature GetAt (nuint index);

		// -(void)add:(FSSignature *)element;
		[Export ("add:")]
		void Add (FSSignature element);

		// -(void)removeAt:(unsigned long)index;
		[Export ("removeAt:")]
		void RemoveAt (nuint index);

		// -(void)insertAt:(unsigned long)index element:(FSSignature *)element;
		[Export ("insertAt:element:")]
		void InsertAt (nuint index, FSSignature element);

		// -(void)removeAll;
		[Export ("removeAll")]
		void RemoveAll ();

		// -(void)dealloc;
		[Export ("dealloc")]
		void Dealloc ();
	}

	// @interface FSSignature : FSField
	[BaseType (typeof(FSField))]
	interface FSSignature
	{
		// @property (getter = getDocPermission, nonatomic) FSSignatureDocPermission docPermission;
		[Export ("docPermission", ArgumentSemantic.Assign)]
		FSSignatureDocPermission DocPermission { [Bind ("getDocPermission")] get; set; }

		// @property (getter = getAppearanceFlags, nonatomic) unsigned int appearanceFlags;
		[Export ("appearanceFlags")]
		uint AppearanceFlags { [Bind ("getAppearanceFlags")] get; set; }

		// @property (getter = getSignTime, copy, nonatomic) FSDateTime * signTime;
		[Export ("signTime", ArgumentSemantic.Copy)]
		FSDateTime SignTime { [Bind ("getSignTime")] get; set; }

		// @property (getter = getFilter, copy, nonatomic) NSString * filter;
		[Export ("filter")]
		string Filter { [Bind ("getFilter")] get; set; }

		// @property (getter = getSubFilter, copy, nonatomic) NSString * subFilter;
		[Export ("subFilter")]
		string SubFilter { [Bind ("getSubFilter")] get; set; }

		// @property (getter = getBitmap, copy, nonatomic) FSBitmap * bitmap;
		[Export ("bitmap", ArgumentSemantic.Copy)]
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

		// -(void)setFieldMDPActionFields:(FSSignatureFieldMDPAction)action field_array:(NSArray<NSString *> *)field_array;
		[Export ("setFieldMDPActionFields:field_array:")]
		void SetFieldMDPActionFields (FSSignatureFieldMDPAction action, string[] field_array);

		// -(FSSignatureFieldMDPAction)getFieldMDPAction;
		[Export ("getFieldMDPAction")]
		//[Verify (MethodToProperty)]
		FSSignatureFieldMDPAction FieldMDPAction { get; }

		// -(NSArray<NSString *> *)getFieldMDPActionFields;
		[Export ("getFieldMDPActionFields")]
		//[Verify (MethodToProperty)]
		string[] FieldMDPActionFields { get; }

		// -(void)enableIncrementalSaveForFirstSigning:(BOOL)enable_incremental_save;
		[Export ("enableIncrementalSaveForFirstSigning:")]
		void EnableIncrementalSaveForFirstSigning (bool enable_incremental_save);

		// -(FSProgressive *)startSign:(NSString *)cert_path cert_password:(NSString *)cert_password digest_algorithm:(FSSignatureDigestAlgorithm)digest_algorithm save_path:(NSString *)save_path client_data:(NSData *)client_data pause:(id<FSPauseCallback>)pause;
		[Export ("startSign:cert_password:digest_algorithm:save_path:client_data:pause:")]
		FSProgressive StartSign (string cert_path, string cert_password, FSSignatureDigestAlgorithm digest_algorithm, string save_path, NSData client_data, NSObject pause);

		// -(FSProgressive *)startSign:(NSString *)cert_path cert_password:(NSString *)cert_password digest_algorithm:(FSSignatureDigestAlgorithm)digest_algorithm save_path:(NSString *)save_path client_data:(NSData *)client_data;
		[Export ("startSign:cert_password:digest_algorithm:save_path:client_data:")]
		FSProgressive StartSign (string cert_path, string cert_password, FSSignatureDigestAlgorithm digest_algorithm, string save_path, NSData client_data);

		// -(FSProgressive *)startSign:(NSString *)cert_path cert_password:(NSString *)cert_password digest_algorithm:(FSSignatureDigestAlgorithm)digest_algorithm save_path:(NSString *)save_path;
		[Export ("startSign:cert_password:digest_algorithm:save_path:")]
		FSProgressive StartSign (string cert_path, string cert_password, FSSignatureDigestAlgorithm digest_algorithm, string save_path);

		// -(FSProgressive *)startSignByCertStream:(id<FSStreamCallback>)cert_file_stream cert_password:(NSString *)cert_password digest_algorithm:(FSSignatureDigestAlgorithm)digest_algorithm save_path:(NSString *)save_path client_data:(NSData *)client_data pause:(id<FSPauseCallback>)pause;
		[Export ("startSignByCertStream:cert_password:digest_algorithm:save_path:client_data:pause:")]
		FSProgressive StartSignByCertStream (NSObject cert_file_stream, string cert_password, FSSignatureDigestAlgorithm digest_algorithm, string save_path, NSData client_data, NSObject pause);

		// -(FSProgressive *)startSignByCertStream:(id<FSStreamCallback>)cert_file_stream cert_password:(NSString *)cert_password digest_algorithm:(FSSignatureDigestAlgorithm)digest_algorithm save_path:(NSString *)save_path client_data:(NSData *)client_data;
		[Export ("startSignByCertStream:cert_password:digest_algorithm:save_path:client_data:")]
		FSProgressive StartSignByCertStream (NSObject cert_file_stream, string cert_password, FSSignatureDigestAlgorithm digest_algorithm, string save_path, NSData client_data);

		// -(FSProgressive *)startSignByCertStream:(id<FSStreamCallback>)cert_file_stream cert_password:(NSString *)cert_password digest_algorithm:(FSSignatureDigestAlgorithm)digest_algorithm save_path:(NSString *)save_path;
		[Export ("startSignByCertStream:cert_password:digest_algorithm:save_path:")]
		FSProgressive StartSignByCertStream (NSObject cert_file_stream, string cert_password, FSSignatureDigestAlgorithm digest_algorithm, string save_path);

		// -(FSProgressive *)startSignToStream:(NSString *)cert_path cert_password:(NSString *)cert_password digest_algorithm:(FSSignatureDigestAlgorithm)digest_algorithm stream_callback:(id<FSStreamCallback>)stream_callback client_data:(NSData *)client_data pause:(id<FSPauseCallback>)pause;
		[Export ("startSignToStream:cert_password:digest_algorithm:stream_callback:client_data:pause:")]
		FSProgressive StartSignToStream (string cert_path, string cert_password, FSSignatureDigestAlgorithm digest_algorithm, NSObject stream_callback, NSData client_data, NSObject pause);

		// -(FSProgressive *)startSignToStream:(NSString *)cert_path cert_password:(NSString *)cert_password digest_algorithm:(FSSignatureDigestAlgorithm)digest_algorithm stream_callback:(id<FSStreamCallback>)stream_callback client_data:(NSData *)client_data;
		[Export ("startSignToStream:cert_password:digest_algorithm:stream_callback:client_data:")]
		FSProgressive StartSignToStream (string cert_path, string cert_password, FSSignatureDigestAlgorithm digest_algorithm, NSObject stream_callback, NSData client_data);

		// -(FSProgressive *)startSignToStream:(NSString *)cert_path cert_password:(NSString *)cert_password digest_algorithm:(FSSignatureDigestAlgorithm)digest_algorithm stream_callback:(id<FSStreamCallback>)stream_callback;
		[Export ("startSignToStream:cert_password:digest_algorithm:stream_callback:")]
		FSProgressive StartSignToStream (string cert_path, string cert_password, FSSignatureDigestAlgorithm digest_algorithm, NSObject stream_callback);

		// -(FSProgressive *)startSignToStreamByCertStream:(id<FSStreamCallback>)cert_file_stream cert_password:(NSString *)cert_password digest_algorithm:(FSSignatureDigestAlgorithm)digest_algorithm stream_callback:(id<FSStreamCallback>)stream_callback client_data:(NSData *)client_data pause:(id<FSPauseCallback>)pause;
		[Export ("startSignToStreamByCertStream:cert_password:digest_algorithm:stream_callback:client_data:pause:")]
		FSProgressive StartSignToStreamByCertStream (NSObject cert_file_stream, string cert_password, FSSignatureDigestAlgorithm digest_algorithm, NSObject stream_callback, NSData client_data, NSObject pause);

		// -(FSProgressive *)startSignToStreamByCertStream:(id<FSStreamCallback>)cert_file_stream cert_password:(NSString *)cert_password digest_algorithm:(FSSignatureDigestAlgorithm)digest_algorithm stream_callback:(id<FSStreamCallback>)stream_callback client_data:(NSData *)client_data;
		[Export ("startSignToStreamByCertStream:cert_password:digest_algorithm:stream_callback:client_data:")]
		FSProgressive StartSignToStreamByCertStream (NSObject cert_file_stream, string cert_password, FSSignatureDigestAlgorithm digest_algorithm, NSObject stream_callback, NSData client_data);

		// -(FSProgressive *)startSignToStreamByCertStream:(id<FSStreamCallback>)cert_file_stream cert_password:(NSString *)cert_password digest_algorithm:(FSSignatureDigestAlgorithm)digest_algorithm stream_callback:(id<FSStreamCallback>)stream_callback;
		[Export ("startSignToStreamByCertStream:cert_password:digest_algorithm:stream_callback:")]
		FSProgressive StartSignToStreamByCertStream (NSObject cert_file_stream, string cert_password, FSSignatureDigestAlgorithm digest_algorithm, NSObject stream_callback);

		// -(FSProgressive *)startVerify:(NSData *)client_data pause:(id<FSPauseCallback>)pause;
		[Export ("startVerify:pause:")]
		FSProgressive StartVerify (NSData client_data, NSObject pause);

		// -(FSProgressive *)startVerify:(NSData *)client_data;
		[Export ("startVerify:")]
		FSProgressive StartVerify (NSData client_data);

		// -(FSProgressive *)startVerify;
		[Export ("startVerify")]
		//[Verify (MethodToProperty)]
		FSProgressive StartVerify ();

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

		// -(FSPDFDoc *)getSignedVersionDocument:(NSString *)file_path;
		[Export ("getSignedVersionDocument:")]
		FSPDFDoc GetSignedVersionDocument (string file_path);

		// -(void)setAppearanceContent:(NSString *)appearance_content;
		[Export ("setAppearanceContent:")]
		void SetAppearanceContent (string appearance_content);

		// -(NSString *)getKeyValue:(FSSignatureKeyName)key;
		[Export ("getKeyValue:")]
		string GetKeyValue (FSSignatureKeyName key);

		// -(void)setKeyValue:(FSSignatureKeyName)key value:(NSString *)value;
		[Export ("setKeyValue:value:")]
		void SetKeyValue (FSSignatureKeyName key, string value);

		// -(void)setKeyLabel:(FSSignatureLabelName)label_name label_value:(NSString *)label_value;
		[Export ("setKeyLabel:label_value:")]
		void SetKeyLabel (FSSignatureLabelName label_name, string label_value);

		// -(NSString *)getKeyLabel:(FSSignatureLabelName)label_name;
		[Export ("getKeyLabel:")]
		string GetKeyLabel (FSSignatureLabelName label_name);

		// -(void)setImage:(FSImage *)image frame_index:(int)frame_index;
		[Export ("setImage:frame_index:")]
		void SetImage (FSImage image, int frame_index);

		// -(void)setImageWithFilePath:(NSString *)file_path frame_index:(int)frame_index;
		[Export ("setImageWithFilePath:frame_index:")]
		void SetImageWithFilePath (string file_path, int frame_index);

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

		// -(FSSignatureSignatureType)getSignatureType;
		[Export ("getSignatureType")]
		//[Verify (MethodToProperty)]
		FSSignatureSignatureType SignatureType { get; }

		// -(BOOL)isTimeStamp;
		[Export ("isTimeStamp")]
		//[Verify (MethodToProperty)]
		bool IsTimeStamp { get; }

		// -(FSSignaturePAdESLevel)getPAdESLevel;
		[Export ("getPAdESLevel")]
		//[Verify (MethodToProperty)]
		FSSignaturePAdESLevel PAdESLevel { get; }

		// -(void)setCustomObject:(NSString *)key pdf_object:(FSPDFObject *)pdf_object;
		[Export ("setCustomObject:pdf_object:")]
		void SetCustomObject (string key, FSPDFObject pdf_object);

		// -(FSSignatureArray *)getPagingSealGroupElements;
		[Export ("getPagingSealGroupElements")]
		//[Verify (MethodToProperty)]
		FSSignatureArray PagingSealGroupElements { get; }

		// -(BOOL)generateAppearance;
		[Export ("generateAppearance")]
		//[Verify (MethodToProperty)]
		bool GenerateAppearance { get; }

		// -(FSPagingSealSignature *)getPagingSealSignature;
		[Export ("getPagingSealSignature")]
		//[Verify (MethodToProperty)]
		FSPagingSealSignature PagingSealSignature { get; }

		// -(void)enableEmbedFont:(BOOL)enable_embed_font;
		[Export ("enableEmbedFont:")]
		void EnableEmbedFont (bool enable_embed_font);

		// -(BOOL)detectModification;
		[Export ("detectModification")]
		//[Verify (MethodToProperty)]
		bool DetectModification { get; }

		// -(FSInt32Array *)getByteRangeArray;
		[Export ("getByteRangeArray")]
		//[Verify (MethodToProperty)]
		FSInt32Array ByteRangeArray { get; }

		// -(void)dealloc;
		[Export ("dealloc")]
		void Dealloc ();
	}

	// @interface FSTimeStampServerMgr : NSObject
	[BaseType (typeof(NSObject))]
	interface FSTimeStampServerMgr
	{
		// -(void *)getCptr;
		[Export ("getCptr")]
		//[Verify (MethodToProperty)]
		IntPtr Cptr { get; }

		// -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
		[Export ("initWithCptr:swigOwnCObject:")]
		IntPtr Constructor (IntPtr cptr, bool ownCObject);

		// +(FSErrorCode)Initialize;
		[Static]
		[Export ("Initialize")]
		//[Verify (MethodToProperty)]
		FSErrorCode Initialize { get; }

		// +(void)destroy;
		[Static]
		[Export ("destroy")]
		void Destroy ();

		// +(int)getServerCount;
		[Static]
		[Export ("getServerCount")]
		//[Verify (MethodToProperty)]
		int ServerCount { get; }

		// +(FSTimeStampServer *)getServer:(int)index;
		[Static]
		[Export ("getServer:")]
		FSTimeStampServer GetServer (int index);

		// +(int)getServerIndex:(FSTimeStampServer *)server;
		[Static]
		[Export ("getServerIndex:")]
		int GetServerIndex (FSTimeStampServer server);

		// +(FSTimeStampServer *)getDefaultServer;
		[Static]
		[Export ("getDefaultServer")]
		//[Verify (MethodToProperty)]
		FSTimeStampServer DefaultServer { get; }

		// +(void)setDefaultServerWithIndex:(int)index;
		[Static]
		[Export ("setDefaultServerWithIndex:")]
		void SetDefaultServerWithIndex (int index);

		// +(void)setDefaultServer:(FSTimeStampServer *)server;
		[Static]
		[Export ("setDefaultServer:")]
		void SetDefaultServer (FSTimeStampServer server);

		// +(FSTimeStampServer *)addServer:(NSString *)server_name server_url:(NSString *)server_url user_name:(NSString *)user_name password:(NSString *)password;
		[Static]
		[Export ("addServer:server_url:user_name:password:")]
		FSTimeStampServer AddServer (string server_name, string server_url, string user_name, string password);

		// +(void)removeServerWithIndex:(int)index;
		[Static]
		[Export ("removeServerWithIndex:")]
		void RemoveServerWithIndex (int index);

		// +(void)removeServer:(FSTimeStampServer *)server;
		[Static]
		[Export ("removeServer:")]
		void RemoveServer (FSTimeStampServer server);

		// -(void)dealloc;
		[Export ("dealloc")]
		void Dealloc ();
	}

	// @interface FSTimeStampServer : FSBase
	[BaseType (typeof(FSBase))]
	[DisableDefaultCtor]
	interface FSTimeStampServer
	{
		// -(void *)getCptr;
		[Export ("getCptr")]
		//[Verify (MethodToProperty)]
		IntPtr Cptr { get; }

		// -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
		[Export ("initWithCptr:swigOwnCObject:")]
		IntPtr Constructor (IntPtr cptr, bool ownCObject);

		// -(id)initWithOther:(FSTimeStampServer *)other;
		[Export ("initWithOther:")]
		IntPtr Constructor (FSTimeStampServer other);

		// -(BOOL)isEmpty;
		[Export ("isEmpty")]
		//[Verify (MethodToProperty)]
		bool IsEmpty { get; }

		// -(FSTimeStampServerSendRequestResult)sendTimeStampRequest:(NSString *)request;
		[Export ("sendTimeStampRequest:")]
		FSTimeStampServerSendRequestResult SendTimeStampRequest (string request);

		// -(NSString *)getTimeStampMessage;
		[Export ("getTimeStampMessage")]
		//[Verify (MethodToProperty)]
		string TimeStampMessage { get; }

		// -(void)dealloc;
		[Export ("dealloc")]
		void Dealloc ();
	}

	// @interface FSPagingSealConfig : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface FSPagingSealConfig
	{
		// @property (getter = getPaging_seal_position, nonatomic) FSPagingSealConfigPagingSealPosition paging_seal_position;
		[Export ("paging_seal_position", ArgumentSemantic.Assign)]
		FSPagingSealConfigPagingSealPosition Paging_seal_position { [Bind ("getPaging_seal_position")] get; set; }

		// @property (getter = getOffset, nonatomic) float offset;
		[Export ("offset")]
		float Offset { [Bind ("getOffset")] get; set; }

		// @property (getter = getFirst_page_percent, nonatomic) float first_page_percent;
		[Export ("first_page_percent")]
		float First_page_percent { [Bind ("getFirst_page_percent")] get; set; }

		// @property (getter = getIs_on_perforation, nonatomic) BOOL is_on_perforation;
		[Export ("is_on_perforation")]
		bool Is_on_perforation { [Bind ("getIs_on_perforation")] get; set; }

		// @property (getter = getPaging_seal_style, nonatomic) FSPagingSealConfigPagingSealStyle paging_seal_style;
		[Export ("paging_seal_style", ArgumentSemantic.Assign)]
		FSPagingSealConfigPagingSealStyle Paging_seal_style { [Bind ("getPaging_seal_style")] get; set; }

		// @property (getter = getIs_display_multiple_seal, nonatomic) BOOL is_display_multiple_seal;
		[Export ("is_display_multiple_seal")]
		bool Is_display_multiple_seal { [Bind ("getIs_display_multiple_seal")] get; set; }

		// @property (getter = getPage_count_for_each_seal, nonatomic) int page_count_for_each_seal;
		[Export ("page_count_for_each_seal")]
		int Page_count_for_each_seal { [Bind ("getPage_count_for_each_seal")] get; set; }

		// -(void *)getCptr;
		[Export ("getCptr")]
		//[Verify (MethodToProperty)]
		IntPtr Cptr { get; }

		// -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
		[Export ("initWithCptr:swigOwnCObject:")]
		IntPtr Constructor (IntPtr cptr, bool ownCObject);

		// -(id)initWithPaging_seal_position:(FSPagingSealConfigPagingSealPosition)paging_seal_position offset:(float)offset first_page_percent:(float)first_page_percent is_on_perforation:(BOOL)is_on_perforation paging_seal_style:(FSPagingSealConfigPagingSealStyle)paging_seal_style is_display_multiple_seal:(BOOL)is_display_multiple_seal page_count_for_each_seal:(int)page_count_for_each_seal;
		[Export ("initWithPaging_seal_position:offset:first_page_percent:is_on_perforation:paging_seal_style:is_display_multiple_seal:page_count_for_each_seal:")]
		IntPtr Constructor (FSPagingSealConfigPagingSealPosition paging_seal_position, float offset, float first_page_percent, bool is_on_perforation, FSPagingSealConfigPagingSealStyle paging_seal_style, bool is_display_multiple_seal, int page_count_for_each_seal);

		// -(id)initWithPaging_seal_position:(FSPagingSealConfigPagingSealPosition)paging_seal_position offset:(float)offset first_page_percent:(float)first_page_percent is_on_perforation:(BOOL)is_on_perforation paging_seal_style:(FSPagingSealConfigPagingSealStyle)paging_seal_style is_display_multiple_seal:(BOOL)is_display_multiple_seal;
		[Export ("initWithPaging_seal_position:offset:first_page_percent:is_on_perforation:paging_seal_style:is_display_multiple_seal:")]
		IntPtr Constructor (FSPagingSealConfigPagingSealPosition paging_seal_position, float offset, float first_page_percent, bool is_on_perforation, FSPagingSealConfigPagingSealStyle paging_seal_style, bool is_display_multiple_seal);

		// -(id)initWithPaging_seal_position:(FSPagingSealConfigPagingSealPosition)paging_seal_position offset:(float)offset first_page_percent:(float)first_page_percent is_on_perforation:(BOOL)is_on_perforation paging_seal_style:(FSPagingSealConfigPagingSealStyle)paging_seal_style;
		[Export ("initWithPaging_seal_position:offset:first_page_percent:is_on_perforation:paging_seal_style:")]
		IntPtr Constructor (FSPagingSealConfigPagingSealPosition paging_seal_position, float offset, float first_page_percent, bool is_on_perforation, FSPagingSealConfigPagingSealStyle paging_seal_style);

		// -(id)initWithPaging_seal_position:(FSPagingSealConfigPagingSealPosition)paging_seal_position offset:(float)offset first_page_percent:(float)first_page_percent is_on_perforation:(BOOL)is_on_perforation;
		[Export ("initWithPaging_seal_position:offset:first_page_percent:is_on_perforation:")]
		IntPtr Constructor (FSPagingSealConfigPagingSealPosition paging_seal_position, float offset, float first_page_percent, bool is_on_perforation);

		// -(void)set:(FSPagingSealConfigPagingSealPosition)paging_seal_position offset:(float)offset first_page_percent:(float)first_page_percent is_on_perforation:(BOOL)is_on_perforation paging_seal_style:(FSPagingSealConfigPagingSealStyle)paging_seal_style is_display_multiple_seal:(BOOL)is_display_multiple_seal page_count_for_each_seal:(int)page_count_for_each_seal;
		[Export ("set:offset:first_page_percent:is_on_perforation:paging_seal_style:is_display_multiple_seal:page_count_for_each_seal:")]
		void Set (FSPagingSealConfigPagingSealPosition paging_seal_position, float offset, float first_page_percent, bool is_on_perforation, FSPagingSealConfigPagingSealStyle paging_seal_style, bool is_display_multiple_seal, int page_count_for_each_seal);

		// -(void)set:(FSPagingSealConfigPagingSealPosition)paging_seal_position offset:(float)offset first_page_percent:(float)first_page_percent is_on_perforation:(BOOL)is_on_perforation paging_seal_style:(FSPagingSealConfigPagingSealStyle)paging_seal_style is_display_multiple_seal:(BOOL)is_display_multiple_seal;
		[Export ("set:offset:first_page_percent:is_on_perforation:paging_seal_style:is_display_multiple_seal:")]
		void Set (FSPagingSealConfigPagingSealPosition paging_seal_position, float offset, float first_page_percent, bool is_on_perforation, FSPagingSealConfigPagingSealStyle paging_seal_style, bool is_display_multiple_seal);

		// -(void)set:(FSPagingSealConfigPagingSealPosition)paging_seal_position offset:(float)offset first_page_percent:(float)first_page_percent is_on_perforation:(BOOL)is_on_perforation paging_seal_style:(FSPagingSealConfigPagingSealStyle)paging_seal_style;
		[Export ("set:offset:first_page_percent:is_on_perforation:paging_seal_style:")]
		void Set (FSPagingSealConfigPagingSealPosition paging_seal_position, float offset, float first_page_percent, bool is_on_perforation, FSPagingSealConfigPagingSealStyle paging_seal_style);

		// -(void)dealloc;
		[Export ("dealloc")]
		void Dealloc ();
	}

	// @interface FSPagingSealSignature : FSSignature
	[BaseType (typeof(FSSignature))]
	[DisableDefaultCtor]
	interface FSPagingSealSignature
	{
		// -(void *)getCptr;
		[Export ("getCptr")]
		//[Verify (MethodToProperty)]
		IntPtr Cptr { get; }

		// -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
		[Export ("initWithCptr:swigOwnCObject:")]
		IntPtr Constructor (IntPtr cptr, bool ownCObject);

		// -(void)setPagingSealConfig:(FSPagingSealConfig *)paging_seal_config;
		[Export ("setPagingSealConfig:")]
		void SetPagingSealConfig (FSPagingSealConfig paging_seal_config);

		// -(void)setAPStateBitmap:(FSPagingSealSignaturePagingSealAPState)ap_state bitmap:(FSBitmap *)bitmap;
		[Export ("setAPStateBitmap:bitmap:")]
		void SetAPStateBitmap (FSPagingSealSignaturePagingSealAPState ap_state, FSBitmap bitmap);

		// -(BOOL)generateAppearance;
		[Export ("generateAppearance")]
		//[Verify (MethodToProperty)]
		bool GenerateAppearance { get; }

		// -(void)dealloc;
		[Export ("dealloc")]
		void Dealloc ();
	}

	// @interface FSResponse : NSObject
	[BaseType (typeof(NSObject))]
	interface FSResponse
	{
		// @property (getter = getType, nonatomic) FSResponseResponseType type;
		[Export ("type", ArgumentSemantic.Assign)]
		FSResponseResponseType Type { [Bind ("getType")] get; set; }

		// @property (getter = getResponse_data, copy, nonatomic) NSString * response_data;
		[Export ("response_data")]
		string Response_data { [Bind ("getResponse_data")] get; set; }

		// -(void *)getCptr;
		[Export ("getCptr")]
		//[Verify (MethodToProperty)]
		IntPtr Cptr { get; }

		// -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
		[Export ("initWithCptr:swigOwnCObject:")]
		IntPtr Constructor (IntPtr cptr, bool ownCObject);

		// -(id)initWithType:(FSResponseResponseType)type response_data:(NSString *)response_data;
		[Export ("initWithType:response_data:")]
		IntPtr Constructor (FSResponseResponseType type, string response_data);

		// -(id)initWithOther:(FSResponse *)other;
		[Export ("initWithOther:")]
		IntPtr Constructor (FSResponse other);

		// -(void)set:(FSResponseResponseType)type response_data:(NSString *)response_data;
		[Export ("set:response_data:")]
		void Set (FSResponseResponseType type, string response_data);

		// -(void)dealloc;
		[Export ("dealloc")]
		void Dealloc ();
	}

	// @interface FSTimeRange : NSObject
	[BaseType (typeof(NSObject))]
	interface FSTimeRange
	{
		// @property (getter = getStart_time, copy, nonatomic) FSDateTime * start_time;
		[Export ("start_time", ArgumentSemantic.Copy)]
		FSDateTime Start_time { [Bind ("getStart_time")] get; set; }

		// @property (getter = getEnd_time, copy, nonatomic) FSDateTime * end_time;
		[Export ("end_time", ArgumentSemantic.Copy)]
		FSDateTime End_time { [Bind ("getEnd_time")] get; set; }

		// -(void *)getCptr;
		[Export ("getCptr")]
		//[Verify (MethodToProperty)]
		IntPtr Cptr { get; }

		// -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
		[Export ("initWithCptr:swigOwnCObject:")]
		IntPtr Constructor (IntPtr cptr, bool ownCObject);

		// -(id)initWithStart_time:(FSDateTime *)start_time end_time:(FSDateTime *)end_time;
		[Export ("initWithStart_time:end_time:")]
		IntPtr Constructor (FSDateTime start_time, FSDateTime end_time);

		// -(id)initWithOther:(FSTimeRange *)other;
		[Export ("initWithOther:")]
		IntPtr Constructor (FSTimeRange other);

		// -(void)set:(FSDateTime *)start_time end_time:(FSDateTime *)end_time;
		[Export ("set:end_time:")]
		void Set (FSDateTime start_time, FSDateTime end_time);

		// -(void)dealloc;
		[Export ("dealloc")]
		void Dealloc ();
	}

	// @interface FSCertVerifyResult : NSObject
	[BaseType (typeof(NSObject))]
	interface FSCertVerifyResult
	{
		// @property (getter = getCert, copy, nonatomic) NSString * cert;
		[Export ("cert")]
		string Cert { [Bind ("getCert")] get; set; }

		// @property (getter = getIs_ca, nonatomic) BOOL is_ca;
		[Export ("is_ca")]
		bool Is_ca { [Bind ("getIs_ca")] get; set; }

		// @property (getter = getIs_trusted, nonatomic) BOOL is_trusted;
		[Export ("is_trusted")]
		bool Is_trusted { [Bind ("getIs_trusted")] get; set; }

		// @property (getter = getResponse, copy, nonatomic) FSResponse * response;
		[Export ("response", ArgumentSemantic.Copy)]
		FSResponse Response { [Bind ("getResponse")] get; set; }

		// @property (getter = getResponse_effect_time_range, copy, nonatomic) FSTimeRange * response_effect_time_range;
		[Export ("response_effect_time_range", ArgumentSemantic.Copy)]
		FSTimeRange Response_effect_time_range { [Bind ("getResponse_effect_time_range")] get; set; }

		// @property (getter = getRevoke_time, copy, nonatomic) FSDateTime * revoke_time;
		[Export ("revoke_time", ArgumentSemantic.Copy)]
		FSDateTime Revoke_time { [Bind ("getRevoke_time")] get; set; }

		// @property (getter = getCert_status, nonatomic) FSCertVerifyResultCertStatus cert_status;
		[Export ("cert_status", ArgumentSemantic.Assign)]
		FSCertVerifyResultCertStatus Cert_status { [Bind ("getCert_status")] get; set; }

		// @property (getter = getReason, nonatomic) FSCertVerifyResultRevocationReason reason;
		[Export ("reason", ArgumentSemantic.Assign)]
		FSCertVerifyResultRevocationReason Reason { [Bind ("getReason")] get; set; }

		// @property (getter = getCert_check_time, copy, nonatomic) FSDateTime * cert_check_time;
		[Export ("cert_check_time", ArgumentSemantic.Copy)]
		FSDateTime Cert_check_time { [Bind ("getCert_check_time")] get; set; }

		// @property (getter = getExist_signature_vri_creation_time, nonatomic) BOOL exist_signature_vri_creation_time;
		[Export ("exist_signature_vri_creation_time")]
		bool Exist_signature_vri_creation_time { [Bind ("getExist_signature_vri_creation_time")] get; set; }

		// @property (getter = getSignature_vri_creation_time, copy, nonatomic) FSDateTime * signature_vri_creation_time;
		[Export ("signature_vri_creation_time", ArgumentSemantic.Copy)]
		FSDateTime Signature_vri_creation_time { [Bind ("getSignature_vri_creation_time")] get; set; }

		// @property (getter = getExist_response_signature_vri_creation_time, nonatomic) BOOL exist_response_signature_vri_creation_time;
		[Export ("exist_response_signature_vri_creation_time")]
		bool Exist_response_signature_vri_creation_time { [Bind ("getExist_response_signature_vri_creation_time")] get; set; }

		// @property (getter = getResponse_signature_vri_creation_time, copy, nonatomic) FSDateTime * response_signature_vri_creation_time;
		[Export ("response_signature_vri_creation_time", ArgumentSemantic.Copy)]
		FSDateTime Response_signature_vri_creation_time { [Bind ("getResponse_signature_vri_creation_time")] get; set; }

		// @property (getter = getResponse_info_location, nonatomic) FSCertVerifyResultResponseInfoLocation response_info_location;
		[Export ("response_info_location", ArgumentSemantic.Assign)]
		FSCertVerifyResultResponseInfoLocation Response_info_location { [Bind ("getResponse_info_location")] get; set; }

		// -(void *)getCptr;
		[Export ("getCptr")]
		//[Verify (MethodToProperty)]
		IntPtr Cptr { get; }

		// -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
		[Export ("initWithCptr:swigOwnCObject:")]
		IntPtr Constructor (IntPtr cptr, bool ownCObject);

		// -(id)initWithCert:(NSString *)cert is_ca:(BOOL)is_ca is_trusted:(BOOL)is_trusted response:(FSResponse *)response response_effect_time_range:(FSTimeRange *)response_effect_time_range revoke_time:(FSDateTime *)revoke_time cert_status:(FSCertVerifyResultCertStatus)cert_status reason:(FSCertVerifyResultRevocationReason)reason cert_check_time:(FSDateTime *)cert_check_time exist_signature_vri_creation_time:(BOOL)exist_signature_vri_creation_time signature_vri_creation_time:(FSDateTime *)signature_vri_creation_time exist_response_signature_vri_creation_time:(BOOL)exist_response_signature_vri_creation_time response_signature_vri_creation_time:(FSDateTime *)response_signature_vri_creation_time response_info_location:(FSCertVerifyResultResponseInfoLocation)response_info_location;
		[Export ("initWithCert:is_ca:is_trusted:response:response_effect_time_range:revoke_time:cert_status:reason:cert_check_time:exist_signature_vri_creation_time:signature_vri_creation_time:exist_response_signature_vri_creation_time:response_signature_vri_creation_time:response_info_location:")]
		IntPtr Constructor (string cert, bool is_ca, bool is_trusted, FSResponse response, FSTimeRange response_effect_time_range, FSDateTime revoke_time, FSCertVerifyResultCertStatus cert_status, FSCertVerifyResultRevocationReason reason, FSDateTime cert_check_time, bool exist_signature_vri_creation_time, FSDateTime signature_vri_creation_time, bool exist_response_signature_vri_creation_time, FSDateTime response_signature_vri_creation_time, FSCertVerifyResultResponseInfoLocation response_info_location);

		// -(id)initWithOther:(FSCertVerifyResult *)other;
		[Export ("initWithOther:")]
		IntPtr Constructor (FSCertVerifyResult other);

		// -(void)set:(NSString *)cert is_ca:(BOOL)is_ca is_trusted:(BOOL)is_trusted response:(FSResponse *)response response_effect_time_range:(FSTimeRange *)response_effect_time_range revoke_time:(FSDateTime *)revoke_time cert_status:(FSCertVerifyResultCertStatus)cert_status reason:(FSCertVerifyResultRevocationReason)reason cert_check_time:(FSDateTime *)cert_check_time exist_signature_vri_creation_time:(BOOL)exist_signature_vri_creation_time signature_vri_creation_time:(FSDateTime *)signature_vri_creation_time exist_response_signature_vri_creation_time:(BOOL)exist_response_signature_vri_creation_time response_signature_vri_creation_time:(FSDateTime *)response_signature_vri_creation_time response_info_location:(FSCertVerifyResultResponseInfoLocation)response_info_location;
		[Export ("set:is_ca:is_trusted:response:response_effect_time_range:revoke_time:cert_status:reason:cert_check_time:exist_signature_vri_creation_time:signature_vri_creation_time:exist_response_signature_vri_creation_time:response_signature_vri_creation_time:response_info_location:")]
		void Set (string cert, bool is_ca, bool is_trusted, FSResponse response, FSTimeRange response_effect_time_range, FSDateTime revoke_time, FSCertVerifyResultCertStatus cert_status, FSCertVerifyResultRevocationReason reason, FSDateTime cert_check_time, bool exist_signature_vri_creation_time, FSDateTime signature_vri_creation_time, bool exist_response_signature_vri_creation_time, FSDateTime response_signature_vri_creation_time, FSCertVerifyResultResponseInfoLocation response_info_location);

		// -(void)dealloc;
		[Export ("dealloc")]
		void Dealloc ();
	}

	// @interface FSCertVerifyResultArray : NSObject
	[BaseType (typeof(NSObject))]
	interface FSCertVerifyResultArray
	{
		// -(void *)getCptr;
		[Export ("getCptr")]
		//[Verify (MethodToProperty)]
		IntPtr Cptr { get; }

		// -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
		[Export ("initWithCptr:swigOwnCObject:")]
		IntPtr Constructor (IntPtr cptr, bool ownCObject);

		// -(id)initWithOther:(FSCertVerifyResultArray *)other;
		[Export ("initWithOther:")]
		IntPtr Constructor (FSCertVerifyResultArray other);

		// -(unsigned long)getSize;
		[Export ("getSize")]
		//[Verify (MethodToProperty)]
		nuint Size { get; }

		// -(FSCertVerifyResult *)getAt:(unsigned long)index;
		[Export ("getAt:")]
		FSCertVerifyResult GetAt (nuint index);

		// -(void)add:(FSCertVerifyResult *)element;
		[Export ("add:")]
		void Add (FSCertVerifyResult element);

		// -(void)removeAt:(unsigned long)index;
		[Export ("removeAt:")]
		void RemoveAt (nuint index);

		// -(void)insertAt:(unsigned long)index element:(FSCertVerifyResult *)element;
		[Export ("insertAt:element:")]
		void InsertAt (nuint index, FSCertVerifyResult element);

		// -(void)removeAll;
		[Export ("removeAll")]
		void RemoveAll ();

		// -(void)dealloc;
		[Export ("dealloc")]
		void Dealloc ();
	}

	// @interface FSCertIssuerPair : NSObject
	[BaseType (typeof(NSObject))]
	interface FSCertIssuerPair
	{
		// @property (getter = getCert, copy, nonatomic) NSString * cert;
		[Export ("cert")]
		string Cert { [Bind ("getCert")] get; set; }

		// @property (getter = getIssuer, copy, nonatomic) NSString * issuer;
		[Export ("issuer")]
		string Issuer { [Bind ("getIssuer")] get; set; }

		// -(void *)getCptr;
		[Export ("getCptr")]
		//[Verify (MethodToProperty)]
		IntPtr Cptr { get; }

		// -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
		[Export ("initWithCptr:swigOwnCObject:")]
		IntPtr Constructor (IntPtr cptr, bool ownCObject);

		// -(id)initWithCert:(NSString *)cert issuer:(NSString *)issuer;
		[Export ("initWithCert:issuer:")]
		IntPtr Constructor (string cert, string issuer);

		// -(id)initWithOther:(FSCertIssuerPair *)other;
		[Export ("initWithOther:")]
		IntPtr Constructor (FSCertIssuerPair other);

		// -(void)set:(NSString *)cert issuer:(NSString *)issuer;
		[Export ("set:issuer:")]
		void Set (string cert, string issuer);

		// -(void)dealloc;
		[Export ("dealloc")]
		void Dealloc ();
	}

	// @interface FSRevocationArrayInfo : NSObject
	[BaseType (typeof(NSObject))]
	interface FSRevocationArrayInfo
	{
		// @property (getter = getOcsp_array, copy, nonatomic) NSArray<NSData *> * ocsp_array;
		[Export ("ocsp_array", ArgumentSemantic.Copy)]
		NSData[] Ocsp_array { [Bind ("getOcsp_array")] get; set; }

		// @property (getter = getCrl_array, copy, nonatomic) NSArray<NSData *> * crl_array;
		[Export ("crl_array", ArgumentSemantic.Copy)]
		NSData[] Crl_array { [Bind ("getCrl_array")] get; set; }

		// -(void *)getCptr;
		[Export ("getCptr")]
		//[Verify (MethodToProperty)]
		IntPtr Cptr { get; }

		// -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
		[Export ("initWithCptr:swigOwnCObject:")]
		IntPtr Constructor (IntPtr cptr, bool ownCObject);

		// -(id)initWithOcsp_array:(NSArray<NSData *> *)ocsp_array crl_array:(NSArray<NSData *> *)crl_array;
		[Export ("initWithOcsp_array:crl_array:")]
		IntPtr Constructor (NSData[] ocsp_array, NSData[] crl_array);

		// -(id)initWithOther:(FSRevocationArrayInfo *)other;
		[Export ("initWithOther:")]
		IntPtr Constructor (FSRevocationArrayInfo other);

		// -(void)set:(NSArray<NSData *> *)ocsp_array crl_array:(NSArray<NSData *> *)crl_array;
		[Export ("set:crl_array:")]
		void Set (NSData[] ocsp_array, NSData[] crl_array);

		// -(void)dealloc;
		[Export ("dealloc")]
		void Dealloc ();
	}

	// @interface FSSignatureVerifyResultArray : NSObject
	[BaseType (typeof(NSObject))]
	interface FSSignatureVerifyResultArray
	{
		// -(void *)getCptr;
		[Export ("getCptr")]
		//[Verify (MethodToProperty)]
		IntPtr Cptr { get; }

		// -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
		[Export ("initWithCptr:swigOwnCObject:")]
		IntPtr Constructor (IntPtr cptr, bool ownCObject);

		// -(id)initWithOther:(FSSignatureVerifyResultArray *)other;
		[Export ("initWithOther:")]
		IntPtr Constructor (FSSignatureVerifyResultArray other);

		// -(unsigned long)getSize;
		[Export ("getSize")]
		//[Verify (MethodToProperty)]
		nuint Size { get; }

		// -(FSSignatureVerifyResult *)getAt:(unsigned long)index;
		[Export ("getAt:")]
		FSSignatureVerifyResult GetAt (nuint index);

		// -(void)add:(FSSignatureVerifyResult *)element;
		[Export ("add:")]
		void Add (FSSignatureVerifyResult element);

		// -(void)removeAt:(unsigned long)index;
		[Export ("removeAt:")]
		void RemoveAt (nuint index);

		// -(void)insertAt:(unsigned long)index element:(FSSignatureVerifyResult *)element;
		[Export ("insertAt:element:")]
		void InsertAt (nuint index, FSSignatureVerifyResult element);

		// -(void)removeAll;
		[Export ("removeAll")]
		void RemoveAll ();

		// -(void)dealloc;
		[Export ("dealloc")]
		void Dealloc ();
	}

	// @interface FSLTVVerifier : FSBase
	[BaseType (typeof(FSBase))]
	[DisableDefaultCtor]
	interface FSLTVVerifier
	{
		// -(void *)getCptr;
		[Export ("getCptr")]
		//[Verify (MethodToProperty)]
		IntPtr Cptr { get; }

		// -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
		[Export ("initWithCptr:swigOwnCObject:")]
		IntPtr Constructor (IntPtr cptr, bool ownCObject);

		// -(id)initWithDocument:(FSPDFDoc *)document is_verify_signature:(BOOL)is_verify_signature use_expired_tst:(BOOL)use_expired_tst ignore_doc_info:(BOOL)ignore_doc_info time_type:(FSLTVVerifierTimeType)time_type;
		[Export ("initWithDocument:is_verify_signature:use_expired_tst:ignore_doc_info:time_type:")]
		IntPtr Constructor (FSPDFDoc document, bool is_verify_signature, bool use_expired_tst, bool ignore_doc_info, FSLTVVerifierTimeType time_type);

		// -(id)initWithOther:(FSLTVVerifier *)other;
		[Export ("initWithOther:")]
		IntPtr Constructor (FSLTVVerifier other);

		// -(BOOL)isEmpty;
		[Export ("isEmpty")]
		//[Verify (MethodToProperty)]
		bool IsEmpty { get; }

		// -(void)setRevocationCallback:(id<FSRevocationCallback>)callback;
		[Export ("setRevocationCallback:")]
		void SetRevocationCallback (NSObject callback);

		// -(void)setVerifyMode:(FSLTVVerifierVerifyMode)mode;
		[Export ("setVerifyMode:")]
		void SetVerifyMode (FSLTVVerifierVerifyMode mode);

		// -(void)setTrustedCertStoreCallback:(id<FSTrustedCertStoreCallback>)callback;
		[Export ("setTrustedCertStoreCallback:")]
		void SetTrustedCertStoreCallback (NSObject callback);

		// -(FSSignatureVerifyResultArray *)verify;
		[Export ("verify")]
		//[Verify (MethodToProperty)]
		FSSignatureVerifyResultArray Verify { get; }

		// -(FSSignatureVerifyResultArray *)verifySignature:(FSSignature *)signature;
		[Export ("verifySignature:")]
		FSSignatureVerifyResultArray VerifySignature (FSSignature signature);

		// -(void)addDSS:(FSSignatureVerifyResult *)signature_verify_result;
		[Export ("addDSS:")]
		void AddDSS (FSSignatureVerifyResult signature_verify_result);

		// -(void)dealloc;
		[Export ("dealloc")]
		void Dealloc ();
	}

	// @interface FSSignatureVerifyResult : FSBase
	[BaseType (typeof(FSBase))]
	[DisableDefaultCtor]
	interface FSSignatureVerifyResult
	{
		// -(void *)getCptr;
		[Export ("getCptr")]
		//[Verify (MethodToProperty)]
		IntPtr Cptr { get; }

		// -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
		[Export ("initWithCptr:swigOwnCObject:")]
		IntPtr Constructor (IntPtr cptr, bool ownCObject);

		// -(id)initWithOther:(FSSignatureVerifyResult *)other;
		[Export ("initWithOther:")]
		IntPtr Constructor (FSSignatureVerifyResult other);

		// -(BOOL)isEmpty;
		[Export ("isEmpty")]
		//[Verify (MethodToProperty)]
		bool IsEmpty { get; }

		// -(NSString *)getSignatureName;
		[Export ("getSignatureName")]
		//[Verify (MethodToProperty)]
		string SignatureName { get; }

		// -(NSString *)getSignatureHashValue;
		[Export ("getSignatureHashValue")]
		//[Verify (MethodToProperty)]
		string SignatureHashValue { get; }

		// -(unsigned int)getSignatureState;
		[Export ("getSignatureState")]
		//[Verify (MethodToProperty)]
		uint SignatureState { get; }

		// -(FSDateTime *)getSignatureCheckTime;
		[Export ("getSignatureCheckTime")]
		//[Verify (MethodToProperty)]
		FSDateTime SignatureCheckTime { get; }

		// -(FSLTVVerifierTimeType)getSignatureCheckTimeType;
		[Export ("getSignatureCheckTimeType")]
		//[Verify (MethodToProperty)]
		FSLTVVerifierTimeType SignatureCheckTimeType { get; }

		// -(FSSignatureVerifyResultLTVState)getLTVState;
		[Export ("getLTVState")]
		//[Verify (MethodToProperty)]
		FSSignatureVerifyResultLTVState LTVState { get; }

		// -(FSCertVerifyResultArray *)getCertificateVerifyResults;
		[Export ("getCertificateVerifyResults")]
		//[Verify (MethodToProperty)]
		FSCertVerifyResultArray CertificateVerifyResults { get; }

		// -(FSSignatureVerifyResultArray *)getOCSPSigantureVerifyResults;
		[Export ("getOCSPSigantureVerifyResults")]
		//[Verify (MethodToProperty)]
		FSSignatureVerifyResultArray OCSPSigantureVerifyResults { get; }

		// -(FSSignatureVerifyResult *)getTSTSignatureVerifyResult;
		[Export ("getTSTSignatureVerifyResult")]
		//[Verify (MethodToProperty)]
		FSSignatureVerifyResult TSTSignatureVerifyResult { get; }

		// -(void)dealloc;
		[Export ("dealloc")]
		void Dealloc ();
	}

	// @interface FSPortfolioNode : FSBase
	[BaseType (typeof(FSBase))]
	interface FSPortfolioNode
	{
		// -(void *)getCptr;
		[Export ("getCptr")]
		//[Verify (MethodToProperty)]
		IntPtr Cptr { get; }

		// -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
		[Export ("initWithCptr:swigOwnCObject:")]
		IntPtr Constructor (IntPtr cptr, bool ownCObject);

		// -(id)initWithOther:(FSPortfolioNode *)other;
		[Export ("initWithOther:")]
		IntPtr Constructor (FSPortfolioNode other);

		// -(BOOL)isEmpty;
		[Export ("isEmpty")]
		//[Verify (MethodToProperty)]
		bool IsEmpty { get; }

		// -(FSPortfolioNodeType)getNodeType;
		[Export ("getNodeType")]
		//[Verify (MethodToProperty)]
		FSPortfolioNodeType NodeType { get; }

		// -(void)dealloc;
		[Export ("dealloc")]
		void Dealloc ();
	}

	// @interface FSPortfolioNodeArray : NSObject
	[BaseType (typeof(NSObject))]
	interface FSPortfolioNodeArray
	{
		// -(void *)getCptr;
		[Export ("getCptr")]
		//[Verify (MethodToProperty)]
		IntPtr Cptr { get; }

		// -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
		[Export ("initWithCptr:swigOwnCObject:")]
		IntPtr Constructor (IntPtr cptr, bool ownCObject);

		// -(id)initWithOther:(FSPortfolioNodeArray *)other;
		[Export ("initWithOther:")]
		IntPtr Constructor (FSPortfolioNodeArray other);

		// -(unsigned long)getSize;
		[Export ("getSize")]
		//[Verify (MethodToProperty)]
		nuint Size { get; }

		// -(FSPortfolioNode *)getAt:(unsigned long)index;
		[Export ("getAt:")]
		FSPortfolioNode GetAt (nuint index);

		// -(void)add:(FSPortfolioNode *)element;
		[Export ("add:")]
		void Add (FSPortfolioNode element);

		// -(void)removeAt:(unsigned long)index;
		[Export ("removeAt:")]
		void RemoveAt (nuint index);

		// -(void)insertAt:(unsigned long)index element:(FSPortfolioNode *)element;
		[Export ("insertAt:element:")]
		void InsertAt (nuint index, FSPortfolioNode element);

		// -(void)removeAll;
		[Export ("removeAll")]
		void RemoveAll ();

		// -(void)dealloc;
		[Export ("dealloc")]
		void Dealloc ();
	}

	// @interface FSPortfolioFolderNode : FSPortfolioNode
	[BaseType (typeof(FSPortfolioNode))]
	[DisableDefaultCtor]
	interface FSPortfolioFolderNode
	{
		// @property (getter = getDescription, copy, nonatomic) NSString * description;
		[Export ("description")]
		string Description { [Bind ("getDescription")] get; set; }

		// -(void *)getCptr;
		[Export ("getCptr")]
		//[Verify (MethodToProperty)]
		IntPtr Cptr { get; }

		// -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
		[Export ("initWithCptr:swigOwnCObject:")]
		IntPtr Constructor (IntPtr cptr, bool ownCObject);

		// -(id)initWithOther:(FSPortfolioNode *)other;
		[Export ("initWithOther:")]
		IntPtr Constructor (FSPortfolioNode other);

		// -(BOOL)isRoot;
		[Export ("isRoot")]
		//[Verify (MethodToProperty)]
		bool IsRoot { get; }

		// -(NSString *)getName;
		[Export ("getName")]
		//[Verify (MethodToProperty)]
		string Name { get; }

		// -(FSPortfolioFileNode *)addFile:(NSString *)file_path;
		[Export ("addFile:")]
		FSPortfolioFileNode AddFile (string file_path);

		// -(FSPortfolioFileNode *)addFileWithStreamCallback:(id<FSStreamCallback>)file_stream file_name:(NSString *)file_name;
		[Export ("addFileWithStreamCallback:file_name:")]
		FSPortfolioFileNode AddFileWithStreamCallback (NSObject file_stream, string file_name);

		// -(FSPortfolioFileNode *)addPDFDoc:(FSPDFDoc *)pdf_doc file_name:(NSString *)file_name;
		[Export ("addPDFDoc:file_name:")]
		FSPortfolioFileNode AddPDFDoc (FSPDFDoc pdf_doc, string file_name);

		// -(FSPortfolioFolderNode *)addSubFolder:(NSString *)folder_name;
		[Export ("addSubFolder:")]
		FSPortfolioFolderNode AddSubFolder (string folder_name);

		// -(void)removeSubNode:(FSPortfolioNode *)sub_node;
		[Export ("removeSubNode:")]
		void RemoveSubNode (FSPortfolioNode sub_node);

		// -(FSPortfolioNodeArray *)getSortedSubNodes;
		[Export ("getSortedSubNodes")]
		//[Verify (MethodToProperty)]
		FSPortfolioNodeArray SortedSubNodes { get; }

		// -(FSDateTime *)getModifiedDateTime;
		[Export ("getModifiedDateTime")]
		//[Verify (MethodToProperty)]
		FSDateTime ModifiedDateTime { get; }

		// -(FSDateTime *)getCreationDateTime;
		[Export ("getCreationDateTime")]
		//[Verify (MethodToProperty)]
		FSDateTime CreationDateTime { get; }

		// -(void)dealloc;
		[Export ("dealloc")]
		void Dealloc ();
	}

	// @interface FSPortfolioFileNode : FSPortfolioNode
	[BaseType (typeof(FSPortfolioNode))]
	[DisableDefaultCtor]
	interface FSPortfolioFileNode
	{
		// -(void *)getCptr;
		[Export ("getCptr")]
		//[Verify (MethodToProperty)]
		IntPtr Cptr { get; }

		// -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
		[Export ("initWithCptr:swigOwnCObject:")]
		IntPtr Constructor (IntPtr cptr, bool ownCObject);

		// -(id)initWithOther:(FSPortfolioNode *)other;
		[Export ("initWithOther:")]
		IntPtr Constructor (FSPortfolioNode other);

		// -(FSFileSpec *)getFileSpec;
		[Export ("getFileSpec")]
		//[Verify (MethodToProperty)]
		FSFileSpec FileSpec { get; }

		// -(NSString *)getKeyName;
		[Export ("getKeyName")]
		//[Verify (MethodToProperty)]
		string KeyName { get; }

		// -(void)dealloc;
		[Export ("dealloc")]
		void Dealloc ();
	}

	// @interface FSSchemaField : FSBase
	[BaseType (typeof(FSBase))]
	interface FSSchemaField
	{
		// @property (getter = getKeyName, copy, nonatomic) NSString * keyName;
		[Export ("keyName")]
		string KeyName { [Bind ("getKeyName")] get; set; }

		// @property (getter = getSubtypeName, copy, nonatomic) NSString * subtypeName;
		[Export ("subtypeName")]
		string SubtypeName { [Bind ("getSubtypeName")] get; set; }

		// @property (getter = getDisplayName, copy, nonatomic) NSString * displayName;
		[Export ("displayName")]
		string DisplayName { [Bind ("getDisplayName")] get; set; }

		// -(void *)getCptr;
		[Export ("getCptr")]
		//[Verify (MethodToProperty)]
		IntPtr Cptr { get; }

		// -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
		[Export ("initWithCptr:swigOwnCObject:")]
		IntPtr Constructor (IntPtr cptr, bool ownCObject);

		// -(id)initWithOther:(FSSchemaField *)other;
		[Export ("initWithOther:")]
		IntPtr Constructor (FSSchemaField other);

		// -(BOOL)isEmpty;
		[Export ("isEmpty")]
		//[Verify (MethodToProperty)]
		bool IsEmpty { get; }

		// -(BOOL)isVisible;
		[Export ("isVisible")]
		//[Verify (MethodToProperty)]
		bool IsVisible { get; }

		// -(void)setVisibility:(BOOL)is_visible;
		[Export ("setVisibility:")]
		void SetVisibility (bool is_visible);

		// -(void)dealloc;
		[Export ("dealloc")]
		void Dealloc ();
	}

	// @interface FSSchemaFieldArray : NSObject
	[BaseType (typeof(NSObject))]
	interface FSSchemaFieldArray
	{
		// -(void *)getCptr;
		[Export ("getCptr")]
		//[Verify (MethodToProperty)]
		IntPtr Cptr { get; }

		// -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
		[Export ("initWithCptr:swigOwnCObject:")]
		IntPtr Constructor (IntPtr cptr, bool ownCObject);

		// -(id)initWithOther:(FSSchemaFieldArray *)other;
		[Export ("initWithOther:")]
		IntPtr Constructor (FSSchemaFieldArray other);

		// -(unsigned long)getSize;
		[Export ("getSize")]
		//[Verify (MethodToProperty)]
		nuint Size { get; }

		// -(FSSchemaField *)getAt:(unsigned long)index;
		[Export ("getAt:")]
		FSSchemaField GetAt (nuint index);

		// -(void)add:(FSSchemaField *)element;
		[Export ("add:")]
		void Add (FSSchemaField element);

		// -(void)removeAt:(unsigned long)index;
		[Export ("removeAt:")]
		void RemoveAt (nuint index);

		// -(void)insertAt:(unsigned long)index element:(FSSchemaField *)element;
		[Export ("insertAt:element:")]
		void InsertAt (nuint index, FSSchemaField element);

		// -(void)removeAll;
		[Export ("removeAll")]
		void RemoveAll ();

		// -(void)dealloc;
		[Export ("dealloc")]
		void Dealloc ();
	}

	// @interface FSPortfolio : FSBase
	[BaseType (typeof(FSBase))]
	[DisableDefaultCtor]
	interface FSPortfolio
	{
		// @property (getter = getInitialViewMode, nonatomic) FSPortfolioInitialViewMode initialViewMode;
		[Export ("initialViewMode", ArgumentSemantic.Assign)]
		FSPortfolioInitialViewMode InitialViewMode { [Bind ("getInitialViewMode")] get; set; }

		// @property (getter = getSortingFieldKeyName, copy, nonatomic) NSString * sortingFieldKeyName;
		[Export ("sortingFieldKeyName")]
		string SortingFieldKeyName { [Bind ("getSortingFieldKeyName")] get; set; }

		// @property (getter = getInitialFileSpecKeyName, copy, nonatomic) NSString * initialFileSpecKeyName;
		[Export ("initialFileSpecKeyName")]
		string InitialFileSpecKeyName { [Bind ("getInitialFileSpecKeyName")] get; set; }

		// @property (getter = getSchemaFields, copy, nonatomic) FSSchemaFieldArray * schemaFields;
		[Export ("schemaFields", ArgumentSemantic.Copy)]
		FSSchemaFieldArray SchemaFields { [Bind ("getSchemaFields")] get; set; }

		// -(void *)getCptr;
		[Export ("getCptr")]
		//[Verify (MethodToProperty)]
		IntPtr Cptr { get; }

		// -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
		[Export ("initWithCptr:swigOwnCObject:")]
		IntPtr Constructor (IntPtr cptr, bool ownCObject);

		// +(FSPortfolio *)createPortfolio;
		[Static]
		[Export ("createPortfolio")]
		//[Verify (MethodToProperty)]
		FSPortfolio CreatePortfolio { get; }

		// +(FSPortfolio *)createPortfolioWithPDFDoc:(FSPDFDoc *)portfolio_pdf_doc;
		[Static]
		[Export ("createPortfolioWithPDFDoc:")]
		FSPortfolio CreatePortfolioWithPDFDoc (FSPDFDoc portfolio_pdf_doc);

		// -(id)initWithOther:(FSPortfolio *)other;
		[Export ("initWithOther:")]
		IntPtr Constructor (FSPortfolio other);

		// -(BOOL)isEmpty;
		[Export ("isEmpty")]
		//[Verify (MethodToProperty)]
		bool IsEmpty { get; }

		// -(FSPDFDoc *)getPortfolioPDFDoc;
		[Export ("getPortfolioPDFDoc")]
		//[Verify (MethodToProperty)]
		FSPDFDoc PortfolioPDFDoc { get; }

		// -(FSPortfolioNode *)getRootNode;
		[Export ("getRootNode")]
		//[Verify (MethodToProperty)]
		FSPortfolioNode RootNode { get; }

		// -(BOOL)isSortedInAscending;
		[Export ("isSortedInAscending")]
		//[Verify (MethodToProperty)]
		bool IsSortedInAscending { get; }

		// -(void)setSortingOrder:(BOOL)use_ascending_order;
		[Export ("setSortingOrder:")]
		void SetSortingOrder (bool use_ascending_order);

		// -(void)dealloc;
		[Export ("dealloc")]
		void Dealloc ();
	}

	// @interface FSAnnotationSummarySettings : FSBase
	[BaseType (typeof(FSBase))]
	interface FSAnnotationSummarySettings
	{
		// -(void *)getCptr;
		[Export ("getCptr")]
		//[Verify (MethodToProperty)]
		IntPtr Cptr { get; }

		// -(id)initWithCptr:(void *)cptr swigOwnCObject:(BOOL)ownCObject;
		[Export ("initWithCptr:swigOwnCObject:")]
		IntPtr Constructor (IntPtr cptr, bool ownCObject);

		// -(id)initWithOther:(FSAnnotationSummarySettings *)other;
		[Export ("initWithOther:")]
		IntPtr Constructor (FSAnnotationSummarySettings other);

		// -(BOOL)isEmpty;
		[Export ("isEmpty")]
		//[Verify (MethodToProperty)]
		bool IsEmpty { get; }

		// -(void)setSummaryLayout:(FSAnnotationSummarySettingsSummaryLayout)type;
		[Export ("setSummaryLayout:")]
		void SetSummaryLayout (FSAnnotationSummarySettingsSummaryLayout type);

		// -(void)setSortType:(FSAnnotationSummarySettingsSortType)type;
		[Export ("setSortType:")]
		void SetSortType (FSAnnotationSummarySettingsSortType type);

		// -(void)setFontSize:(FSAnnotationSummarySettingsFontSizeType)type;
		[Export ("setFontSize:")]
		void SetFontSize (FSAnnotationSummarySettingsFontSizeType type);

		// -(void)setAnnotType:(FSAnnotType)type use_all:(BOOL)use_all;
		[Export ("setAnnotType:use_all:")]
		void SetAnnotType (FSAnnotType type, bool use_all);

		// -(void)setFileTitle:(NSString *)title;
		[Export ("setFileTitle:")]
		void SetFileTitle (string title);

		// -(void)setPageRect:(FSRectF *)rect;
		[Export ("setPageRect:")]
		void SetPageRect (FSRectF rect);

		// -(void)setPageMargin:(FSRectF *)margin;
		[Export ("setPageMargin:")]
		void SetPageMargin (FSRectF margin);

		// -(void)setStartPage:(int)page_index;
		[Export ("setStartPage:")]
		void SetStartPage (int page_index);

		// -(void)setEndPage:(int)page_index;
		[Export ("setEndPage:")]
		void SetEndPage (int page_index);

		// -(void)enableOutputNoAnnotationPage:(BOOL)enable;
		[Export ("enableOutputNoAnnotationPage:")]
		void EnableOutputNoAnnotationPage (bool enable);

		// -(void)setConnectorLineColor:(unsigned int)color;
		[Export ("setConnectorLineColor:")]
		void SetConnectorLineColor (uint color);

		// -(void)setConnectorLineOpacity:(float)opacity;
		[Export ("setConnectorLineOpacity:")]
		void SetConnectorLineOpacity (float opacity);

		// -(void)setAnnotThumbnail:(FSAnnotType)type thumbnail:(FSBitmap *)thumbnail;
		[Export ("setAnnotThumbnail:thumbnail:")]
		void SetAnnotThumbnail (FSAnnotType type, FSBitmap thumbnail);

		// -(void)dealloc;
		[Export ("dealloc")]
		void Dealloc ();
	}

	// @interface FSAnnotationSummary : FSBase
	[BaseType (typeof(FSBase))]
	[DisableDefaultCtor]
	interface FSAnnotationSummary
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

		// -(id)initWithOther:(FSAnnotationSummary *)other;
		[Export ("initWithOther:")]
		IntPtr Constructor (FSAnnotationSummary other);

		// -(BOOL)isEmpty;
		[Export ("isEmpty")]
		//[Verify (MethodToProperty)]
		bool IsEmpty { get; }

		// -(void)setCallback:(id<FSAnnotationSummaryCallback>)callback;
		[Export ("setCallback:")]
		void SetCallback (NSObject callback);

		// -(FSProgressive *)startSummarize:(NSString *)dest_file_path settings:(FSAnnotationSummarySettings *)settings pause:(id<FSPauseCallback>)pause;
		[Export ("startSummarize:settings:pause:")]
		FSProgressive StartSummarize (string dest_file_path, FSAnnotationSummarySettings settings, NSObject pause);

		// -(FSProgressive *)startSummarize:(NSString *)dest_file_path settings:(FSAnnotationSummarySettings *)settings;
		[Export ("startSummarize:settings:")]
		FSProgressive StartSummarize (string dest_file_path, FSAnnotationSummarySettings settings);

		// -(FSProgressive *)startSummarizeWithDestFile:(id<FSFileWriterCallback>)dest_file settings:(FSAnnotationSummarySettings *)settings pause:(id<FSPauseCallback>)pause;
		[Export ("startSummarizeWithDestFile:settings:pause:")]
		FSProgressive StartSummarizeWithDestFile (NSObject dest_file, FSAnnotationSummarySettings settings, NSObject pause);

		// -(FSProgressive *)startSummarizeWithDestFile:(id<FSFileWriterCallback>)dest_file settings:(FSAnnotationSummarySettings *)settings;
		[Export ("startSummarizeWithDestFile:settings:")]
		FSProgressive StartSummarizeWithDestFile (NSObject dest_file, FSAnnotationSummarySettings settings);

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
		NSData readBlock (ulong offset, ulong size);

		// @required -(unsigned long long)getSize;
		[Abstract]
		[Export ("getSize")]
		//[Verify (MethodToProperty)]
		ulong Size { get; }
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

	// @protocol FSStreamCallback <NSObject>
    [Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface FSStreamCallback
	{
		// @required -(unsigned long long)getSize;
		[Abstract]
		[Export ("getSize")]
		//[Verify (MethodToProperty)]
		ulong Size { get; }

		// @required -(BOOL)IsEOF;
		[Abstract]
		[Export ("IsEOF")]
		//[Verify (MethodToProperty)]
		bool IsEOF { get; }

		// @required -(unsigned long long)GetPosition;
		[Abstract]
		[Export ("GetPosition")]
		//[Verify (MethodToProperty)]
		ulong Position { get; }

		// @required -(NSData *)readBlock:(unsigned long long)offset size:(unsigned long long)size;
		[Abstract]
		[Export ("readBlock:size:")]
		NSData ReadBlock (ulong offset, ulong size);

		// @required -(BOOL)writeBlock:(NSData *)data offset:(unsigned long long)offset;
		[Abstract]
		[Export ("writeBlock:offset:")]
		bool WriteBlock (NSData data, ulong offset);

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

		// @required -(void)setCurrentPage:(FSPDFDoc *)pdfDoc destination:(FSDestination *)destination;
		[Abstract]
		[Export ("setCurrentPage:destination:")]
		void SetCurrentPage (FSPDFDoc pdfDoc, FSDestination destination);

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

		// @required -(BOOL)invalidateRect:(FSPDFDoc *)document page_index:(int)page_index pdf_rect:(FSRectF *)pdf_rect;
		[Abstract]
		[Export ("invalidateRect:page_index:pdf_rect:")]
		bool InvalidateRect (FSPDFDoc document, int page_index, FSRectF pdf_rect);

		// @required -(BOOL)setDocChangeMark:(FSPDFDoc *)document change_mark:(BOOL)change_mark;
		[Abstract]
		[Export ("setDocChangeMark:change_mark:")]
		bool SetDocChangeMark (FSPDFDoc document, bool change_mark);

		// @required -(BOOL)getDocChangeMark:(FSPDFDoc *)document;
		[Abstract]
		[Export ("getDocChangeMark:")]
		bool GetDocChangeMark (FSPDFDoc document);

		// @required -(BOOL)submitForm:(FSPDFDoc *)document formData:(NSData *)formData url:(NSString *)url file_format_type:(FSFileFormatType)file_format_type;
		[Abstract]
		[Export ("submitForm:formData:url:file_format_type:")]
		bool SubmitForm (FSPDFDoc document, NSData formData, string url, FSFileFormatType file_format_type);

		// @required -(unsigned int)verifySignature:(FSPDFDoc *)document signature:(FSSignature *)signature;
		[Abstract]
		[Export ("verifySignature:signature:")]
		uint VerifySignature (FSPDFDoc document, FSSignature signature);

		// @required -(NSString *)browseFile:(BOOL)is_open_dialog file_format:(NSString *)file_format file_filter:(NSString *)file_filter;
		[Abstract]
		[Export ("browseFile:file_format:file_filter:")]
		string BrowseFile (bool is_open_dialog, string file_format, string file_filter);

		// @required -(NSString *)getAppInfo:(FSActionCallbackAppInfoType)type;
		[Abstract]
		[Export ("getAppInfo:")]
		string GetAppInfo (FSActionCallbackAppInfoType type);

		// @required -(void)query:(NSString *)keywords search_scope:(FSActionCallbackSearchScope)search_scope search_option:(FSSearchOption *)search_option di_path:(NSString *)di_path;
		[Abstract]
		[Export ("query:search_scope:search_option:di_path:")]
		void Query (string keywords, FSActionCallbackSearchScope search_scope, FSSearchOption search_option, string di_path);

		// @required -(FSSearchIndexConfig *)addSearchIndex:(NSString *)di_path is_selected:(BOOL)is_selected;
		[Abstract]
		[Export ("addSearchIndex:is_selected:")]
		FSSearchIndexConfig AddSearchIndex (string di_path, bool is_selected);

		// @required -(BOOL)removeSearchIndex:(FSSearchIndexConfig *)searchIndexConfig;
		[Abstract]
		[Export ("removeSearchIndex:")]
		bool RemoveSearchIndex (FSSearchIndexConfig searchIndexConfig);

		// @required -(NSArray<NSString *> *)getSignatureAPStyleNameList;
		[Abstract]
		[Export ("getSignatureAPStyleNameList")]
		//[Verify (MethodToProperty)]
		string[] SignatureAPStyleNameList { get; }

		// @required -(NSString *)GetJapaneseEras:(int)year month:(int)month day:(int)day;
		[Abstract]
		[Export ("GetJapaneseEras:month:day:")]
		string GetJapaneseEras (int year, int month, int day);
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
		unsafe bool SetTimer (int elapse, FSTimer timer, int out_timer_id);

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

		// @required -(void)reportInvalidValue:(NSString *)form_field_name invalid_value:(NSString *)invalid_value;
		[Abstract]
		[Export ("reportInvalidValue:invalid_value:")]
		void ReportInvalidValue (string form_field_name, string invalid_value);

		// @optional -(void *)createPopupMenu;
		[Export ("createPopupMenu")]
		//[Verify (MethodToProperty)]
		IntPtr CreatePopupMenu { get; }

		// @optional -(BOOL)appendPopupMenuItem:(void *)h_popup_menu popupMenuItem:(FSFillerAssistCallbackPopupMenuItem)popupMenuItem default_string:(NSString *)default_string;
		[Export ("appendPopupMenuItem:popupMenuItem:default_string:")]
		unsafe bool AppendPopupMenuItem (IntPtr h_popup_menu, FSFillerAssistCallbackPopupMenuItem popupMenuItem, string default_string);

		// @optional -(BOOL)enablePopupMenuItem:(void *)h_popup_menu popupMenuItem:(FSFillerAssistCallbackPopupMenuItem)popupMenuItem is_enabled:(BOOL)is_enabled;
		[Export ("enablePopupMenuItem:popupMenuItem:is_enabled:")]
		unsafe bool EnablePopupMenuItem (IntPtr h_popup_menu, FSFillerAssistCallbackPopupMenuItem popupMenuItem, bool is_enabled);

		// @optional -(BOOL)showPopupMenu:(void *)h_popup_menu point:(FSPointF *)point;
		[Export ("showPopupMenu:point:")]
		unsafe bool ShowPopupMenu (IntPtr h_popup_menu, FSPointF point);

		// @optional -(void)destroyPopupMenu:(void *)h_popup_menu;
		[Export ("destroyPopupMenu:")]
		unsafe void DestroyPopupMenu (IntPtr h_popup_menu);

		// @optional -(void)setClipboardText:(NSString *)text;
		[Export ("setClipboardText:")]
		void SetClipboardText (string text);

		// @optional -(NSString *)getClipboardText;
		[Export ("getClipboardText")]
		//[Verify (MethodToProperty)]
		string ClipboardText { get; }

		// @optional -(void)executeAction:(FSPDFPage *)page action:(FSAction *)action;
		[Export ("executeAction:action:")]
		void ExecuteAction (FSPDFPage page, FSAction action);

		// @optional -(void)editingMonitorOnCaretChanged:(int)n_caret_pos;
		[Export ("editingMonitorOnCaretChanged:")]
		void EditingMonitorOnCaretChanged (int n_caret_pos);

		// @optional -(void)editingMonitorOnContentChanged:(NSString *)content;
		[Export ("editingMonitorOnContentChanged:")]
		void EditingMonitorOnContentChanged (string content);
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
	[BaseType(typeof(NSObject))]
	interface FSCustomSecurityCallback : FSSecurityCallback
	{
		// @required -(void *)createContext:(NSString *)filter subFilter:(NSString *)subFilter encryptInfo:(NSString *)encryptInfo;
		[Abstract]
		[Export ("createContext:subFilter:encryptInfo:")]
		IntPtr CreateContext (string filter, string subFilter, string encryptInfo);

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
		IntPtr StartDecryptor (IntPtr context, int objNum, int genNum);

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
		unsafe bool EncryptData (IntPtr context, int objNum, int genNum, IntPtr srcData, uint srcDataLen, IntPtr dstBuffer, uint dstBufferLen);

		// @required -(BOOL)useStandardCryptoMethod:(void *)context;
		[Abstract]
		[Export ("useStandardCryptoMethod:")]
		unsafe bool UseStandardCryptoMethod (IntPtr context);
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
		unsafe bool StartCalcDigest (NSObject file, NSNumber[] byteRangeArray, FSSignature signature, IntPtr clientData);

		// @required -(FSProgressiveState)continueCalcDigest:(id<FSPauseCallback>)pause clientData:(void *)clientData;
		[Abstract]
		[Export ("continueCalcDigest:clientData:")]
		unsafe FSProgressiveState ContinueCalcDigest (NSObject pause, IntPtr clientData);

		// @required -(NSData *)getDigest:(void *)clientData;
		[Abstract]
		[Export ("getDigest:")]
		unsafe NSData GetDigest (IntPtr clientData);

		// @required -(NSData *)sign:(NSData *)digest certPath:(NSString *)certPath certPassword:(NSString *)certPassword digestAlgorithm:(FSSignatureDigestAlgorithm)digestAlgorithm clientData:(void *)clientData;
		[Abstract]
		[Export ("sign:certPath:certPassword:digestAlgorithm:clientData:")]
		unsafe NSData Sign (NSData digest, string certPath, string certPassword, FSSignatureDigestAlgorithm digestAlgorithm, IntPtr clientData);

		// @required -(NSData *)sign:(NSData *)digest certStream:(id<FSStreamCallback>)certStream certPassword:(NSString *)certPassword digestAlgorithm:(FSSignatureDigestAlgorithm)digestAlgorithm clientData:(void *)clientData;
		[Abstract]
		[Export ("sign:certStream:certPassword:digestAlgorithm:clientData:")]
		unsafe NSData Sign (NSData digest, NSObject certStream, string certPassword, FSSignatureDigestAlgorithm digestAlgorithm, IntPtr clientData);

		// @required -(FSSignatureStates)verifySigState:(NSData *)digest signedData:(NSData *)signedData clientData:(void *)clientData;
		[Abstract]
		[Export ("verifySigState:signedData:clientData:")]
		unsafe FSSignatureStates VerifySigState (NSData digest, NSData signedData, IntPtr clientData);

		// @required -(BOOL)isNeedPadData;
		[Abstract]
		[Export ("isNeedPadData")]
		//[Verify (MethodToProperty)]
		bool IsNeedPadData { get; }

		// @required -(FSSignatureCallbackCertValidity)CheckCertificateValidity:(NSString *)certPath certPassword:(NSString *)certPassword clientData:(void *)clientData;
		[Abstract]
		[Export ("CheckCertificateValidity:certPassword:clientData:")]
		unsafe FSSignatureCallbackCertValidity CheckCertificateValidity (string certPath, string certPassword, IntPtr clientData);
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
		NSObject DownLoadUrl (string url);

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

	// @protocol FSRevocationCallback <NSObject>
    [Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface FSRevocationCallback
	{
		// @required -(NSArray<NSData *> *)getCertChainFromSignature:(NSData *)signature_content;
		[Abstract]
		[Export ("getCertChainFromSignature:")]
		NSData[] GetCertChainFromSignature (NSData signature_content);

		// @required -(FSResponse *)getResponseOnLineForSingleCert:(FSCertIssuerPair *)cert_issuer_pair;
		[Abstract]
		[Export ("getResponseOnLineForSingleCert:")]
		FSResponse GetResponseOnLineForSingleCert (FSCertIssuerPair cert_issuer_pair);

		// @required -(FSCertVerifyResult *)verifyOCSP:(FSCertIssuerPair *)cert_issuer_pair ocsp_data:(NSData *)ocsp_data;
		[Abstract]
		[Export ("verifyOCSP:ocsp_data:")]
		FSCertVerifyResult VerifyOCSP (FSCertIssuerPair cert_issuer_pair, NSData ocsp_data);

		// @required -(FSCertVerifyResult *)verifyCRL:(FSCertIssuerPair *)cert_issuer_pair crl_data:(NSData *)crl_data;
		[Abstract]
		[Export ("verifyCRL:crl_data:")]
		FSCertVerifyResult VerifyCRL (FSCertIssuerPair cert_issuer_pair, NSData crl_data);

		// @required -(BOOL)isCA:(NSData *)cert;
		[Abstract]
		[Export ("isCA:")]
		bool IsCA (NSData cert);

		// @required -(FSDateTime *)getDTSTime:(NSData *)signature_content;
		[Abstract]
		[Export ("getDTSTime:")]
		FSDateTime GetDTSTime (NSData signature_content);

		// @required -(NSData *)getTSTSignature:(NSData *)signature_content;
		[Abstract]
		[Export ("getTSTSignature:")]
		NSData GetTSTSignature (NSData signature_content);

		// @required -(FSDateTime *)getTSTTime:(NSData *)signature_content;
		[Abstract]
		[Export ("getTSTTime:")]
		FSDateTime GetTSTTime (NSData signature_content);

		// @required -(FSCertIssuerPair *)getOCSPCertAndIssuer:(NSData *)ocsp_data trust_cert_chain:(NSArray<NSData *> *)trust_cert_chain;
		[Abstract]
		[Export ("getOCSPCertAndIssuer:trust_cert_chain:")]
		FSCertIssuerPair GetOCSPCertAndIssuer (NSData ocsp_data, NSData[] trust_cert_chain);

		// @required -(FSDateTime *)getOCSPProducedAtTime:(NSData *)ocsp_data;
		[Abstract]
		[Export ("getOCSPProducedAtTime:")]
		FSDateTime GetOCSPProducedAtTime (NSData ocsp_data);

		// @required -(BOOL)isOCSPNeedCheck:(NSData *)ocsp_data;
		[Abstract]
		[Export ("isOCSPNeedCheck:")]
		bool IsOCSPNeedCheck (NSData ocsp_data);

		// @required -(FSTimeRange *)getCertValidTimeRange:(NSData *)cert;
		[Abstract]
		[Export ("getCertValidTimeRange:")]
		FSTimeRange GetCertValidTimeRange (NSData cert);

		// @required -(NSData *)getOCSPSignature:(NSData *)ocsp_data;
		[Abstract]
		[Export ("getOCSPSignature:")]
		NSData GetOCSPSignature (NSData ocsp_data);

		// @required -(NSData *)getCRLSignature:(NSData *)crl_data;
		[Abstract]
		[Export ("getCRLSignature:")]
		NSData GetCRLSignature (NSData crl_data);

		// @required -(FSRevocationArrayInfo *)getRevocationInfoFromSignatureData:(NSData *)signature_content;
		[Abstract]
		[Export ("getRevocationInfoFromSignatureData:")]
		FSRevocationArrayInfo GetRevocationInfoFromSignatureData (NSData signature_content);

		// @required -(BOOL)isIssuerMatchCert:(FSCertIssuerPair *)cert_issuer_pair;
		[Abstract]
		[Export ("isIssuerMatchCert:")]
		bool IsIssuerMatchCert (FSCertIssuerPair cert_issuer_pair);
	}

	// @protocol FSTrustedCertStoreCallback <NSObject>
    [Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface FSTrustedCertStoreCallback
	{
		// @required -(BOOL)isCertTrusted:(NSData *)cert;
		[Abstract]
		[Export ("isCertTrusted:")]
		bool IsCertTrusted (NSData cert);

		// @required -(BOOL)isCertTrustedRoot:(NSData *)cert;
		[Abstract]
		[Export ("isCertTrustedRoot:")]
		bool IsCertTrustedRoot (NSData cert);
	}

	// @protocol FSFontMapperCallback <NSObject>
    [Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface FSFontMapperCallback
	{
		// @required -(FSFontMapResult *)mapFont:(NSString *)font_name is_truetype:(BOOL)is_truetype styles:(unsigned int)styles weight:(int)weight italic_angle:(int)italic_angle charset:(FSFontCharset)charset;
		[Abstract]
		[Export ("mapFont:is_truetype:styles:weight:italic_angle:charset:")]
		FSFontMapResult Is_truetype (string font_name, bool is_truetype, uint styles, int weight, int italic_angle, FSFontCharset charset);
	}

	// @protocol FSAnnotationSummaryCallback <NSObject>
    [Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface FSAnnotationSummaryCallback
	{
		// @required -(FSLocaleID)getCurrentLocaleID;
		[Abstract]
		[Export ("getCurrentLocaleID")]
		//[Verify (MethodToProperty)]
		FSLocaleID CurrentLocaleID { get; }

		// @required -(NSString *)getLocalFontName;
		[Abstract]
		[Export ("getLocalFontName")]
		//[Verify (MethodToProperty)]
		string LocalFontName { get; }

		// @required -(NSString *)loadString:(FSAnnotationSummaryCallbackAnnotationSummaryStringID)stringID;
		[Abstract]
		[Export ("loadString:")]
		string LoadString (FSAnnotationSummaryCallbackAnnotationSummaryStringID stringID);
	}

	// @protocol FSTimeStampCallback <NSObject>
    [Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface FSTimeStampCallback
	{
		// @optional -(FSTimeStampServerSendRequestResult)sendTimeStampRequest:(NSString *)request;
		[Export ("sendTimeStampRequest:")]
		FSTimeStampServerSendRequestResult SendTimeStampRequest (string request);

		// @optional -(NSString *)getTimeStampMessage;
		[Export ("getTimeStampMessage")]
		//[Verify (MethodToProperty)]
		string TimeStampMessage { get; }
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

	// @protocol FSDWG2PDFProgressCallback <NSObject>
    [Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface FSDWG2PDFProgressCallback
	{
		// @optional -(void)onProgress:(NSString *)message progress:(float)progress;
		[Export ("onProgress:progress:")]
		void Progress (string message, float progress);
	}

	[Static]
	//[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern const FSLocalizationLanguageOptional FSLocalizationLanguageOptionalEnglish;
		[Field ("FSLocalizationLanguageOptionalEnglish", "__Internal")]
		nuint FSLocalizationLanguageOptionalEnglish { get; }

		// extern const FSLocalizationLanguageOptional FSLocalizationLanguageOptionalChineseSimplified;
		[Field ("FSLocalizationLanguageOptionalChineseSimplified", "__Internal")]
		nuint FSLocalizationLanguageOptionalChineseSimplified { get; }

		// extern const FSLocalizationLanguageOptional FSLocalizationLanguageOptionalChineseTraditional;
		[Field ("FSLocalizationLanguageOptionalChineseTraditional", "__Internal")]
		nuint FSLocalizationLanguageOptionalChineseTraditional { get; }

		// extern const FSLocalizationLanguageOptional FSLocalizationLanguageOptionalKorean;
		[Field ("FSLocalizationLanguageOptionalKorean", "__Internal")]
		nuint FSLocalizationLanguageOptionalKorean { get; }

		// extern const FSLocalizationLanguageOptional FSLocalizationLanguageOptionalSpanishLatinAmerica;
		[Field ("FSLocalizationLanguageOptionalSpanishLatinAmerica", "__Internal")]
		nuint FSLocalizationLanguageOptionalSpanishLatinAmerica { get; }

		// extern const FSLocalizationLanguageOptional FSLocalizationLanguageOptionalFrench;
		[Field ("FSLocalizationLanguageOptionalFrench", "__Internal")]
		nuint FSLocalizationLanguageOptionalFrench { get; }

		// extern const FSLocalizationLanguageOptional FSLocalizationLanguageOptionalGerman;
		[Field ("FSLocalizationLanguageOptionalGerman", "__Internal")]
		nuint FSLocalizationLanguageOptionalGerman { get; }

		// extern const FSLocalizationLanguageOptional FSLocalizationLanguageOptionalRussian;
		[Field ("FSLocalizationLanguageOptionalRussian", "__Internal")]
		nuint FSLocalizationLanguageOptionalRussian { get; }

		// extern const FSLocalizationLanguageOptional FSLocalizationLanguageOptionalPortugueseBrazil;
		[Field ("FSLocalizationLanguageOptionalPortugueseBrazil", "__Internal")]
		nuint FSLocalizationLanguageOptionalPortugueseBrazil { get; }

		// extern const FSLocalizationLanguageOptional FSLocalizationLanguageOptionalItalian;
		[Field ("FSLocalizationLanguageOptionalItalian", "__Internal")]
		nuint FSLocalizationLanguageOptionalItalian { get; }

		// extern const FSLocalizationLanguageOptional FSLocalizationLanguageOptionalDutch;
		[Field ("FSLocalizationLanguageOptionalDutch", "__Internal")]
		nuint FSLocalizationLanguageOptionalDutch { get; }

		// extern const FSLocalizationLanguageOptional FSLocalizationLanguageOptionalJapanese;
		[Field ("FSLocalizationLanguageOptionalJapanese", "__Internal")]
		nuint FSLocalizationLanguageOptionalJapanese { get; }
	}

	// @interface FSLocalization : NSObject
	[BaseType (typeof(NSObject))]
	interface FSLocalization
	{
		// @property (assign, nonatomic, class) NSUInteger currentLanguage;
		[Static]
		[Export ("currentLanguage")]
		nuint CurrentLanguage { get; set; }

		// @property (assign, nonatomic, class) BOOL allowLanguageBranch;
		[Static]
		[Export ("allowLanguageBranch")]
		bool AllowLanguageBranch { get; set; }

		// +(void)addLanguage:(NSUInteger)language table:(NSString * _Nonnull)tableName languageAbbr:(NSString * _Nonnull)abbr;
		[Static]
		[Export ("addLanguage:table:languageAbbr:")]
		void AddLanguage (nuint language, string tableName, string abbr);

		// +(NSString * _Nonnull)languageAbbr;
		[Static]
		[Export ("languageAbbr")]
		//[Verify (MethodToProperty)]
		string LanguageAbbr { get; }

		// +(NSString * _Nonnull)tableName;
		[Static]
		[Export ("tableName")]
		//[Verify (MethodToProperty)]
		string TableName { get; }
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

		// @optional -(void)onDocLoading:(FSPDFDoc * _Nonnull)document progress:(int)progress;
		[Export ("onDocLoading:progress:")]
		void OnDocLoading (FSPDFDoc document, int progress);
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

		// @optional -(void)onPagesWillFlatten:(int)index;
		[Export ("onPagesWillFlatten:")]
		void OnPagesWillFlatten (int index);

		// @optional -(void)onPagesFlattened:(int)index;
		[Export ("onPagesFlattened:")]
		void OnPagesFlattened (int index);
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

	// @protocol IViewAppleEventListener <NSObject>
    [Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface IViewAppleEventListener
	{
		// @optional -(void)layoutSubviewsFromPDFViewCtrl:(FSPDFViewCtrl * _Nonnull)pdfViewCtrl;
		[Export ("layoutSubviewsFromPDFViewCtrl:")]
		void LayoutSubviewsFromPDFViewCtrl (FSPDFViewCtrl pdfViewCtrl);

		// @optional -(void)didMoveToWindowFromPDFViewCtrl:(FSPDFViewCtrl * _Nonnull)pdfViewCtrl;
		[Export ("didMoveToWindowFromPDFViewCtrl:")]
		void DidMoveToWindowFromPDFViewCtrl (FSPDFViewCtrl pdfViewCtrl);
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

		// @optional -(BOOL)onDoubleTap:(UITapGestureRecognizer * _Nonnull)gestureRecognizer;
		[Export ("onDoubleTap:")]
		bool OnDoubleTap (UITapGestureRecognizer gestureRecognizer);

		// @optional -(BOOL)onPan:(UIPanGestureRecognizer * _Nonnull)gestureRecognizer;
		[Export ("onPan:")]
		bool OnPan (UIPanGestureRecognizer gestureRecognizer);

		// @optional -(BOOL)onShouldBegin:(UIGestureRecognizer * _Nonnull)gestureRecognizer;
		[Export ("onShouldBegin:")]
		bool OnShouldBegin (UIGestureRecognizer gestureRecognizer);

		// @optional -(BOOL)onPageGestureRecognizer:(int)pageIndex gestureRecognizer:(UIGestureRecognizer * _Nonnull)gestureRecognizer shouldReceiveTouch:(UITouch * _Nonnull)touch;
		[Export ("onPageGestureRecognizer:gestureRecognizer:shouldReceiveTouch:")]
		bool OnPageGestureRecognizer (int pageIndex, UIGestureRecognizer gestureRecognizer, UITouch touch);
	}

	// @protocol IDrawEventListener <NSObject>
    [Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface IDrawEventListener
	{
		// @required -(void)onDraw:(int)pageIndex inContext:(CGContextRef _Nonnull)context;
		[Abstract]
		[Export ("onDraw:inContext:")]
		void InContext (int pageIndex, CGContext context);
	}

	// @protocol IRenderEventListener <NSObject>
    [Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface IRenderEventListener
	{
		// @required -(void)onWillRender:(FSRenderer * _Nonnull)render flags:(FSRendererContentFlag)flags pageIndex:(int)pageIndex;
		[Abstract]
		[Export ("onWillRender:flags:pageIndex:")]
		void OnWillRender (FSRenderer render, FSRendererContentFlag flags, int pageIndex);

		// @required -(void)onRenderedFlags:(FSRendererContentFlag)flags pageIndex:(int)pageIndex;
		[Abstract]
		[Export ("onRenderedFlags:pageIndex:")]
		void OnRenderedFlags (FSRendererContentFlag flags, int pageIndex);
	}

	// @protocol IReflowEventListener <NSObject>
    [Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface IReflowEventListener
	{
		// @required -(void)onWillStartParseReflowPage:(FSReflowPage * _Nonnull)reflowPage zoom:(int)zoom flags:(FSReflowPageFlags)flags pageIndex:(int)pageIndex;
		[Abstract]
		[Export ("onWillStartParseReflowPage:zoom:flags:pageIndex:")]
		void OnWillStartParseReflowPage (FSReflowPage reflowPage, int zoom, FSReflowPageFlags flags, int pageIndex);

		// @required -(void)onParsedReflowPage:(FSReflowPage * _Nonnull)reflowPage zoom:(int)zoom flags:(FSReflowPageFlags)flags pageIndex:(int)pageIndex;
		[Abstract]
		[Export ("onParsedReflowPage:zoom:flags:pageIndex:")]
		void OnParsedReflowPage (FSReflowPage reflowPage, int zoom, FSReflowPageFlags flags, int pageIndex);
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

	// @protocol FSPDFUIExtensionsManager <IGestureEventListener, IDrawEventListener, ITouchEventListener>
    [Protocol, Model]
	interface FSPDFUIExtensionsManager : IGestureEventListener, IDrawEventListener, ITouchEventListener
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

		// @required -(BOOL)flattenPageAtIndex:(int)pageIndex display:(BOOL)display options:(FSPDFPageFlattenOptions)options;
		[Abstract]
		[Export ("flattenPageAtIndex:display:options:")]
		bool FlattenPageAtIndex (int pageIndex, bool display, FSPDFPageFlattenOptions options);

		// @required -(BOOL)rotatePagesAtIndexes:(NSArray<NSNumber *> * _Nonnull)pageIndexes clockwise:(BOOL)clockwise;
		[Abstract]
		[Export ("rotatePagesAtIndexes:clockwise:")]
		bool RotatePagesAtIndexes (NSNumber[] pageIndexes, bool clockwise);

		// @required -(BOOL)insertPageFromImage:(UIImage * _Nonnull)image atIndex:(NSUInteger)pageIndex;
		[Abstract]
		[Export ("insertPageFromImage:atIndex:")]
		bool InsertPageFromImage (UIImage image, nuint pageIndex);

		// @required -(BOOL)insertPages:(int)index width:(float)width height:(float)height style:(PDF_PAGE_STYLE_TYPE)style color:(unsigned int)color rotation:(FSRotation)rotation count:(int)count;
		[Abstract]
		[Export ("insertPages:width:height:style:color:rotation:count:")]
		bool InsertPages (int index, float width, float height, PDF_PAGE_STYLE_TYPE style, uint color, FSRotation rotation, int count);

		// @required -(BOOL)insertPages:(int)index pageSize:(FSPDFPageSize)pageSize style:(PDF_PAGE_STYLE_TYPE)style color:(unsigned int)color rotation:(FSRotation)rotation count:(int)count;
		[Abstract]
		[Export ("insertPages:pageSize:style:color:rotation:count:")]
		bool InsertPages (int index, FSPDFPageSize pageSize, PDF_PAGE_STYLE_TYPE style, uint color, FSRotation rotation, int count);

		// @required -(void)insertPagesFromDocument:(FSPDFDoc * _Nonnull)document withSourceIndexes:(NSArray<NSNumber *> * _Nonnull)sourcePagesIndexes flags:(FSPDFDocImportPageFlags)flags layerName:(NSString * _Nullable)layerName atIndex:(NSUInteger)destinationIndex success:(void (^ _Nonnull)(NSString * _Nonnull))success error:(void (^ _Nonnull)(NSString * _Nonnull))error;
		[Abstract]
		[Export ("insertPagesFromDocument:withSourceIndexes:flags:layerName:atIndex:success:error:")]
		void InsertPagesFromDocument (FSPDFDoc document, NSNumber[] sourcePagesIndexes, FSPDFDocImportPageFlags flags, [NullAllowed] string layerName, nuint destinationIndex, Action<NSString> success, Action<NSString> error);
	}

	// @protocol FSExceptionLoggerDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface FSExceptionLoggerDelegate
	{
		// @required -(void)stacktraceInfo:(NSString * _Nonnull)stackInfo;
		[Abstract]
		[Export ("stacktraceInfo:")]
		void StacktraceInfo (string stackInfo);
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

		// @property (nonatomic, strong) UIColor * _Nullable reflowBackgroundColor;
		[NullAllowed, Export ("reflowBackgroundColor", ArgumentSemantic.Strong)]
		UIColor ReflowBackgroundColor { get; set; }

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

		// @property (assign, nonatomic) BOOL enablePageFlippingByTouchBorder;
		[Export ("enablePageFlippingByTouchBorder")]
		bool EnablePageFlippingByTouchBorder { get; set; }

		// @property (assign, nonatomic) BOOL keepZoomRatio;
		[Export ("keepZoomRatio")]
		bool KeepZoomRatio { get; set; }

		// @property (nonatomic) BOOL IsChangeLayoutMode;
		[Export ("IsChangeLayoutMode")]
		bool IsChangeLayoutMode { get; set; }

		// @property (assign, nonatomic) FSNightColorMode nightColorMode;
		[Export ("nightColorMode", ArgumentSemantic.Assign)]
		FSNightColorMode NightColorMode { get; set; }

		// @property (nonatomic) NSTimeInterval minimumPressDuration;
		[Export ("minimumPressDuration")]
		double MinimumPressDuration { get; set; }

		// @property (assign, nonatomic) PDF_PAGE_BINDING_EDGE pageBindingEdge;
		[Export ("pageBindingEdge", ArgumentSemantic.Assign)]
		PDF_PAGE_BINDING_EDGE PageBindingEdge { get; set; }

		// @property (nonatomic, weak) API_AVAILABLE(ios(13.0)) UIWindowScene * windowScene __attribute__((availability(ios, introduced=13.0)));
#if !NET
    [iOS (13, 0)]
#endif
		[Export ("windowScene", ArgumentSemantic.Weak)]
		UIWindowScene WindowScene { get; set; }

		// @property (readonly, assign, nonatomic) BOOL supportsMultipleScenes;
		[Export ("supportsMultipleScenes")]
		bool SupportsMultipleScenes { get; }

		// @property (assign, nonatomic) BOOL refreshReflowAnnot;
		[Export ("refreshReflowAnnot")]
		bool RefreshReflowAnnot { get; set; }

		// -(instancetype _Nonnull)initWithFrame:(CGRect)frame;
		[Export ("initWithFrame:")]
		IntPtr Constructor (CGRect frame);

		// -(void)registerDocEventListener:(id<IDocEventListener> _Nonnull)listener;
		[Export ("registerDocEventListener:")]
		void RegisterDocEventListener (NSObject listener);

		// -(void)registerPageEventListener:(id<IPageEventListener> _Nonnull)listener;
		[Export ("registerPageEventListener:")]
		void RegisterPageEventListener (NSObject listener);

		// -(void)registerScrollViewEventListener:(id<IScrollViewEventListener> _Nonnull)listener;
		[Export ("registerScrollViewEventListener:")]
		void RegisterScrollViewEventListener (NSObject listener);

		// -(void)registerLayoutEventListener:(id<ILayoutEventListener> _Nonnull)listener;
		[Export ("registerLayoutEventListener:")]
		void RegisterLayoutEventListener (NSObject listener);

		// -(void)registerGestureEventListener:(id<IGestureEventListener> _Nonnull)listener;
		[Export ("registerGestureEventListener:")]
		void RegisterGestureEventListener (NSObject listener);

		// -(void)registerDrawEventListener:(id<IDrawEventListener> _Nonnull)listener;
		[Export ("registerDrawEventListener:")]
		void RegisterDrawEventListener (NSObject listener);

		// -(void)registerRenderEventListener:(id<IRenderEventListener> _Nonnull)listener;
		[Export ("registerRenderEventListener:")]
		void RegisterRenderEventListener (NSObject listener);

		// -(void)registerReflowEventListener:(id<IReflowEventListener> _Nonnull)listener;
		[Export ("registerReflowEventListener:")]
		void RegisterReflowEventListener (NSObject listener);

		// -(void)registerRecoveryEventListener:(id<IRecoveryEventListener> _Nonnull)listener;
		[Export ("registerRecoveryEventListener:")]
		void RegisterRecoveryEventListener (NSObject listener);

		// -(void)registerViewAppleEventListener:(id<IViewAppleEventListener> _Nonnull)listener;
		[Export ("registerViewAppleEventListener:")]
		void RegisterViewAppleEventListener (NSObject listener);

		// -(void)unregisteRecoveryEventListener:(id<IRecoveryEventListener> _Nonnull)listener;
		[Export ("unregisteRecoveryEventListener:")]
		void UnregisteRecoveryEventListener (NSObject listener);

		// -(void)unregisterDrawEventListener:(id<IDrawEventListener> _Nonnull)listener;
		[Export ("unregisterDrawEventListener:")]
		void UnregisterDrawEventListener (NSObject listener);

		// -(void)unregisterRenderEventListener:(id<IRenderEventListener> _Nonnull)listener;
		[Export ("unregisterRenderEventListener:")]
		void UnregisterRenderEventListener (NSObject listener);

		// -(void)unregisterReflowEventListener:(id<IReflowEventListener> _Nonnull)listener;
		[Export ("unregisterReflowEventListener:")]
		void UnregisterReflowEventListener (NSObject listener);

		// -(void)unregisterGestureEventListener:(id<IGestureEventListener> _Nonnull)listener;
		[Export ("unregisterGestureEventListener:")]
		void UnregisterGestureEventListener (NSObject listener);

		// -(void)unregisterDocEventListener:(id<IDocEventListener> _Nonnull)listener;
		[Export ("unregisterDocEventListener:")]
		void UnregisterDocEventListener (NSObject listener);

		// -(void)unregisterPageEventListener:(id<IPageEventListener> _Nonnull)listener;
		[Export ("unregisterPageEventListener:")]
		void UnregisterPageEventListener (NSObject listener);

		// -(void)unregisterScrollViewEventListener:(id<IScrollViewEventListener> _Nonnull)listener;
		[Export ("unregisterScrollViewEventListener:")]
		void UnregisterScrollViewEventListener (NSObject listener);

		// -(void)unregisterLayoutEventListener:(id<ILayoutEventListener> _Nonnull)listener;
		[Export ("unregisterLayoutEventListener:")]
		void UnregisterLayoutEventListener (NSObject listener);

		// -(void)unregisterViewAppleEventListener:(id<IViewAppleEventListener> _Nonnull)listener;
		[Export ("unregisterViewAppleEventListener:")]
		void UnregisterViewAppleEventListener (NSObject listener);

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

		// -(void)openDocFromFileReader:(id<FSFileReaderCallback> _Nonnull)fileReader password:(NSString * _Nullable)password completion:(void (^ _Nullable)(FSErrorCode))completion;
		[Export ("openDocFromFileReader:password:completion:")]
		void OpenDocFromFileReader (NSObject fileReader, [NullAllowed] string password, [NullAllowed] Action<FSErrorCode> completion);

		// -(void)closeDoc:(void (^ _Nullable)(void))cleanup;
		[Export ("closeDoc:")]
		void CloseDoc ([NullAllowed] Action cleanup);

		// -(BOOL)saveDoc:(NSString * _Nonnull)filePath flag:(FSPDFDocSaveFlags)flag;
		[Export ("saveDoc:flag:")]
		bool SaveDoc (string filePath, FSPDFDocSaveFlags flag);

		// -(BOOL)saveDoc:(NSString * _Nonnull)filePath flag:(FSPDFDocSaveFlags)flag complete:(void (^ _Nonnull)(FSErrorCode))complete;
		[Export ("saveDoc:flag:complete:")]
		bool SaveDoc (string filePath, FSPDFDocSaveFlags flag, Action<FSErrorCode> complete);

		// -(BOOL)saveDocToFileWriter:(id<FSFileWriterCallback> _Nonnull)fileWriter flag:(FSPDFDocSaveFlags)flag;
		[Export ("saveDocToFileWriter:flag:")]
		bool SaveDocToFileWriter (NSObject fileWriter, FSPDFDocSaveFlags flag);

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

		// -(float)getReflowPageScale;
		[Export ("getReflowPageScale")]
		//[Verify (MethodToProperty)]
		float ReflowPageScale { get; }

		// -(float)getUIDevicePPI;
		[Export ("getUIDevicePPI")]
		//[Verify (MethodToProperty)]
		float UIDevicePPI { get; }

		// -(NSMutableArray * _Nonnull)getVisiblePages;
		[Export ("getVisiblePages")]
		//[Verify (MethodToProperty)]
		NSMutableArray VisiblePages { get; }

		// -(BOOL)isPageVisible:(int)pageIndex;
		[Export ("isPageVisible:")]
		bool IsPageVisible (int pageIndex);

		// -(void)rotateView:(int)rotation;
		[Export ("rotateView:")]
		void RotateView (int rotation);

		// -(int)getViewRotation;
		[Export ("getViewRotation")]
		//[Verify (MethodToProperty)]
		int ViewRotation { get; }

		// -(BOOL)gotoPage:(int)index animated:(BOOL)animated;
		[Export ("gotoPage:animated:")]
		bool GotoPage (int index, bool animated);

		// -(BOOL)gotoPage:(int)index withDocPoint:(FSPointF * _Nonnull)point animated:(BOOL)animated;
		[Export ("gotoPage:withDocPoint:animated:")]
		bool GotoPage (int index, FSPointF point, bool animated);

		// -(BOOL)gotoPage:(int)index zoomToDocRect:(FSRectF * _Nonnull)rect animated:(BOOL)animated;
		[Export ("gotoPage:zoomToDocRect:animated:")]
		bool GotoPage (int index, FSRectF rect, bool animated);

		// -(BOOL)gotoPage:(int)index animated:(BOOL)animated needJumpedNode:(BOOL)needJumpedNode;
		[Export ("gotoPage:animated:needJumpedNode:")]
		bool GotoPage (int index, bool animated, bool needJumpedNode);

		// -(void)addPageJumpedNode:(int)indexOld index:(int)indexNew animated:(BOOL)animated;
		[Export ("addPageJumpedNode:index:animated:")]
		void AddPageJumpedNode (int indexOld, int indexNew, bool animated);

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

		// -(float)getScale;
		[Export ("getScale")]
		//[Verify (MethodToProperty)]
		float Scale { get; }

		// -(float)getDefaultPageScale;
		[Export ("getDefaultPageScale")]
		//[Verify (MethodToProperty)]
		float DefaultPageScale { get; }

		// -(float)getZoom;
		[Export ("getZoom")]
		//[Verify (MethodToProperty)]
		float Zoom { get; }

		// -(void)setZoom:(float)zoom;
		[Export ("setZoom:")]
		void SetZoom (float zoom);

		// -(void)setZoom:(float)zoom withSlider:(BOOL)isWithSlider;
		[Export ("setZoom:withSlider:")]
		void SetZoom (float zoom, bool isWithSlider);

		// -(void)setZoom:(float)zoom origin:(CGPoint)origin;
		[Export ("setZoom:origin:")]
		void SetZoom (float zoom, CGPoint origin);

		// -(PDF_DISPLAY_ZOOMMODE)getZoomMode;
		[Export ("getZoomMode")]
		//[Verify (MethodToProperty)]
		PDF_DISPLAY_ZOOMMODE ZoomMode { get; }

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

		// -(void)setDefaultPageWhenDocumentOpened:(int)index;
		[Export ("setDefaultPageWhenDocumentOpened:")]
		void SetDefaultPageWhenDocumentOpened (int index);

		// -(BOOL)isContinuous;
		[Export ("isContinuous")]
		//[Verify (MethodToProperty)]
		bool IsContinuous { get; }

		// -(void)setContinuous:(BOOL)isContinuous;
		[Export ("setContinuous:")]
		void SetContinuous (bool isContinuous);

		// -(BOOL)isViewSignedDocument;
		[Export ("isViewSignedDocument")]
		//[Verify (MethodToProperty)]
		bool IsViewSignedDocument { get; }

		// -(void)setViewSignedDocument:(BOOL)isViewSignedDocument;
		[Export ("setViewSignedDocument:")]
		void SetViewSignedDocument (bool isViewSignedDocument);

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

		// -(UIScrollView * _Nonnull)getPageContainer;
		[Export ("getPageContainer")]
		//[Verify (MethodToProperty)]
		UIScrollView PageContainer { get; }

		// -(BOOL)appendPageView:(UIView * _Nonnull)pageView;
		[Export ("appendPageView:")]
		bool AppendPageView (UIView pageView);

		// -(void)stopCurrentGestureRecognizerShouldBegin;
		[Export ("stopCurrentGestureRecognizerShouldBegin")]
		void StopCurrentGestureRecognizerShouldBegin ();

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

		// -(CGPoint)convertReflowPagePtToPageViewPt:(FSPointF * _Nonnull)point reflowPage:(FSReflowPage * _Nonnull)reflowPage pageIndex:(int)pageIndex;
		[Export ("convertReflowPagePtToPageViewPt:reflowPage:pageIndex:")]
		CGPoint ConvertReflowPagePtToPageViewPt (FSPointF point, FSReflowPage reflowPage, int pageIndex);

		// -(FSPointF * _Nonnull)convertPageViewPtToReflowPagePt:(CGPoint)point reflowPage:(FSReflowPage * _Nonnull)reflowPage pageIndex:(int)pageIndex;
		[Export ("convertPageViewPtToReflowPagePt:reflowPage:pageIndex:")]
		FSPointF ConvertPageViewPtToReflowPagePt (CGPoint point, FSReflowPage reflowPage, int pageIndex);

		// -(CGRect)convertReflowPageRectToPageViewRect:(FSRectF * _Nonnull)rect reflowPage:(FSReflowPage * _Nonnull)reflowPage pageIndex:(int)pageIndex;
		[Export ("convertReflowPageRectToPageViewRect:reflowPage:pageIndex:")]
		CGRect ConvertReflowPageRectToPageViewRect (FSRectF rect, FSReflowPage reflowPage, int pageIndex);

		// -(FSRectF * _Nonnull)convertPageViewRectToReflowPageRect:(CGRect)rect reflowPage:(FSReflowPage * _Nonnull)reflowPage pageIndex:(int)pageIndex;
		[Export ("convertPageViewRectToReflowPageRect:reflowPage:pageIndex:")]
		FSRectF ConvertPageViewRectToReflowPageRect (CGRect rect, FSReflowPage reflowPage, int pageIndex);

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

		// -(void)refresh:(CGRect)rect pageIndex:(int)pageIndex needRender:(BOOL)needRender clearCache:(BOOL)clearCache;
		[Export ("refresh:pageIndex:needRender:clearCache:")]
		void Refresh (CGRect rect, int pageIndex, bool needRender, bool clearCache);

		// -(void)refresh:(int)pageIndex;
		[Export ("refresh:")]
		void Refresh (int pageIndex);

		// -(void)refresh:(int)pageIndex needRender:(BOOL)needRender;
		[Export ("refresh:needRender:")]
		void Refresh (int pageIndex, bool needRender);

		// -(void)refresh:(int)pageIndex needRender:(BOOL)needRender clearCache:(BOOL)clearCache;
		[Export ("refresh:needRender:clearCache:")]
		void Refresh (int pageIndex, bool needRender, bool clearCache);

		// -(void)refresh;
		[Export ("refresh")]
		void Refresh ();

		// -(void)refreshOverlay;
		[Export ("refreshOverlay")]
		void RefreshOverlay ();

		// -(void)clearRenderCache;
		[Export ("clearRenderCache")]
		void ClearRenderCache ();

		// -(UITapGestureRecognizer * _Nonnull)getPageViewDoubleTapGesture:(int)pageIndex;
		[Export ("getPageViewDoubleTapGesture:")]
		UITapGestureRecognizer GetPageViewDoubleTapGesture (int pageIndex);

		// -(void)lockGesturesForRequires:(FSGestureLockOptions)options;
		[Export ("lockGesturesForRequires:")]
		void LockGesturesForRequires (FSGestureLockOptions options);

		// -(FSGestureLockOptions)getLockedOptions;
		[Export ("getLockedOptions")]
		//[Verify (MethodToProperty)]
		FSGestureLockOptions LockedOptions { get; }

		// +(void)recoverForOOM;
		[Static]
		[Export ("recoverForOOM")]
		void RecoverForOOM ();

		// -(void)setPageSpacing:(int)pageSpace;
		[Export ("setPageSpacing:")]
		void SetPageSpacing (int pageSpace);

		// -(void)setPageSpacing:(int)pageSpace direction:(FS_PAGESPACING_DIRECTION)direction;
		[Export ("setPageSpacing:direction:")]
		void SetPageSpacing (int pageSpace, FS_PAGESPACING_DIRECTION direction);

		// +(void)setExceptionLogger:(id<FSExceptionLoggerDelegate> _Nullable)logger;
		[Static]
		[Export ("setExceptionLogger:")]
		void SetExceptionLogger ([NullAllowed] NSObject logger);/*
		

		// -(void)setPageViewEdgeInsets:(UIEdgeInsets)pageViewEdgeInsets moveOffset:(BOOL)moveOffset;
		[Export ("setPageViewEdgeInsets:moveOffset:")]
		void SetPageViewEdgeInsets (UIEdgeInsets pageViewEdgeInsets, bool moveOffset);
	}

	// @interface xfa (FSPDFViewCtrl)
	[Category]
	[BaseType (typeof(FSPDFViewCtrl))]
	interface FSPDFViewCtrl_xfa
	{
		*/
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
		bool ReloadXFADoc (FSDocProviderCallbackPageViewEventType page_view_event_type, NSNumber[] pageIndexes);/*
		
	}

	// @interface rms (FSPDFViewCtrl)
	[Category]
	[BaseType (typeof(FSPDFViewCtrl))]
	interface FSPDFViewCtrl_rms
	{
		*/
		// +(BOOL)handleMSALResponse:(NSUrl * _Nonnull)response sourceApplication:(NSString * _Nullable)sourceApplication;
		[Static]
		[Export ("handleMSALResponse:sourceApplication:")]
		bool HandleMSALResponse (NSUrl response, [NullAllowed] string sourceApplication);

		// -(void)setRMSAppClientId:(NSString * _Nonnull)appClientId redirectURI:(NSString * _Nonnull)redirectURI;
		[Export ("setRMSAppClientId:redirectURI:")]
		void SetRMSAppClientId (string appClientId, string redirectURI);

		// -(BOOL)isRMSProtected;
		[Export ("isRMSProtected")]
		//[Verify (MethodToProperty)]
		bool IsRMSProtected { get; }
	}

	// @interface CacheFileOption : NSObject
	[BaseType (typeof(NSObject))]
	interface CacheFileOption
	{
		// @property (nonatomic, strong) NSString * _Nullable cacheFilePath;
		[NullAllowed, Export ("cacheFilePath", ArgumentSemantic.Strong)]
		string CacheFilePath { get; set; }

		// @property (assign, nonatomic) BOOL isDownloadAll;
		[Export ("isDownloadAll")]
		bool IsDownloadAll { get; set; }
	}

	// @interface HttpRequestProperties : NSObject
	[BaseType (typeof(NSObject))]
	interface HttpRequestProperties
	{
		// @property (nonatomic, strong) NSMutableDictionary * _Nonnull properties;
		[Export ("properties", ArgumentSemantic.Strong)]
		NSMutableDictionary Properties { get; set; }

		// -(void)setRequestProperty:(NSString * _Nonnull)key Value:(NSString * _Nonnull)value;
		[Export ("setRequestProperty:Value:")]
		void SetRequestProperty (string key, string value);
	}

	// @interface async (FSPDFViewCtrl)
	[Category]
	[BaseType (typeof(FSPDFViewCtrl))]
	interface FSPDFViewCtrl_async
	{
		// -(void)openDocAtURL:(NSUrl * _Nonnull)url password:(NSString * _Nonnull)password completion:(void (^ _Nonnull)(FSErrorCode))completion;
		[Export ("openDocAtURL:password:completion:")]
		void OpenDocAtURL (NSUrl url, string password, Action<FSErrorCode> completion);

		// -(void)openDocFromURL:(NSUrl * _Nonnull)url password:(NSString * _Nonnull)password cacheOption:(CacheFileOption * _Nullable)cacheOption httpRequestProperties:(HttpRequestProperties * _Nullable)properties completion:(void (^ _Nonnull)(FSErrorCode))completion;
		[Export ("openDocFromURL:password:cacheOption:httpRequestProperties:completion:")]
		void OpenDocFromURL (NSUrl url, string password, [NullAllowed] CacheFileOption cacheOption, [NullAllowed] HttpRequestProperties properties, Action<FSErrorCode> completion);

		// -(void)clearCacheFile:(NSString * _Nonnull)url;
		[Export ("clearCacheFile:")]
		void ClearCacheFile (string url);

		// -(void)clearAllCacheFile;
		[Export ("clearAllCacheFile")]
		void ClearAllCacheFile ();
	}

	// @interface fips (FSPDFViewCtrl)
	[Category]
	[BaseType (typeof(FSPDFViewCtrl))]
	interface FSPDFViewCtrl_fips
	{
		// +(BOOL)fipsMode;
		[Static]
		[Export ("fipsMode")]
		//[Verify (MethodToProperty)]
		bool FipsMode { get; }
	}

	// @interface CERT_INFO : NSObject
	[BaseType (typeof(NSObject))]
	interface CERT_INFO
	{
		// @property (copy, nonatomic) NSString * _Nonnull certSerialNum;
		[Export ("certSerialNum")]
		string CertSerialNum { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull certPublisher;
		[Export ("certPublisher")]
		string CertPublisher { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull certStartDate;
		[Export ("certStartDate")]
		string CertStartDate { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull certEndDate;
		[Export ("certEndDate")]
		string CertEndDate { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull certEmailInfo;
		[Export ("certEmailInfo")]
		string CertEmailInfo { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull certOrganization;
		[Export ("certOrganization")]
		string CertOrganization { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull certOrganizationUnit;
		[Export ("certOrganizationUnit")]
		string CertOrganizationUnit { get; set; }

		// @property (nonatomic, strong) FSDateTime * _Nonnull signDate;
		[Export ("signDate", ArgumentSemantic.Strong)]
		FSDateTime SignDate { get; set; }

		// @property (assign, nonatomic) const unsigned int * _Nonnull byteRangeArray;
		[Export ("byteRangeArray", ArgumentSemantic.Assign)]
		unsafe uint ByteRangeArray { get; set; }

		// @property (assign, nonatomic) int sizeofArray;
		[Export ("sizeofArray")]
		int SizeofArray { get; set; }

		// @property (assign, nonatomic) int ltvState;
		[Export ("ltvState")]
		int LtvState { get; set; }

		// @property (copy, nonatomic) NSDictionary * _Nonnull cerInfoDic;
		[Export ("cerInfoDic", ArgumentSemantic.Copy)]
		NSDictionary CerInfoDic { get; set; }
	}

	// @interface DIGITALSIGNATURE_PARAM : NSObject
	[BaseType (typeof(NSObject))]
	interface DIGITALSIGNATURE_PARAM
	{
		// @property (copy, nonatomic) NSString * _Nonnull certFile;
		[Export ("certFile")]
		string CertFile { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull certPwd;
		[Export ("certPwd")]
		string CertPwd { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull subfilter;
		[Export ("subfilter")]
		string Subfilter { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull signFilePath;
		[Export ("signFilePath")]
		string SignFilePath { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull imagePath;
		[Export ("imagePath")]
		string ImagePath { get; set; }

		// @property (nonatomic, strong) FSRectF * _Nonnull rect;
		[Export ("rect", ArgumentSemantic.Strong)]
		FSRectF Rect { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull sigName;
		[Export ("sigName")]
		string SigName { get; set; }
	}

	// @interface FSPDFCertUtil : NSObject
	[BaseType (typeof(NSObject))]
	interface FSPDFCertUtil
	{
		// +(PDF_CERT_ERROR_CODE)getCertInfo:(NSString * _Nonnull)path password:(NSString * _Nonnull)pwd certInfo:(CERT_INFO * _Nonnull)info;
		[Static]
		[Export ("getCertInfo:password:certInfo:")]
		PDF_CERT_ERROR_CODE GetCertInfo (string path, string pwd, CERT_INFO info);

		// +(NSMutableArray * _Nonnull)getCertFromSignatureContent:(FSSignature * _Nonnull)signature;
		[Static]
		[Export ("getCertFromSignatureContent:")]
		NSMutableArray GetCertFromSignatureContent (FSSignature signature);

		// +(NSMutableDictionary * _Nonnull)getTrustCertificateInformation:(NSData * _Nonnull)certData;
		[Static]
		[Export ("getTrustCertificateInformation:")]
		NSMutableDictionary GetTrustCertificateInformation (NSData certData);

		// +(BOOL)isCertTrusted:(NSData * _Nonnull)cert toTrust:(NSData * _Nonnull)needBeTrustedCertData;
		[Static]
		[Export ("isCertTrusted:toTrust:")]
		bool IsCertTrusted (NSData cert, NSData needBeTrustedCertData);
	}

	// @protocol FSPDFMultipleScenes <NSObject>
#if !NET
    [iOS (13, 0)]
#endif
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface FSPDFMultipleScenes
	{
		// @required @property (readonly, nonatomic, class) BOOL supportsMultipleScenes;
		[Static, Abstract]
		[Export ("supportsMultipleScenes")]
		bool SupportsMultipleScenes { get; }

		// @required +(NSSet<NSObject>> * _Nonnull)connectedScenes;
		[Static, Abstract]
		[Export ("connectedScenes")]
		//[Verify (MethodToProperty)]
		NSSet<NSObject> ConnectedScenes { get; }
	}

	// @protocol FSMultipleScenesListener <NSObject>
    [Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface FSMultipleScenesListener
	{
		// @optional -(void)willAddPdfViewCtrl:(FSPDFViewCtrl * _Nonnull)pdfViewCtrl;
		[Export ("willAddPdfViewCtrl:")]
		void WillAddPdfViewCtrl (FSPDFViewCtrl pdfViewCtrl);

		// @optional -(void)willRemovePdfViewCtrl:(FSPDFViewCtrl * _Nonnull)pdfViewCtrl;
		[Export ("willRemovePdfViewCtrl:")]
		void WillRemovePdfViewCtrl (FSPDFViewCtrl pdfViewCtrl);
	}

	// @interface SupportsMultipleScenes (FSPDFViewCtrl) <FSPDFMultipleScenes>
#if !NET
    [iOS (13, 0)]
#endif
	[Category]
	[BaseType (typeof(FSPDFViewCtrl))]
	interface FSPDFViewCtrl_SupportsMultipleScenes 
	{
		// +(NSSet<NSObject> * _Nonnull)openedPdfViewCtrls;
		[Static]
		[Export ("openedPdfViewCtrls")]
		//[Verify (MethodToProperty)]
		NSSet<NSObject> OpenedPdfViewCtrls { get; }

		// +(void)registerMultipleScenesListener:(id<FSMultipleScenesListener> _Nonnull)listener;
		[Static]
		[Export ("registerMultipleScenesListener:")]
		void RegisterMultipleScenesListener (NSObject listener);

		// +(void)unregisterMultipleScenesListener:(id<FSMultipleScenesListener> _Nonnull)listener;
		[Static]
		[Export ("unregisterMultipleScenesListener:")]
		void UnregisterMultipleScenesListener (NSObject listener);
	}
}
