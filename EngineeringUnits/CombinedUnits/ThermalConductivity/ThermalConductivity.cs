using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class ThermalConductivity : BaseUnit
    {
        public ThermalConductivity() { }
        public ThermalConductivity(decimal value, ThermalConductivityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ThermalConductivity(double value, ThermalConductivityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ThermalConductivity(int value, ThermalConductivityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ThermalConductivity(UnknownUnit value) : base(value) { }

        public ThermalConductivity(UnknownUnit value, ThermalConductivityUnit selectedUnit) : base(value, selectedUnit.Unit) { }

        public static ThermalConductivity From(double value, ThermalConductivityUnit unit) => new ThermalConductivity(value, unit);
        public double As(ThermalConductivityUnit ReturnInThisUnit) => (double)ToTheOutSide(ReturnInThisUnit.Unit);
        public ThermalConductivity ToUnit(ThermalConductivityUnit selectedUnit) => new ThermalConductivity(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static ThermalConductivity Zero => new ThermalConductivity(0, ThermalConductivityUnit.SI);

        public static implicit operator ThermalConductivity(UnknownUnit Unit) => new ThermalConductivity(Unit, ThermalConductivityUnit.SI);


    }
}
