using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class ElectricConductance : BaseUnit
    {

        public ElectricConductance() { }
        public ElectricConductance(decimal value, ElectricConductanceUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ElectricConductance(double value, ElectricConductanceUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ElectricConductance(int value, ElectricConductanceUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ElectricConductance(UnknownUnit value) : base(value) { }

        public ElectricConductance(UnknownUnit value, ElectricConductanceUnit selectedUnit) : base(value, selectedUnit.Unit) { }

        public static ElectricConductance From(double value, ElectricConductanceUnit unit) => new(value, unit);
        public double As(ElectricConductanceUnit ReturnInThisUnit) => ToTheOutSideDouble(ReturnInThisUnit.Unit);
        public ElectricConductance ToUnit(ElectricConductanceUnit selectedUnit) => new(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static ElectricConductance Zero => new(0, ElectricConductanceUnit.SI);

        public static implicit operator ElectricConductance(UnknownUnit Unit) => new(Unit, ElectricConductanceUnit.SI);


    }
}
