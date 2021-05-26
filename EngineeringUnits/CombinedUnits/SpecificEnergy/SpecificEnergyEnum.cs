using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;

namespace EngineeringUnits
{



    public class SpecificEnergyUnit : Enumeration
    {




        //public static EnergyUnit SI = new EnergyUnit(PreFix.SI, BaseUnits.length);
        //public static SpecificEnergyUnit SI = JoulePerKilogram;
        public static SpecificEnergyUnit JoulePerKilogram = new SpecificEnergyUnit(EnergyUnit.Joule, MassUnit.SI);




        public SpecificEnergyUnit(EnergyUnit energy, MassUnit mass)
        {
            Name = "Energy";

            //  J/kg
            Unit = energy.Unit / mass.Unit;
            Unit.Symbol = energy.Unit.Symbol;

        }


        public static IEnumerable<SpecificEnergyUnit> List()
        {
            return new[] { JoulePerKilogram, };
        }

    }



}