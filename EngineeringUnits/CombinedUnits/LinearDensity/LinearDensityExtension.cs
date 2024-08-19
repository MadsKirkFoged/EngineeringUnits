using System;

namespace EngineeringUnits
{
    public static class LinearDensityUnitExtension
    {

        public static LinearDensity? IfNullSetToZero(this LinearDensity? local)
        {
            if (local is not null)
            {
                return local;
            }

            return LinearDensity.Zero;
        }

    }
}                   