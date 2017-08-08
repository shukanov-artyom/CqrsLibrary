using System;
using System.Threading.Tasks;

namespace CqrsLibrary
{
    public interface IAsyncCommandHandler<TCommand>
        where TCommand : ICommand
    {
        Task<ICommandResult> ExecuteAsync(TCommand command);

        Task<ICommandResult> GetColdTask(TCommand command);
    }
}
