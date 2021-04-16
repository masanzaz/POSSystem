using POSSystem.Domain.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace POSSystem.Domain.Interfaces
{
    public interface IPaymentMethodService : IDisposable
    {
        Task<IEnumerable<PaymentMethod>> GetAll();
        Task<PaymentMethod> GetById(Guid id);
        Task<PaymentMethod> Add(PaymentMethod payment);
        Task<PaymentMethod> Update(PaymentMethod payment);
        Task<bool> Remove(PaymentMethod payment);
        Task<IEnumerable<PaymentMethod>> Search(string paymentName);
    }
}
