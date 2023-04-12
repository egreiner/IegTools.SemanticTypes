namespace IegTools.SemanticTypes.Core;

/// <summary>
/// A numeric-semantic-type
/// </summary>
/// <typeparam name="TNumber">The wrapped primitive numeric type</typeparam>
public record NumericSemanticType<TNumber> : SemanticType<TNumber> where TNumber: System.Numerics.INumber<TNumber>
{
    protected NumericSemanticType(TNumber value) : base(value) { }


    public TSemanticType Add<TSemanticType>(TSemanticType value) where TSemanticType: NumericSemanticType<TNumber>, new()
    {
////#define CONDITION_NOT_MET

////#if (GetType()) != typeof(TSemanticType))
////#error "The required condition is not met. Please define the CONDITION_NOT_MET preprocessor symbol."
////#endif

        return new TSemanticType { Value = Value + value.Value };
    }

    public TSemanticType Sub<TSemanticType>(TSemanticType value) where TSemanticType: NumericSemanticType<TNumber>, new()
        => new() { Value = Value - value.Value };


    public TSemanticType Multiply<TSemanticType>(TNumber multiplicator)
        where TSemanticType : NumericSemanticType<TNumber>, new()
        => new() { Value = Value * multiplicator};

    public TSemanticType Divide<TSemanticType>(TNumber divisor)
        where TSemanticType : NumericSemanticType<TNumber>, new()
        => new() { Value = Value / divisor};
}