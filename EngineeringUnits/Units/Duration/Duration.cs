using System;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class Duration : BaseUnit
    {

        public Duration()
        {
            unitsystem.Duration.Count = 1;
        }


        public Duration(double value, DurationUnit? unit) : this()
        {
            //unitsystem.SetUnit(unit);
            //base.Value = value;
        }

        public static Duration From(double value, DurationUnit unit)
        {
            return new Duration(value, unit);
        }

        public double As(DurationUnit ReturnInThisUnit)
        {

            UnitSystem ReturnInThisUnitSystem = new UnitSystem();

            ReturnInThisUnitSystem.Duration.SelectedUnit = ReturnInThisUnit;
            ReturnInThisUnitSystem.Duration.Count = 1;


            return UnitSystem.Convert(Value, this.unitsystem, ReturnInThisUnitSystem);
        }


        //Every units needs this
        public static implicit operator Duration(UnknownUnit Unit)
        {
            Duration local = new Duration();

            if (local.unitsystem != Unit.baseUnit.unitsystem)
            {
                throw new InvalidOperationException("Units did not result in Duration!");
            }

            local.ValueLocalUnit = Unit.baseUnit.ValueLocalUnit;
            local.unitsystem = Unit.baseUnit.unitsystem;

            return local;
        }



    }
}
