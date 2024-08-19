using System;

namespace EngineeringUnits
{
    public static class DurationCostUnitExtension
    {

        public static DurationCost? IfNullSetToZero(this DurationCost? local)
        {
            if (local is not null)
            {
                return local;
            }

            return DurationCost.Zero;
        }

    }
}                   