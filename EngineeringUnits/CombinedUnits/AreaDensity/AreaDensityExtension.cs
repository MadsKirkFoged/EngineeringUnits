using System;

namespace EngineeringUnits
{
    public static class AreaDensityUnitExtension
    {

        public static AreaDensity? IfNullSetToZero(this AreaDensity? local)
        {
            if (local is not null)
            {
                return local;
            }

            return AreaDensity.Zero;
        }

    }
}                   