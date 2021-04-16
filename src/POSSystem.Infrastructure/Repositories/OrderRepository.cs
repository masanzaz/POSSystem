using Microsoft.EntityFrameworkCore;
using POSSystem.Domain.Interfaces;
using POSSystem.Domain.Models;
using POSSystem.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSSystem.Infrastructure.Repositories
{
    public class OrderRepository : Repository<Order>, IOrderRepository
    {
        public OrderRepository(POSDbContext context) : base(context) { }

        public override async Task<List<Order>> GetAll()
        {
            return await Db.Orders.AsNoTracking().Include(b => b.customer)
                .OrderByDescending(b => b.CreatedDate)
                .ToListAsync();
        }

        public override async Task<Order> GetById(Guid id)
        {
            return await Db.Orders.AsNoTracking().Include(b => b.paymentMethod)
                .Include(b => b.orderDetails).ThenInclude(p => p.product)
                .Where(b => b.Id == id)
                .FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Order>> GetOrdersByCustomerId(Guid customerId)
        {
            return await Db.Orders.AsNoTracking().Include(b => b.customer)
                .Where(b => b.CustomerId == customerId)
                .ToListAsync();
        }

        public async Task<IEnumerable<Order>> GetOrdersByDate(DateTime orderDate)
        {
            return await Db.Orders.AsNoTracking().Include(b => b.customer)
                .Where(b => b.OrderDate == orderDate)
                .ToListAsync();
        }
   
    }
}