namespace IegTools.SemanticTypes;

public record GrossPrice : SemanticType<decimal>
{
    public GrossPrice(decimal value) : base(value) { }

    public GrossPrice(NetPrice netPrice, Vat vat) :
        base(netPrice.Value * (100 + vat.Value) / 100) { }


    public override string ToString() => Value.ToString("c");


    public GrossPrice Add(GrossPrice value) =>
        new(Value + value.Value);

    
    public GrossPrice Sub(GrossPrice value) =>
        new(Value - value.Value);

    public NetPrice Sub(Vat vat)
        => new(Value / (100 + vat.Value) * 100);

    public Vat Sub(NetPrice netPrice) =>
        new((Value - netPrice.Value) / netPrice.Value * 100);


    public GrossPrice Multiply(decimal multiplicator) =>
        new(Value * multiplicator);

    public GrossPrice Divide(decimal divisor) =>
        new(Value / divisor);
}