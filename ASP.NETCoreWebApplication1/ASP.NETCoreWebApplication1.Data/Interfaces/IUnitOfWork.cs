using System;
using System.Threading.Tasks;

namespace ASP.NETCoreWebApplication1.Data.Interfaces
{
    public interface IUnitOfWork : IAsyncDisposable
    {
        Task<int> CompleteAsync();
    }
}
