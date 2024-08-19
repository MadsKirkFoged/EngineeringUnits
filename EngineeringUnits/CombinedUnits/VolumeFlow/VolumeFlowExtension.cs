using System;

namespace EngineeringUnits
{
    public static class VolumeFlowUnitExtension
    {

        public static VolumeFlow? IfNullSetToZero(this VolumeFlow? local)
        {
            if (local is not null)
            {
                return local;
            }

            return VolumeFlow.Zero;
        }

    }
}                   