using EngineeringUnits.Units;
using System.Collections.Generic;
using System;

namespace EngineeringUnits
{
    public partial class MassFlux
    {
        /// <summary>
        ///     Get from SI Unit.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        //public static MassFlux FromSI(double si)
        //{
        //    double value = (double)si;
        //    return new MassFlux(value, MassFluxUnit.SI);
        //}



        /// <summary>
        ///     Get MassFlux from GramsPerHourPerSquareCentimeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromGramsPerHourPerSquareCentimeter->FromGramPerHourPerSquareCentimeter")]
        public static MassFlux FromGramsPerHourPerSquareCentimeter(double gramsperhourpersquarecentimeter)
        {
            double value = (double)gramsperhourpersquarecentimeter;
            return new MassFlux(value, MassFluxUnit.GramPerHourPerSquareCentimeter);
        }
      
        /// <summary>
        ///     Get MassFlux from GramsPerHourPerSquareMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromGramsPerHourPerSquareMeter->FromGramPerHourPerSquareMeter")]
        public static MassFlux FromGramsPerHourPerSquareMeter(double gramsperhourpersquaremeter)
        {
            double value = (double)gramsperhourpersquaremeter;
            return new MassFlux(value, MassFluxUnit.GramPerHourPerSquareMeter);
        }
        
        /// <summary>
        ///     Get MassFlux from GramsPerHourPerSquareMillimeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromGramsPerHourPerSquareMillimeter->FromGramPerHourPerSquareMillimeter")]
        public static MassFlux FromGramsPerHourPerSquareMillimeter(double gramsperhourpersquaremillimeter)
        {
            double value = (double)gramsperhourpersquaremillimeter;
            return new MassFlux(value, MassFluxUnit.GramPerHourPerSquareMillimeter);
        }
        
        /// <summary>
        ///     Get MassFlux from GramsPerSecondPerSquareCentimeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromGramsPerSecondPerSquareCentimeter->FromGramPerSecondPerSquareCentimeter")]
        public static MassFlux FromGramsPerSecondPerSquareCentimeter(double gramspersecondpersquarecentimeter)
        {
            double value = (double)gramspersecondpersquarecentimeter;
            return new MassFlux(value, MassFluxUnit.GramPerSecondPerSquareCentimeter);
        }
        
        /// <summary>
        ///     Get MassFlux from GramsPerSecondPerSquareMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromGramsPerSecondPerSquareMeter->FromGramPerSecondPerSquareMeter")]
        public static MassFlux FromGramsPerSecondPerSquareMeter(double gramspersecondpersquaremeter)
        {
            double value = (double)gramspersecondpersquaremeter;
            return new MassFlux(value, MassFluxUnit.GramPerSecondPerSquareMeter);
        }
        
        /// <summary>
        ///     Get MassFlux from GramsPerSecondPerSquareMillimeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromGramsPerSecondPerSquareMillimeter->FromGramPerSecondPerSquareMillimeter")]
        public static MassFlux FromGramsPerSecondPerSquareMillimeter(double gramspersecondpersquaremillimeter)
        {
            double value = (double)gramspersecondpersquaremillimeter;
            return new MassFlux(value, MassFluxUnit.GramPerSecondPerSquareMillimeter);
        }
        
        /// <summary>
        ///     Get MassFlux from KilogramsPerHourPerSquareCentimeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromKilogramsPerHourPerSquareCentimeter->FromKilogramPerHourPerSquareCentimeter")]
        public static MassFlux FromKilogramsPerHourPerSquareCentimeter(double kilogramsperhourpersquarecentimeter)
        {
            double value = (double)kilogramsperhourpersquarecentimeter;
            return new MassFlux(value, MassFluxUnit.KilogramPerHourPerSquareCentimeter);
        }
        
        /// <summary>
        ///     Get MassFlux from KilogramsPerHourPerSquareMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromKilogramsPerHourPerSquareMeter->FromKilogramPerHourPerSquareMeter")]
        public static MassFlux FromKilogramsPerHourPerSquareMeter(double kilogramsperhourpersquaremeter)
        {
            double value = (double)kilogramsperhourpersquaremeter;
            return new MassFlux(value, MassFluxUnit.KilogramPerHourPerSquareMeter);
        }
        
        /// <summary>
        ///     Get MassFlux from KilogramsPerHourPerSquareMillimeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromKilogramsPerHourPerSquareMillimeter->FromKilogramPerHourPerSquareMillimeter")]
        public static MassFlux FromKilogramsPerHourPerSquareMillimeter(double kilogramsperhourpersquaremillimeter)
        {
            double value = (double)kilogramsperhourpersquaremillimeter;
            return new MassFlux(value, MassFluxUnit.KilogramPerHourPerSquareMillimeter);
        }
        
        /// <summary>
        ///     Get MassFlux from KilogramsPerSecondPerSquareCentimeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromKilogramsPerSecondPerSquareCentimeter->FromKilogramPerSecondPerSquareCentimeter")]
        public static MassFlux FromKilogramsPerSecondPerSquareCentimeter(double kilogramspersecondpersquarecentimeter)
        {
            double value = (double)kilogramspersecondpersquarecentimeter;
            return new MassFlux(value, MassFluxUnit.KilogramPerSecondPerSquareCentimeter);
        }
        
        /// <summary>
        ///     Get MassFlux from KilogramsPerSecondPerSquareMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromKilogramsPerSecondPerSquareMeter->FromKilogramPerSecondPerSquareMeter")]
        public static MassFlux FromKilogramsPerSecondPerSquareMeter(double kilogramspersecondpersquaremeter)
        {
            double value = (double)kilogramspersecondpersquaremeter;
            return new MassFlux(value, MassFluxUnit.KilogramPerSecondPerSquareMeter);
        }
        
        /// <summary>
        ///     Get MassFlux from KilogramsPerSecondPerSquareMillimeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromKilogramsPerSecondPerSquareMillimeter->FromKilogramPerSecondPerSquareMillimeter")]
        public static MassFlux FromKilogramsPerSecondPerSquareMillimeter(double kilogramspersecondpersquaremillimeter)
        {
            double value = (double)kilogramspersecondpersquaremillimeter;
            return new MassFlux(value, MassFluxUnit.KilogramPerSecondPerSquareMillimeter);
        }


    }
}
