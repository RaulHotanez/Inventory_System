using Inventory.Application.Features.SalesOrderItems.DTOs;
using MediatR;

namespace Inventory.Application.Features.SalesOrderItems.Queries.GetSalesOrderItems
{
    public class GetSalesOrderItemsQuery : IRequest<IEnumerable<SalesOrderItemDto>>
    {
    }
}
