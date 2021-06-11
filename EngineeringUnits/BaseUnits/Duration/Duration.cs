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
        public Duration(int value, DurationUnit selectedUnit) : this()
        {
            Unit.Duration = selectedUnit;
            SetValue(value);
        }
        public Duration(double value, DurationUnit selectedUnit) : this()
        {
            Unit.Duration = selectedUnit;
            SetValue(value);
        }

        public Duration(decimal value, DurationUnit selectedUnit) : this()
        {
            Unit.Duration = selectedUnit;
            SetValue(value);
        }

        public static Duration From(double value, DurationUnit unit)
        {
            return new Duration(value, unit);
        }

        public double As(DurationUnit ReturnInThisUnit)
        {

            return (double)ToTheOutSide(ReturnInThisUnit.Unit);
        }

        public Duration ToUnit(DurationUnit selectedUnit)
        {
            return new Duration(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        }

        public static implicit operator Duration(UnknownUnit Unit)
        {
            Duration local = new Duration(0d, DurationUnit.SI);

            local.Transform(Unit);
            return local;
        }



    }
}
