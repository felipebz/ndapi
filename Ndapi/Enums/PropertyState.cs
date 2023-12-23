namespace Ndapi.Enums;

/// <summary>
/// Property states.
/// </summary>
public enum PropertyState
{
    /// <summary>
    /// State unknown.
    /// </summary>
    Unknown,

    /// <summary>
    /// The property has its default value.
    /// </summary>
    Default,

    /// <summary>
    /// The property had the default value and was overriden.
    /// </summary>
    OverriddenDefault,

    /// <summary>
    /// The property is inherited.
    /// </summary>
    Inherited,

    /// <summary>
    /// The property had and inherited value and was overriden.
    /// </summary>
    OverriddenInherited
}
