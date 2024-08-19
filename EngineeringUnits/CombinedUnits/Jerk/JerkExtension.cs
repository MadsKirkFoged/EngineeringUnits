using System;

namespace EngineeringUnits
{
    public static class JerkUnitExtension
    {

        public static Jerk? IfNullSetToZero(this Jerk? local)
        {
            if (local is not null)
            {
                return local;
            }

            return Jerk.Zero;
        }

    }
}                   