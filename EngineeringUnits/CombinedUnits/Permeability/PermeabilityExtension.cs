using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits;

// This class is auto-generated, changes to the file will be overwritten!
public static class PermeabilityUnitExtension
{

    public static Permeability IfNullSetToZero(this Permeability? local)
    {
        if (local is not null)
        {
            return local;
        }

        return Permeability.Zero;
    }


    /// <summary>
    /// Returns the absolute value
    /// </summary>
    [return: NotNullIfNotNull(nameof(a))]
    public static Permeability? Abs(this Permeability? a)
    {
        if (a is null)
            return null;

        if (a.GetBaseValue() > 0)
            return a;

        return (-a)!;
    }

}               