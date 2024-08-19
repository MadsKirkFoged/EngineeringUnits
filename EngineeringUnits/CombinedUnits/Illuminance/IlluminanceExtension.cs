using System;

namespace EngineeringUnits
{
    public static class IlluminanceUnitExtension
    {

        public static Illuminance? IfNullSetToZero(this Illuminance? local)
        {
            if (local is not null)
            {
                return local;
            }

            return Illuminance.Zero;
        }

    }
}                   