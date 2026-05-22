using Inventory.Application.Common.Models;
using MediatR;

namespace Inventory.Application.Features.PurchaseOrderItems.Commands.CreatePurchaseOrderItem
{
    public class CreatePurchaseOrderItemCommand : IRequest<Result>
    {
        public Guid PurchaseOrderId { get; set; }

        public Guid ProductId { get; set; }

        public int Quantity { get; set; }

        public decimal Price { get; set; }
    }
}
