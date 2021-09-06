using EngineeringUnits.Units;


namespace EngineeringUnits
{

    public partial class ElectricCurrent : BaseUnit
    {

        public ElectricCurrent() { }
        public ElectricCurrent(decimal value, ElectricCurrentUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ElectricCurrent(double value, ElectricCurrentUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ElectricCurrent(int value, ElectricCurrentUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ElectricCurrent(UnknownUnit value) : base(value) { }

        public ElectricCurrent(UnknownUnit value, ElectricCurrentUnit selectedUnit) : base(value, selectedUnit.Unit) { }

        public static ElectricCurrent From(double value, ElectricCurrentUnit unit) => new ElectricCurrent(value, unit);
        public double As(ElectricCurrentUnit ReturnInThisUnit) => (double)ToTheOutSide(ReturnInThisUnit.Unit);
        public ElectricCurrent ToUnit(ElectricCurrentUnit selectedUnit) => new ElectricCurrent(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static ElectricCurrent Zero => new ElectricCurrent(0, ElectricCurrentUnit.SI);

        public static implicit operator ElectricCurrent(UnknownUnit Unit) => new ElectricCurrent(Unit, ElectricCurrentUnit.SI);

    }
}
