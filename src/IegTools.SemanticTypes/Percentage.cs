namespace IegTools.SemanticTypes;

using Core;

public class Percentage : NumericSemanticType<double>
{
    public Percentage() : this(0) { }

    public Percentage(double value) : base(value) { }


    public override string ToString() => $"{Value:N2}%";

    
    /// <summary>
    /// Performs an implicit conversion from <see cref="double" /> to <see cref="Percentage" />.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns>The result of the conversion.</returns>
    public static implicit operator Percentage(double value) =>
        new(value);
}