using Ndapi.Core;
using Ndapi.Core.Handles;
using Ndapi.Enums;

namespace Ndapi;

/// <summary>
/// Represents an editor object.
/// </summary>
public partial class Event : NdapiObject<Event>
{
    /// <summary>
    /// Creates an editor.
    /// </summary>
    /// <param name="module">Editor owner.</param>
    /// <param name="name">Editor name.</param>
    public Event(FormModule module, string name) : base(name, ObjectType.Event, module)
    {
    }

    /// <summary>
    /// Creates an editor.
    /// </summary>
    /// <param name="group">Editor owner.</param>
    /// <param name="name">Editor name.</param>
    public Event(ObjectGroup group, string name) : base(name, ObjectType.Event, group)
    {
    }

    internal Event(ObjectSafeHandle handle) : base(handle, ObjectType.Event)
    {
    }

    /// <summary>
    /// Gets or sets the comment.
    /// </summary>
    [Property(NdapiConstant.D2FP_COMMENT)]
    public partial string Comment { get; set; }

    /// <summary>
    /// Gets or sets the block name that will be monitored by a Query Result Change Notification (QRCN) event object.
    /// </summary>
    [Property(NdapiConstant.D2FP_EVENT_BLKNAME)]
    public partial string EventBlockName { get; set; }

    /// <summary>
    /// Gets or sets the correlation id.
    /// </summary>
    [Property(NdapiConstant.D2FP_EVENT_CORRID)]
    public partial string CorrelationId { get; set; }

    /// <summary>
    /// Gets or sets the Database Event Type for the event object.
    /// </summary>
    [Property(NdapiConstant.D2FP_EVENT_DB_SUB_TYPE)]
    public partial DatabaseEventType DatabaseEventType { get; set; }

    /// <summary>
    /// Gets or sets the database object (e.g. table or view) to be monitored by an OCN event object.
    /// </summary>
    [Property(NdapiConstant.D2FP_EVENT_DBOBJNAME)]
    public partial string DatabaseObjectName { get; set; }

    /// <summary>
    /// Gets or sets whether the event is enabled.
    /// </summary>
    [Property(NdapiConstant.D2FP_EVENT_ENABLED)]
    public partial bool IsEnabled { get; set; }

    /// <summary>
    /// Gets or sets whether the event object should notify when an alter on the DB object being monitored is detected.
    /// </summary>
    [Property(NdapiConstant.D2FP_EVENT_OBJCHM_NTFALT)]
    public partial bool NotifyOnAlter { get; set; }

    /// <summary>
    /// Gets or sets whether the event object should notify when a delete on the DB object being monitored is detected.
    /// </summary>
    [Property(NdapiConstant.D2FP_EVENT_OBJCHM_NTFDEL)]
    public partial bool NotifyOnDelete { get; set; }

    /// <summary>
    /// Gets or sets whether the event object should notify when a drop on the DB object being monitored is detected.
    /// </summary>
    [Property(NdapiConstant.D2FP_EVENT_OBJCHM_NTFDRP)]
    public partial bool NotifyOnDrop { get; set; }

    /// <summary>
    /// Gets or sets whether the event object should notify when an insert on the DB object being monitored is detected.
    /// </summary>
    [Property(NdapiConstant.D2FP_EVENT_OBJCHM_NTFINS)]
    public partial bool NotifyOnInsert { get; set; }

    /// <summary>
    /// Gets or sets whether the event object should notify when an update on the DB object being monitored is detected.
    /// </summary>
    [Property(NdapiConstant.D2FP_EVENT_OBJCHM_NTFUPD)]
    public partial bool NotifyOnUpdate { get; set; }

    /// <summary>
    /// Gets or sets the priority mode.
    /// </summary>
    [Property(NdapiConstant.D2FP_EVENT_PRIORITY_MODE)]
    public partial int PriorityMode { get; set; }

    /// <summary>
    /// Gets or sets the event scope.
    /// </summary>
    [Property(NdapiConstant.D2FP_EVENT_SCOPE)]
    public partial EventScope EventScope { get; set; }

    /// <summary>
    /// Gets or sets the correlation id.
    /// </summary>
    [Property(NdapiConstant.D2FP_EVENT_SUBS_NAME)]
    public partial string SubscriptionName { get; set; }

    /// <summary>
    /// Gets or sets the  event subscription mode for a Query Result Change Notification (QRCN) event object.
    /// </summary>
    [Property(NdapiConstant.D2FP_EVENT_SUBSCRIPTION_MODE)]
    public partial SubscriptionMode SubscriptionMode { get; set; }

    /// <summary>
    /// Gets or sets the event scope.
    /// </summary>
    [Property(NdapiConstant.D2FP_EVENT_TYPE)]
    public partial EventType EventType { get; set; }

    /// <summary>
    /// Gets or sets the event scope.
    /// </summary>
    [Property(NdapiConstant.D2FP_EVENT_VIEW_MODE)]
    public partial EventViewMode EventViewMode { get; set; }
}
