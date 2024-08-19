using System;

namespace EngineeringUnits
{
    public static class PressureChangeRateUnitExtension
    {

        public static PressureChangeRate? IfNullSetToZero(this PressureChangeRate? local)
        {
            if (local is not null)
            {
                return local;
            }

            return PressureChangeRate.Zero;
        }

    }
}                   