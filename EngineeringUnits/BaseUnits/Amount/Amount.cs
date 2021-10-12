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


        public static AmountOfSubstance From(double value, AmountOfSubstanceUnit unit) => new(value, unit);
        public double As(AmountOfSubstanceUnit ReturnInThisUnit) => ToTheOutSideDouble(ReturnInThisUnit.Unit);
        public AmountOfSubstance ToUnit(AmountOfSubstanceUnit selectedUnit) => new(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static AmountOfSubstance Zero => new(0, AmountOfSubstanceUnit.SI);

        public static implicit operator AmountOfSubstance(UnknownUnit Unit) => new(Unit);

        public static implicit operator AmountOfSubstance(int zero)
        {
            if (zero != 0)
                throw new WrongUnitException($"You need to give it a unit unless you set it to 0 (zero)!");

            return Zero;
        }

    }
}



