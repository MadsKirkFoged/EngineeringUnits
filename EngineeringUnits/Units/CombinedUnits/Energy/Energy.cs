using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{

    public partial class Energy : BaseUnit
    {

        public Energy()
        {
            Unit.Length.Count = 2;
            Unit.Mass.Count = 1;
            Unit.Duration.Count = -1;

            Name = "Energy";
        }


        //public Energy() :this()
        //{
        //    //Unit.Length.SelectedUnit = unit;
        //    //ValueLocalUnit = Unit.ReturnLocalValue((decimal)value);


        //   // SetLocalValue((decimal)value);
        //}


        public decimal As(LengthUnit ReturnInThisUnit)
        {
            UnitSystem ReturnInThisUnitSystem = new UnitSystem();
            ReturnInThisUnitSystem.Length = ReturnInThisUnit;
            ReturnInThisUnitSystem.Length.Count = 1;

            return ToTheOutSide(ReturnInThisUnitSystem);
        }

        //public static implicit operator Energy(UnknownUnit Unit)
        //{
        //    //Energy local = new Energy(0, LengthUnit.SI);

        //    local.Transform(Unit);
        //    return local;
        //}



    }
}
