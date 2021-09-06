using EngineeringUnits.Units;

namespace EngineeringUnits
{
    public partial class CoefficientOfThermalExpansion : BaseUnit
    {

        public CoefficientOfThermalExpansion() { }
        public CoefficientOfThermalExpansion(decimal value, CoefficientOfThermalExpansionUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public CoefficientOfThermalExpansion(double value, CoefficientOfThermalExpansionUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public CoefficientOfThermalExpansion(int value, CoefficientOfThermalExpansionUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public CoefficientOfThermalExpansion(UnknownUnit value) : base(value) { }

        public CoefficientOfThermalExpansion(UnknownUnit value, CoefficientOfThermalExpansionUnit selectedUnit) : base(value, selectedUnit.Unit) { }

        public static CoefficientOfThermalExpansion From(double value, CoefficientOfThermalExpansionUnit unit) => new CoefficientOfThermalExpansion(value, unit);
        public double As(CoefficientOfThermalExpansionUnit ReturnInThisUnit) => (double)ToTheOutSide(ReturnInThisUnit.Unit);
        public CoefficientOfThermalExpansion ToUnit(CoefficientOfThermalExpansionUnit selectedUnit) => new CoefficientOfThermalExpansion(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static CoefficientOfThermalExpansion Zero => new CoefficientOfThermalExpansion(0, CoefficientOfThermalExpansionUnit.SI);

        public static implicit operator CoefficientOfThermalExpansion(UnknownUnit Unit) => new CoefficientOfThermalExpansion(Unit, CoefficientOfThermalExpansionUnit.SI);


    }
}
