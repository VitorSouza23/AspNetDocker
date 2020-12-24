using System;
using System.Threading.Tasks;

namespace AspNetDocker.Model
{
    public interface ICustomerRepository
    {
        Task<Guid> AddAsync(Customer customer);
        Task<Customer> GetAsync(Guid id);
        Task<Guid> UpdateAsync(Customer customer);
        Task<Guid> DeleteAsync(Guid id);
    }
}