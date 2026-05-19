using Inventory.Domain.Entities;

namespace Inventory.Domain.Interfaces.Repositories
{
    public interface ISupplierRepository
    {
        Task<Supplier?> GetByIdAsync(Guid id);

        Task<IEnumerable<Supplier>> GetAllAsync();

        Task AddAsync(Supplier supplier);
    }
}
