using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits;

// This class is auto-generated, changes to the file will be overwritten!
public static class VolumeFlowUnitExtension
{

    public static VolumeFlow IfNullSetToZero(this VolumeFlow? local)
    {
        if (local is not null)
        {
            return local;
        }

        return VolumeFlow.Zero;
    }


    /// <summary>
    /// Returns the absolute value
    /// </summary>
    [return: NotNullIfNotNull(nameof(a))]
    public static VolumeFlow? Abs(this VolumeFlow? a)
    {
        if (a is null)
            return null;

        if (a.GetBaseValue() > 0)
            return a;

        return (-a)!;
    }

}               