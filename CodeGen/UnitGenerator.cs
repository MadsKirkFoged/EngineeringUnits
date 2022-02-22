using EngineeringUnits;
using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.IO;

using System.Text;
using System.Linq;

namespace CodeGen
{
    internal  class UnitGenerator
    {

        public static List<string> GetListOfCombinedUnits()
        {
            return new List<string>() { "Acceleration", "Angle", "ApparentPower", "AreaDensity", "AreaMomentOfInertia", "Area", "BitRate", "BrakeSpecificFuelConsumption", "Capacitance", "CoefficientOfThermalExpansion", "Density", "DynamicViscosity", "ElectricChargeDensity", "ElectricCharge", "ElectricConductivity", "ElectricCurrentDensity", "ElectricCurrentGradient", "ElectricField", "ElectricInductance", "ElectricPotentialChangeRate", "ElectricPotential", "MolarMass", "ElectricResistance", "ElectricResistivity", "ElectricSurfaceChargeDensity", "Energy", "Entropy", "ForceChangeRate", "ForcePerLength", "Force", "Frequency", "FuelEfficiency", "HeatFlux", "HeatTransferCoefficient", "Illuminance", "Information", "Irradiance", "Irradiation", "KinematicViscosity", "LapseRate", "LinearDensity", "LinearPowerDensity", "LuminousFlux", "MagneticField", "MagneticFlux", "Magnetization", "MassFlow", "MassFlux", "MassMomentOfInertia", "MolarEnergy", "MolarEntropy", "Molarity", "Permeability", "Permittivity", "PowerDensity", "Power", "PressureChangeRate", "Pressure", "Ratio", "ReactiveEnergy", "ReactivePower", "RotationalSpeed", "SpecificEnergy", "SpecificEntropy", "SpecificWeight", "Speed", "TemperatureChangeRate", "ThermalConductivity", "ThermalResistance", "TorquePerLength", "Torque", "VolumeFlow", "VolumePerLength", "Volume", "WarpingMomentOfInertia" };
        }

        public static List<string> GetListOfBaseUnits()
        {
            return new List<string>() { "AmountOfSubstance", "Duration", "ElectricCurrent", "Length", "LuminousIntensity", "Mass" };
        }

        public static void GenerateClasses(string projectPath)
        {

            


            foreach (var item in GetListOfCombinedUnits())
             {

                string sb = Generate(item);
                sb = sb.Replace("Variable", $"{item}");
                string projectPathWithUnit = Path.Combine(projectPath, "CombinedUnits",item);

                File.WriteAllText(Path.Combine(projectPathWithUnit, $"{item}.cs"), sb.ToString());

             }

            foreach (var item in GetListOfBaseUnits())
            {

                string sb = Generate(item);
                sb = sb.Replace("Variable", $"{item}");
                string projectPathWithUnit = Path.Combine(projectPath, "BaseUnits", item);

                File.WriteAllText(Path.Combine(projectPathWithUnit, $"{item}.cs"), sb.ToString());

            }

        }



        public static string Generate(string className)
        {
            StringBuilder sb = new StringBuilder();



           sb.AppendLine(@"
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class Variable : BaseUnit
    {

        public Variable() { }
        public Variable(decimal value, VariableUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Variable(double value, VariableUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Variable(int value, VariableUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Variable(UnknownUnit value) : base(value) { }

        public static Variable From(double value, VariableUnit unit) => new(value, unit);

        public static Variable From(double? value, VariableUnit unit)
        {
            if (value is null || unit is null)
            {
                return null;
            }

            return From((double)value, unit);
        }
        public double As(VariableUnit ReturnInThisUnit) => ToTheOutSideDouble(ReturnInThisUnit.Unit);
        public Variable ToUnit(VariableUnit selectedUnit) => new(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static Variable Zero => new(0, VariableUnit.SI);

        public static implicit operator Variable(UnknownUnit Unit) => new(Unit);

        public static implicit operator Variable(int zero)
        {
            if (zero != 0)
                throw new WrongUnitException(""You need to give it a unit unless you set it to 0(zero)!"");" +

            "\n\t\t\treturn Zero;\n" +
        "\t\t}\n" +
        "\tpublic override string GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<VariableUnit>(_unit);\n"+
    "\t}\n" +
"}\n");


           

            return sb.ToString();



        }
        }





    
}
