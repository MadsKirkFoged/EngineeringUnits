using Fractions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{

    public partial class AmountOfSubstance : BaseUnit
    {

        public AmountOfSubstance()
        {
            //Unit.Amount.Count = 1;
        }


        public AmountOfSubstance(double value, AmountOfSubstanceUnit selectedUnit) :this()
        {

            Unit.Amount = selectedUnit;

            //SetLocalValue(value);

            ValueLocalUnit = (decimal)value / (decimal)selectedUnit.Unit.GetActualC();

        }

        public static AmountOfSubstance From(double value, AmountOfSubstanceUnit unit)
        {
            return new AmountOfSubstance(value, unit);
        }

        public double As(AmountOfSubstanceUnit ReturnInThisUnit)
        {

            UnitSystem ReturnInThisUnitSystem = new UnitSystem();

            ReturnInThisUnitSystem.Amount = ReturnInThisUnit;
            ReturnInThisUnitSystem.Amount.Count = 1;


            return (double)ToTheOutSide(ReturnInThisUnitSystem);
        }


        //public void PermanentChangeUnitTo(LengthUnit ReturnInThisUnit)
        //{

        //    //Value = As(ReturnInThisUnit);
        //    Unit.Length.SelectedUnit = ReturnInThisUnit;
        //}


        //Every units needs this
        public static implicit operator AmountOfSubstance(UnknownUnit Unit)
        {
            AmountOfSubstance local = new AmountOfSubstance();

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
