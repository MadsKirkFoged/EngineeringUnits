using System;

namespace EngineeringUnits
{
    public static class CapacitanceUnitExtension
    {

        public static Capacitance? IfNullSetToZero(this Capacitance? local)
        {
            if (local is not null)
            {
                return local;
            }

            return Capacitance.Zero;
        }

    }
}                   