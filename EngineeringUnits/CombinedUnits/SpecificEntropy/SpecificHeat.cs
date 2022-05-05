
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class SpecificHeat : BaseUnit
    {

        public SpecificHeat() { }
        public SpecificHeat(decimal value, SpecificEntropyUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public SpecificHeat(double value, SpecificEntropyUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public SpecificHeat(int value, SpecificEntropyUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public SpecificHeat(UnknownUnit value) : base(value) { }

        public static SpecificHeat From(double value, SpecificEntropyUnit unit) => new(value, unit);

        public static SpecificHeat From(double? value, SpecificEntropyUnit unit)
        {
            if (value is null || unit is null)
            {
                return null;
            }

            return From((double)value, unit);
        }
        public double As(SpecificEntropyUnit ReturnInThisUnit) => GetValueAsDouble(ReturnInThisUnit.Unit);
        public SpecificHeat ToUnit(SpecificEntropyUnit selectedUnit) => new(GetValueAs(selectedUnit.Unit), selectedUnit);
        public static SpecificHeat Zero => new(0, SpecificEntropyUnit.SI);

        public static implicit operator SpecificHeat(UnknownUnit Unit)
        {
            UnitCheck(Unit, SpecificEntropyUnit.SI);
            return new(Unit);
        }

        public static implicit operator SpecificHeat(int zero)
        {
            if (zero != 0)
                throw new WrongUnitException("You need to give it a unit unless you set it to 0(zero)!");
            return Zero;
        }
        public override string GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<SpecificEntropyUnit>(_unit);
    }
}

