using EngineeringUnits.Units;
using Fractions;
using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class Ratio : BaseUnit
    {

        public Ratio()
        {
            Unit = RatioUnit.SI.Unit.Copy();
        }

        public Ratio(decimal value, RatioUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Ratio(double value, RatioUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Ratio(int value, RatioUnit selectedUnit) : base(value, selectedUnit.Unit) { }


        public static Ratio From(double value, RatioUnit unit) => new Ratio(value, unit);
        public double As(RatioUnit ReturnInThisUnit) => (double)ToTheOutSide(ReturnInThisUnit.Unit);
        public Ratio ToUnit(RatioUnit selectedUnit) => new Ratio(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static Ratio Zero => new Ratio(0, RatioUnit.SI);

        public static implicit operator Ratio(UnknownUnit Unit)
        {
            Ratio local = new Ratio(0, RatioUnit.SI);

            local.Transform(Unit);
            return local;
        }




    }
}
