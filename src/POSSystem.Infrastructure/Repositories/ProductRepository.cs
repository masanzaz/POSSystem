using Microsoft.EntityFrameworkCore;
using POSSystem.Domain.Interfaces;
using POSSystem.Domain.Models;
using POSSystem.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSSystem.Infrastructure.Repositories
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(POSDbContext context) : base(context) { }

        public override async Task<List<Product>> GetAll()
        {
            return await Db.Products.AsNoTracking().Include(b => b.Category)
                .OrderBy(b => b.Name)
                .ToListAsync();
        }

        public override async Task<Product> GetById(Guid id)
        {
            return await Db.Products.AsNoTracking().Include(b => b.Category)
                .Where(b => b.Id == id)
                .FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Product>> GetProductsByCategory(Guid categoryId)
        {
            return await Search(b => b.CategoryId == categoryId);
        }

        public async Task<IEnumerable<Product>> SearchProductWithCategory(string searchedValue)
        {
            return await Db.Products.AsNoTracking()
                .Include(b => b.Category)
                .Where(b => b.Name.Contains(searchedValue) ||
                            b.Description.Contains(searchedValue) ||
                            b.Category.Name.Contains(searchedValue))
                .ToListAsync();
        }
    }
}