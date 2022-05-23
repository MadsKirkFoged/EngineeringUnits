
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    //This class is auto-generated, changes to the file will be overwritten!
    public partial class ElectricSurfaceChargeDensity : BaseUnit
    {

        public ElectricSurfaceChargeDensity() { }
        public ElectricSurfaceChargeDensity(decimal value, ElectricSurfaceChargeDensityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ElectricSurfaceChargeDensity(double value, ElectricSurfaceChargeDensityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ElectricSurfaceChargeDensity(int value, ElectricSurfaceChargeDensityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ElectricSurfaceChargeDensity(UnknownUnit value) : base(value) { }

        public static ElectricSurfaceChargeDensity From(double value, ElectricSurfaceChargeDensityUnit unit) => new(value, unit);

        public static ElectricSurfaceChargeDensity From(double? value, ElectricSurfaceChargeDensityUnit unit)
        {
            if (value is null || unit is null)
            {
                return null;
            }

            return From((double)value, unit);
        }
        public double As(ElectricSurfaceChargeDensityUnit ReturnInThisUnit) => GetValueAsDouble(ReturnInThisUnit.Unit);
        public ElectricSurfaceChargeDensity ToUnit(ElectricSurfaceChargeDensityUnit selectedUnit) => new(GetValueAs(selectedUnit.Unit), selectedUnit);
        public static ElectricSurfaceChargeDensity Zero => new(0, ElectricSurfaceChargeDensityUnit.SI);

        public static implicit operator ElectricSurfaceChargeDensity(UnknownUnit Unit)
        {
            UnitCheck(Unit, ElectricSurfaceChargeDensityUnit.SI);
            return new(Unit);        
        }

        public static implicit operator ElectricSurfaceChargeDensity(int zero)
        {
            if (zero != 0)
                throw new WrongUnitException("You need to give it a unit unless you set it to 0(zero)!");
			return Zero;
		}
	public override string GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<ElectricSurfaceChargeDensityUnit>(_unit);
	}
}

