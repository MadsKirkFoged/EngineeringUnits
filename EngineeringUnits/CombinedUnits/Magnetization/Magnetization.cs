
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    //This class is auto-generated, changes to the file will be overwritten!
    public partial class Magnetization : BaseUnit
    {

        public Magnetization() { }
        public Magnetization(decimal value, MagnetizationUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Magnetization(double value, MagnetizationUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Magnetization(int value, MagnetizationUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Magnetization(UnknownUnit value) : base(value) { }

        public static Magnetization From(double value, MagnetizationUnit unit) => new(value, unit);

        public static Magnetization From(double? value, MagnetizationUnit unit)
        {
            if (value is null || unit is null)
            {
                return null;
            }

            return From((double)value, unit);
        }
        public double As(MagnetizationUnit ReturnInThisUnit) => GetValueAsDouble(ReturnInThisUnit.Unit);
        public Magnetization ToUnit(MagnetizationUnit selectedUnit) => new(GetValueAs(selectedUnit.Unit), selectedUnit);
        public static Magnetization Zero => new(0, MagnetizationUnit.SI);

        public static implicit operator Magnetization(UnknownUnit Unit)
        {
            if (Unit is null)
                return null; 

            Unit.UnitCheck(MagnetizationUnit.SI);
            return new(Unit);        
        }

        public static implicit operator Magnetization(int zero)
        {
            if (zero != 0)
                throw new WrongUnitException("You need to give it a unit unless you set it to 0(zero)!");
			return Zero;
		}
	public override string GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<MagnetizationUnit>(_unit);
	}
}

