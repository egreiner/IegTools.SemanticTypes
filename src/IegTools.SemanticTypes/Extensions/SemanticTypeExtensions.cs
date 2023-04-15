// ReSharper disable once CheckNamespace
namespace IegTools.SemanticTypes;

using JetBrains.Annotations;
using System;

/// <summary>
/// Extension methods for SemanticTypes
/// </summary>
public static class SemanticTypeExtensions
{
    /// <summary>
    /// Returns the value of the SemanticType or the default value of the type
    /// </summary>
    /// <param name="type">The semantic type</param>
    /// <typeparam name="T">The Value-type of the semantic type</typeparam>
    /// <returns></returns>
    public static T GetValueOrDefault<T>([CanBeNull] this SemanticType<T> type)
        where T : IComparable<T>, IEquatable<T> =>
        type == null ? default : type.Value;
}