
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    //This class is auto-generated, changes to the file will be overwritten!
    public partial class ElectricPotential
    {

 

            /// <summary>
            ///     Get ElectricPotential from SI.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static ElectricPotential FromSI(double SI)
            {
                double value= (double)SI;
                return new ElectricPotential(value, ElectricPotentialUnit.SI);
            }
            /// <summary>
            ///     Get ElectricPotential from Volt.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static ElectricPotential FromVolt(double Volt)
            {
                double value= (double)Volt;
                return new ElectricPotential(value, ElectricPotentialUnit.Volt);
            }
            /// <summary>
            ///     Get ElectricPotential from Kilovolt.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static ElectricPotential FromKilovolt(double Kilovolt)
            {
                double value= (double)Kilovolt;
                return new ElectricPotential(value, ElectricPotentialUnit.Kilovolt);
            }
            /// <summary>
            ///     Get ElectricPotential from Megavolt.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static ElectricPotential FromMegavolt(double Megavolt)
            {
                double value= (double)Megavolt;
                return new ElectricPotential(value, ElectricPotentialUnit.Megavolt);
            }
            /// <summary>
            ///     Get ElectricPotential from Gigavolt.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static ElectricPotential FromGigavolt(double Gigavolt)
            {
                double value= (double)Gigavolt;
                return new ElectricPotential(value, ElectricPotentialUnit.Gigavolt);
            }
            /// <summary>
            ///     Get ElectricPotential from Microvolt.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static ElectricPotential FromMicrovolt(double Microvolt)
            {
                double value= (double)Microvolt;
                return new ElectricPotential(value, ElectricPotentialUnit.Microvolt);
            }
            /// <summary>
            ///     Get ElectricPotential from Millivolt.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static ElectricPotential FromMillivolt(double Millivolt)
            {
                double value= (double)Millivolt;
                return new ElectricPotential(value, ElectricPotentialUnit.Millivolt);
            }
    }
}


