//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using LateBindingApi.Core;
namespace NetOffice.MSHTMLApi
{

	#region Delegates

	#pragma warning disable
	public delegate void HTMLLIElement_onhelpEventHandler();
	public delegate void HTMLLIElement_onclickEventHandler();
	public delegate void HTMLLIElement_ondblclickEventHandler();
	public delegate void HTMLLIElement_onkeypressEventHandler();
	public delegate void HTMLLIElement_onkeydownEventHandler();
	public delegate void HTMLLIElement_onkeyupEventHandler();
	public delegate void HTMLLIElement_onmouseoutEventHandler();
	public delegate void HTMLLIElement_onmouseoverEventHandler();
	public delegate void HTMLLIElement_onmousemoveEventHandler();
	public delegate void HTMLLIElement_onmousedownEventHandler();
	public delegate void HTMLLIElement_onmouseupEventHandler();
	public delegate void HTMLLIElement_onselectstartEventHandler();
	public delegate void HTMLLIElement_onfilterchangeEventHandler();
	public delegate void HTMLLIElement_ondragstartEventHandler();
	public delegate void HTMLLIElement_onbeforeupdateEventHandler();
	public delegate void HTMLLIElement_onafterupdateEventHandler();
	public delegate void HTMLLIElement_onerrorupdateEventHandler();
	public delegate void HTMLLIElement_onrowexitEventHandler();
	public delegate void HTMLLIElement_onrowenterEventHandler();
	public delegate void HTMLLIElement_ondatasetchangedEventHandler();
	public delegate void HTMLLIElement_ondataavailableEventHandler();
	public delegate void HTMLLIElement_ondatasetcompleteEventHandler();
	public delegate void HTMLLIElement_onlosecaptureEventHandler();
	public delegate void HTMLLIElement_onpropertychangeEventHandler();
	public delegate void HTMLLIElement_onscrollEventHandler();
	public delegate void HTMLLIElement_onfocusEventHandler();
	public delegate void HTMLLIElement_onblurEventHandler();
	public delegate void HTMLLIElement_onresizeEventHandler();
	public delegate void HTMLLIElement_ondragEventHandler();
	public delegate void HTMLLIElement_ondragendEventHandler();
	public delegate void HTMLLIElement_ondragenterEventHandler();
	public delegate void HTMLLIElement_ondragoverEventHandler();
	public delegate void HTMLLIElement_ondragleaveEventHandler();
	public delegate void HTMLLIElement_ondropEventHandler();
	public delegate void HTMLLIElement_onbeforecutEventHandler();
	public delegate void HTMLLIElement_oncutEventHandler();
	public delegate void HTMLLIElement_onbeforecopyEventHandler();
	public delegate void HTMLLIElement_oncopyEventHandler();
	public delegate void HTMLLIElement_onbeforepasteEventHandler();
	public delegate void HTMLLIElement_onpasteEventHandler();
	public delegate void HTMLLIElement_oncontextmenuEventHandler();
	public delegate void HTMLLIElement_onrowsdeleteEventHandler();
	public delegate void HTMLLIElement_onrowsinsertedEventHandler();
	public delegate void HTMLLIElement_oncellchangeEventHandler();
	public delegate void HTMLLIElement_onreadystatechangeEventHandler();
	public delegate void HTMLLIElement_onbeforeeditfocusEventHandler();
	public delegate void HTMLLIElement_onlayoutcompleteEventHandler();
	public delegate void HTMLLIElement_onpageEventHandler();
	public delegate void HTMLLIElement_onbeforedeactivateEventHandler();
	public delegate void HTMLLIElement_onbeforeactivateEventHandler();
	public delegate void HTMLLIElement_onmoveEventHandler();
	public delegate void HTMLLIElement_oncontrolselectEventHandler();
	public delegate void HTMLLIElement_onmovestartEventHandler();
	public delegate void HTMLLIElement_onmoveendEventHandler();
	public delegate void HTMLLIElement_onresizestartEventHandler();
	public delegate void HTMLLIElement_onresizeendEventHandler();
	public delegate void HTMLLIElement_onmouseenterEventHandler();
	public delegate void HTMLLIElement_onmouseleaveEventHandler();
	public delegate void HTMLLIElement_onmousewheelEventHandler();
	public delegate void HTMLLIElement_onactivateEventHandler();
	public delegate void HTMLLIElement_ondeactivateEventHandler();
	public delegate void HTMLLIElement_onfocusinEventHandler();
	public delegate void HTMLLIElement_onfocusoutEventHandler();
	#pragma warning restore

