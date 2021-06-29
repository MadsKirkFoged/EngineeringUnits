using Fractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class VolumeFlow : BaseUnit
    {

        public VolumeFlow()
        {
            Unit = VolumeFlowUnit.SI.Unit.Copy();
        }

        public VolumeFlow(decimal value, VolumeFlowUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public VolumeFlow(double value, VolumeFlowUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public VolumeFlow(int value, VolumeFlowUnit selectedUnit) : base(value, selectedUnit.Unit) { }


        public static VolumeFlow From(double value, VolumeFlowUnit unit) => new VolumeFlow(value, unit);
        public double As(VolumeFlowUnit ReturnInThisUnit) => (double)ToTheOutSide(ReturnInThisUnit.Unit);
        public VolumeFlow ToUnit(VolumeFlowUnit selectedUnit) => new VolumeFlow(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static VolumeFlow Zero => new VolumeFlow(0, VolumeFlowUnit.SI);

        public static implicit operator VolumeFlow(UnknownUnit Unit)
        {
            VolumeFlow local = new VolumeFlow(0, VolumeFlowUnit.SI);

            local.Transform(Unit);
            return local;
        }




    }
}
