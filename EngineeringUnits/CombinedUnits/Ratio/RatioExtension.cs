using System;

namespace EngineeringUnits
{
    public static class RatioUnitExtension
    {

        public static Ratio? IfNullSetToZero(this Ratio? local)
        {
            if (local is not null)
            {
                return local;
            }

            return Ratio.Zero;
        }

    }
}                   