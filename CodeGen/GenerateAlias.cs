using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGen
{
   internal class GenerateAlias
    {

       
        public static void GenerateEnums(string projectPath)
        {
           
            string str;
           
                foreach (var i in ListOfUnitsForDifferentGenerators.Alias())
                 {   
                    string path = Path.Combine(projectPath, "CombinedUnits", i);
                    
                  
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }

                    foreach (var item in ListOfUnitsForDifferentGenerators.SpecificList())
                    {

                        string projectPathWithUnit = Path.Combine(projectPath, "CombinedUnits", item, $"{item}Enum.cs");

                        str = File.ReadAllText(Path.Combine(projectPathWithUnit));

                        str = str.Replace($"{item}", $"{i}");



                    File.WriteAllText(Path.Combine(path, $"{i}Enum.cs"), str.ToString()); 
                }
            }


        }





        public static void AliasClass(string projectPath)
        {
            foreach (var item in ListOfUnitsForDifferentGenerators.Alias())
            {

                string sb = CreateAlias(item);

                foreach (var i in ListOfUnitsForDifferentGenerators.SpecificList())
                {
                  

                    sb = sb.Replace("Variable", $"{item}");
                    sb = sb.Replace("Original", $"{i}");

                }
                string projectPathWithUnit = Path.Combine(projectPath, "CombinedUnits", item);

                File.WriteAllText(Path.Combine(projectPathWithUnit, $"{item}Alias.cs"), sb.ToString());


            }
        }


        public static string CreateAlias(string className)
        {

            StringBuilder sb = new StringBuilder();
            sb.AppendLine(@"
using EngineeringUnits.Units;


namespace EngineeringUnits
{   //This class is auto-generated, changes to the file will be overwritten!
    public partial class Variable : BaseUnit
    {
        public static implicit operator Variable(Original Unit) => new(Unit);
        public static implicit operator Original(Variable Unit) => new(Unit);
    }
}



 ");

            return sb.ToString();



        }

        
    }
}
