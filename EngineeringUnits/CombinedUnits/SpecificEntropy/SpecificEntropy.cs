using Fractions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{

    public partial class SpecificEntropy : BaseUnit
    {

        public SpecificEntropy()
        {
            Name = "Specific Heat Capacity";
        }


        public SpecificEntropy(double value, SpecificEntropyUnit selectedUnit) : this()
        {

            Unit = selectedUnit.Unit;
            //SetLocalValue(value);
            ValueLocalUnit = (decimal)value / (decimal)selectedUnit.Unit.GetActualC();
        }

        public double As(SpecificEntropyUnit energyUnit)
        {
            return (double)ToTheOutSide(energyUnit.Unit);
        }

        //Every units needs this
        public static implicit operator SpecificEntropy(UnknownUnit Unit)
        {
            SpecificEntropy local = new SpecificEntropy(0, SpecificEntropyUnit.JoulePerKilogramKelvin);

            local.Transform(Unit);
            return local;
        }



    }
}
