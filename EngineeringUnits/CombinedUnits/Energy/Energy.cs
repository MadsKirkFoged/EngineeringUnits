using Fractions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{

    public partial class Energy : BaseUnit
    {

        public Energy()
        {
            Name = "Energy";
        }


        public Energy(double value, EnergyUnit energyUnit) : this()
        {

            Unit = energyUnit.Unit;
            //SetLocalValue(value);
            ValueLocalUnit = (decimal)value;
        }

        public double As(EnergyUnit energyUnit)
        {
            //return ToTheOutSide(energyUnit.Unit);
            return (double)ToTheOutSide(energyUnit.Unit);
        }

        //Every units needs this
        public static implicit operator Energy(UnknownUnit Unit)
        {
            Energy local = new Energy(0, EnergyUnit.SI);

            local.Transform(Unit);
            return local;
        }



    }
}
