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

        public Speed(decimal value, SpeedUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Speed(double value, SpeedUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Speed(int value, SpeedUnit selectedUnit) : base(value, selectedUnit.Unit) { }


        public static Speed From(double value, SpeedUnit unit) => new Speed(value, unit);
        public double As(SpeedUnit ReturnInThisUnit) => (double)ToTheOutSide(ReturnInThisUnit.Unit);
        public Speed ToUnit(SpeedUnit selectedUnit) => new Speed(ToTheOutSide(selectedUnit.Unit), selectedUnit);


        public static implicit operator Speed(UnknownUnit Unit)
        {
            Speed local = new Speed(0, SpeedUnit.SI);

            local.Transform(Unit);
            return local;
        }


    }
}
