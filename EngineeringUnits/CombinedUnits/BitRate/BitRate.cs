using Fractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class BitRate : BaseUnit
    {

        public BitRate()
        {
            Unit = BitRateUnit.SI.Unit.Copy();
        }

        public BitRate(decimal value, BitRateUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public BitRate(double value, BitRateUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public BitRate(int value, BitRateUnit selectedUnit) : base(value, selectedUnit.Unit) { }


        public static BitRate From(double value, BitRateUnit unit) => new BitRate(value, unit);
        public double As(BitRateUnit ReturnInThisUnit) => (double)ToTheOutSide(ReturnInThisUnit.Unit);
        public BitRate ToUnit(BitRateUnit selectedUnit) => new BitRate(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static BitRate Zero => new BitRate(0, BitRateUnit.SI);

        public static implicit operator BitRate(UnknownUnit Unit)
        {
            BitRate local = new BitRate(0, BitRateUnit.SI);

            local.Transform(Unit);
            return local;
        }




    }
}
