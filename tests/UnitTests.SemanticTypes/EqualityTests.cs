namespace UnitTests.SemanticTypes;

using IegTools.SemanticTypes;
using TestTypes;

public class EqualityTests
{
    [Theory]
    [InlineData(100, 199, false)]
    [InlineData(199, 199, true)]
    public void Test_Equality_between_the_same_type(double value1, double value2, bool expected)
    {
        var price1 = new StringSemanticType(value1.ToString());
        var price2 = new StringSemanticType(value2.ToString());

        var actual = price1.Equals(price2);

        actual.Should().Be(expected);
    }
    
    [Theory]
    [InlineData(100, 199, false)]
    [InlineData(199, 199, true)]
    public void Test_Equality_operator_between_the_same_type(double value1, double value2, bool expected)
    {
        var price1 = new StringSemanticType(value1.ToString());
        var price2 = new StringSemanticType(value2.ToString());

        var actual = price1 == price2;

        actual.Should().Be(expected);
    }
    
    [Theory]
    [InlineData(100, 199, false)]
    [InlineData(199, 199, false)]
    public void Test_Equality_between_different_types(decimal value1, decimal value2, bool expected)
    {
        var price1 = new GrossPrice(value1);
        var price2 = new NetPrice(value2);

        var actual = price1.Equals(price2);

        actual.Should().Be(expected);
    }
    
    [Theory]
    [InlineData(100, 199, false)]
    [InlineData(199, 199, false)]
    public void Test_Equality_operator_between_different_types(decimal value1, decimal value2, bool expected)
    {
        var price1 = new GrossPrice(value1);
        var price2 = new NetPrice(value2);

        var actual = price1 == price2;

        actual.Should().Be(expected);
    }
}