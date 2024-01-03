using Ndapi.Core;

namespace Ndapi.Enums;

public enum AlertButton
{
    Button1 = NdapiConstant.D2FC_DFAL_BTN1,
    Button2 = NdapiConstant.D2FC_DFAL_BTN2,
    Button3 = NdapiConstant.D2FC_DFAL_BTN3
}

public enum Justification
{
    Left = NdapiConstant.D2FC_JUST_LEFT,
    Right = NdapiConstant.D2FC_JUST_RIGHT,
    Center = NdapiConstant.D2FC_JUST_CENTER,
    Start = NdapiConstant.D2FC_JUST_START,
    End = NdapiConstant.D2FC_JUST_END
}

public enum AlertStyle
{
    Stop = NdapiConstant.D2FC_ALST_STOP,
    Caution = NdapiConstant.D2FC_ALST_CAUTION,
    Note = NdapiConstant.D2FC_ALST_NOTE
}

public enum DataSourceArgumentMode
{
    In = NdapiConstant.D2FC_DSMO_IN,
    Out = NdapiConstant.D2FC_DSMO_OUT,
    InOut = NdapiConstant.D2FC_DSMO_IN_OUT
}

public enum LineArrowStyle
{
    None = NdapiConstant.D2FC_ARST_NONE,
    Start = NdapiConstant.D2FC_ARST_START,
    End = NdapiConstant.D2FC_ARST_END,
    Both = NdapiConstant.D2FC_ARST_BOTH,
    MiddleToStart = NdapiConstant.D2FC_ARST_MDLTOSTRT,
    MiddleToEnd = NdapiConstant.D2FC_ARST_MDLTOEND
}

public enum GraphicsObjectType
{
    Arc = NdapiConstant.D2FC_GRTY_ARC,
    Image = NdapiConstant.D2FC_GRTY_IMAGE,
    Line = NdapiConstant.D2FC_GRTY_LINE,
    Polygon = NdapiConstant.D2FC_GRTY_POLY,
    Rectangle = NdapiConstant.D2FC_GRTY_RECT,
    RoundedRectangle = NdapiConstant.D2FC_GRTY_RREC,
    Text = NdapiConstant.D2FC_GRTY_TEXT,
    Group = NdapiConstant.D2FC_GRTY_GROUP,
    Frame = NdapiConstant.D2FC_GRTY_FRAME
}

public enum Bevel
{
    Raised = NdapiConstant.D2FC_BEST_RAISED,
    Lowered = NdapiConstant.D2FC_BEST_LOWERED,
    None = NdapiConstant.D2FC_BEST_NONE,
    Inset = NdapiConstant.D2FC_BEST_NSET,
    Outset = NdapiConstant.D2FC_BEST_OUTSET,
    Plain = NdapiConstant.D2FC_BEST_PLAIN
}

public enum DataSourceColumnType
{
    Varchar2 = NdapiConstant.D2FC_DSTY_VARCHAR2,
    Number = NdapiConstant.D2FC_DSTY_NUMBER,
    Long = NdapiConstant.D2FC_DSTY_LONG,
    Rowid = NdapiConstant.D2FC_DSTY_ROWID,
    Date = NdapiConstant.D2FC_DSTY_DATE,
    Raw = NdapiConstant.D2FC_DSTY_RAW,
    LongRaw = NdapiConstant.D2FC_DSTY_LONG_RAW,
    Char = NdapiConstant.D2FC_DSTY_CHAR,
    Mlslabel = NdapiConstant.D2FC_DSTY_MLSLABEL,
    Table = NdapiConstant.D2FC_DSTY_TABLE,
    Record = NdapiConstant.D2FC_DSTY_RECORD,
    Refcursor = NdapiConstant.D2FC_DSTY_REFCURSOR,
    Namedtype = NdapiConstant.D2FC_DSTY_NAMEDTYPE,
    Objectref = NdapiConstant.D2FC_DSTY_OBJECTREF,
    Varray = NdapiConstant.D2FC_DSTY_VARRAY,
    Nestedtab = NdapiConstant.D2FC_DSTY_NESTEDTAB,
    Blob = NdapiConstant.D2FC_DSTY_BLOB,
    Clob = NdapiConstant.D2FC_DSTY_CLOB,
    Bfile = NdapiConstant.D2FC_DSTY_BFILE,
#if FORMS_6
    Cfile = NdapiConstant.D2FC_DSTY_CFILE,
    Unknown = NdapiConstant.D2FC_DSTY_UNKNOWN
#endif
}

