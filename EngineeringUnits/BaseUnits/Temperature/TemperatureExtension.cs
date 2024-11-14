using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits;

// This class is auto-generated, changes to the file will be overwritten!
public static class TemperatureUnitExtension
{

    public static Temperature IfNullSetToZero(this Temperature? local)
    {
        if (local is not null)
        {
            return local;
        }

        return Temperature.Zero;
    }


    /// <summary>
    /// Returns the absolute value
    /// </summary>
    [return: NotNullIfNotNull(nameof(a))]
    public static Temperature? Abs(this Temperature? a)
    {
        if (a is null)
            return null;

        if (a.GetBaseValue() > 0)
            return a;

        return (-a)!;
    }

}               