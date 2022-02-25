
using EngineeringUnits.Units;


namespace EngineeringUnits
{
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
        public double As(AreaMomentOfInertiaUnit ReturnInThisUnit) => ToTheOutSideDouble(ReturnInThisUnit.Unit);
        public AreaMomentOfInertia ToUnit(AreaMomentOfInertiaUnit selectedUnit) => new(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static AreaMomentOfInertia Zero => new(0, AreaMomentOfInertiaUnit.SI);

        public static implicit operator AreaMomentOfInertia(UnknownUnit Unit)
        {
            UnitCheck(Unit, AreaMomentOfInertiaUnit.SI);
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

