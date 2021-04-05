using POSSystem.Domain.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace POSSystem.Domain.Interfaces
{
    public interface ICategoryService : IDisposable
    {
        Task<IEnumerable<Category>> GetAll();
        Task<Category> GetById(Guid id);
        Task<Category> Add(Category category);
        Task<Category> Update(Category category);
        Task<bool> Remove(Category category);
        Task<IEnumerable<Category>> Search(string categoryName);
    }
}
