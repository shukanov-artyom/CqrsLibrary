using System;
using System.Threading.Tasks;

namespace CqrsLibrary
{
    public interface ICommandDispatcher
    {
        Task<ICommandResult> Submit<TCommand>(TCommand command)
            where TCommand : ICommand;
    }
}
