using System;
using System.Threading.Tasks;

namespace CqrsLibrary
{
    /// <summary>
    /// Asynchronous command handler interface.
    /// </summary>
    /// <typeparam name="TCommand"></typeparam>
    public interface IAsyncCommandHandler<in TCommand>
        where TCommand : ICommand
    {
        Task<ICommandResult> ExecuteAsync(TCommand command);

        Task<ICommandResult> GetColdTask(TCommand command);
    }
}
