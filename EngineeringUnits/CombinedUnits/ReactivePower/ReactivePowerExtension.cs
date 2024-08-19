using System;

namespace EngineeringUnits
{
    public static class ReactivePowerUnitExtension
    {

        public static ReactivePower? IfNullSetToZero(this ReactivePower? local)
        {
            if (local is not null)
            {
                return local;
            }

            return ReactivePower.Zero;
        }

    }
}                   