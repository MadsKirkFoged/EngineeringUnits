using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{


    public class IrradianceUnit : Enumeration
    {

        public static readonly IrradianceUnit SI = new IrradianceUnit(PowerUnit.Watt, AreaUnit.SquareMeter);
        public static readonly IrradianceUnit WattPerSquareMeter = new IrradianceUnit(PowerUnit.Watt, AreaUnit.SquareMeter);
        public static readonly IrradianceUnit WattPerSquareCentimeter = new IrradianceUnit(PowerUnit.Watt, AreaUnit.SquareCentimeter);



        public static readonly IrradianceUnit KilowattPerSquareCentimeter = new IrradianceUnit(PreFix.kilo, WattPerSquareCentimeter);
        public static readonly IrradianceUnit MegawattPerSquareCentimeter = new IrradianceUnit(PreFix.mega, WattPerSquareCentimeter);
        public static readonly IrradianceUnit MicrowattPerSquareCentimeter = new IrradianceUnit(PreFix.micro, WattPerSquareCentimeter);
        public static readonly IrradianceUnit MilliwattPerSquareCentimeter = new IrradianceUnit(PreFix.milli, WattPerSquareCentimeter);
        public static readonly IrradianceUnit NanowattPerSquareCentimeter = new IrradianceUnit(PreFix.nano, WattPerSquareCentimeter);
        public static readonly IrradianceUnit PicowattPerSquareCentimeter = new IrradianceUnit(PreFix.pico, WattPerSquareCentimeter);


        public static readonly IrradianceUnit KilowattPerSquareMeter = new IrradianceUnit(PreFix.kilo, WattPerSquareMeter);
        public static readonly IrradianceUnit MegawattPerSquareMeter = new IrradianceUnit(PreFix.mega, WattPerSquareMeter);
        public static readonly IrradianceUnit MicrowattPerSquareMeter = new IrradianceUnit(PreFix.micro, WattPerSquareMeter);
        public static readonly IrradianceUnit MilliwattPerSquareMeter = new IrradianceUnit(PreFix.milli, WattPerSquareMeter);
        public static readonly IrradianceUnit NanowattPerSquareMeter = new IrradianceUnit(PreFix.nano, WattPerSquareMeter);
        public static readonly IrradianceUnit PicowattPerSquareMeter = new IrradianceUnit(PreFix.pico, WattPerSquareMeter);



        public IrradianceUnit(PowerUnit power, AreaUnit area, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = power / area;
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{power}/{area}");
        }       

        public IrradianceUnit(PreFix SI, IrradianceUnit unit)
        {
            Unit = unit.Unit.Copy();
            SetCombined(SI);
            SetNewSymbol(SI);
        }

     

    }




}