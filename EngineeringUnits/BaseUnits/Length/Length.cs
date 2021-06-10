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


        public Length(double value, LengthUnit selectedUnit) :this()
        {
            Unit.Length = selectedUnit;
            SetValue(value);
        }

        public static Length From(double value, LengthUnit unit)
        {
            return new Length(value, unit);
        }


        public double As(LengthUnit ReturnInThisUnit)
        {
            return (double)ToTheOutSide(ReturnInThisUnit.Unit);
        }

        public static implicit operator Length(UnknownUnit Unit)
        {
            Length local = new Length(0, LengthUnit.SI);

            local.Transform(Unit);
            return local;
        }



    }
}
