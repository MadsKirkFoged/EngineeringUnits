using System;
using System.Collections;
using System.Linq;
using System.Reflection;

public static class UnitReflection
{
    /// <summary>
    /// Returns the UnitSystem for EngineeringUnits.Units.{quantityName}Unit.SI.Unit
    /// Example quantityName: "Pressure" -> PressureUnit.SI.Unit
    /// </summary>
    public static object GetSiUnitSystem(string quantityName)
    {
        // 1) Get the assembly that contains EngineeringUnits (best: reference the project and use typeof)
        // If you are inside CodeGen without referencing EngineeringUnits, use Assembly.Load("EngineeringUnits")
        var asm = Assembly.Load("EngineeringUnits");

        // 2) Resolve type: EngineeringUnits.Units.{quantityName}Unit
        var unitTypeName = $"EngineeringUnits.Units.{quantityName}Unit";
        var unitType = asm.GetType(unitTypeName, throwOnError: true)!;

        // 3) Get static field/property "SI"
        // In your generated unit records it is typically "public static readonly XUnit SI = ..."
        // which is a FIELD (like FrequencyUnit.SI) [1](https://github.com/MadsKirkFoged/EngineeringUnits/blob/master/EngineeringUnits/UnitMath.cs)
        object? siInstance =
            unitType.GetField("SI", BindingFlags.Public | BindingFlags.Static)?.GetValue(null)
            ?? unitType.GetProperty("SI", BindingFlags.Public | BindingFlags.Static)?.GetValue(null);

        if (siInstance is null)
            throw new InvalidOperationException($"{unitTypeName} has no public static SI field/property.");

        // 4) Get instance member "Unit" (should be UnitSystem)
        var unitSystem =
            siInstance.GetType().GetProperty("Unit", BindingFlags.Public | BindingFlags.Instance)?.GetValue(siInstance)
            ?? siInstance.GetType().GetField("Unit", BindingFlags.Public | BindingFlags.Instance)?.GetValue(siInstance);

        if (unitSystem is null)
            throw new InvalidOperationException($"{unitTypeName}.SI has no instance Unit property/field.");

        return unitSystem;
    }

    /// <summary>
    /// Returns IEnumerable list of RawUnit-like objects from UnitSystem.ListOfUnits
    /// </summary>
    public static IEnumerable GetListOfUnits(object unitSystem)
    {
        var list =
            unitSystem.GetType().GetProperty("ListOfUnits", BindingFlags.Public | BindingFlags.Instance)?.GetValue(unitSystem)
            ?? unitSystem.GetType().GetField("ListOfUnits", BindingFlags.Public | BindingFlags.Instance)?.GetValue(unitSystem);

        if (list is null)
            throw new InvalidOperationException("UnitSystem has no ListOfUnits property/field.");

        if (list is not IEnumerable enumerable)
            throw new InvalidOperationException("ListOfUnits is not IEnumerable.");

        return enumerable;
    }
}
