using Inventory.Domain.Entities;

namespace Inventory.Domain.Interfaces.Repositories
{
    public interface IPurchaseOrderRepository
    {
        Task<PurchaseOrder?> GetByIdAsync(Guid id);

        Task<IEnumerable<PurchaseOrder>> GetAllAsync();

        Task AddAsync(PurchaseOrder purchaseOrder);

        void Update(PurchaseOrder purchaseOrder);

        void Delete(PurchaseOrder purchaseOrder);
    }
}
