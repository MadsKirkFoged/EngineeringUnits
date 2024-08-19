using System;

namespace EngineeringUnits
{
    public static class ElectricChargeDensityUnitExtension
    {

        public static ElectricChargeDensity? IfNullSetToZero(this ElectricChargeDensity? local)
        {
            if (local is not null)
            {
                return local;
            }

            return ElectricChargeDensity.Zero;
        }

    }
}                   