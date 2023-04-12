namespace UnitTests.SemanticTypes.Money;

using IegTools.SemanticTypes;

public class NetPriceTests
{
    [Fact]
    public void Test_default()
    {
        var actual = new NetPrice();

        actual.Value.Should().Be(0);
    }


    [Fact]
    public void Test_Add()
    {
        var actual = new NetPrice(120).Add<NetPrice>(new NetPrice(20));

        actual.Should().Be(new NetPrice(140));
    }
    
    [Fact]
    public void Test_Sub()
    {
        var actual = new NetPrice(120).Sub(new GrossPrice(20));

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
    public void Test_Add_Vat()
    {
        var actual = new NetPrice(100).Add(new Vat(20));

        actual.Should().BeOfType<GrossPrice>();
        actual.Should().Be(new GrossPrice(120));
    }
}