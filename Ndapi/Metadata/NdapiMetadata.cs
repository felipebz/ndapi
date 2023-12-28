using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

using Ndapi.Enums;

namespace Ndapi.Metadata;

/// <summary>
/// Provides access for the Ndapi metadada.
/// </summary>
public static class NdapiMetadata
{

    private static readonly IList<ObjectTypeMap> _objectTypeMapping = LoadObjectTypeMapping();

    /// <summary>
    /// Gets the Ndapi classes that represents a Forms API object.
    /// </summary>
    public static IEnumerable<Type> Classes => _objectTypeMapping.Select(x => x.Type);

    /// <summary>
    /// Gets a dictionary containing the relation bettwen an <see cref="ObjectType"/> and a Ndapi class.
    /// </summary>
    //public static Dictionary<ObjectType, Type> ObjectTypeMapping => _objectTypeMapping.Value;

    private static IList<ObjectTypeMap> LoadObjectTypeMapping() =>
        [
            new ObjectTypeMap(ObjectType.Alert, typeof(Alert)),
            new ObjectTypeMap(ObjectType.AttachedLibrary, typeof(AttachedLibrary)),
            new ObjectTypeMap(ObjectType.Block, typeof(Block)),
            new ObjectTypeMap(ObjectType.Canvas, typeof(Canvas)),
            new ObjectTypeMap(ObjectType.CompoundText, typeof(CompoundText)),
            new ObjectTypeMap(ObjectType.Coordinate, typeof(Coordinate)),
            new ObjectTypeMap(ObjectType.DataSourceArgument, typeof(DataSourceArgument)),
            new ObjectTypeMap(ObjectType.DataSourceColumn, typeof(DataSourceColumn)),
            new ObjectTypeMap(ObjectType.Editor, typeof(Editor)),
            new ObjectTypeMap(ObjectType.Font, typeof(Font)),
            new ObjectTypeMap(ObjectType.FormModule, typeof(FormModule)),
            new ObjectTypeMap(ObjectType.FormParameter, typeof(FormParameter)),
            new ObjectTypeMap(ObjectType.Graphics, typeof(Graphics)),
            new ObjectTypeMap(ObjectType.Item, typeof(Item)),
            new ObjectTypeMap(ObjectType.LibraryProgramUnit, typeof(LibraryProgramUnit)),
            new ObjectTypeMap(ObjectType.LibraryModule, typeof(LibraryModule)),
            new ObjectTypeMap(ObjectType.LOV, typeof(LOV)),
            new ObjectTypeMap(ObjectType.ColumnMapping, typeof(ColumnMapping)),
            new ObjectTypeMap(ObjectType.Menu, typeof(Menu)),
            new ObjectTypeMap(ObjectType.MenuItem, typeof(MenuItem)),
            new ObjectTypeMap(ObjectType.MenuModule, typeof(MenuModule)),
#if FORMS_6
            new ObjectTypeMap(ObjectType.MenuParameter,       typeof(MenuParameter)),
#endif
            new ObjectTypeMap(ObjectType.ObjectGroup, typeof(ObjectGroup)),
            new ObjectTypeMap(ObjectType.ObjectGroupChild, typeof(ObjectGroupChild)),
            new ObjectTypeMap(ObjectType.ObjectLibrary, typeof(ObjectLibrary)),
            new ObjectTypeMap(ObjectType.ObjectLibraryTab, typeof(ObjectLibraryTab)),
            new ObjectTypeMap(ObjectType.Point, typeof(Point)),
            new ObjectTypeMap(ObjectType.ProgramUnit, typeof(ProgramUnit)),
            new ObjectTypeMap(ObjectType.PropertyClass, typeof(PropertyClass)),
            new ObjectTypeMap(ObjectType.RadioButton, typeof(RadioButton)),
            new ObjectTypeMap(ObjectType.RecordGroup, typeof(RecordGroup)),
            new ObjectTypeMap(ObjectType.BlockRelation, typeof(BlockRelation)),
            new ObjectTypeMap(ObjectType.Report, typeof(Report)),
            new ObjectTypeMap(ObjectType.ColumnSpecification, typeof(RecordGroupColumn)),
            new ObjectTypeMap(ObjectType.TabPage, typeof(TabPage)),
            new ObjectTypeMap(ObjectType.TextSegment, typeof(TextSegment)),
            new ObjectTypeMap(ObjectType.Trigger, typeof(Trigger)),
            new ObjectTypeMap(ObjectType.VisualAttribute, typeof(VisualAttribute)),
            new ObjectTypeMap(ObjectType.Window, typeof(Window))
        ];

    /// <summary>
    /// Gets a <see cref="NdapiMetaObject"/> for the specified class.
    /// </summary>
    /// <param name="type">A Ndapi class.</param>
    /// <returns>The meta object instance.</returns>
    public static NdapiMetaObject GetMetaObjectFrom([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicProperties)] Type type) => NdapiMetaObject.GetOrCreate(type);

    internal static ObjectType GetObjectTypeFrom<T>() => _objectTypeMapping.Single(t => t.Type == typeof(T)).ObjectType;

    internal static ObjectType GetObjectTypeFrom(Type type) => _objectTypeMapping.Single(t => t.Type == type).ObjectType;

    [return: DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.NonPublicConstructors | DynamicallyAccessedMemberTypes.PublicProperties)]
    internal static Type GetTypeFrom(ObjectType type) => _objectTypeMapping.Single(t => t.ObjectType == type).Type;

    private class ObjectTypeMap(
        ObjectType objectType,
        [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.NonPublicConstructors | DynamicallyAccessedMemberTypes.PublicProperties)]
        Type type)
    {
        public ObjectType ObjectType { get; } = objectType;

        [field: DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.NonPublicConstructors | DynamicallyAccessedMemberTypes.PublicProperties)]
        public Type Type
        {
            [return: DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.NonPublicConstructors | DynamicallyAccessedMemberTypes.PublicProperties)]
            get;
        } = type;
    }
}
