
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    //This class is auto-generated, changes to the file will be overwritten!
    public partial class ElectricCurrentDensity : BaseUnit
    {

        public ElectricCurrentDensity() { }
        public ElectricCurrentDensity(decimal value, ElectricCurrentDensityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ElectricCurrentDensity(double value, ElectricCurrentDensityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ElectricCurrentDensity(int value, ElectricCurrentDensityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ElectricCurrentDensity(UnknownUnit value) : base(value) { }

        public static ElectricCurrentDensity From(double value, ElectricCurrentDensityUnit unit) => new(value, unit);

        public static ElectricCurrentDensity From(double? value, ElectricCurrentDensityUnit unit)
        {
            if (value is null || unit is null)
            {
                return null;
            }

            return From((double)value, unit);
        }
        public double As(ElectricCurrentDensityUnit ReturnInThisUnit) => GetValueAsDouble(ReturnInThisUnit);
        public ElectricCurrentDensity ToUnit(ElectricCurrentDensityUnit selectedUnit) => new(GetValueAs(selectedUnit.Unit), selectedUnit);
        public static ElectricCurrentDensity Zero => new(0, ElectricCurrentDensityUnit.SI);
        public static ElectricCurrentDensity NaN => new(double.NaN, ElectricCurrentDensityUnit.SI);

        public static implicit operator ElectricCurrentDensity(UnknownUnit Unit)
        {
            if (Unit is null)
                return null; 

            Unit.UnitCheck(ElectricCurrentDensityUnit.SI);
            return new(Unit);        
        }

        public static implicit operator ElectricCurrentDensity(int zero)
        {
            if (zero != 0)
                throw new WrongUnitException("You need to give it a unit unless you set it to 0(zero)!");
			return Zero;
		}
	public override string GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<ElectricCurrentDensityUnit>(_unit);
	}
}

