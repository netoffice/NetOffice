using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections.Generic;
using System.Collections;
using LateBindingApi.Core;
namespace NetOffice.OutlookApi
{
	///<summary>
	/// DispatchInterface AddressEntries 
	/// SupportByVersion Outlook, 9,10,11,12,14
	///</summary>
	[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class AddressEntries : COMObject ,IEnumerable<NetOffice.OutlookApi.AddressEntry>
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
                    _type = typeof(AddressEntries);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public AddressEntries(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public AddressEntries(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public AddressEntries(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public AddressEntries() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public AddressEntries(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public NetOffice.OutlookApi._Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				NetOffice.OutlookApi._Application newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OutlookApi._Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public NetOffice.OutlookApi.Enums.OlObjectClass Class
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Class", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.OutlookApi.Enums.OlObjectClass)intReturnItem;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public NetOffice.OutlookApi._NameSpace Session
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Session", paramsArray);
				NetOffice.OutlookApi._NameSpace newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OutlookApi._NameSpace;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public object Parent
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
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
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
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public object RawTable
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "RawTable", paramsArray);
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="index">object Index</param>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item")]
		public NetOffice.OutlookApi.AddressEntry this[object index]
		{
			get
			{
				object[] paramsArray = Invoker.ValidateParamsArray(index);
				object returnItem = Invoker.MethodReturn(this, "Item", paramsArray);
				NetOffice.OutlookApi.AddressEntry newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OutlookApi.AddressEntry.LateBindingApiWrapperType) as NetOffice.OutlookApi.AddressEntry;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="type">string Type</param>
		/// <param name="name">optional object Name</param>
		/// <param name="address">optional object Address</param>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public NetOffice.OutlookApi.AddressEntry Add(string type, object name, object address)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(type, name, address);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.OutlookApi.AddressEntry newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OutlookApi.AddressEntry.LateBindingApiWrapperType) as NetOffice.OutlookApi.AddressEntry;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="type">string Type</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public NetOffice.OutlookApi.AddressEntry Add(string type)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(type);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.OutlookApi.AddressEntry newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OutlookApi.AddressEntry.LateBindingApiWrapperType) as NetOffice.OutlookApi.AddressEntry;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="type">string Type</param>
		/// <param name="name">optional object Name</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public NetOffice.OutlookApi.AddressEntry Add(string type, object name)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(type, name);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.OutlookApi.AddressEntry newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OutlookApi.AddressEntry.LateBindingApiWrapperType) as NetOffice.OutlookApi.AddressEntry;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public NetOffice.OutlookApi.AddressEntry GetFirst()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "GetFirst", paramsArray);
			NetOffice.OutlookApi.AddressEntry newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OutlookApi.AddressEntry.LateBindingApiWrapperType) as NetOffice.OutlookApi.AddressEntry;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public NetOffice.OutlookApi.AddressEntry GetLast()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "GetLast", paramsArray);
			NetOffice.OutlookApi.AddressEntry newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OutlookApi.AddressEntry.LateBindingApiWrapperType) as NetOffice.OutlookApi.AddressEntry;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public NetOffice.OutlookApi.AddressEntry GetNext()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "GetNext", paramsArray);
			NetOffice.OutlookApi.AddressEntry newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OutlookApi.AddressEntry.LateBindingApiWrapperType) as NetOffice.OutlookApi.AddressEntry;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public NetOffice.OutlookApi.AddressEntry GetPrevious()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "GetPrevious", paramsArray);
			NetOffice.OutlookApi.AddressEntry newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OutlookApi.AddressEntry.LateBindingApiWrapperType) as NetOffice.OutlookApi.AddressEntry;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="property">optional object Property</param>
		/// <param name="order">optional object Order</param>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public void Sort(object property, object order)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(property, order);
			Invoker.Method(this, "Sort", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// </summary>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public void Sort()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Sort", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Outlook 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="property">optional object Property</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
		public void Sort(object property)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(property);
			Invoker.Method(this, "Sort", paramsArray);
		}

		#endregion
       #region IEnumerable<NetOffice.OutlookApi.AddressEntry> Member
        
        /// <summary>
		/// SupportByVersionAttribute Outlook, 9,10,11,12,14
		/// This is a custom enumerator from NetOffice
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
        [CustomEnumerator]
       public IEnumerator<NetOffice.OutlookApi.AddressEntry> GetEnumerator()  
       {
           NetRuntimeSystem.Collections.IEnumerable innerEnumerator = (this as NetRuntimeSystem.Collections.IEnumerable);
           foreach (NetOffice.OutlookApi.AddressEntry item in innerEnumerator)
               yield return item;
       }

       #endregion
   
       #region IEnumerable Members
        
       /// <summary>
		/// SupportByVersionAttribute Outlook, 9,10,11,12,14
		/// This is a custom enumerator from NetOffice
		/// </summary>
		[SupportByVersionAttribute("Outlook", 9,10,11,12,14)]
        [CustomEnumerator]
        IEnumerator NetRuntimeSystem.Collections.IEnumerable.GetEnumerator()
       {
            int count = Count;
            object[] enumeratorObjects = new object[count];
            for (int i = 0; i < count; i++)
                enumeratorObjects[i] = this[i+1];

            foreach (object item in enumeratorObjects)
                yield return item;
       }

       #endregion
       		#pragma warning restore
	}
}