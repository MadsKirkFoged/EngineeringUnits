using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class HeatTransferCoefficient : BaseUnit
    {

        public HeatTransferCoefficient() { }
        public HeatTransferCoefficient(decimal value, HeatTransferCoefficientUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public HeatTransferCoefficient(double value, HeatTransferCoefficientUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public HeatTransferCoefficient(int value, HeatTransferCoefficientUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public HeatTransferCoefficient(UnknownUnit value) : base(value) { }

        public HeatTransferCoefficient(UnknownUnit value, HeatTransferCoefficientUnit selectedUnit) : base(value, selectedUnit.Unit) { }

        public static HeatTransferCoefficient From(double value, HeatTransferCoefficientUnit unit) => new HeatTransferCoefficient(value, unit);
        public double As(HeatTransferCoefficientUnit ReturnInThisUnit) => (double)ToTheOutSide(ReturnInThisUnit.Unit);
        public HeatTransferCoefficient ToUnit(HeatTransferCoefficientUnit selectedUnit) => new HeatTransferCoefficient(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static HeatTransferCoefficient Zero => new HeatTransferCoefficient(0, HeatTransferCoefficientUnit.SI);

        public static implicit operator HeatTransferCoefficient(UnknownUnit Unit) => new HeatTransferCoefficient(Unit, HeatTransferCoefficientUnit.SI);

    }
}
