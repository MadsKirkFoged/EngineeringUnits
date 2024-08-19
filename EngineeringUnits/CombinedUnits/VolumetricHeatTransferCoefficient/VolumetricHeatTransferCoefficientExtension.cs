using System;

namespace EngineeringUnits
{
    public static class VolumetricHeatTransferCoefficientUnitExtension
    {

        public static VolumetricHeatTransferCoefficient? IfNullSetToZero(this VolumetricHeatTransferCoefficient? local)
        {
            if (local is not null)
            {
                return local;
            }

            return VolumetricHeatTransferCoefficient.Zero;
        }

    }
}                   