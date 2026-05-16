using Inventory.Domain.Common;
using Inventory.Domain.Enums;

namespace Inventory.Domain.Entities;

public class InventoryMovement : AuditableEntity
{
    public Guid ProductId { get; set; }

    public Product Product { get; set; } = null!;

    public Guid WarehouseId { get; set; }

    public Warehouse Warehouse { get; set; } = null!;

    public MovementType Type { get; set; }

    public int Quantity { get; set; }

    public int PreviousStock { get; set; }

    public int NewStock { get; set; }

    public string Reference { get; set; } = string.Empty;

    public Guid UserId { get; set; }

    public User User { get; set; } = null!;
}