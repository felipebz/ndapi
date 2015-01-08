using System;

namespace Ndapi.Metadata
{
    public class NdapiMetaProperty
    {
        public int PropertyId { get; }
        public string Name { get; }
        public bool AllowGet { get; }
        public bool AllowSet { get; }
        public Type PropertyType { get; }
        public string Description => Property.GetName(PropertyId);

        public NdapiMetaProperty(int propertyId, string name, bool allowGet, bool allowSet, Type propertyType)
        {
            PropertyId = propertyId;
            Name = name;
            AllowGet = allowGet;
            AllowSet = allowSet;
            PropertyType = propertyType;
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
