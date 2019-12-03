using System;


namespace R5T.Votadinia
{
    /// <summary>
    /// Allows service-based indirection for providing the current UTC date-time.
    /// </summary>
    public interface ICurrentUtcDateTimeProvider
    {
        DateTime GetCurrentUtcDateTime();
    }
}
