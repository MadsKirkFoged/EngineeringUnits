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
            Name = "Mass";
        }

        public Mass(int value, MassUnit selectedUnit) : this()
        {
            Unit = selectedUnit.Unit;
            SetValue(value);
        }
        public Mass(double value, MassUnit selectedUnit) :this()
        {
            Unit = selectedUnit.Unit;
            SetValue(value);
        }

        public Mass(decimal value, MassUnit selectedUnit) : this()
        {
            Unit = selectedUnit.Unit;
            SetValue(value);
        }

        public static Mass From(double value, MassUnit unit)
        {
            return new Mass(value, unit);
        }

        public double As(MassUnit ReturnInThisUnit)
        {
            return (double)ToTheOutSide(ReturnInThisUnit.Unit);
        }
        public Mass ToUnit(MassUnit selectedUnit)
        {
            return new Mass(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        }

        public static implicit operator Mass(UnknownUnit Unit)
        {
            Mass local = new Mass(0d, MassUnit.SI);

            local.Transform(Unit);
            return local;
        }



    }
}
