using Fractions;
using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Text;
using EngineeringUnits.Units;

namespace EngineeringUnits
{
    public partial class AreaDensity : BaseUnit
    {

        public AreaDensity()
        {
            Unit = AreaDensityUnit.SI.Unit.Copy();
        }

        public AreaDensity(decimal value, AreaDensityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public AreaDensity(double value, AreaDensityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public AreaDensity(int value, AreaDensityUnit selectedUnit) : base(value, selectedUnit.Unit) { }


        public static AreaDensity From(double value, AreaDensityUnit unit) => new AreaDensity(value, unit);
        public double As(AreaDensityUnit ReturnInThisUnit) => (double)ToTheOutSide(ReturnInThisUnit.Unit);
        public AreaDensity ToUnit(AreaDensityUnit selectedUnit) => new AreaDensity(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static AreaDensity Zero => new AreaDensity(0, AreaDensityUnit.SI);

        public static implicit operator AreaDensity(UnknownUnit Unit)
        {
            AreaDensity local = new AreaDensity(0, AreaDensityUnit.SI);

            local.Transform(Unit);
            return local;
        }




    }
}
