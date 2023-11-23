
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    //This class is auto-generated, changes to the file will be overwritten!
    public partial class ElectricChargeDensity : BaseUnit
    {

        public ElectricChargeDensity() { }
        public ElectricChargeDensity(decimal value, ElectricChargeDensityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ElectricChargeDensity(double value, ElectricChargeDensityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ElectricChargeDensity(int value, ElectricChargeDensityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ElectricChargeDensity(UnknownUnit value) : base(value) { }

        public static ElectricChargeDensity From(double value, ElectricChargeDensityUnit unit) => new(value, unit);

        public static ElectricChargeDensity From(double? value, ElectricChargeDensityUnit unit)
        {
            if (value is null || unit is null)
            {
                return null;
            }

            return From((double)value, unit);
        }
        public double As(ElectricChargeDensityUnit ReturnInThisUnit) => GetValueAsDouble(ReturnInThisUnit.Unit);
        public ElectricChargeDensity ToUnit(ElectricChargeDensityUnit selectedUnit) => new(GetValueAs(selectedUnit.Unit), selectedUnit);
        public static ElectricChargeDensity Zero => new(0, ElectricChargeDensityUnit.SI);
        public static ElectricChargeDensity NaN => new(double.NaN, ElectricChargeDensityUnit.SI);

        public static implicit operator ElectricChargeDensity(UnknownUnit Unit)
        {
            if (Unit is null)
                return null; 

            Unit.UnitCheck(ElectricChargeDensityUnit.SI);
            return new(Unit);        
        }

        public static implicit operator ElectricChargeDensity(int zero)
        {
            if (zero != 0)
                throw new WrongUnitException("You need to give it a unit unless you set it to 0(zero)!");
			return Zero;
		}
	public override string GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<ElectricChargeDensityUnit>(_unit);
	}
}

