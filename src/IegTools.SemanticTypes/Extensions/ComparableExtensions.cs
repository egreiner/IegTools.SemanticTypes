// ReSharper disable once CheckNamespace
namespace IegTools.SemanticTypes;

using System;

/// <summary>
/// Extensions für IComparable
/// </summary>
internal static class ComparableExtensions
{
    /// <summary>
    /// Gibt zurück ob sich Zahlen, Datum, strings, Typ muss IComparable implementieren in ihren Grenzen bewegen.
    /// </summary>
    /// <typeparam name="T">Der Objekttyp.</typeparam>
    /// <param name="value">The value.</param>
    /// <param name="min">The minimum.</param>
    /// <param name="max">The maximum.</param>
    public static bool IsInRange<T>(this T value, T min, T max) where T: IComparable, IComparable<T> =>
        value.CompareTo(min) >= 0 && value.CompareTo(max) <= 0;

    /// <summary>
    /// Limitiert Werte auf deren Unter- und Obergrenzen.
    /// </summary>
    /// <typeparam name="T">Der Objekttyp (muss IComparable sein).</typeparam>
    /// <param name="value">Der Wert der nicht außerhalb einer Unter- und Obergrenze liegen darf.</param>
    /// <param name="limits">Die Untergrenze / Obergrenze</param>
    /// <returns>Gibt den Wert zurück der zwischen der Unter- und Obergrenze liegen muss.</returns>
    public static T LimitTo<T>(this T value, (T Min, T Max) limits) where T : IComparable, IComparable<T> =>
        value.LimitToMin(limits.Min).LimitToMax(limits.Max);

    /// <summary>
    /// Limitiert Werte auf deren Unter- und Obergrenzen.
    /// </summary>
    /// <typeparam name="T">Der Objekttyp (muss IComparable sein).</typeparam>
    /// <param name="value">Der Wert der nicht außerhalb einer Unter- und Obergrenze liegen darf.</param>
    /// <param name="min">Die Untergrenze.</param>
    /// <param name="max">Die Obergrenze.</param>
    /// <returns>Gibt den Wert zurück der zwischen der Unter- und Obergrenze liegen muss.</returns>
    public static T LimitTo<T>(this T value, T min, T max) where T : IComparable, IComparable<T> =>
        value.LimitToMin(min).LimitToMax(max);

    /// <summary>
    /// Limitiert Werte auf ein Maximum.
    /// </summary>
    /// <typeparam name="T">Der Objekttyp (muss IComparable sein).</typeparam>
    /// <param name="value">Der Wert der eine Obergrenze nicht überschreiten darf.</param>
    /// <param name="max">Die Obergrenze.</param>
    /// <returns>Gibt den Wert zurück der nach oben begrenzt ist.</returns>
    public static T LimitToMax<T>(this T value, T max) where T: IComparable, IComparable<T> =>
        value.CompareTo(max) <= 0 ? value : max;

    /// <summary>
    /// Limitiert Werte auf ein Minimum.
    /// </summary>
    /// <typeparam name="T">Der Objekttyp (muss IComparable sein).</typeparam>
    /// <param name="value">Der Wert der eine Untergrenze nicht unterschreiten darf.</param>
    /// <param name="min">Die Untergrenze.</param>
    /// <returns>Gibt den Wert zurück der nach unten begrenzt ist.</returns>
    public static T LimitToMin<T>(this T value, T min) where T: IComparable, IComparable<T> =>
        value.CompareTo(min) >= 0 ? value : min;
}