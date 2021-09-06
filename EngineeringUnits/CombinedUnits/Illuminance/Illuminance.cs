using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class Illuminance : BaseUnit
    {

        public Illuminance() { }
        public Illuminance(decimal value, IlluminanceUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Illuminance(double value, IlluminanceUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Illuminance(int value, IlluminanceUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Illuminance(UnknownUnit value) : base(value) { }

        public Illuminance(UnknownUnit value, IlluminanceUnit selectedUnit) : base(value, selectedUnit.Unit) { }

        public static Illuminance From(double value, IlluminanceUnit unit) => new Illuminance(value, unit);
        public double As(IlluminanceUnit ReturnInThisUnit) => (double)ToTheOutSide(ReturnInThisUnit.Unit);
        public Illuminance ToUnit(IlluminanceUnit selectedUnit) => new Illuminance(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static Illuminance Zero => new Illuminance(0, IlluminanceUnit.SI);

        public static implicit operator Illuminance(UnknownUnit Unit) => new Illuminance(Unit, IlluminanceUnit.SI);

    }
}
