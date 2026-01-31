using EngineeringUnits.Units;
using System.Diagnostics.CodeAnalysis;
using Fractions;

namespace EngineeringUnits;

// This class is auto-generated, changes to the file will be overwritten!
[UnitDimension(BaseunitType.time, -3, BaseunitType.length, 1, BaseunitType.mass, 1, BaseunitType.electricCurrent, 0, BaseunitType.temperature, -1, BaseunitType.amountOfSubstance, 0, BaseunitType.luminousIntensity, 0, BaseunitType.Cost, 0)]
public partial class ThermalConductivity : BaseUnit
{
    public ThermalConductivity() { }
    public ThermalConductivity(Fraction value, ThermalConductivityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public ThermalConductivity(decimal value, ThermalConductivityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public ThermalConductivity(double value, ThermalConductivityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public ThermalConductivity(int value, ThermalConductivityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public ThermalConductivity(UnknownUnit value) : base(value) { }

    public static ThermalConductivity From(double value, ThermalConductivityUnit unit) => new(value, unit);

    [return: NotNullIfNotNull(nameof(value))]
    public static ThermalConductivity? From(double? value, ThermalConductivityUnit? unit)
    {
        if (value is null || unit is null)
            return null;

        return From((double)value, unit);
    }
    public double As(ThermalConductivityUnit ReturnInThisUnit) => this.GetValueAsDouble(ReturnInThisUnit);
    public ThermalConductivity ToUnit(ThermalConductivityUnit selectedUnit) => new(this.GetValueAs(selectedUnit.Unit), selectedUnit);
    public static ThermalConductivity Zero => new(0, ThermalConductivityUnit.SI);
    public static ThermalConductivity NaN => new(double.NaN, ThermalConductivityUnit.SI);

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator ThermalConductivity?(UnknownUnit? Unit)
    {
        if (Unit is null)
            return null;

        GuardAgainst.DifferentUnits(Unit, ThermalConductivityUnit.SI);
        return new(Unit);
    }

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator UnknownUnit?(ThermalConductivity? Unit)
    {
        if (Unit is null)
            return null;

        return new(Unit);
    }

    public override string? GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<ThermalConductivityUnit>(_unit);
}
