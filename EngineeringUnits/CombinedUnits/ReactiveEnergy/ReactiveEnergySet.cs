
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class ReactiveEnergy
    {

 

            /// <summary>
            ///     Get ReactiveEnergy from SI.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static ReactiveEnergy FromSI(double SI)
            {
                double value= (double)SI;
                return new ReactiveEnergy(value, ReactiveEnergyUnit.SI);
            }
            /// <summary>
            ///     Get ReactiveEnergy from VoltampereReactiveHour.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static ReactiveEnergy FromVoltampereReactiveHour(double VoltampereReactiveHour)
            {
                double value= (double)VoltampereReactiveHour;
                return new ReactiveEnergy(value, ReactiveEnergyUnit.VoltampereReactiveHour);
            }
            /// <summary>
            ///     Get ReactiveEnergy from MegavoltampereReactiveHour.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static ReactiveEnergy FromMegavoltampereReactiveHour(double MegavoltampereReactiveHour)
            {
                double value= (double)MegavoltampereReactiveHour;
                return new ReactiveEnergy(value, ReactiveEnergyUnit.MegavoltampereReactiveHour);
            }
            /// <summary>
            ///     Get ReactiveEnergy from KilovoltampereReactiveHour.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static ReactiveEnergy FromKilovoltampereReactiveHour(double KilovoltampereReactiveHour)
            {
                double value= (double)KilovoltampereReactiveHour;
                return new ReactiveEnergy(value, ReactiveEnergyUnit.KilovoltampereReactiveHour);
            }
    }
}


