using POSSystem.Domain.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace POSSystem.Domain.Interfaces
{

    public interface IProductRepository : IRepository<Product>
    {
        new Task<List<Product>> GetAll();
        new Task<Product> GetById(Guid id);
        Task<IEnumerable<Product>> GetProductsByCategory(Guid categoryId);
        Task<IEnumerable<Product>> SearchProductWithCategory(string searchedValue);
    }
}
