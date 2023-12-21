using Ndapi.Core;
using Ndapi.Core.Handles;
using Ndapi.Enums;

namespace Ndapi
{
    /// <summary>
    /// Represents a list of values.
    /// </summary>
    public class LOV : NdapiObject<LOV>
    {
        /// <summary>
        /// Creates a list of values.
        /// </summary>
        /// <param name="module">List of values owner.</param>
        /// <param name="name">List of values name.</param>
        public LOV(FormModule module, string name) : base(name, ObjectType.LOV, module)
        {
        }

        /// <summary>
        /// Creates a list of values.
        /// </summary>
        /// <param name="group">List of values owner.</param>
        /// <param name="name">List of values name.</param>
        public LOV(ObjectGroup group, string name) : base(name, ObjectType.LOV, group)
        {
        }

        internal LOV(ObjectSafeHandle handle) : base(handle)
        {
        }

        /// <summary>
        /// Gets or sets whether runtime should adjust the width of columns automatically.
        /// </summary>
        [Property(NdapiConstants.D2FP_AUTO_COL_WID)]
        public bool IsAutomaticColumnWidth
        {
            get => GetBooleanProperty(NdapiConstants.D2FP_AUTO_COL_WID);
            set => SetBooleanProperty(NdapiConstants.D2FP_AUTO_COL_WID, value);
        }

        /// <summary>
        /// Gets or sets whether runtime should display the LOV automatically when the user or
        /// the application navigates into a text item to which the LOV is attached.
        /// </summary>
        [Property(NdapiConstants.D2FP_AUTO_DISP)]
        public bool IsAutomaticDisplay
        {
            get => GetBooleanProperty(NdapiConstants.D2FP_AUTO_DISP);
            set => SetBooleanProperty(NdapiConstants.D2FP_AUTO_DISP, value);
        }

        /// <summary>
        /// Gets or sets whether runtime should position the LOV automatically near the field from which it was invoked. 
        /// </summary>
        [Property(NdapiConstants.D2FP_AUTO_POS)]
        public bool IsAutomaticPosition
        {
            get => GetBooleanProperty(NdapiConstants.D2FP_AUTO_POS);
            set => SetBooleanProperty(NdapiConstants.D2FP_AUTO_POS, value);
        }

        /// <summary>
        /// Gets or sets whether runtime re-executes the query to populate an LOV that is based on a query record group.
        /// </summary>
        [Property(NdapiConstants.D2FP_AUTO_RFRSH)]
        public bool IsAutomaticRefresh
        {
            get => GetBooleanProperty(NdapiConstants.D2FP_AUTO_RFRSH);
            set => SetBooleanProperty(NdapiConstants.D2FP_AUTO_RFRSH, value);
        }

        /// <summary>
        /// Gets or sets whether runtime moves the cursor to the next navigable item when the user makes 
        /// a selection from an LOV to a text item. 
        /// </summary>
        [Property(NdapiConstants.D2FP_AUTO_SKP)]
        public bool IsAutomaticSkip
        {
            get => GetBooleanProperty(NdapiConstants.D2FP_AUTO_SKP);
            set => SetBooleanProperty(NdapiConstants.D2FP_AUTO_SKP, value);
        }

        /// <summary>
        /// Gets or sets whether runtime should select automatically the row when the result list is reduced to a single choice
        /// (by using auto-reduction or searching). If true, the LOV is dismissed automatically and column values from the 
        /// single row are assigned to their corresponding return items. If false, the LOV remains displayed, giving the user 
        /// the option to explicitly select the remaining choice or dismiss the LOV.
        /// </summary>
        [Property(NdapiConstants.D2FP_AUTO_SLCT)]
        public bool IsAutomaticSelect
        {
            get => GetBooleanProperty(NdapiConstants.D2FP_AUTO_SLCT);
            set => SetBooleanProperty(NdapiConstants.D2FP_AUTO_SLCT, value);
        }

