
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class ApparentPower
    {

 

            /// <summary>
            ///     Get ApparentPower from SI.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static ApparentPower FromSI(double SI)
            {
                double value= (double)SI;
                return new ApparentPower(value, ApparentPowerUnit.SI);
            }
            /// <summary>
            ///     Get ApparentPower from Voltampere.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static ApparentPower FromVoltampere(double Voltampere)
            {
                double value= (double)Voltampere;
                return new ApparentPower(value, ApparentPowerUnit.Voltampere);
            }
            /// <summary>
            ///     Get ApparentPower from Megavoltampere.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static ApparentPower FromMegavoltampere(double Megavoltampere)
            {
                double value= (double)Megavoltampere;
                return new ApparentPower(value, ApparentPowerUnit.Megavoltampere);
            }
            /// <summary>
            ///     Get ApparentPower from Kilovoltampere.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static ApparentPower FromKilovoltampere(double Kilovoltampere)
            {
                double value= (double)Kilovoltampere;
                return new ApparentPower(value, ApparentPowerUnit.Kilovoltampere);
            }
            /// <summary>
            ///     Get ApparentPower from Gigavoltampere.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static ApparentPower FromGigavoltampere(double Gigavoltampere)
            {
                double value= (double)Gigavoltampere;
                return new ApparentPower(value, ApparentPowerUnit.Gigavoltampere);
            }
    }
}


