using Classic = global::EngineeringUnits;

namespace EngineeringUnits.Fast.Bridge;

internal static class ClassicValue
{
    /// <summary>
    /// The SI value of an EngineeringUnits quantity, exactly as it holds it. Not <c>As(XUnit.SI)</c>: that goes through
    /// decimal, which keeps only 28 decimal places - 1 µg/day loses digits and 1e-30 m (from arithmetic) becomes 0.
    /// </summary>
    public static double SI(Classic.BaseUnit value, Classic.UnitTypebase siUnit) =>
        value.Unit.IsSIUnit()
            ? Classic.BaseUnitExtensions.As(value, value.Unit)                          // already SI: the stored value itself, bit for bit
            : Classic.BaseUnitExtensions.GetValueAs(value, siUnit.Unit).ToDouble();     // exact Fraction conversion, rounded once
}
