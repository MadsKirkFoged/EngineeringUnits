
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    //This class is auto-generated, changes to the file will be overwritten!
    public partial class SpecificHeatCapacity : BaseUnit
    {

        public SpecificHeatCapacity() { }
        public SpecificHeatCapacity(decimal value, SpecificHeatCapacityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public SpecificHeatCapacity(double value, SpecificHeatCapacityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public SpecificHeatCapacity(int value, SpecificHeatCapacityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public SpecificHeatCapacity(UnknownUnit value) : base(value) { }

        public static SpecificHeatCapacity From(double value, SpecificHeatCapacityUnit unit) => new(value, unit);

        public static SpecificHeatCapacity From(double? value, SpecificHeatCapacityUnit unit)
        {
            if (value is null || unit is null)
            {
                return null;
            }

            return From((double)value, unit);
        }
        public double As(SpecificHeatCapacityUnit ReturnInThisUnit) => GetValueAsDouble(ReturnInThisUnit.Unit);
        public SpecificHeatCapacity ToUnit(SpecificHeatCapacityUnit selectedUnit) => new(GetValueAs(selectedUnit.Unit), selectedUnit);
        public static SpecificHeatCapacity Zero => new(0, SpecificHeatCapacityUnit.SI);

        public static implicit operator SpecificHeatCapacity(UnknownUnit Unit)
        {
            if (Unit is null)
                return null; 

            Unit.UnitCheck(SpecificHeatCapacityUnit.SI);
            return new(Unit);        
        }

        public static implicit operator SpecificHeatCapacity(int zero)
        {
            if (zero != 0)
                throw new WrongUnitException("You need to give it a unit unless you set it to 0(zero)!");
			return Zero;
		}
	public override string GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<SpecificHeatCapacityUnit>(_unit);
	}
}

