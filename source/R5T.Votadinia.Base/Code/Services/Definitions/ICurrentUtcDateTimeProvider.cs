using System;

using R5T.T0064;


namespace R5T.Votadinia
{
    /// <summary>
    /// Allows service-based indirection for providing the current UTC date-time.
    /// </summary>
    [ServiceDefinitionMarker]
    public interface ICurrentUtcDateTimeProvider : IServiceDefinition
    {
        DateTime GetCurrentUtcDateTime();
    }
}
