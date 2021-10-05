using EngineeringUnits.Units;


namespace EngineeringUnits
{

    public partial class MassFlow : BaseUnit
    {

        public MassFlow() { }
        public MassFlow(decimal value, MassFlowUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public MassFlow(double value, MassFlowUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public MassFlow(int value, MassFlowUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public MassFlow(UnknownUnit value) : base(value) { }

        public MassFlow(UnknownUnit value, MassFlowUnit selectedUnit) : base(value, selectedUnit.Unit) { }

        public static MassFlow From(double value, MassFlowUnit unit) => new(value, unit);
        public double As(MassFlowUnit ReturnInThisUnit) => ToTheOutSideDouble(ReturnInThisUnit.Unit);
        public MassFlow ToUnit(MassFlowUnit selectedUnit) => new(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static MassFlow Zero => new(0, MassFlowUnit.SI);

        public static implicit operator MassFlow(UnknownUnit Unit) => new(Unit, MassFlowUnit.SI);

    }
}
