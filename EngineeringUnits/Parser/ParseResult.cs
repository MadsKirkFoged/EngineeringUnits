using System;
using System.Collections.Generic;

namespace EngineeringUnits.Parsing
{
    public sealed class ParseWarning
    {
        public string Code { get; init; } = "";
        public string Message { get; init; } = "";
        public string? SuggestedInput { get; init; }
        public string? SuggestedUnitExpression { get; init; }
    }

    public sealed class ParseResult<T>
    {
        public bool Success { get; init; }
        public T? Value { get; init; }
        public string Original { get; init; } = "";
        public string Normalized { get; init; } = "";
        public IReadOnlyList<ParseWarning> Warnings { get; init; } = Array.Empty<ParseWarning>();
        public string? Error { get; init; }
    }
}