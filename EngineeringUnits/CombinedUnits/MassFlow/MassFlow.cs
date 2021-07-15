using Fractions;
using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using EngineeringUnits.Units;

namespace EngineeringUnits
{

    public partial class MassFlow : BaseUnit
    {

        public MassFlow()
        {
            Unit = MassFlowUnit.SI.Unit.Copy();
        }


        public MassFlow(decimal value, MassFlowUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public MassFlow(double value, MassFlowUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public MassFlow(int value, MassFlowUnit selectedUnit) : base(value, selectedUnit.Unit) { }


        public static MassFlow From(double value, MassFlowUnit unit) => new MassFlow(value, unit);
        public double As(MassFlowUnit ReturnInThisUnit) => (double)ToTheOutSide(ReturnInThisUnit.Unit);
        public MassFlow ToUnit(MassFlowUnit selectedUnit) => new MassFlow(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static MassFlow Zero => new MassFlow(0, MassFlowUnit.SI);

        public static implicit operator MassFlow(UnknownUnit Unit)
        {
            MassFlow local = new MassFlow(0, MassFlowUnit.SI);

            local.Transform(Unit);
            return local;
        }



    }
}
