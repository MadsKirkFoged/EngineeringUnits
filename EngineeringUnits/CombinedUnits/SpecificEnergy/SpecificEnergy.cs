using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{

    public partial class SpecificEnergy : BaseUnit
    {

        public SpecificEnergy()
        {
            Name = "SpecificEnergy";
        }


        public SpecificEnergy(double value, SpecificEnergyUnit unit) : this()
        {

            Unit = unit.Unit;
            SetLocalValue((decimal)value);
        }

        public decimal As(SpecificEnergy energyUnit)
        {
            return ToTheOutSide(energyUnit.Unit);
        }

        //Every units needs this
        public static implicit operator SpecificEnergy(UnknownUnit Unit)
        {
            SpecificEnergy local = new SpecificEnergy(0, SpecificEnergyUnit.JoulePerKilogram);

            local.Transform(Unit);
            return local;
        }



    }
}
