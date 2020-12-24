using System;
using System.Threading.Tasks;
using AspNetDocker.Model;
using Microsoft.EntityFrameworkCore;

namespace AspNetDocker.InfraData
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly DataContext _context;

        public CustomerRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<Guid> AddAsync(Customer customer)
        {
            var newCustomer = _context.Customers.Add(customer).Entity;
            await _context.SaveChangesAsync();
            return newCustomer.Id;
        }

        public async Task<Guid> DeleteAsync(Guid id)
        {
            var customer = await _context.Customers.FindAsync(id);
            _context.Customers.Remove(customer);
            await _context.SaveChangesAsync();
            return id;
        }

        public async Task<Customer> GetAsync(Guid id)
        {
            return await _context.Customers.FindAsync(id);
        }

        public async Task<Guid> UpdateAsync(Customer customer)
        {
            _context.Entry<Customer>(customer).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return customer.Id;
        }
    }
}