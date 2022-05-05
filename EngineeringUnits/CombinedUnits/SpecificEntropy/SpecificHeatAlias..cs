using System;
using System.Collections.Generic;
using System.Text;
using EngineeringUnits.Units;

namespace EngineeringUnits
{
    public partial class SpecificHeat : BaseUnit
    {

        public static implicit operator SpecificHeat(SpecificEntropy Unit) => new(Unit);
        public static implicit operator SpecificEntropy(SpecificHeat Unit) => new(Unit);


    }
}

