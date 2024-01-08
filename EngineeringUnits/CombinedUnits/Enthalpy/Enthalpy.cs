
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    //This class is auto-generated, changes to the file will be overwritten!
    public partial class Enthalpy : BaseUnit
    {

        public Enthalpy() { }
        public Enthalpy(decimal value, EnthalpyUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Enthalpy(double value, EnthalpyUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Enthalpy(int value, EnthalpyUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Enthalpy(UnknownUnit value) : base(value) { }

        public static Enthalpy From(double value, EnthalpyUnit unit) => new(value, unit);

        public static Enthalpy From(double? value, EnthalpyUnit unit)
        {
            if (value is null || unit is null)
            {
                return null;
            }

            return From((double)value, unit);
        }
        public double As(EnthalpyUnit ReturnInThisUnit) => this.GetValueAsDouble(ReturnInThisUnit);
        public Enthalpy ToUnit(EnthalpyUnit selectedUnit) => new(this.GetValueAs(selectedUnit.Unit), selectedUnit);
        public static Enthalpy Zero => new(0, EnthalpyUnit.SI);
        public static Enthalpy NaN => new(double.NaN, EnthalpyUnit.SI);

        public static implicit operator Enthalpy(UnknownUnit Unit)
        {
            if (Unit is null)
                return null; 

            GuardAgainst.DifferentUnits(Unit, EnthalpyUnit.SI);
            return new(Unit);        
        }

        public static implicit operator UnknownUnit(Enthalpy Unit)
        {            
            if (Unit is null)
                return null;

            return new(Unit);
        }

        public override string GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<EnthalpyUnit>(_unit);
        }
    }
