using Fractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class ForceChangeRate : BaseUnit
    {

        public ForceChangeRate()
        {
            Unit = ForceChangeRateUnit.SI.Unit.Copy();
        }

        public ForceChangeRate(decimal value, ForceChangeRateUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ForceChangeRate(double value, ForceChangeRateUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ForceChangeRate(int value, ForceChangeRateUnit selectedUnit) : base(value, selectedUnit.Unit) { }


        public static ForceChangeRate From(double value, ForceChangeRateUnit unit) => new ForceChangeRate(value, unit);
        public double As(ForceChangeRateUnit ReturnInThisUnit) => (double)ToTheOutSide(ReturnInThisUnit.Unit);
        public ForceChangeRate ToUnit(ForceChangeRateUnit selectedUnit) => new ForceChangeRate(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static ForceChangeRate Zero => new ForceChangeRate(0, ForceChangeRateUnit.SI);

        public static implicit operator ForceChangeRate(UnknownUnit Unit)
        {
            ForceChangeRate local = new ForceChangeRate(0, ForceChangeRateUnit.SI);

            local.Transform(Unit);
            return local;
        }




    }
}
