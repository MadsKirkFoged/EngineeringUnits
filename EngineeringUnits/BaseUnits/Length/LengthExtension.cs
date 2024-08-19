using System;

namespace EngineeringUnits
{
    public static class LengthUnitExtension
    {

        public static Length? IfNullSetToZero(this Length? local)
        {
            if (local is not null)
            {
                return local;
            }

            return Length.Zero;
        }

    }
}                   