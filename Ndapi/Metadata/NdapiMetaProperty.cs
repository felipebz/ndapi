using Ndapi.Core;
using Ndapi.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Ndapi.Metadata
{
    /// <summary>
    /// Represents a Ndapi metaproperty.
    /// </summary>
    public class NdapiMetaProperty
    {
        private static Dictionary<int, NdapiMetaProperty> _cache = new Dictionary<int, NdapiMetaProperty>();
        private Lazy<Dictionary<int, string>> _allowedValues;
        private Lazy<PropertyType> _propertyType;

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
        public string Description => GetName(PropertyId);

        /// <summary>
        /// Gets the allowed values for the property
        /// </summary>
        public Dictionary<int, string> AllowedValues => _allowedValues.Value;

        /// <summary>
        /// Gets whether the property accepts constant values.
        /// </summary>
        public bool AcceptConstants { get; }

        private NdapiMetaProperty(int propertyId, string name, bool allowGet, bool allowSet, Type propertyType)
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

        private Dictionary<int, string> LoadAllowedValues()
        {
            if (RawPropertyType.IsEnum)
            {
                return Enum.GetValues(RawPropertyType).Cast<int>().ToDictionary(e => e, e => Enum.GetName(RawPropertyType, e));
            }

            return new Dictionary<int, string>();
        }

        /// <summary>
        /// Gets the value name.
        /// </summary>
        /// <param name="value">Value id (see <see cref="NdapiConstants"/>).</param>
        /// <returns>The value name.</returns>
        public string GetValueName(int value) => GetValueName(PropertyId, value);

        /// <summary>
        /// Gets the property type.
        /// </summary>
        /// <param name="property">Property id (see <see cref="NdapiConstants"/>).</param>
        /// <returns>The property type.</returns>
        public static PropertyType GetPropertyType(int property) => NativeMethods.d2fprgt_GetType(NdapiContext.Context, property);

        /// <summary>
        /// Gets the property name.
        /// </summary>
        /// <param name="property">Property id (see <see cref="NdapiConstants"/>).</param>
        /// <returns>The property name.</returns>
        public static string GetName(int property)
        {
            string name;
            var status = NativeMethods.d2fprgn_GetName(NdapiContext.Context, property, out name);
            Ensure.Success(status);
            return name;
        }

        /// <summary>
        /// Gets the value name.
        /// </summary>
        /// <param name="property">Property id (see <see cref="NdapiConstants"/>).</param>
        /// <param name="value">Value id (see <see cref="NdapiConstants"/>).</param>
        /// <returns>The value name.</returns>
        public static string GetValueName(int property, int value)
        {
            string name;
            var status = NativeMethods.d2fprgvn_GetValueName(NdapiContext.Context, property, value, out name);
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
            int value;
            var status = NativeMethods.d2fprgcv_GetConstValue(NdapiContext.Context, constant, out value);
            Ensure.Success(status);
            return value;
        }

        /// <summary>
        /// Gets the constant name.
        /// </summary>
        /// <param name="constant">Constant id (see <see cref="NdapiConstants"/>).</param>
        /// <returns>The constant name.</returns>
        public static string GetConstantName(int constant)
        {
            string name;
            var status = NativeMethods.d2fprgcn_GetConstName(NdapiContext.Context, constant, out name);
            Ensure.Success(status);
            return name;
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
