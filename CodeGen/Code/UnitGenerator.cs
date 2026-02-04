using EngineeringUnits;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace CodeGen.Code;

internal class UnitGenerator
{

    public static void GenerateClasses(string projectPath)
    {

        List<string> list = ListOfUnitsForDifferentGenerators.GetListOfCombinedUnits();
        foreach (var item in list)
        {
            var sb = Generate(item, GetDimList(item));

            var projectPathWithUnit = Path.Combine(projectPath, "CombinedUnits", item);

            if (!Directory.Exists(projectPathWithUnit))
            {
                _ = Directory.CreateDirectory(projectPathWithUnit);
            }

            File.WriteAllText(Path.Combine(projectPathWithUnit, $"{item}.cs"), sb.ToString());

        }

        foreach (var item in ListOfUnitsForDifferentGenerators.GetListOfBaseUnits())
        {

            var sb = Generate(item, GetDimList(item));

            var projectPathWithUnit = Path.Combine(projectPath, "BaseUnits", item);
            if (!Directory.Exists(projectPathWithUnit))
            {
                _=Directory.CreateDirectory(projectPathWithUnit);
            }

            File.WriteAllText(Path.Combine(projectPathWithUnit, $"{item}.cs"), sb.ToString());

        }
    }

    private static string GetDimList(string item)
    {
        var unitSystem = UnitReflection.GetSiUnitSystem(item);
        var listOfUnits = UnitReflection.GetListOfUnits(unitSystem);

        var dims = Enum.GetValues<BaseunitType>()
                       .Where(k => k != BaseunitType.CombinedUnit)
                       .ToDictionary(k => k, _ => 0);

        foreach (var rawUnit in listOfUnits)
        {
            BaseunitType unitType = (BaseunitType)rawUnit.GetType().GetProperty("UnitType")?.GetValue(rawUnit);
            int count = (int)rawUnit.GetType().GetProperty("Count")?.GetValue(rawUnit);

            dims[unitType] = count;
        }

        var parts = Enum.GetValues<BaseunitType>()
                        .Where(k => k != BaseunitType.CombinedUnit)
                        .Select(t => $"BaseunitType.{t}, {dims.GetValueOrDefault(t)}");

        return $"[UnitDimension({string.Join(", ", parts)})]";
    }

    public static string Generate(string Variable, string DimensionText)
    {

        return $$"""
                   using EngineeringUnits.Units;
                   using System.Diagnostics.CodeAnalysis;
                   using Fractions;
                   using EngineeringUnits.Parsing;
                   using System;
                   
                   namespace EngineeringUnits;
                   
                   // This class is auto-generated, changes to the file will be overwritten!
                   {{DimensionText}}
                   public partial class {{Variable}} : BaseUnit
                   {
                       public {{Variable}}() { }
                       public {{Variable}}(Fraction value, {{Variable}}Unit selectedUnit) : base(value, selectedUnit.Unit) { }
                       public {{Variable}}(decimal value, {{Variable}}Unit selectedUnit) : base(value, selectedUnit.Unit) { }
                       public {{Variable}}(double value, {{Variable}}Unit selectedUnit) : base(value, selectedUnit.Unit) { }
                       public {{Variable}}(int value, {{Variable}}Unit selectedUnit) : base(value, selectedUnit.Unit) { }
                       public {{Variable}}(UnknownUnit value) : base(value) { }
                   
                       public static {{Variable}} From(double value, {{Variable}}Unit unit) => new(value, unit);
                   
                       [return: NotNullIfNotNull(nameof(value))]
                       public static {{Variable}}? From(double? value, {{Variable}}Unit? unit)
                       {
                           if (value is null || unit is null)
                               return null;
                   
                           return From((double)value, unit);
                       }
                       public double As({{Variable}}Unit ReturnInThisUnit) => this.GetValueAsDouble(ReturnInThisUnit);
                       public {{Variable}} ToUnit({{Variable}}Unit selectedUnit) => new(this.GetValueAs(selectedUnit.Unit), selectedUnit);
                       public static {{Variable}} Zero => new(0, {{Variable}}Unit.SI);
                       public static {{Variable}} NaN => new(double.NaN, {{Variable}}Unit.SI);
                   
                       [return: NotNullIfNotNull(nameof(Unit))]
                       public static implicit operator {{Variable}}?(UnknownUnit? Unit)
                       {
                           if (Unit is null)
                               return null;
                   
                           GuardAgainst.DifferentUnits(Unit, {{Variable}}Unit.SI);
                           return new(Unit);
                       }
                   
                       [return: NotNullIfNotNull(nameof(Unit))]
                       public static implicit operator UnknownUnit?({{Variable}}? Unit)
                       {
                           if (Unit is null)
                               return null;
                   
                           return new(Unit);
                       }
                   
                       public override string? GetStandardSymbol(UnitSystem _unit, string? format = null) => GetStandardSymbol<{{Variable}}Unit>(_unit, format);

                       public static {{Variable}} Parse(string? input, IFormatProvider? culture = null)
                       {
                            return QuantityParser.Parse<{{Variable}}, {{Variable}}Unit>(
                            input,
                            (v, u) => new {{Variable}}(v, u),
                            {{Variable}}Unit.SI,
                            culture);
                       }
                   }
                   
                   """;

    }
}
