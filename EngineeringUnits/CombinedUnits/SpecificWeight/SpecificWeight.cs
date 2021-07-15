using EngineeringUnits.Units;
using Fractions;
using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class SpecificWeight : BaseUnit
    {

        public SpecificWeight()
        {
            Unit = SpecificWeightUnit.SI.Unit.Copy();
        }

        public SpecificWeight(decimal value, SpecificWeightUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public SpecificWeight(double value, SpecificWeightUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public SpecificWeight(int value, SpecificWeightUnit selectedUnit) : base(value, selectedUnit.Unit) { }


        public static SpecificWeight From(double value, SpecificWeightUnit unit) => new SpecificWeight(value, unit);
        public double As(SpecificWeightUnit ReturnInThisUnit) => (double)ToTheOutSide(ReturnInThisUnit.Unit);
        public SpecificWeight ToUnit(SpecificWeightUnit selectedUnit) => new SpecificWeight(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static SpecificWeight Zero => new SpecificWeight(0, SpecificWeightUnit.SI);

        public static implicit operator SpecificWeight(UnknownUnit Unit)
        {
            SpecificWeight local = new SpecificWeight(0, SpecificWeightUnit.SI);

            local.Transform(Unit);
            return local;
        }




    }
}
