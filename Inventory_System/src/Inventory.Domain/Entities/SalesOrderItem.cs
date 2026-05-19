using Inventory.Domain.Common;

namespace Inventory.Domain.Entities
{
    public class SalesOrderItem : AuditableEntity
    {
        public Guid SalesOrderId { get; set; }

        public SalesOrder SalesOrder { get; set; } = null!;

        public Guid ProductId { get; set; }

        public Product Product { get; set; } = null!;

        public int Quantity { get; set; }

        public decimal Price { get; set; }
    }
}
