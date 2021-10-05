using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits.Units
{


    public class IlluminanceUnit : Enumeration
    {

        public static readonly IlluminanceUnit SI = new(LuminousIntensityUnit.SI, AreaUnit.SI);
        public static readonly IlluminanceUnit Lux = new(LuminousIntensityUnit.SI, AreaUnit.SquareMeter, "lx");


        public static readonly IlluminanceUnit Kilolux = new(PreFix.kilo, Lux);
        public static readonly IlluminanceUnit Megalux = new(PreFix.mega, Lux);
        public static readonly IlluminanceUnit Millilux = new(PreFix.milli, Lux);


        public IlluminanceUnit(LuminousIntensityUnit luminousIntensity, AreaUnit area, string NewSymbol = "Empty", decimal correction = 1)
        {
            //lm/m2
            Unit = luminousIntensity / area;
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