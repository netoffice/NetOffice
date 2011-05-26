//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections;
using LateBindingApi.Core;
namespace NetOffice.WordApi
{
	///<summary>
	/// DispatchInterface Indexes SupportByLibrary Word, 9,10,11,12,14
	///</summary>
	[SupportByLibrary("Word", 9,10,11,12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class Indexes : COMObject ,IEnumerable
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Indexes(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Indexes(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Indexes(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Indexes()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				NetOffice.WordApi.Application newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.WordApi.Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public Int32 Creator
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Creator", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public COMObject Parent
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Parent", paramsArray);
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public Int32 Count
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Count", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.Enums.WdIndexFormat Format
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Format", paramsArray);
				return (NetOffice.WordApi.Enums.WdIndexFormat)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Format", paramsArray);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Index">Int32 Index</param>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item")]
		public NetOffice.WordApi.Index this[Int32 index]
		{
			get
			{
				object[] paramsArray = Invoker.ValidateParamsArray(index);
				object returnItem = Invoker.MethodReturn(this, "Item", paramsArray);
				NetOffice.WordApi.Index newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.WordApi.Index;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Range">NetOffice.WordApi.Range Range</param>
		/// <param name="HeadingSeparator">optional object HeadingSeparator</param>
		/// <param name="RightAlignPageNumbers">optional object RightAlignPageNumbers</param>
		/// <param name="Type">optional object Type</param>
		/// <param name="NumberOfColumns">optional object NumberOfColumns</param>
		/// <param name="AccentedLetters">optional object AccentedLetters</param>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.Index AddOld(NetOffice.WordApi.Range range, object headingSeparator=null, object rightAlignPageNumbers=null, object type=null, object numberOfColumns=null, object accentedLetters=null)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(range, headingSeparator, rightAlignPageNumbers, type, numberOfColumns, accentedLetters);
			object returnItem = Invoker.MethodReturn(this, "AddOld", paramsArray);
			NetOffice.WordApi.Index newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.WordApi.Index;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Range">NetOffice.WordApi.Range Range</param>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.Index AddOld(NetOffice.WordApi.Range range)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(range);
			object returnItem = Invoker.MethodReturn(this, "AddOld", paramsArray);
			NetOffice.WordApi.Index newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.WordApi.Index;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Range">NetOffice.WordApi.Range Range</param>
		/// <param name="Entry">optional object Entry</param>
		/// <param name="EntryAutoText">optional object EntryAutoText</param>
		/// <param name="CrossReference">optional object CrossReference</param>
		/// <param name="CrossReferenceAutoText">optional object CrossReferenceAutoText</param>
		/// <param name="BookmarkName">optional object BookmarkName</param>
		/// <param name="Bold">optional object Bold</param>
		/// <param name="Italic">optional object Italic</param>
		/// <param name="Reading">optional object Reading</param>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.Field MarkEntry(NetOffice.WordApi.Range range, object entry=null, object entryAutoText=null, object crossReference=null, object crossReferenceAutoText=null, object bookmarkName=null, object bold=null, object italic=null, object reading=null)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(range, entry, entryAutoText, crossReference, crossReferenceAutoText, bookmarkName, bold, italic, reading);
			object returnItem = Invoker.MethodReturn(this, "MarkEntry", paramsArray);
			NetOffice.WordApi.Field newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.WordApi.Field;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Range">NetOffice.WordApi.Range Range</param>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.Field MarkEntry(NetOffice.WordApi.Range range)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(range);
			object returnItem = Invoker.MethodReturn(this, "MarkEntry", paramsArray);
			NetOffice.WordApi.Field newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.WordApi.Field;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Range">NetOffice.WordApi.Range Range</param>
		/// <param name="Entry">optional object Entry</param>
		/// <param name="EntryAutoText">optional object EntryAutoText</param>
		/// <param name="CrossReference">optional object CrossReference</param>
		/// <param name="CrossReferenceAutoText">optional object CrossReferenceAutoText</param>
		/// <param name="BookmarkName">optional object BookmarkName</param>
		/// <param name="Bold">optional object Bold</param>
		/// <param name="Italic">optional object Italic</param>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public void MarkAllEntries(NetOffice.WordApi.Range range, object entry=null, object entryAutoText=null, object crossReference=null, object crossReferenceAutoText=null, object bookmarkName=null, object bold=null, object italic=null)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(range, entry, entryAutoText, crossReference, crossReferenceAutoText, bookmarkName, bold, italic);
			Invoker.Method(this, "MarkAllEntries", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Range">NetOffice.WordApi.Range Range</param>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public void MarkAllEntries(NetOffice.WordApi.Range range)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(range);
			Invoker.Method(this, "MarkAllEntries", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="ConcordanceFileName">string ConcordanceFileName</param>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public void AutoMarkEntries(string concordanceFileName)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(concordanceFileName);
			Invoker.Method(this, "AutoMarkEntries", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Range">NetOffice.WordApi.Range Range</param>
		/// <param name="HeadingSeparator">optional object HeadingSeparator</param>
		/// <param name="RightAlignPageNumbers">optional object RightAlignPageNumbers</param>
		/// <param name="Type">optional object Type</param>
		/// <param name="NumberOfColumns">optional object NumberOfColumns</param>
		/// <param name="AccentedLetters">optional object AccentedLetters</param>
		/// <param name="SortBy">optional object SortBy</param>
		/// <param name="IndexLanguage">optional object IndexLanguage</param>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.Index Add(NetOffice.WordApi.Range range, object headingSeparator=null, object rightAlignPageNumbers=null, object type=null, object numberOfColumns=null, object accentedLetters=null, object sortBy=null, object indexLanguage=null)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(range, headingSeparator, rightAlignPageNumbers, type, numberOfColumns, accentedLetters, sortBy, indexLanguage);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.WordApi.Index newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.WordApi.Index;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Range">NetOffice.WordApi.Range Range</param>
		[SupportByLibrary("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.Index Add(NetOffice.WordApi.Range range)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(range);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.WordApi.Index newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.WordApi.Index;
			return newObject;
		}

		#endregion
   
        #region IEnumerable Members
        
        [SupportByLibrary("Word", 9,10,11,12,14)]
		public IEnumerator GetEnumerator()
		{
			object enumProxy = Invoker.PropertyGet(this, "_NewEnum");
			COMObject enumerator = new COMObject(this, enumProxy);
			Invoker.Method(enumerator, "Reset", null);
			bool isMoveNextTrue = (bool)Invoker.MethodReturn(enumerator, "MoveNext", null);
            while (true == isMoveNextTrue)
            {
                object itemProxy = Invoker.PropertyGet(enumerator, "Current", null);
                COMObject returnClass = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, itemProxy);
                isMoveNextTrue = (bool)Invoker.MethodReturn(enumerator, "MoveNext", null);
				yield return returnClass;
            }
        }

        #endregion
		#pragma warning restore
	}
}