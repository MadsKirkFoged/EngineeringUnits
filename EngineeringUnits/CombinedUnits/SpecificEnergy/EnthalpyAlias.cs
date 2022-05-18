using System;
using System.Collections.Generic;
using System.Text;
using EngineeringUnits.Units;

namespace EngineeringUnits
{
    public partial class Enthalpy : BaseUnit
    {
        public static implicit operator Enthalpy(SpecificEnergy Unit) => new(Unit);
        public static implicit operator SpecificEnergy(Enthalpy Unit) => new(Unit);
    }
}
