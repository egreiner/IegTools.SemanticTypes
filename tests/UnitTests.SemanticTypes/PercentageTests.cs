namespace UnitTests.SemanticTypes;

using IegTools.SemanticTypes;

public class PercentageTests
{
    [Fact]
    public void Test_default()
    {
        var actual = new Percentage();

        actual.Value.Should().Be(0);
    }
}