namespace UnitTests.SemanticTypes.TestTypes;

using IegTools.SemanticTypes.Core;

internal record StringSemanticType : SemanticType<string>
{
    public StringSemanticType() : this(string.Empty) { }

    public StringSemanticType(string value) : base(value) { }
}