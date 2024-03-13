using System;
using System.Collections.Generic;
using System.IO;

using System.Text;
namespace CodeGen.Code;

internal class GenerateGetter
{

    public static void GenerateGetterClasses(string projectPath)
    {
        List<string> list = ListOfUnitsForDifferentGenerators.GetListOfCombinedUnits();
        list.AddRange(ListOfUnitsForDifferentGenerators.GetListOfCombinedUnits());

        foreach (var item in list)
        {

            var sb = Getter(item);

            if (sb is null)
                continue;

            foreach (var i in item)
            {
                sb = sb.Replace("Variable", $"{item}");
            }

            var projectPathWithUnit = Path.Combine(projectPath, "CombinedUnits", item);

            File.WriteAllText(Path.Combine(projectPathWithUnit, $"{item}Get.cs"), sb.ToString());

        }

        foreach (var item in ListOfUnitsForDifferentGenerators.GetListOfBaseUnits())
        {

            var sb = Getter(item);

            if (sb is null)
                continue;

            foreach (var i in item)
            {

                sb = sb.Replace("Variable", $"{item}");

            }

            var projectPathWithUnit = Path.Combine(projectPath, "BaseUnits", item);

            File.WriteAllText(Path.Combine(projectPathWithUnit, $"{item}Get.cs"), sb.ToString());

        }
    }

    public static string? Getter(string className)
    {
        var t = Type.GetType("EngineeringUnits.Units." + className + "Unit, EngineeringUnits");
        var sb = new StringBuilder();

        if (t is null)
            return null;

        var test = $$"""
                     using EngineeringUnits.Units;                     
                     
                     namespace EngineeringUnits;
                     
                     //This class is auto-generated, changes to the file will be overwritten!
                     public partial class Variable
                     {  
                     
                     [InsertHere]
                     }                     
                     """;

        foreach (System.Reflection.FieldInfo i in t.GetFields())
        {
            var test2 = $$"""
                     /// <summary>
                     /// Get Variable in UnitEnum.
                     /// </summary>
                     public double UnitEnum => As(VariableUnit.UnitEnum);                     
                     """.Replace("UnitEnum", $"{i.Name}");

            _=sb.AppendLine(test2);
        }

        return test.Replace("[InsertHere]", sb.ToString());
    }
}
