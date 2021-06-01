using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Fractions;

namespace EngineeringUnits
{

    public partial class Length : BaseUnit
    {

        public Length()
        {
            Name = "Length";
        }


        public Length(double value, LengthUnit unit) :this()
        {
            Unit.Length = unit;

            //SetLocalValue(value);

            ValueLocalUnit = (decimal)value;
        }



        public double As(LengthUnit ReturnInThisUnit)
        {
            UnitSystem ReturnInThisUnitSystem = new UnitSystem();
            ReturnInThisUnitSystem.Length = ReturnInThisUnit;
            ReturnInThisUnitSystem.Length.Count = 1;

            return (double)ToTheOutSide(ReturnInThisUnitSystem);
        }

        public static implicit operator Length(UnknownUnit Unit)
        {
            Length local = new Length(0, LengthUnit.SI);

            local.Transform(Unit);
            return local;
        }



    }
}
