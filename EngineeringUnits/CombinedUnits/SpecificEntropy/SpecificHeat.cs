
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class SpecificHeatCapacity : BaseUnit
    {

        public SpecificHeatCapacity() { }
        public SpecificHeatCapacity(decimal value, SpecificEntropyUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public SpecificHeatCapacity(double value, SpecificEntropyUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public SpecificHeatCapacity(int value, SpecificEntropyUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public SpecificHeatCapacity(UnknownUnit value) : base(value) { }

        public static SpecificHeatCapacity From(double value, SpecificEntropyUnit unit) => new(value, unit);

        public static SpecificHeatCapacity From(double? value, SpecificEntropyUnit unit)
        {
            if (value is null || unit is null)
            {
                return null;
            }

            return From((double)value, unit);
        }
        public double As(SpecificEntropyUnit ReturnInThisUnit) => GetValueAsDouble(ReturnInThisUnit.Unit);
        public SpecificHeatCapacity ToUnit(SpecificEntropyUnit selectedUnit) => new(GetValueAs(selectedUnit.Unit), selectedUnit);
        public static SpecificHeatCapacity Zero => new(0, SpecificEntropyUnit.SI);

        public static implicit operator SpecificHeatCapacity(UnknownUnit Unit)
        {
            UnitCheck(Unit, SpecificEntropyUnit.SI);
            return new(Unit);
        }

        public static implicit operator SpecificHeatCapacity(int zero)
        {
            if (zero != 0)
                throw new WrongUnitException("You need to give it a unit unless you set it to 0(zero)!");
            return Zero;
        }
        public override string GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<SpecificEntropyUnit>(_unit);
    }
}

