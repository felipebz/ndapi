using Ndapi.Core.Handles;
using Ndapi.Enums;
using System.Collections.Generic;

namespace Ndapi
{
    /// <summary>
    /// Represents a canvas object.
    /// </summary>
    public class Canvas : NdapiObject
    {
        /// <summary>
        /// Creates a canvas object.
        /// </summary>
        /// <param name="module">Canvas owner.</param>
        /// <param name="name">Canvas name.</param>
        public Canvas(FormModule module, string name) : base(name, ObjectType.Canvas, module)
        {
        }

        /// <summary>
        /// Creates a canvas object.
        /// </summary>
        /// <param name="group">Canvas owner.</param>
        /// <param name="name">Canvas name.</param>
        public Canvas(ObjectGroup group, string name) : base(name, ObjectType.Canvas, group)
        {
        }

        /// <summary>
        /// Creates a canvas object.
        /// </summary>
        /// <param name="library">Canvas owner.</param>
        /// <param name="name">Canvas name.</param>
        public Canvas(ObjectLibrary library, string name) : base(name, ObjectType.Canvas, library)
        {
        }

        internal Canvas(ObjectSafeHandle handle) : base(handle)
        {
        }

        /// <summary>
        /// Gets or sets the background color.
        /// </summary>
        public string BackgroundColor
        {
            get { return GetStringProperty(NdapiConstants.D2FP_BACK_COLOR); }
            set { SetStringProperty(NdapiConstants.D2FP_BACK_COLOR, value); }
        }

        /// <summary>
        /// Gets or sets the appearance of the object border.
        /// </summary>
        public Bevel Bevel
        {
            get { return GetNumberProperty<Bevel>(NdapiConstants.D2FP_BEVEL); }
            set { SetNumberProperty(NdapiConstants.D2FP_BEVEL, value); }
        }

        /// <summary>
        /// Gets or sets the canvas type.
        /// </summary>
        public CanvasType CanvasType
        {
            get { return GetNumberProperty<CanvasType>(NdapiConstants.D2FP_CNV_TYP); }
            set { SetNumberProperty(NdapiConstants.D2FP_CNV_TYP, value); }
        }

        /// <summary>
        /// Gets or sets the comment.
        /// </summary>
        public string Comment
        {
            get { return GetStringProperty(NdapiConstants.D2FP_COMMENT); }
            set { SetStringProperty(NdapiConstants.D2FP_COMMENT, value); }
        }

        /// <summary>
        /// Gets or sets the pattern to be used for the fill region.
        /// Patterns are rendered in the two colors specified by <see cref="BackgroundColor"/> and <see cref="ForegroundColor"/>.
        /// </summary>
        public string FillPattern
        {
            get { return GetStringProperty(NdapiConstants.D2FP_FILL_PAT); }
            set { SetStringProperty(NdapiConstants.D2FP_FILL_PAT, value); }
        }

        /// <summary>
        /// Gets or sets the font name.
        /// </summary>
        public string FontName
        {
            get { return GetStringProperty(NdapiConstants.D2FP_FONT_NAM); }
            set { SetStringProperty(NdapiConstants.D2FP_FONT_NAM, value); }
        }

