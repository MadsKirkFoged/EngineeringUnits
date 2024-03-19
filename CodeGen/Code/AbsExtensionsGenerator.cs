using System.IO;
using System.Text;

namespace CodeGen.Code;

// generates the AbsExtensions.cs file
internal static class AbsExtensionsGenerator
{
    public static void Generate(string projectRootPath)
    {
        //StringBuilder builder = new StringBuilder();
        //StringBuilder staticUnits = new StringBuilder();
        var conditionals = new StringBuilder();

        foreach (var item in ListOfUnitsForDifferentGenerators.GetListOFAllUnits())
        {
            var functions = $$"""

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
                               """.Replace("Variable", $"{item}");

            _ = conditionals.AppendLine(functions);
        }

        var builder = $$"""
                         using System.Diagnostics.CodeAnalysis;
                         namespace EngineeringUnits;
                         public static class AbsExtensions
                         {
                             [InsertFunctions]
                         }
                         """.Replace("[InsertFunctions]", conditionals.ToString());

        File.WriteAllText(Path.Combine(projectRootPath, "AbsExtensions.cs"), builder);
    }
}
