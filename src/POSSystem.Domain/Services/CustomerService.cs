using POSSystem.Domain.Interfaces;
using POSSystem.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace POSSystem.Domain.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public async Task<IEnumerable<Customer>> GetAll()
        {
            return await _customerRepository.GetAll();
        }

        public async Task<Customer> GetById(Guid id)
        {
            return await _customerRepository.GetById(id);
        }

        public async Task<Customer> Add(Customer customer)
        {
            if (_customerRepository.Search(c => c.Identification == customer.Identification).Result.Any())
                return null;

            await _customerRepository.Add(customer);
            return customer;
        }

        public async Task<Customer> Update(Customer customer)
        {
            if (_customerRepository.Search(c => c.Identification == customer.Identification && c.Id != customer.Id).Result.Any())
                return null;

            await _customerRepository.Update(customer);
            return customer;
        }

        public async Task<bool> Remove(Customer customer)
        {
            await _customerRepository.Remove(customer);
            return true;
        }

        public async Task<IEnumerable<Customer>> Search(string categoryName)
        {
            return await _customerRepository.Search(c => c.FirstName.Contains(categoryName));
        }

        public void Dispose()
        {
            _customerRepository?.Dispose();
        }
    }
}