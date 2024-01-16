
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    //This class is auto-generated, changes to the file will be overwritten!
    public partial class EnergyCost : BaseUnit
    {

        public EnergyCost() { }
        public EnergyCost(decimal value, EnergyCostUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public EnergyCost(double value, EnergyCostUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public EnergyCost(int value, EnergyCostUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public EnergyCost(UnknownUnit value) : base(value) { }

        public static EnergyCost From(double value, EnergyCostUnit unit) => new(value, unit);

        public static EnergyCost From(double? value, EnergyCostUnit unit)
        {
            if (value is null || unit is null)
            {
                return null;
            }

            return From((double)value, unit);
        }
        public double As(EnergyCostUnit ReturnInThisUnit) => this.GetValueAsDouble(ReturnInThisUnit);
        public EnergyCost ToUnit(EnergyCostUnit selectedUnit) => new(this.GetValueAs(selectedUnit.Unit), selectedUnit);
        public static EnergyCost Zero => new(0, EnergyCostUnit.SI);
        public static EnergyCost NaN => new(double.NaN, EnergyCostUnit.SI);

        public static implicit operator EnergyCost(UnknownUnit Unit)
        {
            if (Unit is null)
                return null; 

            GuardAgainst.DifferentUnits(Unit, EnergyCostUnit.SI);
            return new(Unit);        
        }

        public static implicit operator UnknownUnit(EnergyCost Unit)
        {            
            if (Unit is null)
                return null;

            return new(Unit);
        }

        public override string GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<EnergyCostUnit>(_unit);
        }
    }
