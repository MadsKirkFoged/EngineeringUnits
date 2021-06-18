using Fractions;
using Newtonsoft.Json;
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



        public AmountOfSubstance(decimal value, AmountOfSubstanceUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public AmountOfSubstance(double value,  AmountOfSubstanceUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public AmountOfSubstance(int value,     AmountOfSubstanceUnit selectedUnit) : base(value, selectedUnit.Unit) { }


        public static AmountOfSubstance From(double value, AmountOfSubstanceUnit unit) => new AmountOfSubstance(value, unit);
        public double As(AmountOfSubstanceUnit ReturnInThisUnit) => (double)ToTheOutSide(ReturnInThisUnit.Unit);      
        public AmountOfSubstance ToUnit(AmountOfSubstanceUnit selectedUnit) => new AmountOfSubstance(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static AmountOfSubstance Zero => new AmountOfSubstance(0, AmountOfSubstanceUnit.SI);

        public static implicit operator AmountOfSubstance(UnknownUnit Unit)
        {
            AmountOfSubstance local = new AmountOfSubstance(0, AmountOfSubstanceUnit.SI);

            local.Transform(Unit);
            return local;
        }



    }
}
