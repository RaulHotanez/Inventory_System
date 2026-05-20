using Inventory.Domain.Common;

namespace Inventory.Domain.Entities
{
    public class Customer : AuditableEntity
    {
        public string Name { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string Phone { get; set; } = string.Empty;

        public ICollection<SalesOrder> SalesOrders { get; set; } = new List<SalesOrder>();
    }
}
