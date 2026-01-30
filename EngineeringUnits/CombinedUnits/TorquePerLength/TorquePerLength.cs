using EngineeringUnits.Units;
using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits;

// This class is auto-generated, changes to the file will be overwritten!
[UnitDimension(BaseunitType.time, -2, BaseunitType.length, 1, BaseunitType.mass, 1, BaseunitType.electricCurrent, 0, BaseunitType.temperature, 0, BaseunitType.amountOfSubstance, 0, BaseunitType.luminousIntensity, 0, BaseunitType.Cost, 0)]
public partial class TorquePerLength : BaseUnit
{
    public TorquePerLength() { }
    public TorquePerLength(decimal value, TorquePerLengthUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public TorquePerLength(double value, TorquePerLengthUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public TorquePerLength(int value, TorquePerLengthUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public TorquePerLength(UnknownUnit value) : base(value) { }

    public static TorquePerLength From(double value, TorquePerLengthUnit unit) => new(value, unit);

    [return: NotNullIfNotNull(nameof(value))]
    public static TorquePerLength? From(double? value, TorquePerLengthUnit? unit)
    {
        if (value is null || unit is null)
            return null;

        return From((double)value, unit);
    }
    public double As(TorquePerLengthUnit ReturnInThisUnit) => this.GetValueAsDouble(ReturnInThisUnit);
    public TorquePerLength ToUnit(TorquePerLengthUnit selectedUnit) => new(this.GetValueAs(selectedUnit.Unit), selectedUnit);
    public static TorquePerLength Zero => new(0, TorquePerLengthUnit.SI);
    public static TorquePerLength NaN => new(double.NaN, TorquePerLengthUnit.SI);

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator TorquePerLength?(UnknownUnit? Unit)
    {
        if (Unit is null)
            return null;

        GuardAgainst.DifferentUnits(Unit, TorquePerLengthUnit.SI);
        return new(Unit);
    }

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator UnknownUnit?(TorquePerLength? Unit)
    {
        if (Unit is null)
            return null;

        return new(Unit);
    }

    public override string? GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<TorquePerLengthUnit>(_unit);
}
