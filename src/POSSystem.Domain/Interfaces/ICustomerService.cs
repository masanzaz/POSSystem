using POSSystem.Domain.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace POSSystem.Domain.Interfaces
{
    public interface ICustomerService : IDisposable
    {
        Task<IEnumerable<Customer>> GetAll();
        Task<Customer> GetById(Guid id);
        Task<Customer> Add(Customer customer);
        Task<Customer> Update(Customer customer);
        Task<bool> Remove(Customer customer);
        Task<IEnumerable<Customer>> Search(string customer);
    }
}
