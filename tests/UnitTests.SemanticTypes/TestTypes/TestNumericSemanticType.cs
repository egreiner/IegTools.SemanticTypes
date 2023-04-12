namespace UnitTests.SemanticTypes.TestTypes;

using IegTools.SemanticTypes.Core;

internal record TestNumericSemanticType : NumericSemanticType<double>
{
    public TestNumericSemanticType() : this(0) { }


    public TestNumericSemanticType(double value) : base(value)
    {
    }
}