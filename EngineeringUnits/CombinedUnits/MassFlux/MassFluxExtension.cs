using System;

namespace EngineeringUnits
{
    public static class MassFluxUnitExtension
    {

        public static MassFlux? IfNullSetToZero(this MassFlux? local)
        {
            if (local is not null)
            {
                return local;
            }

            return MassFlux.Zero;
        }

    }
}                   