using EngineeringUnits.Units;
using System.Collections.Generic;
using System;

namespace EngineeringUnits
{
    public partial class Speed
    {

        /// <summary>
        ///     Get from SI Unit.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        //public static Speed FromSI(double si)
        //{
        //    double value = (double)si;
        //    return new Speed(value, SpeedUnit.SI);
        //}

        /// <summary>
        ///     Get Speed from CentimetersPerHour.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromCentimetersPerHour->FromCentimeterPerHour")]
        public static Speed FromCentimetersPerHour(double centimetersperhour)
        {
            double value = (double)centimetersperhour;
            return new Speed(value, SpeedUnit.CentimeterPerHour);
        }
       
        /// <summary>
        ///     Get Speed from CentimetersPerMinutes.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromCentimetersPerMinutes->FromCentimeterPerMinutes")]
        public static Speed FromCentimetersPerMinutes(double centimetersperminutes)
        {
            double value = (double)centimetersperminutes;
            return new Speed(value, SpeedUnit.CentimeterPerMinute);
        }
        
        /// <summary>
        ///     Get Speed from CentimetersPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromCentimetersPerSecond->FromCentimeterPerSecond")]
        public static Speed FromCentimetersPerSecond(double centimeterspersecond)
        {
            double value = (double)centimeterspersecond;
            return new Speed(value, SpeedUnit.CentimeterPerSecond);
        }
        
        /// <summary>
        ///     Get Speed from DecimetersPerMinutes.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromDecimetersPerMinutes->FromDecimeterPerMinutes")]
        public static Speed FromDecimetersPerMinutes(double decimetersperminutes)
        {
            double value = (double)decimetersperminutes;
            return new Speed(value, SpeedUnit.DecimeterPerMinute);
        }
       
        /// <summary>
        ///     Get Speed from DecimetersPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromDecimetersPerSecond->FromDecimeterPerSecond")]
        public static Speed FromDecimetersPerSecond(double decimeterspersecond)
        {
            double value = (double)decimeterspersecond;
            return new Speed(value, SpeedUnit.DecimeterPerSecond);
        }
       
        /// <summary>
        ///     Get Speed from FeetPerHour.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use singular form - FromFeetPerHour->FromFootPerHour")]
        public static Speed FromFeetPerHour(double feetperhour)
        {
            double value = (double)feetperhour;
            return new Speed(value, SpeedUnit.FootPerHour);
        }
      
        /// <summary>
        ///     Get Speed from FeetPerMinute.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use singular form - FromFeetPerMinute->FromFootPerMinute")]
        public static Speed FromFeetPerMinute(double feetperminute)
        {
            double value = (double)feetperminute;
            return new Speed(value, SpeedUnit.FootPerMinute);
        }
       
        /// <summary>
        ///     Get Speed from FeetPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use singular form - FromFeetPerSecond->FromFootPerSecond")]
        public static Speed FromFeetPerSecond(double feetpersecond)
        {
            double value = (double)feetpersecond;
            return new Speed(value, SpeedUnit.FootPerSecond);
        }
      
        /// <summary>
        ///     Get Speed from InchesPerHour.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromInchesPerHour->FromInchPerHour")]
        public static Speed FromInchesPerHour(double inchesperhour)
        {
            double value = (double)inchesperhour;
            return new Speed(value, SpeedUnit.InchPerHour);
        }
       
        /// <summary>
        ///     Get Speed from InchesPerMinute.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromInchesPerMinute->FromInchPerMinute")]
        public static Speed FromInchesPerMinute(double inchesperminute)
        {
            double value = (double)inchesperminute;
            return new Speed(value, SpeedUnit.InchPerMinute);
        }
     
        /// <summary>
        ///     Get Speed from InchesPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromInchesPerSecond->FromInchPerSecond")]
        public static Speed FromInchesPerSecond(double inchespersecond)
        {
            double value = (double)inchespersecond;
            return new Speed(value, SpeedUnit.InchPerSecond);
        }
      
        /// <summary>
        ///     Get Speed from KilometersPerHour.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromKilometersPerHour->FromKilometerPerHour")]
        public static Speed FromKilometersPerHour(double kilometersperhour)
        {
            double value = (double)kilometersperhour;
            return new Speed(value, SpeedUnit.KilometerPerHour);
        }
      
        /// <summary>
        ///     Get Speed from KilometersPerMinutes.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromKilometersPerMinutes->FromKilometerPerMinutes")]
        public static Speed FromKilometersPerMinutes(double kilometersperminutes)
        {
            double value = (double)kilometersperminutes;
            return new Speed(value, SpeedUnit.KilometerPerMinute);
        }
       
        /// <summary>
        ///     Get Speed from KilometersPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromKilometersPerSecond->FromKilometerPerSecond")]
        public static Speed FromKilometersPerSecond(double kilometerspersecond)
        {
            double value = (double)kilometerspersecond;
            return new Speed(value, SpeedUnit.KilometerPerSecond);
        }
      
        /// <summary>
        ///     Get Speed from Knots.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromKnots->FromKnot")]
        public static Speed FromKnots(double knots)
        {
            double value = (double)knots;
            return new Speed(value, SpeedUnit.Knot);
        }
       
        /// <summary>
        ///     Get Speed from MetersPerHour.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromMetersPerHour->FromMeterPerHour")]
        public static Speed FromMetersPerHour(double metersperhour)
        {
            double value = (double)metersperhour;
            return new Speed(value, SpeedUnit.MeterPerHour);
        }
      
