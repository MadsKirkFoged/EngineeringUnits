using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGen
{
    class GenerateSetter
    {
        public static List<string> GetListOfCombinedUnits()
        {
            return new List<string>() { "Acceleration", "Angle", "ApparentPower", "AreaDensity", "AreaMomentOfInertia", "Area", "BitRate", "BrakeSpecificFuelConsumption", "Capacitance", "CoefficientOfThermalExpansion", "Density", "DynamicViscosity", "ElectricChargeDensity", "ElectricCharge", "ElectricConductivity", "ElectricCurrentDensity", "ElectricCurrentGradient", "ElectricField", "ElectricInductance", "ElectricPotentialChangeRate", "ElectricPotential", "MolarMass", "ElectricResistance", "ElectricResistivity", "ElectricSurfaceChargeDensity", "Energy", "Entropy", "ForceChangeRate", "ForcePerLength", "Force", "Frequency", "FuelEfficiency", "HeatFlux", "HeatTransferCoefficient", "Illuminance", "Information", "Irradiance", "Irradiation", "KinematicViscosity", "LapseRate", "LinearDensity", "LinearPowerDensity", "LuminousFlux", "MagneticField", "MagneticFlux", "Magnetization", "MassFlow", "MassFlux", "MassMomentOfInertia", "MolarEnergy", "MolarEntropy", "Molarity", "Permeability", "Permittivity", "PowerDensity", "Power", "PressureChangeRate", "Pressure", "Ratio", "ReactiveEnergy", "ReactivePower", "RotationalSpeed", "SpecificEnergy", "SpecificEntropy", "SpecificWeight", "Speed", "TemperatureChangeRate", "ThermalConductivity", "ThermalResistance", "TorquePerLength", "Torque", "VolumeFlow", "VolumePerLength", "Volume", "WarpingMomentOfInertia", "SpecificThermalResistance" };
        }


        public static List<string> GetListOfBaseUnits()
        {
            return new List<string>() { "AmountOfSubstance", "Duration", "ElectricCurrent", "Length", "LuminousIntensity", "Mass" };
        }



        public static void GenerateSetterClasses(string projectPath)
        {


            foreach (var item in GetListOfCombinedUnits())
            {

                string sb = Setter(item);

                foreach (var i in item)
                {

                    sb = sb.Replace("Variable", $"{item}");

                }
                string projectPathWithUnit = Path.Combine(projectPath, "CombinedUnits", item);

                File.WriteAllText(Path.Combine(projectPathWithUnit, $"{item}Set.cs"), sb.ToString());


            }

            foreach (var item in GetListOfBaseUnits())
            {

                string sb = Setter(item);

                foreach (var i in item)
                {

                    sb = sb.Replace("Variable", $"{item}");

                }
                string projectPathWithUnit = Path.Combine(projectPath, "BaseUnits", item);

                File.WriteAllText(Path.Combine(projectPathWithUnit, $"{item}Set.cs"), sb.ToString());

            }


        }


        public static string Setter(string className)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(@"
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class Variable
    {

 ");

            var t = Type.GetType("EngineeringUnits.Units." + className + "Unit, EngineeringUnits");


            foreach (var i in t.GetFields())
            {

                sb.Append(@"
            /// <summary>
            ///     Get Variable from UnitEnum.
            /// </summary>
            /// <exception cref=""ArgumentException"">If value is NaN or Infinity.</exception>
            public static Variable FromUnitEnum(double UnitEnum)
            {
                double value= (double)UnitEnum;
                return new Variable(value, VariableUnit.UnitEnum);
            }");

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
