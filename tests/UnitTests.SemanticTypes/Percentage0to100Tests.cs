namespace UnitTests.SemanticTypes;

using IegTools.SemanticTypes;

public class Percentage0to100Tests
{
    [Fact]
    public void Test_default()
    {
        var actual = new Percentage0To100();

        actual.Value.Should().Be(0);
    }
    
    [Fact]
    public void Test_negative_values_throws_exception()
    {
        var createVat = () => new Percentage0To100(-20);

        createVat.Should().Throw<ArgumentOutOfRangeException>();
    }

    [Theory]
    [InlineData(-10, -10, 0)]
    [InlineData(0, 0, 0)]
    [InlineData(1, 1, 2)]
    [InlineData(50, 50, 100)]
    [InlineData(10, 100, 100)]
    [InlineData(100, 10, 100)]
    public void Test_Add(double value1, double value2, double expected)
    {
        var p1 = Percentage0To100.CreateAutoLimited(value1);
        var p2 = Percentage0To100.CreateAutoLimited(value2);

        var actual = p1.Add(p2);

        actual.Should().Be(new Percentage0To100(expected));
    }

    [Theory]
    [InlineData(-10, -10, 0)]
    [InlineData(0, 0, 0)]
    [InlineData(1, 1, 0)]
    [InlineData(50, 50, 0)]
    [InlineData(10, 100, 0)]
    [InlineData(100, 10, 90)]
    public void Test_Sub(double value1, double value2, double expected)
    {
        var p1 = Percentage0To100.CreateAutoLimited(value1);
        var p2 = Percentage0To100.CreateAutoLimited(value2);

        var actual = p1.Sub(p2);

        actual.Should().Be(new Percentage0To100(expected));
    }

    [Theory]
    [InlineData(-10, 2, 0)]
    [InlineData(0, 2, 0)]
    [InlineData(1, 2, 2)]
    [InlineData(50, 2, 100)]
    [InlineData(10, 2, 20)]
    [InlineData(100, 2, 100)]
    public void Test_Multiply(double value1, double multiplicator, double expected)
    {
        var p1 = Percentage0To100.CreateAutoLimited(value1);

        var actual = p1.Multiply(multiplicator);

        actual.Should().Be(new Percentage0To100(expected));
    }

    [Theory]
    [InlineData(-10, 2, 0)]
    [InlineData(0, 2, 0)]
    [InlineData(1, 2, 0.5)]
    [InlineData(50, 2, 25)]
    [InlineData(10, 2, 5)]
    [InlineData(100, 2, 50)]
    [InlineData(200, 2, 50)]
    public void Test_Divide(double value1, double divisor, double expected)
    {
        var p1 = Percentage0To100.CreateAutoLimited(value1);

        var actual = p1.Divide(divisor);

        actual.Should().Be(new Percentage0To100(expected));
    }
}