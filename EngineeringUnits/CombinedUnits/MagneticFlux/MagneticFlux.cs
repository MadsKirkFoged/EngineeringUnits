using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class MagneticFlux : BaseUnit
    {

        public MagneticFlux() { }
        public MagneticFlux(decimal value, MagneticFluxUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public MagneticFlux(double value, MagneticFluxUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public MagneticFlux(int value, MagneticFluxUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public MagneticFlux(UnknownUnit value) : base(value) { }

        public MagneticFlux(UnknownUnit value, MagneticFluxUnit selectedUnit) : base(value, selectedUnit.Unit) { }

        public static MagneticFlux From(double value, MagneticFluxUnit unit) => new MagneticFlux(value, unit);
        public double As(MagneticFluxUnit ReturnInThisUnit) => (double)ToTheOutSide(ReturnInThisUnit.Unit);
        public MagneticFlux ToUnit(MagneticFluxUnit selectedUnit) => new MagneticFlux(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static MagneticFlux Zero => new MagneticFlux(0, MagneticFluxUnit.SI);

        public static implicit operator MagneticFlux(UnknownUnit Unit) => new MagneticFlux(Unit, MagneticFluxUnit.SI);

    }
}
