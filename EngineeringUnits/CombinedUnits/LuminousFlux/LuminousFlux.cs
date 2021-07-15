using Fractions;
using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Text;
using EngineeringUnits.Units;

namespace EngineeringUnits
{
    public partial class LuminousFlux : BaseUnit
    {

        public LuminousFlux()
        {
            Unit = LuminousFluxUnit.SI.Unit.Copy();
        }

        public LuminousFlux(decimal value, LuminousFluxUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public LuminousFlux(double value, LuminousFluxUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public LuminousFlux(int value, LuminousFluxUnit selectedUnit) : base(value, selectedUnit.Unit) { }


        public static LuminousFlux From(double value, LuminousFluxUnit unit) => new LuminousFlux(value, unit);
        public double As(LuminousFluxUnit ReturnInThisUnit) => (double)ToTheOutSide(ReturnInThisUnit.Unit);
        public LuminousFlux ToUnit(LuminousFluxUnit selectedUnit) => new LuminousFlux(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static LuminousFlux Zero => new LuminousFlux(0, LuminousFluxUnit.SI);

        public static implicit operator LuminousFlux(UnknownUnit Unit)
        {
            LuminousFlux local = new LuminousFlux(0, LuminousFluxUnit.SI);

            local.Transform(Unit);
            return local;
        }




    }
}
