
using EngineeringUnits.Units;

namespace EngineeringUnits;

//This class is auto-generated, changes to the file will be overwritten!
public partial class ForcePerLength : BaseUnit
{

    public ForcePerLength() { }
    public ForcePerLength(decimal value, ForcePerLengthUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public ForcePerLength(double value, ForcePerLengthUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public ForcePerLength(int value, ForcePerLengthUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public ForcePerLength(UnknownUnit value) : base(value) { }

    public static ForcePerLength From(double value, ForcePerLengthUnit unit) => new(value, unit);

    public static ForcePerLength From(double? value, ForcePerLengthUnit unit)
    {
        if (value is null || unit is null)
        {
            return null;
        }

        return From((double)value, unit);
    }
    public double As(ForcePerLengthUnit ReturnInThisUnit) => this.GetValueAsDouble(ReturnInThisUnit);
    public ForcePerLength ToUnit(ForcePerLengthUnit selectedUnit) => new(this.GetValueAs(selectedUnit.Unit), selectedUnit);
    public static ForcePerLength Zero => new(0, ForcePerLengthUnit.SI);
    public static ForcePerLength NaN => new(double.NaN, ForcePerLengthUnit.SI);

    public static implicit operator ForcePerLength(UnknownUnit Unit)
    {
        if (Unit is null)
            return null;

        GuardAgainst.DifferentUnits(Unit, ForcePerLengthUnit.SI);
        return new(Unit);
    }

    public static implicit operator UnknownUnit(ForcePerLength Unit)
    {
        if (Unit is null)
            return null;

        return new(Unit);
    }

    public override string GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<ForcePerLengthUnit>(_unit);
}
