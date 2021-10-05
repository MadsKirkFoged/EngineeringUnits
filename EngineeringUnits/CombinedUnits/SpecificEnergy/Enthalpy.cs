using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{

    public partial class Enthalpy : BaseUnit
    {

        public Enthalpy() { }
        public Enthalpy(decimal value, SpecificEnergyUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Enthalpy(double value, SpecificEnergyUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Enthalpy(int value, SpecificEnergyUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Enthalpy(UnknownUnit value) : base(value) { }

        public Enthalpy(UnknownUnit value, Enthalpy selectedUnit) : base(value, selectedUnit.Unit) { }

        public static Enthalpy From(double value, SpecificEnergyUnit unit) => new Enthalpy(value, unit);
        public double As(SpecificEnergyUnit ReturnInThisUnit) => (double)ToTheOutSide(ReturnInThisUnit.Unit);
        public Enthalpy ToUnit(SpecificEnergyUnit selectedUnit) => new Enthalpy(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static Enthalpy Zero => new Enthalpy(0, SpecificEnergyUnit.SI);

        public static implicit operator Enthalpy(UnknownUnit Unit) => new Enthalpy(Unit, SpecificEnergyUnit.SI);


        //Alias
        public static implicit operator Enthalpy(SpecificEnergy Unit) => new Enthalpy(Unit);
        public static implicit operator SpecificEnergy(Enthalpy Unit) => new SpecificEnergy(Unit);

    }
}
