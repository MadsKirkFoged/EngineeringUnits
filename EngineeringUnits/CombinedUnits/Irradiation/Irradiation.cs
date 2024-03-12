using EngineeringUnits.Units;

namespace EngineeringUnits;

//This class is auto-generated, changes to the file will be overwritten!
public partial class Irradiation : BaseUnit
{
    public Irradiation() { }
    public Irradiation(decimal value, IrradiationUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public Irradiation(double value, IrradiationUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public Irradiation(int value, IrradiationUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public Irradiation(UnknownUnit value) : base(value) { }

    public static Irradiation From(double value, IrradiationUnit unit) => new(value, unit);

    public static Irradiation? From(double? value, IrradiationUnit? unit)
    {
        if (value is null || unit is null)
        {
            return null;
        }

        return From((double)value, unit);
    }
    public double As(IrradiationUnit ReturnInThisUnit) => this.GetValueAsDouble(ReturnInThisUnit);
    public Irradiation ToUnit(IrradiationUnit selectedUnit) => new(this.GetValueAs(selectedUnit.Unit), selectedUnit);
    public static Irradiation Zero => new(0, IrradiationUnit.SI);
    public static Irradiation NaN => new(double.NaN, IrradiationUnit.SI);

    public static implicit operator Irradiation?(UnknownUnit? Unit)
    {
        if (Unit is null)
            return null;

        GuardAgainst.DifferentUnits(Unit, IrradiationUnit.SI);
        return new(Unit);
    }

    public static implicit operator UnknownUnit?(Irradiation? Unit)
    {
        if (Unit is null)
            return null;

        return new(Unit);
    }

    public override string? GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<IrradiationUnit>(_unit);
}
