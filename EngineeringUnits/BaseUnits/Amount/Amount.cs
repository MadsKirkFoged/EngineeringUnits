using EngineeringUnits.Units;


namespace EngineeringUnits
{

    public partial class AmountOfSubstance : BaseUnit
    {

        public AmountOfSubstance()
        {
            Unit = AmountOfSubstanceUnit.SI.Unit;
        }


        public AmountOfSubstance(decimal value, AmountOfSubstanceUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public AmountOfSubstance(double value, AmountOfSubstanceUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public AmountOfSubstance(int value, AmountOfSubstanceUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public AmountOfSubstance(UnknownUnit value) : base(value) { }


        public static AmountOfSubstance From(double value, AmountOfSubstanceUnit unit) => new AmountOfSubstance(value, unit);
        public double As(AmountOfSubstanceUnit ReturnInThisUnit) => (double)ToTheOutSide(ReturnInThisUnit.Unit);
        public AmountOfSubstance ToUnit(AmountOfSubstanceUnit selectedUnit) => new AmountOfSubstance(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static AmountOfSubstance Zero => new AmountOfSubstance(0, AmountOfSubstanceUnit.SI);

        public static implicit operator AmountOfSubstance(UnknownUnit Unit) => new AmountOfSubstance(Unit);

    }
}



