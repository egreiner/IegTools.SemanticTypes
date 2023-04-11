namespace UnitTests.SemanticTypes.Money;

using IegTools.SemanticTypes;

public class GrossPriceTests
{
    [Fact]
    public void Test_default()
    {
        var actual = new GrossPrice();

        actual.Value.Should().Be(0);
    }

    [Fact]
    public void Test_Sub_Vat()
    {
        var actual = new GrossPrice(120).Sub(new Vat(20));

        actual.Should().BeOfType<NetPrice>();
        actual.Should().Be(new NetPrice(100));
    }

    [Fact]
    public void Test_Sub_NetPrice()
    {
        var actual = new GrossPrice(120).Sub(new NetPrice(100));

        actual.Should().BeOfType<Vat>();
        actual.Should().Be(new Vat(20));
    }
}