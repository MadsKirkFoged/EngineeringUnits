
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    //This class is auto-generated, changes to the file will be overwritten!
    public partial class Irradiance : BaseUnit
    {

        public Irradiance() { }
        public Irradiance(decimal value, IrradianceUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Irradiance(double value, IrradianceUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Irradiance(int value, IrradianceUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Irradiance(UnknownUnit value) : base(value) { }

        public static Irradiance From(double value, IrradianceUnit unit) => new(value, unit);

        public static Irradiance From(double? value, IrradianceUnit unit)
        {
            if (value is null || unit is null)
            {
                return null;
            }

            return From((double)value, unit);
        }
        public double As(IrradianceUnit ReturnInThisUnit) => GetValueAsDouble(ReturnInThisUnit.Unit);
        public Irradiance ToUnit(IrradianceUnit selectedUnit) => new(GetValueAs(selectedUnit.Unit), selectedUnit);
        public static Irradiance Zero => new(0, IrradianceUnit.SI);

        public static implicit operator Irradiance(UnknownUnit Unit)
        {
            UnitCheck(Unit, IrradianceUnit.SI);
            return new(Unit);        
        }

        public static implicit operator Irradiance(int zero)
        {
            if (zero != 0)
                throw new WrongUnitException("You need to give it a unit unless you set it to 0(zero)!");
			return Zero;
		}
	public override string GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<IrradianceUnit>(_unit);
	}
}

