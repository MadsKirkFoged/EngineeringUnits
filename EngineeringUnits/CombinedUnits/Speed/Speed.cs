using Fractions;
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

        public Speed(double value, SpeedUnit selectedUnit) : this()
        {
            Unit = selectedUnit.Unit;
            SetValue(value);
        }

        public decimal As(SpeedUnit ReturnInThisUnit)
        {
            return (decimal)ToTheOutSide(ReturnInThisUnit.Unit);
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
