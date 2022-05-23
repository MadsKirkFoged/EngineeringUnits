
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    //This class is auto-generated, changes to the file will be overwritten!
    public partial class ElectricCurrent : BaseUnit
    {

        public ElectricCurrent() { }
        public ElectricCurrent(decimal value, ElectricCurrentUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ElectricCurrent(double value, ElectricCurrentUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ElectricCurrent(int value, ElectricCurrentUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ElectricCurrent(UnknownUnit value) : base(value) { }

        public static ElectricCurrent From(double value, ElectricCurrentUnit unit) => new(value, unit);

        public static ElectricCurrent From(double? value, ElectricCurrentUnit unit)
        {
            if (value is null || unit is null)
            {
                return null;
            }

            return From((double)value, unit);
        }
        public double As(ElectricCurrentUnit ReturnInThisUnit) => GetValueAsDouble(ReturnInThisUnit.Unit);
        public ElectricCurrent ToUnit(ElectricCurrentUnit selectedUnit) => new(GetValueAs(selectedUnit.Unit), selectedUnit);
        public static ElectricCurrent Zero => new(0, ElectricCurrentUnit.SI);

        public static implicit operator ElectricCurrent(UnknownUnit Unit)
        {
            UnitCheck(Unit, ElectricCurrentUnit.SI);
            return new(Unit);        
        }

        public static implicit operator ElectricCurrent(int zero)
        {
            if (zero != 0)
                throw new WrongUnitException("You need to give it a unit unless you set it to 0(zero)!");
			return Zero;
		}
	public override string GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<ElectricCurrentUnit>(_unit);
	}
}

