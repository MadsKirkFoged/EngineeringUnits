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
        public static EnergyUnit Joule = new EnergyUnit(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, "J");
        public static EnergyUnit BritishThermalUnit = new EnergyUnit(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, "BTU", 1055.06m);
        public static EnergyUnit Calorie = new EnergyUnit(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, "cal", 4.184m);
        public static EnergyUnit ElectronVolt = new EnergyUnit(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, "eV", 0.0000000000000000001602176565m);
        public static EnergyUnit FootPound = new EnergyUnit(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, "", 1.3558m);
        public static EnergyUnit KilowattHour = new EnergyUnit(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, "kW⋅h", 3600000);
        public static EnergyUnit WattHour = new EnergyUnit(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, "W⋅h", 3600);


        //public EnergyUnit(MassUnit mass, LengthUnit Length, DurationUnit duration)
        //{
        //    Name = "Energy";

        //    //kg*m2*s-2
        //    Unit = (mass.Unit * Length.Unit * Length.Unit) / (duration.Unit * duration.Unit);
        //    Unit.Symbol = "J";

        //}

        public EnergyUnit(MassUnit mass, LengthUnit Length, DurationUnit duration, string NewSymbol = "", decimal correction = 1)
        {

            Name = "Energy";

            //kg*m2*s-2
            Unit = (mass.Unit * Length.Unit * Length.Unit) / (duration.Unit * duration.Unit);

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