using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class MassFlux : BaseUnit
    {

        public MassFlux() { }
        public MassFlux(decimal value, MassFluxUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public MassFlux(double value, MassFluxUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public MassFlux(int value, MassFluxUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public MassFlux(UnknownUnit value) : base(value) { }

        public MassFlux(UnknownUnit value, MassFluxUnit selectedUnit) : base(value, selectedUnit.Unit) { }

        public static MassFlux From(double value, MassFluxUnit unit) => new MassFlux(value, unit);
        public double As(MassFluxUnit ReturnInThisUnit) => (double)ToTheOutSide(ReturnInThisUnit.Unit);
        public MassFlux ToUnit(MassFluxUnit selectedUnit) => new MassFlux(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static MassFlux Zero => new MassFlux(0, MassFluxUnit.SI);

        public static implicit operator MassFlux(UnknownUnit Unit) => new MassFlux(Unit, MassFluxUnit.SI);
    }
}
