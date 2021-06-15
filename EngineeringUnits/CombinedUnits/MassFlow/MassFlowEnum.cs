using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;

namespace EngineeringUnits
{



    public class MassFlowUnit : Enumeration
    {

        public static MassFlowUnit CentigramPerDay = new MassFlowUnit(MassUnit.Centigram, DurationUnit.Day);
        public static MassFlowUnit CentigramPerSecond = new MassFlowUnit(MassUnit.Centigram, DurationUnit.Second);
        public static MassFlowUnit DecagramPerDay = new MassFlowUnit(MassUnit.Decagram, DurationUnit.Day);
        public static MassFlowUnit DecagramPerSecond = new MassFlowUnit(MassUnit.Decagram, DurationUnit.Second);
        public static MassFlowUnit DecigramPerDay = new MassFlowUnit(MassUnit.Decigram, DurationUnit.Day);
        public static MassFlowUnit DecigramPerSecond = new MassFlowUnit(MassUnit.Decigram, DurationUnit.Second);
        public static MassFlowUnit GramPerDay = new MassFlowUnit(MassUnit.Gram, DurationUnit.Day);
        public static MassFlowUnit GramPerHour = new MassFlowUnit(MassUnit.Gram, DurationUnit.Hour);
        public static MassFlowUnit GramPerSecond = new MassFlowUnit(MassUnit.Gram, DurationUnit.Second);
        public static MassFlowUnit MegagramPerDay = new MassFlowUnit(PreFix.mega, GramPerDay);

        public static MassFlowUnit MicrogramPerSecond = new MassFlowUnit(PreFix.micro, GramPerSecond);
        public static MassFlowUnit MicrogramPerDay = new MassFlowUnit(PreFix.micro, GramPerDay);

        public static MassFlowUnit MilligramPerSecond = new MassFlowUnit(PreFix.milli, GramPerSecond);
        public static MassFlowUnit MilligramPerDay = new MassFlowUnit(PreFix.milli, GramPerDay);

        public static MassFlowUnit NanogramPerSecond = new MassFlowUnit(PreFix.nano, GramPerSecond);
        public static MassFlowUnit NanogramPerDay = new MassFlowUnit(PreFix.nano, GramPerDay);

        public static MassFlowUnit HectogramPerDay = new MassFlowUnit(MassUnit.Hectogram, DurationUnit.Day);
        public static MassFlowUnit HectogramPerSecond = new MassFlowUnit(MassUnit.Hectogram, DurationUnit.Second);


        public static MassFlowUnit SI = new MassFlowUnit(MassUnit.SI, DurationUnit.SI);
        public static MassFlowUnit KilogramPerSecond = new MassFlowUnit(MassUnit.Kilogram, DurationUnit.Second);
        public static MassFlowUnit KilogramPerMinute = new MassFlowUnit(MassUnit.Kilogram, DurationUnit.Minute);
        public static MassFlowUnit KilogramPerHour = new MassFlowUnit(MassUnit.Kilogram, DurationUnit.Hour);
        public static MassFlowUnit KilogramPerDay = new MassFlowUnit(MassUnit.Kilogram, DurationUnit.Day);

        public static MassFlowUnit PoundPerSecond = new MassFlowUnit(MassUnit.Pound, DurationUnit.SI);
        public static MassFlowUnit PoundPerMinute = new MassFlowUnit(MassUnit.Pound, DurationUnit.Minute);
        public static MassFlowUnit PoundPerHour = new MassFlowUnit(MassUnit.Pound, DurationUnit.Hour);
        public static MassFlowUnit PoundPerDay = new MassFlowUnit(MassUnit.Pound, DurationUnit.Day);

        public static MassFlowUnit MegapoundPerDay = new MassFlowUnit(PreFix.mega, PoundPerDay);
        public static MassFlowUnit MegapoundPerHour = new MassFlowUnit(PreFix.mega, PoundPerHour);
        public static MassFlowUnit MegapoundPerMinute = new MassFlowUnit(PreFix.mega, PoundPerMinute);
        public static MassFlowUnit MegapoundPerSecond = new MassFlowUnit(PreFix.mega, PoundPerSecond);

        public static MassFlowUnit ShortTonPerHour = new MassFlowUnit(MassUnit.ShortTon, DurationUnit.Hour);
        public static MassFlowUnit TonnePerDay = new MassFlowUnit(MassUnit.Tonne, DurationUnit.Day);
        public static MassFlowUnit TonnePerHour = new MassFlowUnit(MassUnit.Tonne, DurationUnit.Hour);




        public MassFlowUnit(MassUnit mass, DurationUnit duration, string NewSymbol = "", decimal correction = 1)
        {

            Name = "MassFlow";

            //kg*s-1
            Unit = mass.Unit / duration.Unit;

            if (NewSymbol != "")            
                Unit.Symbol = NewSymbol;            
            else
                Unit.Symbol = $"{mass}/{duration}";


            if (correction != 1)
            {
                Unit.Combined = new CombinedUnit("", correction, 1);
            }


            //Unit.EkstraCorrection = correction;
        }

        public MassFlowUnit(PreFix SI, MassFlowUnit unit)
        {
            Unit = unit.Unit.Copy();


            if (Unit.Combined is null)
                Unit.Combined = new CombinedUnit("", 1, PrefixSISize(SI));
            else
                Unit.Combined.GlobalC *= PrefixSISize(SI);




            Unit.Symbol = PrefixSISymbol(SI) + Unit.Symbol;
        }


        public static IEnumerable<MassFlowUnit> List()
        {
            return new[] { CentigramPerDay, CentigramPerSecond, DecagramPerDay, DecagramPerSecond, DecigramPerDay, DecigramPerSecond, GramPerDay, GramPerHour, GramPerSecond, HectogramPerDay, HectogramPerSecond, KilogramPerDay, KilogramPerHour, KilogramPerMinute, KilogramPerSecond, MegagramPerDay, MegapoundPerDay, MegapoundPerHour, MegapoundPerMinute, MegapoundPerSecond, MicrogramPerDay, MicrogramPerSecond, MilligramPerDay, MilligramPerSecond, NanogramPerDay, NanogramPerSecond, PoundPerDay, PoundPerHour, PoundPerMinute, PoundPerSecond, ShortTonPerHour, TonnePerDay, TonnePerHour, };
        }
        public override string ToString()
        {
            return $"{Unit.Symbol}";
        }
    }



}