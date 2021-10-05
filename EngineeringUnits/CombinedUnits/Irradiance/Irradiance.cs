using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class Irradiance : BaseUnit
    {

        public Irradiance() { }
        public Irradiance(decimal value, IrradianceUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Irradiance(double value, IrradianceUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Irradiance(int value, IrradianceUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Irradiance(UnknownUnit value) : base(value) { }

        public Irradiance(UnknownUnit value, IrradianceUnit selectedUnit) : base(value, selectedUnit.Unit) { }

        public static Irradiance From(double value, IrradianceUnit unit) => new(value, unit);
        public double As(IrradianceUnit ReturnInThisUnit) => ToTheOutSideDouble(ReturnInThisUnit.Unit);
        public Irradiance ToUnit(IrradianceUnit selectedUnit) => new(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static Irradiance Zero => new(0, IrradianceUnit.SI);

        public static implicit operator Irradiance(UnknownUnit Unit) => new(Unit, IrradianceUnit.SI);

    }
}
