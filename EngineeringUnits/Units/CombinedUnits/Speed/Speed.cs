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
            Unit.Length.Count = 1;
            Unit.Duration.Count = -1;
        }


        public Speed(double value, LengthUnit lengthUnit, DurationUnit durationUnit) : this()
        {
            UnitSystem ReturnInThisUnitSystem = new UnitSystem();

            ReturnInThisUnitSystem.Length.SelectedUnit = lengthUnit;
            ReturnInThisUnitSystem.Length.Count = 1;

            ReturnInThisUnitSystem.Duration.SelectedUnit = durationUnit;
            ReturnInThisUnitSystem.Duration.Count = -1;

            //Convert to 'local' unit
            ValueLocalUnit = UnitSystem.GetLocalUnit(value, ReturnInThisUnitSystem);
            Unit = ReturnInThisUnitSystem;
        }

        public static Speed From(double value, LengthUnit a, DurationUnit b)
        {
            return new Speed(value, a, b);
        }

        public decimal As(LengthUnit lengthUnit, DurationUnit durationUnit)
        {

            UnitSystem ReturnInThisUnitSystem = new UnitSystem();

            ReturnInThisUnitSystem.Length.SelectedUnit = lengthUnit;
            ReturnInThisUnitSystem.Length.Count = 1;

            ReturnInThisUnitSystem.Duration.SelectedUnit = durationUnit;
            ReturnInThisUnitSystem.Duration.Count = -1;

            return Unit.ToTheOutSide(ValueLocalUnit, ReturnInThisUnitSystem) / 1.000000000000000000000000000000000m;
        }

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

            if (local.Unit != Unit.baseUnit.Unit)
            {
                throw new InvalidOperationException("Units did not result in Length!");
            }

            local.ValueLocalUnit = Unit.baseUnit.ValueLocalUnit;
            local.Unit = Unit.baseUnit.Unit;

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
