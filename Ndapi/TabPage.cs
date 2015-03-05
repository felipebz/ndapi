using Ndapi.Core;
using Ndapi.Core.Handles;
using Ndapi.Enums;

namespace Ndapi
{
    /// <summary>
    /// Represents a tab page.
    /// </summary>
    public class TabPage : NdapiObject<TabPage>
    {
        /// <summary>
        /// Creates a tab page.
        /// </summary>
        /// <param name="canvas">Canvas object.</param>
        /// <param name="name">Tab page name.</param>
        public TabPage(Canvas canvas, string name) : base(name, ObjectType.TabPage, canvas)
        {
        }

        internal TabPage(ObjectSafeHandle handle) : base(handle)
        {
        }

        /// <summary>
        /// Gets or sets the comment.
        /// </summary>
        [Property(NdapiConstants.D2FP_COMMENT)]
        public string Comment
        {
            get { return GetStringProperty(NdapiConstants.D2FP_COMMENT); }
            set { SetStringProperty(NdapiConstants.D2FP_COMMENT, value); }
        }

        /// <summary>
        /// Gets or sets whether the tab is enabled.
        /// </summary>
        [Property(NdapiConstants.D2FP_ENABLED)]
        public bool IsEnabled
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_ENABLED); }
            set { SetBooleanProperty(NdapiConstants.D2FP_ENABLED, value); }
        }

        /// <summary>
        /// Gets or sets the label.
        /// </summary>
        [Property(NdapiConstants.D2FP_LABEL)]
        public string Label
        {
            get { return GetStringProperty(NdapiConstants.D2FP_LABEL); }
            set { SetStringProperty(NdapiConstants.D2FP_LABEL, value); }
        }

        /// <summary>
        /// Gets or sets whether the tab is visible.
        /// </summary>
        [Property(NdapiConstants.D2FP_VISIBLE)]
        public bool IsVisible
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_VISIBLE); }
            set { SetBooleanProperty(NdapiConstants.D2FP_VISIBLE, value); }
        }

        /// <summary>
        /// Gets all the graphic objects attached to the canvas.
        /// </summary>
        [Property(NdapiConstants.D2FP_GRAPHIC)]
        public NdapiObjectList<Graphics> Graphics => GetObjectList<Graphics>(NdapiConstants.D2FP_GRAPHIC);

        /// <summary>
        /// Creates a child graphics object.
        /// </summary>
        /// <param name="name">Name of the graphics object.</param>
        /// <returns>The child object.</returns>
        public Graphics CreateGraphics(string name) => new Graphics(this, name);
    }
}
