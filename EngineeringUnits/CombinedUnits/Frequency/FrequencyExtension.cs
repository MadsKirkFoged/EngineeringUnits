using System;

namespace EngineeringUnits
{
    public static class FrequencyUnitExtension
    {

        public static Frequency? IfNullSetToZero(this Frequency? local)
        {
            if (local is not null)
            {
                return local;
            }

            return Frequency.Zero;
        }

    }
}                   