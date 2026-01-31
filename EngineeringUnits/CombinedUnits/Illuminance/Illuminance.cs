using EngineeringUnits.Units;
using System.Diagnostics.CodeAnalysis;
using Fractions;

namespace EngineeringUnits;

// This class is auto-generated, changes to the file will be overwritten!
[UnitDimension(BaseunitType.time, 0, BaseunitType.length, -2, BaseunitType.mass, 0, BaseunitType.electricCurrent, 0, BaseunitType.temperature, 0, BaseunitType.amountOfSubstance, 0, BaseunitType.luminousIntensity, 1, BaseunitType.Cost, 0)]
public partial class Illuminance : BaseUnit
{
    public Illuminance() { }
    public Illuminance(Fraction value, IlluminanceUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public Illuminance(decimal value, IlluminanceUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public Illuminance(double value, IlluminanceUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public Illuminance(int value, IlluminanceUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public Illuminance(UnknownUnit value) : base(value) { }

    public static Illuminance From(double value, IlluminanceUnit unit) => new(value, unit);

    [return: NotNullIfNotNull(nameof(value))]
    public static Illuminance? From(double? value, IlluminanceUnit? unit)
    {
        if (value is null || unit is null)
            return null;

        return From((double)value, unit);
    }
    public double As(IlluminanceUnit ReturnInThisUnit) => this.GetValueAsDouble(ReturnInThisUnit);
    public Illuminance ToUnit(IlluminanceUnit selectedUnit) => new(this.GetValueAs(selectedUnit.Unit), selectedUnit);
    public static Illuminance Zero => new(0, IlluminanceUnit.SI);
    public static Illuminance NaN => new(double.NaN, IlluminanceUnit.SI);

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator Illuminance?(UnknownUnit? Unit)
    {
        if (Unit is null)
            return null;

        GuardAgainst.DifferentUnits(Unit, IlluminanceUnit.SI);
        return new(Unit);
    }

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator UnknownUnit?(Illuminance? Unit)
    {
        if (Unit is null)
            return null;

        return new(Unit);
    }

    public override string? GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<IlluminanceUnit>(_unit);
}
