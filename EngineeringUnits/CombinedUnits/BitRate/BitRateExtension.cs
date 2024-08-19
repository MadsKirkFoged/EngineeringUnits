using System;

namespace EngineeringUnits
{
    public static class BitRateUnitExtension
    {

        public static BitRate? IfNullSetToZero(this BitRate? local)
        {
            if (local is not null)
            {
                return local;
            }

            return BitRate.Zero;
        }

    }
}                   