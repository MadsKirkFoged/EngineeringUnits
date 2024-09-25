using System;
using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits;

// This class is auto-generated, changes to the file will be overwritten!
public static class MolarFlowUnitExtension
{

    public static MolarFlow IfNullSetToZero(this MolarFlow? local)
    {
        if (local is not null)
        {
            return local;
        }

        return MolarFlow.Zero;
    }


    /// <summary>
    /// Returns the absolute value
    /// </summary>
    [return: NotNullIfNotNull(nameof(a))]
    public static MolarFlow? Abs(this MolarFlow? a)
    {
        if (a is null)
            return null;

        if (a.GetBaseValue() > 0)
            return a;

        return (-a)!;
    }

}               