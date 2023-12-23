using System;
using System.Collections.Generic;
using System.Linq;

using Ndapi.Enums;

namespace Ndapi.Metadata;

/// <summary>
/// Provides access for the Ndapi metadada.
/// </summary>
public static class NdapiMetadata
{
    private static readonly Lazy<Dictionary<ObjectType, Type>> _objectTypeMapping = new(LoadObjectTypeMapping);

    /// <summary>
    /// Gets the Ndapi classes that represents a Forms API object.
    /// </summary>
    public static IEnumerable<Type> Classes => ObjectTypeMapping.Values;

    /// <summary>
    /// Gets a dictionary containing the relation bettwen an <see cref="ObjectType"/> and a Ndapi class.
    /// </summary>
    public static Dictionary<ObjectType, Type> ObjectTypeMapping => _objectTypeMapping.Value;

    private static Dictionary<ObjectType, Type> LoadObjectTypeMapping() =>
        new()
        {
            { ObjectType.Alert,               typeof(Alert) },
            { ObjectType.AttachedLibrary,     typeof(AttachedLibrary) },
            { ObjectType.Block,               typeof(Block) },
            { ObjectType.Canvas,              typeof(Canvas) },
            { ObjectType.CompoundText,        typeof(CompoundText) },
            { ObjectType.Coordinate,          typeof(Coordinate) },
            { ObjectType.DataSourceArgument,  typeof(DataSourceArgument) },
            { ObjectType.DataSourceColumn,    typeof(DataSourceColumn) },
            { ObjectType.Editor,              typeof(Editor) },
            { ObjectType.Font,                typeof(Font) },
            { ObjectType.FormModule,          typeof(FormModule) },
            { ObjectType.FormParameter,       typeof(FormParameter) },
            { ObjectType.Graphics,            typeof(Graphics) },
            { ObjectType.Item,                typeof(Item) },
            { ObjectType.LibraryProgramUnit,  typeof(LibraryProgramUnit) },
            { ObjectType.LibraryModule,       typeof(LibraryModule) },
            { ObjectType.LOV,                 typeof(LOV) },
            { ObjectType.ColumnMapping,       typeof(ColumnMapping) },
            { ObjectType.Menu,                typeof(Menu) },
            { ObjectType.MenuItem,            typeof(MenuItem) },
            { ObjectType.MenuModule,          typeof(MenuModule) },
#if FORMS_6
                { ObjectType.MenuParameter,       typeof(MenuParameter) },
#endif
            { ObjectType.ObjectGroup,         typeof(ObjectGroup) },
            { ObjectType.ObjectGroupChild,    typeof(ObjectGroupChild) },
            { ObjectType.ObjectLibrary,       typeof(ObjectLibrary) },
            { ObjectType.ObjectLibraryTab,    typeof(ObjectLibraryTab) },
            { ObjectType.Point,               typeof(Point) },
            { ObjectType.ProgramUnit,         typeof(ProgramUnit) },
            { ObjectType.PropertyClass,       typeof(PropertyClass) },
            { ObjectType.RadioButton,         typeof(RadioButton) },
            { ObjectType.RecordGroup,         typeof(RecordGroup) },
            { ObjectType.BlockRelation,       typeof(BlockRelation) },
            { ObjectType.Report,              typeof(Report) },
            { ObjectType.ColumnSpecification, typeof(RecordGroupColumn) },
            { ObjectType.TabPage,             typeof(TabPage) },
            { ObjectType.TextSegment,         typeof(TextSegment) },
            { ObjectType.Trigger,             typeof(Trigger) },
            { ObjectType.VisualAttribute,     typeof(VisualAttribute) },
            { ObjectType.Window,              typeof(Window) }
        };

    /// <summary>
    /// Gets a <see cref="NdapiMetaObject"/> for the specified class.
    /// </summary>
    /// <param name="type">A Ndapi class.</param>
    /// <returns>The meta object instance.</returns>
    public static NdapiMetaObject GetMetaObjectFrom(Type type) => NdapiMetaObject.GetOrCreate(type);

    internal static ObjectType GetObjectTypeFrom<T>() => ObjectTypeMapping.Single(t => t.Value == typeof(T)).Key;
}
