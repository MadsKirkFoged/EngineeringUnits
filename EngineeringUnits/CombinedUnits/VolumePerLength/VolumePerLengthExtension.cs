using System;

namespace EngineeringUnits
{
    public static class VolumePerLengthUnitExtension
    {

        public static VolumePerLength? IfNullSetToZero(this VolumePerLength? local)
        {
            if (local is not null)
            {
                return local;
            }

            return VolumePerLength.Zero;
        }

    }
}                   