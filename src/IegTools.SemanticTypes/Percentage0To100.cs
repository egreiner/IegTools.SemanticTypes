namespace IegTools.SemanticTypes;

using System;

/// <summary>
/// Represents an percentage value between 0.0% and 100.0%
/// Inherits from the SemanticType class and uses a double value to store a percentage between 0.0% and 100.0%
/// </summary>
public record Percentage0To100 : Percentage
{
    /// <summary>
    /// Creates an instance of <see cref="Percentage0To100"/> with the default value of 0
    /// </summary>
    public Percentage0To100() : this(0) { }

    /// <summary>
    /// Creates an instance of <see cref="Percentage0To100"/> with the specified value
    /// </summary>
    /// <param name="value">The Value</param>
    /// <exception cref="ArgumentOutOfRangeException">Throws exception if not within the boundaries 0.0 to 100.0</exception>
    public Percentage0To100(double value) : base(value)
    {
        if (!value.IsInRange(0.0, 100))
            throw new ArgumentOutOfRangeException(nameof(value), "Must be between 0 and 100");
    }


    /// <summary>
    /// Returns the value (auto-limited) as Percentage0To100.
    /// </summary>
    /// <param name="value">The Value</param>
    public static Percentage0To100 CreateAutoLimited(double value) =>
        new(value.LimitTo(0, 100));


    /// <summary>
    /// Adds the value to the current value and returns the result as auto-limited Percentage0To100.
    /// </summary>
    /// <param name="value">The second value to add</param>
    public Percentage0To100 Add(Percentage0To100 value)
        => CreateAutoLimited(Value + value.Value);

    /// <summary>
    /// Subtracts the value from the current value and returns the result as auto-limited Percentage0To100.
    /// </summary>
    /// <param name="value">The second value to subtract</param>
    public Percentage0To100 Sub(Percentage0To100 value)
        => CreateAutoLimited(Value - value.Value);


    /// <summary>
    /// Multiplies the value with the current value and returns the result as auto-limited Percentage0To100.
    /// </summary>
    /// <param name="multiplicator">The multiplicator value</param>
    public Percentage0To100 Multiply(double multiplicator)
        => CreateAutoLimited(Value * multiplicator);

    /// <summary>
    /// Divides the current value with the divisor and returns the result as auto-limited Percentage0To100.
    /// </summary>
    /// <param name="divisor">The divisor value</param>
    public Percentage0To100 Divide(double divisor)
        => CreateAutoLimited(Value / divisor);
}
 