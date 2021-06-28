using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{


    public class VolumeUnit : Enumeration
    {

        public static VolumeUnit SI =                   new VolumeUnit(LengthUnit.Meter);
        public static VolumeUnit CubicMeter =           new VolumeUnit(LengthUnit.Meter);
        public static VolumeUnit HectocubicMeter =      new VolumeUnit(PreFix.hecto, CubicMeter);
        public static VolumeUnit KilocubicMeter =       new VolumeUnit(PreFix.kilo, CubicMeter);


        public static VolumeUnit CubicKilometer =       new VolumeUnit(LengthUnit.Kilometer);
        public static VolumeUnit CubicMicrometer =      new VolumeUnit(LengthUnit.Micrometer);
        public static VolumeUnit CubicMile =            new VolumeUnit(LengthUnit.Mile);
        public static VolumeUnit CubicMillimeter =      new VolumeUnit(LengthUnit.Millimeter);
        public static VolumeUnit CubicYard =            new VolumeUnit(LengthUnit.Yard);
        public static VolumeUnit CubicInch =            new VolumeUnit(LengthUnit.Inch);
        public static VolumeUnit CubicHectometer =      new VolumeUnit(LengthUnit.Hectometer);
        public static VolumeUnit CubicFoot =            new VolumeUnit(LengthUnit.Foot);
        public static VolumeUnit HectocubicFoot =       new VolumeUnit(PreFix.hecto, CubicFoot);
        public static VolumeUnit KilocubicFoot =        new VolumeUnit(PreFix.kilo, CubicFoot);
        public static VolumeUnit MegacubicFoot =        new VolumeUnit(PreFix.mega, CubicFoot);

        public static VolumeUnit CubicDecimeter =       new VolumeUnit(LengthUnit.Decimeter);
        public static VolumeUnit CubicCentimeter =      new VolumeUnit(LengthUnit.Centimeter);

        public static VolumeUnit Liter =                new VolumeUnit(LengthUnit.Decimeter, "l");
        public static VolumeUnit Nanoliter =            new VolumeUnit(PreFix.nano, Liter);
        public static VolumeUnit Microliter =           new VolumeUnit(PreFix.micro, Liter);
        public static VolumeUnit Milliliter =           new VolumeUnit(PreFix.milli, Liter);
        public static VolumeUnit Deciliter =            new VolumeUnit(PreFix.deci, Liter);
        public static VolumeUnit Centiliter =           new VolumeUnit(PreFix.centi, Liter);
        public static VolumeUnit Hectoliter =           new VolumeUnit(PreFix.hecto, Liter);
        public static VolumeUnit Kiloliter =            new VolumeUnit(PreFix.kilo, Liter);
        public static VolumeUnit Megaliter =            new VolumeUnit(PreFix.mega, Liter);

        public static VolumeUnit AcreFoot =             new VolumeUnit(AreaUnit.Acre, LengthUnit.Foot);
        public static VolumeUnit BoardFoot =            new VolumeUnit(AreaUnit.SquareFoot, LengthUnit.Inch, "bf");

        public static VolumeUnit AuTablespoon =         new VolumeUnit(LengthUnit.Meter, "", 2e-5m);
        public static VolumeUnit ImperialBeerBarrel =   new VolumeUnit(LengthUnit.Meter, "bl (imp.)", 0.16365924m);

        public static VolumeUnit MetricTeaspoon =       new VolumeUnit(LengthUnit.Meter, "tsp", 0.5e-5m);
        public static VolumeUnit MetricCup =            new VolumeUnit(LengthUnit.Meter, "", 0.00025m);


        public static VolumeUnit ImperialGallon =       new VolumeUnit(LengthUnit.Meter, "gal (imp.)", 0.00454609000000181429905810072407m);
        public static VolumeUnit KiloimperialGallon =   new VolumeUnit(PreFix.kilo, ImperialGallon);
        public static VolumeUnit MegaimperialGallon =   new VolumeUnit(PreFix.mega, ImperialGallon);

        public static VolumeUnit ImperialOunce =        new VolumeUnit(LengthUnit.Meter, "oz (imp.)", 2.8413062499962901241875439064617e-5m);
        public static VolumeUnit ImperialPint =         new VolumeUnit(LengthUnit.Meter, "pt (imp.)", 5.6826125e-4m);


        public static VolumeUnit UsCustomaryCup =       new VolumeUnit(LengthUnit.Meter, "", 0.0002365882365m);
        public static VolumeUnit UsBeerBarrel =         new VolumeUnit(LengthUnit.Meter, "bl (U.S.)", 0.1173477658m);
        public static VolumeUnit UkTablespoon =         new VolumeUnit(LengthUnit.Meter, "", 1.5e-5m);

        public static VolumeUnit UsOunce =              new VolumeUnit(LengthUnit.Meter, "oz (U.S.)", 2.957352956253760505068307980135e-5m);
        public static VolumeUnit UsGallon =             new VolumeUnit(UsOunce, "gal (U.S.)", 128m);
        public static VolumeUnit KilousGallon =         new VolumeUnit(PreFix.kilo, UsGallon);
        public static VolumeUnit MegausGallon =         new VolumeUnit(PreFix.mega, UsGallon);
        public static VolumeUnit DecausGallon =         new VolumeUnit(PreFix.deka, UsGallon);
        public static VolumeUnit DeciusGallon =         new VolumeUnit(PreFix.deci, UsGallon);
        public static VolumeUnit HectousGallon =        new VolumeUnit(PreFix.hecto, UsGallon);

        public static VolumeUnit OilBarrel =            new VolumeUnit(UsGallon, "bbl", 42);
        //public static VolumeUnit UsLegalCup =         new VolumeUnit(UsOunce, "", 8m);
        public static VolumeUnit UsLegalCup =           new VolumeUnit(LengthUnit.Meter, "", 0.00024m);
        public static VolumeUnit UsPint =               new VolumeUnit(UsOunce, "pt (U.S.)", 16);
        public static VolumeUnit UsQuart =              new VolumeUnit(UsOunce, "qt (U.S.)", 32);
        public static VolumeUnit UsTablespoon =         new VolumeUnit(UsOunce, "", 1/2m);
        public static VolumeUnit UsTeaspoon =           new VolumeUnit(UsOunce, "", 1/6m);






        public VolumeUnit(LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Length.Unit * Length.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol);         

        }

        public VolumeUnit(AreaUnit Area, LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Area.Unit * Length.Unit;
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