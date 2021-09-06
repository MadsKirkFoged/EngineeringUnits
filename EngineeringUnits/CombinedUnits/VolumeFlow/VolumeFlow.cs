using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class VolumeFlow : BaseUnit
    {

        public VolumeFlow() { }
        public VolumeFlow(decimal value, VolumeFlowUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public VolumeFlow(double value, VolumeFlowUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public VolumeFlow(int value, VolumeFlowUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public VolumeFlow(UnknownUnit value) : base(value) { }

        public VolumeFlow(UnknownUnit value, VolumeFlowUnit selectedUnit) : base(value, selectedUnit.Unit) { }

        public static VolumeFlow From(double value, VolumeFlowUnit unit) => new VolumeFlow(value, unit);
        public double As(VolumeFlowUnit ReturnInThisUnit) => (double)ToTheOutSide(ReturnInThisUnit.Unit);
        public VolumeFlow ToUnit(VolumeFlowUnit selectedUnit) => new VolumeFlow(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static VolumeFlow Zero => new VolumeFlow(0, VolumeFlowUnit.SI);

        public static implicit operator VolumeFlow(UnknownUnit Unit) => new VolumeFlow(Unit, VolumeFlowUnit.SI);

    }
}
