using POSSystem.Domain.Interfaces;
using POSSystem.Domain.Models;
using POSSystem.Infrastructure.Context;

namespace POSSystem.Infrastructure.Repositories
{
    public class PaymentMethodRepositoy : Repository<PaymentMethod>, IPaymentMethodRepositoy
    {
        public PaymentMethodRepositoy(POSDbContext context) : base(context) { }
    }
}
