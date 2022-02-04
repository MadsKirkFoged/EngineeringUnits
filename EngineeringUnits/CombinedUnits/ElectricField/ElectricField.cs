using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class ElectricField : BaseUnit
    {

        public ElectricField() { }
        public ElectricField(decimal value, ElectricFieldUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ElectricField(double value, ElectricFieldUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ElectricField(int value, ElectricFieldUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ElectricField(UnknownUnit value) : base(value) { }

        public ElectricField(UnknownUnit value, ElectricFieldUnit selectedUnit) : base(value, selectedUnit.Unit) { }

        public static ElectricField From(double value, ElectricFieldUnit unit) => new(value, unit);
        public double As(ElectricFieldUnit ReturnInThisUnit) => ToTheOutSideDouble(ReturnInThisUnit.Unit);
        public ElectricField ToUnit(ElectricFieldUnit selectedUnit) => new(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static ElectricField Zero => new(0, ElectricFieldUnit.SI);

        public static implicit operator ElectricField(UnknownUnit Unit) => new(Unit);

        public static implicit operator ElectricField(int zero)
        {
            if (zero != 0)
                throw new WrongUnitException($"You need to give it a unit unless you set it to 0 (zero)!");

            return Zero;
        }


    }
}
