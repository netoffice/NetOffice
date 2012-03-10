//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections.Generic;
using LateBindingApi.Core;
namespace NetOffice.OfficeApi
{
	///<summary>
	/// DispatchInterface SmartDocument 
	/// SupportByLibrary Office, 11,12,14
	///</summary>
	[SupportByLibraryAttribute("Office", 11,12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class SmartDocument : _IMsoDispObj
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
                    _type = typeof(SmartDocument);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public SmartDocument(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public SmartDocument(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public SmartDocument(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public SmartDocument() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public SmartDocument(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary Office 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("Office", 11,12,14)]
		public string SolutionID
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SolutionID", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "SolutionID", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Office 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("Office", 11,12,14)]
		public string SolutionURL
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SolutionURL", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "SolutionURL", paramsArray);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary Office 11, 12, 14
		/// </summary>
		/// <param name="considerAllSchemas">optional bool ConsiderAllSchemas = false</param>
		[SupportByLibraryAttribute("Office", 11,12,14)]
		public void PickSolution(bool considerAllSchemas)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(considerAllSchemas);
			Invoker.Method(this, "PickSolution", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Office 11, 12, 14
		/// </summary>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("Office", 11,12,14)]
		public void PickSolution()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "PickSolution", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Office 11, 12, 14
		/// </summary>
		[SupportByLibraryAttribute("Office", 11,12,14)]
		public void RefreshPane()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "RefreshPane", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}