public enum CommunicationMode
{
    Synchronous = NdapiConstant.D2FC_COMO_SYNCH,
    Asynchronous = NdapiConstant.D2FC_COMO_ASYNCH
}

public enum CoordinateSystem
{
    Character = NdapiConstant.D2FC_COSY_CHARACTER,
    Real = NdapiConstant.D2FC_COSY_REAL
}

public enum QueryDataSourceType
{
    None = NdapiConstant.D2FC_QRDA_NONE,
    Table = NdapiConstant.D2FC_QRDA_TABLE,
    Procedure = NdapiConstant.D2FC_QRDA_PROCEDURE,
    Trig = NdapiConstant.D2FC_QRDA_TRANS_TRIG,
    Query = NdapiConstant.D2FC_QRDA_FRM_CLS_QUERY
}

public enum DMLDataTargetType
{
    None = NdapiConstant.D2FC_DMDA_NONE,
    Table = NdapiConstant.D2FC_DMDA_TABLE,
    Procedure = NdapiConstant.D2FC_DMDA_PROCEDURE,
    TransationalTrigger = NdapiConstant.D2FC_DMDA_TRANS_TRIG
}

public enum EdgeAtachmentType
{
    Start = NdapiConstant.D2FC_PRAT_START,
    End = NdapiConstant.D2FC_PRAT_END,
    Top = NdapiConstant.D2FC_PRAT_TOP,
    Bottom = NdapiConstant.D2FC_PRAT_BOTTOM
}

public enum ExecutionMode
{
    Batch = NdapiConstant.D2FC_EXMO_BATCH,
    Runtime = NdapiConstant.D2FC_EXMO_RUNTIME
}

public enum SourceType
{
    Filesystem = NdapiConstant.D2FC_LISR_FS,
    Database = NdapiConstant.D2FC_LISR_DB
}

public enum UpdateLayout
{
    Manual = NdapiConstant.D2FC_UPLA_MANUAL,
    Automatic = NdapiConstant.D2FC_UPLA_AUTO,
    Locked = NdapiConstant.D2FC_UPLA_LOCKED
}

public enum ItemType
{
    ChartArea = NdapiConstant.D2FC_ITTY_CA,
    CheckBox = NdapiConstant.D2FC_ITTY_CB,
    DisplayItem = NdapiConstant.D2FC_ITTY_DI,
    Image = NdapiConstant.D2FC_ITTY_IM,
    ListItem = NdapiConstant.D2FC_ITTY_LS,
    ActiveX = NdapiConstant.D2FC_ITTY_ACT,
    OLE = NdapiConstant.D2FC_ITTY_OLE,
    Button = NdapiConstant.D2FC_ITTY_PB,
    RadioGroup = NdapiConstant.D2FC_ITTY_RD,
    Sound = NdapiConstant.D2FC_ITTY_SN,
    TextItem = NdapiConstant.D2FC_ITTY_TI,
    UserArea = NdapiConstant.D2FC_ITTY_UA,
    VBX = NdapiConstant.D2FC_ITTY_VBX,
    Tree = NdapiConstant.D2FC_ITTY_TRE,
    Bean = NdapiConstant.D2FC_ITTY_BA
}

public enum OleActivationStyle
{
    Doubleclick = NdapiConstant.D2FC_OLAC_DOUBLECLICK,
    Manual = NdapiConstant.D2FC_OLAC_MANUAL,
    Focus = NdapiConstant.D2FC_OLAC_FOCUS
}

public enum PromptDisplayStyle
{
    Hidden = NdapiConstant.D2FC_PRDI_HIDDEN,
    First = NdapiConstant.D2FC_PRDI_FIRST,
    Each = NdapiConstant.D2FC_PRDI_EACH
}

public enum ProgramUnitType
{
    Unknown = NdapiConstant.D2FC_PGTY_UNKNOWN,
    Procedure = NdapiConstant.D2FC_PGTY_PROCEDURE,
    Function = NdapiConstant.D2FC_PGTY_FUNCTION,
    PackageSpecification = NdapiConstant.D2FC_PGTY_PACKAGESPEC,
    PackageBody = NdapiConstant.D2FC_PGTY_PACKAGEBODY
}

public enum RealUnit
{
    Pixel = NdapiConstant.D2FC_REUN_PIXEL,
    Centimeter = NdapiConstant.D2FC_REUN_CENTIMETER,
    Inch = NdapiConstant.D2FC_REUN_INCH,
    Point = NdapiConstant.D2FC_REUN_POINT,
    Decipoint = NdapiConstant.D2FC_REUN_DECIPOINT
}

