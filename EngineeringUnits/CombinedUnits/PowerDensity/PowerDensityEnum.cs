using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits.Units
{


    public partial record PowerDensityUnit : UnitTypebase
    {

        public static readonly PowerDensityUnit SI = new(PowerUnit.SI, VolumeUnit.SI);

        public static readonly PowerDensityUnit WattPerCubicMeter = new(PowerUnit.Watt, VolumeUnit.CubicMeter);
        public static readonly PowerDensityUnit WattPerLiter = new(PowerUnit.Watt, VolumeUnit.Liter);
        public static readonly PowerDensityUnit WattPerCubicInch = new(PowerUnit.Watt, VolumeUnit.CubicInch);
        public static readonly PowerDensityUnit WattPerCubicFoot = new(PowerUnit.Watt, VolumeUnit.CubicFoot);
        public static readonly PowerDensityUnit TerawattPerLiter = new(PowerUnit.Terawatt, VolumeUnit.Liter);
        public static readonly PowerDensityUnit TerawattPerCubicMeter = new(PowerUnit.Terawatt, VolumeUnit.CubicMeter);
        public static readonly PowerDensityUnit TerawattPerCubicInch = new(PowerUnit.Terawatt, VolumeUnit.CubicInch);
        public static readonly PowerDensityUnit TerawattPerCubicFoot = new(PowerUnit.Terawatt, VolumeUnit.CubicFoot);
        public static readonly PowerDensityUnit PicowattPerLiter = new(PowerUnit.Picowatt, VolumeUnit.Liter);
        public static readonly PowerDensityUnit PicowattPerCubicMeter = new(PowerUnit.Picowatt, VolumeUnit.CubicMeter);
        public static readonly PowerDensityUnit PicowattPerCubicInch = new(PowerUnit.Picowatt, VolumeUnit.CubicInch);
        public static readonly PowerDensityUnit PicowattPerCubicFoot = new(PowerUnit.Picowatt, VolumeUnit.CubicFoot);
        public static readonly PowerDensityUnit NanowattPerLiter = new(PowerUnit.Nanowatt, VolumeUnit.Liter);
        public static readonly PowerDensityUnit NanowattPerCubicMeter = new(PowerUnit.Nanowatt, VolumeUnit.CubicMeter);
        public static readonly PowerDensityUnit NanowattPerCubicInch = new(PowerUnit.Nanowatt, VolumeUnit.CubicInch);
        public static readonly PowerDensityUnit NanowattPerCubicFoot = new(PowerUnit.Nanowatt, VolumeUnit.CubicFoot);
        public static readonly PowerDensityUnit MilliwattPerLiter = new(PowerUnit.Milliwatt, VolumeUnit.Liter);
        public static readonly PowerDensityUnit MilliwattPerCubicMeter = new(PowerUnit.Milliwatt, VolumeUnit.CubicMeter);
        public static readonly PowerDensityUnit MilliwattPerCubicInch = new(PowerUnit.Milliwatt, VolumeUnit.CubicInch);
        public static readonly PowerDensityUnit MilliwattPerCubicFoot = new(PowerUnit.Milliwatt, VolumeUnit.CubicFoot);
        public static readonly PowerDensityUnit MicrowattPerLiter = new(PowerUnit.Microwatt, VolumeUnit.Liter);
        public static readonly PowerDensityUnit MicrowattPerCubicMeter = new(PowerUnit.Microwatt, VolumeUnit.CubicMeter);
        public static readonly PowerDensityUnit MicrowattPerCubicInch = new(PowerUnit.Microwatt, VolumeUnit.CubicInch);
        public static readonly PowerDensityUnit MicrowattPerCubicFoot = new(PowerUnit.Microwatt, VolumeUnit.CubicFoot);
        public static readonly PowerDensityUnit MegawattPerLiter = new(PowerUnit.Megawatt, VolumeUnit.Liter);
        public static readonly PowerDensityUnit MegawattPerCubicMeter = new(PowerUnit.Megawatt, VolumeUnit.CubicMeter);
        public static readonly PowerDensityUnit MegawattPerCubicInch = new(PowerUnit.Megawatt, VolumeUnit.CubicInch);
        public static readonly PowerDensityUnit MegawattPerCubicFoot = new(PowerUnit.Megawatt, VolumeUnit.CubicFoot);
        public static readonly PowerDensityUnit KilowattPerLiter = new(PowerUnit.Kilowatt, VolumeUnit.Liter);
        public static readonly PowerDensityUnit KilowattPerCubicMeter = new(PowerUnit.Kilowatt, VolumeUnit.CubicMeter);
        public static readonly PowerDensityUnit KilowattPerCubicInch = new(PowerUnit.Kilowatt, VolumeUnit.CubicInch);
        public static readonly PowerDensityUnit KilowattPerCubicFoot = new(PowerUnit.Kilowatt, VolumeUnit.CubicFoot);
        public static readonly PowerDensityUnit GigawattPerLiter = new(PowerUnit.Gigawatt, VolumeUnit.Liter);
        public static readonly PowerDensityUnit GigawattPerCubicMeter = new(PowerUnit.Gigawatt, VolumeUnit.CubicMeter);
        public static readonly PowerDensityUnit GigawattPerCubicInch = new(PowerUnit.Gigawatt, VolumeUnit.CubicInch);
        public static readonly PowerDensityUnit GigawattPerCubicFoot = new(PowerUnit.Gigawatt, VolumeUnit.CubicFoot);
        public static readonly PowerDensityUnit DeciwattPerLiter = new(PowerUnit.Deciwatt, VolumeUnit.Liter);
        public static readonly PowerDensityUnit DeciwattPerCubicMeter = new(PowerUnit.Deciwatt, VolumeUnit.CubicMeter);
        public static readonly PowerDensityUnit DeciwattPerCubicInch = new(PowerUnit.Deciwatt, VolumeUnit.CubicInch);
        public static readonly PowerDensityUnit DeciwattPerCubicFoot = new(PowerUnit.Deciwatt, VolumeUnit.CubicFoot);
        public static readonly PowerDensityUnit DecawattPerLiter = new(PowerUnit.Decawatt, VolumeUnit.Liter);
        public static readonly PowerDensityUnit DecawattPerCubicMeter = new(PowerUnit.Decawatt, VolumeUnit.CubicMeter);
        public static readonly PowerDensityUnit DecawattPerCubicInch = new(PowerUnit.Decawatt, VolumeUnit.CubicInch);
        public static readonly PowerDensityUnit DecawattPerCubicFoot = new(PowerUnit.Decawatt, VolumeUnit.CubicFoot);



        public PowerDensityUnit(PowerUnit power, VolumeUnit volume)
        {
            Unit = new UnitSystem(power / volume, 
                               $"{power}/{volume}");
        }

        public override string ToString()
        {
            if (Unit.Symbol is not null)
                return $"{Unit.Symbol}";

            return $"{Unit}";
        }

    }




}