using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.InteropServices;

using Ndapi.Core;
using Ndapi.Core.Handles;
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

    /// <summary>
    /// Gets the ids of every object property defined by the running Forms Builder version, ordered by their native
    /// value. Unlike <see cref="NdapiMetaObject.AllProperties"/>, the list includes the properties that aren't
    /// exposed as typed members of the Ndapi classes, so they can be read and written with the generic accessors
    /// (<see cref="NdapiObject.HasProperty"/>, <see cref="NdapiObject.GetStringProperty"/> and so on).
    /// </summary>
    public static IReadOnlyList<NdapiConstant> SupportedProperties => ConstantConverter.GetSupportedProperties();

    private static IList<ObjectTypeMap> LoadObjectTypeMapping() =>
    [
        new(ObjectType.Alert, typeof(Alert), h => new Alert(h)),
        new(ObjectType.AttachedLibrary, typeof(AttachedLibrary), h => new AttachedLibrary(h)),
        new(ObjectType.Block, typeof(Block), h => new Block(h)),
        new(ObjectType.Canvas, typeof(Canvas), h => new Canvas(h)),
        new(ObjectType.CompoundText, typeof(CompoundText), h => new CompoundText(h)),
        new(ObjectType.Coordinate, typeof(Coordinate), h => new Coordinate(h)),
        new(ObjectType.DataSourceArgument, typeof(DataSourceArgument), h => new DataSourceArgument(h)),
        new(ObjectType.DataSourceColumn, typeof(DataSourceColumn), h => new DataSourceColumn(h)),
        new(ObjectType.Editor, typeof(Editor), h => new Editor(h)),
        new(ObjectType.Event, typeof(Event), h => new Event(h)),
        new(ObjectType.Font, typeof(Font), h => new Font(h)),
        new(ObjectType.FormModule, typeof(FormModule), h => new FormModule(h)),
        new(ObjectType.FormParameter, typeof(FormParameter), h => new FormParameter(h)),
        new(ObjectType.Graphics, typeof(Graphics), h => new Graphics(h)),
        new(ObjectType.Item, typeof(Item), h => new Item(h)),
        new(ObjectType.LibraryProgramUnit, typeof(LibraryProgramUnit), h => new LibraryProgramUnit(h)),
        new(ObjectType.LibraryModule, typeof(LibraryModule), h => new LibraryModule(h)),
        new(ObjectType.Lov, typeof(Lov), h => new Lov(h)),
        new(ObjectType.ColumnMapping, typeof(ColumnMapping), h => new ColumnMapping(h)),
        new(ObjectType.Menu, typeof(Menu), h => new Menu(h)),
        new(ObjectType.MenuItem, typeof(MenuItem), h => new MenuItem(h)),
        new(ObjectType.MenuModule, typeof(MenuModule), h => new MenuModule(h)),
        new(ObjectType.MenuParameter, typeof(MenuParameter), h => new MenuParameter(h)),
        new(ObjectType.ObjectGroup, typeof(ObjectGroup), h => new ObjectGroup(h)),
        new(ObjectType.ObjectGroupChild, typeof(ObjectGroupChild), h => new ObjectGroupChild(h)),
        new(ObjectType.ObjectLibrary, typeof(ObjectLibrary), h => new ObjectLibrary(h)),
        new(ObjectType.ObjectLibraryTab, typeof(ObjectLibraryTab), h => new ObjectLibraryTab(h)),
        new(ObjectType.Point, typeof(Point), h => new Point(h)),
        new(ObjectType.ProgramUnit, typeof(ProgramUnit), h => new ProgramUnit(h)),
        new(ObjectType.PropertyClass, typeof(PropertyClass), h => new PropertyClass(h)),
        new(ObjectType.RadioButton, typeof(RadioButton), h => new RadioButton(h)),
        new(ObjectType.RecordGroup, typeof(RecordGroup), h => new RecordGroup(h)),
        new(ObjectType.BlockRelation, typeof(BlockRelation), h => new BlockRelation(h)),
        new(ObjectType.Report, typeof(Report), h => new Report(h)),
        new(ObjectType.ColumnSpecification, typeof(RecordGroupColumn), h => new RecordGroupColumn(h)),
        new(ObjectType.TabPage, typeof(TabPage), h => new TabPage(h)),
        new(ObjectType.TextSegment, typeof(TextSegment), h => new TextSegment(h)),
        new(ObjectType.Trigger, typeof(Trigger), h => new Trigger(h)),
        new(ObjectType.VisualAttribute, typeof(VisualAttribute), h => new VisualAttribute(h)),
        new(ObjectType.Window, typeof(Window), h => new Window(h))
    ];

    /// <summary>
    /// Gets a <see cref="NdapiMetaObject"/> for the specified class.
    /// </summary>
    /// <param name="type">A Ndapi class.</param>
    /// <returns>The meta object instance.</returns>
    public static NdapiMetaObject GetMetaObjectFrom(Type type) =>
        ObjectTypeMapping.Single(t => t.Type == type).MetaObject;

    /// <summary>
    /// Gets the descriptive name of an object type, e.g. "Canvas".
    /// </summary>
    /// <param name="type">Object type.</param>
    /// <returns>The object type name.</returns>
    public static string GetObjectTypeName(ObjectType type)
    {
        var status = NativeMethods.d2fobgcn_GetConstName(NdapiContext.GetContext(),
            (ushort)ConstantConverter.GetValue(type), out var name);
        Ensure.Success(status);
        return Marshal.PtrToStringAnsi(name) ?? string.Empty; // static string owned by Forms
    }

    /// <summary>
    /// Gets the object type of an object type name, e.g. "CANVAS".
    /// </summary>
    /// <param name="name">Object type name.</param>
    /// <returns>The object type.</returns>
    public static ObjectType GetObjectType(string name)
    {
        var status = NativeMethods.d2fobgcv_GetConstValue(NdapiContext.GetContext(), name, out var value);
        Ensure.Success(status);
        return NdapiObject.Convert<ObjectType>(value);
    }

    internal static ObjectType GetObjectTypeFrom<T>() => ObjectTypeMapping.Single(t => t.Type == typeof(T)).ObjectType;

    internal static ObjectType GetObjectTypeFrom(Type type) =>
        ObjectTypeMapping.Single(t => t.Type == type).ObjectType;

    [return:
        DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.NonPublicConstructors |
                                   DynamicallyAccessedMemberTypes.PublicProperties)]
    internal static Type GetTypeFrom(ObjectType type) =>
        ObjectTypeMapping.SingleOrDefault(t => t.ObjectType == type)?.Type ??
        throw new NdapiException($"Ndapi has no class for the object type {type}.");

    internal static NdapiObject CreateWrapper(Type type, ObjectSafeHandle handle) =>
        (ObjectTypeMapping.SingleOrDefault(t => t.Type == type) ??
         throw new NdapiException($"{type.Name} has no object type mapping.")).Factory(handle);

    internal static NdapiObject CreateWrapper(ObjectType type, ObjectSafeHandle handle) =>
        (ObjectTypeMapping.SingleOrDefault(t => t.ObjectType == type) ??
         throw new NdapiException($"Ndapi has no class for the object type {type}.")).Factory(handle);

    private sealed class ObjectTypeMap
    {
        private readonly Lazy<NdapiMetaObject> _metaObject;

        public ObjectTypeMap(ObjectType objectType,
            [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.NonPublicConstructors |
                                        DynamicallyAccessedMemberTypes.PublicProperties)]
            Type type,
            Func<ObjectSafeHandle, NdapiObject> factory)
        {
            Type = type;
            ObjectType = objectType;
            Factory = factory;
            _metaObject = new Lazy<NdapiMetaObject>(LoadMetaObject);
        }

        public Func<ObjectSafeHandle, NdapiObject> Factory { get; }

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
