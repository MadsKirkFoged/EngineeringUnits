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

        public Length(int value, LengthUnit selectedUnit) : this()
        {
            Unit = selectedUnit.Unit;
            SetValue(value);
        }
        public Length(double value, LengthUnit selectedUnit) :this()
        {
            Unit = selectedUnit.Unit;
            SetValue(value);
        }

        public Length(decimal value, LengthUnit selectedUnit) : this()
        {
            Unit = selectedUnit.Unit;
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

        public Length ToUnit(LengthUnit selectedUnit)
        {
            return new Length(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        }

        public static implicit operator Length(UnknownUnit Unit)
        {
            Length local = new Length(0d, LengthUnit.SI);

            local.Transform(Unit);
            return local;
        }



    }
}
