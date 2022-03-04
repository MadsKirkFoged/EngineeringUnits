using EngineeringUnits.Units;
using System.Collections.Generic;
using System;

namespace EngineeringUnits
{
    public partial class Speed
    {
        /// <summary>
        ///     Get Speed in CentimetersPerHour.
        /// </summary>
        [Obsolete("Use without the 's' - CentimetersPerHour->CentimeterPerHour")]
        public double CentimetersPerHour => As(SpeedUnit.CentimeterPerHour);

        /// <summary>
        ///     Get Speed in CentimetersPerMinutes.
        /// </summary>
        [Obsolete("Use without the 's' - CentimetersPerMinutes->CentimeterPerMinute")]
        public double CentimetersPerMinutes => As(SpeedUnit.CentimeterPerMinute);

        /// <summary>
        ///     Get Speed in CentimetersPerSecond.
        /// </summary>
        [Obsolete("Use without the 's' - CentimetersPerSecond->CentimeterPerSecond")]
        public double CentimetersPerSecond => As(SpeedUnit.CentimeterPerSecond);

        /// <summary>
        ///     Get Speed in DecimetersPerMinutes.
        /// </summary>
        [Obsolete("Use without the 's' - DecimetersPerMinutes->DecimeterPerMinute")]
        public double DecimetersPerMinutes => As(SpeedUnit.DecimeterPerMinute);

        /// <summary>
        ///     Get Speed in DecimetersPerSecond.
        /// </summary>
        [Obsolete("Use without the 's' - DecimetersPerSecond->DecimeterPerSecond")]
        public double DecimetersPerSecond => As(SpeedUnit.DecimeterPerSecond);

        /// <summary>
        ///     Get Speed in FeetPerHour.
        /// </summary>
        [Obsolete("Use singular form - FeetPerHour->FootPerHour")]
        public double FeetPerHour => As(SpeedUnit.FootPerHour);

        /// <summary>
        ///     Get Speed in FeetPerMinute.
        /// </summary>
        [Obsolete("Use singular form - FeetPerMinute->FootPerMinute")]
        public double FeetPerMinute => As(SpeedUnit.FootPerMinute);

        /// <summary>
        ///     Get Speed in FeetPerSecond.
        /// </summary>
        [Obsolete("Use singular form - FeetPerSecond->FootPerSecond")]
        public double FeetPerSecond => As(SpeedUnit.FootPerSecond);

        /// <summary>
        ///     Get Speed in InchesPerHour.
        /// </summary>
        [Obsolete("Use without the 's' - InchesPerHour->InchPerHour")]
        public double InchesPerHour => As(SpeedUnit.InchPerHour);

        /// <summary>
        ///     Get Speed in InchesPerMinute.
        /// </summary>
        [Obsolete("Use without the 's' - InchesPerMinute->InchPerMinute")]
        public double InchesPerMinute => As(SpeedUnit.InchPerMinute);

        /// <summary>
        ///     Get Speed in InchesPerSecond.
        /// </summary>
        [Obsolete("Use without the 's' - InchesPerSecond->InchPerSecond")]
        public double InchesPerSecond => As(SpeedUnit.InchPerSecond);

        /// <summary>
        ///     Get Speed in KilometersPerHour.
        /// </summary>
        [Obsolete("Use without the 's' - KilometersPerHour->KilometerPerHour")]
        public double KilometersPerHour => As(SpeedUnit.KilometerPerHour);

        /// <summary>
        ///     Get Speed in KilometersPerMinutes.
        /// </summary>
        [Obsolete("Use without the 's' - KilometersPerMinutes->KilometerPerMinute")]
        public double KilometersPerMinutes => As(SpeedUnit.KilometerPerMinute);

        /// <summary>
        ///     Get Speed in KilometersPerSecond.
        /// </summary>
        [Obsolete("Use without the 's' - KilometersPerSecond->KilometerPerSecond")]
        public double KilometersPerSecond => As(SpeedUnit.KilometerPerSecond);

        /// <summary>
        ///     Get Speed in Knots.
        /// </summary>
        [Obsolete("Use without the 's' - Knots->Knot")]
        public double Knots => As(SpeedUnit.Knot);

        /// <summary>
        ///     Get Speed in MetersPerHour.
        /// </summary>
        [Obsolete("Use without the 's' - MetersPerHour->MeterPerHour")]
        public double MetersPerHour => As(SpeedUnit.MeterPerHour);

