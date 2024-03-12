using EngineeringUnits.Units;

namespace EngineeringUnits;

//This class is auto-generated, changes to the file will be overwritten!
public partial class Permeability : BaseUnit
{
    public Permeability() { }
    public Permeability(decimal value, PermeabilityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public Permeability(double value, PermeabilityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public Permeability(int value, PermeabilityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public Permeability(UnknownUnit value) : base(value) { }

    public static Permeability From(double value, PermeabilityUnit unit) => new(value, unit);

    public static Permeability? From(double? value, PermeabilityUnit? unit)
    {
        if (value is null || unit is null)
        {
            return null;
        }

        return From((double)value, unit);
    }
    public double As(PermeabilityUnit ReturnInThisUnit) => this.GetValueAsDouble(ReturnInThisUnit);
    public Permeability ToUnit(PermeabilityUnit selectedUnit) => new(this.GetValueAs(selectedUnit.Unit), selectedUnit);
    public static Permeability Zero => new(0, PermeabilityUnit.SI);
    public static Permeability NaN => new(double.NaN, PermeabilityUnit.SI);

    public static implicit operator Permeability?(UnknownUnit? Unit)
    {
        if (Unit is null)
            return null;

        GuardAgainst.DifferentUnits(Unit, PermeabilityUnit.SI);
        return new(Unit);
    }

    public static implicit operator UnknownUnit?(Permeability? Unit)
    {
        if (Unit is null)
            return null;

        return new(Unit);
    }

    public override string? GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<PermeabilityUnit>(_unit);
}
