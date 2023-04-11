namespace IegTools.SemanticTypes.Core;

using System;
using JetBrains.Annotations;

////public abstract record SemanticType<T>(T Value) where T : IComparable<T>, IEquatable<T>
////{
////    public static bool operator >(SemanticType<T> type1, SemanticType<T> type2)
////        => type1.Value.CompareTo(type2.Value) > 0;

////    public static bool operator >=(SemanticType<T> type1, SemanticType<T> type2)
////        => type1.Value.CompareTo(type2.Value) >= 0;


////    public static bool operator <(SemanticType<T> type1, SemanticType<T> type2)
////        => type1.Value.CompareTo(type2.Value) < 0;

////    public static bool operator <=(SemanticType<T> type1, SemanticType<T> type2)
////        => type1.Value.CompareTo(type2.Value) <= 0;
////}

public abstract class SemanticType<T> where T : IComparable<T>, IEquatable<T>
{
    protected SemanticType(T value) => Value = value;


    public T Value { get; protected init; }


    public override bool Equals(object obj) =>
        obj is SemanticType<T> other && other.Value.Equals(Value);

    public override int GetHashCode() => Value.GetHashCode();

    public override string ToString() => Value.ToString();



    public static bool operator >(SemanticType<T> type1, SemanticType<T> type2)
        => type1.Value.CompareTo(type2.Value) > 0;

    public static bool operator >=(SemanticType<T> type1, SemanticType<T> type2)
        => type1.Value.CompareTo(type2.Value) >= 0;


    public static bool operator <(SemanticType<T> type1, SemanticType<T> type2)
        => type1.Value.CompareTo(type2.Value) < 0;

    public static bool operator <=(SemanticType<T> type1, SemanticType<T> type2)
        => type1.Value.CompareTo(type2.Value) <= 0;


    public static bool operator ==([CanBeNull] SemanticType<T> type1, [CanBeNull] SemanticType<T> type2)
        => Equals(type1, type2);

    public static bool operator !=([CanBeNull] SemanticType<T> type1, [CanBeNull] SemanticType<T> type2)
        => !Equals(type1, type2);
}