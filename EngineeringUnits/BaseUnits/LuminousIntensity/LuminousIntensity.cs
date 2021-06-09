using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Fractions;

namespace EngineeringUnits
{

    public partial class LuminousIntensity : BaseUnit
    {

        public LuminousIntensity()
        {
            Name = "LuminousIntensity";
        }


        public LuminousIntensity(double value, LuminousIntensityUnit selectedUnit) :this()
        {
            Unit.LuminousIntensity = selectedUnit;

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

        public static implicit operator LuminousIntensity(UnknownUnit Unit)
        {
            LuminousIntensity local = new LuminousIntensity(0, LuminousIntensityUnit.SI);

            local.Transform(Unit);
            return local;
        }



    }
}
