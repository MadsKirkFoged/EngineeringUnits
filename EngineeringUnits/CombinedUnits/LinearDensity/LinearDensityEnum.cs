using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits.Units
{


    public class LinearDensityUnit : Enumeration
    {

        public static readonly LinearDensityUnit SI = new(MassUnit.SI, LengthUnit.SI);
        public static readonly LinearDensityUnit KilogramPerMeter = new(MassUnit.Kilogram, LengthUnit.Meter);
        public static readonly LinearDensityUnit GramPerCentimeter = new(MassUnit.Gram, LengthUnit.Centimeter);
        public static readonly LinearDensityUnit GramPerMeter = new(MassUnit.Gram, LengthUnit.Meter);
        public static readonly LinearDensityUnit GramPerMillimeter = new(MassUnit.Gram, LengthUnit.Millimeter);
        public static readonly LinearDensityUnit KilogramPerCentimeter = new(MassUnit.Kilogram, LengthUnit.Centimeter);
        public static readonly LinearDensityUnit KilogramPerMillimeter = new(MassUnit.Kilogram, LengthUnit.Millimeter);
        public static readonly LinearDensityUnit MicrogramPerCentimeter = new(MassUnit.Microgram, LengthUnit.Centimeter);
        public static readonly LinearDensityUnit MicrogramPerMeter = new(MassUnit.Microgram, LengthUnit.Meter);
        public static readonly LinearDensityUnit MicrogramPerMillimeter = new(MassUnit.Microgram, LengthUnit.Millimeter);
        public static readonly LinearDensityUnit MilligramPerCentimeter = new(MassUnit.Milligram, LengthUnit.Centimeter);
        public static readonly LinearDensityUnit MilligramPerMeter = new(MassUnit.Milligram, LengthUnit.Meter);

        public static readonly LinearDensityUnit MilligramPerMillimeter = new(MassUnit.Milligram, LengthUnit.Millimeter);
        public static readonly LinearDensityUnit PoundPerFoot = new(MassUnit.Pound, LengthUnit.Foot);
        public static readonly LinearDensityUnit PoundPerInch = new(MassUnit.Pound, LengthUnit.Inch);


        public LinearDensityUnit(MassUnit mass, LengthUnit Length)
        {
            Unit = mass / Length;
        }

        

    }




}