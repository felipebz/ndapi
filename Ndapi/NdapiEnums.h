#pragma once

#include <D2FDEF.H>

namespace Ndapi
{
	public enum class AlertButton : long
	{
		Button1 = D2FC_DFAL_BTN1,
		Button2 = D2FC_DFAL_BTN2,
		Button3 = D2FC_DFAL_BTN3
	};

	public enum class Justification : long
	{
		Left = D2FC_JUST_LEFT,
		Right = D2FC_JUST_RIGHT,
		Center = D2FC_JUST_CENTER,
		Start = D2FC_JUST_START,
		End = D2FC_JUST_END
	};

	public enum class AlertStyle : long
	{
		Stop = D2FC_ALST_STOP,
		Caution = D2FC_ALST_CAUTION,
		Note = D2FC_ALST_NOTE
	};

	public enum class DataSourceArgumentMode : long
	{
		In = D2FC_DSMO_IN,
		Out = D2FC_DSMO_OUT,
		InOut = D2FC_DSMO_IN_OUT
	};

	public enum class LineArrowStyle : long
	{
		None = D2FC_ARST_NONE,
		Start = D2FC_ARST_START,
		End = D2FC_ARST_END,
		Both = D2FC_ARST_BOTH,
		MiddleToStart = D2FC_ARST_MDLTOSTRT,
		MiddleToEnd = D2FC_ARST_MDLTOEND
	};

	public enum class GraphicsObjectType : long
	{
		Arc = D2FC_GRTY_ARC,
		Image = D2FC_GRTY_IMAGE,
		Line = D2FC_GRTY_LINE,
		Polygon = D2FC_GRTY_POLY,
		Rectangle = D2FC_GRTY_RECT,
		RoundedRectangle = D2FC_GRTY_RREC,
		Text = D2FC_GRTY_TEXT,
		Group = D2FC_GRTY_GROUP,
		Frame = D2FC_GRTY_FRAME
	};

	public enum class Bevel : long
	{
		Raised = D2FC_BEST_RAISED,
		Lowered = D2FC_BEST_LOWERED,
		None = D2FC_BEST_NONE,
		Inset = D2FC_BEST_NSET,
		Outset = D2FC_BEST_OUTSET,
		Plain = D2FC_BEST_PLAIN
	};

	public enum class DataSourceColumnType : long
	{
		Varchar2 = D2FC_DSTY_VARCHAR2,
		Number = D2FC_DSTY_NUMBER,
		Long = D2FC_DSTY_LONG,
		Rowid = D2FC_DSTY_ROWID,
		Date = D2FC_DSTY_DATE,
		Raw = D2FC_DSTY_RAW,
		LongRaw = D2FC_DSTY_LONG_RAW,
		Char = D2FC_DSTY_CHAR,
		Mlslabel = D2FC_DSTY_MLSLABEL,
		Table = D2FC_DSTY_TABLE,
		Record = D2FC_DSTY_RECORD,
		Refcursor = D2FC_DSTY_REFCURSOR,
		Namedtype = D2FC_DSTY_NAMEDTYPE,
		Objectref = D2FC_DSTY_OBJECTREF,
		Varray = D2FC_DSTY_VARRAY,
		Nestedtab = D2FC_DSTY_NESTEDTAB,
		Blob = D2FC_DSTY_BLOB,
		Clob = D2FC_DSTY_CLOB,
		Bfile = D2FC_DSTY_BFILE,
		Cfile = D2FC_DSTY_CFILE,
		Unknown = D2FC_DSTY_UNKNOWN
	};

	public enum class CommunicationMode : long
	{
		Synch = D2FC_COMO_SYNCH,
		Asynch = D2FC_COMO_ASYNCH
	};

	public enum class CoordinateSystem : long
	{
		Character = D2FC_COSY_CHARACTER,
		Real = D2FC_COSY_REAL
	};

	public enum class DataSourceQueryType : long
	{
		None = D2FC_QRDA_NONE,
		Table = D2FC_QRDA_TABLE,
		Procedure = D2FC_QRDA_PROCEDURE,
		Trig = D2FC_QRDA_TRANS_TRIG,
		Query = D2FC_QRDA_FRM_CLS_QUERY
	};

	public enum class DMLDataTargetType : long
	{
		None = D2FC_DMDA_NONE,
		Table = D2FC_DMDA_TABLE,
		Procedure = D2FC_DMDA_PROCEDURE,
		TransationalTrigger = D2FC_DMDA_TRANS_TRIG
	};

