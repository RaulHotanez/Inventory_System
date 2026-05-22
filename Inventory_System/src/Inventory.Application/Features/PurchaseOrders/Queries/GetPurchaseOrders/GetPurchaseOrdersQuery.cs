using Inventory.Application.Features.PurchaseOrders.DTOs;
using MediatR;

namespace Inventory.Application.Features.PurchaseOrders.Queries.GetPurchaseOrders
{
    public class GetPurchaseOrdersQuery : IRequest<IEnumerable<PurchaseOrderDto>>
    {
    }
}
