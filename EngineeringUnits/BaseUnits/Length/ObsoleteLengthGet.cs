using EngineeringUnits.Units;
using System.Collections.Generic;
using System;

namespace EngineeringUnits
{
    public partial class Length
    {


        /// <summary>
        ///     Get Length in AstronomicalUnits.
        /// </summary>
        [Obsolete("Use without the 's' - AstronomicalUnits->AstronomicalUnit")]

        public double AstronomicalUnits => As(LengthUnit.AstronomicalUnit);

        /// <summary>
        ///     Get Length in Centimeters.
        /// </summary>
        [Obsolete("Use without the 's' - Centimeters->Centimeter")]

        public double Centimeters => As(LengthUnit.Centimeter);

        /// <summary>
        ///     Get Length in Chains.
        /// </summary>
        [Obsolete("Use without the 's' - Chains->Chain")]

        public double Chains => As(LengthUnit.Chain);

        /// <summary>
        ///     Get Length in Decimeters.
        /// </summary>
        [Obsolete("Use without the 's' - Decimeters->Decimeter")]

        public double Decimeters => As(LengthUnit.Decimeter);

        /// <summary>
        ///     Get Length in DtpPicas.
        /// </summary>
        [Obsolete("Use without the 's' - DtpPicas->DtpPica")]

        public double DtpPicas => As(LengthUnit.DtpPica);

        /// <summary>
        ///     Get Length in DtpPoints.
        /// </summary>
        [Obsolete("Use without the 's' - DtpPoints->DtpPoint")]

        public double DtpPoints => As(LengthUnit.DtpPoint);

        /// <summary>
        ///     Get Length in Fathoms.
        /// </summary>

        [Obsolete("Use without the 's' - Fathoms->Fathom")]
        public double Fathoms => As(LengthUnit.Fathom);

        /// <summary>
        ///     Get Length in Feet.
        /// </summary>
        [Obsolete("Use singular - Feet->Foot")]

        public double Feet => As(LengthUnit.Foot);

        /// <summary>
        ///     Get Length in Hands.
        /// </summary>
        [Obsolete("Use without the 's' - Hands->Hand")]

        public double Hands => As(LengthUnit.Hand);

        /// <summary>
        ///     Get Length in Hectometers.
        /// </summary>

        [Obsolete("Use without the 's' - Hectometers->Hectometer")]
        public double Hectometers => As(LengthUnit.Hectometer);

        /// <summary>
        ///     Get Length in Inches.
        /// </summary>

        [Obsolete("Use without the 's' - Inches->Inche")]
        public double Inches => As(LengthUnit.Inch);

        /// <summary>
        ///     Get Length in KilolightYears.
        /// </summary>

        [Obsolete("Use without the 's' - KilolightYears->KilolightYear")]
        public double KilolightYears => As(LengthUnit.KilolightYear);

        /// <summary>
        ///     Get Length in Kilometers.
        /// </summary>

        [Obsolete("Use without the 's' - Kilometers->Kilometer")]
        public double Kilometers => As(LengthUnit.Kilometer);

        /// <summary>
        ///     Get Length in Kiloparsecs.
        /// </summary>

        [Obsolete("Use without the 's' - Kiloparsecs->Kiloparsec")]
        public double Kiloparsecs => As(LengthUnit.Kiloparsec);

        /// <summary>
        ///     Get Length in LightYears.
        /// </summary>

        [Obsolete("Use without the 's' - LightYears->LightYear")]
        public double LightYears => As(LengthUnit.LightYear);

        /// <summary>
        ///     Get Length in MegalightYears.
        /// </summary>

        [Obsolete("Use without the 's' - MegalightYears->MegalightYear")]
        public double MegalightYears => As(LengthUnit.MegalightYear);

        /// <summary>
        ///     Get Length in Megaparsecs.
        /// </summary>

        [Obsolete("Use without the 's' - Megaparsecs->Megaparsec")]
        public double Megaparsecs => As(LengthUnit.Megaparsec);

        /// <summary>
        ///     Get Length in Meters.
        /// </summary>

        [Obsolete("Use without the 's' - Meters->Meter")]
        public double Meters => As(LengthUnit.Meter);

        /// <summary>
        ///     Get Length in SI Unit (Meters).
        /// </summary>

        //public double SI => As(LengthUnit.SI);

        /// <summary>
        ///     Get Length in Microinches.
        /// </summary>

        [Obsolete("Use without the 's' - Microinches->Microinch")]
        public double Microinches => As(LengthUnit.Microinch);

        /// <summary>
        ///     Get Length in Micrometers.
        /// </summary>

        [Obsolete("Use without the 's' - Micrometers->Micrometer")]
        public double Micrometers => As(LengthUnit.Micrometer);

        /// <summary>
        ///     Get Length in Mils.
        /// </summary>

        [Obsolete("Use without the 's' - Mils->Mil")]
        public double Mils => As(LengthUnit.Mil);

        /// <summary>
        ///     Get Length in Miles.
        /// </summary>

        [Obsolete("Use without the 's' - Miles->Mile")]
        public double Miles => As(LengthUnit.Mile);

        /// <summary>
        ///     Get Length in Millimeters.
        /// </summary>

        [Obsolete("Use without the 's' - Millimeters->Millimeter")]
        public double Millimeters => As(LengthUnit.Millimeter);

        /// <summary>
        ///     Get Length in Nanometers.
        /// </summary>

        [Obsolete("Use without the 's' - Nanometers->Nanometer")]
        public double Nanometers => As(LengthUnit.Nanometer);

        /// <summary>
        ///     Get Length in NauticalMiles.
        /// </summary>
        [Obsolete("Use without the 's' - NauticalMiles->NauticalMile")]

        public double NauticalMiles => As(LengthUnit.NauticalMile);

        /// <summary>
        ///     Get Length in Parsecs.
        /// </summary>
        [Obsolete("Use without the 's' - Parsecs->Parsec")]

        public double Parsecs => As(LengthUnit.Parsec);

        /// <summary>
        ///     Get Length in PrinterPicas.
        /// </summary>
        //public double PrinterPicas => As(LengthUnit.PrinterPica);

        /// <summary>
        ///     Get Length in PrinterPoints.
        /// </summary>
        //public double PrinterPoints => As(LengthUnit.PrinterPoint);

        /// <summary>
        ///     Get Length in Shackles.
        /// </summary>
        [Obsolete("Use without the 's' - Shackles->Shackle")]

        public double Shackles => As(LengthUnit.Shackle);

        /// <summary>
        ///     Get Length in SolarRadiuses.
        /// </summary>

        [Obsolete("Use without the 's' - SolarRadiuses->SolarRadius")]
        public double SolarRadiuses => As(LengthUnit.SolarRadius);

        /// <summary>
        ///     Get Length in Twips.
        /// </summary>
        [Obsolete("Use without the 's' - Twips->Twip")]

        public double Twips => As(LengthUnit.Twip);

        /// <summary>
        ///     Get Length in UsSurveyFeet.
        /// </summary>
        //public double UsSurveyFeet => As(LengthUnit.UsSurveyFoot);

        /// <summary>
        ///     Get Length in Yards.
        /// </summary>
        [Obsolete("Use without the 's' - Yards->Yard")]

        public double Yards => As(LengthUnit.Yard);






    }
}
