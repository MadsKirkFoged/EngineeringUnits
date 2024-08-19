using System;

namespace EngineeringUnits
{
    public static class LengthCostUnitExtension
    {

        public static LengthCost? IfNullSetToZero(this LengthCost? local)
        {
            if (local is not null)
            {
                return local;
            }

            return LengthCost.Zero;
        }

    }
}                   