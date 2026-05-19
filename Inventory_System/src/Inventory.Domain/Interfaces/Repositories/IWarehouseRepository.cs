using Inventory.Domain.Entities;

namespace Inventory.Domain.Interfaces.Repositories
{
    public interface IWarehouseRepository
    {
        Task<Warehouse?> GetByIdAsync(Guid id);

        Task<IEnumerable<Warehouse>> GetAllAsync();

        Task AddAsync(Warehouse warehouse);

        void Update(Warehouse warehouse);

        void Delete(Warehouse warehouse);
    }
}

