namespace IegTools.SemanticTypes;

/// <summary>
/// Represents a gross price, which is the price of an item or service including vat taxes.
/// Inherits from the SemanticType class and uses a decimal value to store the gross price.
/// </summary>
public record GrossPrice : SemanticType<decimal>
{
    /// <summary>
    /// Initializes a new instance of the GrossPrice class using a decimal value.
    /// </summary>
    public GrossPrice(decimal value) : base(value) { }

    /// <summary>
    /// Initializes a new instance of the GrossPrice class using a NetPrice and a Vat.
    /// </summary>
    public GrossPrice(NetPrice netPrice, Vat vat) :
        base(netPrice.Value * (100 + vat.Value) / 100) { }

    /// <summary>
    /// Returns a string that represents the current object.
    /// </summary>
    public override string ToString() => Value.ToString("c");

    /// <summary>
    /// Adds the specified GrossPrice value to the current GrossPrice.
    /// </summary>
    public GrossPrice Add(GrossPrice value) =>
        new(Value + value.Value);

    /// <summary>
    /// Subtracts the specified GrossPrice value from the current GrossPrice.
    /// </summary>
    public GrossPrice Sub(GrossPrice value) =>
        new(Value - value.Value);

    /// <summary>
    /// Subtracts the specified Vat value from the current GrossPrice and returns a NetPrice.
    /// </summary>
    public NetPrice Sub(Vat vat)
        => new(Value / (100 + vat.Value) * 100);

    /// <summary>
    /// Subtracts the specified NetPrice value from the current GrossPrice and returns a Vat.
    /// </summary>
    public Vat Sub(NetPrice netPrice) =>
        new((Value - netPrice.Value) / netPrice.Value * 100);

    /// <summary>
    /// Multiplies the current GrossPrice by the specified multiplicator.
    /// </summary>
    public GrossPrice Multiply(decimal multiplicator) =>
        new(Value * multiplicator);

    /// <summary>
    /// Divides the current GrossPrice by the specified divisor.
    /// </summary>
    public GrossPrice Divide(decimal divisor) =>
        new(Value / divisor);
}