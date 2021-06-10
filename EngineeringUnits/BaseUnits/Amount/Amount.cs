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
            Name = "AmountOfSubstance";
        }


        public AmountOfSubstance(double value, AmountOfSubstanceUnit selectedUnit) :this()
        {
            Unit.Amount = selectedUnit;
            SetValue(value);
        }

        public static AmountOfSubstance From(double value, AmountOfSubstanceUnit unit)
        {
            return new AmountOfSubstance(value, unit);
        }

        public double As(AmountOfSubstanceUnit ReturnInThisUnit)
        {
            return (double)ToTheOutSide(ReturnInThisUnit.Unit);
        }
      

        public static implicit operator AmountOfSubstance(UnknownUnit Unit)
        {
            AmountOfSubstance local = new AmountOfSubstance(0, AmountOfSubstanceUnit.SI);

            local.Transform(Unit);
            return local;
        }



    }
}
