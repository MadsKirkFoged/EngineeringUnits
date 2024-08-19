using System;

namespace EngineeringUnits
{
    public static class VolumeUnitExtension
    {

        public static Volume? IfNullSetToZero(this Volume? local)
        {
            if (local is not null)
            {
                return local;
            }

            return Volume.Zero;
        }

    }
}                   