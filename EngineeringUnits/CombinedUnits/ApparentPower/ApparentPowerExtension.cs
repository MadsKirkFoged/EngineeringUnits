using System;

namespace EngineeringUnits
{
    public static class ApparentPowerUnitExtension
    {

        public static ApparentPower? IfNullSetToZero(this ApparentPower? local)
        {
            if (local is not null)
            {
                return local;
            }

            return ApparentPower.Zero;
        }

    }
}                   