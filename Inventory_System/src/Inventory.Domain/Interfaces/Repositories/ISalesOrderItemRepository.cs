using Inventory.Domain.Entities;

namespace Inventory.Domain.Interfaces.Repositories
{
    public interface ISalesOrderItemRepository
    {
        Task<SalesOrderItem?> GetByIdAsync(Guid id);

        Task<IEnumerable<SalesOrderItem>> GetAllAsync();

        Task AddAsync(SalesOrderItem salesOrderItem);

        void Update(SalesOrderItem salesOrderItem);

        void Delete(SalesOrderItem salesOrderItem);
    }
}
