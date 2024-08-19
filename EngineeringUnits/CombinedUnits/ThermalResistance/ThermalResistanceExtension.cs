using System;

namespace EngineeringUnits
{
    public static class ThermalResistanceUnitExtension
    {

        public static ThermalResistance? IfNullSetToZero(this ThermalResistance? local)
        {
            if (local is not null)
            {
                return local;
            }

            return ThermalResistance.Zero;
        }

    }
}                   