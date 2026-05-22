using Inventory.Domain.Enums;

namespace Inventory.Application.Features.PurchaseOrders.DTOs
{
    public class PurchaseOrderDto
    {
        public Guid Id { get; set; }

        public string Supplier { get; set; } = string.Empty;

        public decimal Total { get; set; }

        public OrderStatus Status { get; set; }
    }
}
