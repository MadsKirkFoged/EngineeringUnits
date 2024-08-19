using System;

namespace EngineeringUnits
{
    public static class DurationUnitExtension
    {

        public static Duration? IfNullSetToZero(this Duration? local)
        {
            if (local is not null)
            {
                return local;
            }

            return Duration.Zero;
        }

    }
}                   