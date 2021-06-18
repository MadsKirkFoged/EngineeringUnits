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

        public Length(decimal value, LengthUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Length(double value, LengthUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Length(int value, LengthUnit selectedUnit) : base(value, selectedUnit.Unit) { }


        public static Length From(double value, LengthUnit unit) => new Length(value, unit);
        public double As(LengthUnit ReturnInThisUnit) => (double)ToTheOutSide(ReturnInThisUnit.Unit);
        public Length ToUnit(LengthUnit selectedUnit) => new Length(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public Length Zero => new Length(0, LengthUnit.SI);

        public static implicit operator Length(UnknownUnit Unit)
        {
            Length local = new Length(0, LengthUnit.SI);

            local.Transform(Unit);
            return local;
        }



    }
}
