using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class Frequency : BaseUnit
    {

        public Frequency() { }
        public Frequency(decimal value, FrequencyUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Frequency(double value, FrequencyUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Frequency(int value, FrequencyUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Frequency(UnknownUnit value) : base(value) { }

        public Frequency(UnknownUnit value, FrequencyUnit selectedUnit) : base(value, selectedUnit.Unit) { }

        public static Frequency From(double value, FrequencyUnit unit) => new(value, unit);
        public double As(FrequencyUnit ReturnInThisUnit) => ToTheOutSideDouble(ReturnInThisUnit.Unit);
        public Frequency ToUnit(FrequencyUnit selectedUnit) => new(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static Frequency Zero => new(0, FrequencyUnit.SI);

        public static implicit operator Frequency(UnknownUnit Unit) => new(Unit, FrequencyUnit.SI);

        public static implicit operator Frequency(int zero)
        {
            if (zero != 0)
                throw new WrongUnitException($"You need to give it a unit unless you set it to 0 (zero)!");

            return Zero;
        }



    }
}
