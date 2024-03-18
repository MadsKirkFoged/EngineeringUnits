using System.Collections.Generic;

namespace CodeGen;

public class ListOfUnitsForDifferentGenerators
{

    public static List<string> GetListOfCombinedUnits() => [        
        "Acceleration",
        "Angle",
        "ApparentPower",
        "Area",
        "AreaCost",
        "AreaDensity",
        "AreaMomentOfInertia",
        "BitRate",
        "BrakeSpecificFuelConsumption",
        "Capacitance",
        "CoefficientOfThermalExpansion",
        "Density",
        "DynamicViscosity",
        "ElectricCharge",
        "ElectricChargeDensity",
        "ElectricConductivity",        
        "ElectricCurrentDensity",
        "ElectricCurrentGradient",
        "ElectricField",
        "ElectricInductance",
        "ElectricPotential",
        "ElectricPotentialChangeRate",
        "ElectricResistance",
        "ElectricResistivity",
        "ElectricSurfaceChargeDensity",
        "Energy",
        "EnergyCost",
        "Enthalpy",
        "Entropy",
        "Force",
        "ForceChangeRate",
        "ForcePerLength",
        "Frequency",
        "FuelEfficiency",
        "HeatFlux",
        "HeatTransferCoefficient",
        "Illuminance",
        "Information",
        "Irradiance",
        "Irradiation",
        "Jerk",
        "KinematicViscosity",
        "LapseRate",
        "LengthCost",
        // NOTE: missing: Level
        "LinearDensity",
        "LinearPowerDensity",
        "LuminousFlux",
        "MagneticField",
        "MagneticFlux",
        "Magnetization",
        "MassCost",
        "MassFlow",
        "MassFlux",
        "MassMomentOfInertia",
        "MolarEnergy",
        "MolarEntropy",
        "MolarFlow",
        "Molarity",
        "MolarMass",
        "Permeability",
        "Permittivity",
        "Power",
        "PowerCost",
        "PowerDensity",
        "Pressure",
        "PressureChangeRate",
        "Ratio",
        "ReactiveEnergy",
        "ReactivePower",
        "RotationalSpeed",
        "SpecificEnergy",
        "SpecificEntropy",
        "SpecificHeatCapacity",
        "SpecificThermalResistance",
        "SpecificVolume",
        "SpecificWeight",
        "Speed",
        "TemperatureChangeRate",
        "ThermalConductivity",
        "ThermalResistance",
        "Torque",
        "TorquePerLength",
        "Volume",
        "VolumeCost",
        "VolumeFlow",
        "VolumePerLength",
        "VolumetricHeatTransferCoefficient",
        "WarpingMomentOfInertia",
        ];

    public static List<string> GetListOfBaseUnits() => [
        "AmountOfSubstance",
        "Cost",
        "Duration",
        "ElectricCurrent",
        "Length",
        "LuminousIntensity",
        "Mass",
        "Temperature"
        ];

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
        return
        [
            new KeyValuePair<string, string>("SpecificEnergy","Enthalpy"),
            new KeyValuePair<string, string>("SpecificEntropy","SpecificHeatCapacity")

        ];

    }
}
