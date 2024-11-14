using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits;

// This class is auto-generated, changes to the file will be overwritten!
public static class TorquePerLengthUnitExtension
{

    public static TorquePerLength IfNullSetToZero(this TorquePerLength? local)
    {
        if (local is not null)
        {
            return local;
        }

        return TorquePerLength.Zero;
    }


    /// <summary>
    /// Returns the absolute value
    /// </summary>
    [return: NotNullIfNotNull(nameof(a))]
    public static TorquePerLength? Abs(this TorquePerLength? a)
    {
        if (a is null)
            return null;

        if (a.GetBaseValue() > 0)
            return a;

        return (-a)!;
    }

}               