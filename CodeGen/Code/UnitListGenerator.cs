using System;
using System.Collections.Generic;
using System.Reflection;

namespace CodeGen.Code;

internal class UnitListGenerator
{

    public static string ShowUnittypes()
    {
        var PrintOut = $"";

        foreach (var assemblyName in ListOfUnitsForDifferentGenerators.GetListOFAllUnits())
        {
            var t = Type.GetType("EngineeringUnits.Units." + assemblyName + "Unit, EngineeringUnits");

            if (t is null)
                continue;

            PrintOut += "\n" + assemblyName + ":";
            foreach (FieldInfo item in t.GetFields())
            {
                PrintOut += $"[{item.GetValue(item)}], ";
            }
        }

        Console.WriteLine(PrintOut);
        return PrintOut;
    }

    public static string ShowUnitNames()
    {
        var PrintOut = $"";

        List<string> assembly = ListOfUnitsForDifferentGenerators.GetListOFAllUnits();

        assembly.Sort();

        foreach (var assemblyName in assembly)
        {
            var t = Type.GetType("EngineeringUnits.Units." + assemblyName + "Unit, EngineeringUnits");
            PrintOut += "\n"+assemblyName+":";
            foreach (FieldInfo item in t.GetFields(BindingFlags.Static | BindingFlags.Public))

                PrintOut+=$"[{item.Name}], ";
        }

        Console.WriteLine(PrintOut);
        return PrintOut;

    }
}
