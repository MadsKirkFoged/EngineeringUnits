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

        public static LuminousIntensity From(double value, LuminousIntensityUnit unit) => new(value, unit);
        public double As(LuminousIntensityUnit ReturnInThisUnit) => ToTheOutSideDouble(ReturnInThisUnit.Unit);
        public LuminousIntensity ToUnit(LuminousIntensityUnit selectedUnit) => new(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static LuminousIntensity Zero => new(0, LuminousIntensityUnit.SI);

        public static implicit operator LuminousIntensity(UnknownUnit Unit) => new(Unit, LuminousIntensityUnit.SI);


    }
}