        /// <summary>
        ///     Get Speed from MetersPerMinutes.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromMetersPerMinutes->FromMeterPerMinutes")]
        public static Speed FromMetersPerMinutes(double metersperminutes)
        {
            double value = (double)metersperminutes;
            return new Speed(value, SpeedUnit.MeterPerMinute);
        }
       
        /// <summary>
        ///     Get Speed from MetersPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromMetersPerSecond->FromMeterPerSecond")]
        public static Speed FromMetersPerSecond(double meterspersecond)
        {
            double value = (double)meterspersecond;
            return new Speed(value, SpeedUnit.MeterPerSecond);
        }
      
        /// <summary>
        ///     Get Speed from MicrometersPerMinutes.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromMicrometersPerMinutes->FromMicrometerPerMinutes")]
        public static Speed FromMicrometersPerMinutes(double micrometersperminutes)
        {
            double value = (double)micrometersperminutes;
            return new Speed(value, SpeedUnit.MicrometerPerMinute);
        }
       
        /// <summary>
        ///     Get Speed from MicrometersPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromMicrometersPerSecond->FromMicrometerPerSecond")]
        public static Speed FromMicrometersPerSecond(double micrometerspersecond)
        {
            double value = (double)micrometerspersecond;
            return new Speed(value, SpeedUnit.MicrometerPerSecond);
        }
      
        /// <summary>
        ///     Get Speed from MilesPerHour.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromMilesPerHour->FromMilePerHour")]
        public static Speed FromMilesPerHour(double milesperhour)
        {
            double value = (double)milesperhour;
            return new Speed(value, SpeedUnit.MilePerHour);
        }
       
        /// <summary>
        ///     Get Speed from MillimetersPerHour.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromMillimetersPerHour->FromMillimeterPerHour")]
        public static Speed FromMillimetersPerHour(double millimetersperhour)
        {
            double value = (double)millimetersperhour;
            return new Speed(value, SpeedUnit.MillimeterPerHour);
        }
      
        /// <summary>
        ///     Get Speed from MillimetersPerMinutes.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromMillimetersPerMinutes->FromMillimeterPerMinutes")]
        public static Speed FromMillimetersPerMinutes(double millimetersperminutes)
        {
            double value = (double)millimetersperminutes;
            return new Speed(value, SpeedUnit.MillimeterPerMinute);
        }
      
        /// <summary>
        ///     Get Speed from MillimetersPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromMillimetersPerSecond->FromMillimeterPerSecond")]
        public static Speed FromMillimetersPerSecond(double millimeterspersecond)
        {
            double value = (double)millimeterspersecond;
            return new Speed(value, SpeedUnit.MillimeterPerSecond);
        }
       
        /// <summary>
        ///     Get Speed from NanometersPerMinutes.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromNanometersPerMinutes->FromNanometerPerMinutes")]
        public static Speed FromNanometersPerMinutes(double nanometersperminutes)
        {
            double value = (double)nanometersperminutes;
            return new Speed(value, SpeedUnit.NanometerPerMinute);
        }
       
        /// <summary>
        ///     Get Speed from NanometersPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromNanometersPerSecond->FromNanometerPerSecond")]
        public static Speed FromNanometersPerSecond(double nanometerspersecond)
        {
            double value = (double)nanometerspersecond;
            return new Speed(value, SpeedUnit.NanometerPerSecond);
        }
       
        /// <summary>
        ///     Get Speed from UsSurveyFeetPerHour.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use singular from - FromUsSurveyFeetPerHour->FromUsSurveyFoottPerHour")]
        public static Speed FromUsSurveyFeetPerHour(double ussurveyfeetperhour)
        {
            double value = (double)ussurveyfeetperhour;
            return new Speed(value, SpeedUnit.UsSurveyFootPerHour);
        }
      
        /// <summary>
        ///     Get Speed from UsSurveyFeetPerMinute.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use singular from - FromUsSurveyFeetPerMinute->FromUsSurveyFootPerMinute")]
        public static Speed FromUsSurveyFeetPerMinute(double ussurveyfeetperminute)
        {
            double value = (double)ussurveyfeetperminute;
            return new Speed(value, SpeedUnit.UsSurveyFootPerMinute);
        }
      
        /// <summary>
        ///     Get Speed from UsSurveyFeetPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use singular from - FromUsSurveyFeetPerSecond->FromUsSurveyFootPerSecond")]
        public static Speed FromUsSurveyFeetPerSecond(double ussurveyfeetpersecond)
        {
            double value = (double)ussurveyfeetpersecond;
            return new Speed(value, SpeedUnit.UsSurveyFootPerSecond);
        }
       
        /// <summary>
        ///     Get Speed from YardsPerHour.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromYardsPerHour->FromYardPerHour")]
        public static Speed FromYardsPerHour(double yardsperhour)
        {
            double value = (double)yardsperhour;
            return new Speed(value, SpeedUnit.YardPerHour);
        }
      
        /// <summary>
        ///     Get Speed from YardsPerMinute.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromYardsPerMinute->FromYardPerMinute")]
        public static Speed FromYardsPerMinute(double yardsperminute)
        {
            double value = (double)yardsperminute;
            return new Speed(value, SpeedUnit.YardPerMinute);
        }
      
        /// <summary>
        ///     Get Speed from YardsPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromYardsPerSecond->FromYardPerSecond")]
        public static Speed FromYardsPerSecond(double yardspersecond)
        {
            double value = (double)yardspersecond;
            return new Speed(value, SpeedUnit.YardPerSecond);
        }

    }
}
