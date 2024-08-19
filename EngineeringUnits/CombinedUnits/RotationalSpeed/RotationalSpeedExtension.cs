using System;

namespace EngineeringUnits
{
    public static class RotationalSpeedUnitExtension
    {

        public static RotationalSpeed? IfNullSetToZero(this RotationalSpeed? local)
        {
            if (local is not null)
            {
                return local;
            }

            return RotationalSpeed.Zero;
        }

    }
}                   