        /// <summary>
        /// Gets or sets the font size.
        /// </summary>
        public int FontSize
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_FONT_SIZ); }
            set { SetNumberProperty(NdapiConstants.D2FP_FONT_SIZ, value); }
        }

        /// <summary>
        /// Gets or sets the font spacing.
        /// </summary>
        public FontSpacing FontSpacing
        {
            get { return GetNumberProperty<FontSpacing>(NdapiConstants.D2FP_FONT_SPCING); }
            set { SetNumberProperty(NdapiConstants.D2FP_FONT_SPCING, value); }
        }

        /// <summary>
        /// Gets or sets the font style.
        /// </summary>
        public FontStyle FontStyle
        {
            get { return GetNumberProperty<FontStyle>(NdapiConstants.D2FP_FONT_STY); }
            set { SetNumberProperty(NdapiConstants.D2FP_FONT_STY, value); }
        }

        /// <summary>
        /// Gets or sets the font weight.
        /// </summary>
        public FontWeight FontWeight
        {
            get { return GetNumberProperty<FontWeight>(NdapiConstants.D2FP_FONT_WGHT); }
            set { SetNumberProperty(NdapiConstants.D2FP_FONT_WGHT, value); }
        }

        /// <summary>
        /// Gets or sets the foreground color.
        /// </summary>
        public string ForegroundColor
        {
            get { return GetStringProperty(NdapiConstants.D2FP_FORE_COLOR); }
            set { SetStringProperty(NdapiConstants.D2FP_FORE_COLOR, value); }
        }

        /// <summary>
        /// Gets or sets the height.
        /// </summary>
        public int Height
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_HEIGHT); }
            set { SetNumberProperty(NdapiConstants.D2FP_HEIGHT, value); }
        }

        /// <summary>
        /// Gets or sets the associated help book topic.
        /// </summary>
        public string HelpBookTopic
        {
            get { return GetStringProperty(NdapiConstants.D2FP_HELP_BOOK_TOPIC); }
            set { SetStringProperty(NdapiConstants.D2FP_HELP_BOOK_TOPIC, value); }
        }

        /// <summary>
        /// Gets or sets the language direction.
        /// </summary>
        public LanguageDirection LanguageDirection
        {
            get { return GetNumberProperty<LanguageDirection>(NdapiConstants.D2FP_LANG_DIR); }
            set { SetNumberProperty(NdapiConstants.D2FP_LANG_DIR, value); }
        }

        /// <summary>
        /// Gets or sets the name of the popup object.
        /// </summary>
        public string PopupMenuName
        {
            get { return GetStringProperty(NdapiConstants.D2FP_POPUP_MNU_NAM); }
            set { SetStringProperty(NdapiConstants.D2FP_POPUP_MNU_NAM, value); }
        }

        /// <summary>
        /// Gets or sets whether runtime should display the canvas when the end user or the application
        /// navigates to an item on the canvas. 
        /// This property is valid only when the <see cref="CanvasType"/> is set to <see cref="CanvasType.Tab"/>.
        /// </summary>
        public bool RaiseOnEntry
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_RAISE_ON_ENT); }
            set { SetBooleanProperty(NdapiConstants.D2FP_RAISE_ON_ENT, value); }
        }

        /// <summary>
        /// Gets or sets the location where tabs are attached to a tab canvas.
        /// </summary>
        public TabAttachmentEdge TabAttachmentEdge
        {
            get { return GetNumberProperty<TabAttachmentEdge>(NdapiConstants.D2FP_TAB_ATT_EDGE); }
            set { SetNumberProperty(NdapiConstants.D2FP_TAB_ATT_EDGE, value); }
        }

        /// <summary>
        /// Gets or sets the tab style.
        /// </summary>
        public TabStyle TabStyle
        {
            get { return GetNumberProperty<TabStyle>(NdapiConstants.D2FP_TAB_STY); }
            set { SetNumberProperty(NdapiConstants.D2FP_TAB_STY, value); }
        }

        /// <summary>
        /// Gets or sets the visual attribute name.
        /// </summary>
        public string VisualAttributeName
        {
            get { return GetStringProperty(NdapiConstants.D2FP_VAT_NAM); }
            set { SetStringProperty(NdapiConstants.D2FP_VAT_NAM, value); }
        }

        /// <summary>
        /// Gets or sets whether the canvas is initially shown or hidden in the window to which it is assigned.
        /// This property is valid only when the <see cref="CanvasType"/> is set to <see cref="CanvasType.Stacked"/>.
        /// </summary>
        public bool Visible
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_VISIBLE); }
            set { SetBooleanProperty(NdapiConstants.D2FP_VISIBLE, value); }
        }

        /// <summary>
        /// Gets or sets the viewport height.
        /// </summary>
        public int ViewportHeight
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_VPRT_HGT); }
            set { SetNumberProperty(NdapiConstants.D2FP_VPRT_HGT, value); }
        }

        /// <summary>
        /// Gets or sets the viewport width.
        /// </summary>
        public int ViewportWidth
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_VPRT_WID); }
            set { SetNumberProperty(NdapiConstants.D2FP_VPRT_WID, value); }
        }

        /// <summary>
        /// Gets or sets the X position of canvas's upper left corner relative to the upper left corner of the window's current content view. 
        /// This property is valid only when the <see cref="CanvasType"/> is set to <see cref="CanvasType.Stacked"/>.
        /// </summary>
        public int ViewportXPosition
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_VPRT_X_POS); }
            set { SetNumberProperty(NdapiConstants.D2FP_VPRT_X_POS, value); }
        }

        /// <summary>
        /// Gets or sets the X position of the view's upper left corner relative to the upper left corner of the canvas.
        /// </summary>
        public int ViewportXPositionOnCanvas
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_VPRT_X_POS_ON_CNV); }
            set { SetNumberProperty(NdapiConstants.D2FP_VPRT_X_POS_ON_CNV, value); }
        }

        /// <summary>
        /// Gets or sets the Y position of canvas's upper left corner relative to the upper left corner of the window's current content view. 
        /// This property is valid only when the <see cref="CanvasType"/> is set to <see cref="CanvasType.Stacked"/>.
        /// </summary>
        public int ViewportYPosition
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_VPRT_Y_POS); }
            set { SetNumberProperty(NdapiConstants.D2FP_VPRT_Y_POS, value); }
        }

        /// <summary>
        /// Gets or sets the Y position of the view's upper left corner relative to the upper left corner of the canvas.
        /// </summary>
        public int ViewportYPositionOnCanvas
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_VPRT_Y_POS_ON_CNV); }
            set { SetNumberProperty(NdapiConstants.D2FP_VPRT_Y_POS_ON_CNV, value); }
        }

        /// <summary>
        /// Gets or sets the white-on-black property.
        /// </summary>
        public bool WhiteOnBlack
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_WHITE_ON_BLACK); }
            set { SetBooleanProperty(NdapiConstants.D2FP_WHITE_ON_BLACK, value); }
        }

        /// <summary>
        /// Gets or sets the width.
        /// </summary>
        public int Width
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_WIDTH); }
            set { SetNumberProperty(NdapiConstants.D2FP_WIDTH, value); }
        }

        /// <summary>
        /// Gets or sets the window in which the canvas will be displayed at runtime.
        /// </summary>
        public Window Window
        {
            get { return GetObjectProperty<Window>(NdapiConstants.D2FP_WND_OBJ); }
            set { SetObjectProperty(NdapiConstants.D2FP_WND_OBJ, value); }
        }

        /// <summary>
        /// Gets or sets the window name in which the canvas will be displayed at runtime.
        /// </summary>
        public string WindowName
        {
            get { return GetStringProperty(NdapiConstants.D2FP_WND_NAM); }
            set { SetStringProperty(NdapiConstants.D2FP_WND_NAM, value); }
        }

        /// <summary>
        /// Gets all the graphics objects attached to the canvas.
        /// </summary>
        public IEnumerable<Graphics> Graphics =>
            GetObjectList<Graphics>(NdapiConstants.D2FP_GRAPHIC);

        /// <summary>
        /// Gets all the tab pages associated with the current canvas.
        /// This property is valid only when the <see cref="CanvasType"/> is set to <see cref="CanvasType.Tab"/>.
        /// </summary>
        public IEnumerable<TabPage> TabPages =>
            GetObjectList<TabPage>(NdapiConstants.D2FP_TAB_PAGE);
    }
}
