using System;

namespace EngineeringUnits
{
    public static class ThermalConductivityUnitExtension
    {

        public static ThermalConductivity? IfNullSetToZero(this ThermalConductivity? local)
        {
            if (local is not null)
            {
                return local;
            }

            return ThermalConductivity.Zero;
        }

    }
}                   