using Fractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class Permittivity : BaseUnit
    {

        public Permittivity()
        {
            Unit = PermittivityUnit.SI.Unit.Copy();
        }

        public Permittivity(decimal value, PermittivityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Permittivity(double value, PermittivityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Permittivity(int value, PermittivityUnit selectedUnit) : base(value, selectedUnit.Unit) { }


        public static Permittivity From(double value, PermittivityUnit unit) => new Permittivity(value, unit);
        public double As(PermittivityUnit ReturnInThisUnit) => (double)ToTheOutSide(ReturnInThisUnit.Unit);
        public Permittivity ToUnit(PermittivityUnit selectedUnit) => new Permittivity(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static Permittivity Zero => new Permittivity(0, PermittivityUnit.SI);

        public static implicit operator Permittivity(UnknownUnit Unit)
        {
            Permittivity local = new Permittivity(0, PermittivityUnit.SI);

            local.Transform(Unit);
            return local;
        }




    }
}
