using POSSystem.Domain.Interfaces;
using POSSystem.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace POSSystem.Domain.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IProductRepository _productRepository;

        public OrderService(IOrderRepository orderRepository, IProductRepository productRepository)
        {
            _orderRepository = orderRepository;
            _productRepository = productRepository;
        }

        public async Task<IEnumerable<Order>> GetAll()
        {
            return await _orderRepository.GetAll();
        }

        public async Task<Order> GetById(Guid id)
        {
            return await _orderRepository.GetById(id);
        }

        public async Task<Order> Add(Order order)
        {
            if (order.orderDetails?.Count() <= 0)
                return null;

            if (_orderRepository.Search(b => b.Codigo == order.Codigo).Result.Any())
                return null;

            GetTotal(order.orderDetails);

            await _orderRepository.Add(order);
            return order;
        }

        public async Task<Order> Update(Order order)
        {
            if (!_orderRepository.Search(b => b.Id != order.Id).Result.Any())
                return null;

            GetTotal(order.orderDetails);

            await _orderRepository.Update(order);
            return order;
        }

        public async Task<bool> Remove(Order order)
        {
            await _orderRepository.Remove(order);
            return true;
        }

        public async Task<IEnumerable<Order>> GetOrdersByCustomerId(Guid customerId)
        {
            return await _orderRepository.GetOrdersByCustomerId(customerId);
        }

        public async Task<IEnumerable<Order>> GetOrdersByDate(DateTime orderDate)
        {
            return await _orderRepository.GetOrdersByDate(orderDate);
        }

        public void Dispose()
        {
            _orderRepository?.Dispose();
        }

        public void GetTotal(IEnumerable<OrderDetail> details)
        {
            foreach (var detail in details)
            {
                var product = _productRepository.GetById(detail.ProductId)?.Result;
                detail.UnitPrice = product.Price;
                detail.Total = detail.UnitPrice * detail.Quantity - ((detail.Discount / 100) * detail.UnitPrice * detail.Quantity);
            }
        }
    }
}