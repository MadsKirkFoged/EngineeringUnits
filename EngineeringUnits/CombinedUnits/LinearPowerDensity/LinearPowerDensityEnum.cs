using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits.Units
{


    public class LinearPowerDensityUnit : UnitEnumbase
    {

        public static readonly LinearPowerDensityUnit SI = new(PowerUnit.SI, LengthUnit.SI);
        public static readonly LinearPowerDensityUnit WattPerMeter = new(PowerUnit.Watt, LengthUnit.Meter);
        public static readonly LinearPowerDensityUnit WattPerMillimeter = new(PowerUnit.Watt, LengthUnit.Millimeter);
        public static readonly LinearPowerDensityUnit WattPerInch = new(PowerUnit.Watt, LengthUnit.Inch);
        public static readonly LinearPowerDensityUnit WattPerFoot = new(PowerUnit.Watt, LengthUnit.Foot);
        public static readonly LinearPowerDensityUnit WattPerCentimeter = new(PowerUnit.Watt, LengthUnit.Centimeter);

        public static readonly LinearPowerDensityUnit MilliwattPerMillimeter = new(PowerUnit.Milliwatt, LengthUnit.Millimeter);
        public static readonly LinearPowerDensityUnit MilliwattPerMeter = new(PowerUnit.Milliwatt, LengthUnit.Meter);
        public static readonly LinearPowerDensityUnit MilliwattPerInch = new(PowerUnit.Milliwatt, LengthUnit.Inch);
        public static readonly LinearPowerDensityUnit MilliwattPerFoot = new(PowerUnit.Milliwatt, LengthUnit.Foot);
        public static readonly LinearPowerDensityUnit MilliwattPerCentimeter = new(PowerUnit.Milliwatt, LengthUnit.Centimeter);

        public static readonly LinearPowerDensityUnit MegawattPerMillimeter = new(PowerUnit.Megawatt, LengthUnit.Millimeter);
        public static readonly LinearPowerDensityUnit MegawattPerMeter = new(PowerUnit.Megawatt, LengthUnit.Meter);
        public static readonly LinearPowerDensityUnit MegawattPerInch = new(PowerUnit.Megawatt, LengthUnit.Inch);
        public static readonly LinearPowerDensityUnit MegawattPerFoot = new(PowerUnit.Megawatt, LengthUnit.Foot);
        public static readonly LinearPowerDensityUnit MegawattPerCentimeter = new(PowerUnit.Megawatt, LengthUnit.Centimeter);

        public static readonly LinearPowerDensityUnit KilowattPerMillimeter = new(PowerUnit.Kilowatt, LengthUnit.Millimeter);
        public static readonly LinearPowerDensityUnit KilowattPerMeter = new(PowerUnit.Kilowatt, LengthUnit.Meter);
        public static readonly LinearPowerDensityUnit KilowattPerInch = new(PowerUnit.Kilowatt, LengthUnit.Inch);
        public static readonly LinearPowerDensityUnit KilowattPerFoot = new(PowerUnit.Kilowatt, LengthUnit.Foot);
        public static readonly LinearPowerDensityUnit KilowattPerCentimeter = new(PowerUnit.Kilowatt, LengthUnit.Centimeter);


        public static readonly LinearPowerDensityUnit GigawattPerMillimeter = new(PowerUnit.Gigawatt, LengthUnit.Millimeter);
        public static readonly LinearPowerDensityUnit GigawattPerMeter = new(PowerUnit.Gigawatt, LengthUnit.Meter);
        public static readonly LinearPowerDensityUnit GigawattPerInch = new(PowerUnit.Gigawatt, LengthUnit.Inch);
        public static readonly LinearPowerDensityUnit GigawattPerFoot = new(PowerUnit.Gigawatt, LengthUnit.Foot);
        public static readonly LinearPowerDensityUnit GigawattPerCentimeter = new(PowerUnit.Gigawatt, LengthUnit.Centimeter);



        public LinearPowerDensityUnit(PowerUnit power, LengthUnit Length)
        {
            Unit = new UnitSystem(power / Length, 
                               $"{power}/{Length}");
        }       


    }




}