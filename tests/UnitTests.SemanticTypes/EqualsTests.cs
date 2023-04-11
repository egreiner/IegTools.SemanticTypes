namespace UnitTests.SemanticTypes;

using TestTypes;

public class EqualsTests
{
    [Theory]
    [InlineData(100, 199, false)]
    [InlineData(199, 199, true)]
    public void Test_Equal(double value1, double value2, bool expected)
    {
        var price1 = new StringSemanticType(value1.ToString());
        var price2 = new StringSemanticType(value2.ToString());

        var actual = price1.Equals(price2);

        actual.Should().Be(expected);
    }
}