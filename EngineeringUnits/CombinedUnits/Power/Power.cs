using EngineeringUnits.Units;


namespace EngineeringUnits
{

    public partial class Power : BaseUnit
    {

        public Power()
        {
            Unit = PowerUnit.SI.Unit;
        }


        public Power(decimal value, PowerUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Power(double value, PowerUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Power(int value, PowerUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Power(UnknownUnit value) : base(value) { }


        public static Power From(double value, PowerUnit unit) => new Power(value, unit);
        public double As(PowerUnit ReturnInThisUnit) => (double)ToTheOutSide(ReturnInThisUnit.Unit);
        public Power ToUnit(PowerUnit selectedUnit) => new Power(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static Power Zero => new Power(0, PowerUnit.SI);

        public static implicit operator Power(UnknownUnit Unit) => new Power(Unit);

    }
}
