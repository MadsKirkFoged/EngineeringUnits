using System;

namespace EngineeringUnits
{
    public static class PowerDensityUnitExtension
    {

        public static PowerDensity? IfNullSetToZero(this PowerDensity? local)
        {
            if (local is not null)
            {
                return local;
            }

            return PowerDensity.Zero;
        }

    }
}                   