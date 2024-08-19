using System;

namespace EngineeringUnits
{
    public static class TorqueUnitExtension
    {

        public static Torque? IfNullSetToZero(this Torque? local)
        {
            if (local is not null)
            {
                return local;
            }

            return Torque.Zero;
        }

    }
}                   