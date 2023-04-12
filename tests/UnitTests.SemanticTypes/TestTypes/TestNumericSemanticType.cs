namespace UnitTests.SemanticTypes.TestTypes;

using IegTools.SemanticTypes;

internal record TestNumericSemanticType : SemanticType<double>
{
    public TestNumericSemanticType() : this(0) { }


    public TestNumericSemanticType(double value) : base(value)
    {
    }
}