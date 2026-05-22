using Inventory.Application.Common.Models;
using Inventory.Domain.Enums;
using MediatR;

namespace Inventory.Application.Features.PurchaseOrders.Commands.CreatePurchaseOrder
{
    public class CreatePurchaseOrderCommand : IRequest<Result>
    {
        public Guid SupplierId { get; set; }

        public decimal Total { get; set; }

        public OrderStatus Status { get; set; }
    }
}
