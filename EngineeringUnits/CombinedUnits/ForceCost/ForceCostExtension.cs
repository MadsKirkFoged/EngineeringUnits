using System;

namespace EngineeringUnits
{
    public static class ForceCostUnitExtension
    {

        public static ForceCost? IfNullSetToZero(this ForceCost? local)
        {
            if (local is not null)
            {
                return local;
            }

            return ForceCost.Zero;
        }

    }
}                   