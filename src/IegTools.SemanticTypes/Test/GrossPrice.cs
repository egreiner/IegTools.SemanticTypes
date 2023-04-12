namespace IegTools.SemanticTypes.Test;


public abstract record SemanticType<T>(T Value) where T : IComparable<T>, IEquatable<T>
{
    public static bool operator >(SemanticType<T> type1, SemanticType<T> type2)
        => type1.Value.CompareTo(type2.Value) > 0;

    public static bool operator >=(SemanticType<T> type1, SemanticType<T> type2)
        => type1.Value.CompareTo(type2.Value) >= 0;


    public static bool operator <(SemanticType<T> type1, SemanticType<T> type2)
        => type1.Value.CompareTo(type2.Value) < 0;

    public static bool operator <=(SemanticType<T> type1, SemanticType<T> type2)
        => type1.Value.CompareTo(type2.Value) <= 0;
}

/// <summary>
/// A numeric-semantic-type
/// </summary>
/// <typeparam name="TNumber">The wrapped primitive numeric type</typeparam>
public record NumericSemanticType<TNumber> : SemanticType<TNumber> where TNumber: System.Numerics.INumber<TNumber>
{
    protected NumericSemanticType(TNumber value) : base(value) { }


    public TSemanticType Add<TSemanticType>(TSemanticType value) where TSemanticType: NumericSemanticType<TNumber>, new()
        => new() { Value = Value + value.Value };

    public TSemanticType Sub<TSemanticType>(TSemanticType value) where TSemanticType: NumericSemanticType<TNumber>, new()
        => new() { Value = Value - value.Value };


    public TSemanticType Multiply<TSemanticType>(TNumber multiplicator)
        where TSemanticType : NumericSemanticType<TNumber>, new()
        => new() { Value = Value * multiplicator};

    public TSemanticType Divide<TSemanticType>(TNumber divisor)
        where TSemanticType : NumericSemanticType<TNumber>, new()
        => new() { Value = Value / divisor};
}

public record GrossPrice : NumericSemanticType<decimal>
{
    public GrossPrice(): this(0) {  }

    public GrossPrice(decimal value) : base(value) { }

    public GrossPrice(NetPrice netPrice, Vat vat) :
        base(netPrice.Value * (100 + vat.Value) / 100) { }


    public override string ToString() => Value.ToString("c");


    public NetPrice Sub(Vat vat)
        => new(Value / (100 + vat.Value) * 100);

    public Vat Sub(NetPrice netPrice) =>
        new(Value - netPrice.Value);
}


public record NetPrice : NumericSemanticType<decimal>
{   
    public NetPrice() : this(0) { }

    public NetPrice(decimal value) : base(value) { }

    public NetPrice(GrossPrice grossPrice, Vat vat) :
        base(grossPrice.Value / ((100 + vat.Value) / 100))
    { }


    public override string ToString() => Value.ToString("c");


    public GrossPrice Add(Vat vat) =>
        new(Value * (100 + vat.Value) / 100);
}

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