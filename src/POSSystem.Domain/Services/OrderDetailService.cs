using POSSystem.Domain.Interfaces;
using POSSystem.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POSSystem.Domain.Services
{
    public class OrderDetailService : IOrderDetailService
    {
        private readonly IOrderDetailRepository _orderDetailRepository;

        public OrderDetailService(IOrderDetailRepository orderDetailRepository)
        {
            _orderDetailRepository = orderDetailRepository;
        }

        public async Task<OrderDetail> GetById(Guid id)
        {
            return await _orderDetailRepository.GetById(id);
        }

        public async Task<OrderDetail> Add(OrderDetail orderDetail)
        {
            await _orderDetailRepository.Add(orderDetail);
            return orderDetail;
        }

        public async Task<OrderDetail> Update(OrderDetail orderDetail)
        {
            if (_orderDetailRepository.Search(b => b.Id != orderDetail.Id).Result.Any())
                return null;

            await _orderDetailRepository.Update(orderDetail);
            return orderDetail;
        }

        public async Task<bool> Remove(OrderDetail orderDetail)
        {
            await _orderDetailRepository.Remove(orderDetail);
            return true;
        }

        public async Task<IEnumerable<OrderDetail>> GetDetailsByOrderId(Guid orderId)
        {
            return await _orderDetailRepository.GetDetailsByOrderId(orderId);
        }

        public void Dispose()
        {
            _orderDetailRepository?.Dispose();
        }
    }
}