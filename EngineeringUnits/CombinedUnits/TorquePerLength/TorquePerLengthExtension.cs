using System;

namespace EngineeringUnits
{
    public static class TorquePerLengthUnitExtension
    {

        public static TorquePerLength? IfNullSetToZero(this TorquePerLength? local)
        {
            if (local is not null)
            {
                return local;
            }

            return TorquePerLength.Zero;
        }

    }
}                   