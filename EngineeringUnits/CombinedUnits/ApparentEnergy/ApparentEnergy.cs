using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class ApparentEnergy : BaseUnit
    {

        public ApparentEnergy() { }
        public ApparentEnergy(decimal value, ApparentEnergyUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ApparentEnergy(double value, ApparentEnergyUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ApparentEnergy(int value, ApparentEnergyUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ApparentEnergy(UnknownUnit value) : base(value) { }

        public ApparentEnergy(UnknownUnit value, ApparentEnergyUnit selectedUnit) : base(value, selectedUnit.Unit) { }

        public static ApparentEnergy From(double value, ApparentEnergyUnit unit) => new(value, unit);
        public double As(ApparentEnergyUnit ReturnInThisUnit) => GetValueAsDouble(ReturnInThisUnit.Unit);
        public ApparentEnergy ToUnit(ApparentEnergyUnit selectedUnit) => new(GetValueAs(selectedUnit.Unit), selectedUnit);
        public static ApparentEnergy Zero => new(0, ApparentEnergyUnit.SI);

        public static implicit operator ApparentEnergy(UnknownUnit Unit) => new(Unit);

        public static implicit operator ApparentEnergy(int zero)
        {
            if (zero != 0)
                throw new WrongUnitException($"You need to give it a unit unless you set it to 0 (zero)!");

            return Zero;
        }


    }
}
