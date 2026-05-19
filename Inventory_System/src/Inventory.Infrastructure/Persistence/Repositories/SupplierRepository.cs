using Inventory.Domain.Entities;
using Inventory.Domain.Interfaces.Repositories;
using Inventory.Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace Inventory.Infrastructure.Persistence.Repositories
{
    public class SupplierRepository : ISupplierRepository
    {
        private ApplicationDbContext _context;
        public SupplierRepository(ApplicationDbContext context) 
        {
            _context = context;
        }
        public async Task AddAsync(Supplier supplier)
        {
            await _context.Suppliers.AddAsync(supplier);
        }

        public async Task<IEnumerable<Supplier>> GetAllAsync()
        {
            return await _context.Suppliers.ToListAsync();
        }

        public async Task<Supplier?> GetByIdAsync(Guid id)
        {
            return await _context.Suppliers.FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
