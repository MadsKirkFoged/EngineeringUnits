using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class ElectricCurrentGradient : BaseUnit
    {

        public ElectricCurrentGradient() { }
        public ElectricCurrentGradient(decimal value, ElectricCurrentGradientUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ElectricCurrentGradient(double value, ElectricCurrentGradientUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ElectricCurrentGradient(int value, ElectricCurrentGradientUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ElectricCurrentGradient(UnknownUnit value) : base(value) { }

        public ElectricCurrentGradient(UnknownUnit value, ElectricCurrentGradientUnit selectedUnit) : base(value, selectedUnit.Unit) { }

        public static ElectricCurrentGradient From(double value, ElectricCurrentGradientUnit unit) => new ElectricCurrentGradient(value, unit);
        public double As(ElectricCurrentGradientUnit ReturnInThisUnit) => (double)ToTheOutSide(ReturnInThisUnit.Unit);
        public ElectricCurrentGradient ToUnit(ElectricCurrentGradientUnit selectedUnit) => new ElectricCurrentGradient(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static ElectricCurrentGradient Zero => new ElectricCurrentGradient(0, ElectricCurrentGradientUnit.SI);

        public static implicit operator ElectricCurrentGradient(UnknownUnit Unit) => new ElectricCurrentGradient(Unit, ElectricCurrentGradientUnit.SI);

    }
}
