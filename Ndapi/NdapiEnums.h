#pragma once

#include <D2FDEF.H>

namespace Ndapi
{
	public enum class ModuleStorageType : long
	{
		Filesystem = D2FC_PAMO_FILESYSTEM,
		Database = D2FC_PAMO_DATABASE
	};

	public enum class ProgramUnitType : long
	{
		Unknown = D2FC_PGTY_UNKNOWN,
		Procedure = D2FC_PGTY_PROCEDURE,
		Function = D2FC_PGTY_FUNCTION,
		PackageSpecification = D2FC_PGTY_PACKAGESPEC,
		PackageBody = D2FC_PGTY_PACKAGEBODY
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

	public enum class LanguageDirection : long 
	{
		Default = D2FC_LADI_DEFAULT,
		LeftToRight = D2FC_LADI_TORIGHT,
		RigthToLeft = D2FC_LADI_TOLEFT
	};

	public enum class MenuSource : long
	{
		File = D2FC_MNSR_FILE,
		Database = D2FC_MNSR_DB
	};

	public enum class MenuStyle : long
	{
		Pulldown = D2FC_MNST_PULLDOWN,
		Fullscreen = D2FC_MNST_FULLSCREEN
	};

	public enum class MouseNavigationLimit : long
	{
		Form = D2FC_MONA_FORM,
		Block = D2FC_MONA_BLOCK,
		Record = D2FC_MONA_RECORD,
		Item = D2FC_MONA_ITEM
	};

	public enum class RuntimeCompatibility : long
	{
		Forms_45 = D2FC_RUCO_45,
		Forms_50 = D2FC_RUCO_50
	};

	public enum class ValidationUnit : long
	{
		Default = D2FC_VAUN_DEFAULT,
		Form = D2FC_VAUN_FORM,
		Block = D2FC_VAUN_BLOCK,
		Record = D2FC_VAUN_RECORD,
		Item = D2FC_VAUN_ITEM
	};

	public enum class AlertStyle : long
	{
		Stop = D2FC_ALST_STOP,
		Caution = D2FC_ALST_CAUTION,
		Note = D2FC_ALST_NOTE
	};

	public enum class AlertButton : long
	{
		Button1 = D2FC_DFAL_BTN1,
		Button2 = D2FC_DFAL_BTN2,
		Button3 = D2FC_DFAL_BTN3
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

	public enum class DMLDataTargetType : long
	{
		None = D2FC_DMDA_NONE,
		Table = D2FC_DMDA_TABLE,
		Procedure = D2FC_DMDA_PROCEDURE,
		TransationalTrigger = D2FC_DMDA_TRANS_TRIG
	};

	public enum class KeyMode : long
	{
		Unique = D2FC_KEMO_UNIQUE,
		Updateable = D2FC_KEMO_UPDATEABLE,
		NonUpdateable = D2FC_KEMO_NUPDATEABLE,
		Automatic = D2FC_KEMO_AUTO
	};

	public enum class LockingMode : long
	{
		Immediate = D2FC_LOMO_IMMEDIATE,
		Delayed = D2FC_LOMO_DELAYED,
		Automatic = D2FC_LOMO_AUTO
	};

	public enum class NavigationStyle : long
	{
		SameRecord = D2FC_NAST_SAMERECORD,
		ChangeRecord = D2FC_NAST_CHANGERECORD,
		ChangeBlock = D2FC_NAST_CHANGEBLOCK
	};

	public enum class RecordOrientation : long
	{
		Vertical = D2FC_REOR_VERTICAL,
		Horizontal = D2FC_REOR_HORIZONTAL
	};

	public enum class ScrollBarOrientation : long
	{
		Vertical = D2FC_SCOR_VERTICAL,
		Horizontal = D2FC_SCOR_HORIZONTAL
	};

	public enum class ExecutionStyle : long
	{
		Override = D2FC_EXHI_OVERRIDE,
		Before = D2FC_EXHI_BEFORE,
		After = D2FC_EXHI_AFTER
	};

	public enum class TriggerStyle : long
	{
		PLSQL = D2FC_TRST_PLSQL,
		V2 = D2FC_TRST_V2
	};

	public enum class SourceType : long
	{
		Filesystem = D2FC_LISR_FS,
		Dataabse = D2FC_LISR_DB
	};

	public enum class ParameterDataType : long
	{
		Char = D2FC_PADA_CHAR,
		Number = D2FC_PADA_NUMBER,
		Date = D2FC_PADA_DATE
	};

