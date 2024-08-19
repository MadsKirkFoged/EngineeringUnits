using System;

namespace EngineeringUnits
{
    public static class TemperatureUnitExtension
    {

        public static Temperature? IfNullSetToZero(this Temperature? local)
        {
            if (local is not null)
            {
                return local;
            }

            return Temperature.Zero;
        }

    }
}                   