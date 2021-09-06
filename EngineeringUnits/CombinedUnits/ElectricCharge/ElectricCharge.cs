using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class ElectricCharge : BaseUnit
    {

        public ElectricCharge() { }
        public ElectricCharge(decimal value, ElectricChargeUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ElectricCharge(double value, ElectricChargeUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ElectricCharge(int value, ElectricChargeUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ElectricCharge(UnknownUnit value) : base(value) { }

        public ElectricCharge(UnknownUnit value, ElectricChargeUnit selectedUnit) : base(value, selectedUnit.Unit) { }

        public static ElectricCharge From(double value, ElectricChargeUnit unit) => new ElectricCharge(value, unit);
        public double As(ElectricChargeUnit ReturnInThisUnit) => (double)ToTheOutSide(ReturnInThisUnit.Unit);
        public ElectricCharge ToUnit(ElectricChargeUnit selectedUnit) => new ElectricCharge(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static ElectricCharge Zero => new ElectricCharge(0, ElectricChargeUnit.SI);

        public static implicit operator ElectricCharge(UnknownUnit Unit) => new ElectricCharge(Unit, ElectricChargeUnit.SI);


    }
}
