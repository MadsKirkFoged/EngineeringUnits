using System;

namespace EngineeringUnits
{
    public static class MolarFlowUnitExtension
    {

        public static MolarFlow? IfNullSetToZero(this MolarFlow? local)
        {
            if (local is not null)
            {
                return local;
            }

            return MolarFlow.Zero;
        }

    }
}                   