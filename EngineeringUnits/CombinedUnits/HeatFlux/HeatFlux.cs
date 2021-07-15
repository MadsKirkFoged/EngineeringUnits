using Fractions;
using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Text;
using EngineeringUnits.Units;

namespace EngineeringUnits
{
    public partial class HeatFlux : BaseUnit
    {

        public HeatFlux()
        {
            Unit = HeatFluxUnit.SI.Unit.Copy();
        }

        public HeatFlux(decimal value, HeatFluxUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public HeatFlux(double value, HeatFluxUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public HeatFlux(int value, HeatFluxUnit selectedUnit) : base(value, selectedUnit.Unit) { }


        public static HeatFlux From(double value, HeatFluxUnit unit) => new HeatFlux(value, unit);
        public double As(HeatFluxUnit ReturnInThisUnit) => (double)ToTheOutSide(ReturnInThisUnit.Unit);
        public HeatFlux ToUnit(HeatFluxUnit selectedUnit) => new HeatFlux(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static HeatFlux Zero => new HeatFlux(0, HeatFluxUnit.SI);

        public static implicit operator HeatFlux(UnknownUnit Unit)
        {
            HeatFlux local = new HeatFlux(0, HeatFluxUnit.SI);

            local.Transform(Unit);
            return local;
        }




    }
}
