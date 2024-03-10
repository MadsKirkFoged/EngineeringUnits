
using EngineeringUnits.Units;

namespace EngineeringUnits;

//This class is auto-generated, changes to the file will be overwritten!
public partial class ThermalResistance : BaseUnit
{

    public ThermalResistance() { }
    public ThermalResistance(decimal value, ThermalResistanceUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public ThermalResistance(double value, ThermalResistanceUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public ThermalResistance(int value, ThermalResistanceUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public ThermalResistance(UnknownUnit value) : base(value) { }

    public static ThermalResistance From(double value, ThermalResistanceUnit unit) => new(value, unit);

    public static ThermalResistance From(double? value, ThermalResistanceUnit unit)
    {
        if (value is null || unit is null)
        {
            return null;
        }

        return From((double)value, unit);
    }
    public double As(ThermalResistanceUnit ReturnInThisUnit) => this.GetValueAsDouble(ReturnInThisUnit);
    public ThermalResistance ToUnit(ThermalResistanceUnit selectedUnit) => new(this.GetValueAs(selectedUnit.Unit), selectedUnit);
    public static ThermalResistance Zero => new(0, ThermalResistanceUnit.SI);
    public static ThermalResistance NaN => new(double.NaN, ThermalResistanceUnit.SI);

    public static implicit operator ThermalResistance(UnknownUnit Unit)
    {
        if (Unit is null)
            return null;

        GuardAgainst.DifferentUnits(Unit, ThermalResistanceUnit.SI);
        return new(Unit);
    }

    public static implicit operator UnknownUnit(ThermalResistance Unit)
    {
        if (Unit is null)
            return null;

        return new(Unit);
    }

    public override string GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<ThermalResistanceUnit>(_unit);
}
