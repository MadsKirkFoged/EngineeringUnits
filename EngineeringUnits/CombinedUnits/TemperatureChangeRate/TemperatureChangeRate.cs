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

        public static TemperatureChangeRate From(double value, TemperatureChangeRateUnit unit) => new(value, unit);
        public double As(TemperatureChangeRateUnit ReturnInThisUnit) => ToTheOutSideDouble(ReturnInThisUnit.Unit);
        public TemperatureChangeRate ToUnit(TemperatureChangeRateUnit selectedUnit) => new(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static TemperatureChangeRate Zero => new(0, TemperatureChangeRateUnit.SI);

        public static implicit operator TemperatureChangeRate(UnknownUnit Unit) => new(Unit);

        public static implicit operator TemperatureChangeRate(int zero)
        {
            if (zero != 0)
                throw new WrongUnitException($"You need to give it a unit unless you set it to 0 (zero)!");

            return Zero;
        }
    }
}
