using Fractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class MassFlux : BaseUnit
    {

        public MassFlux()
        {
            Unit = MassFluxUnit.SI.Unit.Copy();
        }

        public MassFlux(decimal value, MassFluxUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public MassFlux(double value, MassFluxUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public MassFlux(int value, MassFluxUnit selectedUnit) : base(value, selectedUnit.Unit) { }


        public static MassFlux From(double value, MassFluxUnit unit) => new MassFlux(value, unit);
        public double As(MassFluxUnit ReturnInThisUnit) => (double)ToTheOutSide(ReturnInThisUnit.Unit);
        public MassFlux ToUnit(MassFluxUnit selectedUnit) => new MassFlux(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static MassFlux Zero => new MassFlux(0, MassFluxUnit.SI);

        public static implicit operator MassFlux(UnknownUnit Unit)
        {
            MassFlux local = new MassFlux(0, MassFluxUnit.SI);

            local.Transform(Unit);
            return local;
        }




    }
}
