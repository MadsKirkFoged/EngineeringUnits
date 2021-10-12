using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class ElectricCurrentDensity : BaseUnit
    {

        public ElectricCurrentDensity() { }
        public ElectricCurrentDensity(decimal value, ElectricCurrentDensityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ElectricCurrentDensity(double value, ElectricCurrentDensityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ElectricCurrentDensity(int value, ElectricCurrentDensityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ElectricCurrentDensity(UnknownUnit value) : base(value) { }

        public ElectricCurrentDensity(UnknownUnit value, ElectricCurrentDensityUnit selectedUnit) : base(value, selectedUnit.Unit) { }

        public static ElectricCurrentDensity From(double value, ElectricCurrentDensityUnit unit) => new(value, unit);
        public double As(ElectricCurrentDensityUnit ReturnInThisUnit) => ToTheOutSideDouble(ReturnInThisUnit.Unit);
        public ElectricCurrentDensity ToUnit(ElectricCurrentDensityUnit selectedUnit) => new(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static ElectricCurrentDensity Zero => new(0, ElectricCurrentDensityUnit.SI);

        public static implicit operator ElectricCurrentDensity(UnknownUnit Unit) => new(Unit, ElectricCurrentDensityUnit.SI);

        public static implicit operator ElectricCurrentDensity(int zero)
        {
            if (zero != 0)
                throw new WrongUnitException($"You need to give it a unit unless you set it to 0 (zero)!");

            return Zero;
        }


    }
}
