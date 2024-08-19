using System;

namespace EngineeringUnits
{
    public static class MagneticFluxUnitExtension
    {

        public static MagneticFlux? IfNullSetToZero(this MagneticFlux? local)
        {
            if (local is not null)
            {
                return local;
            }

            return MagneticFlux.Zero;
        }

    }
}                   