using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Fractions;

namespace EngineeringUnits
{

    public partial class Mass : BaseUnit
    {

        public Mass()
        {
            Name = "Mass";
        }


        public Mass(double value, MassUnit selectedUnit) :this()
        {
            Unit.Mass = selectedUnit;
            SetValue(value);
        }

        public static Mass From(double value, MassUnit unit)
        {
            return new Mass(value, unit);
        }

        public double As(MassUnit ReturnInThisUnit)
        {
            return (double)ToTheOutSide(ReturnInThisUnit.Unit);
        }

        public static implicit operator Mass(UnknownUnit Unit)
        {
            Mass local = new Mass(0, MassUnit.SI);

            local.Transform(Unit);
            return local;
        }



    }
}
