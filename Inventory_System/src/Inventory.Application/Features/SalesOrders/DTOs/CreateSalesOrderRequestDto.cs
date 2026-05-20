using Inventory.Domain.Entities;
using Inventory.Domain.Enums;

namespace Inventory.Application.Features.SalesOrders.DTOs
{
    public class CreateSalesOrderRequestDto
    {
        public Guid CustomerId { get; set; }
        public decimal Total { get; set; }
        public OrderStatus Status { get; set; }
    }
}
