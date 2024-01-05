
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    //This class is auto-generated, changes to the file will be overwritten!
    public partial class FuelEfficiency : BaseUnit
    {

        public FuelEfficiency() { }
        public FuelEfficiency(decimal value, FuelEfficiencyUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public FuelEfficiency(double value, FuelEfficiencyUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public FuelEfficiency(int value, FuelEfficiencyUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public FuelEfficiency(UnknownUnit value) : base(value) { }

        public static FuelEfficiency From(double value, FuelEfficiencyUnit unit) => new(value, unit);

        public static FuelEfficiency From(double? value, FuelEfficiencyUnit unit)
        {
            if (value is null || unit is null)
            {
                return null;
            }

            return From((double)value, unit);
        }
        public double As(FuelEfficiencyUnit ReturnInThisUnit) => this.GetValueAsDouble(ReturnInThisUnit);
        public FuelEfficiency ToUnit(FuelEfficiencyUnit selectedUnit) => new(this.GetValueAs(selectedUnit.Unit), selectedUnit);
        public static FuelEfficiency Zero => new(0, FuelEfficiencyUnit.SI);
        public static FuelEfficiency NaN => new(double.NaN, FuelEfficiencyUnit.SI);

        public static implicit operator FuelEfficiency(UnknownUnit Unit)
        {
            if (Unit is null)
                return null; 

            GuardAgainst.DifferentUnits(Unit, FuelEfficiencyUnit.SI);
            return new(Unit);        
        }

        public static implicit operator UnknownUnit(FuelEfficiency Unit)
        {
            return new(Unit);
        }

        public override string GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<FuelEfficiencyUnit>(_unit);
        }
    }
