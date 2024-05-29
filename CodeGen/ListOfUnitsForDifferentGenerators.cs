using System.Collections.Generic;

namespace CodeGen;

public class ListOfUnitsForDifferentGenerators
{


    //Ordering this is right now a hack.
    //If two units have the same  units but with different names, the first one will be used.
    //Therefore I order them in groups where the first one is the one I want to use.
    //Maybe in the future we can make all the 'extra' units as aliases..

    public static List<string> GetListOfCombinedUnits() => [        
        
        "Acceleration",       

        "Ratio", //Same as Ratio
        "Angle", //Same as Ratio
        "BitRate", //Same as Ratio
        "Information", //Same as Ratio
        "PipeSize",
        // NOTE: missing: Dimensionless
        // NOTE: missing: Level
        // NOTE: missing: Scalar
        // NOTE: missing: SolidAngle
        
        "Power",
        "ApparentPower", //Same as Power
        "ReactivePower", //Same as Power

        "Area", //Same as Area
        "VolumePerLength", //Same as Area


        "AreaCost",

        "AreaDensity",

        "AreaMomentOfInertia",
        
        "BrakeSpecificFuelConsumption",

        "Capacitance",

        "CoefficientOfThermalExpansion",

        "Density",

        "DurationCost",
        
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
        
        "Energy", //Same as Energy
        "Torque", //Same as Energy
        "ReactiveEnergy", //Same as Energy
        
        "EnergyCost",
        
        
        "SpecificEnergy", //Same as SpecificEnergy
        "Enthalpy", //Same as SpecificEnergy
        
        "Entropy",

        "Force", //Same as Force
        "TorquePerLength", //Same as Force

        "ForceChangeRate", //Same as ForceChangeRate
        "LinearPowerDensity", //Same as ForceChangeRate

        "ForceCost",
        
        "Irradiation", //Same as Irradiation
        "ForcePerLength",//Same as Irradiation
        
        "Frequency", //Same as Frequency
        "RotationalSpeed", //Same as Frequency
        
        "FuelEfficiency",
        
        "HeatFlux", //Same as HeatFlux
        "Irradiance", //Same as HeatFlux
        
        "HeatTransferCoefficient",
        
        "Illuminance",

        "Jerk",

        "KinematicViscosity",

        "LapseRate",

        "LengthCost",

        "LinearDensity",

        "LuminousFlux", // same as LuminousIntensity

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
        
        "PowerCost",

        
        "PowerDensity", //Same as PowerDensity
        "PressureChangeRate", //Same as PowerDensity

        "Pressure",


        "SpecificEntropy", //Same as SpecificEntropy
        "SpecificHeatCapacity", //Same as SpecificEntropy

        "SpecificThermalResistance",

        "SpecificVolume",

        "SpecificWeight",

        "Speed",

        "TemperatureChangeRate",

        "ThermalConductivity",
        
        "ThermalResistance",
        
        "Volume",
        
        "VolumeCost",
        
        "VolumeFlow",
        
        "VolumetricHeatTransferCoefficient",
        
        "WarpingMomentOfInertia",
        
        
        // NOTE: missing ApparentEnergy
        // NOTE: missing: ElectricAdmittance
        // NOTE: missing: ElectricConductance
        // NOTE: missing: RotatinalAcceleration
        // NOTE: missing: RotatinalStiffness
        // NOTE: missing: RotatinalStiffnessPerLength
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
