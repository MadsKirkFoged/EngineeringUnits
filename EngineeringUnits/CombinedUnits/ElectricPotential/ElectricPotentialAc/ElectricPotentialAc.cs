using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class ElectricPotentialAc : BaseUnit
    {

        public ElectricPotentialAc()
        {
            //Unit = new UnitSystem(ElectricPotentialUnit.SI);
        }

        public ElectricPotentialAc(decimal value, ElectricPotentialUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ElectricPotentialAc(double value, ElectricPotentialUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ElectricPotentialAc(int value, ElectricPotentialUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ElectricPotentialAc(UnknownUnit value) : base(value) { }

        public static ElectricPotentialAc From(double value, ElectricPotentialUnit unit) => new(value, unit);
        public double As(ElectricPotentialUnit ReturnInThisUnit) => this.GetValueAsDouble(ReturnInThisUnit.Unit);
        public ElectricPotentialAc ToUnit(ElectricPotentialUnit selectedUnit) => new(this.GetValueAs(selectedUnit.Unit), selectedUnit);
        public static ElectricPotentialAc Zero => new(0, ElectricPotentialUnit.SI);

        public static implicit operator ElectricPotentialAc(UnknownUnit Unit) => new(Unit);

        public static implicit operator ElectricPotentialAc(int zero)
        {
            if (zero != 0)
                throw new WrongUnitException($"You need to give it a unit unless you set it to 0 (zero)!");

            return Zero;
        }




    }
}
