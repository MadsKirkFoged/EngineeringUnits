using System;

namespace EngineeringUnits
{
    public static class LuminousFluxUnitExtension
    {

        public static LuminousFlux? IfNullSetToZero(this LuminousFlux? local)
        {
            if (local is not null)
            {
                return local;
            }

            return LuminousFlux.Zero;
        }

    }
}                   