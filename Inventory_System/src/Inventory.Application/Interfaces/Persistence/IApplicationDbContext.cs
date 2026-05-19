using Inventory.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Inventory.Application.Interfaces.Persistence;

public interface IApplicationDbContext
{
    DbSet<Category> Categories { get; }

    DbSet<Product> Products { get; }

    DbSet<Warehouse> Warehouses { get; }

    DbSet<User> Users { get; }

    DbSet<Role> Roles { get; }

    DbSet<InventoryMovement> InventoryMovements { get; }
    DbSet<Supplier> Suppliers { get; }
    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}