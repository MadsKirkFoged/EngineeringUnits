using Fractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class LinearPowerDensity : BaseUnit
    {

        public LinearPowerDensity()
        {
            Unit = LinearPowerDensityUnit.SI.Unit.Copy();
        }

        public LinearPowerDensity(decimal value, LinearPowerDensityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public LinearPowerDensity(double value, LinearPowerDensityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public LinearPowerDensity(int value, LinearPowerDensityUnit selectedUnit) : base(value, selectedUnit.Unit) { }


        public static LinearPowerDensity From(double value, LinearPowerDensityUnit unit) => new LinearPowerDensity(value, unit);
        public double As(LinearPowerDensityUnit ReturnInThisUnit) => (double)ToTheOutSide(ReturnInThisUnit.Unit);
        public LinearPowerDensity ToUnit(LinearPowerDensityUnit selectedUnit) => new LinearPowerDensity(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static LinearPowerDensity Zero => new LinearPowerDensity(0, LinearPowerDensityUnit.SI);

        public static implicit operator LinearPowerDensity(UnknownUnit Unit)
        {
            LinearPowerDensity local = new LinearPowerDensity(0, LinearPowerDensityUnit.SI);

            local.Transform(Unit);
            return local;
        }




    }
}
