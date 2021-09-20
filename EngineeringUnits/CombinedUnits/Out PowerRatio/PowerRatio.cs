using EngineeringUnits.Units;
using Fractions;
using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class PowerRatio : BaseUnit
    {

        public PowerRatio()
        {
            Unit = PowerRatioUnit.SI.Unit.Copy();
        }

        public PowerRatio(decimal value, PowerRatioUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public PowerRatio(double value, PowerRatioUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public PowerRatio(int value, PowerRatioUnit selectedUnit) : base(value, selectedUnit.Unit) { }


        public static PowerRatio From(double value, PowerRatioUnit unit) => new PowerRatio(value, unit);
        public double As(PowerRatioUnit ReturnInThisUnit) => ToTheOutSideDouble(ReturnInThisUnit.Unit);
        public PowerRatio ToUnit(PowerRatioUnit selectedUnit) => new PowerRatio(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static PowerRatio Zero => new PowerRatio(0, PowerRatioUnit.SI);

        public static implicit operator PowerRatio(UnknownUnit Unit)
        {
            PowerRatio local = new PowerRatio(0, PowerRatioUnit.SI);

            local.Transform(Unit);
            return local;
        }




    }
}
