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
            Name = "Time";
        }


        public Duration(double value, DurationUnit unit) : this()
        {


            Unit.Duration = unit;
            //ValueLocalUnit = Unit.ReturnLocalValue((decimal)value);
            SetLocalValue(value);

        }

        public static Duration From(double value, DurationUnit unit)
        {
            return new Duration(value, unit);
        }

        public double As(DurationUnit ReturnInThisUnit)
        {

            UnitSystem ReturnInThisUnitSystem = new UnitSystem();

            ReturnInThisUnitSystem.Duration = ReturnInThisUnit;
            ReturnInThisUnitSystem.Duration.Count = 1;

            return ToTheOutSide(ReturnInThisUnitSystem);
        }


        //Every units needs this
        public static implicit operator Duration(UnknownUnit Unit)
        {
            Duration local = new Duration(0, DurationUnit.SI);

            local.Transform(Unit);
            return local;
        }



    }
}
