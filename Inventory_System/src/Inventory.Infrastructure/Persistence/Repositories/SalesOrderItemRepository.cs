using Inventory.Domain.Entities;
using Inventory.Domain.Interfaces.Repositories;
using Inventory.Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace Inventory.Infrastructure.Persistence.Repositories
{
    public class SalesOrderItemRepository : ISalesOrderItemRepository
    {
        private readonly ApplicationDbContext _context;
        public SalesOrderItemRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(SalesOrderItem salesOrderItem)
        {
            await _context.SalesOrderItems.AddAsync(salesOrderItem);
        }

        public void Delete(SalesOrderItem salesOrderItem)
        {
            _context.SalesOrderItems.Remove(salesOrderItem);
        }

        public async Task<IEnumerable<SalesOrderItem>> GetAllAsync()
        {
            return await _context.SalesOrderItems.Include(x => x.SalesOrder).Include(x => x.Product).ToListAsync();
        }

        public Task<SalesOrderItem?> GetByIdAsync(Guid id)
        {
            return _context.SalesOrderItems.Include(x => x.SalesOrder).Include(x => x.Product).FirstOrDefaultAsync(x => x.Id == id);
        }

        public void Update(SalesOrderItem salesOrderItem)
        {
            _context.SalesOrderItems.Update(salesOrderItem);
        }
    }
}
