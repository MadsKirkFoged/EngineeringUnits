using EngineeringUnits.Fast;

// Global namespace on purpose (see the generated {T}NullableExtensions): these are instance members in EngineeringUnits,
// usable without "using EngineeringUnits;"

/// <summary>The hand-written <see cref="PipeSize"/> extras on a <see cref="PipeSize"/>? - reading from null throws, like EngineeringUnits.</summary>
public static class PipeSizeNullableExtras
{
    extension(PipeSize? pipeSize)
    {
        public int DNValve => pipeSize!.Value.DNValve;
        public Length? GetOutsideDiameter => pipeSize?.GetOutsideDiameter;
    }

    public static Length? GetWallThickness(this PipeSize? pipeSize, PipeScheduleEnum schedule) => pipeSize?.GetWallThickness(schedule);
    public static Length? GetInsideDiameter(this PipeSize? pipeSize, PipeScheduleEnum schedule) => pipeSize?.GetInsideDiameter(schedule);
    public static Area? GetInsideCrossSection(this PipeSize? pipeSize, PipeScheduleEnum schedule) => pipeSize?.GetInsideCrossSection(schedule);
}
