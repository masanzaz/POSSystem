using POSSystem.Domain.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace POSSystem.Domain.Interfaces
{
    public interface IOrderDetailRepository : IRepository<OrderDetail>
    {
        new Task<OrderDetail> GetById(Guid id);
        Task<IEnumerable<OrderDetail>> GetDetailsByOrderId(Guid orderId);
    }
}
