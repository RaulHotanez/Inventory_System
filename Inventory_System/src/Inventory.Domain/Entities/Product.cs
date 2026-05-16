using Inventory.Domain.Common;

namespace Inventory.Domain.Entities;

public class Product : AuditableEntity
{
    public string SKU { get; set; } = string.Empty;

    public string Name { get; set; } = string.Empty;

    public string? Description { get; set; }

    public decimal Price { get; set; }

    public decimal Cost { get; set; }

    public int Stock { get; set; }

    public bool IsActive { get; set; } = true;

    public Guid CategoryId { get; set; }

    public Category Category { get; set; } = null!;

    public ICollection<InventoryMovement> InventoryMovements { get; set; }
        = new List<InventoryMovement>();
}