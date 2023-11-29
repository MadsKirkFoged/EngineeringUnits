
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    //This class is auto-generated, changes to the file will be overwritten!
    public partial class Irradiation : BaseUnit
    {

        public Irradiation() { }
        public Irradiation(decimal value, IrradiationUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Irradiation(double value, IrradiationUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Irradiation(int value, IrradiationUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Irradiation(UnknownUnit value) : base(value) { }

        public static Irradiation From(double value, IrradiationUnit unit) => new(value, unit);

        public static Irradiation From(double? value, IrradiationUnit unit)
        {
            if (value is null || unit is null)
            {
                return null;
            }

            return From((double)value, unit);
        }
        public double As(IrradiationUnit ReturnInThisUnit) => GetValueAsDouble(ReturnInThisUnit);
        public Irradiation ToUnit(IrradiationUnit selectedUnit) => new(GetValueAs(selectedUnit.Unit), selectedUnit);
        public static Irradiation Zero => new(0, IrradiationUnit.SI);
        public static Irradiation NaN => new(double.NaN, IrradiationUnit.SI);

        public static implicit operator Irradiation(UnknownUnit Unit)
        {
            if (Unit is null)
                return null; 

            Unit.UnitCheck(IrradiationUnit.SI);
            return new(Unit);        
        }

        public static implicit operator Irradiation(int zero)
        {
            if (zero != 0)
                throw new WrongUnitException("You need to give it a unit unless you set it to 0(zero)!");
			return Zero;
		}
	public override string GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<IrradiationUnit>(_unit);
	}
}

