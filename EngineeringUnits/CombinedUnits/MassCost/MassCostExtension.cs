using System;

namespace EngineeringUnits
{
    public static class MassCostUnitExtension
    {

        public static MassCost? IfNullSetToZero(this MassCost? local)
        {
            if (local is not null)
            {
                return local;
            }

            return MassCost.Zero;
        }

    }
}                   