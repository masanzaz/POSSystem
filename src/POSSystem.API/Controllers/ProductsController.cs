using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using POSSystem.API.Dtos.Product;
using POSSystem.Domain.Interfaces;
using POSSystem.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POSSystem.API.Controllers
{
    [Route("api/[controller]")]
    public class ProductsController : MainController
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public ProductsController(IMapper mapper,
                                IProductService productService)
        {
            _mapper = mapper;
            _productService = productService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var products = await _productService.GetAll();

            return Ok(_mapper.Map<IEnumerable<ProductResultDto>>(products));
        }

        [HttpGet("{id:Guid}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var product = await _productService.GetById(id);

            if (product == null) return NotFound();

            return Ok(_mapper.Map<ProductResultDto>(product));
        }

        [HttpGet]
        [Route("get-products-by-category/{categoryId:Guid}")]
        public async Task<IActionResult> GetProductsByCategory(Guid categoryId)
        {
            var products = await _productService.GetProductsByCategory(categoryId);

            if (!products.Any()) return NotFound();

            return Ok(_mapper.Map<IEnumerable<ProductResultDto>>(products));
        }

        [HttpPost]
        public async Task<IActionResult> Add(ProductAddDto productDto)
        {
            if (!ModelState.IsValid) return BadRequest();

            var product = _mapper.Map<Product>(productDto);
            var productResult = await _productService.Add(product);

            if (productResult == null) return BadRequest();

            return Ok(_mapper.Map<ProductResultDto>(productResult));
        }

        [HttpPut("{id:Guid}")]
        public async Task<IActionResult> Update(Guid id, ProductEditDto productDto)
        {
            if (id != productDto.Id) return BadRequest();

            if (!ModelState.IsValid) return BadRequest();

            await _productService.Update(_mapper.Map<Product>(productDto));

            return Ok(productDto);
        }

        [HttpDelete("{id:Guid}")]
        public async Task<IActionResult> Remove(Guid id)
        {
            var product = await _productService.GetById(id);
            if (product == null) return NotFound();

            await _productService.Remove(product);

            return Ok();
        }

        [Route("search/{productName}")]
        [HttpGet]
        public async Task<ActionResult<List<ProductResultDto>>> Search(string productName)
        {
            var products = _mapper.Map<List<Product>>(await _productService.Search(productName));

            if (products == null || products.Count == 0) return NotFound("None product was founded");

            return Ok(_mapper.Map<IEnumerable<ProductResultDto>>(products));
        }

        [Route("search-product-with-category/{searchedValue}")]
        [HttpGet]
        public async Task<ActionResult<List<ProductResultDto>>> SearchProductWithCategory(string searchedValue)
        {
            var products = _mapper.Map<List<Product>>(await _productService.SearchProductWithCategory(searchedValue));

            if (!products.Any()) return NotFound("None product was founded");

            return Ok(_mapper.Map<IEnumerable<ProductResultDto>>(products));
        }
    }
}