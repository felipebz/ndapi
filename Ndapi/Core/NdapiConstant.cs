﻿namespace Ndapi.Core;

// ReSharper disable InconsistentNaming
// disable rule because we want to keep the same name as the constants in the d2fdef.h file

public enum NdapiConstant
{
    D2FC_UNDEFINED,
    D2FC_DFAL_BTN1,
    D2FC_DFAL_BTN2,
    D2FC_DFAL_BTN3,
    D2FC_JUST_LEFT,
    D2FC_JUST_RIGHT,
    D2FC_JUST_CENTER,
    D2FC_JUST_START,
    D2FC_JUST_END,
    D2FC_ALST_STOP,
    D2FC_ALST_CAUTION,
    D2FC_ALST_NOTE,
    D2FC_DSMO_IN,
    D2FC_DSMO_OUT,
    D2FC_DSMO_IN_OUT,
    D2FC_ARST_NONE,
    D2FC_ARST_START,
    D2FC_ARST_END,
    D2FC_ARST_BOTH,
    D2FC_ARST_MDLTOSTRT,
    D2FC_ARST_MDLTOEND,
    D2FC_GRTY_ARC,
    D2FC_GRTY_IMAGE,
    D2FC_GRTY_LINE,
    D2FC_GRTY_POLY,
    D2FC_GRTY_RECT,
    D2FC_GRTY_RREC,
    D2FC_GRTY_TEXT,
    D2FC_GRTY_GROUP,
    D2FC_GRTY_FRAME,
    D2FC_BEST_RAISED,
    D2FC_BEST_LOWERED,
    D2FC_BEST_NONE,
    D2FC_BEST_NSET,
    D2FC_BEST_OUTSET,
    D2FC_BEST_PLAIN,
    D2FC_DSTY_VARCHAR2,
    D2FC_DSTY_NUMBER,
    D2FC_DSTY_LONG,
    D2FC_DSTY_ROWID,
    D2FC_DSTY_DATE,
    D2FC_DSTY_RAW,
    D2FC_DSTY_LONG_RAW,
    D2FC_DSTY_CHAR,
    D2FC_DSTY_MLSLABEL,
    D2FC_DSTY_TABLE,
    D2FC_DSTY_RECORD,
    D2FC_DSTY_REFCURSOR,
    D2FC_DSTY_NAMEDTYPE,
    D2FC_DSTY_OBJECTREF,
    D2FC_DSTY_VARRAY,
    D2FC_DSTY_NESTEDTAB,
    D2FC_DSTY_BLOB,
    D2FC_DSTY_CLOB,
    D2FC_DSTY_BFILE,
    D2FC_DSTY_CFILE,
    D2FC_DSTY_UNKNOWN,
    D2FC_DSTY_NVARCHAR2,
    D2FC_DSTY_NCHAR,
    D2FC_DSTY_NCLOB,
    D2FC_COMO_SYNCH,
    D2FC_COMO_ASYNCH,
    D2FC_COSY_CHARACTER,
    D2FC_COSY_REAL,
    D2FC_QRDA_NONE,
    D2FC_QRDA_TABLE,
    D2FC_QRDA_PROCEDURE,
    D2FC_QRDA_TRANS_TRIG,
    D2FC_QRDA_FRM_CLS_QUERY,
    D2FC_DMDA_NONE,
    D2FC_DMDA_TABLE,
    D2FC_DMDA_PROCEDURE,
    D2FC_DMDA_TRANS_TRIG,
    D2FC_PRAT_START,
    D2FC_PRAT_END,
    D2FC_PRAT_TOP,
    D2FC_PRAT_BOTTOM,
    D2FC_EXMO_BATCH,
    D2FC_EXMO_RUNTIME,
    D2FC_LISR_FS,
    D2FC_LISR_DB,
    D2FC_UPLA_MANUAL,
    D2FC_UPLA_AUTO,
    D2FC_UPLA_LOCKED,
    D2FC_ITTY_BA,
    D2FC_ITTY_CB,
    D2FC_ITTY_DI,
    D2FC_ITTY_TRE,
    D2FC_ITTY_IM,
    D2FC_ITTY_LS,
    D2FC_ITTY_PB,
    D2FC_ITTY_RD,
    D2FC_ITTY_TI,
    D2FC_ITTY_UA,
    D2FC_ITTY_ACT,
    D2FC_ITTY_CA,
    D2FC_ITTY_OLE,
    D2FC_ITTY_SN,
    D2FC_ITTY_VBX,
    D2FC_ITTY_MAX,
    D2FC_OLAC_DOUBLECLICK,
    D2FC_OLAC_MANUAL,
    D2FC_OLAC_FOCUS,
    D2FC_PRDI_HIDDEN,
    D2FC_PRDI_FIRST,
    D2FC_PRDI_EACH,
    D2FC_PGTY_UNKNOWN,
    D2FC_PGTY_PROCEDURE,
    D2FC_PGTY_FUNCTION,
    D2FC_PGTY_PACKAGESPEC,
    D2FC_PGTY_PACKAGEBODY,
    D2FC_REUN_PIXEL,
    D2FC_REUN_CENTIMETER,
    D2FC_REUN_INCH,
    D2FC_REUN_POINT,
    D2FC_REUN_DECIPOINT,
    D2FC_RELT_JOIN,
    D2FC_RELT_REF,
    D2FC_RUCO_45,
    D2FC_RUCO_50,
    D2FC_TAAT_TOP,
    D2FC_TAAT_BOTTOM,
    D2FC_TAAT_LEFT,
    D2FC_TAAT_RIGHT,
    D2FC_TAAT_START,
    D2FC_TAAT_END,
    D2FC_TAST_CHAMFERED,
    D2FC_TAST_SQUARE,
    D2FC_TAST_ROUNDED,
    D2FC_VATY_COMMON,
    D2FC_VATY_PROMPT,
    D2FC_VATY_TITLE,
    D2FC_CODA_CHAR,
    D2FC_CODA_NUMBER,
    D2FC_CODA_DATE,
    D2FC_CODA_LONG,
    D2FC_CODA_REF,
    D2FC_AUCH_AUTO,
    D2FC_AUCH_MONO,
    D2FC_AUCH_STEREO,
    D2FC_CAMO_NONE,
    D2FC_CAMO_FORMULA,
    D2FC_CAMO_SUMMARY,
    D2FC_CRMO_OPEN,
    D2FC_CRMO_CLOSE,
    D2FC_CAST_BUTT,
    D2FC_CAST_ROUND,
    D2FC_CAST_PROJECT,
    D2FC_CMQL_NONE,
    D2FC_CMQL_MIN,
    D2FC_CMQL_LOW,
    D2FC_CMQL_MED,
    D2FC_CMQL_HIGH,
    D2FC_CMQL_MAX,
    D2FC_CARS_MIXED,
    D2FC_CARS_UPPER,
    D2FC_CARS_LOWER,
    D2FC_CNTY_CONTENT,
    D2FC_CNTY_STACKED,
    D2FC_CNTY_VTOOLBAR,
    D2FC_CNTY_HTOOLBAR,
    D2FC_CNTY_TAB,
    D2FC_CHBX_ILLEGAL,
    D2FC_CHBX_CHECKED,
    D2FC_CHBX_UNCHECKED,
    D2FC_LADI_DEFAULT,
    D2FC_LADI_TORIGHT,
    D2FC_LADI_TOLEFT,
    D2FC_INKB_DEFAULT,
    D2FC_INKB_ROMAN,
    D2FC_INKB_NATIVE,
    D2FC_IMDP_ORIG,
    D2FC_IMDP_MONO,
    D2FC_IMDP_GRAY,
    D2FC_IMDP_LUT,
    D2FC_IMDP_RGB,
    D2FC_DAST_SOLID,
    D2FC_DAST_DOT,
    D2FC_DAST_DASH,
    D2FC_DAST_DASHDOT,
    D2FC_DAST_DOUBDOT,
    D2FC_DAST_LONGDASH,
    D2FC_DAST_DASHDOUBDOT,
    D2FC_EXHI_OVERRIDE,
    D2FC_EXHI_BEFORE,
    D2FC_EXHI_AFTER,
    D2FC_FRAL_START,
    D2FC_FRAL_END,
    D2FC_FRAL_CENTER,
    D2FC_FRAL_FILL,
    D2FC_FRAL_COLUMN,
    D2FC_FOSP_ULTRADENSE,
    D2FC_FOSP_EXTRADENSE,
    D2FC_FOSP_DENSE,
    D2FC_FOSP_SEMIDENSE,
    D2FC_FOSP_NORMAL,
    D2FC_FOSP_SEMIEXPAND,
    D2FC_FOSP_EXPAND,
    D2FC_FOSP_EXTRAEXPAND,
    D2FC_FOSP_ULTRAEXPAND,
    D2FC_FOST_PLAIN,
    D2FC_FOST_ITALIC,
    D2FC_FOST_OBLIQUE,
    D2FC_FOST_UNDERLINE,
    D2FC_FOST_OUTLINE,
    D2FC_FOST_SHADOW,
    D2FC_FOST_INVERTED,
    D2FC_FOST_OVERSTRIKE,
    D2FC_FOST_BLINK,
    D2FC_FOWG_ULTRALIGHT,
    D2FC_FOWG_EXTRALIGHT,
    D2FC_FOWG_LIGHT,
    D2FC_FOWG_DEMILIGHT,
    D2FC_FOWG_MEDIUM,
    D2FC_FOWG_DEMIBOLD,
    D2FC_FOWG_BOLD,
    D2FC_FOWG_EXTRABOLD,
    D2FC_FOWG_ULTRABOLD,
    D2FC_LAST_FORM,
    D2FC_LAST_TABULAR,
    D2FC_HOOR_LEFT,
    D2FC_HOOR_RIGHT,
    D2FC_HOOR_CENTER,
    D2FC_HOJU_LEFT,
    D2FC_HOJU_RIGHT,
    D2FC_HOJU_CENTER,
    D2FC_HOJU_START,
    D2FC_HOJU_END,
    D2FC_DATY_CHAR,
    D2FC_DATY_NUMBER,
    D2FC_DATY_DATE,
    D2FC_DATY_ALPHA,
    D2FC_DATY_INTEGER,
    D2FC_DATY_DATETIME,
    D2FC_DATY_LONG,
    D2FC_DATY_RNUMBER,
    D2FC_DATY_JDATE,
    D2FC_DATY_EDATE,
    D2FC_DATY_TIME,
    D2FC_DATY_RINTEGER,
    D2FC_DATY_MONEY,
    D2FC_DATY_RMONEY,
    D2FC_DATY_OBJECTREF,
    D2FC_DATY_LOB,
    D2FC_DATY_FILE,
    D2FC_DATY_NCHAR,
    D2FC_IMFM_BMP,
    D2FC_IMFM_CALS,
    D2FC_IMFM_GIF,
    D2FC_IMFM_JFIF,
    D2FC_IMFM_PICT,
    D2FC_IMFM_RAS,
    D2FC_IMFM_TIFF,
    D2FC_IMFM_TPIC,
    D2FC_IMFM_NATIVE,
    D2FC_DIQL_HIGH,
    D2FC_DIQL_MEDIUM,
    D2FC_DIQL_LOW,
    D2FC_SIST_CROP,
    D2FC_SIST_ADJUST,
    D2FC_SIST_FILL,
    D2FC_JOST_MITRE,
    D2FC_JOST_BEVEL,
    D2FC_JOST_ROUND,
    D2FC_KEMO_UNIQUE,
    D2FC_KEMO_UPDATEABLE,
    D2FC_KEMO_NUPDATEABLE,
    D2FC_KEMO_AUTO,
    D2FC_ALIG_START,
    D2FC_ALIG_END,
    D2FC_ALIG_CENTER,
    D2FC_INMO_BLOCKING,
    D2FC_INMO_NONBLOCKING,
    D2FC_ISMO_READ,
    D2FC_ISMO_SERIAL,
    D2FC_LOMO_IMMEDIATE,
    D2FC_LOMO_DELAYED,
    D2FC_LOMO_AUTO,
    D2FC_LSST_POPLIST,
    D2FC_LSST_TLIST,
    D2FC_LSST_COMBO,
    D2FC_LSTY_RECORDGROUP,
    D2FC_LSTY_OLD,
    D2FC_COTY_NULL,
    D2FC_COTY_MENU,
    D2FC_COTY_PLSQL,
    D2FC_COTY_PLUS,
    D2FC_COTY_FORM,
    D2FC_COTY_MACRO,
    D2FC_DERE_CASCADING,
    D2FC_DERE_ISOLATED,
    D2FC_DERE_NON_ISOLATED,
    D2FC_MAIT_NONE,
    D2FC_MAIT_CUT,
    D2FC_MAIT_COPY,
    D2FC_MAIT_PASTE,
    D2FC_MAIT_CLEAR,
    D2FC_MAIT_UNDO,
    D2FC_MAIT_HELP,
    D2FC_MAIT_ABOUT,
    D2FC_MAIT_QUIT,
    D2FC_MAIT_WINDOW,
    D2FC_MAIT_PAGESETUP,
    D2FC_MONA_FORM,
    D2FC_MONA_BLOCK,
    D2FC_MONA_RECORD,
    D2FC_MONA_ITEM,
    D2FC_MNST_PULLDOWN,
    D2FC_MNST_FULLSCREEN,
    D2FC_MNSR_FILE,
    D2FC_MNSR_DB,
    D2FC_MNIT_PLAIN,
    D2FC_MNIT_CHECK,
    D2FC_MNIT_RADIO,
    D2FC_MNIT_SEPARATOR,
    D2FC_MNIT_MAGIC,
    D2FC_NAST_SAMERECORD,
    D2FC_NAST_CHANGERECORD,
    D2FC_NAST_CHANGEBLOCK,
    D2FC_PAMO_FILESYSTEM,
    D2FC_PAMO_DATABASE,
    D2FC_REOR_VERTICAL,
    D2FC_REOR_HORIZONTAL,
    D2FC_OLTN_ANY,
    D2FC_OLTN_NONE,
    D2FC_OLTN_STATIC,
    D2FC_OLTN_LINKED,
    D2FC_OLTN_EMBEDDED,
    D2FC_OLTN_CONTROL,
    D2FC_PADA_CHAR,
    D2FC_PADA_NUMBER,
    D2FC_PADA_DATE,
    D2FC_REGR_QUERY,
    D2FC_REGR_STATIC,
    D2FC_READ_DEFAULT,
    D2FC_READ_TORIGHT,
    D2FC_READ_TOLEFT,
    D2FC_RPDE_PREVIEW,
    D2FC_RPDE_FILE,
    D2FC_RPDE_PRINTER,
    D2FC_RPDE_MAIL,
    D2FC_RPDE_CACHE,
    D2FC_RPDE_SCREEN,
    D2FC_OLRE_CLIP,
    D2FC_OLRE_SCALE,
    D2FC_OLRE_INITIAL,
    D2FC_OLRE_DYNAMIC,
    D2FC_COMP_AUTO,
    D2FC_COMP_OFF,
    D2FC_COMP_ON,
    D2FC_SNFM_AU,
    D2FC_SNFM_AIFF,
    D2FC_SNFM_AIFF_C,
    D2FC_SNFM_WAVE,
    D2FC_SNQL_AUTO,
    D2FC_SNQL_HIGHEST,
    D2FC_SNQL_HIGH,
    D2FC_SNQL_MEDIUM,
    D2FC_SNQL_LOW,
    D2FC_SNQL_LOWEST,
    D2FC_SCOR_VERTICAL,
    D2FC_SCOR_HORIZONTAL,
    D2FC_SCAL_START,
    D2FC_SCAL_END,
    D2FC_LISP_SINGLE,
    D2FC_LISP_ONEHALF,
    D2FC_LISP_DOUBLE,
    D2FC_LISP_CUSTOM,
    D2FC_SUFU_NONE,
    D2FC_SUFU_AVG,
    D2FC_SUFU_COUNT,
    D2FC_SUFU_MAX,
    D2FC_SUFU_MIN,
    D2FC_SUFU_STDDEV,
    D2FC_SUFU_SUM,
    D2FC_SUFU_VAR,
    D2FC_OLET_CONTENT,
    D2FC_OLET_ICON,
    D2FC_OLET_THUMBNAIL,
    D2FC_TRST_PLSQL,
    D2FC_TRST_V2,
    D2FC_TRTY_BUILTIN,
    D2FC_TRTY_USERNAMED,
    D2FC_VEOR_TOP,
    D2FC_VEOR_CENTER,
    D2FC_VEOR_BOTTOM,
    D2FC_VEJU_TOP,
    D2FC_VEJU_CENTER,
    D2FC_VEJU_BOTTOM,
    D2FC_KBST_ANY,
    D2FC_KBST_ROMAN,
    D2FC_KBST_NATIVE,
    D2FC_VAUN_DEFAULT,
    D2FC_VAUN_FORM,
    D2FC_VAUN_BLOCK,
    D2FC_VAUN_RECORD,
    D2FC_VAUN_ITEM,
    D2FC_WRST_NONE,
    D2FC_WRST_CHARACTER,
    D2FC_WRST_WORD,
    D2FC_WIST_DOCUMENT,
    D2FC_WIST_DIALOG,
    D2FC_CHLE_NULL,
    D2FC_CHLE_BYTE,
    D2FC_CHLE_CHAR,
    D2FC_EVENT_TYPE_DATABASE,
    D2FC_EVENT_TYPE_USERDEFINED,
    D2FC_EVENT_TYPE_SYSTEMIDLE,
    D2FC_EVENT_TYPE_SYSTEMDBIDLE,
    D2FC_EVENT_TYPE_SYSTEMLOGOUT,
    D2FC_EVENT_TYPE_SYSTEMEMPING,
    D2FC_EVENT_TYPE_SYSTEMMEDIADONE,
    D2FC_EVENT_SCOPE_APPLICATION,
    D2FC_EVENT_SCOPE_FORM,
    D2FC_EVENT_VIEW_MODE_BROWSE,
    D2FC_EVENT_VIEW_MODE_LOCKED,
    D2FC_EVENT_VIEW_MODE_REMOVE,
    D2FC_CURSOR_STYLE_UNSPECIFIED,
    D2FC_CURSOR_STYLE_BUSY,
    D2FC_CURSOR_STYLE_CROSSHAIR,
    D2FC_CURSOR_STYLE_DEFAULT,
    D2FC_CURSOR_STYLE_INSERTION,
    D2FC_CURSOR_STYLE_HAND,
    D2FC_CURSOR_STYLE_MOVE,
    D2FC_CURSOR_STYLE_NRESIZE,
    D2FC_CURSOR_STYLE_SRESIZE,
    D2FC_CURSOR_STYLE_ERESIZE,
    D2FC_CURSOR_STYLE_WRESIZE,
    D2FC_CURSOR_STYLE_NERESIZE,
    D2FC_CURSOR_STYLE_NWRESIZE,
    D2FC_CURSOR_STYLE_SERESIZE,
    D2FC_CURSOR_STYLE_SWRESIZE,
    D2FC_GRADIENT_NONE,
    D2FC_GRADIENT_LEFT,
    D2FC_GRADIENT_TOP,
    D2FC_GRADIENT_RIGHT,
    D2FC_GRADIENT_BOTTOM,
    D2FFO_MIN,
    D2FFO_MAX,
    D2FFO_UNDEFINED,
    D2FFO_ANY,
    D2FFO_ALERT,
    D2FFO_ATT_LIB,
    D2FFO_BLOCK,
    D2FFO_CANVAS,
    D2FFO_CMPTXT,
    D2FFO_COLUMN_VALUE,
    D2FFO_COORD,
    D2FFO_DAT_SRC_ARG,
    D2FFO_DAT_SRC_COL,
    D2FFO_EDITOR,
    D2FFO_EVENT,
    D2FFO_FONT,
    D2FFO_FORM_MODULE,
    D2FFO_FORM_PARAM,
    D2FFO_GRAPHIC,
    D2FFO_ITEM,
    D2FFO_LIB_PROG_UNIT,
    D2FFO_LIBRARY_MODULE,
    D2FFO_LOV,
    D2FFO_LV_COLMAP,
    D2FFO_MENU,
    D2FFO_MENU_ITEM,
    D2FFO_MENU_MODULE,
    D2FFO_MENU_PARAM,
    D2FFO_OBJ_GROUP,
    D2FFO_OBG_CHILD,
    D2FFO_OBJ_LIB,
    D2FFO_OBJ_LIB_TAB,
    D2FFO_POINT,
    D2FFO_PROG_UNIT,
    D2FFO_PROP_CLASS,
    D2FFO_RADIO_BUTTON,
    D2FFO_REC_GROUP,
    D2FFO_RELATION,
    D2FFO_REPORT,
    D2FFO_RG_COLSPEC,
    D2FFO_TAB_PAGE,
    D2FFO_TEXT_SEG,
    D2FFO_TRIGGER,
    D2FFO_TRIG_STEP,
    D2FFO_VIS_ATTR,
    D2FFO_VIS_STATE,
    D2FFO_WINDOW,
    D2FP_UNDEFINED,
    D2FP_MIN,
    D2FP_MAX,
    D2FP_NONE,
    D2FP_ABORT_FAIL,
    D2FP_ACCESS_KEY,
    D2FP_ACCESS_KEY_STRID,
    D2FP_ALERT,
    D2FP_ALIAS,
    D2FP_ALLOW_EXPANSION,
    D2FP_ALLOW_MLT_LIN_PRMPTS,
    D2FP_ALLOW_STRT_ATT_PRMPTS,
    D2FP_ALLOW_TOP_ATT_PRMPTS,
    D2FP_ALT_MSG,
    D2FP_ALT_MSG_STRID,
    D2FP_ALT_STY,
    D2FP_ARROW_STY,
    D2FP_ASSOC_MENUS_COUNT,
    D2FP_ASSOC_MNUS,
    D2FP_ATT_LIB,
    D2FP_AUDIO_CHNNLS,
    D2FP_AUTO_COL_WID,
    D2FP_AUTO_DISP,
    D2FP_AUTO_HINT,
    D2FP_AUTO_POS,
    D2FP_AUTO_QRY,
    D2FP_AUTO_RFRSH,
    D2FP_AUTO_SKP,
    D2FP_AUTO_SLCT,
    D2FP_BACK_COLOR,
    D2FP_BEVEL,
    D2FP_BLK_DESCRIPTION,
    D2FP_BLK_DSCRP_STRID,
    D2FP_BLOCK,
    D2FP_BOUNDING_BX_SCALABLE,
    D2FP_BTM_TTL,
    D2FP_BTM_TTL_STRID,
    D2FP_BTN_1_LBL,
    D2FP_BTN_1_LBL_STRID,
    D2FP_BTN_2_LBL,
    D2FP_BTN_2_LBL_STRID,
    D2FP_BTN_3_LBL,
    D2FP_BTN_3_LBL_STRID,
    D2FP_CALC_MODE,
    D2FP_CANVAS,
    D2FP_CAP_STY,
    D2FP_CASE_INSENSITIVE_QRY,
    D2FP_CASE_RSTRCTION,
    D2FP_CENTER_TRACKING,
    D2FP_CHAR_CELL_HDEN,
    D2FP_CHAR_CELL_HGT,
    D2FP_CHAR_CELL_HNUM,
    D2FP_CHAR_CELL_VDEN,
    D2FP_CHAR_CELL_VNUM,
    D2FP_CHAR_CELL_WID,
    D2FP_CHKED_VAL,
    D2FP_CHK_BX_OTHER_VALS,
    D2FP_CLIENT_INFO,
    D2FP_CLIP_HGT,
    D2FP_CLIP_WID,
    D2FP_CLIP_X_POS,
    D2FP_CLIP_Y_POS,
    D2FP_CLOSED,
    D2FP_CLS_ALLOWED,
    D2FP_CMPRSSION_QLTY,
    D2FP_CMPTXT,
    D2FP_CNV_NAM,
    D2FP_CNV_OBJ,
    D2FP_CNV_TYP,
    D2FP_COLUMN_VALUE,
    D2FP_COL_DAT_TYP,
    D2FP_COL_MAP,
    D2FP_COL_NAM,
    D2FP_COL_SPEC,
    D2FP_COL_VALS_COUNT,
    D2FP_COMMENT,
    D2FP_COMM_MODE,
    D2FP_COMPRESS,
    D2FP_COM_TXT,
    D2FP_COM_TYP,
    D2FP_CONCEAL_DATA,
    D2FP_CONSOLE_WIN,
    D2FP_COORD_SYS,
    D2FP_COPY_VAL_FROM_ITM,
    D2FP_CORNER_RADIUS_X,
    D2FP_CORNER_RADIUS_Y,
    D2FP_CRSR_MODE,
    D2FP_CSTM_SPCING,
    D2FP_CURSOR_STYLE,
    D2FP_DASH_STY,
    D2FP_DATA_LEN_SEMANTICS,
    D2FP_DAT_SRC_BLK,
    D2FP_DAT_SRC_X_AXS,
    D2FP_DAT_SRC_Y_AXS,
    D2FP_DAT_TYP,
    D2FP_DB_BLK,
    D2FP_DB_ITM,
    D2FP_DEFERRED,
    D2FP_DEFER_REQ_ENF,
    D2FP_DEL_ALLOWED,
    D2FP_DEL_DAT_SRC_ARG,
    D2FP_DEL_DAT_SRC_COL,
    D2FP_DEL_PROC_NAM,
    D2FP_DEL_REC,
    D2FP_DETAIL_BLK,
    D2FP_DETAIL_ITEMREF,
    D2FP_DFLT_ALT_BTN,
    D2FP_DFLT_BTN,
    D2FP_DFLT_FNT_SCALING,
    D2FP_DIRTY_INFO,
    D2FP_DISP_IN_KBRD_HLP,
    D2FP_DISP_NO_PRIV,
    D2FP_DISP_QLTY,
    D2FP_DISP_VIEWPORT,
    D2FP_DISP_WID,
    D2FP_DIST_BTWN_RECS,
    D2FP_DITHER,
    D2FP_DML_ARY_SIZ,
    D2FP_DML_DAT_NAM,
    D2FP_DML_DAT_TYP,
    D2FP_DML_RET_VAL,
    D2FP_DRAWING_HDEN,
    D2FP_DRAWING_HNUM,
    D2FP_DRAWING_WDEN,
    D2FP_DRAWING_WNUM,
    D2FP_DSA_MODE,
    D2FP_DSA_NAM,
    D2FP_DSA_TYP,
    D2FP_DSA_TYP_NAM,
    D2FP_DSA_VAL,
    D2FP_DSC_LEN,
    D2FP_DSC_MANDATORY,
    D2FP_DSC_NAM,
    D2FP_DSC_NOCHILDREN,
    D2FP_DSC_PARENT_NAME,
    D2FP_DSC_PRECISION,
    D2FP_DSC_SCALE,
    D2FP_DSC_TYP,
    D2FP_DSC_TYPE_NAME,
    D2FP_DS_DEL_ARG_LIST,
    D2FP_DS_DEL_COL_LIST,
    D2FP_DS_INS_ARG_LIST,
    D2FP_DS_INS_COL_LIST,
    D2FP_DS_LOK_ARG_LIST,
    D2FP_DS_LOK_COL_LIST,
    D2FP_DS_QRY_ARG_LIST,
    D2FP_DS_QRY_COL_LIST,
    D2FP_DS_UPD_ARG_LIST,
    D2FP_DS_UPD_COL_LIST,
    D2FP_EDGE_BACK_COLOR,
    D2FP_EDGE_FORE_COLOR,
    D2FP_EDGE_PAT,
    D2FP_EDITOR,
    D2FP_EDITOR_HEIGHT,
    D2FP_EDITOR_WIDTH,
    D2FP_EDT_NAM,
    D2FP_EDT_OBJ,
    D2FP_EDT_X_POS,
    D2FP_EDT_Y_POS,
    D2FP_ENABLED,
    D2FP_ENFRC_COL_SECURITY,
    D2FP_ENFRC_PRMRY_KEY,
    D2FP_EVENT,
    D2FP_EVENT_CORRID,
    D2FP_EVENT_ENABLED,
    D2FP_EVENT_IMPLCLASS,
    D2FP_EVENT_PRIORITY_MODE,
    D2FP_EVENT_SCOPE,
    D2FP_EVENT_SUBS_NAME,
    D2FP_EVENT_TYPE,
    D2FP_EVENT_VIEW_MODE,
    D2FP_EXEC_HIERARCHY,
    D2FP_EXEC_MODE,
    D2FP_FAIL_LABEL,
    D2FP_FAIL_MSG,
    D2FP_FAIL_MSG_STRID,
    D2FP_FILL_PAT,
    D2FP_FIRE_IN_QRY,
    D2FP_FIXED_BOUNDING_BX,
    D2FP_FIXED_LEN,
    D2FP_FLNAM,
    D2FP_FLTR_BEFORE_DISP,
    D2FP_FMT_MSK,
    D2FP_FONT_NAM,
    D2FP_FONT_SCALEABLE,
    D2FP_FONT_SIZ,
    D2FP_FONT_SPCING,
    D2FP_FONT_STY,
    D2FP_FONT_WGHT,
    D2FP_FORE_COLOR,
    D2FP_FORMULA,
    D2FP_FORM_PARAM,
    D2FP_FRAME_ALIGN,
    D2FP_FRAME_TTL,
    D2FP_FRAME_TTL_ALIGN,
    D2FP_FRAME_TTL_BACK_COLOR,
    D2FP_FRAME_TTL_FILL_PAT,
    D2FP_FRAME_TTL_FONT_NAM,
    D2FP_FRAME_TTL_FONT_SIZ,
    D2FP_FRAME_TTL_FONT_SPCING,
    D2FP_FRAME_TTL_FONT_STY,
    D2FP_FRAME_TTL_FONT_WGHT,
    D2FP_FRAME_TTL_FORE_COLOR,
    D2FP_FRAME_TTL_OFST,
    D2FP_FRAME_TTL_SPCING,
    D2FP_FRAME_TTL_STRID,
    D2FP_FRAME_TTL_VAT_NAM,
    D2FP_FRAME_TTL_VAT_OBJ,
    D2FP_FRST_NAVIGATION_BLK_NAM,
    D2FP_FRST_NAVIGATION_BLK_OBJ,
    D2FP_GRADIENT_START,
    D2FP_GRAPHIC,
    D2FP_GRAPHICS_TYP,
    D2FP_GRA_FONT_COLOR,
    D2FP_GRA_FONT_COLOR_CODE,
    D2FP_GRA_FONT_NAM,
    D2FP_GRA_FONT_SIZ,
    D2FP_GRA_FONT_SPCING,
    D2FP_GRA_FONT_STY,
    D2FP_GRA_FONT_WGHT,
    D2FP_GRA_TEXT,
    D2FP_GRA_TEXT_STRID,
    D2FP_GRIDSNAP_FLAG,
    D2FP_GRID_FLAG,
    D2FP_GRID_INTERVAL_CNT,
    D2FP_GRID_SNAP_CNT,
    D2FP_GRID_UNIT_CNT,
    D2FP_HEIGHT,
    D2FP_HELP_BOOK_TITLE,
    D2FP_HELP_BOOK_TOPIC,
    D2FP_HIDE,
    D2FP_HIDE_ON_EXIT,
    D2FP_HIGHEST_ALLOWED_VAL,
    D2FP_HIGHEST_VAL_STRID,
    D2FP_HINT,
    D2FP_HINT_STRID,
    D2FP_HLP_DESCRIPTION,
    D2FP_HLP_DSCRP_STRID,
    D2FP_HORZ_JST,
    D2FP_HORZ_MARGN,
    D2FP_HORZ_OBJ_OFST,
    D2FP_HORZ_ORGN,
    D2FP_HORZ_TLBR_CNV,
    D2FP_HTB_CNV_NAME,
    D2FP_ICONIC,
    D2FP_ICON_FLNAM,
    D2FP_ICON_IN_MNU,
    D2FP_IMG_DPTH,
    D2FP_IMG_FMT,
    D2FP_IMPL_CLASS,
    D2FP_INCLUDE_REFITEM,
    D2FP_INHRT_MNU,
    D2FP_INIT_KBRD_DIR,
    D2FP_INIT_MNU,
    D2FP_INIT_VAL,
    D2FP_INIT_VAL_STRID,
    D2FP_INSRT_ALLOWED,
    D2FP_INSRT_PROC_NAM,
    D2FP_INS_DAT_SRC_ARG,
    D2FP_INS_DAT_SRC_COL,
    D2FP_INTERACTION_MODE,
    D2FP_INTERNAL_END_ANGLE,
    D2FP_INTERNAL_LIN_WID,
    D2FP_INTERNAL_ROTATION_ANGLE,
    D2FP_INTERNAL_STRT_ANGLE,
    D2FP_ISOLATION_MODE,
    D2FP_ITEM,
    D2FP_ITMS_DISP,
    D2FP_ITM_TYP,
    D2FP_JOIN_COND,
    D2FP_JOIN_STY,
    D2FP_JUSTIFICATION,
    D2FP_KBRD_ACC,
    D2FP_KBRD_ACC_STRID,
    D2FP_KBRD_HLP_TXT,
    D2FP_KBRD_HLP_TXT_STRID,
    D2FP_KBRD_NAVIGABLE,
    D2FP_KBRD_STATE,
    D2FP_KEEP_CRSR_POS,
    D2FP_KEY_MODE,
    D2FP_LABEL,
    D2FP_LABEL_STRID,
    D2FP_LANG,
    D2FP_LANG_DIR,
    D2FP_LAYOUT_DATA_BLK_NAM,
    D2FP_LAYOUT_STY,
    D2FP_LIB_LOC,
    D2FP_LIB_PROG_UNIT,
    D2FP_LIB_SRC,
    D2FP_LIN_SPCING,
    D2FP_LIST_ELEM,
    D2FP_LOCK_DAT_SRC_ARG,
    D2FP_LOCK_DAT_SRC_COL,
    D2FP_LOCK_MODE,
    D2FP_LOCK_PROC_NAM,
    D2FP_LOCK_REC,
    D2FP_LOV,
    D2FP_LOV_NAM,
    D2FP_LOV_OBJ,
    D2FP_LOV_X_POS,
    D2FP_LOV_Y_POS,
    D2FP_LOWEST_ALLOWED_VAL,
    D2FP_LOWEST_VAL_STRID,
    D2FP_LST_ELEMENT_COUNT,
    D2FP_LST_IN_BLK_MNU,
    D2FP_LST_STY,
    D2FP_LST_TYP,
    D2FP_MAGIC_ITM,
    D2FP_MAIN_MNU,
    D2FP_MAXIMIZE_ALLOWED,
    D2FP_MAX_LEN,
    D2FP_MAX_OBJS,
    D2FP_MAX_QRY_TIME,
    D2FP_MAX_RECS_FETCHED,
    D2FP_MENU,
    D2FP_MINIMIZE_ALLOWED,
    D2FP_MINIMIZE_TTL,
    D2FP_MINIMIZE_TTL_STRID,
    D2FP_MLT_LIN,
    D2FP_MNU_DRCTRY,
    D2FP_MNU_FLNAM,
    D2FP_MNU_ITM,
    D2FP_MNU_ITM_CODE,
    D2FP_MNU_ITM_RAD_GRP,
    D2FP_MNU_ITM_TYP,
    D2FP_MNU_MOD,
    D2FP_MNU_PARAM,
    D2FP_MNU_PARAM_INIT_VAL,
    D2FP_MNU_PARAM_INIT_VAL_STRID,
    D2FP_MNU_ROLE,
    D2FP_MNU_SRC,
    D2FP_MNU_STY,
    D2FP_MODAL,
    D2FP_MODULE,
    D2FP_MOUSE_NAVIGATE,
    D2FP_MOUSE_NAVIGATION_LMT,
    D2FP_MV_ALLOWED,
    D2FP_NAME,
    D2FP_NAVIGATION_STY,
    D2FP_NEWDEFER_REQ_ENF,
    D2FP_CHAR_MODE_LOGICAL_ATTR,
    D2FP_NEW_CURSOR,
    D2FP_NEXT,
    D2FP_NXT_NAVIGATION_BLK_NAM,
    D2FP_NXT_NAVIGATION_BLK_OBJ,
    D2FP_NXT_NAVIGATION_ITM_NAM,
    D2FP_NXT_NAVIGATION_ITM_OBJ,
    D2FP_OBJ_COUNT,
    D2FP_OBJ_GRP,
    D2FP_OBJ_GRP_CHILD_REAL_OBJ,
    D2FP_OBJ_GRP_TYP,
    D2FP_OBJ_LIB_TAB,
    D2FP_OG_CHILD,
    D2FP_OLD_LOV_TXT,
    D2FP_OLE_ACT_STY,
    D2FP_OLE_CLASS,
    D2FP_OLE_INSD_OUT_SUPPORT,
    D2FP_OLE_IN_PLACE_ACT,
    D2FP_OLE_POPUP_MNU_ITMS,
    D2FP_OLE_RESIZ_STY,
    D2FP_OLE_SHOW_POPUP_MNU,
    D2FP_OLE_SHOW_TNNT_TYP,
    D2FP_OLE_TNNT_ASPCT,
    D2FP_OLE_TNNT_TYP,
    D2FP_OPT_HINT,
    D2FP_ORDR_BY_CLAUSE,
    D2FP_OTHER_VALS,
    D2FP_OWNER,
    D2FP_PAGEBREAK_FLAG,
    D2FP_PAGE_COUNT_SEQ,
    D2FP_PARAM_DAT_TYP,
    D2FP_PARAM_INIT_VAL,
    D2FP_PARAM_INIT_VAL_STRID,
    D2FP_PAR_FLNAM,
    D2FP_PAR_FLPATH,
    D2FP_PAR_MODSTR,
    D2FP_PAR_MODTYP,
    D2FP_PAR_MODULE,
    D2FP_PAR_NAM,
    D2FP_PAR_SL1OBJ_NAM,
    D2FP_PAR_SL1OBJ_TYP,
    D2FP_PAR_SL2OBJ_NAM,
    D2FP_PAR_SL2OBJ_TYP,
    D2FP_PAR_TYP,
    D2FP_PERSIST_CLIENT_INFO,
    D2FP_PERSIST_CLT_INF_LEN,
    D2FP_PGU_TXT,
    D2FP_PGU_TYP,
    D2FP_POINT,
    D2FP_POPUP_MNU_NAM,
    D2FP_POPUP_MNU_OBJ,
    D2FP_POPUP_VA_OBJ,
    D2FP_PRECOMP_SUMM,
    D2FP_PREVIOUS,
    D2FP_PREV_NAVIGATION_BLK_NAM,
    D2FP_PREV_NAVIGATION_BLK_OBJ,
    D2FP_PREV_NAVIGATION_ITM_NAM,
    D2FP_PREV_NAVIGATION_ITM_OBJ,
    D2FP_PRMPT,
    D2FP_PRMPT_ALIGN,
    D2FP_PRMPT_ALIGN_OFST,
    D2FP_PRMPT_ATT_EDGE,
    D2FP_PRMPT_ATT_OFST,
    D2FP_PRMPT_BACK_COLOR,
    D2FP_PRMPT_DISP_STY,
    D2FP_PRMPT_FILL_PAT,
    D2FP_PRMPT_FONT_NAM,
    D2FP_PRMPT_FONT_SIZ,
    D2FP_PRMPT_FONT_SPCING,
    D2FP_PRMPT_FONT_STY,
    D2FP_PRMPT_FONT_WGHT,
    D2FP_PRMPT_FORE_COLOR,
    D2FP_PRMPT_JST,
    D2FP_PRMPT_READING_ORDR,
    D2FP_PRMPT_STRID,
    D2FP_PRMPT_VAT_NAM,
    D2FP_PRMPT_VAT_OBJ,
    D2FP_PRMRY_CNV,
    D2FP_PRMRY_KEY,
    D2FP_PROG_UNIT,
    D2FP_PROP_CLASS,
    D2FP_PRVNT_MSTRLESS_OPS,
    D2FP_QRY_ALLOWED,
    D2FP_QRY_ALL_RECS,
    D2FP_QRY_DAT_SRC_ARG,
    D2FP_QRY_DAT_SRC_COL,
    D2FP_QRY_DAT_SRC_NAM,
    D2FP_QRY_DAT_SRC_TYP,
    D2FP_QRY_LEN,
    D2FP_QRY_ONLY,
    D2FP_QUERY_NAME,
    D2FP_RAD_BUT,
    D2FP_RAISE_ON_ENT,
    D2FP_RDB_VAL,
    D2FP_READING_ORDR,
    D2FP_REAL_UNIT,
    D2FP_RECS_BUFFERED_COUNT,
    D2FP_RECS_DISP_COUNT,
    D2FP_RECS_FETCHED_COUNT,
    D2FP_REC_GRP,
    D2FP_REC_GRP_FETCH_SIZ,
    D2FP_REC_GRP_NAM,
    D2FP_REC_GRP_OBJ,
    D2FP_REC_GRP_QRY,
    D2FP_REC_GRP_TYP,
    D2FP_REC_ORNT,
    D2FP_REC_VAT_GRP_NAM,
    D2FP_REC_VAT_GRP_OBJ,
    D2FP_REL,
    D2FP_REL_TYPE,
    D2FP_RENDERED,
    D2FP_REPORT,
    D2FP_REQUIRED,
    D2FP_RESIZABLE_FLAG,
    D2FP_RESIZE_ALLOWED,
    D2FP_REV_DIR,
    D2FP_REV_RET,
    D2FP_ROLE_COUNT,
    D2FP_ROW_BANDING_FREQ,
    D2FP_RPT_ABS_PATH,
    D2FP_RPT_BIP_PARAMS,
    D2FP_RPT_DEL_TYPE,
    D2FP_RPT_DESTINATION_FMT,
    D2FP_RPT_DESTINATION_NAM,
    D2FP_RPT_DESTINATION_TYP,
    D2FP_RPT_FAX_NUMBER,
    D2FP_RPT_FAX_SERVER,
    D2FP_RPT_FTP_FILENAME,
    D2FP_RPT_FTP_SECURED,
    D2FP_RPT_FTP_SERVER,
    D2FP_RPT_FTP_USER,
    D2FP_RPT_LOCALE,
    D2FP_RPT_LOCAL_FILENAME,
    D2FP_RPT_MAIL_BCC,
    D2FP_RPT_MAIL_BODY,
    D2FP_RPT_MAIL_CC,
    D2FP_RPT_MAIL_FROM,
    D2FP_RPT_MAIL_REPLYTO,
    D2FP_RPT_MAIL_SERVER,
    D2FP_RPT_MAIL_SUBJECT,
    D2FP_RPT_MAIL_TO,
    D2FP_RPT_OBJECT_TYPE,
    D2FP_RPT_OPT_FMT,
    D2FP_RPT_PARAMS,
    D2FP_RPT_PRINT_NAME,
    D2FP_RPT_PRINT_NUMBEROFCOPY,
    D2FP_RPT_PRINT_ORIENTATION,
    D2FP_RPT_PRINT_PAGERANGE,
    D2FP_RPT_PRINT_SIDE,
    D2FP_RPT_PRINT_TRAY,
    D2FP_RPT_SRVC_LOC,
    D2FP_RPT_SRVR,
    D2FP_RPT_SSL_CONN,
    D2FP_RPT_TEMPLATE_NAME,
    D2FP_RPT_WEBDAV_AUTHTYPE,
    D2FP_RPT_WEBDAV_FILE,
    D2FP_RPT_WEBDAV_SERVER,
    D2FP_RPT_WEBDAV_USER,
    D2FP_RTRN_ITM,
    D2FP_RULER_FLAG,
    D2FP_RULER_GUIDE_FLAG,
    D2FP_RULER_MAJOR,
    D2FP_RULER_MINOR,
    D2FP_RULER_UNIT,
    D2FP_RUNTIME_COMP,
    D2FP_SCRLBR_ALIGN,
    D2FP_SCRLBR_CNV_NAM,
    D2FP_SCRLBR_CNV_OBJ,
    D2FP_SCRLBR_LEN,
    D2FP_SCRLBR_ORNT,
    D2FP_SCRLBR_TBP_NAM,
    D2FP_SCRLBR_TBP_OBJ,
    D2FP_SCRLBR_WID,
    D2FP_SCRLBR_X_POS,
    D2FP_SCRLBR_Y_POS,
    D2FP_SHARE_LIB,
    D2FP_SHOW_CANVAS,
    D2FP_SHOW_FAST_FWD,
    D2FP_SHOW_HORZ_SCRLBR,
    D2FP_SHOW_PALETTE,
    D2FP_SHOW_PLAY,
    D2FP_SHOW_REC,
    D2FP_SHOW_REWIND,
    D2FP_SHOW_SCRLBR,
    D2FP_SHOW_SLIDER,
    D2FP_SHOW_TIME,
    D2FP_SHOW_VERT_SCRLBR,
    D2FP_SHOW_VIEW,
    D2FP_SHOW_VOLUME,
    D2FP_SHRINKWRAP,
    D2FP_SIZING_STY,
    D2FP_SND_FMT,
    D2FP_SND_QLTY,
    D2FP_SNGL_OBJ_ALIGN,
    D2FP_SNGL_REC,
    D2FP_SOURCE,
    D2FP_STATUS_LINE_FLAG,
    D2FP_STRTUP_CODE,
    D2FP_STRT_PRMPT_ALIGN,
    D2FP_STRT_PRMPT_OFST,
    D2FP_SUBCL_OBJGRP,
    D2FP_SUBCL_SUBOBJ,
    D2FP_SUB_MNU_NAM,
    D2FP_SUB_MNU_OBJ,
    D2FP_SUB_TTL,
    D2FP_SUB_TTL_STRID,
    D2FP_SUCC_ABORT,
    D2FP_SUCC_LABEL,
    D2FP_SUMM_BLK_NAM,
    D2FP_SUMM_FUNC,
    D2FP_SUMM_ITM_NAM,
    D2FP_SVPNT_MODE,
    D2FP_SYNC_ITM_NAM,
    D2FP_SYNC_ITM_OBJ,
    D2FP_TAB_ACT_STY,
    D2FP_TAB_ATT_EDGE,
    D2FP_TAB_PAGE,
    D2FP_TAB_STY,
    D2FP_TAB_WID_STY,
    D2FP_TBP_NAM,
    D2FP_TBP_OBJ,
    D2FP_TEAR_OFF_MNU,
    D2FP_TEXT,
    D2FP_TEXT_SEG,
    D2FP_TEXT_STRID,
    D2FP_TITLE,
    D2FP_TITLE_STRID,
    D2FP_TOOLPALETTE_FLAG,
    D2FP_TOOLTIP,
    D2FP_TOOLTIP_STRID,
    D2FP_TOOLTIP_VAT_GRP,
    D2FP_TOP_PRMPT_ALIGN,
    D2FP_TOP_PRMPT_OFST,
    D2FP_TRE_ALLW_EMP_BRANCH,
    D2FP_TRE_DATA_QRY,
    D2FP_TRE_MULTI_SELECT,
    D2FP_TRE_REC_GRP,
    D2FP_TRE_SHOW_LINES,
    D2FP_TRE_SHOW_SYMBOL,
    D2FP_TRG_INTERNAL_TYP,
    D2FP_TRG_STY,
    D2FP_TRG_TXT,
    D2FP_TRIGGER,
    D2FP_TRIG_STEP,
    D2FP_QRY_NAME,
    D2FP_TRIG_STEP_TXT,
    D2FP_TTL_READING_ORDR,
    D2FP_UNCHKED_VAL,
    D2FP_UPDT_ALLOWED,
    D2FP_UPDT_CHANGED_COLS,
    D2FP_UPDT_COMMIT,
    D2FP_UPDT_IF_NULL,
    D2FP_UPDT_LAYOUT,
    D2FP_UPDT_PROC_NAM,
    D2FP_UPDT_QRY,
    D2FP_UPD_DAT_SRC_ARG,
    D2FP_UPD_DAT_SRC_COL,
    D2FP_USE_3D_CNTRLS,
    D2FP_USE_SECURITY,
    D2FP_VALIDATE_FROM_LST,
    D2FP_VALIDATION_UNIT,
    D2FP_VAT_NAM,
    D2FP_VAT_OBJ,
    D2FP_VAT_TYP,
    D2FP_VERT_FILL,
    D2FP_VERT_JST,
    D2FP_VERT_MARGN,
    D2FP_VERT_OBJ_OFST,
    D2FP_VERT_ORGN,
    D2FP_VERT_TLBR_CNV,
    D2FP_VISIBLE,
    D2FP_VIS_ATTR,
    D2FP_VIS_STATE,
    D2FP_VIS_STATE_VALID,
    D2FP_VPRT_HGT,
    D2FP_VPRT_WID,
    D2FP_VPRT_X_POS,
    D2FP_VPRT_X_POS_ON_CNV,
    D2FP_VPRT_Y_POS,
    D2FP_VPRT_Y_POS_ON_CNV,
    D2FP_VSBL_IN_HORZ_MNU_TLBR,
    D2FP_VSBL_IN_MENU,
    D2FP_VSBL_IN_VERT_MNU_TLBR,
    D2FP_VTB_CNV_NAME,
    D2FP_WHERE_CLAUSE,
    D2FP_WHITE_ON_BLACK,
    D2FP_WIDTH,
    D2FP_WINDOW,
    D2FP_WIN_HEIGHT,
    D2FP_WIN_STY,
    D2FP_WIN_WIDTH,
    D2FP_WIN_X_POS,
    D2FP_WIN_Y_POS,
    D2FP_WND_NAM,
    D2FP_WND_OBJ,
    D2FP_WRAP_STY,
    D2FP_WRAP_TXT,
    D2FP_X_POS,
    D2FP_Y_POS,
    D2FP_ZOOM_LEVEL,
    D2FP_TYP_UNKNOWN,
    D2FP_TYP_BOOLEAN,
    D2FP_TYP_NUMBER,
    D2FP_TYP_TEXT,
    D2FP_TYP_OBJECT,
    BINTOTEXT,
    TEXTTOBIN,
}
