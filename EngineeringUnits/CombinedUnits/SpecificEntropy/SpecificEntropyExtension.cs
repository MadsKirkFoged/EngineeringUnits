using System;

namespace EngineeringUnits
{
    public static class SpecificEntropyUnitExtension
    {

        public static SpecificEntropy? IfNullSetToZero(this SpecificEntropy? local)
        {
            if (local is not null)
            {
                return local;
            }

            return SpecificEntropy.Zero;
        }

    }
}                   