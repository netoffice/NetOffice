//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using LateBindingApi.Core;
namespace NetOffice.MSComctlLibApi
{

	#region Delegates

	#pragma warning disable
	public delegate void ListView_BeforeLabelEditEventHandler(ref Int16 Cancel);
	public delegate void ListView_AfterLabelEditEventHandler(ref Int16 Cancel, ref string NewString);
	public delegate void ListView_ColumnClickEventHandler(NetOffice.MSComctlLibApi.ColumnHeader ColumnHeader);
	public delegate void ListView_ItemClickEventHandler(NetOffice.MSComctlLibApi.ListItem Item);
	public delegate void ListView_KeyDownEventHandler(ref Int16 KeyCode, Int16 Shift);
	public delegate void ListView_KeyUpEventHandler(ref Int16 KeyCode, Int16 Shift);
	public delegate void ListView_KeyPressEventHandler(ref Int16 KeyAscii);
	public delegate void ListView_MouseDownEventHandler(Int16 Button, Int16 Shift, Int32 x, Int32 y);
	public delegate void ListView_MouseMoveEventHandler(Int16 Button, Int16 Shift, Int32 x, Int32 y);
	public delegate void ListView_MouseUpEventHandler(Int16 Button, Int16 Shift, Int32 x, Int32 y);
	public delegate void ListView_ClickEventHandler();
	public delegate void ListView_DblClickEventHandler();
	public delegate void ListView_OLEStartDragEventHandler(ref NetOffice.MSComctlLibApi.DataObject Data, ref Int32 AllowedEffects);
	public delegate void ListView_OLEGiveFeedbackEventHandler(ref Int32 Effect, ref bool DefaultCursors);
	public delegate void ListView_OLESetDataEventHandler(ref NetOffice.MSComctlLibApi.DataObject Data, ref Int16 DataFormat);
	public delegate void ListView_OLECompleteDragEventHandler(ref Int32 Effect);
	public delegate void ListView_OLEDragOverEventHandler(ref NetOffice.MSComctlLibApi.DataObject Data, ref Int32 Effect, ref Int16 Button, ref Int16 Shift, ref Single x, ref Single y, ref Int16 State);
	public delegate void ListView_OLEDragDropEventHandler(ref NetOffice.MSComctlLibApi.DataObject Data, ref Int32 Effect, ref Int16 Button, ref Int16 Shift, ref Single x, ref Single y);
	public delegate void ListView_ItemCheckEventHandler(NetOffice.MSComctlLibApi.ListItem Item);
	#pragma warning restore

	#endregion

	///<summary>
	/// CoClass ListView 
	/// SupportByLibrary MSComctlLib, 2
	///</summary>
	[SupportByLibraryAttribute("MSComctlLib", 2)]
	[EntityTypeAttribute(EntityType.IsCoClass)]
	public class ListView : IListView, IEventBinding 
	{
		#pragma warning disable
		#region Fields
		
		private NetRuntimeSystem.Runtime.InteropServices.ComTypes.IConnectionPoint _connectPoint;
		private string _activeSinkId;
		private NetRuntimeSystem.Type _thisType;
		ListViewEvents_SinkHelper _listViewEvents_SinkHelper;
	
		#endregion

		#region Type Information

        private static Type _type;
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(ListView);
                    
