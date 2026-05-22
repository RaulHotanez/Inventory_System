using Inventory.Application.Features.PurchaseOrderItems.DTOs;
using MediatR;

namespace Inventory.Application.Features.PurchaseOrderItems.Queries.GetPurchaseOrderItems
{
    public class GetPurchaseOrderItemQuery : IRequest<IEnumerable<PurchaseOrderItemDto>>
    {
    }
}
