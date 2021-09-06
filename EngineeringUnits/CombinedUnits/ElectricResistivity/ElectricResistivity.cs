using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class ElectricResistivity : BaseUnit
    {

        public ElectricResistivity() { }
        public ElectricResistivity(decimal value, ElectricResistivityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ElectricResistivity(double value, ElectricResistivityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ElectricResistivity(int value, ElectricResistivityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ElectricResistivity(UnknownUnit value) : base(value) { }

        public ElectricResistivity(UnknownUnit value, ElectricResistivityUnit selectedUnit) : base(value, selectedUnit.Unit) { }

        public static ElectricResistivity From(double value, ElectricResistivityUnit unit) => new ElectricResistivity(value, unit);
        public double As(ElectricResistivityUnit ReturnInThisUnit) => (double)ToTheOutSide(ReturnInThisUnit.Unit);
        public ElectricResistivity ToUnit(ElectricResistivityUnit selectedUnit) => new ElectricResistivity(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static ElectricResistivity Zero => new ElectricResistivity(0, ElectricResistivityUnit.SI);

        public static implicit operator ElectricResistivity(UnknownUnit Unit) => new ElectricResistivity(Unit, ElectricResistivityUnit.SI);

    }
}
