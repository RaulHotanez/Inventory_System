
using Inventory.Domain.Entities;
using Inventory.Domain.Interfaces.Repositories;
using Inventory.Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace Inventory.Infrastructure.Persistence.Repositories
{
    public class SalesOrderRepository : ISalesOrderRepository
    {
        private readonly ApplicationDbContext _context;
        public SalesOrderRepository(ApplicationDbContext context) 
        {
            _context = context;
        }
        public async Task AddAsync(SalesOrder salesOrder)
        {
            await _context.SalesOrders.AddAsync(salesOrder);
        }

        public void Delete(SalesOrder salesOrder)
        {
             _context.SalesOrders.Remove(salesOrder);
        }

        public async Task<IEnumerable<SalesOrder>> GetAllAsync()
        {
            return await _context.SalesOrders.ToListAsync();
        }

        public async Task<SalesOrder?> GetByIdAsync(Guid id)
        {
            return await _context.SalesOrders.FirstOrDefaultAsync(x=>x.Id==id);
        }

        public void Update(SalesOrder salesOrder)
        {
            _context.SalesOrders.Update(salesOrder);
        }
    }
}
