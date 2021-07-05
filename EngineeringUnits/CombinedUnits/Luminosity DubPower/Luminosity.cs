using Fractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class Luminosity : BaseUnit
    {

        public Luminosity()
        {
            Unit = LuminosityUnit.SI.Unit.Copy();
        }

        public Luminosity(decimal value, LuminosityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Luminosity(double value, LuminosityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Luminosity(int value, LuminosityUnit selectedUnit) : base(value, selectedUnit.Unit) { }


        public static Luminosity From(double value, LuminosityUnit unit) => new Luminosity(value, unit);
        public double As(LuminosityUnit ReturnInThisUnit) => (double)ToTheOutSide(ReturnInThisUnit.Unit);
        public Luminosity ToUnit(LuminosityUnit selectedUnit) => new Luminosity(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static Luminosity Zero => new Luminosity(0, LuminosityUnit.SI);

        public static implicit operator Luminosity(UnknownUnit Unit)
        {
            Luminosity local = new Luminosity(0, LuminosityUnit.SI);

            local.Transform(Unit);
            return local;
        }




    }
}
