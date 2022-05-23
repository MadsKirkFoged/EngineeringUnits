
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    //This class is auto-generated, changes to the file will be overwritten!
    public partial class MassMomentOfInertia : BaseUnit
    {

        public MassMomentOfInertia() { }
        public MassMomentOfInertia(decimal value, MassMomentOfInertiaUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public MassMomentOfInertia(double value, MassMomentOfInertiaUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public MassMomentOfInertia(int value, MassMomentOfInertiaUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public MassMomentOfInertia(UnknownUnit value) : base(value) { }

        public static MassMomentOfInertia From(double value, MassMomentOfInertiaUnit unit) => new(value, unit);

        public static MassMomentOfInertia From(double? value, MassMomentOfInertiaUnit unit)
        {
            if (value is null || unit is null)
            {
                return null;
            }

            return From((double)value, unit);
        }
        public double As(MassMomentOfInertiaUnit ReturnInThisUnit) => GetValueAsDouble(ReturnInThisUnit.Unit);
        public MassMomentOfInertia ToUnit(MassMomentOfInertiaUnit selectedUnit) => new(GetValueAs(selectedUnit.Unit), selectedUnit);
        public static MassMomentOfInertia Zero => new(0, MassMomentOfInertiaUnit.SI);

        public static implicit operator MassMomentOfInertia(UnknownUnit Unit)
        {
            UnitCheck(Unit, MassMomentOfInertiaUnit.SI);
            return new(Unit);        
        }

        public static implicit operator MassMomentOfInertia(int zero)
        {
            if (zero != 0)
                throw new WrongUnitException("You need to give it a unit unless you set it to 0(zero)!");
			return Zero;
		}
	public override string GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<MassMomentOfInertiaUnit>(_unit);
	}
}

