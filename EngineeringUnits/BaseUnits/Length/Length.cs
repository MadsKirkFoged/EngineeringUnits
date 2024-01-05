
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    //This class is auto-generated, changes to the file will be overwritten!
    public partial class Length : BaseUnit
    {

        public Length() { }
        public Length(decimal value, LengthUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Length(double value, LengthUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Length(int value, LengthUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Length(UnknownUnit value) : base(value) { }

        public static Length From(double value, LengthUnit unit) => new(value, unit);

        public static Length From(double? value, LengthUnit unit)
        {
            if (value is null || unit is null)
            {
                return null;
            }

            return From((double)value, unit);
        }
        public double As(LengthUnit ReturnInThisUnit) => this.GetValueAsDouble(ReturnInThisUnit);
        public Length ToUnit(LengthUnit selectedUnit) => new(this.GetValueAs(selectedUnit.Unit), selectedUnit);
        public static Length Zero => new(0, LengthUnit.SI);
        public static Length NaN => new(double.NaN, LengthUnit.SI);

        public static implicit operator Length(UnknownUnit Unit)
        {
            if (Unit is null)
                return null; 

            GuardAgainst.DifferentUnits(Unit, LengthUnit.SI);
            return new(Unit);        
        }

        public static implicit operator UnknownUnit(Length Unit)
        {
            return new(Unit);
        }

        public override string GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<LengthUnit>(_unit);
        }
    }
