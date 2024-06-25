using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits;
public static class AngleMath
{

    [return: NotNullIfNotNull(nameof(a))]
    public static double? Sin(this Angle? a)
    {
        if (a is null)
            return null;

        return System.Math.Sin(a.Radian);
    }

    [return: NotNullIfNotNull(nameof(a))]
    public static double? Cos(this Angle? a)
    {
        if (a is null)
            return null;

        return System.Math.Cos(a.Radian);
    }

    [return: NotNullIfNotNull(nameof(a))]
    public static double? Tan(this Angle? a)
    {
        if (a is null)
            return null;

        return System.Math.Tan(a.Radian);
    }

    [return: NotNullIfNotNull(nameof(a))]
    public static double? Sinh(this Angle? a)
    {
        if (a is null)
            return null;

        return System.Math.Sinh(a.Radian);
    }

    [return: NotNullIfNotNull(nameof(a))]
    public static double? Cosh(this Angle? a)
    {
        if (a is null)
            return null;

        return System.Math.Cosh(a.Radian);
    }

    [return: NotNullIfNotNull(nameof(a))]
    public static double? Tanh(this Angle? a)
    {
        if (a is null)
            return null;

        return System.Math.Tanh(a.Radian);
    }

    [return: NotNullIfNotNull(nameof(s))]
    public static Angle? Asin(this double? s)
    {
        if (s is null)
            return null;

        return Angle.FromRadian(System.Math.Asin((double)s));
    }

    [return: NotNullIfNotNull(nameof(c))]
    public static Angle? Acos(this double? c)
    {
        if (c is null)
            return null;

        return Angle.FromRadian(System.Math.Acos((double)c));
    }

    [return: NotNullIfNotNull(nameof(t))]
    public static Angle? Atan(this double? t)
    {
        if (t is null)
            return null;

        return Angle.FromRadian(System.Math.Atan((double)t));
    }

#if NET // NOTE: some System.Math methods are not available for .NET Standard
    [return: NotNullIfNotNull(nameof(s))]
    public static Angle? Asinh(this double? s)
    {
        if (s is null)
            return null;

        return Angle.FromRadian(System.Math.Asinh((double)s));
    }

    [return: NotNullIfNotNull(nameof(c))]
    public static Angle? Acosh(this double? c)
    {
        if (c is null)
            return null;

        return Angle.FromRadian(System.Math.Acosh((double)c));
    }

    [return: NotNullIfNotNull(nameof(t))]
    public static Angle? Atanh(this double? t)
    {
        if (t is null)
            return null;

        return Angle.FromRadian(System.Math.Atanh((double)t));
    }
#endif
}
