using POSSystem.Domain.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace POSSystem.Domain.Interfaces
{
    public interface IOrderRepository : IRepository<Order>
    {
        new Task<List<Order>> GetAll();
        new Task<Order> GetById(Guid id);
        Task<IEnumerable<Order>> GetOrdersByCustomerId(Guid customerId);
        Task<IEnumerable<Order>> GetOrdersByDate(DateTime orderDate);
    }
}
