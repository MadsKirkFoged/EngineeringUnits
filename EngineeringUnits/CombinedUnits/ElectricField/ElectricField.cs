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

        public static ElectricField From(double value, ElectricFieldUnit unit) => new ElectricField(value, unit);
        public double As(ElectricFieldUnit ReturnInThisUnit) => (double)ToTheOutSide(ReturnInThisUnit.Unit);
        public ElectricField ToUnit(ElectricFieldUnit selectedUnit) => new ElectricField(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static ElectricField Zero => new ElectricField(0, ElectricFieldUnit.SI);

        public static implicit operator ElectricField(UnknownUnit Unit) => new ElectricField(Unit, ElectricFieldUnit.SI);


    }
}
