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

        public static Frequency From(double value, FrequencyUnit unit) => new Frequency(value, unit);
        public double As(FrequencyUnit ReturnInThisUnit) => (double)ToTheOutSide(ReturnInThisUnit.Unit);
        public Frequency ToUnit(FrequencyUnit selectedUnit) => new Frequency(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static Frequency Zero => new Frequency(0, FrequencyUnit.SI);

        public static implicit operator Frequency(UnknownUnit Unit) => new Frequency(Unit, FrequencyUnit.SI);



    }
}
