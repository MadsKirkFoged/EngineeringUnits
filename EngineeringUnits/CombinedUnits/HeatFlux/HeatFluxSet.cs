
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class HeatFlux
    {

 

            /// <summary>
            ///     Get HeatFlux from SI.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static HeatFlux FromSI(double SI)
            {
                double value= (double)SI;
                return new HeatFlux(value, HeatFluxUnit.SI);
            }
            /// <summary>
            ///     Get HeatFlux from WattPerSquareMeter.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static HeatFlux FromWattPerSquareMeter(double WattPerSquareMeter)
            {
                double value= (double)WattPerSquareMeter;
                return new HeatFlux(value, HeatFluxUnit.WattPerSquareMeter);
            }
            /// <summary>
            ///     Get HeatFlux from WattPerSquareInch.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static HeatFlux FromWattPerSquareInch(double WattPerSquareInch)
            {
                double value= (double)WattPerSquareInch;
                return new HeatFlux(value, HeatFluxUnit.WattPerSquareInch);
            }
            /// <summary>
            ///     Get HeatFlux from WattPerSquareFoot.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static HeatFlux FromWattPerSquareFoot(double WattPerSquareFoot)
            {
                double value= (double)WattPerSquareFoot;
                return new HeatFlux(value, HeatFluxUnit.WattPerSquareFoot);
            }
            /// <summary>
            ///     Get HeatFlux from BtuPerHourSquareFoot.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static HeatFlux FromBtuPerHourSquareFoot(double BtuPerHourSquareFoot)
            {
                double value= (double)BtuPerHourSquareFoot;
                return new HeatFlux(value, HeatFluxUnit.BtuPerHourSquareFoot);
            }
            /// <summary>
            ///     Get HeatFlux from BtuPerMinuteSquareFoot.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static HeatFlux FromBtuPerMinuteSquareFoot(double BtuPerMinuteSquareFoot)
            {
                double value= (double)BtuPerMinuteSquareFoot;
                return new HeatFlux(value, HeatFluxUnit.BtuPerMinuteSquareFoot);
            }
            /// <summary>
            ///     Get HeatFlux from BtuPerSecondSquareFoot.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static HeatFlux FromBtuPerSecondSquareFoot(double BtuPerSecondSquareFoot)
            {
                double value= (double)BtuPerSecondSquareFoot;
                return new HeatFlux(value, HeatFluxUnit.BtuPerSecondSquareFoot);
            }
            /// <summary>
            ///     Get HeatFlux from BtuPerSecondSquareInch.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static HeatFlux FromBtuPerSecondSquareInch(double BtuPerSecondSquareInch)
            {
                double value= (double)BtuPerSecondSquareInch;
                return new HeatFlux(value, HeatFluxUnit.BtuPerSecondSquareInch);
            }
            /// <summary>
            ///     Get HeatFlux from CaloriePerSecondSquareCentimeter.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static HeatFlux FromCaloriePerSecondSquareCentimeter(double CaloriePerSecondSquareCentimeter)
            {
                double value= (double)CaloriePerSecondSquareCentimeter;
                return new HeatFlux(value, HeatFluxUnit.CaloriePerSecondSquareCentimeter);
            }
            /// <summary>
            ///     Get HeatFlux from KilocaloriePerHourSquareMeter.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static HeatFlux FromKilocaloriePerHourSquareMeter(double KilocaloriePerHourSquareMeter)
            {
                double value= (double)KilocaloriePerHourSquareMeter;
                return new HeatFlux(value, HeatFluxUnit.KilocaloriePerHourSquareMeter);
            }
            /// <summary>
            ///     Get HeatFlux from KilocaloriePerSecondSquareCentimeter.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static HeatFlux FromKilocaloriePerSecondSquareCentimeter(double KilocaloriePerSecondSquareCentimeter)
            {
                double value= (double)KilocaloriePerSecondSquareCentimeter;
                return new HeatFlux(value, HeatFluxUnit.KilocaloriePerSecondSquareCentimeter);
            }
            /// <summary>
            ///     Get HeatFlux from KilowattPerSquareMeter.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static HeatFlux FromKilowattPerSquareMeter(double KilowattPerSquareMeter)
            {
                double value= (double)KilowattPerSquareMeter;
                return new HeatFlux(value, HeatFluxUnit.KilowattPerSquareMeter);
            }
            /// <summary>
            ///     Get HeatFlux from MicrowattPerSquareMeter.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static HeatFlux FromMicrowattPerSquareMeter(double MicrowattPerSquareMeter)
            {
                double value= (double)MicrowattPerSquareMeter;
                return new HeatFlux(value, HeatFluxUnit.MicrowattPerSquareMeter);
            }
            /// <summary>
            ///     Get HeatFlux from MilliwattPerSquareMeter.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static HeatFlux FromMilliwattPerSquareMeter(double MilliwattPerSquareMeter)
            {
                double value= (double)MilliwattPerSquareMeter;
                return new HeatFlux(value, HeatFluxUnit.MilliwattPerSquareMeter);
            }
            /// <summary>
            ///     Get HeatFlux from NanowattPerSquareMeter.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static HeatFlux FromNanowattPerSquareMeter(double NanowattPerSquareMeter)
            {
                double value= (double)NanowattPerSquareMeter;
                return new HeatFlux(value, HeatFluxUnit.NanowattPerSquareMeter);
            }
            /// <summary>
            ///     Get HeatFlux from CentiwattPerSquareMeter.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static HeatFlux FromCentiwattPerSquareMeter(double CentiwattPerSquareMeter)
            {
                double value= (double)CentiwattPerSquareMeter;
                return new HeatFlux(value, HeatFluxUnit.CentiwattPerSquareMeter);
            }
            /// <summary>
            ///     Get HeatFlux from DeciwattPerSquareMeter.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static HeatFlux FromDeciwattPerSquareMeter(double DeciwattPerSquareMeter)
            {
                double value= (double)DeciwattPerSquareMeter;
                return new HeatFlux(value, HeatFluxUnit.DeciwattPerSquareMeter);
            }
            /// <summary>
            ///     Get HeatFlux from PoundForcePerFootSecond.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static HeatFlux FromPoundForcePerFootSecond(double PoundForcePerFootSecond)
            {
                double value= (double)PoundForcePerFootSecond;
                return new HeatFlux(value, HeatFluxUnit.PoundForcePerFootSecond);
            }
            /// <summary>
            ///     Get HeatFlux from PoundPerSecondCubed.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static HeatFlux FromPoundPerSecondCubed(double PoundPerSecondCubed)
            {
                double value= (double)PoundPerSecondCubed;
                return new HeatFlux(value, HeatFluxUnit.PoundPerSecondCubed);
            }
    }
}


