namespace IegTools.SemanticTypes;

using Core;

public class NetPrice : NumericSemanticType<decimal>
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