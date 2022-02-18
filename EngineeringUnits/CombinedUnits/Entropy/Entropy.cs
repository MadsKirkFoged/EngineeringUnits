
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class Entropy : BaseUnit
    {

        public Entropy() { }
        public Entropy(decimal value, EntropyUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Entropy(double value, EntropyUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Entropy(int value, EntropyUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Entropy(UnknownUnit value) : base(value) { }

        public static Entropy From(double value, EntropyUnit unit) => new(value, unit);
        public double As(EntropyUnit ReturnInThisUnit) => ToTheOutSideDouble(ReturnInThisUnit.Unit);
        public Entropy ToUnit(EntropyUnit selectedUnit) => new(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static Entropy Zero => new(0, EntropyUnit.SI);

        public static implicit operator Entropy(UnknownUnit Unit) => new(Unit);

        public static implicit operator Entropy(int zero)
        {
            if (zero != 0)
                throw new WrongUnitException("You need to give it a unit unless you set it to 0(zero)!");
			return Zero;
		}
	public override string GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<EntropyUnit>(_unit);
	}
}

