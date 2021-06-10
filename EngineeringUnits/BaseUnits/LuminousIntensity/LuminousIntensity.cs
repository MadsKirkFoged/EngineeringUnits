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
            SetValue(value);
        }

        public static LuminousIntensity From(double value, LuminousIntensityUnit unit)
        {
            return new LuminousIntensity(value, unit);
        }

        public double As(ElectricCurrentUnit ReturnInThisUnit)
        {
            return (double)ToTheOutSide(ReturnInThisUnit.Unit);
        }

        public static implicit operator LuminousIntensity(UnknownUnit Unit)
        {
            LuminousIntensity local = new LuminousIntensity(0, LuminousIntensityUnit.SI);

            local.Transform(Unit);
            return local;
        }



    }
}
