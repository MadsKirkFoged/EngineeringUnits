using System;

namespace EngineeringUnits
{
    public static class PressureUnitExtension
    {

        public static Pressure? IfNullSetToZero(this Pressure? local)
        {
            if (local is not null)
            {
                return local;
            }

            return Pressure.Zero;
        }

    }
}                   