using EngineeringUnits.Units;


namespace EngineeringUnits
{

    public partial class Energy : BaseUnit
    {

        public Energy() { }
        public Energy(decimal value, EnergyUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Energy(double value, EnergyUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Energy(int value, EnergyUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Energy(UnknownUnit value) : base(value) { }

        public Energy(UnknownUnit value, EnergyUnit selectedUnit) : base(value, selectedUnit.Unit) { }

        public static Energy From(double value, EnergyUnit unit) => new(value, unit);
        public double As(EnergyUnit ReturnInThisUnit) => ToTheOutSideDouble(ReturnInThisUnit.Unit);
        public Energy ToUnit(EnergyUnit selectedUnit) => new(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static Energy Zero => new(0, EnergyUnit.SI);

        public static implicit operator Energy(UnknownUnit Unit) => new(Unit, EnergyUnit.SI);

    }
}
