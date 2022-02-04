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

        public static ElectricCurrentGradient From(double value, ElectricCurrentGradientUnit unit) => new(value, unit);
        public double As(ElectricCurrentGradientUnit ReturnInThisUnit) => ToTheOutSideDouble(ReturnInThisUnit.Unit);
        public ElectricCurrentGradient ToUnit(ElectricCurrentGradientUnit selectedUnit) => new(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static ElectricCurrentGradient Zero => new(0, ElectricCurrentGradientUnit.SI);

        public static implicit operator ElectricCurrentGradient(UnknownUnit Unit) => new(Unit);

        public static implicit operator ElectricCurrentGradient(int zero)
        {
            if (zero != 0)
                throw new WrongUnitException($"You need to give it a unit unless you set it to 0 (zero)!");

            return Zero;
        }

    }
}
