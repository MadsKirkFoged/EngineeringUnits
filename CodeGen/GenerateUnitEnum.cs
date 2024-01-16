using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGen;
public class GenerateUnitEnum
{
    public static void GenerateClasses(string projectPath)
    {

        List<string> list = ListOfUnitsForDifferentGenerators.GetListOfCombinedUnits();


        foreach (var item in list)
        {
            //string path = Path.Combine(projectPath, $@"CombinedUnits/{item}/{item}Enum.cs");

            string path1 = Path.Combine(projectPath, "CombinedUnits");
            string path2 = Path.Combine(path1, $"{item}");
            string path3 = Path.Combine(path2, $"{item}Enum.cs");

            if (File.Exists(path3))
                continue;
       
      

            string functions = $$"""
                                    using Fractions;
                                    using System;
                                    using System.Collections.Generic;
                                    using System.Text;

                                    namespace EngineeringUnits;
                                    public record [Variable]Unit : UnitTypebase
                                    {    
                                    

                                    }    
    
                                    """.Replace("[Variable]", $"{item}");


            File.WriteAllText(path3, functions);

        }       

    }




}
