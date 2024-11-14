using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits;

// This class is auto-generated, changes to the file will be overwritten!
public static class MolarMassUnitExtension
{

    public static MolarMass IfNullSetToZero(this MolarMass? local)
    {
        if (local is not null)
        {
            return local;
        }

        return MolarMass.Zero;
    }


    /// <summary>
    /// Returns the absolute value
    /// </summary>
    [return: NotNullIfNotNull(nameof(a))]
    public static MolarMass? Abs(this MolarMass? a)
    {
        if (a is null)
            return null;

        if (a.GetBaseValue() > 0)
            return a;

        return (-a)!;
    }

}               