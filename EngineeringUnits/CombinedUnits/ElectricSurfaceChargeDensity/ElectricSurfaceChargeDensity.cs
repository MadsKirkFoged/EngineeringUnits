using EngineeringUnits.Units;

namespace EngineeringUnits
{
    public partial class ElectricSurfaceChargeDensity : BaseUnit
    {

        public ElectricSurfaceChargeDensity() { }
        public ElectricSurfaceChargeDensity(decimal value, ElectricSurfaceChargeDensityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ElectricSurfaceChargeDensity(double value, ElectricSurfaceChargeDensityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ElectricSurfaceChargeDensity(int value, ElectricSurfaceChargeDensityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ElectricSurfaceChargeDensity(UnknownUnit value) : base(value) { }

        public ElectricSurfaceChargeDensity(UnknownUnit value, ElectricSurfaceChargeDensityUnit selectedUnit) : base(value, selectedUnit.Unit) { }

        public static ElectricSurfaceChargeDensity From(double value, ElectricSurfaceChargeDensityUnit unit) => new ElectricSurfaceChargeDensity(value, unit);
        public double As(ElectricSurfaceChargeDensityUnit ReturnInThisUnit) => (double)ToTheOutSide(ReturnInThisUnit.Unit);
        public ElectricSurfaceChargeDensity ToUnit(ElectricSurfaceChargeDensityUnit selectedUnit) => new ElectricSurfaceChargeDensity(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static ElectricSurfaceChargeDensity Zero => new ElectricSurfaceChargeDensity(0, ElectricSurfaceChargeDensityUnit.SI);

        public static implicit operator ElectricSurfaceChargeDensity(UnknownUnit Unit) => new ElectricSurfaceChargeDensity(Unit, ElectricSurfaceChargeDensityUnit.SI);


    }
}
