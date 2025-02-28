﻿using POSSystem.Domain.Interfaces;
using POSSystem.Domain.Models;
using POSSystem.Infrastructure.Context;

namespace POSSystem.Infrastructure.Repositories
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public CategoryRepository(POSDbContext context) : base(context) { }
    }
}
