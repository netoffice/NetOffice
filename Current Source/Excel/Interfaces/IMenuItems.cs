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
	/// Interface IMenuItems 
	/// SupportByLibrary Excel, 9,10,11,12,14
	///</summary>
	[SupportByLibraryAttribute("Excel", 9,10,11,12,14)]
	[EntityTypeAttribute(EntityType.IsInterface)]
	public class IMenuItems : COMObject ,IEnumerable<object>
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
                    _type = typeof(IMenuItems);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IMenuItems(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IMenuItems(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IMenuItems(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IMenuItems() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IMenuItems(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Excel", 9,10,11,12,14)]
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
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Excel", 9,10,11,12,14)]
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
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Excel", 9,10,11,12,14)]
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
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Excel", 9,10,11,12,14)]
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
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		/// <param name="Index">object Index</param>
		[SupportByLibraryAttribute("Excel", 9,10,11,12,14)]
		public COMObject get__Default(object index)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.PropertyGet(this, "_Default", paramsArray);
			COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		/// <param name="Index">object Index</param>
		[SupportByLibraryAttribute("Excel", 9,10,11,12,14)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item")]
		public COMObject this[object index]
		{
			get
{			
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.PropertyGet(this, "Item", paramsArray);
			COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
			return newObject;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="caption">string Caption</param>
		/// <param name="onAction">optional object OnAction</param>
		/// <param name="shortcutKey">optional object ShortcutKey</param>
		/// <param name="before">optional object Before</param>
		/// <param name="restore">optional object Restore</param>
		/// <param name="statusBar">optional object StatusBar</param>
		/// <param name="helpFile">optional object HelpFile</param>
		/// <param name="helpContextID">optional object HelpContextID</param>
		[SupportByLibraryAttribute("Excel", 9,10,11,12,14)]
		public NetOffice.ExcelApi.MenuItem Add(string caption, object onAction, object shortcutKey, object before, object restore, object statusBar, object helpFile, object helpContextID)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(caption, onAction, shortcutKey, before, restore, statusBar, helpFile, helpContextID);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.ExcelApi.MenuItem newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.MenuItem.LateBindingApiWrapperType) as NetOffice.ExcelApi.MenuItem;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="caption">string Caption</param>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("Excel", 9,10,11,12,14)]
		public NetOffice.ExcelApi.MenuItem Add(string caption)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(caption);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.ExcelApi.MenuItem newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.MenuItem.LateBindingApiWrapperType) as NetOffice.ExcelApi.MenuItem;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="caption">string Caption</param>
		/// <param name="onAction">optional object OnAction</param>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("Excel", 9,10,11,12,14)]
		public NetOffice.ExcelApi.MenuItem Add(string caption, object onAction)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(caption, onAction);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.ExcelApi.MenuItem newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.MenuItem.LateBindingApiWrapperType) as NetOffice.ExcelApi.MenuItem;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="caption">string Caption</param>
		/// <param name="onAction">optional object OnAction</param>
		/// <param name="shortcutKey">optional object ShortcutKey</param>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("Excel", 9,10,11,12,14)]
		public NetOffice.ExcelApi.MenuItem Add(string caption, object onAction, object shortcutKey)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(caption, onAction, shortcutKey);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.ExcelApi.MenuItem newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.MenuItem.LateBindingApiWrapperType) as NetOffice.ExcelApi.MenuItem;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="caption">string Caption</param>
		/// <param name="onAction">optional object OnAction</param>
		/// <param name="shortcutKey">optional object ShortcutKey</param>
		/// <param name="before">optional object Before</param>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("Excel", 9,10,11,12,14)]
		public NetOffice.ExcelApi.MenuItem Add(string caption, object onAction, object shortcutKey, object before)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(caption, onAction, shortcutKey, before);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.ExcelApi.MenuItem newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.MenuItem.LateBindingApiWrapperType) as NetOffice.ExcelApi.MenuItem;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="caption">string Caption</param>
		/// <param name="onAction">optional object OnAction</param>
		/// <param name="shortcutKey">optional object ShortcutKey</param>
		/// <param name="before">optional object Before</param>
		/// <param name="restore">optional object Restore</param>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("Excel", 9,10,11,12,14)]
		public NetOffice.ExcelApi.MenuItem Add(string caption, object onAction, object shortcutKey, object before, object restore)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(caption, onAction, shortcutKey, before, restore);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.ExcelApi.MenuItem newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.MenuItem.LateBindingApiWrapperType) as NetOffice.ExcelApi.MenuItem;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="caption">string Caption</param>
		/// <param name="onAction">optional object OnAction</param>
		/// <param name="shortcutKey">optional object ShortcutKey</param>
		/// <param name="before">optional object Before</param>
		/// <param name="restore">optional object Restore</param>
		/// <param name="statusBar">optional object StatusBar</param>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("Excel", 9,10,11,12,14)]
		public NetOffice.ExcelApi.MenuItem Add(string caption, object onAction, object shortcutKey, object before, object restore, object statusBar)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(caption, onAction, shortcutKey, before, restore, statusBar);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.ExcelApi.MenuItem newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.MenuItem.LateBindingApiWrapperType) as NetOffice.ExcelApi.MenuItem;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="caption">string Caption</param>
		/// <param name="onAction">optional object OnAction</param>
		/// <param name="shortcutKey">optional object ShortcutKey</param>
		/// <param name="before">optional object Before</param>
		/// <param name="restore">optional object Restore</param>
		/// <param name="statusBar">optional object StatusBar</param>
		/// <param name="helpFile">optional object HelpFile</param>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("Excel", 9,10,11,12,14)]
		public NetOffice.ExcelApi.MenuItem Add(string caption, object onAction, object shortcutKey, object before, object restore, object statusBar, object helpFile)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(caption, onAction, shortcutKey, before, restore, statusBar, helpFile);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.ExcelApi.MenuItem newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.MenuItem.LateBindingApiWrapperType) as NetOffice.ExcelApi.MenuItem;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="caption">string Caption</param>
		/// <param name="before">optional object Before</param>
		/// <param name="restore">optional object Restore</param>
		[SupportByLibraryAttribute("Excel", 9,10,11,12,14)]
		public NetOffice.ExcelApi.Menu AddMenu(string caption, object before, object restore)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(caption, before, restore);
			object returnItem = Invoker.MethodReturn(this, "AddMenu", paramsArray);
			NetOffice.ExcelApi.Menu newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.Menu.LateBindingApiWrapperType) as NetOffice.ExcelApi.Menu;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="caption">string Caption</param>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("Excel", 9,10,11,12,14)]
		public NetOffice.ExcelApi.Menu AddMenu(string caption)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(caption);
			object returnItem = Invoker.MethodReturn(this, "AddMenu", paramsArray);
			NetOffice.ExcelApi.Menu newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.Menu.LateBindingApiWrapperType) as NetOffice.ExcelApi.Menu;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="caption">string Caption</param>
		/// <param name="before">optional object Before</param>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("Excel", 9,10,11,12,14)]
		public NetOffice.ExcelApi.Menu AddMenu(string caption, object before)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(caption, before);
			object returnItem = Invoker.MethodReturn(this, "AddMenu", paramsArray);
			NetOffice.ExcelApi.Menu newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.Menu.LateBindingApiWrapperType) as NetOffice.ExcelApi.Menu;
			return newObject;
		}

		#endregion

        #region IEnumerable<object> Member
		
		/// <summary>
		/// SupportByLibraryAttribute Excel, 9,10,11,12,14
		/// </summary>
		[SupportByLibraryAttribute("Excel", 9,10,11,12,14)]
        public IEnumerator<object> GetEnumerator()  
        {
            NetRuntimeSystem.Collections.IEnumerable innerEnumerator = (this as NetRuntimeSystem.Collections.IEnumerable);
            foreach (object item in innerEnumerator)
                yield return item;
        }

        #endregion
           
        #region IEnumerable Members
        
		/// <summary>
		/// SupportByLibraryAttribute Excel, 9,10,11,12,14
		/// </summary>
		[SupportByLibraryAttribute("Excel", 9,10,11,12,14)]
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