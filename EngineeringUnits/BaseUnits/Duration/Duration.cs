using System;
using System.Collections.Generic;
using System.Text;

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
            //UnitSystem ReturnInThisUnitSystem = new UnitSystem();

            //ReturnInThisUnitSystem.Duration.SelectedUnit = unit;
            //ReturnInThisUnitSystem.Duration.Count = 1;

            ////Convert to 'local' unit
            //ValueLocalUnit = UnitSystem.GetLocalUnit(value, ReturnInThisUnitSystem);
            //Unit = ReturnInThisUnitSystem;


            Unit.Duration = unit;
            //ValueLocalUnit = Unit.ReturnLocalValue((decimal)value);
            SetLocalValue((decimal)value);

        }

        public static Duration From(double value, DurationUnit unit)
        {
            return new Duration(value, unit);
        }

        public decimal As(DurationUnit ReturnInThisUnit)
        {

            UnitSystem ReturnInThisUnitSystem = new UnitSystem();

            ReturnInThisUnitSystem.Duration = ReturnInThisUnit;
            ReturnInThisUnitSystem.Duration.Count = 1;

            return ToTheOutSide(ReturnInThisUnitSystem) / 1.000000000000000000000000000000000m;
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
