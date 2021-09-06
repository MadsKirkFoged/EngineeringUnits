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

        public static ElectricAdmittance From(double value, ElectricAdmittanceUnit unit) => new ElectricAdmittance(value, unit);
        public double As(ElectricAdmittanceUnit ReturnInThisUnit) => (double)ToTheOutSide(ReturnInThisUnit.Unit);
        public ElectricAdmittance ToUnit(ElectricAdmittanceUnit selectedUnit) => new ElectricAdmittance(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static ElectricAdmittance Zero => new ElectricAdmittance(0, ElectricAdmittanceUnit.SI);

        public static implicit operator ElectricAdmittance(UnknownUnit Unit) => new ElectricAdmittance(Unit, ElectricAdmittanceUnit.SI);


    }
}
