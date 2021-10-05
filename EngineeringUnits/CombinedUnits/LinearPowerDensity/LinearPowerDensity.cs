﻿using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class LinearPowerDensity : BaseUnit
    {

        public LinearPowerDensity() { }
        public LinearPowerDensity(decimal value, LinearPowerDensityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public LinearPowerDensity(double value, LinearPowerDensityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public LinearPowerDensity(int value, LinearPowerDensityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public LinearPowerDensity(UnknownUnit value) : base(value) { }

        public LinearPowerDensity(UnknownUnit value, LinearPowerDensityUnit selectedUnit) : base(value, selectedUnit.Unit) { }

        public static LinearPowerDensity From(double value, LinearPowerDensityUnit unit) => new(value, unit);
        public double As(LinearPowerDensityUnit ReturnInThisUnit) => ToTheOutSideDouble(ReturnInThisUnit.Unit);
        public LinearPowerDensity ToUnit(LinearPowerDensityUnit selectedUnit) => new(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static LinearPowerDensity Zero => new(0, LinearPowerDensityUnit.SI);

        public static implicit operator LinearPowerDensity(UnknownUnit Unit) => new(Unit, LinearPowerDensityUnit.SI);
    }
}
