using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Ndapi.Core;

internal static partial class ConstantConverter
{
    // the members of every Ndapi enum hold NdapiConstant ids, and all of them are int based
    private static NdapiConstant ToConstant<T>(T value) where T : struct, Enum => Unsafe.BitCast<T, NdapiConstant>(value);

    public static int GetValue<T>(T value) where T : struct, Enum => GetValue(ToConstant(value));

    public static int GetValue(int propertyId) => GetValue((NdapiConstant)propertyId);

    public static int GetValue(NdapiConstant property)
    {
        var constants = NdapiContext.BuilderVersion.MajorVersion switch
        {
            6 => Forms6Constants,
            12 => Forms12Constants,
            14 => Forms14Constants,
            _ => throw new NdapiException($"Unsupported Forms Builder version ({NdapiContext.BuilderVersion.FullVersion})")
        };

        return constants.TryGetValue(property, out var value)
            ? value
            : throw new NdapiException(
                $"{property} is not supported by Oracle Forms {NdapiContext.BuilderVersion.FullVersion}.");
    }

    public static bool IsPropertySupportedByBuilderVersion<T>(T value) where T : struct, Enum =>
        IsPropertySupportedByBuilderVersion(ToConstant(value));

    public static bool IsPropertySupportedByBuilderVersion(int propertyId) =>
        IsPropertySupportedByBuilderVersion((NdapiConstant)propertyId);

    public static bool IsPropertySupportedByBuilderVersion(NdapiConstant property)
    {
        return NdapiContext.BuilderVersion.MajorVersion switch
        {
            6 => Forms6Constants.ContainsKey(property),
            12 => Forms12Constants.ContainsKey(property),
            14 => Forms14Constants.ContainsKey(property),
            _ => throw new NdapiException($"Unsupported Forms Builder version ({NdapiContext.BuilderVersion.FullVersion})")
        };
    }

    /// <summary>
    /// Converts a value returned by Forms to the member of <typeparamref name="T"/> that the running Builder version
    /// maps to it.
    /// </summary>
    public static T ToEnum<T>(int nativeValue) where T : struct, Enum => EnumValues<T>.Get(nativeValue);

    private static class EnumValues<T> where T : struct, Enum
    {
        private static Dictionary<int, T>? s_byNativeValue;
        private static int s_majorVersion;

        public static T Get(int nativeValue)
        {
            var majorVersion = NdapiContext.BuilderVersion.MajorVersion;
            if (s_byNativeValue is null || s_majorVersion != majorVersion)
            {
                s_byNativeValue = Load();
                s_majorVersion = majorVersion;
            }

            return s_byNativeValue.TryGetValue(nativeValue, out var value)
                ? value
                : throw new NdapiException(
                    $"Oracle Forms returned {nativeValue}, which is not a known {typeof(T).Name} value.");
        }

        // several members can share a native value: the first one in Enum.GetValues order wins
        private static Dictionary<int, T> Load()
        {
            var values = new Dictionary<int, T>();
            foreach (var member in Enum.GetValues<T>())
            {
                if (IsPropertySupportedByBuilderVersion(member))
                {
                    values.TryAdd(GetValue(member), member);
                }
            }

            return values;
        }
    }

    /// <summary>
    /// Gets the object property ids (D2FP_*) defined by the running Forms Builder version, ordered by their native value.
    /// Pseudo constants (D2FP_MIN, D2FP_MAX, D2FP_NONE, D2FP_UNDEFINED and the D2FP_TYP_* property types) are excluded.
    /// </summary>
    public static IReadOnlyList<NdapiConstant> GetSupportedProperties()
    {
        var majorVersion = NdapiContext.BuilderVersion.MajorVersion;
        if (s_supportedProperties is not null && s_supportedPropertiesVersion == majorVersion)
        {
            return s_supportedProperties;
        }

        var constants = majorVersion switch
        {
            6 => Forms6Constants,
            12 => Forms12Constants,
            14 => Forms14Constants,
            _ => throw new NdapiException($"Unsupported Forms Builder version ({NdapiContext.BuilderVersion.FullVersion})")
        };

        s_supportedProperties = constants
            .Where(c => IsObjectProperty(c.Key))
            .OrderBy(c => c.Value)
            .Select(c => c.Key)
            .ToList()
            .AsReadOnly();
        s_supportedPropertiesVersion = majorVersion;
        return s_supportedProperties;
    }

    private static IReadOnlyList<NdapiConstant>? s_supportedProperties;
    private static int s_supportedPropertiesVersion;

    private static bool IsObjectProperty(NdapiConstant constant)
    {
        var name = constant.ToString();
        return name.StartsWith("D2FP_", StringComparison.Ordinal)
               && !name.StartsWith("D2FP_TYP_", StringComparison.Ordinal)
               && constant is not (NdapiConstant.D2FP_MIN or NdapiConstant.D2FP_MAX or NdapiConstant.D2FP_NONE
                   or NdapiConstant.D2FP_UNDEFINED);
    }
}
