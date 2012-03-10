//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Reflection;
using System.Collections.Generic;
using System.Collections;
using LateBindingApi.Core;
namespace NetOffice.ExcelApi
{
	///<summary>
	/// Interface IPivotTableChangeList 
	/// SupportByLibrary Excel, 14
	///</summary>
	[SupportByLibraryAttribute("Excel", 14)]
	[EntityTypeAttribute(EntityType.IsInterface)]
	public class IPivotTableChangeList : COMObject ,IEnumerable<NetOffice.ExcelApi.ValueChange>
	{
		#pragma warning disable
		#region Type Information

        private static Type _type;

		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(IPivotTableChangeList);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IPivotTableChangeList(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IPivotTableChangeList(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IPivotTableChangeList(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IPivotTableChangeList() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IPivotTableChangeList(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary Excel 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Excel", 14)]
		public NetOffice.ExcelApi.Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				NetOffice.ExcelApi.Application newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.ExcelApi.Application.LateBindingApiWrapperType) as NetOffice.ExcelApi.Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Excel 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Excel", 14)]
		public NetOffice.ExcelApi.Enums.XlCreator Creator
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Creator", paramsArray);
				return (NetOffice.ExcelApi.Enums.XlCreator)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Excel 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Excel", 14)]
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
		/// SupportByLibrary Excel 14
		/// Get
		/// </summary>
		/// <param name="Index">object Index</param>
		[SupportByLibraryAttribute("Excel", 14)]
		public NetOffice.ExcelApi.ValueChange get__Default(object index)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.PropertyGet(this, "_Default", paramsArray);
			NetOffice.ExcelApi.ValueChange newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.ExcelApi.ValueChange.LateBindingApiWrapperType) as NetOffice.ExcelApi.ValueChange;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Excel 14
		/// Get
		/// </summary>
		/// <param name="Index">object Index</param>
		[SupportByLibraryAttribute("Excel", 14)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item")]
		public NetOffice.ExcelApi.ValueChange this[object index]
		{
			get
{			
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.PropertyGet(this, "Item", paramsArray);
			NetOffice.ExcelApi.ValueChange newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.ExcelApi.ValueChange.LateBindingApiWrapperType) as NetOffice.ExcelApi.ValueChange;
			return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Excel 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Excel", 14)]
		public Int32 Count
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Count", paramsArray);
				return NetRuntimeSystem.Convert.ToInt32(returnItem);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary Excel 14
		/// </summary>
		/// <param name="tuple">string Tuple</param>
		/// <param name="value">Double Value</param>
		/// <param name="allocationValue">optional object AllocationValue</param>
		/// <param name="allocationMethod">optional object AllocationMethod</param>
		/// <param name="allocationWeightExpression">optional object AllocationWeightExpression</param>
		[SupportByLibraryAttribute("Excel", 14)]
		public NetOffice.ExcelApi.ValueChange Add(string tuple, Double value, object allocationValue, object allocationMethod, object allocationWeightExpression)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(tuple, value, allocationValue, allocationMethod, allocationWeightExpression);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.ExcelApi.ValueChange newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.ValueChange.LateBindingApiWrapperType) as NetOffice.ExcelApi.ValueChange;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Excel 14
		/// </summary>
		/// <param name="tuple">string Tuple</param>
		/// <param name="value">Double Value</param>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("Excel", 14)]
		public NetOffice.ExcelApi.ValueChange Add(string tuple, Double value)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(tuple, value);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.ExcelApi.ValueChange newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.ValueChange.LateBindingApiWrapperType) as NetOffice.ExcelApi.ValueChange;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Excel 14
		/// </summary>
		/// <param name="tuple">string Tuple</param>
		/// <param name="value">Double Value</param>
		/// <param name="allocationValue">optional object AllocationValue</param>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("Excel", 14)]
		public NetOffice.ExcelApi.ValueChange Add(string tuple, Double value, object allocationValue)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(tuple, value, allocationValue);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.ExcelApi.ValueChange newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.ValueChange.LateBindingApiWrapperType) as NetOffice.ExcelApi.ValueChange;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Excel 14
		/// </summary>
		/// <param name="tuple">string Tuple</param>
		/// <param name="value">Double Value</param>
		/// <param name="allocationValue">optional object AllocationValue</param>
		/// <param name="allocationMethod">optional object AllocationMethod</param>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("Excel", 14)]
		public NetOffice.ExcelApi.ValueChange Add(string tuple, Double value, object allocationValue, object allocationMethod)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(tuple, value, allocationValue, allocationMethod);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.ExcelApi.ValueChange newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.ValueChange.LateBindingApiWrapperType) as NetOffice.ExcelApi.ValueChange;
			return newObject;
		}

		#endregion

        #region IEnumerable<NetOffice.ExcelApi.ValueChange> Member
		
		/// <summary>
		/// SupportByLibraryAttribute Excel, 14
		/// </summary>
		[SupportByLibraryAttribute("Excel", 14)]
        public IEnumerator<NetOffice.ExcelApi.ValueChange> GetEnumerator()  
        {
            NetRuntimeSystem.Collections.IEnumerable innerEnumerator = (this as NetRuntimeSystem.Collections.IEnumerable);
            foreach (NetOffice.ExcelApi.ValueChange item in innerEnumerator)
                yield return item;
        }

        #endregion
           
        #region IEnumerable Members
        
		/// <summary>
		/// SupportByLibraryAttribute Excel, 14
		/// </summary>
		[SupportByLibraryAttribute("Excel", 14)]
		IEnumerator NetRuntimeSystem.Collections.IEnumerable.GetEnumerator()
		{
			object enumProxy = Invoker.PropertyGet(this, "_NewEnum");
			COMObject enumerator = new COMObject(this, enumProxy, true);
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