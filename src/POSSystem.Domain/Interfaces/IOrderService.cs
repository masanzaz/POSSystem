using POSSystem.Domain.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace POSSystem.Domain.Interfaces
{
    public interface IOrderService : IDisposable
    {
        Task<IEnumerable<Order>> GetAll();
        Task<Order> GetById(Guid id);
        Task<Order> Add(Order order);
        Task<Order> Update(Order order);
        Task<bool> Remove(Order order);
        Task<IEnumerable<Order>> GetOrdersByCustomerId(Guid customerId);
        Task<IEnumerable<Order>> GetOrdersByDate(DateTime orderDate);
    }
}
