using System;

namespace EngineeringUnits
{
    public static class LinearPowerDensityUnitExtension
    {

        public static LinearPowerDensity? IfNullSetToZero(this LinearPowerDensity? local)
        {
            if (local is not null)
            {
                return local;
            }

            return LinearPowerDensity.Zero;
        }

    }
}                   