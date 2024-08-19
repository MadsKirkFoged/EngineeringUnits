using System;

namespace EngineeringUnits
{
    public static class ElectricCurrentDensityUnitExtension
    {

        public static ElectricCurrentDensity? IfNullSetToZero(this ElectricCurrentDensity? local)
        {
            if (local is not null)
            {
                return local;
            }

            return ElectricCurrentDensity.Zero;
        }

    }
}                   