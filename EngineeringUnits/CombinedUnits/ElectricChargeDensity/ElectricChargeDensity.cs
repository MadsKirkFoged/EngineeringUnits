using Fractions;
using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Text;
using EngineeringUnits.Units;

namespace EngineeringUnits
{
    public partial class ElectricChargeDensity : BaseUnit
    {

        public ElectricChargeDensity()
        {
            Unit = ElectricChargeDensityUnit.SI.Unit.Copy();
        }

        public ElectricChargeDensity(decimal value, ElectricChargeDensityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ElectricChargeDensity(double value, ElectricChargeDensityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ElectricChargeDensity(int value, ElectricChargeDensityUnit selectedUnit) : base(value, selectedUnit.Unit) { }


        public static ElectricChargeDensity From(double value, ElectricChargeDensityUnit unit) => new ElectricChargeDensity(value, unit);
        public double As(ElectricChargeDensityUnit ReturnInThisUnit) => (double)ToTheOutSide(ReturnInThisUnit.Unit);
        public ElectricChargeDensity ToUnit(ElectricChargeDensityUnit selectedUnit) => new ElectricChargeDensity(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static ElectricChargeDensity Zero => new ElectricChargeDensity(0, ElectricChargeDensityUnit.SI);

        public static implicit operator ElectricChargeDensity(UnknownUnit Unit)
        {
            ElectricChargeDensity local = new ElectricChargeDensity(0, ElectricChargeDensityUnit.SI);

            local.Transform(Unit);
            return local;
        }




    }
}
