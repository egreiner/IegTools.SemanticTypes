namespace UnitTests.SemanticTypes.WhyThisIsNotWorking;

public record TestGrossPrice : NumericSemanticType<decimal>
{
    public TestGrossPrice() : this(0) {  }

    public TestGrossPrice(decimal value) : base(value) { }
}