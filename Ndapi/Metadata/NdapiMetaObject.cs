using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

using Ndapi.Core;
using Ndapi.Enums;

namespace Ndapi.Metadata;

/// <summary>
/// Represents a Ndapi metaobject.
/// </summary>
public sealed class NdapiMetaObject
{
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
    public IEnumerable<NdapiMetaProperty> StringProperties =>
        AllProperties.Where(p => p.PropertyType == PropertyType.Text);

    /// <summary>
    /// Gets the boolean properties.
    /// </summary>
    public IEnumerable<NdapiMetaProperty> BooleanProperties =>
        AllProperties.Where(p => p.PropertyType == PropertyType.Boolean);

    /// <summary>
    /// Gets the integer properties.
    /// </summary>
    public IEnumerable<NdapiMetaProperty> IntegerProperties =>
        AllProperties.Where(p => p.PropertyType == PropertyType.Number);

    /// <summary>
    /// Gets the object properties.
    /// </summary>
    public IEnumerable<NdapiMetaProperty> ObjectProperties =>
        AllProperties.Where(p => p.PropertyType == PropertyType.Object && !p.IsList);

    /// <summary>
    /// Gets the object list properties.
    /// </summary>
    public IEnumerable<NdapiMetaProperty> ChildObjectProperties => AllProperties.Where(p => p.IsList);

    internal NdapiMetaObject(Type type)
    {
        TypeName = type.Name;

        _type = type;
        _properties = new Lazy<IEnumerable<NdapiMetaProperty>>(LoadProperties, LazyThreadSafetyMode.PublicationOnly);
    }

    // Walks from the class to its bases, so an overriding declaration hides the one it overrides, as reflection did.
    private List<NdapiMetaProperty> LoadProperties()
    {
        var names = new HashSet<string>(StringComparer.Ordinal);
        var properties = new List<NdapiMetaProperty>();
        for (var type = _type; type is not null; type = type.BaseType)
        {
            if (!PropertyDeclarations.Declared.TryGetValue(type, out var declarations))
            {
                continue;
            }

            foreach (var declaration in declarations)
            {
                if (names.Add(declaration.Name) &&
                    ConstantConverter.IsPropertySupportedByBuilderVersion(declaration.PropertyId))
                {
                    properties.Add(new NdapiMetaProperty(declaration.PropertyId, declaration.Name, allowGet: true,
                        declaration.CanWrite, declaration.PropertyType));
                }
            }
        }

        return properties.OrderBy(p => p.PropertyId).ToList();
    }
}
