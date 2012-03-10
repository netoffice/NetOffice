//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using LateBindingApi.Core;
namespace NetOffice.MSComctlLibApi
{

	#region Delegates

	#pragma warning disable
	public delegate void StatusBar_PanelClickEventHandler(NetOffice.MSComctlLibApi.Panel Panel);
	public delegate void StatusBar_PanelDblClickEventHandler(NetOffice.MSComctlLibApi.Panel Panel);
	public delegate void StatusBar_MouseDownEventHandler(Int16 Button, Int16 Shift, Int32 x, Int32 y);
	public delegate void StatusBar_MouseMoveEventHandler(Int16 Button, Int16 Shift, Int32 x, Int32 y);
	public delegate void StatusBar_MouseUpEventHandler(Int16 Button, Int16 Shift, Int32 x, Int32 y);
	public delegate void StatusBar_ClickEventHandler();
	public delegate void StatusBar_DblClickEventHandler();
	public delegate void StatusBar_OLEStartDragEventHandler(ref NetOffice.MSComctlLibApi.DataObject Data, ref Int32 AllowedEffects);
	public delegate void StatusBar_OLEGiveFeedbackEventHandler(ref Int32 Effect, ref bool DefaultCursors);
	public delegate void StatusBar_OLESetDataEventHandler(ref NetOffice.MSComctlLibApi.DataObject Data, ref Int16 DataFormat);
	public delegate void StatusBar_OLECompleteDragEventHandler(ref Int32 Effect);
	public delegate void StatusBar_OLEDragOverEventHandler(ref NetOffice.MSComctlLibApi.DataObject Data, ref Int32 Effect, ref Int16 Button, ref Int16 Shift, ref Single x, ref Single y, ref Int16 State);
	public delegate void StatusBar_OLEDragDropEventHandler(ref NetOffice.MSComctlLibApi.DataObject Data, ref Int32 Effect, ref Int16 Button, ref Int16 Shift, ref Single x, ref Single y);
	#pragma warning restore

	#endregion

	///<summary>
	/// CoClass StatusBar 
	/// SupportByLibrary MSComctlLib, 2
	///</summary>
	[SupportByLibraryAttribute("MSComctlLib", 2)]
	[EntityTypeAttribute(EntityType.IsCoClass)]
	public class StatusBar : IStatusBar, IEventBinding 
	{
		#pragma warning disable
		#region Fields
		
		private NetRuntimeSystem.Runtime.InteropServices.ComTypes.IConnectionPoint _connectPoint;
		private string _activeSinkId;
		private NetRuntimeSystem.Type _thisType;
		IStatusBarEvents_SinkHelper _iStatusBarEvents_SinkHelper;
	
		#endregion

		#region Type Information

        private static Type _type;
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(StatusBar);
                    
