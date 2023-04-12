namespace IegTools.SemanticTypes;

using System;

public abstract record SemanticType<T>(T Value) where T : IComparable<T>, IEquatable<T>
{
    public static bool operator >(SemanticType<T> type1, SemanticType<T> type2)
        => type1.Value.CompareTo(type2.Value) > 0;

    public static bool operator >=(SemanticType<T> type1, SemanticType<T> type2)
        => type1.Value.CompareTo(type2.Value) >= 0;


    public static bool operator <(SemanticType<T> type1, SemanticType<T> type2)
        => type1.Value.CompareTo(type2.Value) < 0;

    public static bool operator <=(SemanticType<T> type1, SemanticType<T> type2)
        => type1.Value.CompareTo(type2.Value) <= 0;
}