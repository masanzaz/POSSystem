using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using POSSystem.API.Dtos.Customer;
using POSSystem.Domain.Interfaces;
using POSSystem.Domain.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace POSSystem.API.Controllers
{
    [Route("api/[controller]")]
    public class CustomersController : MainController
    {
        private readonly ICustomerService _customeryService;
        private readonly IMapper _mapper;

        public CustomersController(IMapper mapper,
                                    ICustomerService customeryService)
        {
            _mapper = mapper;
            _customeryService = customeryService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var categories = await _customeryService.GetAll();

            return Ok(_mapper.Map<IEnumerable<CustomerResultDto>>(categories));
        }

        [HttpGet("{id:Guid}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var customer = await _customeryService.GetById(id);
             
            if (customer == null) return NotFound();

            return Ok(_mapper.Map<CustomerResultDto>(customer));
        }

        [HttpPost]
        public async Task<IActionResult> Add(CustomerAddDto customerAdd)
        {
            if (!ModelState.IsValid) return BadRequest();

            var customer = _mapper.Map<Customer>(customerAdd);
            var customerResult = await _customeryService.Add(customer);

            if (customerResult == null) return BadRequest();

            return Ok(_mapper.Map<CustomerAddDto>(customerResult));
        }

        [HttpPut("{id:Guid}")]
        public async Task<IActionResult> Update(Guid id, CustomerEditDto customerDto)
        {
            if (id != customerDto.Id) return BadRequest();

            if (!ModelState.IsValid) return BadRequest();

            await _customeryService.Update(_mapper.Map<Customer>(customerDto));

            return Ok(customerDto);
        }

        [HttpDelete("{id:Guid}")]
        public async Task<IActionResult> Remove(Guid id)
        {
            var customer = await _customeryService.GetById(id);
            if (customer == null) return NotFound();

            var result = await _customeryService.Remove(customer);

            if (!result) return BadRequest();

            return Ok();
        }

        [Route("search/{customer}")]
        [HttpGet]
        public async Task<ActionResult<List<CustomerResultDto>>> Search(string customer)
        {
            var customers = _mapper.Map<List<CustomerResultDto>>(await _customeryService.Search(customer));

            if (customers == null || customers.Count == 0)
                return NotFound("None customer was founded");

            return Ok(customers);
        }
    }
}