public enum RelationType
{
    Join = NdapiConstant.D2FC_RELT_JOIN,
    Ref = NdapiConstant.D2FC_RELT_REF
}

public enum RuntimeCompatibility
{
    Forms_45 = NdapiConstant.D2FC_RUCO_45,
    Forms_50 = NdapiConstant.D2FC_RUCO_50
}

public enum TabAttachmentEdge
{
    Top = NdapiConstant.D2FC_TAAT_TOP,
    Bottom = NdapiConstant.D2FC_TAAT_BOTTOM,
    Left = NdapiConstant.D2FC_TAAT_LEFT,
    Right = NdapiConstant.D2FC_TAAT_RIGHT,
    Start = NdapiConstant.D2FC_TAAT_START,
    End = NdapiConstant.D2FC_TAAT_END
}

public enum TabStyle
{
    Chamfered = NdapiConstant.D2FC_TAST_CHAMFERED,
    Square = NdapiConstant.D2FC_TAST_SQUARE,
    Rounded = NdapiConstant.D2FC_TAST_ROUNDED
}

public enum VisualAttributeType
{
    Common = NdapiConstant.D2FC_VATY_COMMON,
    Prompt = NdapiConstant.D2FC_VATY_PROMPT,
    Title = NdapiConstant.D2FC_VATY_TITLE
}

public enum ColumnSpecificationDataType
{
    Char = NdapiConstant.D2FC_CODA_CHAR,
    Number = NdapiConstant.D2FC_CODA_NUMBER,
    Date = NdapiConstant.D2FC_CODA_DATE,
    Long = NdapiConstant.D2FC_CODA_LONG,
    RefObject = NdapiConstant.D2FC_CODA_REF
}

public enum SoundChannels
{
    Auto = NdapiConstant.D2FC_AUCH_AUTO,
    Mono = NdapiConstant.D2FC_AUCH_MONO,
    Stereo = NdapiConstant.D2FC_AUCH_STEREO
}

public enum CalculationMode
{
    None = NdapiConstant.D2FC_CAMO_NONE,
    Formula = NdapiConstant.D2FC_CAMO_FORMULA,
    Summary = NdapiConstant.D2FC_CAMO_SUMMARY
}

public enum CursorMode
{
    Open = NdapiConstant.D2FC_CRMO_OPEN,
    Close = NdapiConstant.D2FC_CRMO_CLOSE
}

public enum ObjectEdgeCapStyle
{
    Butt = NdapiConstant.D2FC_CAST_BUTT,
    Round = NdapiConstant.D2FC_CAST_ROUND,
    Projecting = NdapiConstant.D2FC_CAST_PROJECT
}

public enum CompressionQuality
{
    None = NdapiConstant.D2FC_CMQL_NONE,
    Min = NdapiConstant.D2FC_CMQL_MIN,
    Low = NdapiConstant.D2FC_CMQL_LOW,
    Med = NdapiConstant.D2FC_CMQL_MED,
    High = NdapiConstant.D2FC_CMQL_HIGH,
    Max = NdapiConstant.D2FC_CMQL_MAX
}

public enum CaseRestriction
{
    Mixed = NdapiConstant.D2FC_CARS_MIXED,
    Upper = NdapiConstant.D2FC_CARS_UPPER,
    Lower = NdapiConstant.D2FC_CARS_LOWER
}

public enum CanvasType
{
    Content = NdapiConstant.D2FC_CNTY_CONTENT,
    Stacked = NdapiConstant.D2FC_CNTY_STACKED,
    VerticalToolbar = NdapiConstant.D2FC_CNTY_VTOOLBAR,
    HorizontalToolbar = NdapiConstant.D2FC_CNTY_HTOOLBAR,
    Tab = NdapiConstant.D2FC_CNTY_TAB
}

public enum CheckBoxOtherValues
{
    Illegal = NdapiConstant.D2FC_CHBX_ILLEGAL,
    Checked = NdapiConstant.D2FC_CHBX_CHECKED,
    Unchecked = NdapiConstant.D2FC_CHBX_UNCHECKED
}

public enum LanguageDirection
{
    Default = NdapiConstant.D2FC_LADI_DEFAULT,
    LeftToRight = NdapiConstant.D2FC_LADI_TORIGHT,
    RigthToLeft = NdapiConstant.D2FC_LADI_TOLEFT
}

public enum InitialKeyboardDirection
{
    Default = NdapiConstant.D2FC_INKB_DEFAULT,
    Roman = NdapiConstant.D2FC_INKB_ROMAN,
    Native = NdapiConstant.D2FC_INKB_NATIVE
}

