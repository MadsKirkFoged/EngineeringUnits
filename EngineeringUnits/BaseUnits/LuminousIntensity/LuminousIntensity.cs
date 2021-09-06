using EngineeringUnits.Units;


namespace EngineeringUnits
{

    public partial class LuminousIntensity : BaseUnit
    {

        public LuminousIntensity() { }
        public LuminousIntensity(decimal value, LuminousIntensityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public LuminousIntensity(double value, LuminousIntensityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public LuminousIntensity(int value, LuminousIntensityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public LuminousIntensity(UnknownUnit value) : base(value) { }

        public LuminousIntensity(UnknownUnit value, LuminousIntensityUnit selectedUnit) : base(value, selectedUnit.Unit) { }

        public static LuminousIntensity From(double value, LuminousIntensityUnit unit) => new LuminousIntensity(value, unit);
        public double As(LuminousIntensityUnit ReturnInThisUnit) => (double)ToTheOutSide(ReturnInThisUnit.Unit);
        public LuminousIntensity ToUnit(LuminousIntensityUnit selectedUnit) => new LuminousIntensity(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static LuminousIntensity Zero => new LuminousIntensity(0, LuminousIntensityUnit.SI);

        public static implicit operator LuminousIntensity(UnknownUnit Unit) => new LuminousIntensity(Unit, LuminousIntensityUnit.SI);


    }
}
