namespace IegTools.SemanticTypes;

using System;

/// <summary>
/// Base record for all semantic types
/// </summary>
/// <param name="Value">The primitive value that should be encapsulated</param>
/// <typeparam name="T">The type of the encapsulated value</typeparam>
public abstract record SemanticType<T>(T Value) where T : IComparable<T>, IEquatable<T>
{
    /// <summary>
    /// Greater than operator
    /// </summary>
    /// <param name="type1">Type 1 for comparison</param>
    /// <param name="type2">Type 2 for comparison</param>
    public static bool operator >(SemanticType<T> type1, SemanticType<T> type2)
        => type1.Value.CompareTo(type2.Value) > 0;

    /// <summary>
    /// Greater than or equal to operator 
    /// </summary>
    /// <param name="type1">Type 1 for comparison</param>
    /// <param name="type2">Type 2 for comparison</param>
    public static bool operator >=(SemanticType<T> type1, SemanticType<T> type2)
        => type1.Value.CompareTo(type2.Value) >= 0;


    /// <summary>
    /// Less than to operator 
    /// </summary>
    /// <param name="type1">Type 1 for comparison</param>
    /// <param name="type2">Type 2 for comparison</param>
    public static bool operator <(SemanticType<T> type1, SemanticType<T> type2)
        => type1.Value.CompareTo(type2.Value) < 0;

    /// <summary>
    /// Less than or equal to operator 
    /// </summary>
    /// <param name="type1">Type 1 for comparison</param>
    /// <param name="type2">Type 2 for comparison</param>
    public static bool operator <=(SemanticType<T> type1, SemanticType<T> type2)
        => type1.Value.CompareTo(type2.Value) <= 0;
}