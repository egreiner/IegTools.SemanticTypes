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
    public void Test_Add()
    {
        var actual = new GrossPrice(120).Add(new GrossPrice(20));

        actual.Should().Be(new GrossPrice(140));
    }
    
    [Fact]
    public void Test_Sub()
    {
        var actual = new GrossPrice(120).Sub(new GrossPrice(20));

        actual.Should().Be(new GrossPrice(100));
    }

    [Fact]
    public void Test_Multiply()
    {
        var actual = new GrossPrice(120).Multiply<GrossPrice>(2.0m);

        actual.Should().Be(new GrossPrice(240));
    }

    [Fact]
    public void Test_Divide()
    {
        var actual = new GrossPrice(120).Divide<GrossPrice>(2.0m);

        actual.Should().Be(new GrossPrice(60));
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