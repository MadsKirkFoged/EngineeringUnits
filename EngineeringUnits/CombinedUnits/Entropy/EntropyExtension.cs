using System;

namespace EngineeringUnits
{
    public static class EntropyUnitExtension
    {

        public static Entropy? IfNullSetToZero(this Entropy? local)
        {
            if (local is not null)
            {
                return local;
            }

            return Entropy.Zero;
        }

    }
}                   