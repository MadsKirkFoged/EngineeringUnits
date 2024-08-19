using System;

namespace EngineeringUnits
{
    public static class HeatFluxUnitExtension
    {

        public static HeatFlux? IfNullSetToZero(this HeatFlux? local)
        {
            if (local is not null)
            {
                return local;
            }

            return HeatFlux.Zero;
        }

    }
}                   