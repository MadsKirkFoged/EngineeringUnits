using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class ElectricConductivity : BaseUnit
    {

        public ElectricConductivity() { }
        public ElectricConductivity(decimal value, ElectricConductivityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ElectricConductivity(double value, ElectricConductivityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ElectricConductivity(int value, ElectricConductivityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ElectricConductivity(UnknownUnit value) : base(value) { }

        public ElectricConductivity(UnknownUnit value, ElectricConductivityUnit selectedUnit) : base(value, selectedUnit.Unit) { }

        public static ElectricConductivity From(double value, ElectricConductivityUnit unit) => new(value, unit);
        public double As(ElectricConductivityUnit ReturnInThisUnit) => ToTheOutSideDouble(ReturnInThisUnit.Unit);
        public ElectricConductivity ToUnit(ElectricConductivityUnit selectedUnit) => new(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static ElectricConductivity Zero => new(0, ElectricConductivityUnit.SI);

        public static implicit operator ElectricConductivity(UnknownUnit Unit) => new(Unit, ElectricConductivityUnit.SI);

        public static implicit operator ElectricConductivity(int zero)
        {
            if (zero != 0)
                throw new WrongUnitException($"You need to give it a unit unless you set it to 0 (zero)!");

            return Zero;
        }


    }
}
