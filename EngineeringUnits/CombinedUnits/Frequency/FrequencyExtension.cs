using System;
using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits;

// This class is auto-generated, changes to the file will be overwritten!
public static class FrequencyUnitExtension
{

    public static Frequency IfNullSetToZero(this Frequency? local)
    {
        if (local is not null)
        {
            return local;
        }

        return Frequency.Zero;
    }


    /// <summary>
    /// Returns the absolute value
    /// </summary>
    [return: NotNullIfNotNull(nameof(a))]
    public static Frequency? Abs(this Frequency? a)
    {
        if (a is null)
            return null;

        if (a.GetBaseValue() > 0)
            return a;

        return (-a)!;
    }

}               