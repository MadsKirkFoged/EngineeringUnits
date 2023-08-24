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


            foreach (KeyValuePair<string, string> i in ListOfUnitsForDifferentGenerators.AliasList())
            {
                string path = Path.Combine(projectPath, "CombinedUnits", i.Value);


                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                

                    string projectPathWithUnit = Path.Combine(projectPath, "CombinedUnits",i.Key, $"{i.Key}Enum.cs");

                    str = File.ReadAllText(Path.Combine(projectPathWithUnit));

                    str = str.Replace($"{i.Key}", $"{i.Value}");



                    File.WriteAllText(Path.Combine(path, $"{i.Value}Enum.cs"), str.ToString());
                
            }




        }


        





        public static void AliasClass(string projectPath)
        {
           

            foreach (var item in ListOfUnitsForDifferentGenerators.AliasList())
            {

                string sb = CreateAlias(item.Value);

               


                    sb = sb.Replace("Variable", $"{item.Value}");
                    sb = sb.Replace("Original", $"{item.Key}");

                
                string projectPathWithUnit = Path.Combine(projectPath, "CombinedUnits", item.Value);

                File.WriteAllText(Path.Combine(projectPathWithUnit, $"{item.Value}Alias.cs"), sb.ToString());


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
        public static implicit operator Variable(Original Unit)
        {
            if (Unit is null)
                return null;           

            return new(Unit);
        }

        public static implicit operator Original(Variable Unit)
        {
            if (Unit is null)
                return null;           

            return new(Unit);
        }
    }
}



 ");

            return sb.ToString();



        }

        
    }
}
