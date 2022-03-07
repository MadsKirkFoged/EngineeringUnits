
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class DynamicViscosity
    {

 

            /// <summary>
            ///     Get DynamicViscosity from SI.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static DynamicViscosity FromSI(double SI)
            {
                double value= (double)SI;
                return new DynamicViscosity(value, DynamicViscosityUnit.SI);
            }
            /// <summary>
            ///     Get DynamicViscosity from PascalSecond.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static DynamicViscosity FromPascalSecond(double PascalSecond)
            {
                double value= (double)PascalSecond;
                return new DynamicViscosity(value, DynamicViscosityUnit.PascalSecond);
            }
            /// <summary>
            ///     Get DynamicViscosity from MicropascalSecond.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static DynamicViscosity FromMicropascalSecond(double MicropascalSecond)
            {
                double value= (double)MicropascalSecond;
                return new DynamicViscosity(value, DynamicViscosityUnit.MicropascalSecond);
            }
            /// <summary>
            ///     Get DynamicViscosity from MillipascalSecond.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static DynamicViscosity FromMillipascalSecond(double MillipascalSecond)
            {
                double value= (double)MillipascalSecond;
                return new DynamicViscosity(value, DynamicViscosityUnit.MillipascalSecond);
            }
            /// <summary>
            ///     Get DynamicViscosity from PoundPerFootSecond.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static DynamicViscosity FromPoundPerFootSecond(double PoundPerFootSecond)
            {
                double value= (double)PoundPerFootSecond;
                return new DynamicViscosity(value, DynamicViscosityUnit.PoundPerFootSecond);
            }
            /// <summary>
            ///     Get DynamicViscosity from Poise.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static DynamicViscosity FromPoise(double Poise)
            {
                double value= (double)Poise;
                return new DynamicViscosity(value, DynamicViscosityUnit.Poise);
            }
            /// <summary>
            ///     Get DynamicViscosity from Centipoise.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static DynamicViscosity FromCentipoise(double Centipoise)
            {
                double value= (double)Centipoise;
                return new DynamicViscosity(value, DynamicViscosityUnit.Centipoise);
            }
            /// <summary>
            ///     Get DynamicViscosity from NewtonSecondPerMeterSquared.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static DynamicViscosity FromNewtonSecondPerMeterSquared(double NewtonSecondPerMeterSquared)
            {
                double value= (double)NewtonSecondPerMeterSquared;
                return new DynamicViscosity(value, DynamicViscosityUnit.NewtonSecondPerMeterSquared);
            }
            /// <summary>
            ///     Get DynamicViscosity from PoundForceSecondPerSquareFoot.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static DynamicViscosity FromPoundForceSecondPerSquareFoot(double PoundForceSecondPerSquareFoot)
            {
                double value= (double)PoundForceSecondPerSquareFoot;
                return new DynamicViscosity(value, DynamicViscosityUnit.PoundForceSecondPerSquareFoot);
            }
            /// <summary>
            ///     Get DynamicViscosity from PoundForceSecondPerSquareInch.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static DynamicViscosity FromPoundForceSecondPerSquareInch(double PoundForceSecondPerSquareInch)
            {
                double value= (double)PoundForceSecondPerSquareInch;
                return new DynamicViscosity(value, DynamicViscosityUnit.PoundForceSecondPerSquareInch);
            }
            /// <summary>
            ///     Get DynamicViscosity from Reyn.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static DynamicViscosity FromReyn(double Reyn)
            {
                double value= (double)Reyn;
                return new DynamicViscosity(value, DynamicViscosityUnit.Reyn);
            }
    }
}


