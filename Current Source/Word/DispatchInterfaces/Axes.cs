//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections.Generic;
using System.Collections;
using LateBindingApi.Core;
namespace NetOffice.WordApi
{
	///<summary>
	/// DispatchInterface Axes 
	/// SupportByLibrary Word, 14
	///</summary>
	[SupportByLibraryAttribute("Word", 14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class Axes : COMObject ,IEnumerable<NetOffice.WordApi.Axis>
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
                    _type = typeof(Axes);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Axes(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Axes(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Axes(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Axes() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Axes(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary Word 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Word", 14)]
		public Int32 Count
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Count", paramsArray);
				return NetRuntimeSystem.Convert.ToInt32(returnItem);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Word", 14)]
		public COMObject Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Word 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Word", 14)]
		public Int32 Creator
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Creator", paramsArray);
				return NetRuntimeSystem.Convert.ToInt32(returnItem);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Word", 14)]
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

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary Word 14
		/// </summary>
		/// <param name="type">NetOffice.WordApi.Enums.XlAxisType Type</param>
		/// <param name="axisGroup">optional NetOffice.WordApi.Enums.XlAxisGroup AxisGroup = 1</param>
		[SupportByLibraryAttribute("Word", 14)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item")]
		public NetOffice.WordApi.Axis this[NetOffice.WordApi.Enums.XlAxisType type, NetOffice.WordApi.Enums.XlAxisGroup axisGroup]
		{
			get
			{
				object[] paramsArray = Invoker.ValidateParamsArray(type, axisGroup);
				object returnItem = Invoker.MethodReturn(this, "Item", paramsArray);
				NetOffice.WordApi.Axis newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.WordApi.Axis.LateBindingApiWrapperType) as NetOffice.WordApi.Axis;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Word 14
		/// </summary>
		/// <param name="type">NetOffice.WordApi.Enums.XlAxisType Type</param>
		/// <param name="axisGroup">optional NetOffice.WordApi.Enums.XlAxisGroup AxisGroup = 1</param>
		[SupportByLibraryAttribute("Word", 14)]
		public NetOffice.WordApi.Axis _Default(NetOffice.WordApi.Enums.XlAxisType type, NetOffice.WordApi.Enums.XlAxisGroup axisGroup)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(type, axisGroup);
			object returnItem = Invoker.MethodReturn(this, "_Default", paramsArray);
			NetOffice.WordApi.Axis newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.WordApi.Axis.LateBindingApiWrapperType) as NetOffice.WordApi.Axis;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Word 14
		/// </summary>
		/// <param name="type">NetOffice.WordApi.Enums.XlAxisType Type</param>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("Word", 14)]
		public NetOffice.WordApi.Axis _Default(NetOffice.WordApi.Enums.XlAxisType type)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(type);
			object returnItem = Invoker.MethodReturn(this, "_Default", paramsArray);
			NetOffice.WordApi.Axis newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.WordApi.Axis.LateBindingApiWrapperType) as NetOffice.WordApi.Axis;
			return newObject;
		}

		#endregion

        #region IEnumerable<NetOffice.WordApi.Axis> Member
		
		/// <summary>
		/// SupportByLibraryAttribute Word, 14
		/// </summary>
		[SupportByLibraryAttribute("Word", 14)]
        public IEnumerator<NetOffice.WordApi.Axis> GetEnumerator()  
        {
            NetRuntimeSystem.Collections.IEnumerable innerEnumerator = (this as NetRuntimeSystem.Collections.IEnumerable);
            foreach (NetOffice.WordApi.Axis item in innerEnumerator)
                yield return item;
        }

        #endregion
           
        #region IEnumerable Members
        
		/// <summary>
		/// SupportByLibraryAttribute Word, 14
		/// </summary>
		[SupportByLibraryAttribute("Word", 14)]
		IEnumerator NetRuntimeSystem.Collections.IEnumerable.GetEnumerator()
		{
			object enumProxy = Invoker.MethodReturn(this, "_NewEnum");
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