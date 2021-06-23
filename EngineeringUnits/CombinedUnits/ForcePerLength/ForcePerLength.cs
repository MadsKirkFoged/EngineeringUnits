using Fractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class ForcePerLength : BaseUnit
    {

        public ForcePerLength()
        {
            Name = "ForcePerLength";
        }

        public ForcePerLength(decimal value, ForcePerLengthUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ForcePerLength(double value, ForcePerLengthUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ForcePerLength(int value, ForcePerLengthUnit selectedUnit) : base(value, selectedUnit.Unit) { }


        public static ForcePerLength From(double value, ForcePerLengthUnit unit) => new ForcePerLength(value, unit);
        public double As(ForcePerLengthUnit ReturnInThisUnit) => (double)ToTheOutSide(ReturnInThisUnit.Unit);
        public ForcePerLength ToUnit(ForcePerLengthUnit selectedUnit) => new ForcePerLength(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static ForcePerLength Zero => new ForcePerLength(0, ForcePerLengthUnit.SI);

        public static implicit operator ForcePerLength(UnknownUnit Unit)
        {
            ForcePerLength local = new ForcePerLength(0, ForcePerLengthUnit.SI);

            local.Transform(Unit);
            return local;

        }




    }
}
