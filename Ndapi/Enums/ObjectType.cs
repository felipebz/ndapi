using Ndapi.Core;

namespace Ndapi.Enums;

/// <summary>
/// Object types.
/// </summary>
public enum ObjectType
{
    /// <summary>
    /// Any.
    /// </summary>
    Any = NdapiConstant.D2FFO_ANY,

    /// <summary>
    /// Alert.
    /// </summary>
    Alert = NdapiConstant.D2FFO_ALERT,

    /// <summary>
    /// Attached library.
    /// </summary>
    AttachedLibrary = NdapiConstant.D2FFO_ATT_LIB,

    /// <summary>
    /// Block.
    /// </summary>
    Block = NdapiConstant.D2FFO_BLOCK,

    /// <summary>
    /// Canvas.
    /// </summary>
    Canvas = NdapiConstant.D2FFO_CANVAS,

    /// <summary>
    /// Column value.
    /// </summary>
    ColumnValue = NdapiConstant.D2FFO_COLUMN_VALUE,

    /// <summary>
    /// Compound text.
    /// </summary>
    CompoundText = NdapiConstant.D2FFO_CMPTXT,

    /// <summary>
    /// Coordinate declaration.
    /// </summary>
    Coordinate = NdapiConstant.D2FFO_COORD,

    /// <summary>
    /// Data source argument.
    /// </summary>
    DataSourceArgument = NdapiConstant.D2FFO_DAT_SRC_ARG,

    /// <summary>
    /// Data source column.
    /// </summary>
    DataSourceColumn = NdapiConstant.D2FFO_DAT_SRC_COL,

    /// <summary>
    /// Editor.
    /// </summary>
    Editor = NdapiConstant.D2FFO_EDITOR,

#if FORMS_12_OR_GREATER
    /// <summary>
    /// Event.
    /// </summary>
    Event = NdapiConstant.D2FFO_EVENT,
#endif

    /// <summary>
    /// Font declaration.
    /// </summary>
    Font = NdapiConstant.D2FFO_FONT,

    /// <summary>
    /// Form module.
    /// </summary>
    FormModule = NdapiConstant.D2FFO_FORM_MODULE,

    /// <summary>
    /// Form module parameter.
    /// </summary>
    FormParameter = NdapiConstant.D2FFO_FORM_PARAM,

    /// <summary>
    /// Graphics item.
    /// </summary>
    Graphics = NdapiConstant.D2FFO_GRAPHIC,

    /// <summary>
    /// Item;
    /// </summary>
    Item = NdapiConstant.D2FFO_ITEM,

    /// <summary>
    /// Library program unit.
    /// </summary>
    LibraryProgramUnit = NdapiConstant.D2FFO_LIB_PROG_UNIT,

    /// <summary>
    /// Library module.
    /// </summary>
    LibraryModule = NdapiConstant.D2FFO_LIBRARY_MODULE,

    /// <summary>
    /// List of values.
    /// </summary>
    LOV = NdapiConstant.D2FFO_LOV,

    /// <summary>
    /// List-of-values column mapping.
    /// </summary>
    ColumnMapping = NdapiConstant.D2FFO_LV_COLMAP,

    /// <summary>
    /// Menu.
    /// </summary>
    Menu = NdapiConstant.D2FFO_MENU,

    /// <summary>
    /// Menu item;
    /// </summary>
    MenuItem = NdapiConstant.D2FFO_MENU_ITEM,

    /// <summary>
    /// Menu module.
    /// </summary>
    MenuModule = NdapiConstant.D2FFO_MENU_MODULE,

#if FORMS_6
        /// <summary>
        /// Menu module parameter.
        /// </summary>
        MenuParameter = NdapiConstant.D2FFO_MENU_PARAM,
#endif

    /// <summary>
    /// Object group.
    /// </summary>
    ObjectGroup = NdapiConstant.D2FFO_OBJ_GROUP,

    /// <summary>
    /// Object group child.
    /// </summary>
    ObjectGroupChild = NdapiConstant.D2FFO_OBG_CHILD,

    /// <summary>
    /// Object library.
    /// </summary>
    ObjectLibrary = NdapiConstant.D2FFO_OBJ_LIB,

    /// <summary>
    /// Object library tab;
    /// </summary>
    ObjectLibraryTab = NdapiConstant.D2FFO_OBJ_LIB_TAB,

    /// <summary>
    /// Point declaration.
    /// </summary>
    Point = NdapiConstant.D2FFO_POINT,

    /// <summary>
    /// Program unit.
    /// </summary>
    ProgramUnit = NdapiConstant.D2FFO_PROG_UNIT,

    /// <summary>
    /// Property class.
    /// </summary>
    PropertyClass = NdapiConstant.D2FFO_PROP_CLASS,

    /// <summary>
    /// Radio button.
    /// </summary>
    RadioButton = NdapiConstant.D2FFO_RADIO_BUTTON,

    /// <summary>
    /// Record group.
    /// </summary>
    RecordGroup = NdapiConstant.D2FFO_REC_GROUP,

    /// <summary>
    /// Block relation.
    /// </summary>
    BlockRelation = NdapiConstant.D2FFO_RELATION,

    /// <summary>
    /// Report.
    /// </summary>
    Report = NdapiConstant.D2FFO_REPORT,

    /// <summary>
    /// List-of-values column specification.
    /// </summary>
    ColumnSpecification = NdapiConstant.D2FFO_RG_COLSPEC,

    /// <summary>
    /// Tab page.
    /// </summary>
    TabPage = NdapiConstant.D2FFO_TAB_PAGE,

    /// <summary>
    /// Text segment.
    /// </summary>
    TextSegment = NdapiConstant.D2FFO_TEXT_SEG,

    /// <summary>
    /// Trigger.
    /// </summary>
    Trigger = NdapiConstant.D2FFO_TRIGGER,

    /// <summary>
    /// Trigger step.
    /// </summary>
    TriggerStep = NdapiConstant.D2FFO_TRIG_STEP,

    /// <summary>
    /// Visual attribute.
    /// </summary>
    VisualAttribute = NdapiConstant.D2FFO_VIS_ATTR,

    /// <summary>
    /// Window.
    /// </summary>
    Window = NdapiConstant.D2FFO_WINDOW,

    /// <summary>
    /// Undefined.
    /// </summary>
    Undefined = NdapiConstant.D2FFO_UNDEFINED
}
