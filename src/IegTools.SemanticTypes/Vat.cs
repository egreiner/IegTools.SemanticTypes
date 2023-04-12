namespace IegTools.SemanticTypes;

using System;
using Core;

public record Vat : NumericSemanticType<decimal>
{
    public Vat() : this(0) { }

    public Vat(decimal value) : base(value)
    {
        if (!value.IsInRange(0, 100))
            throw new ArgumentOutOfRangeException(nameof(value), "Must be between 0 and 100");
    }


    public override string ToString() => $"{Value}%";
}