using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGen
{
    public class ExtensionGenerator
    {
        public static void GenerateExtention(string projectPath)
        {

            List<string> list = ListOfUnitsForDifferentGenerators.GetListOfCombinedUnits();
            list.AddRange(ListOfUnitsForDifferentGenerators.GetListOfCombinedUnits());
            foreach (var item in list)
            {

                var sb = Generate().Replace("Variable", $"{item}");

                var projectPathWithUnit = Path.Combine(projectPath, "CombinedUnits", item);

                if (!Directory.Exists(projectPathWithUnit))
                {
                    _=Directory.CreateDirectory(projectPathWithUnit);
                }

                File.WriteAllText(Path.Combine(projectPathWithUnit, $"{item}Extension.cs"), sb.ToString());

            }

            foreach (var item in ListOfUnitsForDifferentGenerators.GetListOfBaseUnits())
            {

                var sb = Generate().Replace("Variable", $"{item}");

                var projectPathWithUnit = Path.Combine(projectPath, "BaseUnits", item);
                if (!Directory.Exists(projectPathWithUnit))
                {
                    _=Directory.CreateDirectory(projectPathWithUnit);
                }

                File.WriteAllText(Path.Combine(projectPathWithUnit, $"{item}Extension.cs"), sb.ToString());

            }
        }


        public static string Generate()
        {

            return $$"""
                   using System;
                   using System.Diagnostics.CodeAnalysis;

                   namespace EngineeringUnits
                   {
                       public static class VariableUnitExtension
                       {

                           public static Variable IfNullSetToZero(this Variable? local)
                           {
                               if (local is not null)
                               {
                                   return local;
                               }

                               return Variable.Zero;
                           }


                           /// <summary>
                           /// Returns the absolute value
                           /// </summary>
                           [return: NotNullIfNotNull(nameof(a))]
                           public static Variable? Abs(this Variable? a)
                           {
                               if (a is null)
                                   return null;

                               if (a.GetBaseValue() > 0)
                                   return a;

                               return (-a)!;
                           }

                       }
                   }                   
                   """;

        }

    }
}
