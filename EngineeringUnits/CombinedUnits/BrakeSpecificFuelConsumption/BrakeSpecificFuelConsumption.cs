
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    //This class is auto-generated, changes to the file will be overwritten!
    public partial class BrakeSpecificFuelConsumption : BaseUnit
    {

        public BrakeSpecificFuelConsumption() { }
        public BrakeSpecificFuelConsumption(decimal value, BrakeSpecificFuelConsumptionUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public BrakeSpecificFuelConsumption(double value, BrakeSpecificFuelConsumptionUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public BrakeSpecificFuelConsumption(int value, BrakeSpecificFuelConsumptionUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public BrakeSpecificFuelConsumption(UnknownUnit value) : base(value) { }

        public static BrakeSpecificFuelConsumption From(double value, BrakeSpecificFuelConsumptionUnit unit) => new(value, unit);

        public static BrakeSpecificFuelConsumption From(double? value, BrakeSpecificFuelConsumptionUnit unit)
        {
            if (value is null || unit is null)
            {
                return null;
            }

            return From((double)value, unit);
        }
        public double As(BrakeSpecificFuelConsumptionUnit ReturnInThisUnit) => this.GetValueAsDouble(ReturnInThisUnit);
        public BrakeSpecificFuelConsumption ToUnit(BrakeSpecificFuelConsumptionUnit selectedUnit) => new(this.GetValueAs(selectedUnit.Unit), selectedUnit);
        public static BrakeSpecificFuelConsumption Zero => new(0, BrakeSpecificFuelConsumptionUnit.SI);
        public static BrakeSpecificFuelConsumption NaN => new(double.NaN, BrakeSpecificFuelConsumptionUnit.SI);

        public static implicit operator BrakeSpecificFuelConsumption(UnknownUnit Unit)
        {
            if (Unit is null)
                return null; 

            GuardAgainst.DifferentUnits(Unit, BrakeSpecificFuelConsumptionUnit.SI);
            return new(Unit);        
        }

        public static implicit operator UnknownUnit(BrakeSpecificFuelConsumption Unit)
        {
            return new(Unit);
        }

        public override string GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<BrakeSpecificFuelConsumptionUnit>(_unit);
        }
    }
