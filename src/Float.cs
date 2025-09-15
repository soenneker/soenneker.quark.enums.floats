using Intellenum;
using Soenneker.Quark.Enums.GlobalKeywords;

namespace Soenneker.Quark.Enums.Floats;

/// <summary>
/// An enumeration for Quark, representing HTML float CSS values.
/// This enum contains all valid CSS float property values for use in HTML/CSS styling.
/// </summary>
[Intellenum<string>]
public partial class Float
{
    /// <summary>
    /// The element does not float and remains in its default position in the document flow.
    /// This is the default value for most elements.
    /// </summary>
    public static readonly Float None = new("none");

    /// <summary>
    /// The element floats to the left side of its container, allowing content to flow around its right side.
    /// Other elements will wrap around the floated element.
    /// </summary>
    public static readonly Float Left = new("left");

    /// <summary>
    /// The element floats to the right side of its container, allowing content to flow around its left side.
    /// Other elements will wrap around the floated element. 
    /// </summary>
    public static readonly Float Right = new("right");

    public static readonly Float InlineStart = new("inline-start");

    public static readonly Float InlineEnd = new("inline-end");

    public static implicit operator Float(GlobalKeyword style) => new(style.Value); // Value is the underlying string
}
