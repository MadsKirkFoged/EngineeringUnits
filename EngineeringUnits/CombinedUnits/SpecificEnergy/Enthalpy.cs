using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{

    public partial class Enthalpy : SpecificEnergy
    {

        public Enthalpy()
        {
            Name = "Enthalpy";
        }


        public Enthalpy(double value, SpecificEnergyUnit unit) : base(value, unit) { }
        

        //Every units needs this
        public static implicit operator Enthalpy(UnknownUnit Unit)
        {
            Enthalpy local = new Enthalpy(0, SpecificEnergyUnit.JoulePerKilogram);

            local.Transform(Unit);
            return local;
        }



    }
}
