using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{


    public class PowerDensityUnit : Enumeration
    {

        public static readonly PowerDensityUnit SI = new PowerDensityUnit(PowerUnit.Watt, VolumeUnit.CubicMeter);

        public static readonly PowerDensityUnit WattPerCubicMeter = new PowerDensityUnit(PowerUnit.Watt, VolumeUnit.CubicMeter);
        public static readonly PowerDensityUnit WattPerLiter = new PowerDensityUnit(PowerUnit.Watt, VolumeUnit.Liter);
        public static readonly PowerDensityUnit WattPerCubicInch = new PowerDensityUnit(PowerUnit.Watt, VolumeUnit.CubicInch);
        public static readonly PowerDensityUnit WattPerCubicFoot = new PowerDensityUnit(PowerUnit.Watt, VolumeUnit.CubicFoot);
        public static readonly PowerDensityUnit TerawattPerLiter = new PowerDensityUnit(PowerUnit.Terawatt, VolumeUnit.Liter);
        public static readonly PowerDensityUnit TerawattPerCubicMeter = new PowerDensityUnit(PowerUnit.Terawatt, VolumeUnit.CubicMeter);
        public static readonly PowerDensityUnit TerawattPerCubicInch = new PowerDensityUnit(PowerUnit.Terawatt, VolumeUnit.CubicInch);
        public static readonly PowerDensityUnit TerawattPerCubicFoot = new PowerDensityUnit(PowerUnit.Terawatt, VolumeUnit.CubicFoot);
        public static readonly PowerDensityUnit PicowattPerLiter = new PowerDensityUnit(PowerUnit.Picowatt, VolumeUnit.Liter);
        public static readonly PowerDensityUnit PicowattPerCubicMeter = new PowerDensityUnit(PowerUnit.Picowatt, VolumeUnit.CubicMeter);
        public static readonly PowerDensityUnit PicowattPerCubicInch = new PowerDensityUnit(PowerUnit.Picowatt, VolumeUnit.CubicInch);
        public static readonly PowerDensityUnit PicowattPerCubicFoot = new PowerDensityUnit(PowerUnit.Picowatt, VolumeUnit.CubicFoot);
        public static readonly PowerDensityUnit NanowattPerLiter = new PowerDensityUnit(PowerUnit.Nanowatt, VolumeUnit.Liter);
        public static readonly PowerDensityUnit NanowattPerCubicMeter = new PowerDensityUnit(PowerUnit.Nanowatt, VolumeUnit.CubicMeter);
        public static readonly PowerDensityUnit NanowattPerCubicInch = new PowerDensityUnit(PowerUnit.Nanowatt, VolumeUnit.CubicInch);
        public static readonly PowerDensityUnit NanowattPerCubicFoot = new PowerDensityUnit(PowerUnit.Nanowatt, VolumeUnit.CubicFoot);
        public static readonly PowerDensityUnit MilliwattPerLiter = new PowerDensityUnit(PowerUnit.Milliwatt, VolumeUnit.Liter);
        public static readonly PowerDensityUnit MilliwattPerCubicMeter = new PowerDensityUnit(PowerUnit.Milliwatt, VolumeUnit.CubicMeter);
        public static readonly PowerDensityUnit MilliwattPerCubicInch = new PowerDensityUnit(PowerUnit.Milliwatt, VolumeUnit.CubicInch);
        public static readonly PowerDensityUnit MilliwattPerCubicFoot = new PowerDensityUnit(PowerUnit.Milliwatt, VolumeUnit.CubicFoot);
        public static readonly PowerDensityUnit MicrowattPerLiter = new PowerDensityUnit(PowerUnit.Microwatt, VolumeUnit.Liter);
        public static readonly PowerDensityUnit MicrowattPerCubicMeter = new PowerDensityUnit(PowerUnit.Microwatt, VolumeUnit.CubicMeter);
        public static readonly PowerDensityUnit MicrowattPerCubicInch = new PowerDensityUnit(PowerUnit.Microwatt, VolumeUnit.CubicInch);
        public static readonly PowerDensityUnit MicrowattPerCubicFoot = new PowerDensityUnit(PowerUnit.Microwatt, VolumeUnit.CubicFoot);
        public static readonly PowerDensityUnit MegawattPerLiter = new PowerDensityUnit(PowerUnit.Megawatt, VolumeUnit.Liter);
        public static readonly PowerDensityUnit MegawattPerCubicMeter = new PowerDensityUnit(PowerUnit.Megawatt, VolumeUnit.CubicMeter);
        public static readonly PowerDensityUnit MegawattPerCubicInch = new PowerDensityUnit(PowerUnit.Megawatt, VolumeUnit.CubicInch);
        public static readonly PowerDensityUnit MegawattPerCubicFoot = new PowerDensityUnit(PowerUnit.Megawatt, VolumeUnit.CubicFoot);
        public static readonly PowerDensityUnit KilowattPerLiter = new PowerDensityUnit(PowerUnit.Kilowatt, VolumeUnit.Liter);
        public static readonly PowerDensityUnit KilowattPerCubicMeter = new PowerDensityUnit(PowerUnit.Kilowatt, VolumeUnit.CubicMeter);
        public static readonly PowerDensityUnit KilowattPerCubicInch = new PowerDensityUnit(PowerUnit.Kilowatt, VolumeUnit.CubicInch);
        public static readonly PowerDensityUnit KilowattPerCubicFoot = new PowerDensityUnit(PowerUnit.Kilowatt, VolumeUnit.CubicFoot);
        public static readonly PowerDensityUnit GigawattPerLiter = new PowerDensityUnit(PowerUnit.Gigawatt, VolumeUnit.Liter);
        public static readonly PowerDensityUnit GigawattPerCubicMeter = new PowerDensityUnit(PowerUnit.Gigawatt, VolumeUnit.CubicMeter);
        public static readonly PowerDensityUnit GigawattPerCubicInch = new PowerDensityUnit(PowerUnit.Gigawatt, VolumeUnit.CubicInch);
        public static readonly PowerDensityUnit GigawattPerCubicFoot = new PowerDensityUnit(PowerUnit.Gigawatt, VolumeUnit.CubicFoot);
        public static readonly PowerDensityUnit DeciwattPerLiter = new PowerDensityUnit(PowerUnit.Deciwatt, VolumeUnit.Liter);
        public static readonly PowerDensityUnit DeciwattPerCubicMeter = new PowerDensityUnit(PowerUnit.Deciwatt, VolumeUnit.CubicMeter);
        public static readonly PowerDensityUnit DeciwattPerCubicInch = new PowerDensityUnit(PowerUnit.Deciwatt, VolumeUnit.CubicInch);
        public static readonly PowerDensityUnit DeciwattPerCubicFoot = new PowerDensityUnit(PowerUnit.Deciwatt, VolumeUnit.CubicFoot);
        public static readonly PowerDensityUnit DecawattPerLiter = new PowerDensityUnit(PowerUnit.Decawatt, VolumeUnit.Liter);
        public static readonly PowerDensityUnit DecawattPerCubicMeter = new PowerDensityUnit(PowerUnit.Decawatt, VolumeUnit.CubicMeter);
        public static readonly PowerDensityUnit DecawattPerCubicInch = new PowerDensityUnit(PowerUnit.Decawatt, VolumeUnit.CubicInch);
        public static readonly PowerDensityUnit DecawattPerCubicFoot = new PowerDensityUnit(PowerUnit.Decawatt, VolumeUnit.CubicFoot);



        public PowerDensityUnit(PowerUnit power, VolumeUnit volume, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = power.Unit / volume.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{power}/{volume}");
        }
       

    }




}