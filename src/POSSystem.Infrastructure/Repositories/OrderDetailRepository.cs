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
    public class OrderDetailRepository : Repository<OrderDetail>, IOrderDetailRepository
    {
        public OrderDetailRepository(POSDbContext context) : base(context) { }

        public override async Task<OrderDetail> GetById(Guid id)
        {
            return await Db.OrderDetails.AsNoTracking().Include(b => b.product)
                .Where(b => b.Id == id)
                .FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<OrderDetail>> GetDetailsByOrderId(Guid orderId)
        {
            return await Db.OrderDetails.AsNoTracking().Include(b => b.order)
                .Where(b => b.OrderId == orderId)
                .ToListAsync();
        }


    }
}
