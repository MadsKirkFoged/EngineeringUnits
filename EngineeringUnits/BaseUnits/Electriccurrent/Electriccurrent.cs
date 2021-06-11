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

        public ElectricCurrent(int value, ElectricCurrentUnit selectedUnit) : this()
        {
            Unit.Electriccurrent = selectedUnit;
            SetValue(value);
        }

        public ElectricCurrent(double value, ElectricCurrentUnit selectedUnit) :this()
        {
            Unit.Electriccurrent = selectedUnit;
            SetValue(value);
        }

        public ElectricCurrent(decimal value, ElectricCurrentUnit selectedUnit) : this()
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

        public ElectricCurrent ToUnit(ElectricCurrentUnit selectedUnit)
        {
            return new ElectricCurrent(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        }

        public static implicit operator ElectricCurrent(UnknownUnit Unit)
        {
            ElectricCurrent local = new ElectricCurrent(0d, ElectricCurrentUnit.SI);

            local.Transform(Unit);
            return local;
        }



    }
}
