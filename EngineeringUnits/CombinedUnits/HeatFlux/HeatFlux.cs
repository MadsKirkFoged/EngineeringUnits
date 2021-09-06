using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class HeatFlux : BaseUnit
    {

        public HeatFlux() { }
        public HeatFlux(decimal value, HeatFluxUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public HeatFlux(double value, HeatFluxUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public HeatFlux(int value, HeatFluxUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public HeatFlux(UnknownUnit value) : base(value) { }

        public HeatFlux(UnknownUnit value, HeatFluxUnit selectedUnit) : base(value, selectedUnit.Unit) { }

        public static HeatFlux From(double value, HeatFluxUnit unit) => new HeatFlux(value, unit);
        public double As(HeatFluxUnit ReturnInThisUnit) => (double)ToTheOutSide(ReturnInThisUnit.Unit);
        public HeatFlux ToUnit(HeatFluxUnit selectedUnit) => new HeatFlux(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static HeatFlux Zero => new HeatFlux(0, HeatFluxUnit.SI);

        public static implicit operator HeatFlux(UnknownUnit Unit) => new HeatFlux(Unit, HeatFluxUnit.SI);

    }
}
