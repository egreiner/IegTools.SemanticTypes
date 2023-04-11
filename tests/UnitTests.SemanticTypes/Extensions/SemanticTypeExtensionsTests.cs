namespace UnitTests.SemanticTypes.Extensions;

using IegTools.SemanticTypes;
using UnitTests.SemanticTypes.TestTypes;

public class SemanticTypeExtensionsTests
{
    [Fact]
    public void Test_GetValueOrDefault()
    {
        var value = new TestNumericSemanticType(1000.0);

        var actual = value.GetValueOrDefault();

        actual.Should().Be(1000.0);
    }

    [Fact]
    public void Test_GetValueOrDefault_null()
    {
        TestNumericSemanticType value = null;

        var actual = value.GetValueOrDefault();

        actual.Should().Be(0.0);
    }
}