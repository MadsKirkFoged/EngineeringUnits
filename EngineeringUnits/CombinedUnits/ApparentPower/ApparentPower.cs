using Fractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class ApparentPower : BaseUnit
    {

        public ApparentPower()
        {
            Unit = ApparentPowerUnit.SI.Unit.Copy();
        }

        public ApparentPower(decimal value, ApparentPowerUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ApparentPower(double value, ApparentPowerUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ApparentPower(int value, ApparentPowerUnit selectedUnit) : base(value, selectedUnit.Unit) { }


        public static ApparentPower From(double value, ApparentPowerUnit unit) => new ApparentPower(value, unit);
        public double As(ApparentPowerUnit ReturnInThisUnit) => (double)ToTheOutSide(ReturnInThisUnit.Unit);
        public ApparentPower ToUnit(ApparentPowerUnit selectedUnit) => new ApparentPower(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static ApparentPower Zero => new ApparentPower(0, ApparentPowerUnit.SI);

        public static implicit operator ApparentPower(UnknownUnit Unit)
        {
            ApparentPower local = new ApparentPower(0, ApparentPowerUnit.SI);

            local.Transform(Unit);
            return local;
        }




    }
}
