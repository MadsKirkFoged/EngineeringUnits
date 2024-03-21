using System.IO;
using System.Text;

namespace CodeGen.Code;

// generates the UnknownUnitExtensions.cs file
internal static class UnknownUnitExtensionsGenerator
{
    public static void Generate(string projectRootPath)
    {
        //StringBuilder builder = new StringBuilder();
        //StringBuilder staticUnits = new StringBuilder();
        var conditionals = new StringBuilder();
        _ = conditionals.AppendLine(""); // NOTE: this fixes tabbing offset for first [Variable]... there might be a better way to do this than this...

        foreach (var item in ListOfUnitsForDifferentGenerators.GetListOFAllUnits())
        {
            var functions = $$"""
                                      if (toCast == [Variable]Unit.SI.Unit)
                                          return ([Variable]?)toCast;
                              """.Replace("[Variable]", $"{item}");

            _ = conditionals.AppendLine(functions);
        }

        var builder = $$"""
                         using EngineeringUnits.Units;

                         namespace EngineeringUnits;
                         
                         // This class is auto-generated, changes to the file will be overwritten!
                         public static class UnknownUnitExtensions
                         {
                             
                             public static BaseUnit? IntelligentCast(this UnknownUnit toCast)
                             {
                                 [InsertFunctions]
                                 return null;
                             }
                         }
                         
                         """.Replace("[InsertFunctions]", conditionals.ToString());

        File.WriteAllText(Path.Combine(projectRootPath, "UnknownUnitExtensions.cs"), builder.ToString());
    }
}
