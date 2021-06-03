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


        public static MassFlowUnit SI = new MassFlowUnit(MassUnit.SI, DurationUnit.SI, "");
        public static MassFlowUnit KilogramPerSecond = new MassFlowUnit(MassUnit.Kilogram, DurationUnit.Second, "");
        public static MassFlowUnit KilogramPerMinute = new MassFlowUnit(MassUnit.Kilogram, DurationUnit.Minute, "");
        public static MassFlowUnit KilogramPerHour = new MassFlowUnit(MassUnit.Kilogram, DurationUnit.Hour, "");
        public static MassFlowUnit PoundPerSecond = new MassFlowUnit(MassUnit.Pound, DurationUnit.SI, "");
        public static MassFlowUnit PoundPerMinute = new MassFlowUnit(MassUnit.Pound, DurationUnit.Minute, "");
        public static MassFlowUnit PoundPerHour = new MassFlowUnit(MassUnit.Pound, DurationUnit.Hour, "");

        public MassFlowUnit(MassUnit mass, DurationUnit duration, string NewSymbol = "", decimal correction = 1)
        {

            Name = "MassFlow";

            //kg*s-1
            Unit = mass.Unit / duration.Unit;

            if (NewSymbol != "")
            {
                Unit.Symbol = NewSymbol;
            }

            if (correction != 1)
            {
                Unit.Combined = new CombinedUnit("", correction, 1);
            }


            //Unit.EkstraCorrection = correction;
        }


        public static IEnumerable<MassFlowUnit> List()
        {
            return new[] { SI };
        }
        public override string ToString()
        {
            return $"{Unit.Symbol}";
        }
    }



}