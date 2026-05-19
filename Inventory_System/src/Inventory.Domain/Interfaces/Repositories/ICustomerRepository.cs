using Inventory.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Domain.Interfaces.Repositories
{
    public interface ICustomerRepository
    {
        Task<Customer?> GetByIdAsync(Guid id);

        Task<IEnumerable<Customer>> GetAllAsync();

        Task AddAsync(Customer customer);

        void Update(Customer customer);

        void Delete(Customer customer);
    }
}
