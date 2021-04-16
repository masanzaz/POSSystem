using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using POSSystem.API.Dtos.Order;
using POSSystem.Domain.Interfaces;
using POSSystem.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POSSystem.API.Controllers
{
    [Route("api/[controller]")]
    public class OrdersController : MainController
    {
        private readonly IOrderService _orderService;
        private readonly IMapper _mapper;

        public OrdersController(IMapper mapper,
                        IOrderService orderService)
        {
            _mapper = mapper;
            _orderService = orderService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var orders = await _orderService.GetAll();

            return Ok(_mapper.Map<IEnumerable<OrderResultDto>>(orders));
        }

        [HttpGet("{id:Guid}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var order = await _orderService.GetById(id);

            if (order == null) return NotFound();

            return Ok(_mapper.Map<OrderResultDto>(order));
        }

        [HttpPost]
        public async Task<IActionResult> Add(OrderAddDto orderAddDto)
        {
            if (!ModelState.IsValid) return BadRequest();

            var order = _mapper.Map<Order>(orderAddDto);
            var orderResult = await _orderService.Add(order);

            if (orderResult == null) return BadRequest();

            return Ok(_mapper.Map<OrderAddDto>(orderResult));
        }

        [HttpPut("{id:Guid}")]
        public async Task<IActionResult> Update(Guid id, OrderEditDto orderEditDto)
        {
            if (id != orderEditDto.Id) return BadRequest();

            if (!ModelState.IsValid) return BadRequest();
            try
            {
                await _orderService.Update(_mapper.Map<Order>(orderEditDto));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            return Ok(orderEditDto);
        }

        [HttpDelete("{id:Guid}")]
        public async Task<IActionResult> Remove(Guid id)
        {
            var order = await _orderService.GetById(id);
            if (order == null) return NotFound();

            await _orderService.Remove(order);

            return Ok();
        }

        [Route("search/{customerId}")]
        [HttpGet]
        public async Task<ActionResult<List<OrderResultDto>>> GetOrdersByCustomerId(Guid customerId)
        {
            var orders = _mapper.Map<List<Order>>(await _orderService.GetOrdersByCustomerId(customerId));

            if (orders == null || orders.Count == 0) return NotFound("None order was founded");

            return Ok(_mapper.Map<IEnumerable<OrderResultDto>>(orders));
        }

        [Route("search/{orderDate}")]
        [HttpGet]
        public async Task<ActionResult<List<OrderResultDto>>> GetOrdersByDate(DateTime orderDate)
        {
            var orders = _mapper.Map<List<Order>>(await _orderService.GetOrdersByDate(orderDate));

            if (orders == null || orders.Count == 0) return NotFound("None order was founded");

            return Ok(_mapper.Map<IEnumerable<OrderResultDto>>(orders));
        }

    }
}