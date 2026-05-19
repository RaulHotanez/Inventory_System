using Inventory.Domain.Common;
using Inventory.Domain.Enums;

namespace Inventory.Domain.Entities
{
    public class PurchaseOrder : AuditableEntity
    {
        public Guid SupplierId { get; set; }

        public Supplier Supplier { get; set; } = null!;

        public decimal Total { get; set; }

        public OrderStatus Status { get; set; }

        public ICollection<PurchaseOrderItem> Items { get; set; }
            = new List<PurchaseOrderItem>();
    }
}
