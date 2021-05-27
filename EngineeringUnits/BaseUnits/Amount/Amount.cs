using Fractions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{

    public partial class Amount : BaseUnit
    {

        public Amount()
        {
            Unit.Amount.Count = 1;
        }


        public Amount(double value, AmountOfSubstanceUnit unit) :this()
        {

            Unit.Amount = unit;

            SetLocalValue(value);

        }

        public static Amount From(double value, AmountOfSubstanceUnit unit)
        {
            return new Amount(value, unit);
        }

        public double As(AmountOfSubstanceUnit ReturnInThisUnit)
        {

            UnitSystem ReturnInThisUnitSystem = new UnitSystem();

            ReturnInThisUnitSystem.Amount = ReturnInThisUnit;
            ReturnInThisUnitSystem.Amount.Count = 1;


            return ToTheOutSide(ReturnInThisUnitSystem);
        }


        //public void PermanentChangeUnitTo(LengthUnit ReturnInThisUnit)
        //{

        //    //Value = As(ReturnInThisUnit);
        //    Unit.Length.SelectedUnit = ReturnInThisUnit;
        //}


        //Every units needs this
        public static implicit operator Amount(UnknownUnit Unit)
        {
            Amount local = new Amount();

            if (local.Unit != Unit.baseUnit.Unit)
            {
                throw new InvalidOperationException("Units did not result in Length!");
            }

            local.ValueLocalUnit = Unit.baseUnit.ValueLocalUnit;
            local.Unit = Unit.baseUnit.Unit;

            return local;
        }



    }
}
