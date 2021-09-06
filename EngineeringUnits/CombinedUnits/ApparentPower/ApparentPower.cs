using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class ApparentPower : BaseUnit
    {

        public ApparentPower() { }
        public ApparentPower(decimal value, ApparentPowerUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ApparentPower(double value, ApparentPowerUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ApparentPower(int value, ApparentPowerUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ApparentPower(UnknownUnit value) : base(value) { }

        public ApparentPower(UnknownUnit value, ApparentPowerUnit selectedUnit) : base(value, selectedUnit.Unit) { }

        public static ApparentPower From(double value, ApparentPowerUnit unit) => new ApparentPower(value, unit);
        public double As(ApparentPowerUnit ReturnInThisUnit) => (double)ToTheOutSide(ReturnInThisUnit.Unit);
        public ApparentPower ToUnit(ApparentPowerUnit selectedUnit) => new ApparentPower(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static ApparentPower Zero => new ApparentPower(0, ApparentPowerUnit.SI);

        public static implicit operator ApparentPower(UnknownUnit Unit) => new ApparentPower(Unit, ApparentPowerUnit.SI);


    }
}
