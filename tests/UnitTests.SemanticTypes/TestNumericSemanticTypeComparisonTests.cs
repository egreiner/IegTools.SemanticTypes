namespace UnitTests.SemanticTypes;

using TestTypes;

public class TestNumericSemanticTypeComparisonTests
{
    [Theory]
    [InlineData(100, 199, false)]
    [InlineData(199, 199, true)]
    public void Test_Equal(double value1, double value2, bool expected)
    {
        var price1 = new TestNumericSemanticType(value1);
        var price2 = new TestNumericSemanticType(value2);

        var actual = price1 == price2;

        actual.Should().Be(expected);
    }

    [Theory]
    [InlineData(100, 199, true)]
    [InlineData(199, 199, false)]
    public void Test_NotEqual(double value1, double value2, bool expected)
    {
        var price1 = new TestNumericSemanticType(value1);
        var price2 = new TestNumericSemanticType(value2);

        var actual = price1 != price2;

        actual.Should().Be(expected);
    }


    [Theory]
    [InlineData(100, 199, true)]
    [InlineData(199, 199, false)]
    [InlineData(999, 199, false)]
    public void Test_LessThan(double value1, double value2, bool expected)
    {
        var price1 = new TestNumericSemanticType(value1);
        var price2 = new TestNumericSemanticType(value2);

        var actual = price1 < price2;

        actual.Should().Be(expected);
    }

    [Theory]
    [InlineData(100, 199, true)]
    [InlineData(199, 199, true)]
    [InlineData(999, 199, false)]
    public void Test_LessThanOrEqual(double value1, double value2, bool expected)
    {
        var price1 = new TestNumericSemanticType(value1);
        var price2 = new TestNumericSemanticType(value2);

        var actual = price1 <= price2;

        actual.Should().Be(expected);
    }


    [Theory]
    [InlineData(100, 199, false)]
    [InlineData(199, 199, false)]
    [InlineData(999, 199, true)]
    public void Test_GreaterThan(double value1, double value2, bool expected)
    {
        var price1 = new TestNumericSemanticType(value1);
        var price2 = new TestNumericSemanticType(value2);

        var actual = price1 > price2;

        actual.Should().Be(expected);
    }

    [Theory]
    [InlineData(100, 199, false)]
    [InlineData(199, 199, true)]
    [InlineData(999, 199, true)]
    public void Test_GreaterThanOrEqual(double value1, double value2, bool expected)
    {
        var price1 = new TestNumericSemanticType(value1);
        var price2 = new TestNumericSemanticType(value2);

        var actual = price1 >= price2;

        actual.Should().Be(expected);
    }
}