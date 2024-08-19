using System;

namespace EngineeringUnits
{
    public static class VolumeCostUnitExtension
    {

        public static VolumeCost? IfNullSetToZero(this VolumeCost? local)
        {
            if (local is not null)
            {
                return local;
            }

            return VolumeCost.Zero;
        }

    }
}                   