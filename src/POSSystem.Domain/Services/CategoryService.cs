using POSSystem.Domain.Interfaces;
using POSSystem.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POSSystem.Domain.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IProductService _productService;

        public CategoryService(ICategoryRepository categoryRepository, IProductService productService)
        {
            _categoryRepository = categoryRepository;
            _productService = productService;
        }

        public async Task<IEnumerable<Category>> GetAll()
        {
            return await _categoryRepository.GetAll();
        }

        public async Task<Category> GetById(Guid id)
        {
            return await _categoryRepository.GetById(id);
        }

        public async Task<Category> Add(Category category)
        {
            if (_categoryRepository.Search(c => c.Name == category.Name).Result.Any())
                return null;

            await _categoryRepository.Add(category);
            return category;
        }

        public async Task<Category> Update(Category category)
        {
            if (_categoryRepository.Search(c => c.Name == category.Name && c.Id != category.Id).Result.Any())
                return null;

            await _categoryRepository.Update(category);
            return category;
        }

        public async Task<bool> Remove(Category category)
        {
            var categories = await _productService.GetProductsByCategory(category.Id);
            if (categories.Any()) return false;

            await _categoryRepository.Remove(category);
            return true;
        }

        public async Task<IEnumerable<Category>> Search(string categoryName)
        {
            return await _categoryRepository.Search(c => c.Name.Contains(categoryName));
        }

        public void Dispose()
        {
            _categoryRepository?.Dispose();
        }
    }
}