using System;

namespace EngineeringUnits
{
    public static class DensityUnitExtension
    {

        public static Density? IfNullSetToZero(this Density? local)
        {
            if (local is not null)
            {
                return local;
            }

            return Density.Zero;
        }

    }
}                   