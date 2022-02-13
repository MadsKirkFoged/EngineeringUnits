using EngineeringUnits.Units;
using Fractions;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class PowerRatio : BaseUnit
    {

        public PowerRatio()
        {
            Unit = new UnitSystem(PowerRatioUnit.SI);
        }

        public PowerRatio(decimal value, PowerRatioUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public PowerRatio(double value, PowerRatioUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public PowerRatio(int value, PowerRatioUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public PowerRatio(UnknownUnit value) : base(value) { }


        public static PowerRatio From(double value, PowerRatioUnit unit) => new(value, unit);
        public double As(PowerRatioUnit ReturnInThisUnit) => ToTheOutSideDouble(ReturnInThisUnit.Unit);
        public PowerRatio ToUnit(PowerRatioUnit selectedUnit) => new(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static PowerRatio Zero => new(0, PowerRatioUnit.SI);

        public static implicit operator PowerRatio(UnknownUnit Unit) => new(Unit);




    }
}
