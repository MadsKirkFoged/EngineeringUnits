using Fractions;
using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Text;
using EngineeringUnits.Units;

namespace EngineeringUnits
{
    public partial class LinearDensity : BaseUnit
    {

        public LinearDensity()
        {
            Unit = LinearDensityUnit.SI.Unit.Copy();
        }

        public LinearDensity(decimal value, LinearDensityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public LinearDensity(double value, LinearDensityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public LinearDensity(int value, LinearDensityUnit selectedUnit) : base(value, selectedUnit.Unit) { }


        public static LinearDensity From(double value, LinearDensityUnit unit) => new LinearDensity(value, unit);
        public double As(LinearDensityUnit ReturnInThisUnit) => (double)ToTheOutSide(ReturnInThisUnit.Unit);
        public LinearDensity ToUnit(LinearDensityUnit selectedUnit) => new LinearDensity(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static LinearDensity Zero => new LinearDensity(0, LinearDensityUnit.SI);

        public static implicit operator LinearDensity(UnknownUnit Unit)
        {
            LinearDensity local = new LinearDensity(0, LinearDensityUnit.SI);

            local.Transform(Unit);
            return local;
        }




    }
}
