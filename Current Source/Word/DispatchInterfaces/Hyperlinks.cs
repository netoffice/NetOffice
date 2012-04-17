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
	/// DispatchInterface Hyperlinks 
	/// SupportByVersion Word, 9,10,11,12,14
	///</summary>
	[SupportByVersionAttribute("Word", 9,10,11,12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class Hyperlinks : COMObject ,IEnumerable<NetOffice.WordApi.Hyperlink>
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
                    _type = typeof(Hyperlinks);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Hyperlinks(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Hyperlinks(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Hyperlinks(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Hyperlinks() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Hyperlinks(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				NetOffice.WordApi.Application newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.WordApi.Application.LateBindingApiWrapperType) as NetOffice.WordApi.Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
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
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
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
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
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
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="index">object Index</param>
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item")]
		public NetOffice.WordApi.Hyperlink this[object index]
		{
			get
			{
				object[] paramsArray = Invoker.ValidateParamsArray(index);
				object returnItem = Invoker.MethodReturn(this, "Item", paramsArray);
				NetOffice.WordApi.Hyperlink newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.WordApi.Hyperlink.LateBindingApiWrapperType) as NetOffice.WordApi.Hyperlink;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="anchor">object Anchor</param>
		/// <param name="address">optional object Address</param>
		/// <param name="subAddress">optional object SubAddress</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.Hyperlink _Add(object anchor, object address, object subAddress)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(anchor, address, subAddress);
			object returnItem = Invoker.MethodReturn(this, "_Add", paramsArray);
			NetOffice.WordApi.Hyperlink newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.WordApi.Hyperlink.LateBindingApiWrapperType) as NetOffice.WordApi.Hyperlink;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="anchor">object Anchor</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.Hyperlink _Add(object anchor)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(anchor);
			object returnItem = Invoker.MethodReturn(this, "_Add", paramsArray);
			NetOffice.WordApi.Hyperlink newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.WordApi.Hyperlink.LateBindingApiWrapperType) as NetOffice.WordApi.Hyperlink;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="anchor">object Anchor</param>
		/// <param name="address">optional object Address</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.Hyperlink _Add(object anchor, object address)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(anchor, address);
			object returnItem = Invoker.MethodReturn(this, "_Add", paramsArray);
			NetOffice.WordApi.Hyperlink newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.WordApi.Hyperlink.LateBindingApiWrapperType) as NetOffice.WordApi.Hyperlink;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="anchor">object Anchor</param>
		/// <param name="address">optional object Address</param>
		/// <param name="subAddress">optional object SubAddress</param>
		/// <param name="screenTip">optional object ScreenTip</param>
		/// <param name="textToDisplay">optional object TextToDisplay</param>
		/// <param name="target">optional object Target</param>
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.Hyperlink Add(object anchor, object address, object subAddress, object screenTip, object textToDisplay, object target)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(anchor, address, subAddress, screenTip, textToDisplay, target);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.WordApi.Hyperlink newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.WordApi.Hyperlink.LateBindingApiWrapperType) as NetOffice.WordApi.Hyperlink;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="anchor">object Anchor</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.Hyperlink Add(object anchor)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(anchor);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.WordApi.Hyperlink newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.WordApi.Hyperlink.LateBindingApiWrapperType) as NetOffice.WordApi.Hyperlink;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="anchor">object Anchor</param>
		/// <param name="address">optional object Address</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.Hyperlink Add(object anchor, object address)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(anchor, address);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.WordApi.Hyperlink newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.WordApi.Hyperlink.LateBindingApiWrapperType) as NetOffice.WordApi.Hyperlink;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="anchor">object Anchor</param>
		/// <param name="address">optional object Address</param>
		/// <param name="subAddress">optional object SubAddress</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.Hyperlink Add(object anchor, object address, object subAddress)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(anchor, address, subAddress);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.WordApi.Hyperlink newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.WordApi.Hyperlink.LateBindingApiWrapperType) as NetOffice.WordApi.Hyperlink;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="anchor">object Anchor</param>
		/// <param name="address">optional object Address</param>
		/// <param name="subAddress">optional object SubAddress</param>
		/// <param name="screenTip">optional object ScreenTip</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.Hyperlink Add(object anchor, object address, object subAddress, object screenTip)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(anchor, address, subAddress, screenTip);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.WordApi.Hyperlink newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.WordApi.Hyperlink.LateBindingApiWrapperType) as NetOffice.WordApi.Hyperlink;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="anchor">object Anchor</param>
		/// <param name="address">optional object Address</param>
		/// <param name="subAddress">optional object SubAddress</param>
		/// <param name="screenTip">optional object ScreenTip</param>
		/// <param name="textToDisplay">optional object TextToDisplay</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.Hyperlink Add(object anchor, object address, object subAddress, object screenTip, object textToDisplay)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(anchor, address, subAddress, screenTip, textToDisplay);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.WordApi.Hyperlink newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.WordApi.Hyperlink.LateBindingApiWrapperType) as NetOffice.WordApi.Hyperlink;
			return newObject;
		}

		#endregion

       #region IEnumerable<NetOffice.WordApi.Hyperlink> Member
        
        /// <summary>
		/// SupportByVersionAttribute Word, 9,10,11,12,14
		/// </summary>
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
       public IEnumerator<NetOffice.WordApi.Hyperlink> GetEnumerator()  
       {
           NetRuntimeSystem.Collections.IEnumerable innerEnumerator = (this as NetRuntimeSystem.Collections.IEnumerable);
           foreach (NetOffice.WordApi.Hyperlink item in innerEnumerator)
               yield return item;
       }

       #endregion
          
		#region IEnumerable Members
       
		/// <summary>
		/// SupportByVersionAttribute Word, 9,10,11,12,14
		/// </summary>
		[SupportByVersionAttribute("Word", 9,10,11,12,14)]
		IEnumerator NetRuntimeSystem.Collections.IEnumerable.GetEnumerator()
		{
			return LateBindingApi.Core.Utils.GetProxyEnumeratorAsProperty(this);
		}

		#endregion
		#pragma warning restore
	}
}