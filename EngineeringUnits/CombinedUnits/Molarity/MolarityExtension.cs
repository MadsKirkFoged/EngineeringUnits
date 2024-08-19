using System;

namespace EngineeringUnits
{
    public static class MolarityUnitExtension
    {

        public static Molarity? IfNullSetToZero(this Molarity? local)
        {
            if (local is not null)
            {
                return local;
            }

            return Molarity.Zero;
        }

    }
}                   