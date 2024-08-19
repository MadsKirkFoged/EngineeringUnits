using System;

namespace EngineeringUnits
{
    public static class SpecificThermalResistanceUnitExtension
    {

        public static SpecificThermalResistance? IfNullSetToZero(this SpecificThermalResistance? local)
        {
            if (local is not null)
            {
                return local;
            }

            return SpecificThermalResistance.Zero;
        }

    }
}                   