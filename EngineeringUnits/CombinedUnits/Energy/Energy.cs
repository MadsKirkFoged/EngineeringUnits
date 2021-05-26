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
            SetLocalValue((decimal)value);
        }

        public decimal As(EnergyUnit energyUnit)
        {
            return ToTheOutSide(energyUnit.Unit);
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
