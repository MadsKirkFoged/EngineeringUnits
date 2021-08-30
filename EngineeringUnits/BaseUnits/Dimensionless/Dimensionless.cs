using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Fractions;
using EngineeringUnits.Units;

namespace EngineeringUnits
{

    public partial class Dimensionless : BaseUnit
    {

        public Dimensionless()
        {
            Unit = DimensionlessUnit.Dimensionless.Unit.Copy();
        }

        public Dimensionless(decimal value, DimensionlessUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Dimensionless(double value, DimensionlessUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Dimensionless(int value, DimensionlessUnit selectedUnit) : base(value, selectedUnit.Unit) { }


        public static Dimensionless From(double value, DimensionlessUnit unit) => new Dimensionless(value, unit);
        public double As(DimensionlessUnit ReturnInThisUnit) => (double)ToTheOutSide(ReturnInThisUnit.Unit);
        public Dimensionless ToUnit(DimensionlessUnit selectedUnit) => new Dimensionless(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static Dimensionless Zero => new Dimensionless(0, DimensionlessUnit.Dimensionless);

        public static implicit operator Dimensionless(UnknownUnit Unit)
        {
            Dimensionless local = new Dimensionless(0, DimensionlessUnit.Dimensionless);

            local.Transform(Unit);
            return local;
        }
        
    }
}
