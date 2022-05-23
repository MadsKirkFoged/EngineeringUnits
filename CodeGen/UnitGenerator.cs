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
    internal  class UnitGenerator
    {
                    

        public static void GenerateClasses(string projectPath)
        {

            List<string> list = ListOfUnitsForDifferentGenerators.GetListOfCombinedUnits();
            list.AddRange(ListOfUnitsForDifferentGenerators.Alias());
            foreach (var item in list)
             {

                string sb = Generate(item);
               
                sb = sb.Replace("Variable", $"{item}");
                string projectPathWithUnit = Path.Combine(projectPath, "CombinedUnits",item);

                File.WriteAllText(Path.Combine(projectPathWithUnit, $"{item}.cs"), sb.ToString());

             }

            foreach (var item in ListOfUnitsForDifferentGenerators.GetListOfBaseUnits())
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
    //This class is auto-generated, changes to the file will be overwritten!
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
        public double As(VariableUnit ReturnInThisUnit) => GetValueAsDouble(ReturnInThisUnit.Unit);
        public Variable ToUnit(VariableUnit selectedUnit) => new(GetValueAs(selectedUnit.Unit), selectedUnit);
        public static Variable Zero => new(0, VariableUnit.SI);

        public static implicit operator Variable(UnknownUnit Unit)
        {
            UnitCheck(Unit, VariableUnit.SI);
            return new(Unit);        
        }

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
