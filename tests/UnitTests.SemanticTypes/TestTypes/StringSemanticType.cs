namespace UnitTests.SemanticTypes.TestTypes;

using IegTools.SemanticTypes.Core;

internal class StringSemanticType : SemanticType<string>
{
    public StringSemanticType() : this(string.Empty) { }

    public StringSemanticType(string value) : base(value) { }
}