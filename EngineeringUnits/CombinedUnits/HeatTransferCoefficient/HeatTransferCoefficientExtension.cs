using System;

namespace EngineeringUnits
{
    public static class HeatTransferCoefficientUnitExtension
    {

        public static HeatTransferCoefficient? IfNullSetToZero(this HeatTransferCoefficient? local)
        {
            if (local is not null)
            {
                return local;
            }

            return HeatTransferCoefficient.Zero;
        }

    }
}                   