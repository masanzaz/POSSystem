using POSSystem.Domain.Interfaces;
using POSSystem.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POSSystem.Domain.Services
{
    public class PaymentMethodService : IPaymentMethodService
    {
        private readonly IPaymentMethodRepositoy _paymentMethodRepositoy;

        public PaymentMethodService(IPaymentMethodRepositoy paymentMethodRepositoy)
        {
            _paymentMethodRepositoy = paymentMethodRepositoy;
        }

        public async Task<IEnumerable<PaymentMethod>> GetAll()
        {
            return await _paymentMethodRepositoy.GetAll();
        }

        public async Task<PaymentMethod> GetById(Guid id)
        {
            return await _paymentMethodRepositoy.GetById(id);
        }

        public async Task<PaymentMethod> Add(PaymentMethod payment)
        {
            if (_paymentMethodRepositoy.Search(c => c.Name == payment.Name).Result.Any())
                return null;

            await _paymentMethodRepositoy.Add(payment);
            return payment;
        }

        public async Task<PaymentMethod> Update(PaymentMethod payment)
        {
            if (_paymentMethodRepositoy.Search(c => c.Name == payment.Name && c.Id != payment.Id).Result.Any())
                return null;

            await _paymentMethodRepositoy.Update(payment);
            return payment;
        }

        public async Task<bool> Remove(PaymentMethod payment)
        {
            await _paymentMethodRepositoy.Remove(payment);
            return true;
        }

        public async Task<IEnumerable<PaymentMethod>> Search(string paymentName)
        {
            return await _paymentMethodRepositoy.Search(c => c.Name.Contains(paymentName));
        }

        public void Dispose()
        {
            _paymentMethodRepositoy?.Dispose();
        }
    }
}