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

        public static ElectricCurrent From(double value, ElectricCurrentUnit unit) => new(value, unit);
        public double As(ElectricCurrentUnit ReturnInThisUnit) => ToTheOutSideDouble(ReturnInThisUnit.Unit);
        public ElectricCurrent ToUnit(ElectricCurrentUnit selectedUnit) => new(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static ElectricCurrent Zero => new(0, ElectricCurrentUnit.SI);

        public static implicit operator ElectricCurrent(UnknownUnit Unit) => new(Unit);

        public static implicit operator ElectricCurrent(int zero)
        {
            if (zero != 0)
                throw new WrongUnitException($"You need to give it a unit unless you set it to 0 (zero)!");

            return Zero;
        }

    }
}
