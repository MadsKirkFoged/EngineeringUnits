using EngineeringUnits;
using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.IO;

using System.Text;
using System.Linq;
using EngineeringUnits.Units;
using System.Collections;
namespace CodeGen.Code
{
    internal class GenerateGetter
    {




        public static void GenerateGetterClasses(string projectPath)
        {
            List<string> list = ListOfUnitsForDifferentGenerators.GetListOfCombinedUnits();
            list.AddRange(ListOfUnitsForDifferentGenerators.GetListOfCombinedUnits());

            foreach (var item in list)
            {

                string sb = Getter(item);

                if (sb is null)
                    continue;

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

                if (sb is null)
                    continue;

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

            if (t is null)
                return null;

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
