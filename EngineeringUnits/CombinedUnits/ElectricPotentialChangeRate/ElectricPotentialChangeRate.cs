using Fractions;
using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Text;
using EngineeringUnits.Units;

namespace EngineeringUnits
{
    public partial class ElectricPotentialChangeRate : BaseUnit
    {

        public ElectricPotentialChangeRate()
        {
            Unit = ElectricPotentialChangeRateUnit.SI.Unit.Copy();
        }

        public ElectricPotentialChangeRate(decimal value, ElectricPotentialChangeRateUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ElectricPotentialChangeRate(double value, ElectricPotentialChangeRateUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ElectricPotentialChangeRate(int value, ElectricPotentialChangeRateUnit selectedUnit) : base(value, selectedUnit.Unit) { }


        public static ElectricPotentialChangeRate From(double value, ElectricPotentialChangeRateUnit unit) => new ElectricPotentialChangeRate(value, unit);
        public double As(ElectricPotentialChangeRateUnit ReturnInThisUnit) => (double)ToTheOutSide(ReturnInThisUnit.Unit);
        public ElectricPotentialChangeRate ToUnit(ElectricPotentialChangeRateUnit selectedUnit) => new ElectricPotentialChangeRate(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static ElectricPotentialChangeRate Zero => new ElectricPotentialChangeRate(0, ElectricPotentialChangeRateUnit.SI);

        public static implicit operator ElectricPotentialChangeRate(UnknownUnit Unit)
        {
            ElectricPotentialChangeRate local = new ElectricPotentialChangeRate(0, ElectricPotentialChangeRateUnit.SI);

            local.Transform(Unit);
            return local;
        }




    }
}
