using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits.Units
{


    public class LinearPowerDensityUnit : Enumeration
    {

        public static readonly LinearPowerDensityUnit SI = new LinearPowerDensityUnit(PowerUnit.SI, LengthUnit.SI);
        public static readonly LinearPowerDensityUnit WattPerMeter = new LinearPowerDensityUnit(PowerUnit.Watt, LengthUnit.Meter);
        public static readonly LinearPowerDensityUnit WattPerMillimeter = new LinearPowerDensityUnit(PowerUnit.Watt, LengthUnit.Millimeter);
        public static readonly LinearPowerDensityUnit WattPerInch = new LinearPowerDensityUnit(PowerUnit.Watt, LengthUnit.Inch);
        public static readonly LinearPowerDensityUnit WattPerFoot = new LinearPowerDensityUnit(PowerUnit.Watt, LengthUnit.Foot);
        public static readonly LinearPowerDensityUnit WattPerCentimeter = new LinearPowerDensityUnit(PowerUnit.Watt, LengthUnit.Centimeter);

        public static readonly LinearPowerDensityUnit MilliwattPerMillimeter = new LinearPowerDensityUnit(PowerUnit.Milliwatt, LengthUnit.Millimeter);
        public static readonly LinearPowerDensityUnit MilliwattPerMeter = new LinearPowerDensityUnit(PowerUnit.Milliwatt, LengthUnit.Meter);
        public static readonly LinearPowerDensityUnit MilliwattPerInch = new LinearPowerDensityUnit(PowerUnit.Milliwatt, LengthUnit.Inch);
        public static readonly LinearPowerDensityUnit MilliwattPerFoot = new LinearPowerDensityUnit(PowerUnit.Milliwatt, LengthUnit.Foot);
        public static readonly LinearPowerDensityUnit MilliwattPerCentimeter = new LinearPowerDensityUnit(PowerUnit.Milliwatt, LengthUnit.Centimeter);

        public static readonly LinearPowerDensityUnit MegawattPerMillimeter = new LinearPowerDensityUnit(PowerUnit.Megawatt, LengthUnit.Millimeter);
        public static readonly LinearPowerDensityUnit MegawattPerMeter = new LinearPowerDensityUnit(PowerUnit.Megawatt, LengthUnit.Meter);
        public static readonly LinearPowerDensityUnit MegawattPerInch = new LinearPowerDensityUnit(PowerUnit.Megawatt, LengthUnit.Inch);
        public static readonly LinearPowerDensityUnit MegawattPerFoot = new LinearPowerDensityUnit(PowerUnit.Megawatt, LengthUnit.Foot);
        public static readonly LinearPowerDensityUnit MegawattPerCentimeter = new LinearPowerDensityUnit(PowerUnit.Megawatt, LengthUnit.Centimeter);

        public static readonly LinearPowerDensityUnit KilowattPerMillimeter = new LinearPowerDensityUnit(PowerUnit.Kilowatt, LengthUnit.Millimeter);
        public static readonly LinearPowerDensityUnit KilowattPerMeter = new LinearPowerDensityUnit(PowerUnit.Kilowatt, LengthUnit.Meter);
        public static readonly LinearPowerDensityUnit KilowattPerInch = new LinearPowerDensityUnit(PowerUnit.Kilowatt, LengthUnit.Inch);
        public static readonly LinearPowerDensityUnit KilowattPerFoot = new LinearPowerDensityUnit(PowerUnit.Kilowatt, LengthUnit.Foot);
        public static readonly LinearPowerDensityUnit KilowattPerCentimeter = new LinearPowerDensityUnit(PowerUnit.Kilowatt, LengthUnit.Centimeter);


        public static readonly LinearPowerDensityUnit GigawattPerMillimeter = new LinearPowerDensityUnit(PowerUnit.Gigawatt, LengthUnit.Millimeter);
        public static readonly LinearPowerDensityUnit GigawattPerMeter = new LinearPowerDensityUnit(PowerUnit.Gigawatt, LengthUnit.Meter);
        public static readonly LinearPowerDensityUnit GigawattPerInch = new LinearPowerDensityUnit(PowerUnit.Gigawatt, LengthUnit.Inch);
        public static readonly LinearPowerDensityUnit GigawattPerFoot = new LinearPowerDensityUnit(PowerUnit.Gigawatt, LengthUnit.Foot);
        public static readonly LinearPowerDensityUnit GigawattPerCentimeter = new LinearPowerDensityUnit(PowerUnit.Gigawatt, LengthUnit.Centimeter);



        public LinearPowerDensityUnit(PowerUnit power, LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = power / Length ;
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{power}/{Length}");
        }       


    }




}