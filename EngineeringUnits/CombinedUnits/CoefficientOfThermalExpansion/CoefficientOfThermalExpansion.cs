using Fractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class CoefficientOfThermalExpansion : BaseUnit
    {

        public CoefficientOfThermalExpansion()
        {
            Unit = CoefficientOfThermalExpansionUnit.SI.Unit.Copy();
        }

        public CoefficientOfThermalExpansion(decimal value, CoefficientOfThermalExpansionUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public CoefficientOfThermalExpansion(double value, CoefficientOfThermalExpansionUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public CoefficientOfThermalExpansion(int value, CoefficientOfThermalExpansionUnit selectedUnit) : base(value, selectedUnit.Unit) { }


        public static CoefficientOfThermalExpansion From(double value, CoefficientOfThermalExpansionUnit unit) => new CoefficientOfThermalExpansion(value, unit);
        public double As(CoefficientOfThermalExpansionUnit ReturnInThisUnit) => (double)ToTheOutSide(ReturnInThisUnit.Unit);
        public CoefficientOfThermalExpansion ToUnit(CoefficientOfThermalExpansionUnit selectedUnit) => new CoefficientOfThermalExpansion(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static CoefficientOfThermalExpansion Zero => new CoefficientOfThermalExpansion(0, CoefficientOfThermalExpansionUnit.SI);

        public static implicit operator CoefficientOfThermalExpansion(UnknownUnit Unit)
        {
            CoefficientOfThermalExpansion local = new CoefficientOfThermalExpansion(0, CoefficientOfThermalExpansionUnit.SI);

            local.Transform(Unit);
            return local;
        }




    }
}
