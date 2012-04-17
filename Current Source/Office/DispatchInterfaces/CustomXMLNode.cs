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
	/// DispatchInterface CustomXMLNode 
	/// SupportByVersion Office, 12,14
	///</summary>
	[SupportByVersionAttribute("Office", 12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class CustomXMLNode : _IMsoDispObj
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
                    _type = typeof(CustomXMLNode);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public CustomXMLNode(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public CustomXMLNode(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public CustomXMLNode(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public CustomXMLNode() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public CustomXMLNode(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion Office 12, 14
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		[SupportByVersionAttribute("Office", 12,14)]
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
		/// SupportByVersion Office 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Office", 12,14)]
		public NetOffice.OfficeApi.CustomXMLNodes Attributes
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Attributes", paramsArray);
				NetOffice.OfficeApi.CustomXMLNodes newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OfficeApi.CustomXMLNodes.LateBindingApiWrapperType) as NetOffice.OfficeApi.CustomXMLNodes;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Office 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Office", 12,14)]
		public string BaseName
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "BaseName", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Office 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Office", 12,14)]
		public NetOffice.OfficeApi.CustomXMLNodes ChildNodes
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ChildNodes", paramsArray);
				NetOffice.OfficeApi.CustomXMLNodes newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OfficeApi.CustomXMLNodes.LateBindingApiWrapperType) as NetOffice.OfficeApi.CustomXMLNodes;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Office 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Office", 12,14)]
		public NetOffice.OfficeApi.CustomXMLNode FirstChild
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "FirstChild", paramsArray);
				NetOffice.OfficeApi.CustomXMLNode newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OfficeApi.CustomXMLNode.LateBindingApiWrapperType) as NetOffice.OfficeApi.CustomXMLNode;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Office 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Office", 12,14)]
		public NetOffice.OfficeApi.CustomXMLNode LastChild
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "LastChild", paramsArray);
				NetOffice.OfficeApi.CustomXMLNode newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OfficeApi.CustomXMLNode.LateBindingApiWrapperType) as NetOffice.OfficeApi.CustomXMLNode;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Office 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Office", 12,14)]
		public string NamespaceURI
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "NamespaceURI", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Office 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Office", 12,14)]
		public NetOffice.OfficeApi.CustomXMLNode NextSibling
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "NextSibling", paramsArray);
				NetOffice.OfficeApi.CustomXMLNode newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OfficeApi.CustomXMLNode.LateBindingApiWrapperType) as NetOffice.OfficeApi.CustomXMLNode;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Office 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Office", 12,14)]
		public NetOffice.OfficeApi.Enums.MsoCustomXMLNodeType NodeType
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "NodeType", paramsArray);
				int intReturnItem = NetRuntimeSystem.Convert.ToInt32(returnItem);
				return (NetOffice.OfficeApi.Enums.MsoCustomXMLNodeType)intReturnItem;
			}
		}

		/// <summary>
		/// SupportByVersion Office 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Office", 12,14)]
		public string NodeValue
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "NodeValue", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "NodeValue", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Office 12, 14
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		[SupportByVersionAttribute("Office", 12,14)]
		public object OwnerDocument
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "OwnerDocument", paramsArray);
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Office 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Office", 12,14)]
		public NetOffice.OfficeApi.CustomXMLPart OwnerPart
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "OwnerPart", paramsArray);
				NetOffice.OfficeApi.CustomXMLPart newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OfficeApi.CustomXMLPart.LateBindingApiWrapperType) as NetOffice.OfficeApi.CustomXMLPart;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Office 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Office", 12,14)]
		public NetOffice.OfficeApi.CustomXMLNode PreviousSibling
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "PreviousSibling", paramsArray);
				NetOffice.OfficeApi.CustomXMLNode newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OfficeApi.CustomXMLNode.LateBindingApiWrapperType) as NetOffice.OfficeApi.CustomXMLNode;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Office 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Office", 12,14)]
		public NetOffice.OfficeApi.CustomXMLNode ParentNode
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ParentNode", paramsArray);
				NetOffice.OfficeApi.CustomXMLNode newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OfficeApi.CustomXMLNode.LateBindingApiWrapperType) as NetOffice.OfficeApi.CustomXMLNode;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Office 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Office", 12,14)]
		public string Text
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Text", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Text", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Office 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Office", 12,14)]
		public string XPath
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "XPath", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Office 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Office", 12,14)]
		public string XML
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "XML", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion Office 12, 14
		/// </summary>
		/// <param name="name">optional string Name = </param>
		/// <param name="namespaceURI">optional string NamespaceURI = </param>
		/// <param name="nodeType">optional NetOffice.OfficeApi.Enums.MsoCustomXMLNodeType NodeType = 1</param>
		/// <param name="nodeValue">optional string NodeValue = </param>
		[SupportByVersionAttribute("Office", 12,14)]
		public void AppendChildNode(string name, string namespaceURI, NetOffice.OfficeApi.Enums.MsoCustomXMLNodeType nodeType, string nodeValue)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, namespaceURI, nodeType, nodeValue);
			Invoker.Method(this, "AppendChildNode", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Office 12, 14
		/// </summary>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Office", 12,14)]
		public void AppendChildNode()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "AppendChildNode", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Office 12, 14
		/// </summary>
		/// <param name="name">optional string Name = </param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Office", 12,14)]
		public void AppendChildNode(string name)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name);
			Invoker.Method(this, "AppendChildNode", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Office 12, 14
		/// </summary>
		/// <param name="name">optional string Name = </param>
		/// <param name="namespaceURI">optional string NamespaceURI = </param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Office", 12,14)]
		public void AppendChildNode(string name, string namespaceURI)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, namespaceURI);
			Invoker.Method(this, "AppendChildNode", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Office 12, 14
		/// </summary>
		/// <param name="name">optional string Name = </param>
		/// <param name="namespaceURI">optional string NamespaceURI = </param>
		/// <param name="nodeType">optional NetOffice.OfficeApi.Enums.MsoCustomXMLNodeType NodeType = 1</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Office", 12,14)]
		public void AppendChildNode(string name, string namespaceURI, NetOffice.OfficeApi.Enums.MsoCustomXMLNodeType nodeType)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, namespaceURI, nodeType);
			Invoker.Method(this, "AppendChildNode", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Office 12, 14
		/// </summary>
		/// <param name="xML">string XML</param>
		[SupportByVersionAttribute("Office", 12,14)]
		public void AppendChildSubtree(string xML)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(xML);
			Invoker.Method(this, "AppendChildSubtree", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Office 12, 14
		/// </summary>
		[SupportByVersionAttribute("Office", 12,14)]
		public void Delete()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Delete", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Office 12, 14
		/// </summary>
		[SupportByVersionAttribute("Office", 12,14)]
		public bool HasChildNodes()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "HasChildNodes", paramsArray);
			return (bool)returnItem;
		}

		/// <summary>
		/// SupportByVersion Office 12, 14
		/// </summary>
		/// <param name="name">optional string Name = </param>
		/// <param name="namespaceURI">optional string NamespaceURI = </param>
		/// <param name="nodeType">optional NetOffice.OfficeApi.Enums.MsoCustomXMLNodeType NodeType = 1</param>
		/// <param name="nodeValue">optional string NodeValue = </param>
		/// <param name="nextSibling">optional NetOffice.OfficeApi.CustomXMLNode NextSibling = 0</param>
		[SupportByVersionAttribute("Office", 12,14)]
		public void InsertNodeBefore(string name, string namespaceURI, NetOffice.OfficeApi.Enums.MsoCustomXMLNodeType nodeType, string nodeValue, NetOffice.OfficeApi.CustomXMLNode nextSibling)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, namespaceURI, nodeType, nodeValue, nextSibling);
			Invoker.Method(this, "InsertNodeBefore", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Office 12, 14
		/// </summary>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Office", 12,14)]
		public void InsertNodeBefore()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "InsertNodeBefore", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Office 12, 14
		/// </summary>
		/// <param name="name">optional string Name = </param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Office", 12,14)]
		public void InsertNodeBefore(string name)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name);
			Invoker.Method(this, "InsertNodeBefore", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Office 12, 14
		/// </summary>
		/// <param name="name">optional string Name = </param>
		/// <param name="namespaceURI">optional string NamespaceURI = </param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Office", 12,14)]
		public void InsertNodeBefore(string name, string namespaceURI)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, namespaceURI);
			Invoker.Method(this, "InsertNodeBefore", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Office 12, 14
		/// </summary>
		/// <param name="name">optional string Name = </param>
		/// <param name="namespaceURI">optional string NamespaceURI = </param>
		/// <param name="nodeType">optional NetOffice.OfficeApi.Enums.MsoCustomXMLNodeType NodeType = 1</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Office", 12,14)]
		public void InsertNodeBefore(string name, string namespaceURI, NetOffice.OfficeApi.Enums.MsoCustomXMLNodeType nodeType)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, namespaceURI, nodeType);
			Invoker.Method(this, "InsertNodeBefore", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Office 12, 14
		/// </summary>
		/// <param name="name">optional string Name = </param>
		/// <param name="namespaceURI">optional string NamespaceURI = </param>
		/// <param name="nodeType">optional NetOffice.OfficeApi.Enums.MsoCustomXMLNodeType NodeType = 1</param>
		/// <param name="nodeValue">optional string NodeValue = </param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Office", 12,14)]
		public void InsertNodeBefore(string name, string namespaceURI, NetOffice.OfficeApi.Enums.MsoCustomXMLNodeType nodeType, string nodeValue)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, namespaceURI, nodeType, nodeValue);
			Invoker.Method(this, "InsertNodeBefore", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Office 12, 14
		/// </summary>
		/// <param name="xML">string XML</param>
		/// <param name="nextSibling">optional NetOffice.OfficeApi.CustomXMLNode NextSibling = 0</param>
		[SupportByVersionAttribute("Office", 12,14)]
		public void InsertSubtreeBefore(string xML, NetOffice.OfficeApi.CustomXMLNode nextSibling)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(xML, nextSibling);
			Invoker.Method(this, "InsertSubtreeBefore", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Office 12, 14
		/// </summary>
		/// <param name="xML">string XML</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Office", 12,14)]
		public void InsertSubtreeBefore(string xML)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(xML);
			Invoker.Method(this, "InsertSubtreeBefore", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Office 12, 14
		/// </summary>
		/// <param name="child">NetOffice.OfficeApi.CustomXMLNode Child</param>
		[SupportByVersionAttribute("Office", 12,14)]
		public void RemoveChild(NetOffice.OfficeApi.CustomXMLNode child)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(child);
			Invoker.Method(this, "RemoveChild", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Office 12, 14
		/// </summary>
		/// <param name="oldNode">NetOffice.OfficeApi.CustomXMLNode OldNode</param>
		/// <param name="name">optional string Name = </param>
		/// <param name="namespaceURI">optional string NamespaceURI = </param>
		/// <param name="nodeType">optional NetOffice.OfficeApi.Enums.MsoCustomXMLNodeType NodeType = 1</param>
		/// <param name="nodeValue">optional string NodeValue = </param>
		[SupportByVersionAttribute("Office", 12,14)]
		public void ReplaceChildNode(NetOffice.OfficeApi.CustomXMLNode oldNode, string name, string namespaceURI, NetOffice.OfficeApi.Enums.MsoCustomXMLNodeType nodeType, string nodeValue)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(oldNode, name, namespaceURI, nodeType, nodeValue);
			Invoker.Method(this, "ReplaceChildNode", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Office 12, 14
		/// </summary>
		/// <param name="oldNode">NetOffice.OfficeApi.CustomXMLNode OldNode</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Office", 12,14)]
		public void ReplaceChildNode(NetOffice.OfficeApi.CustomXMLNode oldNode)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(oldNode);
			Invoker.Method(this, "ReplaceChildNode", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Office 12, 14
		/// </summary>
		/// <param name="oldNode">NetOffice.OfficeApi.CustomXMLNode OldNode</param>
		/// <param name="name">optional string Name = </param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Office", 12,14)]
		public void ReplaceChildNode(NetOffice.OfficeApi.CustomXMLNode oldNode, string name)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(oldNode, name);
			Invoker.Method(this, "ReplaceChildNode", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Office 12, 14
		/// </summary>
		/// <param name="oldNode">NetOffice.OfficeApi.CustomXMLNode OldNode</param>
		/// <param name="name">optional string Name = </param>
		/// <param name="namespaceURI">optional string NamespaceURI = </param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Office", 12,14)]
		public void ReplaceChildNode(NetOffice.OfficeApi.CustomXMLNode oldNode, string name, string namespaceURI)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(oldNode, name, namespaceURI);
			Invoker.Method(this, "ReplaceChildNode", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Office 12, 14
		/// </summary>
		/// <param name="oldNode">NetOffice.OfficeApi.CustomXMLNode OldNode</param>
		/// <param name="name">optional string Name = </param>
		/// <param name="namespaceURI">optional string NamespaceURI = </param>
		/// <param name="nodeType">optional NetOffice.OfficeApi.Enums.MsoCustomXMLNodeType NodeType = 1</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Office", 12,14)]
		public void ReplaceChildNode(NetOffice.OfficeApi.CustomXMLNode oldNode, string name, string namespaceURI, NetOffice.OfficeApi.Enums.MsoCustomXMLNodeType nodeType)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(oldNode, name, namespaceURI, nodeType);
			Invoker.Method(this, "ReplaceChildNode", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Office 12, 14
		/// </summary>
		/// <param name="xML">string XML</param>
		/// <param name="oldNode">NetOffice.OfficeApi.CustomXMLNode OldNode</param>
		[SupportByVersionAttribute("Office", 12,14)]
		public void ReplaceChildSubtree(string xML, NetOffice.OfficeApi.CustomXMLNode oldNode)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(xML, oldNode);
			Invoker.Method(this, "ReplaceChildSubtree", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Office 12, 14
		/// </summary>
		/// <param name="xPath">string XPath</param>
		[SupportByVersionAttribute("Office", 12,14)]
		public NetOffice.OfficeApi.CustomXMLNodes SelectNodes(string xPath)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(xPath);
			object returnItem = Invoker.MethodReturn(this, "SelectNodes", paramsArray);
			NetOffice.OfficeApi.CustomXMLNodes newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OfficeApi.CustomXMLNodes.LateBindingApiWrapperType) as NetOffice.OfficeApi.CustomXMLNodes;
			return newObject;
		}

		/// <summary>
		/// SupportByVersion Office 12, 14
		/// </summary>
		/// <param name="xPath">string XPath</param>
		[SupportByVersionAttribute("Office", 12,14)]
		public NetOffice.OfficeApi.CustomXMLNode SelectSingleNode(string xPath)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(xPath);
			object returnItem = Invoker.MethodReturn(this, "SelectSingleNode", paramsArray);
			NetOffice.OfficeApi.CustomXMLNode newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OfficeApi.CustomXMLNode.LateBindingApiWrapperType) as NetOffice.OfficeApi.CustomXMLNode;
			return newObject;
		}

		#endregion
		#pragma warning restore
	}
}