public enum ImageDepth
{
    Orig = NdapiConstant.D2FC_IMDP_ORIG,
    Mono = NdapiConstant.D2FC_IMDP_MONO,
    Gray = NdapiConstant.D2FC_IMDP_GRAY,
    Lut = NdapiConstant.D2FC_IMDP_LUT,
    Rgb = NdapiConstant.D2FC_IMDP_RGB
}

public enum DashStyle
{
    Solid = NdapiConstant.D2FC_DAST_SOLID,
    Dotted = NdapiConstant.D2FC_DAST_DOT,
    Dashed = NdapiConstant.D2FC_DAST_DASH,
    DashDot = NdapiConstant.D2FC_DAST_DASHDOT,
    DoubleDot = NdapiConstant.D2FC_DAST_DOUBDOT,
    LongDash = NdapiConstant.D2FC_DAST_LONGDASH,
    DashDoubleDot = NdapiConstant.D2FC_DAST_DASHDOUBDOT
}

public enum ExecutionStyle
{
    Override = NdapiConstant.D2FC_EXHI_OVERRIDE,
    Before = NdapiConstant.D2FC_EXHI_BEFORE,
    After = NdapiConstant.D2FC_EXHI_AFTER
}

public enum FrameAlignment
{
    Start = NdapiConstant.D2FC_FRAL_START,
    End = NdapiConstant.D2FC_FRAL_END,
    Center = NdapiConstant.D2FC_FRAL_CENTER,
    Fill = NdapiConstant.D2FC_FRAL_FILL,
    Column = NdapiConstant.D2FC_FRAL_COLUMN
}

public enum FontSpacing
{
    Ultradense = NdapiConstant.D2FC_FOSP_ULTRADENSE,
    Extradense = NdapiConstant.D2FC_FOSP_EXTRADENSE,
    Dense = NdapiConstant.D2FC_FOSP_DENSE,
    Semidense = NdapiConstant.D2FC_FOSP_SEMIDENSE,
    Normal = NdapiConstant.D2FC_FOSP_NORMAL,
    Semiexpand = NdapiConstant.D2FC_FOSP_SEMIEXPAND,
    Expand = NdapiConstant.D2FC_FOSP_EXPAND,
    Extraexpand = NdapiConstant.D2FC_FOSP_EXTRAEXPAND,
    Ultraexpand = NdapiConstant.D2FC_FOSP_ULTRAEXPAND
}

public enum FontStyle
{
    Plain = NdapiConstant.D2FC_FOST_PLAIN,
    Italic = NdapiConstant.D2FC_FOST_ITALIC,
    Oblique = NdapiConstant.D2FC_FOST_OBLIQUE,
    Underline = NdapiConstant.D2FC_FOST_UNDERLINE,
    Outline = NdapiConstant.D2FC_FOST_OUTLINE,
    Shadow = NdapiConstant.D2FC_FOST_SHADOW,
    Inverted = NdapiConstant.D2FC_FOST_INVERTED,
    Overstrike = NdapiConstant.D2FC_FOST_OVERSTRIKE,
    Blink = NdapiConstant.D2FC_FOST_BLINK
}

public enum FontWeight
{
    Ultralight = NdapiConstant.D2FC_FOWG_ULTRALIGHT,
    Extralight = NdapiConstant.D2FC_FOWG_EXTRALIGHT,
    Light = NdapiConstant.D2FC_FOWG_LIGHT,
    Demilight = NdapiConstant.D2FC_FOWG_DEMILIGHT,
    Medium = NdapiConstant.D2FC_FOWG_MEDIUM,
    Demibold = NdapiConstant.D2FC_FOWG_DEMIBOLD,
    Bold = NdapiConstant.D2FC_FOWG_BOLD,
    Extrabold = NdapiConstant.D2FC_FOWG_EXTRABOLD,
    Ultrabold = NdapiConstant.D2FC_FOWG_ULTRABOLD
}

public enum LayoutStyle
{
    Form = NdapiConstant.D2FC_LAST_FORM,
    Tabular = NdapiConstant.D2FC_LAST_TABULAR
}

public enum HorizontalOrigin
{
    Left = NdapiConstant.D2FC_HOOR_LEFT,
    Right = NdapiConstant.D2FC_HOOR_RIGHT,
    Center = NdapiConstant.D2FC_HOOR_CENTER
}

public enum HorizontalJustification
{
    Left = NdapiConstant.D2FC_HOJU_LEFT,
    Right = NdapiConstant.D2FC_HOJU_RIGHT,
    Center = NdapiConstant.D2FC_HOJU_CENTER,
    Start = NdapiConstant.D2FC_HOJU_START,
    End = NdapiConstant.D2FC_HOJU_END
}

