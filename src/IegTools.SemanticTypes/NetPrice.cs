namespace IegTools.SemanticTypes;

/// <summary>
/// Represents a net price, which is the price of an item or service excluding taxes.
/// Inherits from the SemanticType class and uses a decimal value to store the net price.
/// </summary>
public record NetPrice : SemanticType<decimal>
{   
    /// <summary>
    /// Initializes a new instance of the NetPrice class using a decimal value.
    /// </summary>
    public NetPrice(decimal value) : base(value) { }

    /// <summary>
    /// Initializes a new instance of the NetPrice class using a GrossPrice and a Vat.
    /// </summary>
    public NetPrice(GrossPrice grossPrice, Vat vat) :
        base(grossPrice.Value / ((100 + vat.Value) / 100))
    { }

    /// <summary>
    /// Returns a string that represents the current object.
    /// </summary>
    public override string ToString() => Value.ToString("c");

    /// <summary>
    /// Adds the specified net price to the current net price.
    /// </summary>
    public NetPrice Add(NetPrice value) =>
        new(Value + value.Value);

    /// <summary>
    /// Calculates the gross price for the current net price, given the specified VAT rate.
    /// </summary>
    public GrossPrice Add(Vat vat) =>
        new(Value * (100 + vat.Value) / 100);

    /// <summary>
    /// Subtracts the specified net price from the current net price.
    /// </summary>
    public NetPrice Sub(NetPrice value) =>
        new(Value - value.Value);

    /// <summary>
    /// Multiplies the current net price by the specified multiplicator.
    /// </summary>
    public NetPrice Multiply(decimal multiplicator) =>
        new(Value * multiplicator);

    /// <summary>
    /// Divides the current net price by the specified divisor.
    /// </summary>
    public NetPrice Divide(decimal divisor) =>
        new(Value / divisor);
}