        /// <summary>
        /// Gets or sets the background color.
        /// </summary>
        [Property(NdapiConstants.D2FP_BACK_COLOR)]
        public string BackgroundColor
        {
            get => GetStringProperty(NdapiConstants.D2FP_BACK_COLOR);
            set => SetStringProperty(NdapiConstants.D2FP_BACK_COLOR, value);
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
        /// Gets or sets the pattern to be used for the fill region.
        /// Patterns are rendered in the two colors specified by <see cref="BackgroundColor"/> and <see cref="ForegroundColor"/>.
        /// </summary>
        [Property(NdapiConstants.D2FP_FILL_PAT)]
        public string FillPattern
        {
            get => GetStringProperty(NdapiConstants.D2FP_FILL_PAT);
            set => SetStringProperty(NdapiConstants.D2FP_FILL_PAT, value);
        }

        /// <summary>
        /// Gets or sets whether runtime allows the user to enter a query criteria before displaying the query results.
        /// </summary>
        [Property(NdapiConstants.D2FP_FLTR_BEFORE_DISP)]
        public bool FilterBeforeDisplay
        {
            get => GetBooleanProperty(NdapiConstants.D2FP_FLTR_BEFORE_DISP);
            set => SetBooleanProperty(NdapiConstants.D2FP_FLTR_BEFORE_DISP, value);
        }

        /// <summary>
        /// Gets or sets the font name.
        /// </summary>
        [Property(NdapiConstants.D2FP_FONT_NAM)]
        public string FontName
        {
            get => GetStringProperty(NdapiConstants.D2FP_FONT_NAM);
            set => SetStringProperty(NdapiConstants.D2FP_FONT_NAM, value);
        }

        /// <summary>
        /// Gets or sets the font size.
        /// </summary>
        [Property(NdapiConstants.D2FP_FONT_SIZ)]
        public int FontSize
        {
            get => GetNumberProperty(NdapiConstants.D2FP_FONT_SIZ);
            set => SetNumberProperty(NdapiConstants.D2FP_FONT_SIZ, value);
        }

        /// <summary>
        /// Gets or sets the font spacing.
        /// </summary>
        [Property(NdapiConstants.D2FP_FONT_SPCING)]
        public FontSpacing FontSpacing
        {
            get => GetNumberProperty<FontSpacing>(NdapiConstants.D2FP_FONT_SPCING);
            set => SetNumberProperty(NdapiConstants.D2FP_FONT_SPCING, value);
        }

        /// <summary>
        /// Gets or sets the font style.
        /// </summary>
        [Property(NdapiConstants.D2FP_FONT_STY)]
        public FontStyle FontStyle
        {
            get => GetNumberProperty<FontStyle>(NdapiConstants.D2FP_FONT_STY);
            set => SetNumberProperty(NdapiConstants.D2FP_FONT_STY, value);
        }

        /// <summary>
        /// Gets or sets the font weight.
        /// </summary>
        [Property(NdapiConstants.D2FP_FONT_WGHT)]
        public FontWeight FontWeight
        {
            get => GetNumberProperty<FontWeight>(NdapiConstants.D2FP_FONT_WGHT);
            set => SetNumberProperty(NdapiConstants.D2FP_FONT_WGHT, value);
        }

        /// <summary>
        /// Gets or sets the foreground color.
        /// </summary>
        [Property(NdapiConstants.D2FP_FORE_COLOR)]
        public string ForegroundColor
        {
            get => GetStringProperty(NdapiConstants.D2FP_FORE_COLOR);
            set => SetStringProperty(NdapiConstants.D2FP_FORE_COLOR, value);
        }

        /// <summary>
        /// Gets or sets the height.
        /// </summary>
        [Property(NdapiConstants.D2FP_HEIGHT)]
        public int Height
        {
            get => GetNumberProperty(NdapiConstants.D2FP_HEIGHT);
            set => SetNumberProperty(NdapiConstants.D2FP_HEIGHT, value);
        }

        /// <summary>
        /// Gets or sets the language direction.
        /// </summary>
        [Property(NdapiConstants.D2FP_LANG_DIR)]
        public LanguageDirection LanguageDirection
        {
            get => GetNumberProperty<LanguageDirection>(NdapiConstants.D2FP_LANG_DIR);
            set => SetNumberProperty(NdapiConstants.D2FP_LANG_DIR, value);
        }

        /// <summary>
        /// Gets or sets the list type.
        /// </summary>
        [Property(NdapiConstants.D2FP_LST_TYP)]
        public ListType ListType
        {
            get => GetNumberProperty<ListType>(NdapiConstants.D2FP_LST_TYP);
            set => SetNumberProperty(NdapiConstants.D2FP_LST_TYP, value);
        }

        /// <summary>
        /// Gets or sets the LOV text (included only for compatibility).
        /// </summary>
        [Property(NdapiConstants.D2FP_OLD_LOV_TXT)]
        public string OldLOVText
        {
            get => GetStringProperty(NdapiConstants.D2FP_OLD_LOV_TXT);
            set => SetStringProperty(NdapiConstants.D2FP_OLD_LOV_TXT, value);
        }

        /// <summary>
        /// Gets or sets the record group associated with the LOV.
        /// </summary>
        [Property(NdapiConstants.D2FP_REC_GRP_OBJ)]
        public RecordGroup RecordGroup
        {
            get => GetObjectProperty<RecordGroup>(NdapiConstants.D2FP_REC_GRP_OBJ);
            set => SetObjectProperty(NdapiConstants.D2FP_REC_GRP_OBJ, value);
        }

        /// <summary>
        /// Gets or sets the LOV title.
        /// </summary>
        [Property(NdapiConstants.D2FP_TITLE)]
        public string Title
        {
            get => GetStringProperty(NdapiConstants.D2FP_TITLE);
            set => SetStringProperty(NdapiConstants.D2FP_TITLE, value);
        }

        /// <summary>
        /// Gets or sets the visual attribute name.
        /// </summary>
        [Property(NdapiConstants.D2FP_VAT_NAM)]
        public string VisualAttributeName
        {
            get => GetStringProperty(NdapiConstants.D2FP_VAT_NAM);
            set => SetStringProperty(NdapiConstants.D2FP_VAT_NAM, value);
        }

#if FORMS_6
        /// <summary>
        /// Gets or sets the white-on-black property.
        /// </summary>
        [Property(NdapiConstants.D2FP_WHITE_ON_BLACK)]
        public bool IsWhiteOnBlack
        {
            get => GetBooleanProperty(NdapiConstants.D2FP_WHITE_ON_BLACK);
            set => SetBooleanProperty(NdapiConstants.D2FP_WHITE_ON_BLACK, value);
        }
#endif

        /// <summary>
        /// Gets or sets the width.
        /// </summary>
        [Property(NdapiConstants.D2FP_WIDTH)]
        public int Width
        {
            get => GetNumberProperty(NdapiConstants.D2FP_WIDTH);
            set => SetNumberProperty(NdapiConstants.D2FP_WIDTH, value);
        }

        /// <summary>
        /// Gets or sets the X position measured at the upper left corner.
        /// </summary>
        [Property(NdapiConstants.D2FP_X_POS)]
        public int XPosition
        {
            get => GetNumberProperty(NdapiConstants.D2FP_X_POS);
            set => SetNumberProperty(NdapiConstants.D2FP_X_POS, value);
        }

        /// <summary>
        /// Gets or sets the Y position measured at the upper left corner.
        /// </summary>
        [Property(NdapiConstants.D2FP_Y_POS)]
        public int YPosition
        {
            get => GetNumberProperty(NdapiConstants.D2FP_Y_POS);
            set => SetNumberProperty(NdapiConstants.D2FP_Y_POS, value);
        }

        /// <summary>
        /// Gets all the LOV column mappings.
        /// </summary>
        [Property(NdapiConstants.D2FP_COL_MAP)]
        public NdapiObjectList<ColumnMapping> ColumnMappings => GetObjectList<ColumnMapping>(NdapiConstants.D2FP_COL_MAP);

        /// <summary>
        /// Creates a column mapping.
        /// </summary>
        /// <param name="name">Name of the column mapping.</param>
        /// <returns>The child object.</returns>
        public ColumnMapping CreateColumnMapping(string name) => new ColumnMapping(this, name);
    }
}
