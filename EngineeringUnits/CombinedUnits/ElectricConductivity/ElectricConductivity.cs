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

        public static ElectricConductivity From(double value, ElectricConductivityUnit unit) => new ElectricConductivity(value, unit);
        public double As(ElectricConductivityUnit ReturnInThisUnit) => (double)ToTheOutSide(ReturnInThisUnit.Unit);
        public ElectricConductivity ToUnit(ElectricConductivityUnit selectedUnit) => new ElectricConductivity(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static ElectricConductivity Zero => new ElectricConductivity(0, ElectricConductivityUnit.SI);

        public static implicit operator ElectricConductivity(UnknownUnit Unit) => new ElectricConductivity(Unit, ElectricConductivityUnit.SI);


    }
}
