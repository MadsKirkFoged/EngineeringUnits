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

            //SetLocalValue(value);

            ValueLocalUnit = (decimal)value / (decimal)selectedUnit.Unit.GetActualC();
        }



        public double As(ElectricCurrentUnit ReturnInThisUnit)
        {
            UnitSystem ReturnInThisUnitSystem = new UnitSystem();
            ReturnInThisUnitSystem.Electriccurrent = ReturnInThisUnit;
            ReturnInThisUnitSystem.Electriccurrent.Count = 1;

            return (double)ToTheOutSide(ReturnInThisUnitSystem);
        }

        public static implicit operator ElectricCurrent(UnknownUnit Unit)
        {
            ElectricCurrent local = new ElectricCurrent(0, ElectricCurrentUnit.SI);

            local.Transform(Unit);
            return local;
        }



    }
}
