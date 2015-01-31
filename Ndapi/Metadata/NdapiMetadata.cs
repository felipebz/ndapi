using Ndapi.Enums;
using System;
using System.Collections.Generic;

namespace Ndapi.Metadata
{
    /// <summary>
    /// Provides access for the Ndapi metadada.
    /// </summary>
    public static class NdapiMetadata
    {
        private static readonly Lazy<Dictionary<ObjectType, Type>> _objectTypeMapping = new Lazy<Dictionary<ObjectType, Type>>(LoadObjectTypeMapping);

        /// <summary>
        /// Gets the Ndapi classes that represents a Forms API object.
        /// </summary>
        public static IEnumerable<Type> Classes => ObjectTypeMapping.Values;

        /// <summary>
        /// Gets a dictionary containing the relation bettwen an <see cref="ObjectType"/> and a Ndapi class.
        /// </summary>
        public static Dictionary<ObjectType, Type> ObjectTypeMapping => _objectTypeMapping.Value;

        private static Dictionary<ObjectType, Type> LoadObjectTypeMapping()
        {

            return new Dictionary<ObjectType, Type>
            {
                { ObjectType.Alert,               typeof(Alert) },
                { ObjectType.AttachedLibrary,     typeof(AttachedLibrary) },
                { ObjectType.Block,               typeof(Block) },
                { ObjectType.Canvas,              typeof(Canvas) },
                //{ ObjectType.ColumnValue,       typeof(NdapiObject) },
                //{ ObjectType.CompoundText,      typeof(NdapiObject) },
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
                { ObjectType.MenuParameter,       typeof(MenuParameter) },
                { ObjectType.ObjectGroup,         typeof(ObjectGroup) },
                { ObjectType.ObjectGroupChild,    typeof(ObjectGroupChild) },
                { ObjectType.ObjectLibrary,       typeof(ObjectLibrary) },
                { ObjectType.ObjectLibraryTab,    typeof(ObjectLibraryTab) },
                //{ ObjectType.Point,             typeof(NdapiObject) },
                { ObjectType.ProgramUnit,         typeof(ProgramUnit) },
                { ObjectType.PropertyClass,       typeof(PropertyClass) },
                { ObjectType.RadioButton,         typeof(RadioButton) },
                { ObjectType.RecordGroup,         typeof(RecordGroup) },
                { ObjectType.BlockRelation,       typeof(BlockRelation) },
                { ObjectType.Report,              typeof(Report) },
                { ObjectType.ColumnSpecification, typeof(RecordGroupColumn) },
                { ObjectType.TabPage,             typeof(TabPage) },
                //{ ObjectType.TextSegment,       typeof(NdapiObject) },
                { ObjectType.Trigger,             typeof(Trigger) },
                //{ ObjectType.TriggerStep,       typeof(NdapiObject) },
                { ObjectType.VisualAttribute,     typeof(VisualAttribute) },
                { ObjectType.Window,              typeof(Window) }
            };
        }

        /// <summary>
        /// Gets a <see cref="NdapiMetaObject"/> for the specified class.
        /// </summary>
        /// <param name="type">A Ndapi class.</param>
        /// <returns>The meta object instance.</returns>
        public static NdapiMetaObject GetMetaObjectFrom(Type type) => NdapiMetaObject.GetOrCreate(type);
    }
}
