using Fractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class Density : BaseUnit
    {

        public Density()
        {
            Name = "Density";
        }

        public Density(decimal value, DensityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Density(double value, DensityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Density(int value, DensityUnit selectedUnit) : base(value, selectedUnit.Unit) { }


        public static Density From(double value, DensityUnit unit) => new Density(value, unit);
        public double As(DensityUnit ReturnInThisUnit) => (double)ToTheOutSide(ReturnInThisUnit.Unit);
        public Density ToUnit(DensityUnit selectedUnit) => new Density(ToTheOutSide(selectedUnit.Unit), selectedUnit);


        //public static implicit operator Density(UnknownUnit Unit)
        //{
        //    Density local = new Density(0, DensityUnit.SI);

        //    local.Transform(Unit);
        //    return local;
        //}




    }
}
