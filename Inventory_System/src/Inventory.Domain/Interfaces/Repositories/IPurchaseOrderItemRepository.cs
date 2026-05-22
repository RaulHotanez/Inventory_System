
using Inventory.Domain.Entities;

namespace Inventory.Domain.Interfaces.Repositories
{
    public interface IPurchaseOrderItemRepository
    {
        Task<PurchaseOrderItem?> GetByIdAsync(Guid id);

        Task<IEnumerable<PurchaseOrderItem>> GetAllAsync();

        Task AddAsync(PurchaseOrderItem purchaseOrderItem);

        void Update(PurchaseOrderItem purchaseOrderItem);

        void Delete(PurchaseOrderItem purchaseOrderItem);
    }
}
