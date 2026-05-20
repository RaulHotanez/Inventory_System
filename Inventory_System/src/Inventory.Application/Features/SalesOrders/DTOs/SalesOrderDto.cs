using Inventory.Domain.Enums;

namespace Inventory.Application.Features.SalesOrders.DTOs
{
    public class SalesOrderDto
    {
        public Guid Id { get; set; }

        public string Customer { get; set; } = null!;

        public decimal Total { get; set; }

        public OrderStatus Status { get; set; }
    }
}
