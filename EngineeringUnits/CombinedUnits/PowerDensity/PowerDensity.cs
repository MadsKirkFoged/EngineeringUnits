using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class PowerDensity : BaseUnit
    {

        public PowerDensity() { }
        public PowerDensity(decimal value, PowerDensityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public PowerDensity(double value, PowerDensityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public PowerDensity(int value, PowerDensityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public PowerDensity(UnknownUnit value) : base(value) { }

        public PowerDensity(UnknownUnit value, PowerDensityUnit selectedUnit) : base(value, selectedUnit.Unit) { }

        public static PowerDensity From(double value, PowerDensityUnit unit) => new PowerDensity(value, unit);
        public double As(PowerDensityUnit ReturnInThisUnit) => (double)ToTheOutSide(ReturnInThisUnit.Unit);
        public PowerDensity ToUnit(PowerDensityUnit selectedUnit) => new PowerDensity(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static PowerDensity Zero => new PowerDensity(0, PowerDensityUnit.SI);

        public static implicit operator PowerDensity(UnknownUnit Unit) => new PowerDensity(Unit, PowerDensityUnit.SI);
    }
}
