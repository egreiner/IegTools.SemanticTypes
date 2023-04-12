namespace UnitTests.SemanticTypes.WhyThisIsNotWorking;

/// <summary>
/// A numeric-semantic-type that is not working as intended.
/// The math operations create the possibility to e.g. add GrossPrice and NetPrice, which is not allowed.
/// This is exactly what SemanticTypes should prevent!
/// I didn't find a way to prevent this with preprocessor directives or other possibilities.
/// Maybe there are possibility to use JetBrains or Roslyn to prevent this?
/// </summary>
/// <typeparam name="TNumber">The wrapped primitive numeric type</typeparam>
public record NumericSemanticType<TNumber> : IegTools.SemanticTypes.SemanticType<TNumber> where TNumber: System.Numerics.INumber<TNumber>
{
    protected NumericSemanticType(TNumber value) : base(value) { }


    public TSemanticType Add<TSemanticType>(TSemanticType value) where TSemanticType: NumericSemanticType<TNumber>, new() =>
        new() { Value = Value + value.Value };
}