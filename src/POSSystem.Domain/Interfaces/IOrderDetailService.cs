using POSSystem.Domain.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace POSSystem.Domain.Interfaces
{
    public interface IOrderDetailService : IDisposable
    {
        Task<OrderDetail> GetById(Guid id);
        Task<OrderDetail> Add(OrderDetail orderDetail);
        Task<OrderDetail> Update(OrderDetail orderDetail);
        Task<bool> Remove(OrderDetail orderDetail);
        Task<IEnumerable<OrderDetail>> GetDetailsByOrderId(Guid orderId);
    }
}
