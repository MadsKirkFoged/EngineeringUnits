using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class ForceChangeRate : BaseUnit
    {

        public ForceChangeRate() { }
        public ForceChangeRate(decimal value, ForceChangeRateUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ForceChangeRate(double value, ForceChangeRateUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ForceChangeRate(int value, ForceChangeRateUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ForceChangeRate(UnknownUnit value) : base(value) { }

        public ForceChangeRate(UnknownUnit value, ForceChangeRateUnit selectedUnit) : base(value, selectedUnit.Unit) { }

        public static ForceChangeRate From(double value, ForceChangeRateUnit unit) => new ForceChangeRate(value, unit);
        public double As(ForceChangeRateUnit ReturnInThisUnit) => (double)ToTheOutSide(ReturnInThisUnit.Unit);
        public ForceChangeRate ToUnit(ForceChangeRateUnit selectedUnit) => new ForceChangeRate(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static ForceChangeRate Zero => new ForceChangeRate(0, ForceChangeRateUnit.SI);

        public static implicit operator ForceChangeRate(UnknownUnit Unit) => new ForceChangeRate(Unit, ForceChangeRateUnit.SI);


    }
}
