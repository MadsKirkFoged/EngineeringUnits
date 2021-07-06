using Fractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class PressureChangeRate : BaseUnit
    {

        public PressureChangeRate()
        {
            Unit = PressureChangeRateUnit.SI.Unit.Copy();
        }

        public PressureChangeRate(decimal value, PressureChangeRateUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public PressureChangeRate(double value, PressureChangeRateUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public PressureChangeRate(int value, PressureChangeRateUnit selectedUnit) : base(value, selectedUnit.Unit) { }


        public static PressureChangeRate From(double value, PressureChangeRateUnit unit) => new PressureChangeRate(value, unit);
        public double As(PressureChangeRateUnit ReturnInThisUnit) => (double)ToTheOutSide(ReturnInThisUnit.Unit);
        public PressureChangeRate ToUnit(PressureChangeRateUnit selectedUnit) => new PressureChangeRate(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static PressureChangeRate Zero => new PressureChangeRate(0, PressureChangeRateUnit.SI);

        public static implicit operator PressureChangeRate(UnknownUnit Unit)
        {
            PressureChangeRate local = new PressureChangeRate(0, PressureChangeRateUnit.SI);

            local.Transform(Unit);
            return local;
        }




    }
}
