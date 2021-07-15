using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;

namespace EngineeringUnits.Units
{



    public class MassFlowUnit : Enumeration
    {

        public static readonly MassFlowUnit CentigramPerDay =    new MassFlowUnit(MassUnit.Centigram, DurationUnit.Day);
        public static readonly MassFlowUnit CentigramPerSecond = new MassFlowUnit(MassUnit.Centigram, DurationUnit.Second);
        public static readonly MassFlowUnit DecagramPerDay =     new MassFlowUnit(MassUnit.Decagram, DurationUnit.Day);
        public static readonly MassFlowUnit DecagramPerSecond =  new MassFlowUnit(MassUnit.Decagram, DurationUnit.Second);
        public static readonly MassFlowUnit DecigramPerDay =     new MassFlowUnit(MassUnit.Decigram, DurationUnit.Day);
        public static readonly MassFlowUnit DecigramPerSecond =  new MassFlowUnit(MassUnit.Decigram, DurationUnit.Second);
        public static readonly MassFlowUnit GramPerDay =         new MassFlowUnit(MassUnit.Gram, DurationUnit.Day);
        public static readonly MassFlowUnit GramPerHour =        new MassFlowUnit(MassUnit.Gram, DurationUnit.Hour);
        public static readonly MassFlowUnit GramPerSecond =      new MassFlowUnit(MassUnit.Gram, DurationUnit.Second);
        public static readonly MassFlowUnit MegagramPerDay =     new MassFlowUnit(PreFix.mega, GramPerDay);
        public static readonly MassFlowUnit MicrogramPerSecond = new MassFlowUnit(PreFix.micro, GramPerSecond);
        public static readonly MassFlowUnit MicrogramPerDay =    new MassFlowUnit(PreFix.micro, GramPerDay);
        public static readonly MassFlowUnit MilligramPerSecond = new MassFlowUnit(PreFix.milli, GramPerSecond);
        public static readonly MassFlowUnit MilligramPerDay =    new MassFlowUnit(PreFix.milli, GramPerDay);
        public static readonly MassFlowUnit NanogramPerSecond =  new MassFlowUnit(PreFix.nano, GramPerSecond);
        public static readonly MassFlowUnit NanogramPerDay =     new MassFlowUnit(PreFix.nano, GramPerDay);
        public static readonly MassFlowUnit HectogramPerDay =    new MassFlowUnit(MassUnit.Hectogram, DurationUnit.Day);
        public static readonly MassFlowUnit HectogramPerSecond = new MassFlowUnit(MassUnit.Hectogram, DurationUnit.Second);
        public static readonly MassFlowUnit SI =                 new MassFlowUnit(MassUnit.SI, DurationUnit.SI);
        public static readonly MassFlowUnit KilogramPerSecond =  new MassFlowUnit(MassUnit.Kilogram, DurationUnit.Second);
        public static readonly MassFlowUnit KilogramPerMinute =  new MassFlowUnit(MassUnit.Kilogram, DurationUnit.Minute);
        public static readonly MassFlowUnit KilogramPerHour =    new MassFlowUnit(MassUnit.Kilogram, DurationUnit.Hour);
        public static readonly MassFlowUnit KilogramPerDay =     new MassFlowUnit(MassUnit.Kilogram, DurationUnit.Day);
        public static readonly MassFlowUnit PoundPerSecond =     new MassFlowUnit(MassUnit.Pound, DurationUnit.SI);
        public static readonly MassFlowUnit PoundPerMinute =     new MassFlowUnit(MassUnit.Pound, DurationUnit.Minute);
        public static readonly MassFlowUnit PoundPerHour =       new MassFlowUnit(MassUnit.Pound, DurationUnit.Hour);
        public static readonly MassFlowUnit PoundPerDay =        new MassFlowUnit(MassUnit.Pound, DurationUnit.Day);
        public static readonly MassFlowUnit MegapoundPerDay =    new MassFlowUnit(PreFix.mega, PoundPerDay);
        public static readonly MassFlowUnit MegapoundPerHour =   new MassFlowUnit(PreFix.mega, PoundPerHour);
        public static readonly MassFlowUnit MegapoundPerMinute = new MassFlowUnit(PreFix.mega, PoundPerMinute);
        public static readonly MassFlowUnit MegapoundPerSecond = new MassFlowUnit(PreFix.mega, PoundPerSecond);
        public static readonly MassFlowUnit ShortTonPerHour =    new MassFlowUnit(MassUnit.ShortTon, DurationUnit.Hour, "short tn/h");
        public static readonly MassFlowUnit TonnePerDay =        new MassFlowUnit(MassUnit.Tonne, DurationUnit.Day);
        public static readonly MassFlowUnit TonnePerHour =       new MassFlowUnit(MassUnit.Tonne, DurationUnit.Hour);




        public MassFlowUnit(MassUnit mass, DurationUnit duration, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = mass / duration;
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{mass}/{duration}");
        }

        public MassFlowUnit(PreFix SI, MassFlowUnit unit)
        {
            Unit = unit.Unit.Copy();
            SetCombined(SI);
            SetNewSymbol(SI);
        }


    }



}