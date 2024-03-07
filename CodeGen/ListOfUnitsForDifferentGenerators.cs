using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGen
{
    public class ListOfUnitsForDifferentGenerators
    {

        public static List<string> GetListOfCombinedUnits()
        {
            return new List<string>() { "Ratio", "Acceleration", "AreaDensity", "AreaMomentOfInertia", "Area", "AreaCost", "BitRate", "BrakeSpecificFuelConsumption", "Capacitance", "CoefficientOfThermalExpansion", "Density", "DynamicViscosity", "ElectricChargeDensity", "ElectricCharge", "ElectricConductivity", "ElectricCurrentDensity", "ElectricCurrentGradient", "ElectricField", "ElectricInductance", "ElectricPotentialChangeRate", "ElectricPotential", "MolarMass", "ElectricResistance", "ElectricResistivity", "ElectricSurfaceChargeDensity", "Energy", "EnergyCost", "Entropy", "ForceChangeRate", "ForcePerLength", "Force", "Frequency", "FuelEfficiency", "HeatFlux", "HeatTransferCoefficient", "Illuminance", "Information", "Irradiance", "Irradiation", "KinematicViscosity", "LapseRate", "LengthCost", "LinearDensity", "LinearPowerDensity", "LuminousFlux", "MagneticField", "MagneticFlux", "Magnetization", "MassCost", "MassFlow", "MassFlux", "MassMomentOfInertia", "MolarEnergy", "MolarEntropy", "Molarity", "Permeability", "Permittivity", "PowerDensity", "Power", "PowerCost", "Pressure", "PressureChangeRate", "ReactiveEnergy", "ReactivePower", "RotationalSpeed", "SpecificEnergy", "SpecificEntropy", "SpecificWeight", "Speed", "TemperatureChangeRate", "ThermalConductivity", "ThermalResistance", "TorquePerLength", "Torque", "VolumeFlow", "VolumePerLength", "Volume", "VolumeCost", "WarpingMomentOfInertia", "SpecificThermalResistance", "ApparentPower", "Enthalpy", "SpecificHeatCapacity", "Angle", "MolarFlow", "SpecificVolume", "VolumetricHeatTransferCoefficient", "Jerk" };
        }

        public static List<string> GetListOfBaseUnits()
        {
            return new List<string>() { "AmountOfSubstance", "Duration", "ElectricCurrent", "Length", "LuminousIntensity", "Mass", "Temperature", "Cost" };
        }

        public static List<string> GetListOFAllUnits()
        {
            List<string> list = GetListOfCombinedUnits();
            list.AddRange(GetListOfBaseUnits());
            //list.Add("Temperature");
            //list.Add("Pressure");
            return list;
        }

        


        public static List<KeyValuePair<string, string>> AliasList()
        {
            return new List<KeyValuePair<string,string>>() 
            {
                new KeyValuePair<string, string>("SpecificEnergy","Enthalpy"),
                new KeyValuePair<string, string>("SpecificEntropy","SpecificHeatCapacity")
               
            };

        }

    }
}
