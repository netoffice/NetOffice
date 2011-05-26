//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.OutlookApi
{
	///<summary>
	/// DispatchInterface _Application SupportByLibrary Outlook, 9,10,11,12,14
	///</summary>
	[SupportByLibrary("Outlook", 9,10,11,12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class _Application : COMObject
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _Application(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _Application(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _Application(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _Application()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary Outlook 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
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
		/// SupportByLibrary Outlook 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public NetOffice.OutlookApi.Enums.OlObjectClass Class
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Class", paramsArray);
				return (NetOffice.OutlookApi.Enums.OlObjectClass)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
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
		/// SupportByLibrary Outlook 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
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
		/// SupportByLibrary Outlook 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public NetOffice.OfficeApi.Assistant Assistant
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Assistant", paramsArray);
				NetOffice.OfficeApi.Assistant newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OfficeApi.Assistant;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public string Name
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Name", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public string Version
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Version", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public NetOffice.OfficeApi.COMAddIns COMAddIns
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "COMAddIns", paramsArray);
				NetOffice.OfficeApi.COMAddIns newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OfficeApi.COMAddIns;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public NetOffice.OutlookApi._Explorers Explorers
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Explorers", paramsArray);
				NetOffice.OutlookApi._Explorers newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OutlookApi._Explorers;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public NetOffice.OutlookApi._Inspectors Inspectors
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Inspectors", paramsArray);
				NetOffice.OutlookApi._Inspectors newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OutlookApi._Inspectors;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public NetOffice.OfficeApi.LanguageSettings LanguageSettings
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "LanguageSettings", paramsArray);
				NetOffice.OfficeApi.LanguageSettings newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OfficeApi.LanguageSettings;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public string ProductCode
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ProductCode", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public NetOffice.OfficeApi.AnswerWizard AnswerWizard
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AnswerWizard", paramsArray);
				NetOffice.OfficeApi.AnswerWizard newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OfficeApi.AnswerWizard;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public NetOffice.OfficeApi.Enums.MsoFeatureInstall FeatureInstall
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "FeatureInstall", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoFeatureInstall)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "FeatureInstall", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Outlook", 10,11,12,14)]
		public NetOffice.OutlookApi._Reminders Reminders
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Reminders", paramsArray);
				NetOffice.OutlookApi._Reminders newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OutlookApi._Reminders;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 12, 14
		/// </summary>
		[SupportByLibrary("Outlook", 12,14)]
		public string DefaultProfileName
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DefaultProfileName", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 12, 14
		/// </summary>
		[SupportByLibrary("Outlook", 12,14)]
		public bool IsTrusted
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "IsTrusted", paramsArray);
				return (bool)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 12, 14
		/// </summary>
		[SupportByLibrary("Outlook", 12,14)]
		public NetOffice.OfficeApi.IAssistance Assistance
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Assistance", paramsArray);
				NetOffice.OfficeApi.IAssistance newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OfficeApi.IAssistance;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 12, 14
		/// </summary>
		[SupportByLibrary("Outlook", 12,14)]
		public NetOffice.OutlookApi.TimeZones TimeZones
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "TimeZones", paramsArray);
				NetOffice.OutlookApi.TimeZones newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OutlookApi.TimeZones;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook 14
		/// </summary>
		[SupportByLibrary("Outlook", 14)]
		public NetOffice.OfficeApi.PickerDialog PickerDialog
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "PickerDialog", paramsArray);
				NetOffice.OfficeApi.PickerDialog newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OfficeApi.PickerDialog;
				return newObject;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary Outlook 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public NetOffice.OutlookApi._Explorer ActiveExplorer()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "ActiveExplorer", paramsArray);
			NetOffice.OutlookApi._Explorer newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.OutlookApi._Explorer;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Outlook 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public NetOffice.OutlookApi._Inspector ActiveInspector()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "ActiveInspector", paramsArray);
			NetOffice.OutlookApi._Inspector newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.OutlookApi._Inspector;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Outlook 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="ItemType">NetOffice.OutlookApi.Enums.OlItemType ItemType</param>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public COMObject CreateItem(NetOffice.OutlookApi.Enums.OlItemType itemType)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(itemType);
			object returnItem = Invoker.MethodReturn(this, "CreateItem", paramsArray);
			COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Outlook 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="TemplatePath">string TemplatePath</param>
		/// <param name="InFolder">optional object InFolder</param>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public COMObject CreateItemFromTemplate(string templatePath, object inFolder=null)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(templatePath, inFolder);
			object returnItem = Invoker.MethodReturn(this, "CreateItemFromTemplate", paramsArray);
			COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Outlook 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="TemplatePath">string TemplatePath</param>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public COMObject CreateItemFromTemplate(string templatePath)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(templatePath);
			object returnItem = Invoker.MethodReturn(this, "CreateItemFromTemplate", paramsArray);
			COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Outlook 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="ObjectName">string ObjectName</param>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public COMObject CreateObject(string objectName)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(objectName);
			object returnItem = Invoker.MethodReturn(this, "CreateObject", paramsArray);
			COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Outlook 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Type">string Type</param>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public NetOffice.OutlookApi._NameSpace GetNamespace(string type)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(type);
			object returnItem = Invoker.MethodReturn(this, "GetNamespace", paramsArray);
			NetOffice.OutlookApi._NameSpace newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.OutlookApi._NameSpace;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Outlook 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public void Quit()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Quit", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Outlook 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public COMObject ActiveWindow()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "ActiveWindow", paramsArray);
			COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Outlook 10, 11, 12, 14
		/// </summary>
		/// <param name="FilePath">string FilePath</param>
		/// <param name="DestFolderPath">string DestFolderPath</param>
		[SupportByLibrary("Outlook", 10,11,12,14)]
		public COMObject CopyFile(string filePath, string destFolderPath)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(filePath, destFolderPath);
			object returnItem = Invoker.MethodReturn(this, "CopyFile", paramsArray);
			COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Outlook 10, 11, 12, 14
		/// </summary>
		/// <param name="Scope">string Scope</param>
		/// <param name="Filter">optional object Filter</param>
		/// <param name="SearchSubFolders">optional object SearchSubFolders</param>
		/// <param name="Tag">optional object Tag</param>
		[SupportByLibrary("Outlook", 10,11,12,14)]
		public NetOffice.OutlookApi.Search AdvancedSearch(string scope, object filter=null, object searchSubFolders=null, object tag=null)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(scope, filter, searchSubFolders, tag);
			object returnItem = Invoker.MethodReturn(this, "AdvancedSearch", paramsArray);
			NetOffice.OutlookApi.Search newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.OutlookApi.Search;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Outlook 10, 11, 12, 14
		/// </summary>
		/// <param name="Scope">string Scope</param>
		[SupportByLibrary("Outlook", 10,11,12,14)]
		public NetOffice.OutlookApi.Search AdvancedSearch(string scope)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(scope);
			object returnItem = Invoker.MethodReturn(this, "AdvancedSearch", paramsArray);
			NetOffice.OutlookApi.Search newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.OutlookApi.Search;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Outlook 10, 11, 12, 14
		/// </summary>
		/// <param name="LookInFolders">string LookInFolders</param>
		[SupportByLibrary("Outlook", 10,11,12,14)]
		public bool IsSearchSynchronous(string lookInFolders)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(lookInFolders);
			object returnItem = Invoker.MethodReturn(this, "IsSearchSynchronous", paramsArray);
			return (bool)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Outlook 10, 11, 12, 14
		/// </summary>
		/// <param name="pvar">object pvar</param>
		[SupportByLibrary("Outlook", 10,11,12,14)]
		public void GetNewNickNames(object pvar)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pvar);
			Invoker.Method(this, "GetNewNickNames", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Outlook 12, 14
		/// </summary>
		/// <param name="Item">object Item</param>
		/// <param name="ReferenceType">NetOffice.OutlookApi.Enums.OlReferenceType ReferenceType</param>
		[SupportByLibrary("Outlook", 12,14)]
		public COMObject GetObjectReference(object item, NetOffice.OutlookApi.Enums.OlReferenceType referenceType)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(item, referenceType);
			object returnItem = Invoker.MethodReturn(this, "GetObjectReference", paramsArray);
			COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Outlook 14
		/// </summary>
		/// <param name="RegionName">string RegionName</param>
		[SupportByLibrary("Outlook", 14)]
		public void RefreshFormRegionDefinition(string regionName)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(regionName);
			Invoker.Method(this, "RefreshFormRegionDefinition", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}