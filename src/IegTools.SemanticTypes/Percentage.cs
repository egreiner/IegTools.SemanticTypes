namespace IegTools.SemanticTypes;

/// <summary>
/// Represents any percentage
/// </summary>
public record Percentage : SemanticType<double>
{
    public Percentage() : this(0) { }

    public Percentage(double value) : base(value) { }


    public override string ToString() => $"{Value:N2}%";
}