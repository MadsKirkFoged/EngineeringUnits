
using CodeGen.Code;
using System.IO;
using System.Reflection;
#pragma warning disable IDE0060

namespace CodeGen;

internal class Program
{
    private static readonly string LIBRARY_NAME = "EngineeringUnits";
    private static readonly string GENERATOR_NAME = "CodeGen";

    private static void Main(string[] args)
    {
        var assemblyDir = Assembly.GetAssembly(typeof(Program))!.Location;
        var solutionDir = assemblyDir[..assemblyDir.IndexOf(GENERATOR_NAME)];
        var libraryDir = Path.Combine(solutionDir, LIBRARY_NAME);

        UnitGenerator.GenerateClasses(libraryDir);
        GenerateUnitEnum.GenerateClasses(libraryDir);
        GenerateAlias.GenerateEnums(libraryDir);
        GenerateSetter.GenerateSetterClasses(libraryDir);
        GenerateGetter.GenerateGetterClasses(libraryDir);
        GenerateAlias.AliasClass(libraryDir);

        AbsExtensionsGenerator.Generate(libraryDir);
        UnknownUnitExtensionsGenerator.Generate(libraryDir);

        //_=UnitListGenerator.ShowUnittypes();
        //_=UnitListGenerator.ShowUnitNames();
    }
}
