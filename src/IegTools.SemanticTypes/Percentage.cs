namespace IegTools.SemanticTypes;

/// <summary>
/// Represents any percentage
/// Inherits from the SemanticType class and uses a double value to store the percentage.
/// </summary>
public record Percentage : SemanticType<double>
{
    /// <summary>
    /// Creates an instance of <see cref="Percentage"/> with the default value of 0
    /// </summary>
    public Percentage() : this(0) { }

    /// <summary>
    /// Creates an instance of <see cref="Percentage"/> with the specified value
    /// </summary>
    /// <param name="value">The value</param>
    public Percentage(double value) : base(value) { }


    /// <summary>
    /// Returns a string that represents the current object.
    /// </summary>
    public override string ToString() => $"{Value:N2}%";
}