using System;

namespace EngineeringUnits
{
    public static class ForceChangeRateUnitExtension
    {

        public static ForceChangeRate? IfNullSetToZero(this ForceChangeRate? local)
        {
            if (local is not null)
            {
                return local;
            }

            return ForceChangeRate.Zero;
        }

    }
}                   