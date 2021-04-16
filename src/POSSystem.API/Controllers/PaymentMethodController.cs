using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using POSSystem.API.Dtos.PaymentMethod;
using POSSystem.Domain.Interfaces;
using POSSystem.Domain.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace POSSystem.API.Controllers
{
    [Route("api/[controller]")]
    public class PaymentMethodController : MainController
    {
        private readonly IPaymentMethodService _paymentMethodService;
        private readonly IMapper _mapper;

        public PaymentMethodController(IMapper mapper,
                                    IPaymentMethodService paymentMethodService)
        {
            _mapper = mapper;
            _paymentMethodService = paymentMethodService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var paymentMethods = await _paymentMethodService.GetAll();

            return Ok(_mapper.Map<IEnumerable<PaymentResultDto>>(paymentMethods));
        }

        [HttpGet("{id:Guid}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var paymentMethod = await _paymentMethodService.GetById(id);

            if (paymentMethod == null) return NotFound();

            return Ok(_mapper.Map<PaymentResultDto>(paymentMethod));
        }

        [HttpPost]
        public async Task<IActionResult> Add(PaymentAddDto paymentAddDto)
        {
            if (!ModelState.IsValid) return BadRequest();

            var payment = _mapper.Map<PaymentMethod>(paymentAddDto);
            var paymentMethodResult = await _paymentMethodService.Add(payment);

            if (paymentMethodResult == null) return BadRequest();

            return Ok(_mapper.Map<PaymentResultDto>(paymentMethodResult));
        }

        [HttpPut("{id:Guid}")]
        public async Task<IActionResult> Update(Guid id, PaymentEditDto paymentEditDto)
        {
            if (id != paymentEditDto.Id) return BadRequest();

            if (!ModelState.IsValid) return BadRequest();

            await _paymentMethodService.Update(_mapper.Map<PaymentMethod>(paymentEditDto));

            return Ok(paymentEditDto);
        }

        [HttpDelete("{id:Guid}")]
        public async Task<IActionResult> Remove(Guid id)
        {
            var paymentMethod = await _paymentMethodService.GetById(id);
            if (paymentMethod == null) return NotFound();

            var result = await _paymentMethodService.Remove(paymentMethod);

            if (!result) return BadRequest();

            return Ok();
        }

        [Route("search/{paymentMethod}")]
        [HttpGet]
        public async Task<ActionResult<List<PaymentResultDto>>> Search(string paymentMethod)
        {
            var paymentResults = _mapper.Map<List<PaymentResultDto>>(await _paymentMethodService.Search(paymentMethod));

            if (paymentResults == null || paymentResults.Count == 0)
                return NotFound("None payment was founded");

            return Ok(paymentResults);
        }
    }
}