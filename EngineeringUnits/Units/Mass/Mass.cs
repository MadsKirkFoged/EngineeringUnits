using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{

    public partial class Mass : BaseUnit
    {

        public Mass()
        {
            Unit.Length.Count = 1;
            Name = "Length";
        }


        public Mass(double value, MassUnit unit) :this()
        {
            Unit.Length.SelectedUnit = unit;
            //ValueLocalUnit = Unit.ReturnLocalValue((decimal)value);


            SetLocalValue((decimal)value);
        }


        public decimal As(MassUnit ReturnInThisUnit)
        {
            UnitSystem ReturnInThisUnitSystem = new UnitSystem();
            ReturnInThisUnitSystem.Length.SelectedUnit = ReturnInThisUnit;
            ReturnInThisUnitSystem.Length.Count = 1;

            return ToTheOutSide(ReturnInThisUnitSystem);
        }

        public static implicit operator Mass(UnknownUnit Unit)
        {
            Mass local = new Mass(0, MassUnit.SI);

            local.Transform(Unit);
            return local;
        }



    }
}
