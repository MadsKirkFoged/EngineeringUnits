
using CodeGen.Code;
using EngineeringUnits;
using EngineeringUnits.Units;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
#pragma warning disable IDE0060

namespace CodeGen;

internal class Program
{
    private static readonly string LIBRARY_NAME = "EngineeringUnits";
    private static readonly string GENERATOR_NAME = "CodeGen";

    private static void Main(string[] args)
    {

        //For finding units that are equal but with different names
        //UnknownUnit test = new WarpingMomentOfInertia(1, WarpingMomentOfInertiaUnit.SI);
        //var list = test.IntelligentCastTest().ToList();
        //foreach (var item in list)
        //{
        //    Debug.WriteLine(item.GetType().Name);
        //}


        var assemblyDir = Assembly.GetAssembly(typeof(Program))!.Location;
        var solutionDir = assemblyDir[..assemblyDir.IndexOf(GENERATOR_NAME)];
        var libraryDir = Path.Combine(solutionDir, LIBRARY_NAME);

        UnitGenerator.GenerateClasses(libraryDir);
        ExtentionGenerator.GenerateExtention(libraryDir);

        GenerateUnitEnum.GenerateClasses(libraryDir);
        GenerateAlias.GenerateEnums(libraryDir);
        GenerateSetter.GenerateSetterClasses(libraryDir);
        GenerateGetter.GenerateGetterClasses(libraryDir);
        GenerateAlias.AliasClass(libraryDir);

        //AbsExtensionsGenerator.Generate(libraryDir);
        UnknownUnitExtensionsGenerator.Generate(libraryDir);

        _ = UnitListGenerator.ShowUnittypes();
        _ = UnitListGenerator.ShowUnitNames();
    }
}
