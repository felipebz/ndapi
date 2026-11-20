using Ndapi.Enums;

namespace Ndapi.Tests;

internal sealed class FormsObjects
{
    // Font and Coordinate are not native objects; a library module can only be loaded from a .pll file
    public static readonly IReadOnlySet<Type> NotCreatable = new HashSet<Type>
    {
        typeof(Font), typeof(Coordinate), typeof(LibraryModule), typeof(LibraryProgramUnit), typeof(AttachedLibrary)
    };

    private readonly List<NdapiModule> _modules = [];

    public Dictionary<Type, NdapiObject> Objects { get; } = [];

    public FormsObjects(string prefix)
    {
        var version = NdapiContext.BuilderVersion.MajorVersion;

        var form = Add(new FormModule($"{prefix}_FMB"));
        _modules.Add(form);
        var window = Add(new Window(form, "WIN"));
        var canvas = Add(new Canvas(form, "CNV") { Window = window });
        var tabCanvas = new Canvas(form, "TAB_CNV") { CanvasType = CanvasType.Tab };
        Add(new TabPage(tabCanvas, "TAB"));

        var block = Add(new Block(form, "BLK"));
        Add(new BlockRelation(block, "REL"));
        var item = Add(new Item(block, "ITM"));
        Add(new Trigger(item, "WHEN-VALIDATE-ITEM"));
        var radioGroup = new Item(block, "RG") { ItemType = ItemType.RadioGroup };
        Add(new RadioButton(radioGroup, "RB"));

        var procedureBlock = new Block(form, "PROC_BLK") { QueryDataSourceType = QueryDataSourceType.Procedure };
        Add(new DataSourceArgument(procedureBlock, DataSourceOperation.Query, "ARG"));
        Add(new DataSourceColumn(procedureBlock, DataSourceOperation.Query, "COL"));

        Add(new Graphics(canvas, "GRA"));
        var text = new Graphics(canvas, "GRA_TXT") { GraphicsObjectType = GraphicsObjectType.Text };
        var compoundText = Add(new CompoundText(text, "CTX"));
        Add(new TextSegment(compoundText, "SEG"));
        var polygon = new Graphics(canvas, "GRA_POLY") { GraphicsObjectType = GraphicsObjectType.Polygon };
        Add(new Point(polygon, "PNT"));

        Add(new Alert(form, "ALT"));
        Add(new Editor(form, "EDT"));
        Add(new FormParameter(form, "PRM"));
        var lov = Add(new Lov(form, "LOV"));
        Add(new ColumnMapping(lov, "MAP"));
        var group = Add(new ObjectGroup(form, "OBG"));
        Add(new ObjectGroupChild(group, "WIN"));
        Add(new ProgramUnit(form, "PU"));
        Add(new PropertyClass(form, "PC"));
        var recordGroup = Add(new RecordGroup(form, "RG"));
        Add(recordGroup.CreateRecordGroupColumn("COL"));
        Add(new Report(form, "RPT"));
        Add(new VisualAttribute(form, "VA"));
        if (version >= 12)
        {
            Add(new Event(form, "EVT"));
        }

        var menuModule = Add(new MenuModule($"{prefix}_MMB"));
        _modules.Add(menuModule);
        var menu = Add(new Menu(menuModule, "MNU"));
        Add(new MenuItem(menu, "MNI"));
        if (version == 6)
        {
            Add(new MenuParameter(menuModule, "MPM"));
        }

        var objectLibrary = Add(new ObjectLibrary($"{prefix}_OLB"));
        _modules.Add(objectLibrary);
        Add(objectLibrary.CreateObjectLibraryTab("TAB"));
    }

    private T Add<T>(T obj) where T : NdapiObject
    {
        Objects.Add(typeof(T), obj);
        return obj;
    }

    public void Destroy()
    {
        foreach (var module in _modules)
        {
            module.Destroy();
        }
    }
}
