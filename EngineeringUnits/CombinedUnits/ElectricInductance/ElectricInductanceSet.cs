
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    //This class is auto-generated, changes to the file will be overwritten!
    public partial class ElectricInductance
    {

 

            /// <summary>
            ///     Get ElectricInductance from SI.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static ElectricInductance FromSI(double SI)
            {
                double value= (double)SI;
                return new ElectricInductance(value, ElectricInductanceUnit.SI);
            }
            /// <summary>
            ///     Get ElectricInductance from Henry.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static ElectricInductance FromHenry(double Henry)
            {
                double value= (double)Henry;
                return new ElectricInductance(value, ElectricInductanceUnit.Henry);
            }
            /// <summary>
            ///     Get ElectricInductance from Microhenry.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static ElectricInductance FromMicrohenry(double Microhenry)
            {
                double value= (double)Microhenry;
                return new ElectricInductance(value, ElectricInductanceUnit.Microhenry);
            }
            /// <summary>
            ///     Get ElectricInductance from Millihenry.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static ElectricInductance FromMillihenry(double Millihenry)
            {
                double value= (double)Millihenry;
                return new ElectricInductance(value, ElectricInductanceUnit.Millihenry);
            }
            /// <summary>
            ///     Get ElectricInductance from Nanohenry.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static ElectricInductance FromNanohenry(double Nanohenry)
            {
                double value= (double)Nanohenry;
                return new ElectricInductance(value, ElectricInductanceUnit.Nanohenry);
            }
    }
}


