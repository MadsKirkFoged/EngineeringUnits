
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
            StringBuilder staticUnits = new StringBuilder();
            StringBuilder conditionals = new StringBuilder();

            typeof(BaseUnit).Assembly.GetTypes()
                .Where(t => t.IsSubclassOf(typeof(BaseUnit)))
                .Where(t => null != t.GetMethod("FromSI")).ToList()
                .ForEach(type =>
                {
                    //staticUnits.AppendLine($"\t\tstatic UnitSystem {type.Name.ToLower()} = {type.Name}.FromSI(1).Unit;");

                    conditionals.AppendLine($"\t\t\tif (toCast.unitsystem == {type.Name}Unit.SI.Unit)");
                    conditionals.AppendLine($"\t\t\t{{");
                    conditionals.AppendLine($"\t\t\t\treturn ({type.Name}) toCast;");
                    conditionals.AppendLine($"\t\t\t}}");
                });

            builder.AppendLine(@"using EngineeringUnits.Units;

namespace EngineeringUnits
{
    public static class UnknownUnitExtensions
    {");
            builder.AppendLine();
            builder.Append(staticUnits);
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
