using Fractions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{

    public partial class MassFlow : BaseUnit
    {

        public MassFlow()
        {
            Name = "MassFlow";
        }


        public MassFlow(double value, MassFlowUnit selectedUnit) : this()
        {

            Unit = selectedUnit.Unit;
            SetValue(value);
        }

        public double As(MassFlowUnit ReturnInThisUnit)
        {
            return (double)ToTheOutSide(ReturnInThisUnit.Unit);
        }

        //Every units needs this
        public static implicit operator MassFlow(UnknownUnit Unit)
        {
            MassFlow local = new MassFlow(0, MassFlowUnit.SI);

            local.Transform(Unit);
            return local;
        }



    }
}
