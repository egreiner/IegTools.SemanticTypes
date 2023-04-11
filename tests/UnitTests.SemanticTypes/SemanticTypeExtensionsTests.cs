namespace UnitTests.SemanticTypes;

using IegTools.SemanticTypes;

public class SemanticTypeExtensionsTests
{
    [Fact]
    public void Test_GetValueOrDefault()
    {
        Percentage percentage = new Percentage(1000.0);

        double actual = percentage.GetValueOrDefault();

        actual.Should().Be(1000.0);
    }

    [Fact]
    public void Test_GetValueOrDefault_null()
    {
        Percentage percentage = null;

        double actual = percentage.GetValueOrDefault();

        actual.Should().Be(0.0);
    }
}