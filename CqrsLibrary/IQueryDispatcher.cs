using System;
using System.Threading.Tasks;

namespace CqrsLibrary
{
    public interface IQueryDispatcher
    {
        Task<IQueryResult> Submit<TQuery>(TQuery query)
            where TQuery : IQuery;
    }
}
