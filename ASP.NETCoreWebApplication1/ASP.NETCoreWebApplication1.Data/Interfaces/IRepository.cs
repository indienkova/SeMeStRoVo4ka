﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace ASP.NETCoreWebApplication1.Data.Interfaces
{
    public interface IRepository<TEntity> where TEntity: class
    {
        IEnumerable<TEntity> GetAll();
        Task<TEntity> Get(int id);
        Task Add(TEntity entity);
        Task Delete(int id);
    }
}
