using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGen
{
    internal class UnitListGenerator
    {

        public static string UnitsInclude()
        {
            string PrintOut = $"";
          //  List<string> assembly = new List<string>() { "AmountOfSubstance", "Duration", "ElectricCurrent", "Length", "LuminousIntensity", "Mass","Temperature", "Acceleration", "Angle", "ApparentPower", "AreaDensity", "AreaMomentOfInertia", "Area", "BitRate", "BrakeSpecificFuelConsumption", "Capacitance", "CoefficientOfThermalExpansion", "Density", "DynamicViscosity", "ElectricChargeDensity", "ElectricCharge", "ElectricConductivity", "ElectricCurrentDensity", "ElectricCurrentGradient", "ElectricField", "ElectricInductance", "ElectricPotentialChangeRate", "ElectricPotential", "MolarMass", "ElectricResistance", "ElectricResistivity", "ElectricSurfaceChargeDensity", "Energy", "Entropy", "ForceChangeRate", "ForcePerLength", "Force", "Frequency", "FuelEfficiency", "HeatFlux", "HeatTransferCoefficient", "Illuminance", "Information", "Irradiance", "Irradiation", "KinematicViscosity", "LapseRate", "LinearDensity", "LinearPowerDensity", "LuminousFlux", "MagneticField", "MagneticFlux", "Magnetization", "MassFlow", "MassFlux", "MassMomentOfInertia", "MolarEnergy", "MolarEntropy", "Molarity", "Permeability", "Permittivity", "PowerDensity", "Power", "PressureChangeRate", "Pressure", "Ratio", "ReactiveEnergy", "ReactivePower", "RotationalSpeed", "SpecificEnergy", "SpecificEntropy", "SpecificWeight", "Speed", "TemperatureChangeRate", "ThermalConductivity", "ThermalResistance", "TorquePerLength", "Torque", "VolumeFlow", "VolumePerLength", "Volume", "WarpingMomentOfInertia", "SpecificThermalResistance" };

            foreach (string assemblyName in ListOfUnitsForDifferentGenerators.GetListOFAllUnits())
            {
                var t = Type.GetType("EngineeringUnits.Units." + assemblyName + "Unit, EngineeringUnits");

                if (t is null)
                    continue;
                
                PrintOut += "\n" + assemblyName + ":";
                foreach (var item in t.GetFields())
                {

                    PrintOut += $"[{item.GetValue(item)}], ";
                }
            }
            Console.WriteLine(PrintOut);
            return PrintOut;
        }
    }
}