	public enum class EdgeAtachmentType : long
	{
		Start = D2FC_PRAT_START,
		End = D2FC_PRAT_END,
		Top = D2FC_PRAT_TOP,
		Bottom = D2FC_PRAT_BOTTOM
	};

	public enum class ExecutionMode : long
	{
		Batch = D2FC_EXMO_BATCH,
		Runtime = D2FC_EXMO_RUNTIME
	};

	public enum class SourceType : long
	{
		Filesystem = D2FC_LISR_FS,
		Database = D2FC_LISR_DB
	};

	public enum class UpdateLayout : long
	{
		Manual = D2FC_UPLA_MANUAL,
		Automatic = D2FC_UPLA_AUTO,
		Locked = D2FC_UPLA_LOCKED
	};

	public enum class ItemType : long
	{
		ChartArea = D2FC_ITTY_CA,
		CheckBox = D2FC_ITTY_CB,
		DisplayItem = D2FC_ITTY_DI,
		Image = D2FC_ITTY_IM,
		ListItem = D2FC_ITTY_LS,
		ActiveX = D2FC_ITTY_ACT,
		OLE = D2FC_ITTY_OLE,
		Button = D2FC_ITTY_PB,
		RadioGroup = D2FC_ITTY_RD,
		Sound = D2FC_ITTY_SN,
		TextItem = D2FC_ITTY_TI,
		UserArea = D2FC_ITTY_UA,
		VBX = D2FC_ITTY_VBX,
		Tree = D2FC_ITTY_TRE,
		Bean = D2FC_ITTY_BA
	};

	public enum class OleActivationStyle : long
	{
		Doubleclick = D2FC_OLAC_DOUBLECLICK,
		Manual = D2FC_OLAC_MANUAL,
		Focus = D2FC_OLAC_FOCUS
	};

	public enum class PromptDisplayStyle : long
	{
		Hidden = D2FC_PRDI_HIDDEN,
		First = D2FC_PRDI_FIRST,
		Each = D2FC_PRDI_EACH
	};

	public enum class ProgramUnitType : long
	{
		Unknown = D2FC_PGTY_UNKNOWN,
		Procedure = D2FC_PGTY_PROCEDURE,
		Function = D2FC_PGTY_FUNCTION,
		PackageSpecification = D2FC_PGTY_PACKAGESPEC,
		PackageBody = D2FC_PGTY_PACKAGEBODY
	};

	public enum class RealUnit : long
	{
		Pixel = D2FC_REUN_PIXEL,
		Centimeter = D2FC_REUN_CENTIMETER,
		Inch = D2FC_REUN_INCH,
		Point = D2FC_REUN_POINT,
		Decipoint = D2FC_REUN_DECIPOINT
	};

	public enum class RelationType : long
	{
		Join = D2FC_RELT_JOIN,
		Ref = D2FC_RELT_REF
	};

	public enum class RuntimeCompatibility : long
	{
		Forms_45 = D2FC_RUCO_45,
		Forms_50 = D2FC_RUCO_50
	};

	public enum class TabAttachmentEdge : long
	{
		Top = D2FC_TAAT_TOP,
		Bottom = D2FC_TAAT_BOTTOM,
		Left = D2FC_TAAT_LEFT,
		Right = D2FC_TAAT_RIGHT,
		Start = D2FC_TAAT_START,
		End = D2FC_TAAT_END
	};

	public enum class TabStyle : long
	{
		Chamfered = D2FC_TAST_CHAMFERED,
		Square = D2FC_TAST_SQUARE,
		Rounded = D2FC_TAST_ROUNDED
	};

	public enum class VisualAttributeType : long
	{
		Common = D2FC_VATY_COMMON,
		Prompt = D2FC_VATY_PROMPT,
		Title = D2FC_VATY_TITLE
	};

	public enum class ColumnSpecificationDataType : long
	{
		Char = D2FC_CODA_CHAR,
		Number = D2FC_CODA_NUMBER,
		Date = D2FC_CODA_DATE,
		Long = D2FC_CODA_LONG,
		RefObject = D2FC_CODA_REF
	};

	public enum class SoundChannels : long
	{
		Auto = D2FC_AUCH_AUTO,
		Mono = D2FC_AUCH_MONO,
		Stereo = D2FC_AUCH_STEREO
	};

