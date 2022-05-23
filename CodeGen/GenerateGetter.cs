using EngineeringUnits;
using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.IO;

using System.Text;
using System.Linq;
using EngineeringUnits.Units;
using System.Collections;
namespace CodeGen
{
    internal class GenerateGetter
    {

        //public static List<string> GetListOfCombinedUnits()
        //{
        //    return new List<string>() { "Acceleration", "Angle", "ApparentPower", "AreaDensity", "AreaMomentOfInertia", "Area", "BitRate", "BrakeSpecificFuelConsumption", "Capacitance", "CoefficientOfThermalExpansion", "Density", "DynamicViscosity", "ElectricChargeDensity", "ElectricCharge", "ElectricConductivity", "ElectricCurrentDensity", "ElectricCurrentGradient", "ElectricField", "ElectricInductance", "ElectricPotentialChangeRate", "ElectricPotential", "MolarMass", "ElectricResistance", "ElectricResistivity", "ElectricSurfaceChargeDensity", "Energy", "Entropy", "ForceChangeRate", "ForcePerLength", "Force", "Frequency", "FuelEfficiency", "HeatFlux", "HeatTransferCoefficient", "Illuminance", "Information", "Irradiance", "Irradiation", "KinematicViscosity", "LapseRate", "LinearDensity", "LinearPowerDensity", "LuminousFlux", "MagneticField", "MagneticFlux", "Magnetization", "MassFlow", "MassFlux", "MassMomentOfInertia", "MolarEnergy", "MolarEntropy", "Molarity", "Permeability", "Permittivity", "PowerDensity", "Power", "PressureChangeRate", "Pressure", "Ratio", "ReactiveEnergy", "ReactivePower", "RotationalSpeed", "SpecificEnergy", "SpecificEntropy", "SpecificWeight", "Speed", "TemperatureChangeRate", "ThermalConductivity", "ThermalResistance", "TorquePerLength", "Torque", "VolumeFlow", "VolumePerLength", "Volume", "WarpingMomentOfInertia", "SpecificThermalResistance" };
        //}
        
        //public static List<string> GetListOfBaseUnits()
        //{
        //    return new List<string>() { "AmountOfSubstance", "Duration", "ElectricCurrent", "Length", "LuminousIntensity", "Mass" };
        //}



        public static void GenerateGetterClasses(string projectPath)
        {
            List<string> list = ListOfUnitsForDifferentGenerators.GetListOfCombinedUnits();
            list.AddRange(ListOfUnitsForDifferentGenerators.Alias());

            foreach (var item in list)
            {

                string sb = Getter(item);

                foreach (var i in item)
                { 
                    
                    sb = sb.Replace("Variable", $"{item}");

                }
                string projectPathWithUnit = Path.Combine(projectPath, "CombinedUnits", item);

                File.WriteAllText(Path.Combine(projectPathWithUnit, $"{item}Get.cs"), sb.ToString());


            }

            foreach (var item in ListOfUnitsForDifferentGenerators.GetListOfBaseUnits())
            {

                string sb = Getter(item);

                foreach (var i in item)
                {

                    sb = sb.Replace("Variable", $"{item}");

                }
                string projectPathWithUnit = Path.Combine(projectPath, "BaseUnits", item);

                File.WriteAllText(Path.Combine(projectPathWithUnit, $"{item}Get.cs"), sb.ToString());

            }


        }


        public static string Getter(string className)
        {
            StringBuilder sb = new StringBuilder();
           
                sb.AppendLine(@"
using EngineeringUnits.Units;


namespace EngineeringUnits
{   //This class is auto-generated, changes to the file will be overwritten!
    public partial class Variable
    {

 ");
            // sb.Append(AllGetters());
            
                var t = Type.GetType("EngineeringUnits.Units." + className + "Unit, EngineeringUnits");

               
                    foreach (var i in t.GetFields())
                    {

                        sb.Append(@"
            /// <summary>
            ///     Get Variable in UnitEnum.
            /// </summary>
            public double UnitEnum => As(VariableUnit.UnitEnum);");

                        sb = sb.Replace("UnitEnum", $"{i.Name}");
                    }
                

            sb.AppendLine(@"
    }
}

");
            

            return sb.ToString();
        
 }



       





    }
}
