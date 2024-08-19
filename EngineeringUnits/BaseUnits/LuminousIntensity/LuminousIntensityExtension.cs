using System;

namespace EngineeringUnits
{
    public static class LuminousIntensityUnitExtension
    {

        public static LuminousIntensity? IfNullSetToZero(this LuminousIntensity? local)
        {
            if (local is not null)
            {
                return local;
            }

            return LuminousIntensity.Zero;
        }

    }
}                   