	public enum class DeleteRecordBehavior : long
	{
		Cascading = D2FC_DERE_CASCADING,
		Isolated = D2FC_DERE_ISOLATED,
		NonIsolated = D2FC_DERE_NON_ISOLATED
	};

	public enum class RecordGroupType : long
	{
		Query = D2FC_REGR_QUERY,
		Static = D2FC_REGR_STATIC
	};

	public enum class ColumnSpecificationDataType : long
	{
		Char = D2FC_CODA_CHAR,
		Number = D2FC_CODA_NUMBER,
		Date = D2FC_CODA_DATE,
		Long = D2FC_CODA_LONG,
		RefObject = D2FC_CODA_REF
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

	public enum class CanvasType : long
	{
		Content = D2FC_CNTY_CONTENT,
		Stacked = D2FC_CNTY_STACKED,
		VerticalToolbar = D2FC_CNTY_VTOOLBAR,
		HorizontalToolbar = D2FC_CNTY_HTOOLBAR,
		Tab = D2FC_CNTY_TAB
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

	public enum class LineArrowStyle : long
	{
		None = D2FC_ARST_NONE,
		Start = D2FC_ARST_START,
		End = D2FC_ARST_END,
		Both = D2FC_ARST_BOTH,
		MiddleToStart = D2FC_ARST_MDLTOSTRT,
		MiddleToEnd = D2FC_ARST_MDLTOEND
	};

	public enum class ObjectEdgeCapStyle : long
	{
		Butt = D2FC_CAST_BUTT,
		Round = D2FC_CAST_ROUND,
		Projecting = D2FC_CAST_PROJECT
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

	public enum class DisplayQuality : long
	{
		High = D2FC_DIQL_HIGH,
		Medium = D2FC_DIQL_MEDIUM,
		Low = D2FC_DIQL_LOW
	};

	public enum class FrameAlignment : long
	{
		Start = D2FC_FRAL_START,
		End = D2FC_FRAL_END,
		Center = D2FC_FRAL_CENTER,
		Fill = D2FC_FRAL_FILL,
		Column = D2FC_FRAL_COLUMN
	};

	public enum class FrameTitleAlignment : long
	{
		Left = D2FC_JUST_LEFT,
		Right = D2FC_JUST_RIGHT,
		Center = D2FC_JUST_CENTER,
		Start = D2FC_JUST_START,
		End = D2FC_JUST_END
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

	public enum class HorizontalJustification : long
	{
		Left = D2FC_HOJU_LEFT,
		Right = D2FC_HOJU_RIGHT,
		Center = D2FC_HOJU_CENTER,
		Start = D2FC_HOJU_START,
		End = D2FC_HOJU_END
	};

	public enum class JoinStyle : long
	{
		Mitre = D2FC_JOST_MITRE,
		Bevel = D2FC_JOST_BEVEL,
		Round = D2FC_JOST_ROUND
	};

	public enum class LayoutStyle : long
	{
		Form = D2FC_LAST_FORM,
		Tabulat = D2FC_LAST_TABULAR
	};

	public enum class LineSpacing : long
	{
		Single = D2FC_LISP_SINGLE,
		OneAndAHalf = D2FC_LISP_ONEHALF,
		Double = D2FC_LISP_DOUBLE,
		Custom = D2FC_LISP_CUSTOM
	};

	public enum class ScrollBarAlignment : long
	{
		Start = D2FC_SCAL_START,
		End = D2FC_SCAL_END
	};

	public enum class Alignment : long
	{
		Start = D2FC_ALIG_START,
		End = D2FC_ALIG_END,
		Center = D2FC_ALIG_CENTER
	};

	public enum class TitleReadingOrder : long
	{
		Default = D2FC_READ_DEFAULT,
		LeftToRight = D2FC_READ_TORIGHT,
		RightToLeft = D2FC_READ_TOLEFT
	};

	public enum class UpdateLayout : long
	{
		Manual = D2FC_UPLA_MANUAL,
		Automatic = D2FC_UPLA_AUTO,
		Locked = D2FC_UPLA_LOCKED
	};

	public enum class VerticalJustification : long
	{
		Top = D2FC_VEJU_TOP,
		Center = D2FC_VEJU_CENTER,
		Bottom = D2FC_VEJU_BOTTOM
	};

	public enum class WindowStyle : long
	{
		Document = D2FC_WIST_DOCUMENT,
		Dialog = D2FC_WIST_DIALOG
	};

	public enum class ListType : long
	{
		RecordGroup = D2FC_LSTY_RECORDGROUP,
		Old = D2FC_LSTY_OLD
	};
}
