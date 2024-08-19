using System;

namespace EngineeringUnits
{
    public static class SpecificVolumeUnitExtension
    {

        public static SpecificVolume? IfNullSetToZero(this SpecificVolume? local)
        {
            if (local is not null)
            {
                return local;
            }

            return SpecificVolume.Zero;
        }

    }
}                   