
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    //This class is auto-generated, changes to the file will be overwritten!
    public partial class LuminousIntensity : BaseUnit
    {

        public LuminousIntensity() { }
        public LuminousIntensity(decimal value, LuminousIntensityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public LuminousIntensity(double value, LuminousIntensityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public LuminousIntensity(int value, LuminousIntensityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public LuminousIntensity(UnknownUnit value) : base(value) { }

        public static LuminousIntensity From(double value, LuminousIntensityUnit unit) => new(value, unit);

        public static LuminousIntensity From(double? value, LuminousIntensityUnit unit)
        {
            if (value is null || unit is null)
            {
                return null;
            }

            return From((double)value, unit);
        }
        public double As(LuminousIntensityUnit ReturnInThisUnit) => GetValueAsDouble(ReturnInThisUnit.Unit);
        public LuminousIntensity ToUnit(LuminousIntensityUnit selectedUnit) => new(GetValueAs(selectedUnit.Unit), selectedUnit);
        public static LuminousIntensity Zero => new(0, LuminousIntensityUnit.SI);

        public static implicit operator LuminousIntensity(UnknownUnit Unit)
        {
            UnitCheck(Unit, LuminousIntensityUnit.SI);
            return new(Unit);        
        }

        public static implicit operator LuminousIntensity(int zero)
        {
            if (zero != 0)
                throw new WrongUnitException("You need to give it a unit unless you set it to 0(zero)!");
			return Zero;
		}
	public override string GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<LuminousIntensityUnit>(_unit);
	}
}

