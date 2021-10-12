using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class LuminousFlux : BaseUnit
    {

        public LuminousFlux() { }
        public LuminousFlux(decimal value, LuminousFluxUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public LuminousFlux(double value, LuminousFluxUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public LuminousFlux(int value, LuminousFluxUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public LuminousFlux(UnknownUnit value) : base(value) { }

        public LuminousFlux(UnknownUnit value, LuminousFluxUnit selectedUnit) : base(value, selectedUnit.Unit) { }

        public static LuminousFlux From(double value, LuminousFluxUnit unit) => new(value, unit);
        public double As(LuminousFluxUnit ReturnInThisUnit) => ToTheOutSideDouble(ReturnInThisUnit.Unit);
        public LuminousFlux ToUnit(LuminousFluxUnit selectedUnit) => new(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static LuminousFlux Zero => new(0, LuminousFluxUnit.SI);

        public static implicit operator LuminousFlux(UnknownUnit Unit) => new(Unit, LuminousFluxUnit.SI);

        public static implicit operator LuminousFlux(int zero)
        {
            if (zero != 0)
                throw new WrongUnitException($"You need to give it a unit unless you set it to 0 (zero)!");

            return Zero;
        }
    }
}
