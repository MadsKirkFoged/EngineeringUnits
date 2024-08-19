using System;

namespace EngineeringUnits
{
    public static class MagnetizationUnitExtension
    {

        public static Magnetization? IfNullSetToZero(this Magnetization? local)
        {
            if (local is not null)
            {
                return local;
            }

            return Magnetization.Zero;
        }

    }
}                   