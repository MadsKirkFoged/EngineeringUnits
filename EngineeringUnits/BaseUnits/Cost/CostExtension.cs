using System;

namespace EngineeringUnits
{
    public static class CostUnitExtension
    {

        public static Cost? IfNullSetToZero(this Cost? local)
        {
            if (local is not null)
            {
                return local;
            }

            return Cost.Zero;
        }

    }
}                   