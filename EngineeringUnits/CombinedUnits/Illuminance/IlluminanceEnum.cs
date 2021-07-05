using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{


    public class IlluminanceUnit : Enumeration
    {

        public static readonly IlluminanceUnit SI = new IlluminanceUnit(LuminousIntensityUnit.SI, AreaUnit.SquareMeter);
        public static readonly IlluminanceUnit Lux = new IlluminanceUnit(LuminousIntensityUnit.SI, AreaUnit.SquareMeter, "lx");


        public static readonly IlluminanceUnit Kilolux = new IlluminanceUnit(PreFix.kilo, Lux);
        public static readonly IlluminanceUnit Megalux = new IlluminanceUnit(PreFix.mega, Lux);
        public static readonly IlluminanceUnit Millilux = new IlluminanceUnit(PreFix.milli, Lux);


        public IlluminanceUnit(LuminousIntensityUnit luminousIntensity, AreaUnit area, string NewSymbol = "Empty", decimal correction = 1)
        {
            //lm/m2
            Unit = luminousIntensity.Unit / area.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

     
        public IlluminanceUnit(PreFix SI, IlluminanceUnit unit)
        {
            Unit = unit.Unit.Copy();
            SetCombined(SI);
            SetNewSymbol(SI);
        }

       

    }




}