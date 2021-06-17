using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{


    public class testUnit : Enumeration
    {

        public static testUnit SI = new testUnit(LengthUnit.Meter);
        public static testUnit CubicMeter = new testUnit(LengthUnit.Meter);
        public static testUnit HectocubicMeter = new testUnit(PreFix.hecto, CubicMeter);
        public static testUnit KilocubicMeter = new testUnit(PreFix.kilo, CubicMeter);


        public static testUnit CubicKilometer = new testUnit(LengthUnit.Kilometer);
        public static testUnit CubicMicrometer = new testUnit(LengthUnit.Micrometer);
        public static testUnit CubicMile = new testUnit(LengthUnit.Mile);
        public static testUnit CubicMillimeter = new testUnit(LengthUnit.Millimeter);
        public static testUnit CubicYard = new testUnit(LengthUnit.Yard);
        public static testUnit CubicInch = new testUnit(LengthUnit.Inch);
        public static testUnit CubicHectometer = new testUnit(LengthUnit.Hectometer);
        public static testUnit CubicFoot = new testUnit(LengthUnit.Foot);
        public static testUnit HectocubicFoot = new testUnit(PreFix.hecto, CubicFoot);
        public static testUnit KilocubicFoot = new testUnit(PreFix.kilo, CubicFoot);
        public static testUnit MegacubicFoot = new testUnit(PreFix.mega, CubicFoot);

        public static testUnit CubicDecimeter = new testUnit(LengthUnit.Decimeter);
        public static testUnit CubicCentimeter = new testUnit(LengthUnit.Centimeter);

        public static testUnit Liter = new testUnit(LengthUnit.Decimeter, "l");
        public static testUnit Microliter = new testUnit(PreFix.micro, Liter);
        public static testUnit Milliliter = new testUnit(PreFix.milli, Liter);
        public static testUnit Deciliter = new testUnit(PreFix.deci, Liter);
        public static testUnit Centiliter = new testUnit(PreFix.centi, Liter);
        public static testUnit Hectoliter = new testUnit(PreFix.hecto, Liter);
        public static testUnit Kiloliter = new testUnit(PreFix.kilo, Liter);
        public static testUnit Megaliter = new testUnit(PreFix.mega, Liter);

        public static testUnit AcreFoot = new testUnit(AreaUnit.Acre, LengthUnit.Foot);
        public static testUnit BoardFoot = new testUnit(AreaUnit.SquareFoot, LengthUnit.Inch, "bf");

        public static testUnit AuTablespoon = new testUnit(LengthUnit.Meter, "", 2e-5m);
        public static testUnit ImperialBeerBarrel = new testUnit(LengthUnit.Meter, "bl (imp.)", 0.16365924m);

        public static testUnit MetricTeaspoon = new testUnit(LengthUnit.Meter, "tsp", 0.5e-5m);
        public static testUnit MetricCup = new testUnit(LengthUnit.Meter, "", 0.00025m);


        public static testUnit ImperialGallon = new testUnit(LengthUnit.Meter, "gal (imp.)", 0.00454609000000181429905810072407m);
        public static testUnit KiloimperialGallon = new testUnit(PreFix.kilo, ImperialGallon);
        public static testUnit MegaimperialGallon = new testUnit(PreFix.mega, ImperialGallon);

        public static testUnit ImperialOunce = new testUnit(LengthUnit.Meter, "oz (imp.)", 2.8413062499962901241875439064617e-5m);
        public static testUnit ImperialPint = new testUnit(LengthUnit.Meter, "pt (imp.)", 5.6826125e-4m);


        public static testUnit UsCustomaryCup = new testUnit(LengthUnit.Meter, "", 0.0002365882365m);
        public static testUnit UsBeerBarrel = new testUnit(LengthUnit.Meter, "bl (U.S.)", 0.1173477658m);
        public static testUnit UkTablespoon = new testUnit(LengthUnit.Meter, "", 1.5e-5m);

        public static testUnit UsOunce = new testUnit(LengthUnit.Meter, "oz (U.S.)", 2.957352956253760505068307980135e-5m);
        public static testUnit UsGallon = new testUnit(UsOunce, "gal (U.S.)", 128m);
        public static testUnit KilousGallon = new testUnit(PreFix.kilo, UsGallon);
        public static testUnit MegausGallon = new testUnit(PreFix.mega, UsGallon);
        public static testUnit DecausGallon = new testUnit(PreFix.deka, UsGallon);
        public static testUnit DeciusGallon = new testUnit(PreFix.deci, UsGallon);
        public static testUnit HectousGallon = new testUnit(PreFix.hecto, UsGallon);

        public static testUnit OilBarrel = new testUnit(UsGallon, "bbl", 42);
        public static testUnit UsLegalCup = new testUnit(LengthUnit.Meter, "", 0.00024m);
        public static testUnit UsPint = new testUnit(UsOunce, "pt (U.S.)", 16);
        public static testUnit UsQuart = new testUnit(UsOunce, "qt (U.S.)", 32);
        public static testUnit UsTablespoon = new testUnit(UsOunce, "", 1 / 2m);
        public static testUnit UsTeaspoon = new testUnit(UsOunce, "", 1 / 6m);






        public testUnit(LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {

            Name = "test";
            Unit = Length.Unit * Length.Unit * Length.Unit;

            SetCombined(correction);
            SetNewSymbol(NewSymbol);

        }

        public testUnit(AreaUnit Area, LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {

            Name = "test";
            Unit = Area.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{Area}-{Length}");
        }

        public testUnit(PreFix SI, testUnit unit)
        {
            Name = "test";
            Unit = unit.Unit.Copy();

            SetCombined(SI);
            SetNewSymbol(SI);
        }

        public testUnit(testUnit unit, string NewSymbol = "Empty", decimal correction = 1)
        {

            Name = "test";
            Unit = unit.Unit.Copy();

            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }


        public static IEnumerable<testUnit> List()
        {
            return new[] { SI };
        }





    }




}