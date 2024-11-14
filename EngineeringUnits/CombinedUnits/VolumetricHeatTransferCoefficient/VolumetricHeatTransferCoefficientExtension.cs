using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits;

// This class is auto-generated, changes to the file will be overwritten!
public static class VolumetricHeatTransferCoefficientUnitExtension
{

    public static VolumetricHeatTransferCoefficient IfNullSetToZero(this VolumetricHeatTransferCoefficient? local)
    {
        if (local is not null)
        {
            return local;
        }

        return VolumetricHeatTransferCoefficient.Zero;
    }


    /// <summary>
    /// Returns the absolute value
    /// </summary>
    [return: NotNullIfNotNull(nameof(a))]
    public static VolumetricHeatTransferCoefficient? Abs(this VolumetricHeatTransferCoefficient? a)
    {
        if (a is null)
            return null;

        if (a.GetBaseValue() > 0)
            return a;

        return (-a)!;
    }

}               