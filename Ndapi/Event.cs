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
    /// Gets or sets the correlation id.
    /// </summary>
    [Property(NdapiConstant.D2FP_EVENT_CORRID)]
    public partial string CorrelationId { get; set; }

    /// <summary>
    /// Gets or sets whether the event is enabled.
    /// </summary>
    [Property(NdapiConstant.D2FP_EVENT_ENABLED)]
    public partial bool IsEnabled { get; set; }

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
