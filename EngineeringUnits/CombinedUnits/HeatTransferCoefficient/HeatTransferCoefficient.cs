using Fractions;
using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Text;
using EngineeringUnits.Units;

namespace EngineeringUnits
{
    public partial class HeatTransferCoefficient : BaseUnit
    {

        public HeatTransferCoefficient()
        {
            Unit = HeatTransferCoefficientUnit.SI.Unit.Copy();
        }

        public HeatTransferCoefficient(decimal value, HeatTransferCoefficientUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public HeatTransferCoefficient(double value, HeatTransferCoefficientUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public HeatTransferCoefficient(int value, HeatTransferCoefficientUnit selectedUnit) : base(value, selectedUnit.Unit) { }


        public static HeatTransferCoefficient From(double value, HeatTransferCoefficientUnit unit) => new HeatTransferCoefficient(value, unit);
        public double As(HeatTransferCoefficientUnit ReturnInThisUnit) => (double)ToTheOutSide(ReturnInThisUnit.Unit);
        public HeatTransferCoefficient ToUnit(HeatTransferCoefficientUnit selectedUnit) => new HeatTransferCoefficient(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static HeatTransferCoefficient Zero => new HeatTransferCoefficient(0, HeatTransferCoefficientUnit.SI);

        public static implicit operator HeatTransferCoefficient(UnknownUnit Unit)
        {
            HeatTransferCoefficient local = new HeatTransferCoefficient(0, HeatTransferCoefficientUnit.SI);

            local.Transform(Unit);
            return local;
        }




    }
}
