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
        Task<Product> Add(Product product);
        Task<Product> Update(Product product);
        Task<bool> Remove(Product product);
        Task<IEnumerable<Product>> GetProductsByCategory(Guid categoryId);
        Task<IEnumerable<Product>> Search(string productName);
        Task<IEnumerable<Product>> SearchProductWithCategory(string searchedValue);
    }
}
