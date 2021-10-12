using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class ElectricResistance : BaseUnit
    {

        public ElectricResistance() { }
        public ElectricResistance(decimal value, ElectricResistanceUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ElectricResistance(double value, ElectricResistanceUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ElectricResistance(int value, ElectricResistanceUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ElectricResistance(UnknownUnit value) : base(value) { }

        public ElectricResistance(UnknownUnit value, ElectricResistanceUnit selectedUnit) : base(value, selectedUnit.Unit) { }

        public static ElectricResistance From(double value, ElectricResistanceUnit unit) => new(value, unit);
        public double As(ElectricResistanceUnit ReturnInThisUnit) => ToTheOutSideDouble(ReturnInThisUnit.Unit);
        public ElectricResistance ToUnit(ElectricResistanceUnit selectedUnit) => new(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static ElectricResistance Zero => new(0, ElectricResistanceUnit.SI);

        public static implicit operator ElectricResistance(UnknownUnit Unit) => new(Unit, ElectricResistanceUnit.SI);

        public static implicit operator ElectricResistance(int zero)
        {
            if (zero != 0)
                throw new WrongUnitException($"You need to give it a unit unless you set it to 0 (zero)!");

            return Zero;
        }

    }
}
