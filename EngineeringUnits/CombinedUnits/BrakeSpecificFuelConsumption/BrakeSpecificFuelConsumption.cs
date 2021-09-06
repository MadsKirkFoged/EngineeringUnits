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

        public static BrakeSpecificFuelConsumption From(double value, BrakeSpecificFuelConsumptionUnit unit) => new BrakeSpecificFuelConsumption(value, unit);
        public double As(BrakeSpecificFuelConsumptionUnit ReturnInThisUnit) => (double)ToTheOutSide(ReturnInThisUnit.Unit);
        public BrakeSpecificFuelConsumption ToUnit(BrakeSpecificFuelConsumptionUnit selectedUnit) => new BrakeSpecificFuelConsumption(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static BrakeSpecificFuelConsumption Zero => new BrakeSpecificFuelConsumption(0, BrakeSpecificFuelConsumptionUnit.SI);

        public static implicit operator BrakeSpecificFuelConsumption(UnknownUnit Unit) => new BrakeSpecificFuelConsumption(Unit, BrakeSpecificFuelConsumptionUnit.SI);


    }
}
