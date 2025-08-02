namespace IegTools.SemanticTypes;

/// <summary>
/// A semantic type that represents an identity value.
/// This type is used to encapsulate a value that represents an identity, such as a user ID, product ID, etc.
/// It is intended to provide type safety and clarity in the codebase.
/// The underlying value can be of any type, such as int, string, Guid, etc.
/// The value is immutable and can be used in comparisons and other operations as needed.
/// </summary>
public readonly record struct IdentityValue<T>(T Value)
{
    /// <inheritdoc />
    public override string ToString() => Value.ToString();
}