	public enum class CalculationMode : long
	{
		None = D2FC_CAMO_NONE,
		Formula = D2FC_CAMO_FORMULA,
		Summary = D2FC_CAMO_SUMMARY
	};

	public enum class CursorMode : long
	{
		Open = D2FC_CRMO_OPEN,
		Close = D2FC_CRMO_CLOSE
	};

	public enum class ObjectEdgeCapStyle : long
	{
		Butt = D2FC_CAST_BUTT,
		Round = D2FC_CAST_ROUND,
		Projecting = D2FC_CAST_PROJECT
	};

	public enum class CompressionQuality : long
	{
		None = D2FC_CMQL_NONE,
		Min = D2FC_CMQL_MIN,
		Low = D2FC_CMQL_LOW,
		Med = D2FC_CMQL_MED,
		High = D2FC_CMQL_HIGH,
		Max = D2FC_CMQL_MAX
	};

	public enum class CaseRestriction : long
	{
		Mixed = D2FC_CARS_MIXED,
		Upper = D2FC_CARS_UPPER,
		Lower = D2FC_CARS_LOWER
	};

	public enum class CanvasType : long
	{
		Content = D2FC_CNTY_CONTENT,
		Stacked = D2FC_CNTY_STACKED,
		VerticalToolbar = D2FC_CNTY_VTOOLBAR,
		HorizontalToolbar = D2FC_CNTY_HTOOLBAR,
		Tab = D2FC_CNTY_TAB
	};

	public enum class CheckBoxOtherValues : long
	{
		Illegal = D2FC_CHBX_ILLEGAL,
		Checked = D2FC_CHBX_CHECKED,
		Unchecked = D2FC_CHBX_UNCHECKED
	};

	public enum class LanguageDirection : long
	{
		Default = D2FC_LADI_DEFAULT,
		LeftToRight = D2FC_LADI_TORIGHT,
		RigthToLeft = D2FC_LADI_TOLEFT
	};

	public enum class InitialKeyboardDirection : long
	{
		Default = D2FC_INKB_DEFAULT,
		Roman = D2FC_INKB_ROMAN,
		Native = D2FC_INKB_NATIVE
	};

	public enum class ImageDepth : long
	{
		Orig = D2FC_IMDP_ORIG,
		Mono = D2FC_IMDP_MONO,
		Gray = D2FC_IMDP_GRAY,
		Lut = D2FC_IMDP_LUT,
		Rgb = D2FC_IMDP_RGB
	};

	public enum class DashStyle : long
	{
		Solid = D2FC_DAST_SOLID,
		Dotted = D2FC_DAST_DOT,
		Dashed = D2FC_DAST_DASH,
		DashDot = D2FC_DAST_DASHDOT,
		DoubleDot = D2FC_DAST_DOUBDOT,
		LongDash = D2FC_DAST_LONGDASH,
		DashDoubleDot = D2FC_DAST_DASHDOUBDOT
	};

	public enum class ExecutionStyle : long
	{
		Override = D2FC_EXHI_OVERRIDE,
		Before = D2FC_EXHI_BEFORE,
		After = D2FC_EXHI_AFTER
	};

	public enum class FrameAlignment : long
	{
		Start = D2FC_FRAL_START,
		End = D2FC_FRAL_END,
		Center = D2FC_FRAL_CENTER,
		Fill = D2FC_FRAL_FILL,
		Column = D2FC_FRAL_COLUMN
	};

	public enum class FontSpacing : long
	{
		Ultradense = D2FC_FOSP_ULTRADENSE,
		Extradense = D2FC_FOSP_EXTRADENSE,
		Dense = D2FC_FOSP_DENSE,
		Semidense = D2FC_FOSP_SEMIDENSE,
		Normal = D2FC_FOSP_NORMAL,
		Semiexpand = D2FC_FOSP_SEMIEXPAND,
		Expand = D2FC_FOSP_EXPAND,
		Extraexpand = D2FC_FOSP_EXTRAEXPAND,
		Ultraexpand = D2FC_FOSP_ULTRAEXPAND
	};

	public enum class FontStyle : long
	{
		Plain = D2FC_FOST_PLAIN,
		Italic = D2FC_FOST_ITALIC,
		Oblique = D2FC_FOST_OBLIQUE,
		Underline = D2FC_FOST_UNDERLINE,
		Outline = D2FC_FOST_OUTLINE,
		Shadow = D2FC_FOST_SHADOW,
		Inverted = D2FC_FOST_INVERTED,
		Overstrike = D2FC_FOST_OVERSTRIKE,
		Blink = D2FC_FOST_BLINK
	};