                return _type;
            }
        }
        
        #endregion
        		
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
		public ListView(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
			
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ListView(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
			
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ListView(COMObject replacedObject) : base(replacedObject)
		{
			
		}
		
		/// <summary>
        /// creates a new instance of ListView 
        /// </summary>		
		public ListView():base("MSComctlLib.ListView")
		{
			
		}
		
		/// <summary>
        /// creates a new instance of ListView
        /// </summary>
        /// <param name="progId">registered ProgID</param>
		public ListView(string progId):base(progId)
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
				_activeSinkId = SinkHelper.GetConnectionPoint(this, ref _connectPoint, ListViewEvents_SinkHelper.Id);


			if(ListViewEvents_SinkHelper.Id.Equals(_activeSinkId, StringComparison.InvariantCultureIgnoreCase))
			{
				_listViewEvents_SinkHelper = new ListViewEvents_SinkHelper(this, _connectPoint);
				return;
			} 
        }
		
		#endregion

		#region Events

		/// <summary>
		/// SupportByLibrary MSComctlLib, 2
		/// </summary>
		private event ListView_BeforeLabelEditEventHandler _BeforeLabelEditEvent;

		/// <summary>
		/// SupportByLibrary MSComctlLib 2
		/// </summary>
		[SupportByLibrary("MSComctlLib", 2)]
		public event ListView_BeforeLabelEditEventHandler BeforeLabelEditEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeLabelEditEvent += value;
			}
			remove
			{
				_BeforeLabelEditEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSComctlLib, 2
		/// </summary>
		private event ListView_AfterLabelEditEventHandler _AfterLabelEditEvent;

		/// <summary>
		/// SupportByLibrary MSComctlLib 2
		/// </summary>
		[SupportByLibrary("MSComctlLib", 2)]
		public event ListView_AfterLabelEditEventHandler AfterLabelEditEvent
		{
			add
			{
				CreateEventBridge();
				_AfterLabelEditEvent += value;
			}
			remove
			{
				_AfterLabelEditEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSComctlLib, 2
		/// </summary>
		private event ListView_ColumnClickEventHandler _ColumnClickEvent;

		/// <summary>
		/// SupportByLibrary MSComctlLib 2
		/// </summary>
		[SupportByLibrary("MSComctlLib", 2)]
		public event ListView_ColumnClickEventHandler ColumnClickEvent
		{
			add
			{
				CreateEventBridge();
				_ColumnClickEvent += value;
			}
			remove
			{
				_ColumnClickEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSComctlLib, 2
		/// </summary>
		private event ListView_ItemClickEventHandler _ItemClickEvent;

		/// <summary>
		/// SupportByLibrary MSComctlLib 2
		/// </summary>
		[SupportByLibrary("MSComctlLib", 2)]
		public event ListView_ItemClickEventHandler ItemClickEvent
		{
			add
			{
				CreateEventBridge();
				_ItemClickEvent += value;
			}
			remove
			{
				_ItemClickEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSComctlLib, 2
		/// </summary>
		private event ListView_KeyDownEventHandler _KeyDownEvent;

		/// <summary>
		/// SupportByLibrary MSComctlLib 2
		/// </summary>
		[SupportByLibrary("MSComctlLib", 2)]
		public event ListView_KeyDownEventHandler KeyDownEvent
		{
			add
			{
				CreateEventBridge();
				_KeyDownEvent += value;
			}
			remove
			{
				_KeyDownEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSComctlLib, 2
		/// </summary>
		private event ListView_KeyUpEventHandler _KeyUpEvent;

		/// <summary>
		/// SupportByLibrary MSComctlLib 2
		/// </summary>
		[SupportByLibrary("MSComctlLib", 2)]
		public event ListView_KeyUpEventHandler KeyUpEvent
		{
			add
			{
				CreateEventBridge();
				_KeyUpEvent += value;
			}
			remove
			{
				_KeyUpEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSComctlLib, 2
		/// </summary>
		private event ListView_KeyPressEventHandler _KeyPressEvent;

		/// <summary>
		/// SupportByLibrary MSComctlLib 2
		/// </summary>
		[SupportByLibrary("MSComctlLib", 2)]
		public event ListView_KeyPressEventHandler KeyPressEvent
		{
			add
			{
				CreateEventBridge();
				_KeyPressEvent += value;
			}
			remove
			{
				_KeyPressEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSComctlLib, 2
		/// </summary>
		private event ListView_MouseDownEventHandler _MouseDownEvent;

		/// <summary>
		/// SupportByLibrary MSComctlLib 2
		/// </summary>
		[SupportByLibrary("MSComctlLib", 2)]
		public event ListView_MouseDownEventHandler MouseDownEvent
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
		private event ListView_MouseMoveEventHandler _MouseMoveEvent;

		/// <summary>
		/// SupportByLibrary MSComctlLib 2
		/// </summary>
		[SupportByLibrary("MSComctlLib", 2)]
		public event ListView_MouseMoveEventHandler MouseMoveEvent
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
		private event ListView_MouseUpEventHandler _MouseUpEvent;

		/// <summary>
		/// SupportByLibrary MSComctlLib 2
		/// </summary>
		[SupportByLibrary("MSComctlLib", 2)]
		public event ListView_MouseUpEventHandler MouseUpEvent
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
		private event ListView_ClickEventHandler _ClickEvent;

		/// <summary>
		/// SupportByLibrary MSComctlLib 2
		/// </summary>
		[SupportByLibrary("MSComctlLib", 2)]
		public event ListView_ClickEventHandler ClickEvent
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
		private event ListView_DblClickEventHandler _DblClickEvent;

		/// <summary>
		/// SupportByLibrary MSComctlLib 2
		/// </summary>
		[SupportByLibrary("MSComctlLib", 2)]
		public event ListView_DblClickEventHandler DblClickEvent
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
		private event ListView_OLEStartDragEventHandler _OLEStartDragEvent;

		/// <summary>
		/// SupportByLibrary MSComctlLib 2
		/// </summary>
		[SupportByLibrary("MSComctlLib", 2)]
		public event ListView_OLEStartDragEventHandler OLEStartDragEvent
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
		private event ListView_OLEGiveFeedbackEventHandler _OLEGiveFeedbackEvent;

		/// <summary>
		/// SupportByLibrary MSComctlLib 2
		/// </summary>
		[SupportByLibrary("MSComctlLib", 2)]
		public event ListView_OLEGiveFeedbackEventHandler OLEGiveFeedbackEvent
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
		private event ListView_OLESetDataEventHandler _OLESetDataEvent;

		/// <summary>
		/// SupportByLibrary MSComctlLib 2
		/// </summary>
		[SupportByLibrary("MSComctlLib", 2)]
		public event ListView_OLESetDataEventHandler OLESetDataEvent
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
		private event ListView_OLECompleteDragEventHandler _OLECompleteDragEvent;

		/// <summary>
		/// SupportByLibrary MSComctlLib 2
		/// </summary>
		[SupportByLibrary("MSComctlLib", 2)]
		public event ListView_OLECompleteDragEventHandler OLECompleteDragEvent
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
		private event ListView_OLEDragOverEventHandler _OLEDragOverEvent;

		/// <summary>
		/// SupportByLibrary MSComctlLib 2
		/// </summary>
		[SupportByLibrary("MSComctlLib", 2)]
		public event ListView_OLEDragOverEventHandler OLEDragOverEvent
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
		private event ListView_OLEDragDropEventHandler _OLEDragDropEvent;

		/// <summary>
		/// SupportByLibrary MSComctlLib 2
		/// </summary>
		[SupportByLibrary("MSComctlLib", 2)]
		public event ListView_OLEDragDropEventHandler OLEDragDropEvent
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

		/// <summary>
		/// SupportByLibrary MSComctlLib, 2
		/// </summary>
		private event ListView_ItemCheckEventHandler _ItemCheckEvent;

		/// <summary>
		/// SupportByLibrary MSComctlLib 2
		/// </summary>
		[SupportByLibrary("MSComctlLib", 2)]
		public event ListView_ItemCheckEventHandler ItemCheckEvent
		{
			add
			{
				CreateEventBridge();
				_ItemCheckEvent += value;
			}
			remove
			{
				_ItemCheckEvent -= value;
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
			if( null != _listViewEvents_SinkHelper)
			{
				_listViewEvents_SinkHelper.Dispose();
				_listViewEvents_SinkHelper = null;
			}

			_connectPoint = null;
		}
        
        #endregion
		#pragma warning restore
	}
}