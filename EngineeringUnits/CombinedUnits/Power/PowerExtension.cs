using System;

namespace EngineeringUnits
{
    public static class PowerUnitExtension
    {

        public static Power? IfNullSetToZero(this Power? local)
        {
            if (local is not null)
            {
                return local;
            }

            return Power.Zero;
        }

    }
}                   