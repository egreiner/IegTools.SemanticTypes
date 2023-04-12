namespace IegTools.SemanticTypes;

public record NetPrice : SemanticType<decimal>
{   
    public NetPrice(decimal value) : base(value) { }

    public NetPrice(GrossPrice grossPrice, Vat vat) :
        base(grossPrice.Value / ((100 + vat.Value) / 100))
    { }


    public override string ToString() => Value.ToString("c");


    public NetPrice Add(NetPrice value) =>
        new(Value + value.Value);

    public GrossPrice Add(Vat vat) =>
        new(Value * (100 + vat.Value) / 100);

    
    public NetPrice Sub(NetPrice value) =>
        new(Value - value.Value);


    public NetPrice Multiply(decimal multiplicator) =>
        new(Value * multiplicator);

    public NetPrice Divide(decimal divisor) =>
        new(Value / divisor);
}