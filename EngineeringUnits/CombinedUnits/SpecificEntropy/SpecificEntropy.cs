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


        public SpecificEntropy(decimal value, SpecificEntropyUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public SpecificEntropy(double value, SpecificEntropyUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public SpecificEntropy(int value, SpecificEntropyUnit selectedUnit) : base(value, selectedUnit.Unit) { }


        public static SpecificEntropy From(double value, SpecificEntropyUnit unit) => new SpecificEntropy(value, unit);
        public double As(SpecificEntropyUnit ReturnInThisUnit) => (double)ToTheOutSide(ReturnInThisUnit.Unit);
        public SpecificEntropy ToUnit(SpecificEntropyUnit selectedUnit) => new SpecificEntropy(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public SpecificEntropy Zero => new SpecificEntropy(0, SpecificEntropyUnit.SI);

        public static implicit operator SpecificEntropy(UnknownUnit Unit)
        {
            SpecificEntropy local = new SpecificEntropy(0, SpecificEntropyUnit.SI);

            local.Transform(Unit);
            return local;
        }




    }
}
