using POSSystem.Domain.Interfaces;
using POSSystem.Domain.Models;
using POSSystem.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace POSSystem.Infrastructure.Repositories
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public CategoryRepository(POSDbContext context) : base(context) { }
    }
}
