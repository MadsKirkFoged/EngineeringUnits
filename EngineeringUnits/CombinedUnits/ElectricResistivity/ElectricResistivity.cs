
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class ElectricResistivity : BaseUnit
    {

        public ElectricResistivity() { }
        public ElectricResistivity(decimal value, ElectricResistivityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ElectricResistivity(double value, ElectricResistivityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ElectricResistivity(int value, ElectricResistivityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ElectricResistivity(UnknownUnit value) : base(value) { }

        public static ElectricResistivity From(double value, ElectricResistivityUnit unit) => new(value, unit);

        public static ElectricResistivity From(double? value, ElectricResistivityUnit unit)
        {
            if (value is null || unit is null)
            {
                return null;
            }

            return From((double)value, unit);
        }
        public double As(ElectricResistivityUnit ReturnInThisUnit) => ToTheOutSideDouble(ReturnInThisUnit.Unit);
        public ElectricResistivity ToUnit(ElectricResistivityUnit selectedUnit) => new(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static ElectricResistivity Zero => new(0, ElectricResistivityUnit.SI);

        public static implicit operator ElectricResistivity(UnknownUnit Unit) => new(Unit);

        public static implicit operator ElectricResistivity(int zero)
        {
            if (zero != 0)
                throw new WrongUnitException("You need to give it a unit unless you set it to 0(zero)!");
			return Zero;
		}
	public override string GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<ElectricResistivityUnit>(_unit);
	}
}

