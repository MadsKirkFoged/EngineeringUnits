using System;
using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits;

// This class is auto-generated, changes to the file will be overwritten!
public static class EntropyUnitExtension
{

    public static Entropy IfNullSetToZero(this Entropy? local)
    {
        if (local is not null)
        {
            return local;
        }

        return Entropy.Zero;
    }


    /// <summary>
    /// Returns the absolute value
    /// </summary>
    [return: NotNullIfNotNull(nameof(a))]
    public static Entropy? Abs(this Entropy? a)
    {
        if (a is null)
            return null;

        if (a.GetBaseValue() > 0)
            return a;

        return (-a)!;
    }

}               