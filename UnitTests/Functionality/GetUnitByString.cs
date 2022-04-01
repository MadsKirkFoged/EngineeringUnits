using EngineeringUnits;
using EngineeringUnits.Units;
using Microsoft.Data.Edm.Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace UnitTests
{
    [TestClass]
    public class GetUnitByString
    {
        [TestMethod]
        public void GetUnitByString01()
        {
            LengthUnit unitasstring = UnitTypebase.GetUnitByString<LengthUnit>("Kilometer");

            Assert.AreEqual(unitasstring.ToString(), "km");
        }

       

        [TestMethod]
        public void EqualUnitEquaHash()

        {  
            var unitList = new List<string>() { "AmountOfSubstance", "Duration", "ElectricCurrent", "Length", "LuminousIntensity", "Mass", "Acceleration", "Angle", "ApparentPower", "AreaDensity", "AreaMomentOfInertia", "Area", "BitRate", "BrakeSpecificFuelConsumption", "Capacitance", "CoefficientOfThermalExpansion", "Density", "DynamicViscosity", "ElectricChargeDensity", "ElectricCharge", "ElectricConductivity", "ElectricCurrentDensity", "ElectricCurrentGradient", "ElectricField", "ElectricInductance", "ElectricPotentialChangeRate", "ElectricPotential", "MolarMass", "ElectricResistance", "ElectricResistivity", "ElectricSurfaceChargeDensity", "Energy", "Entropy", "ForceChangeRate", "ForcePerLength", "Force", "Frequency", "FuelEfficiency", "HeatFlux", "HeatTransferCoefficient", "Illuminance", "Information", "Irradiance", "Irradiation", "KinematicViscosity", "LapseRate", "LinearDensity", "LinearPowerDensity", "LuminousFlux", "MagneticField", "MagneticFlux", "Magnetization", "MassFlow", "MassFlux", "MassMomentOfInertia", "MolarEnergy", "MolarEntropy", "Molarity", "Permeability", "Permittivity", "PowerDensity", "Power", "PressureChangeRate", "Pressure", "Ratio", "ReactiveEnergy", "ReactivePower", "RotationalSpeed", "SpecificEnergy", "SpecificEntropy", "SpecificWeight", "Speed", "TemperatureChangeRate", "ThermalConductivity", "ThermalResistance", "TorquePerLength", "Torque", "VolumeFlow", "VolumePerLength", "Volume", "WarpingMomentOfInertia", "SpecificThermalResistance" };
            bool isUnique = true;
            int counter = 0;
            List<(UnitSystem, int)> List = new();


            foreach (var item in unitList)
            {
                var t = Type.GetType("EngineeringUnits.Units." + item + "Unit, EngineeringUnits");

                foreach (var i in t.GetFields())
                {

                    (UnitSystem, int) test;
                    test.Item1 = ((UnitTypebase)i.GetValue(i)).Unit;
                    test.Item2 = ((UnitTypebase)i.GetValue(i)).Unit.GetHashCode();

                    List.Add(test);

                }

            }
            var duplicates = List.OrderBy(x => x.Item2)
                .GroupBy(x => x.Item2)
              .Where(g => g.Count() > 1)
              //.Select(x => new { Element = x.Key, Counter = x.Count() })
              .ToList();
            foreach (var n in duplicates)
            {
                if (n.Count() <= 1) { break; }

                else
                {
                    for (int i = 0; i < n.Count() - 1; i++)
                    {
                        var first = n.ElementAt(i).Item1;
                        var second = n.ElementAt(i + 1).Item1;
                        bool f = UnitSystem.EqualWithoutHash(first, second);
                        if (f == false)
                        {
                            counter++;
                           
                        }

                    }

                }
            }
            //Assert.IsTrue(duplicates.Count()==0);

            Assert.IsTrue(counter == 0);


        }

    }
}