	#endregion

	///<summary>
	/// CoClass HTMLLIElement 
	/// SupportByLibrary MSHTML, 4
	///</summary>
	[SupportByLibraryAttribute("MSHTML", 4)]
	[EntityTypeAttribute(EntityType.IsCoClass)]
	public class HTMLLIElement : DispHTMLLIElement, IEventBinding 
	{
		#pragma warning disable
		#region Fields
		
		private NetRuntimeSystem.Runtime.InteropServices.ComTypes.IConnectionPoint _connectPoint;
		private string _activeSinkId;
		private NetRuntimeSystem.Type _thisType;
		HTMLElementEvents_SinkHelper _hTMLElementEvents_SinkHelper;
	
		#endregion

		#region Type Information

        private static Type _type;
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(HTMLLIElement);
                    
                return _type;
            }
        }
        
        #endregion
        		
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
		public HTMLLIElement(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
			
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public HTMLLIElement(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
			
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public HTMLLIElement(COMObject replacedObject) : base(replacedObject)
		{
			
		}
		
		/// <summary>
        /// creates a new instance of HTMLLIElement 
        /// </summary>		
		public HTMLLIElement():base("MSHTML.HTMLLIElement")
		{
			
		}
		
		/// <summary>
        /// creates a new instance of HTMLLIElement
        /// </summary>
        /// <param name="progId">registered ProgID</param>
		public HTMLLIElement(string progId):base(progId)
		{
			
		}

		#endregion
		
		#region Private Methods
		
		/// <summary>
        /// creates active sink helper
        /// </summary>
		private void CreateEventBridge()
        {
			if(false == LateBindingApi.Core.Settings.EnableEvents)
				return;
	
			if (null != _connectPoint)
				return;
	
            if (null == _activeSinkId)
				_activeSinkId = SinkHelper.GetConnectionPoint(this, ref _connectPoint, HTMLElementEvents_SinkHelper.Id);


			if(HTMLElementEvents_SinkHelper.Id.Equals(_activeSinkId, StringComparison.InvariantCultureIgnoreCase))
			{
				_hTMLElementEvents_SinkHelper = new HTMLElementEvents_SinkHelper(this, _connectPoint);
				return;
			} 
        }
		
		#endregion

		#region Events

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLLIElement_onhelpEventHandler _onhelpEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLLIElement_onhelpEventHandler onhelpEvent
		{
			add
			{
				CreateEventBridge();
				_onhelpEvent += value;
			}
			remove
			{
				_onhelpEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLLIElement_onclickEventHandler _onclickEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLLIElement_onclickEventHandler onclickEvent
		{
			add
			{
				CreateEventBridge();
				_onclickEvent += value;
			}
			remove
			{
				_onclickEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLLIElement_ondblclickEventHandler _ondblclickEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLLIElement_ondblclickEventHandler ondblclickEvent
		{
			add
			{
				CreateEventBridge();
				_ondblclickEvent += value;
			}
			remove
			{
				_ondblclickEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLLIElement_onkeypressEventHandler _onkeypressEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLLIElement_onkeypressEventHandler onkeypressEvent
		{
			add
			{
				CreateEventBridge();
				_onkeypressEvent += value;
			}
			remove
			{
				_onkeypressEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLLIElement_onkeydownEventHandler _onkeydownEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLLIElement_onkeydownEventHandler onkeydownEvent
		{
			add
			{
				CreateEventBridge();
				_onkeydownEvent += value;
			}
			remove
			{
				_onkeydownEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLLIElement_onkeyupEventHandler _onkeyupEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLLIElement_onkeyupEventHandler onkeyupEvent
		{
			add
			{
				CreateEventBridge();
				_onkeyupEvent += value;
			}
			remove
			{
				_onkeyupEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLLIElement_onmouseoutEventHandler _onmouseoutEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLLIElement_onmouseoutEventHandler onmouseoutEvent
		{
			add
			{
				CreateEventBridge();
				_onmouseoutEvent += value;
			}
			remove
			{
				_onmouseoutEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLLIElement_onmouseoverEventHandler _onmouseoverEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLLIElement_onmouseoverEventHandler onmouseoverEvent
		{
			add
			{
				CreateEventBridge();
				_onmouseoverEvent += value;
			}
			remove
			{
				_onmouseoverEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLLIElement_onmousemoveEventHandler _onmousemoveEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLLIElement_onmousemoveEventHandler onmousemoveEvent
		{
			add
			{
				CreateEventBridge();
				_onmousemoveEvent += value;
			}
			remove
			{
				_onmousemoveEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLLIElement_onmousedownEventHandler _onmousedownEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLLIElement_onmousedownEventHandler onmousedownEvent
		{
			add
			{
				CreateEventBridge();
				_onmousedownEvent += value;
			}
			remove
			{
				_onmousedownEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLLIElement_onmouseupEventHandler _onmouseupEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLLIElement_onmouseupEventHandler onmouseupEvent
		{
			add
			{
				CreateEventBridge();
				_onmouseupEvent += value;
			}
			remove
			{
				_onmouseupEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLLIElement_onselectstartEventHandler _onselectstartEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLLIElement_onselectstartEventHandler onselectstartEvent
		{
			add
			{
				CreateEventBridge();
				_onselectstartEvent += value;
			}
			remove
			{
				_onselectstartEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLLIElement_onfilterchangeEventHandler _onfilterchangeEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLLIElement_onfilterchangeEventHandler onfilterchangeEvent
		{
			add
			{
				CreateEventBridge();
				_onfilterchangeEvent += value;
			}
			remove
			{
				_onfilterchangeEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLLIElement_ondragstartEventHandler _ondragstartEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLLIElement_ondragstartEventHandler ondragstartEvent
		{
			add
			{
				CreateEventBridge();
				_ondragstartEvent += value;
			}
			remove
			{
				_ondragstartEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLLIElement_onbeforeupdateEventHandler _onbeforeupdateEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLLIElement_onbeforeupdateEventHandler onbeforeupdateEvent
		{
			add
			{
				CreateEventBridge();
				_onbeforeupdateEvent += value;
			}
			remove
			{
				_onbeforeupdateEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLLIElement_onafterupdateEventHandler _onafterupdateEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLLIElement_onafterupdateEventHandler onafterupdateEvent
		{
			add
			{
				CreateEventBridge();
				_onafterupdateEvent += value;
			}
			remove
			{
				_onafterupdateEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLLIElement_onerrorupdateEventHandler _onerrorupdateEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLLIElement_onerrorupdateEventHandler onerrorupdateEvent
		{
			add
			{
				CreateEventBridge();
				_onerrorupdateEvent += value;
			}
			remove
			{
				_onerrorupdateEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLLIElement_onrowexitEventHandler _onrowexitEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLLIElement_onrowexitEventHandler onrowexitEvent
		{
			add
			{
				CreateEventBridge();
				_onrowexitEvent += value;
			}
			remove
			{
				_onrowexitEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLLIElement_onrowenterEventHandler _onrowenterEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLLIElement_onrowenterEventHandler onrowenterEvent
		{
			add
			{
				CreateEventBridge();
				_onrowenterEvent += value;
			}
			remove
			{
				_onrowenterEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLLIElement_ondatasetchangedEventHandler _ondatasetchangedEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLLIElement_ondatasetchangedEventHandler ondatasetchangedEvent
		{
			add
			{
				CreateEventBridge();
				_ondatasetchangedEvent += value;
			}
			remove
			{
				_ondatasetchangedEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLLIElement_ondataavailableEventHandler _ondataavailableEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLLIElement_ondataavailableEventHandler ondataavailableEvent
		{
			add
			{
				CreateEventBridge();
				_ondataavailableEvent += value;
			}
			remove
			{
				_ondataavailableEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLLIElement_ondatasetcompleteEventHandler _ondatasetcompleteEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLLIElement_ondatasetcompleteEventHandler ondatasetcompleteEvent
		{
			add
			{
				CreateEventBridge();
				_ondatasetcompleteEvent += value;
			}
			remove
			{
				_ondatasetcompleteEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLLIElement_onlosecaptureEventHandler _onlosecaptureEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLLIElement_onlosecaptureEventHandler onlosecaptureEvent
		{
			add
			{
				CreateEventBridge();
				_onlosecaptureEvent += value;
			}
			remove
			{
				_onlosecaptureEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLLIElement_onpropertychangeEventHandler _onpropertychangeEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLLIElement_onpropertychangeEventHandler onpropertychangeEvent
		{
			add
			{
				CreateEventBridge();
				_onpropertychangeEvent += value;
			}
			remove
			{
				_onpropertychangeEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLLIElement_onscrollEventHandler _onscrollEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLLIElement_onscrollEventHandler onscrollEvent
		{
			add
			{
				CreateEventBridge();
				_onscrollEvent += value;
			}
			remove
			{
				_onscrollEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLLIElement_onfocusEventHandler _onfocusEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLLIElement_onfocusEventHandler onfocusEvent
		{
			add
			{
				CreateEventBridge();
				_onfocusEvent += value;
			}
			remove
			{
				_onfocusEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLLIElement_onblurEventHandler _onblurEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLLIElement_onblurEventHandler onblurEvent
		{
			add
			{
				CreateEventBridge();
				_onblurEvent += value;
			}
			remove
			{
				_onblurEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLLIElement_onresizeEventHandler _onresizeEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLLIElement_onresizeEventHandler onresizeEvent
		{
			add
			{
				CreateEventBridge();
				_onresizeEvent += value;
			}
			remove
			{
				_onresizeEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLLIElement_ondragEventHandler _ondragEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLLIElement_ondragEventHandler ondragEvent
		{
			add
			{
				CreateEventBridge();
				_ondragEvent += value;
			}
			remove
			{
				_ondragEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLLIElement_ondragendEventHandler _ondragendEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLLIElement_ondragendEventHandler ondragendEvent
		{
			add
			{
				CreateEventBridge();
				_ondragendEvent += value;
			}
			remove
			{
				_ondragendEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLLIElement_ondragenterEventHandler _ondragenterEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLLIElement_ondragenterEventHandler ondragenterEvent
		{
			add
			{
				CreateEventBridge();
				_ondragenterEvent += value;
			}
			remove
			{
				_ondragenterEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLLIElement_ondragoverEventHandler _ondragoverEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLLIElement_ondragoverEventHandler ondragoverEvent
		{
			add
			{
				CreateEventBridge();
				_ondragoverEvent += value;
			}
			remove
			{
				_ondragoverEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLLIElement_ondragleaveEventHandler _ondragleaveEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLLIElement_ondragleaveEventHandler ondragleaveEvent
		{
			add
			{
				CreateEventBridge();
				_ondragleaveEvent += value;
			}
			remove
			{
				_ondragleaveEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLLIElement_ondropEventHandler _ondropEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLLIElement_ondropEventHandler ondropEvent
		{
			add
			{
				CreateEventBridge();
				_ondropEvent += value;
			}
			remove
			{
				_ondropEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLLIElement_onbeforecutEventHandler _onbeforecutEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLLIElement_onbeforecutEventHandler onbeforecutEvent
		{
			add
			{
				CreateEventBridge();
				_onbeforecutEvent += value;
			}
			remove
			{
				_onbeforecutEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLLIElement_oncutEventHandler _oncutEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLLIElement_oncutEventHandler oncutEvent
		{
			add
			{
				CreateEventBridge();
				_oncutEvent += value;
			}
			remove
			{
				_oncutEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLLIElement_onbeforecopyEventHandler _onbeforecopyEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLLIElement_onbeforecopyEventHandler onbeforecopyEvent
		{
			add
			{
				CreateEventBridge();
				_onbeforecopyEvent += value;
			}
			remove
			{
				_onbeforecopyEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLLIElement_oncopyEventHandler _oncopyEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLLIElement_oncopyEventHandler oncopyEvent
		{
			add
			{
				CreateEventBridge();
				_oncopyEvent += value;
			}
			remove
			{
				_oncopyEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLLIElement_onbeforepasteEventHandler _onbeforepasteEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLLIElement_onbeforepasteEventHandler onbeforepasteEvent
		{
			add
			{
				CreateEventBridge();
				_onbeforepasteEvent += value;
			}
			remove
			{
				_onbeforepasteEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLLIElement_onpasteEventHandler _onpasteEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLLIElement_onpasteEventHandler onpasteEvent
		{
			add
			{
				CreateEventBridge();
				_onpasteEvent += value;
			}
			remove
			{
				_onpasteEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLLIElement_oncontextmenuEventHandler _oncontextmenuEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLLIElement_oncontextmenuEventHandler oncontextmenuEvent
		{
			add
			{
				CreateEventBridge();
				_oncontextmenuEvent += value;
			}
			remove
			{
				_oncontextmenuEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLLIElement_onrowsdeleteEventHandler _onrowsdeleteEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLLIElement_onrowsdeleteEventHandler onrowsdeleteEvent
		{
			add
			{
				CreateEventBridge();
				_onrowsdeleteEvent += value;
			}
			remove
			{
				_onrowsdeleteEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLLIElement_onrowsinsertedEventHandler _onrowsinsertedEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLLIElement_onrowsinsertedEventHandler onrowsinsertedEvent
		{
			add
			{
				CreateEventBridge();
				_onrowsinsertedEvent += value;
			}
			remove
			{
				_onrowsinsertedEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLLIElement_oncellchangeEventHandler _oncellchangeEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLLIElement_oncellchangeEventHandler oncellchangeEvent
		{
			add
			{
				CreateEventBridge();
				_oncellchangeEvent += value;
			}
			remove
			{
				_oncellchangeEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLLIElement_onreadystatechangeEventHandler _onreadystatechangeEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLLIElement_onreadystatechangeEventHandler onreadystatechangeEvent
		{
			add
			{
				CreateEventBridge();
				_onreadystatechangeEvent += value;
			}
			remove
			{
				_onreadystatechangeEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLLIElement_onbeforeeditfocusEventHandler _onbeforeeditfocusEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLLIElement_onbeforeeditfocusEventHandler onbeforeeditfocusEvent
		{
			add
			{
				CreateEventBridge();
				_onbeforeeditfocusEvent += value;
			}
			remove
			{
				_onbeforeeditfocusEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLLIElement_onlayoutcompleteEventHandler _onlayoutcompleteEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLLIElement_onlayoutcompleteEventHandler onlayoutcompleteEvent
		{
			add
			{
				CreateEventBridge();
				_onlayoutcompleteEvent += value;
			}
			remove
			{
				_onlayoutcompleteEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLLIElement_onpageEventHandler _onpageEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLLIElement_onpageEventHandler onpageEvent
		{
			add
			{
				CreateEventBridge();
				_onpageEvent += value;
			}
			remove
			{
				_onpageEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLLIElement_onbeforedeactivateEventHandler _onbeforedeactivateEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLLIElement_onbeforedeactivateEventHandler onbeforedeactivateEvent
		{
			add
			{
				CreateEventBridge();
				_onbeforedeactivateEvent += value;
			}
			remove
			{
				_onbeforedeactivateEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLLIElement_onbeforeactivateEventHandler _onbeforeactivateEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLLIElement_onbeforeactivateEventHandler onbeforeactivateEvent
		{
			add
			{
				CreateEventBridge();
				_onbeforeactivateEvent += value;
			}
			remove
			{
				_onbeforeactivateEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLLIElement_onmoveEventHandler _onmoveEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLLIElement_onmoveEventHandler onmoveEvent
		{
			add
			{
				CreateEventBridge();
				_onmoveEvent += value;
			}
			remove
			{
				_onmoveEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLLIElement_oncontrolselectEventHandler _oncontrolselectEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLLIElement_oncontrolselectEventHandler oncontrolselectEvent
		{
			add
			{
				CreateEventBridge();
				_oncontrolselectEvent += value;
			}
			remove
			{
				_oncontrolselectEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLLIElement_onmovestartEventHandler _onmovestartEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLLIElement_onmovestartEventHandler onmovestartEvent
		{
			add
			{
				CreateEventBridge();
				_onmovestartEvent += value;
			}
			remove
			{
				_onmovestartEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLLIElement_onmoveendEventHandler _onmoveendEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLLIElement_onmoveendEventHandler onmoveendEvent
		{
			add
			{
				CreateEventBridge();
				_onmoveendEvent += value;
			}
			remove
			{
				_onmoveendEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLLIElement_onresizestartEventHandler _onresizestartEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLLIElement_onresizestartEventHandler onresizestartEvent
		{
			add
			{
				CreateEventBridge();
				_onresizestartEvent += value;
			}
			remove
			{
				_onresizestartEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLLIElement_onresizeendEventHandler _onresizeendEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLLIElement_onresizeendEventHandler onresizeendEvent
		{
			add
			{
				CreateEventBridge();
				_onresizeendEvent += value;
			}
			remove
			{
				_onresizeendEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLLIElement_onmouseenterEventHandler _onmouseenterEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLLIElement_onmouseenterEventHandler onmouseenterEvent
		{
			add
			{
				CreateEventBridge();
				_onmouseenterEvent += value;
			}
			remove
			{
				_onmouseenterEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLLIElement_onmouseleaveEventHandler _onmouseleaveEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLLIElement_onmouseleaveEventHandler onmouseleaveEvent
		{
			add
			{
				CreateEventBridge();
				_onmouseleaveEvent += value;
			}
			remove
			{
				_onmouseleaveEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLLIElement_onmousewheelEventHandler _onmousewheelEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLLIElement_onmousewheelEventHandler onmousewheelEvent
		{
			add
			{
				CreateEventBridge();
				_onmousewheelEvent += value;
			}
			remove
			{
				_onmousewheelEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLLIElement_onactivateEventHandler _onactivateEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLLIElement_onactivateEventHandler onactivateEvent
		{
			add
			{
				CreateEventBridge();
				_onactivateEvent += value;
			}
			remove
			{
				_onactivateEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLLIElement_ondeactivateEventHandler _ondeactivateEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLLIElement_ondeactivateEventHandler ondeactivateEvent
		{
			add
			{
				CreateEventBridge();
				_ondeactivateEvent += value;
			}
			remove
			{
				_ondeactivateEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLLIElement_onfocusinEventHandler _onfocusinEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLLIElement_onfocusinEventHandler onfocusinEvent
		{
			add
			{
				CreateEventBridge();
				_onfocusinEvent += value;
			}
			remove
			{
				_onfocusinEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event HTMLLIElement_onfocusoutEventHandler _onfocusoutEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event HTMLLIElement_onfocusoutEventHandler onfocusoutEvent
		{
			add
			{
				CreateEventBridge();
				_onfocusoutEvent += value;
			}
			remove
			{
				_onfocusoutEvent -= value;
			}
		}

		#endregion

        #region IEventBinding Member
        
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public bool EventBridgeInitialized
        {
            get 
            {
                return (null != _connectPoint);
            }
        }
        
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public bool HasEventRecipients       
        {
			get
			{
				if(null == _thisType)
					_thisType = this.GetType();
					
				foreach (NetRuntimeSystem.Reflection.EventInfo item in _thisType.GetEvents())
				{
					MulticastDelegate eventDelegate = (MulticastDelegate) _thisType.GetType().GetField(item.Name, 
																			NetRuntimeSystem.Reflection.BindingFlags.NonPublic |
																			NetRuntimeSystem.Reflection.BindingFlags.Instance).GetValue(this);
					
					if( (null != eventDelegate) && (eventDelegate.GetInvocationList().Length > 0) )
						return false;
				}
				
				return false;
			}
        }
        
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public Delegate[] GetEventRecipients(string eventName)
        {
			if(null == _thisType)
				_thisType = this.GetType();
             
            MulticastDelegate eventDelegate = (MulticastDelegate)_thisType.GetField(
                                                "_" + eventName + "Event",
                                                NetRuntimeSystem.Reflection.BindingFlags.Instance |
                                                NetRuntimeSystem.Reflection.BindingFlags.NonPublic).GetValue(this);

            if (null != eventDelegate)
            {
                Delegate[] delegates = eventDelegate.GetInvocationList();
                return delegates;
            }
            else
                return new Delegate[0];
        }

        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public void DisposeSinkHelper()
        {
			if( null != _hTMLElementEvents_SinkHelper)
			{
				_hTMLElementEvents_SinkHelper.Dispose();
				_hTMLElementEvents_SinkHelper = null;
			}

			_connectPoint = null;
		}
        
        #endregion
		#pragma warning restore
	}
}