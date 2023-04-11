namespace IegTools.SemanticTypes;

using Core;

public class NetPrice : NumericSemanticType<decimal>
{
    public NetPrice(decimal value) : base(value) { }

    public NetPrice(GrossPrice grossPrice, Vat vat) :
        base(grossPrice.Value / ((100 + vat.Value) / 100))
    { }


    public override string ToString() => Value.ToString("c");


    /// <summary>
    /// Performs an implicit conversion from <see cref="decimal" /> to <see cref="NetPrice" />.
    /// Implicit conversion from single or double isn't done on purpose because there could be a loss of precision.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns>The result of the conversion.</returns>
    public static implicit operator NetPrice(decimal value) =>
        new(value);


    public GrossPrice Add(Vat vat) =>
        new(Value * (100 + vat.Value) / 100);
}