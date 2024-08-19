using System;

namespace EngineeringUnits
{
    public static class AreaCostUnitExtension
    {

        public static AreaCost? IfNullSetToZero(this AreaCost? local)
        {
            if (local is not null)
            {
                return local;
            }

            return AreaCost.Zero;
        }

    }
}                   