public enum ItemDataType
{
    Char = NdapiConstant.D2FC_DATY_CHAR,
    Number = NdapiConstant.D2FC_DATY_NUMBER,
    Date = NdapiConstant.D2FC_DATY_DATE,
    Alpha = NdapiConstant.D2FC_DATY_ALPHA,
    Integer = NdapiConstant.D2FC_DATY_INTEGER,
    Datetime = NdapiConstant.D2FC_DATY_DATETIME,
    Long = NdapiConstant.D2FC_DATY_LONG,
    Rnumber = NdapiConstant.D2FC_DATY_RNUMBER,
    Jdate = NdapiConstant.D2FC_DATY_JDATE,
    Edate = NdapiConstant.D2FC_DATY_EDATE,
    Time = NdapiConstant.D2FC_DATY_TIME,
    Rinteger = NdapiConstant.D2FC_DATY_RINTEGER,
    Money = NdapiConstant.D2FC_DATY_MONEY,
    Rmoney = NdapiConstant.D2FC_DATY_RMONEY,
    Objectref = NdapiConstant.D2FC_DATY_OBJECTREF,
    Lob = NdapiConstant.D2FC_DATY_LOB,
    File = NdapiConstant.D2FC_DATY_FILE
}

public enum ImageFormat
{
    Bmp = NdapiConstant.D2FC_IMFM_BMP,
    Cals = NdapiConstant.D2FC_IMFM_CALS,
    Gif = NdapiConstant.D2FC_IMFM_GIF,
    Jfif = NdapiConstant.D2FC_IMFM_JFIF,
    Pict = NdapiConstant.D2FC_IMFM_PICT,
    Ras = NdapiConstant.D2FC_IMFM_RAS,
    Tiff = NdapiConstant.D2FC_IMFM_TIFF,
    Tpic = NdapiConstant.D2FC_IMFM_TPIC,
    Native = NdapiConstant.D2FC_IMFM_NATIVE
}

public enum DisplayQuality
{
    High = NdapiConstant.D2FC_DIQL_HIGH,
    Medium = NdapiConstant.D2FC_DIQL_MEDIUM,
    Low = NdapiConstant.D2FC_DIQL_LOW
}

public enum ImageSizingStyle
{
    Crop = NdapiConstant.D2FC_SIST_CROP,
    Adjust = NdapiConstant.D2FC_SIST_ADJUST,
    Fill = NdapiConstant.D2FC_SIST_FILL
}

public enum JoinStyle
{
    Mitre = NdapiConstant.D2FC_JOST_MITRE,
    Bevel = NdapiConstant.D2FC_JOST_BEVEL,
    Round = NdapiConstant.D2FC_JOST_ROUND
}

public enum KeyMode
{
    Unique = NdapiConstant.D2FC_KEMO_UNIQUE,
    Updateable = NdapiConstant.D2FC_KEMO_UPDATEABLE,
    NonUpdateable = NdapiConstant.D2FC_KEMO_NUPDATEABLE,
    Automatic = NdapiConstant.D2FC_KEMO_AUTO
}

public enum Alignment
{
    Start = NdapiConstant.D2FC_ALIG_START,
    End = NdapiConstant.D2FC_ALIG_END,
    Center = NdapiConstant.D2FC_ALIG_CENTER
}

public enum InteractionMode
{
    Blocking = NdapiConstant.D2FC_INMO_BLOCKING,
    NonBlocking = NdapiConstant.D2FC_INMO_NONBLOCKING
}

public enum IsolationMode
{
    Read = NdapiConstant.D2FC_ISMO_READ,
    Serial = NdapiConstant.D2FC_ISMO_SERIAL
}

public enum LockingMode
{
    Immediate = NdapiConstant.D2FC_LOMO_IMMEDIATE,
    Delayed = NdapiConstant.D2FC_LOMO_DELAYED,
    Automatic = NdapiConstant.D2FC_LOMO_AUTO
}

public enum ListStyle
{
    Poplist = NdapiConstant.D2FC_LSST_POPLIST,
    Tlist = NdapiConstant.D2FC_LSST_TLIST,
    Combo = NdapiConstant.D2FC_LSST_COMBO
}

public enum ListType
{
    RecordGroup = NdapiConstant.D2FC_LSTY_RECORDGROUP,
    Old = NdapiConstant.D2FC_LSTY_OLD
}

