
using System;
using System.IO;
using System.Linq;
using System.Text;
using EngineeringUnits;

namespace CodeGen.Code
{
    // generates the AbsExtensions.cs file
    internal static class AbsExtensionsGenerator
    {
        public static void Generate(string projectRootPath)
        {
            //StringBuilder builder = new StringBuilder();
            //StringBuilder staticUnits = new StringBuilder();
            StringBuilder conditionals = new StringBuilder();

            foreach (var item in ListOfUnitsForDifferentGenerators.GetListOFAllUnits())
            {
                string functions = $$"""

                                 /// <summary>
                                 /// Returns the absolute value
                                 /// </summary>
                                 public static Variable Abs(this Variable a)
                                 {
                                     if (a is null)
                                         return null;

                                     if (a.GetBaseValue() > 0)
                                         return a;

                                     return -a;
                                 }

                               """.Replace("Variable", $"{item}");

                conditionals.AppendLine(functions);
            }


            string builder = $$"""

                               namespace EngineeringUnits;
                               public static class AbsExtensions
                               {
                                   [InsertFunctions]
                               }

                               """.Replace("[InsertFunctions]", conditionals.ToString());




            File.WriteAllText(Path.Combine(projectRootPath, "AbsExtensions.cs"), builder);
        }
    }



}
