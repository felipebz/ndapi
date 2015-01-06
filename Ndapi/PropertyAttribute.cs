using System;

namespace Ndapi
{
    internal sealed class PropertyAttribute : Attribute
    {
        internal int PropertyId { get; }

        public PropertyAttribute(int propertyId)
        {
            PropertyId = propertyId;
        }
    }
}