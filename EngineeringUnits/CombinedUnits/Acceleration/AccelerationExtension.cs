using System;

namespace EngineeringUnits
{
    public static class AccelerationUnitExtension
    {

        public static Acceleration? IfNullSetToZero(this Acceleration? local)
        {
            if (local is not null)
            {
                return local;
            }

            return Acceleration.Zero;
        }

    }
}                   