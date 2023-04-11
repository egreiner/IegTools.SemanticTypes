namespace UnitTests.SemanticTypes.Money;

using IegTools.SemanticTypes;

public class GrossPriceImplicitTests
{
    [Fact]
    public void Test_implicit_cast_decimal_to_GrossPrice_is_Ok()
    {
        const decimal expected = 100M;
        GrossPrice gross = expected;

        Assert.Equal(expected, gross.Value);
    }

    [Fact]
    public void Test_implicit_cast_int_to_GrossPrice_is_Ok()
    {
        const int expected = 100;
        GrossPrice gross = expected;

        Assert.Equal(expected, gross.Value);
    }

    [Fact]
    public void Test_implicit_cast_GrossPrice_to_decimal_is_Ok()
    {
        var gross = new GrossPrice(10);

        Assert.Equal(10, gross);
    }
}