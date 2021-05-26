using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{
    public partial class Speed : BaseUnit
    {

        public Speed()
        {
            Name = "Speed";
        }

        public Speed(double value, SpeedUnit SquaredlengthUnit) : this()
        {

            Unit = SquaredlengthUnit.Unit;

            SetLocalValue((decimal)value);
        }

        public decimal As(SpeedUnit Selectedunit)
        {
            return ToTheOutSide(Selectedunit.Unit);
        }

        //Every units needs this
        public static implicit operator Speed(UnknownUnit Unit)
        {
            Speed local = new Speed(0, SpeedUnit.SI);

            local.Transform(Unit);
            return local;
        }

    }
}
