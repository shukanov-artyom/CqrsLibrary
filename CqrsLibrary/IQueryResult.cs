using System;

namespace CqrsLibrary
{
    /// <summary>
    /// Query Result interface.
    /// </summary>
    public interface IQueryResult
    {
        bool IsSuccess { get; }
    }
}
