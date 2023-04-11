namespace UnitTests.SemanticTypes.Money;

using IegTools.SemanticTypes;

public class VatTests
{
    [Fact]
    public void Test_default()
    {
        var actual = new Vat();

        actual.Value.Should().Be(0);
    }

    [Fact]
    public void Test_negative_values_throws_exception()
    {
        var createVat = () => new Vat(-20);

        createVat.Should().Throw<ArgumentOutOfRangeException>();
    }
}