using System;
using System.Collections.Generic;
using System.Text;
using EngineeringUnits.Units;

namespace EngineeringUnits
{
    public partial class SpecificHeatCapacity : BaseUnit
    {

        public static implicit operator SpecificHeatCapacity(SpecificEntropy Unit) => new(Unit);
        public static implicit operator SpecificEntropy(SpecificHeatCapacity Unit) => new(Unit);


    }
}

