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
            base.Value = value;
        }

        public static Duration From(double value, DurationUnit unit)
        {
            return new Duration(value, unit);
        }

        //public double As(DurationUnit ReturnInThisUnit)
        //{
        //    return UnitSystem.VectorDifferent(unitsystem.SelectedDurationUnit, ReturnInThisUnit) * Value;
        //}

        //public void ChangeUnitTo(DurationUnit ReturnInThisUnit)
        //{
        //    double Vector = UnitSystem.VectorDifferent(unitsystem.SelectedDurationUnit, ReturnInThisUnit);
        //    Value *= Vector;

        //    unitsystem.SetUnit(ReturnInThisUnit);
        //}


        //Every units needs this
        public static implicit operator Duration(UnknownUnit Unit)
        {
            Duration local = new Duration();

            if (local.unitsystem != Unit.baseUnit.unitsystem)
            {
                throw new InvalidOperationException("Units did not result in Duration!");
            }

            local.Value = Unit.baseUnit.Value;
            local.unitsystem = Unit.baseUnit.unitsystem;

            return local;
        }

        //Every units needs this

        //public static UnknownUnit operator *(Duration a, BaseUnit b) => BaseUnit.Multiply(a, b);
        //public static UnknownUnit operator *(Duration a, double b) => BaseUnit.Multiply(a, b);
        //public static UnknownUnit operator *(double a, Duration b) => BaseUnit.Multiply(b, a);
        //public static UnknownUnit operator /(Duration a, BaseUnit b) => BaseUnit.Divide(a, b);
        //public static UnknownUnit operator /(Duration a, double b) => BaseUnit.Divide(a, b);
        //public static UnknownUnit operator /(double a, Duration b) => BaseUnit.Divide(a, b);
        //public static double operator /(Duration a, Duration b) => BaseUnit.DivideResultsInDouble(a, b);
        //public static Duration operator +(Duration a, Duration b) => BaseUnit.Add(a, b);
        //public static Duration operator -(Duration a, Duration b) => BaseUnit.Subtract(a, b);

    }
}
