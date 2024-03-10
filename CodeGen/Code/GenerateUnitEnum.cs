using System.Collections.Generic;
using System.IO;

namespace CodeGen.Code;
public class GenerateUnitEnum
{
    public static void GenerateClasses(string projectPath)
    {

        List<string> list = ListOfUnitsForDifferentGenerators.GetListOfCombinedUnits();

        foreach (var item in list)
        {
            //string path = Path.Combine(projectPath, $@"CombinedUnits/{item}/{item}Enum.cs");

            var path1 = Path.Combine(projectPath, "CombinedUnits");
            var path2 = Path.Combine(path1, $"{item}");
            var path3 = Path.Combine(path2, $"{item}Enum.cs");

            if (File.Exists(path3))
                continue;

            var functions = $$"""
                                    using Fractions;
                                    using System;
                                    using System.Collections.Generic;
                                    using System.Text;

                                    namespace EngineeringUnits.Units;
                                    public partial record [Variable]Unit : UnitTypebase
                                    {    
                                    
                                    




                                        public override string ToString()
                                        {
                                            if (Unit.Symbol is not null)
                                                return $"{Unit.Symbol}";

                                            return $"{Unit}";
                                        }

                                    }    
    
                                    """.Replace("[Variable]", $"{item}");

            File.WriteAllText(path3, functions);

        }
    }
}
