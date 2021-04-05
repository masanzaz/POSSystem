using POSSystem.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace POSSystem.Domain.Interfaces
{
    public interface IRepository<TEntity> : IDisposable where TEntity : EntityEf<Guid>
    {
        Task Add(TEntity entity);
        Task<List<TEntity>> GetAll();
        Task<TEntity> GetById(Guid id);
        Task Update(TEntity entity);
        Task Remove(TEntity entity);
        Task<IEnumerable<TEntity>> Search(Expression<Func<TEntity, bool>> predicate);
        Task<int> SaveChanges();
    }
}
