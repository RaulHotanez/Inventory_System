using Inventory.Domain.Entities;
using Inventory.Domain.Interfaces.Repositories;
using Inventory.Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace Inventory.Infrastructure.Persistence.Repositories
{
    public class PurchaseOrderItemRepository : IPurchaseOrderItemRepository
    {
        private readonly ApplicationDbContext _context;
        public PurchaseOrderItemRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task AddAsync(PurchaseOrderItem purchaseOrderItem)
        {
            await _context.PurchaseOrderItems.AddAsync(purchaseOrderItem);
        }

        public void Delete(PurchaseOrderItem purchaseOrderItem)
        {
            _context.PurchaseOrderItems.Remove(purchaseOrderItem);
        }

        public async Task<IEnumerable<PurchaseOrderItem>> GetAllAsync()
        {
            return await _context.PurchaseOrderItems.ToListAsync();
        }

        public async Task<PurchaseOrderItem?> GetByIdAsync(Guid id)
        {
            return await _context.PurchaseOrderItems.FirstOrDefaultAsync(x => x.Id == id);
        }

        public void Update(PurchaseOrderItem purchaseOrderItem)
        {
            _context.PurchaseOrderItems.Update(purchaseOrderItem);
        }
    }
}
