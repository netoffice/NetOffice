//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.AccessApi
{
	///<summary>
	/// DispatchInterface _WizHook SupportByLibrary Access, 9,10,11,12,14
	///</summary>
	[SupportByLibrary("Access", 9,10,11,12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class _WizHook : COMObject
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _WizHook(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _WizHook(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _WizHook(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _WizHook()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary Access 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public Int32 Key
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Key", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Key", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Access 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public NetOffice.VBIDEApi._VBProject DbcVbProject
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DbcVbProject", paramsArray);
				NetOffice.VBIDEApi._VBProject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.VBIDEApi._VBProject;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Access 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="bstrConnectionString">string bstrConnectionString</param>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public bool get_IsMatchToDbcConnectString(string bstrConnectionString)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(bstrConnectionString);
			object returnItem = Invoker.PropertyGet(this, "IsMatchToDbcConnectString", paramsArray);
			return (bool)returnItem;
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary Access 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Actid">Int32 Actid</param>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public string NameFromActid(Int32 actid)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(actid);
			object returnItem = Invoker.MethodReturn(this, "NameFromActid", paramsArray);
			return (string)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Access 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Actid">Int32 Actid</param>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public Int32 ArgsOfActid(Int32 actid)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(actid);
			object returnItem = Invoker.MethodReturn(this, "ArgsOfActid", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Access 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Script">string Script</param>
		/// <param name="Label">string Label</param>
		/// <param name="OpenMode">Int32 OpenMode</param>
		/// <param name="Extra">Int32 Extra</param>
		/// <param name="Version">Int32 Version</param>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public Int32 OpenScript(string script, string label, Int32 openMode, Int32 extra, Int32 version)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(script, label, openMode, extra, version);
			object returnItem = Invoker.MethodReturn(this, "OpenScript", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Access 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="HScr">Int32 HScr</param>
		/// <param name="ScriptColumn">Int32 ScriptColumn</param>
		/// <param name="Value">string Value</param>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public bool GetScriptString(Int32 hScr, Int32 scriptColumn, string value)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(hScr, scriptColumn, value);
			object returnItem = Invoker.MethodReturn(this, "GetScriptString", paramsArray);
			return (bool)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Access 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="HScr">Int32 HScr</param>
		/// <param name="ScriptColumn">Int32 ScriptColumn</param>
		/// <param name="Value">string Value</param>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public bool SaveScriptString(Int32 hScr, Int32 scriptColumn, string value)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(hScr, scriptColumn, value);
			object returnItem = Invoker.MethodReturn(this, "SaveScriptString", paramsArray);
			return (bool)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Access 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Name">string Name</param>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public bool GlobalProcExists(string name)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name);
			object returnItem = Invoker.MethodReturn(this, "GlobalProcExists", paramsArray);
			return (bool)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Access 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Table">string Table</param>
		/// <param name="Columns">string Columns</param>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public bool TableFieldHasUniqueIndex(string table, string columns)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(table, columns);
			object returnItem = Invoker.MethodReturn(this, "TableFieldHasUniqueIndex", paramsArray);
			return (bool)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Access 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="String">string String</param>
		/// <param name="flags">Int32 flags</param>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public bool BracketString(string _string, Int32 flags)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(_string, flags);
			object returnItem = Invoker.MethodReturn(this, "BracketString", paramsArray);
			return (bool)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Access 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="HelpFile">string HelpFile</param>
		/// <param name="wCmd">Int32 wCmd</param>
		/// <param name="ContextID">Int32 ContextID</param>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public bool WizHelp(string helpFile, Int32 wCmd, Int32 contextID)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(helpFile, wCmd, contextID);
			object returnItem = Invoker.MethodReturn(this, "WizHelp", paramsArray);
			return (bool)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Access 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="File">string File</param>
		/// <param name="Cancelled">bool Cancelled</param>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public bool OpenPictureFile(string file, bool cancelled)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(file, cancelled);
			object returnItem = Invoker.MethodReturn(this, "OpenPictureFile", paramsArray);
			return (bool)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Access 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="In">string In</param>
		/// <param name="Out">string Out</param>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public bool EnglishPictToLocal(string _in, string _out)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(_in, _out);
			object returnItem = Invoker.MethodReturn(this, "EnglishPictToLocal", paramsArray);
			return (bool)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Access 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="In">string In</param>
		/// <param name="Out">string Out</param>
		/// <param name="ParseFlags">Int32 ParseFlags</param>
		/// <param name="TranslateFlags">Int32 TranslateFlags</param>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public bool TranslateExpression(string _in, string _out, Int32 parseFlags, Int32 translateFlags)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(_in, _out, parseFlags, translateFlags);
			object returnItem = Invoker.MethodReturn(this, "TranslateExpression", paramsArray);
			return (bool)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Access 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="File">string File</param>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public bool FileExists(string file)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(file);
			object returnItem = Invoker.MethodReturn(this, "FileExists", paramsArray);
			return (bool)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Access 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="RelativePath">string RelativePath</param>
		/// <param name="FullPath">string FullPath</param>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public Int16 FullPath(string relativePath, string fullPath)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(relativePath, fullPath);
			object returnItem = Invoker.MethodReturn(this, "FullPath", paramsArray);
			return (Int16)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Access 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Path">string Path</param>
		/// <param name="Drive">string Drive</param>
		/// <param name="Dir">string Dir</param>
		/// <param name="File">string File</param>
		/// <param name="Ext">string Ext</param>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public void SplitPath(string path, string drive, string dir, string file, string ext)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(path, drive, dir, file, ext);
			Invoker.Method(this, "SplitPath", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Access 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="FontName">string FontName</param>
		/// <param name="Size">Int32 Size</param>
		/// <param name="Weight">Int32 Weight</param>
		/// <param name="Italic">bool Italic</param>
		/// <param name="Underline">bool Underline</param>
		/// <param name="Cch">Int32 Cch</param>
		/// <param name="Caption">string Caption</param>
		/// <param name="MaxWidthCch">Int32 MaxWidthCch</param>
		/// <param name="dx">Int32 dx</param>
		/// <param name="dy">Int32 dy</param>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public bool TwipsFromFont(string fontName, Int32 size, Int32 weight, bool italic, bool underline, Int32 cch, string caption, Int32 maxWidthCch, Int32 dx, Int32 dy)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(fontName, size, weight, italic, underline, cch, caption, maxWidthCch, dx, dy);
			object returnItem = Invoker.MethodReturn(this, "TwipsFromFont", paramsArray);
			return (bool)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Access 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="RecordSource">string RecordSource</param>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public Int16 ObjTypOfRecordSource(string recordSource)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(recordSource);
			object returnItem = Invoker.MethodReturn(this, "ObjTypOfRecordSource", paramsArray);
			return (Int16)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Access 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Identifier">string Identifier</param>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public bool IsValidIdent(string identifier)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(identifier);
			object returnItem = Invoker.MethodReturn(this, "IsValidIdent", paramsArray);
			return (bool)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Access 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Array">String[] Array</param>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public void SortStringArray(String[] array)
		{
			object[] paramsArray = Invoker.ValidateParamsArray((object)array);
			Invoker.Method(this, "SortStringArray", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Access 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Workspace">NetOffice.DAOApi.Workspace Workspace</param>
		/// <param name="Database">NetOffice.DAOApi.Database Database</param>
		/// <param name="Table">string Table</param>
		/// <param name="ReturnDebugInfo">bool ReturnDebugInfo</param>
		/// <param name="Results">string Results</param>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public Int32 AnalyzeTable(NetOffice.DAOApi.Workspace workspace, NetOffice.DAOApi.Database database, string table, bool returnDebugInfo, string results)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(workspace, database, table, returnDebugInfo, results);
			object returnItem = Invoker.MethodReturn(this, "AnalyzeTable", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Access 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Workspace">NetOffice.DAOApi.Workspace Workspace</param>
		/// <param name="Database">NetOffice.DAOApi.Database Database</param>
		/// <param name="Query">string Query</param>
		/// <param name="Results">string Results</param>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public Int32 AnalyzeQuery(NetOffice.DAOApi.Workspace workspace, NetOffice.DAOApi.Database database, string query, string results)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(workspace, database, query, results);
			object returnItem = Invoker.MethodReturn(this, "AnalyzeQuery", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Access 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="hwndOwner">Int32 hwndOwner</param>
		/// <param name="AppName">string AppName</param>
		/// <param name="DlgTitle">string DlgTitle</param>
		/// <param name="OpenTitle">string OpenTitle</param>
		/// <param name="File">string File</param>
		/// <param name="InitialDir">string InitialDir</param>
		/// <param name="Filter">string Filter</param>
		/// <param name="FilterIndex">Int32 FilterIndex</param>
		/// <param name="View">Int32 View</param>
		/// <param name="flags">Int32 flags</param>
		/// <param name="fOpen">bool fOpen</param>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public Int32 GetFileName(Int32 hwndOwner, string appName, string dlgTitle, string openTitle, string file, string initialDir, string filter, Int32 filterIndex, Int32 view, Int32 flags, bool fOpen)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(hwndOwner, appName, dlgTitle, openTitle, file, initialDir, filter, filterIndex, view, flags, fOpen);
			object returnItem = Invoker.MethodReturn(this, "GetFileName", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Access 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="DpName">string DpName</param>
		/// <param name="CtlName">string CtlName</param>
		/// <param name="Typ">Int32 Typ</param>
		/// <param name="Section">string Section</param>
		/// <param name="SectionType">Int32 SectionType</param>
		/// <param name="AppletCode">string AppletCode</param>
		/// <param name="X">Int32 X</param>
		/// <param name="Y">Int32 Y</param>
		/// <param name="dx">Int32 dx</param>
		/// <param name="dy">Int32 dy</param>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public void CreateDataPageControl(string dpName, string ctlName, Int32 typ, string section, Int32 sectionType, string appletCode, Int32 x, Int32 y, Int32 dx, Int32 dy)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(dpName, ctlName, typ, section, sectionType, appletCode, x, y, dx, dy);
			Invoker.Method(this, "CreateDataPageControl", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Access 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="fStart">bool fStart</param>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public void KnownWizLeaks(bool fStart)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(fStart);
			Invoker.Method(this, "KnownWizLeaks", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Access 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="bstrDbName">string bstrDbName</param>
		/// <param name="bstrConnect">string bstrConnect</param>
		/// <param name="bstrPasswd">string bstrPasswd</param>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public bool SetVbaPassword(string bstrDbName, string bstrConnect, string bstrPasswd)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(bstrDbName, bstrConnect, bstrPasswd);
			object returnItem = Invoker.MethodReturn(this, "SetVbaPassword", paramsArray);
			return (bool)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Access 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public string LocalFont()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "LocalFont", paramsArray);
			return (string)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Access 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="bstrName">string bstrName</param>
		/// <param name="objtyp">Int16 objtyp</param>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public void SaveObject(string bstrName, Int16 objtyp)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(bstrName, objtyp);
			Invoker.Method(this, "SaveObject", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Access 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public Int32 CurrentLangID()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "CurrentLangID", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Access 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public Int32 KeyboardLangID()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "KeyboardLangID", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Access 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public string AccessUserDataDir()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "AccessUserDataDir", paramsArray);
			return (string)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Access 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public string OfficeAddInDir()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "OfficeAddInDir", paramsArray);
			return (string)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Access 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="DpName">string DpName</param>
		/// <param name="FileToInsert">string FileToInsert</param>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public string EmbedFileOnDataPage(string dpName, string fileToInsert)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(dpName, fileToInsert);
			object returnItem = Invoker.MethodReturn(this, "EmbedFileOnDataPage", paramsArray);
			return (string)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Access 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="fRptToFile">bool fRptToFile</param>
		/// <param name="bstrFileOut">string bstrFileOut</param>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public void ReportLeaksToFile(bool fRptToFile, string bstrFileOut)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(fRptToFile, bstrFileOut);
			Invoker.Method(this, "ReportLeaksToFile", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Access 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="bstrFilename">string bstrFilename</param>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public void LoadImexSpecSolution(string bstrFilename)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(bstrFilename);
			Invoker.Method(this, "LoadImexSpecSolution", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Access 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="fBlockKeys">bool fBlockKeys</param>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public void SetDpBlockKeyInput(bool fBlockKeys)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(fBlockKeys);
			Invoker.Method(this, "SetDpBlockKeyInput", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Access 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Name">string Name</param>
		/// <param name="ObjType">NetOffice.AccessApi.Enums.AcObjectType ObjType</param>
		/// <param name="Attribs">Int32 Attribs</param>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public bool FirstDbcDataObject(string name, NetOffice.AccessApi.Enums.AcObjectType objType, Int32 attribs)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, objType, attribs);
			object returnItem = Invoker.MethodReturn(this, "FirstDbcDataObject", paramsArray);
			return (bool)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Access 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Access", 9,10,11,12,14)]
		public bool CloseCurrentDatabase()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "CloseCurrentDatabase", paramsArray);
			return (bool)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Access 10, 11, 12, 14
		/// </summary>
		/// <param name="bstrWhich">string bstrWhich</param>
		[SupportByLibrary("Access", 10,11,12,14)]
		public string AccessWizFilePath(string bstrWhich)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(bstrWhich);
			object returnItem = Invoker.MethodReturn(this, "AccessWizFilePath", paramsArray);
			return (string)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Access 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Access", 10,11,12,14)]
		public bool HideDates()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "HideDates", paramsArray);
			return (bool)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Access 10, 11, 12, 14
		/// </summary>
		/// <param name="bstrBase">string bstrBase</param>
		[SupportByLibrary("Access", 10,11,12,14)]
		public string GetColumns(string bstrBase)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(bstrBase);
			object returnItem = Invoker.MethodReturn(this, "GetColumns", paramsArray);
			return (string)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Access 10, 11, 12, 14
		/// </summary>
		/// <param name="bstrExt">string bstrExt</param>
		/// <param name="bstrFilename">string bstrFilename</param>
		[SupportByLibrary("Access", 10,11,12,14)]
		public Int32 GetFileOdso(string bstrExt, string bstrFilename)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(bstrExt, bstrFilename);
			object returnItem = Invoker.MethodReturn(this, "GetFileOdso", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Access 10, 11, 12, 14
		/// </summary>
		/// <param name="bstrBase">string bstrBase</param>
		[SupportByLibrary("Access", 10,11,12,14)]
		public string GetInfoForColumns(string bstrBase)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(bstrBase);
			object returnItem = Invoker.MethodReturn(this, "GetInfoForColumns", paramsArray);
			return (string)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Access 10, 11, 12, 14
		/// </summary>
		/// <param name="hwndOwner">Int32 hwndOwner</param>
		/// <param name="AppName">string AppName</param>
		/// <param name="DlgTitle">string DlgTitle</param>
		/// <param name="OpenTitle">string OpenTitle</param>
		/// <param name="File">string File</param>
		/// <param name="InitialDir">string InitialDir</param>
		/// <param name="Filter">string Filter</param>
		/// <param name="FilterIndex">Int32 FilterIndex</param>
		/// <param name="View">Int32 View</param>
		/// <param name="flags">Int32 flags</param>
		/// <param name="fOpen">bool fOpen</param>
		/// <param name="fFileSystem">object fFileSystem</param>
		[SupportByLibrary("Access", 10,11,12,14)]
		public Int32 GetFileName2(Int32 hwndOwner, string appName, string dlgTitle, string openTitle, string file, string initialDir, string filter, Int32 filterIndex, Int32 view, Int32 flags, bool fOpen, object fFileSystem)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(hwndOwner, appName, dlgTitle, openTitle, file, initialDir, filter, filterIndex, view, flags, fOpen, fFileSystem);
			object returnItem = Invoker.MethodReturn(this, "GetFileName2", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Access 10, 11, 12, 14
		/// </summary>
		/// <param name="fBlockKeys">bool fBlockKeys</param>
		[SupportByLibrary("Access", 10,11,12,14)]
		public bool FGetMSDE(bool fBlockKeys)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(fBlockKeys);
			object returnItem = Invoker.MethodReturn(this, "FGetMSDE", paramsArray);
			return (bool)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Access 10, 11, 12, 14
		/// </summary>
		/// <param name="bstrText">string bstrText</param>
		/// <param name="bstrCaption">string bstrCaption</param>
		/// <param name="wStyle">Int32 wStyle</param>
		/// <param name="idHelpID">Int32 idHelpID</param>
		/// <param name="bstrHelpFileName">string bstrHelpFileName</param>
		[SupportByLibrary("Access", 10,11,12,14)]
		public Int32 WizMsgBox(string bstrText, string bstrCaption, Int32 wStyle, Int32 idHelpID, string bstrHelpFileName)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(bstrText, bstrCaption, wStyle, idHelpID, bstrHelpFileName);
			object returnItem = Invoker.MethodReturn(this, "WizMsgBox", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Access 10, 11, 12, 14
		/// </summary>
		/// <param name="pbstrUID">string pbstrUID</param>
		/// <param name="pbstrPwd">string pbstrPwd</param>
		[SupportByLibrary("Access", 10,11,12,14)]
		public bool AdpUIDPwd(string pbstrUID, string pbstrPwd)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pbstrUID, pbstrPwd);
			object returnItem = Invoker.MethodReturn(this, "AdpUIDPwd", paramsArray);
			return (bool)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Access 10, 11, 12, 14
		/// </summary>
		/// <param name="lWhich">Int32 lWhich</param>
		/// <param name="vValue">object vValue</param>
		[SupportByLibrary("Access", 10,11,12,14)]
		public void SetWizGlob(Int32 lWhich, object vValue)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(lWhich, vValue);
			Invoker.Method(this, "SetWizGlob", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Access 10, 11, 12, 14
		/// </summary>
		/// <param name="lWhich">Int32 lWhich</param>
		[SupportByLibrary("Access", 10,11,12,14)]
		public object GetWizGlob(Int32 lWhich)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(lWhich);
			object returnItem = Invoker.MethodReturn(this, "GetWizGlob", paramsArray);
			Type returnItemType = Invoker.GetObjectType(returnItem);
			if ((null != returnItem) && (true == returnItemType.IsCOMObject))
			{
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem, returnItemType);
				return newObject;
			}
			else
			{
				return  returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Access 10, 11, 12, 14
		/// </summary>
		/// <param name="bstrADPName">string bstrADPName</param>
		[SupportByLibrary("Access", 10,11,12,14)]
		public void WizCopyCmdbars(string bstrADPName)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(bstrADPName);
			Invoker.Method(this, "WizCopyCmdbars", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Access 10, 11, 12, 14
		/// </summary>
		/// <param name="bstrTableName">string bstrTableName</param>
		[SupportByLibrary("Access", 10,11,12,14)]
		public Int32 GetCurrentView(string bstrTableName)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(bstrTableName);
			object returnItem = Invoker.MethodReturn(this, "GetCurrentView", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Access 10, 11, 12, 14
		/// </summary>
		/// <param name="wch">Int32 wch</param>
		[SupportByLibrary("Access", 10,11,12,14)]
		public bool FIsFEWch(Int32 wch)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(wch);
			object returnItem = Invoker.MethodReturn(this, "FIsFEWch", paramsArray);
			return (bool)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Access 11, 12, 14
		/// </summary>
		/// <param name="dispid">Int32 dispid</param>
		[SupportByLibrary("Access", 11,12,14)]
		public bool IsMemberSafe(Int32 dispid)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(dispid);
			object returnItem = Invoker.MethodReturn(this, "IsMemberSafe", paramsArray);
			return (bool)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Access 11, 12, 14
		/// </summary>
		[SupportByLibrary("Access", 11,12,14)]
		public string GetAccWizRCPath()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "GetAccWizRCPath", paramsArray);
			return (string)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Access 11, 12, 14
		/// </summary>
		/// <param name="objtyp">Int16 objtyp</param>
		/// <param name="bstrObjName">string bstrObjName</param>
		[SupportByLibrary("Access", 11,12,14)]
		public bool FCreateNameMap(Int16 objtyp, string bstrObjName)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(objtyp, bstrObjName);
			object returnItem = Invoker.MethodReturn(this, "FCreateNameMap", paramsArray);
			return (bool)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Access 12, 14
		/// </summary>
		[SupportByLibrary("Access", 12,14)]
		public string GetAdeRegistryPath()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "GetAdeRegistryPath", paramsArray);
			return (string)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Access 12, 14
		/// </summary>
		/// <param name="bstrSpecXML">string bstrSpecXML</param>
		[SupportByLibrary("Access", 12,14)]
		public void ExecuteTempImexSpec(string bstrSpecXML)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(bstrSpecXML);
			Invoker.Method(this, "ExecuteTempImexSpec", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Access 12, 14
		/// </summary>
		[SupportByLibrary("Access", 12,14)]
		public bool FCacheStatus()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "FCacheStatus", paramsArray);
			return (bool)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Access 12, 14
		/// </summary>
		/// <param name="bstrStatus">string bstrStatus</param>
		[SupportByLibrary("Access", 12,14)]
		public void CacheStatus(string bstrStatus)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(bstrStatus);
			Invoker.Method(this, "CacheStatus", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Access 12, 14
		/// </summary>
		/// <param name="bstrSpecName">string bstrSpecName</param>
		[SupportByLibrary("Access", 12,14)]
		public void SetDefaultSpecName(string bstrSpecName)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(bstrSpecName);
			Invoker.Method(this, "SetDefaultSpecName", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Access 12, 14
		/// </summary>
		[SupportByLibrary("Access", 12,14)]
		public string GetImexTblName()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "GetImexTblName", paramsArray);
			return (string)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Access 12, 14
		/// </summary>
		/// <param name="bstrTableName">string bstrTableName</param>
		/// <param name="bstrPropertyName">string bstrPropertyName</param>
		/// <param name="fServer">bool fServer</param>
		[SupportByLibrary("Access", 12,14)]
		public string GetLinkedListProperty(string bstrTableName, string bstrPropertyName, bool fServer)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(bstrTableName, bstrPropertyName, fServer);
			object returnItem = Invoker.MethodReturn(this, "GetLinkedListProperty", paramsArray);
			return (string)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Access 12, 14
		/// </summary>
		/// <param name="pProperty">NetOffice.AccessApi._AccessProperty pProperty</param>
		/// <param name="OpenMode">Int32 OpenMode</param>
		/// <param name="Extra">Int32 Extra</param>
		/// <param name="Version">Int32 Version</param>
		[SupportByLibrary("Access", 12,14)]
		public Int32 OpenEmScript(NetOffice.AccessApi._AccessProperty pProperty, Int32 openMode, Int32 extra, Int32 version)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pProperty, openMode, extra, version);
			object returnItem = Invoker.MethodReturn(this, "OpenEmScript", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Access 14
		/// </summary>
		[SupportByLibrary("Access", 14)]
		public string GetDisabledExtensions()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "GetDisabledExtensions", paramsArray);
			return (string)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Access 14
		/// </summary>
		/// <param name="bstrObjectName">string bstrObjectName</param>
		/// <param name="iobjtyp">NetOffice.AccessApi.Enums.AcObjectType iobjtyp</param>
		/// <param name="fTablesAsClient">bool fTablesAsClient</param>
		[SupportByLibrary("Access", 14)]
		public Int32 GetObjPubOption(string bstrObjectName, NetOffice.AccessApi.Enums.AcObjectType iobjtyp, bool fTablesAsClient)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(bstrObjectName, iobjtyp, fTablesAsClient);
			object returnItem = Invoker.MethodReturn(this, "GetObjPubOption", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Access 14
		/// </summary>
		/// <param name="bstrObjectName">string bstrObjectName</param>
		[SupportByLibrary("Access", 14)]
		public bool FIsPublishedXasTable(string bstrObjectName)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(bstrObjectName);
			object returnItem = Invoker.MethodReturn(this, "FIsPublishedXasTable", paramsArray);
			return (bool)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Access 14
		/// </summary>
		[SupportByLibrary("Access", 14)]
		public bool FIsXasDb()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "FIsXasDb", paramsArray);
			return (bool)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Access 14
		/// </summary>
		/// <param name="bstrObjectName">string bstrObjectName</param>
		/// <param name="iobjtyp">NetOffice.AccessApi.Enums.AcObjectType iobjtyp</param>
		[SupportByLibrary("Access", 14)]
		public bool FIsValidXasObjectName(string bstrObjectName, NetOffice.AccessApi.Enums.AcObjectType iobjtyp)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(bstrObjectName, iobjtyp);
			object returnItem = Invoker.MethodReturn(this, "FIsValidXasObjectName", paramsArray);
			return (bool)returnItem;
		}

		#endregion
		#pragma warning restore
	}
}