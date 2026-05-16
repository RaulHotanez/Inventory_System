using Inventory.Domain.Common;
using Inventory.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
