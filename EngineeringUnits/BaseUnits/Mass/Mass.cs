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
            Name = "Length";
        }


        public Mass(double value, MassUnit unit) :this()
        {
            Unit.Mass = unit;

            SetLocalValue(value);
        }


        public decimal As(MassUnit ReturnInThisUnit)
        {
            UnitSystem ReturnInThisUnitSystem = new UnitSystem();
            ReturnInThisUnitSystem.Mass = ReturnInThisUnit;
            ReturnInThisUnitSystem.Mass.Count = 1;

            return (decimal)ToTheOutSide(ReturnInThisUnitSystem);
        }

        public static implicit operator Mass(UnknownUnit Unit)
        {
            Mass local = new Mass(0, MassUnit.SI);

            local.Transform(Unit);
            return local;
        }



    }
}
