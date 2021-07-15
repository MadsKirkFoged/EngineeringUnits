using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits.Units
{


    public class LinearDensityUnit : Enumeration
    {

        public static readonly LinearDensityUnit SI = new LinearDensityUnit(MassUnit.SI, LengthUnit.SI);
        public static readonly LinearDensityUnit KilogramPerMeter = new LinearDensityUnit(MassUnit.Kilogram, LengthUnit.Meter);
        public static readonly LinearDensityUnit GramPerCentimeter = new LinearDensityUnit(MassUnit.Gram, LengthUnit.Centimeter);
        public static readonly LinearDensityUnit GramPerMeter = new LinearDensityUnit(MassUnit.Gram, LengthUnit.Meter);
        public static readonly LinearDensityUnit GramPerMillimeter = new LinearDensityUnit(MassUnit.Gram, LengthUnit.Millimeter);
        public static readonly LinearDensityUnit KilogramPerCentimeter = new LinearDensityUnit(MassUnit.Kilogram, LengthUnit.Centimeter);
        public static readonly LinearDensityUnit KilogramPerMillimeter = new LinearDensityUnit(MassUnit.Kilogram, LengthUnit.Millimeter);
        public static readonly LinearDensityUnit MicrogramPerCentimeter = new LinearDensityUnit(MassUnit.Microgram, LengthUnit.Centimeter);
        public static readonly LinearDensityUnit MicrogramPerMeter = new LinearDensityUnit(MassUnit.Microgram, LengthUnit.Meter);
        public static readonly LinearDensityUnit MicrogramPerMillimeter = new LinearDensityUnit(MassUnit.Microgram, LengthUnit.Millimeter);
        public static readonly LinearDensityUnit MilligramPerCentimeter = new LinearDensityUnit(MassUnit.Milligram, LengthUnit.Centimeter);
        public static readonly LinearDensityUnit MilligramPerMeter = new LinearDensityUnit(MassUnit.Milligram, LengthUnit.Meter);

        public static readonly LinearDensityUnit MilligramPerMillimeter = new LinearDensityUnit(MassUnit.Milligram, LengthUnit.Millimeter);
        public static readonly LinearDensityUnit PoundPerFoot = new LinearDensityUnit(MassUnit.Pound, LengthUnit.Foot);
        public static readonly LinearDensityUnit PoundPerInch = new LinearDensityUnit(MassUnit.Pound, LengthUnit.Inch);






        public LinearDensityUnit(MassUnit mass, LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = mass / Length;
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{mass}/{Length}");
        }

        

    }




}