                return _type;
            }
        }
        
        #endregion
        		
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
		public StatusBar(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
			
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public StatusBar(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
			
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public StatusBar(COMObject replacedObject) : base(replacedObject)
		{
			
		}
		
		/// <summary>
        /// creates a new instance of StatusBar 
        /// </summary>		
		public StatusBar():base("MSComctlLib.StatusBar")
		{
			
		}
		
		/// <summary>
        /// creates a new instance of StatusBar
        /// </summary>
        /// <param name="progId">registered ProgID</param>
		public StatusBar(string progId):base(progId)
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
				_activeSinkId = SinkHelper.GetConnectionPoint(this, ref _connectPoint, IStatusBarEvents_SinkHelper.Id);


			if(IStatusBarEvents_SinkHelper.Id.Equals(_activeSinkId, StringComparison.InvariantCultureIgnoreCase))
			{
				_iStatusBarEvents_SinkHelper = new IStatusBarEvents_SinkHelper(this, _connectPoint);
				return;
			} 
        }
		
		#endregion

		#region Events

		/// <summary>
		/// SupportByLibrary MSComctlLib, 2
		/// </summary>
		private event StatusBar_PanelClickEventHandler _PanelClickEvent;

		/// <summary>
		/// SupportByLibrary MSComctlLib 2
		/// </summary>
		[SupportByLibrary("MSComctlLib", 2)]
		public event StatusBar_PanelClickEventHandler PanelClickEvent
		{
			add
			{
				CreateEventBridge();
				_PanelClickEvent += value;
			}
			remove
			{
				_PanelClickEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSComctlLib, 2
		/// </summary>
		private event StatusBar_PanelDblClickEventHandler _PanelDblClickEvent;

		/// <summary>
		/// SupportByLibrary MSComctlLib 2
		/// </summary>
		[SupportByLibrary("MSComctlLib", 2)]
		public event StatusBar_PanelDblClickEventHandler PanelDblClickEvent
		{
			add
			{
				CreateEventBridge();
				_PanelDblClickEvent += value;
			}
			remove
			{
				_PanelDblClickEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSComctlLib, 2
		/// </summary>
		private event StatusBar_MouseDownEventHandler _MouseDownEvent;

		/// <summary>
		/// SupportByLibrary MSComctlLib 2
		/// </summary>
		[SupportByLibrary("MSComctlLib", 2)]
		public event StatusBar_MouseDownEventHandler MouseDownEvent
		{
			add
			{
				CreateEventBridge();
				_MouseDownEvent += value;
			}
			remove
			{
				_MouseDownEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSComctlLib, 2
		/// </summary>
		private event StatusBar_MouseMoveEventHandler _MouseMoveEvent;

		/// <summary>
		/// SupportByLibrary MSComctlLib 2
		/// </summary>
		[SupportByLibrary("MSComctlLib", 2)]
		public event StatusBar_MouseMoveEventHandler MouseMoveEvent
		{
			add
			{
				CreateEventBridge();
				_MouseMoveEvent += value;
			}
			remove
			{
				_MouseMoveEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSComctlLib, 2
		/// </summary>
		private event StatusBar_MouseUpEventHandler _MouseUpEvent;

		/// <summary>
		/// SupportByLibrary MSComctlLib 2
		/// </summary>
		[SupportByLibrary("MSComctlLib", 2)]
		public event StatusBar_MouseUpEventHandler MouseUpEvent
		{
			add
			{
				CreateEventBridge();
				_MouseUpEvent += value;
			}
			remove
			{
				_MouseUpEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSComctlLib, 2
		/// </summary>
		private event StatusBar_ClickEventHandler _ClickEvent;

		/// <summary>
		/// SupportByLibrary MSComctlLib 2
		/// </summary>
		[SupportByLibrary("MSComctlLib", 2)]
		public event StatusBar_ClickEventHandler ClickEvent
		{
			add
			{
				CreateEventBridge();
				_ClickEvent += value;
			}
			remove
			{
				_ClickEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSComctlLib, 2
		/// </summary>
		private event StatusBar_DblClickEventHandler _DblClickEvent;

		/// <summary>
		/// SupportByLibrary MSComctlLib 2
		/// </summary>
		[SupportByLibrary("MSComctlLib", 2)]
		public event StatusBar_DblClickEventHandler DblClickEvent
		{
			add
			{
				CreateEventBridge();
				_DblClickEvent += value;
			}
			remove
			{
				_DblClickEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSComctlLib, 2
		/// </summary>
		private event StatusBar_OLEStartDragEventHandler _OLEStartDragEvent;

		/// <summary>
		/// SupportByLibrary MSComctlLib 2
		/// </summary>
		[SupportByLibrary("MSComctlLib", 2)]
		public event StatusBar_OLEStartDragEventHandler OLEStartDragEvent
		{
			add
			{
				CreateEventBridge();
				_OLEStartDragEvent += value;
			}
			remove
			{
				_OLEStartDragEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSComctlLib, 2
		/// </summary>
		private event StatusBar_OLEGiveFeedbackEventHandler _OLEGiveFeedbackEvent;

		/// <summary>
		/// SupportByLibrary MSComctlLib 2
		/// </summary>
		[SupportByLibrary("MSComctlLib", 2)]
		public event StatusBar_OLEGiveFeedbackEventHandler OLEGiveFeedbackEvent
		{
			add
			{
				CreateEventBridge();
				_OLEGiveFeedbackEvent += value;
			}
			remove
			{
				_OLEGiveFeedbackEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSComctlLib, 2
		/// </summary>
		private event StatusBar_OLESetDataEventHandler _OLESetDataEvent;

		/// <summary>
		/// SupportByLibrary MSComctlLib 2
		/// </summary>
		[SupportByLibrary("MSComctlLib", 2)]
		public event StatusBar_OLESetDataEventHandler OLESetDataEvent
		{
			add
			{
				CreateEventBridge();
				_OLESetDataEvent += value;
			}
			remove
			{
				_OLESetDataEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSComctlLib, 2
		/// </summary>
		private event StatusBar_OLECompleteDragEventHandler _OLECompleteDragEvent;

		/// <summary>
		/// SupportByLibrary MSComctlLib 2
		/// </summary>
		[SupportByLibrary("MSComctlLib", 2)]
		public event StatusBar_OLECompleteDragEventHandler OLECompleteDragEvent
		{
			add
			{
				CreateEventBridge();
				_OLECompleteDragEvent += value;
			}
			remove
			{
				_OLECompleteDragEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSComctlLib, 2
		/// </summary>
		private event StatusBar_OLEDragOverEventHandler _OLEDragOverEvent;

		/// <summary>
		/// SupportByLibrary MSComctlLib 2
		/// </summary>
		[SupportByLibrary("MSComctlLib", 2)]
		public event StatusBar_OLEDragOverEventHandler OLEDragOverEvent
		{
			add
			{
				CreateEventBridge();
				_OLEDragOverEvent += value;
			}
			remove
			{
				_OLEDragOverEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSComctlLib, 2
		/// </summary>
		private event StatusBar_OLEDragDropEventHandler _OLEDragDropEvent;

		/// <summary>
		/// SupportByLibrary MSComctlLib 2
		/// </summary>
		[SupportByLibrary("MSComctlLib", 2)]
		public event StatusBar_OLEDragDropEventHandler OLEDragDropEvent
		{
			add
			{
				CreateEventBridge();
				_OLEDragDropEvent += value;
			}
			remove
			{
				_OLEDragDropEvent -= value;
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
			if( null != _iStatusBarEvents_SinkHelper)
			{
				_iStatusBarEvents_SinkHelper.Dispose();
				_iStatusBarEvents_SinkHelper = null;
			}

			_connectPoint = null;
		}
        
        #endregion
		#pragma warning restore
	}
}