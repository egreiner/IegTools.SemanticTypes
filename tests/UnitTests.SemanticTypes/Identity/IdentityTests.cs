namespace UnitTests.SemanticTypes.Identity;

using IegTools.SemanticTypes;

public class IdentityTests
{
    [Fact]
    public void Identities_ShouldBe_equal_when_same_int_values()
    {
        var id1 = new IdentityValue<int>(1);
        var id2 = new IdentityValue<int>(1);

        id2.Should().Be(id1);
    }
    
    [Fact]
    public void Identities_ShouldBe_equal_when_same_values()
    {
        var id1 = new IdentityValue<int>(1);
        var id2 = new IdentityValue<int>(1);

        var actual = id1 == id2;
        actual.Should().BeTrue();
    }
    
    [Fact]
    public void Identities_ShouldBe_equal_when_same_string_values()
    {
        var id1 = new IdentityValue<string>("1");
        var id2 = new IdentityValue<string>("1");

        id2.Should().Be(id1);
    }
    
    [Fact]
    public void Identities_ShouldNotBe_equal_when_different_value()
    {
        var id1 = new IdentityValue<int>(1);
        var id2 = new IdentityValue<int>(2);

        id2.Should().NotBe(id1);
    }
    
    [Fact]
    public void Identities_ShouldNotBe_equal_when_different_types()
    {
        var id1 = new IdentityValue<int>(1);
        var id2 = new IdentityValue<string>("1");

        id2.Should().NotBe(id1);
    }
    
    [Fact]
    public void ToString_Should_contain_expected_strings()
    {
        const int value = 1;
        var id = new IdentityValue<int>(value);
        
        var actual = id.ToString();
        
        actual.Should().Contain(nameof(IdentityValue<int>));
        actual.Should().Contain(nameof(id.Value));
        actual.Should().Contain(value.ToString());
    }
    
    [Fact]
    public void ToString_Should_be_as_expected()
    {
        const int value = 1;
        var id = new IdentityValue<int>(value);
        
        var actual = id.ToString();
        
        actual.Should().Be("IdentityValue { Value = 1 }");
    }
}