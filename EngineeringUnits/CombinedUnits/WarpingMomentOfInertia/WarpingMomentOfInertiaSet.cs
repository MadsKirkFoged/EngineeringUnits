
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class WarpingMomentOfInertia
    {

 

            /// <summary>
            ///     Get WarpingMomentOfInertia from MeterToTheSixth.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static WarpingMomentOfInertia FromMeterToTheSixth(double MeterToTheSixth)
            {
                double value= (double)MeterToTheSixth;
                return new WarpingMomentOfInertia(value, WarpingMomentOfInertiaUnit.MeterToTheSixth);
            }
            /// <summary>
            ///     Get WarpingMomentOfInertia from MillimeterToTheSixth.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static WarpingMomentOfInertia FromMillimeterToTheSixth(double MillimeterToTheSixth)
            {
                double value= (double)MillimeterToTheSixth;
                return new WarpingMomentOfInertia(value, WarpingMomentOfInertiaUnit.MillimeterToTheSixth);
            }
            /// <summary>
            ///     Get WarpingMomentOfInertia from InchToTheSixth.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static WarpingMomentOfInertia FromInchToTheSixth(double InchToTheSixth)
            {
                double value= (double)InchToTheSixth;
                return new WarpingMomentOfInertia(value, WarpingMomentOfInertiaUnit.InchToTheSixth);
            }
            /// <summary>
            ///     Get WarpingMomentOfInertia from FootToTheSixth.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static WarpingMomentOfInertia FromFootToTheSixth(double FootToTheSixth)
            {
                double value= (double)FootToTheSixth;
                return new WarpingMomentOfInertia(value, WarpingMomentOfInertiaUnit.FootToTheSixth);
            }
            /// <summary>
            ///     Get WarpingMomentOfInertia from DecimeterToTheSixth.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static WarpingMomentOfInertia FromDecimeterToTheSixth(double DecimeterToTheSixth)
            {
                double value= (double)DecimeterToTheSixth;
                return new WarpingMomentOfInertia(value, WarpingMomentOfInertiaUnit.DecimeterToTheSixth);
            }
            /// <summary>
            ///     Get WarpingMomentOfInertia from CentimeterToTheSixth.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static WarpingMomentOfInertia FromCentimeterToTheSixth(double CentimeterToTheSixth)
            {
                double value= (double)CentimeterToTheSixth;
                return new WarpingMomentOfInertia(value, WarpingMomentOfInertiaUnit.CentimeterToTheSixth);
            }
            /// <summary>
            ///     Get WarpingMomentOfInertia from SI.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static WarpingMomentOfInertia FromSI(double SI)
            {
                double value= (double)SI;
                return new WarpingMomentOfInertia(value, WarpingMomentOfInertiaUnit.SI);
            }
    }
}


