using System;

namespace EngineeringUnits
{
    public static class TemperatureChangeRateUnitExtension
    {

        public static TemperatureChangeRate? IfNullSetToZero(this TemperatureChangeRate? local)
        {
            if (local is not null)
            {
                return local;
            }

            return TemperatureChangeRate.Zero;
        }

    }
}                   