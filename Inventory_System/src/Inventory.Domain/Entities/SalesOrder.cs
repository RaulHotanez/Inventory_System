using Inventory.Domain.Common;
using Inventory.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Domain.Entities
{
    public class SalesOrder : AuditableEntity
    {
        public Guid CustomerId { get; set; }

        public Customer Customer { get; set; } = null!;

        public decimal Total { get; set; }

        public OrderStatus Status { get; set; }

        public ICollection<SalesOrderItem> Items { get; set; }
            = new List<SalesOrderItem>();
    }
}
