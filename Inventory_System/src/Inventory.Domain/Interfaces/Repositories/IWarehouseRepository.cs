using Inventory.Domain.Common;
using Inventory.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Domain.Interfaces.Repositories
{
    public interface IWarehouseRepository
    {
        Task<Warehouse?> GetByIdAsync(Guid id);

        Task<IEnumerable<Warehouse>> GetAllAsync();

        Task AddAsync(Warehouse warehouse);

        void Update(Warehouse warehouse);

        void Delete(Warehouse warehouse);
    }
}

