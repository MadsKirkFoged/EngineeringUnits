
using System;
using System.IO;
using System.Linq;
using System.Text;

using EngineeringUnits;

namespace CodeGen
{
    // generates the UnknownUnitExtensions.cs file
    internal static class UnknownUnitExtensionsGenerator
    {
        public static void Generate(string projectRootPath)
        {
            StringBuilder builder = new StringBuilder();
            //StringBuilder staticUnits = new StringBuilder();
            StringBuilder conditionals = new StringBuilder();

            foreach (var item in ListOfUnitsForDifferentGenerators.GetListOFAllUnits())
            {
                conditionals.AppendLine($"\t\t\tif (toCast.Unit == {item}Unit.SI.Unit)");
                conditionals.AppendLine($"\t\t\t{{");
                conditionals.AppendLine($"\t\t\t\treturn ({item}) toCast;");
                conditionals.AppendLine($"\t\t\t}}");

            }







            builder.AppendLine(@"using EngineeringUnits.Units;

namespace EngineeringUnits
{
    //This class is auto-generated, changes to the file will be overwritten!
    public static class UnknownUnitExtensions
    {");
            builder.AppendLine();
            //builder.Append(staticUnits);
            builder.AppendLine(@"       public static BaseUnit IntelligentCast(this UnknownUnit toCast)
        {
            BaseUnit output = (BaseUnit) toCast;
            UnitSystem unit = output.Unit;");
            builder.Append(conditionals);
            builder.AppendLine(@"
            return output;
            
        }
    }
}");

            File.WriteAllText(Path.Combine(projectRootPath, "UnknownUnitExtensions.cs"), builder.ToString());
        }
    }



}