public enum MenuCommandType
{
    Null = NdapiConstant.D2FC_COTY_NULL,
    Menu = NdapiConstant.D2FC_COTY_MENU,
    Plsql = NdapiConstant.D2FC_COTY_PLSQL,
    Plus = NdapiConstant.D2FC_COTY_PLUS,
    Form = NdapiConstant.D2FC_COTY_FORM,
    Macro = NdapiConstant.D2FC_COTY_MACRO
}

public enum DeleteRecordBehavior
{
    Cascading = NdapiConstant.D2FC_DERE_CASCADING,
    Isolated = NdapiConstant.D2FC_DERE_ISOLATED,
    NonIsolated = NdapiConstant.D2FC_DERE_NON_ISOLATED
}

public enum MagicMenuItemType
{
    None = NdapiConstant.D2FC_MAIT_NONE,
    Cut = NdapiConstant.D2FC_MAIT_CUT,
    Copy = NdapiConstant.D2FC_MAIT_COPY,
    Paste = NdapiConstant.D2FC_MAIT_PASTE,
    Clear = NdapiConstant.D2FC_MAIT_CLEAR,
    Undo = NdapiConstant.D2FC_MAIT_UNDO,
    Help = NdapiConstant.D2FC_MAIT_HELP,
    About = NdapiConstant.D2FC_MAIT_ABOUT,
    Quit = NdapiConstant.D2FC_MAIT_QUIT,
    Window = NdapiConstant.D2FC_MAIT_WINDOW,
    PageSetup = NdapiConstant.D2FC_MAIT_PAGESETUP
}

public enum MouseNavigationLimit
{
    Form = NdapiConstant.D2FC_MONA_FORM,
    Block = NdapiConstant.D2FC_MONA_BLOCK,
    Record = NdapiConstant.D2FC_MONA_RECORD,
    Item = NdapiConstant.D2FC_MONA_ITEM
}

public enum MenuStyle
{
    Pulldown = NdapiConstant.D2FC_MNST_PULLDOWN,
    Fullscreen = NdapiConstant.D2FC_MNST_FULLSCREEN
}

public enum MenuSource
{
    File = NdapiConstant.D2FC_MNSR_FILE,
    Database = NdapiConstant.D2FC_MNSR_DB
}

public enum MenuItemType
{
    Plain = NdapiConstant.D2FC_MNIT_PLAIN,
    Check = NdapiConstant.D2FC_MNIT_CHECK,
    Radio = NdapiConstant.D2FC_MNIT_RADIO,
    Separator = NdapiConstant.D2FC_MNIT_SEPARATOR,
    Magic = NdapiConstant.D2FC_MNIT_MAGIC
}

public enum NavigationStyle
{
    SameRecord = NdapiConstant.D2FC_NAST_SAMERECORD,
    ChangeRecord = NdapiConstant.D2FC_NAST_CHANGERECORD,
    ChangeBlock = NdapiConstant.D2FC_NAST_CHANGEBLOCK
}

public enum ModuleStorageType
{
    Filesystem = NdapiConstant.D2FC_PAMO_FILESYSTEM,
    Database = NdapiConstant.D2FC_PAMO_DATABASE
}

public enum RecordOrientation
{
    Vertical = NdapiConstant.D2FC_REOR_VERTICAL,
    Horizontal = NdapiConstant.D2FC_REOR_HORIZONTAL
}

public enum OleTenantTypes
{
    Any = NdapiConstant.D2FC_OLTN_ANY,
    None = NdapiConstant.D2FC_OLTN_NONE,
    Static = NdapiConstant.D2FC_OLTN_STATIC,
    Linked = NdapiConstant.D2FC_OLTN_LINKED,
    Embedded = NdapiConstant.D2FC_OLTN_EMBEDDED,
    Control = NdapiConstant.D2FC_OLTN_CONTROL
}

public enum ParameterDataType
{
    Char = NdapiConstant.D2FC_PADA_CHAR,
    Number = NdapiConstant.D2FC_PADA_NUMBER,
    Date = NdapiConstant.D2FC_PADA_DATE
}

public enum RecordGroupType
{
    Query = NdapiConstant.D2FC_REGR_QUERY,
    Static = NdapiConstant.D2FC_REGR_STATIC
}

public enum ReadingOrder
{
    Default = NdapiConstant.D2FC_READ_DEFAULT,
    LeftToRight = NdapiConstant.D2FC_READ_TORIGHT,
    RightToLeft = NdapiConstant.D2FC_READ_TOLEFT
}

