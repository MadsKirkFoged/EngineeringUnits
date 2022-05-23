
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    //This class is auto-generated, changes to the file will be overwritten!
    public partial class Energy : BaseUnit
    {

        public Energy() { }
        public Energy(decimal value, EnergyUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Energy(double value, EnergyUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Energy(int value, EnergyUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Energy(UnknownUnit value) : base(value) { }

        public static Energy From(double value, EnergyUnit unit) => new(value, unit);

        public static Energy From(double? value, EnergyUnit unit)
        {
            if (value is null || unit is null)
            {
                return null;
            }

            return From((double)value, unit);
        }
        public double As(EnergyUnit ReturnInThisUnit) => GetValueAsDouble(ReturnInThisUnit.Unit);
        public Energy ToUnit(EnergyUnit selectedUnit) => new(GetValueAs(selectedUnit.Unit), selectedUnit);
        public static Energy Zero => new(0, EnergyUnit.SI);

        public static implicit operator Energy(UnknownUnit Unit)
        {
            UnitCheck(Unit, EnergyUnit.SI);
            return new(Unit);        
        }

        public static implicit operator Energy(int zero)
        {
            if (zero != 0)
                throw new WrongUnitException("You need to give it a unit unless you set it to 0(zero)!");
			return Zero;
		}
	public override string GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<EnergyUnit>(_unit);
	}
}

