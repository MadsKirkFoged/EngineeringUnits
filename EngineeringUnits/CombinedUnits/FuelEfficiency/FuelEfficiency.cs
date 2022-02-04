using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class FuelEfficiency : BaseUnit
    {

        public FuelEfficiency() { }
        public FuelEfficiency(decimal value, FuelEfficiencyUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public FuelEfficiency(double value, FuelEfficiencyUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public FuelEfficiency(int value, FuelEfficiencyUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public FuelEfficiency(UnknownUnit value) : base(value) { }

        public FuelEfficiency(UnknownUnit value, FuelEfficiencyUnit selectedUnit) : base(value, selectedUnit.Unit) { }

        public static FuelEfficiency From(double value, FuelEfficiencyUnit unit) => new(value, unit);
        public double As(FuelEfficiencyUnit ReturnInThisUnit) => ToTheOutSideDouble(ReturnInThisUnit.Unit);
        public FuelEfficiency ToUnit(FuelEfficiencyUnit selectedUnit) => new(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static FuelEfficiency Zero => new(0, FuelEfficiencyUnit.SI);

        public static implicit operator FuelEfficiency(UnknownUnit Unit) => new(Unit);

        public static implicit operator FuelEfficiency(int zero)
        {
            if (zero != 0)
                throw new WrongUnitException($"You need to give it a unit unless you set it to 0 (zero)!");

            return Zero;
        }


    }
}
