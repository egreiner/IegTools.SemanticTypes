namespace IegTools.SemanticTypes;

using Core;

public class GrossPrice : NumericSemanticType<decimal>
{
    public GrossPrice(): this(0) {  }

    public GrossPrice(decimal value) : base(value) { }

    public GrossPrice(NetPrice netPrice, Vat vat) :
        base(netPrice.Value * (100 + vat.Value) / 100) { }


    public override string ToString() => Value.ToString("c");


    /// <summary>
    /// Performs an implicit conversion from <see cref="decimal" /> to <see cref="GrossPrice" />.
    /// Implicit conversion from single or double isn't done on purpose because there could be a loss of precision.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns>The result of the conversion.</returns>
    public static implicit operator GrossPrice(decimal value) =>
        new(value);


    public NetPrice Sub(Vat vat)
        => new(Value / (100 + vat.Value) * 100);

    public Vat Sub(NetPrice netPrice) =>
        new(Value - netPrice.Value);
}