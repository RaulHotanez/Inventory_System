
namespace Inventory.Application.Features.SalesOrderItems.DTOs
{
    public class SalesOrderItemDto
    {
        public Guid Id { get; set; }

        public Guid SalesOrderId { get; set; }

        public Guid ProductId { get; set; }

        public int Quantity { get; set; }

        public decimal Price { get; set; }
    }
}
