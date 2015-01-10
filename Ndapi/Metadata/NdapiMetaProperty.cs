using System;
using System.Collections.Generic;

namespace Ndapi.Metadata
{
    /// <summary>
    /// Represents a Ndapi metaproperty.
    /// </summary>
    public class NdapiMetaProperty
    {
        private static Dictionary<int, NdapiMetaProperty> _cache = new Dictionary<int, NdapiMetaProperty>();

        /// <summary>
        /// Gets the property id;
        /// </summary>
        public int PropertyId { get; }

        /// <summary>
        /// Gets the property name.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Gets whether the property has a getter method.
        /// </summary>
        public bool AllowGet { get; }

        /// <summary>
        /// Gets whether the property has a setter method.
        /// </summary>
        public bool AllowSet { get; }

        /// <summary>
        /// Gets the property type.
        /// </summary>
        public Type PropertyType { get; }

        /// <summary>
        /// Gets the property description.
        /// </summary>
        public string Description => Property.GetName(PropertyId);

        private NdapiMetaProperty(int propertyId, string name, bool allowGet, bool allowSet, Type propertyType)
        {
            PropertyId = propertyId;
            Name = name;
            AllowGet = allowGet;
            AllowSet = allowSet;
            PropertyType = propertyType;
        }

        internal static NdapiMetaProperty GetOrCreate(int propertyId, string name, bool allowGet, bool allowSet, Type propertyType)
        {
            NdapiMetaProperty metaProperty;
            if (_cache.TryGetValue(propertyId, out metaProperty))
            {
                return metaProperty;
            }

            metaProperty = new NdapiMetaProperty(propertyId, name, allowGet, allowSet, propertyType);
            _cache.Add(propertyId, metaProperty);
            return metaProperty;
        }

        public override bool Equals(object obj)
        {
            var other = obj as NdapiMetaProperty;
            return PropertyId == other?.PropertyId;
        }

        public override int GetHashCode()
        {
            return PropertyId.GetHashCode();
        }
    }
}