	public enum class FontWeight : long
	{
		Ultralight = D2FC_FOWG_ULTRALIGHT,
		Extralight = D2FC_FOWG_EXTRALIGHT,
		Light = D2FC_FOWG_LIGHT,
		Demilight = D2FC_FOWG_DEMILIGHT,
		Medium = D2FC_FOWG_MEDIUM,
		Demibold = D2FC_FOWG_DEMIBOLD,
		Bold = D2FC_FOWG_BOLD,
		Extrabold = D2FC_FOWG_EXTRABOLD,
		Ultrabold = D2FC_FOWG_ULTRABOLD
	};

	public enum class LayoutStyle : long
	{
		Form = D2FC_LAST_FORM,
		Tabular = D2FC_LAST_TABULAR
	};

	public enum class HorizontalOrigin : long
	{
		Left = D2FC_HOOR_LEFT,
		Right = D2FC_HOOR_RIGHT,
		Center = D2FC_HOOR_CENTER
	};

	public enum class HorizontalJustification : long
	{
		Left = D2FC_HOJU_LEFT,
		Right = D2FC_HOJU_RIGHT,
		Center = D2FC_HOJU_CENTER,
		Start = D2FC_HOJU_START,
		End = D2FC_HOJU_END
	};

	public enum class ItemDataType : long
	{
		Char = D2FC_DATY_CHAR,
		Number = D2FC_DATY_NUMBER,
		Date = D2FC_DATY_DATE,
		Alpha = D2FC_DATY_ALPHA,
		Integer = D2FC_DATY_INTEGER,
		Datetime = D2FC_DATY_DATETIME,
		Long = D2FC_DATY_LONG,
		Rnumber = D2FC_DATY_RNUMBER,
		Jdate = D2FC_DATY_JDATE,
		Edate = D2FC_DATY_EDATE,
		Time = D2FC_DATY_TIME,
		Rinteger = D2FC_DATY_RINTEGER,
		Money = D2FC_DATY_MONEY,
		Rmoney = D2FC_DATY_RMONEY,
		Objectref = D2FC_DATY_OBJECTREF,
		Lob = D2FC_DATY_LOB,
		File = D2FC_DATY_FILE
	};

	public enum class ImageStorageFormat : long
	{
		Bmp = D2FC_IMFM_BMP,
		Cals = D2FC_IMFM_CALS,
		Gif = D2FC_IMFM_GIF,
		Jfif = D2FC_IMFM_JFIF,
		Pict = D2FC_IMFM_PICT,
		Ras = D2FC_IMFM_RAS,
		Tiff = D2FC_IMFM_TIFF,
		Tpic = D2FC_IMFM_TPIC
	};

	public enum class DisplayQuality : long
	{
		High = D2FC_DIQL_HIGH,
		Medium = D2FC_DIQL_MEDIUM,
		Low = D2FC_DIQL_LOW
	};

	public enum class ImageSizingStyle : long
	{
		Crop = D2FC_SIST_CROP,
		Adjust = D2FC_SIST_ADJUST
	};

	public enum class JoinStyle : long
	{
		Mitre = D2FC_JOST_MITRE,
		Bevel = D2FC_JOST_BEVEL,
		Round = D2FC_JOST_ROUND
	};

	public enum class KeyMode : long
	{
		Unique = D2FC_KEMO_UNIQUE,
		Updateable = D2FC_KEMO_UPDATEABLE,
		NonUpdateable = D2FC_KEMO_NUPDATEABLE,
		Automatic = D2FC_KEMO_AUTO
	};

	public enum class Alignment : long
	{
		Start = D2FC_ALIG_START,
		End = D2FC_ALIG_END,
		Center = D2FC_ALIG_CENTER
	};

	public enum class InteractionMode : long
	{
		Blocking = D2FC_INMO_BLOCKING,
		NonBlocking = D2FC_INMO_NONBLOCKING
	};

	public enum class IsolationMode : long
	{
		Read = D2FC_ISMO_READ,
		Serial = D2FC_ISMO_SERIAL
	};

