using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class ElectricCurrentDensity : BaseUnit
    {

        public ElectricCurrentDensity() { }
        public ElectricCurrentDensity(decimal value, ElectricCurrentDensityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ElectricCurrentDensity(double value, ElectricCurrentDensityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ElectricCurrentDensity(int value, ElectricCurrentDensityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ElectricCurrentDensity(UnknownUnit value) : base(value) { }

        public ElectricCurrentDensity(UnknownUnit value, ElectricCurrentDensityUnit selectedUnit) : base(value, selectedUnit.Unit) { }

        public static ElectricCurrentDensity From(double value, ElectricCurrentDensityUnit unit) => new ElectricCurrentDensity(value, unit);
        public double As(ElectricCurrentDensityUnit ReturnInThisUnit) => (double)ToTheOutSide(ReturnInThisUnit.Unit);
        public ElectricCurrentDensity ToUnit(ElectricCurrentDensityUnit selectedUnit) => new ElectricCurrentDensity(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static ElectricCurrentDensity Zero => new ElectricCurrentDensity(0, ElectricCurrentDensityUnit.SI);

        public static implicit operator ElectricCurrentDensity(UnknownUnit Unit) => new ElectricCurrentDensity(Unit, ElectricCurrentDensityUnit.SI);


    }
}
