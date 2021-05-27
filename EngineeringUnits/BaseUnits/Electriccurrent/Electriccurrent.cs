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


        public ElectricCurrent(double value, ElectricCurrentUnit unit) :this()
        {
            Unit.Electriccurrent = unit;

            SetLocalValue(value);
        }



        public double As(ElectricCurrentUnit ReturnInThisUnit)
        {
            UnitSystem ReturnInThisUnitSystem = new UnitSystem();
            ReturnInThisUnitSystem.Electriccurrent = ReturnInThisUnit;
            ReturnInThisUnitSystem.Electriccurrent.Count = 1;

            return ToTheOutSide(ReturnInThisUnitSystem);
        }

        public static implicit operator ElectricCurrent(UnknownUnit Unit)
        {
            ElectricCurrent local = new ElectricCurrent(0, ElectricCurrentUnit.SI);

            local.Transform(Unit);
            return local;
        }



    }
}
