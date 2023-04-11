namespace UnitTests.SemanticTypes.TestTypes;

using IegTools.SemanticTypes.Core;

internal class TestNumericSemanticType : NumericSemanticType<double>
{
    public TestNumericSemanticType() : this(0) { }


    public TestNumericSemanticType(double value) : base(value)
    {
    }
}