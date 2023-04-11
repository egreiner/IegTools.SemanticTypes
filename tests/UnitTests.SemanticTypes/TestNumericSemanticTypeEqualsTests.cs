namespace UnitTests.SemanticTypes;

public class TestNumericSemanticTypeEqualsTests
{
    [Theory]
    [InlineData(100, 199, false)]
    [InlineData(199, 199, true)]
    public void Test_Equal(double value1, double value2, bool expected)
    {
        var price1 = new TestNumericSemanticType(value1);
        var price2 = new TestNumericSemanticType(value2);

        var actual = price1.Equals(price2);

        actual.Should().Be(expected);
    }
}