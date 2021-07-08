using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{


    //public class AmplitudeRatioUnit : Enumeration
    //{

    //    public static readonly AmplitudeRatioUnit SI = new AmplitudeRatioUnit(LengthUnit.Meter);
    //    public static readonly AmplitudeRatioUnit CubicMeter = new AmplitudeRatioUnit(LengthUnit.Meter);
    //    public static readonly AmplitudeRatioUnit HectocubicMeter = new AmplitudeRatioUnit(PreFix.hecto, CubicMeter);
    //    public static readonly AmplitudeRatioUnit KilocubicMeter = new AmplitudeRatioUnit(PreFix.kilo, CubicMeter);



    //    public AmplitudeRatioUnit(LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
    //    {
    //        Unit = Length.Unit * Length.Unit * Length.Unit;
    //        SetCombined(correction);
    //        SetNewSymbol(NewSymbol);
    //    }

    //    public AmplitudeRatioUnit(AreaUnit Area, LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
    //    {
    //        Unit = Area.Unit * Length.Unit;
    //        SetCombined(correction);
    //        SetNewSymbol(NewSymbol, $"{Area}-{Length}");
    //    }

    //    public AmplitudeRatioUnit(PreFix SI, AmplitudeRatioUnit unit)
    //    {
    //        Unit = unit.Unit.Copy();
    //        SetCombined(SI);
    //        SetNewSymbol(SI);
    //    }

    //    public AmplitudeRatioUnit(AmplitudeRatioUnit unit, string NewSymbol = "Empty", decimal correction = 1)
    //    {
    //        Unit = unit.Unit.Copy();
    //        SetCombined(correction);
    //        SetNewSymbol(NewSymbol);
    //    }

    //}




}