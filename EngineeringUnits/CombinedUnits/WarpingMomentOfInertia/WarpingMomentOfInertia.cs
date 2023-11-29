
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    //This class is auto-generated, changes to the file will be overwritten!
    public partial class WarpingMomentOfInertia : BaseUnit
    {

        public WarpingMomentOfInertia() { }
        public WarpingMomentOfInertia(decimal value, WarpingMomentOfInertiaUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public WarpingMomentOfInertia(double value, WarpingMomentOfInertiaUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public WarpingMomentOfInertia(int value, WarpingMomentOfInertiaUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public WarpingMomentOfInertia(UnknownUnit value) : base(value) { }

        public static WarpingMomentOfInertia From(double value, WarpingMomentOfInertiaUnit unit) => new(value, unit);

        public static WarpingMomentOfInertia From(double? value, WarpingMomentOfInertiaUnit unit)
        {
            if (value is null || unit is null)
            {
                return null;
            }

            return From((double)value, unit);
        }
        public double As(WarpingMomentOfInertiaUnit ReturnInThisUnit) => GetValueAsDouble(ReturnInThisUnit);
        public WarpingMomentOfInertia ToUnit(WarpingMomentOfInertiaUnit selectedUnit) => new(GetValueAs(selectedUnit.Unit), selectedUnit);
        public static WarpingMomentOfInertia Zero => new(0, WarpingMomentOfInertiaUnit.SI);
        public static WarpingMomentOfInertia NaN => new(double.NaN, WarpingMomentOfInertiaUnit.SI);

        public static implicit operator WarpingMomentOfInertia(UnknownUnit Unit)
        {
            if (Unit is null)
                return null; 

            Unit.UnitCheck(WarpingMomentOfInertiaUnit.SI);
            return new(Unit);        
        }

        public static implicit operator WarpingMomentOfInertia(int zero)
        {
            if (zero != 0)
                throw new WrongUnitException("You need to give it a unit unless you set it to 0(zero)!");
			return Zero;
		}
	public override string GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<WarpingMomentOfInertiaUnit>(_unit);
	}
}

