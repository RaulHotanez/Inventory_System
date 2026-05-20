using Inventory.Domain.Entities;

namespace Inventory.Domain.Interfaces.Repositories
{
    public interface ISalesOrderRepository
    {
        Task<SalesOrder?> GetByIdAsync(Guid id);

        Task<IEnumerable<SalesOrder>> GetAllAsync();

        Task AddAsync(SalesOrder salesOrder);

        void Update(SalesOrder salesOrder);

        void Delete(SalesOrder salesOrder);
    }
}
