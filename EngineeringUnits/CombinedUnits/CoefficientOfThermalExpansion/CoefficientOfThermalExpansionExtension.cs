using System;

namespace EngineeringUnits
{
    public static class CoefficientOfThermalExpansionUnitExtension
    {

        public static CoefficientOfThermalExpansion? IfNullSetToZero(this CoefficientOfThermalExpansion? local)
        {
            if (local is not null)
            {
                return local;
            }

            return CoefficientOfThermalExpansion.Zero;
        }

    }
}                   