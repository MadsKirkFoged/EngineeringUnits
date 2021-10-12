using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class BrakeSpecificFuelConsumption : BaseUnit
    {

        public BrakeSpecificFuelConsumption() { }
        public BrakeSpecificFuelConsumption(decimal value, BrakeSpecificFuelConsumptionUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public BrakeSpecificFuelConsumption(double value, BrakeSpecificFuelConsumptionUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public BrakeSpecificFuelConsumption(int value, BrakeSpecificFuelConsumptionUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public BrakeSpecificFuelConsumption(UnknownUnit value) : base(value) { }

        public BrakeSpecificFuelConsumption(UnknownUnit value, BrakeSpecificFuelConsumptionUnit selectedUnit) : base(value, selectedUnit.Unit) { }

        public static BrakeSpecificFuelConsumption From(double value, BrakeSpecificFuelConsumptionUnit unit) => new(value, unit);
        public double As(BrakeSpecificFuelConsumptionUnit ReturnInThisUnit) => ToTheOutSideDouble(ReturnInThisUnit.Unit);
        public BrakeSpecificFuelConsumption ToUnit(BrakeSpecificFuelConsumptionUnit selectedUnit) => new(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static BrakeSpecificFuelConsumption Zero => new(0, BrakeSpecificFuelConsumptionUnit.SI);

        public static implicit operator BrakeSpecificFuelConsumption(UnknownUnit Unit) => new(Unit, BrakeSpecificFuelConsumptionUnit.SI);

        public static implicit operator BrakeSpecificFuelConsumption(int zero)
        {
            if (zero != 0)
                throw new WrongUnitException($"You need to give it a unit unless you set it to 0 (zero)!");

            return Zero;
        }


    }
}
