using System;

namespace Ndapi.Core
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    internal sealed class PropertyAttribute : Attribute
    {
        internal int PropertyId { get; }

        public PropertyAttribute(int propertyId)
        {
            PropertyId = propertyId;
        }
    }
}
