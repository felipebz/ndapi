using System;

namespace Ndapi.Core;

[AttributeUsage(AttributeTargets.Property)]
internal sealed class PropertyAttribute(NdapiConstant propertyId) : Attribute
{
    internal NdapiConstant PropertyId { get; } = propertyId;
}
