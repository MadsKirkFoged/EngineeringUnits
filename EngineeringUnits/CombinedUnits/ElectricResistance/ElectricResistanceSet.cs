
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    //This class is auto-generated, changes to the file will be overwritten!
    public partial class ElectricResistance
    {

 

            /// <summary>
            ///     Get ElectricResistance from SI.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static ElectricResistance FromSI(double SI)
            {
                double value= (double)SI;
                return new ElectricResistance(value, ElectricResistanceUnit.SI);
            }
            /// <summary>
            ///     Get ElectricResistance from Ohm.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static ElectricResistance FromOhm(double Ohm)
            {
                double value= (double)Ohm;
                return new ElectricResistance(value, ElectricResistanceUnit.Ohm);
            }
            /// <summary>
            ///     Get ElectricResistance from Gigaohm.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static ElectricResistance FromGigaohm(double Gigaohm)
            {
                double value= (double)Gigaohm;
                return new ElectricResistance(value, ElectricResistanceUnit.Gigaohm);
            }
            /// <summary>
            ///     Get ElectricResistance from Kiloohm.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static ElectricResistance FromKiloohm(double Kiloohm)
            {
                double value= (double)Kiloohm;
                return new ElectricResistance(value, ElectricResistanceUnit.Kiloohm);
            }
            /// <summary>
            ///     Get ElectricResistance from Megaohm.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static ElectricResistance FromMegaohm(double Megaohm)
            {
                double value= (double)Megaohm;
                return new ElectricResistance(value, ElectricResistanceUnit.Megaohm);
            }
            /// <summary>
            ///     Get ElectricResistance from Microohm.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static ElectricResistance FromMicroohm(double Microohm)
            {
                double value= (double)Microohm;
                return new ElectricResistance(value, ElectricResistanceUnit.Microohm);
            }
            /// <summary>
            ///     Get ElectricResistance from Milliohm.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static ElectricResistance FromMilliohm(double Milliohm)
            {
                double value= (double)Milliohm;
                return new ElectricResistance(value, ElectricResistanceUnit.Milliohm);
            }
    }
}


