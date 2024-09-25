using System;
using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits;

// This class is auto-generated, changes to the file will be overwritten!
public static class IrradiationUnitExtension
{

    public static Irradiation IfNullSetToZero(this Irradiation? local)
    {
        if (local is not null)
        {
            return local;
        }

        return Irradiation.Zero;
    }


    /// <summary>
    /// Returns the absolute value
    /// </summary>
    [return: NotNullIfNotNull(nameof(a))]
    public static Irradiation? Abs(this Irradiation? a)
    {
        if (a is null)
            return null;

        if (a.GetBaseValue() > 0)
            return a;

        return (-a)!;
    }

}               