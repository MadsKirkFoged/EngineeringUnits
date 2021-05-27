using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;

namespace EngineeringUnits
{



    public class EnergyUnit : Enumeration
    {




        //public static EnergyUnit SI = new EnergyUnit(PreFix.SI, BaseUnits.length);
        public static EnergyUnit SI = Joule;
        public static EnergyUnit Joule = new EnergyUnit(MassUnit.SI, LengthUnit.SI, DurationUnit.SI);




        public EnergyUnit(MassUnit mass, LengthUnit Length, DurationUnit duration)
        {
            Name = "Energy";

            //kg*m2*s-2
            Unit = (mass.Unit * Length.Unit * Length.Unit) / (duration.Unit * duration.Unit);
            Unit.Symbol = "J";

        }


        public static IEnumerable<EnergyUnit> List()
        {
            return new[] { SI, Joule, };
        }
        public override string ToString()
        {
            return $"{Unit.Symbol}";
        }
    }



}