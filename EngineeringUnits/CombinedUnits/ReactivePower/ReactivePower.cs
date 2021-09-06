using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class ReactivePower : BaseUnit
    {

        public ReactivePower() { }
        public ReactivePower(decimal value, ReactivePowerUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ReactivePower(double value, ReactivePowerUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ReactivePower(int value, ReactivePowerUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ReactivePower(UnknownUnit value) : base(value) { }

        public ReactivePower(UnknownUnit value, ReactivePowerUnit selectedUnit) : base(value, selectedUnit.Unit) { }

        public static ReactivePower From(double value, ReactivePowerUnit unit) => new ReactivePower(value, unit);
        public double As(ReactivePowerUnit ReturnInThisUnit) => (double)ToTheOutSide(ReturnInThisUnit.Unit);
        public ReactivePower ToUnit(ReactivePowerUnit selectedUnit) => new ReactivePower(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static ReactivePower Zero => new ReactivePower(0, ReactivePowerUnit.SI);

        public static implicit operator ReactivePower(UnknownUnit Unit) => new ReactivePower(Unit, ReactivePowerUnit.SI);
    }
}
