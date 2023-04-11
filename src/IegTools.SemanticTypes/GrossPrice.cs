namespace IegTools.SemanticTypes;

using Core;

public class GrossPrice : NumericSemanticType<decimal>
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