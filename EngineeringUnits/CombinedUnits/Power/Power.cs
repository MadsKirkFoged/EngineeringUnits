using EngineeringUnits.Units;


namespace EngineeringUnits
{

    public partial class Power : BaseUnit
    {

        public Power() {}
        public Power(decimal value, PowerUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Power(double value, PowerUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Power(int value, PowerUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Power(UnknownUnit value) : base(value) { }

        public Power(UnknownUnit value, PowerUnit selectedUnit) : base(value, selectedUnit.Unit) { }

        public static Power From(double value, PowerUnit unit) => new(value, unit);
        public double As(PowerUnit ReturnInThisUnit) => ToTheOutSideDouble(ReturnInThisUnit.Unit);
        public Power ToUnit(PowerUnit selectedUnit) => new(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static Power Zero => new(0, PowerUnit.SI);

        public static implicit operator Power(UnknownUnit Unit) => new(Unit, PowerUnit.SI);       

    }
}
