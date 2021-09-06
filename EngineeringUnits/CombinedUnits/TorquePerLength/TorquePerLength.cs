using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class TorquePerLength : BaseUnit
    {

        public TorquePerLength() { }
        public TorquePerLength(decimal value, TorquePerLengthUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public TorquePerLength(double value, TorquePerLengthUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public TorquePerLength(int value, TorquePerLengthUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public TorquePerLength(UnknownUnit value) : base(value) { }

        public TorquePerLength(UnknownUnit value, TorquePerLengthUnit selectedUnit) : base(value, selectedUnit.Unit) { }

        public static TorquePerLength From(double value, TorquePerLengthUnit unit) => new TorquePerLength(value, unit);
        public double As(TorquePerLengthUnit ReturnInThisUnit) => (double)ToTheOutSide(ReturnInThisUnit.Unit);
        public TorquePerLength ToUnit(TorquePerLengthUnit selectedUnit) => new TorquePerLength(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static TorquePerLength Zero => new TorquePerLength(0, TorquePerLengthUnit.SI);

        public static implicit operator TorquePerLength(UnknownUnit Unit) => new TorquePerLength(Unit, TorquePerLengthUnit.SI);
    }
}