	public enum class LockingMode : long
	{
		Immediate = D2FC_LOMO_IMMEDIATE,
		Delayed = D2FC_LOMO_DELAYED,
		Automatic = D2FC_LOMO_AUTO
	};

	public enum class ListStyle : long
	{
		Poplist = D2FC_LSST_POPLIST,
		Tlist = D2FC_LSST_TLIST,
		Combo = D2FC_LSST_COMBO
	};

	public enum class ListType : long
	{
		RecordGroup = D2FC_LSTY_RECORDGROUP,
		Old = D2FC_LSTY_OLD
	};

	public enum class MenuCommandType : long
	{
		Null = D2FC_COTY_NULL,
		Menu = D2FC_COTY_MENU,
		Plsql = D2FC_COTY_PLSQL,
		Plus = D2FC_COTY_PLUS,
		Form = D2FC_COTY_FORM,
		Macro = D2FC_COTY_MACRO
	};

	public enum class DeleteRecordBehavior : long
	{
		Cascading = D2FC_DERE_CASCADING,
		Isolated = D2FC_DERE_ISOLATED,
		NonIsolated = D2FC_DERE_NON_ISOLATED
	};

	public enum class MagicMenuItemType : long
	{
		None = D2FC_MAIT_NONE,
		Cut = D2FC_MAIT_CUT,
		Copy = D2FC_MAIT_COPY,
		Paste = D2FC_MAIT_PASTE,
		Clear = D2FC_MAIT_CLEAR,
		Undo = D2FC_MAIT_UNDO,
		Help = D2FC_MAIT_HELP,
		About = D2FC_MAIT_ABOUT,
		Quit = D2FC_MAIT_QUIT,
		Window = D2FC_MAIT_WINDOW,
		Pagesetup = D2FC_MAIT_PAGESETUP
	};

	public enum class MouseNavigationLimit : long
	{
		Form = D2FC_MONA_FORM,
		Block = D2FC_MONA_BLOCK,
		Record = D2FC_MONA_RECORD,
		Item = D2FC_MONA_ITEM
	};

	public enum class MenuStyle : long
	{
		Pulldown = D2FC_MNST_PULLDOWN,
		Fullscreen = D2FC_MNST_FULLSCREEN
	};

	public enum class MenuSource : long
	{
		File = D2FC_MNSR_FILE,
		Database = D2FC_MNSR_DB
	};

	public enum class MenuItemType : long
	{
		Plain = D2FC_MNIT_PLAIN,
		Check = D2FC_MNIT_CHECK,
		Radio = D2FC_MNIT_RADIO,
		Separator = D2FC_MNIT_SEPARATOR,
		Magic = D2FC_MNIT_MAGIC
	};

	public enum class NavigationStyle : long
	{
		SameRecord = D2FC_NAST_SAMERECORD,
		ChangeRecord = D2FC_NAST_CHANGERECORD,
		ChangeBlock = D2FC_NAST_CHANGEBLOCK
	};

	public enum class ModuleStorageType : long
	{
		Filesystem = D2FC_PAMO_FILESYSTEM,
		Database = D2FC_PAMO_DATABASE
	};

	public enum class RecordOrientation : long
	{
		Vertical = D2FC_REOR_VERTICAL,
		Horizontal = D2FC_REOR_HORIZONTAL
	};

	public enum class OleTenantTypes : long
	{
		Any = D2FC_OLTN_ANY,
		None = D2FC_OLTN_NONE,
		Static = D2FC_OLTN_STATIC,
		Linked = D2FC_OLTN_LINKED,
		Embedded = D2FC_OLTN_EMBEDDED,
		Control = D2FC_OLTN_CONTROL
	};

	public enum class ParameterDataType : long
	{
		Char = D2FC_PADA_CHAR,
		Number = D2FC_PADA_NUMBER,
		Date = D2FC_PADA_DATE
	};

	public enum class RecordGroupType : long
	{
		Query = D2FC_REGR_QUERY,
		Static = D2FC_REGR_STATIC
	};

	public enum class TitleReadingOrder : long
	{
		Default = D2FC_READ_DEFAULT,
		LeftToRight = D2FC_READ_TORIGHT,
		RightToLeft = D2FC_READ_TOLEFT
	};

	public enum class ReportDestinationType : long
	{
		Preview = D2FC_RPDE_PREVIEW,
		File = D2FC_RPDE_FILE,
		Printer = D2FC_RPDE_PRINTER,
		Mail = D2FC_RPDE_MAIL,
		Cache = D2FC_RPDE_CACHE,
		Screen = D2FC_RPDE_SCREEN
	};

