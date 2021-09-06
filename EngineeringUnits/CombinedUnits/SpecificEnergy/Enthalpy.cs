using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using EngineeringUnits.Units;

namespace EngineeringUnits
{

    public partial class Enthalpy : SpecificEnergy
    {

        public Enthalpy()
        {
            //Unit = SpecificEnergyUnit.SI.Unit.Copy();
        }


        public Enthalpy(decimal value, SpecificEnergyUnit selectedUnit) : base(value, selectedUnit) { }
        public Enthalpy(double value, SpecificEnergyUnit selectedUnit) : base(value, selectedUnit) { }
        public Enthalpy(int value, SpecificEnergyUnit selectedUnit) : base(value, selectedUnit) { }


        //public static Enthalpy From(double value, SpecificEnergyUnit unit) => new Enthalpy(value, unit);
        //public double As(SpecificEnergyUnit ReturnInThisUnit) => (double)ToTheOutSide(ReturnInThisUnit.Unit);
        //public Enthalpy ToUnit(SpecificEnergyUnit selectedUnit) => new Enthalpy(ToTheOutSide(selectedUnit.Unit), selectedUnit);


        public static implicit operator Enthalpy(UnknownUnit Unit)
        {
            Enthalpy local = new Enthalpy(0, SpecificEnergyUnit.SI);

            local.Transform(Unit);
            return local;
        }



    }
}
