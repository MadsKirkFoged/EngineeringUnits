using System;

namespace EngineeringUnits
{
    public static class AmountOfSubstanceUnitExtension
    {

        public static AmountOfSubstance? IfNullSetToZero(this AmountOfSubstance? local)
        {
            if (local is not null)
            {
                return local;
            }

            return AmountOfSubstance.Zero;
        }

    }
}                   