using Intellenum;

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

    /// <summary>
    /// The element inherits the float value from its parent element.
    /// This allows the element to adopt the floating behavior of its parent.
    /// </summary>
    public static readonly Float Inherit = new("inherit");

    /// <summary>
    /// The element resets the float property to its initial value, which is 'none'.
    /// This effectively removes any floating behavior and returns the element to normal document flow.
    /// </summary>
    public static readonly Float Initial = new("initial");

    /// <summary>
    /// The element resets the float property to its inherited value if it inherits, or to its initial value if it doesn't.
    /// This provides a way to reset the float property without explicitly knowing its initial value.
    /// </summary>
    public static readonly Float Unset = new("unset");
}
