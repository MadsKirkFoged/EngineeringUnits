using Fractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class Area : BaseUnit
    {

        public Area()
        {
            Name = "Area";
        }

        public Area(int value, AreaUnit selectedUnit) : this()
        {
            Unit = selectedUnit.Unit;
            SetValue(value);
        }
        public Area(double value, AreaUnit selectedUnit) : this()
        {
            Unit = selectedUnit.Unit;
            SetValue(value);
        }
        public Area(Decimal value, AreaUnit selectedUnit) : this()
        {
            Unit = selectedUnit.Unit;
            SetValue(value);
        }

        public static Area From(double value, AreaUnit unit)
        {
            return new Area(value, unit);
        }

        public double As(AreaUnit ReturnInThisUnit)
        {
            return (double)ToTheOutSide(ReturnInThisUnit.Unit);
        }

        public Area ToUnit(AreaUnit selectedUnit)
        {
            return new Area(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        }

        //Every units needs this
        public static implicit operator Area(UnknownUnit Unit)
        {
            Area local = new Area(0, AreaUnit.SI);

            local.Transform(Unit);
            return local;
        }




    }
}
