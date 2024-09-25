using System;
using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits;

// This class is auto-generated, changes to the file will be overwritten!
public static class MassFlowUnitExtension
{

    public static MassFlow IfNullSetToZero(this MassFlow? local)
    {
        if (local is not null)
        {
            return local;
        }

        return MassFlow.Zero;
    }


    /// <summary>
    /// Returns the absolute value
    /// </summary>
    [return: NotNullIfNotNull(nameof(a))]
    public static MassFlow? Abs(this MassFlow? a)
    {
        if (a is null)
            return null;

        if (a.GetBaseValue() > 0)
            return a;

        return (-a)!;
    }

}               