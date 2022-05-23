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
        



        public static void GenerateSetterClasses(string projectPath)
        {
            List<string> list = ListOfUnitsForDifferentGenerators.GetListOfCombinedUnits();
            list.AddRange(ListOfUnitsForDifferentGenerators.Alias());

            foreach (var item in list)
            {

                string sb = Setter(item);

                foreach (var i in item)
                {

                    sb = sb.Replace("Variable", $"{item}");

                }
                string projectPathWithUnit = Path.Combine(projectPath, "CombinedUnits", item);

                File.WriteAllText(Path.Combine(projectPathWithUnit, $"{item}Set.cs"), sb.ToString());


            }

            foreach (var item in ListOfUnitsForDifferentGenerators.GetListOfBaseUnits())
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
    //This class is auto-generated, changes to the file will be overwritten!
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
