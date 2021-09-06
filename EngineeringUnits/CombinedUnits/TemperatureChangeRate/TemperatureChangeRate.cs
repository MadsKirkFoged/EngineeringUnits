using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class TemperatureChangeRate : BaseUnit
    {
        public TemperatureChangeRate() { }
        public TemperatureChangeRate(decimal value, TemperatureChangeRateUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public TemperatureChangeRate(double value, TemperatureChangeRateUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public TemperatureChangeRate(int value, TemperatureChangeRateUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public TemperatureChangeRate(UnknownUnit value) : base(value) { }

        public TemperatureChangeRate(UnknownUnit value, TemperatureChangeRateUnit selectedUnit) : base(value, selectedUnit.Unit) { }

        public static TemperatureChangeRate From(double value, TemperatureChangeRateUnit unit) => new TemperatureChangeRate(value, unit);
        public double As(TemperatureChangeRateUnit ReturnInThisUnit) => (double)ToTheOutSide(ReturnInThisUnit.Unit);
        public TemperatureChangeRate ToUnit(TemperatureChangeRateUnit selectedUnit) => new TemperatureChangeRate(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static TemperatureChangeRate Zero => new TemperatureChangeRate(0, TemperatureChangeRateUnit.SI);

        public static implicit operator TemperatureChangeRate(UnknownUnit Unit) => new TemperatureChangeRate(Unit, TemperatureChangeRateUnit.SI);
    }
}
