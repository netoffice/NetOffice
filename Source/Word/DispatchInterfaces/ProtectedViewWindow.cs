using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections.Generic;
using NetOffice;
namespace NetOffice.WordApi
{
	///<summary>
	/// DispatchInterface ProtectedViewWindow 
	/// SupportByVersion Word, 14
	///</summary>
	[SupportByVersionAttribute("Word", 14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class ProtectedViewWindow : COMObject
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
                    _type = typeof(ProtectedViewWindow);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ProtectedViewWindow(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ProtectedViewWindow(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ProtectedViewWindow(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ProtectedViewWindow() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ProtectedViewWindow(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion Word 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Word", 14)]
		public NetOffice.WordApi.Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				NetOffice.WordApi.Application newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.WordApi.Application.LateBindingApiWrapperType) as NetOffice.WordApi.Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Word 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Word", 14)]
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
		/// SupportByVersion Word 14
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		[SupportByVersionAttribute("Word", 14)]
		public object Parent
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Parent", paramsArray);
				COMObject newObject = NetOffice.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Word 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Word", 14)]
		public string Caption
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Caption", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Caption", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Word 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Word", 14)]
		public NetOffice.WordApi.Document Document
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Document", paramsArray);
				NetOffice.WordApi.Document newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.WordApi.Document.LateBindingApiWrapperType) as NetOffice.WordApi.Document;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Word 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Word", 14)]
		public Int32 Left
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Left", paramsArray);
				return NetRuntimeSystem.Convert.ToInt32(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Left", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Word 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Word", 14)]
		public Int32 Top
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Top", paramsArray);
				return NetRuntimeSystem.Convert.ToInt32(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Top", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Word 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Word", 14)]
		public Int32 Width
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Width", paramsArray);
				return NetRuntimeSystem.Convert.ToInt32(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Width", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Word 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Word", 14)]
		public Int32 Height
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Height", paramsArray);
				return NetRuntimeSystem.Convert.ToInt32(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Height", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Word 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Word", 14)]
		public NetOffice.WordApi.Enums.WdWindowState WindowState
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "WindowState", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.WordApi.Enums.WdWindowState)intReturnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "WindowState", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Word 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Word", 14)]
		public bool Active
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Active", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Word 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Word", 14)]
		public Int32 Index
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Index", paramsArray);
				return NetRuntimeSystem.Convert.ToInt32(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Word 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Word", 14)]
		public bool Visible
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Visible", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Visible", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Word 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Word", 14)]
		public string SourceName
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SourceName", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Word 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Word", 14)]
		public string SourcePath
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SourcePath", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion Word 14
		/// </summary>
		[SupportByVersionAttribute("Word", 14)]
		public void Activate()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Activate", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 14
		/// </summary>
		/// <param name="passwordTemplate">optional object PasswordTemplate</param>
		/// <param name="writePasswordDocument">optional object WritePasswordDocument</param>
		/// <param name="writePasswordTemplate">optional object WritePasswordTemplate</param>
		[SupportByVersionAttribute("Word", 14)]
		public NetOffice.WordApi.Document Edit(object passwordTemplate, object writePasswordDocument, object writePasswordTemplate)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(passwordTemplate, writePasswordDocument, writePasswordTemplate);
			object returnItem = Invoker.MethodReturn(this, "Edit", paramsArray);
			NetOffice.WordApi.Document newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.WordApi.Document.LateBindingApiWrapperType) as NetOffice.WordApi.Document;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Word 14
		/// </summary>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 14)]
		public NetOffice.WordApi.Document Edit()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "Edit", paramsArray);
			NetOffice.WordApi.Document newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.WordApi.Document.LateBindingApiWrapperType) as NetOffice.WordApi.Document;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Word 14
		/// </summary>
		/// <param name="passwordTemplate">optional object PasswordTemplate</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 14)]
		public NetOffice.WordApi.Document Edit(object passwordTemplate)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(passwordTemplate);
			object returnItem = Invoker.MethodReturn(this, "Edit", paramsArray);
			NetOffice.WordApi.Document newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.WordApi.Document.LateBindingApiWrapperType) as NetOffice.WordApi.Document;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Word 14
		/// </summary>
		/// <param name="passwordTemplate">optional object PasswordTemplate</param>
		/// <param name="writePasswordDocument">optional object WritePasswordDocument</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Word", 14)]
		public NetOffice.WordApi.Document Edit(object passwordTemplate, object writePasswordDocument)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(passwordTemplate, writePasswordDocument);
			object returnItem = Invoker.MethodReturn(this, "Edit", paramsArray);
			NetOffice.WordApi.Document newObject = NetOffice.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.WordApi.Document.LateBindingApiWrapperType) as NetOffice.WordApi.Document;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Word 14
		/// </summary>
		[SupportByVersionAttribute("Word", 14)]
		public void Close()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Close", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Word 14
		/// </summary>
		[SupportByVersionAttribute("Word", 14)]
		public void ToggleRibbon()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "ToggleRibbon", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}