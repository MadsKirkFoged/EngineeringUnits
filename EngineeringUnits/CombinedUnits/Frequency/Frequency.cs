using Fractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class Frequency : BaseUnit
    {

        public Frequency()
        {
            Name = "Frequency";
        }

        public Frequency(decimal value, FrequencyUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Frequency(double value, FrequencyUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Frequency(int value, FrequencyUnit selectedUnit) : base(value, selectedUnit.Unit) { }


        public static Frequency From(double value, FrequencyUnit unit) => new Frequency(value, unit);
        public double As(FrequencyUnit ReturnInThisUnit) => (double)ToTheOutSide(ReturnInThisUnit.Unit);
        public Frequency ToUnit(FrequencyUnit selectedUnit) => new Frequency(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static Frequency Zero => new Frequency(0, FrequencyUnit.SI);

        public static implicit operator Frequency(UnknownUnit Unit)
        {
            Frequency local = new Frequency(0, FrequencyUnit.SI);

            local.Transform(Unit);
            return local;
        }




    }
}
