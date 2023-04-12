namespace UnitTests.SemanticTypes.WhyThisIsNotWorking;

public record TestNetPrice : NumericSemanticType<decimal>
{
    public TestNetPrice() : this(0) {  }

    public TestNetPrice(decimal value) : base(value) { }
}