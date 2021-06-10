using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Fractions;

namespace EngineeringUnits
{

    public partial class ElectricCurrent : BaseUnit
    {

        public ElectricCurrent()
        {
            Name = "ElectricCurrent";
        }


        public ElectricCurrent(double value, ElectricCurrentUnit selectedUnit) :this()
        {
            Unit.Electriccurrent = selectedUnit;
            SetValue(value);
        }

        public static ElectricCurrent From(double value, ElectricCurrentUnit unit)
        {
            return new ElectricCurrent(value, unit);
        }


        public double As(ElectricCurrentUnit ReturnInThisUnit)
        {
            return (double)ToTheOutSide(ReturnInThisUnit.Unit);
        }

        public static implicit operator ElectricCurrent(UnknownUnit Unit)
        {
            ElectricCurrent local = new ElectricCurrent(0, ElectricCurrentUnit.SI);

            local.Transform(Unit);
            return local;
        }



    }
}
