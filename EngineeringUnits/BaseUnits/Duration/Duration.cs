using System;
using System.Collections.Generic;
using System.Text;
using Fractions;

namespace EngineeringUnits
{
    public partial class Duration : BaseUnit
    {

        public Duration()
        {
            Name = "Duration";
        }


        public Duration(decimal value, DurationUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Duration(double value, DurationUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Duration(int value, DurationUnit selectedUnit) : base(value, selectedUnit.Unit) { }


        public static Duration From(double value, DurationUnit unit) => new Duration(value, unit);
        public double As(DurationUnit ReturnInThisUnit) => (double)ToTheOutSide(ReturnInThisUnit.Unit);
        public Duration ToUnit(DurationUnit selectedUnit) => new Duration(ToTheOutSide(selectedUnit.Unit), selectedUnit);


        public static implicit operator Duration(UnknownUnit Unit)
        {
            Duration local = new Duration(0, DurationUnit.SI);

            local.Transform(Unit);
            return local;
        }



    }
}
