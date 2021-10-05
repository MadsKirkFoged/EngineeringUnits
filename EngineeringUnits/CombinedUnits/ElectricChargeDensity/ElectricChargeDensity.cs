using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class ElectricChargeDensity : BaseUnit
    {

        public ElectricChargeDensity() { }
        public ElectricChargeDensity(decimal value, ElectricChargeDensityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ElectricChargeDensity(double value, ElectricChargeDensityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ElectricChargeDensity(int value, ElectricChargeDensityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ElectricChargeDensity(UnknownUnit value) : base(value) { }

        public ElectricChargeDensity(UnknownUnit value, ElectricChargeDensityUnit selectedUnit) : base(value, selectedUnit.Unit) { }

        public static ElectricChargeDensity From(double value, ElectricChargeDensityUnit unit) => new(value, unit);
        public double As(ElectricChargeDensityUnit ReturnInThisUnit) => ToTheOutSideDouble(ReturnInThisUnit.Unit);
        public ElectricChargeDensity ToUnit(ElectricChargeDensityUnit selectedUnit) => new(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static ElectricChargeDensity Zero => new(0, ElectricChargeDensityUnit.SI);

        public static implicit operator ElectricChargeDensity(UnknownUnit Unit) => new(Unit, ElectricChargeDensityUnit.SI);


    }
}
