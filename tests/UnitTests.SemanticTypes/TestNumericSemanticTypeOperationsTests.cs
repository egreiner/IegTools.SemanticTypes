namespace UnitTests.SemanticTypes;

public class TestNumericSemanticTypeOperationsTests
{
    [Fact]
    public void Test_Add()
    {
        var actual = new TestNumericSemanticType(10).Add(new TestNumericSemanticType(1));

        actual.Should().BeOfType<TestNumericSemanticType>();
        actual.Should().Be(new TestNumericSemanticType(11));
    }

    [Fact]
    public void Test_Sub()
    {
        var actual = new TestNumericSemanticType(10).Sub(new TestNumericSemanticType(1));

        actual.Should().BeOfType<TestNumericSemanticType>();
        actual.Should().Be(new TestNumericSemanticType(9));
    }

    [Fact]
    public void Test_Multiply()
    {
        var value = new TestNumericSemanticType(10);
        var actual = value.Multiply<TestNumericSemanticType>(2.5);

        actual.Should().BeOfType<TestNumericSemanticType>();
        actual.Should().Be(new TestNumericSemanticType(25));
    }

    [Fact]
    public void Test_Divide()
    {
        var value = new TestNumericSemanticType(25);
        var actual = value.Divide<TestNumericSemanticType>(2.5);

        actual.Should().BeOfType<TestNumericSemanticType>();
        actual.Should().Be(new TestNumericSemanticType(10));
    }
}