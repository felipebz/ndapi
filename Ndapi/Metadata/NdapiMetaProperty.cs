using System;
using System.Collections.Generic;
using System.Linq;

using Ndapi.Core;
using Ndapi.Enums;

namespace Ndapi.Metadata;

/// <summary>
/// Represents a Ndapi metaproperty.
/// </summary>
public sealed class NdapiMetaProperty : IEquatable<NdapiMetaProperty>
{
    private static readonly Dictionary<NdapiConstant, NdapiMetaProperty> Cache = new();
    private readonly Lazy<Dictionary<int, string>> _allowedValues;
    private readonly Lazy<PropertyType> _propertyType;
    private readonly Lazy<string> _description;

    /// <summary>
    /// Gets the property id;
    /// </summary>
    public NdapiConstant PropertyId { get; }

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
    /// Gets whether the property represents a list of items.
    /// </summary>
    public bool IsList { get; }

    /// <summary>
    /// Gets the raw property type.
    /// </summary>
    public Type RawPropertyType { get; }

    /// <summary>
    /// Gets the property type.
    /// </summary>
    public PropertyType PropertyType => _propertyType.Value;

    /// <summary>
    /// Gets the property description.
    /// </summary>
    public string Description => _description.Value;

    /// <summary>
    /// Gets the allowed values for the property
    /// </summary>
    public Dictionary<int, string> AllowedValues => _allowedValues.Value;

    /// <summary>
    /// Gets whether the property accepts constant values.
    /// </summary>
    public bool AcceptConstants { get; }

    private NdapiMetaProperty(NdapiConstant propertyId, string name, bool allowGet, bool allowSet, Type propertyType)
    {
        PropertyId = propertyId;
        Name = name;
        AllowGet = allowGet;
        AllowSet = allowSet;
        RawPropertyType = propertyType;
        AcceptConstants = propertyType.IsEnum;
        IsList = RawPropertyType.IsGenericType;

        _allowedValues = new Lazy<Dictionary<int, string>>(LoadAllowedValues);
        _propertyType = new Lazy<PropertyType>(() => GetPropertyType(propertyId));
        _description = new Lazy<string>(() => GetName(PropertyId));
    }

    internal static NdapiMetaProperty GetOrCreate(NdapiConstant propertyId, string name, bool allowGet, bool allowSet,
        Type propertyType)
    {
        if (Cache.TryGetValue(propertyId, out var metaProperty))
        {
            return metaProperty;
        }

        metaProperty = new NdapiMetaProperty(propertyId, name, allowGet, allowSet, propertyType);
        Cache.Add(propertyId, metaProperty);
        return metaProperty;
    }

    private Dictionary<int, string> LoadAllowedValues()
    {
        return AcceptConstants
            ? Enum.GetValuesAsUnderlyingType(RawPropertyType)
                .Cast<int>()
                .Where(ConstantConverter.IsPropertySupportedByBuilderVersion)
                .Select(ConstantConverter.GetValue)
                .ToDictionary(e => e, e => Enum.GetName(RawPropertyType, e))
            : new Dictionary<int, string>();
    }

    /// <summary>
    /// Gets the value name.
    /// </summary>
    /// <param name="value">Value id (see <see cref="NdapiConstant"/>).</param>
    /// <returns>The value name.</returns>
    public string GetValueName(int value) => GetValueName(PropertyId, value);

    /// <summary>
    /// Gets the property type.
    /// </summary>
    /// <param name="property">Property id (see <see cref="NdapiConstant"/>).</param>
    /// <returns>The property type.</returns>
    public static PropertyType GetPropertyType(NdapiConstant property)
    {
        var type = NativeMethods.d2fprgt_GetType(NdapiContext.GetContext(), ConstantConverter.GetValue(property));
        return NdapiObject.Convert<PropertyType>(type);
    }

    /// <summary>
    /// Gets the property name.
    /// </summary>
    /// <param name="property">Property id (see <see cref="NdapiConstant"/>).</param>
    /// <returns>The property name.</returns>
    public static string GetName(NdapiConstant property)
    {
        var status = NativeMethods.d2fprgn_GetName(NdapiContext.GetContext(), ConstantConverter.GetValue(property),
            out var name);
        Ensure.Success(status);
        return name;
    }

    /// <summary>
    /// Gets the value name.
    /// </summary>
    /// <param name="property">Property id (see <see cref="NdapiConstant"/>).</param>
    /// <param name="value">Value id (see <see cref="NdapiConstant"/>).</param>
    /// <returns>The value name.</returns>
    public static string GetValueName(NdapiConstant property, int value)
    {
        var status = NativeMethods.d2fprgvn_GetValueName(NdapiContext.GetContext(),
            ConstantConverter.GetValue(property), value, out var name);
        Ensure.Success(status);
        return name;
    }

    /// <summary>
    /// Gets the constant value.
    /// </summary>
    /// <param name="constant">Constant name.</param>
    /// <returns>The constant value.</returns>
    public static int GetConstantValue(string constant)
    {
        var status = NativeMethods.d2fprgcv_GetConstValue(NdapiContext.GetContext(), constant, out var value);
        Ensure.Success(status);
        return value;
    }

    /// <summary>
    /// Gets the constant name.
    /// </summary>
    /// <param name="constant">Constant id (see <see cref="NdapiConstant"/>).</param>
    /// <returns>The constant name.</returns>
    public static string GetConstantName(int constant)
    {
        var status = NativeMethods.d2fprgcn_GetConstName(NdapiContext.GetContext(), constant, out var name);
        Ensure.Success(status);
        return name;
    }

    public override bool Equals(object obj)
    {
        return Equals(obj as NdapiMetaProperty);
    }

    public bool Equals(NdapiMetaProperty other)
    {
        return PropertyId == other?.PropertyId;
    }

    public override int GetHashCode()
    {
        return PropertyId.GetHashCode();
    }
}
