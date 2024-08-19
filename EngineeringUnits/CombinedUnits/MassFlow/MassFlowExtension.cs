using System;

namespace EngineeringUnits
{
    public static class MassFlowExtension
    {

        public static MassFlow? IfNullSetToZero(this MassFlow? local)
        {
            if (local is not null)
            {
                return local;
            }

            return MassFlow.Zero;
        }




    }
}
