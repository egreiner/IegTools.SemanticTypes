// ReSharper disable once CheckNamespace
namespace IegTools.SemanticTypes;

using Core;
using JetBrains.Annotations;
using System;

public static class SemanticTypeExtensions
{
    public static T GetValueOrDefault<T>([CanBeNull] this SemanticType<T> type)
        where T : IComparable<T>, IEquatable<T> =>
        type == null ? default : type.Value;
}