
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class ReactivePower
    {

 

            /// <summary>
            ///     Get ReactivePower from SI.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static ReactivePower FromSI(double SI)
            {
                double value= (double)SI;
                return new ReactivePower(value, ReactivePowerUnit.SI);
            }
            /// <summary>
            ///     Get ReactivePower from VoltampereReactive.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static ReactivePower FromVoltampereReactive(double VoltampereReactive)
            {
                double value= (double)VoltampereReactive;
                return new ReactivePower(value, ReactivePowerUnit.VoltampereReactive);
            }
            /// <summary>
            ///     Get ReactivePower from MegavoltampereReactive.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static ReactivePower FromMegavoltampereReactive(double MegavoltampereReactive)
            {
                double value= (double)MegavoltampereReactive;
                return new ReactivePower(value, ReactivePowerUnit.MegavoltampereReactive);
            }
            /// <summary>
            ///     Get ReactivePower from KilovoltampereReactive.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static ReactivePower FromKilovoltampereReactive(double KilovoltampereReactive)
            {
                double value= (double)KilovoltampereReactive;
                return new ReactivePower(value, ReactivePowerUnit.KilovoltampereReactive);
            }
            /// <summary>
            ///     Get ReactivePower from GigavoltampereReactive.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static ReactivePower FromGigavoltampereReactive(double GigavoltampereReactive)
            {
                double value= (double)GigavoltampereReactive;
                return new ReactivePower(value, ReactivePowerUnit.GigavoltampereReactive);
            }
    }
}


