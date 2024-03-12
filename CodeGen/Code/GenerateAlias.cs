using System.Collections.Generic;
using System.IO;

namespace CodeGen.Code;

internal class GenerateAlias
{

    public static void GenerateEnums(string projectPath)
    {

        string str;

        foreach (KeyValuePair<string, string> i in ListOfUnitsForDifferentGenerators.AliasList())
        {
            var path = Path.Combine(projectPath, "CombinedUnits", i.Value);

            if (!Directory.Exists(path))
            {
                _=Directory.CreateDirectory(path);
            }

            var projectPathWithUnit = Path.Combine(projectPath, "CombinedUnits", i.Key, $"{i.Key}Enum.cs");

            str = File.ReadAllText(Path.Combine(projectPathWithUnit));

            str = str.Replace($"{i.Key}", $"{i.Value}");

            File.WriteAllText(Path.Combine(path, $"{i.Value}Enum.cs"), str.ToString());

        }
    }

    public static void AliasClass(string projectPath)
    {

        foreach (KeyValuePair<string, string> item in ListOfUnitsForDifferentGenerators.AliasList())
        {

            var sb = CreateAlias().Replace("Variable", $"{item.Value}")
                                  .Replace("Original", $"{item.Key}");

            var projectPathWithUnit = Path.Combine(projectPath, "CombinedUnits", item.Value);

            File.WriteAllText(Path.Combine(projectPathWithUnit, $"{item.Value}Alias.cs"), sb.ToString());

        }
    }

    public static string CreateAlias()
    {

        return $$"""
                   namespace EngineeringUnits;
                   //This class is auto-generated, changes to the file will be overwritten!
                    
                   public partial class Variable : BaseUnit
                   {
                       public static implicit operator Variable?(Original? Unit)
                       {
                           if (Unit is null)
                               return null;           
                   
                           return new(Unit);
                       }
                   
                       public static implicit operator Original?(Variable? Unit)
                       {
                           if (Unit is null)
                               return null;           
                   
                           return new(Unit);
                       }
                   }
                   
                   """;
    }
}
