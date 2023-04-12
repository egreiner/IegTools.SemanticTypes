namespace UnitTests.SemanticTypes.Money;

using IegTools.SemanticTypes;

public class VatTests
{
    [Fact]
    public void Test_negative_values_throws_exception()
    {
        var createVat = () => new Vat(-20);

        createVat.Should().Throw<ArgumentOutOfRangeException>();
    }

    [Fact]
    public void Test_Add()
    {
        var actual = new Vat(120).Add(new Vat(20));

        actual.Should().Be(new Vat(140));
    }
    
    [Fact]
    public void Test_Sub()
    {
        var actual = new Vat(120).Sub(new Vat(20));

        actual.Should().Be(new Vat(100));
    }

    [Fact]
    public void Test_Multiply()
    {
        var actual = new Vat(120).Multiply(2.0m);

        actual.Should().Be(new Vat(240));
    }

    [Fact]
    public void Test_Divide()
    {
        var actual = new Vat(120).Divide(2.0m);

        actual.Should().Be(new Vat(60));
    }
}