        /// <summary>
        ///     Get Speed in MetersPerMinutes.
        /// </summary>
        [Obsolete("Use without the 's' - MetersPerMinutes->MeterPerMinute")]
        public double MetersPerMinutes => As(SpeedUnit.MeterPerMinute);

        /// <summary>
        ///     Get Speed in MetersPerSecond.
        /// </summary>
        [Obsolete("Use without the 's' - MetersPerSecond->MeterPerSecond")]
        public double MetersPerSecond => As(SpeedUnit.MeterPerSecond);

        /// <summary>
        ///     Get Speed in SI unit (MetersPerSecond).
        /// </summary>
        //public double SI => As(SpeedUnit.SI);

        /// <summary>
        ///     Get Speed in MicrometersPerMinutes.
        /// </summary>
        [Obsolete("Use without the 's' - MicrometersPerMinutes->MicrometerPerMinute")]
        public double MicrometersPerMinutes => As(SpeedUnit.MicrometerPerMinute);

        /// <summary>
        ///     Get Speed in MicrometersPerSecond.
        /// </summary>
        [Obsolete("Use without the 's' - MicrometersPerSecond->MicrometerPerSecond")]
        public double MicrometersPerSecond => As(SpeedUnit.MicrometerPerSecond);

        /// <summary>
        ///     Get Speed in MilesPerHour.
        /// </summary>
        [Obsolete("Use without the 's' - MilesPerHour->MilePerHour")]
        public double MilesPerHour => As(SpeedUnit.MilePerHour);

        /// <summary>
        ///     Get Speed in MillimetersPerHour.
        /// </summary>
        [Obsolete("Use without the 's' - MillimetersPerHour->MillimeterPerHour")]
        public double MillimetersPerHour => As(SpeedUnit.MillimeterPerHour);

        /// <summary>
        ///     Get Speed in MillimetersPerMinutes.
        /// </summary>
        [Obsolete("Use without the 's' - MillimetersPerMinutes->MillimeterPerMinute")]
        public double MillimetersPerMinutes => As(SpeedUnit.MillimeterPerMinute);

        /// <summary>
        ///     Get Speed in MillimetersPerSecond.
        /// </summary>
        [Obsolete("Use without the 's' - MillimetersPerSecond->MillimeterPerSecond")]
        public double MillimetersPerSecond => As(SpeedUnit.MillimeterPerSecond);

        /// <summary>
        ///     Get Speed in NanometersPerMinutes.
        /// </summary>
        [Obsolete("Use without the 's' - NanometersPerMinutes->NanometerPerMinute")]
        public double NanometersPerMinutes => As(SpeedUnit.NanometerPerMinute);

        /// <summary>
        ///     Get Speed in NanometersPerSecond.
        /// </summary>
        [Obsolete("Use without the 's' - NanometersPerSecond->NanometerPerSecond")]
        public double NanometersPerSecond => As(SpeedUnit.NanometerPerSecond);

        /// <summary>
        ///     Get Speed in UsSurveyFeetPerHour.
        /// </summary>
        [Obsolete("Use singular form - UsSurveyFeetPerHour->UsSurveyFootPerHour")]
        public double UsSurveyFeetPerHour => As(SpeedUnit.UsSurveyFootPerHour);

        /// <summary>
        ///     Get Speed in UsSurveyFeetPerMinute.
        /// </summary>
        [Obsolete("Use singular form - UsSurveyFeetPerMinute->UsSurveyFootPerMinute")]
        public double UsSurveyFeetPerMinute => As(SpeedUnit.UsSurveyFootPerMinute);

        /// <summary>
        ///     Get Speed in UsSurveyFeetPerSecond.
        /// </summary>
        [Obsolete("Use singular form - UsSurveyFeetPerSecond->UsSurveyFootPerSecond")]
        public double UsSurveyFeetPerSecond => As(SpeedUnit.UsSurveyFootPerSecond);

        /// <summary>
        ///     Get Speed in YardsPerHour.
        /// </summary>
        [Obsolete("Use without the 's' - YardsPerHour->YardPerHour")]
        public double YardsPerHour => As(SpeedUnit.YardPerHour);

        /// <summary>
        ///     Get Speed in YardsPerMinute.
        /// </summary>
        [Obsolete("Use without the 's' - YardsPerMinute->YardPerMinute")]
        public double YardsPerMinute => As(SpeedUnit.YardPerMinute);

        /// <summary>
        ///     Get Speed in YardsPerSecond.
        /// </summary>
        [Obsolete("Use without the 's' - YardsPerSecond->YardPerSecond")]
        public double YardsPerSecond => As(SpeedUnit.YardPerSecond);
    }
}
