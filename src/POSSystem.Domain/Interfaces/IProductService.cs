using POSSystem.Domain.Models;
using System;
using System.Collections.Generic;

using System.Threading.Tasks;

namespace POSSystem.Domain.Interfaces
{
    public interface IProductService : IDisposable
    {
        Task<IEnumerable<Product>> GetAll();
        Task<Product> GetById(Guid id);
        Task<Product> Add(Product book);
        Task<Product> Update(Product book);
        Task<bool> Remove(Product book);
        Task<IEnumerable<Product>> GetProductsByCategory(Guid categoryId);
        Task<IEnumerable<Product>> Search(string bookName);
        Task<IEnumerable<Product>> SearchProductWithCategory(string searchedValue);
    }
}
