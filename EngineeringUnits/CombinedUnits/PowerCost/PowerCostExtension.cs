using System;

namespace EngineeringUnits
{
    public static class PowerCostUnitExtension
    {

        public static PowerCost? IfNullSetToZero(this PowerCost? local)
        {
            if (local is not null)
            {
                return local;
            }

            return PowerCost.Zero;
        }

    }
}                   