using Soenneker.Gen.EnumValues;

namespace Soenneker.Quark.Enums;

/// <summary>
/// An enumeration for Quark, representing HTML float CSS values.
/// This enum contains all valid CSS float property values for use in HTML/CSS styling.
/// </summary>
[EnumValue<string>]
[IncludeEnumValues(typeof(GlobalKeyword))]
public partial class FloatKeyword
{
    /// <summary>
    /// The element does not float and remains in its default position in the document flow.
    /// This is the default value for most elements.
    /// </summary>
    public static readonly FloatKeyword None = new("none");

    /// <summary>
    /// The element floats to the left side of its container, allowing content to flow around its right side.
    /// Other elements will wrap around the floated element.
    /// </summary>
    public static readonly FloatKeyword Left = new("left");

    /// <summary>
    /// The element floats to the right side of its container, allowing content to flow around its left side.
    /// Other elements will wrap around the floated element. 
    /// </summary>
    public static readonly FloatKeyword Right = new("right");

    public static readonly FloatKeyword InlineStart = new("inline-start");

    public static readonly FloatKeyword InlineEnd = new("inline-end");
}
