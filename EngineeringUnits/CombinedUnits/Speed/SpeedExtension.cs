using System;

namespace EngineeringUnits
{
    public static class SpeedUnitExtension
    {

        public static Speed? IfNullSetToZero(this Speed? local)
        {
            if (local is not null)
            {
                return local;
            }

            return Speed.Zero;
        }

    }
}                   