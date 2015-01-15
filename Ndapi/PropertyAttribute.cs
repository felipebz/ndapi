using System;

namespace Ndapi
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