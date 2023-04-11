﻿namespace IegTools.SemanticTypes.Core;

/// <summary>
/// A numeric-semantic-type
/// </summary>
/// <typeparam name="TNumber">The wrapped primitive numeric type</typeparam>
public class NumericSemanticType<TNumber> : SemanticType<TNumber> where TNumber: System.Numerics.INumber<TNumber>
{
    protected NumericSemanticType(TNumber value) : base(value) { }


    public override bool Equals(object obj) =>
        obj is NumericSemanticType<TNumber> other && other.Value.Equals(Value);

    public override int GetHashCode() => Value.GetHashCode();



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