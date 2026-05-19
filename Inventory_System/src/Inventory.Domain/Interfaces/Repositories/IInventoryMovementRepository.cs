using Inventory.Domain.Entities;

namespace Inventory.Domain.Interfaces.Repositories
{
    public interface IInventoryMovementRepository
    {
        Task AddAsync(InventoryMovement movement);

        Task<IEnumerable<InventoryMovement>> GetByProductIdAsync(Guid productId);
    }
}
