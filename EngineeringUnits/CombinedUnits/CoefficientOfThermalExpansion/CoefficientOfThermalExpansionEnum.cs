﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{


    public class CoefficientOfThermalExpansionUnit : Enumeration
    {

        public static readonly CoefficientOfThermalExpansionUnit SI = new CoefficientOfThermalExpansionUnit(TemperatureUnit.Kelvin);
        public static readonly CoefficientOfThermalExpansionUnit InverseKelvin = new CoefficientOfThermalExpansionUnit(TemperatureUnit.Kelvin, "K⁻¹");
        public static readonly CoefficientOfThermalExpansionUnit InverseDegreeFahrenheit = new CoefficientOfThermalExpansionUnit(TemperatureUnit.DegreeFahrenheit);
        public static readonly CoefficientOfThermalExpansionUnit InverseDegreeCelsius = new CoefficientOfThermalExpansionUnit(TemperatureUnit.DegreeCelsius);



        public CoefficientOfThermalExpansionUnit(TemperatureUnit temperature, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = temperature.Unit / (temperature.Unit * temperature.Unit);
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }      

    }




}