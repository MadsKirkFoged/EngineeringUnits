using Fractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class ElectricSurfaceChargeDensity : BaseUnit
    {

        public ElectricSurfaceChargeDensity()
        {
            Unit = ElectricSurfaceChargeDensityUnit.SI.Unit.Copy();
        }

        public ElectricSurfaceChargeDensity(decimal value, ElectricSurfaceChargeDensityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ElectricSurfaceChargeDensity(double value, ElectricSurfaceChargeDensityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ElectricSurfaceChargeDensity(int value, ElectricSurfaceChargeDensityUnit selectedUnit) : base(value, selectedUnit.Unit) { }


        public static ElectricSurfaceChargeDensity From(double value, ElectricSurfaceChargeDensityUnit unit) => new ElectricSurfaceChargeDensity(value, unit);
        public double As(ElectricSurfaceChargeDensityUnit ReturnInThisUnit) => (double)ToTheOutSide(ReturnInThisUnit.Unit);
        public ElectricSurfaceChargeDensity ToUnit(ElectricSurfaceChargeDensityUnit selectedUnit) => new ElectricSurfaceChargeDensity(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static ElectricSurfaceChargeDensity Zero => new ElectricSurfaceChargeDensity(0, ElectricSurfaceChargeDensityUnit.SI);

        public static implicit operator ElectricSurfaceChargeDensity(UnknownUnit Unit)
        {
            ElectricSurfaceChargeDensity local = new ElectricSurfaceChargeDensity(0, ElectricSurfaceChargeDensityUnit.SI);

            local.Transform(Unit);
            return local;
        }




    }
}
