using EngineeringUnits.Units;
using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits;

//This class is auto-generated, changes to the file will be overwritten!
public partial class MolarMass : BaseUnit
{
    public MolarMass() { }
    public MolarMass(decimal value, MolarMassUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public MolarMass(double value, MolarMassUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public MolarMass(int value, MolarMassUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public MolarMass(UnknownUnit value) : base(value) { }

    public static MolarMass From(double value, MolarMassUnit unit) => new(value, unit);

    [return: NotNullIfNotNull(nameof(value))]
    public static MolarMass? From(double? value, MolarMassUnit? unit)
    {
        if (value is null || unit is null)
            return null;

        return From((double)value, unit);
    }
    public double As(MolarMassUnit ReturnInThisUnit) => this.GetValueAsDouble(ReturnInThisUnit);
    public MolarMass ToUnit(MolarMassUnit selectedUnit) => new(this.GetValueAs(selectedUnit.Unit), selectedUnit);
    public static MolarMass Zero => new(0, MolarMassUnit.SI);
    public static MolarMass NaN => new(double.NaN, MolarMassUnit.SI);

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator MolarMass?(UnknownUnit? Unit)
    {
        if (Unit is null)
            return null;

        GuardAgainst.DifferentUnits(Unit, MolarMassUnit.SI);
        return new(Unit);
    }

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator UnknownUnit?(MolarMass? Unit)
    {
        if (Unit is null)
            return null;

        return new(Unit);
    }

    public override string? GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<MolarMassUnit>(_unit);
}
