using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NETCoreWebApplication1.Interfaces
{
    public interface IUnitOfWork : IAsyncDisposable
    {
        Task<int> CompleteAsync();
    }
}
