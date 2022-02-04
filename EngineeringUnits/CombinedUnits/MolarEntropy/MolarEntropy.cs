﻿using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class MolarEntropy : BaseUnit
    {

        public MolarEntropy() { }
        public MolarEntropy(decimal value, MolarEntropyUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public MolarEntropy(double value, MolarEntropyUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public MolarEntropy(int value, MolarEntropyUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public MolarEntropy(UnknownUnit value) : base(value) { }

        public MolarEntropy(UnknownUnit value, MolarEntropyUnit selectedUnit) : base(value, selectedUnit.Unit) { }

        public static MolarEntropy From(double value, MolarEntropyUnit unit) => new(value, unit);
        public double As(MolarEntropyUnit ReturnInThisUnit) => ToTheOutSideDouble(ReturnInThisUnit.Unit);
        public MolarEntropy ToUnit(MolarEntropyUnit selectedUnit) => new(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static MolarEntropy Zero => new(0, MolarEntropyUnit.SI);

        public static implicit operator MolarEntropy(UnknownUnit Unit) => new(Unit);

        public static implicit operator MolarEntropy(int zero)
        {
            if (zero != 0)
                throw new WrongUnitException($"You need to give it a unit unless you set it to 0 (zero)!");

            return Zero;
        }

    }
}
