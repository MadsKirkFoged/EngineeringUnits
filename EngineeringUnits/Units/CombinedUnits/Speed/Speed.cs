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
            unitsystem.LengthCount = 1;
            unitsystem.DurationCount = -1;
        }


        public Speed(double value, LengthUnit? a, DurationUnit? b) : this()
        {
            unitsystem.SelectedLengthUnit = a;
            unitsystem.SelectedDurationUnit = b;
            base.Value = value;
        }

        public static Speed From(double value, LengthUnit a, DurationUnit b)
        {
            return new Speed(value, a, b);
        }

        //public double As(LengthUnit a, DurationUnit b)
        //{

        //    UnitSystem local = new UnitSystem();
        //    local.SetUnit(a);
        //    local.SetUnit(b);

        //    return (double)UnitSystem.ValueConvert(unitsystem, local) * Value;
        //}

        //public void ChangeUnitTo(LengthUnit a, DurationUnit b)
        //{

        //    UnitSystem local = new UnitSystem();
        //    local.SetUnit(a);
        //    local.SetUnit(b);

        //    Value = (double)UnitSystem.ValueConvert(unitsystem, local) * Value;

        //    unitsystem.SetUnit(a);
        //    unitsystem.SetUnit(b);
           
        //}


        //Every units needs this
        public static implicit operator Speed(UnknownUnit Unit)
        {
            Speed local = new Speed();

            if (local.unitsystem != Unit.baseUnit.unitsystem)
            {
                throw new InvalidOperationException("Units did not result in Length!");
            }

            local.Value = Unit.baseUnit.Value;
            local.unitsystem = Unit.baseUnit.unitsystem;

            return local;
        }

        //Every units needs this

        //public static UnknownUnit operator *(Speed a, BaseUnit b) => BaseUnit.Multiply(a, b);
        //public static UnknownUnit operator *(Speed a, double b) => BaseUnit.Multiply(a, b);
        //public static UnknownUnit operator *(double a, Speed b) => BaseUnit.Multiply(b, a);
        //public static UnknownUnit operator /(Speed a, BaseUnit b) => BaseUnit.Divide(a, b);
        //public static UnknownUnit operator /(Speed a, double b) => BaseUnit.Divide(a, b);
        //public static UnknownUnit operator /(double a, Speed b) => BaseUnit.Divide(a, b);
        //public static double operator /(Speed a, Speed b) => BaseUnit.DivideResultsInDouble(a, b);
        //public static Speed operator +(Speed a, Speed b) => BaseUnit.Add(a, b);
        //public static Speed operator -(Speed a, Speed b) => BaseUnit.Subtract(a, b);

    }
}
