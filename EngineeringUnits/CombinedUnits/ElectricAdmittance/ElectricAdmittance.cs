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

        public ElectricAdmittance(UnknownUnit value, ElectricAdmittanceUnit selectedUnit) : base((decimal)value, selectedUnit.Unit) { }

        public static ElectricAdmittance From(double value, ElectricAdmittanceUnit unit) => new(value, unit);
        public double As(ElectricAdmittanceUnit ReturnInThisUnit) => this.GetValueAsDouble(ReturnInThisUnit.Unit);
        public ElectricAdmittance ToUnit(ElectricAdmittanceUnit selectedUnit) => new(this.GetValueAs(selectedUnit.Unit), selectedUnit);
        public static ElectricAdmittance Zero => new(0, ElectricAdmittanceUnit.SI);

        public static implicit operator ElectricAdmittance(UnknownUnit Unit) => new(Unit);

        public static implicit operator ElectricAdmittance(int zero)
        {
            if (zero != 0)
                throw new WrongUnitException($"You need to give it a unit unless you set it to 0 (zero)!");

            return Zero;
        }


    }
}
