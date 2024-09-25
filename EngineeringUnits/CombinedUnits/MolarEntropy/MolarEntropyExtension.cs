using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits;

// This class is auto-generated, changes to the file will be overwritten!
public static class MolarEntropyUnitExtension
{

    public static MolarEntropy IfNullSetToZero(this MolarEntropy? local)
    {
        if (local is not null)
        {
            return local;
        }

        return MolarEntropy.Zero;
    }


    /// <summary>
    /// Returns the absolute value
    /// </summary>
    [return: NotNullIfNotNull(nameof(a))]
    public static MolarEntropy? Abs(this MolarEntropy? a)
    {
        if (a is null)
            return null;

        if (a.GetBaseValue() > 0)
            return a;

        return (-a)!;
    }

}               