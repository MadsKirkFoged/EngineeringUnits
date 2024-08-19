using System;

namespace EngineeringUnits
{
    public static class LapseRateUnitExtension
    {

        public static LapseRate? IfNullSetToZero(this LapseRate? local)
        {
            if (local is not null)
            {
                return local;
            }

            return LapseRate.Zero;
        }

    }
}                   