using System;

namespace CqrsLibrary
{
    /// <summary>
    /// CQRS Command interface
    /// </summary>
    public interface ICommand
    {
        ICommandResult Execute(ICommandContext commandContext);
    }
}
