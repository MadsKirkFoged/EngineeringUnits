using System;

namespace EngineeringUnits
{
    public static class InformationUnitExtension
    {

        public static Information? IfNullSetToZero(this Information? local)
        {
            if (local is not null)
            {
                return local;
            }

            return Information.Zero;
        }

    }
}                   