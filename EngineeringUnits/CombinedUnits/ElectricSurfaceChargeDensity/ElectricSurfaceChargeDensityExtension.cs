using System;

namespace EngineeringUnits
{
    public static class ElectricSurfaceChargeDensityUnitExtension
    {

        public static ElectricSurfaceChargeDensity? IfNullSetToZero(this ElectricSurfaceChargeDensity? local)
        {
            if (local is not null)
            {
                return local;
            }

            return ElectricSurfaceChargeDensity.Zero;
        }

    }
}                   