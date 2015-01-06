using System;

namespace Ndapi.Metadata
{
    public class NdapiMetaProperty
    {
        public int PropertyId { get; }
        public bool AllowGet { get; }
        public bool AllowSet { get; }
        public Type PropertyType { get; }

        public NdapiMetaProperty(int propertyId, bool allowGet, bool allowSet, Type propertyType)
        {
            PropertyId = propertyId;
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
