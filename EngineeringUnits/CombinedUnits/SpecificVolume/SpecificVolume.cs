using EngineeringUnits.Units;
using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits;

// This class is auto-generated, changes to the file will be overwritten!
[UnitDimension(BaseunitType.time, 0, BaseunitType.length, 3, BaseunitType.mass, -1, BaseunitType.electricCurrent, 0, BaseunitType.temperature, 0, BaseunitType.amountOfSubstance, 0, BaseunitType.luminousIntensity, 0, BaseunitType.Cost, 0)]
public partial class SpecificVolume : BaseUnit
{
    public SpecificVolume() { }
    public SpecificVolume(decimal value, SpecificVolumeUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public SpecificVolume(double value, SpecificVolumeUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public SpecificVolume(int value, SpecificVolumeUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public SpecificVolume(UnknownUnit value) : base(value) { }

    public static SpecificVolume From(double value, SpecificVolumeUnit unit) => new(value, unit);

    [return: NotNullIfNotNull(nameof(value))]
    public static SpecificVolume? From(double? value, SpecificVolumeUnit? unit)
    {
        if (value is null || unit is null)
            return null;

        return From((double)value, unit);
    }
    public double As(SpecificVolumeUnit ReturnInThisUnit) => this.GetValueAsDouble(ReturnInThisUnit);
    public SpecificVolume ToUnit(SpecificVolumeUnit selectedUnit) => new(this.GetValueAs(selectedUnit.Unit), selectedUnit);
    public static SpecificVolume Zero => new(0, SpecificVolumeUnit.SI);
    public static SpecificVolume NaN => new(double.NaN, SpecificVolumeUnit.SI);

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator SpecificVolume?(UnknownUnit? Unit)
    {
        if (Unit is null)
            return null;

        GuardAgainst.DifferentUnits(Unit, SpecificVolumeUnit.SI);
        return new(Unit);
    }

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator UnknownUnit?(SpecificVolume? Unit)
    {
        if (Unit is null)
            return null;

        return new(Unit);
    }

    public override string? GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<SpecificVolumeUnit>(_unit);
}
