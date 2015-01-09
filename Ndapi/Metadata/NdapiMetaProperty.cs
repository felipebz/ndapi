using System;
using System.Collections.Generic;

namespace Ndapi.Metadata
{
    public class NdapiMetaProperty
    {
        private static Dictionary<int, NdapiMetaProperty> _cache = new Dictionary<int, NdapiMetaProperty>();

        public int PropertyId { get; }
        public string Name { get; }
        public bool AllowGet { get; }
        public bool AllowSet { get; }
        public Type PropertyType { get; }
        public string Description => Property.GetName(PropertyId);

        private NdapiMetaProperty(int propertyId, string name, bool allowGet, bool allowSet, Type propertyType)
        {
            PropertyId = propertyId;
            Name = name;
            AllowGet = allowGet;
            AllowSet = allowSet;
            PropertyType = propertyType;
        }

        public static NdapiMetaProperty GetOrCreate(int propertyId, string name, bool allowGet, bool allowSet, Type propertyType)
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
