using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class ElectricAdmittance : BaseUnit
    {

        public ElectricAdmittance() { }
        public ElectricAdmittance(decimal value, ElectricAdmittanceUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ElectricAdmittance(double value, ElectricAdmittanceUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ElectricAdmittance(int value, ElectricAdmittanceUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ElectricAdmittance(UnknownUnit value) : base(value) { }

        public ElectricAdmittance(UnknownUnit value, ElectricAdmittanceUnit selectedUnit) : base(value, selectedUnit.Unit) { }

        public static ElectricAdmittance From(double value, ElectricAdmittanceUnit unit) => new(value, unit);
        public double As(ElectricAdmittanceUnit ReturnInThisUnit) => ToTheOutSideDouble(ReturnInThisUnit.Unit);
        public ElectricAdmittance ToUnit(ElectricAdmittanceUnit selectedUnit) => new(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static ElectricAdmittance Zero => new(0, ElectricAdmittanceUnit.SI);

        public static implicit operator ElectricAdmittance(UnknownUnit Unit) => new(Unit, ElectricAdmittanceUnit.SI);


    }
}
