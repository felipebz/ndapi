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
    private static readonly IList<ObjectTypeMap> ObjectTypeMapping = LoadObjectTypeMapping();

    /// <summary>
    /// Gets the Ndapi classes that represents a Forms API object.
    /// </summary>
    public static IEnumerable<Type> Classes => ObjectTypeMapping.Select(x => x.Type);

    private static IList<ObjectTypeMap> LoadObjectTypeMapping() =>
    [
        new(ObjectType.Alert, typeof(Alert)),
        new(ObjectType.AttachedLibrary, typeof(AttachedLibrary)),
        new(ObjectType.Block, typeof(Block)),
        new(ObjectType.Canvas, typeof(Canvas)),
        new(ObjectType.CompoundText, typeof(CompoundText)),
        new(ObjectType.Coordinate, typeof(Coordinate)),
        new(ObjectType.DataSourceArgument, typeof(DataSourceArgument)),
        new(ObjectType.DataSourceColumn, typeof(DataSourceColumn)),
        new(ObjectType.Editor, typeof(Editor)),
        new(ObjectType.Event, typeof(Event)),
        new(ObjectType.Font, typeof(Font)),
        new(ObjectType.FormModule, typeof(FormModule)),
        new(ObjectType.FormParameter, typeof(FormParameter)),
        new(ObjectType.Graphics, typeof(Graphics)),
        new(ObjectType.Item, typeof(Item)),
        new(ObjectType.LibraryProgramUnit, typeof(LibraryProgramUnit)),
        new(ObjectType.LibraryModule, typeof(LibraryModule)),
        new(ObjectType.Lov, typeof(Lov)),
        new(ObjectType.ColumnMapping, typeof(ColumnMapping)),
        new(ObjectType.Menu, typeof(Menu)),
        new(ObjectType.MenuItem, typeof(MenuItem)),
        new(ObjectType.MenuModule, typeof(MenuModule)),
        new(ObjectType.MenuParameter, typeof(MenuParameter)),
        new(ObjectType.ObjectGroup, typeof(ObjectGroup)),
        new(ObjectType.ObjectGroupChild, typeof(ObjectGroupChild)),
        new(ObjectType.ObjectLibrary, typeof(ObjectLibrary)),
        new(ObjectType.ObjectLibraryTab, typeof(ObjectLibraryTab)),
        new(ObjectType.Point, typeof(Point)),
        new(ObjectType.ProgramUnit, typeof(ProgramUnit)),
        new(ObjectType.PropertyClass, typeof(PropertyClass)),
        new(ObjectType.RadioButton, typeof(RadioButton)),
        new(ObjectType.RecordGroup, typeof(RecordGroup)),
        new(ObjectType.BlockRelation, typeof(BlockRelation)),
        new(ObjectType.Report, typeof(Report)),
        new(ObjectType.ColumnSpecification, typeof(RecordGroupColumn)),
        new(ObjectType.TabPage, typeof(TabPage)),
        new(ObjectType.TextSegment, typeof(TextSegment)),
        new(ObjectType.Trigger, typeof(Trigger)),
        new(ObjectType.VisualAttribute, typeof(VisualAttribute)),
        new(ObjectType.Window, typeof(Window))
    ];

    /// <summary>
    /// Gets a <see cref="NdapiMetaObject"/> for the specified class.
    /// </summary>
    /// <param name="type">A Ndapi class.</param>
    /// <returns>The meta object instance.</returns>
    public static NdapiMetaObject GetMetaObjectFrom(Type type) =>
        ObjectTypeMapping.Single(t => t.Type == type).MetaObject;

    internal static ObjectType GetObjectTypeFrom<T>() => ObjectTypeMapping.Single(t => t.Type == typeof(T)).ObjectType;

    internal static ObjectType GetObjectTypeFrom(Type type) =>
        ObjectTypeMapping.Single(t => t.Type == type).ObjectType;

    [return:
        DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.NonPublicConstructors |
                                   DynamicallyAccessedMemberTypes.PublicProperties)]
    internal static Type GetTypeFrom(ObjectType type) => ObjectTypeMapping.Single(t => t.ObjectType == type).Type;

    private sealed class ObjectTypeMap
    {
        private readonly Lazy<NdapiMetaObject> _metaObject;

        public ObjectTypeMap(ObjectType objectType,
            [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.NonPublicConstructors |
                                        DynamicallyAccessedMemberTypes.PublicProperties)]
            Type type)
        {
            Type = type;
            ObjectType = objectType;
            _metaObject = new Lazy<NdapiMetaObject>(LoadMetaObject);
        }

        public ObjectType ObjectType { get; }

        [field:
            DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.NonPublicConstructors |
                                       DynamicallyAccessedMemberTypes.PublicProperties)]
        public Type Type
        {
            [return:
                DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.NonPublicConstructors |
                                           DynamicallyAccessedMemberTypes.PublicProperties)]
            get;
        }

        public NdapiMetaObject MetaObject => _metaObject.Value;

        private NdapiMetaObject LoadMetaObject()
        {
            return new NdapiMetaObject(Type);
        }
    }
}
