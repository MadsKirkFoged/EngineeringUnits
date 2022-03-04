
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class ReactiveEnergy
    {

 

            /// <summary>
            ///     Get ReactiveEnergy in SI.
            /// </summary>
            public double SI => As(ReactiveEnergyUnit.SI);
            /// <summary>
            ///     Get ReactiveEnergy in VoltampereReactiveHour.
            /// </summary>
            public double VoltampereReactiveHour => As(ReactiveEnergyUnit.VoltampereReactiveHour);
            /// <summary>
            ///     Get ReactiveEnergy in MegavoltampereReactiveHour.
            /// </summary>
            public double MegavoltampereReactiveHour => As(ReactiveEnergyUnit.MegavoltampereReactiveHour);
            /// <summary>
            ///     Get ReactiveEnergy in KilovoltampereReactiveHour.
            /// </summary>
            public double KilovoltampereReactiveHour => As(ReactiveEnergyUnit.KilovoltampereReactiveHour);
    }
}


