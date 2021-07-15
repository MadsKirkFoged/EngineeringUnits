using Fractions;
using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Text;
using EngineeringUnits.Units;

namespace EngineeringUnits
{
    public partial class FuelEfficiency : BaseUnit
    {

        public FuelEfficiency()
        {
            Unit = FuelEfficiencyUnit.SI.Unit.Copy();
        }

        public FuelEfficiency(decimal value, FuelEfficiencyUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public FuelEfficiency(double value, FuelEfficiencyUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public FuelEfficiency(int value, FuelEfficiencyUnit selectedUnit) : base(value, selectedUnit.Unit) { }


        public static FuelEfficiency From(double value, FuelEfficiencyUnit unit) => new FuelEfficiency(value, unit);
        public double As(FuelEfficiencyUnit ReturnInThisUnit) => (double)ToTheOutSide(ReturnInThisUnit.Unit);
        public FuelEfficiency ToUnit(FuelEfficiencyUnit selectedUnit) => new FuelEfficiency(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static FuelEfficiency Zero => new FuelEfficiency(0, FuelEfficiencyUnit.SI);

        public static implicit operator FuelEfficiency(UnknownUnit Unit)
        {
            FuelEfficiency local = new FuelEfficiency(0, FuelEfficiencyUnit.SI);

            local.Transform(Unit);
            return local;
        }




    }
}