public enum ReportDestinationType
{
    Preview = NdapiConstant.D2FC_RPDE_PREVIEW,
    File = NdapiConstant.D2FC_RPDE_FILE,
    Printer = NdapiConstant.D2FC_RPDE_PRINTER,
    Mail = NdapiConstant.D2FC_RPDE_MAIL,
    Cache = NdapiConstant.D2FC_RPDE_CACHE,
    Screen = NdapiConstant.D2FC_RPDE_SCREEN
}

public enum OleResizeStyle
{
    Clip = NdapiConstant.D2FC_OLRE_CLIP,
    Scale = NdapiConstant.D2FC_OLRE_SCALE,
    Initial = NdapiConstant.D2FC_OLRE_INITIAL,
    Dynamic = NdapiConstant.D2FC_OLRE_DYNAMIC
}

public enum SoundCompression
{
    Auto = NdapiConstant.D2FC_COMP_AUTO,
    Off = NdapiConstant.D2FC_COMP_OFF,
    On = NdapiConstant.D2FC_COMP_ON
}

public enum SoundFormat
{
    Au = NdapiConstant.D2FC_SNFM_AU,
    Aiff = NdapiConstant.D2FC_SNFM_AIFF,
    C = NdapiConstant.D2FC_SNFM_AIFF_C,
    Wave = NdapiConstant.D2FC_SNFM_WAVE
}

public enum SoundQuality
{
    Auto = NdapiConstant.D2FC_SNQL_AUTO,
    Highest = NdapiConstant.D2FC_SNQL_HIGHEST,
    High = NdapiConstant.D2FC_SNQL_HIGH,
    Medium = NdapiConstant.D2FC_SNQL_MEDIUM,
    Low = NdapiConstant.D2FC_SNQL_LOW,
    Lowest = NdapiConstant.D2FC_SNQL_LOWEST
}

public enum ScrollBarOrientation
{
    Vertical = NdapiConstant.D2FC_SCOR_VERTICAL,
    Horizontal = NdapiConstant.D2FC_SCOR_HORIZONTAL
}

public enum ScrollBarAlignment
{
    Start = NdapiConstant.D2FC_SCAL_START,
    End = NdapiConstant.D2FC_SCAL_END
}

public enum LineSpacing
{
    Single = NdapiConstant.D2FC_LISP_SINGLE,
    OneAndAHalf = NdapiConstant.D2FC_LISP_ONEHALF,
    Double = NdapiConstant.D2FC_LISP_DOUBLE,
    Custom = NdapiConstant.D2FC_LISP_CUSTOM
}

public enum SummaryFunction
{
    None = NdapiConstant.D2FC_SUFU_NONE,
    Avg = NdapiConstant.D2FC_SUFU_AVG,
    Count = NdapiConstant.D2FC_SUFU_COUNT,
    Max = NdapiConstant.D2FC_SUFU_MAX,
    Min = NdapiConstant.D2FC_SUFU_MIN,
    Stddev = NdapiConstant.D2FC_SUFU_STDDEV,
    Sum = NdapiConstant.D2FC_SUFU_SUM,
    Var = NdapiConstant.D2FC_SUFU_VAR
}

public enum OleTenantAspect
{
    Content = NdapiConstant.D2FC_OLET_CONTENT,
    Icon = NdapiConstant.D2FC_OLET_ICON,
    Thumbnail = NdapiConstant.D2FC_OLET_THUMBNAIL
}

public enum TriggerStyle
{
    PLSQL = NdapiConstant.D2FC_TRST_PLSQL,
    V2 = NdapiConstant.D2FC_TRST_V2
}

public enum TriggerType
{
    Builtin = NdapiConstant.D2FC_TRTY_BUILTIN,
    Usernamed = NdapiConstant.D2FC_TRTY_USERNAMED
}

public enum VerticalOrigin
{
    Top = NdapiConstant.D2FC_VEOR_TOP,
    Center = NdapiConstant.D2FC_VEOR_CENTER,
    Bottom = NdapiConstant.D2FC_VEOR_BOTTOM
}

public enum VerticalJustification
{
    Top = NdapiConstant.D2FC_VEJU_TOP,
    Center = NdapiConstant.D2FC_VEJU_CENTER,
    Bottom = NdapiConstant.D2FC_VEJU_BOTTOM
}

public enum KeyboardState
{
    Any = NdapiConstant.D2FC_KBST_ANY,
    Roman = NdapiConstant.D2FC_KBST_ROMAN,
    Native = NdapiConstant.D2FC_KBST_NATIVE
}

public enum ValidationUnit
{
    Default = NdapiConstant.D2FC_VAUN_DEFAULT,
    Form = NdapiConstant.D2FC_VAUN_FORM,
    Block = NdapiConstant.D2FC_VAUN_BLOCK,
    Record = NdapiConstant.D2FC_VAUN_RECORD,
    Item = NdapiConstant.D2FC_VAUN_ITEM
}

