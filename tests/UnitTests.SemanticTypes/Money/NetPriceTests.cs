namespace UnitTests.SemanticTypes.Money;

using IegTools.SemanticTypes;

public class NetPriceTests
{
    [Fact]
    public void Test_Add()
    {
        var actual = new NetPrice(120).Add(new NetPrice(20));

        actual.Should().Be(new NetPrice(140));
    }
    
    [Fact]
    public void Test_Sub()
    {
        var actual = new NetPrice(120).Sub(new NetPrice(20));

        actual.Should().Be(new NetPrice(100));
    }

    [Fact]
    public void Test_Multiply()
    {
        var actual = new NetPrice(120).Multiply(2.0m);

        actual.Should().Be(new NetPrice(240));
    }

    [Fact]
    public void Test_Divide()
    {
        var actual = new NetPrice(120).Divide(2.0m);

        actual.Should().Be(new NetPrice(60));
    }



    [Fact]
    public void Test_Add_Vat()
    {
        var actual = new NetPrice(100).Add(new Vat(20));

        actual.Should().Be(new GrossPrice(120));
    }
}