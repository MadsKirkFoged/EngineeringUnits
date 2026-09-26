using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits;

// This class is auto-generated, changes to the file will be overwritten!
public static class VolumetricHeatCapacityUnitExtension
{

    public static VolumetricHeatCapacity IfNullSetToZero(this VolumetricHeatCapacity? local)
    {
        if (local is not null)
        {
            return local;
        }

        return VolumetricHeatCapacity.Zero;
    }


    /// <summary>
    /// Returns the absolute value
    /// </summary>
    [return: NotNullIfNotNull(nameof(a))]
    public static VolumetricHeatCapacity? Abs(this VolumetricHeatCapacity? a)
    {
        if (a is null)
            return null;

        if (a.GetBaseValue() > 0)
            return a;

        return (-a)!;
    }

}
