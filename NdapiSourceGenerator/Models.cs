using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Text;

namespace NdapiSourceGenerator;

internal sealed record ClassInfo(string? Namespace, string Name, string FullName, string HintName);

/// <param name="BareType">The type without its nullable annotation, for <c>typeof</c>.</param>
internal sealed record PropertyModel(
    string Modifiers,
    string Type,
    string BareType,
    string Name,
    string Constant,
    string GetterModifiers,
    string Getter,
    string? SetterModifiers,
    string? Setter);

internal sealed record ClassModel(ClassInfo Class, EquatableArray<PropertyModel> Properties);

/// <summary>
/// The outcome for one <c>[Property]</c> declaration: a property to implement, a diagnostic, or nothing.
/// </summary>
internal sealed record PropertyResult(ClassInfo? Class, PropertyModel? Property, DiagnosticInfo? Diagnostic)
{
    public static PropertyResult Nothing { get; } = new(null, null, null);

    public static PropertyResult Error(DiagnosticDescriptor descriptor, Location location, params string[] arguments) =>
        new(null, null, new DiagnosticInfo(descriptor, LocationInfo.From(location),
            new EquatableArray<string>(arguments.ToImmutableArray())));
}

/// <summary>
/// A diagnostic without the syntax tree a <see cref="Location"/> holds, which would defeat caching.
/// </summary>
internal sealed record DiagnosticInfo(DiagnosticDescriptor Descriptor, LocationInfo Location, EquatableArray<string> Arguments)
{
    public Diagnostic Create() =>
        Diagnostic.Create(Descriptor, Location.ToLocation(), Arguments.Cast<object>().ToArray());
}

internal sealed record LocationInfo(string FilePath, TextSpan Span, LinePositionSpan LineSpan)
{
    public static LocationInfo From(Location location) =>
        new(location.SourceTree?.FilePath ?? "", location.SourceSpan, location.GetLineSpan().Span);

    public Location ToLocation() => Location.Create(FilePath, Span, LineSpan);
}

/// <summary>
/// An immutable array compared by its items, so pipeline values holding one stay cacheable.
/// </summary>
internal readonly struct EquatableArray<T>(ImmutableArray<T> items) : IEquatable<EquatableArray<T>>, IEnumerable<T>
    where T : IEquatable<T>
{
    private ImmutableArray<T> Items => items.IsDefault ? ImmutableArray<T>.Empty : items;

    public bool Equals(EquatableArray<T> other) => Items.SequenceEqual(other.Items);

    public override bool Equals(object? obj) => obj is EquatableArray<T> other && Equals(other);

    public override int GetHashCode()
    {
        var hash = 17;
        foreach (var item in Items)
        {
            hash = unchecked((hash * 31) + item.GetHashCode());
        }

        return hash;
    }

    public IEnumerator<T> GetEnumerator() => ((IEnumerable<T>)Items).GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}
