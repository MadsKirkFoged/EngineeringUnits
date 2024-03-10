using System.Collections.Generic;
using System.IO;

using System.Text;

namespace CodeGen.Code;

internal class UnitGenerator
{

    public static void GenerateClasses(string projectPath)
    {

        List<string> list = ListOfUnitsForDifferentGenerators.GetListOfCombinedUnits();
        list.AddRange(ListOfUnitsForDifferentGenerators.GetListOfCombinedUnits());
        foreach (var item in list)
        {

            var sb = Generate(item);

            sb = sb.Replace("Variable", $"{item}");
            var projectPathWithUnit = Path.Combine(projectPath, "CombinedUnits", item);

            if (!Directory.Exists(projectPathWithUnit))
            {
                _=Directory.CreateDirectory(projectPathWithUnit);
            }

            File.WriteAllText(Path.Combine(projectPathWithUnit, $"{item}.cs"), sb.ToString());

        }

        foreach (var item in ListOfUnitsForDifferentGenerators.GetListOfBaseUnits())
        {

            var sb = Generate(item);
            sb = sb.Replace("Variable", $"{item}");
            var projectPathWithUnit = Path.Combine(projectPath, "BaseUnits", item);
            if (!Directory.Exists(projectPathWithUnit))
            {
                _=Directory.CreateDirectory(projectPathWithUnit);
            }

            File.WriteAllText(Path.Combine(projectPathWithUnit, $"{item}.cs"), sb.ToString());

        }
    }

    public static string Generate(string className)
    {
        var sb = new StringBuilder();

        _=sb.AppendLine(@"
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    //This class is auto-generated, changes to the file will be overwritten!
    public partial class Variable : BaseUnit
    {

        public Variable() { }
        public Variable(decimal value, VariableUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Variable(double value, VariableUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Variable(int value, VariableUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Variable(UnknownUnit value) : base(value) { }

        public static Variable From(double value, VariableUnit unit) => new(value, unit);

        public static Variable From(double? value, VariableUnit unit)
        {
            if (value is null || unit is null)
            {
                return null;
            }

            return From((double)value, unit);
        }
        public double As(VariableUnit ReturnInThisUnit) => this.GetValueAsDouble(ReturnInThisUnit);
        public Variable ToUnit(VariableUnit selectedUnit) => new(this.GetValueAs(selectedUnit.Unit), selectedUnit);
        public static Variable Zero => new(0, VariableUnit.SI);
        public static Variable NaN => new(double.NaN, VariableUnit.SI);

        public static implicit operator Variable(UnknownUnit Unit)
        {
            if (Unit is null)
                return null; 

            GuardAgainst.DifferentUnits(Unit, VariableUnit.SI);
            return new(Unit);        
        }

        public static implicit operator UnknownUnit(Variable Unit)
        {            
            if (Unit is null)
                return null;

            return new(Unit);
        }

        public override string GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<VariableUnit>(_unit);
        }
    }");

        return sb.ToString();

    }
}
