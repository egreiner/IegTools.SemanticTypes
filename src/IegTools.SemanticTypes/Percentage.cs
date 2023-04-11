namespace IegTools.SemanticTypes;

using Core;

/// <summary>
/// Represents any percentage
/// </summary>
public class Percentage : NumericSemanticType<double>
{
    public Percentage() : this(0) { }

    public Percentage(double value) : base(value) { }


    public override string ToString() => $"{Value:N2}%";
}