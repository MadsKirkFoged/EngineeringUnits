
using System.IO;
using System.Reflection;

namespace CodeGen
{
    class Program
    {

        static readonly string LIBRARY_NAME = "EngineeringUnits";
        static readonly string GENERATOR_NAME = "CodeGen";
        static void Main(string[] args)
        {
            string assemblyDir = Assembly.GetAssembly(typeof(Program)).Location;
            string solutionDir = assemblyDir.Substring(0, assemblyDir.IndexOf(GENERATOR_NAME));
            string libraryDir = Path.Combine(solutionDir, LIBRARY_NAME);


            UnitGenerator.GenerateClasses(libraryDir);
            GenerateUnitEnum.GenerateClasses(libraryDir);
            GenerateAlias.GenerateEnums(libraryDir);
            GenerateSetter.GenerateSetterClasses(libraryDir);
            GenerateGetter.GenerateGetterClasses(libraryDir);
            UnitListGenerator.UnitsInclude();
            GenerateAlias.AliasClass(libraryDir);
            AbsExtensionsGenerator.Generate(libraryDir);
            UnknownUnitExtensionsGenerator.Generate(libraryDir);

        }
    }
}
