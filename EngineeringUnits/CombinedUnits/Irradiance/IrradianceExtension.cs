using System;

namespace EngineeringUnits
{
    public static class IrradianceUnitExtension
    {

        public static Irradiance? IfNullSetToZero(this Irradiance? local)
        {
            if (local is not null)
            {
                return local;
            }

            return Irradiance.Zero;
        }

    }
}                   