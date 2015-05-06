using Ndapi.Core;
using Ndapi.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Ndapi.Metadata
{
    /// <summary>
    /// Represents a Ndapi metaobject.
    /// </summary>
    public sealed class NdapiMetaObject
    {
        private static Dictionary<Type, NdapiMetaObject> _cache = new Dictionary<Type, NdapiMetaObject>();

        private readonly Type _type;
        private readonly Lazy<IEnumerable<NdapiMetaProperty>> _properties;

        /// <summary>
        /// Gets the type name.
        /// </summary>
        public string TypeName { get; }

        /// <summary>
        /// Gets all the properties.
        /// </summary>
        public IEnumerable<NdapiMetaProperty> AllProperties => _properties.Value;

        /// <summary>
        /// Gets the string properties.
        /// </summary>
        public IEnumerable<NdapiMetaProperty> StringProperties => AllProperties.Where(p => p.PropertyType == PropertyType.Text);

        /// <summary>
        /// Gets the boolean properties.
        /// </summary>
        public IEnumerable<NdapiMetaProperty> BooleanProperties => AllProperties.Where(p => p.PropertyType == PropertyType.Boolean);

        /// <summary>
        /// Gets the integer properties.
        /// </summary>
        public IEnumerable<NdapiMetaProperty> IntegerProperties => AllProperties.Where(p => p.PropertyType == PropertyType.Number);

        /// <summary>
        /// Gets the object properties.
        /// </summary>
        public IEnumerable<NdapiMetaProperty> ObjectProperties => AllProperties.Where(p => p.PropertyType == PropertyType.Object && !p.IsList);

        /// <summary>
        /// Gets the object list properties.
        /// </summary>
        public IEnumerable<NdapiMetaProperty> ChildObjectProperties => AllProperties.Where(p => p.IsList);

        private NdapiMetaObject(Type type)
        {
            TypeName = type.Name;

            _type = type;
            _properties = new Lazy<IEnumerable<NdapiMetaProperty>>(LoadProperties);
        }

        private IEnumerable<NdapiMetaProperty> LoadProperties()
        {
            var properties = from property in _type.GetProperties()
                             from info in property.GetCustomAttributes(typeof(PropertyAttribute), false).Cast<PropertyAttribute>()
                             select NdapiMetaProperty.GetOrCreate(info.PropertyId, property.Name, property.CanRead, property.CanWrite, property.PropertyType);
            return properties.OrderBy(p => p.PropertyId).ToList();
        }

        internal static NdapiMetaObject GetOrCreate(Type type)
        {
            NdapiMetaObject metaObject;
            if (_cache.TryGetValue(type, out metaObject))
            {
                return metaObject;
            }

            metaObject = new NdapiMetaObject(type);
            _cache.Add(type, metaObject);
            return metaObject;
        }
    }
}
