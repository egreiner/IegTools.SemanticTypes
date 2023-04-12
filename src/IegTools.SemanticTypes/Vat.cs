namespace IegTools.SemanticTypes;

using System;

public record Vat : SemanticType<decimal>
{
    public Vat(decimal value) : base(value)
    {
        if (value < 0)
            throw new ArgumentOutOfRangeException(nameof(value), "Must be greater or equal to 0%");
    }


    public override string ToString() => $"{Value}%";


    public Vat Add(Vat value) =>
        new(Value + value.Value);

    public Vat Sub(Vat value) =>
        new(Value - value.Value);


    public Vat Multiply(decimal multiplicator) =>
        new(Value * multiplicator);

    public Vat Divide(decimal divisor) =>
        new(Value / divisor);
}