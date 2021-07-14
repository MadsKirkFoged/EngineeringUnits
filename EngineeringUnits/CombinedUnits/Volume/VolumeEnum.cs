using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{


    public class VolumeUnit : Enumeration
    {

        public static readonly VolumeUnit SI =                   new VolumeUnit(LengthUnit.Meter);
        public static readonly VolumeUnit CubicMeter =           new VolumeUnit(LengthUnit.Meter);
        public static readonly VolumeUnit HectocubicMeter =      new VolumeUnit(PreFix.hecto, CubicMeter);
        public static readonly VolumeUnit KilocubicMeter =       new VolumeUnit(PreFix.kilo, CubicMeter);
        public static readonly VolumeUnit CubicKilometer =       new VolumeUnit(LengthUnit.Kilometer);
        public static readonly VolumeUnit CubicMicrometer =      new VolumeUnit(LengthUnit.Micrometer);
        public static readonly VolumeUnit CubicMile =            new VolumeUnit(LengthUnit.Mile);
        public static readonly VolumeUnit CubicMillimeter =      new VolumeUnit(LengthUnit.Millimeter);
        public static readonly VolumeUnit CubicYard =            new VolumeUnit(LengthUnit.Yard);
        public static readonly VolumeUnit CubicInch =            new VolumeUnit(LengthUnit.Inch);
        public static readonly VolumeUnit CubicHectometer =      new VolumeUnit(LengthUnit.Hectometer);
        public static readonly VolumeUnit CubicFoot =            new VolumeUnit(LengthUnit.Foot);
        public static readonly VolumeUnit HectocubicFoot =       new VolumeUnit(PreFix.hecto, CubicFoot);
        public static readonly VolumeUnit KilocubicFoot =        new VolumeUnit(PreFix.kilo, CubicFoot);
        public static readonly VolumeUnit MegacubicFoot =        new VolumeUnit(PreFix.mega, CubicFoot);
        public static readonly VolumeUnit CubicDecimeter =       new VolumeUnit(LengthUnit.Decimeter);
        public static readonly VolumeUnit CubicCentimeter =      new VolumeUnit(LengthUnit.Centimeter);
        public static readonly VolumeUnit Liter =                new VolumeUnit(LengthUnit.Decimeter, "l");
        public static readonly VolumeUnit Nanoliter =            new VolumeUnit(PreFix.nano, Liter);
        public static readonly VolumeUnit Microliter =           new VolumeUnit(PreFix.micro, Liter);
        public static readonly VolumeUnit Milliliter =           new VolumeUnit(PreFix.milli, Liter);
        public static readonly VolumeUnit Deciliter =            new VolumeUnit(PreFix.deci, Liter);
        public static readonly VolumeUnit Centiliter =           new VolumeUnit(PreFix.centi, Liter);
        public static readonly VolumeUnit Hectoliter =           new VolumeUnit(PreFix.hecto, Liter);
        public static readonly VolumeUnit Kiloliter =            new VolumeUnit(PreFix.kilo, Liter);
        public static readonly VolumeUnit Megaliter =            new VolumeUnit(PreFix.mega, Liter);
        public static readonly VolumeUnit Picoliter =            new VolumeUnit(PreFix.pico, Liter);
        public static readonly VolumeUnit AcreFoot =             new VolumeUnit(AreaUnit.Acre, LengthUnit.Foot);
        public static readonly VolumeUnit BoardFoot =            new VolumeUnit(AreaUnit.SquareFoot, LengthUnit.Inch, "bf");
        public static readonly VolumeUnit AuTablespoon =         new VolumeUnit(LengthUnit.Meter, "", 2e-5m);
        public static readonly VolumeUnit ImperialBeerBarrel =   new VolumeUnit(LengthUnit.Meter, "bl (imp.)", 0.16365924m);
        public static readonly VolumeUnit MetricTeaspoon =       new VolumeUnit(LengthUnit.Meter, "tsp", 0.5e-5m);
        public static readonly VolumeUnit MetricCup =            new VolumeUnit(LengthUnit.Meter, "", 0.00025m);
        public static readonly VolumeUnit ImperialGallon =       new VolumeUnit(LengthUnit.Meter, "gal (imp.)", 0.00454609000000181429905810072407m);
        public static readonly VolumeUnit KiloimperialGallon =   new VolumeUnit(PreFix.kilo, ImperialGallon);
        public static readonly VolumeUnit MegaimperialGallon =   new VolumeUnit(PreFix.mega, ImperialGallon);
        public static readonly VolumeUnit ImperialOunce =        new VolumeUnit(LengthUnit.Meter, "oz (imp.)", 2.8413062499962901241875439064617e-5m);
        public static readonly VolumeUnit ImperialPint =         new VolumeUnit(LengthUnit.Meter, "pt (imp.)", 5.6826125e-4m);
        public static readonly VolumeUnit UsCustomaryCup =       new VolumeUnit(LengthUnit.Meter, "", 0.0002365882365m);
        public static readonly VolumeUnit UsBeerBarrel =         new VolumeUnit(LengthUnit.Meter, "bl (U.S.)", 0.1173477658m);
        public static readonly VolumeUnit UkTablespoon =         new VolumeUnit(LengthUnit.Meter, "", 1.5e-5m);
        public static readonly VolumeUnit UsOunce =              new VolumeUnit(LengthUnit.Meter, "oz (U.S.)", 2.957352956253760505068307980135e-5m);
        public static readonly VolumeUnit UsGallon =             new VolumeUnit(UsOunce, "gal (U.S.)", 128m);
        public static readonly VolumeUnit KilousGallon =         new VolumeUnit(PreFix.kilo, UsGallon);
        public static readonly VolumeUnit MegausGallon =         new VolumeUnit(PreFix.mega, UsGallon);
        public static readonly VolumeUnit DecausGallon =         new VolumeUnit(PreFix.deka, UsGallon);
        public static readonly VolumeUnit DeciusGallon =         new VolumeUnit(PreFix.deci, UsGallon);
        public static readonly VolumeUnit HectousGallon =        new VolumeUnit(PreFix.hecto, UsGallon);
        public static readonly VolumeUnit OilBarrel =            new VolumeUnit(UsGallon, "bbl", 42);
        public static readonly VolumeUnit UsLegalCup =           new VolumeUnit(LengthUnit.Meter, "", 0.00024m);
        public static readonly VolumeUnit UsPint =               new VolumeUnit(UsOunce, "pt (U.S.)", 16);
        public static readonly VolumeUnit UsQuart =              new VolumeUnit(UsOunce, "qt (U.S.)", 32);
        public static readonly VolumeUnit UsTablespoon =         new VolumeUnit(UsOunce, "", 1/2m);
        public static readonly VolumeUnit UsTeaspoon =           new VolumeUnit(UsOunce, "", 1/6m);
        //public static VolumeUnit UsLegalCup =         new VolumeUnit(UsOunce, "", 8m);






        public VolumeUnit(LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Length.Pow(3);
            SetCombined(correction);
            SetNewSymbol(NewSymbol);         

        }

        public VolumeUnit(AreaUnit Area, LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Area * Length;
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{Area}-{Length}");
        }

        public VolumeUnit(PreFix SI, VolumeUnit unit)
        {
            Unit = unit.Unit.Copy();
            SetCombined(SI);
            SetNewSymbol(SI);
        }

        public VolumeUnit(VolumeUnit unit, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = unit.Unit.Copy();
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

    }

}