	public enum class OleResizeStyle : long
	{
		Clip = D2FC_OLRE_CLIP,
		Scale = D2FC_OLRE_SCALE,
		Initial = D2FC_OLRE_INITIAL,
		Dynamic = D2FC_OLRE_DYNAMIC
	};

	public enum class SoundCompression : long
	{
		Auto = D2FC_COMP_AUTO,
		Off = D2FC_COMP_OFF,
		On = D2FC_COMP_ON
	};

	public enum class SoundFormat : long
	{
		Au = D2FC_SNFM_AU,
		Aiff = D2FC_SNFM_AIFF,
		C = D2FC_SNFM_AIFF_C,
		Wave = D2FC_SNFM_WAVE
	};

	public enum class SoundQuality : long
	{
		Auto = D2FC_SNQL_AUTO,
		Highest = D2FC_SNQL_HIGHEST,
		High = D2FC_SNQL_HIGH,
		Medium = D2FC_SNQL_MEDIUM,
		Low = D2FC_SNQL_LOW,
		Lowest = D2FC_SNQL_LOWEST
	};

	public enum class ScrollBarOrientation : long
	{
		Vertical = D2FC_SCOR_VERTICAL,
		Horizontal = D2FC_SCOR_HORIZONTAL
	};

	public enum class ScrollBarAlignment : long
	{
		Start = D2FC_SCAL_START,
		End = D2FC_SCAL_END
	};

	public enum class LineSpacing : long
	{
		Single = D2FC_LISP_SINGLE,
		OneAndAHalf = D2FC_LISP_ONEHALF,
		Double = D2FC_LISP_DOUBLE,
		Custom = D2FC_LISP_CUSTOM
	};

	public enum class SummaryFunction : long
	{
		None = D2FC_SUFU_NONE,
		Avg = D2FC_SUFU_AVG,
		Count = D2FC_SUFU_COUNT,
		Max = D2FC_SUFU_MAX,
		Min = D2FC_SUFU_MIN,
		Stddev = D2FC_SUFU_STDDEV,
		Sum = D2FC_SUFU_SUM,
		Var = D2FC_SUFU_VAR
	};

	public enum class OleTenantAspect : long
	{
		Content = D2FC_OLET_CONTENT,
		Icon = D2FC_OLET_ICON,
		Thumbnail = D2FC_OLET_THUMBNAIL
	};

	public enum class TriggerStyle : long
	{
		PLSQL = D2FC_TRST_PLSQL,
		V2 = D2FC_TRST_V2
	};

	public enum class TriggerType : long
	{
		Builtin = D2FC_TRTY_BUILTIN,
		Usernamed = D2FC_TRTY_USERNAMED
	};

	public enum class VerticalOrigin : long
	{
		Top = D2FC_VEOR_TOP,
		Center = D2FC_VEOR_CENTER,
		Bottom = D2FC_VEOR_BOTTOM
	};

	public enum class VerticalJustification : long
	{
		Top = D2FC_VEJU_TOP,
		Center = D2FC_VEJU_CENTER,
		Bottom = D2FC_VEJU_BOTTOM
	};

	public enum class KeyboardState : long
	{
		Any = D2FC_KBST_ANY,
		Roman = D2FC_KBST_ROMAN,
		Native = D2FC_KBST_NATIVE
	};

	public enum class ValidationUnit : long
	{
		Default = D2FC_VAUN_DEFAULT,
		Form = D2FC_VAUN_FORM,
		Block = D2FC_VAUN_BLOCK,
		Record = D2FC_VAUN_RECORD,
		Item = D2FC_VAUN_ITEM
	};

	public enum class WrapStyle : long
	{
		None = D2FC_WRST_NONE,
		Character = D2FC_WRST_CHARACTER,
		Word = D2FC_WRST_WORD
	};

	public enum class WindowStyle : long
	{
		Document = D2FC_WIST_DOCUMENT,
		Dialog = D2FC_WIST_DIALOG
	};

	public enum class FrameTitleAlignment : long
	{
		Left = D2FC_JUST_LEFT,
		Right = D2FC_JUST_RIGHT,
		Center = D2FC_JUST_CENTER,
		Start = D2FC_JUST_START,
		End = D2FC_JUST_END
	};
}
