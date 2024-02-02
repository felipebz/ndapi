﻿using System.Collections.Generic;

using static Ndapi.Core.NdapiConstant;

namespace Ndapi.Core;

internal static partial class ConstantConverter
{
    private static Dictionary<NdapiConstant, int> Forms6Constants { get; } = new()
    {
        [D2FC_UNDEFINED] = 255,
        [D2FC_DFAL_BTN1] = 0,
        [D2FC_DFAL_BTN2] = 1,
        [D2FC_DFAL_BTN3] = 2,
        [D2FC_JUST_LEFT] = 0,
        [D2FC_JUST_RIGHT] = 1,
        [D2FC_JUST_CENTER] = 2,
        [D2FC_JUST_START] = 3,
        [D2FC_JUST_END] = 4,
        [D2FC_ALST_STOP] = 0,
        [D2FC_ALST_CAUTION] = 1,
        [D2FC_ALST_NOTE] = 2,
        [D2FC_DSMO_IN] = 0,
        [D2FC_DSMO_OUT] = 1,
        [D2FC_DSMO_IN_OUT] = 2,
        [D2FC_ARST_NONE] = 0,
        [D2FC_ARST_START] = 1,
        [D2FC_ARST_END] = 2,
        [D2FC_ARST_BOTH] = 3,
        [D2FC_ARST_MDLTOSTRT] = 4,
        [D2FC_ARST_MDLTOEND] = 5,
        [D2FC_GRTY_ARC] = 0,
        [D2FC_GRTY_IMAGE] = 1,
        [D2FC_GRTY_LINE] = 2,
        [D2FC_GRTY_POLY] = 3,
        [D2FC_GRTY_RECT] = 4,
        [D2FC_GRTY_RREC] = 5,
        [D2FC_GRTY_TEXT] = 6,
        [D2FC_GRTY_GROUP] = 7,
        [D2FC_GRTY_FRAME] = 8,
        [D2FC_BEST_RAISED] = 0,
        [D2FC_BEST_LOWERED] = 1,
        [D2FC_BEST_NONE] = 2,
        [D2FC_BEST_NSET] = 3,
        [D2FC_BEST_OUTSET] = 4,
        [D2FC_BEST_PLAIN] = 5,
        [D2FC_DSTY_VARCHAR2] = 0,
        [D2FC_DSTY_NUMBER] = 1,
        [D2FC_DSTY_LONG] = 2,
        [D2FC_DSTY_ROWID] = 3,
        [D2FC_DSTY_DATE] = 4,
        [D2FC_DSTY_RAW] = 5,
        [D2FC_DSTY_LONG_RAW] = 6,
        [D2FC_DSTY_CHAR] = 7,
        [D2FC_DSTY_MLSLABEL] = 8,
        [D2FC_DSTY_TABLE] = 9,
        [D2FC_DSTY_RECORD] = 10,
        [D2FC_DSTY_REFCURSOR] = 11,
        [D2FC_DSTY_NAMEDTYPE] = 12,
        [D2FC_DSTY_OBJECTREF] = 13,
        [D2FC_DSTY_VARRAY] = 14,
        [D2FC_DSTY_NESTEDTAB] = 15,
        [D2FC_DSTY_BLOB] = 16,
        [D2FC_DSTY_CLOB] = 17,
        [D2FC_DSTY_BFILE] = 18,
        [D2FC_DSTY_CFILE] = 19,
        [D2FC_DSTY_UNKNOWN] = 99,
        [D2FC_COMO_SYNCH] = 0,
        [D2FC_COMO_ASYNCH] = 1,
        [D2FC_COSY_CHARACTER] = 0,
        [D2FC_COSY_REAL] = 1,
        [D2FC_QRDA_NONE] = 0,
        [D2FC_QRDA_TABLE] = 1,
        [D2FC_QRDA_PROCEDURE] = 2,
        [D2FC_QRDA_TRANS_TRIG] = 3,
        [D2FC_QRDA_FRM_CLS_QUERY] = 4,
        [D2FC_DMDA_NONE] = 0,
        [D2FC_DMDA_TABLE] = 1,
        [D2FC_DMDA_PROCEDURE] = 2,
        [D2FC_DMDA_TRANS_TRIG] = 3,
        [D2FC_PRAT_START] = 0,
        [D2FC_PRAT_END] = 1,
        [D2FC_PRAT_TOP] = 2,
        [D2FC_PRAT_BOTTOM] = 3,
        [D2FC_EXMO_BATCH] = 0,
        [D2FC_EXMO_RUNTIME] = 1,
        [D2FC_LISR_FS] = 0,
        [D2FC_LISR_DB] = 1,
        [D2FC_UPLA_MANUAL] = 0,
        [D2FC_UPLA_AUTO] = 1,
        [D2FC_UPLA_LOCKED] = 2,
        [D2FC_ITTY_CA] = 0,
        [D2FC_ITTY_CB] = 1,
        [D2FC_ITTY_DI] = 2,
        [D2FC_ITTY_IM] = 3,
        [D2FC_ITTY_LS] = 4,
        [D2FC_ITTY_ACT] = 5,
        [D2FC_ITTY_OLE] = 6,
        [D2FC_ITTY_PB] = 7,
        [D2FC_ITTY_RD] = 8,
        [D2FC_ITTY_SN] = 9,
        [D2FC_ITTY_TI] = 10,
        [D2FC_ITTY_UA] = 11,
        [D2FC_ITTY_VBX] = 12,
        [D2FC_ITTY_TRE] = 13,
        [D2FC_ITTY_BA] = 14,
        [D2FC_ITTY_MAX] = 14,
        [D2FC_OLAC_DOUBLECLICK] = 0,
        [D2FC_OLAC_MANUAL] = 1,
        [D2FC_OLAC_FOCUS] = 2,
        [D2FC_PRDI_HIDDEN] = 0,
        [D2FC_PRDI_FIRST] = 1,
        [D2FC_PRDI_EACH] = 2,
        [D2FC_PGTY_UNKNOWN] = 0,
        [D2FC_PGTY_PROCEDURE] = 1,
        [D2FC_PGTY_FUNCTION] = 2,
        [D2FC_PGTY_PACKAGESPEC] = 3,
        [D2FC_PGTY_PACKAGEBODY] = 4,
        [D2FC_REUN_PIXEL] = 0,
        [D2FC_REUN_CENTIMETER] = 1,
        [D2FC_REUN_INCH] = 2,
        [D2FC_REUN_POINT] = 3,
        [D2FC_REUN_DECIPOINT] = 4,
        [D2FC_RELT_JOIN] = 0,
        [D2FC_RELT_REF] = 1,
        [D2FC_RUCO_45] = 0,
        [D2FC_RUCO_50] = 1,
        [D2FC_TAAT_TOP] = 0,
        [D2FC_TAAT_BOTTOM] = 1,
        [D2FC_TAAT_LEFT] = 2,
        [D2FC_TAAT_RIGHT] = 3,
        [D2FC_TAAT_START] = 4,
        [D2FC_TAAT_END] = 5,
        [D2FC_TAST_CHAMFERED] = 0,
        [D2FC_TAST_SQUARE] = 1,
        [D2FC_TAST_ROUNDED] = 2,
        [D2FC_VATY_COMMON] = 0,
        [D2FC_VATY_PROMPT] = 1,
        [D2FC_VATY_TITLE] = 2,
        [D2FC_CODA_CHAR] = 0,
        [D2FC_CODA_NUMBER] = 1,
        [D2FC_CODA_DATE] = 2,
        [D2FC_CODA_LONG] = 3,
        [D2FC_CODA_REF] = 4,
        [D2FC_AUCH_AUTO] = 0,
        [D2FC_AUCH_MONO] = 1,
        [D2FC_AUCH_STEREO] = 2,
        [D2FC_CAMO_NONE] = 0,
        [D2FC_CAMO_FORMULA] = 1,
        [D2FC_CAMO_SUMMARY] = 2,
        [D2FC_CRMO_OPEN] = 0,
        [D2FC_CRMO_CLOSE] = 1,
        [D2FC_CAST_BUTT] = 0,
        [D2FC_CAST_ROUND] = 1,
        [D2FC_CAST_PROJECT] = 2,
        [D2FC_CMQL_NONE] = 0,
        [D2FC_CMQL_MIN] = 1,
        [D2FC_CMQL_LOW] = 2,
        [D2FC_CMQL_MED] = 3,
        [D2FC_CMQL_HIGH] = 4,
        [D2FC_CMQL_MAX] = 5,
        [D2FC_CARS_MIXED] = 0,
        [D2FC_CARS_UPPER] = 1,
        [D2FC_CARS_LOWER] = 2,
        [D2FC_CNTY_CONTENT] = 0,
        [D2FC_CNTY_STACKED] = 1,
        [D2FC_CNTY_VTOOLBAR] = 2,
        [D2FC_CNTY_HTOOLBAR] = 3,
        [D2FC_CNTY_TAB] = 4,
        [D2FC_CHBX_ILLEGAL] = 0,
        [D2FC_CHBX_CHECKED] = 1,
        [D2FC_CHBX_UNCHECKED] = 2,
        [D2FC_LADI_DEFAULT] = 0,
        [D2FC_LADI_TORIGHT] = 1,
        [D2FC_LADI_TOLEFT] = 2,
        [D2FC_INKB_DEFAULT] = 0,
        [D2FC_INKB_ROMAN] = 1,
        [D2FC_INKB_NATIVE] = 2,
        [D2FC_IMDP_ORIG] = 0,
        [D2FC_IMDP_MONO] = 1,
        [D2FC_IMDP_GRAY] = 2,
        [D2FC_IMDP_LUT] = 3,
        [D2FC_IMDP_RGB] = 4,
        [D2FC_DAST_SOLID] = 0,
        [D2FC_DAST_DOT] = 1,
        [D2FC_DAST_DASH] = 2,
        [D2FC_DAST_DASHDOT] = 3,
        [D2FC_DAST_DOUBDOT] = 4,
        [D2FC_DAST_LONGDASH] = 5,
        [D2FC_DAST_DASHDOUBDOT] = 6,
        [D2FC_EXHI_OVERRIDE] = 0,
        [D2FC_EXHI_BEFORE] = 1,
        [D2FC_EXHI_AFTER] = 2,
        [D2FC_FRAL_START] = 0,
        [D2FC_FRAL_END] = 1,
        [D2FC_FRAL_CENTER] = 2,
        [D2FC_FRAL_FILL] = 3,
        [D2FC_FRAL_COLUMN] = 4,
        [D2FC_FOSP_ULTRADENSE] = 0,
        [D2FC_FOSP_EXTRADENSE] = 1,
        [D2FC_FOSP_DENSE] = 2,
        [D2FC_FOSP_SEMIDENSE] = 3,
        [D2FC_FOSP_NORMAL] = 4,
        [D2FC_FOSP_SEMIEXPAND] = 5,
        [D2FC_FOSP_EXPAND] = 6,
        [D2FC_FOSP_EXTRAEXPAND] = 7,
        [D2FC_FOSP_ULTRAEXPAND] = 8,
        [D2FC_FOST_PLAIN] = 0,
        [D2FC_FOST_ITALIC] = 1,
        [D2FC_FOST_OBLIQUE] = 2,
        [D2FC_FOST_UNDERLINE] = 3,
        [D2FC_FOST_OUTLINE] = 4,
        [D2FC_FOST_SHADOW] = 5,
        [D2FC_FOST_INVERTED] = 6,
        [D2FC_FOST_OVERSTRIKE] = 7,
        [D2FC_FOST_BLINK] = 8,
        [D2FC_FOWG_ULTRALIGHT] = 0,
        [D2FC_FOWG_EXTRALIGHT] = 1,
        [D2FC_FOWG_LIGHT] = 2,
        [D2FC_FOWG_DEMILIGHT] = 3,
        [D2FC_FOWG_MEDIUM] = 4,
        [D2FC_FOWG_DEMIBOLD] = 5,
        [D2FC_FOWG_BOLD] = 6,
        [D2FC_FOWG_EXTRABOLD] = 7,
        [D2FC_FOWG_ULTRABOLD] = 8,
        [D2FC_LAST_FORM] = 0,
        [D2FC_LAST_TABULAR] = 1,
        [D2FC_HOOR_LEFT] = 0,
        [D2FC_HOOR_RIGHT] = 1,
        [D2FC_HOOR_CENTER] = 2,
        [D2FC_HOJU_LEFT] = 0,
        [D2FC_HOJU_RIGHT] = 1,
        [D2FC_HOJU_CENTER] = 2,
        [D2FC_HOJU_START] = 3,
        [D2FC_HOJU_END] = 4,
        [D2FC_DATY_CHAR] = 0,
        [D2FC_DATY_NUMBER] = 1,
        [D2FC_DATY_DATE] = 2,
        [D2FC_DATY_ALPHA] = 3,
        [D2FC_DATY_INTEGER] = 4,
        [D2FC_DATY_DATETIME] = 5,
        [D2FC_DATY_LONG] = 6,
        [D2FC_DATY_RNUMBER] = 7,
        [D2FC_DATY_JDATE] = 8,
        [D2FC_DATY_EDATE] = 9,
        [D2FC_DATY_TIME] = 10,
        [D2FC_DATY_RINTEGER] = 11,
        [D2FC_DATY_MONEY] = 12,
        [D2FC_DATY_RMONEY] = 13,
        [D2FC_DATY_OBJECTREF] = 14,
        [D2FC_DATY_LOB] = 15,
        [D2FC_DATY_FILE] = 16,
        [D2FC_IMFM_BMP] = 0,
        [D2FC_IMFM_CALS] = 1,
        [D2FC_IMFM_GIF] = 2,
        [D2FC_IMFM_JFIF] = 3,
        [D2FC_IMFM_PICT] = 4,
        [D2FC_IMFM_RAS] = 5,
        [D2FC_IMFM_TIFF] = 6,
        [D2FC_IMFM_TPIC] = 7,
        [D2FC_DIQL_HIGH] = 0,
        [D2FC_DIQL_MEDIUM] = 1,
        [D2FC_DIQL_LOW] = 2,
        [D2FC_SIST_CROP] = 0,
        [D2FC_SIST_ADJUST] = 1,
        [D2FC_JOST_MITRE] = 0,
        [D2FC_JOST_BEVEL] = 1,
        [D2FC_JOST_ROUND] = 2,
        [D2FC_KEMO_UNIQUE] = 0,
        [D2FC_KEMO_UPDATEABLE] = 1,
        [D2FC_KEMO_NUPDATEABLE] = 2,
        [D2FC_KEMO_AUTO] = 3,
        [D2FC_ALIG_START] = 0,
        [D2FC_ALIG_END] = 1,
        [D2FC_ALIG_CENTER] = 2,
        [D2FC_INMO_BLOCKING] = 0,
        [D2FC_INMO_NONBLOCKING] = 1,
        [D2FC_ISMO_READ] = 0,
        [D2FC_ISMO_SERIAL] = 1,
        [D2FC_LOMO_IMMEDIATE] = 0,
        [D2FC_LOMO_DELAYED] = 1,
        [D2FC_LOMO_AUTO] = 2,
        [D2FC_LSST_POPLIST] = 0,
        [D2FC_LSST_TLIST] = 1,
        [D2FC_LSST_COMBO] = 2,
        [D2FC_LSTY_RECORDGROUP] = 0,
        [D2FC_LSTY_OLD] = 1,
        [D2FC_COTY_NULL] = 0,
        [D2FC_COTY_MENU] = 1,
        [D2FC_COTY_PLSQL] = 2,
        [D2FC_COTY_PLUS] = 3,
        [D2FC_COTY_FORM] = 4,
        [D2FC_COTY_MACRO] = 5,
        [D2FC_DERE_CASCADING] = 0,
        [D2FC_DERE_ISOLATED] = 1,
        [D2FC_DERE_NON_ISOLATED] = 2,
        [D2FC_MAIT_NONE] = 0,
        [D2FC_MAIT_CUT] = 1,
        [D2FC_MAIT_COPY] = 2,
        [D2FC_MAIT_PASTE] = 3,
        [D2FC_MAIT_CLEAR] = 4,
        [D2FC_MAIT_UNDO] = 5,
        [D2FC_MAIT_HELP] = 6,
        [D2FC_MAIT_ABOUT] = 7,
        [D2FC_MAIT_QUIT] = 8,
        [D2FC_MAIT_WINDOW] = 9,
        [D2FC_MAIT_PAGESETUP] = 10,
        [D2FC_MONA_FORM] = 0,
        [D2FC_MONA_BLOCK] = 1,
        [D2FC_MONA_RECORD] = 2,
        [D2FC_MONA_ITEM] = 3,
        [D2FC_MNST_PULLDOWN] = 0,
        [D2FC_MNST_FULLSCREEN] = 1,
        [D2FC_MNSR_FILE] = 0,
        [D2FC_MNSR_DB] = 1,
        [D2FC_MNIT_PLAIN] = 0,
        [D2FC_MNIT_CHECK] = 1,
        [D2FC_MNIT_RADIO] = 2,
        [D2FC_MNIT_SEPARATOR] = 3,
        [D2FC_MNIT_MAGIC] = 4,
        [D2FC_NAST_SAMERECORD] = 0,
        [D2FC_NAST_CHANGERECORD] = 1,
        [D2FC_NAST_CHANGEBLOCK] = 2,
        [D2FC_PAMO_FILESYSTEM] = 0,
        [D2FC_PAMO_DATABASE] = 1,
        [D2FC_REOR_VERTICAL] = 0,
        [D2FC_REOR_HORIZONTAL] = 1,
        [D2FC_OLTN_ANY] = 0,
        [D2FC_OLTN_NONE] = 1,
        [D2FC_OLTN_STATIC] = 2,
        [D2FC_OLTN_LINKED] = 3,
        [D2FC_OLTN_EMBEDDED] = 4,
        [D2FC_OLTN_CONTROL] = 5,
        [D2FC_PADA_CHAR] = 0,
        [D2FC_PADA_NUMBER] = 1,
        [D2FC_PADA_DATE] = 2,
        [D2FC_REGR_QUERY] = 0,
        [D2FC_REGR_STATIC] = 1,
        [D2FC_READ_DEFAULT] = 0,
        [D2FC_READ_TORIGHT] = 1,
        [D2FC_READ_TOLEFT] = 2,
        [D2FC_RPDE_PREVIEW] = 0,
        [D2FC_RPDE_FILE] = 1,
        [D2FC_RPDE_PRINTER] = 2,
        [D2FC_RPDE_MAIL] = 3,
        [D2FC_RPDE_CACHE] = 4,
        [D2FC_RPDE_SCREEN] = 5,
        [D2FC_OLRE_CLIP] = 0,
        [D2FC_OLRE_SCALE] = 1,
        [D2FC_OLRE_INITIAL] = 2,
        [D2FC_OLRE_DYNAMIC] = 3,
        [D2FC_COMP_AUTO] = 0,
        [D2FC_COMP_OFF] = 1,
        [D2FC_COMP_ON] = 2,
        [D2FC_SNFM_AU] = 0,
        [D2FC_SNFM_AIFF] = 1,
        [D2FC_SNFM_AIFF_C] = 2,
        [D2FC_SNFM_WAVE] = 3,
        [D2FC_SNQL_AUTO] = 0,
        [D2FC_SNQL_HIGHEST] = 1,
        [D2FC_SNQL_HIGH] = 2,
        [D2FC_SNQL_MEDIUM] = 3,
        [D2FC_SNQL_LOW] = 4,
        [D2FC_SNQL_LOWEST] = 5,
        [D2FC_SCOR_VERTICAL] = 0,
        [D2FC_SCOR_HORIZONTAL] = 1,
        [D2FC_SCAL_START] = 0,
        [D2FC_SCAL_END] = 1,
        [D2FC_LISP_SINGLE] = 0,
        [D2FC_LISP_ONEHALF] = 1,
        [D2FC_LISP_DOUBLE] = 2,
        [D2FC_LISP_CUSTOM] = 3,
        [D2FC_SUFU_NONE] = 0,
        [D2FC_SUFU_AVG] = 1,
        [D2FC_SUFU_COUNT] = 2,
        [D2FC_SUFU_MAX] = 3,
        [D2FC_SUFU_MIN] = 4,
        [D2FC_SUFU_STDDEV] = 5,
        [D2FC_SUFU_SUM] = 6,
        [D2FC_SUFU_VAR] = 7,
        [D2FC_OLET_CONTENT] = 0,
        [D2FC_OLET_ICON] = 1,
        [D2FC_OLET_THUMBNAIL] = 2,
        [D2FC_TRST_PLSQL] = 0,
        [D2FC_TRST_V2] = 1,
        [D2FC_TRTY_BUILTIN] = 0,
        [D2FC_TRTY_USERNAMED] = 1,
        [D2FC_VEOR_TOP] = 0,
        [D2FC_VEOR_CENTER] = 1,
        [D2FC_VEOR_BOTTOM] = 2,
        [D2FC_VEJU_TOP] = 0,
        [D2FC_VEJU_CENTER] = 1,
        [D2FC_VEJU_BOTTOM] = 2,
        [D2FC_KBST_ANY] = 0,
        [D2FC_KBST_ROMAN] = 1,
        [D2FC_KBST_NATIVE] = 2,
        [D2FC_VAUN_DEFAULT] = 0,
        [D2FC_VAUN_FORM] = 1,
        [D2FC_VAUN_BLOCK] = 2,
        [D2FC_VAUN_RECORD] = 3,
        [D2FC_VAUN_ITEM] = 4,
        [D2FC_WRST_NONE] = 0,
        [D2FC_WRST_CHARACTER] = 1,
        [D2FC_WRST_WORD] = 2,
        [D2FC_WIST_DOCUMENT] = 0,
        [D2FC_WIST_DIALOG] = 1,
        [D2FFO_MIN] = 0,
        [D2FFO_MAX] = 41,
        [D2FFO_UNDEFINED] = 255,
        [D2FFO_ANY] = 0,
        [D2FFO_ALERT] = 1,
        [D2FFO_ATT_LIB] = 2,
        [D2FFO_BLOCK] = 3,
        [D2FFO_CANVAS] = 4,
        [D2FFO_COLUMN_VALUE] = 37,
        [D2FFO_CMPTXT] = 40,
        [D2FFO_COORD] = 5,
        [D2FFO_DAT_SRC_ARG] = 6,
        [D2FFO_DAT_SRC_COL] = 7,
        [D2FFO_EDITOR] = 8,
        [D2FFO_FONT] = 9,
        [D2FFO_FORM_MODULE] = 10,
        [D2FFO_FORM_PARAM] = 11,
        [D2FFO_GRAPHIC] = 12,
        [D2FFO_ITEM] = 13,
        [D2FFO_LIB_PROG_UNIT] = 36,
        [D2FFO_LIBRARY_MODULE] = 14,
        [D2FFO_LOV] = 15,
        [D2FFO_LV_COLMAP] = 16,
        [D2FFO_MENU] = 17,
        [D2FFO_MENU_ITEM] = 18,
        [D2FFO_MENU_MODULE] = 19,
        [D2FFO_MENU_PARAM] = 20,
        [D2FFO_OBJ_GROUP] = 21,
        [D2FFO_OBG_CHILD] = 22,
        [D2FFO_OBJ_LIB] = 23,
        [D2FFO_OBJ_LIB_TAB] = 24,
        [D2FFO_POINT] = 39,
        [D2FFO_PROG_UNIT] = 25,
        [D2FFO_PROP_CLASS] = 26,
        [D2FFO_RADIO_BUTTON] = 27,
        [D2FFO_REC_GROUP] = 28,
        [D2FFO_RELATION] = 29,
        [D2FFO_REPORT] = 30,
        [D2FFO_RG_COLSPEC] = 31,
        [D2FFO_TAB_PAGE] = 32,
        [D2FFO_TEXT_SEG] = 41,
        [D2FFO_TRIGGER] = 33,
        [D2FFO_TRIG_STEP] = 38,
        [D2FFO_VIS_ATTR] = 34,
        [D2FFO_WINDOW] = 35,
        [D2FP_UNDEFINED] = 9000,
        [D2FP_MIN] = 0,
        [D2FP_NONE] = 0,
        [D2FP_ACCESS_KEY] = 1,
        [D2FP_ACCESS_KEY_STRID] = 2,
        [D2FP_ALERT] = 3,
        [D2FP_ALIAS] = 4,
        [D2FP_ALLOW_EXPANSION] = 5,
        [D2FP_ALLOW_MLT_LIN_PRMPTS] = 6,
        [D2FP_ALLOW_STRT_ATT_PRMPTS] = 7,
        [D2FP_ALLOW_TOP_ATT_PRMPTS] = 8,
        [D2FP_ALT_MSG] = 9,
        [D2FP_ALT_MSG_STRID] = 10,
        [D2FP_ALT_STY] = 11,
        [D2FP_ARROW_STY] = 12,
        [D2FP_ASSOC_MENUS_COUNT] = 13,
        [D2FP_ASSOC_MNUS] = 14,
        [D2FP_ATT_LIB] = 15,
        [D2FP_AUDIO_CHNNLS] = 16,
        [D2FP_AUTO_COL_WID] = 17,
        [D2FP_AUTO_DISP] = 18,
        [D2FP_AUTO_HINT] = 19,
        [D2FP_AUTO_POS] = 20,
        [D2FP_AUTO_QRY] = 21,
        [D2FP_AUTO_RFRSH] = 22,
        [D2FP_AUTO_SKP] = 23,
        [D2FP_AUTO_SLCT] = 24,
        [D2FP_BACK_COLOR] = 25,
        [D2FP_BEVEL] = 26,
        [D2FP_BLK_DESCRIPTION] = 27,
        [D2FP_BLK_DSCRP_STRID] = 28,
        [D2FP_BLOCK] = 29,
        [D2FP_BOUNDING_BX_SCALABLE] = 30,
        [D2FP_BTM_TTL] = 31,
        [D2FP_BTM_TTL_STRID] = 32,
        [D2FP_BTN_1_LBL] = 33,
        [D2FP_BTN_1_LBL_STRID] = 34,
        [D2FP_BTN_2_LBL] = 35,
        [D2FP_BTN_2_LBL_STRID] = 36,
        [D2FP_BTN_3_LBL] = 37,
        [D2FP_BTN_3_LBL_STRID] = 38,
        [D2FP_CALC_MODE] = 39,
        [D2FP_CANVAS] = 40,
        [D2FP_CAP_STY] = 41,
        [D2FP_CASE_INSENSITIVE_QRY] = 42,
        [D2FP_CASE_RSTRCTION] = 43,
        [D2FP_CHAR_CELL_HGT] = 44,
        [D2FP_CHAR_CELL_WID] = 45,
        [D2FP_CHKED_VAL] = 46,
        [D2FP_CHK_BX_OTHER_VALS] = 47,
        [D2FP_CLIENT_INFO] = 48,
        [D2FP_CLIP_HGT] = 49,
        [D2FP_CLIP_WID] = 50,
        [D2FP_CLIP_X_POS] = 51,
        [D2FP_CLIP_Y_POS] = 52,
        [D2FP_CLOSED] = 53,
        [D2FP_CLS_ALLOWED] = 54,
        [D2FP_CMPRSSION_QLTY] = 55,
        [D2FP_CMPTXT] = 56,
        [D2FP_CNV_NAM] = 57,
        [D2FP_CNV_OBJ] = 58,
        [D2FP_CNV_TYP] = 59,
        [D2FP_COL_DAT_TYP] = 60,
        [D2FP_COL_MAP] = 61,
        [D2FP_COL_NAM] = 62,
        [D2FP_COL_SPEC] = 63,
        [D2FP_COL_VALS_COUNT] = 64,
        [D2FP_COMMENT] = 65,
        [D2FP_COMM_MODE] = 66,
        [D2FP_COMPRESS] = 67,
        [D2FP_COM_TXT] = 68,
        [D2FP_COM_TYP] = 69,
        [D2FP_CONCEAL_DATA] = 70,
        [D2FP_CONSOLE_WIN] = 71,
        [D2FP_COORD_SYS] = 72,
        [D2FP_COPY_VAL_FROM_ITM] = 73,
        [D2FP_CORNER_RADIUS_X] = 74,
        [D2FP_CORNER_RADIUS_Y] = 75,
        [D2FP_CRSR_MODE] = 76,
        [D2FP_CSTM_SPCING] = 77,
        [D2FP_DASH_STY] = 78,
        [D2FP_DAT_SRC_BLK] = 79,
        [D2FP_DAT_SRC_X_AXS] = 80,
        [D2FP_DAT_SRC_Y_AXS] = 81,
        [D2FP_DAT_TYP] = 82,
        [D2FP_DB_BLK] = 83,
        [D2FP_DB_ITM] = 84,
        [D2FP_DEFERRED] = 85,
        [D2FP_DEFER_REQ_ENF] = 86,
        [D2FP_DEL_ALLOWED] = 87,
        [D2FP_DEL_DAT_SRC_ARG] = 88,
        [D2FP_DEL_DAT_SRC_COL] = 89,
        [D2FP_DEL_PROC_NAM] = 90,
        [D2FP_DEL_REC] = 91,
        [D2FP_DETAIL_BLK] = 92,
        [D2FP_DETAIL_ITEMREF] = 93,
        [D2FP_DFLT_ALT_BTN] = 94,
        [D2FP_DFLT_BTN] = 95,
        [D2FP_DFLT_FNT_SCALING] = 96,
        [D2FP_DIRTY_INFO] = 97,
        [D2FP_DISP_IN_KBRD_HLP] = 98,
        [D2FP_DISP_NO_PRIV] = 99,
        [D2FP_DISP_QLTY] = 100,
        [D2FP_DISP_WID] = 101,
        [D2FP_DIST_BTWN_RECS] = 102,
        [D2FP_DITHER] = 103,
        [D2FP_DML_ARY_SIZ] = 104,
        [D2FP_DML_DAT_NAM] = 105,
        [D2FP_DML_DAT_TYP] = 106,
        [D2FP_DML_RET_VAL] = 107,
        [D2FP_DSA_MODE] = 108,
        [D2FP_DSA_NAM] = 109,
        [D2FP_DSA_TYP] = 110,
        [D2FP_DSA_TYP_NAM] = 111,
        [D2FP_DSA_VAL] = 112,
        [D2FP_DSC_LEN] = 113,
        [D2FP_DSC_MANDATORY] = 114,
        [D2FP_DSC_NAM] = 115,
        [D2FP_DSC_NOCHILDREN] = 116,
        [D2FP_DSC_PARENT_NAME] = 117,
        [D2FP_DSC_PRECISION] = 118,
        [D2FP_DSC_SCALE] = 119,
        [D2FP_DSC_TYP] = 120,
        [D2FP_DSC_TYPE_NAME] = 121,
        [D2FP_DS_DEL_ARG_LIST] = 122,
        [D2FP_DS_DEL_COL_LIST] = 123,
        [D2FP_DS_INS_ARG_LIST] = 124,
        [D2FP_DS_INS_COL_LIST] = 125,
        [D2FP_DS_LOK_ARG_LIST] = 126,
        [D2FP_DS_LOK_COL_LIST] = 127,
        [D2FP_DS_QRY_ARG_LIST] = 128,
        [D2FP_DS_QRY_COL_LIST] = 129,
        [D2FP_DS_UPD_ARG_LIST] = 130,
        [D2FP_DS_UPD_COL_LIST] = 131,
        [D2FP_EDGE_BACK_COLOR] = 132,
        [D2FP_EDGE_FORE_COLOR] = 133,
        [D2FP_EDGE_PAT] = 134,
        [D2FP_EDITOR] = 135,
        [D2FP_EDT_NAM] = 136,
        [D2FP_EDT_OBJ] = 137,
        [D2FP_EDT_X_POS] = 138,
        [D2FP_EDT_Y_POS] = 139,
        [D2FP_ENABLED] = 140,
        [D2FP_ENFRC_COL_SECURITY] = 141,
        [D2FP_ENFRC_PRMRY_KEY] = 142,
        [D2FP_EXEC_HIERARCHY] = 143,
        [D2FP_EXEC_MODE] = 144,
        [D2FP_FAIL_MSG_STRID] = 145,
        [D2FP_FILL_PAT] = 146,
        [D2FP_FIRE_IN_QRY] = 147,
        [D2FP_FIXED_BOUNDING_BX] = 148,
        [D2FP_FIXED_LEN] = 149,
        [D2FP_FLNAM] = 150,
        [D2FP_FLTR_BEFORE_DISP] = 151,
        [D2FP_FMT_MSK] = 152,
        [D2FP_FONT_NAM] = 153,
        [D2FP_FONT_SCALEABLE] = 154,
        [D2FP_FONT_SIZ] = 155,
        [D2FP_FONT_SPCING] = 156,
        [D2FP_FONT_STY] = 157,
        [D2FP_FONT_WGHT] = 158,
        [D2FP_FORE_COLOR] = 159,
        [D2FP_FORMULA] = 160,
        [D2FP_FORM_PARAM] = 161,
        [D2FP_FRAME_ALIGN] = 162,
        [D2FP_FRAME_TTL] = 163,
        [D2FP_FRAME_TTL_ALIGN] = 164,
        [D2FP_FRAME_TTL_BACK_COLOR] = 165,
        [D2FP_FRAME_TTL_FILL_PAT] = 166,
        [D2FP_FRAME_TTL_FONT_NAM] = 167,
        [D2FP_FRAME_TTL_FONT_SIZ] = 168,
        [D2FP_FRAME_TTL_FONT_SPCING] = 169,
        [D2FP_FRAME_TTL_FONT_STY] = 170,
        [D2FP_FRAME_TTL_FONT_WGHT] = 171,
        [D2FP_FRAME_TTL_FORE_COLOR] = 172,
        [D2FP_FRAME_TTL_OFST] = 173,
        [D2FP_FRAME_TTL_SPCING] = 174,
        [D2FP_FRAME_TTL_STRID] = 175,
        [D2FP_FRAME_TTL_VAT_NAM] = 176,
        [D2FP_FRAME_TTL_VAT_OBJ] = 177,
        [D2FP_FRST_NAVIGATION_BLK_NAM] = 178,
        [D2FP_FRST_NAVIGATION_BLK_OBJ] = 179,
        [D2FP_GRAPHIC] = 180,
        [D2FP_GRAPHICS_TYP] = 181,
        [D2FP_GRA_FONT_COLOR] = 182,
        [D2FP_GRA_FONT_COLOR_CODE] = 183,
        [D2FP_GRA_FONT_NAM] = 184,
        [D2FP_GRA_FONT_SIZ] = 185,
        [D2FP_GRA_FONT_SPCING] = 186,
        [D2FP_GRA_FONT_STY] = 187,
        [D2FP_GRA_FONT_WGHT] = 188,
        [D2FP_GRA_TEXT] = 189,
        [D2FP_HEIGHT] = 190,
        [D2FP_HELP_BOOK_TITLE] = 191,
        [D2FP_HELP_BOOK_TOPIC] = 192,
        [D2FP_HIDE] = 193,
        [D2FP_HIDE_ON_EXIT] = 194,
        [D2FP_HIGHEST_ALLOWED_VAL] = 195,
        [D2FP_HIGHEST_VAL_STRID] = 196,
        [D2FP_HINT] = 197,
        [D2FP_HINT_STRID] = 198,
        [D2FP_HLP_DESCRIPTION] = 199,
        [D2FP_HLP_DSCRP_STRID] = 200,
        [D2FP_HORZ_JST] = 201,
        [D2FP_HORZ_MARGN] = 202,
        [D2FP_HORZ_OBJ_OFST] = 203,
        [D2FP_HORZ_ORGN] = 204,
        [D2FP_HORZ_TLBR_CNV] = 205,
        [D2FP_HTB_CNV_NAME] = 206,
        [D2FP_ICONIC] = 207,
        [D2FP_ICON_FLNAM] = 208,
        [D2FP_ICON_IN_MNU] = 209,
        [D2FP_IMG_DPTH] = 210,
        [D2FP_IMG_FMT] = 211,
        [D2FP_IMPL_CLASS] = 212,
        [D2FP_INCLUDE_REFITEM] = 213,
        [D2FP_INHRT_MNU] = 214,
        [D2FP_INIT_KBRD_DIR] = 215,
        [D2FP_INIT_MNU] = 216,
        [D2FP_INIT_VAL] = 217,
        [D2FP_INIT_VAL_STRID] = 218,
        [D2FP_INSRT_ALLOWED] = 219,
        [D2FP_INSRT_PROC_NAM] = 220,
        [D2FP_INS_DAT_SRC_ARG] = 221,
        [D2FP_INS_DAT_SRC_COL] = 222,
        [D2FP_INTERACTION_MODE] = 223,
        [D2FP_INTERNAL_END_ANGLE] = 224,
        [D2FP_INTERNAL_LIN_WID] = 225,
        [D2FP_INTERNAL_ROTATION_ANGLE] = 226,
        [D2FP_INTERNAL_STRT_ANGLE] = 227,
        [D2FP_ISOLATION_MODE] = 228,
        [D2FP_ITEM] = 229,
        [D2FP_ITMS_DISP] = 230,
        [D2FP_ITM_TYP] = 231,
        [D2FP_JOIN_COND] = 232,
        [D2FP_JOIN_STY] = 233,
        [D2FP_JUSTIFICATION] = 234,
        [D2FP_KBRD_ACC] = 235,
        [D2FP_KBRD_ACC_STRID] = 236,
        [D2FP_KBRD_HLP_TXT] = 237,
        [D2FP_KBRD_HLP_TXT_STRID] = 238,
        [D2FP_KBRD_NAVIGABLE] = 239,
        [D2FP_KBRD_STATE] = 240,
        [D2FP_KEEP_CRSR_POS] = 241,
        [D2FP_KEY_MODE] = 242,
        [D2FP_LABEL] = 243,
        [D2FP_LABEL_STRID] = 244,
        [D2FP_LANG] = 245,
        [D2FP_LANG_DIR] = 246,
        [D2FP_LAYOUT_DATA_BLK_NAM] = 247,
        [D2FP_LAYOUT_STY] = 248,
        [D2FP_LIB_LOC] = 249,
        [D2FP_LIB_PROG_UNIT] = 250,
        [D2FP_LIB_SRC] = 251,
        [D2FP_LIN_SPCING] = 252,
        [D2FP_LIST_ELEM] = 253,
        [D2FP_LOCK_DAT_SRC_ARG] = 254,
        [D2FP_LOCK_DAT_SRC_COL] = 255,
        [D2FP_LOCK_MODE] = 256,
        [D2FP_LOCK_PROC_NAM] = 257,
        [D2FP_LOCK_REC] = 258,
        [D2FP_LOV] = 259,
        [D2FP_LOV_NAM] = 260,
        [D2FP_LOV_OBJ] = 261,
        [D2FP_LOV_X_POS] = 262,
        [D2FP_LOV_Y_POS] = 263,
        [D2FP_LOWEST_ALLOWED_VAL] = 264,
        [D2FP_LOWEST_VAL_STRID] = 265,
        [D2FP_LST_ELEMENT_COUNT] = 266,
        [D2FP_LST_IN_BLK_MNU] = 267,
        [D2FP_LST_STY] = 268,
        [D2FP_LST_TYP] = 269,
        [D2FP_MAGIC_ITM] = 270,
        [D2FP_MAIN_MNU] = 271,
        [D2FP_MAXIMIZE_ALLOWED] = 272,
        [D2FP_MAX_LEN] = 273,
        [D2FP_MAX_OBJS] = 274,
        [D2FP_MAX_QRY_TIME] = 275,
        [D2FP_MAX_RECS_FETCHED] = 276,
        [D2FP_MENU] = 277,
        [D2FP_MINIMIZE_ALLOWED] = 278,
        [D2FP_MINIMIZE_TTL] = 279,
        [D2FP_MINIMIZE_TTL_STRID] = 280,
        [D2FP_MLT_LIN] = 281,
        [D2FP_MNU_DRCTRY] = 282,
        [D2FP_MNU_FLNAM] = 283,
        [D2FP_MNU_ITM] = 284,
        [D2FP_MNU_ITM_CODE] = 285,
        [D2FP_MNU_ITM_RAD_GRP] = 286,
        [D2FP_MNU_ITM_TYP] = 287,
        [D2FP_MNU_MOD] = 288,
        [D2FP_MNU_PARAM] = 289,
        [D2FP_MNU_PARAM_INIT_VAL] = 290,
        [D2FP_MNU_PARAM_INIT_VAL_STRID] = 291,
        [D2FP_MNU_ROLE] = 292,
        [D2FP_MNU_SRC] = 293,
        [D2FP_MNU_STY] = 294,
        [D2FP_MODAL] = 295,
        [D2FP_MODULE] = 296,
        [D2FP_MOUSE_NAVIGATE] = 297,
        [D2FP_MOUSE_NAVIGATION_LMT] = 298,
        [D2FP_MV_ALLOWED] = 299,
        [D2FP_NAME] = 300,
        [D2FP_NAVIGATION_STY] = 301,
        [D2FP_NEXT] = 302,
        [D2FP_NXT_NAVIGATION_BLK_NAM] = 303,
        [D2FP_NXT_NAVIGATION_BLK_OBJ] = 304,
        [D2FP_NXT_NAVIGATION_ITM_NAM] = 305,
        [D2FP_NXT_NAVIGATION_ITM_OBJ] = 306,
        [D2FP_OBJ_COUNT] = 307,
        [D2FP_OBJ_GRP] = 308,
        [D2FP_OBJ_GRP_CHILD_REAL_OBJ] = 309,
        [D2FP_OBJ_LIB_TAB] = 310,
        [D2FP_OG_CHILD] = 311,
        [D2FP_OLD_LOV_TXT] = 312,
        [D2FP_OLE_ACT_STY] = 313,
        [D2FP_OLE_CLASS] = 314,
        [D2FP_OLE_INSD_OUT_SUPPORT] = 315,
        [D2FP_OLE_IN_PLACE_ACT] = 316,
        [D2FP_OLE_POPUP_MNU_ITMS] = 317,
        [D2FP_OLE_RESIZ_STY] = 318,
        [D2FP_OLE_SHOW_POPUP_MNU] = 319,
        [D2FP_OLE_SHOW_TNNT_TYP] = 320,
        [D2FP_OLE_TNNT_ASPCT] = 321,
        [D2FP_OLE_TNNT_TYP] = 322,
        [D2FP_OPT_HINT] = 323,
        [D2FP_ORDR_BY_CLAUSE] = 324,
        [D2FP_OTHER_VALS] = 325,
        [D2FP_OWNER] = 326,
        [D2FP_PARAM_DAT_TYP] = 327,
        [D2FP_PARAM_INIT_VAL] = 328,
        [D2FP_PARAM_INIT_VAL_STRID] = 329,
        [D2FP_PAR_FLNAM] = 330,
        [D2FP_PAR_FLPATH] = 331,
        [D2FP_PAR_MODSTR] = 332,
        [D2FP_PAR_MODTYP] = 333,
        [D2FP_PAR_MODULE] = 334,
        [D2FP_PAR_NAM] = 335,
        [D2FP_PAR_SL1OBJ_NAM] = 336,
        [D2FP_PAR_SL1OBJ_TYP] = 337,
        [D2FP_PAR_SL2OBJ_NAM] = 338,
        [D2FP_PAR_SL2OBJ_TYP] = 339,
        [D2FP_PAR_TYP] = 340,
        [D2FP_PERSIST_CLIENT_INFO] = 341,
        [D2FP_PERSIST_CLT_INF_LEN] = 342,
        [D2FP_PGU_TXT] = 343,
        [D2FP_PGU_TYP] = 344,
        [D2FP_POINT] = 345,
        [D2FP_POPUP_MNU_NAM] = 346,
        [D2FP_POPUP_MNU_OBJ] = 347,
        [D2FP_POPUP_VA_OBJ] = 348,
        [D2FP_PRECOMP_SUMM] = 349,
        [D2FP_PREVIOUS] = 350,
        [D2FP_PREV_NAVIGATION_BLK_NAM] = 351,
        [D2FP_PREV_NAVIGATION_BLK_OBJ] = 352,
        [D2FP_PREV_NAVIGATION_ITM_NAM] = 353,
        [D2FP_PREV_NAVIGATION_ITM_OBJ] = 354,
        [D2FP_PRMPT] = 355,
        [D2FP_PRMPT_ALIGN] = 356,
        [D2FP_PRMPT_ALIGN_OFST] = 357,
        [D2FP_PRMPT_ATT_EDGE] = 358,
        [D2FP_PRMPT_ATT_OFST] = 359,
        [D2FP_PRMPT_BACK_COLOR] = 360,
        [D2FP_PRMPT_DISP_STY] = 361,
        [D2FP_PRMPT_FILL_PAT] = 362,
        [D2FP_PRMPT_FONT_NAM] = 363,
        [D2FP_PRMPT_FONT_SIZ] = 364,
        [D2FP_PRMPT_FONT_SPCING] = 365,
        [D2FP_PRMPT_FONT_STY] = 366,
        [D2FP_PRMPT_FONT_WGHT] = 367,
        [D2FP_PRMPT_FORE_COLOR] = 368,
        [D2FP_PRMPT_JST] = 369,
        [D2FP_PRMPT_READING_ORDR] = 370,
        [D2FP_PRMPT_STRID] = 371,
        [D2FP_PRMPT_VAT_NAM] = 372,
        [D2FP_PRMPT_VAT_OBJ] = 373,
        [D2FP_PRMRY_CNV] = 374,
        [D2FP_PRMRY_KEY] = 375,
        [D2FP_PROG_UNIT] = 376,
        [D2FP_PROP_CLASS] = 377,
        [D2FP_PRVNT_MSTRLESS_OPS] = 378,
        [D2FP_QRY_ALLOWED] = 379,
        [D2FP_QRY_ALL_RECS] = 380,
        [D2FP_QRY_DAT_SRC_ARG] = 381,
        [D2FP_QRY_DAT_SRC_COL] = 382,
        [D2FP_QRY_DAT_SRC_NAM] = 383,
        [D2FP_QRY_DAT_SRC_TYP] = 384,
        [D2FP_QRY_LEN] = 385,
        [D2FP_QRY_ONLY] = 386,
        [D2FP_RAD_BUT] = 387,
        [D2FP_RAISE_ON_ENT] = 388,
        [D2FP_RDB_VAL] = 389,
        [D2FP_READING_ORDR] = 390,
        [D2FP_REAL_UNIT] = 391,
        [D2FP_RECS_BUFFERED_COUNT] = 392,
        [D2FP_RECS_DISP_COUNT] = 393,
        [D2FP_RECS_FETCHED_COUNT] = 394,
        [D2FP_REC_GRP] = 395,
        [D2FP_REC_GRP_FETCH_SIZ] = 396,
        [D2FP_REC_GRP_NAM] = 397,
        [D2FP_REC_GRP_OBJ] = 398,
        [D2FP_REC_GRP_QRY] = 399,
        [D2FP_REC_GRP_TYP] = 400,
        [D2FP_REC_ORNT] = 401,
        [D2FP_REC_VAT_GRP_NAM] = 402,
        [D2FP_REC_VAT_GRP_OBJ] = 403,
        [D2FP_REL] = 404,
        [D2FP_REL_TYPE] = 405,
        [D2FP_RENDERED] = 406,
        [D2FP_REPORT] = 407,
        [D2FP_REQUIRED] = 408,
        [D2FP_RESIZE_ALLOWED] = 409,
        [D2FP_REV_DIR] = 410,
        [D2FP_ROLE_COUNT] = 411,
        [D2FP_RPT_DESTINATION_FMT] = 412,
        [D2FP_RPT_DESTINATION_NAM] = 413,
        [D2FP_RPT_DESTINATION_TYP] = 414,
        [D2FP_RPT_PARAMS] = 415,
        [D2FP_RPT_SRVR] = 416,
        [D2FP_RTRN_ITM] = 417,
        [D2FP_RUNTIME_COMP] = 418,
        [D2FP_SCRLBR_ALIGN] = 419,
        [D2FP_SCRLBR_CNV_NAM] = 420,
        [D2FP_SCRLBR_CNV_OBJ] = 421,
        [D2FP_SCRLBR_LEN] = 422,
        [D2FP_SCRLBR_ORNT] = 423,
        [D2FP_SCRLBR_TBP_NAM] = 424,
        [D2FP_SCRLBR_TBP_OBJ] = 425,
        [D2FP_SCRLBR_WID] = 426,
        [D2FP_SCRLBR_X_POS] = 427,
        [D2FP_SCRLBR_Y_POS] = 428,
        [D2FP_SHARE_LIB] = 429,
        [D2FP_SHOW_FAST_FWD] = 430,
        [D2FP_SHOW_HORZ_SCRLBR] = 431,
        [D2FP_SHOW_PALETTE] = 432,
        [D2FP_SHOW_PLAY] = 433,
        [D2FP_SHOW_REC] = 434,
        [D2FP_SHOW_REWIND] = 435,
        [D2FP_SHOW_SCRLBR] = 436,
        [D2FP_SHOW_SLIDER] = 437,
        [D2FP_SHOW_TIME] = 438,
        [D2FP_SHOW_VERT_SCRLBR] = 439,
        [D2FP_SHOW_VOLUME] = 440,
        [D2FP_SHRINKWRAP] = 441,
        [D2FP_SIZING_STY] = 442,
        [D2FP_SND_FMT] = 443,
        [D2FP_SND_QLTY] = 444,
        [D2FP_SNGL_OBJ_ALIGN] = 445,
        [D2FP_SNGL_REC] = 446,
        [D2FP_SOURCE] = 447,
        [D2FP_STRTUP_CODE] = 448,
        [D2FP_STRT_PRMPT_ALIGN] = 449,
        [D2FP_STRT_PRMPT_OFST] = 450,
        [D2FP_SUBCL_OBJGRP] = 451,
        [D2FP_SUBCL_SUBOBJ] = 452,
        [D2FP_SUB_MNU_NAM] = 453,
        [D2FP_SUB_MNU_OBJ] = 454,
        [D2FP_SUB_TTL] = 455,
        [D2FP_SUB_TTL_STRID] = 456,
        [D2FP_SUMM_BLK_NAM] = 457,
        [D2FP_SUMM_FUNC] = 458,
        [D2FP_SUMM_ITM_NAM] = 459,
        [D2FP_SVPNT_MODE] = 460,
        [D2FP_SYNC_ITM_NAM] = 461,
        [D2FP_SYNC_ITM_OBJ] = 462,
        [D2FP_TAB_ACT_STY] = 463,
        [D2FP_TAB_ATT_EDGE] = 464,
        [D2FP_TAB_PAGE] = 465,
        [D2FP_TAB_STY] = 466,
        [D2FP_TAB_WID_STY] = 467,
        [D2FP_TBP_NAM] = 468,
        [D2FP_TBP_OBJ] = 469,
        [D2FP_TEAR_OFF_MNU] = 470,
        [D2FP_TEXT] = 471,
        [D2FP_TEXT_SEG] = 472,
        [D2FP_TEXT_STRID] = 473,
        [D2FP_TITLE] = 474,
        [D2FP_TITLE_STRID] = 475,
        [D2FP_TOOLTIP] = 476,
        [D2FP_TOOLTIP_STRID] = 477,
        [D2FP_TOOLTIP_VAT_GRP] = 478,
        [D2FP_TOP_PRMPT_ALIGN] = 479,
        [D2FP_TOP_PRMPT_OFST] = 480,
        [D2FP_TRE_ALLW_EMP_BRANCH] = 481,
        [D2FP_TRE_DATA_QRY] = 482,
        [D2FP_TRE_MULTI_SELECT] = 483,
        [D2FP_TRE_REC_GRP] = 484,
        [D2FP_TRE_SHOW_LINES] = 485,
        [D2FP_TRE_SHOW_SYMBOL] = 486,
        [D2FP_TRG_INTERNAL_TYP] = 487,
        [D2FP_TRG_STY] = 488,
        [D2FP_TRG_TXT] = 489,
        [D2FP_TRIGGER] = 490,
        [D2FP_TTL_READING_ORDR] = 491,
        [D2FP_UNCHKED_VAL] = 492,
        [D2FP_UPDT_ALLOWED] = 493,
        [D2FP_UPDT_CHANGED_COLS] = 494,
        [D2FP_UPDT_COMMIT] = 495,
        [D2FP_UPDT_IF_NULL] = 496,
        [D2FP_UPDT_LAYOUT] = 497,
        [D2FP_UPDT_PROC_NAM] = 498,
        [D2FP_UPDT_QRY] = 499,
        [D2FP_UPD_DAT_SRC_ARG] = 500,
        [D2FP_UPD_DAT_SRC_COL] = 501,
        [D2FP_USE_3D_CNTRLS] = 502,
        [D2FP_USE_SECURITY] = 503,
        [D2FP_VALIDATE_FROM_LST] = 504,
        [D2FP_VALIDATION_UNIT] = 505,
        [D2FP_VAT_NAM] = 506,
        [D2FP_VAT_OBJ] = 507,
        [D2FP_VAT_TYP] = 508,
        [D2FP_VERT_FILL] = 509,
        [D2FP_VERT_JST] = 510,
        [D2FP_VERT_MARGN] = 511,
        [D2FP_VERT_OBJ_OFST] = 512,
        [D2FP_VERT_ORGN] = 513,
        [D2FP_VERT_TLBR_CNV] = 514,
        [D2FP_VISIBLE] = 515,
        [D2FP_VIS_ATTR] = 516,
        [D2FP_VPRT_HGT] = 517,
        [D2FP_VPRT_WID] = 518,
        [D2FP_VPRT_X_POS] = 519,
        [D2FP_VPRT_X_POS_ON_CNV] = 520,
        [D2FP_VPRT_Y_POS] = 521,
        [D2FP_VPRT_Y_POS_ON_CNV] = 522,
        [D2FP_VSBL_IN_HORZ_MNU_TLBR] = 523,
        [D2FP_VSBL_IN_MENU] = 524,
        [D2FP_VSBL_IN_VERT_MNU_TLBR] = 525,
        [D2FP_VTB_CNV_NAME] = 526,
        [D2FP_WHERE_CLAUSE] = 527,
        [D2FP_WHITE_ON_BLACK] = 528,
        [D2FP_WIDTH] = 529,
        [D2FP_WINDOW] = 530,
        [D2FP_WIN_STY] = 531,
        [D2FP_WND_NAM] = 532,
        [D2FP_WND_OBJ] = 533,
        [D2FP_WRAP_STY] = 534,
        [D2FP_WRAP_TXT] = 535,
        [D2FP_X_POS] = 536,
        [D2FP_Y_POS] = 537,
        [D2FP_COLUMN_VALUE] = 538,
        [D2FP_GRA_TEXT_STRID] = 539,
        [D2FP_NEWDEFER_REQ_ENF] = 540,
        [D2FP_CHAR_MODE_LOGICAL_ATTR] = 541,
        [D2FP_ABORT_FAIL] = 542,
        [D2FP_FAIL_LABEL] = 543,
        [D2FP_FAIL_MSG] = 544,
        [D2FP_NEW_CURSOR] = 545,
        [D2FP_REV_RET] = 546,
        [D2FP_SUCC_ABORT] = 547,
        [D2FP_SUCC_LABEL] = 548,
        [D2FP_TRIG_STEP_TXT] = 549,
        [D2FP_TRIG_STEP] = 550,
        [D2FP_QRY_NAME] = 551,
        [D2FP_MAX] = 551,
        [D2FP_TYP_UNKNOWN] = 0,
        [D2FP_TYP_BOOLEAN] = 1,
        [D2FP_TYP_NUMBER] = 2,
        [D2FP_TYP_TEXT] = 3,
        [D2FP_TYP_OBJECT] = 4,
        [BINTOTEXT] = 1,
        [TEXTTOBIN] = 2
    };
}
