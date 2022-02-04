﻿using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class MolarEnergy : BaseUnit
    {

        public MolarEnergy() { }
        public MolarEnergy(decimal value, MolarEnergyUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public MolarEnergy(double value, MolarEnergyUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public MolarEnergy(int value, MolarEnergyUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public MolarEnergy(UnknownUnit value) : base(value) { }

        public MolarEnergy(UnknownUnit value, MolarEnergyUnit selectedUnit) : base(value, selectedUnit.Unit) { }

        public static MolarEnergy From(double value, MolarEnergyUnit unit) => new(value, unit);
        public double As(MolarEnergyUnit ReturnInThisUnit) => ToTheOutSideDouble(ReturnInThisUnit.Unit);
        public MolarEnergy ToUnit(MolarEnergyUnit selectedUnit) => new(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static MolarEnergy Zero => new(0, MolarEnergyUnit.SI);

        public static implicit operator MolarEnergy(UnknownUnit Unit) => new(Unit);

        public static implicit operator MolarEnergy(int zero)
        {
            if (zero != 0)
                throw new WrongUnitException($"You need to give it a unit unless you set it to 0 (zero)!");

            return Zero;
        }

    }
}