public enum WrapStyle
{
    None = NdapiConstant.D2FC_WRST_NONE,
    Character = NdapiConstant.D2FC_WRST_CHARACTER,
    Word = NdapiConstant.D2FC_WRST_WORD
}

public enum WindowStyle
{
    Document = NdapiConstant.D2FC_WIST_DOCUMENT,
    Dialog = NdapiConstant.D2FC_WIST_DIALOG
}

public enum FrameTitleAlignment
{
    Left = NdapiConstant.D2FC_JUST_LEFT,
    Right = NdapiConstant.D2FC_JUST_RIGHT,
    Center = NdapiConstant.D2FC_JUST_CENTER,
    Start = NdapiConstant.D2FC_JUST_START,
    End = NdapiConstant.D2FC_JUST_END
}

public enum PropertyType
{
    Unknown = NdapiConstant.D2FP_TYP_UNKNOWN,
    Boolean = NdapiConstant.D2FP_TYP_BOOLEAN,
    Number = NdapiConstant.D2FP_TYP_NUMBER,
    Text = NdapiConstant.D2FP_TYP_TEXT,
    Object = NdapiConstant.D2FP_TYP_OBJECT
}

public enum CursorStyle
{
    Unspecified = NdapiConstant.D2FC_CURSOR_STYLE_UNSPECIFIED,
    Busy = NdapiConstant.D2FC_CURSOR_STYLE_BUSY,
    Crosshair = NdapiConstant.D2FC_CURSOR_STYLE_CROSSHAIR,
    DefaultCursor = NdapiConstant.D2FC_CURSOR_STYLE_DEFAULT,
    Insertion = NdapiConstant.D2FC_CURSOR_STYLE_INSERTION,
    Hand = NdapiConstant.D2FC_CURSOR_STYLE_HAND,
    Move = NdapiConstant.D2FC_CURSOR_STYLE_MOVE,
    NorthResize = NdapiConstant.D2FC_CURSOR_STYLE_NRESIZE,
    SouthResize = NdapiConstant.D2FC_CURSOR_STYLE_SRESIZE,
    EastResize = NdapiConstant.D2FC_CURSOR_STYLE_ERESIZE,
    WestResize = NdapiConstant.D2FC_CURSOR_STYLE_WRESIZE,
    NortheastResize = NdapiConstant.D2FC_CURSOR_STYLE_NERESIZE,
    Northwestresize = NdapiConstant.D2FC_CURSOR_STYLE_NWRESIZE,
    SoutheastResize = NdapiConstant.D2FC_CURSOR_STYLE_SERESIZE,
    SouthwestResize = NdapiConstant.D2FC_CURSOR_STYLE_SWRESIZE
}

public enum GradientStartSide
{
    None = NdapiConstant.D2FC_GRADIENT_NONE,
    Left = NdapiConstant.D2FC_GRADIENT_LEFT,
    Top = NdapiConstant.D2FC_GRADIENT_TOP,
    Right = NdapiConstant.D2FC_GRADIENT_RIGHT,
    Bottom = NdapiConstant.D2FC_GRADIENT_BOTTOM
}

public enum EventType
{
    Database = NdapiConstant.D2FC_EVENT_TYPE_DATABASE,
    UserDefined = NdapiConstant.D2FC_EVENT_TYPE_USERDEFINED,
    SystemIdle = NdapiConstant.D2FC_EVENT_TYPE_SYSTEMIDLE,
    SystemDbIdle = NdapiConstant.D2FC_EVENT_TYPE_SYSTEMDBIDLE,
    SystemLogout = NdapiConstant.D2FC_EVENT_TYPE_SYSTEMLOGOUT,
    SystemEmPing = NdapiConstant.D2FC_EVENT_TYPE_SYSTEMEMPING,
    SystemMediaDone = NdapiConstant.D2FC_EVENT_TYPE_SYSTEMMEDIADONE
}

public enum EventScope
{
    Application = NdapiConstant.D2FC_EVENT_SCOPE_APPLICATION,
    Form = NdapiConstant.D2FC_EVENT_SCOPE_FORM
}

public enum EventViewMode
{
    Browse = NdapiConstant.D2FC_EVENT_VIEW_MODE_BROWSE,
    Locked = NdapiConstant.D2FC_EVENT_VIEW_MODE_LOCKED,
    Remove = NdapiConstant.D2FC_EVENT_VIEW_MODE_REMOVE
}
