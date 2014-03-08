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
}
