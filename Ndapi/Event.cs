#if FORMS_12_OR_GREATER
using Ndapi.Core;
using Ndapi.Core.Handles;
using Ndapi.Enums;

namespace Ndapi
{
    /// <summary>
    /// Represents an editor object.
    /// </summary>
    public class Event : NdapiObject<Event>
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

        internal Event(ObjectSafeHandle handle) : base(handle)
        {
        }

        /// <summary>
        /// Gets or sets the comment.
        /// </summary>
        [Property(NdapiConstants.D2FP_COMMENT)]
        public string Comment
        {
            get => GetStringProperty(NdapiConstants.D2FP_COMMENT);
            set => SetStringProperty(NdapiConstants.D2FP_COMMENT, value);
        }

        /// <summary>
        /// Gets or sets the correlation id.
        /// </summary>
        [Property(NdapiConstants.D2FP_EVENT_CORRID)]
        public string CorrelationId
        {
            get => GetStringProperty(NdapiConstants.D2FP_EVENT_CORRID);
            set => SetStringProperty(NdapiConstants.D2FP_EVENT_CORRID, value);
        }

        /// <summary>
        /// Gets or sets whether the event is enabled.
        /// </summary>
        [Property(NdapiConstants.D2FP_EVENT_ENABLED)]
        public bool IsEnabled
        {
            get => GetBooleanProperty(NdapiConstants.D2FP_EVENT_ENABLED);
            set => SetBooleanProperty(NdapiConstants.D2FP_EVENT_ENABLED, value);
        }

        /// <summary>
        /// Gets or sets the priority mode.
        /// </summary>
        [Property(NdapiConstants.D2FP_EVENT_PRIORITY_MODE)]
        public int PriorityMode
        {
            get => GetNumberProperty(NdapiConstants.D2FP_EVENT_PRIORITY_MODE);
            set => SetNumberProperty(NdapiConstants.D2FP_EVENT_PRIORITY_MODE, value);
        }

        /// <summary>
        /// Gets or sets the event scope.
        /// </summary>
        [Property(NdapiConstants.D2FP_EVENT_SCOPE)]
        public EventScope EventScope
        {
            get => GetNumberProperty<EventScope>(NdapiConstants.D2FP_EVENT_SCOPE);
            set => SetNumberProperty(NdapiConstants.D2FP_EVENT_SCOPE, value);
        }

        /// <summary>
        /// Gets or sets the correlation id.
        /// </summary>
        [Property(NdapiConstants.D2FP_EVENT_SUBS_NAME)]
        public string SubscriptionName
        {
            get => GetStringProperty(NdapiConstants.D2FP_EVENT_SUBS_NAME);
            set => SetStringProperty(NdapiConstants.D2FP_EVENT_SUBS_NAME, value);
        }

        /// <summary>
        /// Gets or sets the event scope.
        /// </summary>
        [Property(NdapiConstants.D2FP_EVENT_TYPE)]
        public EventType EventType
        {
            get => GetNumberProperty<EventType>(NdapiConstants.D2FP_EVENT_TYPE);
            set => SetNumberProperty(NdapiConstants.D2FP_EVENT_TYPE, value);
        }

        /// <summary>
        /// Gets or sets the event scope.
        /// </summary>
        [Property(NdapiConstants.D2FP_EVENT_VIEW_MODE)]
        public EventViewMode EventViewMode
        {
            get => GetNumberProperty<EventViewMode>(NdapiConstants.D2FP_EVENT_VIEW_MODE);
            set => SetNumberProperty(NdapiConstants.D2FP_EVENT_VIEW_MODE, value);
        }
    }
}
#endif
