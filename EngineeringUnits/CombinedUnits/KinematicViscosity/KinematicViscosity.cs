
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    //This class is auto-generated, changes to the file will be overwritten!
    public partial class KinematicViscosity : BaseUnit
    {

        public KinematicViscosity() { }
        public KinematicViscosity(decimal value, KinematicViscosityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public KinematicViscosity(double value, KinematicViscosityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public KinematicViscosity(int value, KinematicViscosityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public KinematicViscosity(UnknownUnit value) : base(value) { }

        public static KinematicViscosity From(double value, KinematicViscosityUnit unit) => new(value, unit);

        public static KinematicViscosity From(double? value, KinematicViscosityUnit unit)
        {
            if (value is null || unit is null)
            {
                return null;
            }

            return From((double)value, unit);
        }
        public double As(KinematicViscosityUnit ReturnInThisUnit) => GetValueAsDouble(ReturnInThisUnit.Unit);
        public KinematicViscosity ToUnit(KinematicViscosityUnit selectedUnit) => new(GetValueAs(selectedUnit.Unit), selectedUnit);
        public static KinematicViscosity Zero => new(0, KinematicViscosityUnit.SI);

        public static implicit operator KinematicViscosity(UnknownUnit Unit)
        {
            if (Unit is null)
                return null; 

            Unit.UnitCheck(KinematicViscosityUnit.SI);
            return new(Unit);        
        }

        public static implicit operator KinematicViscosity(int zero)
        {
            if (zero != 0)
                throw new WrongUnitException("You need to give it a unit unless you set it to 0(zero)!");
			return Zero;
		}
	public override string GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<KinematicViscosityUnit>(_unit);
	}
}

