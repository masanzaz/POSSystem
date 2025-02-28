﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using POSSystem.API.Dtos.Category;
using POSSystem.Domain.Interfaces;
using POSSystem.Domain.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace POSSystem.API.Controllers
{
    [Route("api/[controller]")]
    public class CategoriesController : MainController
    {
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;

        public CategoriesController(IMapper mapper,
                                    ICategoryService categoryService)
        {
            _mapper = mapper;
            _categoryService = categoryService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var categories = await _categoryService.GetAll();

            return Ok(_mapper.Map<IEnumerable<CategoryResultDto>>(categories));
        }

        [HttpGet("{id:Guid}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var category = await _categoryService.GetById(id);

            if (category == null) return NotFound();

            return Ok(_mapper.Map<CategoryResultDto>(category));
        }

        [HttpPost]
        public async Task<IActionResult> Add(CategoryAddDto categoryDto)
        {
            if (!ModelState.IsValid) return BadRequest();

            var category = _mapper.Map<Category>(categoryDto);
            var categoryResult = await _categoryService.Add(category);

            if (categoryResult == null) return BadRequest();

            return Ok(_mapper.Map<CategoryResultDto>(categoryResult));
        }

        [HttpPut("{id:Guid}")]
        public async Task<IActionResult> Update(Guid id, CategoryEditDto categoryDto)
        {
            if (id != categoryDto.Id) return BadRequest();

            if (!ModelState.IsValid) return BadRequest();

            await _categoryService.Update(_mapper.Map<Category>(categoryDto));

            return Ok(categoryDto);
        }

        [HttpDelete("{id:Guid}")]
        public async Task<IActionResult> Remove(Guid id)
        {
            var category = await _categoryService.GetById(id);
            if (category == null) return NotFound();

            var result = await _categoryService.Remove(category);

            if (!result) return BadRequest();

            return Ok();
        }

        [Route("search/{category}")]
        [HttpGet]
        public async Task<ActionResult<List<CategoryResultDto>>> Search(string category)
        {
            var categories = _mapper.Map<List<CategoryResultDto>>(await _categoryService.Search(category));

            if (categories == null || categories.Count == 0)
                return NotFound("None category was founded");

            return Ok(categories);
        }
    }
}