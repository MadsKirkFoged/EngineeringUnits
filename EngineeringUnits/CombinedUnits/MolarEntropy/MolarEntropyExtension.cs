using System;

namespace EngineeringUnits
{
    public static class MolarEntropyUnitExtension
    {

        public static MolarEntropy? IfNullSetToZero(this MolarEntropy? local)
        {
            if (local is not null)
            {
                return local;
            }

            return MolarEntropy.Zero;
        }

    }
}                   