namespace UnitTests.SemanticTypes.Money;

using IegTools.SemanticTypes;

public class NetPriceOperationsTests
{
    [Fact]
    public void Test_Add_Vat()
    {
        var actual = new NetPrice(100).Add(new Vat(20));

        actual.Should().BeOfType<GrossPrice>();
        actual.Should().Be(new GrossPrice(120));
    }
}