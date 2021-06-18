using Fractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class DynamicViscosity : BaseUnit
    {

        public DynamicViscosity()
        {
            Name = "DynamicViscosity";
        }

        public DynamicViscosity(decimal value, DynamicViscosityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public DynamicViscosity(double value, DynamicViscosityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public DynamicViscosity(int value, DynamicViscosityUnit selectedUnit) : base(value, selectedUnit.Unit) { }


        public static DynamicViscosity From(double value, DynamicViscosityUnit unit) => new DynamicViscosity(value, unit);
        public double As(DynamicViscosityUnit ReturnInThisUnit) => (double)ToTheOutSide(ReturnInThisUnit.Unit);
        public DynamicViscosity ToUnit(DynamicViscosityUnit selectedUnit) => new DynamicViscosity(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public DynamicViscosity Zero => new DynamicViscosity(0, DynamicViscosityUnit.SI);

        public static implicit operator DynamicViscosity(UnknownUnit Unit)
        {
            DynamicViscosity local = new DynamicViscosity(0, DynamicViscosityUnit.SI);

            local.Transform(Unit);
            return local;
        }




    }
}
