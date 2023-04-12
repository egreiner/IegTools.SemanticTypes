namespace UnitTests.SemanticTypes.WhyThisIsNotWorking;

public class NumericSemanticTypeTests
{
    [Fact]
    public void Test_Adding_GrossPrice_and_NetPrice_this_never_should_work()
    {
        var grossPrice = new TestGrossPrice(100);
        var netPrice   = new TestNetPrice(100);

        var actual = grossPrice.Add(netPrice);

        actual.Should().BeOfType<TestNetPrice>();
        actual.Value.Should().Be(200);
    }
}