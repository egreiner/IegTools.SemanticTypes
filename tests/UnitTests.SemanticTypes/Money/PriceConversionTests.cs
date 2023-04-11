namespace UnitTests.SemanticTypes.Money;

using IegTools.SemanticTypes;

public class PriceConversionTests
{
    [Fact]
    public void Test_create_GrossPrice_from_NetPrice_and_Vat()
    {
        var actual = new GrossPrice(new NetPrice(100), new Vat(20));

        actual.Should().Be(new GrossPrice(120));
    }

    [Fact]
    public void Test_create_NetPrice_from_GrossPrice_and_Vat()
    {
        var actual = new NetPrice(new GrossPrice(120), new Vat(20));

        actual.Should().Be(new NetPrice(100));
    }
}