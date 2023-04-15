namespace IegTools.SemanticTypes;

using System;

/// <summary>
/// Represents a Value Added Tax (VAT) rate as a percentage value.
/// Inherits from the SemanticType class and uses a decimal value to store the VAT rate.
/// </summary>
public record Vat : SemanticType<decimal>
{
    /// <summary>
    /// Constructs a new Vat instance with the given decimal value.
    /// </summary>
    /// <param name="value">The decimal value representing the VAT rate.</param>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when the value is less than 0.</exception>
    public Vat(decimal value) : base(value)
    {
        if (value < 0)
            throw new ArgumentOutOfRangeException(nameof(value), "Must be greater or equal to 0%");
    }

    /// <summary>
    /// Returns a string representation of the Vat object, formatted as "{Value}%"
    /// </summary>
    public override string ToString() => $"{Value}%";

    /// <summary>
    /// Adds the specified Vat value to the current Vat object, and returns a new Vat object.
    /// </summary>
    /// <param name="value">The Vat object to add to the current object.</param>
    /// <returns>A new Vat object representing the sum of the two VAT rates.</returns>
    public Vat Add(Vat value) =>
        new(Value + value.Value);

    /// <summary>
    /// Subtracts the specified Vat value from the current Vat object, and returns a new Vat object.
    /// </summary>
    /// <param name="value">The Vat object to subtract from the current object.</param>
    /// <returns>A new Vat object representing the difference of the two VAT rates.</returns>
    public Vat Sub(Vat value) =>
        new(Value - value.Value);

    /// <summary>
    /// Multiplies the current Vat value by the specified decimal multiplicator, and returns a new Vat object.
    /// </summary>
    /// <param name="multiplicator">The decimal multiplicator to multiply the current Vat value by.</param>
    /// <returns>A new Vat object representing the product of the multiplication.</returns>
    public Vat Multiply(decimal multiplicator) =>
        new(Value * multiplicator);

    /// <summary>
    /// Divides the current Vat value by the specified decimal divisor, and returns a new Vat object.
    /// </summary>
    /// <param name="divisor">The decimal divisor to divide the current Vat value by.</param>
    /// <returns>A new Vat object representing the result of the division.</returns>
    public Vat Divide(decimal divisor) =>
        new(Value / divisor);
}