using Inventory.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Domain.Interfaces.Repositories
{
    public interface IInventoryMovementRepository
    {
        Task AddAsync(InventoryMovement movement);

        Task<IEnumerable<InventoryMovement>> GetByProductIdAsync(Guid productId);
    }
}
