using Inventory.Domain.Entities;
using Inventory.Domain.Interfaces.Repositories;
using Inventory.Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace Inventory.Infrastructure.Persistence.Repositories
{
    public class InventoryMovementRepository : IInventoryMovementRepository
    {
        private readonly ApplicationDbContext _context;
        private InventoryMovementRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task AddAsync(InventoryMovement movement)
        {
            await _context.InventoryMovements.AddAsync(movement);
        }

        public async Task<IEnumerable<InventoryMovement>> GetByProductIdAsync(Guid productId)
        {
            return await _context.InventoryMovements.Where(x => x.ProductId == productId).OrderByDescending(x => x.CreatedAt).ToListAsync();
        }
    }
}
