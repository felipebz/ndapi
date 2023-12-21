namespace Ndapi.Enums
{
    public enum AlertButton
    {
        Button1 = NdapiConstants.D2FC_DFAL_BTN1,
        Button2 = NdapiConstants.D2FC_DFAL_BTN2,
        Button3 = NdapiConstants.D2FC_DFAL_BTN3
    }

    public enum Justification
    {
        Left = NdapiConstants.D2FC_JUST_LEFT,
        Right = NdapiConstants.D2FC_JUST_RIGHT,
        Center = NdapiConstants.D2FC_JUST_CENTER,
        Start = NdapiConstants.D2FC_JUST_START,
        End = NdapiConstants.D2FC_JUST_END
    }

    public enum AlertStyle
    {
        Stop = NdapiConstants.D2FC_ALST_STOP,
        Caution = NdapiConstants.D2FC_ALST_CAUTION,
        Note = NdapiConstants.D2FC_ALST_NOTE
    }

    public enum DataSourceArgumentMode
    {
        In = NdapiConstants.D2FC_DSMO_IN,
        Out = NdapiConstants.D2FC_DSMO_OUT,
        InOut = NdapiConstants.D2FC_DSMO_IN_OUT
    }

    public enum LineArrowStyle
    {
        None = NdapiConstants.D2FC_ARST_NONE,
        Start = NdapiConstants.D2FC_ARST_START,
        End = NdapiConstants.D2FC_ARST_END,
        Both = NdapiConstants.D2FC_ARST_BOTH,
        MiddleToStart = NdapiConstants.D2FC_ARST_MDLTOSTRT,
        MiddleToEnd = NdapiConstants.D2FC_ARST_MDLTOEND
    }

    public enum GraphicsObjectType
    {
        Arc = NdapiConstants.D2FC_GRTY_ARC,
        Image = NdapiConstants.D2FC_GRTY_IMAGE,
        Line = NdapiConstants.D2FC_GRTY_LINE,
        Polygon = NdapiConstants.D2FC_GRTY_POLY,
        Rectangle = NdapiConstants.D2FC_GRTY_RECT,
        RoundedRectangle = NdapiConstants.D2FC_GRTY_RREC,
        Text = NdapiConstants.D2FC_GRTY_TEXT,
        Group = NdapiConstants.D2FC_GRTY_GROUP,
        Frame = NdapiConstants.D2FC_GRTY_FRAME
    }

    public enum Bevel
    {
        Raised = NdapiConstants.D2FC_BEST_RAISED,
        Lowered = NdapiConstants.D2FC_BEST_LOWERED,
        None = NdapiConstants.D2FC_BEST_NONE,
        Inset = NdapiConstants.D2FC_BEST_NSET,
        Outset = NdapiConstants.D2FC_BEST_OUTSET,
        Plain = NdapiConstants.D2FC_BEST_PLAIN
    }

    public enum DataSourceColumnType
    {
        Varchar2 = NdapiConstants.D2FC_DSTY_VARCHAR2,
        Number = NdapiConstants.D2FC_DSTY_NUMBER,
        Long = NdapiConstants.D2FC_DSTY_LONG,
        Rowid = NdapiConstants.D2FC_DSTY_ROWID,
        Date = NdapiConstants.D2FC_DSTY_DATE,
        Raw = NdapiConstants.D2FC_DSTY_RAW,
        LongRaw = NdapiConstants.D2FC_DSTY_LONG_RAW,
        Char = NdapiConstants.D2FC_DSTY_CHAR,
        Mlslabel = NdapiConstants.D2FC_DSTY_MLSLABEL,
        Table = NdapiConstants.D2FC_DSTY_TABLE,
        Record = NdapiConstants.D2FC_DSTY_RECORD,
        Refcursor = NdapiConstants.D2FC_DSTY_REFCURSOR,
        Namedtype = NdapiConstants.D2FC_DSTY_NAMEDTYPE,
        Objectref = NdapiConstants.D2FC_DSTY_OBJECTREF,
        Varray = NdapiConstants.D2FC_DSTY_VARRAY,
        Nestedtab = NdapiConstants.D2FC_DSTY_NESTEDTAB,
        Blob = NdapiConstants.D2FC_DSTY_BLOB,
        Clob = NdapiConstants.D2FC_DSTY_CLOB,
        Bfile = NdapiConstants.D2FC_DSTY_BFILE,
#if FORMS_6
        Cfile = NdapiConstants.D2FC_DSTY_CFILE,
        Unknown = NdapiConstants.D2FC_DSTY_UNKNOWN
#endif
    }

    public enum CommunicationMode
    {
        Synchronous = NdapiConstants.D2FC_COMO_SYNCH,
        Asynchronous = NdapiConstants.D2FC_COMO_ASYNCH
    }

    public enum CoordinateSystem
    {
        Character = NdapiConstants.D2FC_COSY_CHARACTER,
        Real = NdapiConstants.D2FC_COSY_REAL
    }

    public enum QueryDataSourceType
    {
        None = NdapiConstants.D2FC_QRDA_NONE,
        Table = NdapiConstants.D2FC_QRDA_TABLE,
        Procedure = NdapiConstants.D2FC_QRDA_PROCEDURE,
        Trig = NdapiConstants.D2FC_QRDA_TRANS_TRIG,
        Query = NdapiConstants.D2FC_QRDA_FRM_CLS_QUERY
    }

    public enum DMLDataTargetType
    {
        None = NdapiConstants.D2FC_DMDA_NONE,
        Table = NdapiConstants.D2FC_DMDA_TABLE,
        Procedure = NdapiConstants.D2FC_DMDA_PROCEDURE,
        TransationalTrigger = NdapiConstants.D2FC_DMDA_TRANS_TRIG
    }

    public enum EdgeAtachmentType
    {
        Start = NdapiConstants.D2FC_PRAT_START,
        End = NdapiConstants.D2FC_PRAT_END,
        Top = NdapiConstants.D2FC_PRAT_TOP,
        Bottom = NdapiConstants.D2FC_PRAT_BOTTOM
    }

    public enum ExecutionMode
    {
        Batch = NdapiConstants.D2FC_EXMO_BATCH,
        Runtime = NdapiConstants.D2FC_EXMO_RUNTIME
    }

    public enum SourceType
    {
        Filesystem = NdapiConstants.D2FC_LISR_FS,
        Database = NdapiConstants.D2FC_LISR_DB
    }

    public enum UpdateLayout
    {
        Manual = NdapiConstants.D2FC_UPLA_MANUAL,
        Automatic = NdapiConstants.D2FC_UPLA_AUTO,
        Locked = NdapiConstants.D2FC_UPLA_LOCKED
    }

    public enum ItemType
    {
        ChartArea = NdapiConstants.D2FC_ITTY_CA,
        CheckBox = NdapiConstants.D2FC_ITTY_CB,
        DisplayItem = NdapiConstants.D2FC_ITTY_DI,
        Image = NdapiConstants.D2FC_ITTY_IM,
        ListItem = NdapiConstants.D2FC_ITTY_LS,
        ActiveX = NdapiConstants.D2FC_ITTY_ACT,
        OLE = NdapiConstants.D2FC_ITTY_OLE,
        Button = NdapiConstants.D2FC_ITTY_PB,
        RadioGroup = NdapiConstants.D2FC_ITTY_RD,
        Sound = NdapiConstants.D2FC_ITTY_SN,
        TextItem = NdapiConstants.D2FC_ITTY_TI,
        UserArea = NdapiConstants.D2FC_ITTY_UA,
        VBX = NdapiConstants.D2FC_ITTY_VBX,
        Tree = NdapiConstants.D2FC_ITTY_TRE,
        Bean = NdapiConstants.D2FC_ITTY_BA
    }

    public enum OleActivationStyle
    {
        Doubleclick = NdapiConstants.D2FC_OLAC_DOUBLECLICK,
        Manual = NdapiConstants.D2FC_OLAC_MANUAL,
        Focus = NdapiConstants.D2FC_OLAC_FOCUS
    }

    public enum PromptDisplayStyle
    {
        Hidden = NdapiConstants.D2FC_PRDI_HIDDEN,
        First = NdapiConstants.D2FC_PRDI_FIRST,
        Each = NdapiConstants.D2FC_PRDI_EACH
    }

    public enum ProgramUnitType
    {
        Unknown = NdapiConstants.D2FC_PGTY_UNKNOWN,
        Procedure = NdapiConstants.D2FC_PGTY_PROCEDURE,
        Function = NdapiConstants.D2FC_PGTY_FUNCTION,
        PackageSpecification = NdapiConstants.D2FC_PGTY_PACKAGESPEC,
        PackageBody = NdapiConstants.D2FC_PGTY_PACKAGEBODY
    }

    public enum RealUnit
    {
        Pixel = NdapiConstants.D2FC_REUN_PIXEL,
        Centimeter = NdapiConstants.D2FC_REUN_CENTIMETER,
        Inch = NdapiConstants.D2FC_REUN_INCH,
        Point = NdapiConstants.D2FC_REUN_POINT,
        Decipoint = NdapiConstants.D2FC_REUN_DECIPOINT
    }

    public enum RelationType
    {
        Join = NdapiConstants.D2FC_RELT_JOIN,
        Ref = NdapiConstants.D2FC_RELT_REF
    }

    public enum RuntimeCompatibility
    {
        Forms_45 = NdapiConstants.D2FC_RUCO_45,
        Forms_50 = NdapiConstants.D2FC_RUCO_50
    }

    public enum TabAttachmentEdge
    {
        Top = NdapiConstants.D2FC_TAAT_TOP,
        Bottom = NdapiConstants.D2FC_TAAT_BOTTOM,
        Left = NdapiConstants.D2FC_TAAT_LEFT,
        Right = NdapiConstants.D2FC_TAAT_RIGHT,
        Start = NdapiConstants.D2FC_TAAT_START,
        End = NdapiConstants.D2FC_TAAT_END
    }

    public enum TabStyle
    {
        Chamfered = NdapiConstants.D2FC_TAST_CHAMFERED,
        Square = NdapiConstants.D2FC_TAST_SQUARE,
        Rounded = NdapiConstants.D2FC_TAST_ROUNDED
    }

    public enum VisualAttributeType
    {
        Common = NdapiConstants.D2FC_VATY_COMMON,
        Prompt = NdapiConstants.D2FC_VATY_PROMPT,
        Title = NdapiConstants.D2FC_VATY_TITLE
    }

    public enum ColumnSpecificationDataType
    {
        Char = NdapiConstants.D2FC_CODA_CHAR,
        Number = NdapiConstants.D2FC_CODA_NUMBER,
        Date = NdapiConstants.D2FC_CODA_DATE,
        Long = NdapiConstants.D2FC_CODA_LONG,
        RefObject = NdapiConstants.D2FC_CODA_REF
    }

    public enum SoundChannels
    {
        Auto = NdapiConstants.D2FC_AUCH_AUTO,
        Mono = NdapiConstants.D2FC_AUCH_MONO,
        Stereo = NdapiConstants.D2FC_AUCH_STEREO
    }

    public enum CalculationMode
    {
        None = NdapiConstants.D2FC_CAMO_NONE,
        Formula = NdapiConstants.D2FC_CAMO_FORMULA,
        Summary = NdapiConstants.D2FC_CAMO_SUMMARY
    }

    public enum CursorMode
    {
        Open = NdapiConstants.D2FC_CRMO_OPEN,
        Close = NdapiConstants.D2FC_CRMO_CLOSE
    }

    public enum ObjectEdgeCapStyle
    {
        Butt = NdapiConstants.D2FC_CAST_BUTT,
        Round = NdapiConstants.D2FC_CAST_ROUND,
        Projecting = NdapiConstants.D2FC_CAST_PROJECT
    }

    public enum CompressionQuality
    {
        None = NdapiConstants.D2FC_CMQL_NONE,
        Min = NdapiConstants.D2FC_CMQL_MIN,
        Low = NdapiConstants.D2FC_CMQL_LOW,
        Med = NdapiConstants.D2FC_CMQL_MED,
        High = NdapiConstants.D2FC_CMQL_HIGH,
        Max = NdapiConstants.D2FC_CMQL_MAX
    }

    public enum CaseRestriction
    {
        Mixed = NdapiConstants.D2FC_CARS_MIXED,
        Upper = NdapiConstants.D2FC_CARS_UPPER,
        Lower = NdapiConstants.D2FC_CARS_LOWER
    }

    public enum CanvasType
    {
        Content = NdapiConstants.D2FC_CNTY_CONTENT,
        Stacked = NdapiConstants.D2FC_CNTY_STACKED,
        VerticalToolbar = NdapiConstants.D2FC_CNTY_VTOOLBAR,
        HorizontalToolbar = NdapiConstants.D2FC_CNTY_HTOOLBAR,
        Tab = NdapiConstants.D2FC_CNTY_TAB
    }

    public enum CheckBoxOtherValues
    {
        Illegal = NdapiConstants.D2FC_CHBX_ILLEGAL,
        Checked = NdapiConstants.D2FC_CHBX_CHECKED,
        Unchecked = NdapiConstants.D2FC_CHBX_UNCHECKED
    }

    public enum LanguageDirection
    {
        Default = NdapiConstants.D2FC_LADI_DEFAULT,
        LeftToRight = NdapiConstants.D2FC_LADI_TORIGHT,
        RigthToLeft = NdapiConstants.D2FC_LADI_TOLEFT
    }

    public enum InitialKeyboardDirection
    {
        Default = NdapiConstants.D2FC_INKB_DEFAULT,
        Roman = NdapiConstants.D2FC_INKB_ROMAN,
        Native = NdapiConstants.D2FC_INKB_NATIVE
    }

    public enum ImageDepth
    {
        Orig = NdapiConstants.D2FC_IMDP_ORIG,
        Mono = NdapiConstants.D2FC_IMDP_MONO,
        Gray = NdapiConstants.D2FC_IMDP_GRAY,
        Lut = NdapiConstants.D2FC_IMDP_LUT,
        Rgb = NdapiConstants.D2FC_IMDP_RGB
    }

    public enum DashStyle
    {
        Solid = NdapiConstants.D2FC_DAST_SOLID,
        Dotted = NdapiConstants.D2FC_DAST_DOT,
        Dashed = NdapiConstants.D2FC_DAST_DASH,
        DashDot = NdapiConstants.D2FC_DAST_DASHDOT,
        DoubleDot = NdapiConstants.D2FC_DAST_DOUBDOT,
        LongDash = NdapiConstants.D2FC_DAST_LONGDASH,
        DashDoubleDot = NdapiConstants.D2FC_DAST_DASHDOUBDOT
    }

    public enum ExecutionStyle
    {
        Override = NdapiConstants.D2FC_EXHI_OVERRIDE,
        Before = NdapiConstants.D2FC_EXHI_BEFORE,
        After = NdapiConstants.D2FC_EXHI_AFTER
    }

    public enum FrameAlignment
    {
        Start = NdapiConstants.D2FC_FRAL_START,
        End = NdapiConstants.D2FC_FRAL_END,
        Center = NdapiConstants.D2FC_FRAL_CENTER,
        Fill = NdapiConstants.D2FC_FRAL_FILL,
        Column = NdapiConstants.D2FC_FRAL_COLUMN
    }

    public enum FontSpacing
    {
        Ultradense = NdapiConstants.D2FC_FOSP_ULTRADENSE,
        Extradense = NdapiConstants.D2FC_FOSP_EXTRADENSE,
        Dense = NdapiConstants.D2FC_FOSP_DENSE,
        Semidense = NdapiConstants.D2FC_FOSP_SEMIDENSE,
        Normal = NdapiConstants.D2FC_FOSP_NORMAL,
        Semiexpand = NdapiConstants.D2FC_FOSP_SEMIEXPAND,
        Expand = NdapiConstants.D2FC_FOSP_EXPAND,
        Extraexpand = NdapiConstants.D2FC_FOSP_EXTRAEXPAND,
        Ultraexpand = NdapiConstants.D2FC_FOSP_ULTRAEXPAND
    }

    public enum FontStyle
    {
        Plain = NdapiConstants.D2FC_FOST_PLAIN,
        Italic = NdapiConstants.D2FC_FOST_ITALIC,
        Oblique = NdapiConstants.D2FC_FOST_OBLIQUE,
        Underline = NdapiConstants.D2FC_FOST_UNDERLINE,
        Outline = NdapiConstants.D2FC_FOST_OUTLINE,
        Shadow = NdapiConstants.D2FC_FOST_SHADOW,
        Inverted = NdapiConstants.D2FC_FOST_INVERTED,
        Overstrike = NdapiConstants.D2FC_FOST_OVERSTRIKE,
        Blink = NdapiConstants.D2FC_FOST_BLINK
    }

    public enum FontWeight
    {
        Ultralight = NdapiConstants.D2FC_FOWG_ULTRALIGHT,
        Extralight = NdapiConstants.D2FC_FOWG_EXTRALIGHT,
        Light = NdapiConstants.D2FC_FOWG_LIGHT,
        Demilight = NdapiConstants.D2FC_FOWG_DEMILIGHT,
        Medium = NdapiConstants.D2FC_FOWG_MEDIUM,
        Demibold = NdapiConstants.D2FC_FOWG_DEMIBOLD,
        Bold = NdapiConstants.D2FC_FOWG_BOLD,
        Extrabold = NdapiConstants.D2FC_FOWG_EXTRABOLD,
        Ultrabold = NdapiConstants.D2FC_FOWG_ULTRABOLD
    }

    public enum LayoutStyle
    {
        Form = NdapiConstants.D2FC_LAST_FORM,
        Tabular = NdapiConstants.D2FC_LAST_TABULAR
    }

    public enum HorizontalOrigin
    {
        Left = NdapiConstants.D2FC_HOOR_LEFT,
        Right = NdapiConstants.D2FC_HOOR_RIGHT,
        Center = NdapiConstants.D2FC_HOOR_CENTER
    }

    public enum HorizontalJustification
    {
        Left = NdapiConstants.D2FC_HOJU_LEFT,
        Right = NdapiConstants.D2FC_HOJU_RIGHT,
        Center = NdapiConstants.D2FC_HOJU_CENTER,
        Start = NdapiConstants.D2FC_HOJU_START,
        End = NdapiConstants.D2FC_HOJU_END
    }

    public enum ItemDataType
    {
        Char = NdapiConstants.D2FC_DATY_CHAR,
        Number = NdapiConstants.D2FC_DATY_NUMBER,
        Date = NdapiConstants.D2FC_DATY_DATE,
        Alpha = NdapiConstants.D2FC_DATY_ALPHA,
        Integer = NdapiConstants.D2FC_DATY_INTEGER,
        Datetime = NdapiConstants.D2FC_DATY_DATETIME,
        Long = NdapiConstants.D2FC_DATY_LONG,
        Rnumber = NdapiConstants.D2FC_DATY_RNUMBER,
        Jdate = NdapiConstants.D2FC_DATY_JDATE,
        Edate = NdapiConstants.D2FC_DATY_EDATE,
        Time = NdapiConstants.D2FC_DATY_TIME,
        Rinteger = NdapiConstants.D2FC_DATY_RINTEGER,
        Money = NdapiConstants.D2FC_DATY_MONEY,
        Rmoney = NdapiConstants.D2FC_DATY_RMONEY,
        Objectref = NdapiConstants.D2FC_DATY_OBJECTREF,
#if FORMS_6
        Lob = NdapiConstants.D2FC_DATY_LOB,
        File = NdapiConstants.D2FC_DATY_FILE
#endif
    }

    public enum ImageFormat
    {
        Bmp = NdapiConstants.D2FC_IMFM_BMP,
        Cals = NdapiConstants.D2FC_IMFM_CALS,
        Gif = NdapiConstants.D2FC_IMFM_GIF,
        Jfif = NdapiConstants.D2FC_IMFM_JFIF,
        Pict = NdapiConstants.D2FC_IMFM_PICT,
        Ras = NdapiConstants.D2FC_IMFM_RAS,
        Tiff = NdapiConstants.D2FC_IMFM_TIFF,
        Tpic = NdapiConstants.D2FC_IMFM_TPIC,
#if FORMS_12_OR_GREATER
        Native = NdapiConstants.D2FC_IMFM_NATIVE
#endif
    }

    public enum DisplayQuality
    {
        High = NdapiConstants.D2FC_DIQL_HIGH,
        Medium = NdapiConstants.D2FC_DIQL_MEDIUM,
        Low = NdapiConstants.D2FC_DIQL_LOW
    }

    public enum ImageSizingStyle
    {
        Crop = NdapiConstants.D2FC_SIST_CROP,
        Adjust = NdapiConstants.D2FC_SIST_ADJUST,
#if FORMS_12_OR_GREATER
        Fill = NdapiConstants.D2FC_SIST_FILL
#endif
    }

    public enum JoinStyle
    {
        Mitre = NdapiConstants.D2FC_JOST_MITRE,
        Bevel = NdapiConstants.D2FC_JOST_BEVEL,
        Round = NdapiConstants.D2FC_JOST_ROUND
    }

    public enum KeyMode
    {
        Unique = NdapiConstants.D2FC_KEMO_UNIQUE,
        Updateable = NdapiConstants.D2FC_KEMO_UPDATEABLE,
        NonUpdateable = NdapiConstants.D2FC_KEMO_NUPDATEABLE,
        Automatic = NdapiConstants.D2FC_KEMO_AUTO
    }

    public enum Alignment
    {
        Start = NdapiConstants.D2FC_ALIG_START,
        End = NdapiConstants.D2FC_ALIG_END,
        Center = NdapiConstants.D2FC_ALIG_CENTER
    }

    public enum InteractionMode
    {
        Blocking = NdapiConstants.D2FC_INMO_BLOCKING,
        NonBlocking = NdapiConstants.D2FC_INMO_NONBLOCKING
    }

    public enum IsolationMode
    {
        Read = NdapiConstants.D2FC_ISMO_READ,
        Serial = NdapiConstants.D2FC_ISMO_SERIAL
    }

    public enum LockingMode
    {
        Immediate = NdapiConstants.D2FC_LOMO_IMMEDIATE,
        Delayed = NdapiConstants.D2FC_LOMO_DELAYED,
        Automatic = NdapiConstants.D2FC_LOMO_AUTO
    }

    public enum ListStyle
    {
        Poplist = NdapiConstants.D2FC_LSST_POPLIST,
        Tlist = NdapiConstants.D2FC_LSST_TLIST,
        Combo = NdapiConstants.D2FC_LSST_COMBO
    }

    public enum ListType
    {
        RecordGroup = NdapiConstants.D2FC_LSTY_RECORDGROUP,
        Old = NdapiConstants.D2FC_LSTY_OLD
    }

    public enum MenuCommandType
    {
        Null = NdapiConstants.D2FC_COTY_NULL,
        Menu = NdapiConstants.D2FC_COTY_MENU,
        Plsql = NdapiConstants.D2FC_COTY_PLSQL,
#if FORMS_6
        Plus = NdapiConstants.D2FC_COTY_PLUS,
        Form = NdapiConstants.D2FC_COTY_FORM,
        Macro = NdapiConstants.D2FC_COTY_MACRO
#endif
    }

    public enum DeleteRecordBehavior
    {
        Cascading = NdapiConstants.D2FC_DERE_CASCADING,
        Isolated = NdapiConstants.D2FC_DERE_ISOLATED,
        NonIsolated = NdapiConstants.D2FC_DERE_NON_ISOLATED
    }

    public enum MagicMenuItemType
    {
        None = NdapiConstants.D2FC_MAIT_NONE,
        Cut = NdapiConstants.D2FC_MAIT_CUT,
        Copy = NdapiConstants.D2FC_MAIT_COPY,
        Paste = NdapiConstants.D2FC_MAIT_PASTE,
        Clear = NdapiConstants.D2FC_MAIT_CLEAR,
        Undo = NdapiConstants.D2FC_MAIT_UNDO,
        Help = NdapiConstants.D2FC_MAIT_HELP,
        About = NdapiConstants.D2FC_MAIT_ABOUT,
        Quit = NdapiConstants.D2FC_MAIT_QUIT,
        Window = NdapiConstants.D2FC_MAIT_WINDOW,
        PageSetup = NdapiConstants.D2FC_MAIT_PAGESETUP
    }

    public enum MouseNavigationLimit
    {
        Form = NdapiConstants.D2FC_MONA_FORM,
        Block = NdapiConstants.D2FC_MONA_BLOCK,
        Record = NdapiConstants.D2FC_MONA_RECORD,
        Item = NdapiConstants.D2FC_MONA_ITEM
    }
    
#if FORMS_6
    public enum MenuStyle
    {
        Pulldown = NdapiConstants.D2FC_MNST_PULLDOWN,
        Fullscreen = NdapiConstants.D2FC_MNST_FULLSCREEN
    }

    public enum MenuSource
    {
        File = NdapiConstants.D2FC_MNSR_FILE,
        Database = NdapiConstants.D2FC_MNSR_DB
    }
#endif

    public enum MenuItemType
    {
        Plain = NdapiConstants.D2FC_MNIT_PLAIN,
        Check = NdapiConstants.D2FC_MNIT_CHECK,
        Radio = NdapiConstants.D2FC_MNIT_RADIO,
        Separator = NdapiConstants.D2FC_MNIT_SEPARATOR,
        Magic = NdapiConstants.D2FC_MNIT_MAGIC
    }

    public enum NavigationStyle
    {
        SameRecord = NdapiConstants.D2FC_NAST_SAMERECORD,
        ChangeRecord = NdapiConstants.D2FC_NAST_CHANGERECORD,
        ChangeBlock = NdapiConstants.D2FC_NAST_CHANGEBLOCK
    }
    
#if FORMS_6
    public enum ModuleStorageType
    {
        Filesystem = NdapiConstants.D2FC_PAMO_FILESYSTEM,
        Database = NdapiConstants.D2FC_PAMO_DATABASE
    }
#endif
    
    public enum RecordOrientation
    {
        Vertical = NdapiConstants.D2FC_REOR_VERTICAL,
        Horizontal = NdapiConstants.D2FC_REOR_HORIZONTAL
    }

    public enum OleTenantTypes
    {
        Any = NdapiConstants.D2FC_OLTN_ANY,
        None = NdapiConstants.D2FC_OLTN_NONE,
        Static = NdapiConstants.D2FC_OLTN_STATIC,
        Linked = NdapiConstants.D2FC_OLTN_LINKED,
        Embedded = NdapiConstants.D2FC_OLTN_EMBEDDED,
        Control = NdapiConstants.D2FC_OLTN_CONTROL
    }

    public enum ParameterDataType
    {
        Char = NdapiConstants.D2FC_PADA_CHAR,
        Number = NdapiConstants.D2FC_PADA_NUMBER,
        Date = NdapiConstants.D2FC_PADA_DATE
    }

    public enum RecordGroupType
    {
        Query = NdapiConstants.D2FC_REGR_QUERY,
        Static = NdapiConstants.D2FC_REGR_STATIC
    }

    public enum ReadingOrder
    {
        Default = NdapiConstants.D2FC_READ_DEFAULT,
        LeftToRight = NdapiConstants.D2FC_READ_TORIGHT,
        RightToLeft = NdapiConstants.D2FC_READ_TOLEFT
    }

    public enum ReportDestinationType
    {
        Preview = NdapiConstants.D2FC_RPDE_PREVIEW,
        File = NdapiConstants.D2FC_RPDE_FILE,
        Printer = NdapiConstants.D2FC_RPDE_PRINTER,
        Mail = NdapiConstants.D2FC_RPDE_MAIL,
        Cache = NdapiConstants.D2FC_RPDE_CACHE,
        Screen = NdapiConstants.D2FC_RPDE_SCREEN
    }

    public enum OleResizeStyle
    {
        Clip = NdapiConstants.D2FC_OLRE_CLIP,
        Scale = NdapiConstants.D2FC_OLRE_SCALE,
        Initial = NdapiConstants.D2FC_OLRE_INITIAL,
        Dynamic = NdapiConstants.D2FC_OLRE_DYNAMIC
    }

    public enum SoundCompression
    {
        Auto = NdapiConstants.D2FC_COMP_AUTO,
        Off = NdapiConstants.D2FC_COMP_OFF,
        On = NdapiConstants.D2FC_COMP_ON
    }

    public enum SoundFormat
    {
        Au = NdapiConstants.D2FC_SNFM_AU,
        Aiff = NdapiConstants.D2FC_SNFM_AIFF,
        C = NdapiConstants.D2FC_SNFM_AIFF_C,
        Wave = NdapiConstants.D2FC_SNFM_WAVE
    }

    public enum SoundQuality
    {
        Auto = NdapiConstants.D2FC_SNQL_AUTO,
        Highest = NdapiConstants.D2FC_SNQL_HIGHEST,
        High = NdapiConstants.D2FC_SNQL_HIGH,
        Medium = NdapiConstants.D2FC_SNQL_MEDIUM,
        Low = NdapiConstants.D2FC_SNQL_LOW,
        Lowest = NdapiConstants.D2FC_SNQL_LOWEST
    }

    public enum ScrollBarOrientation
    {
        Vertical = NdapiConstants.D2FC_SCOR_VERTICAL,
        Horizontal = NdapiConstants.D2FC_SCOR_HORIZONTAL
    }

    public enum ScrollBarAlignment
    {
        Start = NdapiConstants.D2FC_SCAL_START,
        End = NdapiConstants.D2FC_SCAL_END
    }

    public enum LineSpacing
    {
        Single = NdapiConstants.D2FC_LISP_SINGLE,
        OneAndAHalf = NdapiConstants.D2FC_LISP_ONEHALF,
        Double = NdapiConstants.D2FC_LISP_DOUBLE,
        Custom = NdapiConstants.D2FC_LISP_CUSTOM
    }

    public enum SummaryFunction
    {
        None = NdapiConstants.D2FC_SUFU_NONE,
        Avg = NdapiConstants.D2FC_SUFU_AVG,
        Count = NdapiConstants.D2FC_SUFU_COUNT,
        Max = NdapiConstants.D2FC_SUFU_MAX,
        Min = NdapiConstants.D2FC_SUFU_MIN,
        Stddev = NdapiConstants.D2FC_SUFU_STDDEV,
        Sum = NdapiConstants.D2FC_SUFU_SUM,
        Var = NdapiConstants.D2FC_SUFU_VAR
    }

    public enum OleTenantAspect
    {
        Content = NdapiConstants.D2FC_OLET_CONTENT,
        Icon = NdapiConstants.D2FC_OLET_ICON,
        Thumbnail = NdapiConstants.D2FC_OLET_THUMBNAIL
    }

    public enum TriggerStyle
    {
        PLSQL = NdapiConstants.D2FC_TRST_PLSQL,
        V2 = NdapiConstants.D2FC_TRST_V2
    }
    
#if FORMS_6
    public enum TriggerType
    {
        Builtin = NdapiConstants.D2FC_TRTY_BUILTIN,
        Usernamed = NdapiConstants.D2FC_TRTY_USERNAMED
    }
#endif

    public enum VerticalOrigin
    {
        Top = NdapiConstants.D2FC_VEOR_TOP,
        Center = NdapiConstants.D2FC_VEOR_CENTER,
        Bottom = NdapiConstants.D2FC_VEOR_BOTTOM
    }

    public enum VerticalJustification
    {
        Top = NdapiConstants.D2FC_VEJU_TOP,
        Center = NdapiConstants.D2FC_VEJU_CENTER,
        Bottom = NdapiConstants.D2FC_VEJU_BOTTOM
    }

    public enum KeyboardState
    {
        Any = NdapiConstants.D2FC_KBST_ANY,
        Roman = NdapiConstants.D2FC_KBST_ROMAN,
        Native = NdapiConstants.D2FC_KBST_NATIVE
    }

    public enum ValidationUnit
    {
        Default = NdapiConstants.D2FC_VAUN_DEFAULT,
        Form = NdapiConstants.D2FC_VAUN_FORM,
        Block = NdapiConstants.D2FC_VAUN_BLOCK,
        Record = NdapiConstants.D2FC_VAUN_RECORD,
        Item = NdapiConstants.D2FC_VAUN_ITEM
    }

    public enum WrapStyle
    {
        None = NdapiConstants.D2FC_WRST_NONE,
        Character = NdapiConstants.D2FC_WRST_CHARACTER,
        Word = NdapiConstants.D2FC_WRST_WORD
    }

    public enum WindowStyle
    {
        Document = NdapiConstants.D2FC_WIST_DOCUMENT,
        Dialog = NdapiConstants.D2FC_WIST_DIALOG
    }

    public enum FrameTitleAlignment
    {
        Left = NdapiConstants.D2FC_JUST_LEFT,
        Right = NdapiConstants.D2FC_JUST_RIGHT,
        Center = NdapiConstants.D2FC_JUST_CENTER,
        Start = NdapiConstants.D2FC_JUST_START,
        End = NdapiConstants.D2FC_JUST_END
    }

    public enum PropertyType
    {
        Unknown = NdapiConstants.D2FP_TYP_UNKNOWN,
        Boolean = NdapiConstants.D2FP_TYP_BOOLEAN,
        Number = NdapiConstants.D2FP_TYP_NUMBER,
        Text = NdapiConstants.D2FP_TYP_TEXT,
        Object = NdapiConstants.D2FP_TYP_OBJECT
    }
    
#if FORMS_12_OR_GREATER
    public enum CursorStyle
    {
        Unspecified = NdapiConstants.D2FC_CURSOR_STYLE_UNSPECIFIED,
        Busy = NdapiConstants.D2FC_CURSOR_STYLE_BUSY,
        Crosshair = NdapiConstants.D2FC_CURSOR_STYLE_CROSSHAIR,
        DefaultCursor = NdapiConstants.D2FC_CURSOR_STYLE_DEFAULT,
        Insertion = NdapiConstants.D2FC_CURSOR_STYLE_INSERTION,
        Hand = NdapiConstants.D2FC_CURSOR_STYLE_HAND,
        Move = NdapiConstants.D2FC_CURSOR_STYLE_MOVE,
        NorthResize = NdapiConstants.D2FC_CURSOR_STYLE_NRESIZE,
        SouthResize = NdapiConstants.D2FC_CURSOR_STYLE_SRESIZE,
        EastResize = NdapiConstants.D2FC_CURSOR_STYLE_ERESIZE,
        WestResize = NdapiConstants.D2FC_CURSOR_STYLE_WRESIZE,
        NortheastResize = NdapiConstants.D2FC_CURSOR_STYLE_NERESIZE,
        Northwestresize = NdapiConstants.D2FC_CURSOR_STYLE_NWRESIZE,
        SoutheastResize = NdapiConstants.D2FC_CURSOR_STYLE_SERESIZE,
        SouthwestResize = NdapiConstants.D2FC_CURSOR_STYLE_SWRESIZE
    }

    public enum GradientStartSide
    {
        None = NdapiConstants.D2FC_GRADIENT_NONE,
        Left = NdapiConstants.D2FC_GRADIENT_LEFT,
        Top = NdapiConstants.D2FC_GRADIENT_TOP,
        Right = NdapiConstants.D2FC_GRADIENT_RIGHT,
        Bottom = NdapiConstants.D2FC_GRADIENT_BOTTOM
    }

    public enum EventType
    {
        Database = NdapiConstants.D2FC_EVENT_TYPE_DATABASE,
        UserDefined = NdapiConstants.D2FC_EVENT_TYPE_USERDEFINED,
        SystemIdle = NdapiConstants.D2FC_EVENT_TYPE_SYSTEMIDLE,
        SystemDbIdle = NdapiConstants.D2FC_EVENT_TYPE_SYSTEMDBIDLE,
        SystemLogout = NdapiConstants.D2FC_EVENT_TYPE_SYSTEMLOGOUT,
        SystemEmPing = NdapiConstants.D2FC_EVENT_TYPE_SYSTEMEMPING,
        SystemMediaDone = NdapiConstants.D2FC_EVENT_TYPE_SYSTEMMEDIADONE
    }

    public enum EventScope
    {
        Application = NdapiConstants.D2FC_EVENT_SCOPE_APPLICATION,
        Form = NdapiConstants.D2FC_EVENT_SCOPE_FORM
    }

    public enum EventViewMode
    {
        Browse = NdapiConstants.D2FC_EVENT_VIEW_MODE_BROWSE,
        Locked = NdapiConstants.D2FC_EVENT_VIEW_MODE_LOCKED,
        Remove = NdapiConstants.D2FC_EVENT_VIEW_MODE_REMOVE
    }
#endif
}