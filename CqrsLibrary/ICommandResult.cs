using System;

namespace CqrsLibrary
{
    public interface ICommandResult
    {
        bool IsSuccess { get; }
    }
}
