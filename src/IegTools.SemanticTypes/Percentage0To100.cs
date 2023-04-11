namespace IegTools.SemanticTypes;

using System;

public class Percentage0To100 : Percentage
{
    public Percentage0To100() : this(0) { }

    /// <summary>
    /// Returns the value as Percentage0To100.
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
    /// Performs an implicit conversion from <see cref="double" /> to <see cref="Percentage0To100" />.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns>The result of the conversion.</returns>
    public static implicit operator Percentage0To100(double value) =>
        CreateAutoLimited(value);



    public Percentage0To100 Add(Percentage0To100 value)
        => CreateAutoLimited(Value + value.Value);

    public Percentage0To100 Sub(Percentage0To100 value)
        => CreateAutoLimited(Value - value.Value);


    public Percentage0To100 Multiply(double multiplicator)
        => CreateAutoLimited(Value * multiplicator);

    public Percentage0To100 Divide(double divisor)
        => CreateAutoLimited(Value / divisor);
}
 