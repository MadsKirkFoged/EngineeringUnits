
using System;
using System.IO;
using System.Reflection;

namespace CodeGen
{
    class Program
    {
        static readonly string LIBRARY_NAME = "EngineeringUnits";
        static void Main(string[] args)
        {
            string assemblyDir = Assembly.GetAssembly(typeof(Program)).Location;
            string solutionDir = assemblyDir.Substring(0, assemblyDir.IndexOf(LIBRARY_NAME) + LIBRARY_NAME.Length);
            string libraryDir = Path.Combine(solutionDir, LIBRARY_NAME);

            UnknownUnitExtensionsGenerator.Generate(libraryDir);
        }
    }
}
