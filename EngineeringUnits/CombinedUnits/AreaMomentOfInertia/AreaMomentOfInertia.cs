
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    //This class is auto-generated, changes to the file will be overwritten!
    public partial class AreaMomentOfInertia : BaseUnit
    {

        public AreaMomentOfInertia() { }
        public AreaMomentOfInertia(decimal value, AreaMomentOfInertiaUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public AreaMomentOfInertia(double value, AreaMomentOfInertiaUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public AreaMomentOfInertia(int value, AreaMomentOfInertiaUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public AreaMomentOfInertia(UnknownUnit value) : base(value) { }

        public static AreaMomentOfInertia From(double value, AreaMomentOfInertiaUnit unit) => new(value, unit);

        public static AreaMomentOfInertia From(double? value, AreaMomentOfInertiaUnit unit)
        {
            if (value is null || unit is null)
            {
                return null;
            }

            return From((double)value, unit);
        }
        public double As(AreaMomentOfInertiaUnit ReturnInThisUnit) => GetValueAsDouble(ReturnInThisUnit.Unit);
        public AreaMomentOfInertia ToUnit(AreaMomentOfInertiaUnit selectedUnit) => new(GetValueAs(selectedUnit.Unit), selectedUnit);
        public static AreaMomentOfInertia Zero => new(0, AreaMomentOfInertiaUnit.SI);

        public static implicit operator AreaMomentOfInertia(UnknownUnit Unit)
        {
            Unit.UnitCheck(AreaMomentOfInertiaUnit.SI);
            return new(Unit);        
        }

        public static implicit operator AreaMomentOfInertia(int zero)
        {
            if (zero != 0)
                throw new WrongUnitException("You need to give it a unit unless you set it to 0(zero)!");
			return Zero;
		}
	public override string GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<AreaMomentOfInertiaUnit>(_unit);
	}
}

