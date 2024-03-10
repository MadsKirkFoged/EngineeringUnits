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

    public static string Getter(string className)
    {
        var sb = new StringBuilder();

        _=sb.AppendLine(@"
using EngineeringUnits.Units;

namespace EngineeringUnits;
//This class is auto-generated, changes to the file will be overwritten!
public partial class Variable
{
");
        // sb.Append(AllGetters());

        var t = Type.GetType("EngineeringUnits.Units." + className + "Unit, EngineeringUnits");

        if (t is null)
            return null;

        foreach (System.Reflection.FieldInfo i in t.GetFields())
        {
            _=sb.Append(@"
            /// <summary>
            ///     Get Variable in UnitEnum.
            /// </summary>
            public double UnitEnum => As(VariableUnit.UnitEnum);");

            sb = sb.Replace("UnitEnum", $"{i.Name}");
        }

        _=sb.AppendLine(@"
    }


");

        return sb.ToString();

    }
}
