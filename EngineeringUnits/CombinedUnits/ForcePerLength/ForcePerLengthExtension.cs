using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits;

// This class is auto-generated, changes to the file will be overwritten!
public static class ForcePerLengthUnitExtension
{

    public static ForcePerLength IfNullSetToZero(this ForcePerLength? local)
    {
        if (local is not null)
        {
            return local;
        }

        return ForcePerLength.Zero;
    }


    /// <summary>
    /// Returns the absolute value
    /// </summary>
    [return: NotNullIfNotNull(nameof(a))]
    public static ForcePerLength? Abs(this ForcePerLength? a)
    {
        if (a is null)
            return null;

        if (a.GetBaseValue() > 0)
            return a;

        return (-a)!;
    }

}               