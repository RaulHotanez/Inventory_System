using Inventory.Domain.Common;

namespace Inventory.Domain.Entities
{
    public class PurchaseOrderItem : AuditableEntity
    {
        public Guid PurchaseOrderId { get; set; }

        public PurchaseOrder PurchaseOrder { get; set; } = null!;

        public Guid ProductId { get; set; }

        public Product Product { get; set; } = null!;

        public int Quantity { get; set; }

        public decimal Price { get; set; }
    }
}
