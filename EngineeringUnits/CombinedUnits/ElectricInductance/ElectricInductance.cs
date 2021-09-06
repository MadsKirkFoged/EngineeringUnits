using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class ElectricInductance : BaseUnit
    {

        public ElectricInductance() { }
        public ElectricInductance(decimal value, ElectricInductanceUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ElectricInductance(double value, ElectricInductanceUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ElectricInductance(int value, ElectricInductanceUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ElectricInductance(UnknownUnit value) : base(value) { }

        public ElectricInductance(UnknownUnit value, ElectricInductanceUnit selectedUnit) : base(value, selectedUnit.Unit) { }

        public static ElectricInductance From(double value, ElectricInductanceUnit unit) => new ElectricInductance(value, unit);
        public double As(ElectricInductanceUnit ReturnInThisUnit) => (double)ToTheOutSide(ReturnInThisUnit.Unit);
        public ElectricInductance ToUnit(ElectricInductanceUnit selectedUnit) => new ElectricInductance(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static ElectricInductance Zero => new ElectricInductance(0, ElectricInductanceUnit.SI);

        public static implicit operator ElectricInductance(UnknownUnit Unit) => new ElectricInductance(Unit, ElectricInductanceUnit.SI);


    }
}
