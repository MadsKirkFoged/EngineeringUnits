using System;

namespace EngineeringUnits
{
    public static class ElectricCurrentGradientUnitExtension
    {

        public static ElectricCurrentGradient? IfNullSetToZero(this ElectricCurrentGradient? local)
        {
            if (local is not null)
            {
                return local;
            }

            return ElectricCurrentGradient.Zero;
        }

    }
}                   